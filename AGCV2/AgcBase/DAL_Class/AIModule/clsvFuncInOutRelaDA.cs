﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncInOutRelaDA
 表名:vFuncInOutRela(00050408)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:44:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// v函数输入输出关系(vFuncInOutRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFuncInOutRelaDA : clsCommBase4DA
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
 return clsvFuncInOutRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFuncInOutRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncInOutRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFuncInOutRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFuncInOutRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFuncInOutRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable_vFuncInOutRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFuncInOutRela.* from vFuncInOutRela Left Join {1} on {2} where {3} and vFuncInOutRela.mId not in (Select top {5} vFuncInOutRela.mId from vFuncInOutRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1} and mId not in (Select top {2} mId from vFuncInOutRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1} and mId not in (Select top {3} mId from vFuncInOutRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFuncInOutRela.* from vFuncInOutRela Left Join {1} on {2} where {3} and vFuncInOutRela.mId not in (Select top {5} vFuncInOutRela.mId from vFuncInOutRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1} and mId not in (Select top {2} mId from vFuncInOutRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFuncInOutRela where {1} and mId not in (Select top {3} mId from vFuncInOutRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFuncInOutRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA:GetObjLst)", objException.Message));
}
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = TransNullToInt(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetObjLst)", objException.Message));
}
objvFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncInOutRelaEN);
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
public List<clsvFuncInOutRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFuncInOutRelaEN> arrObjLst = new List<clsvFuncInOutRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = TransNullToInt(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetObjLst)", objException.Message));
}
objvFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFuncInOutRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFuncInOutRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFuncInOutRela(ref clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where mId = " + ""+ objvFuncInOutRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFuncInOutRelaEN.mId = TransNullToInt(objDT.Rows[0][convFuncInOutRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFuncInOutRelaEN.FuncTabId = objDT.Rows[0][convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFuncInOutRelaEN.TabName = objDT.Rows[0][convFuncInOutRela.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncInOutRelaEN.TabCnName = objDT.Rows[0][convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFuncInOutRelaEN.InFldIds = objDT.Rows[0][convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.InFldNames = objDT.Rows[0][convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.OutFldIds = objDT.Rows[0][convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.OutFldNames = objDT.Rows[0][convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.GcFuncName = objDT.Rows[0][convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFuncInOutRelaEN.UpdDate = objDT.Rows[0][convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncInOutRelaEN.UpdUser = objDT.Rows[0][convFuncInOutRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncInOutRelaEN.Memo = objDT.Rows[0][convFuncInOutRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetvFuncInOutRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFuncInOutRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
 objvFuncInOutRelaEN.mId = Int32.Parse(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id(字段类型:char,字段长度:8,是否可空:True)
 objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetObjBymId)", objException.Message));
}
return objvFuncInOutRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFuncInOutRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
strSQL = "Select * from vFuncInOutRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN()
{
mId = TransNullToInt(objRow[convFuncInOutRela.mId].ToString().Trim()), //mId
FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(), //功能表Id
TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(), //表名
TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(), //表中文名
InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(), //输入字段Ids
InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(), //输入字段名s
OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(), //输出字段Ids
OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(), //输出字段名s
GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(), //GC函数名
UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim() //说明
};
objvFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncInOutRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFuncInOutRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = TransNullToInt(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetObjByDataRowvFuncInOutRela)", objException.Message));
}
objvFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncInOutRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFuncInOutRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFuncInOutRelaEN objvFuncInOutRelaEN = new clsvFuncInOutRelaEN();
try
{
objvFuncInOutRelaEN.mId = TransNullToInt(objRow[convFuncInOutRela.mId].ToString().Trim()); //mId
objvFuncInOutRelaEN.FuncTabId = objRow[convFuncInOutRela.FuncTabId] == DBNull.Value ? null : objRow[convFuncInOutRela.FuncTabId].ToString().Trim(); //功能表Id
objvFuncInOutRelaEN.TabName = objRow[convFuncInOutRela.TabName].ToString().Trim(); //表名
objvFuncInOutRelaEN.TabCnName = objRow[convFuncInOutRela.TabCnName] == DBNull.Value ? null : objRow[convFuncInOutRela.TabCnName].ToString().Trim(); //表中文名
objvFuncInOutRelaEN.InFldIds = objRow[convFuncInOutRela.InFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldIds].ToString().Trim(); //输入字段Ids
objvFuncInOutRelaEN.InFldNames = objRow[convFuncInOutRela.InFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.InFldNames].ToString().Trim(); //输入字段名s
objvFuncInOutRelaEN.OutFldIds = objRow[convFuncInOutRela.OutFldIds] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldIds].ToString().Trim(); //输出字段Ids
objvFuncInOutRelaEN.OutFldNames = objRow[convFuncInOutRela.OutFldNames] == DBNull.Value ? null : objRow[convFuncInOutRela.OutFldNames].ToString().Trim(); //输出字段名s
objvFuncInOutRelaEN.GcFuncName = objRow[convFuncInOutRela.GcFuncName] == DBNull.Value ? null : objRow[convFuncInOutRela.GcFuncName].ToString().Trim(); //GC函数名
objvFuncInOutRelaEN.UpdDate = objRow[convFuncInOutRela.UpdDate] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdDate].ToString().Trim(); //修改日期
objvFuncInOutRelaEN.UpdUser = objRow[convFuncInOutRela.UpdUser] == DBNull.Value ? null : objRow[convFuncInOutRela.UpdUser].ToString().Trim(); //修改者
objvFuncInOutRelaEN.Memo = objRow[convFuncInOutRela.Memo] == DBNull.Value ? null : objRow[convFuncInOutRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFuncInOutRelaDA: GetObjByDataRow)", objException.Message));
}
objvFuncInOutRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFuncInOutRelaEN;
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
objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncInOutRelaEN._CurrTabName, convFuncInOutRela.mId, 8, "");
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
objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFuncInOutRelaEN._CurrTabName, convFuncInOutRela.mId, 8, strPrefix);
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFuncInOutRela where " + strCondition;
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFuncInOutRela where " + strCondition;
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncInOutRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFuncInOutRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFuncInOutRela", strCondition))
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
objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFuncInOutRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFuncInOutRelaENS">源对象</param>
 /// <param name = "objvFuncInOutRelaENT">目标对象</param>
