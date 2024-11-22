﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightTypeDA
 表名:vQxRightType(01120171)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// v权限类型(vQxRightType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxRightTypeDA : clsCommBase4DA
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
 return clsvQxRightTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxRightTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRightTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxRightTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxRightTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRightTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRightTypeId)
{
strRightTypeId = strRightTypeId.Replace("'", "''");
if (strRightTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vQxRightType中,检查关键字,长度不正确!(clsvQxRightTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRightTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxRightType中,关键字不能为空 或 null!(clsvQxRightTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRightTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxRightTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxRightType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable_vQxRightType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRightType.* from vQxRightType Left Join {1} on {2} where {3} and vQxRightType.RightTypeId not in (Select top {5} vQxRightType.RightTypeId from vQxRightType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1} and RightTypeId not in (Select top {2} RightTypeId from vQxRightType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1} and RightTypeId not in (Select top {3} RightTypeId from vQxRightType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRightType.* from vQxRightType Left Join {1} on {2} where {3} and vQxRightType.RightTypeId not in (Select top {5} vQxRightType.RightTypeId from vQxRightType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1} and RightTypeId not in (Select top {2} RightTypeId from vQxRightType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRightType where {1} and RightTypeId not in (Select top {3} RightTypeId from vQxRightType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQxRightTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxRightTypeDA:GetObjLst)", objException.Message));
}
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRightTypeDA: GetObjLst)", objException.Message));
}
objvQxRightTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRightTypeEN);
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
public List<clsvQxRightTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxRightTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRightTypeDA: GetObjLst)", objException.Message));
}
objvQxRightTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRightType(ref clsvQxRightTypeEN objvQxRightTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where RightTypeId = " + "'"+ objvQxRightTypeEN.RightTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxRightTypeEN.RightTypeId = objDT.Rows[0][convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxRightTypeEN.RightTypeName = objDT.Rows[0][convQxRightType.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRightTypeEN.FuncModuleId = objDT.Rows[0][convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxRightTypeEN.FuncModuleName = objDT.Rows[0][convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightTypeEN.FuncModuleNameSim = objDT.Rows[0][convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRightTypeEN.MenuId = objDT.Rows[0][convQxRightType.MenuId].ToString().Trim(); //菜单编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightTypeEN.ViewId = objDT.Rows[0][convQxRightType.ViewId].ToString().Trim(); //界面编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightTypeEN.UpdDate = objDT.Rows[0][convQxRightType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightTypeEN.UpdUser = objDT.Rows[0][convQxRightType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightTypeEN.Memo = objDT.Rows[0][convQxRightType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxRightTypeDA: GetvQxRightType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRightTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxRightTypeEN GetObjByRightTypeId(string strRightTypeId)
{
CheckPrimaryKey(strRightTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where RightTypeId = " + "'"+ strRightTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
 objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxRightTypeDA: GetObjByRightTypeId)", objException.Message));
}
return objvQxRightTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRightTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxRightTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
strSQL = "Select * from vQxRightType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN()
{
RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(), //权限类型编号
RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(), //权限类型名
FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(), //功能模块简称
MenuId = objRow[convQxRightType.MenuId].ToString().Trim(), //菜单编号
ViewId = objRow[convQxRightType.ViewId].ToString().Trim(), //界面编号
UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim() //备注
};
objvQxRightTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxRightTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxRightTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxRightTypeDA: GetObjByDataRowvQxRightType)", objException.Message));
}
objvQxRightTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxRightTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxRightTypeDA: GetObjByDataRow)", objException.Message));
}
objvQxRightTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightTypeEN;
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
objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRightTypeEN._CurrTabName, convQxRightType.RightTypeId, 4, "");
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
objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRightTypeEN._CurrTabName, convQxRightType.RightTypeId, 4, strPrefix);
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RightTypeId from vQxRightType where " + strCondition;
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RightTypeId from vQxRightType where " + strCondition;
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
 /// <param name = "strRightTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRightTypeId)
{
CheckPrimaryKey(strRightTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRightType", "RightTypeId = " + "'"+ strRightTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxRightTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRightType", strCondition))
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
objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxRightType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxRightTypeENS">源对象</param>
 /// <param name = "objvQxRightTypeENT">目标对象</param>
public void CopyTo(clsvQxRightTypeEN objvQxRightTypeENS, clsvQxRightTypeEN objvQxRightTypeENT)
{
objvQxRightTypeENT.RightTypeId = objvQxRightTypeENS.RightTypeId; //权限类型编号
objvQxRightTypeENT.RightTypeName = objvQxRightTypeENS.RightTypeName; //权限类型名
objvQxRightTypeENT.FuncModuleId = objvQxRightTypeENS.FuncModuleId; //功能模块Id
objvQxRightTypeENT.FuncModuleName = objvQxRightTypeENS.FuncModuleName; //功能模块名称
objvQxRightTypeENT.FuncModuleNameSim = objvQxRightTypeENS.FuncModuleNameSim; //功能模块简称
objvQxRightTypeENT.MenuId = objvQxRightTypeENS.MenuId; //菜单编号
objvQxRightTypeENT.ViewId = objvQxRightTypeENS.ViewId; //界面编号
objvQxRightTypeENT.UpdDate = objvQxRightTypeENS.UpdDate; //修改日期
objvQxRightTypeENT.UpdUser = objvQxRightTypeENS.UpdUser; //修改人
objvQxRightTypeENT.Memo = objvQxRightTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxRightTypeEN objvQxRightTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.RightTypeId, 4, convQxRightType.RightTypeId);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.RightTypeName, 50, convQxRightType.RightTypeName);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.FuncModuleId, 4, convQxRightType.FuncModuleId);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.FuncModuleName, 30, convQxRightType.FuncModuleName);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.FuncModuleNameSim, 30, convQxRightType.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.MenuId, 8, convQxRightType.MenuId);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.ViewId, 8, convQxRightType.ViewId);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.UpdDate, 20, convQxRightType.UpdDate);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.UpdUser, 20, convQxRightType.UpdUser);
clsCheckSql.CheckFieldLen(objvQxRightTypeEN.Memo, 1000, convQxRightType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.RightTypeId, convQxRightType.RightTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.RightTypeName, convQxRightType.RightTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.FuncModuleId, convQxRightType.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.FuncModuleName, convQxRightType.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.FuncModuleNameSim, convQxRightType.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.MenuId, convQxRightType.MenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.ViewId, convQxRightType.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.UpdDate, convQxRightType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.UpdUser, convQxRightType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxRightTypeEN.Memo, convQxRightType.Memo);
//检查外键字段长度
 objvQxRightTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetRightTypeId()
{
//获取某学院所有专业信息
string strSQL = "select RightTypeId, RightTypeName from vQxRightType ";
 clsSpecSQLforSql mySql = clsvQxRightTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRightTypeEN._CurrTabName);
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRightTypeEN._CurrTabName, strCondition);
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
 objSQL = clsvQxRightTypeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}