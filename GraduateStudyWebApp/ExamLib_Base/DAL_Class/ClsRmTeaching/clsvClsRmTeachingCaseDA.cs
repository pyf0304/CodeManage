
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseDA
 表名:vClsRmTeachingCase(01120382)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学(ClsRmTeaching)
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
 /// v课堂教学案例(vClsRmTeachingCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClsRmTeachingCaseDA : clsCommBase4DA
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
 return clsvClsRmTeachingCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClsRmTeachingCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vClsRmTeachingCase中,检查关键字,长度不正确!(clsvClsRmTeachingCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdClsRmTeachingCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vClsRmTeachingCase中,关键字不能为空 或 null!(clsvClsRmTeachingCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdClsRmTeachingCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvClsRmTeachingCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClsRmTeachingCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable_vClsRmTeachingCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCase.* from vClsRmTeachingCase Left Join {1} on {2} where {3} and vClsRmTeachingCase.IdClsRmTeachingCase not in (Select top {5} vClsRmTeachingCase.IdClsRmTeachingCase from vClsRmTeachingCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from vClsRmTeachingCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from vClsRmTeachingCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCase.* from vClsRmTeachingCase Left Join {1} on {2} where {3} and vClsRmTeachingCase.IdClsRmTeachingCase not in (Select top {5} vClsRmTeachingCase.IdClsRmTeachingCase from vClsRmTeachingCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {2} IdClsRmTeachingCase from vClsRmTeachingCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCase where {1} and IdClsRmTeachingCase not in (Select top {3} IdClsRmTeachingCase from vClsRmTeachingCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClsRmTeachingCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA:GetObjLst)", objException.Message));
}
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseEN);
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
public List<clsvClsRmTeachingCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClsRmTeachingCaseEN> arrObjLst = new List<clsvClsRmTeachingCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClsRmTeachingCase(ref clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ objvClsRmTeachingCaseEN.IdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objDT.Rows[0][convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objDT.Rows[0][convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objDT.Rows[0][convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.IdStudyLevel = objDT.Rows[0][convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.StudyLevelName = objDT.Rows[0][convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdTeachingPlan = objDT.Rows[0][convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.IdCaseType = objDT.Rows[0][convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdDiscipline = objDT.Rows[0][convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.DisciplineID = objDT.Rows[0][convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.IdSchoolPs = objDT.Rows[0][convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.SchoolId = objDT.Rows[0][convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCaseEN.SchoolName = objDT.Rows[0][convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.IdDisciplinePs = objDT.Rows[0][convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.DisciplineName = objDT.Rows[0][convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdGradeBase = objDT.Rows[0][convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.senateGaugeVersionID = objDT.Rows[0][convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.senateGaugeVersionName = objDT.Rows[0][convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdTeachSkill = objDT.Rows[0][convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillID = objDT.Rows[0][convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.SkillTypeName = objDT.Rows[0][convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillName = objDT.Rows[0][convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillTheory = objDT.Rows[0][convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCaseEN.TeachSkillOperMethod = objDT.Rows[0][convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCaseEN.IdSkillType = objDT.Rows[0][convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.SkillTypeID = objDT.Rows[0][convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.CaseLevelId = objDT.Rows[0][convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseEN.CaseLevelName = objDT.Rows[0][convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.DocFile = objDT.Rows[0][convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseEN.WordCreateDate = objDT.Rows[0][convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvClsRmTeachingCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerId = objDT.Rows[0][convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseEN.IdStudentInfo = objDT.Rows[0][convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.StuName = objDT.Rows[0][convClsRmTeachingCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.StuId = objDT.Rows[0][convClsRmTeachingCase.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.PoliticsName = objDT.Rows[0][convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.SexDesc = objDT.Rows[0][convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCaseEN.EthnicName = objDT.Rows[0][convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.UniZoneDesc = objDT.Rows[0][convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseEN.StuTypeDesc = objDT.Rows[0][convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdXzCollege = objDT.Rows[0][convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.CollegeId = objDT.Rows[0][convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.CollegeName = objDT.Rows[0][convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.CollegeNameA = objDT.Rows[0][convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCaseEN.IdXzMajor = objDT.Rows[0][convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.MajorName = objDT.Rows[0][convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.GradeBaseName = objDT.Rows[0][convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdAdminCls = objDT.Rows[0][convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.AdminClsId = objDT.Rows[0][convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.AdminClsName = objDT.Rows[0][convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvClsRmTeachingCaseEN.Birthday = objDT.Rows[0][convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.NativePlace = objDT.Rows[0][convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.Duty = objDT.Rows[0][convClsRmTeachingCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.IdCardNo = objDT.Rows[0][convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.StuCardNo = objDT.Rows[0][convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.LiveAddress = objDT.Rows[0][convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.HomePhone = objDT.Rows[0][convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.EnrollmentDate = objDT.Rows[0][convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.PostCode = objDT.Rows[0][convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.UserKindId = objDT.Rows[0][convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseEN.UserKindName = objDT.Rows[0][convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.UserTypeId = objDT.Rows[0][convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseEN.UserTypeName = objDT.Rows[0][convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCaseEN.RecommendedDegreeId = objDT.Rows[0][convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseEN.RecommendedDegreeName = objDT.Rows[0][convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.Memo = objDT.Rows[0][convClsRmTeachingCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCaseEN.DisciplineNamePs = objDT.Rows[0][convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.GradeNamePs = objDT.Rows[0][convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.IdGradePs = objDT.Rows[0][convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerName = objDT.Rows[0][convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerNameWithId = objDT.Rows[0][convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IsHaveVideo = objDT.Rows[0][convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.ftpFileType = objDT.Rows[0][convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetvClsRmTeachingCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdClsRmTeachingCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvClsRmTeachingCaseEN GetObjByIdClsRmTeachingCase(string strIdClsRmTeachingCase)
{
CheckPrimaryKey(strIdClsRmTeachingCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
 objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvClsRmTeachingCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetObjByIdClsRmTeachingCase)", objException.Message));
}
return objvClsRmTeachingCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClsRmTeachingCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN()
{
IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(), //课堂教学案例流水号
ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(), //课堂教学案例ID
ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(), //课堂教学案例名称
ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(), //课堂教学案例主题词
IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(), //课堂案例类型流水号
ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(), //课堂案例类型名称
ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(), //案例文本内容
ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(), //课堂教学日期
ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(), //课堂教学时间
ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(), //案例入库日期
ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(), //学科ID
IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(), //学校流水号
SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(), //学校名称
IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(), //学科流水号
DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(), //学科名称
IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(), //年级流水号
IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(), //学生流水号
StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(), //姓名
StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(), //学号
PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(), //政治面貌
SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(), //性别名称
EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(), //民族名称
UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(), //校区名称
StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(), //专业名称
GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(), //年级名称
IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(), //行政班流水号
AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(), //行政班代号
AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(), //行政班名称
Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(), //职位
IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(), //住宅电话
EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(), //邮编
UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(), //用户类型名称
IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(), //备注
DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(), //学科
GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(), //年级
IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(), //年级流水号
OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(), //IsHaveVideo
ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim() //ftp文件类型
};
objvClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetObjByDataRowvClsRmTeachingCase)", objException.Message));
}
objvClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN = new clsvClsRmTeachingCaseEN();
try
{
objvClsRmTeachingCaseEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCase.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCase.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType = objRow[convClsRmTeachingCase.IdClsRmTeachingCaseType].ToString().Trim(); //课堂案例类型流水号
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseEN.ClsRmTeachingCaseText = objRow[convClsRmTeachingCase.ClsRmTeachingCaseText] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseText].ToString().Trim(); //案例文本内容
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseEN.IdStudyLevel = objRow[convClsRmTeachingCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvClsRmTeachingCaseEN.StudyLevelName = objRow[convClsRmTeachingCase.StudyLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StudyLevelName].ToString().Trim(); //学段名称
objvClsRmTeachingCaseEN.IdTeachingPlan = objRow[convClsRmTeachingCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvClsRmTeachingCaseEN.IdCaseType = objRow[convClsRmTeachingCase.IdCaseType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvClsRmTeachingCaseEN.IdDiscipline = objRow[convClsRmTeachingCase.IdDiscipline].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineID = objRow[convClsRmTeachingCase.DisciplineID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineID].ToString().Trim(); //学科ID
objvClsRmTeachingCaseEN.IdSchoolPs = objRow[convClsRmTeachingCase.IdSchoolPs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSchoolPs].ToString().Trim(); //学校流水号
objvClsRmTeachingCaseEN.SchoolId = objRow[convClsRmTeachingCase.SchoolId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolId].ToString().Trim(); //学校编号
objvClsRmTeachingCaseEN.SchoolName = objRow[convClsRmTeachingCase.SchoolName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SchoolName].ToString().Trim(); //学校名称
objvClsRmTeachingCaseEN.IdDisciplinePs = objRow[convClsRmTeachingCase.IdDisciplinePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdDisciplinePs].ToString().Trim(); //学科流水号
objvClsRmTeachingCaseEN.DisciplineName = objRow[convClsRmTeachingCase.DisciplineName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineName].ToString().Trim(); //学科名称
objvClsRmTeachingCaseEN.IdGradeBase = objRow[convClsRmTeachingCase.IdGradeBase] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradeBase].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseEN.senateGaugeVersionID = objRow[convClsRmTeachingCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseEN.senateGaugeVersionName = objRow[convClsRmTeachingCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseEN.VersionNo = objRow[convClsRmTeachingCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.VersionNo].ToString().Trim()); //版本号
objvClsRmTeachingCaseEN.IdTeachSkill = objRow[convClsRmTeachingCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvClsRmTeachingCaseEN.TeachSkillID = objRow[convClsRmTeachingCase.TeachSkillID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvClsRmTeachingCaseEN.SkillTypeName = objRow[convClsRmTeachingCase.SkillTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvClsRmTeachingCaseEN.TeachSkillName = objRow[convClsRmTeachingCase.TeachSkillName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvClsRmTeachingCaseEN.TeachSkillTheory = objRow[convClsRmTeachingCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvClsRmTeachingCaseEN.TeachSkillOperMethod = objRow[convClsRmTeachingCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convClsRmTeachingCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvClsRmTeachingCaseEN.IdSkillType = objRow[convClsRmTeachingCase.IdSkillType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvClsRmTeachingCaseEN.SkillTypeID = objRow[convClsRmTeachingCase.SkillTypeID] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvClsRmTeachingCaseEN.CaseLevelId = objRow[convClsRmTeachingCase.CaseLevelId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvClsRmTeachingCaseEN.CaseLevelName = objRow[convClsRmTeachingCase.CaseLevelName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvClsRmTeachingCaseEN.DocFile = objRow[convClsRmTeachingCase.DocFile] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DocFile].ToString().Trim(); //生成的Word文件名
objvClsRmTeachingCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convClsRmTeachingCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvClsRmTeachingCaseEN.WordCreateDate = objRow[convClsRmTeachingCase.WordCreateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvClsRmTeachingCaseEN.IsVisible = TransNullToBool(objRow[convClsRmTeachingCase.IsVisible].ToString().Trim()); //是否显示
objvClsRmTeachingCaseEN.OwnerId = objRow[convClsRmTeachingCase.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseEN.IdStudentInfo = objRow[convClsRmTeachingCase.IdStudentInfo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdStudentInfo].ToString().Trim(); //学生流水号
objvClsRmTeachingCaseEN.StuName = objRow[convClsRmTeachingCase.StuName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuName].ToString().Trim(); //姓名
objvClsRmTeachingCaseEN.StuId = objRow[convClsRmTeachingCase.StuId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuId].ToString().Trim(); //学号
objvClsRmTeachingCaseEN.PoliticsName = objRow[convClsRmTeachingCase.PoliticsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PoliticsName].ToString().Trim(); //政治面貌
objvClsRmTeachingCaseEN.SexDesc = objRow[convClsRmTeachingCase.SexDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.SexDesc].ToString().Trim(); //性别名称
objvClsRmTeachingCaseEN.EthnicName = objRow[convClsRmTeachingCase.EthnicName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EthnicName].ToString().Trim(); //民族名称
objvClsRmTeachingCaseEN.UniZoneDesc = objRow[convClsRmTeachingCase.UniZoneDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UniZoneDesc].ToString().Trim(); //校区名称
objvClsRmTeachingCaseEN.StuTypeDesc = objRow[convClsRmTeachingCase.StuTypeDesc] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuTypeDesc].ToString().Trim(); //学生类别名称
objvClsRmTeachingCaseEN.IdXzCollege = objRow[convClsRmTeachingCase.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseEN.CollegeId = objRow[convClsRmTeachingCase.CollegeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeId].ToString().Trim(); //学院ID
objvClsRmTeachingCaseEN.CollegeName = objRow[convClsRmTeachingCase.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseEN.CollegeNameA = objRow[convClsRmTeachingCase.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseEN.IdXzMajor = objRow[convClsRmTeachingCase.IdXzMajor] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdXzMajor].ToString().Trim(); //专业流水号
objvClsRmTeachingCaseEN.MajorName = objRow[convClsRmTeachingCase.MajorName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.MajorName].ToString().Trim(); //专业名称
objvClsRmTeachingCaseEN.GradeBaseName = objRow[convClsRmTeachingCase.GradeBaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeBaseName].ToString().Trim(); //年级名称
objvClsRmTeachingCaseEN.IdAdminCls = objRow[convClsRmTeachingCase.IdAdminCls] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdAdminCls].ToString().Trim(); //行政班流水号
objvClsRmTeachingCaseEN.AdminClsId = objRow[convClsRmTeachingCase.AdminClsId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsId].ToString().Trim(); //行政班代号
objvClsRmTeachingCaseEN.AdminClsName = objRow[convClsRmTeachingCase.AdminClsName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.AdminClsName].ToString().Trim(); //行政班名称
objvClsRmTeachingCaseEN.Birthday = objRow[convClsRmTeachingCase.Birthday] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Birthday].ToString().Trim(); //出生日期
objvClsRmTeachingCaseEN.NativePlace = objRow[convClsRmTeachingCase.NativePlace] == DBNull.Value ? null : objRow[convClsRmTeachingCase.NativePlace].ToString().Trim(); //籍贯
objvClsRmTeachingCaseEN.Duty = objRow[convClsRmTeachingCase.Duty] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Duty].ToString().Trim(); //职位
objvClsRmTeachingCaseEN.IdCardNo = objRow[convClsRmTeachingCase.IdCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdCardNo].ToString().Trim(); //身份证号
objvClsRmTeachingCaseEN.StuCardNo = objRow[convClsRmTeachingCase.StuCardNo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.StuCardNo].ToString().Trim(); //学生证号
objvClsRmTeachingCaseEN.LiveAddress = objRow[convClsRmTeachingCase.LiveAddress] == DBNull.Value ? null : objRow[convClsRmTeachingCase.LiveAddress].ToString().Trim(); //居住地址
objvClsRmTeachingCaseEN.HomePhone = objRow[convClsRmTeachingCase.HomePhone] == DBNull.Value ? null : objRow[convClsRmTeachingCase.HomePhone].ToString().Trim(); //住宅电话
objvClsRmTeachingCaseEN.EnrollmentDate = objRow[convClsRmTeachingCase.EnrollmentDate] == DBNull.Value ? null : objRow[convClsRmTeachingCase.EnrollmentDate].ToString().Trim(); //入校日期
objvClsRmTeachingCaseEN.PostCode = objRow[convClsRmTeachingCase.PostCode] == DBNull.Value ? null : objRow[convClsRmTeachingCase.PostCode].ToString().Trim(); //邮编
objvClsRmTeachingCaseEN.UserKindId = objRow[convClsRmTeachingCase.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseEN.UserKindName = objRow[convClsRmTeachingCase.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseEN.UserTypeId = objRow[convClsRmTeachingCase.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseEN.UserTypeName = objRow[convClsRmTeachingCase.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.UserTypeName].ToString().Trim(); //用户类型名称
objvClsRmTeachingCaseEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCase.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseEN.RecommendedDegreeId = objRow[convClsRmTeachingCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvClsRmTeachingCaseEN.RecommendedDegreeName = objRow[convClsRmTeachingCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvClsRmTeachingCaseEN.Memo = objRow[convClsRmTeachingCase.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCase.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseEN.DisciplineNamePs = objRow[convClsRmTeachingCase.DisciplineNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.DisciplineNamePs].ToString().Trim(); //学科
objvClsRmTeachingCaseEN.GradeNamePs = objRow[convClsRmTeachingCase.GradeNamePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.GradeNamePs].ToString().Trim(); //年级
objvClsRmTeachingCaseEN.IdGradePs = objRow[convClsRmTeachingCase.IdGradePs] == DBNull.Value ? null : objRow[convClsRmTeachingCase.IdGradePs].ToString().Trim(); //年级流水号
objvClsRmTeachingCaseEN.OwnerName = objRow[convClsRmTeachingCase.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseEN.OwnerNameWithId = objRow[convClsRmTeachingCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseEN.BrowseCount4Case = objRow[convClsRmTeachingCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvClsRmTeachingCaseEN.IsHaveVideo = objRow[convClsRmTeachingCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
objvClsRmTeachingCaseEN.ftpFileType = objRow[convClsRmTeachingCase.ftpFileType] == DBNull.Value ? null : objRow[convClsRmTeachingCase.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseDA: GetObjByDataRow)", objException.Message));
}
objvClsRmTeachingCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseEN;
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
objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseEN._CurrTabName, convClsRmTeachingCase.IdClsRmTeachingCase, 8, "");
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
objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseEN._CurrTabName, convClsRmTeachingCase.IdClsRmTeachingCase, 8, strPrefix);
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from vClsRmTeachingCase where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdClsRmTeachingCase from vClsRmTeachingCase where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCase", "IdClsRmTeachingCase = " + "'"+ strIdClsRmTeachingCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCase", strCondition))
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
objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClsRmTeachingCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseENT">目标对象</param>
public void CopyTo(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENS, clsvClsRmTeachingCaseEN objvClsRmTeachingCaseENT)
{
objvClsRmTeachingCaseENT.IdClsRmTeachingCase = objvClsRmTeachingCaseENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseENT.IdClsRmTeachingCaseType = objvClsRmTeachingCaseENS.IdClsRmTeachingCaseType; //课堂案例类型流水号
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseENT.ClsRmTeachingCaseText = objvClsRmTeachingCaseENS.ClsRmTeachingCaseText; //案例文本内容
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseENT.IdStudyLevel = objvClsRmTeachingCaseENS.IdStudyLevel; //id_StudyLevel
objvClsRmTeachingCaseENT.StudyLevelName = objvClsRmTeachingCaseENS.StudyLevelName; //学段名称
objvClsRmTeachingCaseENT.IdTeachingPlan = objvClsRmTeachingCaseENS.IdTeachingPlan; //教案流水号
objvClsRmTeachingCaseENT.IdCaseType = objvClsRmTeachingCaseENS.IdCaseType; //案例类型流水号
objvClsRmTeachingCaseENT.IdDiscipline = objvClsRmTeachingCaseENS.IdDiscipline; //学科流水号
objvClsRmTeachingCaseENT.DisciplineID = objvClsRmTeachingCaseENS.DisciplineID; //学科ID
objvClsRmTeachingCaseENT.IdSchoolPs = objvClsRmTeachingCaseENS.IdSchoolPs; //学校流水号
objvClsRmTeachingCaseENT.SchoolId = objvClsRmTeachingCaseENS.SchoolId; //学校编号
objvClsRmTeachingCaseENT.SchoolName = objvClsRmTeachingCaseENS.SchoolName; //学校名称
objvClsRmTeachingCaseENT.IdDisciplinePs = objvClsRmTeachingCaseENS.IdDisciplinePs; //学科流水号
objvClsRmTeachingCaseENT.DisciplineName = objvClsRmTeachingCaseENS.DisciplineName; //学科名称
objvClsRmTeachingCaseENT.IdGradeBase = objvClsRmTeachingCaseENS.IdGradeBase; //年级流水号
objvClsRmTeachingCaseENT.IdSenateGaugeVersion = objvClsRmTeachingCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseENT.senateGaugeVersionID = objvClsRmTeachingCaseENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseENT.senateGaugeVersionName = objvClsRmTeachingCaseENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseENT.VersionNo = objvClsRmTeachingCaseENS.VersionNo; //版本号
objvClsRmTeachingCaseENT.IdTeachSkill = objvClsRmTeachingCaseENS.IdTeachSkill; //教学技能流水号
objvClsRmTeachingCaseENT.TeachSkillID = objvClsRmTeachingCaseENS.TeachSkillID; //教学技能ID
objvClsRmTeachingCaseENT.SkillTypeName = objvClsRmTeachingCaseENS.SkillTypeName; //技能类型名称
objvClsRmTeachingCaseENT.TeachSkillName = objvClsRmTeachingCaseENS.TeachSkillName; //教学技能名称
objvClsRmTeachingCaseENT.TeachSkillTheory = objvClsRmTeachingCaseENS.TeachSkillTheory; //教学技能理论阐述
objvClsRmTeachingCaseENT.TeachSkillOperMethod = objvClsRmTeachingCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvClsRmTeachingCaseENT.IdSkillType = objvClsRmTeachingCaseENS.IdSkillType; //技能类型流水号
objvClsRmTeachingCaseENT.SkillTypeID = objvClsRmTeachingCaseENS.SkillTypeID; //技能类型ID
objvClsRmTeachingCaseENT.CaseLevelId = objvClsRmTeachingCaseENS.CaseLevelId; //课例等级Id
objvClsRmTeachingCaseENT.CaseLevelName = objvClsRmTeachingCaseENS.CaseLevelName; //案例等级名称
objvClsRmTeachingCaseENT.DocFile = objvClsRmTeachingCaseENS.DocFile; //生成的Word文件名
objvClsRmTeachingCaseENT.IsNeedGeneWord = objvClsRmTeachingCaseENS.IsNeedGeneWord; //是否需要生成Word
objvClsRmTeachingCaseENT.WordCreateDate = objvClsRmTeachingCaseENS.WordCreateDate; //Word生成日期
objvClsRmTeachingCaseENT.IsVisible = objvClsRmTeachingCaseENS.IsVisible; //是否显示
objvClsRmTeachingCaseENT.OwnerId = objvClsRmTeachingCaseENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseENT.IdStudentInfo = objvClsRmTeachingCaseENS.IdStudentInfo; //学生流水号
objvClsRmTeachingCaseENT.StuName = objvClsRmTeachingCaseENS.StuName; //姓名
objvClsRmTeachingCaseENT.StuId = objvClsRmTeachingCaseENS.StuId; //学号
objvClsRmTeachingCaseENT.PoliticsName = objvClsRmTeachingCaseENS.PoliticsName; //政治面貌
objvClsRmTeachingCaseENT.SexDesc = objvClsRmTeachingCaseENS.SexDesc; //性别名称
objvClsRmTeachingCaseENT.EthnicName = objvClsRmTeachingCaseENS.EthnicName; //民族名称
objvClsRmTeachingCaseENT.UniZoneDesc = objvClsRmTeachingCaseENS.UniZoneDesc; //校区名称
objvClsRmTeachingCaseENT.StuTypeDesc = objvClsRmTeachingCaseENS.StuTypeDesc; //学生类别名称
objvClsRmTeachingCaseENT.IdXzCollege = objvClsRmTeachingCaseENS.IdXzCollege; //学院流水号
objvClsRmTeachingCaseENT.CollegeId = objvClsRmTeachingCaseENS.CollegeId; //学院ID
objvClsRmTeachingCaseENT.CollegeName = objvClsRmTeachingCaseENS.CollegeName; //学院名称
objvClsRmTeachingCaseENT.CollegeNameA = objvClsRmTeachingCaseENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseENT.IdXzMajor = objvClsRmTeachingCaseENS.IdXzMajor; //专业流水号
objvClsRmTeachingCaseENT.MajorName = objvClsRmTeachingCaseENS.MajorName; //专业名称
objvClsRmTeachingCaseENT.GradeBaseName = objvClsRmTeachingCaseENS.GradeBaseName; //年级名称
objvClsRmTeachingCaseENT.IdAdminCls = objvClsRmTeachingCaseENS.IdAdminCls; //行政班流水号
objvClsRmTeachingCaseENT.AdminClsId = objvClsRmTeachingCaseENS.AdminClsId; //行政班代号
objvClsRmTeachingCaseENT.AdminClsName = objvClsRmTeachingCaseENS.AdminClsName; //行政班名称
objvClsRmTeachingCaseENT.Birthday = objvClsRmTeachingCaseENS.Birthday; //出生日期
objvClsRmTeachingCaseENT.NativePlace = objvClsRmTeachingCaseENS.NativePlace; //籍贯
objvClsRmTeachingCaseENT.Duty = objvClsRmTeachingCaseENS.Duty; //职位
objvClsRmTeachingCaseENT.IdCardNo = objvClsRmTeachingCaseENS.IdCardNo; //身份证号
objvClsRmTeachingCaseENT.StuCardNo = objvClsRmTeachingCaseENS.StuCardNo; //学生证号
objvClsRmTeachingCaseENT.LiveAddress = objvClsRmTeachingCaseENS.LiveAddress; //居住地址
objvClsRmTeachingCaseENT.HomePhone = objvClsRmTeachingCaseENS.HomePhone; //住宅电话
objvClsRmTeachingCaseENT.EnrollmentDate = objvClsRmTeachingCaseENS.EnrollmentDate; //入校日期
objvClsRmTeachingCaseENT.PostCode = objvClsRmTeachingCaseENS.PostCode; //邮编
objvClsRmTeachingCaseENT.UserKindId = objvClsRmTeachingCaseENS.UserKindId; //用户类别Id
objvClsRmTeachingCaseENT.UserKindName = objvClsRmTeachingCaseENS.UserKindName; //用户类别名
objvClsRmTeachingCaseENT.UserTypeId = objvClsRmTeachingCaseENS.UserTypeId; //用户类型Id
objvClsRmTeachingCaseENT.UserTypeName = objvClsRmTeachingCaseENS.UserTypeName; //用户类型名称
objvClsRmTeachingCaseENT.IsDualVideo = objvClsRmTeachingCaseENS.IsDualVideo; //是否双视频
objvClsRmTeachingCaseENT.RecommendedDegreeId = objvClsRmTeachingCaseENS.RecommendedDegreeId; //推荐度Id
objvClsRmTeachingCaseENT.RecommendedDegreeName = objvClsRmTeachingCaseENS.RecommendedDegreeName; //推荐度名称
objvClsRmTeachingCaseENT.Memo = objvClsRmTeachingCaseENS.Memo; //备注
objvClsRmTeachingCaseENT.DisciplineNamePs = objvClsRmTeachingCaseENS.DisciplineNamePs; //学科
objvClsRmTeachingCaseENT.GradeNamePs = objvClsRmTeachingCaseENS.GradeNamePs; //年级
objvClsRmTeachingCaseENT.IdGradePs = objvClsRmTeachingCaseENS.IdGradePs; //年级流水号
objvClsRmTeachingCaseENT.OwnerName = objvClsRmTeachingCaseENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseENT.OwnerNameWithId = objvClsRmTeachingCaseENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseENT.BrowseCount4Case = objvClsRmTeachingCaseENS.BrowseCount4Case; //课例浏览次数
objvClsRmTeachingCaseENT.IsHaveVideo = objvClsRmTeachingCaseENS.IsHaveVideo; //IsHaveVideo
objvClsRmTeachingCaseENT.ftpFileType = objvClsRmTeachingCaseENS.ftpFileType; //ftp文件类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClsRmTeachingCaseEN objvClsRmTeachingCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdClsRmTeachingCase, 8, convClsRmTeachingCase.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseID, 8, convClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseName, 100, convClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, 200, convClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType, 4, convClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName, 30, convClsRmTeachingCase.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseText, 8000, convClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate, 8, convClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime, 6, convClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, 8, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdStudyLevel, 4, convClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.StudyLevelName, 50, convClsRmTeachingCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdTeachingPlan, 8, convClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdCaseType, 4, convClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdDiscipline, 4, convClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.DisciplineID, 4, convClsRmTeachingCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdSchoolPs, 4, convClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.SchoolId, 10, convClsRmTeachingCase.SchoolId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.SchoolName, 50, convClsRmTeachingCase.SchoolName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdDisciplinePs, 4, convClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.DisciplineName, 50, convClsRmTeachingCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdGradeBase, 4, convClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdSenateGaugeVersion, 4, convClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.senateGaugeVersionID, 4, convClsRmTeachingCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.senateGaugeVersionName, 200, convClsRmTeachingCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdTeachSkill, 8, convClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.TeachSkillID, 8, convClsRmTeachingCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.SkillTypeName, 50, convClsRmTeachingCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.TeachSkillName, 50, convClsRmTeachingCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.TeachSkillTheory, 8000, convClsRmTeachingCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.TeachSkillOperMethod, 2000, convClsRmTeachingCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdSkillType, 4, convClsRmTeachingCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.SkillTypeID, 4, convClsRmTeachingCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.CaseLevelId, 2, convClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.CaseLevelName, 30, convClsRmTeachingCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.DocFile, 200, convClsRmTeachingCase.DocFile);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.WordCreateDate, 14, convClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.OwnerId, 20, convClsRmTeachingCase.OwnerId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdStudentInfo, 8, convClsRmTeachingCase.IdStudentInfo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.StuName, 50, convClsRmTeachingCase.StuName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.StuId, 20, convClsRmTeachingCase.StuId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.PoliticsName, 30, convClsRmTeachingCase.PoliticsName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.SexDesc, 10, convClsRmTeachingCase.SexDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.EthnicName, 30, convClsRmTeachingCase.EthnicName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.UniZoneDesc, 20, convClsRmTeachingCase.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.StuTypeDesc, 50, convClsRmTeachingCase.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdXzCollege, 4, convClsRmTeachingCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.CollegeId, 4, convClsRmTeachingCase.CollegeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.CollegeName, 100, convClsRmTeachingCase.CollegeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.CollegeNameA, 12, convClsRmTeachingCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdXzMajor, 8, convClsRmTeachingCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.MajorName, 100, convClsRmTeachingCase.MajorName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.GradeBaseName, 50, convClsRmTeachingCase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdAdminCls, 8, convClsRmTeachingCase.IdAdminCls);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.AdminClsId, 8, convClsRmTeachingCase.AdminClsId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.AdminClsName, 100, convClsRmTeachingCase.AdminClsName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.Birthday, 8, convClsRmTeachingCase.Birthday);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.NativePlace, 200, convClsRmTeachingCase.NativePlace);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.Duty, 30, convClsRmTeachingCase.Duty);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdCardNo, 20, convClsRmTeachingCase.IdCardNo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.StuCardNo, 20, convClsRmTeachingCase.StuCardNo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.LiveAddress, 200, convClsRmTeachingCase.LiveAddress);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.HomePhone, 20, convClsRmTeachingCase.HomePhone);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.EnrollmentDate, 8, convClsRmTeachingCase.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.PostCode, 6, convClsRmTeachingCase.PostCode);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.UserKindId, 2, convClsRmTeachingCase.UserKindId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.UserKindName, 30, convClsRmTeachingCase.UserKindName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.UserTypeId, 2, convClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.UserTypeName, 20, convClsRmTeachingCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.RecommendedDegreeId, 2, convClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.RecommendedDegreeName, 30, convClsRmTeachingCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.Memo, 1000, convClsRmTeachingCase.Memo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.DisciplineNamePs, 50, convClsRmTeachingCase.DisciplineNamePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.GradeNamePs, 50, convClsRmTeachingCase.GradeNamePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IdGradePs, 4, convClsRmTeachingCase.IdGradePs);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.OwnerName, 30, convClsRmTeachingCase.OwnerName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.OwnerNameWithId, 51, convClsRmTeachingCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.IsHaveVideo, 6, convClsRmTeachingCase.IsHaveVideo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseEN.ftpFileType, 30, convClsRmTeachingCase.ftpFileType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdClsRmTeachingCase, convClsRmTeachingCase.IdClsRmTeachingCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseID, convClsRmTeachingCase.ClsRmTeachingCaseID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseName, convClsRmTeachingCase.ClsRmTeachingCaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTheme, convClsRmTeachingCase.ClsRmTeachingCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdClsRmTeachingCaseType, convClsRmTeachingCase.IdClsRmTeachingCaseType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTypeName, convClsRmTeachingCase.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseText, convClsRmTeachingCase.ClsRmTeachingCaseText);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseDate, convClsRmTeachingCase.ClsRmTeachingCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTime, convClsRmTeachingCase.ClsRmTeachingCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseDateIn, convClsRmTeachingCase.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ClsRmTeachingCaseTimeIn, convClsRmTeachingCase.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdStudyLevel, convClsRmTeachingCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.StudyLevelName, convClsRmTeachingCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdTeachingPlan, convClsRmTeachingCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdCaseType, convClsRmTeachingCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdDiscipline, convClsRmTeachingCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.DisciplineID, convClsRmTeachingCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdSchoolPs, convClsRmTeachingCase.IdSchoolPs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.SchoolId, convClsRmTeachingCase.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.SchoolName, convClsRmTeachingCase.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdDisciplinePs, convClsRmTeachingCase.IdDisciplinePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.DisciplineName, convClsRmTeachingCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdGradeBase, convClsRmTeachingCase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdSenateGaugeVersion, convClsRmTeachingCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.senateGaugeVersionID, convClsRmTeachingCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.senateGaugeVersionName, convClsRmTeachingCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdTeachSkill, convClsRmTeachingCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.TeachSkillID, convClsRmTeachingCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.SkillTypeName, convClsRmTeachingCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.TeachSkillName, convClsRmTeachingCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.TeachSkillTheory, convClsRmTeachingCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.TeachSkillOperMethod, convClsRmTeachingCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdSkillType, convClsRmTeachingCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.SkillTypeID, convClsRmTeachingCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.CaseLevelId, convClsRmTeachingCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.CaseLevelName, convClsRmTeachingCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.DocFile, convClsRmTeachingCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.WordCreateDate, convClsRmTeachingCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.OwnerId, convClsRmTeachingCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdStudentInfo, convClsRmTeachingCase.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.StuName, convClsRmTeachingCase.StuName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.StuId, convClsRmTeachingCase.StuId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.PoliticsName, convClsRmTeachingCase.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.SexDesc, convClsRmTeachingCase.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.EthnicName, convClsRmTeachingCase.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.UniZoneDesc, convClsRmTeachingCase.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.StuTypeDesc, convClsRmTeachingCase.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdXzCollege, convClsRmTeachingCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.CollegeId, convClsRmTeachingCase.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.CollegeName, convClsRmTeachingCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.CollegeNameA, convClsRmTeachingCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdXzMajor, convClsRmTeachingCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.MajorName, convClsRmTeachingCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.GradeBaseName, convClsRmTeachingCase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdAdminCls, convClsRmTeachingCase.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.AdminClsId, convClsRmTeachingCase.AdminClsId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.AdminClsName, convClsRmTeachingCase.AdminClsName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.Birthday, convClsRmTeachingCase.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.NativePlace, convClsRmTeachingCase.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.Duty, convClsRmTeachingCase.Duty);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdCardNo, convClsRmTeachingCase.IdCardNo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.StuCardNo, convClsRmTeachingCase.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.LiveAddress, convClsRmTeachingCase.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.HomePhone, convClsRmTeachingCase.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.EnrollmentDate, convClsRmTeachingCase.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.PostCode, convClsRmTeachingCase.PostCode);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.UserKindId, convClsRmTeachingCase.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.UserKindName, convClsRmTeachingCase.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.UserTypeId, convClsRmTeachingCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.UserTypeName, convClsRmTeachingCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.RecommendedDegreeId, convClsRmTeachingCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.RecommendedDegreeName, convClsRmTeachingCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.Memo, convClsRmTeachingCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.DisciplineNamePs, convClsRmTeachingCase.DisciplineNamePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.GradeNamePs, convClsRmTeachingCase.GradeNamePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IdGradePs, convClsRmTeachingCase.IdGradePs);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.OwnerName, convClsRmTeachingCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.OwnerNameWithId, convClsRmTeachingCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.IsHaveVideo, convClsRmTeachingCase.IsHaveVideo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseEN.ftpFileType, convClsRmTeachingCase.ftpFileType);
//检查外键字段长度
 objvClsRmTeachingCaseEN._IsCheckProperty = true;
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
string strSQL = "select IdClsRmTeachingCase, ClsRmTeachingCaseName from vClsRmTeachingCase ";
 clsSpecSQLforSql mySql = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseEN._CurrTabName);
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvClsRmTeachingCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}