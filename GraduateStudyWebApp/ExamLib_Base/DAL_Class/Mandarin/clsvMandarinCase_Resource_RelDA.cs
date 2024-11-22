
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMandarinCase_Resource_RelDA
 表名:vMandarinCase_Resource_Rel(01120430)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:普通话点播(Mandarin)
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
 /// vMandarinCase_Resource_Rel(vMandarinCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMandarinCase_Resource_RelDA : clsCommBase4DA
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
 return clsvMandarinCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMandarinCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMandarinCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMandarinCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMandarinCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMandarinCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable_vMandarinCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCase_Resource_Rel.* from vMandarinCase_Resource_Rel Left Join {1} on {2} where {3} and vMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMandarinCase_Resource_Rel.* from vMandarinCase_Resource_Rel Left Join {1} on {2} where {3} and vMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel not in (Select top {5} vMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {2} IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMandarinCase_Resource_Rel where {1} and IdMicroteachCaseResourceRel not in (Select top {3} IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMandarinCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvMandarinCase_Resource_RelEN> arrObjLst = new List<clsvMandarinCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN();
try
{
objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMandarinCase_Resource_RelEN.FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCase_Resource_RelEN.FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCase_Resource_RelEN.IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCase_Resource_RelEN.UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMandarinCase_Resource_RelEN.UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMandarinCase_Resource_RelEN.IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMandarinCase_Resource_RelEN.ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMandarinCase_Resource_RelEN.IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCase_Resource_RelEN.IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMandarinCase_Resource_RelEN.FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMandarinCase_Resource_RelEN.FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMandarinCase_Resource_RelEN.SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMandarinCase_Resource_RelEN.SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCase_Resource_RelEN.FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCase_Resource_RelEN.FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCase_Resource_RelEN.FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMandarinCase_Resource_RelEN.FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCase_Resource_RelEN.IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCase_Resource_RelEN.ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCase_Resource_RelEN.ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCase_Resource_RelEN.ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCase_Resource_RelEN.ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCase_Resource_RelEN.ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCase_Resource_RelEN.ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCase_Resource_RelEN.FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCase_Resource_RelEN.FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMandarinCase_Resource_RelEN.FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCase_Resource_RelEN.IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMandarinCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMandarinCase_Resource_RelEN.IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMandarinCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMandarinCase_Resource_RelEN.BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCase_Resource_RelEN.Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvMandarinCase_Resource_RelEN.IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCase_Resource_RelEN.MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCase_Resource_RelEN.MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCase_Resource_RelEN.IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCase_Resource_RelEN.DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCase_Resource_RelEN.DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCase_Resource_RelEN.IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCase_Resource_RelEN.StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCase_Resource_RelEN.MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCase_Resource_RelEN.MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCase_Resource_RelEN.IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCase_Resource_RelEN.VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMandarinCase_Resource_RelEN.CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCase_Resource_RelEN.OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCase_Resource_RelEN.StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMandarinCase_Resource_RelEN.StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMandarinCase_Resource_RelEN.CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMandarinCase_Resource_RelEN.IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCase_Resource_RelEN.CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCase_Resource_RelEN.IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCase_Resource_RelEN.IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCase_Resource_RelEN.IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCase_Resource_RelEN.BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvMandarinCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCase_Resource_RelEN);
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
public List<clsvMandarinCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMandarinCase_Resource_RelEN> arrObjLst = new List<clsvMandarinCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN();
try
{
objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMandarinCase_Resource_RelEN.FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCase_Resource_RelEN.FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCase_Resource_RelEN.IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCase_Resource_RelEN.UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMandarinCase_Resource_RelEN.UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMandarinCase_Resource_RelEN.IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMandarinCase_Resource_RelEN.ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMandarinCase_Resource_RelEN.IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCase_Resource_RelEN.IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMandarinCase_Resource_RelEN.FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMandarinCase_Resource_RelEN.FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMandarinCase_Resource_RelEN.SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMandarinCase_Resource_RelEN.SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCase_Resource_RelEN.FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCase_Resource_RelEN.FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCase_Resource_RelEN.FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMandarinCase_Resource_RelEN.FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCase_Resource_RelEN.IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCase_Resource_RelEN.ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCase_Resource_RelEN.ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCase_Resource_RelEN.ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCase_Resource_RelEN.ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCase_Resource_RelEN.ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCase_Resource_RelEN.ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCase_Resource_RelEN.FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCase_Resource_RelEN.FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMandarinCase_Resource_RelEN.FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCase_Resource_RelEN.IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMandarinCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMandarinCase_Resource_RelEN.IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMandarinCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMandarinCase_Resource_RelEN.BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCase_Resource_RelEN.Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvMandarinCase_Resource_RelEN.IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCase_Resource_RelEN.MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCase_Resource_RelEN.MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCase_Resource_RelEN.IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCase_Resource_RelEN.DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCase_Resource_RelEN.DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCase_Resource_RelEN.IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCase_Resource_RelEN.StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCase_Resource_RelEN.MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCase_Resource_RelEN.MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCase_Resource_RelEN.IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCase_Resource_RelEN.VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMandarinCase_Resource_RelEN.CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCase_Resource_RelEN.OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCase_Resource_RelEN.StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMandarinCase_Resource_RelEN.StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMandarinCase_Resource_RelEN.CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMandarinCase_Resource_RelEN.IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCase_Resource_RelEN.CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCase_Resource_RelEN.IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCase_Resource_RelEN.IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCase_Resource_RelEN.IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCase_Resource_RelEN.BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvMandarinCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMandarinCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMandarinCase_Resource_Rel(ref clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.FuncModuleName = objDT.Rows[0][convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCase_Resource_RelEN.FuncModuleId = objDT.Rows[0][convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdMicroteachCase = objDT.Rows[0][convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.UpdDate = objDT.Rows[0][convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.UpdUser = objDT.Rows[0][convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdResource = objDT.Rows[0][convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceID = objDT.Rows[0][convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdFile = objDT.Rows[0][convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileType = objDT.Rows[0][convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveDate = objDT.Rows[0][convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileSize = objDT.Rows[0][convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveTime = objDT.Rows[0][convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileDirName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileRename = objDT.Rows[0][convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileNewName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileOldName = objDT.Rows[0][convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdUsingMode = objDT.Rows[0][convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.Memo = objDT.Rows[0][convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdMandarinCase = objDT.Rows[0][convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseID = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseName = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.DisciplineID = objDT.Rows[0][convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseDate = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseTime = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objDT.Rows[0][convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objDT.Rows[0][convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objDT.Rows[0][convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.VersionNo = TransNullToInt(objDT.Rows[0][convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.CaseLevelId = objDT.Rows[0][convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCase_Resource_RelEN.OwnerId = objDT.Rows[0][convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCase_Resource_RelEN.StuName = objDT.Rows[0][convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.StuID = objDT.Rows[0][convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.CollegeName = objDT.Rows[0][convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdXzMajor = objDT.Rows[0][convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdGradeBase = objDT.Rows[0][convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdAdminCls = objDT.Rows[0][convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetvMandarinCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdMicroteachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvMandarinCase_Resource_RelEN GetObjByIdMicroteachCaseResourceRel(long lngIdMicroteachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN();
try
{
 objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = Int32.Parse(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCase_Resource_RelEN.FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvMandarinCase_Resource_RelEN.ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCase_Resource_RelEN.FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvMandarinCase_Resource_RelEN.BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMandarinCase_Resource_RelEN.OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMandarinCase_Resource_RelEN.StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvMandarinCase_Resource_RelEN.StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvMandarinCase_Resource_RelEN.CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMandarinCase_Resource_RelEN.IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMandarinCase_Resource_RelEN.IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvMandarinCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMandarinCase_Resource_RelEN.BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetObjByIdMicroteachCaseResourceRel)", objException.Message));
}
return objvMandarinCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMandarinCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vMandarinCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN()
{
IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(), //功能模块Id
IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(), //修改人
IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(), //资源使用模式流水号
IsVisible = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
IsMain = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(), //备注
IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(), //普通话案例流水号
MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(), //普通话教学案例ID
MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(), //普通话教学案例名称
IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(), //普通话教学案例主题词
MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(), //普通话教学日期
MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(), //普通话教学时间
MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(), //案例入库日期
MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(), //案例入库时间
IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()), //版本号
CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(), //课例等级Id
OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(), //姓名
StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(), //学号
CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(), //专业流水号
IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(), //年级流水号
IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(), //行政班流水号
IsDualVideo = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvMandarinCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMandarinCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN();
try
{
objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMandarinCase_Resource_RelEN.FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCase_Resource_RelEN.FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCase_Resource_RelEN.IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCase_Resource_RelEN.UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMandarinCase_Resource_RelEN.UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMandarinCase_Resource_RelEN.IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMandarinCase_Resource_RelEN.ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMandarinCase_Resource_RelEN.IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCase_Resource_RelEN.IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMandarinCase_Resource_RelEN.FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMandarinCase_Resource_RelEN.FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMandarinCase_Resource_RelEN.SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMandarinCase_Resource_RelEN.SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCase_Resource_RelEN.FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCase_Resource_RelEN.FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCase_Resource_RelEN.FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMandarinCase_Resource_RelEN.FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCase_Resource_RelEN.IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCase_Resource_RelEN.ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCase_Resource_RelEN.ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCase_Resource_RelEN.ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCase_Resource_RelEN.ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCase_Resource_RelEN.ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCase_Resource_RelEN.ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCase_Resource_RelEN.FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCase_Resource_RelEN.FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMandarinCase_Resource_RelEN.FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCase_Resource_RelEN.IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMandarinCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMandarinCase_Resource_RelEN.IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMandarinCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMandarinCase_Resource_RelEN.BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCase_Resource_RelEN.Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvMandarinCase_Resource_RelEN.IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCase_Resource_RelEN.MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCase_Resource_RelEN.MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCase_Resource_RelEN.IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCase_Resource_RelEN.DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCase_Resource_RelEN.DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCase_Resource_RelEN.IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCase_Resource_RelEN.StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCase_Resource_RelEN.MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCase_Resource_RelEN.MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCase_Resource_RelEN.IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCase_Resource_RelEN.VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMandarinCase_Resource_RelEN.CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCase_Resource_RelEN.OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCase_Resource_RelEN.StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMandarinCase_Resource_RelEN.StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMandarinCase_Resource_RelEN.CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMandarinCase_Resource_RelEN.IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCase_Resource_RelEN.CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCase_Resource_RelEN.IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCase_Resource_RelEN.IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCase_Resource_RelEN.IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCase_Resource_RelEN.BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetObjByDataRowvMandarinCase_Resource_Rel)", objException.Message));
}
objvMandarinCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMandarinCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN = new clsvMandarinCase_Resource_RelEN();
try
{
objvMandarinCase_Resource_RelEN.IdMicroteachCaseResourceRel = TransNullToInt(objRow[convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvMandarinCase_Resource_RelEN.FuncModuleName = objRow[convMandarinCase_Resource_Rel.FuncModuleName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FuncModuleName].ToString().Trim(); //功能模块名称
objvMandarinCase_Resource_RelEN.FuncModuleId = objRow[convMandarinCase_Resource_Rel.FuncModuleId].ToString().Trim(); //功能模块Id
objvMandarinCase_Resource_RelEN.IdMicroteachCase = objRow[convMandarinCase_Resource_Rel.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMandarinCase_Resource_RelEN.UpdDate = objRow[convMandarinCase_Resource_Rel.UpdDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdDate].ToString().Trim(); //修改日期
objvMandarinCase_Resource_RelEN.UpdUser = objRow[convMandarinCase_Resource_Rel.UpdUser] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.UpdUser].ToString().Trim(); //修改人
objvMandarinCase_Resource_RelEN.IdResource = objRow[convMandarinCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvMandarinCase_Resource_RelEN.ResourceID = objRow[convMandarinCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvMandarinCase_Resource_RelEN.IdFtpResource = objRow[convMandarinCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvMandarinCase_Resource_RelEN.IdFile = objRow[convMandarinCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvMandarinCase_Resource_RelEN.FileName = objRow[convMandarinCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvMandarinCase_Resource_RelEN.FileType = objRow[convMandarinCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvMandarinCase_Resource_RelEN.SaveDate = objRow[convMandarinCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileSize = objRow[convMandarinCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvMandarinCase_Resource_RelEN.SaveTime = objRow[convMandarinCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.FtpResourceID = objRow[convMandarinCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvMandarinCase_Resource_RelEN.FileOriginalName = objRow[convMandarinCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvMandarinCase_Resource_RelEN.FileDirName = objRow[convMandarinCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvMandarinCase_Resource_RelEN.FileRename = objRow[convMandarinCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvMandarinCase_Resource_RelEN.FileUpDate = objRow[convMandarinCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvMandarinCase_Resource_RelEN.FileUpTime = objRow[convMandarinCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvMandarinCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convMandarinCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvMandarinCase_Resource_RelEN.IdResourceType = objRow[convMandarinCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvMandarinCase_Resource_RelEN.ResourceTypeID = objRow[convMandarinCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvMandarinCase_Resource_RelEN.ResourceTypeName = objRow[convMandarinCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvMandarinCase_Resource_RelEN.ResourceOwner = objRow[convMandarinCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvMandarinCase_Resource_RelEN.ftpFileType = objRow[convMandarinCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvMandarinCase_Resource_RelEN.ftpFileSize = objRow[convMandarinCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvMandarinCase_Resource_RelEN.ftpResourceOwner = objRow[convMandarinCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvMandarinCase_Resource_RelEN.FileOriginName = objRow[convMandarinCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvMandarinCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvMandarinCase_Resource_RelEN.FileNewName = objRow[convMandarinCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvMandarinCase_Resource_RelEN.FileOldName = objRow[convMandarinCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvMandarinCase_Resource_RelEN.IdUsingMode = objRow[convMandarinCase_Resource_Rel.IdUsingMode].ToString().Trim(); //资源使用模式流水号
objvMandarinCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvMandarinCase_Resource_RelEN.IndexNO = objRow[convMandarinCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvMandarinCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvMandarinCase_Resource_RelEN.BrowseCount = objRow[convMandarinCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvMandarinCase_Resource_RelEN.Memo = objRow[convMandarinCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvMandarinCase_Resource_RelEN.IdMandarinCase = objRow[convMandarinCase_Resource_Rel.IdMandarinCase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdMandarinCase].ToString().Trim(); //普通话案例流水号
objvMandarinCase_Resource_RelEN.MandarinCaseID = objRow[convMandarinCase_Resource_Rel.MandarinCaseID] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseID].ToString().Trim(); //普通话教学案例ID
objvMandarinCase_Resource_RelEN.MandarinCaseName = objRow[convMandarinCase_Resource_Rel.MandarinCaseName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseName].ToString().Trim(); //普通话教学案例名称
objvMandarinCase_Resource_RelEN.IdDiscipline = objRow[convMandarinCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvMandarinCase_Resource_RelEN.DisciplineID = objRow[convMandarinCase_Resource_Rel.DisciplineID].ToString().Trim(); //学科ID
objvMandarinCase_Resource_RelEN.DisciplineName = objRow[convMandarinCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvMandarinCase_Resource_RelEN.IdStudyLevel = objRow[convMandarinCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMandarinCase_Resource_RelEN.StudyLevelName = objRow[convMandarinCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvMandarinCase_Resource_RelEN.MandarinCaseTheme = objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTheme].ToString().Trim(); //普通话教学案例主题词
objvMandarinCase_Resource_RelEN.MandarinCaseDate = objRow[convMandarinCase_Resource_Rel.MandarinCaseDate] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDate].ToString().Trim(); //普通话教学日期
objvMandarinCase_Resource_RelEN.MandarinCaseTime = objRow[convMandarinCase_Resource_Rel.MandarinCaseTime] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTime].ToString().Trim(); //普通话教学时间
objvMandarinCase_Resource_RelEN.MandarinCaseDateIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseDateIn].ToString().Trim(); //案例入库日期
objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn = objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.MandarinCaseTimeIn].ToString().Trim(); //案例入库时间
objvMandarinCase_Resource_RelEN.IdTeachingPlan = objRow[convMandarinCase_Resource_Rel.IdTeachingPlan] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMandarinCase_Resource_RelEN.senateGaugeVersionID = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMandarinCase_Resource_RelEN.senateGaugeVersionName = objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMandarinCase_Resource_RelEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convMandarinCase_Resource_Rel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMandarinCase_Resource_RelEN.VersionNo = objRow[convMandarinCase_Resource_Rel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.VersionNo].ToString().Trim()); //版本号
objvMandarinCase_Resource_RelEN.CaseLevelId = objRow[convMandarinCase_Resource_Rel.CaseLevelId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CaseLevelId].ToString().Trim(); //课例等级Id
objvMandarinCase_Resource_RelEN.OwnerId = objRow[convMandarinCase_Resource_Rel.OwnerId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.OwnerId].ToString().Trim(); //拥有者Id
objvMandarinCase_Resource_RelEN.StuName = objRow[convMandarinCase_Resource_Rel.StuName].ToString().Trim(); //姓名
objvMandarinCase_Resource_RelEN.StuID = objRow[convMandarinCase_Resource_Rel.StuID].ToString().Trim(); //学号
objvMandarinCase_Resource_RelEN.CollegeName = objRow[convMandarinCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvMandarinCase_Resource_RelEN.IdXzCollege = objRow[convMandarinCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvMandarinCase_Resource_RelEN.CollegeNameA = objRow[convMandarinCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
objvMandarinCase_Resource_RelEN.IdXzMajor = objRow[convMandarinCase_Resource_Rel.IdXzMajor] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdXzMajor].ToString().Trim(); //专业流水号
objvMandarinCase_Resource_RelEN.IdGradeBase = objRow[convMandarinCase_Resource_Rel.IdGradeBase] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdGradeBase].ToString().Trim(); //年级流水号
objvMandarinCase_Resource_RelEN.IdAdminCls = objRow[convMandarinCase_Resource_Rel.IdAdminCls] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.IdAdminCls].ToString().Trim(); //行政班流水号
objvMandarinCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convMandarinCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvMandarinCase_Resource_RelEN.RecommendedDegreeId = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMandarinCase_Resource_RelEN.RecommendedDegreeName = objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMandarinCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMandarinCase_Resource_RelEN.BrowseCount4Case = objRow[convMandarinCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMandarinCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMandarinCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvMandarinCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMandarinCase_Resource_RelEN;
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
objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCase_Resource_RelEN._CurrTabName, convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, "");
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
objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMandarinCase_Resource_RelEN._CurrTabName, convMandarinCase_Resource_Rel.IdMicroteachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCaseResourceRel from vMandarinCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCase_Resource_Rel", "IdMicroteachCaseResourceRel = " + ""+ lngIdMicroteachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMandarinCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMandarinCase_Resource_Rel", strCondition))
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
objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMandarinCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMandarinCase_Resource_RelENS">源对象</param>
 /// <param name = "objvMandarinCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelENS, clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelENT)
{
objvMandarinCase_Resource_RelENT.IdMicroteachCaseResourceRel = objvMandarinCase_Resource_RelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvMandarinCase_Resource_RelENT.FuncModuleName = objvMandarinCase_Resource_RelENS.FuncModuleName; //功能模块名称
objvMandarinCase_Resource_RelENT.FuncModuleId = objvMandarinCase_Resource_RelENS.FuncModuleId; //功能模块Id
objvMandarinCase_Resource_RelENT.IdMicroteachCase = objvMandarinCase_Resource_RelENS.IdMicroteachCase; //微格教学案例流水号
objvMandarinCase_Resource_RelENT.UpdDate = objvMandarinCase_Resource_RelENS.UpdDate; //修改日期
objvMandarinCase_Resource_RelENT.UpdUser = objvMandarinCase_Resource_RelENS.UpdUser; //修改人
objvMandarinCase_Resource_RelENT.IdResource = objvMandarinCase_Resource_RelENS.IdResource; //资源流水号
objvMandarinCase_Resource_RelENT.ResourceID = objvMandarinCase_Resource_RelENS.ResourceID; //资源ID
objvMandarinCase_Resource_RelENT.IdFtpResource = objvMandarinCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvMandarinCase_Resource_RelENT.IdFile = objvMandarinCase_Resource_RelENS.IdFile; //文件流水号
objvMandarinCase_Resource_RelENT.FileName = objvMandarinCase_Resource_RelENS.FileName; //文件名称
objvMandarinCase_Resource_RelENT.FileType = objvMandarinCase_Resource_RelENS.FileType; //文件类型
objvMandarinCase_Resource_RelENT.SaveDate = objvMandarinCase_Resource_RelENS.SaveDate; //创建日期
objvMandarinCase_Resource_RelENT.FileSize = objvMandarinCase_Resource_RelENS.FileSize; //文件大小
objvMandarinCase_Resource_RelENT.SaveTime = objvMandarinCase_Resource_RelENS.SaveTime; //创建时间
objvMandarinCase_Resource_RelENT.FtpResourceID = objvMandarinCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvMandarinCase_Resource_RelENT.FileOriginalName = objvMandarinCase_Resource_RelENS.FileOriginalName; //文件原名
objvMandarinCase_Resource_RelENT.FileDirName = objvMandarinCase_Resource_RelENS.FileDirName; //文件目录名
objvMandarinCase_Resource_RelENT.FileRename = objvMandarinCase_Resource_RelENS.FileRename; //文件新名
objvMandarinCase_Resource_RelENT.FileUpDate = objvMandarinCase_Resource_RelENS.FileUpDate; //创建日期
objvMandarinCase_Resource_RelENT.FileUpTime = objvMandarinCase_Resource_RelENS.FileUpTime; //创建时间
objvMandarinCase_Resource_RelENT.SaveMode = objvMandarinCase_Resource_RelENS.SaveMode; //文件存放方式
objvMandarinCase_Resource_RelENT.IdResourceType = objvMandarinCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvMandarinCase_Resource_RelENT.ResourceTypeID = objvMandarinCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvMandarinCase_Resource_RelENT.ResourceTypeName = objvMandarinCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvMandarinCase_Resource_RelENT.ResourceOwner = objvMandarinCase_Resource_RelENS.ResourceOwner; //上传者
objvMandarinCase_Resource_RelENT.ftpFileType = objvMandarinCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvMandarinCase_Resource_RelENT.ftpFileSize = objvMandarinCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvMandarinCase_Resource_RelENT.ftpResourceOwner = objvMandarinCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvMandarinCase_Resource_RelENT.FileOriginName = objvMandarinCase_Resource_RelENS.FileOriginName; //原文件名
objvMandarinCase_Resource_RelENT.IsExistFile = objvMandarinCase_Resource_RelENS.IsExistFile; //是否存在文件
objvMandarinCase_Resource_RelENT.FileNewName = objvMandarinCase_Resource_RelENS.FileNewName; //新文件名
objvMandarinCase_Resource_RelENT.FileOldName = objvMandarinCase_Resource_RelENS.FileOldName; //旧文件名
objvMandarinCase_Resource_RelENT.IdUsingMode = objvMandarinCase_Resource_RelENS.IdUsingMode; //资源使用模式流水号
objvMandarinCase_Resource_RelENT.IsVisible = objvMandarinCase_Resource_RelENS.IsVisible; //是否显示
objvMandarinCase_Resource_RelENT.IndexNO = objvMandarinCase_Resource_RelENS.IndexNO; //序号
objvMandarinCase_Resource_RelENT.IsMain = objvMandarinCase_Resource_RelENS.IsMain; //是否主资源
objvMandarinCase_Resource_RelENT.BrowseCount = objvMandarinCase_Resource_RelENS.BrowseCount; //浏览次数
objvMandarinCase_Resource_RelENT.Memo = objvMandarinCase_Resource_RelENS.Memo; //备注
objvMandarinCase_Resource_RelENT.IdMandarinCase = objvMandarinCase_Resource_RelENS.IdMandarinCase; //普通话案例流水号
objvMandarinCase_Resource_RelENT.MandarinCaseID = objvMandarinCase_Resource_RelENS.MandarinCaseID; //普通话教学案例ID
objvMandarinCase_Resource_RelENT.MandarinCaseName = objvMandarinCase_Resource_RelENS.MandarinCaseName; //普通话教学案例名称
objvMandarinCase_Resource_RelENT.IdDiscipline = objvMandarinCase_Resource_RelENS.IdDiscipline; //学科流水号
objvMandarinCase_Resource_RelENT.DisciplineID = objvMandarinCase_Resource_RelENS.DisciplineID; //学科ID
objvMandarinCase_Resource_RelENT.DisciplineName = objvMandarinCase_Resource_RelENS.DisciplineName; //学科名称
objvMandarinCase_Resource_RelENT.IdStudyLevel = objvMandarinCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvMandarinCase_Resource_RelENT.StudyLevelName = objvMandarinCase_Resource_RelENS.StudyLevelName; //学段名称
objvMandarinCase_Resource_RelENT.MandarinCaseTheme = objvMandarinCase_Resource_RelENS.MandarinCaseTheme; //普通话教学案例主题词
objvMandarinCase_Resource_RelENT.MandarinCaseDate = objvMandarinCase_Resource_RelENS.MandarinCaseDate; //普通话教学日期
objvMandarinCase_Resource_RelENT.MandarinCaseTime = objvMandarinCase_Resource_RelENS.MandarinCaseTime; //普通话教学时间
objvMandarinCase_Resource_RelENT.MandarinCaseDateIn = objvMandarinCase_Resource_RelENS.MandarinCaseDateIn; //案例入库日期
objvMandarinCase_Resource_RelENT.MandarinCaseTimeIn = objvMandarinCase_Resource_RelENS.MandarinCaseTimeIn; //案例入库时间
objvMandarinCase_Resource_RelENT.IdTeachingPlan = objvMandarinCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvMandarinCase_Resource_RelENT.senateGaugeVersionID = objvMandarinCase_Resource_RelENS.senateGaugeVersionID; //评价量表版本ID
objvMandarinCase_Resource_RelENT.senateGaugeVersionName = objvMandarinCase_Resource_RelENS.senateGaugeVersionName; //评价量表版本名称
objvMandarinCase_Resource_RelENT.senateGaugeVersionTtlScore = objvMandarinCase_Resource_RelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMandarinCase_Resource_RelENT.VersionNo = objvMandarinCase_Resource_RelENS.VersionNo; //版本号
objvMandarinCase_Resource_RelENT.CaseLevelId = objvMandarinCase_Resource_RelENS.CaseLevelId; //课例等级Id
objvMandarinCase_Resource_RelENT.OwnerId = objvMandarinCase_Resource_RelENS.OwnerId; //拥有者Id
objvMandarinCase_Resource_RelENT.StuName = objvMandarinCase_Resource_RelENS.StuName; //姓名
objvMandarinCase_Resource_RelENT.StuID = objvMandarinCase_Resource_RelENS.StuID; //学号
objvMandarinCase_Resource_RelENT.CollegeName = objvMandarinCase_Resource_RelENS.CollegeName; //学院名称
objvMandarinCase_Resource_RelENT.IdXzCollege = objvMandarinCase_Resource_RelENS.IdXzCollege; //学院流水号
objvMandarinCase_Resource_RelENT.CollegeNameA = objvMandarinCase_Resource_RelENS.CollegeNameA; //学院名称简写
objvMandarinCase_Resource_RelENT.IdXzMajor = objvMandarinCase_Resource_RelENS.IdXzMajor; //专业流水号
objvMandarinCase_Resource_RelENT.IdGradeBase = objvMandarinCase_Resource_RelENS.IdGradeBase; //年级流水号
objvMandarinCase_Resource_RelENT.IdAdminCls = objvMandarinCase_Resource_RelENS.IdAdminCls; //行政班流水号
objvMandarinCase_Resource_RelENT.IsDualVideo = objvMandarinCase_Resource_RelENS.IsDualVideo; //是否双视频
objvMandarinCase_Resource_RelENT.RecommendedDegreeId = objvMandarinCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvMandarinCase_Resource_RelENT.RecommendedDegreeName = objvMandarinCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvMandarinCase_Resource_RelENT.BrowseCount4Case = objvMandarinCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMandarinCase_Resource_RelEN objvMandarinCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FuncModuleName, 30, convMandarinCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FuncModuleId, 4, convMandarinCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdMicroteachCase, 8, convMandarinCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.UpdDate, 20, convMandarinCase_Resource_Rel.UpdDate);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.UpdUser, 20, convMandarinCase_Resource_Rel.UpdUser);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdResource, 8, convMandarinCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ResourceID, 8, convMandarinCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdFtpResource, 8, convMandarinCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdFile, 8, convMandarinCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileName, 500, convMandarinCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileType, 30, convMandarinCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.SaveDate, 8, convMandarinCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileSize, 50, convMandarinCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.SaveTime, 6, convMandarinCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FtpResourceID, 8, convMandarinCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileOriginalName, 200, convMandarinCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileDirName, 200, convMandarinCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileRename, 200, convMandarinCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileUpDate, 8, convMandarinCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileUpTime, 6, convMandarinCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdResourceType, 4, convMandarinCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ResourceTypeID, 4, convMandarinCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ResourceTypeName, 50, convMandarinCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ResourceOwner, 50, convMandarinCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ftpFileType, 30, convMandarinCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ftpFileSize, 50, convMandarinCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.ftpResourceOwner, 50, convMandarinCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileOriginName, 500, convMandarinCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileNewName, 530, convMandarinCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.FileOldName, 530, convMandarinCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdUsingMode, 4, convMandarinCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.Memo, 1000, convMandarinCase_Resource_Rel.Memo);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdMandarinCase, 8, convMandarinCase_Resource_Rel.IdMandarinCase);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseID, 8, convMandarinCase_Resource_Rel.MandarinCaseID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseName, 100, convMandarinCase_Resource_Rel.MandarinCaseName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdDiscipline, 4, convMandarinCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.DisciplineID, 4, convMandarinCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.DisciplineName, 50, convMandarinCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdStudyLevel, 4, convMandarinCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.StudyLevelName, 50, convMandarinCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseTheme, 200, convMandarinCase_Resource_Rel.MandarinCaseTheme);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseDate, 8, convMandarinCase_Resource_Rel.MandarinCaseDate);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseTime, 6, convMandarinCase_Resource_Rel.MandarinCaseTime);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseDateIn, 8, convMandarinCase_Resource_Rel.MandarinCaseDateIn);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn, 6, convMandarinCase_Resource_Rel.MandarinCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdTeachingPlan, 8, convMandarinCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.senateGaugeVersionID, 4, convMandarinCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.senateGaugeVersionName, 200, convMandarinCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.CaseLevelId, 2, convMandarinCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.OwnerId, 20, convMandarinCase_Resource_Rel.OwnerId);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.StuName, 50, convMandarinCase_Resource_Rel.StuName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.StuID, 20, convMandarinCase_Resource_Rel.StuID);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.CollegeName, 100, convMandarinCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdXzCollege, 4, convMandarinCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.CollegeNameA, 12, convMandarinCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdXzMajor, 8, convMandarinCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdGradeBase, 4, convMandarinCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.IdAdminCls, 8, convMandarinCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.RecommendedDegreeId, 2, convMandarinCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMandarinCase_Resource_RelEN.RecommendedDegreeName, 30, convMandarinCase_Resource_Rel.RecommendedDegreeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FuncModuleName, convMandarinCase_Resource_Rel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FuncModuleId, convMandarinCase_Resource_Rel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdMicroteachCase, convMandarinCase_Resource_Rel.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.UpdDate, convMandarinCase_Resource_Rel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.UpdUser, convMandarinCase_Resource_Rel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdResource, convMandarinCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ResourceID, convMandarinCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdFtpResource, convMandarinCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdFile, convMandarinCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileName, convMandarinCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileType, convMandarinCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.SaveDate, convMandarinCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileSize, convMandarinCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.SaveTime, convMandarinCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FtpResourceID, convMandarinCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileOriginalName, convMandarinCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileDirName, convMandarinCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileRename, convMandarinCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileUpDate, convMandarinCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileUpTime, convMandarinCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdResourceType, convMandarinCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ResourceTypeID, convMandarinCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ResourceTypeName, convMandarinCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ResourceOwner, convMandarinCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ftpFileType, convMandarinCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ftpFileSize, convMandarinCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.ftpResourceOwner, convMandarinCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileOriginName, convMandarinCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileNewName, convMandarinCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.FileOldName, convMandarinCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdUsingMode, convMandarinCase_Resource_Rel.IdUsingMode);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.Memo, convMandarinCase_Resource_Rel.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdMandarinCase, convMandarinCase_Resource_Rel.IdMandarinCase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseID, convMandarinCase_Resource_Rel.MandarinCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseName, convMandarinCase_Resource_Rel.MandarinCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdDiscipline, convMandarinCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.DisciplineID, convMandarinCase_Resource_Rel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.DisciplineName, convMandarinCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdStudyLevel, convMandarinCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.StudyLevelName, convMandarinCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseTheme, convMandarinCase_Resource_Rel.MandarinCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseDate, convMandarinCase_Resource_Rel.MandarinCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseTime, convMandarinCase_Resource_Rel.MandarinCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseDateIn, convMandarinCase_Resource_Rel.MandarinCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.MandarinCaseTimeIn, convMandarinCase_Resource_Rel.MandarinCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdTeachingPlan, convMandarinCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.senateGaugeVersionID, convMandarinCase_Resource_Rel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.senateGaugeVersionName, convMandarinCase_Resource_Rel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.CaseLevelId, convMandarinCase_Resource_Rel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.OwnerId, convMandarinCase_Resource_Rel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.StuName, convMandarinCase_Resource_Rel.StuName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.StuID, convMandarinCase_Resource_Rel.StuID);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.CollegeName, convMandarinCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdXzCollege, convMandarinCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.CollegeNameA, convMandarinCase_Resource_Rel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdXzMajor, convMandarinCase_Resource_Rel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdGradeBase, convMandarinCase_Resource_Rel.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.IdAdminCls, convMandarinCase_Resource_Rel.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.RecommendedDegreeId, convMandarinCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMandarinCase_Resource_RelEN.RecommendedDegreeName, convMandarinCase_Resource_Rel.RecommendedDegreeName);
//检查外键字段长度
 objvMandarinCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMandarinCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvMandarinCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}