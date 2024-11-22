﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFrontAndBack4AppTypeDA
 表名:vFrontAndBack4AppType(00050424)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:50:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// v应用类型的前后台关系(vFrontAndBack4AppType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFrontAndBack4AppTypeDA : clsCommBase4DA
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
 return clsvFrontAndBack4AppTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFrontAndBack4AppTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFrontAndBack4AppTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFrontAndBack4AppTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFrontAndBack4AppTypeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFrontAndBack4AppType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable_vFrontAndBack4AppType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFrontAndBack4AppType.* from vFrontAndBack4AppType Left Join {1} on {2} where {3} and vFrontAndBack4AppType.mId not in (Select top {5} vFrontAndBack4AppType.mId from vFrontAndBack4AppType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1} and mId not in (Select top {2} mId from vFrontAndBack4AppType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1} and mId not in (Select top {3} mId from vFrontAndBack4AppType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vFrontAndBack4AppType.* from vFrontAndBack4AppType Left Join {1} on {2} where {3} and vFrontAndBack4AppType.mId not in (Select top {5} vFrontAndBack4AppType.mId from vFrontAndBack4AppType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1} and mId not in (Select top {2} mId from vFrontAndBack4AppType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFrontAndBack4AppType where {1} and mId not in (Select top {3} mId from vFrontAndBack4AppType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFrontAndBack4AppTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA:GetObjLst)", objException.Message));
}
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = TransNullToInt(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = TransNullToInt(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = TransNullToBool(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetObjLst)", objException.Message));
}
objvFrontAndBack4AppTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
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
public List<clsvFrontAndBack4AppTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFrontAndBack4AppTypeEN> arrObjLst = new List<clsvFrontAndBack4AppTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = TransNullToInt(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = TransNullToInt(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = TransNullToBool(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetObjLst)", objException.Message));
}
objvFrontAndBack4AppTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFrontAndBack4AppTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFrontAndBack4AppType(ref clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where mId = " + ""+ objvFrontAndBack4AppTypeEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFrontAndBack4AppTypeEN.mId = TransNullToInt(objDT.Rows[0][convFrontAndBack4AppType.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFrontAndBack4AppTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFrontAndBack4AppTypeEN.AppTypeId4Front = TransNullToInt(objDT.Rows[0][convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front(字段类型:int,字段长度:4,是否可空:True)
 objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objDT.Rows[0][convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front(字段类型:varchar,字段长度:30,是否可空:True)
 objvFrontAndBack4AppTypeEN.IsVisible = TransNullToBool(objDT.Rows[0][convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvFrontAndBack4AppTypeEN.AppTypeId4Back = TransNullToInt(objDT.Rows[0][convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back(字段类型:int,字段长度:4,是否可空:True)
 objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objDT.Rows[0][convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back(字段类型:varchar,字段长度:30,是否可空:True)
 objvFrontAndBack4AppTypeEN.UpdDate = objDT.Rows[0][convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFrontAndBack4AppTypeEN.UpdUser = objDT.Rows[0][convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFrontAndBack4AppTypeEN.Memo = objDT.Rows[0][convFrontAndBack4AppType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetvFrontAndBack4AppType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvFrontAndBack4AppTypeEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
 objvFrontAndBack4AppTypeEN.mId = Int32.Parse(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvFrontAndBack4AppTypeEN.OrderNum = Int32.Parse(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front(字段类型:int,字段长度:4,是否可空:True)
 objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front(字段类型:varchar,字段长度:30,是否可空:True)
 objvFrontAndBack4AppTypeEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back(字段类型:int,字段长度:4,是否可空:True)
 objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back(字段类型:varchar,字段长度:30,是否可空:True)
 objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetObjBymId)", objException.Message));
}
return objvFrontAndBack4AppTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFrontAndBack4AppTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
strSQL = "Select * from vFrontAndBack4AppType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN()
{
mId = TransNullToInt(objRow[convFrontAndBack4AppType.mId].ToString().Trim()), //mId
OrderNum = TransNullToInt(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()), //序号
AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()), //应用类型Id4Front
ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(), //ApplTypeName4Front
IsVisible = TransNullToBool(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()), //是否显示
AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()), //应用类型Id4Back
ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(), //ApplTypeName4Back
UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim() //说明
};
objvFrontAndBack4AppTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFrontAndBack4AppTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFrontAndBack4AppTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = TransNullToInt(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = TransNullToInt(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = TransNullToBool(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetObjByDataRowvFrontAndBack4AppType)", objException.Message));
}
objvFrontAndBack4AppTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFrontAndBack4AppTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFrontAndBack4AppTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN = new clsvFrontAndBack4AppTypeEN();
try
{
objvFrontAndBack4AppTypeEN.mId = TransNullToInt(objRow[convFrontAndBack4AppType.mId].ToString().Trim()); //mId
objvFrontAndBack4AppTypeEN.OrderNum = TransNullToInt(objRow[convFrontAndBack4AppType.OrderNum].ToString().Trim()); //序号
objvFrontAndBack4AppTypeEN.AppTypeId4Front = objRow[convFrontAndBack4AppType.AppTypeId4Front] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Front].ToString().Trim()); //应用类型Id4Front
objvFrontAndBack4AppTypeEN.ApplTypeName4Front = objRow[convFrontAndBack4AppType.ApplTypeName4Front] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Front].ToString().Trim(); //ApplTypeName4Front
objvFrontAndBack4AppTypeEN.IsVisible = TransNullToBool(objRow[convFrontAndBack4AppType.IsVisible].ToString().Trim()); //是否显示
objvFrontAndBack4AppTypeEN.AppTypeId4Back = objRow[convFrontAndBack4AppType.AppTypeId4Back] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFrontAndBack4AppType.AppTypeId4Back].ToString().Trim()); //应用类型Id4Back
objvFrontAndBack4AppTypeEN.ApplTypeName4Back = objRow[convFrontAndBack4AppType.ApplTypeName4Back] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.ApplTypeName4Back].ToString().Trim(); //ApplTypeName4Back
objvFrontAndBack4AppTypeEN.UpdDate = objRow[convFrontAndBack4AppType.UpdDate] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdDate].ToString().Trim(); //修改日期
objvFrontAndBack4AppTypeEN.UpdUser = objRow[convFrontAndBack4AppType.UpdUser] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.UpdUser].ToString().Trim(); //修改者
objvFrontAndBack4AppTypeEN.Memo = objRow[convFrontAndBack4AppType.Memo] == DBNull.Value ? null : objRow[convFrontAndBack4AppType.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFrontAndBack4AppTypeDA: GetObjByDataRow)", objException.Message));
}
objvFrontAndBack4AppTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFrontAndBack4AppTypeEN;
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
objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFrontAndBack4AppTypeEN._CurrTabName, convFrontAndBack4AppType.mId, 8, "");
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
objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFrontAndBack4AppTypeEN._CurrTabName, convFrontAndBack4AppType.mId, 8, strPrefix);
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vFrontAndBack4AppType where " + strCondition;
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vFrontAndBack4AppType where " + strCondition;
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFrontAndBack4AppType", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFrontAndBack4AppTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFrontAndBack4AppType", strCondition))
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
objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFrontAndBack4AppType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFrontAndBack4AppTypeENS">源对象</param>
 /// <param name = "objvFrontAndBack4AppTypeENT">目标对象</param>
