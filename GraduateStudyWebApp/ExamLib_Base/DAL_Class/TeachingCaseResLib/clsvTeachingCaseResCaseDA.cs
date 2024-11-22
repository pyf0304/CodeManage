
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseDA
 表名:vTeachingCaseResCase(01120378)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:58
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
 /// v教学案例资源案例(vTeachingCaseResCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingCaseResCaseDA : clsCommBase4DA
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
 return clsvTeachingCaseResCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingCaseResCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingCaseResCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingCaseResCaseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vTeachingCaseResCase中,检查关键字,长度不正确!(clsvTeachingCaseResCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachingCaseResCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachingCaseResCase中,关键字不能为空 或 null!(clsvTeachingCaseResCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachingCaseResCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachingCaseResCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingCaseResCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable_vTeachingCaseResCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCase.* from vTeachingCaseResCase Left Join {1} on {2} where {3} and vTeachingCaseResCase.IdTeachingCaseResCase not in (Select top {5} vTeachingCaseResCase.IdTeachingCaseResCase from vTeachingCaseResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from vTeachingCaseResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from vTeachingCaseResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingCaseResCase.* from vTeachingCaseResCase Left Join {1} on {2} where {3} and vTeachingCaseResCase.IdTeachingCaseResCase not in (Select top {5} vTeachingCaseResCase.IdTeachingCaseResCase from vTeachingCaseResCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {2} IdTeachingCaseResCase from vTeachingCaseResCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingCaseResCase where {1} and IdTeachingCaseResCase not in (Select top {3} IdTeachingCaseResCase from vTeachingCaseResCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingCaseResCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA:GetObjLst)", objException.Message));
}
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseEN);
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
public List<clsvTeachingCaseResCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingCaseResCaseEN> arrObjLst = new List<clsvTeachingCaseResCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetObjLst)", objException.Message));
}
objvTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingCaseResCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingCaseResCase(ref clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ objvTeachingCaseResCaseEN.IdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objDT.Rows[0][convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objDT.Rows[0][convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objDT.Rows[0][convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseEN.CourseId = objDT.Rows[0][convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.CourseCode = objDT.Rows[0][convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.CourseName = objDT.Rows[0][convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerId = objDT.Rows[0][convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCaseEN.IdStudyLevel = objDT.Rows[0][convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.StudyLevelName = objDT.Rows[0][convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.IdTeachingPlan = objDT.Rows[0][convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.IdDiscipline = objDT.Rows[0][convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.DisciplineID = objDT.Rows[0][convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.DisciplineName = objDT.Rows[0][convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.senateGaugeVersionID = objDT.Rows[0][convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.senateGaugeVersionName = objDT.Rows[0][convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IdTeachSkill = objDT.Rows[0][convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillID = objDT.Rows[0][convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.SkillTypeName = objDT.Rows[0][convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillName = objDT.Rows[0][convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillTheory = objDT.Rows[0][convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCaseEN.TeachSkillOperMethod = objDT.Rows[0][convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCaseEN.IdSkillType = objDT.Rows[0][convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.SkillTypeID = objDT.Rows[0][convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.CaseLevelId = objDT.Rows[0][convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvTeachingCaseResCaseEN.CaseLevelName = objDT.Rows[0][convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.DocFile = objDT.Rows[0][convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.WordCreateDate = objDT.Rows[0][convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvTeachingCaseResCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCaseEN.IdXzCollege = objDT.Rows[0][convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.CollegeID = objDT.Rows[0][convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.CollegeName = objDT.Rows[0][convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.CollegeNameA = objDT.Rows[0][convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseEN.IdXzMajor = objDT.Rows[0][convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.MajorID = objDT.Rows[0][convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.MajorName = objDT.Rows[0][convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.CourseChapterId = objDT.Rows[0][convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.CourseChapterName = objDT.Rows[0][convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.ParentNodeID = objDT.Rows[0][convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.ParentNodeName = objDT.Rows[0][convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseEN.CourseChapterReferred = objDT.Rows[0][convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCaseEN.ParentNodeReferred = objDT.Rows[0][convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IsShow = TransNullToBool(objDT.Rows[0][convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.RecommendedDegreeId = objDT.Rows[0][convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCaseEN.RecommendedDegreeName = objDT.Rows[0][convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseEN.ftpFileType = objDT.Rows[0][convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.VideoUrl = objDT.Rows[0][convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.VideoPath = objDT.Rows[0][convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.ResErrMsg = objDT.Rows[0][convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.UpdDate = objDT.Rows[0][convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.UpdUserId = objDT.Rows[0][convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.Memo = objDT.Rows[0][convTeachingCaseResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerNameWithId = objDT.Rows[0][convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerName = objDT.Rows[0][convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IsHaveVideo = objDT.Rows[0][convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetvTeachingCaseResCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachingCaseResCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingCaseResCaseEN GetObjByIdTeachingCaseResCase(string strIdTeachingCaseResCase)
{
CheckPrimaryKey(strIdTeachingCaseResCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
 objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachingCaseResCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvTeachingCaseResCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo(字段类型:varchar,字段长度:6,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetObjByIdTeachingCaseResCase)", objException.Message));
}
return objvTeachingCaseResCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingCaseResCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingCaseResCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN()
{
IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(), //教学案例资源案例流水号
TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(), //教学案例资源案例ID
TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(), //教学案例资源案例名称
TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(), //教学案例资源案例主题词
TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(), //案例文本内容
TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(), //视频资源日期
TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(), //视频资源时间
TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(), //案例入库日期
TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(), //案例入库时间
IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(), //教学案例资源类型流水号
TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(), //教学案例资源案例类型名称
CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(), //课程名称
OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(), //专业名称
CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(), //父节点名称
CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(), //章简称
ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(), //拥有者姓名
BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim() //IsHaveVideo
};
objvTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetObjByDataRowvTeachingCaseResCase)", objException.Message));
}
objvTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingCaseResCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN = new clsvTeachingCaseResCaseEN();
try
{
objvTeachingCaseResCaseEN.IdTeachingCaseResCase = objRow[convTeachingCaseResCase.IdTeachingCaseResCase].ToString().Trim(); //教学案例资源案例流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseID = objRow[convTeachingCaseResCase.TeachingCaseResCaseID].ToString().Trim(); //教学案例资源案例ID
objvTeachingCaseResCaseEN.TeachingCaseResCaseName = objRow[convTeachingCaseResCase.TeachingCaseResCaseName].ToString().Trim(); //教学案例资源案例名称
objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme = objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTheme].ToString().Trim(); //教学案例资源案例主题词
objvTeachingCaseResCaseEN.TeachingCaseResCaseText = objRow[convTeachingCaseResCase.TeachingCaseResCaseText] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseText].ToString().Trim(); //案例文本内容
objvTeachingCaseResCaseEN.TeachingCaseResCaseDate = objRow[convTeachingCaseResCase.TeachingCaseResCaseDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDate].ToString().Trim(); //视频资源日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTime = objRow[convTeachingCaseResCase.TeachingCaseResCaseTime] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTime].ToString().Trim(); //视频资源时间
objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn = objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType = objRow[convTeachingCaseResCase.IdTeachingCaseResCaseType].ToString().Trim(); //教学案例资源类型流水号
objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName = objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachingCaseResCaseTypeName].ToString().Trim(); //教学案例资源案例类型名称
objvTeachingCaseResCaseEN.CourseId = objRow[convTeachingCaseResCase.CourseId].ToString().Trim(); //课程Id
objvTeachingCaseResCaseEN.CourseCode = objRow[convTeachingCaseResCase.CourseCode] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseCode].ToString().Trim(); //课程代码
objvTeachingCaseResCaseEN.CourseName = objRow[convTeachingCaseResCase.CourseName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseName].ToString().Trim(); //课程名称
objvTeachingCaseResCaseEN.OwnerId = objRow[convTeachingCaseResCase.OwnerId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingCaseResCaseEN.IdStudyLevel = objRow[convTeachingCaseResCase.IdStudyLevel] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachingCaseResCaseEN.StudyLevelName = objRow[convTeachingCaseResCase.StudyLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachingCaseResCaseEN.IdTeachingPlan = objRow[convTeachingCaseResCase.IdTeachingPlan] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachingCaseResCaseEN.IdDiscipline = objRow[convTeachingCaseResCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachingCaseResCaseEN.DisciplineID = objRow[convTeachingCaseResCase.DisciplineID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineID].ToString().Trim(); //学科ID
objvTeachingCaseResCaseEN.DisciplineName = objRow[convTeachingCaseResCase.DisciplineName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachingCaseResCaseEN.IdSenateGaugeVersion = objRow[convTeachingCaseResCase.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvTeachingCaseResCaseEN.senateGaugeVersionID = objRow[convTeachingCaseResCase.senateGaugeVersionID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvTeachingCaseResCaseEN.senateGaugeVersionName = objRow[convTeachingCaseResCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvTeachingCaseResCaseEN.senateGaugeVersionTtlScore = objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTeachingCaseResCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvTeachingCaseResCaseEN.VersionNo = objRow[convTeachingCaseResCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.VersionNo].ToString().Trim()); //版本号
objvTeachingCaseResCaseEN.IdTeachSkill = objRow[convTeachingCaseResCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachingCaseResCaseEN.TeachSkillID = objRow[convTeachingCaseResCase.TeachSkillID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachingCaseResCaseEN.SkillTypeName = objRow[convTeachingCaseResCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachingCaseResCaseEN.TeachSkillName = objRow[convTeachingCaseResCase.TeachSkillName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachingCaseResCaseEN.TeachSkillTheory = objRow[convTeachingCaseResCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachingCaseResCaseEN.TeachSkillOperMethod = objRow[convTeachingCaseResCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachingCaseResCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachingCaseResCaseEN.IdSkillType = objRow[convTeachingCaseResCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachingCaseResCaseEN.SkillTypeID = objRow[convTeachingCaseResCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachingCaseResCaseEN.CaseLevelId = objRow[convTeachingCaseResCase.CaseLevelId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvTeachingCaseResCaseEN.CaseLevelName = objRow[convTeachingCaseResCase.CaseLevelName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CaseLevelName].ToString().Trim(); //案例等级名称
objvTeachingCaseResCaseEN.DocFile = objRow[convTeachingCaseResCase.DocFile] == DBNull.Value ? null : objRow[convTeachingCaseResCase.DocFile].ToString().Trim(); //生成的Word文件名
objvTeachingCaseResCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convTeachingCaseResCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvTeachingCaseResCaseEN.WordCreateDate = objRow[convTeachingCaseResCase.WordCreateDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvTeachingCaseResCaseEN.IsVisible = TransNullToBool(objRow[convTeachingCaseResCase.IsVisible].ToString().Trim()); //是否显示
objvTeachingCaseResCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachingCaseResCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachingCaseResCaseEN.IdXzCollege = objRow[convTeachingCaseResCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingCaseResCaseEN.CollegeID = objRow[convTeachingCaseResCase.CollegeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeID].ToString().Trim(); //学院ID
objvTeachingCaseResCaseEN.CollegeName = objRow[convTeachingCaseResCase.CollegeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeName].ToString().Trim(); //学院名称
objvTeachingCaseResCaseEN.CollegeNameA = objRow[convTeachingCaseResCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachingCaseResCaseEN.IdXzMajor = objRow[convTeachingCaseResCase.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingCaseResCaseEN.MajorID = objRow[convTeachingCaseResCase.MajorID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorID].ToString().Trim(); //专业ID
objvTeachingCaseResCaseEN.MajorName = objRow[convTeachingCaseResCase.MajorName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.MajorName].ToString().Trim(); //专业名称
objvTeachingCaseResCaseEN.CourseChapterId = objRow[convTeachingCaseResCase.CourseChapterId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterId].ToString().Trim(); //课程章节ID
objvTeachingCaseResCaseEN.CourseChapterName = objRow[convTeachingCaseResCase.CourseChapterName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterName].ToString().Trim(); //课程章节名称
objvTeachingCaseResCaseEN.ParentNodeID = objRow[convTeachingCaseResCase.ParentNodeID] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeID].ToString().Trim(); //父节点编号
objvTeachingCaseResCaseEN.ParentNodeName = objRow[convTeachingCaseResCase.ParentNodeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeName].ToString().Trim(); //父节点名称
objvTeachingCaseResCaseEN.CourseChapterReferred = objRow[convTeachingCaseResCase.CourseChapterReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.CourseChapterReferred].ToString().Trim(); //节简称
objvTeachingCaseResCaseEN.ParentNodeReferred = objRow[convTeachingCaseResCase.ParentNodeReferred] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ParentNodeReferred].ToString().Trim(); //章简称
objvTeachingCaseResCaseEN.ViewCount = objRow[convTeachingCaseResCase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.ViewCount].ToString().Trim()); //浏览量
objvTeachingCaseResCaseEN.IsShow = TransNullToBool(objRow[convTeachingCaseResCase.IsShow].ToString().Trim()); //是否启用
objvTeachingCaseResCaseEN.DownloadNumber = objRow[convTeachingCaseResCase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.DownloadNumber].ToString().Trim()); //下载数目
objvTeachingCaseResCaseEN.FileIntegration = objRow[convTeachingCaseResCase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.FileIntegration].ToString().Trim()); //文件积分
objvTeachingCaseResCaseEN.LikeCount = objRow[convTeachingCaseResCase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.LikeCount].ToString().Trim()); //资源喜欢数量
objvTeachingCaseResCaseEN.CollectionCount = objRow[convTeachingCaseResCase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convTeachingCaseResCase.CollectionCount].ToString().Trim()); //收藏数量
objvTeachingCaseResCaseEN.RecommendedDegreeId = objRow[convTeachingCaseResCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachingCaseResCaseEN.RecommendedDegreeName = objRow[convTeachingCaseResCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachingCaseResCaseEN.ftpFileType = objRow[convTeachingCaseResCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachingCaseResCaseEN.VideoUrl = objRow[convTeachingCaseResCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachingCaseResCaseEN.VideoPath = objRow[convTeachingCaseResCase.VideoPath] == DBNull.Value ? null : objRow[convTeachingCaseResCase.VideoPath].ToString().Trim(); //视频目录
objvTeachingCaseResCaseEN.ResErrMsg = objRow[convTeachingCaseResCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachingCaseResCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachingCaseResCaseEN.UpdDate = objRow[convTeachingCaseResCase.UpdDate] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdDate].ToString().Trim(); //修改日期
objvTeachingCaseResCaseEN.UpdUserId = objRow[convTeachingCaseResCase.UpdUserId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.UpdUserId].ToString().Trim(); //修改用户Id
objvTeachingCaseResCaseEN.Memo = objRow[convTeachingCaseResCase.Memo] == DBNull.Value ? null : objRow[convTeachingCaseResCase.Memo].ToString().Trim(); //备注
objvTeachingCaseResCaseEN.OwnerNameWithId = objRow[convTeachingCaseResCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvTeachingCaseResCaseEN.OwnerName = objRow[convTeachingCaseResCase.OwnerName] == DBNull.Value ? null : objRow[convTeachingCaseResCase.OwnerName].ToString().Trim(); //拥有者姓名
objvTeachingCaseResCaseEN.BrowseCount4Case = objRow[convTeachingCaseResCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingCaseResCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachingCaseResCaseEN.IsHaveVideo = objRow[convTeachingCaseResCase.IsHaveVideo].ToString().Trim(); //IsHaveVideo
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingCaseResCaseDA: GetObjByDataRow)", objException.Message));
}
objvTeachingCaseResCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingCaseResCaseEN;
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
objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseEN._CurrTabName, convTeachingCaseResCase.IdTeachingCaseResCase, 8, "");
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
objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingCaseResCaseEN._CurrTabName, convTeachingCaseResCase.IdTeachingCaseResCase, 8, strPrefix);
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from vTeachingCaseResCase where " + strCondition;
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachingCaseResCase from vTeachingCaseResCase where " + strCondition;
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCase", "IdTeachingCaseResCase = " + "'"+ strIdTeachingCaseResCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingCaseResCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingCaseResCase", strCondition))
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
objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingCaseResCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseENT">目标对象</param>
public void CopyTo(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENS, clsvTeachingCaseResCaseEN objvTeachingCaseResCaseENT)
{
objvTeachingCaseResCaseENT.IdTeachingCaseResCase = objvTeachingCaseResCaseENS.IdTeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseID = objvTeachingCaseResCaseENS.TeachingCaseResCaseID; //教学案例资源案例ID
objvTeachingCaseResCaseENT.TeachingCaseResCaseName = objvTeachingCaseResCaseENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseENT.TeachingCaseResCaseTheme = objvTeachingCaseResCaseENS.TeachingCaseResCaseTheme; //教学案例资源案例主题词
objvTeachingCaseResCaseENT.TeachingCaseResCaseText = objvTeachingCaseResCaseENS.TeachingCaseResCaseText; //案例文本内容
objvTeachingCaseResCaseENT.TeachingCaseResCaseDate = objvTeachingCaseResCaseENS.TeachingCaseResCaseDate; //视频资源日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTime = objvTeachingCaseResCaseENS.TeachingCaseResCaseTime; //视频资源时间
objvTeachingCaseResCaseENT.TeachingCaseResCaseDateIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseDateIn; //案例入库日期
objvTeachingCaseResCaseENT.TeachingCaseResCaseTimeIn = objvTeachingCaseResCaseENS.TeachingCaseResCaseTimeIn; //案例入库时间
objvTeachingCaseResCaseENT.IdTeachingCaseResCaseType = objvTeachingCaseResCaseENS.IdTeachingCaseResCaseType; //教学案例资源类型流水号
objvTeachingCaseResCaseENT.TeachingCaseResCaseTypeName = objvTeachingCaseResCaseENS.TeachingCaseResCaseTypeName; //教学案例资源案例类型名称
objvTeachingCaseResCaseENT.CourseId = objvTeachingCaseResCaseENS.CourseId; //课程Id
objvTeachingCaseResCaseENT.CourseCode = objvTeachingCaseResCaseENS.CourseCode; //课程代码
objvTeachingCaseResCaseENT.CourseName = objvTeachingCaseResCaseENS.CourseName; //课程名称
objvTeachingCaseResCaseENT.OwnerId = objvTeachingCaseResCaseENS.OwnerId; //拥有者Id
objvTeachingCaseResCaseENT.IdStudyLevel = objvTeachingCaseResCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachingCaseResCaseENT.StudyLevelName = objvTeachingCaseResCaseENS.StudyLevelName; //学段名称
objvTeachingCaseResCaseENT.IdTeachingPlan = objvTeachingCaseResCaseENS.IdTeachingPlan; //教案流水号
objvTeachingCaseResCaseENT.IdDiscipline = objvTeachingCaseResCaseENS.IdDiscipline; //学科流水号
objvTeachingCaseResCaseENT.DisciplineID = objvTeachingCaseResCaseENS.DisciplineID; //学科ID
objvTeachingCaseResCaseENT.DisciplineName = objvTeachingCaseResCaseENS.DisciplineName; //学科名称
objvTeachingCaseResCaseENT.IdSenateGaugeVersion = objvTeachingCaseResCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvTeachingCaseResCaseENT.senateGaugeVersionID = objvTeachingCaseResCaseENS.senateGaugeVersionID; //评价量表版本ID
objvTeachingCaseResCaseENT.senateGaugeVersionName = objvTeachingCaseResCaseENS.senateGaugeVersionName; //评价量表版本名称
objvTeachingCaseResCaseENT.senateGaugeVersionTtlScore = objvTeachingCaseResCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvTeachingCaseResCaseENT.VersionNo = objvTeachingCaseResCaseENS.VersionNo; //版本号
objvTeachingCaseResCaseENT.IdTeachSkill = objvTeachingCaseResCaseENS.IdTeachSkill; //教学技能流水号
objvTeachingCaseResCaseENT.TeachSkillID = objvTeachingCaseResCaseENS.TeachSkillID; //教学技能ID
objvTeachingCaseResCaseENT.SkillTypeName = objvTeachingCaseResCaseENS.SkillTypeName; //技能类型名称
objvTeachingCaseResCaseENT.TeachSkillName = objvTeachingCaseResCaseENS.TeachSkillName; //教学技能名称
objvTeachingCaseResCaseENT.TeachSkillTheory = objvTeachingCaseResCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachingCaseResCaseENT.TeachSkillOperMethod = objvTeachingCaseResCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachingCaseResCaseENT.IdSkillType = objvTeachingCaseResCaseENS.IdSkillType; //技能类型流水号
objvTeachingCaseResCaseENT.SkillTypeID = objvTeachingCaseResCaseENS.SkillTypeID; //技能类型ID
objvTeachingCaseResCaseENT.CaseLevelId = objvTeachingCaseResCaseENS.CaseLevelId; //课例等级Id
objvTeachingCaseResCaseENT.CaseLevelName = objvTeachingCaseResCaseENS.CaseLevelName; //案例等级名称
objvTeachingCaseResCaseENT.DocFile = objvTeachingCaseResCaseENS.DocFile; //生成的Word文件名
objvTeachingCaseResCaseENT.IsNeedGeneWord = objvTeachingCaseResCaseENS.IsNeedGeneWord; //是否需要生成Word
objvTeachingCaseResCaseENT.WordCreateDate = objvTeachingCaseResCaseENS.WordCreateDate; //Word生成日期
objvTeachingCaseResCaseENT.IsVisible = objvTeachingCaseResCaseENS.IsVisible; //是否显示
objvTeachingCaseResCaseENT.IsDualVideo = objvTeachingCaseResCaseENS.IsDualVideo; //是否双视频
objvTeachingCaseResCaseENT.IdXzCollege = objvTeachingCaseResCaseENS.IdXzCollege; //学院流水号
objvTeachingCaseResCaseENT.CollegeID = objvTeachingCaseResCaseENS.CollegeID; //学院ID
objvTeachingCaseResCaseENT.CollegeName = objvTeachingCaseResCaseENS.CollegeName; //学院名称
objvTeachingCaseResCaseENT.CollegeNameA = objvTeachingCaseResCaseENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseENT.IdXzMajor = objvTeachingCaseResCaseENS.IdXzMajor; //专业流水号
objvTeachingCaseResCaseENT.MajorID = objvTeachingCaseResCaseENS.MajorID; //专业ID
objvTeachingCaseResCaseENT.MajorName = objvTeachingCaseResCaseENS.MajorName; //专业名称
objvTeachingCaseResCaseENT.CourseChapterId = objvTeachingCaseResCaseENS.CourseChapterId; //课程章节ID
objvTeachingCaseResCaseENT.CourseChapterName = objvTeachingCaseResCaseENS.CourseChapterName; //课程章节名称
objvTeachingCaseResCaseENT.ParentNodeID = objvTeachingCaseResCaseENS.ParentNodeID; //父节点编号
objvTeachingCaseResCaseENT.ParentNodeName = objvTeachingCaseResCaseENS.ParentNodeName; //父节点名称
objvTeachingCaseResCaseENT.CourseChapterReferred = objvTeachingCaseResCaseENS.CourseChapterReferred; //节简称
objvTeachingCaseResCaseENT.ParentNodeReferred = objvTeachingCaseResCaseENS.ParentNodeReferred; //章简称
objvTeachingCaseResCaseENT.ViewCount = objvTeachingCaseResCaseENS.ViewCount; //浏览量
objvTeachingCaseResCaseENT.IsShow = objvTeachingCaseResCaseENS.IsShow; //是否启用
objvTeachingCaseResCaseENT.DownloadNumber = objvTeachingCaseResCaseENS.DownloadNumber; //下载数目
objvTeachingCaseResCaseENT.FileIntegration = objvTeachingCaseResCaseENS.FileIntegration; //文件积分
objvTeachingCaseResCaseENT.LikeCount = objvTeachingCaseResCaseENS.LikeCount; //资源喜欢数量
objvTeachingCaseResCaseENT.CollectionCount = objvTeachingCaseResCaseENS.CollectionCount; //收藏数量
objvTeachingCaseResCaseENT.RecommendedDegreeId = objvTeachingCaseResCaseENS.RecommendedDegreeId; //推荐度Id
objvTeachingCaseResCaseENT.RecommendedDegreeName = objvTeachingCaseResCaseENS.RecommendedDegreeName; //推荐度名称
objvTeachingCaseResCaseENT.ftpFileType = objvTeachingCaseResCaseENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCaseENT.VideoUrl = objvTeachingCaseResCaseENS.VideoUrl; //视频Url
objvTeachingCaseResCaseENT.VideoPath = objvTeachingCaseResCaseENS.VideoPath; //视频目录
objvTeachingCaseResCaseENT.ResErrMsg = objvTeachingCaseResCaseENS.ResErrMsg; //资源错误信息
objvTeachingCaseResCaseENT.UpdDate = objvTeachingCaseResCaseENS.UpdDate; //修改日期
objvTeachingCaseResCaseENT.UpdUserId = objvTeachingCaseResCaseENS.UpdUserId; //修改用户Id
objvTeachingCaseResCaseENT.Memo = objvTeachingCaseResCaseENS.Memo; //备注
objvTeachingCaseResCaseENT.OwnerNameWithId = objvTeachingCaseResCaseENS.OwnerNameWithId; //拥有者名称附Id
objvTeachingCaseResCaseENT.OwnerName = objvTeachingCaseResCaseENS.OwnerName; //拥有者姓名
objvTeachingCaseResCaseENT.BrowseCount4Case = objvTeachingCaseResCaseENS.BrowseCount4Case; //课例浏览次数
objvTeachingCaseResCaseENT.IsHaveVideo = objvTeachingCaseResCaseENS.IsHaveVideo; //IsHaveVideo
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingCaseResCaseEN objvTeachingCaseResCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdTeachingCaseResCase, 8, convTeachingCaseResCase.IdTeachingCaseResCase);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseID, 8, convTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseName, 100, convTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme, 200, convTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseText, 8000, convTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseDate, 8, convTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseTime, 6, convTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, 8, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, 6, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType, 4, convTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName, 30, convTeachingCaseResCase.TeachingCaseResCaseTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseId, 8, convTeachingCaseResCase.CourseId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseCode, 20, convTeachingCaseResCase.CourseCode);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseName, 100, convTeachingCaseResCase.CourseName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.OwnerId, 20, convTeachingCaseResCase.OwnerId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdStudyLevel, 4, convTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.StudyLevelName, 50, convTeachingCaseResCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdTeachingPlan, 8, convTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdDiscipline, 4, convTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.DisciplineID, 4, convTeachingCaseResCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.DisciplineName, 50, convTeachingCaseResCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdSenateGaugeVersion, 4, convTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.senateGaugeVersionID, 4, convTeachingCaseResCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.senateGaugeVersionName, 200, convTeachingCaseResCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdTeachSkill, 8, convTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachSkillID, 8, convTeachingCaseResCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.SkillTypeName, 50, convTeachingCaseResCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachSkillName, 50, convTeachingCaseResCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachSkillTheory, 8000, convTeachingCaseResCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.TeachSkillOperMethod, 2000, convTeachingCaseResCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdSkillType, 4, convTeachingCaseResCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.SkillTypeID, 4, convTeachingCaseResCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CaseLevelId, 2, convTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CaseLevelName, 30, convTeachingCaseResCase.CaseLevelName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.DocFile, 200, convTeachingCaseResCase.DocFile);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.WordCreateDate, 14, convTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdXzCollege, 4, convTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CollegeID, 4, convTeachingCaseResCase.CollegeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CollegeName, 100, convTeachingCaseResCase.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CollegeNameA, 12, convTeachingCaseResCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IdXzMajor, 8, convTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.MajorID, 4, convTeachingCaseResCase.MajorID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.MajorName, 100, convTeachingCaseResCase.MajorName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseChapterId, 8, convTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseChapterName, 100, convTeachingCaseResCase.CourseChapterName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.ParentNodeID, 8, convTeachingCaseResCase.ParentNodeID);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.ParentNodeName, 50, convTeachingCaseResCase.ParentNodeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.CourseChapterReferred, 10, convTeachingCaseResCase.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.ParentNodeReferred, 10, convTeachingCaseResCase.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.RecommendedDegreeId, 2, convTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.RecommendedDegreeName, 30, convTeachingCaseResCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.ftpFileType, 30, convTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.VideoUrl, 1000, convTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.VideoPath, 1000, convTeachingCaseResCase.VideoPath);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.ResErrMsg, 30, convTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.UpdDate, 20, convTeachingCaseResCase.UpdDate);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.UpdUserId, 20, convTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.Memo, 1000, convTeachingCaseResCase.Memo);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.OwnerNameWithId, 51, convTeachingCaseResCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.OwnerName, 30, convTeachingCaseResCase.OwnerName);
clsCheckSql.CheckFieldLen(objvTeachingCaseResCaseEN.IsHaveVideo, 6, convTeachingCaseResCase.IsHaveVideo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdTeachingCaseResCase, convTeachingCaseResCase.IdTeachingCaseResCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseID, convTeachingCaseResCase.TeachingCaseResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseName, convTeachingCaseResCase.TeachingCaseResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseTheme, convTeachingCaseResCase.TeachingCaseResCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseText, convTeachingCaseResCase.TeachingCaseResCaseText);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseDate, convTeachingCaseResCase.TeachingCaseResCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseTime, convTeachingCaseResCase.TeachingCaseResCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseDateIn, convTeachingCaseResCase.TeachingCaseResCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseTimeIn, convTeachingCaseResCase.TeachingCaseResCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdTeachingCaseResCaseType, convTeachingCaseResCase.IdTeachingCaseResCaseType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachingCaseResCaseTypeName, convTeachingCaseResCase.TeachingCaseResCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseId, convTeachingCaseResCase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseCode, convTeachingCaseResCase.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseName, convTeachingCaseResCase.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.OwnerId, convTeachingCaseResCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdStudyLevel, convTeachingCaseResCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.StudyLevelName, convTeachingCaseResCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdTeachingPlan, convTeachingCaseResCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdDiscipline, convTeachingCaseResCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.DisciplineID, convTeachingCaseResCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.DisciplineName, convTeachingCaseResCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdSenateGaugeVersion, convTeachingCaseResCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.senateGaugeVersionID, convTeachingCaseResCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.senateGaugeVersionName, convTeachingCaseResCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdTeachSkill, convTeachingCaseResCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachSkillID, convTeachingCaseResCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.SkillTypeName, convTeachingCaseResCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachSkillName, convTeachingCaseResCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachSkillTheory, convTeachingCaseResCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.TeachSkillOperMethod, convTeachingCaseResCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdSkillType, convTeachingCaseResCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.SkillTypeID, convTeachingCaseResCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CaseLevelId, convTeachingCaseResCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CaseLevelName, convTeachingCaseResCase.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.DocFile, convTeachingCaseResCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.WordCreateDate, convTeachingCaseResCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdXzCollege, convTeachingCaseResCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CollegeID, convTeachingCaseResCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CollegeName, convTeachingCaseResCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CollegeNameA, convTeachingCaseResCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IdXzMajor, convTeachingCaseResCase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.MajorID, convTeachingCaseResCase.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.MajorName, convTeachingCaseResCase.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseChapterId, convTeachingCaseResCase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseChapterName, convTeachingCaseResCase.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.ParentNodeID, convTeachingCaseResCase.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.ParentNodeName, convTeachingCaseResCase.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.CourseChapterReferred, convTeachingCaseResCase.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.ParentNodeReferred, convTeachingCaseResCase.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.RecommendedDegreeId, convTeachingCaseResCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.RecommendedDegreeName, convTeachingCaseResCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.ftpFileType, convTeachingCaseResCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.VideoUrl, convTeachingCaseResCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.VideoPath, convTeachingCaseResCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.ResErrMsg, convTeachingCaseResCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.UpdDate, convTeachingCaseResCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.UpdUserId, convTeachingCaseResCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.Memo, convTeachingCaseResCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.OwnerNameWithId, convTeachingCaseResCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.OwnerName, convTeachingCaseResCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingCaseResCaseEN.IsHaveVideo, convTeachingCaseResCase.IsHaveVideo);
//检查外键字段长度
 objvTeachingCaseResCaseEN._IsCheckProperty = true;
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseEN._CurrTabName);
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingCaseResCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingCaseResCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}