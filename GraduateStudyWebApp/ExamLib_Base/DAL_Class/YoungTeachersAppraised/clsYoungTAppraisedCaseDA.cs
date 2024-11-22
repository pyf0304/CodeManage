
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsYoungTAppraisedCaseDA
 表名:YoungTAppraisedCase(01120463)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// 青教评优案例(YoungTAppraisedCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsYoungTAppraisedCaseDA : clsCommBase4DA
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
 return clsYoungTAppraisedCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsYoungTAppraisedCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsYoungTAppraisedCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsYoungTAppraisedCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsYoungTAppraisedCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdYoungTAppraisedCase)
{
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:YoungTAppraisedCase中,检查关键字,长度不正确!(clsYoungTAppraisedCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:YoungTAppraisedCase中,关键字不能为空 或 null!(clsYoungTAppraisedCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsYoungTAppraisedCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_YoungTAppraisedCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable_YoungTAppraisedCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} YoungTAppraisedCase.* from YoungTAppraisedCase Left Join {1} on {2} where {3} and YoungTAppraisedCase.IdYoungTAppraisedCase not in (Select top {5} YoungTAppraisedCase.IdYoungTAppraisedCase from YoungTAppraisedCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from YoungTAppraisedCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from YoungTAppraisedCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} YoungTAppraisedCase.* from YoungTAppraisedCase Left Join {1} on {2} where {3} and YoungTAppraisedCase.IdYoungTAppraisedCase not in (Select top {5} YoungTAppraisedCase.IdYoungTAppraisedCase from YoungTAppraisedCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from YoungTAppraisedCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from YoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from YoungTAppraisedCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsYoungTAppraisedCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA:GetObjLst)", objException.Message));
}
List<clsYoungTAppraisedCaseEN> arrObjLst = new List<clsYoungTAppraisedCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN();
try
{
objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objYoungTAppraisedCaseEN.IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号
objYoungTAppraisedCaseEN.IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objYoungTAppraisedCaseEN.IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objYoungTAppraisedCaseEN.IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objYoungTAppraisedCaseEN.BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数
objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objYoungTAppraisedCaseEN.IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objYoungTAppraisedCaseEN.CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objYoungTAppraisedCaseEN.DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objYoungTAppraisedCaseEN.WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objYoungTAppraisedCaseEN.OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objYoungTAppraisedCaseEN.UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objYoungTAppraisedCaseEN.ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objYoungTAppraisedCaseEN.VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objYoungTAppraisedCaseEN.VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objYoungTAppraisedCaseEN.ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objYoungTAppraisedCaseEN.UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objYoungTAppraisedCaseEN.UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objYoungTAppraisedCaseEN.Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetObjLst)", objException.Message));
}
objYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objYoungTAppraisedCaseEN);
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
public List<clsYoungTAppraisedCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsYoungTAppraisedCaseEN> arrObjLst = new List<clsYoungTAppraisedCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN();
try
{
objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objYoungTAppraisedCaseEN.IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号
objYoungTAppraisedCaseEN.IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objYoungTAppraisedCaseEN.IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objYoungTAppraisedCaseEN.IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objYoungTAppraisedCaseEN.BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数
objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objYoungTAppraisedCaseEN.IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objYoungTAppraisedCaseEN.CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objYoungTAppraisedCaseEN.DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objYoungTAppraisedCaseEN.WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objYoungTAppraisedCaseEN.OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objYoungTAppraisedCaseEN.UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objYoungTAppraisedCaseEN.ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objYoungTAppraisedCaseEN.VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objYoungTAppraisedCaseEN.VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objYoungTAppraisedCaseEN.ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objYoungTAppraisedCaseEN.UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objYoungTAppraisedCaseEN.UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objYoungTAppraisedCaseEN.Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetObjLst)", objException.Message));
}
objYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objYoungTAppraisedCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetYoungTAppraisedCase(ref clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ objYoungTAppraisedCaseEN.IdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objDT.Rows[0][conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objDT.Rows[0][conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objYoungTAppraisedCaseEN.IdStudyLevel = objDT.Rows[0][conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdTeachingPlan = objDT.Rows[0][conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.IdCaseType = objDT.Rows[0][conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdDiscipline = objDT.Rows[0][conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objDT.Rows[0][conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.IdTeachSkill = objDT.Rows[0][conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.CaseLevelId = objDT.Rows[0][conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objYoungTAppraisedCaseEN.DocFile = objDT.Rows[0][conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objYoungTAppraisedCaseEN.WordCreateDate = objDT.Rows[0][conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objYoungTAppraisedCaseEN.OwnerId = objDT.Rows[0][conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objDT.Rows[0][conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.UserTypeId = objDT.Rows[0][conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objYoungTAppraisedCaseEN.RecommendedDegreeId = objDT.Rows[0][conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objYoungTAppraisedCaseEN.ftpFileType = objDT.Rows[0][conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objYoungTAppraisedCaseEN.VideoUrl = objDT.Rows[0][conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objYoungTAppraisedCaseEN.VideoPath = objDT.Rows[0][conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objYoungTAppraisedCaseEN.ResErrMsg = objDT.Rows[0][conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objYoungTAppraisedCaseEN.UpdUserId = objDT.Rows[0][conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objYoungTAppraisedCaseEN.UpdDate = objDT.Rows[0][conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objYoungTAppraisedCaseEN.Memo = objDT.Rows[0][conYoungTAppraisedCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetYoungTAppraisedCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public clsYoungTAppraisedCaseEN GetObjByIdYoungTAppraisedCase(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN();
try
{
 objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objYoungTAppraisedCaseEN.IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号(字段类型:char,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objYoungTAppraisedCaseEN.CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objYoungTAppraisedCaseEN.DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objYoungTAppraisedCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objYoungTAppraisedCaseEN.WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objYoungTAppraisedCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objYoungTAppraisedCaseEN.OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objYoungTAppraisedCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objYoungTAppraisedCaseEN.UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objYoungTAppraisedCaseEN.ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objYoungTAppraisedCaseEN.VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objYoungTAppraisedCaseEN.VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objYoungTAppraisedCaseEN.ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objYoungTAppraisedCaseEN.UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objYoungTAppraisedCaseEN.UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objYoungTAppraisedCaseEN.Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetObjByIdYoungTAppraisedCase)", objException.Message));
}
return objYoungTAppraisedCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsYoungTAppraisedCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN()
{
IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(), //青教评优案例ID
YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(), //案例文本内容
YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(), //青教评优教学日期
YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(), //青教评优教学时间
YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(), //青教评优案例主题词
YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(), //案例入库日期
YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(), //学段流水号
IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(), //学科流水号
BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(), //拥有者Id
IsDualVideo = TransNullToBool(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()), //是否双视频
IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(), //青教案例类型流水号
UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim() //备注
};
objYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objYoungTAppraisedCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsYoungTAppraisedCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN();
try
{
objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objYoungTAppraisedCaseEN.IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号
objYoungTAppraisedCaseEN.IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objYoungTAppraisedCaseEN.IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objYoungTAppraisedCaseEN.IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objYoungTAppraisedCaseEN.BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数
objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objYoungTAppraisedCaseEN.IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objYoungTAppraisedCaseEN.CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objYoungTAppraisedCaseEN.DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objYoungTAppraisedCaseEN.WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objYoungTAppraisedCaseEN.OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objYoungTAppraisedCaseEN.UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objYoungTAppraisedCaseEN.ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objYoungTAppraisedCaseEN.VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objYoungTAppraisedCaseEN.VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objYoungTAppraisedCaseEN.ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objYoungTAppraisedCaseEN.UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objYoungTAppraisedCaseEN.UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objYoungTAppraisedCaseEN.Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetObjByDataRowYoungTAppraisedCase)", objException.Message));
}
objYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objYoungTAppraisedCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsYoungTAppraisedCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN = new clsYoungTAppraisedCaseEN();
try
{
objYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objYoungTAppraisedCaseEN.IdStudyLevel = objRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号
objYoungTAppraisedCaseEN.IdTeachingPlan = objRow[conYoungTAppraisedCase.IdTeachingPlan] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objYoungTAppraisedCaseEN.IdCaseType = objRow[conYoungTAppraisedCase.IdCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objYoungTAppraisedCaseEN.IdDiscipline = objRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objYoungTAppraisedCaseEN.BrowseCount = objRow[conYoungTAppraisedCase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim()); //浏览次数
objYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objYoungTAppraisedCaseEN.IdTeachSkill = objRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objYoungTAppraisedCaseEN.CaseLevelId = objRow[conYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objYoungTAppraisedCaseEN.DocFile = objRow[conYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objYoungTAppraisedCaseEN.WordCreateDate = objRow[conYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[conYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objYoungTAppraisedCaseEN.OwnerId = objRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objYoungTAppraisedCaseEN.UserTypeId = objRow[conYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objYoungTAppraisedCaseEN.ftpFileType = objRow[conYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objYoungTAppraisedCaseEN.VideoUrl = objRow[conYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objYoungTAppraisedCaseEN.VideoPath = objRow[conYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objYoungTAppraisedCaseEN.ResErrMsg = objRow[conYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objYoungTAppraisedCaseEN.UpdUserId = objRow[conYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objYoungTAppraisedCaseEN.UpdDate = objRow[conYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objYoungTAppraisedCaseEN.Memo = objRow[conYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsYoungTAppraisedCaseDA: GetObjByDataRow)", objException.Message));
}
objYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objYoungTAppraisedCaseEN;
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
objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsYoungTAppraisedCaseEN._CurrTabName, conYoungTAppraisedCase.IdYoungTAppraisedCase, 8, "");
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
objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsYoungTAppraisedCaseEN._CurrTabName, conYoungTAppraisedCase.IdYoungTAppraisedCase, 8, strPrefix);
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from YoungTAppraisedCase where " + strCondition;
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from YoungTAppraisedCase where " + strCondition;
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
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("YoungTAppraisedCase", "IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("YoungTAppraisedCase", strCondition))
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
objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("YoungTAppraisedCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
 {
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objYoungTAppraisedCaseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "YoungTAppraisedCase");
objRow = objDS.Tables["YoungTAppraisedCase"].NewRow();
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase] = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase; //青教评优案例流水号
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID; //青教评优案例ID
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName; //青教评优案例名称
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText; //案例文本内容
 }
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate; //青教评优教学日期
 }
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime; //青教评优教学时间
 }
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme; //青教评优案例主题词
 }
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn; //案例入库日期
 }
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  "")
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn; //案例入库时间
 }
objRow[conYoungTAppraisedCase.IdStudyLevel] = objYoungTAppraisedCaseEN.IdStudyLevel; //学段流水号
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  "")
 {
objRow[conYoungTAppraisedCase.IdTeachingPlan] = objYoungTAppraisedCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objYoungTAppraisedCaseEN.IdCaseType !=  "")
 {
objRow[conYoungTAppraisedCase.IdCaseType] = objYoungTAppraisedCaseEN.IdCaseType; //案例类型流水号
 }
objRow[conYoungTAppraisedCase.IdDiscipline] = objYoungTAppraisedCaseEN.IdDiscipline; //学科流水号
objRow[conYoungTAppraisedCase.BrowseCount] = objYoungTAppraisedCaseEN.BrowseCount; //浏览次数
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  "")
 {
objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] = objYoungTAppraisedCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
objRow[conYoungTAppraisedCase.IdTeachSkill] = objYoungTAppraisedCaseEN.IdTeachSkill; //教学技能流水号
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  "")
 {
objRow[conYoungTAppraisedCase.CaseLevelId] = objYoungTAppraisedCaseEN.CaseLevelId; //课例等级Id
 }
 if (objYoungTAppraisedCaseEN.DocFile !=  "")
 {
objRow[conYoungTAppraisedCase.DocFile] = objYoungTAppraisedCaseEN.DocFile; //生成的Word文件名
 }
objRow[conYoungTAppraisedCase.IsNeedGeneWord] = objYoungTAppraisedCaseEN.IsNeedGeneWord; //是否需要生成Word
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  "")
 {
objRow[conYoungTAppraisedCase.WordCreateDate] = objYoungTAppraisedCaseEN.WordCreateDate; //Word生成日期
 }
objRow[conYoungTAppraisedCase.IsVisible] = objYoungTAppraisedCaseEN.IsVisible; //是否显示
objRow[conYoungTAppraisedCase.OwnerId] = objYoungTAppraisedCaseEN.OwnerId; //拥有者Id
objRow[conYoungTAppraisedCase.IsDualVideo] = objYoungTAppraisedCaseEN.IsDualVideo; //是否双视频
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  "")
 {
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType; //青教案例类型流水号
 }
 if (objYoungTAppraisedCaseEN.UserTypeId !=  "")
 {
objRow[conYoungTAppraisedCase.UserTypeId] = objYoungTAppraisedCaseEN.UserTypeId; //用户类型Id
 }
objRow[conYoungTAppraisedCase.RecommendedDegreeId] = objYoungTAppraisedCaseEN.RecommendedDegreeId; //推荐度Id
 if (objYoungTAppraisedCaseEN.ftpFileType !=  "")
 {
objRow[conYoungTAppraisedCase.ftpFileType] = objYoungTAppraisedCaseEN.ftpFileType; //ftp文件类型
 }
 if (objYoungTAppraisedCaseEN.VideoUrl !=  "")
 {
objRow[conYoungTAppraisedCase.VideoUrl] = objYoungTAppraisedCaseEN.VideoUrl; //视频Url
 }
 if (objYoungTAppraisedCaseEN.VideoPath !=  "")
 {
objRow[conYoungTAppraisedCase.VideoPath] = objYoungTAppraisedCaseEN.VideoPath; //视频目录
 }
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  "")
 {
objRow[conYoungTAppraisedCase.ResErrMsg] = objYoungTAppraisedCaseEN.ResErrMsg; //资源错误信息
 }
 if (objYoungTAppraisedCaseEN.UpdUserId !=  "")
 {
objRow[conYoungTAppraisedCase.UpdUserId] = objYoungTAppraisedCaseEN.UpdUserId; //修改用户Id
 }
 if (objYoungTAppraisedCaseEN.UpdDate !=  "")
 {
objRow[conYoungTAppraisedCase.UpdDate] = objYoungTAppraisedCaseEN.UpdDate; //修改日期
 }
 if (objYoungTAppraisedCaseEN.Memo !=  "")
 {
objRow[conYoungTAppraisedCase.Memo] = objYoungTAppraisedCaseEN.Memo; //备注
 }
objDS.Tables[clsYoungTAppraisedCaseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsYoungTAppraisedCaseEN._CurrTabName);
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
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objYoungTAppraisedCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCase !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCase);
 var strIdYoungTAppraisedCase = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCase + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID);
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseID + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName);
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseName + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText);
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseText + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTime + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTheme + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDateIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTimeIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdStudyLevel);
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachingPlan);
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdCaseType);
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdDiscipline);
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.BrowseCount);
 arrValueListForInsert.Add(objYoungTAppraisedCaseEN.BrowseCount.ToString());
 }
 
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachSkill);
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.CaseLevelId);
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.DocFile);
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.WordCreateDate);
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsVisible);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.OwnerId);
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UserTypeId);
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ftpFileType);
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoUrl);
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoPath);
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ResErrMsg);
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdUserId);
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdDate);
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.Memo);
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into YoungTAppraisedCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objYoungTAppraisedCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCase !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCase);
 var strIdYoungTAppraisedCase = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCase + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID);
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseID + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName);
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseName + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText);
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseText + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTime + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTheme + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDateIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTimeIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdStudyLevel);
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachingPlan);
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdCaseType);
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdDiscipline);
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.BrowseCount);
 arrValueListForInsert.Add(objYoungTAppraisedCaseEN.BrowseCount.ToString());
 }
 
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachSkill);
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.CaseLevelId);
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.DocFile);
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.WordCreateDate);
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsVisible);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.OwnerId);
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UserTypeId);
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ftpFileType);
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoUrl);
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoPath);
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ResErrMsg);
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdUserId);
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdDate);
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.Memo);
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into YoungTAppraisedCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objYoungTAppraisedCaseEN.IdYoungTAppraisedCase;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objYoungTAppraisedCaseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCase !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCase);
 var strIdYoungTAppraisedCase = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCase + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID);
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseID + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName);
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseName + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText);
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseText + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTime + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTheme + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDateIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTimeIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdStudyLevel);
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachingPlan);
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdCaseType);
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdDiscipline);
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.BrowseCount);
 arrValueListForInsert.Add(objYoungTAppraisedCaseEN.BrowseCount.ToString());
 }
 
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachSkill);
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.CaseLevelId);
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.DocFile);
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.WordCreateDate);
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsVisible);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.OwnerId);
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UserTypeId);
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ftpFileType);
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoUrl);
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoPath);
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ResErrMsg);
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdUserId);
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdDate);
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.Memo);
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into YoungTAppraisedCase");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objYoungTAppraisedCaseEN.IdYoungTAppraisedCase;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objYoungTAppraisedCaseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCase !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCase);
 var strIdYoungTAppraisedCase = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCase + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseID);
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseID + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseName);
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseName + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseText);
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseText + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDate);
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTime);
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTime + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTheme + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseDateIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYoungTAppraisedCaseTimeIn + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdStudyLevel);
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudyLevel + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachingPlan);
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachingPlan + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdCaseType);
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdDiscipline);
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDiscipline + "'");
 }
 
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.BrowseCount);
 arrValueListForInsert.Add(objYoungTAppraisedCaseEN.BrowseCount.ToString());
 }
 
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdTeachSkill);
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeachSkill + "'");
 }
 
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.CaseLevelId);
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseLevelId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.DocFile);
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocFile + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsNeedGeneWord);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsNeedGeneWord  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.WordCreateDate);
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordCreateDate + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsVisible);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsVisible  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.OwnerId);
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IsDualVideo);
 arrValueListForInsert.Add("'" + (objYoungTAppraisedCaseEN.IsDualVideo  ==  false ? "0" : "1") + "'");
 
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdYoungTAppraisedCaseType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UserTypeId);
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.RecommendedDegreeId);
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedDegreeId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ftpFileType);
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strftpFileType + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoUrl);
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoUrl + "'");
 }
 
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.VideoPath);
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVideoPath + "'");
 }
 
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.ResErrMsg);
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResErrMsg + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdUserId);
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.UpdDate);
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conYoungTAppraisedCase.Memo);
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into YoungTAppraisedCase");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewYoungTAppraisedCases(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where IdYoungTAppraisedCase = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "YoungTAppraisedCase");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdYoungTAppraisedCase = oRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim();
if (IsExist(strIdYoungTAppraisedCase))
{
 string strResult = "关键字变量值为:" + string.Format("IdYoungTAppraisedCase = {0}", strIdYoungTAppraisedCase) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsYoungTAppraisedCaseEN._CurrTabName ].NewRow();
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase] = oRow[conYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = oRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objRow[conYoungTAppraisedCase.IdStudyLevel] = oRow[conYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //学段流水号
objRow[conYoungTAppraisedCase.IdTeachingPlan] = oRow[conYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objRow[conYoungTAppraisedCase.IdCaseType] = oRow[conYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conYoungTAppraisedCase.IdDiscipline] = oRow[conYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objRow[conYoungTAppraisedCase.BrowseCount] = oRow[conYoungTAppraisedCase.BrowseCount].ToString().Trim(); //浏览次数
objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] = oRow[conYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conYoungTAppraisedCase.IdTeachSkill] = oRow[conYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objRow[conYoungTAppraisedCase.CaseLevelId] = oRow[conYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objRow[conYoungTAppraisedCase.DocFile] = oRow[conYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objRow[conYoungTAppraisedCase.IsNeedGeneWord] = oRow[conYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim(); //是否需要生成Word
objRow[conYoungTAppraisedCase.WordCreateDate] = oRow[conYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objRow[conYoungTAppraisedCase.IsVisible] = oRow[conYoungTAppraisedCase.IsVisible].ToString().Trim(); //是否显示
objRow[conYoungTAppraisedCase.OwnerId] = oRow[conYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objRow[conYoungTAppraisedCase.IsDualVideo] = oRow[conYoungTAppraisedCase.IsDualVideo].ToString().Trim(); //是否双视频
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] = oRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objRow[conYoungTAppraisedCase.UserTypeId] = oRow[conYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conYoungTAppraisedCase.RecommendedDegreeId] = oRow[conYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objRow[conYoungTAppraisedCase.ftpFileType] = oRow[conYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objRow[conYoungTAppraisedCase.VideoUrl] = oRow[conYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objRow[conYoungTAppraisedCase.VideoPath] = oRow[conYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objRow[conYoungTAppraisedCase.ResErrMsg] = oRow[conYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objRow[conYoungTAppraisedCase.UpdUserId] = oRow[conYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conYoungTAppraisedCase.UpdDate] = oRow[conYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objRow[conYoungTAppraisedCase.Memo] = oRow[conYoungTAppraisedCase.Memo].ToString().Trim(); //备注
 objDS.Tables[clsYoungTAppraisedCaseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsYoungTAppraisedCaseEN._CurrTabName);
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
 /// <param name = "objYoungTAppraisedCaseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objYoungTAppraisedCaseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from YoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ objYoungTAppraisedCaseEN.IdYoungTAppraisedCase+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsYoungTAppraisedCaseEN._CurrTabName);
if (objDS.Tables[clsYoungTAppraisedCaseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdYoungTAppraisedCase = " + "'"+ objYoungTAppraisedCaseEN.IdYoungTAppraisedCase+"'");
return false;
}
objRow = objDS.Tables[clsYoungTAppraisedCaseEN._CurrTabName].Rows[0];
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCase))
 {
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCase] = objYoungTAppraisedCaseEN.IdYoungTAppraisedCase; //青教评优案例流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseID] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID; //青教评优案例ID
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseName] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName; //青教评优案例名称
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseText] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText; //案例文本内容
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDate] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate; //青教评优教学日期
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTime] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime; //青教评优教学时间
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTheme] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme; //青教评优案例主题词
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseDateIn] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn; //案例入库日期
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn))
 {
objRow[conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn; //案例入库时间
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdStudyLevel))
 {
objRow[conYoungTAppraisedCase.IdStudyLevel] = objYoungTAppraisedCaseEN.IdStudyLevel; //学段流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachingPlan))
 {
objRow[conYoungTAppraisedCase.IdTeachingPlan] = objYoungTAppraisedCaseEN.IdTeachingPlan; //教案流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdCaseType))
 {
objRow[conYoungTAppraisedCase.IdCaseType] = objYoungTAppraisedCaseEN.IdCaseType; //案例类型流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdDiscipline))
 {
objRow[conYoungTAppraisedCase.IdDiscipline] = objYoungTAppraisedCaseEN.IdDiscipline; //学科流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.BrowseCount))
 {
objRow[conYoungTAppraisedCase.BrowseCount] = objYoungTAppraisedCaseEN.BrowseCount; //浏览次数
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdSenateGaugeVersion))
 {
objRow[conYoungTAppraisedCase.IdSenateGaugeVersion] = objYoungTAppraisedCaseEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachSkill))
 {
objRow[conYoungTAppraisedCase.IdTeachSkill] = objYoungTAppraisedCaseEN.IdTeachSkill; //教学技能流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.CaseLevelId))
 {
objRow[conYoungTAppraisedCase.CaseLevelId] = objYoungTAppraisedCaseEN.CaseLevelId; //课例等级Id
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.DocFile))
 {
objRow[conYoungTAppraisedCase.DocFile] = objYoungTAppraisedCaseEN.DocFile; //生成的Word文件名
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord))
 {
objRow[conYoungTAppraisedCase.IsNeedGeneWord] = objYoungTAppraisedCaseEN.IsNeedGeneWord; //是否需要生成Word
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.WordCreateDate))
 {
objRow[conYoungTAppraisedCase.WordCreateDate] = objYoungTAppraisedCaseEN.WordCreateDate; //Word生成日期
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsVisible))
 {
objRow[conYoungTAppraisedCase.IsVisible] = objYoungTAppraisedCaseEN.IsVisible; //是否显示
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.OwnerId))
 {
objRow[conYoungTAppraisedCase.OwnerId] = objYoungTAppraisedCaseEN.OwnerId; //拥有者Id
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsDualVideo))
 {
objRow[conYoungTAppraisedCase.IsDualVideo] = objYoungTAppraisedCaseEN.IsDualVideo; //是否双视频
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCaseType))
 {
objRow[conYoungTAppraisedCase.IdYoungTAppraisedCaseType] = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType; //青教案例类型流水号
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UserTypeId))
 {
objRow[conYoungTAppraisedCase.UserTypeId] = objYoungTAppraisedCaseEN.UserTypeId; //用户类型Id
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId))
 {
objRow[conYoungTAppraisedCase.RecommendedDegreeId] = objYoungTAppraisedCaseEN.RecommendedDegreeId; //推荐度Id
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ftpFileType))
 {
objRow[conYoungTAppraisedCase.ftpFileType] = objYoungTAppraisedCaseEN.ftpFileType; //ftp文件类型
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoUrl))
 {
objRow[conYoungTAppraisedCase.VideoUrl] = objYoungTAppraisedCaseEN.VideoUrl; //视频Url
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoPath))
 {
objRow[conYoungTAppraisedCase.VideoPath] = objYoungTAppraisedCaseEN.VideoPath; //视频目录
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ResErrMsg))
 {
objRow[conYoungTAppraisedCase.ResErrMsg] = objYoungTAppraisedCaseEN.ResErrMsg; //资源错误信息
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdUserId))
 {
objRow[conYoungTAppraisedCase.UpdUserId] = objYoungTAppraisedCaseEN.UpdUserId; //修改用户Id
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdDate))
 {
objRow[conYoungTAppraisedCase.UpdDate] = objYoungTAppraisedCaseEN.UpdDate; //修改日期
 }
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.Memo))
 {
objRow[conYoungTAppraisedCase.Memo] = objYoungTAppraisedCaseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsYoungTAppraisedCaseEN._CurrTabName);
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
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objYoungTAppraisedCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update YoungTAppraisedCase Set ");
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseID, conYoungTAppraisedCase.YoungTAppraisedCaseID); //青教评优案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseID); //青教评优案例ID
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseName, conYoungTAppraisedCase.YoungTAppraisedCaseName); //青教评优案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseName); //青教评优案例名称
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseText, conYoungTAppraisedCase.YoungTAppraisedCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseText); //案例文本内容
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseDate, conYoungTAppraisedCase.YoungTAppraisedCaseDate); //青教评优教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseDate); //青教评优教学日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTime, conYoungTAppraisedCase.YoungTAppraisedCaseTime); //青教评优教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTime); //青教评优教学时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTheme, conYoungTAppraisedCase.YoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseDateIn, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseDateIn); //案例入库日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTimeIn, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn); //案例入库时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdStudyLevel))
 {
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conYoungTAppraisedCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachingPlan))
 {
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conYoungTAppraisedCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conYoungTAppraisedCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdDiscipline))
 {
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conYoungTAppraisedCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.BrowseCount))
 {
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objYoungTAppraisedCaseEN.BrowseCount, conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdSenateGaugeVersion))
 {
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conYoungTAppraisedCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachSkill))
 {
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conYoungTAppraisedCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.CaseLevelId))
 {
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conYoungTAppraisedCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.DocFile))
 {
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conYoungTAppraisedCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsNeedGeneWord == true?"1":"0", conYoungTAppraisedCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.WordCreateDate))
 {
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conYoungTAppraisedCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsVisible == true?"1":"0", conYoungTAppraisedCase.IsVisible); //是否显示
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.OwnerId))
 {
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conYoungTAppraisedCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.OwnerId); //拥有者Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsDualVideo == true?"1":"0", conYoungTAppraisedCase.IsDualVideo); //是否双视频
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdYoungTAppraisedCaseType, conYoungTAppraisedCase.IdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UserTypeId))
 {
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conYoungTAppraisedCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId))
 {
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conYoungTAppraisedCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ftpFileType))
 {
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conYoungTAppraisedCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoUrl))
 {
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conYoungTAppraisedCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.VideoUrl); //视频Url
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoPath))
 {
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conYoungTAppraisedCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.VideoPath); //视频目录
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ResErrMsg))
 {
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conYoungTAppraisedCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdUserId))
 {
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conYoungTAppraisedCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdDate))
 {
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conYoungTAppraisedCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UpdDate); //修改日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.Memo))
 {
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conYoungTAppraisedCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdYoungTAppraisedCase = '{0}'", objYoungTAppraisedCaseEN.IdYoungTAppraisedCase); 
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
 /// <param name = "objYoungTAppraisedCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strCondition)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objYoungTAppraisedCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update YoungTAppraisedCase Set ");
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseID = '{0}',", strYoungTAppraisedCaseID); //青教评优案例ID
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseID = null,"); //青教评优案例ID
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseName = '{0}',", strYoungTAppraisedCaseName); //青教评优案例名称
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseName = null,"); //青教评优案例名称
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseText = '{0}',", strYoungTAppraisedCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseText = null,"); //案例文本内容
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseDate = '{0}',", strYoungTAppraisedCaseDate); //青教评优教学日期
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseDate = null,"); //青教评优教学日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTime = '{0}',", strYoungTAppraisedCaseTime); //青教评优教学时间
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTime = null,"); //青教评优教学时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTheme = '{0}',", strYoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTheme = null,"); //青教评优案例主题词
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseDateIn = '{0}',", strYoungTAppraisedCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTimeIn = '{0}',", strYoungTAppraisedCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdStudyLevel))
 {
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachingPlan))
 {
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdDiscipline))
 {
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.BrowseCount))
 {
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objYoungTAppraisedCaseEN.BrowseCount, conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdSenateGaugeVersion))
 {
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachSkill))
 {
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.CaseLevelId))
 {
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.DocFile))
 {
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objYoungTAppraisedCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.WordCreateDate))
 {
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objYoungTAppraisedCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.OwnerId))
 {
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objYoungTAppraisedCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdYoungTAppraisedCaseType = '{0}',", strIdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdYoungTAppraisedCaseType = null,"); //青教案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UserTypeId))
 {
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId))
 {
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ftpFileType))
 {
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoUrl))
 {
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoPath))
 {
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ResErrMsg))
 {
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdUserId))
 {
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdDate))
 {
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.Memo))
 {
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objYoungTAppraisedCaseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objYoungTAppraisedCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update YoungTAppraisedCase Set ");
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseID = '{0}',", strYoungTAppraisedCaseID); //青教评优案例ID
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseID = null,"); //青教评优案例ID
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseName = '{0}',", strYoungTAppraisedCaseName); //青教评优案例名称
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseName = null,"); //青教评优案例名称
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseText = '{0}',", strYoungTAppraisedCaseText); //案例文本内容
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseText = null,"); //案例文本内容
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseDate = '{0}',", strYoungTAppraisedCaseDate); //青教评优教学日期
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseDate = null,"); //青教评优教学日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTime = '{0}',", strYoungTAppraisedCaseTime); //青教评优教学时间
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTime = null,"); //青教评优教学时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTheme = '{0}',", strYoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTheme = null,"); //青教评优案例主题词
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseDateIn = '{0}',", strYoungTAppraisedCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseDateIn = null,"); //案例入库日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" YoungTAppraisedCaseTimeIn = '{0}',", strYoungTAppraisedCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.Append(" YoungTAppraisedCaseTimeIn = null,"); //案例入库时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdStudyLevel))
 {
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudyLevel = '{0}',", strIdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.Append(" IdStudyLevel = null,"); //学段流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachingPlan))
 {
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachingPlan = '{0}',", strIdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.Append(" IdTeachingPlan = null,"); //教案流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdDiscipline))
 {
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDiscipline = '{0}',", strIdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDiscipline = null,"); //学科流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.BrowseCount))
 {
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objYoungTAppraisedCaseEN.BrowseCount, conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdSenateGaugeVersion))
 {
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSenateGaugeVersion = '{0}',", strIdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.Append(" IdSenateGaugeVersion = null,"); //评价量表版本流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachSkill))
 {
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeachSkill = '{0}',", strIdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.Append(" IdTeachSkill = null,"); //教学技能流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.CaseLevelId))
 {
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseLevelId = '{0}',", strCaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.Append(" CaseLevelId = null,"); //课例等级Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.DocFile))
 {
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocFile = '{0}',", strDocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.Append(" DocFile = null,"); //生成的Word文件名
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" IsNeedGeneWord = '{0}',", objYoungTAppraisedCaseEN.IsNeedGeneWord == true?"1":"0"); //是否需要生成Word
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.WordCreateDate))
 {
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordCreateDate = '{0}',", strWordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.Append(" WordCreateDate = null,"); //Word生成日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsVisible))
 {
 sbSQL.AppendFormat(" IsVisible = '{0}',", objYoungTAppraisedCaseEN.IsVisible == true?"1":"0"); //是否显示
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.OwnerId))
 {
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" IsDualVideo = '{0}',", objYoungTAppraisedCaseEN.IsDualVideo == true?"1":"0"); //是否双视频
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdYoungTAppraisedCaseType = '{0}',", strIdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdYoungTAppraisedCaseType = null,"); //青教案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UserTypeId))
 {
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId))
 {
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedDegreeId = '{0}',", strRecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.Append(" RecommendedDegreeId = null,"); //推荐度Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ftpFileType))
 {
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ftpFileType = '{0}',", strftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.Append(" ftpFileType = null,"); //ftp文件类型
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoUrl))
 {
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoUrl = '{0}',", strVideoUrl); //视频Url
 }
 else
 {
 sbSQL.Append(" VideoUrl = null,"); //视频Url
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoPath))
 {
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VideoPath = '{0}',", strVideoPath); //视频目录
 }
 else
 {
 sbSQL.Append(" VideoPath = null,"); //视频目录
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ResErrMsg))
 {
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResErrMsg = '{0}',", strResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.Append(" ResErrMsg = null,"); //资源错误信息
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdUserId))
 {
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdDate))
 {
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.Memo))
 {
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objYoungTAppraisedCaseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objYoungTAppraisedCaseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objYoungTAppraisedCaseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objYoungTAppraisedCaseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update YoungTAppraisedCase Set ");
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseID))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseID !=  null)
 {
 var strYoungTAppraisedCaseID = objYoungTAppraisedCaseEN.YoungTAppraisedCaseID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseID, conYoungTAppraisedCase.YoungTAppraisedCaseID); //青教评优案例ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseID); //青教评优案例ID
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseName))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseName !=  null)
 {
 var strYoungTAppraisedCaseName = objYoungTAppraisedCaseEN.YoungTAppraisedCaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseName, conYoungTAppraisedCase.YoungTAppraisedCaseName); //青教评优案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseName); //青教评优案例名称
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseText))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseText !=  null)
 {
 var strYoungTAppraisedCaseText = objYoungTAppraisedCaseEN.YoungTAppraisedCaseText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseText, conYoungTAppraisedCase.YoungTAppraisedCaseText); //案例文本内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseText); //案例文本内容
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDate))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate !=  null)
 {
 var strYoungTAppraisedCaseDate = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseDate, conYoungTAppraisedCase.YoungTAppraisedCaseDate); //青教评优教学日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseDate); //青教评优教学日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTime))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime !=  null)
 {
 var strYoungTAppraisedCaseTime = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTime, conYoungTAppraisedCase.YoungTAppraisedCaseTime); //青教评优教学时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTime); //青教评优教学时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTheme))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme !=  null)
 {
 var strYoungTAppraisedCaseTheme = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTheme, conYoungTAppraisedCase.YoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTheme); //青教评优案例主题词
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseDateIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn !=  null)
 {
 var strYoungTAppraisedCaseDateIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseDateIn, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn); //案例入库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseDateIn); //案例入库日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn))
 {
 if (objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn !=  null)
 {
 var strYoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYoungTAppraisedCaseTimeIn, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn); //案例入库时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn); //案例入库时间
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdStudyLevel))
 {
 if (objYoungTAppraisedCaseEN.IdStudyLevel !=  null)
 {
 var strIdStudyLevel = objYoungTAppraisedCaseEN.IdStudyLevel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudyLevel, conYoungTAppraisedCase.IdStudyLevel); //学段流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdStudyLevel); //学段流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachingPlan))
 {
 if (objYoungTAppraisedCaseEN.IdTeachingPlan !=  null)
 {
 var strIdTeachingPlan = objYoungTAppraisedCaseEN.IdTeachingPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachingPlan, conYoungTAppraisedCase.IdTeachingPlan); //教案流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdTeachingPlan); //教案流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdCaseType !=  null)
 {
 var strIdCaseType = objYoungTAppraisedCaseEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conYoungTAppraisedCase.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdCaseType); //案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdDiscipline))
 {
 if (objYoungTAppraisedCaseEN.IdDiscipline !=  null)
 {
 var strIdDiscipline = objYoungTAppraisedCaseEN.IdDiscipline.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDiscipline, conYoungTAppraisedCase.IdDiscipline); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdDiscipline); //学科流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.BrowseCount))
 {
 if (objYoungTAppraisedCaseEN.BrowseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objYoungTAppraisedCaseEN.BrowseCount, conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.BrowseCount); //浏览次数
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdSenateGaugeVersion))
 {
 if (objYoungTAppraisedCaseEN.IdSenateGaugeVersion !=  null)
 {
 var strIdSenateGaugeVersion = objYoungTAppraisedCaseEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSenateGaugeVersion, conYoungTAppraisedCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdSenateGaugeVersion); //评价量表版本流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdTeachSkill))
 {
 if (objYoungTAppraisedCaseEN.IdTeachSkill !=  null)
 {
 var strIdTeachSkill = objYoungTAppraisedCaseEN.IdTeachSkill.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeachSkill, conYoungTAppraisedCase.IdTeachSkill); //教学技能流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdTeachSkill); //教学技能流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.CaseLevelId))
 {
 if (objYoungTAppraisedCaseEN.CaseLevelId !=  null)
 {
 var strCaseLevelId = objYoungTAppraisedCaseEN.CaseLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseLevelId, conYoungTAppraisedCase.CaseLevelId); //课例等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.CaseLevelId); //课例等级Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.DocFile))
 {
 if (objYoungTAppraisedCaseEN.DocFile !=  null)
 {
 var strDocFile = objYoungTAppraisedCaseEN.DocFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocFile, conYoungTAppraisedCase.DocFile); //生成的Word文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.DocFile); //生成的Word文件名
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsNeedGeneWord))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsNeedGeneWord == true?"1":"0", conYoungTAppraisedCase.IsNeedGeneWord); //是否需要生成Word
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.WordCreateDate))
 {
 if (objYoungTAppraisedCaseEN.WordCreateDate !=  null)
 {
 var strWordCreateDate = objYoungTAppraisedCaseEN.WordCreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordCreateDate, conYoungTAppraisedCase.WordCreateDate); //Word生成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.WordCreateDate); //Word生成日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsVisible))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsVisible == true?"1":"0", conYoungTAppraisedCase.IsVisible); //是否显示
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.OwnerId))
 {
 if (objYoungTAppraisedCaseEN.OwnerId !=  null)
 {
 var strOwnerId = objYoungTAppraisedCaseEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conYoungTAppraisedCase.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.OwnerId); //拥有者Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IsDualVideo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objYoungTAppraisedCaseEN.IsDualVideo == true?"1":"0", conYoungTAppraisedCase.IsDualVideo); //是否双视频
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.IdYoungTAppraisedCaseType))
 {
 if (objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType !=  null)
 {
 var strIdYoungTAppraisedCaseType = objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdYoungTAppraisedCaseType, conYoungTAppraisedCase.IdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.IdYoungTAppraisedCaseType); //青教案例类型流水号
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UserTypeId))
 {
 if (objYoungTAppraisedCaseEN.UserTypeId !=  null)
 {
 var strUserTypeId = objYoungTAppraisedCaseEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conYoungTAppraisedCase.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UserTypeId); //用户类型Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.RecommendedDegreeId))
 {
 if (objYoungTAppraisedCaseEN.RecommendedDegreeId !=  null)
 {
 var strRecommendedDegreeId = objYoungTAppraisedCaseEN.RecommendedDegreeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedDegreeId, conYoungTAppraisedCase.RecommendedDegreeId); //推荐度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.RecommendedDegreeId); //推荐度Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ftpFileType))
 {
 if (objYoungTAppraisedCaseEN.ftpFileType !=  null)
 {
 var strftpFileType = objYoungTAppraisedCaseEN.ftpFileType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strftpFileType, conYoungTAppraisedCase.ftpFileType); //ftp文件类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.ftpFileType); //ftp文件类型
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoUrl))
 {
 if (objYoungTAppraisedCaseEN.VideoUrl !=  null)
 {
 var strVideoUrl = objYoungTAppraisedCaseEN.VideoUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoUrl, conYoungTAppraisedCase.VideoUrl); //视频Url
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.VideoUrl); //视频Url
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.VideoPath))
 {
 if (objYoungTAppraisedCaseEN.VideoPath !=  null)
 {
 var strVideoPath = objYoungTAppraisedCaseEN.VideoPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVideoPath, conYoungTAppraisedCase.VideoPath); //视频目录
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.VideoPath); //视频目录
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.ResErrMsg))
 {
 if (objYoungTAppraisedCaseEN.ResErrMsg !=  null)
 {
 var strResErrMsg = objYoungTAppraisedCaseEN.ResErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResErrMsg, conYoungTAppraisedCase.ResErrMsg); //资源错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.ResErrMsg); //资源错误信息
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdUserId))
 {
 if (objYoungTAppraisedCaseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objYoungTAppraisedCaseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conYoungTAppraisedCase.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UpdUserId); //修改用户Id
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.UpdDate))
 {
 if (objYoungTAppraisedCaseEN.UpdDate !=  null)
 {
 var strUpdDate = objYoungTAppraisedCaseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conYoungTAppraisedCase.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.UpdDate); //修改日期
 }
 }
 
 if (objYoungTAppraisedCaseEN.IsUpdated(conYoungTAppraisedCase.Memo))
 {
 if (objYoungTAppraisedCaseEN.Memo !=  null)
 {
 var strMemo = objYoungTAppraisedCaseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conYoungTAppraisedCase.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conYoungTAppraisedCase.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdYoungTAppraisedCase = '{0}'", objYoungTAppraisedCaseEN.IdYoungTAppraisedCase); 
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
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdYoungTAppraisedCase) 
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdYoungTAppraisedCase,
};
 objSQL.ExecSP("YoungTAppraisedCase_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdYoungTAppraisedCase, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
//删除YoungTAppraisedCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from YoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelYoungTAppraisedCase(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
//删除YoungTAppraisedCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from YoungTAppraisedCase where IdYoungTAppraisedCase in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdYoungTAppraisedCase) 
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
//删除YoungTAppraisedCase本表中与当前对象有关的记录
strSQL = strSQL + "Delete from YoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelYoungTAppraisedCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: DelYoungTAppraisedCase)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from YoungTAppraisedCase where " + strCondition ;
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
public bool DelYoungTAppraisedCaseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsYoungTAppraisedCaseDA: DelYoungTAppraisedCaseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from YoungTAppraisedCase where " + strCondition ;
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
 /// <param name = "objYoungTAppraisedCaseENS">源对象</param>
 /// <param name = "objYoungTAppraisedCaseENT">目标对象</param>
public void CopyTo(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseENS, clsYoungTAppraisedCaseEN objYoungTAppraisedCaseENT)
{
objYoungTAppraisedCaseENT.IdYoungTAppraisedCase = objYoungTAppraisedCaseENS.IdYoungTAppraisedCase; //青教评优案例流水号
objYoungTAppraisedCaseENT.YoungTAppraisedCaseID = objYoungTAppraisedCaseENS.YoungTAppraisedCaseID; //青教评优案例ID
objYoungTAppraisedCaseENT.YoungTAppraisedCaseName = objYoungTAppraisedCaseENS.YoungTAppraisedCaseName; //青教评优案例名称
objYoungTAppraisedCaseENT.YoungTAppraisedCaseText = objYoungTAppraisedCaseENS.YoungTAppraisedCaseText; //案例文本内容
objYoungTAppraisedCaseENT.YoungTAppraisedCaseDate = objYoungTAppraisedCaseENS.YoungTAppraisedCaseDate; //青教评优教学日期
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTime = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTime; //青教评优教学时间
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTheme = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objYoungTAppraisedCaseENT.YoungTAppraisedCaseDateIn = objYoungTAppraisedCaseENS.YoungTAppraisedCaseDateIn; //案例入库日期
objYoungTAppraisedCaseENT.YoungTAppraisedCaseTimeIn = objYoungTAppraisedCaseENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objYoungTAppraisedCaseENT.IdStudyLevel = objYoungTAppraisedCaseENS.IdStudyLevel; //学段流水号
objYoungTAppraisedCaseENT.IdTeachingPlan = objYoungTAppraisedCaseENS.IdTeachingPlan; //教案流水号
objYoungTAppraisedCaseENT.IdCaseType = objYoungTAppraisedCaseENS.IdCaseType; //案例类型流水号
objYoungTAppraisedCaseENT.IdDiscipline = objYoungTAppraisedCaseENS.IdDiscipline; //学科流水号
objYoungTAppraisedCaseENT.BrowseCount = objYoungTAppraisedCaseENS.BrowseCount; //浏览次数
objYoungTAppraisedCaseENT.IdSenateGaugeVersion = objYoungTAppraisedCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objYoungTAppraisedCaseENT.IdTeachSkill = objYoungTAppraisedCaseENS.IdTeachSkill; //教学技能流水号
objYoungTAppraisedCaseENT.CaseLevelId = objYoungTAppraisedCaseENS.CaseLevelId; //课例等级Id
objYoungTAppraisedCaseENT.DocFile = objYoungTAppraisedCaseENS.DocFile; //生成的Word文件名
objYoungTAppraisedCaseENT.IsNeedGeneWord = objYoungTAppraisedCaseENS.IsNeedGeneWord; //是否需要生成Word
objYoungTAppraisedCaseENT.WordCreateDate = objYoungTAppraisedCaseENS.WordCreateDate; //Word生成日期
objYoungTAppraisedCaseENT.IsVisible = objYoungTAppraisedCaseENS.IsVisible; //是否显示
objYoungTAppraisedCaseENT.OwnerId = objYoungTAppraisedCaseENS.OwnerId; //拥有者Id
objYoungTAppraisedCaseENT.IsDualVideo = objYoungTAppraisedCaseENS.IsDualVideo; //是否双视频
objYoungTAppraisedCaseENT.IdYoungTAppraisedCaseType = objYoungTAppraisedCaseENS.IdYoungTAppraisedCaseType; //青教案例类型流水号
objYoungTAppraisedCaseENT.UserTypeId = objYoungTAppraisedCaseENS.UserTypeId; //用户类型Id
objYoungTAppraisedCaseENT.RecommendedDegreeId = objYoungTAppraisedCaseENS.RecommendedDegreeId; //推荐度Id
objYoungTAppraisedCaseENT.ftpFileType = objYoungTAppraisedCaseENS.ftpFileType; //ftp文件类型
objYoungTAppraisedCaseENT.VideoUrl = objYoungTAppraisedCaseENS.VideoUrl; //视频Url
objYoungTAppraisedCaseENT.VideoPath = objYoungTAppraisedCaseENS.VideoPath; //视频目录
objYoungTAppraisedCaseENT.ResErrMsg = objYoungTAppraisedCaseENS.ResErrMsg; //资源错误信息
objYoungTAppraisedCaseENT.UpdUserId = objYoungTAppraisedCaseENS.UpdUserId; //修改用户Id
objYoungTAppraisedCaseENT.UpdDate = objYoungTAppraisedCaseENS.UpdDate; //修改日期
objYoungTAppraisedCaseENT.Memo = objYoungTAppraisedCaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.IdStudyLevel, conYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.IdDiscipline, conYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.IdTeachSkill, conYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.OwnerId, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.IsDualVideo, conYoungTAppraisedCase.IsDualVideo);
clsCheckSql.CheckFieldNotNull(objYoungTAppraisedCaseEN.RecommendedDegreeId, conYoungTAppraisedCase.RecommendedDegreeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdYoungTAppraisedCase, 8, conYoungTAppraisedCase.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID, 8, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName, 100, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseText, 8000, conYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, 200, conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdStudyLevel, 4, conYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachingPlan, 8, conYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdCaseType, 4, conYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdDiscipline, 4, conYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdSenateGaugeVersion, 4, conYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachSkill, 8, conYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.CaseLevelId, 2, conYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.DocFile, 200, conYoungTAppraisedCase.DocFile);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.WordCreateDate, 14, conYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.OwnerId, 20, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, 4, conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UserTypeId, 2, conYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.RecommendedDegreeId, 2, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ftpFileType, 30, conYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoUrl, 1000, conYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoPath, 1000, conYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ResErrMsg, 30, conYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdUserId, 20, conYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdDate, 20, conYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.Memo, 1000, conYoungTAppraisedCase.Memo);
//检查字段外键固定长度
 objYoungTAppraisedCaseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID, 8, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName, 100, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseText, 8000, conYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, 200, conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdStudyLevel, 4, conYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachingPlan, 8, conYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdCaseType, 4, conYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdDiscipline, 4, conYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdSenateGaugeVersion, 4, conYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachSkill, 8, conYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.CaseLevelId, 2, conYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.DocFile, 200, conYoungTAppraisedCase.DocFile);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.WordCreateDate, 14, conYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.OwnerId, 20, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, 4, conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UserTypeId, 2, conYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.RecommendedDegreeId, 2, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ftpFileType, 30, conYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoUrl, 1000, conYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoPath, 1000, conYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ResErrMsg, 30, conYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdUserId, 20, conYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdDate, 20, conYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.Memo, 1000, conYoungTAppraisedCase.Memo);
