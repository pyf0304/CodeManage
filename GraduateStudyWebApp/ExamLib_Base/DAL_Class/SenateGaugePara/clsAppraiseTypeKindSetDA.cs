
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAppraiseTypeKindSetDA
 表名:AppraiseTypeKindSet(01120460)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:20:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// 评议类型种类设置(AppraiseTypeKindSet)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAppraiseTypeKindSetDA : clsCommBase4DA
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
 return clsAppraiseTypeKindSetEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAppraiseTypeKindSetEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAppraiseTypeKindSetEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAppraiseTypeKindSetEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAppraiseTypeKindSetEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_AppraiseTypeKindSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable_AppraiseTypeKindSet)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} AppraiseTypeKindSet.* from AppraiseTypeKindSet Left Join {1} on {2} where {3} and AppraiseTypeKindSet.mId not in (Select top {5} AppraiseTypeKindSet.mId from AppraiseTypeKindSet Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1} and mId not in (Select top {2} mId from AppraiseTypeKindSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1} and mId not in (Select top {3} mId from AppraiseTypeKindSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} AppraiseTypeKindSet.* from AppraiseTypeKindSet Left Join {1} on {2} where {3} and AppraiseTypeKindSet.mId not in (Select top {5} AppraiseTypeKindSet.mId from AppraiseTypeKindSet Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1} and mId not in (Select top {2} mId from AppraiseTypeKindSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from AppraiseTypeKindSet where {1} and mId not in (Select top {3} mId from AppraiseTypeKindSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAppraiseTypeKindSetEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA:GetObjLst)", objException.Message));
}
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = TransNullToInt(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = TransNullToBool(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetObjLst)", objException.Message));
}
objAppraiseTypeKindSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppraiseTypeKindSetEN);
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
public List<clsAppraiseTypeKindSetEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA:GetObjLstByTabName)", objException.Message));
}
List<clsAppraiseTypeKindSetEN> arrObjLst = new List<clsAppraiseTypeKindSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = TransNullToInt(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = TransNullToBool(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetObjLst)", objException.Message));
}
objAppraiseTypeKindSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAppraiseTypeKindSet(ref clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where mId = " + ""+ objAppraiseTypeKindSetEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAppraiseTypeKindSetEN.mId = TransNullToInt(objDT.Rows[0][conAppraiseTypeKindSet.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objAppraiseTypeKindSetEN.IdSchool = objDT.Rows[0][conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objAppraiseTypeKindSetEN.FuncModuleId = objDT.Rows[0][conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objAppraiseTypeKindSetEN.IdAppraiseType = objDT.Rows[0][conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objAppraiseTypeKindSetEN.AppraiseKindId = objDT.Rows[0][conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id(字段类型:char,字段长度:2,是否可空:False)
 objAppraiseTypeKindSetEN.InEffect = TransNullToBool(objDT.Rows[0][conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:False)
 objAppraiseTypeKindSetEN.UpdDate = objDT.Rows[0][conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppraiseTypeKindSetEN.UpdUserId = objDT.Rows[0][conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objAppraiseTypeKindSetEN.Memo = objDT.Rows[0][conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetAppraiseTypeKindSet)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsAppraiseTypeKindSetEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
 objAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id(字段类型:char,字段长度:2,是否可空:False)
 objAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:False)
 objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetObjBymId)", objException.Message));
}
return objAppraiseTypeKindSetEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAppraiseTypeKindSetEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN()
{
mId = TransNullToInt(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()), //mId
IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(), //学校流水号
FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(), //功能模块Id
IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(), //评议种类Id
InEffect = TransNullToBool(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()), //是否有效
UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim() //备注
};
objAppraiseTypeKindSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppraiseTypeKindSetEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAppraiseTypeKindSetEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = TransNullToInt(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = TransNullToBool(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetObjByDataRowAppraiseTypeKindSet)", objException.Message));
}
objAppraiseTypeKindSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppraiseTypeKindSetEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAppraiseTypeKindSetEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN = new clsAppraiseTypeKindSetEN();
try
{
objAppraiseTypeKindSetEN.mId = TransNullToInt(objRow[conAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objAppraiseTypeKindSetEN.IdSchool = objRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objAppraiseTypeKindSetEN.FuncModuleId = objRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objAppraiseTypeKindSetEN.IdAppraiseType = objRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objAppraiseTypeKindSetEN.AppraiseKindId = objRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objAppraiseTypeKindSetEN.InEffect = TransNullToBool(objRow[conAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objAppraiseTypeKindSetEN.UpdDate = objRow[conAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objAppraiseTypeKindSetEN.UpdUserId = objRow[conAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objAppraiseTypeKindSetEN.Memo = objRow[conAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAppraiseTypeKindSetDA: GetObjByDataRow)", objException.Message));
}
objAppraiseTypeKindSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAppraiseTypeKindSetEN;
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
objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppraiseTypeKindSetEN._CurrTabName, conAppraiseTypeKindSet.mId, 8, "");
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
objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAppraiseTypeKindSetEN._CurrTabName, conAppraiseTypeKindSet.mId, 8, strPrefix);
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from AppraiseTypeKindSet where " + strCondition;
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from AppraiseTypeKindSet where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppraiseTypeKindSet", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("AppraiseTypeKindSet", strCondition))
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
objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("AppraiseTypeKindSet");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
 {
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppraiseTypeKindSetEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppraiseTypeKindSet");
objRow = objDS.Tables["AppraiseTypeKindSet"].NewRow();
objRow[conAppraiseTypeKindSet.IdSchool] = objAppraiseTypeKindSetEN.IdSchool; //学校流水号
objRow[conAppraiseTypeKindSet.FuncModuleId] = objAppraiseTypeKindSetEN.FuncModuleId; //功能模块Id
objRow[conAppraiseTypeKindSet.IdAppraiseType] = objAppraiseTypeKindSetEN.IdAppraiseType; //评议类型流水号
objRow[conAppraiseTypeKindSet.AppraiseKindId] = objAppraiseTypeKindSetEN.AppraiseKindId; //评议种类Id
objRow[conAppraiseTypeKindSet.InEffect] = objAppraiseTypeKindSetEN.InEffect; //是否有效
 if (objAppraiseTypeKindSetEN.UpdDate !=  "")
 {
objRow[conAppraiseTypeKindSet.UpdDate] = objAppraiseTypeKindSetEN.UpdDate; //修改日期
 }
 if (objAppraiseTypeKindSetEN.UpdUserId !=  "")
 {
objRow[conAppraiseTypeKindSet.UpdUserId] = objAppraiseTypeKindSetEN.UpdUserId; //修改用户Id
 }
 if (objAppraiseTypeKindSetEN.Memo !=  "")
 {
objRow[conAppraiseTypeKindSet.Memo] = objAppraiseTypeKindSetEN.Memo; //备注
 }
objDS.Tables[clsAppraiseTypeKindSetEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAppraiseTypeKindSetEN._CurrTabName);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppraiseTypeKindSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdSchool);
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.FuncModuleId);
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdAppraiseType);
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.AppraiseKindId);
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseKindId + "'");
 }
 
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.InEffect);
 arrValueListForInsert.Add("'" + (objAppraiseTypeKindSetEN.InEffect  ==  false ? "0" : "1") + "'");
 
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdDate);
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdUserId);
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.Memo);
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppraiseTypeKindSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppraiseTypeKindSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdSchool);
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.FuncModuleId);
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdAppraiseType);
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.AppraiseKindId);
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseKindId + "'");
 }
 
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.InEffect);
 arrValueListForInsert.Add("'" + (objAppraiseTypeKindSetEN.InEffect  ==  false ? "0" : "1") + "'");
 
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdDate);
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdUserId);
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.Memo);
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppraiseTypeKindSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppraiseTypeKindSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdSchool);
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.FuncModuleId);
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdAppraiseType);
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.AppraiseKindId);
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseKindId + "'");
 }
 
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.InEffect);
 arrValueListForInsert.Add("'" + (objAppraiseTypeKindSetEN.InEffect  ==  false ? "0" : "1") + "'");
 
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdDate);
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdUserId);
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.Memo);
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppraiseTypeKindSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAppraiseTypeKindSetEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdSchool);
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.FuncModuleId);
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.IdAppraiseType);
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAppraiseType + "'");
 }
 
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.AppraiseKindId);
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAppraiseKindId + "'");
 }
 
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.InEffect);
 arrValueListForInsert.Add("'" + (objAppraiseTypeKindSetEN.InEffect  ==  false ? "0" : "1") + "'");
 
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdDate);
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.UpdUserId);
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conAppraiseTypeKindSet.Memo);
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into AppraiseTypeKindSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAppraiseTypeKindSets(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "AppraiseTypeKindSet");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAppraiseTypeKindSetEN._CurrTabName ].NewRow();
objRow[conAppraiseTypeKindSet.IdSchool] = oRow[conAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objRow[conAppraiseTypeKindSet.FuncModuleId] = oRow[conAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conAppraiseTypeKindSet.IdAppraiseType] = oRow[conAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objRow[conAppraiseTypeKindSet.AppraiseKindId] = oRow[conAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objRow[conAppraiseTypeKindSet.InEffect] = oRow[conAppraiseTypeKindSet.InEffect].ToString().Trim(); //是否有效
objRow[conAppraiseTypeKindSet.UpdDate] = oRow[conAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objRow[conAppraiseTypeKindSet.UpdUserId] = oRow[conAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conAppraiseTypeKindSet.Memo] = oRow[conAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
 objDS.Tables[clsAppraiseTypeKindSetEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAppraiseTypeKindSetEN._CurrTabName);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppraiseTypeKindSetEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
strSQL = "Select * from AppraiseTypeKindSet where mId = " + ""+ objAppraiseTypeKindSetEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAppraiseTypeKindSetEN._CurrTabName);
if (objDS.Tables[clsAppraiseTypeKindSetEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objAppraiseTypeKindSetEN.mId+"");
return false;
}
objRow = objDS.Tables[clsAppraiseTypeKindSetEN._CurrTabName].Rows[0];
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdSchool))
 {
objRow[conAppraiseTypeKindSet.IdSchool] = objAppraiseTypeKindSetEN.IdSchool; //学校流水号
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.FuncModuleId))
 {
objRow[conAppraiseTypeKindSet.FuncModuleId] = objAppraiseTypeKindSetEN.FuncModuleId; //功能模块Id
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType))
 {
objRow[conAppraiseTypeKindSet.IdAppraiseType] = objAppraiseTypeKindSetEN.IdAppraiseType; //评议类型流水号
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId))
 {
objRow[conAppraiseTypeKindSet.AppraiseKindId] = objAppraiseTypeKindSetEN.AppraiseKindId; //评议种类Id
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.InEffect))
 {
objRow[conAppraiseTypeKindSet.InEffect] = objAppraiseTypeKindSetEN.InEffect; //是否有效
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdDate))
 {
objRow[conAppraiseTypeKindSet.UpdDate] = objAppraiseTypeKindSetEN.UpdDate; //修改日期
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdUserId))
 {
objRow[conAppraiseTypeKindSet.UpdUserId] = objAppraiseTypeKindSetEN.UpdUserId; //修改用户Id
 }
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.Memo))
 {
objRow[conAppraiseTypeKindSet.Memo] = objAppraiseTypeKindSetEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsAppraiseTypeKindSetEN._CurrTabName);
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppraiseTypeKindSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update AppraiseTypeKindSet Set ");
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdSchool))
 {
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conAppraiseTypeKindSet.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.IdSchool); //学校流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.FuncModuleId))
 {
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conAppraiseTypeKindSet.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.FuncModuleId); //功能模块Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType))
 {
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conAppraiseTypeKindSet.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId))
 {
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId); //评议种类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.AppraiseKindId); //评议种类Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.InEffect))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppraiseTypeKindSetEN.InEffect == true?"1":"0", conAppraiseTypeKindSet.InEffect); //是否有效
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdDate))
 {
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppraiseTypeKindSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.UpdDate); //修改日期
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdUserId))
 {
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conAppraiseTypeKindSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.Memo))
 {
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppraiseTypeKindSet.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAppraiseTypeKindSetEN.mId); 
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strCondition)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppraiseTypeKindSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppraiseTypeKindSet Set ");
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdSchool))
 {
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.FuncModuleId))
 {
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType))
 {
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId))
 {
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseKindId = '{0}',", strAppraiseKindId); //评议种类Id
 }
 else
 {
 sbSQL.Append(" AppraiseKindId = null,"); //评议种类Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.InEffect))
 {
 sbSQL.AppendFormat(" InEffect = '{0}',", objAppraiseTypeKindSetEN.InEffect == true?"1":"0"); //是否有效
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdDate))
 {
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdUserId))
 {
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.Memo))
 {
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppraiseTypeKindSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppraiseTypeKindSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppraiseTypeKindSet Set ");
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdSchool))
 {
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.FuncModuleId))
 {
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType))
 {
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAppraiseType = '{0}',", strIdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.Append(" IdAppraiseType = null,"); //评议类型流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId))
 {
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AppraiseKindId = '{0}',", strAppraiseKindId); //评议种类Id
 }
 else
 {
 sbSQL.Append(" AppraiseKindId = null,"); //评议种类Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.InEffect))
 {
 sbSQL.AppendFormat(" InEffect = '{0}',", objAppraiseTypeKindSetEN.InEffect == true?"1":"0"); //是否有效
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdDate))
 {
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdUserId))
 {
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.Memo))
 {
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objAppraiseTypeKindSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objAppraiseTypeKindSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objAppraiseTypeKindSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAppraiseTypeKindSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update AppraiseTypeKindSet Set ");
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdSchool))
 {
 if (objAppraiseTypeKindSetEN.IdSchool !=  null)
 {
 var strIdSchool = objAppraiseTypeKindSetEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, conAppraiseTypeKindSet.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.IdSchool); //学校流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.FuncModuleId))
 {
 if (objAppraiseTypeKindSetEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objAppraiseTypeKindSetEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conAppraiseTypeKindSet.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.FuncModuleId); //功能模块Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.IdAppraiseType))
 {
 if (objAppraiseTypeKindSetEN.IdAppraiseType !=  null)
 {
 var strIdAppraiseType = objAppraiseTypeKindSetEN.IdAppraiseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAppraiseType, conAppraiseTypeKindSet.IdAppraiseType); //评议类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.IdAppraiseType); //评议类型流水号
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.AppraiseKindId))
 {
 if (objAppraiseTypeKindSetEN.AppraiseKindId !=  null)
 {
 var strAppraiseKindId = objAppraiseTypeKindSetEN.AppraiseKindId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId); //评议种类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.AppraiseKindId); //评议种类Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.InEffect))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objAppraiseTypeKindSetEN.InEffect == true?"1":"0", conAppraiseTypeKindSet.InEffect); //是否有效
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdDate))
 {
 if (objAppraiseTypeKindSetEN.UpdDate !=  null)
 {
 var strUpdDate = objAppraiseTypeKindSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conAppraiseTypeKindSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.UpdDate); //修改日期
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.UpdUserId))
 {
 if (objAppraiseTypeKindSetEN.UpdUserId !=  null)
 {
 var strUpdUserId = objAppraiseTypeKindSetEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conAppraiseTypeKindSet.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.UpdUserId); //修改用户Id
 }
 }
 
 if (objAppraiseTypeKindSetEN.IsUpdated(conAppraiseTypeKindSet.Memo))
 {
 if (objAppraiseTypeKindSetEN.Memo !=  null)
 {
 var strMemo = objAppraiseTypeKindSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conAppraiseTypeKindSet.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAppraiseTypeKindSet.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objAppraiseTypeKindSetEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("AppraiseTypeKindSet_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
//删除AppraiseTypeKindSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppraiseTypeKindSet where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelAppraiseTypeKindSet(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除AppraiseTypeKindSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppraiseTypeKindSet where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
//删除AppraiseTypeKindSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from AppraiseTypeKindSet where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAppraiseTypeKindSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: DelAppraiseTypeKindSet)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppraiseTypeKindSet where " + strCondition ;
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
public bool DelAppraiseTypeKindSetWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAppraiseTypeKindSetDA: DelAppraiseTypeKindSetWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from AppraiseTypeKindSet where " + strCondition ;
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
 /// <param name = "objAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objAppraiseTypeKindSetENT">目标对象</param>
public void CopyTo(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENS, clsAppraiseTypeKindSetEN objAppraiseTypeKindSetENT)
{
objAppraiseTypeKindSetENT.mId = objAppraiseTypeKindSetENS.mId; //mId
objAppraiseTypeKindSetENT.IdSchool = objAppraiseTypeKindSetENS.IdSchool; //学校流水号
objAppraiseTypeKindSetENT.FuncModuleId = objAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objAppraiseTypeKindSetENT.IdAppraiseType = objAppraiseTypeKindSetENS.IdAppraiseType; //评议类型流水号
objAppraiseTypeKindSetENT.AppraiseKindId = objAppraiseTypeKindSetENS.AppraiseKindId; //评议种类Id
objAppraiseTypeKindSetENT.InEffect = objAppraiseTypeKindSetENS.InEffect; //是否有效
objAppraiseTypeKindSetENT.UpdDate = objAppraiseTypeKindSetENS.UpdDate; //修改日期
objAppraiseTypeKindSetENT.UpdUserId = objAppraiseTypeKindSetENS.UpdUserId; //修改用户Id
objAppraiseTypeKindSetENT.Memo = objAppraiseTypeKindSetENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objAppraiseTypeKindSetEN.IdSchool, conAppraiseTypeKindSet.IdSchool);
clsCheckSql.CheckFieldNotNull(objAppraiseTypeKindSetEN.FuncModuleId, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldNotNull(objAppraiseTypeKindSetEN.IdAppraiseType, conAppraiseTypeKindSet.IdAppraiseType);
clsCheckSql.CheckFieldNotNull(objAppraiseTypeKindSetEN.AppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldNotNull(objAppraiseTypeKindSetEN.InEffect, conAppraiseTypeKindSet.InEffect);
//检查字段长度
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdSchool, 4, conAppraiseTypeKindSet.IdSchool);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.FuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdAppraiseType, 4, conAppraiseTypeKindSet.IdAppraiseType);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.AppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdDate, 20, conAppraiseTypeKindSet.UpdDate);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdUserId, 20, conAppraiseTypeKindSet.UpdUserId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.Memo, 1000, conAppraiseTypeKindSet.Memo);
//检查字段外键固定长度
 objAppraiseTypeKindSetEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdSchool, 4, conAppraiseTypeKindSet.IdSchool);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.FuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdAppraiseType, 4, conAppraiseTypeKindSet.IdAppraiseType);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.AppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdDate, 20, conAppraiseTypeKindSet.UpdDate);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdUserId, 20, conAppraiseTypeKindSet.UpdUserId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.Memo, 1000, conAppraiseTypeKindSet.Memo);
