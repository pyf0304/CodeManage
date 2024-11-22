
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCase_Resource_RelDA
 表名:vEduMSTRGiftedClsCase_Resource_Rel(01120431)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:28
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
 /// v教育硕士优课案例与资源关系(vEduMSTRGiftedClsCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEduMSTRGiftedClsCase_Resource_RelDA : clsCommBase4DA
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
 return clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEduMSTRGiftedClsCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable_vEduMSTRGiftedClsCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase_Resource_Rel.* from vEduMSTRGiftedClsCase_Resource_Rel Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCase_Resource_Rel.* from vEduMSTRGiftedClsCase_Resource_Rel Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN();
try
{
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCase_Resource_RelEN);
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
public List<clsvEduMSTRGiftedClsCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEduMSTRGiftedClsCase_Resource_RelEN> arrObjLst = new List<clsvEduMSTRGiftedClsCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN();
try
{
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEduMSTRGiftedClsCase_Resource_Rel(ref clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objDT.Rows[0][convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetvEduMSTRGiftedClsCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN();
try
{
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvEduMSTRGiftedClsCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEduMSTRGiftedClsCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(), //教育硕士优课案例主题词
EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(), //教育硕士优课案例日期
EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(), //教育硕士优课案例时间
EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(), //案例入库时间
IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(), //教育硕士优课案例类型流水号
EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(), //教育硕士优课案例类型名称
IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(), //教育硕士优课案例文本
OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(), //姓名
StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(), //学号
SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(), //性别名称
StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(), //学生类别ID
StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(), //学生类别名称
IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(), //年级名称
StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(), //学生证号
EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(), //入校日期
IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim() //备注
};
objvEduMSTRGiftedClsCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN();
try
{
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetObjByDataRowvEduMSTRGiftedClsCase_Resource_Rel)", objException.Message));
}
objvEduMSTRGiftedClsCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN = new clsvEduMSTRGiftedClsCase_Resource_RelEN();
try
{
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme].ToString().Trim(); //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime].ToString().Trim(); //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn].ToString().Trim(); //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn].ToString().Trim(); //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType].ToString().Trim(); //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType].ToString().Trim(); //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelEN.VersionNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod = objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText].ToString().Trim(); //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelEN.StuName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.StuID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SexDesc].ToString().Trim(); //性别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID].ToString().Trim(); //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc].ToString().Trim(); //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA = objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.MajorName].ToString().Trim(); //专业名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName].ToString().Trim(); //年级名称
objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo].ToString().Trim(); //学生证号
objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate].ToString().Trim(); //入校日期
objvEduMSTRGiftedClsCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount4Case = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.FileName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvEduMSTRGiftedClsCase_Resource_RelEN.FileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvEduMSTRGiftedClsCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner = objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName = objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvEduMSTRGiftedClsCase_Resource_RelEN.IndexNO = objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvEduMSTRGiftedClsCase_Resource_RelEN.BrowseCount = objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser = objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCase_Resource_RelEN.Memo = objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCase_Resource_Rel.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvEduMSTRGiftedClsCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCase_Resource_RelEN;
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
objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName, convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName, convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vEduMSTRGiftedClsCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCase_Resource_Rel", strCondition))
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
objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEduMSTRGiftedClsCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelENS, clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelENT)
{
objvEduMSTRGiftedClsCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvEduMSTRGiftedClsCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.FuncModuleId = objvEduMSTRGiftedClsCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCase_Resource_RelENT.FuncModuleName = objvEduMSTRGiftedClsCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdMicroteachCase = objvEduMSTRGiftedClsCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCase_Resource_RelENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTheme = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTheme; //教育硕士优课案例主题词
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTime = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTime; //教育硕士优课案例时间
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseDateIn = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseDateIn; //案例入库日期
objvEduMSTRGiftedClsCase_Resource_RelENT.IdStudyLevel = objvEduMSTRGiftedClsCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvEduMSTRGiftedClsCase_Resource_RelENT.StudyLevelName = objvEduMSTRGiftedClsCase_Resource_RelENS.StudyLevelName; //学段名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdTeachingPlan = objvEduMSTRGiftedClsCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTimeIn = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTimeIn; //案例入库时间
objvEduMSTRGiftedClsCase_Resource_RelENT.IdEduMSTRGiftedClsCaseType = objvEduMSTRGiftedClsCase_Resource_RelENS.IdEduMSTRGiftedClsCaseType; //教育硕士优课案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdCaseType = objvEduMSTRGiftedClsCase_Resource_RelENS.IdCaseType; //案例类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.IdDiscipline = objvEduMSTRGiftedClsCase_Resource_RelENS.IdDiscipline; //学科流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.DisciplineID = objvEduMSTRGiftedClsCase_Resource_RelENS.DisciplineID; //学科ID
objvEduMSTRGiftedClsCase_Resource_RelENT.DisciplineName = objvEduMSTRGiftedClsCase_Resource_RelENS.DisciplineName; //学科名称
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionID = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionName = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCase_Resource_RelENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCase_Resource_RelENT.VersionNo = objvEduMSTRGiftedClsCase_Resource_RelENS.VersionNo; //版本号
objvEduMSTRGiftedClsCase_Resource_RelENT.IdTeachSkill = objvEduMSTRGiftedClsCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillID = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvEduMSTRGiftedClsCase_Resource_RelENT.SkillTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillName = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillTheory = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvEduMSTRGiftedClsCase_Resource_RelENT.TeachSkillOperMethod = objvEduMSTRGiftedClsCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvEduMSTRGiftedClsCase_Resource_RelENT.IdSkillType = objvEduMSTRGiftedClsCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.SkillTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvEduMSTRGiftedClsCase_Resource_RelENT.CaseLevelId = objvEduMSTRGiftedClsCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvEduMSTRGiftedClsCase_Resource_RelENT.EduMSTRGiftedClsCaseText = objvEduMSTRGiftedClsCase_Resource_RelENS.EduMSTRGiftedClsCaseText; //教育硕士优课案例文本
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerId = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCase_Resource_RelENT.StuName = objvEduMSTRGiftedClsCase_Resource_RelENS.StuName; //姓名
objvEduMSTRGiftedClsCase_Resource_RelENT.StuID = objvEduMSTRGiftedClsCase_Resource_RelENS.StuID; //学号
objvEduMSTRGiftedClsCase_Resource_RelENT.SexDesc = objvEduMSTRGiftedClsCase_Resource_RelENS.SexDesc; //性别名称
objvEduMSTRGiftedClsCase_Resource_RelENT.StuTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.StuTypeID; //学生类别ID
objvEduMSTRGiftedClsCase_Resource_RelENT.StuTypeDesc = objvEduMSTRGiftedClsCase_Resource_RelENS.StuTypeDesc; //学生类别名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdXzCollege = objvEduMSTRGiftedClsCase_Resource_RelENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.CollegeName = objvEduMSTRGiftedClsCase_Resource_RelENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCase_Resource_RelENT.CollegeNameA = objvEduMSTRGiftedClsCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCase_Resource_RelENT.IdXzMajor = objvEduMSTRGiftedClsCase_Resource_RelENS.IdXzMajor; //专业流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.MajorName = objvEduMSTRGiftedClsCase_Resource_RelENS.MajorName; //专业名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdGradeBase = objvEduMSTRGiftedClsCase_Resource_RelENS.IdGradeBase; //年级流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.GradeBaseName = objvEduMSTRGiftedClsCase_Resource_RelENS.GradeBaseName; //年级名称
objvEduMSTRGiftedClsCase_Resource_RelENT.StuCardNo = objvEduMSTRGiftedClsCase_Resource_RelENS.StuCardNo; //学生证号
objvEduMSTRGiftedClsCase_Resource_RelENT.EnrollmentDate = objvEduMSTRGiftedClsCase_Resource_RelENS.EnrollmentDate; //入校日期
objvEduMSTRGiftedClsCase_Resource_RelENT.IsDualVideo = objvEduMSTRGiftedClsCase_Resource_RelENS.IsDualVideo; //是否双视频
objvEduMSTRGiftedClsCase_Resource_RelENT.UserTypeId = objvEduMSTRGiftedClsCase_Resource_RelENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCase_Resource_RelENT.RecommendedDegreeId = objvEduMSTRGiftedClsCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvEduMSTRGiftedClsCase_Resource_RelENT.RecommendedDegreeName = objvEduMSTRGiftedClsCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerName = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCase_Resource_RelENT.OwnerNameWithId = objvEduMSTRGiftedClsCase_Resource_RelENS.OwnerNameWithId; //拥有者名称附Id
objvEduMSTRGiftedClsCase_Resource_RelENT.BrowseCount4Case = objvEduMSTRGiftedClsCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvEduMSTRGiftedClsCase_Resource_RelENT.IdResource = objvEduMSTRGiftedClsCase_Resource_RelENS.IdResource; //资源流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceID = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceID; //资源ID
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceName = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceName; //资源名称
objvEduMSTRGiftedClsCase_Resource_RelENT.IdFtpResource = objvEduMSTRGiftedClsCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.IdFile = objvEduMSTRGiftedClsCase_Resource_RelENS.IdFile; //文件流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.FileName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileName; //文件名称
objvEduMSTRGiftedClsCase_Resource_RelENT.FileType = objvEduMSTRGiftedClsCase_Resource_RelENS.FileType; //文件类型
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveDate = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveDate; //创建日期
objvEduMSTRGiftedClsCase_Resource_RelENT.FileSize = objvEduMSTRGiftedClsCase_Resource_RelENS.FileSize; //文件大小
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveTime = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveTime; //创建时间
objvEduMSTRGiftedClsCase_Resource_RelENT.FtpResourceID = objvEduMSTRGiftedClsCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOriginalName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOriginalName; //文件原名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileDirName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileDirName; //文件目录名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileRename = objvEduMSTRGiftedClsCase_Resource_RelENS.FileRename; //文件新名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileUpDate = objvEduMSTRGiftedClsCase_Resource_RelENS.FileUpDate; //创建日期
objvEduMSTRGiftedClsCase_Resource_RelENT.FileUpTime = objvEduMSTRGiftedClsCase_Resource_RelENS.FileUpTime; //创建时间
objvEduMSTRGiftedClsCase_Resource_RelENT.SaveMode = objvEduMSTRGiftedClsCase_Resource_RelENS.SaveMode; //文件存放方式
objvEduMSTRGiftedClsCase_Resource_RelENT.IdResourceType = objvEduMSTRGiftedClsCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceTypeID = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceTypeName = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvEduMSTRGiftedClsCase_Resource_RelENT.ResourceOwner = objvEduMSTRGiftedClsCase_Resource_RelENS.ResourceOwner; //上传者
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpFileType = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpFileSize = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvEduMSTRGiftedClsCase_Resource_RelENT.ftpResourceOwner = objvEduMSTRGiftedClsCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOriginName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOriginName; //原文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.IsExistFile = objvEduMSTRGiftedClsCase_Resource_RelENS.IsExistFile; //是否存在文件
objvEduMSTRGiftedClsCase_Resource_RelENT.FileNewName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileNewName; //新文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.FileOldName = objvEduMSTRGiftedClsCase_Resource_RelENS.FileOldName; //旧文件名
objvEduMSTRGiftedClsCase_Resource_RelENT.IsMain = objvEduMSTRGiftedClsCase_Resource_RelENS.IsMain; //是否主资源
objvEduMSTRGiftedClsCase_Resource_RelENT.IdUsingMode = objvEduMSTRGiftedClsCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvEduMSTRGiftedClsCase_Resource_RelENT.IsVisible = objvEduMSTRGiftedClsCase_Resource_RelENS.IsVisible; //是否显示
objvEduMSTRGiftedClsCase_Resource_RelENT.IndexNO = objvEduMSTRGiftedClsCase_Resource_RelENS.IndexNO; //序号
objvEduMSTRGiftedClsCase_Resource_RelENT.BrowseCount = objvEduMSTRGiftedClsCase_Resource_RelENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCase_Resource_RelENT.UpdDate = objvEduMSTRGiftedClsCase_Resource_RelENS.UpdDate; //修改日期
objvEduMSTRGiftedClsCase_Resource_RelENT.UpdUser = objvEduMSTRGiftedClsCase_Resource_RelENS.UpdUser; //修改人
objvEduMSTRGiftedClsCase_Resource_RelENT.Memo = objvEduMSTRGiftedClsCase_Resource_RelENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEduMSTRGiftedClsCase_Resource_RelEN objvEduMSTRGiftedClsCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId, 4, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName, 30, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme, 200, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn, 8, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName, 50, convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn, 6, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID, 4, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName, 50, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID, 4, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName, 200, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID, 8, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName, 50, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory, 8000, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod, 2000, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId, 2, convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText, 8000, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId, 20, convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StuName, 50, convEduMSTRGiftedClsCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StuID, 20, convEduMSTRGiftedClsCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc, 10, convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc, 50, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName, 100, convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA, 12, convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName, 100, convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName, 50, convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo, 20, convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId, 2, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName, 30, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName, 30, convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId, 51, convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName, 100, convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile, 8, convEduMSTRGiftedClsCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileName, 500, convEduMSTRGiftedClsCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileType, 30, convEduMSTRGiftedClsCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize, 50, convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID, 8, convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename, 200, convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate, 8, convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime, 6, convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID, 4, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName, 50, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner, 50, convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType, 30, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize, 50, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner, 50, convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName, 500, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName, 530, convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName, 530, convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode, 4, convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate, 20, convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser, 20, convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCase_Resource_RelEN.Memo, 1000, convEduMSTRGiftedClsCase_Resource_Rel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleId, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FuncModuleName, convEduMSTRGiftedClsCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdMicroteachCase, convEduMSTRGiftedClsCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCase, convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTheme, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDate, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTime, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseDateIn, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdStudyLevel, convEduMSTRGiftedClsCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StudyLevelName, convEduMSTRGiftedClsCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachingPlan, convEduMSTRGiftedClsCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTimeIn, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdEduMSTRGiftedClsCaseType, convEduMSTRGiftedClsCase_Resource_Rel.IdEduMSTRGiftedClsCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseTypeName, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdCaseType, convEduMSTRGiftedClsCase_Resource_Rel.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdDiscipline, convEduMSTRGiftedClsCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineID, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.DisciplineName, convEduMSTRGiftedClsCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionID, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.senateGaugeVersionName, convEduMSTRGiftedClsCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdTeachSkill, convEduMSTRGiftedClsCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillID, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeName, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillName, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillTheory, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.TeachSkillOperMethod, convEduMSTRGiftedClsCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdSkillType, convEduMSTRGiftedClsCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.SkillTypeID, convEduMSTRGiftedClsCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.CaseLevelId, convEduMSTRGiftedClsCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EduMSTRGiftedClsCaseText, convEduMSTRGiftedClsCase_Resource_Rel.EduMSTRGiftedClsCaseText);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerId, convEduMSTRGiftedClsCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StuName, convEduMSTRGiftedClsCase_Resource_Rel.StuName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StuID, convEduMSTRGiftedClsCase_Resource_Rel.StuID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.SexDesc, convEduMSTRGiftedClsCase_Resource_Rel.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeID, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StuTypeDesc, convEduMSTRGiftedClsCase_Resource_Rel.StuTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzCollege, convEduMSTRGiftedClsCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeName, convEduMSTRGiftedClsCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.CollegeNameA, convEduMSTRGiftedClsCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdXzMajor, convEduMSTRGiftedClsCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.MajorName, convEduMSTRGiftedClsCase_Resource_Rel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdGradeBase, convEduMSTRGiftedClsCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.GradeBaseName, convEduMSTRGiftedClsCase_Resource_Rel.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.StuCardNo, convEduMSTRGiftedClsCase_Resource_Rel.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.EnrollmentDate, convEduMSTRGiftedClsCase_Resource_Rel.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.UserTypeId, convEduMSTRGiftedClsCase_Resource_Rel.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeId, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.RecommendedDegreeName, convEduMSTRGiftedClsCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerName, convEduMSTRGiftedClsCase_Resource_Rel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.OwnerNameWithId, convEduMSTRGiftedClsCase_Resource_Rel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdResource, convEduMSTRGiftedClsCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceID, convEduMSTRGiftedClsCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceName, convEduMSTRGiftedClsCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdFtpResource, convEduMSTRGiftedClsCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdFile, convEduMSTRGiftedClsCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileName, convEduMSTRGiftedClsCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileType, convEduMSTRGiftedClsCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.SaveDate, convEduMSTRGiftedClsCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileSize, convEduMSTRGiftedClsCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.SaveTime, convEduMSTRGiftedClsCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FtpResourceID, convEduMSTRGiftedClsCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginalName, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileDirName, convEduMSTRGiftedClsCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileRename, convEduMSTRGiftedClsCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpDate, convEduMSTRGiftedClsCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileUpTime, convEduMSTRGiftedClsCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdResourceType, convEduMSTRGiftedClsCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeID, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceTypeName, convEduMSTRGiftedClsCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ResourceOwner, convEduMSTRGiftedClsCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileType, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpFileSize, convEduMSTRGiftedClsCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.ftpResourceOwner, convEduMSTRGiftedClsCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOriginName, convEduMSTRGiftedClsCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileNewName, convEduMSTRGiftedClsCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.FileOldName, convEduMSTRGiftedClsCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.IdUsingMode, convEduMSTRGiftedClsCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.UpdDate, convEduMSTRGiftedClsCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.UpdUser, convEduMSTRGiftedClsCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCase_Resource_RelEN.Memo, convEduMSTRGiftedClsCase_Resource_Rel.Memo);
//检查外键字段长度
 objvEduMSTRGiftedClsCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvEduMSTRGiftedClsCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}