//检查外键字段长度
 objYoungTAppraisedCaseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsYoungTAppraisedCaseEN objYoungTAppraisedCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdYoungTAppraisedCase, 8, conYoungTAppraisedCase.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID, 8, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName, 100, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseText, 8000, conYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, 200, conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, 8, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, 6, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdStudyLevel, 4, conYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachingPlan, 8, conYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdCaseType, 4, conYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdDiscipline, 4, conYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdSenateGaugeVersion, 4, conYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdTeachSkill, 8, conYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.CaseLevelId, 2, conYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.DocFile, 200, conYoungTAppraisedCase.DocFile);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.WordCreateDate, 14, conYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.OwnerId, 20, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, 4, conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UserTypeId, 2, conYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.RecommendedDegreeId, 2, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ftpFileType, 30, conYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoUrl, 1000, conYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.VideoPath, 1000, conYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.ResErrMsg, 30, conYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdUserId, 20, conYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.UpdDate, 20, conYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckFieldLen(objYoungTAppraisedCaseEN.Memo, 1000, conYoungTAppraisedCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdYoungTAppraisedCase, conYoungTAppraisedCase.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseID, conYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseName, conYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseText, conYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, conYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, conYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, conYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, conYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, conYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdStudyLevel, conYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdTeachingPlan, conYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdCaseType, conYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdDiscipline, conYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdSenateGaugeVersion, conYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdTeachSkill, conYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.CaseLevelId, conYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.DocFile, conYoungTAppraisedCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.WordCreateDate, conYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.OwnerId, conYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, conYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.UserTypeId, conYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.RecommendedDegreeId, conYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.ftpFileType, conYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.VideoUrl, conYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.VideoPath, conYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.ResErrMsg, conYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.UpdUserId, conYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.UpdDate, conYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objYoungTAppraisedCaseEN.Memo, conYoungTAppraisedCase.Memo);
//检查外键字段长度
 objYoungTAppraisedCaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdYoungTAppraisedCase()
{
//获取某学院所有专业信息
string strSQL = "select IdYoungTAppraisedCase, YoungTAppraisedCaseName from YoungTAppraisedCase ";
 clsSpecSQLforSql mySql = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsYoungTAppraisedCaseEN._CurrTabName);
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsYoungTAppraisedCaseEN._CurrTabName, strCondition);
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsYoungTAppraisedCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}