
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightDA
 表名:vQxRight(01120174)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:14
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
 /// v用户权限(vQxRight)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQxRightDA : clsCommBase4DA
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
 return clsvQxRightEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQxRightEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRightEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQxRightEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQxRightEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRightId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRightId)
{
strRightId = strRightId.Replace("'", "''");
if (strRightId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vQxRight中,检查关键字,长度不正确!(clsvQxRightDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRightId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQxRight中,关键字不能为空 或 null!(clsvQxRightDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRightId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQxRightDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQxRight(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable_vQxRight)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQxRight where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRight.* from vQxRight Left Join {1} on {2} where {3} and vQxRight.RightId not in (Select top {5} vQxRight.RightId from vQxRight Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1} and RightId not in (Select top {2} RightId from vQxRight where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1} and RightId not in (Select top {3} RightId from vQxRight where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQxRightDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQxRight.* from vQxRight Left Join {1} on {2} where {3} and vQxRight.RightId not in (Select top {5} vQxRight.RightId from vQxRight Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1} and RightId not in (Select top {2} RightId from vQxRight where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQxRight where {1} and RightId not in (Select top {3} RightId from vQxRight where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQxRightEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQxRightDA:GetObjLst)", objException.Message));
}
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRightDA: GetObjLst)", objException.Message));
}
objvQxRightEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRightEN);
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
public List<clsvQxRightEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQxRightDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQxRightDA: GetObjLst)", objException.Message));
}
objvQxRightEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQxRightEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQxRight(ref clsvQxRightEN objvQxRightEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where RightId = " + "'"+ objvQxRightEN.RightId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQxRightEN.RightId = objDT.Rows[0][convQxRight.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objvQxRightEN.RightName = objDT.Rows[0][convQxRight.RightName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxRightEN.RightTypeId = objDT.Rows[0][convQxRight.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxRightEN.RightTypeName = objDT.Rows[0][convQxRight.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRightEN.MenuId = objDT.Rows[0][convQxRight.MenuId].ToString().Trim(); //菜单编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightEN.FuncModuleId = objDT.Rows[0][convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxRightEN.FuncModuleName = objDT.Rows[0][convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightEN.FuncModuleNameSim = objDT.Rows[0][convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRightEN.OrderNum = TransNullToInt(objDT.Rows[0][convQxRight.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRightEN.RightRangeLevelId = objDT.Rows[0][convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxRightEN.RightRangeLevelName = objDT.Rows[0][convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightEN.UpdDate = objDT.Rows[0][convQxRight.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightEN.UpdUser = objDT.Rows[0][convQxRight.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightEN.Memo = objDT.Rows[0][convQxRight.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQxRightDA: GetvQxRight)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQxRightEN GetObjByRightId(string strRightId)
{
CheckPrimaryKey(strRightId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where RightId = " + "'"+ strRightId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
 objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号(字段类型:char,字段长度:4,是否可空:False)
 objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号(字段类型:varchar,字段长度:8,是否可空:False)
 objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id(字段类型:char,字段长度:2,是否可空:False)
 objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQxRightDA: GetObjByRightId)", objException.Message));
}
return objvQxRightEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQxRightEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQxRightDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
strSQL = "Select * from vQxRight where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN()
{
RightId = objRow[convQxRight.RightId].ToString().Trim(), //权限编号
RightName = objRow[convQxRight.RightName].ToString().Trim(), //权限名称
RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(), //权限类型编号
RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(), //权限类型名
MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(), //菜单编号
FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(), //功能模块简称
OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRight.OrderNum].ToString().Trim()), //序号
RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(), //权限范围等级Id
RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(), //权限范围等级名称
UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim() //备注
};
objvQxRightEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQxRightDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQxRightEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQxRightDA: GetObjByDataRowvQxRight)", objException.Message));
}
objvQxRightEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQxRightEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQxRightDA: GetObjByDataRow)", objException.Message));
}
objvQxRightEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQxRightEN;
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
objSQL = clsvQxRightDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRightEN._CurrTabName, convQxRight.RightId, 8, "");
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
objSQL = clsvQxRightDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQxRightEN._CurrTabName, convQxRight.RightId, 8, strPrefix);
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RightId from vQxRight where " + strCondition;
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RightId from vQxRight where " + strCondition;
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
 /// <param name = "strRightId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRightId)
{
CheckPrimaryKey(strRightId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRight", "RightId = " + "'"+ strRightId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQxRightDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQxRightDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQxRight", strCondition))
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
objSQL = clsvQxRightDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQxRight");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQxRightENS">源对象</param>
 /// <param name = "objvQxRightENT">目标对象</param>
public void CopyTo(clsvQxRightEN objvQxRightENS, clsvQxRightEN objvQxRightENT)
{
objvQxRightENT.RightId = objvQxRightENS.RightId; //权限编号
objvQxRightENT.RightName = objvQxRightENS.RightName; //权限名称
objvQxRightENT.RightTypeId = objvQxRightENS.RightTypeId; //权限类型编号
objvQxRightENT.RightTypeName = objvQxRightENS.RightTypeName; //权限类型名
objvQxRightENT.MenuId = objvQxRightENS.MenuId; //菜单编号
objvQxRightENT.FuncModuleId = objvQxRightENS.FuncModuleId; //功能模块Id
objvQxRightENT.FuncModuleName = objvQxRightENS.FuncModuleName; //功能模块名称
objvQxRightENT.FuncModuleNameSim = objvQxRightENS.FuncModuleNameSim; //功能模块简称
objvQxRightENT.OrderNum = objvQxRightENS.OrderNum; //序号
objvQxRightENT.RightRangeLevelId = objvQxRightENS.RightRangeLevelId; //权限范围等级Id
objvQxRightENT.RightRangeLevelName = objvQxRightENS.RightRangeLevelName; //权限范围等级名称
objvQxRightENT.UpdDate = objvQxRightENS.UpdDate; //修改日期
objvQxRightENT.UpdUser = objvQxRightENS.UpdUser; //修改人
objvQxRightENT.Memo = objvQxRightENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQxRightEN objvQxRightEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQxRightEN.RightId, 8, convQxRight.RightId);
clsCheckSql.CheckFieldLen(objvQxRightEN.RightName, 200, convQxRight.RightName);
clsCheckSql.CheckFieldLen(objvQxRightEN.RightTypeId, 4, convQxRight.RightTypeId);
clsCheckSql.CheckFieldLen(objvQxRightEN.RightTypeName, 50, convQxRight.RightTypeName);
clsCheckSql.CheckFieldLen(objvQxRightEN.MenuId, 8, convQxRight.MenuId);
clsCheckSql.CheckFieldLen(objvQxRightEN.FuncModuleId, 4, convQxRight.FuncModuleId);
clsCheckSql.CheckFieldLen(objvQxRightEN.FuncModuleName, 30, convQxRight.FuncModuleName);
clsCheckSql.CheckFieldLen(objvQxRightEN.FuncModuleNameSim, 30, convQxRight.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvQxRightEN.RightRangeLevelId, 2, convQxRight.RightRangeLevelId);
clsCheckSql.CheckFieldLen(objvQxRightEN.RightRangeLevelName, 30, convQxRight.RightRangeLevelName);
clsCheckSql.CheckFieldLen(objvQxRightEN.UpdDate, 20, convQxRight.UpdDate);
clsCheckSql.CheckFieldLen(objvQxRightEN.UpdUser, 20, convQxRight.UpdUser);
clsCheckSql.CheckFieldLen(objvQxRightEN.Memo, 1000, convQxRight.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightId, convQxRight.RightId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightName, convQxRight.RightName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightTypeId, convQxRight.RightTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightTypeName, convQxRight.RightTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.MenuId, convQxRight.MenuId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.FuncModuleId, convQxRight.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.FuncModuleName, convQxRight.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.FuncModuleNameSim, convQxRight.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightRangeLevelId, convQxRight.RightRangeLevelId);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.RightRangeLevelName, convQxRight.RightRangeLevelName);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.UpdDate, convQxRight.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.UpdUser, convQxRight.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQxRightEN.Memo, convQxRight.Memo);
//检查外键字段长度
 objvQxRightEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetRightId()
{
//获取某学院所有专业信息
string strSQL = "select RightId, RightName from vQxRight ";
 clsSpecSQLforSql mySql = clsvQxRightDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRightEN._CurrTabName);
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQxRightEN._CurrTabName, strCondition);
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
 objSQL = clsvQxRightDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}