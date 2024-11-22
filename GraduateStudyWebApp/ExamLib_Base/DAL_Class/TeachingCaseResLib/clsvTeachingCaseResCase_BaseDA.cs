
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCase_BaseDA
 表名:vTeachingCaseResCase_Base(01120515)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v教学案例资源案例_Base(vTeachingCaseResCase_Base)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingCaseResCase_BaseDA : clsCommBase4DA
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
 return clsvTeachingCaseResCase_BaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCase_BaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCase_BaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingCaseResCase_BaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCase_BaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vTeachingCaseResCase_Base中,检查关键字,长度不正确!(clsvTeachingCaseResCase_BaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachingCaseResCase_Base中,关键字不能为空 或 null!(clsvTeachingCaseResCase_BaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingCaseResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachingCaseResCase_BaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingCaseResCase_Base(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable_vTeachingCaseResCase_Base)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCase_Base.* from vTeachingCaseResCase_Base Left Join {1} on {2} where {3} and vTeachingCaseResCase_Base.IdTeachingCaseResCase not in (Select top {5} vTeachingCaseResCase_Base.IdTeachingCaseResCase from vTeachingCaseResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from vTeachingCaseResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from vTeachingCaseResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCase_Base.* from vTeachingCaseResCase_Base Left Join {1} on {2} where {3} and vTeachingCaseResCase_Base.IdTeachingCaseResCase not in (Select top {5} vTeachingCaseResCase_Base.IdTeachingCaseResCase from vTeachingCaseResCase_Base Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from vTeachingCaseResCase_Base where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase_Base where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from vTeachingCaseResCase_Base where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingCaseResCase_BaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA:GetObjLst)", objException.Message));
}
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
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
public List<clsvTeachingCaseResCase_BaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingCaseResCase_BaseEN> arrObjLst = new List<clsvTeachingCaseResCase_BaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCase_BaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingCaseResCase_Base(ref clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where IdTeachingCaseResCase = " + "'"+ objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objDT.Rows[0][convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objDT.Rows[0][convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objDT.Rows[0][convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseId = objDT.Rows[0][convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseCode = objDT.Rows[0][convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseName = objDT.Rows[0][convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerId = objDT.Rows[0][convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdStudyLevel = objDT.Rows[0][convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.StudyLevelName = objDT.Rows[0][convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objDT.Rows[0][convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdDiscipline = objDT.Rows[0][convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.DisciplineID = objDT.Rows[0][convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.DisciplineName = objDT.Rows[0][convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objDT.Rows[0][convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objDT.Rows[0][convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objDT.Rows[0][convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdTeachSkill = objDT.Rows[0][convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillID = objDT.Rows[0][convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.SkillTypeName = objDT.Rows[0][convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillName = objDT.Rows[0][convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objDT.Rows[0][convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objDT.Rows[0][convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdSkillType = objDT.Rows[0][convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.SkillTypeID = objDT.Rows[0][convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CaseLevelId = objDT.Rows[0][convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CaseLevelName = objDT.Rows[0][convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.DocFile = objDT.Rows[0][convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.WordCreateDate = objDT.Rows[0][convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdXzCollege = objDT.Rows[0][convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CollegeId = objDT.Rows[0][convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CollegeName = objDT.Rows[0][convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CollegeNameA = objDT.Rows[0][convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdXzMajor = objDT.Rows[0][convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.MajorID = objDT.Rows[0][convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.MajorName = objDT.Rows[0][convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseChapterId = objDT.Rows[0][convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseChapterName = objDT.Rows[0][convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.ParentNodeId = objDT.Rows[0][convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ParentNodeName = objDT.Rows[0][convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objDT.Rows[0][convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objDT.Rows[0][convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsShow = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objDT.Rows[0][convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objDT.Rows[0][convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCase_BaseEN.ftpFileType = objDT.Rows[0][convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.VideoUrl = objDT.Rows[0][convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.VideoPath = objDT.Rows[0][convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ResErrMsg = objDT.Rows[0][convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.Memo = objDT.Rows[0][convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerName = objDT.Rows[0][convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objDT.Rows[0][convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCase_BaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetvTeachingCaseResCase_Base)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingCaseResCase_BaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
{
CheckPrimaryKey(strIdTeachingCaseResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
 objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetObjByIdTeachingCaseResCase)", objException.Message));
}
return objvTeachingCaseResCase_BaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingCaseResCase_BaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase_Base where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN()
{
IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(), //教学案例资源案例流水号
TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(), //教学案例资源案例ID
TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(), //教学案例资源案例名称
TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(), //教学案例资源案例主题词
TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(), //案例文本内容
TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(), //视频资源日期
TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(), //视频资源时间
TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(), //案例入库日期
TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(), //案例入库时间
IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(), //教学案例资源类型流水号
TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(), //教学案例资源案例类型名称
CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(), //课程名称
OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(), //父节点名称
CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(), //章简称
ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(), //备注
OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvTeachingCaseResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCase_BaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCase_BaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetObjByDataRowvTeachingCaseResCase_Base)", objException.Message));
}
objvTeachingCaseResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCase_BaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCase_BaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN = new clsvTeachingCaseResCase_BaseEN();
try
{
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase_Base.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseEN.CourseId = objRow[convTeachingCaseResCase_Base.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCase_BaseEN.CourseCode = objRow[convTeachingCaseResCase_Base.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCase_BaseEN.CourseName = objRow[convTeachingCaseResCase_Base.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCase_BaseEN.OwnerId = objRow[convTeachingCaseResCase_Base.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCase_BaseEN.IdStudyLevel = objRow[convTeachingCaseResCase_Base.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCase_BaseEN.StudyLevelName = objRow[convTeachingCaseResCase_Base.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCase_BaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase_Base.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCase_BaseEN.IdDiscipline = objRow[convTeachingCaseResCase_Base.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCase_BaseEN.DisciplineID = objRow[convTeachingCaseResCase_Base.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCase_BaseEN.DisciplineName = objRow[convTeachingCaseResCase_Base.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCase_BaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase_Base.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCase_BaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase_Base.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCase_BaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase_Base.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCase_BaseEN.VersionNo = objRow[convTeachingCaseResCase_Base.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCase_BaseEN.IdTeachSkill = objRow[convTeachingCaseResCase_Base.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCase_BaseEN.TeachSkillID = objRow[convTeachingCaseResCase_Base.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCase_BaseEN.SkillTypeName = objRow[convTeachingCaseResCase_Base.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCase_BaseEN.TeachSkillName = objRow[convTeachingCaseResCase_Base.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCase_BaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase_Base.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCase_BaseEN.IdSkillType = objRow[convTeachingCaseResCase_Base.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCase_BaseEN.SkillTypeID = objRow[convTeachingCaseResCase_Base.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCase_BaseEN.CaseLevelId = objRow[convTeachingCaseResCase_Base.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCase_BaseEN.CaseLevelName = objRow[convTeachingCaseResCase_Base.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCase_BaseEN.DocFile = objRow[convTeachingCaseResCase_Base.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCase_BaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCase_BaseEN.WordCreateDate = objRow[convTeachingCaseResCase_Base.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCase_BaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCase_BaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCase_BaseEN.IdXzCollege = objRow[convTeachingCaseResCase_Base.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCase_BaseEN.CollegeId = objRow[convTeachingCaseResCase_Base.CollegeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeId].ToString().Trim(); //学院ID
objvTeachingCaseResCase_BaseEN.CollegeName = objRow[convTeachingCaseResCase_Base.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCase_BaseEN.CollegeNameA = objRow[convTeachingCaseResCase_Base.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCase_BaseEN.IdXzMajor = objRow[convTeachingCaseResCase_Base.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCase_BaseEN.MajorID = objRow[convTeachingCaseResCase_Base.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCase_BaseEN.MajorName = objRow[convTeachingCaseResCase_Base.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCase_BaseEN.CourseChapterId = objRow[convTeachingCaseResCase_Base.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCase_BaseEN.CourseChapterName = objRow[convTeachingCaseResCase_Base.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCase_BaseEN.ParentNodeId = objRow[convTeachingCaseResCase_Base.ParentNodeId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeId].ToString().Trim(); //父节点编号
objvTeachingCaseResCase_BaseEN.ParentNodeName = objRow[convTeachingCaseResCase_Base.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCase_BaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase_Base.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCase_BaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase_Base.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCase_BaseEN.ViewCount = objRow[convTeachingCaseResCase_Base.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCase_BaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase_Base.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCase_BaseEN.DownloadNumber = objRow[convTeachingCaseResCase_Base.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCase_BaseEN.FileIntegration = objRow[convTeachingCaseResCase_Base.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCase_BaseEN.LikeCount = objRow[convTeachingCaseResCase_Base.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCase_BaseEN.CollectionCount = objRow[convTeachingCaseResCase_Base.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCase_BaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase_Base.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCase_BaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase_Base.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCase_BaseEN.ftpFileType = objRow[convTeachingCaseResCase_Base.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCase_BaseEN.VideoUrl = objRow[convTeachingCaseResCase_Base.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCase_BaseEN.VideoPath = objRow[convTeachingCaseResCase_Base.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCase_BaseEN.ResErrMsg = objRow[convTeachingCaseResCase_Base.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCase_BaseEN.Memo = objRow[convTeachingCaseResCase_Base.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.Memo].ToString().Trim(); //备注
objvTeachingCaseResCase_BaseEN.OwnerName = objRow[convTeachingCaseResCase_Base.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCase_BaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase_Base.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase_Base.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCase_BaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase_Base.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase_Base.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCase_BaseDA: GetObjByDataRow)", objException.Message));
}
objvTeachingCaseResCase_BaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCase_BaseEN;
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
objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCase_BaseEN._CurrTabName, convTeachingCaseResCase_Base.IdTeachingCaseResCase, 8, "");
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
objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCase_BaseEN._CurrTabName, convTeachingCaseResCase_Base.IdTeachingCaseResCase, 8, strPrefix);
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from vTeachingCaseResCase_Base where " + strCondition;
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from vTeachingCaseResCase_Base where " + strCondition;
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCase_Base", "IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingCaseResCase_BaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCase_Base", strCondition))
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
objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingCaseResCase_Base");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCase_BaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCase_BaseENT">目标对象</param>
public void CopyTo(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENS, clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseENT)
{
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCase = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseID = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseText = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCase_BaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCase_BaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCase_BaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCase_BaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCase_BaseENT.CourseId = objvTeachingCaseResCase_BaseENS.CourseId; //课程Id
objvTeachingCaseResCase_BaseENT.CourseCode = objvTeachingCaseResCase_BaseENS.CourseCode; //课程代码
objvTeachingCaseResCase_BaseENT.CourseName = objvTeachingCaseResCase_BaseENS.CourseName; //课程名称
objvTeachingCaseResCase_BaseENT.OwnerId = objvTeachingCaseResCase_BaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCase_BaseENT.IdStudyLevel = objvTeachingCaseResCase_BaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCase_BaseENT.StudyLevelName = objvTeachingCaseResCase_BaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCase_BaseENT.IdTeachingPlan = objvTeachingCaseResCase_BaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCase_BaseENT.IdDiscipline = objvTeachingCaseResCase_BaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCase_BaseENT.DisciplineID = objvTeachingCaseResCase_BaseENS.DisciplineID; //学科ID
objvTeachingCaseResCase_BaseENT.DisciplineName = objvTeachingCaseResCase_BaseENS.DisciplineName; //学科名称
objvTeachingCaseResCase_BaseENT.IdSenateGaugeVersion = objvTeachingCaseResCase_BaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCase_BaseENT.senateGaugeVersionID = objvTeachingCaseResCase_BaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCase_BaseENT.senateGaugeVersionName = objvTeachingCaseResCase_BaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCase_BaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCase_BaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCase_BaseENT.VersionNo = objvTeachingCaseResCase_BaseENS.VersionNo; //版本号
objvTeachingCaseResCase_BaseENT.IdTeachSkill = objvTeachingCaseResCase_BaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCase_BaseENT.TeachSkillID = objvTeachingCaseResCase_BaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCase_BaseENT.SkillTypeName = objvTeachingCaseResCase_BaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCase_BaseENT.TeachSkillName = objvTeachingCaseResCase_BaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCase_BaseENT.TeachSkillTheory = objvTeachingCaseResCase_BaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCase_BaseENT.TeachSkillOperMethod = objvTeachingCaseResCase_BaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCase_BaseENT.IdSkillType = objvTeachingCaseResCase_BaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCase_BaseENT.SkillTypeID = objvTeachingCaseResCase_BaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCase_BaseENT.CaseLevelId = objvTeachingCaseResCase_BaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCase_BaseENT.CaseLevelName = objvTeachingCaseResCase_BaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCase_BaseENT.DocFile = objvTeachingCaseResCase_BaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCase_BaseENT.IsNeedGeneWord = objvTeachingCaseResCase_BaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCase_BaseENT.WordCreateDate = objvTeachingCaseResCase_BaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCase_BaseENT.IsVisible = objvTeachingCaseResCase_BaseENS.IsVisible; //是否显示
objvTeachingCaseResCase_BaseENT.IsDualVideo = objvTeachingCaseResCase_BaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCase_BaseENT.IdXzCollege = objvTeachingCaseResCase_BaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCase_BaseENT.CollegeId = objvTeachingCaseResCase_BaseENS.CollegeId; //学院ID
objvTeachingCaseResCase_BaseENT.CollegeName = objvTeachingCaseResCase_BaseENS.CollegeName; //学院名称
objvTeachingCaseResCase_BaseENT.CollegeNameA = objvTeachingCaseResCase_BaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCase_BaseENT.IdXzMajor = objvTeachingCaseResCase_BaseENS.IdXzMajor; //专业流水号
objvTeachingCaseResCase_BaseENT.MajorID = objvTeachingCaseResCase_BaseENS.MajorID; //专业ID
objvTeachingCaseResCase_BaseENT.MajorName = objvTeachingCaseResCase_BaseENS.MajorName; //专业名称
objvTeachingCaseResCase_BaseENT.CourseChapterId = objvTeachingCaseResCase_BaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCase_BaseENT.CourseChapterName = objvTeachingCaseResCase_BaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCase_BaseENT.ParentNodeId = objvTeachingCaseResCase_BaseENS.ParentNodeId; //父节点编号
objvTeachingCaseResCase_BaseENT.ParentNodeName = objvTeachingCaseResCase_BaseENS.ParentNodeName; //父节点名称
objvTeachingCaseResCase_BaseENT.CourseChapterReferred = objvTeachingCaseResCase_BaseENS.CourseChapterReferred; //节简称
objvTeachingCaseResCase_BaseENT.ParentNodeReferred = objvTeachingCaseResCase_BaseENS.ParentNodeReferred; //章简称
objvTeachingCaseResCase_BaseENT.ViewCount = objvTeachingCaseResCase_BaseENS.ViewCount; //浏览量
objvTeachingCaseResCase_BaseENT.IsShow = objvTeachingCaseResCase_BaseENS.IsShow; //是否启用
objvTeachingCaseResCase_BaseENT.DownloadNumber = objvTeachingCaseResCase_BaseENS.DownloadNumber; //下载数目
objvTeachingCaseResCase_BaseENT.FileIntegration = objvTeachingCaseResCase_BaseENS.FileIntegration; //文件积分
objvTeachingCaseResCase_BaseENT.LikeCount = objvTeachingCaseResCase_BaseENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCase_BaseENT.CollectionCount = objvTeachingCaseResCase_BaseENS.CollectionCount; //收藏数量
objvTeachingCaseResCase_BaseENT.RecommendedDegreeId = objvTeachingCaseResCase_BaseENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCase_BaseENT.RecommendedDegreeName = objvTeachingCaseResCase_BaseENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCase_BaseENT.ftpFileType = objvTeachingCaseResCase_BaseENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCase_BaseENT.VideoUrl = objvTeachingCaseResCase_BaseENS.VideoUrl; //视频Url
objvTeachingCaseResCase_BaseENT.VideoPath = objvTeachingCaseResCase_BaseENS.VideoPath; //视频目录
objvTeachingCaseResCase_BaseENT.ResErrMsg = objvTeachingCaseResCase_BaseENS.ResErrMsg; //资源错误信息
objvTeachingCaseResCase_BaseENT.Memo = objvTeachingCaseResCase_BaseENS.Memo; //备注
objvTeachingCaseResCase_BaseENT.OwnerName = objvTeachingCaseResCase_BaseENS.OwnerName; //拥有者姓名
objvTeachingCaseResCase_BaseENT.OwnerNameWithId = objvTeachingCaseResCase_BaseENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCase_BaseENT.BrowseCount4Case = objvTeachingCaseResCase_BaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingCaseResCase_BaseEN objvTeachingCaseResCase_BaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, 8, convTeachingCaseResCase_Base.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName, 100, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme, 200, convTeachingCaseResCase_Base.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText, 8000, convTeachingCaseResCase_Base.TeachingCaseResCaseText);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn, 8, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType, 4, convTeachingCaseResCase_Base.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName, 30, convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseId, 8, convTeachingCaseResCase_Base.CourseId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseCode, 20, convTeachingCaseResCase_Base.CourseCode);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseName, 100, convTeachingCaseResCase_Base.CourseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.OwnerId, 20, convTeachingCaseResCase_Base.OwnerId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdStudyLevel, 4, convTeachingCaseResCase_Base.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.StudyLevelName, 50, convTeachingCaseResCase_Base.StudyLevelName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdTeachingPlan, 8, convTeachingCaseResCase_Base.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdDiscipline, 4, convTeachingCaseResCase_Base.IdDiscipline);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.DisciplineID, 4, convTeachingCaseResCase_Base.DisciplineID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.DisciplineName, 50, convTeachingCaseResCase_Base.DisciplineName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion, 4, convTeachingCaseResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.senateGaugeVersionID, 4, convTeachingCaseResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.senateGaugeVersionName, 200, convTeachingCaseResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdTeachSkill, 8, convTeachingCaseResCase_Base.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachSkillID, 8, convTeachingCaseResCase_Base.TeachSkillID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.SkillTypeName, 50, convTeachingCaseResCase_Base.SkillTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachSkillName, 50, convTeachingCaseResCase_Base.TeachSkillName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachSkillTheory, 8000, convTeachingCaseResCase_Base.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod, 2000, convTeachingCaseResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdSkillType, 4, convTeachingCaseResCase_Base.IdSkillType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.SkillTypeID, 4, convTeachingCaseResCase_Base.SkillTypeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CaseLevelId, 2, convTeachingCaseResCase_Base.CaseLevelId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CaseLevelName, 30, convTeachingCaseResCase_Base.CaseLevelName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.DocFile, 200, convTeachingCaseResCase_Base.DocFile);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.WordCreateDate, 14, convTeachingCaseResCase_Base.WordCreateDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdXzCollege, 4, convTeachingCaseResCase_Base.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CollegeId, 4, convTeachingCaseResCase_Base.CollegeId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CollegeName, 100, convTeachingCaseResCase_Base.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CollegeNameA, 12, convTeachingCaseResCase_Base.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.IdXzMajor, 8, convTeachingCaseResCase_Base.IdXzMajor);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.MajorID, 4, convTeachingCaseResCase_Base.MajorID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.MajorName, 100, convTeachingCaseResCase_Base.MajorName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseChapterId, 8, convTeachingCaseResCase_Base.CourseChapterId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseChapterName, 100, convTeachingCaseResCase_Base.CourseChapterName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.ParentNodeId, 8, convTeachingCaseResCase_Base.ParentNodeId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.ParentNodeName, 100, convTeachingCaseResCase_Base.ParentNodeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.CourseChapterReferred, 10, convTeachingCaseResCase_Base.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.ParentNodeReferred, 10, convTeachingCaseResCase_Base.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.RecommendedDegreeId, 2, convTeachingCaseResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.RecommendedDegreeName, 30, convTeachingCaseResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.ftpFileType, 30, convTeachingCaseResCase_Base.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.VideoUrl, 1000, convTeachingCaseResCase_Base.VideoUrl);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.VideoPath, 1000, convTeachingCaseResCase_Base.VideoPath);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.ResErrMsg, 30, convTeachingCaseResCase_Base.ResErrMsg);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.Memo, 1000, convTeachingCaseResCase_Base.Memo);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.OwnerName, 30, convTeachingCaseResCase_Base.OwnerName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCase_BaseEN.OwnerNameWithId, 51, convTeachingCaseResCase_Base.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCase, convTeachingCaseResCase_Base.IdTeachingCaseResCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseID, convTeachingCaseResCase_Base.TeachingCaseResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseName, convTeachingCaseResCase_Base.TeachingCaseResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTheme, convTeachingCaseResCase_Base.TeachingCaseResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseText, convTeachingCaseResCase_Base.TeachingCaseResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDate, convTeachingCaseResCase_Base.TeachingCaseResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTime, convTeachingCaseResCase_Base.TeachingCaseResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseDateIn, convTeachingCaseResCase_Base.TeachingCaseResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTimeIn, convTeachingCaseResCase_Base.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdTeachingCaseResCaseType, convTeachingCaseResCase_Base.IdTeachingCaseResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachingCaseResCaseTypeName, convTeachingCaseResCase_Base.TeachingCaseResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseId, convTeachingCaseResCase_Base.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseCode, convTeachingCaseResCase_Base.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseName, convTeachingCaseResCase_Base.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.OwnerId, convTeachingCaseResCase_Base.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdStudyLevel, convTeachingCaseResCase_Base.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.StudyLevelName, convTeachingCaseResCase_Base.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdTeachingPlan, convTeachingCaseResCase_Base.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdDiscipline, convTeachingCaseResCase_Base.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.DisciplineID, convTeachingCaseResCase_Base.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.DisciplineName, convTeachingCaseResCase_Base.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdSenateGaugeVersion, convTeachingCaseResCase_Base.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.senateGaugeVersionID, convTeachingCaseResCase_Base.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.senateGaugeVersionName, convTeachingCaseResCase_Base.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdTeachSkill, convTeachingCaseResCase_Base.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachSkillID, convTeachingCaseResCase_Base.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.SkillTypeName, convTeachingCaseResCase_Base.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachSkillName, convTeachingCaseResCase_Base.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachSkillTheory, convTeachingCaseResCase_Base.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.TeachSkillOperMethod, convTeachingCaseResCase_Base.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdSkillType, convTeachingCaseResCase_Base.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.SkillTypeID, convTeachingCaseResCase_Base.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CaseLevelId, convTeachingCaseResCase_Base.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CaseLevelName, convTeachingCaseResCase_Base.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.DocFile, convTeachingCaseResCase_Base.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.WordCreateDate, convTeachingCaseResCase_Base.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdXzCollege, convTeachingCaseResCase_Base.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CollegeId, convTeachingCaseResCase_Base.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CollegeName, convTeachingCaseResCase_Base.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CollegeNameA, convTeachingCaseResCase_Base.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.IdXzMajor, convTeachingCaseResCase_Base.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.MajorID, convTeachingCaseResCase_Base.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.MajorName, convTeachingCaseResCase_Base.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseChapterId, convTeachingCaseResCase_Base.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseChapterName, convTeachingCaseResCase_Base.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.ParentNodeId, convTeachingCaseResCase_Base.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.ParentNodeName, convTeachingCaseResCase_Base.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.CourseChapterReferred, convTeachingCaseResCase_Base.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.ParentNodeReferred, convTeachingCaseResCase_Base.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.RecommendedDegreeId, convTeachingCaseResCase_Base.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.RecommendedDegreeName, convTeachingCaseResCase_Base.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.ftpFileType, convTeachingCaseResCase_Base.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.VideoUrl, convTeachingCaseResCase_Base.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.VideoPath, convTeachingCaseResCase_Base.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.ResErrMsg, convTeachingCaseResCase_Base.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.Memo, convTeachingCaseResCase_Base.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.OwnerName, convTeachingCaseResCase_Base.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCase_BaseEN.OwnerNameWithId, convTeachingCaseResCase_Base.OwnerNameWithId);
//检查外键字段长度
 objvTeachingCaseResCase_BaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdTeachingCaseResCase()
{
//获取某学院所有专业信息
string strSQL = "select IdTeachingCaseResCase, TeachingCaseResCaseName from vTeachingCaseResCase_Base ";
 clsSpecSQLforSql mySql = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCase_BaseEN._CurrTabName);
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCase_BaseEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingCaseResCase_BaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}