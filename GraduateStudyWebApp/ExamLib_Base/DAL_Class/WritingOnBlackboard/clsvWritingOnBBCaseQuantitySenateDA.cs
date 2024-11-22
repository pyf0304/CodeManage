
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWritingOnBBCaseQuantitySenateDA
 表名:vWritingOnBBCaseQuantitySenate(01120446)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:11
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:板书点播(WritingOnBlackboard)
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
 /// vWritingOnBBCaseQuantitySenate(vWritingOnBBCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWritingOnBBCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvWritingOnBBCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWritingOnBBCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWritingOnBBCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWritingOnBBCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWritingOnBBCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable_vWritingOnBBCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCaseQuantitySenate.* from vWritingOnBBCaseQuantitySenate Left Join {1} on {2} where {3} and vWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vWritingOnBBCaseQuantitySenate.* from vWritingOnBBCaseQuantitySenate Left Join {1} on {2} where {3} and vWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWritingOnBBCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = new List<clsvWritingOnBBCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN();
try
{
objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseQuantitySenateEN.BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvWritingOnBBCaseQuantitySenateEN.SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvWritingOnBBCaseQuantitySenateEN.SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvWritingOnBBCaseQuantitySenateEN.SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvWritingOnBBCaseQuantitySenateEN.UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCaseQuantitySenateEN.CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseQuantitySenateEN.CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvWritingOnBBCaseQuantitySenateEN.SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvWritingOnBBCaseQuantitySenateEN.UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvWritingOnBBCaseQuantitySenateEN.UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvWritingOnBBCaseQuantitySenateEN.OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseQuantitySenateEN.StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseQuantitySenateEN.StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseQuantitySenateEN.OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseQuantitySenateEN);
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
public List<clsvWritingOnBBCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWritingOnBBCaseQuantitySenateEN> arrObjLst = new List<clsvWritingOnBBCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN();
try
{
objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseQuantitySenateEN.BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvWritingOnBBCaseQuantitySenateEN.SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvWritingOnBBCaseQuantitySenateEN.SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvWritingOnBBCaseQuantitySenateEN.SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvWritingOnBBCaseQuantitySenateEN.UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCaseQuantitySenateEN.CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseQuantitySenateEN.CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvWritingOnBBCaseQuantitySenateEN.SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvWritingOnBBCaseQuantitySenateEN.UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvWritingOnBBCaseQuantitySenateEN.UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvWritingOnBBCaseQuantitySenateEN.OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseQuantitySenateEN.StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseQuantitySenateEN.StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseQuantitySenateEN.OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvWritingOnBBCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWritingOnBBCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWritingOnBBCaseQuantitySenate(ref clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IsLeaved = TransNullToBool(objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserId = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.StuID = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.StuName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetvWritingOnBBCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvWritingOnBBCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN();
try
{
 objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvWritingOnBBCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWritingOnBBCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vWritingOnBBCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(), //板书案例流水号
WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(), //板书教学案例ID
WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(), //板书教学案例名称
WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(), //板书教学日期
BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IsLeaved = TransNullToBool(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()), //IsLeaved
SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(), //学工号
UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(), //学号
StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(), //姓名
OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(), //板书案例类型名称
IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvWritingOnBBCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN();
try
{
objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseQuantitySenateEN.BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvWritingOnBBCaseQuantitySenateEN.SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvWritingOnBBCaseQuantitySenateEN.SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvWritingOnBBCaseQuantitySenateEN.SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvWritingOnBBCaseQuantitySenateEN.UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCaseQuantitySenateEN.CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseQuantitySenateEN.CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvWritingOnBBCaseQuantitySenateEN.SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvWritingOnBBCaseQuantitySenateEN.UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvWritingOnBBCaseQuantitySenateEN.UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvWritingOnBBCaseQuantitySenateEN.OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseQuantitySenateEN.StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseQuantitySenateEN.StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseQuantitySenateEN.OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetObjByDataRowvWritingOnBBCaseQuantitySenate)", objException.Message));
}
objvWritingOnBBCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWritingOnBBCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN = new clsvWritingOnBBCaseQuantitySenateEN();
try
{
objvWritingOnBBCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateEN.FuncModuleId = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvWritingOnBBCaseQuantitySenateEN.FuncModuleName = objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase = objRow[convWritingOnBBCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType = objRow[convWritingOnBBCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName = objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase = objRow[convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase].ToString().Trim(); //板书案例流水号
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID].ToString().Trim(); //板书教学案例ID
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName].ToString().Trim(); //板书教学案例名称
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate].ToString().Trim(); //板书教学日期
objvWritingOnBBCaseQuantitySenateEN.BrowseCount = objRow[convWritingOnBBCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convWritingOnBBCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvWritingOnBBCaseQuantitySenateEN.SenateTheme = objRow[convWritingOnBBCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvWritingOnBBCaseQuantitySenateEN.SenateContent = objRow[convWritingOnBBCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvWritingOnBBCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvWritingOnBBCaseQuantitySenateEN.SenateDate = objRow[convWritingOnBBCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvWritingOnBBCaseQuantitySenateEN.SenateTime = objRow[convWritingOnBBCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName = objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convWritingOnBBCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvWritingOnBBCaseQuantitySenateEN.UpdUserName = objRow[convWritingOnBBCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvWritingOnBBCaseQuantitySenateEN.UpdUser = objRow[convWritingOnBBCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvWritingOnBBCaseQuantitySenateEN.CollegeID = objRow[convWritingOnBBCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvWritingOnBBCaseQuantitySenateEN.CollegeName = objRow[convWritingOnBBCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvWritingOnBBCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convWritingOnBBCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvWritingOnBBCaseQuantitySenateEN.SenateIp = objRow[convWritingOnBBCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId = objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvWritingOnBBCaseQuantitySenateEN.UserId = objRow[convWritingOnBBCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvWritingOnBBCaseQuantitySenateEN.UserName = objRow[convWritingOnBBCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvWritingOnBBCaseQuantitySenateEN.OwnerId = objRow[convWritingOnBBCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvWritingOnBBCaseQuantitySenateEN.StuID = objRow[convWritingOnBBCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvWritingOnBBCaseQuantitySenateEN.StuName = objRow[convWritingOnBBCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvWritingOnBBCaseQuantitySenateEN.OwnerName = objRow[convWritingOnBBCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId = objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName = objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName].ToString().Trim(); //板书案例类型名称
objvWritingOnBBCaseQuantitySenateEN.IdXzCollege = objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvWritingOnBBCaseQuantitySenateEN.CollegeNameA = objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convWritingOnBBCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvWritingOnBBCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWritingOnBBCaseQuantitySenateEN;
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
objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseQuantitySenateEN._CurrTabName, convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWritingOnBBCaseQuantitySenateEN._CurrTabName, convWritingOnBBCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vWritingOnBBCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWritingOnBBCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWritingOnBBCaseQuantitySenate", strCondition))
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
objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWritingOnBBCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWritingOnBBCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvWritingOnBBCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateENS, clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateENT)
{
objvWritingOnBBCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvWritingOnBBCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvWritingOnBBCaseQuantitySenateENT.FuncModuleId = objvWritingOnBBCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvWritingOnBBCaseQuantitySenateENT.FuncModuleName = objvWritingOnBBCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvWritingOnBBCaseQuantitySenateENT.IdMicroteachCase = objvWritingOnBBCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvWritingOnBBCaseQuantitySenateENT.IdAppraiseType = objvWritingOnBBCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvWritingOnBBCaseQuantitySenateENT.AppraiseTypeName = objvWritingOnBBCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvWritingOnBBCaseQuantitySenateENT.IdWritingOnBBCase = objvWritingOnBBCaseQuantitySenateENS.IdWritingOnBBCase; //板书案例流水号
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseID = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseID; //板书教学案例ID
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseName = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseName; //板书教学案例名称
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseDate = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseDate; //板书教学日期
objvWritingOnBBCaseQuantitySenateENT.BrowseCount = objvWritingOnBBCaseQuantitySenateENS.BrowseCount; //浏览次数
objvWritingOnBBCaseQuantitySenateENT.SenateTheme = objvWritingOnBBCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvWritingOnBBCaseQuantitySenateENT.SenateContent = objvWritingOnBBCaseQuantitySenateENS.SenateContent; //评价内容
objvWritingOnBBCaseQuantitySenateENT.SenateTotalScore = objvWritingOnBBCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvWritingOnBBCaseQuantitySenateENT.SenateDate = objvWritingOnBBCaseQuantitySenateENS.SenateDate; //评价日期
objvWritingOnBBCaseQuantitySenateENT.SenateTime = objvWritingOnBBCaseQuantitySenateENS.SenateTime; //评价时间
objvWritingOnBBCaseQuantitySenateENT.IdSenateGaugeVersion = objvWritingOnBBCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionID = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionName = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvWritingOnBBCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvWritingOnBBCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvWritingOnBBCaseQuantitySenateENT.UpdUserName = objvWritingOnBBCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvWritingOnBBCaseQuantitySenateENT.UpdUser = objvWritingOnBBCaseQuantitySenateENS.UpdUser; //修改人
objvWritingOnBBCaseQuantitySenateENT.CollegeID = objvWritingOnBBCaseQuantitySenateENS.CollegeID; //学院ID
objvWritingOnBBCaseQuantitySenateENT.CollegeName = objvWritingOnBBCaseQuantitySenateENS.CollegeName; //学院名称
objvWritingOnBBCaseQuantitySenateENT.IsLeaved = objvWritingOnBBCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvWritingOnBBCaseQuantitySenateENT.SenateIp = objvWritingOnBBCaseQuantitySenateENS.SenateIp; //评议Ip
objvWritingOnBBCaseQuantitySenateENT.StuIdTeacherId = objvWritingOnBBCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvWritingOnBBCaseQuantitySenateENT.UserId = objvWritingOnBBCaseQuantitySenateENS.UserId; //用户ID
objvWritingOnBBCaseQuantitySenateENT.UserName = objvWritingOnBBCaseQuantitySenateENS.UserName; //用户名
objvWritingOnBBCaseQuantitySenateENT.OwnerId = objvWritingOnBBCaseQuantitySenateENS.OwnerId; //拥有者Id
objvWritingOnBBCaseQuantitySenateENT.StuID = objvWritingOnBBCaseQuantitySenateENS.StuID; //学号
objvWritingOnBBCaseQuantitySenateENT.StuName = objvWritingOnBBCaseQuantitySenateENS.StuName; //姓名
objvWritingOnBBCaseQuantitySenateENT.OwnerName = objvWritingOnBBCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvWritingOnBBCaseQuantitySenateENT.UserNameWithUserId = objvWritingOnBBCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvWritingOnBBCaseQuantitySenateENT.WritingOnBBCaseTypeName = objvWritingOnBBCaseQuantitySenateENS.WritingOnBBCaseTypeName; //板书案例类型名称
objvWritingOnBBCaseQuantitySenateENT.IdXzCollege = objvWritingOnBBCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvWritingOnBBCaseQuantitySenateENT.CollegeNameA = objvWritingOnBBCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWritingOnBBCaseQuantitySenateEN objvWritingOnBBCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.FuncModuleId, 4, convWritingOnBBCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.FuncModuleName, 30, convWritingOnBBCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase, 8, convWritingOnBBCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType, 4, convWritingOnBBCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName, 50, convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase, 8, convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName, 100, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate, 8, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.SenateTheme, 200, convWritingOnBBCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.SenateContent, 2000, convWritingOnBBCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.SenateDate, 8, convWritingOnBBCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.SenateTime, 6, convWritingOnBBCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID, 4, convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName, 200, convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.UpdUserName, 20, convWritingOnBBCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.UpdUser, 20, convWritingOnBBCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.CollegeID, 4, convWritingOnBBCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.CollegeName, 100, convWritingOnBBCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.SenateIp, 50, convWritingOnBBCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId, 20, convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.UserId, 18, convWritingOnBBCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.UserName, 30, convWritingOnBBCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.OwnerId, 20, convWritingOnBBCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.StuID, 20, convWritingOnBBCaseQuantitySenate.StuID);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.StuName, 50, convWritingOnBBCaseQuantitySenate.StuName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.OwnerName, 30, convWritingOnBBCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId, 51, convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName, 50, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.IdXzCollege, 4, convWritingOnBBCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvWritingOnBBCaseQuantitySenateEN.CollegeNameA, 12, convWritingOnBBCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.FuncModuleId, convWritingOnBBCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.FuncModuleName, convWritingOnBBCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.IdMicroteachCase, convWritingOnBBCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.IdAppraiseType, convWritingOnBBCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.AppraiseTypeName, convWritingOnBBCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.IdWritingOnBBCase, convWritingOnBBCaseQuantitySenate.IdWritingOnBBCase);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseID, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseName, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseDate, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.SenateTheme, convWritingOnBBCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.SenateContent, convWritingOnBBCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.SenateDate, convWritingOnBBCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.SenateTime, convWritingOnBBCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.IdSenateGaugeVersion, convWritingOnBBCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionID, convWritingOnBBCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.senateGaugeVersionName, convWritingOnBBCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.UpdUserName, convWritingOnBBCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.UpdUser, convWritingOnBBCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.CollegeID, convWritingOnBBCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.CollegeName, convWritingOnBBCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.SenateIp, convWritingOnBBCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.StuIdTeacherId, convWritingOnBBCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.UserId, convWritingOnBBCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.UserName, convWritingOnBBCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.OwnerId, convWritingOnBBCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.StuID, convWritingOnBBCaseQuantitySenate.StuID);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.StuName, convWritingOnBBCaseQuantitySenate.StuName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.OwnerName, convWritingOnBBCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.UserNameWithUserId, convWritingOnBBCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.WritingOnBBCaseTypeName, convWritingOnBBCaseQuantitySenate.WritingOnBBCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.IdXzCollege, convWritingOnBBCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvWritingOnBBCaseQuantitySenateEN.CollegeNameA, convWritingOnBBCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvWritingOnBBCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWritingOnBBCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvWritingOnBBCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}