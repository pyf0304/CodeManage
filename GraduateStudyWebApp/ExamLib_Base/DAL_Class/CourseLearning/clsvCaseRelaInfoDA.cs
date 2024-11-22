
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseRelaInfoDA
 表名:vCaseRelaInfo(01120390)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:43
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
 /// v案例相关信息(vCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCaseRelaInfoDA : clsCommBase4DA
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
 return clsvCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable_vCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseRelaInfo.* from vCaseRelaInfo Left Join {1} on {2} where {3} and vCaseRelaInfo.IdCaseRelaInfo not in (Select top {5} vCaseRelaInfo.IdCaseRelaInfo from vCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {2} IdCaseRelaInfo from vCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {3} IdCaseRelaInfo from vCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseRelaInfo.* from vCaseRelaInfo Left Join {1} on {2} where {3} and vCaseRelaInfo.IdCaseRelaInfo not in (Select top {5} vCaseRelaInfo.IdCaseRelaInfo from vCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {2} IdCaseRelaInfo from vCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseRelaInfo where {1} and IdCaseRelaInfo not in (Select top {3} IdCaseRelaInfo from vCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseRelaInfoEN);
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
public List<clsvCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCaseRelaInfoEN> arrObjLst = new List<clsvCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCaseRelaInfo(ref clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where IdCaseRelaInfo = " + ""+ objvCaseRelaInfoEN.IdCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objDT.Rows[0][convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleId1 = objDT.Rows[0][convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleName1 = objDT.Rows[0][convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.CaseId1 = objDT.Rows[0][convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1(字段类型:char,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.CaseName1 = objDT.Rows[0][convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseRelaInfoEN.OwnerId1 = objDT.Rows[0][convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseRelaInfoEN.OwnerName1 = objDT.Rows[0][convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.FuncModuleId2 = objDT.Rows[0][convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleName2 = objDT.Rows[0][convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.CaseId2 = objDT.Rows[0][convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2(字段类型:char,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.CaseName2 = objDT.Rows[0][convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseRelaInfoEN.OwnerId2 = objDT.Rows[0][convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseRelaInfoEN.OwnerName2 = objDT.Rows[0][convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.IdCaseRelaInfoType = objDT.Rows[0][convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.CaseRelaInfoTypeName = objDT.Rows[0][convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseRelaInfoEN.RelationsDegree = TransNullToInt(objDT.Rows[0][convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseRelaInfoEN.UpdUserId = objDT.Rows[0][convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseRelaInfoEN.UpdDate = objDT.Rows[0][convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseRelaInfoEN.Memo = objDT.Rows[0][convCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetvCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvCaseRelaInfoEN GetObjByIdCaseRelaInfo(long lngIdCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
 objvCaseRelaInfoEN.IdCaseRelaInfo = Int32.Parse(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1(字段类型:char,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2(字段类型:char,字段长度:8,是否可空:False)
 objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCaseRelaInfoEN.RelationsDegree = Int32.Parse(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度(字段类型:int,字段长度:4,是否可空:False)
 objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetObjByIdCaseRelaInfo)", objException.Message));
}
return objvCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN()
{
IdCaseRelaInfo = TransNullToInt(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(), //功能模块Id1
FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(), //功能模块名称1
CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(), //案例Id1
CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(), //案例名称1
OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(), //拥有者Id1
OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(), //拥有者姓名1
FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(), //功能模块Id2
FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(), //功能模块名称2
CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(), //案例Id2
CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(), //案例名称2
OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(), //拥有者Id2
OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(), //拥有者姓名2
IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(), //案例相关信息类型流水号
CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(), //案例相关信息类型名称
RelationsDegree = TransNullToInt(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()), //关系度
BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetObjByDataRowvCaseRelaInfo)", objException.Message));
}
objvCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseRelaInfoEN objvCaseRelaInfoEN = new clsvCaseRelaInfoEN();
try
{
objvCaseRelaInfoEN.IdCaseRelaInfo = TransNullToInt(objRow[convCaseRelaInfo.IdCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvCaseRelaInfoEN.FuncModuleId1 = objRow[convCaseRelaInfo.FuncModuleId1].ToString().Trim(); //功能模块Id1
objvCaseRelaInfoEN.FuncModuleName1 = objRow[convCaseRelaInfo.FuncModuleName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName1].ToString().Trim(); //功能模块名称1
objvCaseRelaInfoEN.CaseId1 = objRow[convCaseRelaInfo.CaseId1].ToString().Trim(); //案例Id1
objvCaseRelaInfoEN.CaseName1 = objRow[convCaseRelaInfo.CaseName1].ToString().Trim(); //案例名称1
objvCaseRelaInfoEN.OwnerId1 = objRow[convCaseRelaInfo.OwnerId1].ToString().Trim(); //拥有者Id1
objvCaseRelaInfoEN.OwnerName1 = objRow[convCaseRelaInfo.OwnerName1] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName1].ToString().Trim(); //拥有者姓名1
objvCaseRelaInfoEN.FuncModuleId2 = objRow[convCaseRelaInfo.FuncModuleId2].ToString().Trim(); //功能模块Id2
objvCaseRelaInfoEN.FuncModuleName2 = objRow[convCaseRelaInfo.FuncModuleName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.FuncModuleName2].ToString().Trim(); //功能模块名称2
objvCaseRelaInfoEN.CaseId2 = objRow[convCaseRelaInfo.CaseId2].ToString().Trim(); //案例Id2
objvCaseRelaInfoEN.CaseName2 = objRow[convCaseRelaInfo.CaseName2].ToString().Trim(); //案例名称2
objvCaseRelaInfoEN.OwnerId2 = objRow[convCaseRelaInfo.OwnerId2].ToString().Trim(); //拥有者Id2
objvCaseRelaInfoEN.OwnerName2 = objRow[convCaseRelaInfo.OwnerName2] == DBNull.Value ? null : objRow[convCaseRelaInfo.OwnerName2].ToString().Trim(); //拥有者姓名2
objvCaseRelaInfoEN.IdCaseRelaInfoType = objRow[convCaseRelaInfo.IdCaseRelaInfoType].ToString().Trim(); //案例相关信息类型流水号
objvCaseRelaInfoEN.CaseRelaInfoTypeName = objRow[convCaseRelaInfo.CaseRelaInfoTypeName].ToString().Trim(); //案例相关信息类型名称
objvCaseRelaInfoEN.RelationsDegree = TransNullToInt(objRow[convCaseRelaInfo.RelationsDegree].ToString().Trim()); //关系度
objvCaseRelaInfoEN.BrowseCount = objRow[convCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvCaseRelaInfoEN.UpdUserId = objRow[convCaseRelaInfo.UpdUserId] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseRelaInfoEN.UpdDate = objRow[convCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvCaseRelaInfoEN.Memo = objRow[convCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseRelaInfoEN;
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
objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseRelaInfoEN._CurrTabName, convCaseRelaInfo.IdCaseRelaInfo, 8, "");
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
objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseRelaInfoEN._CurrTabName, convCaseRelaInfo.IdCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCaseRelaInfo from vCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCaseRelaInfo from vCaseRelaInfo where " + strCondition;
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseRelaInfo", "IdCaseRelaInfo = " + ""+ lngIdCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseRelaInfo", strCondition))
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
objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCaseRelaInfoENS">源对象</param>
 /// <param name = "objvCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvCaseRelaInfoEN objvCaseRelaInfoENS, clsvCaseRelaInfoEN objvCaseRelaInfoENT)
{
objvCaseRelaInfoENT.IdCaseRelaInfo = objvCaseRelaInfoENS.IdCaseRelaInfo; //案例相关信息流水号
objvCaseRelaInfoENT.FuncModuleId1 = objvCaseRelaInfoENS.FuncModuleId1; //功能模块Id1
objvCaseRelaInfoENT.FuncModuleName1 = objvCaseRelaInfoENS.FuncModuleName1; //功能模块名称1
objvCaseRelaInfoENT.CaseId1 = objvCaseRelaInfoENS.CaseId1; //案例Id1
objvCaseRelaInfoENT.CaseName1 = objvCaseRelaInfoENS.CaseName1; //案例名称1
objvCaseRelaInfoENT.OwnerId1 = objvCaseRelaInfoENS.OwnerId1; //拥有者Id1
objvCaseRelaInfoENT.OwnerName1 = objvCaseRelaInfoENS.OwnerName1; //拥有者姓名1
objvCaseRelaInfoENT.FuncModuleId2 = objvCaseRelaInfoENS.FuncModuleId2; //功能模块Id2
objvCaseRelaInfoENT.FuncModuleName2 = objvCaseRelaInfoENS.FuncModuleName2; //功能模块名称2
objvCaseRelaInfoENT.CaseId2 = objvCaseRelaInfoENS.CaseId2; //案例Id2
objvCaseRelaInfoENT.CaseName2 = objvCaseRelaInfoENS.CaseName2; //案例名称2
objvCaseRelaInfoENT.OwnerId2 = objvCaseRelaInfoENS.OwnerId2; //拥有者Id2
objvCaseRelaInfoENT.OwnerName2 = objvCaseRelaInfoENS.OwnerName2; //拥有者姓名2
objvCaseRelaInfoENT.IdCaseRelaInfoType = objvCaseRelaInfoENS.IdCaseRelaInfoType; //案例相关信息类型流水号
objvCaseRelaInfoENT.CaseRelaInfoTypeName = objvCaseRelaInfoENS.CaseRelaInfoTypeName; //案例相关信息类型名称
objvCaseRelaInfoENT.RelationsDegree = objvCaseRelaInfoENS.RelationsDegree; //关系度
objvCaseRelaInfoENT.BrowseCount = objvCaseRelaInfoENS.BrowseCount; //浏览次数
objvCaseRelaInfoENT.UpdUserId = objvCaseRelaInfoENS.UpdUserId; //修改用户Id
objvCaseRelaInfoENT.UpdDate = objvCaseRelaInfoENS.UpdDate; //修改日期
objvCaseRelaInfoENT.Memo = objvCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCaseRelaInfoEN objvCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.FuncModuleId1, 4, convCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.FuncModuleName1, 30, convCaseRelaInfo.FuncModuleName1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.CaseId1, 8, convCaseRelaInfo.CaseId1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.CaseName1, 100, convCaseRelaInfo.CaseName1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.OwnerId1, 20, convCaseRelaInfo.OwnerId1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.OwnerName1, 30, convCaseRelaInfo.OwnerName1);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.FuncModuleId2, 4, convCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.FuncModuleName2, 30, convCaseRelaInfo.FuncModuleName2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.CaseId2, 8, convCaseRelaInfo.CaseId2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.CaseName2, 100, convCaseRelaInfo.CaseName2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.OwnerId2, 20, convCaseRelaInfo.OwnerId2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.OwnerName2, 30, convCaseRelaInfo.OwnerName2);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.IdCaseRelaInfoType, 4, convCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.CaseRelaInfoTypeName, 50, convCaseRelaInfo.CaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.UpdUserId, 20, convCaseRelaInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.UpdDate, 20, convCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvCaseRelaInfoEN.Memo, 1000, convCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.FuncModuleId1, convCaseRelaInfo.FuncModuleId1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.FuncModuleName1, convCaseRelaInfo.FuncModuleName1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.CaseId1, convCaseRelaInfo.CaseId1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.CaseName1, convCaseRelaInfo.CaseName1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.OwnerId1, convCaseRelaInfo.OwnerId1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.OwnerName1, convCaseRelaInfo.OwnerName1);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.FuncModuleId2, convCaseRelaInfo.FuncModuleId2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.FuncModuleName2, convCaseRelaInfo.FuncModuleName2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.CaseId2, convCaseRelaInfo.CaseId2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.CaseName2, convCaseRelaInfo.CaseName2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.OwnerId2, convCaseRelaInfo.OwnerId2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.OwnerName2, convCaseRelaInfo.OwnerName2);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.IdCaseRelaInfoType, convCaseRelaInfo.IdCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.CaseRelaInfoTypeName, convCaseRelaInfo.CaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.UpdUserId, convCaseRelaInfo.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.UpdDate, convCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseRelaInfoEN.Memo, convCaseRelaInfo.Memo);
//检查外键字段长度
 objvCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}