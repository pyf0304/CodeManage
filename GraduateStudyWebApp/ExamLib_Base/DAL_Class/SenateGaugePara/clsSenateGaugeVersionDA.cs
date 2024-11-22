﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSenateGaugeVersionDA
 表名:SenateGaugeVersion(01120297)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:54
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
 /// 评价量规版本(SenateGaugeVersion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSenateGaugeVersionDA : clsCommBase4DA
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
 return clsSenateGaugeVersionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSenateGaugeVersionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSenateGaugeVersionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSenateGaugeVersionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSenateGaugeVersionEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SenateGaugeVersion中,检查关键字,长度不正确!(clsSenateGaugeVersionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSenateGaugeVersion)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SenateGaugeVersion中,关键字不能为空 或 null!(clsSenateGaugeVersionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSenateGaugeVersion);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSenateGaugeVersionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable_SenateGaugeVersion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeVersion.* from SenateGaugeVersion Left Join {1} on {2} where {3} and SenateGaugeVersion.IdSenateGaugeVersion not in (Select top {5} SenateGaugeVersion.IdSenateGaugeVersion from SenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {2} IdSenateGaugeVersion from SenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {3} IdSenateGaugeVersion from SenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} SenateGaugeVersion.* from SenateGaugeVersion Left Join {1} on {2} where {3} and SenateGaugeVersion.IdSenateGaugeVersion not in (Select top {5} SenateGaugeVersion.IdSenateGaugeVersion from SenateGaugeVersion Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {2} IdSenateGaugeVersion from SenateGaugeVersion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SenateGaugeVersion where {1} and IdSenateGaugeVersion not in (Select top {3} IdSenateGaugeVersion from SenateGaugeVersion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSenateGaugeVersionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA:GetObjLst)", objException.Message));
}
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeVersionEN);
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
public List<clsSenateGaugeVersionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA:GetObjLstByTabName)", objException.Message));
}
List<clsSenateGaugeVersionEN> arrObjLst = new List<clsSenateGaugeVersionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetObjLst)", objException.Message));
}
objSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSenateGaugeVersionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSenateGaugeVersion(ref clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ objSenateGaugeVersionEN.IdSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSenateGaugeVersionEN.IdSenateGaugeVersion = objDT.Rows[0][conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.senateGaugeVersionID = objDT.Rows[0][conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.senateGaugeVersionName = objDT.Rows[0][conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objSenateGaugeVersionEN.IsUse = TransNullToBool(objDT.Rows[0][conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objSenateGaugeVersionEN.VersionNo = TransNullToInt(objDT.Rows[0][conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeVersionEN.IdSkillType = objDT.Rows[0][conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.UserTypeId = objDT.Rows[0][conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeVersionEN.UpdDate = objDT.Rows[0][conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeVersionEN.UpdUserId = objDT.Rows[0][conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeVersionEN.senateGaugeVersionMemo = objDT.Rows[0][conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetSenateGaugeVersion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">表关键字</param>
 /// <returns>表对象</returns>
public clsSenateGaugeVersionEN GetObjByIdSenateGaugeVersion(string strIdSenateGaugeVersion)
{
CheckPrimaryKey(strIdSenateGaugeVersion);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
 objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objSenateGaugeVersionEN.senateGaugeVersionTtlScore = Single.Parse(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objSenateGaugeVersionEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetObjByIdSenateGaugeVersion)", objException.Message));
}
return objSenateGaugeVersionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSenateGaugeVersionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN()
{
IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
IsUse = TransNullToBool(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()), //是否使用
VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()), //版本号
IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(), //技能类型流水号
UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(), //用户类型Id
UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(), //修改用户Id
senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim() //评价量表版本说明
};
objSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeVersionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeVersionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetObjByDataRowSenateGaugeVersion)", objException.Message));
}
objSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeVersionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSenateGaugeVersionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSenateGaugeVersionEN objSenateGaugeVersionEN = new clsSenateGaugeVersionEN();
try
{
objSenateGaugeVersionEN.IdSenateGaugeVersion = objRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objSenateGaugeVersionEN.senateGaugeVersionID = objRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objSenateGaugeVersionEN.senateGaugeVersionName = objRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objSenateGaugeVersionEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objSenateGaugeVersionEN.IsUse = TransNullToBool(objRow[conSenateGaugeVersion.IsUse].ToString().Trim()); //是否使用
objSenateGaugeVersionEN.VersionNo = objRow[conSenateGaugeVersion.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSenateGaugeVersion.VersionNo].ToString().Trim()); //版本号
objSenateGaugeVersionEN.IdSkillType = objRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objSenateGaugeVersionEN.UserTypeId = objRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objSenateGaugeVersionEN.UpdDate = objRow[conSenateGaugeVersion.UpdDate] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objSenateGaugeVersionEN.UpdUserId = objRow[conSenateGaugeVersion.UpdUserId] == DBNull.Value ? null : objRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objSenateGaugeVersionEN.senateGaugeVersionMemo = objRow[conSenateGaugeVersion.senateGaugeVersionMemo] == DBNull.Value ? null : objRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSenateGaugeVersionDA: GetObjByDataRow)", objException.Message));
}
objSenateGaugeVersionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSenateGaugeVersionEN;
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
objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeVersionEN._CurrTabName, conSenateGaugeVersion.IdSenateGaugeVersion, 4, "");
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
objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSenateGaugeVersionEN._CurrTabName, conSenateGaugeVersion.IdSenateGaugeVersion, 4, strPrefix);
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSenateGaugeVersion from SenateGaugeVersion where " + strCondition;
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSenateGaugeVersion from SenateGaugeVersion where " + strCondition;
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeVersion", "IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SenateGaugeVersion", strCondition))
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
objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SenateGaugeVersion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
 {
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeVersionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeVersion");
objRow = objDS.Tables["SenateGaugeVersion"].NewRow();
objRow[conSenateGaugeVersion.IdSenateGaugeVersion] = objSenateGaugeVersionEN.IdSenateGaugeVersion; //评价量表版本流水号
objRow[conSenateGaugeVersion.senateGaugeVersionID] = objSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
objRow[conSenateGaugeVersion.senateGaugeVersionName] = objSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore] = objSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
objRow[conSenateGaugeVersion.IsUse] = objSenateGaugeVersionEN.IsUse; //是否使用
objRow[conSenateGaugeVersion.VersionNo] = objSenateGaugeVersionEN.VersionNo; //版本号
objRow[conSenateGaugeVersion.IdSkillType] = objSenateGaugeVersionEN.IdSkillType; //技能类型流水号
objRow[conSenateGaugeVersion.UserTypeId] = objSenateGaugeVersionEN.UserTypeId; //用户类型Id
 if (objSenateGaugeVersionEN.UpdDate !=  "")
 {
objRow[conSenateGaugeVersion.UpdDate] = objSenateGaugeVersionEN.UpdDate; //修改日期
 }
 if (objSenateGaugeVersionEN.UpdUserId !=  "")
 {
objRow[conSenateGaugeVersion.UpdUserId] = objSenateGaugeVersionEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  "")
 {
objRow[conSenateGaugeVersion.senateGaugeVersionMemo] = objSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
 }
objDS.Tables[clsSenateGaugeVersionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeVersionEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeVersionEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSkillType);
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSkillType + "'");
 }
 
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UserTypeId);
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdDate);
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdUserId);
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeVersionEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeVersionEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSkillType);
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSkillType + "'");
 }
 
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UserTypeId);
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdDate);
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdUserId);
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSenateGaugeVersionEN.IdSenateGaugeVersion;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSenateGaugeVersionEN objSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeVersionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeVersionEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeVersionEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSkillType);
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSkillType + "'");
 }
 
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UserTypeId);
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdDate);
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdUserId);
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSenateGaugeVersionEN.IdSenateGaugeVersion;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSenateGaugeVersionEN objSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSenateGaugeVersionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSenateGaugeVersionEN.IdSenateGaugeVersion !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSenateGaugeVersion);
 var strIdSenateGaugeVersion = objSenateGaugeVersionEN.IdSenateGaugeVersion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSenateGaugeVersion + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionID);
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionID + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionName);
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionName + "'");
 }
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionTtlScore);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.senateGaugeVersionTtlScore.ToString());
 
 arrFieldListForInsert.Add(conSenateGaugeVersion.IsUse);
 arrValueListForInsert.Add("'" + (objSenateGaugeVersionEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.VersionNo);
 arrValueListForInsert.Add(objSenateGaugeVersionEN.VersionNo.ToString());
 }
 
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.IdSkillType);
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSkillType + "'");
 }
 
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UserTypeId);
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserTypeId + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdDate);
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.UpdUserId);
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 arrFieldListForInsert.Add(conSenateGaugeVersion.senateGaugeVersionMemo);
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strsenateGaugeVersionMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SenateGaugeVersion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSenateGaugeVersions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where IdSenateGaugeVersion = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SenateGaugeVersion");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdSenateGaugeVersion = oRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim();
if (IsExist(strIdSenateGaugeVersion))
{
 string strResult = "关键字变量值为:" + string.Format("IdSenateGaugeVersion = {0}", strIdSenateGaugeVersion) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSenateGaugeVersionEN._CurrTabName ].NewRow();
