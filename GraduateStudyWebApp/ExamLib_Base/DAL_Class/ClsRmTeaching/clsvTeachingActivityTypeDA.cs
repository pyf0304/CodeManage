
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingActivityTypeDA
 表名:vTeachingActivityType(01120524)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:57
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
 /// v教学活动类型(vTeachingActivityType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingActivityTypeDA : clsCommBase4DA
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
 return clsvTeachingActivityTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingActivityTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingActivityTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingActivityTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingActivityTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTeachingActivityTypeId)
{
strTeachingActivityTypeId = strTeachingActivityTypeId.Replace("'", "''");
if (strTeachingActivityTypeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:vTeachingActivityType中,检查关键字,长度不正确!(clsvTeachingActivityTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTeachingActivityTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachingActivityType中,关键字不能为空 或 null!(clsvTeachingActivityTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingActivityTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachingActivityTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingActivityType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable_vTeachingActivityType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingActivityType.* from vTeachingActivityType Left Join {1} on {2} where {3} and vTeachingActivityType.TeachingActivityTypeId not in (Select top {5} vTeachingActivityType.TeachingActivityTypeId from vTeachingActivityType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {2} TeachingActivityTypeId from vTeachingActivityType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {3} TeachingActivityTypeId from vTeachingActivityType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingActivityType.* from vTeachingActivityType Left Join {1} on {2} where {3} and vTeachingActivityType.TeachingActivityTypeId not in (Select top {5} vTeachingActivityType.TeachingActivityTypeId from vTeachingActivityType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {2} TeachingActivityTypeId from vTeachingActivityType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {3} TeachingActivityTypeId from vTeachingActivityType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingActivityTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA:GetObjLst)", objException.Message));
}
List<clsvTeachingActivityTypeEN> arrObjLst = new List<clsvTeachingActivityTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN();
try
{
objvTeachingActivityTypeEN.TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objvTeachingActivityTypeEN.TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objvTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objvTeachingActivityTypeEN.UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objvTeachingActivityTypeEN.FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingActivityTypeEN.FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingActivityTypeEN.FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvTeachingActivityTypeEN.IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingActivityTypeEN.CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objvTeachingActivityTypeEN.OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingActivityTypeEN.OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingActivityType.OrderNum].ToString().Trim()); //序号
objvTeachingActivityTypeEN.IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objvTeachingActivityTypeEN.SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号
objvTeachingActivityTypeEN.SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称
objvTeachingActivityTypeEN.Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetObjLst)", objException.Message));
}
objvTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingActivityTypeEN);
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
public List<clsvTeachingActivityTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingActivityTypeEN> arrObjLst = new List<clsvTeachingActivityTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN();
try
{
objvTeachingActivityTypeEN.TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objvTeachingActivityTypeEN.TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objvTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objvTeachingActivityTypeEN.UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objvTeachingActivityTypeEN.FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingActivityTypeEN.FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingActivityTypeEN.FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvTeachingActivityTypeEN.IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingActivityTypeEN.CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objvTeachingActivityTypeEN.OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingActivityTypeEN.OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingActivityType.OrderNum].ToString().Trim()); //序号
objvTeachingActivityTypeEN.IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objvTeachingActivityTypeEN.SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号
objvTeachingActivityTypeEN.SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称
objvTeachingActivityTypeEN.Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetObjLst)", objException.Message));
}
objvTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingActivityTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingActivityType(ref clsvTeachingActivityTypeEN objvTeachingActivityTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where TeachingActivityTypeId = " + "'"+ objvTeachingActivityTypeEN.TeachingActivityTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingActivityTypeEN.TeachingActivityTypeId = objDT.Rows[0][convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingActivityTypeEN.TeachingActivityTypeName = objDT.Rows[0][convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objDT.Rows[0][convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingActivityTypeEN.UseMedia = objDT.Rows[0][convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.FuncModuleId = objDT.Rows[0][convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.FuncModuleName = objDT.Rows[0][convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.FuncModuleNameSim = objDT.Rows[0][convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingActivityTypeEN.IdMicroteachCase = objDT.Rows[0][convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingActivityTypeEN.CaseName = objDT.Rows[0][convTeachingActivityType.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingActivityTypeEN.OwnerId = objDT.Rows[0][convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingActivityTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convTeachingActivityType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.IdSchool = objDT.Rows[0][convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.SchoolId = objDT.Rows[0][convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingActivityTypeEN.SchoolName = objDT.Rows[0][convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingActivityTypeEN.Memo = objDT.Rows[0][convTeachingActivityType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetvTeachingActivityType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingActivityTypeEN GetObjByTeachingActivityTypeId(string strTeachingActivityTypeId)
{
CheckPrimaryKey(strTeachingActivityTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN();
try
{
 objvTeachingActivityTypeEN.TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachingActivityTypeEN.TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.IsSummaryField = clsEntityBase2.TransNullToBool_S(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachingActivityTypeEN.UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingActivityTypeEN.FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachingActivityTypeEN.IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingActivityTypeEN.CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachingActivityTypeEN.OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeachingActivityTypeEN.OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachingActivityType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingActivityTypeEN.SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingActivityTypeEN.SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachingActivityTypeEN.Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetObjByTeachingActivityTypeId)", objException.Message));
}
return objvTeachingActivityTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingActivityTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN()
{
TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(), //教学活动类型Id
TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(), //教学活动类型名称
IsSummaryField = TransNullToBool(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()), //是否汇总字段
UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(), //使用媒体
FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(), //功能模块简称
IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(), //拥有者Id
OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingActivityType.OrderNum].ToString().Trim()), //序号
IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(), //学校流水号
SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(), //学校名称
Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim() //备注
};
objvTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingActivityTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingActivityTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN();
try
{
objvTeachingActivityTypeEN.TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objvTeachingActivityTypeEN.TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objvTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objvTeachingActivityTypeEN.UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objvTeachingActivityTypeEN.FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingActivityTypeEN.FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingActivityTypeEN.FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvTeachingActivityTypeEN.IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingActivityTypeEN.CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objvTeachingActivityTypeEN.OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingActivityTypeEN.OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingActivityType.OrderNum].ToString().Trim()); //序号
objvTeachingActivityTypeEN.IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objvTeachingActivityTypeEN.SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号
objvTeachingActivityTypeEN.SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称
objvTeachingActivityTypeEN.Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetObjByDataRowvTeachingActivityType)", objException.Message));
}
objvTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingActivityTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingActivityTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN();
try
{
objvTeachingActivityTypeEN.TeachingActivityTypeId = objRow[convTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objvTeachingActivityTypeEN.TeachingActivityTypeName = objRow[convTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objvTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[convTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objvTeachingActivityTypeEN.UseMedia = objRow[convTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objvTeachingActivityTypeEN.FuncModuleId = objRow[convTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objvTeachingActivityTypeEN.FuncModuleName = objRow[convTeachingActivityType.FuncModuleName] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleName].ToString().Trim(); //功能模块名称
objvTeachingActivityTypeEN.FuncModuleNameSim = objRow[convTeachingActivityType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convTeachingActivityType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvTeachingActivityTypeEN.IdMicroteachCase = objRow[convTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[convTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvTeachingActivityTypeEN.CaseName = objRow[convTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[convTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objvTeachingActivityTypeEN.OwnerId = objRow[convTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[convTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objvTeachingActivityTypeEN.OrderNum = objRow[convTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachingActivityType.OrderNum].ToString().Trim()); //序号
objvTeachingActivityTypeEN.IdSchool = objRow[convTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[convTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objvTeachingActivityTypeEN.SchoolId = objRow[convTeachingActivityType.SchoolId].ToString().Trim(); //学校编号
objvTeachingActivityTypeEN.SchoolName = objRow[convTeachingActivityType.SchoolName].ToString().Trim(); //学校名称
objvTeachingActivityTypeEN.Memo = objRow[convTeachingActivityType.Memo] == DBNull.Value ? null : objRow[convTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingActivityTypeDA: GetObjByDataRow)", objException.Message));
}
objvTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingActivityTypeEN;
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
objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingActivityTypeEN._CurrTabName, convTeachingActivityType.TeachingActivityTypeId, 2, "");
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
objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingActivityTypeEN._CurrTabName, convTeachingActivityType.TeachingActivityTypeId, 2, strPrefix);
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TeachingActivityTypeId from vTeachingActivityType where " + strCondition;
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TeachingActivityTypeId from vTeachingActivityType where " + strCondition;
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
 /// <param name = "strTeachingActivityTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTeachingActivityTypeId)
{
CheckPrimaryKey(strTeachingActivityTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingActivityType", "TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingActivityTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingActivityType", strCondition))
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
objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingActivityType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeENS">源对象</param>
 /// <param name = "objvTeachingActivityTypeENT">目标对象</param>
public void CopyTo(clsvTeachingActivityTypeEN objvTeachingActivityTypeENS, clsvTeachingActivityTypeEN objvTeachingActivityTypeENT)
{
objvTeachingActivityTypeENT.TeachingActivityTypeId = objvTeachingActivityTypeENS.TeachingActivityTypeId; //教学活动类型Id
objvTeachingActivityTypeENT.TeachingActivityTypeName = objvTeachingActivityTypeENS.TeachingActivityTypeName; //教学活动类型名称
objvTeachingActivityTypeENT.IsSummaryField = objvTeachingActivityTypeENS.IsSummaryField; //是否汇总字段
objvTeachingActivityTypeENT.UseMedia = objvTeachingActivityTypeENS.UseMedia; //使用媒体
objvTeachingActivityTypeENT.FuncModuleId = objvTeachingActivityTypeENS.FuncModuleId; //功能模块Id
objvTeachingActivityTypeENT.FuncModuleName = objvTeachingActivityTypeENS.FuncModuleName; //功能模块名称
objvTeachingActivityTypeENT.FuncModuleNameSim = objvTeachingActivityTypeENS.FuncModuleNameSim; //功能模块简称
objvTeachingActivityTypeENT.IdMicroteachCase = objvTeachingActivityTypeENS.IdMicroteachCase; //微格教学案例流水号
objvTeachingActivityTypeENT.CaseName = objvTeachingActivityTypeENS.CaseName; //案例名称
objvTeachingActivityTypeENT.OwnerId = objvTeachingActivityTypeENS.OwnerId; //拥有者Id
objvTeachingActivityTypeENT.OrderNum = objvTeachingActivityTypeENS.OrderNum; //序号
objvTeachingActivityTypeENT.IdSchool = objvTeachingActivityTypeENS.IdSchool; //学校流水号
objvTeachingActivityTypeENT.SchoolId = objvTeachingActivityTypeENS.SchoolId; //学校编号
objvTeachingActivityTypeENT.SchoolName = objvTeachingActivityTypeENS.SchoolName; //学校名称
objvTeachingActivityTypeENT.Memo = objvTeachingActivityTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingActivityTypeEN objvTeachingActivityTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.TeachingActivityTypeId, 2, convTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.TeachingActivityTypeName, 30, convTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.UseMedia, 30, convTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.FuncModuleId, 4, convTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.FuncModuleName, 30, convTeachingActivityType.FuncModuleName);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.FuncModuleNameSim, 30, convTeachingActivityType.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.IdMicroteachCase, 8, convTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.CaseName, 100, convTeachingActivityType.CaseName);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.OwnerId, 20, convTeachingActivityType.OwnerId);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.IdSchool, 4, convTeachingActivityType.IdSchool);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.SchoolId, 10, convTeachingActivityType.SchoolId);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.SchoolName, 50, convTeachingActivityType.SchoolName);
clsCheckSql.CheckFieldLen(objvTeachingActivityTypeEN.Memo, 1000, convTeachingActivityType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.TeachingActivityTypeId, convTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.TeachingActivityTypeName, convTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.UseMedia, convTeachingActivityType.UseMedia);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.FuncModuleId, convTeachingActivityType.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.FuncModuleName, convTeachingActivityType.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.FuncModuleNameSim, convTeachingActivityType.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.IdMicroteachCase, convTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.CaseName, convTeachingActivityType.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.OwnerId, convTeachingActivityType.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.IdSchool, convTeachingActivityType.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.SchoolId, convTeachingActivityType.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.SchoolName, convTeachingActivityType.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingActivityTypeEN.Memo, convTeachingActivityType.Memo);
//检查外键字段长度
 objvTeachingActivityTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTeachingActivityTypeId()
{
//获取某学院所有专业信息
string strSQL = "select TeachingActivityTypeId, TeachingActivityTypeName from vTeachingActivityType ";
 clsSpecSQLforSql mySql = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingActivityTypeEN._CurrTabName);
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingActivityTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingActivityTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}