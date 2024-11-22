﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQueryOptionDA
 表名:QueryOption(00050080)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:57:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 查询选项(QueryOption)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQueryOptionDA : clsCommBase4DA
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
 return clsQueryOptionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQueryOptionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQueryOptionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQueryOptionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQueryOptionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQueryOptionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQueryOptionId)
{
strQueryOptionId = strQueryOptionId.Replace("'", "''");
if (strQueryOptionId.Length > 2)
{
throw new Exception("(errid:Data000001)在表:QueryOption中,检查关键字,长度不正确!(clsQueryOptionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQueryOptionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QueryOption中,关键字不能为空 或 null!(clsQueryOptionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQueryOptionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQueryOptionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QueryOption(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable_QueryOption)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QueryOption where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QueryOption.* from QueryOption Left Join {1} on {2} where {3} and QueryOption.QueryOptionId not in (Select top {5} QueryOption.QueryOptionId from QueryOption Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1} and QueryOptionId not in (Select top {2} QueryOptionId from QueryOption where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1} and QueryOptionId not in (Select top {3} QueryOptionId from QueryOption where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQueryOptionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QueryOption.* from QueryOption Left Join {1} on {2} where {3} and QueryOption.QueryOptionId not in (Select top {5} QueryOption.QueryOptionId from QueryOption Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1} and QueryOptionId not in (Select top {2} QueryOptionId from QueryOption where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QueryOption where {1} and QueryOptionId not in (Select top {3} QueryOptionId from QueryOption where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQueryOptionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQueryOptionDA:GetObjLst)", objException.Message));
}
List<clsQueryOptionEN> arrObjLst = new List<clsQueryOptionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN();
try
{
objQueryOptionEN.QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id
objQueryOptionEN.QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称
objQueryOptionEN.QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名
objQueryOptionEN.Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQueryOptionDA: GetObjLst)", objException.Message));
}
objQueryOptionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQueryOptionEN);
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
public List<clsQueryOptionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQueryOptionDA:GetObjLstByTabName)", objException.Message));
}
List<clsQueryOptionEN> arrObjLst = new List<clsQueryOptionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN();
try
{
objQueryOptionEN.QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id
objQueryOptionEN.QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称
objQueryOptionEN.QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名
objQueryOptionEN.Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQueryOptionDA: GetObjLst)", objException.Message));
}
objQueryOptionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQueryOptionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQueryOptionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQueryOption(ref clsQueryOptionEN objQueryOptionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where QueryOptionId = " + "'"+ objQueryOptionEN.QueryOptionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQueryOptionEN.QueryOptionId = objDT.Rows[0][conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objQueryOptionEN.QueryOptionName = objDT.Rows[0][conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称(字段类型:varchar,字段长度:20,是否可空:False)
 objQueryOptionEN.QueryOptionENName = objDT.Rows[0][conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objQueryOptionEN.Memo = objDT.Rows[0][conQueryOption.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQueryOptionDA: GetQueryOption)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQueryOptionId">表关键字</param>
 /// <returns>表对象</returns>
public clsQueryOptionEN GetObjByQueryOptionId(string strQueryOptionId)
{
CheckPrimaryKey(strQueryOptionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where QueryOptionId = " + "'"+ strQueryOptionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN();
try
{
 objQueryOptionEN.QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id(字段类型:varchar,字段长度:2,是否可空:False)
 objQueryOptionEN.QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称(字段类型:varchar,字段长度:20,是否可空:False)
 objQueryOptionEN.QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objQueryOptionEN.Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQueryOptionDA: GetObjByQueryOptionId)", objException.Message));
}
return objQueryOptionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQueryOptionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQueryOptionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN()
{
QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(), //查询方式Id
QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(), //查询方式名称
QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(), //查询方式英文名
Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim() //说明
};
objQueryOptionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQueryOptionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQueryOptionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQueryOptionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN();
try
{
objQueryOptionEN.QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id
objQueryOptionEN.QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称
objQueryOptionEN.QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名
objQueryOptionEN.Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQueryOptionDA: GetObjByDataRowQueryOption)", objException.Message));
}
objQueryOptionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQueryOptionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQueryOptionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQueryOptionEN objQueryOptionEN = new clsQueryOptionEN();
try
{
objQueryOptionEN.QueryOptionId = objRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id
objQueryOptionEN.QueryOptionName = objRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称
objQueryOptionEN.QueryOptionENName = objRow[conQueryOption.QueryOptionENName] == DBNull.Value ? null : objRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名
objQueryOptionEN.Memo = objRow[conQueryOption.Memo] == DBNull.Value ? null : objRow[conQueryOption.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQueryOptionDA: GetObjByDataRow)", objException.Message));
}
objQueryOptionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQueryOptionEN;
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
objSQL = clsQueryOptionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQueryOptionEN._CurrTabName, conQueryOption.QueryOptionId, 2, "");
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
objSQL = clsQueryOptionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQueryOptionEN._CurrTabName, conQueryOption.QueryOptionId, 2, strPrefix);
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QueryOptionId from QueryOption where " + strCondition;
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QueryOptionId from QueryOption where " + strCondition;
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
 /// <param name = "strQueryOptionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQueryOptionId)
{
CheckPrimaryKey(strQueryOptionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QueryOption", "QueryOptionId = " + "'"+ strQueryOptionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQueryOptionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QueryOption", strCondition))
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
objSQL = clsQueryOptionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QueryOption");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQueryOptionEN objQueryOptionEN)
 {
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQueryOptionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QueryOption");
objRow = objDS.Tables["QueryOption"].NewRow();
objRow[conQueryOption.QueryOptionId] = objQueryOptionEN.QueryOptionId; //查询方式Id
objRow[conQueryOption.QueryOptionName] = objQueryOptionEN.QueryOptionName; //查询方式名称
 if (objQueryOptionEN.QueryOptionENName !=  "")
 {
objRow[conQueryOption.QueryOptionENName] = objQueryOptionEN.QueryOptionENName; //查询方式英文名
 }
 if (objQueryOptionEN.Memo !=  "")
 {
objRow[conQueryOption.Memo] = objQueryOptionEN.Memo; //说明
 }
objDS.Tables[clsQueryOptionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQueryOptionEN._CurrTabName);
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
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQueryOptionEN objQueryOptionEN)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQueryOptionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQueryOptionEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionId);
 var strQueryOptionId = objQueryOptionEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionName);
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionName + "'");
 }
 
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionENName);
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionENName + "'");
 }
 
 if (objQueryOptionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.Memo);
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QueryOption");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQueryOptionEN objQueryOptionEN)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQueryOptionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQueryOptionEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionId);
 var strQueryOptionId = objQueryOptionEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionName);
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionName + "'");
 }
 
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionENName);
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionENName + "'");
 }
 
 if (objQueryOptionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.Memo);
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QueryOption");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQueryOptionEN.QueryOptionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQueryOptionEN objQueryOptionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQueryOptionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQueryOptionEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionId);
 var strQueryOptionId = objQueryOptionEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionName);
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionName + "'");
 }
 
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionENName);
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionENName + "'");
 }
 
 if (objQueryOptionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.Memo);
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QueryOption");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQueryOptionEN.QueryOptionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQueryOptionEN objQueryOptionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQueryOptionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQueryOptionEN.QueryOptionId !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionId);
 var strQueryOptionId = objQueryOptionEN.QueryOptionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionId + "'");
 }
 
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionName);
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionName + "'");
 }
 
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.QueryOptionENName);
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQueryOptionENName + "'");
 }
 
 if (objQueryOptionEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQueryOption.Memo);
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QueryOption");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQueryOptions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where QueryOptionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QueryOption");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strQueryOptionId = oRow[conQueryOption.QueryOptionId].ToString().Trim();
if (IsExist(strQueryOptionId))
{
 string strResult = "关键字变量值为:" + string.Format("QueryOptionId = {0}", strQueryOptionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQueryOptionEN._CurrTabName ].NewRow();
objRow[conQueryOption.QueryOptionId] = oRow[conQueryOption.QueryOptionId].ToString().Trim(); //查询方式Id
objRow[conQueryOption.QueryOptionName] = oRow[conQueryOption.QueryOptionName].ToString().Trim(); //查询方式名称
objRow[conQueryOption.QueryOptionENName] = oRow[conQueryOption.QueryOptionENName].ToString().Trim(); //查询方式英文名
objRow[conQueryOption.Memo] = oRow[conQueryOption.Memo].ToString().Trim(); //说明
 objDS.Tables[clsQueryOptionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQueryOptionEN._CurrTabName);
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
 /// <param name = "objQueryOptionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQueryOptionEN objQueryOptionEN)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQueryOptionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
strSQL = "Select * from QueryOption where QueryOptionId = " + "'"+ objQueryOptionEN.QueryOptionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQueryOptionEN._CurrTabName);
if (objDS.Tables[clsQueryOptionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QueryOptionId = " + "'"+ objQueryOptionEN.QueryOptionId+"'");
return false;
}
objRow = objDS.Tables[clsQueryOptionEN._CurrTabName].Rows[0];
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionId))
 {
objRow[conQueryOption.QueryOptionId] = objQueryOptionEN.QueryOptionId; //查询方式Id
 }
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionName))
 {
objRow[conQueryOption.QueryOptionName] = objQueryOptionEN.QueryOptionName; //查询方式名称
 }
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionENName))
 {
objRow[conQueryOption.QueryOptionENName] = objQueryOptionEN.QueryOptionENName; //查询方式英文名
 }
 if (objQueryOptionEN.IsUpdated(conQueryOption.Memo))
 {
objRow[conQueryOption.Memo] = objQueryOptionEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsQueryOptionEN._CurrTabName);
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
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQueryOptionEN objQueryOptionEN)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQueryOptionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QueryOption Set ");
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionName))
 {
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionName, conQueryOption.QueryOptionName); //查询方式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.QueryOptionName); //查询方式名称
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionENName))
 {
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionENName, conQueryOption.QueryOptionENName); //查询方式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.QueryOptionENName); //查询方式英文名
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.Memo))
 {
 if (objQueryOptionEN.Memo !=  null)
 {
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQueryOption.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QueryOptionId = '{0}'", objQueryOptionEN.QueryOptionId); 
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
 /// <param name = "objQueryOptionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQueryOptionEN objQueryOptionEN, string strCondition)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQueryOptionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QueryOption Set ");
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionName))
 {
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionName = '{0}',", strQueryOptionName); //查询方式名称
 }
 else
 {
 sbSQL.Append(" QueryOptionName = null,"); //查询方式名称
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionENName))
 {
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionENName = '{0}',", strQueryOptionENName); //查询方式英文名
 }
 else
 {
 sbSQL.Append(" QueryOptionENName = null,"); //查询方式英文名
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.Memo))
 {
 if (objQueryOptionEN.Memo !=  null)
 {
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQueryOptionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQueryOptionEN objQueryOptionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQueryOptionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QueryOption Set ");
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionName))
 {
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionName = '{0}',", strQueryOptionName); //查询方式名称
 }
 else
 {
 sbSQL.Append(" QueryOptionName = null,"); //查询方式名称
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionENName))
 {
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QueryOptionENName = '{0}',", strQueryOptionENName); //查询方式英文名
 }
 else
 {
 sbSQL.Append(" QueryOptionENName = null,"); //查询方式英文名
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.Memo))
 {
 if (objQueryOptionEN.Memo !=  null)
 {
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQueryOptionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQueryOptionEN objQueryOptionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objQueryOptionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQueryOptionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QueryOption Set ");
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionName))
 {
 if (objQueryOptionEN.QueryOptionName !=  null)
 {
 var strQueryOptionName = objQueryOptionEN.QueryOptionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionName, conQueryOption.QueryOptionName); //查询方式名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.QueryOptionName); //查询方式名称
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.QueryOptionENName))
 {
 if (objQueryOptionEN.QueryOptionENName !=  null)
 {
 var strQueryOptionENName = objQueryOptionEN.QueryOptionENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQueryOptionENName, conQueryOption.QueryOptionENName); //查询方式英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.QueryOptionENName); //查询方式英文名
 }
 }
 
 if (objQueryOptionEN.IsUpdated(conQueryOption.Memo))
 {
 if (objQueryOptionEN.Memo !=  null)
 {
 var strMemo = objQueryOptionEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQueryOption.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQueryOption.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QueryOptionId = '{0}'", objQueryOptionEN.QueryOptionId); 
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
 /// <param name = "strQueryOptionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQueryOptionId) 
{
CheckPrimaryKey(strQueryOptionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strQueryOptionId,
};
 objSQL.ExecSP("QueryOption_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strQueryOptionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strQueryOptionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strQueryOptionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
//删除QueryOption本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QueryOption where QueryOptionId = " + "'"+ strQueryOptionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQueryOption(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
//删除QueryOption本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QueryOption where QueryOptionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strQueryOptionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strQueryOptionId) 
{
CheckPrimaryKey(strQueryOptionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
//删除QueryOption本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QueryOption where QueryOptionId = " + "'"+ strQueryOptionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQueryOption(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQueryOptionDA: DelQueryOption)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QueryOption where " + strCondition ;
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
public bool DelQueryOptionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQueryOptionDA: DelQueryOptionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QueryOption where " + strCondition ;
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
 /// <param name = "objQueryOptionENS">源对象</param>
 /// <param name = "objQueryOptionENT">目标对象</param>
public void CopyTo(clsQueryOptionEN objQueryOptionENS, clsQueryOptionEN objQueryOptionENT)
{
objQueryOptionENT.QueryOptionId = objQueryOptionENS.QueryOptionId; //查询方式Id
objQueryOptionENT.QueryOptionName = objQueryOptionENS.QueryOptionName; //查询方式名称
objQueryOptionENT.QueryOptionENName = objQueryOptionENS.QueryOptionENName; //查询方式英文名
objQueryOptionENT.Memo = objQueryOptionENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQueryOptionEN objQueryOptionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQueryOptionEN.QueryOptionName, conQueryOption.QueryOptionName);
//检查字段长度
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionId, 2, conQueryOption.QueryOptionId);
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionName, 20, conQueryOption.QueryOptionName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionENName, 50, conQueryOption.QueryOptionENName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.Memo, 1000, conQueryOption.Memo);
//检查字段外键固定长度
 objQueryOptionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQueryOptionEN objQueryOptionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionName, 20, conQueryOption.QueryOptionName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionENName, 50, conQueryOption.QueryOptionENName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.Memo, 1000, conQueryOption.Memo);
//检查外键字段长度
 objQueryOptionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQueryOptionEN objQueryOptionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionId, 2, conQueryOption.QueryOptionId);
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionName, 20, conQueryOption.QueryOptionName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.QueryOptionENName, 50, conQueryOption.QueryOptionENName);
clsCheckSql.CheckFieldLen(objQueryOptionEN.Memo, 1000, conQueryOption.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQueryOptionEN.QueryOptionId, conQueryOption.QueryOptionId);
clsCheckSql.CheckSqlInjection4Field(objQueryOptionEN.QueryOptionName, conQueryOption.QueryOptionName);
clsCheckSql.CheckSqlInjection4Field(objQueryOptionEN.QueryOptionENName, conQueryOption.QueryOptionENName);
clsCheckSql.CheckSqlInjection4Field(objQueryOptionEN.Memo, conQueryOption.Memo);
//检查外键字段长度
 objQueryOptionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQueryOptionId()
{
//获取某学院所有专业信息
string strSQL = "select QueryOptionId, QueryOptionName from QueryOption ";
 clsSpecSQLforSql mySql = clsQueryOptionDA.GetSpecSQLObj();
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQueryOptionEN._CurrTabName);
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQueryOptionEN._CurrTabName, strCondition);
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
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
 objSQL = clsQueryOptionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}