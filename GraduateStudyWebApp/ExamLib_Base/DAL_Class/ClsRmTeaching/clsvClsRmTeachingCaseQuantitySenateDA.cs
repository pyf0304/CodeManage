
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClsRmTeachingCaseQuantitySenateDA
 表名:vClsRmTeachingCaseQuantitySenate(01120456)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// v课堂教学量化评议(vClsRmTeachingCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClsRmTeachingCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClsRmTeachingCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClsRmTeachingCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClsRmTeachingCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClsRmTeachingCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable_vClsRmTeachingCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCaseQuantitySenate.* from vClsRmTeachingCaseQuantitySenate Left Join {1} on {2} where {3} and vClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClsRmTeachingCaseQuantitySenate.* from vClsRmTeachingCaseQuantitySenate Left Join {1} on {2} where {3} and vClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClsRmTeachingCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = new List<clsvClsRmTeachingCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN();
try
{
objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateEN.UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvClsRmTeachingCaseQuantitySenateEN.UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvClsRmTeachingCaseQuantitySenateEN.Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseQuantitySenateEN);
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
public List<clsvClsRmTeachingCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClsRmTeachingCaseQuantitySenateEN> arrObjLst = new List<clsvClsRmTeachingCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN();
try
{
objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateEN.UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvClsRmTeachingCaseQuantitySenateEN.UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvClsRmTeachingCaseQuantitySenateEN.Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvClsRmTeachingCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClsRmTeachingCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClsRmTeachingCaseQuantitySenate(ref clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UserId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.Memo = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetvClsRmTeachingCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvClsRmTeachingCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN();
try
{
 objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvClsRmTeachingCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClsRmTeachingCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vClsRmTeachingCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN()
{
IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(), //课堂教学案例流水号
ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(), //课堂教学案例ID
ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(), //课堂教学案例名称
ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(), //课堂教学案例主题词
ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(), //课堂案例类型名称
ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(), //课堂教学日期
ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(), //课堂教学时间
ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(), //案例入库日期
ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(), //案例入库时间
UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()), //是否双视频
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(), //备注
UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim() //用户类型名称
};
objvClsRmTeachingCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN();
try
{
objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateEN.UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvClsRmTeachingCaseQuantitySenateEN.UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvClsRmTeachingCaseQuantitySenateEN.Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetObjByDataRowvClsRmTeachingCaseQuantitySenate)", objException.Message));
}
objvClsRmTeachingCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClsRmTeachingCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN = new clsvClsRmTeachingCaseQuantitySenateEN();
try
{
objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase = objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase].ToString().Trim(); //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID].ToString().Trim(); //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName].ToString().Trim(); //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme].ToString().Trim(); //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName].ToString().Trim(); //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate].ToString().Trim(); //课堂教学日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime].ToString().Trim(); //课堂教学时间
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn].ToString().Trim(); //案例入库日期
objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn = objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn].ToString().Trim(); //案例入库时间
objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId = objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateEN.OwnerId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvClsRmTeachingCaseQuantitySenateEN.OwnerName = objRow[convClsRmTeachingCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege = objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvClsRmTeachingCaseQuantitySenateEN.CollegeName = objRow[convClsRmTeachingCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId = objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateEN.CollegeID = objRow[convClsRmTeachingCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA = objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvClsRmTeachingCaseQuantitySenateEN.UserTypeId = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvClsRmTeachingCaseQuantitySenateEN.IsDualVideo = TransNullToBool(objRow[convClsRmTeachingCaseQuantitySenate.IsDualVideo].ToString().Trim()); //是否双视频
objvClsRmTeachingCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName = objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase = objRow[convClsRmTeachingCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType = objRow[convClsRmTeachingCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName = objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvClsRmTeachingCaseQuantitySenateEN.SenateTheme = objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvClsRmTeachingCaseQuantitySenateEN.SenateContent = objRow[convClsRmTeachingCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvClsRmTeachingCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvClsRmTeachingCaseQuantitySenateEN.SenateDate = objRow[convClsRmTeachingCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvClsRmTeachingCaseQuantitySenateEN.SenateTime = objRow[convClsRmTeachingCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvClsRmTeachingCaseQuantitySenateEN.SenateIp = objRow[convClsRmTeachingCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvClsRmTeachingCaseQuantitySenateEN.BrowseCount = objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClsRmTeachingCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convClsRmTeachingCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateEN.UserId = objRow[convClsRmTeachingCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvClsRmTeachingCaseQuantitySenateEN.UserName = objRow[convClsRmTeachingCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvClsRmTeachingCaseQuantitySenateEN.UserKindId = objRow[convClsRmTeachingCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvClsRmTeachingCaseQuantitySenateEN.UserKindName = objRow[convClsRmTeachingCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvClsRmTeachingCaseQuantitySenateEN.UpdUser = objRow[convClsRmTeachingCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvClsRmTeachingCaseQuantitySenateEN.UpdUserName = objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvClsRmTeachingCaseQuantitySenateEN.Memo = objRow[convClsRmTeachingCaseQuantitySenate.Memo] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.Memo].ToString().Trim(); //备注
objvClsRmTeachingCaseQuantitySenateEN.UserTypeName = objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convClsRmTeachingCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvClsRmTeachingCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClsRmTeachingCaseQuantitySenateEN;
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
objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName, convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName, convClsRmTeachingCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vClsRmTeachingCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClsRmTeachingCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClsRmTeachingCaseQuantitySenate", strCondition))
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
objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClsRmTeachingCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvClsRmTeachingCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateENS, clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateENT)
{
objvClsRmTeachingCaseQuantitySenateENT.IdClsRmTeachingCase = objvClsRmTeachingCaseQuantitySenateENS.IdClsRmTeachingCase; //课堂教学案例流水号
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseID = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseID; //课堂教学案例ID
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseName = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseName; //课堂教学案例名称
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTheme = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTheme; //课堂教学案例主题词
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTypeName = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTypeName; //课堂案例类型名称
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseDate = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseDate; //课堂教学日期
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTime = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTime; //课堂教学时间
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseDateIn = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseDateIn; //案例入库日期
objvClsRmTeachingCaseQuantitySenateENT.ClsRmTeachingCaseTimeIn = objvClsRmTeachingCaseQuantitySenateENS.ClsRmTeachingCaseTimeIn; //案例入库时间
objvClsRmTeachingCaseQuantitySenateENT.UserNameWithUserId = objvClsRmTeachingCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvClsRmTeachingCaseQuantitySenateENT.OwnerId = objvClsRmTeachingCaseQuantitySenateENS.OwnerId; //拥有者Id
objvClsRmTeachingCaseQuantitySenateENT.OwnerName = objvClsRmTeachingCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvClsRmTeachingCaseQuantitySenateENT.IdXzCollege = objvClsRmTeachingCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvClsRmTeachingCaseQuantitySenateENT.CollegeName = objvClsRmTeachingCaseQuantitySenateENS.CollegeName; //学院名称
objvClsRmTeachingCaseQuantitySenateENT.OwnerNameWithId = objvClsRmTeachingCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
objvClsRmTeachingCaseQuantitySenateENT.CollegeID = objvClsRmTeachingCaseQuantitySenateENS.CollegeID; //学院ID
objvClsRmTeachingCaseQuantitySenateENT.CollegeNameA = objvClsRmTeachingCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvClsRmTeachingCaseQuantitySenateENT.UserTypeId = objvClsRmTeachingCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvClsRmTeachingCaseQuantitySenateENT.IsDualVideo = objvClsRmTeachingCaseQuantitySenateENS.IsDualVideo; //是否双视频
objvClsRmTeachingCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvClsRmTeachingCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvClsRmTeachingCaseQuantitySenateENT.FuncModuleId = objvClsRmTeachingCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvClsRmTeachingCaseQuantitySenateENT.FuncModuleName = objvClsRmTeachingCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvClsRmTeachingCaseQuantitySenateENT.IdMicroteachCase = objvClsRmTeachingCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvClsRmTeachingCaseQuantitySenateENT.IdAppraiseType = objvClsRmTeachingCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvClsRmTeachingCaseQuantitySenateENT.AppraiseTypeName = objvClsRmTeachingCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvClsRmTeachingCaseQuantitySenateENT.SenateTheme = objvClsRmTeachingCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvClsRmTeachingCaseQuantitySenateENT.SenateContent = objvClsRmTeachingCaseQuantitySenateENS.SenateContent; //评价内容
objvClsRmTeachingCaseQuantitySenateENT.SenateTotalScore = objvClsRmTeachingCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvClsRmTeachingCaseQuantitySenateENT.SenateDate = objvClsRmTeachingCaseQuantitySenateENS.SenateDate; //评价日期
objvClsRmTeachingCaseQuantitySenateENT.SenateTime = objvClsRmTeachingCaseQuantitySenateENS.SenateTime; //评价时间
objvClsRmTeachingCaseQuantitySenateENT.SenateIp = objvClsRmTeachingCaseQuantitySenateENS.SenateIp; //评议Ip
objvClsRmTeachingCaseQuantitySenateENT.BrowseCount = objvClsRmTeachingCaseQuantitySenateENS.BrowseCount; //浏览次数
objvClsRmTeachingCaseQuantitySenateENT.IdSenateGaugeVersion = objvClsRmTeachingCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionID = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionName = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvClsRmTeachingCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvClsRmTeachingCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvClsRmTeachingCaseQuantitySenateENT.UserId = objvClsRmTeachingCaseQuantitySenateENS.UserId; //用户ID
objvClsRmTeachingCaseQuantitySenateENT.UserName = objvClsRmTeachingCaseQuantitySenateENS.UserName; //用户名
objvClsRmTeachingCaseQuantitySenateENT.UserKindId = objvClsRmTeachingCaseQuantitySenateENS.UserKindId; //用户类别Id
objvClsRmTeachingCaseQuantitySenateENT.UserKindName = objvClsRmTeachingCaseQuantitySenateENS.UserKindName; //用户类别名
objvClsRmTeachingCaseQuantitySenateENT.UpdUser = objvClsRmTeachingCaseQuantitySenateENS.UpdUser; //修改人
objvClsRmTeachingCaseQuantitySenateENT.UpdUserName = objvClsRmTeachingCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvClsRmTeachingCaseQuantitySenateENT.Memo = objvClsRmTeachingCaseQuantitySenateENS.Memo; //备注
objvClsRmTeachingCaseQuantitySenateENT.UserTypeName = objvClsRmTeachingCaseQuantitySenateENS.UserTypeName; //用户类型名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClsRmTeachingCaseQuantitySenateEN objvClsRmTeachingCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase, 8, convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName, 100, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme, 200, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName, 30, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn, 8, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn, 6, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId, 51, convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.OwnerId, 20, convClsRmTeachingCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.OwnerName, 30, convClsRmTeachingCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege, 4, convClsRmTeachingCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.CollegeName, 100, convClsRmTeachingCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId, 51, convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.CollegeID, 4, convClsRmTeachingCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA, 12, convClsRmTeachingCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserTypeId, 2, convClsRmTeachingCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId, 4, convClsRmTeachingCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName, 30, convClsRmTeachingCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase, 8, convClsRmTeachingCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType, 4, convClsRmTeachingCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName, 50, convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.SenateTheme, 200, convClsRmTeachingCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.SenateContent, 2000, convClsRmTeachingCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.SenateDate, 8, convClsRmTeachingCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.SenateTime, 6, convClsRmTeachingCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.SenateIp, 50, convClsRmTeachingCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID, 4, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName, 200, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserId, 18, convClsRmTeachingCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserName, 30, convClsRmTeachingCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserKindId, 2, convClsRmTeachingCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserKindName, 30, convClsRmTeachingCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UpdUser, 20, convClsRmTeachingCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UpdUserName, 20, convClsRmTeachingCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.Memo, 1000, convClsRmTeachingCaseQuantitySenate.Memo);
clsCheckSql.CheckFieldLen(objvClsRmTeachingCaseQuantitySenateEN.UserTypeName, 20, convClsRmTeachingCaseQuantitySenate.UserTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.IdClsRmTeachingCase, convClsRmTeachingCaseQuantitySenate.IdClsRmTeachingCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseID, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseName, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTheme, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTypeName, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDate, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTime, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseDateIn, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.ClsRmTeachingCaseTimeIn, convClsRmTeachingCaseQuantitySenate.ClsRmTeachingCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserNameWithUserId, convClsRmTeachingCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.OwnerId, convClsRmTeachingCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.OwnerName, convClsRmTeachingCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.IdXzCollege, convClsRmTeachingCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.CollegeName, convClsRmTeachingCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.OwnerNameWithId, convClsRmTeachingCaseQuantitySenate.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.CollegeID, convClsRmTeachingCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.CollegeNameA, convClsRmTeachingCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserTypeId, convClsRmTeachingCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.FuncModuleId, convClsRmTeachingCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.FuncModuleName, convClsRmTeachingCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.IdMicroteachCase, convClsRmTeachingCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.IdAppraiseType, convClsRmTeachingCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.AppraiseTypeName, convClsRmTeachingCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.SenateTheme, convClsRmTeachingCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.SenateContent, convClsRmTeachingCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.SenateDate, convClsRmTeachingCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.SenateTime, convClsRmTeachingCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.SenateIp, convClsRmTeachingCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.IdSenateGaugeVersion, convClsRmTeachingCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionID, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.senateGaugeVersionName, convClsRmTeachingCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserId, convClsRmTeachingCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserName, convClsRmTeachingCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserKindId, convClsRmTeachingCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserKindName, convClsRmTeachingCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UpdUser, convClsRmTeachingCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UpdUserName, convClsRmTeachingCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.Memo, convClsRmTeachingCaseQuantitySenate.Memo);
clsCheckSql.CheckSqlInjection4Field(objvClsRmTeachingCaseQuantitySenateEN.UserTypeName, convClsRmTeachingCaseQuantitySenate.UserTypeName);
//检查外键字段长度
 objvClsRmTeachingCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClsRmTeachingCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvClsRmTeachingCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}