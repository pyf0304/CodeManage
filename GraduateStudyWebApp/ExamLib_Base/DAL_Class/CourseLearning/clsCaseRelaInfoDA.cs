
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseRelaInfoDA
 表名:CaseRelaInfo(01120389)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:07:53
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 案例相关信息(CaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCaseRelaInfoDA : clsCommBase4DA
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
 return clsCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable_CaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseRelaInfo.* from CaseRelaInfo Left Join {1} on {2} where {3} and CaseRelaInfo.IdCaseRelaInfo not in (Select top {5} CaseRelaInfo.IdCaseRelaInfo from CaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {2} IdCaseRelaInfo from CaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {3} IdCaseRelaInfo from CaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CaseRelaInfo.* from CaseRelaInfo Left Join {1} on {2} where {3} and CaseRelaInfo.IdCaseRelaInfo not in (Select top {5} CaseRelaInfo.IdCaseRelaInfo from CaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {2} IdCaseRelaInfo from CaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {3} IdCaseRelaInfo from CaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = TransNullToInt(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseRelaInfoEN);
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
public List<clsCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsCaseRelaInfoEN> arrObjLst = new List<clsCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = TransNullToInt(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCaseRelaInfo(ref clsCaseRelaInfoEN objCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where IdCaseRelaInfo = " + ""+ objCaseRelaInfoEN.IdCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objDT.Rows[0][conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.FuncModuleId1 = objDT.Rows[0][conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.CaseId1 = objDT.Rows[0][conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1(字段类型:char,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.CaseName1 = objDT.Rows[0][conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1(字段类型:varchar,字段长度:100,是否可空:False)
 objCaseRelaInfoEN.OwnerId1 = objDT.Rows[0][conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseRelaInfoEN.FuncModuleId2 = objDT.Rows[0][conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.CaseId2 = objDT.Rows[0][conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2(字段类型:char,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.CaseName2 = objDT.Rows[0][conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2(字段类型:varchar,字段长度:100,是否可空:False)
 objCaseRelaInfoEN.OwnerId2 = objDT.Rows[0][conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseRelaInfoEN.RelationsDegree = TransNullToInt(objDT.Rows[0][conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.IdCaseRelaInfoType = objDT.Rows[0][conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseRelaInfoEN.UpdDate = objDT.Rows[0][conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseRelaInfoEN.UpdUserId = objDT.Rows[0][conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseRelaInfoEN.Memo = objDT.Rows[0][conCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCaseRelaInfoDA: GetCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsCaseRelaInfoEN GetObjByIdCaseRelaInfo(long lngIdCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
 objCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1(字段类型:char,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1(字段类型:varchar,字段长度:100,是否可空:False)
 objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2(字段类型:char,字段长度:8,是否可空:False)
 objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2(字段类型:varchar,字段长度:100,是否可空:False)
 objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2(字段类型:varchar,字段长度:20,是否可空:False)
 objCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCaseRelaInfoEN.BrowseCount = Int32.Parse(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCaseRelaInfoDA: GetObjByIdCaseRelaInfo)", objException.Message));
}
return objCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN()
{
IdCaseRelaInfo = TransNullToInt(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(), //功能模块Id1
CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(), //案例Id1
CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(), //案例名称1
OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(), //拥有者Id1
FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(), //功能模块Id2
CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(), //案例Id2
CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(), //案例名称2
OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(), //拥有者Id2
RelationsDegree = TransNullToInt(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()), //关系度
IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(), //案例相关信息类型流水号
BrowseCount = TransNullToInt(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim() //备注
};
objCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = TransNullToInt(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCaseRelaInfoDA: GetObjByDataRowCaseRelaInfo)", objException.Message));
}
objCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCaseRelaInfoEN objCaseRelaInfoEN = new clsCaseRelaInfoEN();
try
{
objCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objCaseRelaInfoEN.FuncModuleId1 = objRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objCaseRelaInfoEN.CaseId1 = objRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objCaseRelaInfoEN.CaseName1 = objRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objCaseRelaInfoEN.OwnerId1 = objRow[conCaseRelaInfo.OwnerId1] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objCaseRelaInfoEN.FuncModuleId2 = objRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objCaseRelaInfoEN.CaseId2 = objRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objCaseRelaInfoEN.CaseName2 = objRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objCaseRelaInfoEN.OwnerId2 = objRow[conCaseRelaInfo.OwnerId2] == DBNull.Value ? null : objRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[conCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objCaseRelaInfoEN.IdCaseRelaInfoType = objRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objCaseRelaInfoEN.BrowseCount = TransNullToInt(objRow[conCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objCaseRelaInfoEN.UpdDate = objRow[conCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objCaseRelaInfoEN.UpdUserId = objRow[conCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objCaseRelaInfoEN.Memo = objRow[conCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCaseRelaInfoEN;
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
objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseRelaInfoEN._CurrTabName, conCaseRelaInfo.IdCaseRelaInfo, 8, "");
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
objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCaseRelaInfoEN._CurrTabName, conCaseRelaInfo.IdCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseRelaInfo from CaseRelaInfo where " + strCondition;
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseRelaInfo from CaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseRelaInfo", "IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CaseRelaInfo", strCondition))
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
objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCaseRelaInfoEN objCaseRelaInfoEN)
 {
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseRelaInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseRelaInfo");
objRow = objDS.Tables["CaseRelaInfo"].NewRow();
objRow[conCaseRelaInfo.FuncModuleId1] = objCaseRelaInfoEN.FuncModuleId1; //功能模块Id1
objRow[conCaseRelaInfo.CaseId1] = objCaseRelaInfoEN.CaseId1; //案例Id1
objRow[conCaseRelaInfo.CaseName1] = objCaseRelaInfoEN.CaseName1; //案例名称1
 if (objCaseRelaInfoEN.OwnerId1 !=  "")
 {
objRow[conCaseRelaInfo.OwnerId1] = objCaseRelaInfoEN.OwnerId1; //拥有者Id1
 }
objRow[conCaseRelaInfo.FuncModuleId2] = objCaseRelaInfoEN.FuncModuleId2; //功能模块Id2
objRow[conCaseRelaInfo.CaseId2] = objCaseRelaInfoEN.CaseId2; //案例Id2
objRow[conCaseRelaInfo.CaseName2] = objCaseRelaInfoEN.CaseName2; //案例名称2
 if (objCaseRelaInfoEN.OwnerId2 !=  "")
 {
objRow[conCaseRelaInfo.OwnerId2] = objCaseRelaInfoEN.OwnerId2; //拥有者Id2
 }
objRow[conCaseRelaInfo.RelationsDegree] = objCaseRelaInfoEN.RelationsDegree; //关系度
objRow[conCaseRelaInfo.IdCaseRelaInfoType] = objCaseRelaInfoEN.IdCaseRelaInfoType; //案例相关信息类型流水号
objRow[conCaseRelaInfo.BrowseCount] = objCaseRelaInfoEN.BrowseCount; //浏览次数
 if (objCaseRelaInfoEN.UpdDate !=  "")
 {
objRow[conCaseRelaInfo.UpdDate] = objCaseRelaInfoEN.UpdDate; //修改日期
 }
 if (objCaseRelaInfoEN.UpdUserId !=  "")
 {
objRow[conCaseRelaInfo.UpdUserId] = objCaseRelaInfoEN.UpdUserId; //修改用户Id
 }
 if (objCaseRelaInfoEN.Memo !=  "")
 {
objRow[conCaseRelaInfo.Memo] = objCaseRelaInfoEN.Memo; //备注
 }
objDS.Tables[clsCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId1);
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId1);
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName1);
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName1 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId1);
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId1 + "'");
 }
 
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId2);
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId2);
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName2);
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName2 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId2);
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId2 + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.RelationsDegree);
 arrValueListForInsert.Add(objCaseRelaInfoEN.RelationsDegree.ToString());
 
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.IdCaseRelaInfoType);
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objCaseRelaInfoEN.BrowseCount.ToString());
 
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdDate);
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdUserId);
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.Memo);
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId1);
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId1);
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName1);
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName1 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId1);
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId1 + "'");
 }
 
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId2);
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId2);
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName2);
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName2 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId2);
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId2 + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.RelationsDegree);
 arrValueListForInsert.Add(objCaseRelaInfoEN.RelationsDegree.ToString());
 
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.IdCaseRelaInfoType);
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objCaseRelaInfoEN.BrowseCount.ToString());
 
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdDate);
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdUserId);
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.Memo);
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCaseRelaInfoEN objCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseRelaInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId1);
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId1);
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName1);
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName1 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId1);
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId1 + "'");
 }
 
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId2);
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId2);
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName2);
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName2 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId2);
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId2 + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.RelationsDegree);
 arrValueListForInsert.Add(objCaseRelaInfoEN.RelationsDegree.ToString());
 
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.IdCaseRelaInfoType);
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objCaseRelaInfoEN.BrowseCount.ToString());
 
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdDate);
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdUserId);
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.Memo);
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCaseRelaInfoEN objCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCaseRelaInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId1);
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId1);
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId1 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName1);
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName1 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId1);
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId1 + "'");
 }
 
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.FuncModuleId2);
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseId2);
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseId2 + "'");
 }
 
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.CaseName2);
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCaseName2 + "'");
 }
 
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.OwnerId2);
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwnerId2 + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.RelationsDegree);
 arrValueListForInsert.Add(objCaseRelaInfoEN.RelationsDegree.ToString());
 
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.IdCaseRelaInfoType);
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseRelaInfoType + "'");
 }
 
 arrFieldListForInsert.Add(conCaseRelaInfo.BrowseCount);
 arrValueListForInsert.Add(objCaseRelaInfoEN.BrowseCount.ToString());
 
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdDate);
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.UpdUserId);
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCaseRelaInfo.Memo);
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CaseRelaInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCaseRelaInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where IdCaseRelaInfo = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CaseRelaInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdCaseRelaInfo = TransNullToInt(oRow[conCaseRelaInfo.IdCaseRelaInfo].ToString().Trim());
if (IsExist(lngIdCaseRelaInfo))
{
 string strResult = "关键字变量值为:" + string.Format("IdCaseRelaInfo = {0}", lngIdCaseRelaInfo) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCaseRelaInfoEN._CurrTabName ].NewRow();
