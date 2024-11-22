
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSenateGaugeVersionDA
 表名:vSenateGaugeVersion(01120480)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:31
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
 /// v评价量规版本(vSenateGaugeVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSenateGaugeVersionDA : clsCommBase4DA
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
 return clsvSenateGaugeVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSenateGaugeVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSenateGaugeVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSenateGaugeVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSenateGaugeVersionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSenateGaugeVersion)
{
strIdSenateGaugeVersion = strIdSenateGaugeVersion.Replace("'", "''");
if (strIdSenateGaugeVersion.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vSenateGaugeVersion中,检查关键字,长度不正确!(clsvSenateGaugeVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSenateGaugeVersion中,关键字不能为空 或 null!(clsvSenateGaugeVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSenateGaugeVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable_vSenateGaugeVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeVersion.* from vSenateGaugeVersion Left Join {1} on {2} where {3} and vSenateGaugeVersion.IdSenateGaugeVersion not in (Select top {5} vSenateGaugeVersion.IdSenateGaugeVersion from vSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {2} IdSenateGaugeVersion from vSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {3} IdSenateGaugeVersion from vSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSenateGaugeVersion.* from vSenateGaugeVersion Left Join {1} on {2} where {3} and vSenateGaugeVersion.IdSenateGaugeVersion not in (Select top {5} vSenateGaugeVersion.IdSenateGaugeVersion from vSenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {2} IdSenateGaugeVersion from vSenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {3} IdSenateGaugeVersion from vSenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSenateGaugeVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA:GetObjLst)", objException.Message));
}
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objvSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeVersionEN);
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
public List<clsvSenateGaugeVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSenateGaugeVersionEN> arrObjLst = new List<clsvSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objvSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSenateGaugeVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSenateGaugeVersion(ref clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ objvSenateGaugeVersionEN.IdSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSenateGaugeVersionEN.IdSenateGaugeVersion = objDT.Rows[0][convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.senateGaugeVersionID = objDT.Rows[0][convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.senateGaugeVersionName = objDT.Rows[0][convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeVersionEN.senateGaugeVersionMemo = objDT.Rows[0][convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeVersionEN.SkillTypeID = objDT.Rows[0][convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.SkillTypeName = objDT.Rows[0][convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSenateGaugeVersionEN.IdSkillType = objDT.Rows[0][convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.VersionNo = TransNullToInt(objDT.Rows[0][convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeVersionEN.IsUse = TransNullToBool(objDT.Rows[0][convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeVersionEN.UserTypeId = objDT.Rows[0][convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeVersionEN.UserTypeName = objDT.Rows[0][convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeVersionEN.SenateGaugeNum = TransNullToInt(objDT.Rows[0][convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeVersionEN.CalaTotalScore = TransNullToFloat(objDT.Rows[0][convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeVersionEN.UpdDate = objDT.Rows[0][convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeVersionEN.UpdUserId = objDT.Rows[0][convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetvSenateGaugeVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public clsvSenateGaugeVersionEN GetObjByIdSenateGaugeVersion(string strIdSenateGaugeVersion)
{
CheckPrimaryKey(strIdSenateGaugeVersion);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
 objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum(字段类型:int,字段长度:4,是否可空:True)
 objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore(字段类型:float,字段长度:8,是否可空:True)
 objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetObjByIdSenateGaugeVersion)", objException.Message));
}
return objvSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSenateGaugeVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from vSenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN()
{
IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(), //评价量表版本说明
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(), //技能类型ID
SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(), //技能类型名称
IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(), //技能类型流水号
VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()), //版本号
IsUse = TransNullToBool(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()), //是否使用
UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(), //用户类型名称
SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()), //SenateGaugeNum
CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()), //CalaTotalScore
UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim() //修改用户Id
};
objvSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetObjByDataRowvSenateGaugeVersion)", objException.Message));
}
objvSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSenateGaugeVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSenateGaugeVersionEN objvSenateGaugeVersionEN = new clsvSenateGaugeVersionEN();
try
{
objvSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[convSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvSenateGaugeVersionEN.senateGaugeVersionID = objRow[convSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvSenateGaugeVersionEN.senateGaugeVersionName = objRow[convSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[convSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[convSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
objvSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvSenateGaugeVersionEN.SkillTypeID = objRow[convSenateGaugeVersion.SkillTypeID] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeID].ToString().Trim(); //技能类型ID
objvSenateGaugeVersionEN.SkillTypeName = objRow[convSenateGaugeVersion.SkillTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.SkillTypeName].ToString().Trim(); //技能类型名称
objvSenateGaugeVersionEN.IdSkillType = objRow[convSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objvSenateGaugeVersionEN.VersionNo = objRow[convSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objvSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[convSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objvSenateGaugeVersionEN.UserTypeId = objRow[convSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objvSenateGaugeVersionEN.UserTypeName = objRow[convSenateGaugeVersion.UserTypeName] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UserTypeName].ToString().Trim(); //用户类型名称
objvSenateGaugeVersionEN.SenateGaugeNum = objRow[convSenateGaugeVersion.SenateGaugeNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSenateGaugeVersion.SenateGaugeNum].ToString().Trim()); //SenateGaugeNum
objvSenateGaugeVersionEN.CalaTotalScore = objRow[convSenateGaugeVersion.CalaTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSenateGaugeVersion.CalaTotalScore].ToString().Trim()); //CalaTotalScore
objvSenateGaugeVersionEN.UpdDate = objRow[convSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objvSenateGaugeVersionEN.UpdUserId = objRow[convSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[convSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSenateGaugeVersionDA: GetObjByDataRow)", objException.Message));
}
objvSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSenateGaugeVersionEN;
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
objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeVersionEN._CurrTabName, convSenateGaugeVersion.IdSenateGaugeVersion, 4, "");
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
objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSenateGaugeVersionEN._CurrTabName, convSenateGaugeVersion.IdSenateGaugeVersion, 4, strPrefix);
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeVersion from vSenateGaugeVersion where " + strCondition;
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeVersion from vSenateGaugeVersion where " + strCondition;
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
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSenateGaugeVersion)
{
CheckPrimaryKey(strIdSenateGaugeVersion);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeVersion", "IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSenateGaugeVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSenateGaugeVersion", strCondition))
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
objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSenateGaugeVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSenateGaugeVersionENS">源对象</param>
 /// <param name = "objvSenateGaugeVersionENT">目标对象</param>
public void CopyTo(clsvSenateGaugeVersionEN objvSenateGaugeVersionENS, clsvSenateGaugeVersionEN objvSenateGaugeVersionENT)
{
objvSenateGaugeVersionENT.IdSenateGaugeVersion = objvSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objvSenateGaugeVersionENT.senateGaugeVersionID = objvSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objvSenateGaugeVersionENT.senateGaugeVersionName = objvSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objvSenateGaugeVersionENT.senateGaugeVersionMemo = objvSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
objvSenateGaugeVersionENT.senateGaugeVersionTtlScore = objvSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvSenateGaugeVersionENT.SkillTypeID = objvSenateGaugeVersionENS.SkillTypeID; //技能类型ID
objvSenateGaugeVersionENT.SkillTypeName = objvSenateGaugeVersionENS.SkillTypeName; //技能类型名称
objvSenateGaugeVersionENT.IdSkillType = objvSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objvSenateGaugeVersionENT.VersionNo = objvSenateGaugeVersionENS.VersionNo; //版本号
objvSenateGaugeVersionENT.IsUse = objvSenateGaugeVersionENS.IsUse; //是否使用
objvSenateGaugeVersionENT.UserTypeId = objvSenateGaugeVersionENS.UserTypeId; //用户类型Id
objvSenateGaugeVersionENT.UserTypeName = objvSenateGaugeVersionENS.UserTypeName; //用户类型名称
objvSenateGaugeVersionENT.SenateGaugeNum = objvSenateGaugeVersionENS.SenateGaugeNum; //SenateGaugeNum
objvSenateGaugeVersionENT.CalaTotalScore = objvSenateGaugeVersionENS.CalaTotalScore; //CalaTotalScore
objvSenateGaugeVersionENT.UpdDate = objvSenateGaugeVersionENS.UpdDate; //修改日期
objvSenateGaugeVersionENT.UpdUserId = objvSenateGaugeVersionENS.UpdUserId; //修改用户Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSenateGaugeVersionEN objvSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.IdSenateGaugeVersion, 4, convSenateGaugeVersion.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.senateGaugeVersionID, 4, convSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.senateGaugeVersionName, 200, convSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, convSenateGaugeVersion.senateGaugeVersionMemo);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.SkillTypeID, 4, convSenateGaugeVersion.SkillTypeID);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.SkillTypeName, 50, convSenateGaugeVersion.SkillTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.IdSkillType, 4, convSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.UserTypeId, 2, convSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.UserTypeName, 20, convSenateGaugeVersion.UserTypeName);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.UpdDate, 20, convSenateGaugeVersion.UpdDate);
clsCheckSql.CheckFieldLen(objvSenateGaugeVersionEN.UpdUserId, 20, convSenateGaugeVersion.UpdUserId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.IdSenateGaugeVersion, convSenateGaugeVersion.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.senateGaugeVersionID, convSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.senateGaugeVersionName, convSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.senateGaugeVersionMemo, convSenateGaugeVersion.senateGaugeVersionMemo);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.SkillTypeID, convSenateGaugeVersion.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.SkillTypeName, convSenateGaugeVersion.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.IdSkillType, convSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.UserTypeId, convSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.UserTypeName, convSenateGaugeVersion.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.UpdDate, convSenateGaugeVersion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSenateGaugeVersionEN.UpdUserId, convSenateGaugeVersion.UpdUserId);
//检查外键字段长度
 objvSenateGaugeVersionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSenateGaugeVersion()
{
//获取某学院所有专业信息
string strSQL = "select IdSenateGaugeVersion, senateGaugeVersionName from vSenateGaugeVersion ";
 clsSpecSQLforSql mySql = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeVersionEN._CurrTabName);
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSenateGaugeVersionEN._CurrTabName, strCondition);
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
 objSQL = clsvSenateGaugeVersionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}