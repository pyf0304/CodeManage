﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCacheModeDA
 表名:CacheMode(01120688)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置(SystemSet)
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
 /// 缓存方式(CacheMode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCacheModeDA : clsCommBase4DA
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
 return clsCacheModeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCacheModeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCacheModeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCacheModeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCacheModeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCacheModeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCacheModeId)
{
strCacheModeId = strCacheModeId.Replace("'", "''");
if (strCacheModeId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:CacheMode中,检查关键字,长度不正确!(clsCacheModeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCacheModeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CacheMode中,关键字不能为空 或 null!(clsCacheModeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCacheModeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCacheModeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CacheMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable_CacheMode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CacheMode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CacheMode.* from CacheMode Left Join {1} on {2} where {3} and CacheMode.CacheModeId not in (Select top {5} CacheMode.CacheModeId from CacheMode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1} and CacheModeId not in (Select top {2} CacheModeId from CacheMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1} and CacheModeId not in (Select top {3} CacheModeId from CacheMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCacheModeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CacheMode.* from CacheMode Left Join {1} on {2} where {3} and CacheMode.CacheModeId not in (Select top {5} CacheMode.CacheModeId from CacheMode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1} and CacheModeId not in (Select top {2} CacheModeId from CacheMode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CacheMode where {1} and CacheModeId not in (Select top {3} CacheModeId from CacheMode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCacheModeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCacheModeDA:GetObjLst)", objException.Message));
}
List<clsCacheModeEN> arrObjLst = new List<clsCacheModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheModeEN objCacheModeEN = new clsCacheModeEN();
try
{
objCacheModeEN.CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheModeEN.CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名
objCacheModeEN.CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名
objCacheModeEN.InUse = TransNullToBool(objRow[conCacheMode.InUse].ToString().Trim()); //是否在用
objCacheModeEN.Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCacheModeDA: GetObjLst)", objException.Message));
}
objCacheModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCacheModeEN);
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
public List<clsCacheModeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCacheModeDA:GetObjLstByTabName)", objException.Message));
}
List<clsCacheModeEN> arrObjLst = new List<clsCacheModeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCacheModeEN objCacheModeEN = new clsCacheModeEN();
try
{
objCacheModeEN.CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheModeEN.CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名
objCacheModeEN.CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名
objCacheModeEN.InUse = TransNullToBool(objRow[conCacheMode.InUse].ToString().Trim()); //是否在用
objCacheModeEN.Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCacheModeDA: GetObjLst)", objException.Message));
}
objCacheModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCacheModeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCacheModeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCacheMode(ref clsCacheModeEN objCacheModeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where CacheModeId = " + "'"+ objCacheModeEN.CacheModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCacheModeEN.CacheModeId = objDT.Rows[0][conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCacheModeEN.CacheModeName = objDT.Rows[0][conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objCacheModeEN.CacheModeENName = objDT.Rows[0][conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCacheModeEN.InUse = TransNullToBool(objDT.Rows[0][conCacheMode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCacheModeEN.Memo = objDT.Rows[0][conCacheMode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCacheModeDA: GetCacheMode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCacheModeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCacheModeEN GetObjByCacheModeId(string strCacheModeId)
{
CheckPrimaryKey(strCacheModeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where CacheModeId = " + "'"+ strCacheModeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCacheModeEN objCacheModeEN = new clsCacheModeEN();
try
{
 objCacheModeEN.CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCacheModeEN.CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名(字段类型:varchar,字段长度:50,是否可空:True)
 objCacheModeEN.CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCacheModeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCacheMode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCacheModeEN.Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCacheModeDA: GetObjByCacheModeId)", objException.Message));
}
return objCacheModeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCacheModeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCacheModeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCacheModeEN objCacheModeEN = new clsCacheModeEN()
{
CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(), //缓存方式Id
CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(), //缓存方式名
CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(), //缓存方式英文名
InUse = TransNullToBool(objRow[conCacheMode.InUse].ToString().Trim()), //是否在用
Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim() //备注
};
objCacheModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCacheModeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCacheModeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCacheModeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCacheModeEN objCacheModeEN = new clsCacheModeEN();
try
{
objCacheModeEN.CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheModeEN.CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名
objCacheModeEN.CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名
objCacheModeEN.InUse = TransNullToBool(objRow[conCacheMode.InUse].ToString().Trim()); //是否在用
objCacheModeEN.Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCacheModeDA: GetObjByDataRowCacheMode)", objException.Message));
}
objCacheModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCacheModeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCacheModeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCacheModeEN objCacheModeEN = new clsCacheModeEN();
try
{
objCacheModeEN.CacheModeId = objRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id
objCacheModeEN.CacheModeName = objRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名
objCacheModeEN.CacheModeENName = objRow[conCacheMode.CacheModeENName] == DBNull.Value ? null : objRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名
objCacheModeEN.InUse = TransNullToBool(objRow[conCacheMode.InUse].ToString().Trim()); //是否在用
objCacheModeEN.Memo = objRow[conCacheMode.Memo] == DBNull.Value ? null : objRow[conCacheMode.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCacheModeDA: GetObjByDataRow)", objException.Message));
}
objCacheModeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCacheModeEN;
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
objSQL = clsCacheModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCacheModeEN._CurrTabName, conCacheMode.CacheModeId, 2, "");
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
objSQL = clsCacheModeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCacheModeEN._CurrTabName, conCacheMode.CacheModeId, 2, strPrefix);
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CacheModeId from CacheMode where " + strCondition;
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CacheModeId from CacheMode where " + strCondition;
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
 /// <param name = "strCacheModeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCacheModeId)
{
CheckPrimaryKey(strCacheModeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CacheMode", "CacheModeId = " + "'"+ strCacheModeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCacheModeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CacheMode", strCondition))
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
objSQL = clsCacheModeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CacheMode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCacheModeEN objCacheModeEN)
 {
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCacheModeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CacheMode");
objRow = objDS.Tables["CacheMode"].NewRow();
objRow[conCacheMode.CacheModeId] = objCacheModeEN.CacheModeId; //缓存方式Id
objRow[conCacheMode.CacheModeName] = objCacheModeEN.CacheModeName; //缓存方式名
 if (objCacheModeEN.CacheModeENName !=  "")
 {
objRow[conCacheMode.CacheModeENName] = objCacheModeEN.CacheModeENName; //缓存方式英文名
 }
objRow[conCacheMode.InUse] = objCacheModeEN.InUse; //是否在用
 if (objCacheModeEN.Memo !=  "")
 {
objRow[conCacheMode.Memo] = objCacheModeEN.Memo; //备注
 }
objDS.Tables[clsCacheModeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCacheModeEN._CurrTabName);
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
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCacheModeEN objCacheModeEN)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCacheModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCacheModeEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeId);
 var strCacheModeId = objCacheModeEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objCacheModeEN.CacheModeName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeName);
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeName + "'");
 }
 
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeENName);
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeENName + "'");
 }
 
 arrFieldListForInsert.Add(conCacheMode.InUse);
 arrValueListForInsert.Add("'" + (objCacheModeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCacheModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.Memo);
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CacheMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCacheModeEN objCacheModeEN)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCacheModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCacheModeEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeId);
 var strCacheModeId = objCacheModeEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objCacheModeEN.CacheModeName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeName);
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeName + "'");
 }
 
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeENName);
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeENName + "'");
 }
 
 arrFieldListForInsert.Add(conCacheMode.InUse);
 arrValueListForInsert.Add("'" + (objCacheModeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCacheModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.Memo);
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CacheMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCacheModeEN.CacheModeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCacheModeEN objCacheModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCacheModeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCacheModeEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeId);
 var strCacheModeId = objCacheModeEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objCacheModeEN.CacheModeName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeName);
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeName + "'");
 }
 
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeENName);
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeENName + "'");
 }
 
 arrFieldListForInsert.Add(conCacheMode.InUse);
 arrValueListForInsert.Add("'" + (objCacheModeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCacheModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.Memo);
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CacheMode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCacheModeEN.CacheModeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCacheModeEN objCacheModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCacheModeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCacheModeEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeId);
 var strCacheModeId = objCacheModeEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objCacheModeEN.CacheModeName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeName);
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeName + "'");
 }
 
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.CacheModeENName);
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeENName + "'");
 }
 
 arrFieldListForInsert.Add(conCacheMode.InUse);
 arrValueListForInsert.Add("'" + (objCacheModeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objCacheModeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCacheMode.Memo);
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CacheMode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCacheModes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where CacheModeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CacheMode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCacheModeId = oRow[conCacheMode.CacheModeId].ToString().Trim();
if (IsExist(strCacheModeId))
{
 string strResult = "关键字变量值为:" + string.Format("CacheModeId = {0}", strCacheModeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCacheModeEN._CurrTabName ].NewRow();
objRow[conCacheMode.CacheModeId] = oRow[conCacheMode.CacheModeId].ToString().Trim(); //缓存方式Id
objRow[conCacheMode.CacheModeName] = oRow[conCacheMode.CacheModeName].ToString().Trim(); //缓存方式名
objRow[conCacheMode.CacheModeENName] = oRow[conCacheMode.CacheModeENName].ToString().Trim(); //缓存方式英文名
objRow[conCacheMode.InUse] = oRow[conCacheMode.InUse].ToString().Trim(); //是否在用
objRow[conCacheMode.Memo] = oRow[conCacheMode.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCacheModeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCacheModeEN._CurrTabName);
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
 /// <param name = "objCacheModeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCacheModeEN objCacheModeEN)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCacheModeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
strSQL = "Select * from CacheMode where CacheModeId = " + "'"+ objCacheModeEN.CacheModeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCacheModeEN._CurrTabName);
if (objDS.Tables[clsCacheModeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CacheModeId = " + "'"+ objCacheModeEN.CacheModeId+"'");
return false;
}
objRow = objDS.Tables[clsCacheModeEN._CurrTabName].Rows[0];
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeId))
 {
objRow[conCacheMode.CacheModeId] = objCacheModeEN.CacheModeId; //缓存方式Id
 }
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeName))
 {
objRow[conCacheMode.CacheModeName] = objCacheModeEN.CacheModeName; //缓存方式名
 }
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeENName))
 {
objRow[conCacheMode.CacheModeENName] = objCacheModeEN.CacheModeENName; //缓存方式英文名
 }
 if (objCacheModeEN.IsUpdated(conCacheMode.InUse))
 {
objRow[conCacheMode.InUse] = objCacheModeEN.InUse; //是否在用
 }
 if (objCacheModeEN.IsUpdated(conCacheMode.Memo))
 {
objRow[conCacheMode.Memo] = objCacheModeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCacheModeEN._CurrTabName);
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
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCacheModeEN objCacheModeEN)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCacheModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CacheMode Set ");
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeName))
 {
 if (objCacheModeEN.CacheModeName !=  null)
 {
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeName, conCacheMode.CacheModeName); //缓存方式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.CacheModeName); //缓存方式名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeENName))
 {
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeENName, conCacheMode.CacheModeENName); //缓存方式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.CacheModeENName); //缓存方式英文名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCacheModeEN.InUse == true?"1":"0", conCacheMode.InUse); //是否在用
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.Memo))
 {
 if (objCacheModeEN.Memo !=  null)
 {
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCacheMode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CacheModeId = '{0}'", objCacheModeEN.CacheModeId); 
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
 /// <param name = "objCacheModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCacheModeEN objCacheModeEN, string strCondition)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCacheModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CacheMode Set ");
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeName))
 {
 if (objCacheModeEN.CacheModeName !=  null)
 {
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeName = '{0}',", strCacheModeName); //缓存方式名
 }
 else
 {
 sbSQL.Append(" CacheModeName = null,"); //缓存方式名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeENName))
 {
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeENName = '{0}',", strCacheModeENName); //缓存方式英文名
 }
 else
 {
 sbSQL.Append(" CacheModeENName = null,"); //缓存方式英文名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCacheModeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.Memo))
 {
 if (objCacheModeEN.Memo !=  null)
 {
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCacheModeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCacheModeEN objCacheModeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCacheModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CacheMode Set ");
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeName))
 {
 if (objCacheModeEN.CacheModeName !=  null)
 {
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeName = '{0}',", strCacheModeName); //缓存方式名
 }
 else
 {
 sbSQL.Append(" CacheModeName = null,"); //缓存方式名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeENName))
 {
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeENName = '{0}',", strCacheModeENName); //缓存方式英文名
 }
 else
 {
 sbSQL.Append(" CacheModeENName = null,"); //缓存方式英文名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCacheModeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.Memo))
 {
 if (objCacheModeEN.Memo !=  null)
 {
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCacheModeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCacheModeEN objCacheModeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCacheModeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCacheModeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CacheMode Set ");
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeName))
 {
 if (objCacheModeEN.CacheModeName !=  null)
 {
 var strCacheModeName = objCacheModeEN.CacheModeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeName, conCacheMode.CacheModeName); //缓存方式名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.CacheModeName); //缓存方式名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.CacheModeENName))
 {
 if (objCacheModeEN.CacheModeENName !=  null)
 {
 var strCacheModeENName = objCacheModeEN.CacheModeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeENName, conCacheMode.CacheModeENName); //缓存方式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.CacheModeENName); //缓存方式英文名
 }
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCacheModeEN.InUse == true?"1":"0", conCacheMode.InUse); //是否在用
 }
 
 if (objCacheModeEN.IsUpdated(conCacheMode.Memo))
 {
 if (objCacheModeEN.Memo !=  null)
 {
 var strMemo = objCacheModeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCacheMode.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCacheMode.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CacheModeId = '{0}'", objCacheModeEN.CacheModeId); 
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
 /// <param name = "strCacheModeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCacheModeId) 
{
CheckPrimaryKey(strCacheModeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCacheModeId,
};
 objSQL.ExecSP("CacheMode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCacheModeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCacheModeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCacheModeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
//删除CacheMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CacheMode where CacheModeId = " + "'"+ strCacheModeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCacheMode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
//删除CacheMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CacheMode where CacheModeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCacheModeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCacheModeId) 
{
CheckPrimaryKey(strCacheModeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
//删除CacheMode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CacheMode where CacheModeId = " + "'"+ strCacheModeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCacheMode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCacheModeDA: DelCacheMode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CacheMode where " + strCondition ;
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
public bool DelCacheModeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCacheModeDA: DelCacheModeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCacheModeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CacheMode where " + strCondition ;
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
 /// <param name = "objCacheModeENS">源对象</param>
 /// <param name = "objCacheModeENT">目标对象</param>
public void CopyTo(clsCacheModeEN objCacheModeENS, clsCacheModeEN objCacheModeENT)
{
objCacheModeENT.CacheModeId = objCacheModeENS.CacheModeId; //缓存方式Id
objCacheModeENT.CacheModeName = objCacheModeENS.CacheModeName; //缓存方式名
objCacheModeENT.CacheModeENName = objCacheModeENS.CacheModeENName; //缓存方式英文名
objCacheModeENT.InUse = objCacheModeENS.InUse; //是否在用
objCacheModeENT.Memo = objCacheModeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCacheModeEN objCacheModeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCacheModeEN.CacheModeName, conCacheMode.CacheModeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeId, 2, conCacheMode.CacheModeId);
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeName, 50, conCacheMode.CacheModeName);
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeENName, 50, conCacheMode.CacheModeENName);
clsCheckSql.CheckFieldLen(objCacheModeEN.Memo, 1000, conCacheMode.Memo);
//检查字段外键固定长度
 objCacheModeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCacheModeEN objCacheModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeName, 50, conCacheMode.CacheModeName);
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeENName, 50, conCacheMode.CacheModeENName);
clsCheckSql.CheckFieldLen(objCacheModeEN.Memo, 1000, conCacheMode.Memo);
//检查外键字段长度
 objCacheModeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCacheModeEN objCacheModeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeId, 2, conCacheMode.CacheModeId);
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeName, 50, conCacheMode.CacheModeName);
clsCheckSql.CheckFieldLen(objCacheModeEN.CacheModeENName, 50, conCacheMode.CacheModeENName);
clsCheckSql.CheckFieldLen(objCacheModeEN.Memo, 1000, conCacheMode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCacheModeEN.CacheModeId, conCacheMode.CacheModeId);
clsCheckSql.CheckSqlInjection4Field(objCacheModeEN.CacheModeName, conCacheMode.CacheModeName);
clsCheckSql.CheckSqlInjection4Field(objCacheModeEN.CacheModeENName, conCacheMode.CacheModeENName);
clsCheckSql.CheckSqlInjection4Field(objCacheModeEN.Memo, conCacheMode.Memo);
//检查外键字段长度
 objCacheModeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCacheModeId()
{
//获取某学院所有专业信息
string strSQL = "select CacheModeId, CacheModeName from CacheMode ";
 clsSpecSQLforSql mySql = clsCacheModeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CacheMode(缓存方式),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCacheModeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCacheModeEN objCacheModeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CacheModeId = '{0}'", objCacheModeEN.CacheModeId);
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCacheModeEN._CurrTabName);
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCacheModeEN._CurrTabName, strCondition);
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
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
 objSQL = clsCacheModeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}