objRow[conCaseRelaInfo.FuncModuleId1] = oRow[conCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objRow[conCaseRelaInfo.CaseId1] = oRow[conCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objRow[conCaseRelaInfo.CaseName1] = oRow[conCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objRow[conCaseRelaInfo.OwnerId1] = oRow[conCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objRow[conCaseRelaInfo.FuncModuleId2] = oRow[conCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objRow[conCaseRelaInfo.CaseId2] = oRow[conCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objRow[conCaseRelaInfo.CaseName2] = oRow[conCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objRow[conCaseRelaInfo.OwnerId2] = oRow[conCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objRow[conCaseRelaInfo.RelationsDegree] = oRow[conCaseRelaInfo.RelationsDegree].ToString().Trim(); //关系度
objRow[conCaseRelaInfo.IdCaseRelaInfoType] = oRow[conCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objRow[conCaseRelaInfo.BrowseCount] = oRow[conCaseRelaInfo.BrowseCount].ToString().Trim(); //浏览次数
objRow[conCaseRelaInfo.UpdDate] = oRow[conCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objRow[conCaseRelaInfo.UpdUserId] = oRow[conCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conCaseRelaInfo.Memo] = oRow[conCaseRelaInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCaseRelaInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objCaseRelaInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseRelaInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from CaseRelaInfo where IdCaseRelaInfo = " + ""+ objCaseRelaInfoEN.IdCaseRelaInfo+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCaseRelaInfoEN._CurrTabName);
if (objDS.Tables[clsCaseRelaInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCaseRelaInfo = " + ""+ objCaseRelaInfoEN.IdCaseRelaInfo+"");
return false;
}
objRow = objDS.Tables[clsCaseRelaInfoEN._CurrTabName].Rows[0];
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId1))
 {
objRow[conCaseRelaInfo.FuncModuleId1] = objCaseRelaInfoEN.FuncModuleId1; //功能模块Id1
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId1))
 {
objRow[conCaseRelaInfo.CaseId1] = objCaseRelaInfoEN.CaseId1; //案例Id1
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName1))
 {
objRow[conCaseRelaInfo.CaseName1] = objCaseRelaInfoEN.CaseName1; //案例名称1
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId1))
 {
objRow[conCaseRelaInfo.OwnerId1] = objCaseRelaInfoEN.OwnerId1; //拥有者Id1
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId2))
 {
objRow[conCaseRelaInfo.FuncModuleId2] = objCaseRelaInfoEN.FuncModuleId2; //功能模块Id2
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId2))
 {
objRow[conCaseRelaInfo.CaseId2] = objCaseRelaInfoEN.CaseId2; //案例Id2
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName2))
 {
objRow[conCaseRelaInfo.CaseName2] = objCaseRelaInfoEN.CaseName2; //案例名称2
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId2))
 {
objRow[conCaseRelaInfo.OwnerId2] = objCaseRelaInfoEN.OwnerId2; //拥有者Id2
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.RelationsDegree))
 {
objRow[conCaseRelaInfo.RelationsDegree] = objCaseRelaInfoEN.RelationsDegree; //关系度
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType))
 {
objRow[conCaseRelaInfo.IdCaseRelaInfoType] = objCaseRelaInfoEN.IdCaseRelaInfoType; //案例相关信息类型流水号
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.BrowseCount))
 {
objRow[conCaseRelaInfo.BrowseCount] = objCaseRelaInfoEN.BrowseCount; //浏览次数
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdDate))
 {
objRow[conCaseRelaInfo.UpdDate] = objCaseRelaInfoEN.UpdDate; //修改日期
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdUserId))
 {
objRow[conCaseRelaInfo.UpdUserId] = objCaseRelaInfoEN.UpdUserId; //修改用户Id
 }
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.Memo))
 {
objRow[conCaseRelaInfo.Memo] = objCaseRelaInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCaseRelaInfoEN._CurrTabName);
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CaseRelaInfo Set ");
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId1))
 {
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId1, conCaseRelaInfo.FuncModuleId1); //功能模块Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.FuncModuleId1); //功能模块Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId1))
 {
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId1, conCaseRelaInfo.CaseId1); //案例Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseId1); //案例Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName1))
 {
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName1, conCaseRelaInfo.CaseName1); //案例名称1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseName1); //案例名称1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId1))
 {
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId1, conCaseRelaInfo.OwnerId1); //拥有者Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.OwnerId1); //拥有者Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId2))
 {
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId2, conCaseRelaInfo.FuncModuleId2); //功能模块Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.FuncModuleId2); //功能模块Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId2))
 {
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId2, conCaseRelaInfo.CaseId2); //案例Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseId2); //案例Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName2))
 {
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName2, conCaseRelaInfo.CaseName2); //案例名称2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseName2); //案例名称2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId2))
 {
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId2, conCaseRelaInfo.OwnerId2); //拥有者Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.OwnerId2); //拥有者Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.RelationsDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseRelaInfoEN.RelationsDegree, conCaseRelaInfo.RelationsDegree); //关系度
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType))
 {
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseRelaInfoType, conCaseRelaInfo.IdCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.IdCaseRelaInfoType); //案例相关信息类型流水号
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseRelaInfoEN.BrowseCount, conCaseRelaInfo.BrowseCount); //浏览次数
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdDate))
 {
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseRelaInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.UpdDate); //修改日期
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdUserId))
 {
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseRelaInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.Memo))
 {
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseRelaInfo = {0}", objCaseRelaInfoEN.IdCaseRelaInfo); 
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCaseRelaInfoEN objCaseRelaInfoEN, string strCondition)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseRelaInfo Set ");
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId1))
 {
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId1 = '{0}',", strFuncModuleId1); //功能模块Id1
 }
 else
 {
 sbSQL.Append(" FuncModuleId1 = null,"); //功能模块Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId1))
 {
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId1 = '{0}',", strCaseId1); //案例Id1
 }
 else
 {
 sbSQL.Append(" CaseId1 = null,"); //案例Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName1))
 {
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName1 = '{0}',", strCaseName1); //案例名称1
 }
 else
 {
 sbSQL.Append(" CaseName1 = null,"); //案例名称1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId1))
 {
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId1 = '{0}',", strOwnerId1); //拥有者Id1
 }
 else
 {
 sbSQL.Append(" OwnerId1 = null,"); //拥有者Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId2))
 {
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId2 = '{0}',", strFuncModuleId2); //功能模块Id2
 }
 else
 {
 sbSQL.Append(" FuncModuleId2 = null,"); //功能模块Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId2))
 {
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId2 = '{0}',", strCaseId2); //案例Id2
 }
 else
 {
 sbSQL.Append(" CaseId2 = null,"); //案例Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName2))
 {
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName2 = '{0}',", strCaseName2); //案例名称2
 }
 else
 {
 sbSQL.Append(" CaseName2 = null,"); //案例名称2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId2))
 {
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId2 = '{0}',", strOwnerId2); //拥有者Id2
 }
 else
 {
 sbSQL.Append(" OwnerId2 = null,"); //拥有者Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.RelationsDegree))
 {
 sbSQL.AppendFormat(" RelationsDegree = {0},", objCaseRelaInfoEN.RelationsDegree); //关系度
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType))
 {
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseRelaInfoType = '{0}',", strIdCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseRelaInfoType = null,"); //案例相关信息类型流水号
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdDate))
 {
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdUserId))
 {
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.Memo))
 {
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseRelaInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCaseRelaInfoEN objCaseRelaInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseRelaInfo Set ");
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId1))
 {
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId1 = '{0}',", strFuncModuleId1); //功能模块Id1
 }
 else
 {
 sbSQL.Append(" FuncModuleId1 = null,"); //功能模块Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId1))
 {
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId1 = '{0}',", strCaseId1); //案例Id1
 }
 else
 {
 sbSQL.Append(" CaseId1 = null,"); //案例Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName1))
 {
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName1 = '{0}',", strCaseName1); //案例名称1
 }
 else
 {
 sbSQL.Append(" CaseName1 = null,"); //案例名称1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId1))
 {
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId1 = '{0}',", strOwnerId1); //拥有者Id1
 }
 else
 {
 sbSQL.Append(" OwnerId1 = null,"); //拥有者Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId2))
 {
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId2 = '{0}',", strFuncModuleId2); //功能模块Id2
 }
 else
 {
 sbSQL.Append(" FuncModuleId2 = null,"); //功能模块Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId2))
 {
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseId2 = '{0}',", strCaseId2); //案例Id2
 }
 else
 {
 sbSQL.Append(" CaseId2 = null,"); //案例Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName2))
 {
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CaseName2 = '{0}',", strCaseName2); //案例名称2
 }
 else
 {
 sbSQL.Append(" CaseName2 = null,"); //案例名称2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId2))
 {
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OwnerId2 = '{0}',", strOwnerId2); //拥有者Id2
 }
 else
 {
 sbSQL.Append(" OwnerId2 = null,"); //拥有者Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.RelationsDegree))
 {
 sbSQL.AppendFormat(" RelationsDegree = {0},", objCaseRelaInfoEN.RelationsDegree); //关系度
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType))
 {
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseRelaInfoType = '{0}',", strIdCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseRelaInfoType = null,"); //案例相关信息类型流水号
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat(" BrowseCount = {0},", objCaseRelaInfoEN.BrowseCount); //浏览次数
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdDate))
 {
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdUserId))
 {
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.Memo))
 {
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCaseRelaInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCaseRelaInfoEN objCaseRelaInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCaseRelaInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCaseRelaInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCaseRelaInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CaseRelaInfo Set ");
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId1))
 {
 if (objCaseRelaInfoEN.FuncModuleId1 !=  null)
 {
 var strFuncModuleId1 = objCaseRelaInfoEN.FuncModuleId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId1, conCaseRelaInfo.FuncModuleId1); //功能模块Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.FuncModuleId1); //功能模块Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId1))
 {
 if (objCaseRelaInfoEN.CaseId1 !=  null)
 {
 var strCaseId1 = objCaseRelaInfoEN.CaseId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId1, conCaseRelaInfo.CaseId1); //案例Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseId1); //案例Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName1))
 {
 if (objCaseRelaInfoEN.CaseName1 !=  null)
 {
 var strCaseName1 = objCaseRelaInfoEN.CaseName1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName1, conCaseRelaInfo.CaseName1); //案例名称1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseName1); //案例名称1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId1))
 {
 if (objCaseRelaInfoEN.OwnerId1 !=  null)
 {
 var strOwnerId1 = objCaseRelaInfoEN.OwnerId1.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId1, conCaseRelaInfo.OwnerId1); //拥有者Id1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.OwnerId1); //拥有者Id1
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.FuncModuleId2))
 {
 if (objCaseRelaInfoEN.FuncModuleId2 !=  null)
 {
 var strFuncModuleId2 = objCaseRelaInfoEN.FuncModuleId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId2, conCaseRelaInfo.FuncModuleId2); //功能模块Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.FuncModuleId2); //功能模块Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseId2))
 {
 if (objCaseRelaInfoEN.CaseId2 !=  null)
 {
 var strCaseId2 = objCaseRelaInfoEN.CaseId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseId2, conCaseRelaInfo.CaseId2); //案例Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseId2); //案例Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.CaseName2))
 {
 if (objCaseRelaInfoEN.CaseName2 !=  null)
 {
 var strCaseName2 = objCaseRelaInfoEN.CaseName2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCaseName2, conCaseRelaInfo.CaseName2); //案例名称2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.CaseName2); //案例名称2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.OwnerId2))
 {
 if (objCaseRelaInfoEN.OwnerId2 !=  null)
 {
 var strOwnerId2 = objCaseRelaInfoEN.OwnerId2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwnerId2, conCaseRelaInfo.OwnerId2); //拥有者Id2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.OwnerId2); //拥有者Id2
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.RelationsDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseRelaInfoEN.RelationsDegree, conCaseRelaInfo.RelationsDegree); //关系度
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.IdCaseRelaInfoType))
 {
 if (objCaseRelaInfoEN.IdCaseRelaInfoType !=  null)
 {
 var strIdCaseRelaInfoType = objCaseRelaInfoEN.IdCaseRelaInfoType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseRelaInfoType, conCaseRelaInfo.IdCaseRelaInfoType); //案例相关信息类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.IdCaseRelaInfoType); //案例相关信息类型流水号
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.BrowseCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCaseRelaInfoEN.BrowseCount, conCaseRelaInfo.BrowseCount); //浏览次数
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdDate))
 {
 if (objCaseRelaInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objCaseRelaInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCaseRelaInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.UpdDate); //修改日期
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.UpdUserId))
 {
 if (objCaseRelaInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objCaseRelaInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conCaseRelaInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objCaseRelaInfoEN.IsUpdated(conCaseRelaInfo.Memo))
 {
 if (objCaseRelaInfoEN.Memo !=  null)
 {
 var strMemo = objCaseRelaInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCaseRelaInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCaseRelaInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCaseRelaInfo = {0}", objCaseRelaInfoEN.IdCaseRelaInfo); 
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
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdCaseRelaInfo) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdCaseRelaInfo,
};
 objSQL.ExecSP("CaseRelaInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdCaseRelaInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
//删除CaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseRelaInfo where IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCaseRelaInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
//删除CaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseRelaInfo where IdCaseRelaInfo in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdCaseRelaInfo) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
//删除CaseRelaInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CaseRelaInfo where IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: DelCaseRelaInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseRelaInfo where " + strCondition ;
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
public bool DelCaseRelaInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCaseRelaInfoDA: DelCaseRelaInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CaseRelaInfo where " + strCondition ;
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
 /// <param name = "objCaseRelaInfoENS">源对象</param>
 /// <param name = "objCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsCaseRelaInfoEN objCaseRelaInfoENS, clsCaseRelaInfoEN objCaseRelaInfoENT)
{
objCaseRelaInfoENT.IdCaseRelaInfo = objCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
objCaseRelaInfoENT.FuncModuleId1 = objCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objCaseRelaInfoENT.CaseId1 = objCaseRelaInfoENS.CaseId1; //案例Id1
objCaseRelaInfoENT.CaseName1 = objCaseRelaInfoENS.CaseName1; //案例名称1
objCaseRelaInfoENT.OwnerId1 = objCaseRelaInfoENS.OwnerId1; //拥有者Id1
objCaseRelaInfoENT.FuncModuleId2 = objCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objCaseRelaInfoENT.CaseId2 = objCaseRelaInfoENS.CaseId2; //案例Id2
objCaseRelaInfoENT.CaseName2 = objCaseRelaInfoENS.CaseName2; //案例名称2
objCaseRelaInfoENT.OwnerId2 = objCaseRelaInfoENS.OwnerId2; //拥有者Id2
objCaseRelaInfoENT.RelationsDegree = objCaseRelaInfoENS.RelationsDegree; //关系度
objCaseRelaInfoENT.IdCaseRelaInfoType = objCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objCaseRelaInfoENT.BrowseCount = objCaseRelaInfoENS.BrowseCount; //浏览次数
objCaseRelaInfoENT.UpdDate = objCaseRelaInfoENS.UpdDate; //修改日期
objCaseRelaInfoENT.UpdUserId = objCaseRelaInfoENS.UpdUserId; //修改用户Id
objCaseRelaInfoENT.Memo = objCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.FuncModuleId1, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.CaseId1, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.CaseName1, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.FuncModuleId2, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.CaseId2, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.CaseName2, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.RelationsDegree, conCaseRelaInfo.RelationsDegree);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.IdCaseRelaInfoType, conCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckFieldNotNull(objCaseRelaInfoEN.BrowseCount, conCaseRelaInfo.BrowseCount);
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId1, 8, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName1, 100, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId1, 20, conCaseRelaInfo.OwnerId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId2, 8, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName2, 100, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId2, 20, conCaseRelaInfo.OwnerId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.IdCaseRelaInfoType, 4, conCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdDate, 20, conCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdUserId, 20, conCaseRelaInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.Memo, 1000, conCaseRelaInfo.Memo);
//检查字段外键固定长度
 objCaseRelaInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId1, 8, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName1, 100, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId1, 20, conCaseRelaInfo.OwnerId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId2, 8, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName2, 100, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId2, 20, conCaseRelaInfo.OwnerId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.IdCaseRelaInfoType, 4, conCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdDate, 20, conCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdUserId, 20, conCaseRelaInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.Memo, 1000, conCaseRelaInfo.Memo);
//检查外键字段长度
 objCaseRelaInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId1, 4, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId1, 8, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName1, 100, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId1, 20, conCaseRelaInfo.OwnerId1);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.FuncModuleId2, 4, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseId2, 8, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.CaseName2, 100, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.OwnerId2, 20, conCaseRelaInfo.OwnerId2);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.IdCaseRelaInfoType, 4, conCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdDate, 20, conCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.UpdUserId, 20, conCaseRelaInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objCaseRelaInfoEN.Memo, 1000, conCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.FuncModuleId1, conCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.CaseId1, conCaseRelaInfo.CaseId1);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.CaseName1, conCaseRelaInfo.CaseName1);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.OwnerId1, conCaseRelaInfo.OwnerId1);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.FuncModuleId2, conCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.CaseId2, conCaseRelaInfo.CaseId2);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.CaseName2, conCaseRelaInfo.CaseName2);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.OwnerId2, conCaseRelaInfo.OwnerId2);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.IdCaseRelaInfoType, conCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.UpdDate, conCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.UpdUserId, conCaseRelaInfo.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objCaseRelaInfoEN.Memo, conCaseRelaInfo.Memo);
//检查外键字段长度
 objCaseRelaInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CaseRelaInfo(案例相关信息),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCaseRelaInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCaseRelaInfoEN objCaseRelaInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId1 = '{0}'", objCaseRelaInfoEN.CaseId1);
 sbCondition.AppendFormat(" and CaseId2 = '{0}'", objCaseRelaInfoEN.CaseId2);
 sbCondition.AppendFormat(" and IdCaseRelaInfoType = '{0}'", objCaseRelaInfoEN.IdCaseRelaInfoType);
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}