public void CopyTo(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENS, clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeENT)
{
objvFrontAndBack4AppTypeENT.mId = objvFrontAndBack4AppTypeENS.mId; //mId
objvFrontAndBack4AppTypeENT.OrderNum = objvFrontAndBack4AppTypeENS.OrderNum; //序号
objvFrontAndBack4AppTypeENT.AppTypeId4Front = objvFrontAndBack4AppTypeENS.AppTypeId4Front; //应用类型Id4Front
objvFrontAndBack4AppTypeENT.ApplTypeName4Front = objvFrontAndBack4AppTypeENS.ApplTypeName4Front; //ApplTypeName4Front
objvFrontAndBack4AppTypeENT.IsVisible = objvFrontAndBack4AppTypeENS.IsVisible; //是否显示
objvFrontAndBack4AppTypeENT.AppTypeId4Back = objvFrontAndBack4AppTypeENS.AppTypeId4Back; //应用类型Id4Back
objvFrontAndBack4AppTypeENT.ApplTypeName4Back = objvFrontAndBack4AppTypeENS.ApplTypeName4Back; //ApplTypeName4Back
objvFrontAndBack4AppTypeENT.UpdDate = objvFrontAndBack4AppTypeENS.UpdDate; //修改日期
objvFrontAndBack4AppTypeENT.UpdUser = objvFrontAndBack4AppTypeENS.UpdUser; //修改者
objvFrontAndBack4AppTypeENT.Memo = objvFrontAndBack4AppTypeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFrontAndBack4AppTypeEN objvFrontAndBack4AppTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFrontAndBack4AppTypeEN.ApplTypeName4Front, 30, convFrontAndBack4AppType.ApplTypeName4Front);
clsCheckSql.CheckFieldLen(objvFrontAndBack4AppTypeEN.ApplTypeName4Back, 30, convFrontAndBack4AppType.ApplTypeName4Back);
clsCheckSql.CheckFieldLen(objvFrontAndBack4AppTypeEN.UpdDate, 20, convFrontAndBack4AppType.UpdDate);
clsCheckSql.CheckFieldLen(objvFrontAndBack4AppTypeEN.UpdUser, 20, convFrontAndBack4AppType.UpdUser);
clsCheckSql.CheckFieldLen(objvFrontAndBack4AppTypeEN.Memo, 1000, convFrontAndBack4AppType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFrontAndBack4AppTypeEN.ApplTypeName4Front, convFrontAndBack4AppType.ApplTypeName4Front);
clsCheckSql.CheckSqlInjection4Field(objvFrontAndBack4AppTypeEN.ApplTypeName4Back, convFrontAndBack4AppType.ApplTypeName4Back);
clsCheckSql.CheckSqlInjection4Field(objvFrontAndBack4AppTypeEN.UpdDate, convFrontAndBack4AppType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFrontAndBack4AppTypeEN.UpdUser, convFrontAndBack4AppType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFrontAndBack4AppTypeEN.Memo, convFrontAndBack4AppType.Memo);
//检查外键字段长度
 objvFrontAndBack4AppTypeEN._IsCheckProperty = true;
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFrontAndBack4AppTypeEN._CurrTabName);
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFrontAndBack4AppTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvFrontAndBack4AppTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}