
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseRelaInfoDA
 表名:vEduMSTRGiftedClsCaseRelaInfo(01120402)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// v教育硕士优课案例相关信息(vEduMSTRGiftedClsCaseRelaInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEduMSTRGiftedClsCaseRelaInfoDA : clsCommBase4DA
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
 return clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseRelaInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseRelaInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseRelaInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseRelaInfoEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEduMSTRGiftedClsCaseRelaInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable_vEduMSTRGiftedClsCaseRelaInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCaseRelaInfo.* from vEduMSTRGiftedClsCaseRelaInfo Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCaseRelaInfo.* from vEduMSTRGiftedClsCaseRelaInfo Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo not in (Select top {5} vEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {2} IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseRelaInfo where {1} and IdMicroTeachCaseRelaInfo not in (Select top {3} IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA:GetObjLst)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN();
try
{
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseRelaInfoEN);
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
public List<clsvEduMSTRGiftedClsCaseRelaInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseRelaInfoEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseRelaInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN();
try
{
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseRelaInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEduMSTRGiftedClsCaseRelaInfo(ref clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objDT.Rows[0][convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetvEduMSTRGiftedClsCaseRelaInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByIdMicroTeachCaseRelaInfo(long lngIdMicroTeachCaseRelaInfo)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN();
try
{
 objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = Int32.Parse(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetObjByIdMicroTeachCaseRelaInfo)", objException.Message));
}
return objvEduMSTRGiftedClsCaseRelaInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEduMSTRGiftedClsCaseRelaInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN()
{
EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()), //案例相关信息流水号
FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(), //学院名称简写
MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(), //专业名称
IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(), //文件名称
FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(), //旧文件名
IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(), //微格案例相关信息类型流水号
MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(), //微格案例相关信息类型名称
IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()), //浏览次数
Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(), //标志
UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim() //备注
};
objvEduMSTRGiftedClsCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseRelaInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN();
try
{
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetObjByDataRowvEduMSTRGiftedClsCaseRelaInfo)", objException.Message));
}
objvEduMSTRGiftedClsCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseRelaInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseRelaInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN = new clsvEduMSTRGiftedClsCaseRelaInfoEN();
try
{
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfo = TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo].ToString().Trim()); //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.FileName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCaseRelaInfoEN.FileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID = objRow[convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCaseRelaInfoEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName = objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType = objRow[convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType].ToString().Trim(); //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = objRow[convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName].ToString().Trim(); //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCaseRelaInfo.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCaseRelaInfoEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseRelaInfo.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoEN.Flag = objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Flag].ToString().Trim(); //标志
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser = objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseRelaInfoEN.Memo = objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseRelaInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA: GetObjByDataRow)", objException.Message));
}
objvEduMSTRGiftedClsCaseRelaInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseRelaInfoEN;
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
objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName, convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, "");
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
objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName, convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfo, 8, strPrefix);
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroTeachCaseRelaInfo from vEduMSTRGiftedClsCaseRelaInfo where " + strCondition;
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
 /// <param name = "lngIdMicroTeachCaseRelaInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdMicroTeachCaseRelaInfo)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCaseRelaInfo", "IdMicroTeachCaseRelaInfo = " + ""+ lngIdMicroTeachCaseRelaInfo+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseRelaInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCaseRelaInfo", strCondition))
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
objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEduMSTRGiftedClsCaseRelaInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseRelaInfoENT">目标对象</param>
public void CopyTo(clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoENS, clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoENT)
{
objvEduMSTRGiftedClsCaseRelaInfoENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseRelaInfoENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseRelaInfoENT.IdMicroTeachCaseRelaInfo = objvEduMSTRGiftedClsCaseRelaInfoENS.IdMicroTeachCaseRelaInfo; //案例相关信息流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.FuncModuleId = objvEduMSTRGiftedClsCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCaseRelaInfoENT.FuncModuleName = objvEduMSTRGiftedClsCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IdMicroteachCase = objvEduMSTRGiftedClsCaseRelaInfoENS.IdMicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseRelaInfoENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseRelaInfoENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IdXzCollege = objvEduMSTRGiftedClsCaseRelaInfoENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeID = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeName = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseRelaInfoENT.CollegeNameA = objvEduMSTRGiftedClsCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseRelaInfoENT.MajorName = objvEduMSTRGiftedClsCaseRelaInfoENS.MajorName; //专业名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IdResource = objvEduMSTRGiftedClsCaseRelaInfoENS.IdResource; //资源流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceID = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceID; //资源ID
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceName = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceName; //资源名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IdFtpResource = objvEduMSTRGiftedClsCaseRelaInfoENS.IdFtpResource; //FTP资源流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.IdFile = objvEduMSTRGiftedClsCaseRelaInfoENS.IdFile; //文件流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.FileName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileName; //文件名称
objvEduMSTRGiftedClsCaseRelaInfoENT.FileType = objvEduMSTRGiftedClsCaseRelaInfoENS.FileType; //文件类型
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveDate = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveDate; //创建日期
objvEduMSTRGiftedClsCaseRelaInfoENT.FileSize = objvEduMSTRGiftedClsCaseRelaInfoENS.FileSize; //文件大小
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveTime = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveTime; //创建时间
objvEduMSTRGiftedClsCaseRelaInfoENT.FtpResourceID = objvEduMSTRGiftedClsCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOriginalName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOriginalName; //文件原名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileDirName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileDirName; //文件目录名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileRename = objvEduMSTRGiftedClsCaseRelaInfoENS.FileRename; //文件新名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileUpDate = objvEduMSTRGiftedClsCaseRelaInfoENS.FileUpDate; //创建日期
objvEduMSTRGiftedClsCaseRelaInfoENT.FileUpTime = objvEduMSTRGiftedClsCaseRelaInfoENS.FileUpTime; //创建时间
objvEduMSTRGiftedClsCaseRelaInfoENT.SaveMode = objvEduMSTRGiftedClsCaseRelaInfoENS.SaveMode; //文件存放方式
objvEduMSTRGiftedClsCaseRelaInfoENT.IdResourceType = objvEduMSTRGiftedClsCaseRelaInfoENS.IdResourceType; //资源类型流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceTypeID = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceTypeName = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvEduMSTRGiftedClsCaseRelaInfoENT.ResourceOwner = objvEduMSTRGiftedClsCaseRelaInfoENS.ResourceOwner; //上传者
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpFileType = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpFileSize = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvEduMSTRGiftedClsCaseRelaInfoENT.ftpResourceOwner = objvEduMSTRGiftedClsCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOriginName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOriginName; //原文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.IsExistFile = objvEduMSTRGiftedClsCaseRelaInfoENS.IsExistFile; //是否存在文件
objvEduMSTRGiftedClsCaseRelaInfoENT.FileNewName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileNewName; //新文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.FileOldName = objvEduMSTRGiftedClsCaseRelaInfoENS.FileOldName; //旧文件名
objvEduMSTRGiftedClsCaseRelaInfoENT.IdMicroTeachCaseRelaInfoType = objvEduMSTRGiftedClsCaseRelaInfoENS.IdMicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvEduMSTRGiftedClsCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvEduMSTRGiftedClsCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvEduMSTRGiftedClsCaseRelaInfoENT.IsVisible = objvEduMSTRGiftedClsCaseRelaInfoENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCaseRelaInfoENT.BrowseCount = objvEduMSTRGiftedClsCaseRelaInfoENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCaseRelaInfoENT.Flag = objvEduMSTRGiftedClsCaseRelaInfoENS.Flag; //标志
objvEduMSTRGiftedClsCaseRelaInfoENT.UpdDate = objvEduMSTRGiftedClsCaseRelaInfoENS.UpdDate; //修改日期
objvEduMSTRGiftedClsCaseRelaInfoENT.UpdUser = objvEduMSTRGiftedClsCaseRelaInfoENS.UpdUser; //修改人
objvEduMSTRGiftedClsCaseRelaInfoENT.Memo = objvEduMSTRGiftedClsCaseRelaInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEduMSTRGiftedClsCaseRelaInfoEN objvEduMSTRGiftedClsCaseRelaInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId, 4, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName, 30, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase, 8, convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege, 4, convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID, 4, convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName, 100, convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA, 12, convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName, 100, convEduMSTRGiftedClsCaseRelaInfo.MajorName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource, 8, convEduMSTRGiftedClsCaseRelaInfo.IdResource);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName, 100, convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource, 8, convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile, 8, convEduMSTRGiftedClsCaseRelaInfo.IdFile);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileName, 500, convEduMSTRGiftedClsCaseRelaInfo.FileName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileType, 30, convEduMSTRGiftedClsCaseRelaInfo.FileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate, 8, convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize, 50, convEduMSTRGiftedClsCaseRelaInfo.FileSize);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime, 6, convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID, 8, convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName, 200, convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName, 200, convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename, 200, convEduMSTRGiftedClsCaseRelaInfo.FileRename);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate, 8, convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime, 6, convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType, 4, convEduMSTRGiftedClsCaseRelaInfo.IdResourceType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID, 4, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName, 50, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner, 50, convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType, 30, convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize, 50, convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner, 50, convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName, 500, convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName, 530, convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName, 530, convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, 4, convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, 50, convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.Flag, 50, convEduMSTRGiftedClsCaseRelaInfo.Flag);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate, 20, convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser, 20, convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseRelaInfoEN.Memo, 1000, convEduMSTRGiftedClsCaseRelaInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleId, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FuncModuleName, convEduMSTRGiftedClsCaseRelaInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroteachCase, convEduMSTRGiftedClsCaseRelaInfo.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdEduMSTRGiftedClsCase, convEduMSTRGiftedClsCaseRelaInfo.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.EduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCaseRelaInfo.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdXzCollege, convEduMSTRGiftedClsCaseRelaInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeID, convEduMSTRGiftedClsCaseRelaInfo.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeName, convEduMSTRGiftedClsCaseRelaInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.CollegeNameA, convEduMSTRGiftedClsCaseRelaInfo.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.MajorName, convEduMSTRGiftedClsCaseRelaInfo.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdResource, convEduMSTRGiftedClsCaseRelaInfo.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceID, convEduMSTRGiftedClsCaseRelaInfo.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceName, convEduMSTRGiftedClsCaseRelaInfo.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdFtpResource, convEduMSTRGiftedClsCaseRelaInfo.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdFile, convEduMSTRGiftedClsCaseRelaInfo.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileName, convEduMSTRGiftedClsCaseRelaInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileType, convEduMSTRGiftedClsCaseRelaInfo.FileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.SaveDate, convEduMSTRGiftedClsCaseRelaInfo.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileSize, convEduMSTRGiftedClsCaseRelaInfo.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.SaveTime, convEduMSTRGiftedClsCaseRelaInfo.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FtpResourceID, convEduMSTRGiftedClsCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginalName, convEduMSTRGiftedClsCaseRelaInfo.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileDirName, convEduMSTRGiftedClsCaseRelaInfo.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileRename, convEduMSTRGiftedClsCaseRelaInfo.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpDate, convEduMSTRGiftedClsCaseRelaInfo.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileUpTime, convEduMSTRGiftedClsCaseRelaInfo.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdResourceType, convEduMSTRGiftedClsCaseRelaInfo.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeID, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceTypeName, convEduMSTRGiftedClsCaseRelaInfo.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ResourceOwner, convEduMSTRGiftedClsCaseRelaInfo.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileType, convEduMSTRGiftedClsCaseRelaInfo.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpFileSize, convEduMSTRGiftedClsCaseRelaInfo.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.ftpResourceOwner, convEduMSTRGiftedClsCaseRelaInfo.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOriginName, convEduMSTRGiftedClsCaseRelaInfo.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileNewName, convEduMSTRGiftedClsCaseRelaInfo.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.FileOldName, convEduMSTRGiftedClsCaseRelaInfo.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.IdMicroTeachCaseRelaInfoType, convEduMSTRGiftedClsCaseRelaInfo.IdMicroTeachCaseRelaInfoType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName, convEduMSTRGiftedClsCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.Flag, convEduMSTRGiftedClsCaseRelaInfo.Flag);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.UpdDate, convEduMSTRGiftedClsCaseRelaInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.UpdUser, convEduMSTRGiftedClsCaseRelaInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseRelaInfoEN.Memo, convEduMSTRGiftedClsCaseRelaInfo.Memo);
//检查外键字段长度
 objvEduMSTRGiftedClsCaseRelaInfoEN._IsCheckProperty = true;
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName);
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseRelaInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvEduMSTRGiftedClsCaseRelaInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}