//检查外键字段长度
 objAppraiseTypeKindSetEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdSchool, 4, conAppraiseTypeKindSet.IdSchool);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.FuncModuleId, 4, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.IdAppraiseType, 4, conAppraiseTypeKindSet.IdAppraiseType);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.AppraiseKindId, 2, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdDate, 20, conAppraiseTypeKindSet.UpdDate);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.UpdUserId, 20, conAppraiseTypeKindSet.UpdUserId);
clsCheckSql.CheckFieldLen(objAppraiseTypeKindSetEN.Memo, 1000, conAppraiseTypeKindSet.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.IdSchool, conAppraiseTypeKindSet.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.FuncModuleId, conAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.IdAppraiseType, conAppraiseTypeKindSet.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.AppraiseKindId, conAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.UpdDate, conAppraiseTypeKindSet.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.UpdUserId, conAppraiseTypeKindSet.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objAppraiseTypeKindSetEN.Memo, conAppraiseTypeKindSet.Memo);
//检查外键字段长度
 objAppraiseTypeKindSetEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--AppraiseTypeKindSet(评议类型种类设置),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objAppraiseTypeKindSetEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsAppraiseTypeKindSetEN objAppraiseTypeKindSetEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdSchool = '{0}'", objAppraiseTypeKindSetEN.IdSchool);
 sbCondition.AppendFormat(" and FuncModuleId = '{0}'", objAppraiseTypeKindSetEN.FuncModuleId);
 sbCondition.AppendFormat(" and IdAppraiseType = '{0}'", objAppraiseTypeKindSetEN.IdAppraiseType);
 sbCondition.AppendFormat(" and AppraiseKindId = '{0}'", objAppraiseTypeKindSetEN.AppraiseKindId);
return sbCondition.ToString();
}

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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppraiseTypeKindSetEN._CurrTabName);
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAppraiseTypeKindSetEN._CurrTabName, strCondition);
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
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
 objSQL = clsAppraiseTypeKindSetDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}