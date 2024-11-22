
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingActivityTypeDA
 表名:TeachingActivityType(01120523)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:21:14
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
 /// 教学活动类型(TeachingActivityType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeachingActivityTypeDA : clsCommBase4DA
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
 return clsTeachingActivityTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeachingActivityTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeachingActivityTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeachingActivityTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeachingActivityTypeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:TeachingActivityType中,检查关键字,长度不正确!(clsTeachingActivityTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTeachingActivityTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeachingActivityType中,关键字不能为空 或 null!(clsTeachingActivityTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingActivityTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeachingActivityTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeachingActivityType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable_TeachingActivityType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingActivityType.* from TeachingActivityType Left Join {1} on {2} where {3} and TeachingActivityType.TeachingActivityTypeId not in (Select top {5} TeachingActivityType.TeachingActivityTypeId from TeachingActivityType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {2} TeachingActivityTypeId from TeachingActivityType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {3} TeachingActivityTypeId from TeachingActivityType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeachingActivityType.* from TeachingActivityType Left Join {1} on {2} where {3} and TeachingActivityType.TeachingActivityTypeId not in (Select top {5} TeachingActivityType.TeachingActivityTypeId from TeachingActivityType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {2} TeachingActivityTypeId from TeachingActivityType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeachingActivityType where {1} and TeachingActivityTypeId not in (Select top {3} TeachingActivityTypeId from TeachingActivityType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeachingActivityTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA:GetObjLst)", objException.Message));
}
List<clsTeachingActivityTypeEN> arrObjLst = new List<clsTeachingActivityTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN();
try
{
objTeachingActivityTypeEN.TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingActivityTypeEN.TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objTeachingActivityTypeEN.UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objTeachingActivityTypeEN.FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingActivityTypeEN.IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingActivityTypeEN.CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objTeachingActivityTypeEN.OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objTeachingActivityTypeEN.IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objTeachingActivityTypeEN.OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingActivityType.OrderNum].ToString().Trim()); //序号
objTeachingActivityTypeEN.UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期
objTeachingActivityTypeEN.UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingActivityTypeEN.Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetObjLst)", objException.Message));
}
objTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingActivityTypeEN);
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
public List<clsTeachingActivityTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeachingActivityTypeEN> arrObjLst = new List<clsTeachingActivityTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN();
try
{
objTeachingActivityTypeEN.TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingActivityTypeEN.TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objTeachingActivityTypeEN.UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objTeachingActivityTypeEN.FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingActivityTypeEN.IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingActivityTypeEN.CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objTeachingActivityTypeEN.OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objTeachingActivityTypeEN.IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objTeachingActivityTypeEN.OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingActivityType.OrderNum].ToString().Trim()); //序号
objTeachingActivityTypeEN.UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期
objTeachingActivityTypeEN.UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingActivityTypeEN.Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetObjLst)", objException.Message));
}
objTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeachingActivityTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeachingActivityType(ref clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where TeachingActivityTypeId = " + "'"+ objTeachingActivityTypeEN.TeachingActivityTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeachingActivityTypeEN.TeachingActivityTypeId = objDT.Rows[0][conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingActivityTypeEN.TeachingActivityTypeName = objDT.Rows[0][conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objDT.Rows[0][conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段(字段类型:bit,字段长度:1,是否可空:False)
 objTeachingActivityTypeEN.UseMedia = objDT.Rows[0][conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingActivityTypeEN.FuncModuleId = objDT.Rows[0][conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.IdMicroteachCase = objDT.Rows[0][conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingActivityTypeEN.CaseName = objDT.Rows[0][conTeachingActivityType.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachingActivityTypeEN.OwnerId = objDT.Rows[0][conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingActivityTypeEN.IdSchool = objDT.Rows[0][conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conTeachingActivityType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.UpdDate = objDT.Rows[0][conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingActivityTypeEN.UpdUserId = objDT.Rows[0][conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingActivityTypeEN.Memo = objDT.Rows[0][conTeachingActivityType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetTeachingActivityType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsTeachingActivityTypeEN GetObjByTeachingActivityTypeId(string strTeachingActivityTypeId)
{
CheckPrimaryKey(strTeachingActivityTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN();
try
{
 objTeachingActivityTypeEN.TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTeachingActivityTypeEN.TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingActivityTypeEN.IsSummaryField = clsEntityBase2.TransNullToBool_S(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段(字段类型:bit,字段长度:1,是否可空:False)
 objTeachingActivityTypeEN.UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体(字段类型:varchar,字段长度:30,是否可空:False)
 objTeachingActivityTypeEN.FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeachingActivityTypeEN.CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objTeachingActivityTypeEN.OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objTeachingActivityTypeEN.IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTeachingActivityType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objTeachingActivityTypeEN.UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingActivityTypeEN.UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objTeachingActivityTypeEN.Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetObjByTeachingActivityTypeId)", objException.Message));
}
return objTeachingActivityTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeachingActivityTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN()
{
TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(), //教学活动类型Id
TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(), //教学活动类型名称
IsSummaryField = TransNullToBool(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()), //是否汇总字段
UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(), //使用媒体
FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(), //案例名称
OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(), //拥有者Id
IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(), //学校流水号
OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingActivityType.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim() //备注
};
objTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingActivityTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeachingActivityTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN();
try
{
objTeachingActivityTypeEN.TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingActivityTypeEN.TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objTeachingActivityTypeEN.UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objTeachingActivityTypeEN.FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingActivityTypeEN.IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingActivityTypeEN.CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objTeachingActivityTypeEN.OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objTeachingActivityTypeEN.IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objTeachingActivityTypeEN.OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingActivityType.OrderNum].ToString().Trim()); //序号
objTeachingActivityTypeEN.UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期
objTeachingActivityTypeEN.UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingActivityTypeEN.Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetObjByDataRowTeachingActivityType)", objException.Message));
}
objTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingActivityTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeachingActivityTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeachingActivityTypeEN objTeachingActivityTypeEN = new clsTeachingActivityTypeEN();
try
{
objTeachingActivityTypeEN.TeachingActivityTypeId = objRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objTeachingActivityTypeEN.TeachingActivityTypeName = objRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objTeachingActivityTypeEN.IsSummaryField = TransNullToBool(objRow[conTeachingActivityType.IsSummaryField].ToString().Trim()); //是否汇总字段
objTeachingActivityTypeEN.UseMedia = objRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objTeachingActivityTypeEN.FuncModuleId = objRow[conTeachingActivityType.FuncModuleId] == DBNull.Value ? null : objRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objTeachingActivityTypeEN.IdMicroteachCase = objRow[conTeachingActivityType.IdMicroteachCase] == DBNull.Value ? null : objRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objTeachingActivityTypeEN.CaseName = objRow[conTeachingActivityType.CaseName] == DBNull.Value ? null : objRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objTeachingActivityTypeEN.OwnerId = objRow[conTeachingActivityType.OwnerId] == DBNull.Value ? null : objRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objTeachingActivityTypeEN.IdSchool = objRow[conTeachingActivityType.IdSchool] == DBNull.Value ? null : objRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objTeachingActivityTypeEN.OrderNum = objRow[conTeachingActivityType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTeachingActivityType.OrderNum].ToString().Trim()); //序号
objTeachingActivityTypeEN.UpdDate = objRow[conTeachingActivityType.UpdDate] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期
objTeachingActivityTypeEN.UpdUserId = objRow[conTeachingActivityType.UpdUserId] == DBNull.Value ? null : objRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id
objTeachingActivityTypeEN.Memo = objRow[conTeachingActivityType.Memo] == DBNull.Value ? null : objRow[conTeachingActivityType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeachingActivityTypeDA: GetObjByDataRow)", objException.Message));
}
objTeachingActivityTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeachingActivityTypeEN;
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
objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingActivityTypeEN._CurrTabName, conTeachingActivityType.TeachingActivityTypeId, 2, "");
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
objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeachingActivityTypeEN._CurrTabName, conTeachingActivityType.TeachingActivityTypeId, 2, strPrefix);
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TeachingActivityTypeId from TeachingActivityType where " + strCondition;
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TeachingActivityTypeId from TeachingActivityType where " + strCondition;
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingActivityType", "TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeachingActivityType", strCondition))
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
objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeachingActivityType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
 {
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingActivityTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingActivityType");
objRow = objDS.Tables["TeachingActivityType"].NewRow();
objRow[conTeachingActivityType.TeachingActivityTypeId] = objTeachingActivityTypeEN.TeachingActivityTypeId; //教学活动类型Id
objRow[conTeachingActivityType.TeachingActivityTypeName] = objTeachingActivityTypeEN.TeachingActivityTypeName; //教学活动类型名称
objRow[conTeachingActivityType.IsSummaryField] = objTeachingActivityTypeEN.IsSummaryField; //是否汇总字段
objRow[conTeachingActivityType.UseMedia] = objTeachingActivityTypeEN.UseMedia; //使用媒体
 if (objTeachingActivityTypeEN.FuncModuleId !=  "")
 {
objRow[conTeachingActivityType.FuncModuleId] = objTeachingActivityTypeEN.FuncModuleId; //功能模块Id
 }
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  "")
 {
objRow[conTeachingActivityType.IdMicroteachCase] = objTeachingActivityTypeEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objTeachingActivityTypeEN.CaseName !=  "")
 {
objRow[conTeachingActivityType.CaseName] = objTeachingActivityTypeEN.CaseName; //案例名称
 }
 if (objTeachingActivityTypeEN.OwnerId !=  "")
 {
objRow[conTeachingActivityType.OwnerId] = objTeachingActivityTypeEN.OwnerId; //拥有者Id
 }
 if (objTeachingActivityTypeEN.IdSchool !=  "")
 {
objRow[conTeachingActivityType.IdSchool] = objTeachingActivityTypeEN.IdSchool; //学校流水号
 }
objRow[conTeachingActivityType.OrderNum] = objTeachingActivityTypeEN.OrderNum; //序号
 if (objTeachingActivityTypeEN.UpdDate !=  "")
 {
objRow[conTeachingActivityType.UpdDate] = objTeachingActivityTypeEN.UpdDate; //修改日期
 }
 if (objTeachingActivityTypeEN.UpdUserId !=  "")
 {
objRow[conTeachingActivityType.UpdUserId] = objTeachingActivityTypeEN.UpdUserId; //修改用户Id
 }
 if (objTeachingActivityTypeEN.Memo !=  "")
 {
objRow[conTeachingActivityType.Memo] = objTeachingActivityTypeEN.Memo; //备注
 }
objDS.Tables[clsTeachingActivityTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeachingActivityTypeEN._CurrTabName);
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
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingActivityTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingActivityTypeEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeName);
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingActivityType.IsSummaryField);
 arrValueListForInsert.Add("'" + (objTeachingActivityTypeEN.IsSummaryField  ==  false ? "0" : "1") + "'");
 
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UseMedia);
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.FuncModuleId);
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.CaseName);
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OwnerId);
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdSchool);
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OrderNum);
 arrValueListForInsert.Add(objTeachingActivityTypeEN.OrderNum.ToString());
 }
 
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdDate);
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdUserId);
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.Memo);
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingActivityType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingActivityTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingActivityTypeEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeName);
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingActivityType.IsSummaryField);
 arrValueListForInsert.Add("'" + (objTeachingActivityTypeEN.IsSummaryField  ==  false ? "0" : "1") + "'");
 
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UseMedia);
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.FuncModuleId);
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.CaseName);
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OwnerId);
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdSchool);
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OrderNum);
 arrValueListForInsert.Add(objTeachingActivityTypeEN.OrderNum.ToString());
 }
 
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdDate);
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdUserId);
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.Memo);
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingActivityType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeachingActivityTypeEN.TeachingActivityTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeachingActivityTypeEN objTeachingActivityTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingActivityTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingActivityTypeEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeName);
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingActivityType.IsSummaryField);
 arrValueListForInsert.Add("'" + (objTeachingActivityTypeEN.IsSummaryField  ==  false ? "0" : "1") + "'");
 
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UseMedia);
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.FuncModuleId);
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.CaseName);
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OwnerId);
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdSchool);
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OrderNum);
 arrValueListForInsert.Add(objTeachingActivityTypeEN.OrderNum.ToString());
 }
 
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdDate);
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdUserId);
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.Memo);
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingActivityType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeachingActivityTypeEN.TeachingActivityTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeachingActivityTypeEN objTeachingActivityTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeachingActivityTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeId);
 var strTeachingActivityTypeId = objTeachingActivityTypeEN.TeachingActivityTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeId + "'");
 }
 
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.TeachingActivityTypeName);
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingActivityTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conTeachingActivityType.IsSummaryField);
 arrValueListForInsert.Add("'" + (objTeachingActivityTypeEN.IsSummaryField  ==  false ? "0" : "1") + "'");
 
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UseMedia);
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUseMedia + "'");
 }
 
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.FuncModuleId);
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdMicroteachCase);
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMicroteachCase + "'");
 }
 
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.CaseName);
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName + "'");
 }
 
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OwnerId);
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId + "'");
 }
 
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.IdSchool);
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.OrderNum);
 arrValueListForInsert.Add(objTeachingActivityTypeEN.OrderNum.ToString());
 }
 
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdDate);
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.UpdUserId);
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeachingActivityType.Memo);
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeachingActivityType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeachingActivityTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where TeachingActivityTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeachingActivityType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTeachingActivityTypeId = oRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim();
if (IsExist(strTeachingActivityTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("TeachingActivityTypeId = {0}", strTeachingActivityTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeachingActivityTypeEN._CurrTabName ].NewRow();
objRow[conTeachingActivityType.TeachingActivityTypeId] = oRow[conTeachingActivityType.TeachingActivityTypeId].ToString().Trim(); //教学活动类型Id
objRow[conTeachingActivityType.TeachingActivityTypeName] = oRow[conTeachingActivityType.TeachingActivityTypeName].ToString().Trim(); //教学活动类型名称
objRow[conTeachingActivityType.IsSummaryField] = oRow[conTeachingActivityType.IsSummaryField].ToString().Trim(); //是否汇总字段
objRow[conTeachingActivityType.UseMedia] = oRow[conTeachingActivityType.UseMedia].ToString().Trim(); //使用媒体
objRow[conTeachingActivityType.FuncModuleId] = oRow[conTeachingActivityType.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conTeachingActivityType.IdMicroteachCase] = oRow[conTeachingActivityType.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objRow[conTeachingActivityType.CaseName] = oRow[conTeachingActivityType.CaseName].ToString().Trim(); //案例名称
objRow[conTeachingActivityType.OwnerId] = oRow[conTeachingActivityType.OwnerId].ToString().Trim(); //拥有者Id
objRow[conTeachingActivityType.IdSchool] = oRow[conTeachingActivityType.IdSchool].ToString().Trim(); //学校流水号
objRow[conTeachingActivityType.OrderNum] = oRow[conTeachingActivityType.OrderNum].ToString().Trim(); //序号
objRow[conTeachingActivityType.UpdDate] = oRow[conTeachingActivityType.UpdDate].ToString().Trim(); //修改日期
objRow[conTeachingActivityType.UpdUserId] = oRow[conTeachingActivityType.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conTeachingActivityType.Memo] = oRow[conTeachingActivityType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTeachingActivityTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeachingActivityTypeEN._CurrTabName);
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
 /// <param name = "objTeachingActivityTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingActivityTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
strSQL = "Select * from TeachingActivityType where TeachingActivityTypeId = " + "'"+ objTeachingActivityTypeEN.TeachingActivityTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeachingActivityTypeEN._CurrTabName);
if (objDS.Tables[clsTeachingActivityTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TeachingActivityTypeId = " + "'"+ objTeachingActivityTypeEN.TeachingActivityTypeId+"'");
return false;
}
objRow = objDS.Tables[clsTeachingActivityTypeEN._CurrTabName].Rows[0];
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeId))
 {
objRow[conTeachingActivityType.TeachingActivityTypeId] = objTeachingActivityTypeEN.TeachingActivityTypeId; //教学活动类型Id
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeName))
 {
objRow[conTeachingActivityType.TeachingActivityTypeName] = objTeachingActivityTypeEN.TeachingActivityTypeName; //教学活动类型名称
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IsSummaryField))
 {
objRow[conTeachingActivityType.IsSummaryField] = objTeachingActivityTypeEN.IsSummaryField; //是否汇总字段
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UseMedia))
 {
objRow[conTeachingActivityType.UseMedia] = objTeachingActivityTypeEN.UseMedia; //使用媒体
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.FuncModuleId))
 {
objRow[conTeachingActivityType.FuncModuleId] = objTeachingActivityTypeEN.FuncModuleId; //功能模块Id
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdMicroteachCase))
 {
objRow[conTeachingActivityType.IdMicroteachCase] = objTeachingActivityTypeEN.IdMicroteachCase; //微格教学案例流水号
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.CaseName))
 {
objRow[conTeachingActivityType.CaseName] = objTeachingActivityTypeEN.CaseName; //案例名称
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OwnerId))
 {
objRow[conTeachingActivityType.OwnerId] = objTeachingActivityTypeEN.OwnerId; //拥有者Id
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdSchool))
 {
objRow[conTeachingActivityType.IdSchool] = objTeachingActivityTypeEN.IdSchool; //学校流水号
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OrderNum))
 {
objRow[conTeachingActivityType.OrderNum] = objTeachingActivityTypeEN.OrderNum; //序号
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdDate))
 {
objRow[conTeachingActivityType.UpdDate] = objTeachingActivityTypeEN.UpdDate; //修改日期
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdUserId))
 {
objRow[conTeachingActivityType.UpdUserId] = objTeachingActivityTypeEN.UpdUserId; //修改用户Id
 }
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.Memo))
 {
objRow[conTeachingActivityType.Memo] = objTeachingActivityTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTeachingActivityTypeEN._CurrTabName);
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
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingActivityTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeachingActivityType Set ");
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeName))
 {
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingActivityTypeName, conTeachingActivityType.TeachingActivityTypeName); //教学活动类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.TeachingActivityTypeName); //教学活动类型名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IsSummaryField))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingActivityTypeEN.IsSummaryField == true?"1":"0", conTeachingActivityType.IsSummaryField); //是否汇总字段
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UseMedia))
 {
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseMedia, conTeachingActivityType.UseMedia); //使用媒体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UseMedia); //使用媒体
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.FuncModuleId))
 {
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conTeachingActivityType.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.FuncModuleId); //功能模块Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdMicroteachCase))
 {
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conTeachingActivityType.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.CaseName))
 {
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conTeachingActivityType.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.CaseName); //案例名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OwnerId))
 {
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingActivityType.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdSchool))
 {
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conTeachingActivityType.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.IdSchool); //学校流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OrderNum))
 {
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingActivityTypeEN.OrderNum, conTeachingActivityType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OrderNum); //序号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdDate))
 {
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingActivityType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UpdDate); //修改日期
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdUserId))
 {
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingActivityType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.Memo))
 {
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingActivityType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TeachingActivityTypeId = '{0}'", objTeachingActivityTypeEN.TeachingActivityTypeId); 
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
 /// <param name = "objTeachingActivityTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strCondition)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingActivityTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingActivityType Set ");
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeName))
 {
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingActivityTypeName = '{0}',", strTeachingActivityTypeName); //教学活动类型名称
 }
 else
 {
 sbSQL.Append(" TeachingActivityTypeName = null,"); //教学活动类型名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IsSummaryField))
 {
 sbSQL.AppendFormat(" IsSummaryField = '{0}',", objTeachingActivityTypeEN.IsSummaryField == true?"1":"0"); //是否汇总字段
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UseMedia))
 {
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseMedia = '{0}',", strUseMedia); //使用媒体
 }
 else
 {
 sbSQL.Append(" UseMedia = null,"); //使用媒体
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.FuncModuleId))
 {
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdMicroteachCase))
 {
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.CaseName))
 {
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OwnerId))
 {
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdSchool))
 {
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OrderNum))
 {
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingActivityTypeEN.OrderNum, conTeachingActivityType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OrderNum); //序号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdDate))
 {
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdUserId))
 {
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.Memo))
 {
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingActivityTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeachingActivityTypeEN objTeachingActivityTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingActivityTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingActivityType Set ");
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeName))
 {
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingActivityTypeName = '{0}',", strTeachingActivityTypeName); //教学活动类型名称
 }
 else
 {
 sbSQL.Append(" TeachingActivityTypeName = null,"); //教学活动类型名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IsSummaryField))
 {
 sbSQL.AppendFormat(" IsSummaryField = '{0}',", objTeachingActivityTypeEN.IsSummaryField == true?"1":"0"); //是否汇总字段
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UseMedia))
 {
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UseMedia = '{0}',", strUseMedia); //使用媒体
 }
 else
 {
 sbSQL.Append(" UseMedia = null,"); //使用媒体
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.FuncModuleId))
 {
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdMicroteachCase))
 {
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMicroteachCase = '{0}',", strIdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.Append(" IdMicroteachCase = null,"); //微格教学案例流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.CaseName))
 {
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName = '{0}',", strCaseName); //案例名称
 }
 else
 {
 sbSQL.Append(" CaseName = null,"); //案例名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OwnerId))
 {
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId = '{0}',", strOwnerId); //拥有者Id
 }
 else
 {
 sbSQL.Append(" OwnerId = null,"); //拥有者Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdSchool))
 {
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OrderNum))
 {
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingActivityTypeEN.OrderNum, conTeachingActivityType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OrderNum); //序号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdDate))
 {
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdUserId))
 {
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.Memo))
 {
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTeachingActivityTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeachingActivityTypeEN objTeachingActivityTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeachingActivityTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeachingActivityTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeachingActivityTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeachingActivityType Set ");
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.TeachingActivityTypeName))
 {
 if (objTeachingActivityTypeEN.TeachingActivityTypeName !=  null)
 {
 var strTeachingActivityTypeName = objTeachingActivityTypeEN.TeachingActivityTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingActivityTypeName, conTeachingActivityType.TeachingActivityTypeName); //教学活动类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.TeachingActivityTypeName); //教学活动类型名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IsSummaryField))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeachingActivityTypeEN.IsSummaryField == true?"1":"0", conTeachingActivityType.IsSummaryField); //是否汇总字段
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UseMedia))
 {
 if (objTeachingActivityTypeEN.UseMedia !=  null)
 {
 var strUseMedia = objTeachingActivityTypeEN.UseMedia.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUseMedia, conTeachingActivityType.UseMedia); //使用媒体
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UseMedia); //使用媒体
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.FuncModuleId))
 {
 if (objTeachingActivityTypeEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objTeachingActivityTypeEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conTeachingActivityType.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.FuncModuleId); //功能模块Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdMicroteachCase))
 {
 if (objTeachingActivityTypeEN.IdMicroteachCase !=  null)
 {
 var strIdMicroteachCase = objTeachingActivityTypeEN.IdMicroteachCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMicroteachCase, conTeachingActivityType.IdMicroteachCase); //微格教学案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.IdMicroteachCase); //微格教学案例流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.CaseName))
 {
 if (objTeachingActivityTypeEN.CaseName !=  null)
 {
 var strCaseName = objTeachingActivityTypeEN.CaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName, conTeachingActivityType.CaseName); //案例名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.CaseName); //案例名称
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OwnerId))
 {
 if (objTeachingActivityTypeEN.OwnerId !=  null)
 {
 var strOwnerId = objTeachingActivityTypeEN.OwnerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId, conTeachingActivityType.OwnerId); //拥有者Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OwnerId); //拥有者Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.IdSchool))
 {
 if (objTeachingActivityTypeEN.IdSchool !=  null)
 {
 var strIdSchool = objTeachingActivityTypeEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conTeachingActivityType.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.IdSchool); //学校流水号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.OrderNum))
 {
 if (objTeachingActivityTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTeachingActivityTypeEN.OrderNum, conTeachingActivityType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.OrderNum); //序号
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdDate))
 {
 if (objTeachingActivityTypeEN.UpdDate !=  null)
 {
 var strUpdDate = objTeachingActivityTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTeachingActivityType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UpdDate); //修改日期
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.UpdUserId))
 {
 if (objTeachingActivityTypeEN.UpdUserId !=  null)
 {
 var strUpdUserId = objTeachingActivityTypeEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conTeachingActivityType.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.UpdUserId); //修改用户Id
 }
 }
 
 if (objTeachingActivityTypeEN.IsUpdated(conTeachingActivityType.Memo))
 {
 if (objTeachingActivityTypeEN.Memo !=  null)
 {
 var strMemo = objTeachingActivityTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeachingActivityType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeachingActivityType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TeachingActivityTypeId = '{0}'", objTeachingActivityTypeEN.TeachingActivityTypeId); 
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
 /// <param name = "strTeachingActivityTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTeachingActivityTypeId) 
{
CheckPrimaryKey(strTeachingActivityTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTeachingActivityTypeId,
};
 objSQL.ExecSP("TeachingActivityType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTeachingActivityTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTeachingActivityTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
//删除TeachingActivityType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingActivityType where TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeachingActivityType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
//删除TeachingActivityType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingActivityType where TeachingActivityTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTeachingActivityTypeId) 
{
CheckPrimaryKey(strTeachingActivityTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
//删除TeachingActivityType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeachingActivityType where TeachingActivityTypeId = " + "'"+ strTeachingActivityTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeachingActivityType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: DelTeachingActivityType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingActivityType where " + strCondition ;
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
public bool DelTeachingActivityTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeachingActivityTypeDA: DelTeachingActivityTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeachingActivityType where " + strCondition ;
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
 /// <param name = "objTeachingActivityTypeENS">源对象</param>
 /// <param name = "objTeachingActivityTypeENT">目标对象</param>
public void CopyTo(clsTeachingActivityTypeEN objTeachingActivityTypeENS, clsTeachingActivityTypeEN objTeachingActivityTypeENT)
{
objTeachingActivityTypeENT.TeachingActivityTypeId = objTeachingActivityTypeENS.TeachingActivityTypeId; //教学活动类型Id
objTeachingActivityTypeENT.TeachingActivityTypeName = objTeachingActivityTypeENS.TeachingActivityTypeName; //教学活动类型名称
objTeachingActivityTypeENT.IsSummaryField = objTeachingActivityTypeENS.IsSummaryField; //是否汇总字段
objTeachingActivityTypeENT.UseMedia = objTeachingActivityTypeENS.UseMedia; //使用媒体
objTeachingActivityTypeENT.FuncModuleId = objTeachingActivityTypeENS.FuncModuleId; //功能模块Id
objTeachingActivityTypeENT.IdMicroteachCase = objTeachingActivityTypeENS.IdMicroteachCase; //微格教学案例流水号
objTeachingActivityTypeENT.CaseName = objTeachingActivityTypeENS.CaseName; //案例名称
objTeachingActivityTypeENT.OwnerId = objTeachingActivityTypeENS.OwnerId; //拥有者Id
objTeachingActivityTypeENT.IdSchool = objTeachingActivityTypeENS.IdSchool; //学校流水号
objTeachingActivityTypeENT.OrderNum = objTeachingActivityTypeENS.OrderNum; //序号
objTeachingActivityTypeENT.UpdDate = objTeachingActivityTypeENS.UpdDate; //修改日期
objTeachingActivityTypeENT.UpdUserId = objTeachingActivityTypeENS.UpdUserId; //修改用户Id
objTeachingActivityTypeENT.Memo = objTeachingActivityTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeachingActivityTypeEN.TeachingActivityTypeName, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldNotNull(objTeachingActivityTypeEN.IsSummaryField, conTeachingActivityType.IsSummaryField);
clsCheckSql.CheckFieldNotNull(objTeachingActivityTypeEN.UseMedia, conTeachingActivityType.UseMedia);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.TeachingActivityTypeId, 2, conTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.TeachingActivityTypeName, 30, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UseMedia, 30, conTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.FuncModuleId, 4, conTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdMicroteachCase, 8, conTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.CaseName, 100, conTeachingActivityType.CaseName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.OwnerId, 20, conTeachingActivityType.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdSchool, 4, conTeachingActivityType.IdSchool);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdDate, 20, conTeachingActivityType.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdUserId, 20, conTeachingActivityType.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.Memo, 1000, conTeachingActivityType.Memo);
//检查字段外键固定长度
 objTeachingActivityTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.TeachingActivityTypeName, 30, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UseMedia, 30, conTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.FuncModuleId, 4, conTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdMicroteachCase, 8, conTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.CaseName, 100, conTeachingActivityType.CaseName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.OwnerId, 20, conTeachingActivityType.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdSchool, 4, conTeachingActivityType.IdSchool);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdDate, 20, conTeachingActivityType.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdUserId, 20, conTeachingActivityType.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.Memo, 1000, conTeachingActivityType.Memo);
//检查外键字段长度
 objTeachingActivityTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeachingActivityTypeEN objTeachingActivityTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.TeachingActivityTypeId, 2, conTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.TeachingActivityTypeName, 30, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UseMedia, 30, conTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.FuncModuleId, 4, conTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdMicroteachCase, 8, conTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.CaseName, 100, conTeachingActivityType.CaseName);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.OwnerId, 20, conTeachingActivityType.OwnerId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.IdSchool, 4, conTeachingActivityType.IdSchool);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdDate, 20, conTeachingActivityType.UpdDate);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.UpdUserId, 20, conTeachingActivityType.UpdUserId);
clsCheckSql.CheckFieldLen(objTeachingActivityTypeEN.Memo, 1000, conTeachingActivityType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.TeachingActivityTypeId, conTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.TeachingActivityTypeName, conTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.UseMedia, conTeachingActivityType.UseMedia);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.FuncModuleId, conTeachingActivityType.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.IdMicroteachCase, conTeachingActivityType.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.CaseName, conTeachingActivityType.CaseName);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.OwnerId, conTeachingActivityType.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.IdSchool, conTeachingActivityType.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.UpdDate, conTeachingActivityType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.UpdUserId, conTeachingActivityType.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objTeachingActivityTypeEN.Memo, conTeachingActivityType.Memo);
//检查外键字段长度
 objTeachingActivityTypeEN._IsCheckProperty = true;
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
string strSQL = "select TeachingActivityTypeId, TeachingActivityTypeName from TeachingActivityType ";
 clsSpecSQLforSql mySql = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingActivityTypeEN._CurrTabName);
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeachingActivityTypeEN._CurrTabName, strCondition);
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
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
 objSQL = clsTeachingActivityTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}