
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCaseQuantitySenateDA
 表名:vMicroteachCaseQuantitySenate(01120444)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:51
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
 /// v微格教学教师量化评价视图(vMicroteachCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvMicroteachCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable_vMicroteachCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseQuantitySenate.* from vMicroteachCaseQuantitySenate Left Join {1} on {2} where {3} and vMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCaseQuantitySenate.* from vMicroteachCaseQuantitySenate Left Join {1} on {2} where {3} and vMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
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
public List<clsvMicroteachCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCaseQuantitySenateEN> arrObjLst = new List<clsvMicroteachCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCaseQuantitySenate(ref clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserId = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserName = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.Memo = objDT.Rows[0][convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetvMicroteachCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
 objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvMicroteachCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(), //备注
IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetObjByDataRowvMicroteachCaseQuantitySenate)", objException.Message));
}
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN = new clsvMicroteachCaseQuantitySenateEN();
try
{
objvMicroteachCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvMicroteachCaseQuantitySenateEN.FuncModuleId = objRow[convMicroteachCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvMicroteachCaseQuantitySenateEN.FuncModuleName = objRow[convMicroteachCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvMicroteachCaseQuantitySenateEN.IdMicroteachCase = objRow[convMicroteachCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCaseQuantitySenateEN.IdAppraiseType = objRow[convMicroteachCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvMicroteachCaseQuantitySenateEN.AppraiseTypeName = objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvMicroteachCaseQuantitySenateEN.SenateTheme = objRow[convMicroteachCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvMicroteachCaseQuantitySenateEN.SenateContent = objRow[convMicroteachCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvMicroteachCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convMicroteachCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvMicroteachCaseQuantitySenateEN.SenateDate = objRow[convMicroteachCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvMicroteachCaseQuantitySenateEN.SenateTime = objRow[convMicroteachCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvMicroteachCaseQuantitySenateEN.BrowseCount = objRow[convMicroteachCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCaseQuantitySenateEN.MicroteachCaseID = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCaseQuantitySenateEN.MicroteachCaseName = objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName = objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCaseQuantitySenateEN.CollegeID = objRow[convMicroteachCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvMicroteachCaseQuantitySenateEN.CollegeName = objRow[convMicroteachCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCaseQuantitySenateEN.UserId = objRow[convMicroteachCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvMicroteachCaseQuantitySenateEN.UserName = objRow[convMicroteachCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvMicroteachCaseQuantitySenateEN.OwnerId = objRow[convMicroteachCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCaseQuantitySenateEN.OwnerName = objRow[convMicroteachCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCaseQuantitySenateEN.OwnerNameWithId = objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvMicroteachCaseQuantitySenateEN.SenateIp = objRow[convMicroteachCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvMicroteachCaseQuantitySenateEN.UserNameWithUserId = objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvMicroteachCaseQuantitySenateEN.UserKindId = objRow[convMicroteachCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvMicroteachCaseQuantitySenateEN.UserKindName = objRow[convMicroteachCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvMicroteachCaseQuantitySenateEN.UserTypeId = objRow[convMicroteachCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCaseQuantitySenateEN.UserTypeName = objRow[convMicroteachCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvMicroteachCaseQuantitySenateEN.UpdUserName = objRow[convMicroteachCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvMicroteachCaseQuantitySenateEN.UpdUser = objRow[convMicroteachCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvMicroteachCaseQuantitySenateEN.Memo = objRow[convMicroteachCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvMicroteachCaseQuantitySenateEN.IdXzCollege = objRow[convMicroteachCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCaseQuantitySenateEN.CollegeNameA = objRow[convMicroteachCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCaseQuantitySenateEN;
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
objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseQuantitySenateEN._CurrTabName, convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCaseQuantitySenateEN._CurrTabName, convMicroteachCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vMicroteachCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCaseQuantitySenate", strCondition))
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
objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvMicroteachCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENS, clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateENT)
{
objvMicroteachCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvMicroteachCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvMicroteachCaseQuantitySenateENT.FuncModuleId = objvMicroteachCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvMicroteachCaseQuantitySenateENT.FuncModuleName = objvMicroteachCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvMicroteachCaseQuantitySenateENT.IdMicroteachCase = objvMicroteachCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCaseQuantitySenateENT.IdAppraiseType = objvMicroteachCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvMicroteachCaseQuantitySenateENT.AppraiseTypeName = objvMicroteachCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvMicroteachCaseQuantitySenateENT.SenateTheme = objvMicroteachCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvMicroteachCaseQuantitySenateENT.SenateContent = objvMicroteachCaseQuantitySenateENS.SenateContent; //评价内容
objvMicroteachCaseQuantitySenateENT.SenateTotalScore = objvMicroteachCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvMicroteachCaseQuantitySenateENT.SenateDate = objvMicroteachCaseQuantitySenateENS.SenateDate; //评价日期
objvMicroteachCaseQuantitySenateENT.SenateTime = objvMicroteachCaseQuantitySenateENS.SenateTime; //评价时间
objvMicroteachCaseQuantitySenateENT.BrowseCount = objvMicroteachCaseQuantitySenateENS.BrowseCount; //浏览次数
objvMicroteachCaseQuantitySenateENT.IdSenateGaugeVersion = objvMicroteachCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCaseQuantitySenateENT.MicroteachCaseDate = objvMicroteachCaseQuantitySenateENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCaseQuantitySenateENT.MicroteachCaseID = objvMicroteachCaseQuantitySenateENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCaseQuantitySenateENT.MicroteachCaseName = objvMicroteachCaseQuantitySenateENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCaseQuantitySenateENT.senateGaugeVersionID = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCaseQuantitySenateENT.senateGaugeVersionName = objvMicroteachCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCaseQuantitySenateENT.CollegeID = objvMicroteachCaseQuantitySenateENS.CollegeID; //学院ID
objvMicroteachCaseQuantitySenateENT.CollegeName = objvMicroteachCaseQuantitySenateENS.CollegeName; //学院名称
objvMicroteachCaseQuantitySenateENT.UserId = objvMicroteachCaseQuantitySenateENS.UserId; //用户ID
objvMicroteachCaseQuantitySenateENT.UserName = objvMicroteachCaseQuantitySenateENS.UserName; //用户名
objvMicroteachCaseQuantitySenateENT.OwnerId = objvMicroteachCaseQuantitySenateENS.OwnerId; //拥有者Id
objvMicroteachCaseQuantitySenateENT.OwnerName = objvMicroteachCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvMicroteachCaseQuantitySenateENT.OwnerNameWithId = objvMicroteachCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvMicroteachCaseQuantitySenateENT.SenateIp = objvMicroteachCaseQuantitySenateENS.SenateIp; //评议Ip
objvMicroteachCaseQuantitySenateENT.UserNameWithUserId = objvMicroteachCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvMicroteachCaseQuantitySenateENT.UserKindId = objvMicroteachCaseQuantitySenateENS.UserKindId; //用户类别Id
objvMicroteachCaseQuantitySenateENT.UserKindName = objvMicroteachCaseQuantitySenateENS.UserKindName; //用户类别名
objvMicroteachCaseQuantitySenateENT.UserTypeId = objvMicroteachCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvMicroteachCaseQuantitySenateENT.UserTypeName = objvMicroteachCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvMicroteachCaseQuantitySenateENT.UpdUserName = objvMicroteachCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvMicroteachCaseQuantitySenateENT.UpdUser = objvMicroteachCaseQuantitySenateENS.UpdUser; //修改人
objvMicroteachCaseQuantitySenateENT.Memo = objvMicroteachCaseQuantitySenateENS.Memo; //备注
objvMicroteachCaseQuantitySenateENT.IdXzCollege = objvMicroteachCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvMicroteachCaseQuantitySenateENT.CollegeNameA = objvMicroteachCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCaseQuantitySenateEN objvMicroteachCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.FuncModuleId, 4, convMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.FuncModuleName, 30, convMicroteachCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.IdMicroteachCase, 8, convMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.IdAppraiseType, 4, convMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.AppraiseTypeName, 50, convMicroteachCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.SenateTheme, 200, convMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.SenateContent, 2000, convMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.SenateDate, 8, convMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.SenateTime, 6, convMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate, 8, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.MicroteachCaseID, 8, convMicroteachCaseQuantitySenate.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.MicroteachCaseName, 100, convMicroteachCaseQuantitySenate.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID, 4, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName, 200, convMicroteachCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.CollegeID, 4, convMicroteachCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.CollegeName, 100, convMicroteachCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserId, 18, convMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserName, 30, convMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.OwnerId, 20, convMicroteachCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.OwnerName, 30, convMicroteachCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.OwnerNameWithId, 51, convMicroteachCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.SenateIp, 50, convMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserNameWithUserId, 51, convMicroteachCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserKindId, 2, convMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserKindName, 30, convMicroteachCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserTypeId, 2, convMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UserTypeName, 20, convMicroteachCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UpdUserName, 20, convMicroteachCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.UpdUser, 20, convMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.Memo, 1000, convMicroteachCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.IdXzCollege, 4, convMicroteachCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCaseQuantitySenateEN.CollegeNameA, 12, convMicroteachCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.FuncModuleId, convMicroteachCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.FuncModuleName, convMicroteachCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.IdMicroteachCase, convMicroteachCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.IdAppraiseType, convMicroteachCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.AppraiseTypeName, convMicroteachCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.SenateTheme, convMicroteachCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.SenateContent, convMicroteachCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.SenateDate, convMicroteachCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.SenateTime, convMicroteachCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.IdSenateGaugeVersion, convMicroteachCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.MicroteachCaseDate, convMicroteachCaseQuantitySenate.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.MicroteachCaseID, convMicroteachCaseQuantitySenate.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.MicroteachCaseName, convMicroteachCaseQuantitySenate.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.senateGaugeVersionID, convMicroteachCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.senateGaugeVersionName, convMicroteachCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.CollegeID, convMicroteachCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.CollegeName, convMicroteachCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserId, convMicroteachCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserName, convMicroteachCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.OwnerId, convMicroteachCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.OwnerName, convMicroteachCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.OwnerNameWithId, convMicroteachCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.SenateIp, convMicroteachCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserNameWithUserId, convMicroteachCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserKindId, convMicroteachCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserKindName, convMicroteachCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserTypeId, convMicroteachCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UserTypeName, convMicroteachCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UpdUserName, convMicroteachCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.UpdUser, convMicroteachCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.Memo, convMicroteachCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.IdXzCollege, convMicroteachCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCaseQuantitySenateEN.CollegeNameA, convMicroteachCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvMicroteachCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}