﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GeneViewCodeDA
 表名:Log4GeneViewCode(00050280)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 12:04:42
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// 生成界面代码日志(Log4GeneViewCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLog4GeneViewCodeDA : clsCommBase4DA
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
 return clsLog4GeneViewCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsLog4GeneViewCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLog4GeneViewCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsLog4GeneViewCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLog4GeneViewCodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Log4GeneViewCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable_Log4GeneViewCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Log4GeneViewCode.* from Log4GeneViewCode Left Join {1} on {2} where {3} and Log4GeneViewCode.mId not in (Select top {5} Log4GeneViewCode.mId from Log4GeneViewCode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1} and mId not in (Select top {2} mId from Log4GeneViewCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1} and mId not in (Select top {3} mId from Log4GeneViewCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Log4GeneViewCode.* from Log4GeneViewCode Left Join {1} on {2} where {3} and Log4GeneViewCode.mId not in (Select top {5} Log4GeneViewCode.mId from Log4GeneViewCode Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1} and mId not in (Select top {2} mId from Log4GeneViewCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneViewCode where {1} and mId not in (Select top {3} mId from Log4GeneViewCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsLog4GeneViewCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA:GetObjLst)", objException.Message));
}
List<clsLog4GeneViewCodeEN> arrObjLst = new List<clsLog4GeneViewCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
try
{
objLog4GeneViewCodeEN.mId = TransNullToInt(objRow[conLog4GeneViewCode.mId].ToString().Trim()); //mId
objLog4GeneViewCodeEN.UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objLog4GeneViewCodeEN.ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objLog4GeneViewCodeEN.PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objLog4GeneViewCodeEN.GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneViewCodeEN.VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneViewCodeEN.Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetObjLst)", objException.Message));
}
objLog4GeneViewCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLog4GeneViewCodeEN);
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
public List<clsLog4GeneViewCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsLog4GeneViewCodeEN> arrObjLst = new List<clsLog4GeneViewCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
try
{
objLog4GeneViewCodeEN.mId = TransNullToInt(objRow[conLog4GeneViewCode.mId].ToString().Trim()); //mId
objLog4GeneViewCodeEN.UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objLog4GeneViewCodeEN.ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objLog4GeneViewCodeEN.PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objLog4GeneViewCodeEN.GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneViewCodeEN.VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneViewCodeEN.Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetObjLst)", objException.Message));
}
objLog4GeneViewCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLog4GeneViewCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLog4GeneViewCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLog4GeneViewCode(ref clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where mId = " + ""+ objLog4GeneViewCodeEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLog4GeneViewCodeEN.mId = TransNullToInt(objDT.Rows[0][conLog4GeneViewCode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objLog4GeneViewCodeEN.UserId = objDT.Rows[0][conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objLog4GeneViewCodeEN.ViewId = objDT.Rows[0][conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objLog4GeneViewCodeEN.PrjId = objDT.Rows[0][conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objLog4GeneViewCodeEN.GeneCodeDate = objDT.Rows[0][conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objLog4GeneViewCodeEN.VersionGeneCode = objDT.Rows[0][conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objLog4GeneViewCodeEN.Memo = objDT.Rows[0][conLog4GeneViewCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetLog4GeneViewCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsLog4GeneViewCodeEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
try
{
 objLog4GeneViewCodeEN.mId = Int32.Parse(objRow[conLog4GeneViewCode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objLog4GeneViewCodeEN.UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objLog4GeneViewCodeEN.ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objLog4GeneViewCodeEN.PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objLog4GeneViewCodeEN.GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objLog4GeneViewCodeEN.VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objLog4GeneViewCodeEN.Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetObjBymId)", objException.Message));
}
return objLog4GeneViewCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLog4GeneViewCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN()
{
mId = TransNullToInt(objRow[conLog4GeneViewCode.mId].ToString().Trim()), //mId
UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(), //用户Id
ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(), //界面Id
PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(), //工程ID
GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(), //生成代码日期
VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(), //生成代码版本
Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim() //说明
};
objLog4GeneViewCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneViewCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLog4GeneViewCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
try
{
objLog4GeneViewCodeEN.mId = TransNullToInt(objRow[conLog4GeneViewCode.mId].ToString().Trim()); //mId
objLog4GeneViewCodeEN.UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objLog4GeneViewCodeEN.ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objLog4GeneViewCodeEN.PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objLog4GeneViewCodeEN.GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneViewCodeEN.VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneViewCodeEN.Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetObjByDataRowLog4GeneViewCode)", objException.Message));
}
objLog4GeneViewCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneViewCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLog4GeneViewCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLog4GeneViewCodeEN objLog4GeneViewCodeEN = new clsLog4GeneViewCodeEN();
try
{
objLog4GeneViewCodeEN.mId = TransNullToInt(objRow[conLog4GeneViewCode.mId].ToString().Trim()); //mId
objLog4GeneViewCodeEN.UserId = objRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objLog4GeneViewCodeEN.ViewId = objRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objLog4GeneViewCodeEN.PrjId = objRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objLog4GeneViewCodeEN.GeneCodeDate = objRow[conLog4GeneViewCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneViewCodeEN.VersionGeneCode = objRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneViewCodeEN.Memo = objRow[conLog4GeneViewCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLog4GeneViewCodeDA: GetObjByDataRow)", objException.Message));
}
objLog4GeneViewCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneViewCodeEN;
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
objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLog4GeneViewCodeEN._CurrTabName, conLog4GeneViewCode.mId, 8, "");
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
objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLog4GeneViewCodeEN._CurrTabName, conLog4GeneViewCode.mId, 8, strPrefix);
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from Log4GeneViewCode where " + strCondition;
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from Log4GeneViewCode where " + strCondition;
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Log4GeneViewCode", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Log4GeneViewCode", strCondition))
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
objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Log4GeneViewCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
 {
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneViewCodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Log4GeneViewCode");
objRow = objDS.Tables["Log4GeneViewCode"].NewRow();
objRow[conLog4GeneViewCode.UserId] = objLog4GeneViewCodeEN.UserId; //用户Id
objRow[conLog4GeneViewCode.ViewId] = objLog4GeneViewCodeEN.ViewId; //界面Id
objRow[conLog4GeneViewCode.PrjId] = objLog4GeneViewCodeEN.PrjId; //工程ID
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  "")
 {
objRow[conLog4GeneViewCode.GeneCodeDate] = objLog4GeneViewCodeEN.GeneCodeDate; //生成代码日期
 }