objRow[conSenateGaugeVersion.IdSenateGaugeVersion] = oRow[conSenateGaugeVersion.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objRow[conSenateGaugeVersion.senateGaugeVersionID] = oRow[conSenateGaugeVersion.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objRow[conSenateGaugeVersion.senateGaugeVersionName] = oRow[conSenateGaugeVersion.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore] = oRow[conSenateGaugeVersion.senateGaugeVersionTtlScore].ToString().Trim(); //评价量表版本总分
objRow[conSenateGaugeVersion.IsUse] = oRow[conSenateGaugeVersion.IsUse].ToString().Trim(); //是否使用
objRow[conSenateGaugeVersion.VersionNo] = oRow[conSenateGaugeVersion.VersionNo].ToString().Trim(); //版本号
objRow[conSenateGaugeVersion.IdSkillType] = oRow[conSenateGaugeVersion.IdSkillType].ToString().Trim(); //技能类型流水号
objRow[conSenateGaugeVersion.UserTypeId] = oRow[conSenateGaugeVersion.UserTypeId].ToString().Trim(); //用户类型Id
objRow[conSenateGaugeVersion.UpdDate] = oRow[conSenateGaugeVersion.UpdDate].ToString().Trim(); //修改日期
objRow[conSenateGaugeVersion.UpdUserId] = oRow[conSenateGaugeVersion.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSenateGaugeVersion.senateGaugeVersionMemo] = oRow[conSenateGaugeVersion.senateGaugeVersionMemo].ToString().Trim(); //评价量表版本说明
 objDS.Tables[clsSenateGaugeVersionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objSenateGaugeVersionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeVersionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
strSQL = "Select * from SenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ objSenateGaugeVersionEN.IdSenateGaugeVersion+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSenateGaugeVersionEN._CurrTabName);
if (objDS.Tables[clsSenateGaugeVersionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdSenateGaugeVersion = " + "'"+ objSenateGaugeVersionEN.IdSenateGaugeVersion+"'");
return false;
}
objRow = objDS.Tables[clsSenateGaugeVersionEN._CurrTabName].Rows[0];
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSenateGaugeVersion))
 {
objRow[conSenateGaugeVersion.IdSenateGaugeVersion] = objSenateGaugeVersionEN.IdSenateGaugeVersion; //评价量表版本流水号
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID))
 {
objRow[conSenateGaugeVersion.senateGaugeVersionID] = objSenateGaugeVersionEN.senateGaugeVersionID; //评价量表版本ID
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName))
 {
objRow[conSenateGaugeVersion.senateGaugeVersionName] = objSenateGaugeVersionEN.senateGaugeVersionName; //评价量表版本名称
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
objRow[conSenateGaugeVersion.senateGaugeVersionTtlScore] = objSenateGaugeVersionEN.senateGaugeVersionTtlScore; //评价量表版本总分
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IsUse))
 {
objRow[conSenateGaugeVersion.IsUse] = objSenateGaugeVersionEN.IsUse; //是否使用
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.VersionNo))
 {
objRow[conSenateGaugeVersion.VersionNo] = objSenateGaugeVersionEN.VersionNo; //版本号
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSkillType))
 {
objRow[conSenateGaugeVersion.IdSkillType] = objSenateGaugeVersionEN.IdSkillType; //技能类型流水号
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UserTypeId))
 {
objRow[conSenateGaugeVersion.UserTypeId] = objSenateGaugeVersionEN.UserTypeId; //用户类型Id
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdDate))
 {
objRow[conSenateGaugeVersion.UpdDate] = objSenateGaugeVersionEN.UpdDate; //修改日期
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdUserId))
 {
objRow[conSenateGaugeVersion.UpdUserId] = objSenateGaugeVersionEN.UpdUserId; //修改用户Id
 }
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo))
 {
objRow[conSenateGaugeVersion.senateGaugeVersionMemo] = objSenateGaugeVersionEN.senateGaugeVersionMemo; //评价量表版本说明
 }