public void CopyTo(clsvFuncInOutRelaEN objvFuncInOutRelaENS, clsvFuncInOutRelaEN objvFuncInOutRelaENT)
{
objvFuncInOutRelaENT.mId = objvFuncInOutRelaENS.mId; //mId
objvFuncInOutRelaENT.FuncTabId = objvFuncInOutRelaENS.FuncTabId; //功能表Id
objvFuncInOutRelaENT.TabName = objvFuncInOutRelaENS.TabName; //表名
objvFuncInOutRelaENT.TabCnName = objvFuncInOutRelaENS.TabCnName; //表中文名
objvFuncInOutRelaENT.InFldIds = objvFuncInOutRelaENS.InFldIds; //输入字段Ids
objvFuncInOutRelaENT.InFldNames = objvFuncInOutRelaENS.InFldNames; //输入字段名s
objvFuncInOutRelaENT.OutFldIds = objvFuncInOutRelaENS.OutFldIds; //输出字段Ids
objvFuncInOutRelaENT.OutFldNames = objvFuncInOutRelaENS.OutFldNames; //输出字段名s
objvFuncInOutRelaENT.GcFuncName = objvFuncInOutRelaENS.GcFuncName; //GC函数名
objvFuncInOutRelaENT.UpdDate = objvFuncInOutRelaENS.UpdDate; //修改日期
objvFuncInOutRelaENT.UpdUser = objvFuncInOutRelaENS.UpdUser; //修改者
objvFuncInOutRelaENT.Memo = objvFuncInOutRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFuncInOutRelaEN objvFuncInOutRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.FuncTabId, 8, convFuncInOutRela.FuncTabId);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.TabName, 100, convFuncInOutRela.TabName);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.TabCnName, 200, convFuncInOutRela.TabCnName);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.InFldIds, 1000, convFuncInOutRela.InFldIds);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.InFldNames, 1000, convFuncInOutRela.InFldNames);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.OutFldIds, 1000, convFuncInOutRela.OutFldIds);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.OutFldNames, 1000, convFuncInOutRela.OutFldNames);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.GcFuncName, 50, convFuncInOutRela.GcFuncName);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.UpdDate, 20, convFuncInOutRela.UpdDate);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.UpdUser, 20, convFuncInOutRela.UpdUser);
clsCheckSql.CheckFieldLen(objvFuncInOutRelaEN.Memo, 1000, convFuncInOutRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.FuncTabId, convFuncInOutRela.FuncTabId);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.TabName, convFuncInOutRela.TabName);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.TabCnName, convFuncInOutRela.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.InFldIds, convFuncInOutRela.InFldIds);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.InFldNames, convFuncInOutRela.InFldNames);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.OutFldIds, convFuncInOutRela.OutFldIds);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.OutFldNames, convFuncInOutRela.OutFldNames);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.GcFuncName, convFuncInOutRela.GcFuncName);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.UpdDate, convFuncInOutRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.UpdUser, convFuncInOutRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFuncInOutRelaEN.Memo, convFuncInOutRela.Memo);
//检查外键字段长度
 objvFuncInOutRelaEN._IsCheckProperty = true;
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncInOutRelaEN._CurrTabName);
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFuncInOutRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvFuncInOutRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}