objRow[conLog4GeneViewCode.VersionGeneCode] = objLog4GeneViewCodeEN.VersionGeneCode; //生成代码版本
 if (objLog4GeneViewCodeEN.Memo !=  "")
 {
objRow[conLog4GeneViewCode.Memo] = objLog4GeneViewCodeEN.Memo; //说明
 }
objDS.Tables[clsLog4GeneViewCodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLog4GeneViewCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneViewCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.UserId);
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.ViewId);
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.PrjId);
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.Memo);
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneViewCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneViewCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.UserId);
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.ViewId);
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.PrjId);
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.Memo);
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneViewCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneViewCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.UserId);
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.ViewId);
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.PrjId);
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.Memo);
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneViewCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneViewCodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.UserId);
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.ViewId);
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.PrjId);
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneViewCode.Memo);
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneViewCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLog4GeneViewCodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Log4GeneViewCode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conLog4GeneViewCode.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLog4GeneViewCodeEN._CurrTabName ].NewRow();
objRow[conLog4GeneViewCode.UserId] = oRow[conLog4GeneViewCode.UserId].ToString().Trim(); //用户Id
objRow[conLog4GeneViewCode.ViewId] = oRow[conLog4GeneViewCode.ViewId].ToString().Trim(); //界面Id
objRow[conLog4GeneViewCode.PrjId] = oRow[conLog4GeneViewCode.PrjId].ToString().Trim(); //工程ID
objRow[conLog4GeneViewCode.GeneCodeDate] = oRow[conLog4GeneViewCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objRow[conLog4GeneViewCode.VersionGeneCode] = oRow[conLog4GeneViewCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objRow[conLog4GeneViewCode.Memo] = oRow[conLog4GeneViewCode.Memo].ToString().Trim(); //说明
 objDS.Tables[clsLog4GeneViewCodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLog4GeneViewCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneViewCodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneViewCodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneViewCode where mId = " + ""+ objLog4GeneViewCodeEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLog4GeneViewCodeEN._CurrTabName);
if (objDS.Tables[clsLog4GeneViewCodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objLog4GeneViewCodeEN.mId+"");
return false;
}
objRow = objDS.Tables[clsLog4GeneViewCodeEN._CurrTabName].Rows[0];
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.UserId))
 {
objRow[conLog4GeneViewCode.UserId] = objLog4GeneViewCodeEN.UserId; //用户Id
 }
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.ViewId))
 {
objRow[conLog4GeneViewCode.ViewId] = objLog4GeneViewCodeEN.ViewId; //界面Id
 }
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.PrjId))
 {
objRow[conLog4GeneViewCode.PrjId] = objLog4GeneViewCodeEN.PrjId; //工程ID
 }
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.GeneCodeDate))
 {
objRow[conLog4GeneViewCode.GeneCodeDate] = objLog4GeneViewCodeEN.GeneCodeDate; //生成代码日期
 }
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.VersionGeneCode))
 {
objRow[conLog4GeneViewCode.VersionGeneCode] = objLog4GeneViewCodeEN.VersionGeneCode; //生成代码版本
 }
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.Memo))
 {
objRow[conLog4GeneViewCode.Memo] = objLog4GeneViewCodeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsLog4GeneViewCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneViewCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Log4GeneViewCode Set ");
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.UserId))
 {
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conLog4GeneViewCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.UserId); //用户Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.ViewId))
 {
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conLog4GeneViewCode.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.ViewId); //界面Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.PrjId))
 {
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conLog4GeneViewCode.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.PrjId); //工程ID
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.GeneCodeDate))
 {
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conLog4GeneViewCode.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.VersionGeneCode))
 {
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionGeneCode, conLog4GeneViewCode.VersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.VersionGeneCode); //生成代码版本
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.Memo))
 {
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLog4GeneViewCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objLog4GeneViewCodeEN.mId); 
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
 /// <param name = "objLog4GeneViewCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN, string strCondition)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneViewCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneViewCode Set ");
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.UserId))
 {
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.ViewId))
 {
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.PrjId))
 {
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.GeneCodeDate))
 {
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.VersionGeneCode))
 {
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionGeneCode = '{0}',", strVersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.Append(" VersionGeneCode = null,"); //生成代码版本
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.Memo))
 {
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objLog4GeneViewCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneViewCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneViewCode Set ");
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.UserId))
 {
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.ViewId))
 {
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewId = '{0}',", strViewId); //界面Id
 }
 else
 {
 sbSQL.Append(" ViewId = null,"); //界面Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.PrjId))
 {
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程ID
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程ID
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.GeneCodeDate))
 {
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.VersionGeneCode))
 {
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionGeneCode = '{0}',", strVersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.Append(" VersionGeneCode = null,"); //生成代码版本
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.Memo))
 {
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objLog4GeneViewCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLog4GeneViewCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneViewCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneViewCode Set ");
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.UserId))
 {
 if (objLog4GeneViewCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneViewCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conLog4GeneViewCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.UserId); //用户Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.ViewId))
 {
 if (objLog4GeneViewCodeEN.ViewId !=  null)
 {
 var strViewId = objLog4GeneViewCodeEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewId, conLog4GeneViewCode.ViewId); //界面Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.ViewId); //界面Id
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.PrjId))
 {
 if (objLog4GeneViewCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneViewCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conLog4GeneViewCode.PrjId); //工程ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.PrjId); //工程ID
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.GeneCodeDate))
 {
 if (objLog4GeneViewCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneViewCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conLog4GeneViewCode.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.VersionGeneCode))
 {
 if (objLog4GeneViewCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneViewCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionGeneCode, conLog4GeneViewCode.VersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.VersionGeneCode); //生成代码版本
 }
 }
 
 if (objLog4GeneViewCodeEN.IsUpdated(conLog4GeneViewCode.Memo))
 {
 if (objLog4GeneViewCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneViewCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLog4GeneViewCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneViewCode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objLog4GeneViewCodeEN.mId); 
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("Log4GeneViewCode_Delete", values);
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
//删除Log4GeneViewCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneViewCode where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLog4GeneViewCode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
//删除Log4GeneViewCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneViewCode where mId in (" + strKeyList + ")";
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
//删除Log4GeneViewCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneViewCode where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLog4GeneViewCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: DelLog4GeneViewCode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Log4GeneViewCode where " + strCondition ;
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
public bool DelLog4GeneViewCodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLog4GeneViewCodeDA: DelLog4GeneViewCodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Log4GeneViewCode where " + strCondition ;
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
 /// <param name = "objLog4GeneViewCodeENS">源对象</param>
 /// <param name = "objLog4GeneViewCodeENT">目标对象</param>
public void CopyTo(clsLog4GeneViewCodeEN objLog4GeneViewCodeENS, clsLog4GeneViewCodeEN objLog4GeneViewCodeENT)
{
objLog4GeneViewCodeENT.mId = objLog4GeneViewCodeENS.mId; //mId
objLog4GeneViewCodeENT.UserId = objLog4GeneViewCodeENS.UserId; //用户Id
objLog4GeneViewCodeENT.ViewId = objLog4GeneViewCodeENS.ViewId; //界面Id
objLog4GeneViewCodeENT.PrjId = objLog4GeneViewCodeENS.PrjId; //工程ID
objLog4GeneViewCodeENT.GeneCodeDate = objLog4GeneViewCodeENS.GeneCodeDate; //生成代码日期
objLog4GeneViewCodeENT.VersionGeneCode = objLog4GeneViewCodeENS.VersionGeneCode; //生成代码版本
objLog4GeneViewCodeENT.Memo = objLog4GeneViewCodeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objLog4GeneViewCodeEN.UserId, conLog4GeneViewCode.UserId);
clsCheckSql.CheckFieldNotNull(objLog4GeneViewCodeEN.ViewId, conLog4GeneViewCode.ViewId);
clsCheckSql.CheckFieldNotNull(objLog4GeneViewCodeEN.PrjId, conLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldNotNull(objLog4GeneViewCodeEN.VersionGeneCode, conLog4GeneViewCode.VersionGeneCode);
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.UserId, 18, conLog4GeneViewCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.ViewId, 8, conLog4GeneViewCode.ViewId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.PrjId, 4, conLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.GeneCodeDate, 20, conLog4GeneViewCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.VersionGeneCode, 30, conLog4GeneViewCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.Memo, 1000, conLog4GeneViewCode.Memo);
//检查字段外键固定长度
 objLog4GeneViewCodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.UserId, 18, conLog4GeneViewCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.ViewId, 8, conLog4GeneViewCode.ViewId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.PrjId, 4, conLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.GeneCodeDate, 20, conLog4GeneViewCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.VersionGeneCode, 30, conLog4GeneViewCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.Memo, 1000, conLog4GeneViewCode.Memo);
//检查外键字段长度
 objLog4GeneViewCodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.UserId, 18, conLog4GeneViewCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.ViewId, 8, conLog4GeneViewCode.ViewId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.PrjId, 4, conLog4GeneViewCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.GeneCodeDate, 20, conLog4GeneViewCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.VersionGeneCode, 30, conLog4GeneViewCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneViewCodeEN.Memo, 1000, conLog4GeneViewCode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.UserId, conLog4GeneViewCode.UserId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.ViewId, conLog4GeneViewCode.ViewId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.PrjId, conLog4GeneViewCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.GeneCodeDate, conLog4GeneViewCode.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.VersionGeneCode, conLog4GeneViewCode.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneViewCodeEN.Memo, conLog4GeneViewCode.Memo);
//检查外键字段长度
 objLog4GeneViewCodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Log4GeneViewCode(生成界面代码日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLog4GeneViewCodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsLog4GeneViewCodeEN objLog4GeneViewCodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneViewCodeEN.UserId);
 sbCondition.AppendFormat(" and ViewId = '{0}'", objLog4GeneViewCodeEN.ViewId);
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLog4GeneViewCodeEN._CurrTabName);
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLog4GeneViewCodeEN._CurrTabName, strCondition);
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneViewCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}