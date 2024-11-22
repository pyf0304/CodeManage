
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClsRmTeachingCaseDA
 表名:ClsRmTeachingCase(01120381)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:16
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// 课堂教学案例(ClsRmTeachingCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsClsRmTeachingCaseDA : clsCommBase4DA
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
 return clsClsRmTeachingCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsClsRmTeachingCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClsRmTeachingCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsClsRmTeachingCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsClsRmTeachingCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdClsRmTeachingCase)
{
strIdClsRmTeachingCase = strIdClsRmTeachingCase.Replace("'", "''");
if (strIdClsRmTeachingCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ClsRmTeachingCase中,检查关键字,长度不正确!(clsClsRmTeachingCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ClsRmTeachingCase中,关键字不能为空 或 null!(clsClsRmTeachingCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsClsRmTeachingCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ClsRmTeachingCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable_ClsRmTeachingCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClsRmTeachingCase.* from ClsRmTeachingCase Left Join {1} on {2} where {3} and ClsRmTeachingCase.IdClsRmTeachingCase not in (Select top {5} ClsRmTeachingCase.IdClsRmTeachingCase from ClsRmTeachingCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from ClsRmTeachingCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from ClsRmTeachingCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClsRmTeachingCase.* from ClsRmTeachingCase Left Join {1} on {2} where {3} and ClsRmTeachingCase.IdClsRmTeachingCase not in (Select top {5} ClsRmTeachingCase.IdClsRmTeachingCase from ClsRmTeachingCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from ClsRmTeachingCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from ClsRmTeachingCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsClsRmTeachingCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA:GetObjLst)", objException.Message));
}
List<clsClsRmTeachingCaseEN> arrObjLst = new List<clsClsRmTeachingCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN();
try
{
objClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objClsRmTeachingCaseEN.IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号
objClsRmTeachingCaseEN.IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objClsRmTeachingCaseEN.IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objClsRmTeachingCaseEN.IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objClsRmTeachingCaseEN.IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objClsRmTeachingCaseEN.BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数
objClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objClsRmTeachingCaseEN.IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objClsRmTeachingCaseEN.CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objClsRmTeachingCaseEN.DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objClsRmTeachingCaseEN.WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objClsRmTeachingCaseEN.OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objClsRmTeachingCaseEN.UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objClsRmTeachingCaseEN.UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objClsRmTeachingCaseEN.RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objClsRmTeachingCaseEN.ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
objClsRmTeachingCaseEN.VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url
objClsRmTeachingCaseEN.VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录
objClsRmTeachingCaseEN.ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息
objClsRmTeachingCaseEN.UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期
objClsRmTeachingCaseEN.UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id
objClsRmTeachingCaseEN.Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetObjLst)", objException.Message));
}
objClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClsRmTeachingCaseEN);
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
public List<clsClsRmTeachingCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsClsRmTeachingCaseEN> arrObjLst = new List<clsClsRmTeachingCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN();
try
{
objClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objClsRmTeachingCaseEN.IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号
objClsRmTeachingCaseEN.IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objClsRmTeachingCaseEN.IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objClsRmTeachingCaseEN.IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objClsRmTeachingCaseEN.IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objClsRmTeachingCaseEN.BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数
objClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objClsRmTeachingCaseEN.IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objClsRmTeachingCaseEN.CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objClsRmTeachingCaseEN.DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objClsRmTeachingCaseEN.WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objClsRmTeachingCaseEN.OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objClsRmTeachingCaseEN.UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objClsRmTeachingCaseEN.UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objClsRmTeachingCaseEN.RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objClsRmTeachingCaseEN.ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
objClsRmTeachingCaseEN.VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url
objClsRmTeachingCaseEN.VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录
objClsRmTeachingCaseEN.ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息
objClsRmTeachingCaseEN.UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期
objClsRmTeachingCaseEN.UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id
objClsRmTeachingCaseEN.Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetObjLst)", objException.Message));
}
objClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetClsRmTeachingCase(ref clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ objClsRmTeachingCaseEN.IdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objClsRmTeachingCaseEN.IdClsRmTeachingCase = objDT.Rows[0][conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objDT.Rows[0][conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objDT.Rows[0][conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objClsRmTeachingCaseEN.IdStudyLevel = objDT.Rows[0][conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdTeachingPlan = objDT.Rows[0][conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.IdCaseType = objDT.Rows[0][conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdDiscipline = objDT.Rows[0][conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdSchoolPs = objDT.Rows[0][conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdDisciplinePs = objDT.Rows[0][conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdGradeBase = objDT.Rows[0][conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdTeachSkill = objDT.Rows[0][conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.CaseLevelId = objDT.Rows[0][conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objClsRmTeachingCaseEN.DocFile = objDT.Rows[0][conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objClsRmTeachingCaseEN.WordCreateDate = objDT.Rows[0][conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objClsRmTeachingCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objClsRmTeachingCaseEN.OwnerId = objDT.Rows[0][conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objClsRmTeachingCaseEN.UserKindId = objDT.Rows[0][conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objClsRmTeachingCaseEN.UserTypeId = objDT.Rows[0][conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objClsRmTeachingCaseEN.RecommendedDegreeId = objDT.Rows[0][conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objClsRmTeachingCaseEN.ftpFileType = objDT.Rows[0][conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objClsRmTeachingCaseEN.VideoUrl = objDT.Rows[0][conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objClsRmTeachingCaseEN.VideoPath = objDT.Rows[0][conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objClsRmTeachingCaseEN.ResErrMsg = objDT.Rows[0][conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objClsRmTeachingCaseEN.UpdDate = objDT.Rows[0][conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTeachingCaseEN.UpdUserId = objDT.Rows[0][conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTeachingCaseEN.Memo = objDT.Rows[0][conClsRmTeachingCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetClsRmTeachingCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public clsClsRmTeachingCaseEN GetObjByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
{
CheckPrimaryKey(strIdClsRmTeachingCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN();
try
{
 objClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objClsRmTeachingCaseEN.IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objClsRmTeachingCaseEN.IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objClsRmTeachingCaseEN.CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objClsRmTeachingCaseEN.DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objClsRmTeachingCaseEN.WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objClsRmTeachingCaseEN.OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objClsRmTeachingCaseEN.UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objClsRmTeachingCaseEN.UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objClsRmTeachingCaseEN.RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objClsRmTeachingCaseEN.ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objClsRmTeachingCaseEN.VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objClsRmTeachingCaseEN.VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objClsRmTeachingCaseEN.ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objClsRmTeachingCaseEN.UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTeachingCaseEN.UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objClsRmTeachingCaseEN.Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetObjByIdClsRmTeachingCase)", objException.Message));
}
return objClsRmTeachingCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsClsRmTeachingCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN()
{
IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(), //课堂教学案例流水号
ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(), //课堂教学案例ID
ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(), //课堂教学案例名称
ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(), //课堂教学案例主题词
IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(), //课堂案例类型流水号
ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(), //案例文本内容
ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(), //课堂教学日期
ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(), //课堂教学时间
ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(), //案例入库日期
ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(), //学科流水号
IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(), //学校流水号
IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(), //学科流水号
IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(), //年级流水号
BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(), //拥有者Id
UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim() //备注
};
objClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTeachingCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsClsRmTeachingCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN();
try
{
objClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objClsRmTeachingCaseEN.IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号
objClsRmTeachingCaseEN.IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objClsRmTeachingCaseEN.IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objClsRmTeachingCaseEN.IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objClsRmTeachingCaseEN.IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objClsRmTeachingCaseEN.BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数
objClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objClsRmTeachingCaseEN.IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objClsRmTeachingCaseEN.CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objClsRmTeachingCaseEN.DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objClsRmTeachingCaseEN.WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objClsRmTeachingCaseEN.OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objClsRmTeachingCaseEN.UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objClsRmTeachingCaseEN.UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objClsRmTeachingCaseEN.RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objClsRmTeachingCaseEN.ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
objClsRmTeachingCaseEN.VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url
objClsRmTeachingCaseEN.VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录
objClsRmTeachingCaseEN.ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息
objClsRmTeachingCaseEN.UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期
objClsRmTeachingCaseEN.UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id
objClsRmTeachingCaseEN.Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetObjByDataRowClsRmTeachingCase)", objException.Message));
}
objClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTeachingCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsClsRmTeachingCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClsRmTeachingCaseEN objClsRmTeachingCaseEN = new clsClsRmTeachingCaseEN();
try
{
objClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objClsRmTeachingCaseEN.IdStudyLevel = objRow[conClsRmTeachingCase.IdStudyLevel] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号
objClsRmTeachingCaseEN.IdTeachingPlan = objRow[conClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objClsRmTeachingCaseEN.IdCaseType = objRow[conClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objClsRmTeachingCaseEN.IdDiscipline = objRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdSchoolPs = objRow[conClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objClsRmTeachingCaseEN.IdDisciplinePs = objRow[conClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objClsRmTeachingCaseEN.IdGradeBase = objRow[conClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objClsRmTeachingCaseEN.BrowseCount = objRow[conClsRmTeachingCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conClsRmTeachingCase.BrowseCount].ToString().Trim()); //浏览次数
objClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[conClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objClsRmTeachingCaseEN.IdTeachSkill = objRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objClsRmTeachingCaseEN.CaseLevelId = objRow[conClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objClsRmTeachingCaseEN.DocFile = objRow[conClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objClsRmTeachingCaseEN.WordCreateDate = objRow[conClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[conClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objClsRmTeachingCaseEN.OwnerId = objRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objClsRmTeachingCaseEN.UserKindId = objRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objClsRmTeachingCaseEN.UserTypeId = objRow[conClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objClsRmTeachingCaseEN.RecommendedDegreeId = objRow[conClsRmTeachingCase.RecommendedDegreeId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objClsRmTeachingCaseEN.ftpFileType = objRow[conClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
objClsRmTeachingCaseEN.VideoUrl = objRow[conClsRmTeachingCase.VideoUrl] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url
objClsRmTeachingCaseEN.VideoPath = objRow[conClsRmTeachingCase.VideoPath] == DBNull.Value ? null : objRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录
objClsRmTeachingCaseEN.ResErrMsg = objRow[conClsRmTeachingCase.ResErrMsg] == DBNull.Value ? null : objRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息
objClsRmTeachingCaseEN.UpdDate = objRow[conClsRmTeachingCase.UpdDate] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期
objClsRmTeachingCaseEN.UpdUserId = objRow[conClsRmTeachingCase.UpdUserId] == DBNull.Value ? null : objRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id
objClsRmTeachingCaseEN.Memo = objRow[conClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsClsRmTeachingCaseDA: GetObjByDataRow)", objException.Message));
}
objClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClsRmTeachingCaseEN;
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
objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClsRmTeachingCaseEN._CurrTabName, conClsRmTeachingCase.IdClsRmTeachingCase, 8, "");
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
objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClsRmTeachingCaseEN._CurrTabName, conClsRmTeachingCase.IdClsRmTeachingCase, 8, strPrefix);
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from ClsRmTeachingCase where " + strCondition;
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from ClsRmTeachingCase where " + strCondition;
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
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdClsRmTeachingCase)
{
CheckPrimaryKey(strIdClsRmTeachingCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClsRmTeachingCase", "IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClsRmTeachingCase", strCondition))
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
objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ClsRmTeachingCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
 {
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTeachingCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClsRmTeachingCase");
objRow = objDS.Tables["ClsRmTeachingCase"].NewRow();
objRow[conClsRmTeachingCase.IdClsRmTeachingCase] = objClsRmTeachingCaseEN.IdClsRmTeachingCase; //课堂教学案例流水号
objRow[conClsRmTeachingCase.ClsRmTeachingCaseID] = objClsRmTeachingCaseEN.ClsRmTeachingCaseID; //课堂教学案例ID
objRow[conClsRmTeachingCase.ClsRmTeachingCaseName] = objClsRmTeachingCaseEN.ClsRmTeachingCaseName; //课堂教学案例名称
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme; //课堂教学案例主题词
 }
objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType] = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType; //课堂案例类型流水号
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] = objClsRmTeachingCaseEN.ClsRmTeachingCaseText; //案例文本内容
 }
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate; //课堂教学日期
 }
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime; //课堂教学时间
 }
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn; //案例入库日期
 }
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  "")
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn; //案例入库时间
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  "")
 {
objRow[conClsRmTeachingCase.IdStudyLevel] = objClsRmTeachingCaseEN.IdStudyLevel; //学段流水号
 }
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  "")
 {
objRow[conClsRmTeachingCase.IdTeachingPlan] = objClsRmTeachingCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  "")
 {
objRow[conClsRmTeachingCase.IdCaseType] = objClsRmTeachingCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conClsRmTeachingCase.IdDiscipline] = objClsRmTeachingCaseEN.IdDiscipline; //学科流水号
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  "")
 {
objRow[conClsRmTeachingCase.IdSchoolPs] = objClsRmTeachingCaseEN.IdSchoolPs; //学校流水号
 }
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  "")
 {
objRow[conClsRmTeachingCase.IdDisciplinePs] = objClsRmTeachingCaseEN.IdDisciplinePs; //学科流水号
 }
 if (objClsRmTeachingCaseEN.IdGradeBase !=  "")
 {
objRow[conClsRmTeachingCase.IdGradeBase] = objClsRmTeachingCaseEN.IdGradeBase; //年级流水号
 }
objRow[conClsRmTeachingCase.BrowseCount] = objClsRmTeachingCaseEN.BrowseCount; //浏览次数
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conClsRmTeachingCase.IdSenateGaugeVersion] = objClsRmTeachingCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conClsRmTeachingCase.IdTeachSkill] = objClsRmTeachingCaseEN.IdTeachSkill; //教学技能流水号
 if (objClsRmTeachingCaseEN.CaseLevelId !=  "")
 {
objRow[conClsRmTeachingCase.CaseLevelId] = objClsRmTeachingCaseEN.CaseLevelId; //课例等级Id
 }
 if (objClsRmTeachingCaseEN.DocFile !=  "")
 {
objRow[conClsRmTeachingCase.DocFile] = objClsRmTeachingCaseEN.DocFile; //生成的Word文件名
 }
objRow[conClsRmTeachingCase.IsNeedGeneWord] = objClsRmTeachingCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objClsRmTeachingCaseEN.WordCreateDate !=  "")
 {
objRow[conClsRmTeachingCase.WordCreateDate] = objClsRmTeachingCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conClsRmTeachingCase.IsVisible] = objClsRmTeachingCaseEN.IsVisible; //是否显示
objRow[conClsRmTeachingCase.OwnerId] = objClsRmTeachingCaseEN.OwnerId; //拥有者Id
objRow[conClsRmTeachingCase.UserKindId] = objClsRmTeachingCaseEN.UserKindId; //用户类别Id
 if (objClsRmTeachingCaseEN.UserTypeId !=  "")
 {
objRow[conClsRmTeachingCase.UserTypeId] = objClsRmTeachingCaseEN.UserTypeId; //用户类型Id
 }
objRow[conClsRmTeachingCase.IsDualVideo] = objClsRmTeachingCaseEN.IsDualVideo; //是否双视频
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  "")
 {
objRow[conClsRmTeachingCase.RecommendedDegreeId] = objClsRmTeachingCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objClsRmTeachingCaseEN.ftpFileType !=  "")
 {
objRow[conClsRmTeachingCase.ftpFileType] = objClsRmTeachingCaseEN.ftpFileType; //ftp文件类型
 }
 if (objClsRmTeachingCaseEN.VideoUrl !=  "")
 {
objRow[conClsRmTeachingCase.VideoUrl] = objClsRmTeachingCaseEN.VideoUrl; //视频Url
 }
 if (objClsRmTeachingCaseEN.VideoPath !=  "")
 {
objRow[conClsRmTeachingCase.VideoPath] = objClsRmTeachingCaseEN.VideoPath; //视频目录
 }
 if (objClsRmTeachingCaseEN.ResErrMsg !=  "")
 {
objRow[conClsRmTeachingCase.ResErrMsg] = objClsRmTeachingCaseEN.ResErrMsg; //资源错误信息
 }
 if (objClsRmTeachingCaseEN.UpdDate !=  "")
 {
objRow[conClsRmTeachingCase.UpdDate] = objClsRmTeachingCaseEN.UpdDate; //修改日期
 }
 if (objClsRmTeachingCaseEN.UpdUserId !=  "")
 {
objRow[conClsRmTeachingCase.UpdUserId] = objClsRmTeachingCaseEN.UpdUserId; //修改用户Id
 }
 if (objClsRmTeachingCaseEN.Memo !=  "")
 {
objRow[conClsRmTeachingCase.Memo] = objClsRmTeachingCaseEN.Memo; //备注
 }
objDS.Tables[clsClsRmTeachingCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsClsRmTeachingCaseEN._CurrTabName);
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
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTeachingCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCase);
 var strIdClsRmTeachingCase = objClsRmTeachingCaseEN.IdClsRmTeachingCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCase + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseID);
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseID + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseName);
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseName + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTheme + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCaseType);
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseText);
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseText + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate);
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime);
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTime + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDateIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTimeIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdStudyLevel);
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachingPlan);
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdCaseType);
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDiscipline);
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSchoolPs);
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDisciplinePs);
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdGradeBase);
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.BrowseCount);
 arrValueListForInsert.Add(objClsRmTeachingCaseEN.BrowseCount.ToString());
 }
 
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachSkill);
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.CaseLevelId);
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.DocFile);
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.WordCreateDate);
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsVisible);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.OwnerId);
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserKindId);
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserTypeId);
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ftpFileType);
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoUrl);
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoPath);
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ResErrMsg);
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdDate);
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdUserId);
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.Memo);
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmTeachingCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTeachingCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCase);
 var strIdClsRmTeachingCase = objClsRmTeachingCaseEN.IdClsRmTeachingCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCase + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseID);
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseID + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseName);
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseName + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTheme + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCaseType);
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseText);
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseText + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate);
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime);
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTime + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDateIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTimeIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdStudyLevel);
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachingPlan);
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdCaseType);
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDiscipline);
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSchoolPs);
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDisciplinePs);
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdGradeBase);
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.BrowseCount);
 arrValueListForInsert.Add(objClsRmTeachingCaseEN.BrowseCount.ToString());
 }
 
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachSkill);
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.CaseLevelId);
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.DocFile);
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.WordCreateDate);
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsVisible);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.OwnerId);
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserKindId);
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserTypeId);
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ftpFileType);
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoUrl);
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoPath);
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ResErrMsg);
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdDate);
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdUserId);
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.Memo);
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmTeachingCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objClsRmTeachingCaseEN.IdClsRmTeachingCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTeachingCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCase);
 var strIdClsRmTeachingCase = objClsRmTeachingCaseEN.IdClsRmTeachingCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCase + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseID);
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseID + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseName);
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseName + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTheme + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCaseType);
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseText);
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseText + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate);
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime);
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTime + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDateIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTimeIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdStudyLevel);
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachingPlan);
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdCaseType);
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDiscipline);
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSchoolPs);
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDisciplinePs);
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdGradeBase);
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.BrowseCount);
 arrValueListForInsert.Add(objClsRmTeachingCaseEN.BrowseCount.ToString());
 }
 
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachSkill);
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.CaseLevelId);
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.DocFile);
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.WordCreateDate);
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsVisible);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.OwnerId);
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserKindId);
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserTypeId);
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ftpFileType);
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoUrl);
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoPath);
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ResErrMsg);
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdDate);
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdUserId);
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.Memo);
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmTeachingCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objClsRmTeachingCaseEN.IdClsRmTeachingCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClsRmTeachingCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCase);
 var strIdClsRmTeachingCase = objClsRmTeachingCaseEN.IdClsRmTeachingCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCase + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseID);
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseID + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseName);
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseName + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTheme);
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTheme + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdClsRmTeachingCaseType);
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClsRmTeachingCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseText);
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseText + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDate);
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTime);
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTime + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseDateIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsRmTeachingCaseTimeIn + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdStudyLevel);
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachingPlan);
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdCaseType);
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDiscipline);
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSchoolPs);
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdDisciplinePs);
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdGradeBase);
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.BrowseCount);
 arrValueListForInsert.Add(objClsRmTeachingCaseEN.BrowseCount.ToString());
 }
 
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.IdTeachSkill);
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.CaseLevelId);
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.DocFile);
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.WordCreateDate);
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsVisible);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.OwnerId);
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserKindId);
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserKindId + "'");
 }
 
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UserTypeId);
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conClsRmTeachingCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objClsRmTeachingCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ftpFileType);
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoUrl);
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.VideoPath);
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.ResErrMsg);
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdDate);
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.UpdUserId);
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClsRmTeachingCase.Memo);
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClsRmTeachingCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewClsRmTeachingCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where IdClsRmTeachingCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClsRmTeachingCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdClsRmTeachingCase = oRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim();
if (IsExist(strIdClsRmTeachingCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdClsRmTeachingCase = {0}", strIdClsRmTeachingCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsClsRmTeachingCaseEN._CurrTabName ].NewRow();
objRow[conClsRmTeachingCase.IdClsRmTeachingCase] = oRow[conClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objRow[conClsRmTeachingCase.ClsRmTeachingCaseID] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objRow[conClsRmTeachingCase.ClsRmTeachingCaseName] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType] = oRow[conClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = oRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conClsRmTeachingCase.IdStudyLevel] = oRow[conClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conClsRmTeachingCase.IdTeachingPlan] = oRow[conClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conClsRmTeachingCase.IdCaseType] = oRow[conClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conClsRmTeachingCase.IdDiscipline] = oRow[conClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conClsRmTeachingCase.IdSchoolPs] = oRow[conClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objRow[conClsRmTeachingCase.IdDisciplinePs] = oRow[conClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objRow[conClsRmTeachingCase.IdGradeBase] = oRow[conClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conClsRmTeachingCase.BrowseCount] = oRow[conClsRmTeachingCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conClsRmTeachingCase.IdSenateGaugeVersion] = oRow[conClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conClsRmTeachingCase.IdTeachSkill] = oRow[conClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conClsRmTeachingCase.CaseLevelId] = oRow[conClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conClsRmTeachingCase.DocFile] = oRow[conClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conClsRmTeachingCase.IsNeedGeneWord] = oRow[conClsRmTeachingCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conClsRmTeachingCase.WordCreateDate] = oRow[conClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conClsRmTeachingCase.IsVisible] = oRow[conClsRmTeachingCase.IsVisible].ToString().Trim(); //是否显示
objRow[conClsRmTeachingCase.OwnerId] = oRow[conClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conClsRmTeachingCase.UserKindId] = oRow[conClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objRow[conClsRmTeachingCase.UserTypeId] = oRow[conClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conClsRmTeachingCase.IsDualVideo] = oRow[conClsRmTeachingCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conClsRmTeachingCase.RecommendedDegreeId] = oRow[conClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conClsRmTeachingCase.ftpFileType] = oRow[conClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conClsRmTeachingCase.VideoUrl] = oRow[conClsRmTeachingCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conClsRmTeachingCase.VideoPath] = oRow[conClsRmTeachingCase.VideoPath].ToString().Trim(); //视频目录
objRow[conClsRmTeachingCase.ResErrMsg] = oRow[conClsRmTeachingCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conClsRmTeachingCase.UpdDate] = oRow[conClsRmTeachingCase.UpdDate].ToString().Trim(); //修改日期
objRow[conClsRmTeachingCase.UpdUserId] = oRow[conClsRmTeachingCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conClsRmTeachingCase.Memo] = oRow[conClsRmTeachingCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsClsRmTeachingCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsClsRmTeachingCaseEN._CurrTabName);
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
 /// <param name = "objClsRmTeachingCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTeachingCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from ClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ objClsRmTeachingCaseEN.IdClsRmTeachingCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsClsRmTeachingCaseEN._CurrTabName);
if (objDS.Tables[clsClsRmTeachingCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdClsRmTeachingCase = " + "'"+ objClsRmTeachingCaseEN.IdClsRmTeachingCase+"'");
return false;
}
objRow = objDS.Tables[clsClsRmTeachingCaseEN._CurrTabName].Rows[0];
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCase))
 {
objRow[conClsRmTeachingCase.IdClsRmTeachingCase] = objClsRmTeachingCaseEN.IdClsRmTeachingCase; //课堂教学案例流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseID] = objClsRmTeachingCaseEN.ClsRmTeachingCaseID; //课堂教学案例ID
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseName] = objClsRmTeachingCaseEN.ClsRmTeachingCaseName; //课堂教学案例名称
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTheme] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme; //课堂教学案例主题词
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCaseType))
 {
objRow[conClsRmTeachingCase.IdClsRmTeachingCaseType] = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType; //课堂案例类型流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseText] = objClsRmTeachingCaseEN.ClsRmTeachingCaseText; //案例文本内容
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDate] = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate; //课堂教学日期
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTime] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime; //课堂教学时间
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseDateIn] = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn; //案例入库日期
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn))
 {
objRow[conClsRmTeachingCase.ClsRmTeachingCaseTimeIn] = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn; //案例入库时间
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdStudyLevel))
 {
objRow[conClsRmTeachingCase.IdStudyLevel] = objClsRmTeachingCaseEN.IdStudyLevel; //学段流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachingPlan))
 {
objRow[conClsRmTeachingCase.IdTeachingPlan] = objClsRmTeachingCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdCaseType))
 {
objRow[conClsRmTeachingCase.IdCaseType] = objClsRmTeachingCaseEN.IdCaseType; //案例类型流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDiscipline))
 {
objRow[conClsRmTeachingCase.IdDiscipline] = objClsRmTeachingCaseEN.IdDiscipline; //学科流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSchoolPs))
 {
objRow[conClsRmTeachingCase.IdSchoolPs] = objClsRmTeachingCaseEN.IdSchoolPs; //学校流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDisciplinePs))
 {
objRow[conClsRmTeachingCase.IdDisciplinePs] = objClsRmTeachingCaseEN.IdDisciplinePs; //学科流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdGradeBase))
 {
objRow[conClsRmTeachingCase.IdGradeBase] = objClsRmTeachingCaseEN.IdGradeBase; //年级流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.BrowseCount))
 {
objRow[conClsRmTeachingCase.BrowseCount] = objClsRmTeachingCaseEN.BrowseCount; //浏览次数
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSenateGaugeVersion))
 {
objRow[conClsRmTeachingCase.IdSenateGaugeVersion] = objClsRmTeachingCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachSkill))
 {
objRow[conClsRmTeachingCase.IdTeachSkill] = objClsRmTeachingCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.CaseLevelId))
 {
objRow[conClsRmTeachingCase.CaseLevelId] = objClsRmTeachingCaseEN.CaseLevelId; //课例等级Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.DocFile))
 {
objRow[conClsRmTeachingCase.DocFile] = objClsRmTeachingCaseEN.DocFile; //生成的Word文件名
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord))
 {
objRow[conClsRmTeachingCase.IsNeedGeneWord] = objClsRmTeachingCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.WordCreateDate))
 {
objRow[conClsRmTeachingCase.WordCreateDate] = objClsRmTeachingCaseEN.WordCreateDate; //Word生成日期
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsVisible))
 {
objRow[conClsRmTeachingCase.IsVisible] = objClsRmTeachingCaseEN.IsVisible; //是否显示
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.OwnerId))
 {
objRow[conClsRmTeachingCase.OwnerId] = objClsRmTeachingCaseEN.OwnerId; //拥有者Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserKindId))
 {
objRow[conClsRmTeachingCase.UserKindId] = objClsRmTeachingCaseEN.UserKindId; //用户类别Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserTypeId))
 {
objRow[conClsRmTeachingCase.UserTypeId] = objClsRmTeachingCaseEN.UserTypeId; //用户类型Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsDualVideo))
 {
objRow[conClsRmTeachingCase.IsDualVideo] = objClsRmTeachingCaseEN.IsDualVideo; //是否双视频
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId))
 {
objRow[conClsRmTeachingCase.RecommendedDegreeId] = objClsRmTeachingCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ftpFileType))
 {
objRow[conClsRmTeachingCase.ftpFileType] = objClsRmTeachingCaseEN.ftpFileType; //ftp文件类型
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoUrl))
 {
objRow[conClsRmTeachingCase.VideoUrl] = objClsRmTeachingCaseEN.VideoUrl; //视频Url
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoPath))
 {
objRow[conClsRmTeachingCase.VideoPath] = objClsRmTeachingCaseEN.VideoPath; //视频目录
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ResErrMsg))
 {
objRow[conClsRmTeachingCase.ResErrMsg] = objClsRmTeachingCaseEN.ResErrMsg; //资源错误信息
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdDate))
 {
objRow[conClsRmTeachingCase.UpdDate] = objClsRmTeachingCaseEN.UpdDate; //修改日期
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdUserId))
 {
objRow[conClsRmTeachingCase.UpdUserId] = objClsRmTeachingCaseEN.UpdUserId; //修改用户Id
 }
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.Memo))
 {
objRow[conClsRmTeachingCase.Memo] = objClsRmTeachingCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsClsRmTeachingCaseEN._CurrTabName);
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
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTeachingCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ClsRmTeachingCase Set ");
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseID, conClsRmTeachingCase.ClsRmTeachingCaseID); //课堂教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseID); //课堂教学案例ID
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseName, conClsRmTeachingCase.ClsRmTeachingCaseName); //课堂教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseName); //课堂教学案例名称
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTheme, conClsRmTeachingCase.ClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCaseType))
 {
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClsRmTeachingCaseType, conClsRmTeachingCase.IdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseText, conClsRmTeachingCase.ClsRmTeachingCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseText); //案例文本内容
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseDate, conClsRmTeachingCase.ClsRmTeachingCaseDate); //课堂教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseDate); //课堂教学日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTime, conClsRmTeachingCase.ClsRmTeachingCaseTime); //课堂教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTime); //课堂教学时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseDateIn, conClsRmTeachingCase.ClsRmTeachingCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseDateIn); //案例入库日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTimeIn, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTimeIn); //案例入库时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdStudyLevel))
 {
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conClsRmTeachingCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachingPlan))
 {
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conClsRmTeachingCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdCaseType))
 {
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conClsRmTeachingCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDiscipline))
 {
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conClsRmTeachingCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSchoolPs))
 {
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchoolPs, conClsRmTeachingCase.IdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdSchoolPs); //学校流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDisciplinePs))
 {
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDisciplinePs, conClsRmTeachingCase.IdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdDisciplinePs); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdGradeBase))
 {
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conClsRmTeachingCase.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdGradeBase); //年级流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.BrowseCount))
 {
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objClsRmTeachingCaseEN.BrowseCount, conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSenateGaugeVersion))
 {
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conClsRmTeachingCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachSkill))
 {
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conClsRmTeachingCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.CaseLevelId))
 {
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conClsRmTeachingCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.DocFile))
 {
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conClsRmTeachingCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsNeedGeneWord == true?"1":"0", conClsRmTeachingCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.WordCreateDate))
 {
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conClsRmTeachingCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsVisible == true?"1":"0", conClsRmTeachingCase.IsVisible); //是否显示
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.OwnerId))
 {
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conClsRmTeachingCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.OwnerId); //拥有者Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserKindId))
 {
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conClsRmTeachingCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UserKindId); //用户类别Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserTypeId))
 {
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conClsRmTeachingCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsDualVideo == true?"1":"0", conClsRmTeachingCase.IsDualVideo); //是否双视频
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId))
 {
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conClsRmTeachingCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ftpFileType))
 {
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conClsRmTeachingCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoUrl))
 {
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conClsRmTeachingCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.VideoUrl); //视频Url
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoPath))
 {
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conClsRmTeachingCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.VideoPath); //视频目录
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ResErrMsg))
 {
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conClsRmTeachingCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdDate))
 {
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClsRmTeachingCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UpdDate); //修改日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdUserId))
 {
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conClsRmTeachingCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.Memo))
 {
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClsRmTeachingCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdClsRmTeachingCase = '{0}'", objClsRmTeachingCaseEN.IdClsRmTeachingCase); 
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
 /// <param name = "objClsRmTeachingCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strCondition)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTeachingCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmTeachingCase Set ");
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseID = '{0}',", strClsRmTeachingCaseID); //课堂教学案例ID
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseID = null,"); //课堂教学案例ID
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseName = '{0}',", strClsRmTeachingCaseName); //课堂教学案例名称
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseName = null,"); //课堂教学案例名称
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTheme = '{0}',", strClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTheme = null,"); //课堂教学案例主题词
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCaseType))
 {
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClsRmTeachingCaseType = '{0}',", strIdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdClsRmTeachingCaseType = null,"); //课堂案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseText = '{0}',", strClsRmTeachingCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseText = null,"); //案例文本内容
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseDate = '{0}',", strClsRmTeachingCaseDate); //课堂教学日期
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseDate = null,"); //课堂教学日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTime = '{0}',", strClsRmTeachingCaseTime); //课堂教学时间
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTime = null,"); //课堂教学时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseDateIn = '{0}',", strClsRmTeachingCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTimeIn = '{0}',", strClsRmTeachingCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdStudyLevel))
 {
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachingPlan))
 {
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdCaseType))
 {
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDiscipline))
 {
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSchoolPs))
 {
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchoolPs = '{0}',", strIdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchoolPs = null,"); //学校流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDisciplinePs))
 {
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDisciplinePs = '{0}',", strIdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDisciplinePs = null,"); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdGradeBase))
 {
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.BrowseCount))
 {
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objClsRmTeachingCaseEN.BrowseCount, conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSenateGaugeVersion))
 {
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachSkill))
 {
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.CaseLevelId))
 {
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.DocFile))
 {
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objClsRmTeachingCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.WordCreateDate))
 {
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objClsRmTeachingCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.OwnerId))
 {
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserKindId))
 {
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserTypeId))
 {
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objClsRmTeachingCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId))
 {
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ftpFileType))
 {
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoUrl))
 {
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoPath))
 {
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ResErrMsg))
 {
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdDate))
 {
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdUserId))
 {
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.Memo))
 {
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClsRmTeachingCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTeachingCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmTeachingCase Set ");
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseID = '{0}',", strClsRmTeachingCaseID); //课堂教学案例ID
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseID = null,"); //课堂教学案例ID
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseName = '{0}',", strClsRmTeachingCaseName); //课堂教学案例名称
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseName = null,"); //课堂教学案例名称
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTheme = '{0}',", strClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTheme = null,"); //课堂教学案例主题词
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCaseType))
 {
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClsRmTeachingCaseType = '{0}',", strIdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdClsRmTeachingCaseType = null,"); //课堂案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseText = '{0}',", strClsRmTeachingCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseText = null,"); //案例文本内容
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseDate = '{0}',", strClsRmTeachingCaseDate); //课堂教学日期
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseDate = null,"); //课堂教学日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTime = '{0}',", strClsRmTeachingCaseTime); //课堂教学时间
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTime = null,"); //课堂教学时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseDateIn = '{0}',", strClsRmTeachingCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsRmTeachingCaseTimeIn = '{0}',", strClsRmTeachingCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" ClsRmTeachingCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdStudyLevel))
 {
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachingPlan))
 {
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdCaseType))
 {
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDiscipline))
 {
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSchoolPs))
 {
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchoolPs = '{0}',", strIdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchoolPs = null,"); //学校流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDisciplinePs))
 {
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDisciplinePs = '{0}',", strIdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDisciplinePs = null,"); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdGradeBase))
 {
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.BrowseCount))
 {
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objClsRmTeachingCaseEN.BrowseCount, conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSenateGaugeVersion))
 {
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachSkill))
 {
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.CaseLevelId))
 {
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.DocFile))
 {
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objClsRmTeachingCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.WordCreateDate))
 {
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objClsRmTeachingCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.OwnerId))
 {
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserKindId))
 {
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserKindId = '{0}',", strUserKindId); //用户类别Id
 }
 else
 {
 sbSQL.Append(" UserKindId = null,"); //用户类别Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserTypeId))
 {
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objClsRmTeachingCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId))
 {
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ftpFileType))
 {
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoUrl))
 {
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoPath))
 {
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ResErrMsg))
 {
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdDate))
 {
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdUserId))
 {
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.Memo))
 {
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClsRmTeachingCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClsRmTeachingCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClsRmTeachingCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClsRmTeachingCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClsRmTeachingCase Set ");
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseID))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseID !=  null)
 {
 var strClsRmTeachingCaseID = objClsRmTeachingCaseEN.ClsRmTeachingCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseID, conClsRmTeachingCase.ClsRmTeachingCaseID); //课堂教学案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseID); //课堂教学案例ID
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseName))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseName !=  null)
 {
 var strClsRmTeachingCaseName = objClsRmTeachingCaseEN.ClsRmTeachingCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseName, conClsRmTeachingCase.ClsRmTeachingCaseName); //课堂教学案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseName); //课堂教学案例名称
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTheme))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme !=  null)
 {
 var strClsRmTeachingCaseTheme = objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTheme, conClsRmTeachingCase.ClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTheme); //课堂教学案例主题词
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdClsRmTeachingCaseType))
 {
 if (objClsRmTeachingCaseEN.IdClsRmTeachingCaseType !=  null)
 {
 var strIdClsRmTeachingCaseType = objClsRmTeachingCaseEN.IdClsRmTeachingCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClsRmTeachingCaseType, conClsRmTeachingCase.IdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdClsRmTeachingCaseType); //课堂案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseText))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseText !=  null)
 {
 var strClsRmTeachingCaseText = objClsRmTeachingCaseEN.ClsRmTeachingCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseText, conClsRmTeachingCase.ClsRmTeachingCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseText); //案例文本内容
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDate))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDate !=  null)
 {
 var strClsRmTeachingCaseDate = objClsRmTeachingCaseEN.ClsRmTeachingCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseDate, conClsRmTeachingCase.ClsRmTeachingCaseDate); //课堂教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseDate); //课堂教学日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTime))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTime !=  null)
 {
 var strClsRmTeachingCaseTime = objClsRmTeachingCaseEN.ClsRmTeachingCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTime, conClsRmTeachingCase.ClsRmTeachingCaseTime); //课堂教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTime); //课堂教学时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseDateIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn !=  null)
 {
 var strClsRmTeachingCaseDateIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseDateIn, conClsRmTeachingCase.ClsRmTeachingCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseDateIn); //案例入库日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ClsRmTeachingCaseTimeIn))
 {
 if (objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn !=  null)
 {
 var strClsRmTeachingCaseTimeIn = objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsRmTeachingCaseTimeIn, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ClsRmTeachingCaseTimeIn); //案例入库时间
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdStudyLevel))
 {
 if (objClsRmTeachingCaseEN.IdStudyLevel  ==  "")
 {
 objClsRmTeachingCaseEN.IdStudyLevel = null;
 }
 if (objClsRmTeachingCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objClsRmTeachingCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conClsRmTeachingCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachingPlan))
 {
 if (objClsRmTeachingCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objClsRmTeachingCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conClsRmTeachingCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdCaseType))
 {
 if (objClsRmTeachingCaseEN.IdCaseType  ==  "")
 {
 objClsRmTeachingCaseEN.IdCaseType = null;
 }
 if (objClsRmTeachingCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objClsRmTeachingCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conClsRmTeachingCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDiscipline))
 {
 if (objClsRmTeachingCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objClsRmTeachingCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conClsRmTeachingCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSchoolPs))
 {
 if (objClsRmTeachingCaseEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objClsRmTeachingCaseEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchoolPs, conClsRmTeachingCase.IdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdSchoolPs); //学校流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdDisciplinePs))
 {
 if (objClsRmTeachingCaseEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objClsRmTeachingCaseEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDisciplinePs, conClsRmTeachingCase.IdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdDisciplinePs); //学科流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdGradeBase))
 {
 if (objClsRmTeachingCaseEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objClsRmTeachingCaseEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conClsRmTeachingCase.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdGradeBase); //年级流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.BrowseCount))
 {
 if (objClsRmTeachingCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objClsRmTeachingCaseEN.BrowseCount, conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.BrowseCount); //浏览次数
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdSenateGaugeVersion))
 {
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion  ==  "")
 {
 objClsRmTeachingCaseEN.IdSenateGaugeVersion = null;
 }
 if (objClsRmTeachingCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objClsRmTeachingCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conClsRmTeachingCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IdTeachSkill))
 {
 if (objClsRmTeachingCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objClsRmTeachingCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conClsRmTeachingCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.CaseLevelId))
 {
 if (objClsRmTeachingCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objClsRmTeachingCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conClsRmTeachingCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.DocFile))
 {
 if (objClsRmTeachingCaseEN.DocFile !=  null)
 {
 var strDocFile = objClsRmTeachingCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conClsRmTeachingCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsNeedGeneWord == true?"1":"0", conClsRmTeachingCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.WordCreateDate))
 {
 if (objClsRmTeachingCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objClsRmTeachingCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conClsRmTeachingCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsVisible == true?"1":"0", conClsRmTeachingCase.IsVisible); //是否显示
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.OwnerId))
 {
 if (objClsRmTeachingCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objClsRmTeachingCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conClsRmTeachingCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.OwnerId); //拥有者Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserKindId))
 {
 if (objClsRmTeachingCaseEN.UserKindId  ==  "")
 {
 objClsRmTeachingCaseEN.UserKindId = null;
 }
 if (objClsRmTeachingCaseEN.UserKindId !=  null)
 {
 var strUserKindId = objClsRmTeachingCaseEN.UserKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserKindId, conClsRmTeachingCase.UserKindId); //用户类别Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UserKindId); //用户类别Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UserTypeId))
 {
 if (objClsRmTeachingCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objClsRmTeachingCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conClsRmTeachingCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClsRmTeachingCaseEN.IsDualVideo == true?"1":"0", conClsRmTeachingCase.IsDualVideo); //是否双视频
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.RecommendedDegreeId))
 {
 if (objClsRmTeachingCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objClsRmTeachingCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conClsRmTeachingCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ftpFileType))
 {
 if (objClsRmTeachingCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objClsRmTeachingCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conClsRmTeachingCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoUrl))
 {
 if (objClsRmTeachingCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objClsRmTeachingCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conClsRmTeachingCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.VideoUrl); //视频Url
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.VideoPath))
 {
 if (objClsRmTeachingCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objClsRmTeachingCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conClsRmTeachingCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.VideoPath); //视频目录
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.ResErrMsg))
 {
 if (objClsRmTeachingCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objClsRmTeachingCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conClsRmTeachingCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdDate))
 {
 if (objClsRmTeachingCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objClsRmTeachingCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClsRmTeachingCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UpdDate); //修改日期
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.UpdUserId))
 {
 if (objClsRmTeachingCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objClsRmTeachingCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conClsRmTeachingCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objClsRmTeachingCaseEN.IsUpdated(conClsRmTeachingCase.Memo))
 {
 if (objClsRmTeachingCaseEN.Memo !=  null)
 {
 var strMemo = objClsRmTeachingCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClsRmTeachingCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClsRmTeachingCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdClsRmTeachingCase = '{0}'", objClsRmTeachingCaseEN.IdClsRmTeachingCase); 
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
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdClsRmTeachingCase) 
{
CheckPrimaryKey(strIdClsRmTeachingCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdClsRmTeachingCase,
};
 objSQL.ExecSP("ClsRmTeachingCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdClsRmTeachingCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdClsRmTeachingCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
//删除ClsRmTeachingCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelClsRmTeachingCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
//删除ClsRmTeachingCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmTeachingCase where IdClsRmTeachingCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdClsRmTeachingCase) 
{
CheckPrimaryKey(strIdClsRmTeachingCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
//删除ClsRmTeachingCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelClsRmTeachingCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: DelClsRmTeachingCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClsRmTeachingCase where " + strCondition ;
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
public bool DelClsRmTeachingCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsClsRmTeachingCaseDA: DelClsRmTeachingCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClsRmTeachingCase where " + strCondition ;
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
 /// <param name = "objClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objClsRmTeachingCaseENT">目标对象</param>
public void CopyTo(clsClsRmTeachingCaseEN objClsRmTeachingCaseENS, clsClsRmTeachingCaseEN objClsRmTeachingCaseENT)
{
objClsRmTeachingCaseENT.IdClsRmTeachingCase = objClsRmTeachingCaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objClsRmTeachingCaseENT.ClsRmTeachingCaseID = objClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objClsRmTeachingCaseENT.ClsRmTeachingCaseName = objClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objClsRmTeachingCaseENT.IdClsRmTeachingCaseType = objClsRmTeachingCaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objClsRmTeachingCaseENT.ClsRmTeachingCaseText = objClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objClsRmTeachingCaseENT.IdStudyLevel = objClsRmTeachingCaseENS.IdStudyLevel; //学段流水号
objClsRmTeachingCaseENT.IdTeachingPlan = objClsRmTeachingCaseENS.IdTeachingPlan; //教案流水号
objClsRmTeachingCaseENT.IdCaseType = objClsRmTeachingCaseENS.IdCaseType; //案例类型流水号
objClsRmTeachingCaseENT.IdDiscipline = objClsRmTeachingCaseENS.IdDiscipline; //学科流水号
objClsRmTeachingCaseENT.IdSchoolPs = objClsRmTeachingCaseENS.IdSchoolPs; //学校流水号
objClsRmTeachingCaseENT.IdDisciplinePs = objClsRmTeachingCaseENS.IdDisciplinePs; //学科流水号
objClsRmTeachingCaseENT.IdGradeBase = objClsRmTeachingCaseENS.IdGradeBase; //年级流水号
objClsRmTeachingCaseENT.BrowseCount = objClsRmTeachingCaseENS.BrowseCount; //浏览次数
objClsRmTeachingCaseENT.IdSenateGaugeVersion = objClsRmTeachingCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objClsRmTeachingCaseENT.IdTeachSkill = objClsRmTeachingCaseENS.IdTeachSkill; //教学技能流水号
objClsRmTeachingCaseENT.CaseLevelId = objClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objClsRmTeachingCaseENT.DocFile = objClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objClsRmTeachingCaseENT.IsNeedGeneWord = objClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objClsRmTeachingCaseENT.WordCreateDate = objClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objClsRmTeachingCaseENT.IsVisible = objClsRmTeachingCaseENS.IsVisible; //是否显示
objClsRmTeachingCaseENT.OwnerId = objClsRmTeachingCaseENS.OwnerId; //拥有者Id
objClsRmTeachingCaseENT.UserKindId = objClsRmTeachingCaseENS.UserKindId; //用户类别Id
objClsRmTeachingCaseENT.UserTypeId = objClsRmTeachingCaseENS.UserTypeId; //用户类型Id
objClsRmTeachingCaseENT.IsDualVideo = objClsRmTeachingCaseENS.IsDualVideo; //是否双视频
objClsRmTeachingCaseENT.RecommendedDegreeId = objClsRmTeachingCaseENS.RecommendedDegreeId; //推荐度Id
objClsRmTeachingCaseENT.ftpFileType = objClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
objClsRmTeachingCaseENT.VideoUrl = objClsRmTeachingCaseENS.VideoUrl; //视频Url
objClsRmTeachingCaseENT.VideoPath = objClsRmTeachingCaseENS.VideoPath; //视频目录
objClsRmTeachingCaseENT.ResErrMsg = objClsRmTeachingCaseENS.ResErrMsg; //资源错误信息
objClsRmTeachingCaseENT.UpdDate = objClsRmTeachingCaseENS.UpdDate; //修改日期
objClsRmTeachingCaseENT.UpdUserId = objClsRmTeachingCaseENS.UpdUserId; //修改用户Id
objClsRmTeachingCaseENT.Memo = objClsRmTeachingCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.ClsRmTeachingCaseID, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.ClsRmTeachingCaseName, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.IdClsRmTeachingCaseType, conClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.IdDiscipline, conClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.IdTeachSkill, conClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.OwnerId, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objClsRmTeachingCaseEN.UserKindId, conClsRmTeachingCase.UserKindId);
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdClsRmTeachingCase, 8, conClsRmTeachingCase.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseID, 8, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseName, 100, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, 200, conClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdClsRmTeachingCaseType, 4, conClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseText, 8000, conClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDate, 8, conClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTime, 6, conClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, 8, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, 6, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachingPlan, 8, conClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDiscipline, 4, conClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSchoolPs, 4, conClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDisciplinePs, 4, conClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdGradeBase, 4, conClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachSkill, 8, conClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.CaseLevelId, 2, conClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.DocFile, 200, conClsRmTeachingCase.DocFile);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.WordCreateDate, 14, conClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.OwnerId, 20, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserTypeId, 2, conClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.RecommendedDegreeId, 2, conClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ftpFileType, 30, conClsRmTeachingCase.ftpFileType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoUrl, 1000, conClsRmTeachingCase.VideoUrl);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoPath, 1000, conClsRmTeachingCase.VideoPath);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ResErrMsg, 30, conClsRmTeachingCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdDate, 20, conClsRmTeachingCase.UpdDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdUserId, 20, conClsRmTeachingCase.UpdUserId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.Memo, 1000, conClsRmTeachingCase.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
 objClsRmTeachingCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseID, 8, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseName, 100, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, 200, conClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdClsRmTeachingCaseType, 4, conClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseText, 8000, conClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDate, 8, conClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTime, 6, conClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, 8, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, 6, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachingPlan, 8, conClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDiscipline, 4, conClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSchoolPs, 4, conClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDisciplinePs, 4, conClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdGradeBase, 4, conClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachSkill, 8, conClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.CaseLevelId, 2, conClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.DocFile, 200, conClsRmTeachingCase.DocFile);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.WordCreateDate, 14, conClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.OwnerId, 20, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserTypeId, 2, conClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.RecommendedDegreeId, 2, conClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ftpFileType, 30, conClsRmTeachingCase.ftpFileType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoUrl, 1000, conClsRmTeachingCase.VideoUrl);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoPath, 1000, conClsRmTeachingCase.VideoPath);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ResErrMsg, 30, conClsRmTeachingCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdDate, 20, conClsRmTeachingCase.UpdDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdUserId, 20, conClsRmTeachingCase.UpdUserId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.Memo, 1000, conClsRmTeachingCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
 objClsRmTeachingCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsClsRmTeachingCaseEN objClsRmTeachingCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdClsRmTeachingCase, 8, conClsRmTeachingCase.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseID, 8, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseName, 100, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, 200, conClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdClsRmTeachingCaseType, 4, conClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseText, 8000, conClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDate, 8, conClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTime, 6, conClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, 8, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, 6, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachingPlan, 8, conClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDiscipline, 4, conClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSchoolPs, 4, conClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdDisciplinePs, 4, conClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdGradeBase, 4, conClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.IdTeachSkill, 8, conClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.CaseLevelId, 2, conClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.DocFile, 200, conClsRmTeachingCase.DocFile);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.WordCreateDate, 14, conClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.OwnerId, 20, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UserTypeId, 2, conClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.RecommendedDegreeId, 2, conClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ftpFileType, 30, conClsRmTeachingCase.ftpFileType);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoUrl, 1000, conClsRmTeachingCase.VideoUrl);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.VideoPath, 1000, conClsRmTeachingCase.VideoPath);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.ResErrMsg, 30, conClsRmTeachingCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdDate, 20, conClsRmTeachingCase.UpdDate);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.UpdUserId, 20, conClsRmTeachingCase.UpdUserId);
