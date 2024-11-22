
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase_Resource_Rel4TeaDA
 表名:vMicroteachCase_Resource_Rel4Tea(01120428)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:37
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// v微格资源关系4Tea(vMicroteachCase_Resource_Rel4Tea)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase_Resource_Rel4TeaDA : clsCommBase4DA
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
 return clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase_Resource_Rel4TeaEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase_Resource_Rel4Tea(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable_vMicroteachCase_Resource_Rel4Tea)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel4Tea.* from vMicroteachCase_Resource_Rel4Tea Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase_Resource_Rel4Tea.* from vMicroteachCase_Resource_Rel4Tea Left Join {1} on {2} where {3} and vMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel not in (Select top {5} vMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase_Resource_Rel4Tea where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
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
public List<clsvMicroteachCase_Resource_Rel4TeaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase_Resource_Rel4TeaEN> arrObjLst = new List<clsvMicroteachCase_Resource_Rel4TeaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetObjLst)", objException.Message));
}
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase_Resource_Rel4TeaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase_Resource_Rel4Tea(ref clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where IdMicroteachCaseResourceRel = " + ""+ objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileType = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsMain = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.Memo = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objDT.Rows[0][convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetvMicroteachCase_Resource_Rel4Tea)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase_Resource_Rel4TeaEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
 objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvMicroteachCase_Resource_Rel4TeaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase_Resource_Rel4TeaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(), //课例等级Id
microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(), //拥有者姓名
TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(), //教师姓名
IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(), //学院名称
EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(), //进校日期
CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(), //学院ID
EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(), //EntryYear
IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(), //备注
CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim() //学院名称简写
};
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4TeaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel4TeaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetObjByDataRowvMicroteachCase_Resource_Rel4Tea)", objException.Message));
}
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4TeaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase_Resource_Rel4TeaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN = new clsvMicroteachCase_Resource_Rel4TeaEN();
try
{
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase = objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel = objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName = objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline = objRow[convMicroteachCase_Resource_Rel4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName = objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill = objRow[convMicroteachCase_Resource_Rel4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType = objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId = objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText = objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase_Resource_Rel4TeaEN.OwnerId = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase_Resource_Rel4TeaEN.OwnerName = objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaEN.TeacherID = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherID].ToString().Trim(); //教师工号
objvMicroteachCase_Resource_Rel4TeaEN.TeacherName = objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege = objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase_Resource_Rel4TeaEN.CollegeName = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase_Resource_Rel4TeaEN.EntryDate = objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase_Resource_Rel4TeaEN.CollegeID = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCase_Resource_Rel4TeaEN.EntryYear = objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase_Resource_Rel4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId = objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount4Case = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.IdResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResource].ToString().Trim(); //资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceID].ToString().Trim(); //资源ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceName].ToString().Trim(); //资源名称
objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource = objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaEN.IdFile = objRow[convMicroteachCase_Resource_Rel4Tea.IdFile] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdFile].ToString().Trim(); //文件流水号
objvMicroteachCase_Resource_Rel4TeaEN.FileName = objRow[convMicroteachCase_Resource_Rel4Tea.FileName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileName].ToString().Trim(); //文件名称
objvMicroteachCase_Resource_Rel4TeaEN.FileType = objRow[convMicroteachCase_Resource_Rel4Tea.FileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileType].ToString().Trim(); //文件类型
objvMicroteachCase_Resource_Rel4TeaEN.SaveDate = objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileSize = objRow[convMicroteachCase_Resource_Rel4Tea.FileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileSize].ToString().Trim(); //文件大小
objvMicroteachCase_Resource_Rel4TeaEN.SaveTime = objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.SaveTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID = objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginalName].ToString().Trim(); //文件原名
objvMicroteachCase_Resource_Rel4TeaEN.FileDirName = objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileDirName].ToString().Trim(); //文件目录名
objvMicroteachCase_Resource_Rel4TeaEN.FileRename = objRow[convMicroteachCase_Resource_Rel4Tea.FileRename] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileRename].ToString().Trim(); //文件新名
objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpDate].ToString().Trim(); //创建日期
objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime = objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileUpTime].ToString().Trim(); //创建时间
objvMicroteachCase_Resource_Rel4TeaEN.SaveMode = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.SaveMode].ToString().Trim()); //文件存放方式
objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType = objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdResourceType].ToString().Trim(); //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ResourceOwner].ToString().Trim(); //上传者
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize = objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner = objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOriginName].ToString().Trim(); //原文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsExistFile = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsExistFile].ToString().Trim()); //是否存在文件
objvMicroteachCase_Resource_Rel4TeaEN.FileNewName = objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileNewName].ToString().Trim(); //新文件名
objvMicroteachCase_Resource_Rel4TeaEN.FileOldName = objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.FileOldName].ToString().Trim(); //旧文件名
objvMicroteachCase_Resource_Rel4TeaEN.IsMain = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsMain].ToString().Trim()); //是否主资源
objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode = objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase_Resource_Rel4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase_Resource_Rel4TeaEN.IndexNO = objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.IndexNO].ToString().Trim()); //序号
objvMicroteachCase_Resource_Rel4TeaEN.BrowseCount = objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase_Resource_Rel4Tea.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCase_Resource_Rel4TeaEN.UpdDate = objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdDate].ToString().Trim(); //修改日期
objvMicroteachCase_Resource_Rel4TeaEN.UpdUser = objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.UpdUser].ToString().Trim(); //修改人
objvMicroteachCase_Resource_Rel4TeaEN.Memo = objRow[convMicroteachCase_Resource_Rel4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA = objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase_Resource_Rel4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase_Resource_Rel4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase_Resource_Rel4TeaEN;
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
objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCaseResourceRel, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMicroteachCase_Resource_Rel4Tea where " + strCondition;
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
 /// <param name = "lngIdMicroteachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroteachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel4Tea", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase_Resource_Rel4TeaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase_Resource_Rel4Tea", strCondition))
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
objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase_Resource_Rel4Tea");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase_Resource_Rel4TeaENT">目标对象</param>
public void CopyTo(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENS, clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaENT)
{
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCaseResourceRel = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdMicroteachCase = objvMicroteachCase_Resource_Rel4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseID = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseName = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTheme = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDate = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseTime = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase_Resource_Rel4TeaENT.MicroteachCaseDateIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase_Resource_Rel4TeaENT.IdStudyLevel = objvMicroteachCase_Resource_Rel4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase_Resource_Rel4TeaENT.StudyLevelName = objvMicroteachCase_Resource_Rel4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachingPlan = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase_Resource_Rel4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase_Resource_Rel4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase_Resource_Rel4TeaENT.IdDiscipline = objvMicroteachCase_Resource_Rel4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineID = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineID; //学科ID
objvMicroteachCase_Resource_Rel4TeaENT.DisciplineName = objvMicroteachCase_Resource_Rel4TeaENS.DisciplineName; //学科名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionID = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionName = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase_Resource_Rel4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase_Resource_Rel4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase_Resource_Rel4TeaENT.IdTeachSkill = objvMicroteachCase_Resource_Rel4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillID = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeName = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillName = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillTheory = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase_Resource_Rel4TeaENT.TeachSkillOperMethod = objvMicroteachCase_Resource_Rel4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase_Resource_Rel4TeaENT.IdSkillType = objvMicroteachCase_Resource_Rel4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.SkillTypeID = objvMicroteachCase_Resource_Rel4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase_Resource_Rel4TeaENT.CaseLevelId = objvMicroteachCase_Resource_Rel4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase_Resource_Rel4TeaENT.microteachCaseText = objvMicroteachCase_Resource_Rel4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase_Resource_Rel4TeaENT.OwnerId = objvMicroteachCase_Resource_Rel4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase_Resource_Rel4TeaENT.OwnerName = objvMicroteachCase_Resource_Rel4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase_Resource_Rel4TeaENT.TeacherID = objvMicroteachCase_Resource_Rel4TeaENS.TeacherID; //教师工号
objvMicroteachCase_Resource_Rel4TeaENT.TeacherName = objvMicroteachCase_Resource_Rel4TeaENS.TeacherName; //教师姓名
objvMicroteachCase_Resource_Rel4TeaENT.IdXzCollege = objvMicroteachCase_Resource_Rel4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase_Resource_Rel4TeaENT.CollegeName = objvMicroteachCase_Resource_Rel4TeaENS.CollegeName; //学院名称
objvMicroteachCase_Resource_Rel4TeaENT.EntryDate = objvMicroteachCase_Resource_Rel4TeaENS.EntryDate; //进校日期
objvMicroteachCase_Resource_Rel4TeaENT.CollegeID = objvMicroteachCase_Resource_Rel4TeaENS.CollegeID; //学院ID
objvMicroteachCase_Resource_Rel4TeaENT.EntryYear = objvMicroteachCase_Resource_Rel4TeaENS.EntryYear; //EntryYear
objvMicroteachCase_Resource_Rel4TeaENT.IsDualVideo = objvMicroteachCase_Resource_Rel4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase_Resource_Rel4TeaENT.UserTypeId = objvMicroteachCase_Resource_Rel4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeId = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase_Resource_Rel4TeaENT.RecommendedDegreeName = objvMicroteachCase_Resource_Rel4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount4Case = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.IdResource = objvMicroteachCase_Resource_Rel4TeaENS.IdResource; //资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceID; //资源ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceName; //资源名称
objvMicroteachCase_Resource_Rel4TeaENT.IdFtpResource = objvMicroteachCase_Resource_Rel4TeaENS.IdFtpResource; //FTP资源流水号
objvMicroteachCase_Resource_Rel4TeaENT.IdFile = objvMicroteachCase_Resource_Rel4TeaENS.IdFile; //文件流水号
objvMicroteachCase_Resource_Rel4TeaENT.FileName = objvMicroteachCase_Resource_Rel4TeaENS.FileName; //文件名称
objvMicroteachCase_Resource_Rel4TeaENT.FileType = objvMicroteachCase_Resource_Rel4TeaENS.FileType; //文件类型
objvMicroteachCase_Resource_Rel4TeaENT.SaveDate = objvMicroteachCase_Resource_Rel4TeaENS.SaveDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileSize = objvMicroteachCase_Resource_Rel4TeaENS.FileSize; //文件大小
objvMicroteachCase_Resource_Rel4TeaENT.SaveTime = objvMicroteachCase_Resource_Rel4TeaENS.SaveTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.FtpResourceID = objvMicroteachCase_Resource_Rel4TeaENS.FtpResourceID; //FTP资源ID
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginalName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginalName; //文件原名
objvMicroteachCase_Resource_Rel4TeaENT.FileDirName = objvMicroteachCase_Resource_Rel4TeaENS.FileDirName; //文件目录名
objvMicroteachCase_Resource_Rel4TeaENT.FileRename = objvMicroteachCase_Resource_Rel4TeaENS.FileRename; //文件新名
objvMicroteachCase_Resource_Rel4TeaENT.FileUpDate = objvMicroteachCase_Resource_Rel4TeaENS.FileUpDate; //创建日期
objvMicroteachCase_Resource_Rel4TeaENT.FileUpTime = objvMicroteachCase_Resource_Rel4TeaENS.FileUpTime; //创建时间
objvMicroteachCase_Resource_Rel4TeaENT.SaveMode = objvMicroteachCase_Resource_Rel4TeaENS.SaveMode; //文件存放方式
objvMicroteachCase_Resource_Rel4TeaENT.IdResourceType = objvMicroteachCase_Resource_Rel4TeaENS.IdResourceType; //资源类型流水号
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeID = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeID; //资源类型ID
objvMicroteachCase_Resource_Rel4TeaENT.ResourceTypeName = objvMicroteachCase_Resource_Rel4TeaENS.ResourceTypeName; //资源类型名称
objvMicroteachCase_Resource_Rel4TeaENT.ResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ResourceOwner; //上传者
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileType = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileType; //ftp文件类型
objvMicroteachCase_Resource_Rel4TeaENT.ftpFileSize = objvMicroteachCase_Resource_Rel4TeaENS.ftpFileSize; //ftp文件大小
objvMicroteachCase_Resource_Rel4TeaENT.ftpResourceOwner = objvMicroteachCase_Resource_Rel4TeaENS.ftpResourceOwner; //Ftp资源拥有者
objvMicroteachCase_Resource_Rel4TeaENT.FileOriginName = objvMicroteachCase_Resource_Rel4TeaENS.FileOriginName; //原文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsExistFile = objvMicroteachCase_Resource_Rel4TeaENS.IsExistFile; //是否存在文件
objvMicroteachCase_Resource_Rel4TeaENT.FileNewName = objvMicroteachCase_Resource_Rel4TeaENS.FileNewName; //新文件名
objvMicroteachCase_Resource_Rel4TeaENT.FileOldName = objvMicroteachCase_Resource_Rel4TeaENS.FileOldName; //旧文件名
objvMicroteachCase_Resource_Rel4TeaENT.IsMain = objvMicroteachCase_Resource_Rel4TeaENS.IsMain; //是否主资源
objvMicroteachCase_Resource_Rel4TeaENT.IdUsingMode = objvMicroteachCase_Resource_Rel4TeaENS.IdUsingMode; //资源使用模式流水号
objvMicroteachCase_Resource_Rel4TeaENT.IsVisible = objvMicroteachCase_Resource_Rel4TeaENS.IsVisible; //是否显示
objvMicroteachCase_Resource_Rel4TeaENT.IndexNO = objvMicroteachCase_Resource_Rel4TeaENS.IndexNO; //序号
objvMicroteachCase_Resource_Rel4TeaENT.BrowseCount = objvMicroteachCase_Resource_Rel4TeaENS.BrowseCount; //浏览次数
objvMicroteachCase_Resource_Rel4TeaENT.UpdDate = objvMicroteachCase_Resource_Rel4TeaENS.UpdDate; //修改日期
objvMicroteachCase_Resource_Rel4TeaENT.UpdUser = objvMicroteachCase_Resource_Rel4TeaENS.UpdUser; //修改人
objvMicroteachCase_Resource_Rel4TeaENT.Memo = objvMicroteachCase_Resource_Rel4TeaENS.Memo; //备注
objvMicroteachCase_Resource_Rel4TeaENT.CollegeNameA = objvMicroteachCase_Resource_Rel4TeaENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase_Resource_Rel4TeaEN objvMicroteachCase_Resource_Rel4TeaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase, 8, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName, 100, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme, 200, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime, 6, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn, 8, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel, 4, convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName, 50, convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn, 6, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline, 4, convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID, 4, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName, 50, convMicroteachCase_Resource_Rel4Tea.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID, 4, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName, 200, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill, 8, convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID, 8, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName, 50, convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName, 50, convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory, 8000, convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod, 2000, convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType, 4, convMicroteachCase_Resource_Rel4Tea.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID, 4, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId, 2, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText, 8000, convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.OwnerId, 20, convMicroteachCase_Resource_Rel4Tea.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.OwnerName, 30, convMicroteachCase_Resource_Rel4Tea.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeacherID, 12, convMicroteachCase_Resource_Rel4Tea.TeacherID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.TeacherName, 50, convMicroteachCase_Resource_Rel4Tea.TeacherName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege, 4, convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.CollegeName, 100, convMicroteachCase_Resource_Rel4Tea.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.EntryDate, 8, convMicroteachCase_Resource_Rel4Tea.EntryDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.CollegeID, 4, convMicroteachCase_Resource_Rel4Tea.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.EntryYear, 8, convMicroteachCase_Resource_Rel4Tea.EntryYear);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId, 2, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId, 2, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName, 30, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdResource, 8, convMicroteachCase_Resource_Rel4Tea.IdResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ResourceID, 8, convMicroteachCase_Resource_Rel4Tea.ResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ResourceName, 100, convMicroteachCase_Resource_Rel4Tea.ResourceName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource, 8, convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdFile, 8, convMicroteachCase_Resource_Rel4Tea.IdFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileName, 500, convMicroteachCase_Resource_Rel4Tea.FileName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileType, 30, convMicroteachCase_Resource_Rel4Tea.FileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.SaveDate, 8, convMicroteachCase_Resource_Rel4Tea.SaveDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileSize, 50, convMicroteachCase_Resource_Rel4Tea.FileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.SaveTime, 6, convMicroteachCase_Resource_Rel4Tea.SaveTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID, 8, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName, 200, convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileDirName, 200, convMicroteachCase_Resource_Rel4Tea.FileDirName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileRename, 200, convMicroteachCase_Resource_Rel4Tea.FileRename);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate, 8, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime, 6, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType, 4, convMicroteachCase_Resource_Rel4Tea.IdResourceType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID, 4, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName, 50, convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType, 30, convMicroteachCase_Resource_Rel4Tea.ftpFileType);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize, 50, convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner, 50, convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName, 500, convMicroteachCase_Resource_Rel4Tea.FileOriginName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileNewName, 530, convMicroteachCase_Resource_Rel4Tea.FileNewName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.FileOldName, 530, convMicroteachCase_Resource_Rel4Tea.FileOldName);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode, 4, convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.UpdDate, 20, convMicroteachCase_Resource_Rel4Tea.UpdDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.UpdUser, 20, convMicroteachCase_Resource_Rel4Tea.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.Memo, 1000, convMicroteachCase_Resource_Rel4Tea.Memo);
clsCheckSql.CheckFieldLen(objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA, 12, convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdMicroteachCase, convMicroteachCase_Resource_Rel4Tea.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseID, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseName, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTheme, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDate, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseTime, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroteachCaseDateIn, convMicroteachCase_Resource_Rel4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdStudyLevel, convMicroteachCase_Resource_Rel4Tea.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.StudyLevelName, convMicroteachCase_Resource_Rel4Tea.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdTeachingPlan, convMicroteachCase_Resource_Rel4Tea.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.MicroTeachCaseTimeIn, convMicroteachCase_Resource_Rel4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdDiscipline, convMicroteachCase_Resource_Rel4Tea.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.DisciplineID, convMicroteachCase_Resource_Rel4Tea.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.DisciplineName, convMicroteachCase_Resource_Rel4Tea.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionID, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.senateGaugeVersionName, convMicroteachCase_Resource_Rel4Tea.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdTeachSkill, convMicroteachCase_Resource_Rel4Tea.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillID, convMicroteachCase_Resource_Rel4Tea.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeName, convMicroteachCase_Resource_Rel4Tea.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillName, convMicroteachCase_Resource_Rel4Tea.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillTheory, convMicroteachCase_Resource_Rel4Tea.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeachSkillOperMethod, convMicroteachCase_Resource_Rel4Tea.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdSkillType, convMicroteachCase_Resource_Rel4Tea.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.SkillTypeID, convMicroteachCase_Resource_Rel4Tea.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.CaseLevelId, convMicroteachCase_Resource_Rel4Tea.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.microteachCaseText, convMicroteachCase_Resource_Rel4Tea.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.OwnerId, convMicroteachCase_Resource_Rel4Tea.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.OwnerName, convMicroteachCase_Resource_Rel4Tea.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeacherID, convMicroteachCase_Resource_Rel4Tea.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.TeacherName, convMicroteachCase_Resource_Rel4Tea.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdXzCollege, convMicroteachCase_Resource_Rel4Tea.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.CollegeName, convMicroteachCase_Resource_Rel4Tea.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.EntryDate, convMicroteachCase_Resource_Rel4Tea.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.CollegeID, convMicroteachCase_Resource_Rel4Tea.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.EntryYear, convMicroteachCase_Resource_Rel4Tea.EntryYear);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.UserTypeId, convMicroteachCase_Resource_Rel4Tea.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeId, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.RecommendedDegreeName, convMicroteachCase_Resource_Rel4Tea.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdResource, convMicroteachCase_Resource_Rel4Tea.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ResourceID, convMicroteachCase_Resource_Rel4Tea.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ResourceName, convMicroteachCase_Resource_Rel4Tea.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdFtpResource, convMicroteachCase_Resource_Rel4Tea.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdFile, convMicroteachCase_Resource_Rel4Tea.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileName, convMicroteachCase_Resource_Rel4Tea.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileType, convMicroteachCase_Resource_Rel4Tea.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.SaveDate, convMicroteachCase_Resource_Rel4Tea.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileSize, convMicroteachCase_Resource_Rel4Tea.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.SaveTime, convMicroteachCase_Resource_Rel4Tea.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FtpResourceID, convMicroteachCase_Resource_Rel4Tea.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileOriginalName, convMicroteachCase_Resource_Rel4Tea.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileDirName, convMicroteachCase_Resource_Rel4Tea.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileRename, convMicroteachCase_Resource_Rel4Tea.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileUpDate, convMicroteachCase_Resource_Rel4Tea.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileUpTime, convMicroteachCase_Resource_Rel4Tea.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdResourceType, convMicroteachCase_Resource_Rel4Tea.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeID, convMicroteachCase_Resource_Rel4Tea.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ResourceTypeName, convMicroteachCase_Resource_Rel4Tea.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ResourceOwner, convMicroteachCase_Resource_Rel4Tea.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ftpFileType, convMicroteachCase_Resource_Rel4Tea.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ftpFileSize, convMicroteachCase_Resource_Rel4Tea.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.ftpResourceOwner, convMicroteachCase_Resource_Rel4Tea.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileOriginName, convMicroteachCase_Resource_Rel4Tea.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileNewName, convMicroteachCase_Resource_Rel4Tea.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.FileOldName, convMicroteachCase_Resource_Rel4Tea.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.IdUsingMode, convMicroteachCase_Resource_Rel4Tea.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.UpdDate, convMicroteachCase_Resource_Rel4Tea.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.UpdUser, convMicroteachCase_Resource_Rel4Tea.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.Memo, convMicroteachCase_Resource_Rel4Tea.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase_Resource_Rel4TeaEN.CollegeNameA, convMicroteachCase_Resource_Rel4Tea.CollegeNameA);
//检查外键字段长度
 objvMicroteachCase_Resource_Rel4TeaEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName);
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase_Resource_Rel4TeaEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase_Resource_Rel4TeaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}