try
{
objDA.Update(objDS, clsSenateGaugeVersionEN._CurrTabName);
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SenateGaugeVersion Set ");
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.senateGaugeVersionTtlScore, conSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSenateGaugeVersionEN.IsUse == true?"1":"0", conSenateGaugeVersion.IsUse); //是否使用
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.VersionNo))
 {
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.VersionNo, conSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSkillType))
 {
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSkillType, conSenateGaugeVersion.IdSkillType); //技能类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.IdSkillType); //技能类型流水号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UserTypeId))
 {
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conSenateGaugeVersion.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UserTypeId); //用户类型Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdDate))
 {
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdUserId))
 {
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeVersion.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionMemo, conSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeVersion = '{0}'", objSenateGaugeVersionEN.IdSenateGaugeVersion); 
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strCondition)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeVersion Set ");
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionID = '{0}',", strsenateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionID = null,"); //评价量表版本ID
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionName = '{0}',", strsenateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionName = null,"); //评价量表版本名称
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 sbSQL.AppendFormat(" senateGaugeVersionTtlScore = {0},", objSenateGaugeVersionEN.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objSenateGaugeVersionEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.VersionNo))
 {
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.VersionNo, conSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSkillType))
 {
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSkillType = '{0}',", strIdSkillType); //技能类型流水号
 }
 else
 {
 sbSQL.Append(" IdSkillType = null,"); //技能类型流水号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UserTypeId))
 {
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdDate))
 {
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdUserId))
 {
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionMemo = '{0}',", strsenateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionMemo = null,"); //评价量表版本说明
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
 /// <param name = "objSenateGaugeVersionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSenateGaugeVersionEN objSenateGaugeVersionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeVersion Set ");
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionID = '{0}',", strsenateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionID = null,"); //评价量表版本ID
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionName = '{0}',", strsenateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionName = null,"); //评价量表版本名称
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 sbSQL.AppendFormat(" senateGaugeVersionTtlScore = {0},", objSenateGaugeVersionEN.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objSenateGaugeVersionEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.VersionNo))
 {
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.VersionNo, conSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSkillType))
 {
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSkillType = '{0}',", strIdSkillType); //技能类型流水号
 }
 else
 {
 sbSQL.Append(" IdSkillType = null,"); //技能类型流水号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UserTypeId))
 {
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserTypeId = '{0}',", strUserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.Append(" UserTypeId = null,"); //用户类型Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdDate))
 {
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdUserId))
 {
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" senateGaugeVersionMemo = '{0}',", strsenateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.Append(" senateGaugeVersionMemo = null,"); //评价量表版本说明
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
 /// <param name = "objSenateGaugeVersionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSenateGaugeVersionEN objSenateGaugeVersionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSenateGaugeVersionEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSenateGaugeVersionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSenateGaugeVersionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SenateGaugeVersion Set ");
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionID))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionID !=  null)
 {
 var strsenateGaugeVersionID = objSenateGaugeVersionEN.senateGaugeVersionID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionID); //评价量表版本ID
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionName))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionName !=  null)
 {
 var strsenateGaugeVersionName = objSenateGaugeVersionEN.senateGaugeVersionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionName); //评价量表版本名称
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionTtlScore))
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.senateGaugeVersionTtlScore, conSenateGaugeVersion.senateGaugeVersionTtlScore); //评价量表版本总分
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSenateGaugeVersionEN.IsUse == true?"1":"0", conSenateGaugeVersion.IsUse); //是否使用
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.VersionNo))
 {
 if (objSenateGaugeVersionEN.VersionNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSenateGaugeVersionEN.VersionNo, conSenateGaugeVersion.VersionNo); //版本号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.VersionNo); //版本号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.IdSkillType))
 {
 if (objSenateGaugeVersionEN.IdSkillType  ==  "")
 {
 objSenateGaugeVersionEN.IdSkillType = null;
 }
 if (objSenateGaugeVersionEN.IdSkillType !=  null)
 {
 var strIdSkillType = objSenateGaugeVersionEN.IdSkillType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSkillType, conSenateGaugeVersion.IdSkillType); //技能类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.IdSkillType); //技能类型流水号
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UserTypeId))
 {
 if (objSenateGaugeVersionEN.UserTypeId  ==  "")
 {
 objSenateGaugeVersionEN.UserTypeId = null;
 }
 if (objSenateGaugeVersionEN.UserTypeId !=  null)
 {
 var strUserTypeId = objSenateGaugeVersionEN.UserTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserTypeId, conSenateGaugeVersion.UserTypeId); //用户类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UserTypeId); //用户类型Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdDate))
 {
 if (objSenateGaugeVersionEN.UpdDate !=  null)
 {
 var strUpdDate = objSenateGaugeVersionEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSenateGaugeVersion.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UpdDate); //修改日期
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.UpdUserId))
 {
 if (objSenateGaugeVersionEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSenateGaugeVersionEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSenateGaugeVersion.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.UpdUserId); //修改用户Id
 }
 }
 
 if (objSenateGaugeVersionEN.IsUpdated(conSenateGaugeVersion.senateGaugeVersionMemo))
 {
 if (objSenateGaugeVersionEN.senateGaugeVersionMemo !=  null)
 {
 var strsenateGaugeVersionMemo = objSenateGaugeVersionEN.senateGaugeVersionMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strsenateGaugeVersionMemo, conSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSenateGaugeVersion.senateGaugeVersionMemo); //评价量表版本说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdSenateGaugeVersion = '{0}'", objSenateGaugeVersionEN.IdSenateGaugeVersion); 
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
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdSenateGaugeVersion) 
{
CheckPrimaryKey(strIdSenateGaugeVersion);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdSenateGaugeVersion,
};
 objSQL.ExecSP("SenateGaugeVersion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdSenateGaugeVersion, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdSenateGaugeVersion);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
//删除SenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSenateGaugeVersion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
//删除SenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeVersion where IdSenateGaugeVersion in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdSenateGaugeVersion">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdSenateGaugeVersion) 
{
CheckPrimaryKey(strIdSenateGaugeVersion);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
//删除SenateGaugeVersion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SenateGaugeVersion where IdSenateGaugeVersion = " + "'"+ strIdSenateGaugeVersion+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSenateGaugeVersion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: DelSenateGaugeVersion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeVersion where " + strCondition ;
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
public bool DelSenateGaugeVersionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSenateGaugeVersionDA: DelSenateGaugeVersionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SenateGaugeVersion where " + strCondition ;
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
 /// <param name = "objSenateGaugeVersionENS">源对象</param>
 /// <param name = "objSenateGaugeVersionENT">目标对象</param>
public void CopyTo(clsSenateGaugeVersionEN objSenateGaugeVersionENS, clsSenateGaugeVersionEN objSenateGaugeVersionENT)
{
objSenateGaugeVersionENT.IdSenateGaugeVersion = objSenateGaugeVersionENS.IdSenateGaugeVersion; //评价量表版本流水号
objSenateGaugeVersionENT.senateGaugeVersionID = objSenateGaugeVersionENS.senateGaugeVersionID; //评价量表版本ID
objSenateGaugeVersionENT.senateGaugeVersionName = objSenateGaugeVersionENS.senateGaugeVersionName; //评价量表版本名称
objSenateGaugeVersionENT.senateGaugeVersionTtlScore = objSenateGaugeVersionENS.senateGaugeVersionTtlScore; //评价量表版本总分
objSenateGaugeVersionENT.IsUse = objSenateGaugeVersionENS.IsUse; //是否使用
objSenateGaugeVersionENT.VersionNo = objSenateGaugeVersionENS.VersionNo; //版本号
objSenateGaugeVersionENT.IdSkillType = objSenateGaugeVersionENS.IdSkillType; //技能类型流水号
objSenateGaugeVersionENT.UserTypeId = objSenateGaugeVersionENS.UserTypeId; //用户类型Id
objSenateGaugeVersionENT.UpdDate = objSenateGaugeVersionENS.UpdDate; //修改日期
objSenateGaugeVersionENT.UpdUserId = objSenateGaugeVersionENS.UpdUserId; //修改用户Id
objSenateGaugeVersionENT.senateGaugeVersionMemo = objSenateGaugeVersionENS.senateGaugeVersionMemo; //评价量表版本说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.senateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.senateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.senateGaugeVersionTtlScore, conSenateGaugeVersion.senateGaugeVersionTtlScore);
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.IsUse, conSenateGaugeVersion.IsUse);
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.IdSkillType, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldNotNull(objSenateGaugeVersionEN.UserTypeId, conSenateGaugeVersion.UserTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.IdSenateGaugeVersion, 4, conSenateGaugeVersion.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionName, 200, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdDate, 20, conSenateGaugeVersion.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdUserId, 20, conSenateGaugeVersion.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conSenateGaugeVersion.senateGaugeVersionMemo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
 objSenateGaugeVersionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionName, 200, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdDate, 20, conSenateGaugeVersion.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdUserId, 20, conSenateGaugeVersion.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conSenateGaugeVersion.senateGaugeVersionMemo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
 objSenateGaugeVersionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.IdSenateGaugeVersion, 4, conSenateGaugeVersion.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionID, 4, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionName, 200, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdDate, 20, conSenateGaugeVersion.UpdDate);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.UpdUserId, 20, conSenateGaugeVersion.UpdUserId);
clsCheckSql.CheckFieldLen(objSenateGaugeVersionEN.senateGaugeVersionMemo, 1000, conSenateGaugeVersion.senateGaugeVersionMemo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.IdSenateGaugeVersion, conSenateGaugeVersion.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.senateGaugeVersionID, conSenateGaugeVersion.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.senateGaugeVersionName, conSenateGaugeVersion.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.IdSkillType, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.UserTypeId, conSenateGaugeVersion.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.UpdDate, conSenateGaugeVersion.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.UpdUserId, conSenateGaugeVersion.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSenateGaugeVersionEN.senateGaugeVersionMemo, conSenateGaugeVersion.senateGaugeVersionMemo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.IdSkillType, 4, conSenateGaugeVersion.IdSkillType);
clsCheckSql.CheckFieldForeignKey(objSenateGaugeVersionEN.UserTypeId, 2, conSenateGaugeVersion.UserTypeId);
 objSenateGaugeVersionEN._IsCheckProperty = true;
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
string strSQL = "select IdSenateGaugeVersion, senateGaugeVersionName from SenateGaugeVersion ";
 clsSpecSQLforSql mySql = clsSenateGaugeVersionDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SenateGaugeVersion(评价量规版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSenateGaugeVersionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSenateGaugeVersionEN objSenateGaugeVersionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and senateGaugeVersionName = '{0}'", objSenateGaugeVersionEN.senateGaugeVersionName);
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeVersionEN._CurrTabName);
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSenateGaugeVersionEN._CurrTabName, strCondition);
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
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
 objSQL = clsSenateGaugeVersionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}