clsCheckSql.CheckFieldLen(objClsRmTeachingCaseEN.Memo, 1000, conClsRmTeachingCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdClsRmTeachingCase, conClsRmTeachingCase.IdClsRmTeachingCase);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseID, conClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseName, conClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, conClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdClsRmTeachingCaseType, conClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseText, conClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseDate, conClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseTime, conClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, conClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, conClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdStudyLevel, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdTeachingPlan, conClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdCaseType, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdDiscipline, conClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdSchoolPs, conClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdDisciplinePs, conClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdGradeBase, conClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdSenateGaugeVersion, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.IdTeachSkill, conClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.CaseLevelId, conClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.DocFile, conClsRmTeachingCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.WordCreateDate, conClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.OwnerId, conClsRmTeachingCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.UserKindId, conClsRmTeachingCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.UserTypeId, conClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.RecommendedDegreeId, conClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ftpFileType, conClsRmTeachingCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.VideoUrl, conClsRmTeachingCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.VideoPath, conClsRmTeachingCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.ResErrMsg, conClsRmTeachingCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.UpdDate, conClsRmTeachingCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.UpdUserId, conClsRmTeachingCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objClsRmTeachingCaseEN.Memo, conClsRmTeachingCase.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdStudyLevel, 4, conClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdCaseType, 4, conClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, conClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(objClsRmTeachingCaseEN.UserKindId, 2, conClsRmTeachingCase.UserKindId);
 objClsRmTeachingCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdClsRmTeachingCase()
{
//获取某学院所有专业信息
string strSQL = "select IdClsRmTeachingCase, ClsRmTeachingCaseName from ClsRmTeachingCase ";
 clsSpecSQLforSql mySql = clsClsRmTeachingCaseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClsRmTeachingCaseEN._CurrTabName);
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClsRmTeachingCaseEN._CurrTabName, strCondition);
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsClsRmTeachingCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}