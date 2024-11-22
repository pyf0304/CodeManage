
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingCaseResCaseDA
 表名:TeachingCaseResCase(01120377)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:43:49
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源(TeachingCaseResLib)
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
 /// 教学案例资源案例(TeachingCaseResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachingCaseResCaseDA : clsCommBase4DA
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
 return clsTeachingCaseResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachingCaseResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingCaseResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachingCaseResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachingCaseResCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeachingCaseResCase)
{
strIdTeachingCaseResCase = strIdTeachingCaseResCase.Replace("'", "''");
if (strIdTeachingCaseResCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TeachingCaseResCase中,检查关键字,长度不正确!(clsTeachingCaseResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeachingCaseResCase中,关键字不能为空 或 null!(clsTeachingCaseResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingCaseResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeachingCaseResCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachingCaseResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable_TeachingCaseResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingCaseResCase.* from TeachingCaseResCase Left Join {1} on {2} where {3} and TeachingCaseResCase.IdTeachingCaseResCase not in (Select top {5} TeachingCaseResCase.IdTeachingCaseResCase from TeachingCaseResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from TeachingCaseResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from TeachingCaseResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingCaseResCase.* from TeachingCaseResCase Left Join {1} on {2} where {3} and TeachingCaseResCase.IdTeachingCaseResCase not in (Select top {5} TeachingCaseResCase.IdTeachingCaseResCase from TeachingCaseResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from TeachingCaseResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from TeachingCaseResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachingCaseResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA:GetObjLst)", objException.Message));
}
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetObjLst)", objException.Message));
}
objTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingCaseResCaseEN);
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
public List<clsTeachingCaseResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachingCaseResCaseEN> arrObjLst = new List<clsTeachingCaseResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetObjLst)", objException.Message));
}
objTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachingCaseResCase(ref clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ objTeachingCaseResCaseEN.IdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachingCaseResCaseEN.IdTeachingCaseResCase = objDT.Rows[0][conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseID = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseName = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseText = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objDT.Rows[0][conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingCaseResCaseEN.IdCaseType = objDT.Rows[0][conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objDT.Rows[0][conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.CourseId = objDT.Rows[0][conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.OwnerId = objDT.Rows[0][conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingCaseResCaseEN.IdStudyLevel = objDT.Rows[0][conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdTeachingPlan = objDT.Rows[0][conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.IdDiscipline = objDT.Rows[0][conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.IdTeachSkill = objDT.Rows[0][conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.CaseLevelId = objDT.Rows[0][conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objTeachingCaseResCaseEN.DocFile = objDT.Rows[0][conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.WordCreateDate = objDT.Rows[0][conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objTeachingCaseResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objTeachingCaseResCaseEN.IdXzCollege = objDT.Rows[0][conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdXzMajor = objDT.Rows[0][conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.CourseChapterId = objDT.Rows[0][conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.RecommendedDegreeId = objDT.Rows[0][conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingCaseResCaseEN.ftpFileType = objDT.Rows[0][conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachingCaseResCaseEN.VideoUrl = objDT.Rows[0][conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachingCaseResCaseEN.VideoPath = objDT.Rows[0][conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachingCaseResCaseEN.ResErrMsg = objDT.Rows[0][conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachingCaseResCaseEN.UpdDate = objDT.Rows[0][conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingCaseResCaseEN.UpdUserId = objDT.Rows[0][conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingCaseResCaseEN.Memo = objDT.Rows[0][conTeachingCaseResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetTeachingCaseResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachingCaseResCaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
{
CheckPrimaryKey(strIdTeachingCaseResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
 objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetObjByIdTeachingCaseResCase)", objException.Message));
}
return objTeachingCaseResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachingCaseResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN()
{
IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(), //教学案例资源案例流水号
TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(), //教学案例资源案例ID
TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(), //教学案例资源案例名称
TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(), //教学案例资源案例主题词
TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(), //案例文本内容
TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(), //视频资源日期
TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(), //视频资源时间
TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(), //案例入库日期
TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(), //教学案例资源类型流水号
CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(), //课程Id
OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(), //专业流水号
CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(), //课程章节ID
ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim() //备注
};
objTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingCaseResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachingCaseResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetObjByDataRowTeachingCaseResCase)", objException.Message));
}
objTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingCaseResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachingCaseResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingCaseResCaseEN objTeachingCaseResCaseEN = new clsTeachingCaseResCaseEN();
try
{
objTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[conTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objTeachingCaseResCaseEN.IdCaseType = objRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objTeachingCaseResCaseEN.CourseId = objRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objTeachingCaseResCaseEN.OwnerId = objRow[conTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objTeachingCaseResCaseEN.IdStudyLevel = objRow[conTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objTeachingCaseResCaseEN.IdTeachingPlan = objRow[conTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objTeachingCaseResCaseEN.IdDiscipline = objRow[conTeachingCaseResCase.IdDiscipline] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objTeachingCaseResCaseEN.BrowseCount = objRow[conTeachingCaseResCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.BrowseCount].ToString().Trim()); //浏览次数
objTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[conTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objTeachingCaseResCaseEN.IdTeachSkill = objRow[conTeachingCaseResCase.IdTeachSkill] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objTeachingCaseResCaseEN.CaseLevelId = objRow[conTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objTeachingCaseResCaseEN.DocFile = objRow[conTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objTeachingCaseResCaseEN.WordCreateDate = objRow[conTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[conTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objTeachingCaseResCaseEN.IdXzCollege = objRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objTeachingCaseResCaseEN.IdXzMajor = objRow[conTeachingCaseResCase.IdXzMajor] == DBNull.Value ? null : objRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objTeachingCaseResCaseEN.CourseChapterId = objRow[conTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objTeachingCaseResCaseEN.ViewCount = objRow[conTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[conTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objTeachingCaseResCaseEN.DownloadNumber = objRow[conTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objTeachingCaseResCaseEN.FileIntegration = objRow[conTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objTeachingCaseResCaseEN.LikeCount = objRow[conTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objTeachingCaseResCaseEN.CollectionCount = objRow[conTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objTeachingCaseResCaseEN.RecommendedDegreeId = objRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objTeachingCaseResCaseEN.ftpFileType = objRow[conTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objTeachingCaseResCaseEN.VideoUrl = objRow[conTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objTeachingCaseResCaseEN.VideoPath = objRow[conTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objTeachingCaseResCaseEN.ResErrMsg = objRow[conTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objTeachingCaseResCaseEN.UpdDate = objRow[conTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objTeachingCaseResCaseEN.UpdUserId = objRow[conTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingCaseResCaseEN.Memo = objRow[conTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachingCaseResCaseDA: GetObjByDataRow)", objException.Message));
}
objTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingCaseResCaseEN;
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
objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingCaseResCaseEN._CurrTabName, conTeachingCaseResCase.IdTeachingCaseResCase, 8, "");
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
objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingCaseResCaseEN._CurrTabName, conTeachingCaseResCase.IdTeachingCaseResCase, 8, strPrefix);
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from TeachingCaseResCase where " + strCondition;
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from TeachingCaseResCase where " + strCondition;
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
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeachingCaseResCase)
{
CheckPrimaryKey(strIdTeachingCaseResCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingCaseResCase", "IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingCaseResCase", strCondition))
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
objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachingCaseResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
 {
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingCaseResCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingCaseResCase");
objRow = objDS.Tables["TeachingCaseResCase"].NewRow();
objRow[conTeachingCaseResCase.IdTeachingCaseResCase] = objTeachingCaseResCaseEN.IdTeachingCaseResCase; //教学案例资源案例流水号
objRow[conTeachingCaseResCase.TeachingCaseResCaseID] = objTeachingCaseResCaseEN.TeachingCaseResCaseID; //教学案例资源案例ID
objRow[conTeachingCaseResCase.TeachingCaseResCaseName] = objTeachingCaseResCaseEN.TeachingCaseResCaseName; //教学案例资源案例名称
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
 }
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseText] = objTeachingCaseResCaseEN.TeachingCaseResCaseText; //案例文本内容
 }
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] = objTeachingCaseResCaseEN.TeachingCaseResCaseDate; //视频资源日期
 }
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] = objTeachingCaseResCaseEN.TeachingCaseResCaseTime; //视频资源时间
 }
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn; //案例入库日期
 }
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  "")
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn; //案例入库时间
 }
objRow[conTeachingCaseResCase.IdCaseType] = objTeachingCaseResCaseEN.IdCaseType; //案例类型流水号
objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType] = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objRow[conTeachingCaseResCase.CourseId] = objTeachingCaseResCaseEN.CourseId; //课程Id
 if (objTeachingCaseResCaseEN.OwnerId !=  "")
 {
objRow[conTeachingCaseResCase.OwnerId] = objTeachingCaseResCaseEN.OwnerId; //拥有者Id
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  "")
 {
objRow[conTeachingCaseResCase.IdStudyLevel] = objTeachingCaseResCaseEN.IdStudyLevel; //id_StudyLevel
 }
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  "")
 {
objRow[conTeachingCaseResCase.IdTeachingPlan] = objTeachingCaseResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objTeachingCaseResCaseEN.IdDiscipline !=  "")
 {
objRow[conTeachingCaseResCase.IdDiscipline] = objTeachingCaseResCaseEN.IdDiscipline; //学科流水号
 }
objRow[conTeachingCaseResCase.BrowseCount] = objTeachingCaseResCaseEN.BrowseCount; //浏览次数
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conTeachingCaseResCase.IdSenateGaugeVersion] = objTeachingCaseResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  "")
 {
objRow[conTeachingCaseResCase.IdTeachSkill] = objTeachingCaseResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objTeachingCaseResCaseEN.CaseLevelId !=  "")
 {
objRow[conTeachingCaseResCase.CaseLevelId] = objTeachingCaseResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objTeachingCaseResCaseEN.DocFile !=  "")
 {
objRow[conTeachingCaseResCase.DocFile] = objTeachingCaseResCaseEN.DocFile; //生成的Word文件名
 }
objRow[conTeachingCaseResCase.IsNeedGeneWord] = objTeachingCaseResCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objTeachingCaseResCaseEN.WordCreateDate !=  "")
 {
objRow[conTeachingCaseResCase.WordCreateDate] = objTeachingCaseResCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conTeachingCaseResCase.IsVisible] = objTeachingCaseResCaseEN.IsVisible; //是否显示
objRow[conTeachingCaseResCase.IsDualVideo] = objTeachingCaseResCaseEN.IsDualVideo; //是否双视频
objRow[conTeachingCaseResCase.IdXzCollege] = objTeachingCaseResCaseEN.IdXzCollege; //学院流水号
 if (objTeachingCaseResCaseEN.IdXzMajor !=  "")
 {
objRow[conTeachingCaseResCase.IdXzMajor] = objTeachingCaseResCaseEN.IdXzMajor; //专业流水号
 }
 if (objTeachingCaseResCaseEN.CourseChapterId !=  "")
 {
objRow[conTeachingCaseResCase.CourseChapterId] = objTeachingCaseResCaseEN.CourseChapterId; //课程章节ID
 }
objRow[conTeachingCaseResCase.ViewCount] = objTeachingCaseResCaseEN.ViewCount; //浏览量
objRow[conTeachingCaseResCase.IsShow] = objTeachingCaseResCaseEN.IsShow; //是否启用
objRow[conTeachingCaseResCase.DownloadNumber] = objTeachingCaseResCaseEN.DownloadNumber; //下载数目
objRow[conTeachingCaseResCase.FileIntegration] = objTeachingCaseResCaseEN.FileIntegration; //文件积分
objRow[conTeachingCaseResCase.LikeCount] = objTeachingCaseResCaseEN.LikeCount; //资源喜欢数量
objRow[conTeachingCaseResCase.CollectionCount] = objTeachingCaseResCaseEN.CollectionCount; //收藏数量
objRow[conTeachingCaseResCase.RecommendedDegreeId] = objTeachingCaseResCaseEN.RecommendedDegreeId; //推荐度Id
 if (objTeachingCaseResCaseEN.ftpFileType !=  "")
 {
objRow[conTeachingCaseResCase.ftpFileType] = objTeachingCaseResCaseEN.ftpFileType; //ftp文件类型
 }
 if (objTeachingCaseResCaseEN.VideoUrl !=  "")
 {
objRow[conTeachingCaseResCase.VideoUrl] = objTeachingCaseResCaseEN.VideoUrl; //视频Url
 }
 if (objTeachingCaseResCaseEN.VideoPath !=  "")
 {
objRow[conTeachingCaseResCase.VideoPath] = objTeachingCaseResCaseEN.VideoPath; //视频目录
 }
 if (objTeachingCaseResCaseEN.ResErrMsg !=  "")
 {
objRow[conTeachingCaseResCase.ResErrMsg] = objTeachingCaseResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objTeachingCaseResCaseEN.UpdDate !=  "")
 {
objRow[conTeachingCaseResCase.UpdDate] = objTeachingCaseResCaseEN.UpdDate; //修改日期
 }
 if (objTeachingCaseResCaseEN.UpdUserId !=  "")
 {
objRow[conTeachingCaseResCase.UpdUserId] = objTeachingCaseResCaseEN.UpdUserId; //修改用户Id
 }
 if (objTeachingCaseResCaseEN.Memo !=  "")
 {
objRow[conTeachingCaseResCase.Memo] = objTeachingCaseResCaseEN.Memo; //备注
 }
objDS.Tables[clsTeachingCaseResCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachingCaseResCaseEN._CurrTabName);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingCaseResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCase);
 var strIdTeachingCaseResCase = objTeachingCaseResCaseEN.IdTeachingCaseResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCase + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseID);
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseID + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseName);
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseName + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme);
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTheme + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseText);
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseText + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDate);
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTime);
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTime + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDateIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTimeIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdCaseType);
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCaseType);
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseId);
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.OwnerId);
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdStudyLevel);
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdDiscipline);
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.BrowseCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.BrowseCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachSkill);
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CaseLevelId);
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DocFile);
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.WordCreateDate);
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzCollege);
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzMajor);
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseChapterId);
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ViewCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsShow);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DownloadNumber);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.DownloadNumber.ToString());
 }
 
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.FileIntegration);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.FileIntegration.ToString());
 }
 
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.LikeCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.LikeCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CollectionCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.CollectionCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ftpFileType);
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoUrl);
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoPath);
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ResErrMsg);
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdDate);
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdUserId);
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.Memo);
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingCaseResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingCaseResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCase);
 var strIdTeachingCaseResCase = objTeachingCaseResCaseEN.IdTeachingCaseResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCase + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseID);
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseID + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseName);
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseName + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme);
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTheme + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseText);
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseText + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDate);
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTime);
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTime + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDateIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTimeIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdCaseType);
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCaseType);
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseId);
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.OwnerId);
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdStudyLevel);
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdDiscipline);
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.BrowseCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.BrowseCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachSkill);
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CaseLevelId);
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DocFile);
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.WordCreateDate);
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzCollege);
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzMajor);
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseChapterId);
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ViewCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsShow);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DownloadNumber);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.DownloadNumber.ToString());
 }
 
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.FileIntegration);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.FileIntegration.ToString());
 }
 
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.LikeCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.LikeCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CollectionCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.CollectionCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ftpFileType);
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoUrl);
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoPath);
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ResErrMsg);
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdDate);
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdUserId);
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.Memo);
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingCaseResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeachingCaseResCaseEN.IdTeachingCaseResCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingCaseResCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCase);
 var strIdTeachingCaseResCase = objTeachingCaseResCaseEN.IdTeachingCaseResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCase + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseID);
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseID + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseName);
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseName + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme);
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTheme + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseText);
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseText + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDate);
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTime);
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTime + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDateIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTimeIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdCaseType);
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCaseType);
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseId);
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.OwnerId);
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdStudyLevel);
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdDiscipline);
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.BrowseCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.BrowseCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachSkill);
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CaseLevelId);
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DocFile);
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.WordCreateDate);
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzCollege);
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzMajor);
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseChapterId);
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ViewCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsShow);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DownloadNumber);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.DownloadNumber.ToString());
 }
 
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.FileIntegration);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.FileIntegration.ToString());
 }
 
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.LikeCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.LikeCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CollectionCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.CollectionCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ftpFileType);
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoUrl);
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoPath);
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ResErrMsg);
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdDate);
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdUserId);
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.Memo);
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingCaseResCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeachingCaseResCaseEN.IdTeachingCaseResCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingCaseResCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCase);
 var strIdTeachingCaseResCase = objTeachingCaseResCaseEN.IdTeachingCaseResCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCase + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseID);
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseID + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseName);
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseName + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTheme);
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTheme + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseText);
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseText + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDate);
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTime);
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTime + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseDateIn);
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseDateIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingCaseResCaseTimeIn + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdCaseType);
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingCaseResCaseType);
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingCaseResCaseType + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseId);
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.OwnerId);
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdStudyLevel);
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachingPlan);
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdDiscipline);
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.BrowseCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.BrowseCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdTeachSkill);
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CaseLevelId);
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DocFile);
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.WordCreateDate);
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsVisible);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzCollege);
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.IdXzMajor);
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CourseChapterId);
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ViewCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.ViewCount.ToString());
 }
 
 arrFieldListForInsert.Add(conTeachingCaseResCase.IsShow);
 arrValueListForInsert.Add("'" + (objTeachingCaseResCaseEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.DownloadNumber);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.DownloadNumber.ToString());
 }
 
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.FileIntegration);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.FileIntegration.ToString());
 }
 
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.LikeCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.LikeCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.CollectionCount);
 arrValueListForInsert.Add(objTeachingCaseResCaseEN.CollectionCount.ToString());
 }
 
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ftpFileType);
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoUrl);
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.VideoPath);
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.ResErrMsg);
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdDate);
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.UpdUserId);
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingCaseResCase.Memo);
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingCaseResCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachingCaseResCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where IdTeachingCaseResCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingCaseResCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdTeachingCaseResCase = oRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim();
if (IsExist(strIdTeachingCaseResCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeachingCaseResCase = {0}", strIdTeachingCaseResCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachingCaseResCaseEN._CurrTabName ].NewRow();
objRow[conTeachingCaseResCase.IdTeachingCaseResCase] = oRow[conTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objRow[conTeachingCaseResCase.TeachingCaseResCaseID] = oRow[conTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objRow[conTeachingCaseResCase.TeachingCaseResCaseName] = oRow[conTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] = oRow[conTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objRow[conTeachingCaseResCase.TeachingCaseResCaseText] = oRow[conTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] = oRow[conTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] = oRow[conTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = oRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = oRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conTeachingCaseResCase.IdCaseType] = oRow[conTeachingCaseResCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType] = oRow[conTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objRow[conTeachingCaseResCase.CourseId] = oRow[conTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objRow[conTeachingCaseResCase.OwnerId] = oRow[conTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conTeachingCaseResCase.IdStudyLevel] = oRow[conTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objRow[conTeachingCaseResCase.IdTeachingPlan] = oRow[conTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conTeachingCaseResCase.IdDiscipline] = oRow[conTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conTeachingCaseResCase.BrowseCount] = oRow[conTeachingCaseResCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conTeachingCaseResCase.IdSenateGaugeVersion] = oRow[conTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conTeachingCaseResCase.IdTeachSkill] = oRow[conTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conTeachingCaseResCase.CaseLevelId] = oRow[conTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conTeachingCaseResCase.DocFile] = oRow[conTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conTeachingCaseResCase.IsNeedGeneWord] = oRow[conTeachingCaseResCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conTeachingCaseResCase.WordCreateDate] = oRow[conTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conTeachingCaseResCase.IsVisible] = oRow[conTeachingCaseResCase.IsVisible].ToString().Trim(); //是否显示
objRow[conTeachingCaseResCase.IsDualVideo] = oRow[conTeachingCaseResCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conTeachingCaseResCase.IdXzCollege] = oRow[conTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conTeachingCaseResCase.IdXzMajor] = oRow[conTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conTeachingCaseResCase.CourseChapterId] = oRow[conTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[conTeachingCaseResCase.ViewCount] = oRow[conTeachingCaseResCase.ViewCount].ToString().Trim(); //浏览量
objRow[conTeachingCaseResCase.IsShow] = oRow[conTeachingCaseResCase.IsShow].ToString().Trim(); //是否启用
objRow[conTeachingCaseResCase.DownloadNumber] = oRow[conTeachingCaseResCase.DownloadNumber].ToString().Trim(); //下载数目
objRow[conTeachingCaseResCase.FileIntegration] = oRow[conTeachingCaseResCase.FileIntegration].ToString().Trim(); //文件积分
objRow[conTeachingCaseResCase.LikeCount] = oRow[conTeachingCaseResCase.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[conTeachingCaseResCase.CollectionCount] = oRow[conTeachingCaseResCase.CollectionCount].ToString().Trim(); //收藏数量
objRow[conTeachingCaseResCase.RecommendedDegreeId] = oRow[conTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conTeachingCaseResCase.ftpFileType] = oRow[conTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conTeachingCaseResCase.VideoUrl] = oRow[conTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conTeachingCaseResCase.VideoPath] = oRow[conTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objRow[conTeachingCaseResCase.ResErrMsg] = oRow[conTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conTeachingCaseResCase.UpdDate] = oRow[conTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachingCaseResCase.UpdUserId] = oRow[conTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTeachingCaseResCase.Memo] = oRow[conTeachingCaseResCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachingCaseResCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachingCaseResCaseEN._CurrTabName);
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingCaseResCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from TeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ objTeachingCaseResCaseEN.IdTeachingCaseResCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachingCaseResCaseEN._CurrTabName);
if (objDS.Tables[clsTeachingCaseResCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeachingCaseResCase = " + "'"+ objTeachingCaseResCaseEN.IdTeachingCaseResCase+"'");
return false;
}
objRow = objDS.Tables[clsTeachingCaseResCaseEN._CurrTabName].Rows[0];
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCase))
 {
objRow[conTeachingCaseResCase.IdTeachingCaseResCase] = objTeachingCaseResCaseEN.IdTeachingCaseResCase; //教学案例资源案例流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseID] = objTeachingCaseResCaseEN.TeachingCaseResCaseID; //教学案例资源案例ID
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseName] = objTeachingCaseResCaseEN.TeachingCaseResCaseName; //教学案例资源案例名称
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTheme] = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme; //教学案例资源案例主题词
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseText] = objTeachingCaseResCaseEN.TeachingCaseResCaseText; //案例文本内容
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseDate] = objTeachingCaseResCaseEN.TeachingCaseResCaseDate; //视频资源日期
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTime] = objTeachingCaseResCaseEN.TeachingCaseResCaseTime; //视频资源时间
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseDateIn] = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn; //案例入库日期
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn))
 {
objRow[conTeachingCaseResCase.TeachingCaseResCaseTimeIn] = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn; //案例入库时间
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdCaseType))
 {
objRow[conTeachingCaseResCase.IdCaseType] = objTeachingCaseResCaseEN.IdCaseType; //案例类型流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType))
 {
objRow[conTeachingCaseResCase.IdTeachingCaseResCaseType] = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType; //教学案例资源类型流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseId))
 {
objRow[conTeachingCaseResCase.CourseId] = objTeachingCaseResCaseEN.CourseId; //课程Id
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.OwnerId))
 {
objRow[conTeachingCaseResCase.OwnerId] = objTeachingCaseResCaseEN.OwnerId; //拥有者Id
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdStudyLevel))
 {
objRow[conTeachingCaseResCase.IdStudyLevel] = objTeachingCaseResCaseEN.IdStudyLevel; //id_StudyLevel
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingPlan))
 {
objRow[conTeachingCaseResCase.IdTeachingPlan] = objTeachingCaseResCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdDiscipline))
 {
objRow[conTeachingCaseResCase.IdDiscipline] = objTeachingCaseResCaseEN.IdDiscipline; //学科流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.BrowseCount))
 {
objRow[conTeachingCaseResCase.BrowseCount] = objTeachingCaseResCaseEN.BrowseCount; //浏览次数
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion))
 {
objRow[conTeachingCaseResCase.IdSenateGaugeVersion] = objTeachingCaseResCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachSkill))
 {
objRow[conTeachingCaseResCase.IdTeachSkill] = objTeachingCaseResCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CaseLevelId))
 {
objRow[conTeachingCaseResCase.CaseLevelId] = objTeachingCaseResCaseEN.CaseLevelId; //课例等级Id
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DocFile))
 {
objRow[conTeachingCaseResCase.DocFile] = objTeachingCaseResCaseEN.DocFile; //生成的Word文件名
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord))
 {
objRow[conTeachingCaseResCase.IsNeedGeneWord] = objTeachingCaseResCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.WordCreateDate))
 {
objRow[conTeachingCaseResCase.WordCreateDate] = objTeachingCaseResCaseEN.WordCreateDate; //Word生成日期
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsVisible))
 {
objRow[conTeachingCaseResCase.IsVisible] = objTeachingCaseResCaseEN.IsVisible; //是否显示
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsDualVideo))
 {
objRow[conTeachingCaseResCase.IsDualVideo] = objTeachingCaseResCaseEN.IsDualVideo; //是否双视频
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzCollege))
 {
objRow[conTeachingCaseResCase.IdXzCollege] = objTeachingCaseResCaseEN.IdXzCollege; //学院流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzMajor))
 {
objRow[conTeachingCaseResCase.IdXzMajor] = objTeachingCaseResCaseEN.IdXzMajor; //专业流水号
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseChapterId))
 {
objRow[conTeachingCaseResCase.CourseChapterId] = objTeachingCaseResCaseEN.CourseChapterId; //课程章节ID
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ViewCount))
 {
objRow[conTeachingCaseResCase.ViewCount] = objTeachingCaseResCaseEN.ViewCount; //浏览量
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsShow))
 {
objRow[conTeachingCaseResCase.IsShow] = objTeachingCaseResCaseEN.IsShow; //是否启用
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DownloadNumber))
 {
objRow[conTeachingCaseResCase.DownloadNumber] = objTeachingCaseResCaseEN.DownloadNumber; //下载数目
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.FileIntegration))
 {
objRow[conTeachingCaseResCase.FileIntegration] = objTeachingCaseResCaseEN.FileIntegration; //文件积分
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.LikeCount))
 {
objRow[conTeachingCaseResCase.LikeCount] = objTeachingCaseResCaseEN.LikeCount; //资源喜欢数量
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CollectionCount))
 {
objRow[conTeachingCaseResCase.CollectionCount] = objTeachingCaseResCaseEN.CollectionCount; //收藏数量
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId))
 {
objRow[conTeachingCaseResCase.RecommendedDegreeId] = objTeachingCaseResCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ftpFileType))
 {
objRow[conTeachingCaseResCase.ftpFileType] = objTeachingCaseResCaseEN.ftpFileType; //ftp文件类型
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoUrl))
 {
objRow[conTeachingCaseResCase.VideoUrl] = objTeachingCaseResCaseEN.VideoUrl; //视频Url
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoPath))
 {
objRow[conTeachingCaseResCase.VideoPath] = objTeachingCaseResCaseEN.VideoPath; //视频目录
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ResErrMsg))
 {
objRow[conTeachingCaseResCase.ResErrMsg] = objTeachingCaseResCaseEN.ResErrMsg; //资源错误信息
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdDate))
 {
objRow[conTeachingCaseResCase.UpdDate] = objTeachingCaseResCaseEN.UpdDate; //修改日期
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdUserId))
 {
objRow[conTeachingCaseResCase.UpdUserId] = objTeachingCaseResCaseEN.UpdUserId; //修改用户Id
 }
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.Memo))
 {
objRow[conTeachingCaseResCase.Memo] = objTeachingCaseResCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachingCaseResCaseEN._CurrTabName);
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingCaseResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachingCaseResCase Set ");
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID); //教学案例资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseID); //教学案例资源案例ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName); //教学案例资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseName); //教学案例资源案例名称
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTheme, conTeachingCaseResCase.TeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseText, conTeachingCaseResCase.TeachingCaseResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseText); //案例文本内容
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseDate, conTeachingCaseResCase.TeachingCaseResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseDate); //视频资源日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTime, conTeachingCaseResCase.TeachingCaseResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTime); //视频资源时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseDateIn, conTeachingCaseResCase.TeachingCaseResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseDateIn); //案例入库日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTimeIn, conTeachingCaseResCase.TeachingCaseResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdCaseType))
 {
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conTeachingCaseResCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType))
 {
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingCaseResCaseType, conTeachingCaseResCase.IdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseId))
 {
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conTeachingCaseResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CourseId); //课程Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.OwnerId))
 {
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingCaseResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdStudyLevel))
 {
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conTeachingCaseResCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingPlan))
 {
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conTeachingCaseResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdDiscipline))
 {
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conTeachingCaseResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.BrowseCount))
 {
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.BrowseCount, conTeachingCaseResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion))
 {
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conTeachingCaseResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachSkill))
 {
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conTeachingCaseResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CaseLevelId))
 {
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conTeachingCaseResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DocFile))
 {
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conTeachingCaseResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsNeedGeneWord == true?"1":"0", conTeachingCaseResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.WordCreateDate))
 {
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conTeachingCaseResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsVisible == true?"1":"0", conTeachingCaseResCase.IsVisible); //是否显示
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsDualVideo == true?"1":"0", conTeachingCaseResCase.IsDualVideo); //是否双视频
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzCollege))
 {
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeachingCaseResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzMajor))
 {
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conTeachingCaseResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseChapterId))
 {
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conTeachingCaseResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ViewCount))
 {
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.ViewCount, conTeachingCaseResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ViewCount); //浏览量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsShow == true?"1":"0", conTeachingCaseResCase.IsShow); //是否启用
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DownloadNumber))
 {
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.DownloadNumber, conTeachingCaseResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.FileIntegration))
 {
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.FileIntegration, conTeachingCaseResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.FileIntegration); //文件积分
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.LikeCount))
 {
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.LikeCount, conTeachingCaseResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CollectionCount))
 {
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.CollectionCount, conTeachingCaseResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId))
 {
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ftpFileType))
 {
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conTeachingCaseResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoUrl))
 {
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conTeachingCaseResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.VideoUrl); //视频Url
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoPath))
 {
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conTeachingCaseResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.VideoPath); //视频目录
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ResErrMsg))
 {
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conTeachingCaseResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdDate))
 {
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingCaseResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.UpdDate); //修改日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdUserId))
 {
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingCaseResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.Memo))
 {
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingCaseResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingCaseResCase = '{0}'", objTeachingCaseResCaseEN.IdTeachingCaseResCase); 
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCondition)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingCaseResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingCaseResCase Set ");
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseID = '{0}',", strTeachingCaseResCaseID); //教学案例资源案例ID
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseID = null,"); //教学案例资源案例ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseName = '{0}',", strTeachingCaseResCaseName); //教学案例资源案例名称
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseName = null,"); //教学案例资源案例名称
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTheme = '{0}',", strTeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTheme = null,"); //教学案例资源案例主题词
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseText = '{0}',", strTeachingCaseResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseDate = '{0}',", strTeachingCaseResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTime = '{0}',", strTeachingCaseResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseDateIn = '{0}',", strTeachingCaseResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTimeIn = '{0}',", strTeachingCaseResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdCaseType))
 {
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType))
 {
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingCaseResCaseType = '{0}',", strIdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingCaseResCaseType = null,"); //教学案例资源类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseId))
 {
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.OwnerId))
 {
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdStudyLevel))
 {
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingPlan))
 {
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdDiscipline))
 {
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachingCaseResCaseEN.BrowseCount); //浏览次数
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion))
 {
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachSkill))
 {
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CaseLevelId))
 {
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DocFile))
 {
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objTeachingCaseResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.WordCreateDate))
 {
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachingCaseResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objTeachingCaseResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzCollege))
 {
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzMajor))
 {
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseChapterId))
 {
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objTeachingCaseResCaseEN.ViewCount); //浏览量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objTeachingCaseResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objTeachingCaseResCaseEN.DownloadNumber); //下载数目
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objTeachingCaseResCaseEN.FileIntegration); //文件积分
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objTeachingCaseResCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objTeachingCaseResCaseEN.CollectionCount); //收藏数量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId))
 {
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ftpFileType))
 {
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoUrl))
 {
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoPath))
 {
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ResErrMsg))
 {
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdDate))
 {
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdUserId))
 {
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.Memo))
 {
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingCaseResCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingCaseResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingCaseResCase Set ");
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseID = '{0}',", strTeachingCaseResCaseID); //教学案例资源案例ID
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseID = null,"); //教学案例资源案例ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseName = '{0}',", strTeachingCaseResCaseName); //教学案例资源案例名称
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseName = null,"); //教学案例资源案例名称
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTheme = '{0}',", strTeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTheme = null,"); //教学案例资源案例主题词
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseText = '{0}',", strTeachingCaseResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseText = null,"); //案例文本内容
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseDate = '{0}',", strTeachingCaseResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseDate = null,"); //视频资源日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTime = '{0}',", strTeachingCaseResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTime = null,"); //视频资源时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseDateIn = '{0}',", strTeachingCaseResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingCaseResCaseTimeIn = '{0}',", strTeachingCaseResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" TeachingCaseResCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdCaseType))
 {
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType))
 {
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingCaseResCaseType = '{0}',", strIdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingCaseResCaseType = null,"); //教学案例资源类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseId))
 {
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.OwnerId))
 {
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdStudyLevel))
 {
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //id_StudyLevel
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingPlan))
 {
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdDiscipline))
 {
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objTeachingCaseResCaseEN.BrowseCount); //浏览次数
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion))
 {
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachSkill))
 {
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CaseLevelId))
 {
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DocFile))
 {
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objTeachingCaseResCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.WordCreateDate))
 {
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objTeachingCaseResCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objTeachingCaseResCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzCollege))
 {
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzMajor))
 {
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseChapterId))
 {
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ViewCount))
 {
 sbSQL.AppendFormat(" ViewCount = {0},", objTeachingCaseResCaseEN.ViewCount); //浏览量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objTeachingCaseResCaseEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DownloadNumber))
 {
 sbSQL.AppendFormat(" DownloadNumber = {0},", objTeachingCaseResCaseEN.DownloadNumber); //下载数目
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.FileIntegration))
 {
 sbSQL.AppendFormat(" FileIntegration = {0},", objTeachingCaseResCaseEN.FileIntegration); //文件积分
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.LikeCount))
 {
 sbSQL.AppendFormat(" LikeCount = {0},", objTeachingCaseResCaseEN.LikeCount); //资源喜欢数量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CollectionCount))
 {
 sbSQL.AppendFormat(" CollectionCount = {0},", objTeachingCaseResCaseEN.CollectionCount); //收藏数量
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId))
 {
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ftpFileType))
 {
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoUrl))
 {
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoPath))
 {
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ResErrMsg))
 {
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdDate))
 {
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdUserId))
 {
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.Memo))
 {
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingCaseResCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingCaseResCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingCaseResCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingCaseResCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingCaseResCase Set ");
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseID))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseID !=  null)
 {
 var strTeachingCaseResCaseID = objTeachingCaseResCaseEN.TeachingCaseResCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID); //教学案例资源案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseID); //教学案例资源案例ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseName))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseName !=  null)
 {
 var strTeachingCaseResCaseName = objTeachingCaseResCaseEN.TeachingCaseResCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName); //教学案例资源案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseName); //教学案例资源案例名称
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTheme))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTheme !=  null)
 {
 var strTeachingCaseResCaseTheme = objTeachingCaseResCaseEN.TeachingCaseResCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTheme, conTeachingCaseResCase.TeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTheme); //教学案例资源案例主题词
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseText))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseText !=  null)
 {
 var strTeachingCaseResCaseText = objTeachingCaseResCaseEN.TeachingCaseResCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseText, conTeachingCaseResCase.TeachingCaseResCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseText); //案例文本内容
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDate))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDate !=  null)
 {
 var strTeachingCaseResCaseDate = objTeachingCaseResCaseEN.TeachingCaseResCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseDate, conTeachingCaseResCase.TeachingCaseResCaseDate); //视频资源日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseDate); //视频资源日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTime))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTime !=  null)
 {
 var strTeachingCaseResCaseTime = objTeachingCaseResCaseEN.TeachingCaseResCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTime, conTeachingCaseResCase.TeachingCaseResCaseTime); //视频资源时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTime); //视频资源时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseDateIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn !=  null)
 {
 var strTeachingCaseResCaseDateIn = objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseDateIn, conTeachingCaseResCase.TeachingCaseResCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseDateIn); //案例入库日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.TeachingCaseResCaseTimeIn))
 {
 if (objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn !=  null)
 {
 var strTeachingCaseResCaseTimeIn = objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingCaseResCaseTimeIn, conTeachingCaseResCase.TeachingCaseResCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.TeachingCaseResCaseTimeIn); //案例入库时间
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdCaseType))
 {
 if (objTeachingCaseResCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objTeachingCaseResCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conTeachingCaseResCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingCaseResCaseType))
 {
 if (objTeachingCaseResCaseEN.IdTeachingCaseResCaseType !=  null)
 {
 var strIdTeachingCaseResCaseType = objTeachingCaseResCaseEN.IdTeachingCaseResCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingCaseResCaseType, conTeachingCaseResCase.IdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachingCaseResCaseType); //教学案例资源类型流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseId))
 {
 if (objTeachingCaseResCaseEN.CourseId  ==  "")
 {
 objTeachingCaseResCaseEN.CourseId = null;
 }
 if (objTeachingCaseResCaseEN.CourseId !=  null)
 {
 var strCourseId = objTeachingCaseResCaseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conTeachingCaseResCase.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CourseId); //课程Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.OwnerId))
 {
 if (objTeachingCaseResCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingCaseResCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingCaseResCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdStudyLevel))
 {
 if (objTeachingCaseResCaseEN.IdStudyLevel  ==  "")
 {
 objTeachingCaseResCaseEN.IdStudyLevel = null;
 }
 if (objTeachingCaseResCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objTeachingCaseResCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conTeachingCaseResCase.IdStudyLevel); //id_StudyLevel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdStudyLevel); //id_StudyLevel
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachingPlan))
 {
 if (objTeachingCaseResCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objTeachingCaseResCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conTeachingCaseResCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdDiscipline))
 {
 if (objTeachingCaseResCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objTeachingCaseResCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conTeachingCaseResCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.BrowseCount))
 {
 if (objTeachingCaseResCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.BrowseCount, conTeachingCaseResCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.BrowseCount); //浏览次数
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdSenateGaugeVersion))
 {
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objTeachingCaseResCaseEN.IdSenateGaugeVersion = null;
 }
 if (objTeachingCaseResCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objTeachingCaseResCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conTeachingCaseResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdTeachSkill))
 {
 if (objTeachingCaseResCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objTeachingCaseResCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conTeachingCaseResCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CaseLevelId))
 {
 if (objTeachingCaseResCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objTeachingCaseResCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conTeachingCaseResCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DocFile))
 {
 if (objTeachingCaseResCaseEN.DocFile !=  null)
 {
 var strDocFile = objTeachingCaseResCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conTeachingCaseResCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsNeedGeneWord == true?"1":"0", conTeachingCaseResCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.WordCreateDate))
 {
 if (objTeachingCaseResCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objTeachingCaseResCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conTeachingCaseResCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsVisible == true?"1":"0", conTeachingCaseResCase.IsVisible); //是否显示
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsDualVideo == true?"1":"0", conTeachingCaseResCase.IsDualVideo); //是否双视频
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzCollege))
 {
 if (objTeachingCaseResCaseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeachingCaseResCaseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeachingCaseResCase.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IdXzMajor))
 {
 if (objTeachingCaseResCaseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeachingCaseResCaseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conTeachingCaseResCase.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.IdXzMajor); //专业流水号
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CourseChapterId))
 {
 if (objTeachingCaseResCaseEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objTeachingCaseResCaseEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, conTeachingCaseResCase.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CourseChapterId); //课程章节ID
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ViewCount))
 {
 if (objTeachingCaseResCaseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.ViewCount, conTeachingCaseResCase.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ViewCount); //浏览量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingCaseResCaseEN.IsShow == true?"1":"0", conTeachingCaseResCase.IsShow); //是否启用
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.DownloadNumber))
 {
 if (objTeachingCaseResCaseEN.DownloadNumber !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.DownloadNumber, conTeachingCaseResCase.DownloadNumber); //下载数目
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.DownloadNumber); //下载数目
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.FileIntegration))
 {
 if (objTeachingCaseResCaseEN.FileIntegration !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.FileIntegration, conTeachingCaseResCase.FileIntegration); //文件积分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.FileIntegration); //文件积分
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.LikeCount))
 {
 if (objTeachingCaseResCaseEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.LikeCount, conTeachingCaseResCase.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.LikeCount); //资源喜欢数量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.CollectionCount))
 {
 if (objTeachingCaseResCaseEN.CollectionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingCaseResCaseEN.CollectionCount, conTeachingCaseResCase.CollectionCount); //收藏数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.CollectionCount); //收藏数量
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.RecommendedDegreeId))
 {
 if (objTeachingCaseResCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objTeachingCaseResCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ftpFileType))
 {
 if (objTeachingCaseResCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objTeachingCaseResCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conTeachingCaseResCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoUrl))
 {
 if (objTeachingCaseResCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objTeachingCaseResCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conTeachingCaseResCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.VideoUrl); //视频Url
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.VideoPath))
 {
 if (objTeachingCaseResCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objTeachingCaseResCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conTeachingCaseResCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.VideoPath); //视频目录
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.ResErrMsg))
 {
 if (objTeachingCaseResCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objTeachingCaseResCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conTeachingCaseResCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdDate))
 {
 if (objTeachingCaseResCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingCaseResCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingCaseResCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.UpdDate); //修改日期
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.UpdUserId))
 {
 if (objTeachingCaseResCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingCaseResCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingCaseResCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingCaseResCaseEN.IsUpdated(conTeachingCaseResCase.Memo))
 {
 if (objTeachingCaseResCaseEN.Memo !=  null)
 {
 var strMemo = objTeachingCaseResCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingCaseResCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingCaseResCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeachingCaseResCase = '{0}'", objTeachingCaseResCaseEN.IdTeachingCaseResCase); 
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
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdTeachingCaseResCase) 
{
CheckPrimaryKey(strIdTeachingCaseResCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdTeachingCaseResCase,
};
 objSQL.ExecSP("TeachingCaseResCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdTeachingCaseResCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdTeachingCaseResCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
//删除TeachingCaseResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachingCaseResCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
//删除TeachingCaseResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingCaseResCase where IdTeachingCaseResCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdTeachingCaseResCase) 
{
CheckPrimaryKey(strIdTeachingCaseResCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
//删除TeachingCaseResCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachingCaseResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: DelTeachingCaseResCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingCaseResCase where " + strCondition ;
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
public bool DelTeachingCaseResCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachingCaseResCaseDA: DelTeachingCaseResCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingCaseResCase where " + strCondition ;
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
 /// <param name = "objTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objTeachingCaseResCaseENT">目标对象</param>
public void CopyTo(clsTeachingCaseResCaseEN objTeachingCaseResCaseENS, clsTeachingCaseResCaseEN objTeachingCaseResCaseENT)
{
objTeachingCaseResCaseENT.IdTeachingCaseResCase = objTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objTeachingCaseResCaseENT.TeachingCaseResCaseID = objTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objTeachingCaseResCaseENT.TeachingCaseResCaseName = objTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objTeachingCaseResCaseENT.TeachingCaseResCaseText = objTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objTeachingCaseResCaseENT.TeachingCaseResCaseDate = objTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTime = objTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objTeachingCaseResCaseENT.IdCaseType = objTeachingCaseResCaseENS.IdCaseType; //案例类型流水号
objTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objTeachingCaseResCaseENT.CourseId = objTeachingCaseResCaseENS.CourseId; //课程Id
objTeachingCaseResCaseENT.OwnerId = objTeachingCaseResCaseENS.OwnerId; //拥有者Id
objTeachingCaseResCaseENT.IdStudyLevel = objTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objTeachingCaseResCaseENT.IdTeachingPlan = objTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objTeachingCaseResCaseENT.IdDiscipline = objTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objTeachingCaseResCaseENT.BrowseCount = objTeachingCaseResCaseENS.BrowseCount; //浏览次数
objTeachingCaseResCaseENT.IdSenateGaugeVersion = objTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objTeachingCaseResCaseENT.IdTeachSkill = objTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objTeachingCaseResCaseENT.CaseLevelId = objTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objTeachingCaseResCaseENT.DocFile = objTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objTeachingCaseResCaseENT.IsNeedGeneWord = objTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objTeachingCaseResCaseENT.WordCreateDate = objTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objTeachingCaseResCaseENT.IsVisible = objTeachingCaseResCaseENS.IsVisible; //是否显示
objTeachingCaseResCaseENT.IsDualVideo = objTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objTeachingCaseResCaseENT.IdXzCollege = objTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objTeachingCaseResCaseENT.IdXzMajor = objTeachingCaseResCaseENS.IdXzMajor; //专业流水号
objTeachingCaseResCaseENT.CourseChapterId = objTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objTeachingCaseResCaseENT.ViewCount = objTeachingCaseResCaseENS.ViewCount; //浏览量
objTeachingCaseResCaseENT.IsShow = objTeachingCaseResCaseENS.IsShow; //是否启用
objTeachingCaseResCaseENT.DownloadNumber = objTeachingCaseResCaseENS.DownloadNumber; //下载数目
objTeachingCaseResCaseENT.FileIntegration = objTeachingCaseResCaseENS.FileIntegration; //文件积分
objTeachingCaseResCaseENT.LikeCount = objTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objTeachingCaseResCaseENT.CollectionCount = objTeachingCaseResCaseENS.CollectionCount; //收藏数量
objTeachingCaseResCaseENT.RecommendedDegreeId = objTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objTeachingCaseResCaseENT.ftpFileType = objTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objTeachingCaseResCaseENT.VideoUrl = objTeachingCaseResCaseENS.VideoUrl; //视频Url
objTeachingCaseResCaseENT.VideoPath = objTeachingCaseResCaseENS.VideoPath; //视频目录
objTeachingCaseResCaseENT.ResErrMsg = objTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objTeachingCaseResCaseENT.UpdDate = objTeachingCaseResCaseENS.UpdDate; //修改日期
objTeachingCaseResCaseENT.UpdUserId = objTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objTeachingCaseResCaseENT.Memo = objTeachingCaseResCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.TeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.TeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.IdCaseType, conTeachingCaseResCase.IdCaseType);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.IdTeachingCaseResCaseType, conTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.CourseId, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.IdXzCollege, conTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckFieldNotNull(objTeachingCaseResCaseEN.RecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingCaseResCase, 8, conTeachingCaseResCase.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseName, 100, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTheme, 200, conTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseText, 8000, conTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdCaseType, 4, conTeachingCaseResCase.IdCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingCaseResCaseType, 4, conTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.OwnerId, 20, conTeachingCaseResCase.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingPlan, 8, conTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdDiscipline, 4, conTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachSkill, 8, conTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.DocFile, 200, conTeachingCaseResCase.DocFile);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.WordCreateDate, 14, conTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzCollege, 4, conTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzMajor, 8, conTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.RecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ftpFileType, 30, conTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoUrl, 1000, conTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoPath, 1000, conTeachingCaseResCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ResErrMsg, 30, conTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdDate, 20, conTeachingCaseResCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdUserId, 20, conTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.Memo, 1000, conTeachingCaseResCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
 objTeachingCaseResCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseName, 100, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTheme, 200, conTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseText, 8000, conTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdCaseType, 4, conTeachingCaseResCase.IdCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingCaseResCaseType, 4, conTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.OwnerId, 20, conTeachingCaseResCase.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingPlan, 8, conTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdDiscipline, 4, conTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachSkill, 8, conTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.DocFile, 200, conTeachingCaseResCase.DocFile);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.WordCreateDate, 14, conTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzCollege, 4, conTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzMajor, 8, conTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.RecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ftpFileType, 30, conTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoUrl, 1000, conTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoPath, 1000, conTeachingCaseResCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ResErrMsg, 30, conTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdDate, 20, conTeachingCaseResCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdUserId, 20, conTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.Memo, 1000, conTeachingCaseResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
 objTeachingCaseResCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingCaseResCase, 8, conTeachingCaseResCase.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseID, 8, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseName, 100, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTheme, 200, conTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseText, 8000, conTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDate, 8, conTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTime, 6, conTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, 8, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, 6, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdCaseType, 4, conTeachingCaseResCase.IdCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingCaseResCaseType, 4, conTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.OwnerId, 20, conTeachingCaseResCase.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachingPlan, 8, conTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdDiscipline, 4, conTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdTeachSkill, 8, conTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CaseLevelId, 2, conTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.DocFile, 200, conTeachingCaseResCase.DocFile);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.WordCreateDate, 14, conTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzCollege, 4, conTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.IdXzMajor, 8, conTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.CourseChapterId, 8, conTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.RecommendedDegreeId, 2, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ftpFileType, 30, conTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoUrl, 1000, conTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.VideoPath, 1000, conTeachingCaseResCase.VideoPath);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.ResErrMsg, 30, conTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdDate, 20, conTeachingCaseResCase.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.UpdUserId, 20, conTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingCaseResCaseEN.Memo, 1000, conTeachingCaseResCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdTeachingCaseResCase, conTeachingCaseResCase.IdTeachingCaseResCase);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseID, conTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseName, conTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseTheme, conTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseText, conTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseDate, conTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseTime, conTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, conTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, conTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdCaseType, conTeachingCaseResCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdTeachingCaseResCaseType, conTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.CourseId, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.OwnerId, conTeachingCaseResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdStudyLevel, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdTeachingPlan, conTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdDiscipline, conTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdSenateGaugeVersion, conTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdTeachSkill, conTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.CaseLevelId, conTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.DocFile, conTeachingCaseResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.WordCreateDate, conTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdXzCollege, conTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.IdXzMajor, conTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.CourseChapterId, conTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.RecommendedDegreeId, conTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.ftpFileType, conTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.VideoUrl, conTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.VideoPath, conTeachingCaseResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.ResErrMsg, conTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.UpdDate, conTeachingCaseResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.UpdUserId, conTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTeachingCaseResCaseEN.Memo, conTeachingCaseResCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.CourseId, 8, conTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdStudyLevel, 4, conTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, conTeachingCaseResCase.IdSenateGaugeVersion);
 objTeachingCaseResCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeachingCaseResCase(教学案例资源案例),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeachingCaseResCaseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeachingCaseResCaseEN objTeachingCaseResCaseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeachingCaseResCaseID = '{0}'", objTeachingCaseResCaseEN.TeachingCaseResCaseID);
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingCaseResCaseEN._CurrTabName);
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingCaseResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
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
 objSQL = clsTeachingCaseResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}