
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectPrjTabDA
 表名:vCMProjectPrjTab(00050531)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:53:00
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// vCMProjectPrjTab(vCMProjectPrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMProjectPrjTabDA : clsCommBase4DA
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
 return clsvCMProjectPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMProjectPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMProjectPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMProjectPrjTabEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMProjectPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable_vCMProjectPrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMProjectPrjTab.* from vCMProjectPrjTab Left Join {1} on {2} where {3} and vCMProjectPrjTab.mId not in (Select top {5} vCMProjectPrjTab.mId from vCMProjectPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1} and mId not in (Select top {2} mId from vCMProjectPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1} and mId not in (Select top {3} mId from vCMProjectPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMProjectPrjTab.* from vCMProjectPrjTab Left Join {1} on {2} where {3} and vCMProjectPrjTab.mId not in (Select top {5} vCMProjectPrjTab.mId from vCMProjectPrjTab Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1} and mId not in (Select top {2} mId from vCMProjectPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectPrjTab where {1} and mId not in (Select top {3} mId from vCMProjectPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMProjectPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA:GetObjLst)", objException.Message));
}
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = TransNullToInt(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetObjLst)", objException.Message));
}
objvCMProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectPrjTabEN);
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
public List<clsvCMProjectPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMProjectPrjTabEN> arrObjLst = new List<clsvCMProjectPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = TransNullToInt(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetObjLst)", objException.Message));
}
objvCMProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMProjectPrjTab(ref clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where mId = " + ""+ objvCMProjectPrjTabEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMProjectPrjTabEN.mId = TransNullToInt(objDT.Rows[0][convCMProjectPrjTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.CmPrjId = objDT.Rows[0][convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectPrjTabEN.CmPrjName = objDT.Rows[0][convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectPrjTabEN.PrjId = objDT.Rows[0][convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.TabId = objDT.Rows[0][convCMProjectPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.TabName = objDT.Rows[0][convCMProjectPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMProjectPrjTabEN.FuncModuleAgcId = objDT.Rows[0][convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.FuncModuleName = objDT.Rows[0][convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectPrjTabEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.UpdDate = objDT.Rows[0][convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectPrjTabEN.UpdUser = objDT.Rows[0][convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectPrjTabEN.Memo = objDT.Rows[0][convCMProjectPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMProjectPrjTabEN.SqlDsTypeId = objDT.Rows[0][convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMProjectPrjTabEN.SqlDsTypeName = objDT.Rows[0][convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCMProjectPrjTabEN.TabRecNum = TransNullToInt(objDT.Rows[0][convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvCMProjectPrjTabEN.TabTypeId = objDT.Rows[0][convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.TabStateId = objDT.Rows[0][convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetvCMProjectPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMProjectPrjTabEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
 objvCMProjectPrjTabEN.mId = Int32.Parse(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectPrjTabEN.OrderNum = Int32.Parse(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetObjBymId)", objException.Message));
}
return objvCMProjectPrjTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMProjectPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN()
{
mId = TransNullToInt(objRow[convCMProjectPrjTab.mId].ToString().Trim()), //mId
CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(), //CM工程Id
CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(), //CM工程名
PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(), //工程ID
TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(), //表名
FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(), //功能模块名称
OrderNum = TransNullToInt(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(), //说明
SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()), //记录数
TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim() //表状态ID
};
objvCMProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMProjectPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = TransNullToInt(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetObjByDataRowvCMProjectPrjTab)", objException.Message));
}
objvCMProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMProjectPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectPrjTabEN objvCMProjectPrjTabEN = new clsvCMProjectPrjTabEN();
try
{
objvCMProjectPrjTabEN.mId = TransNullToInt(objRow[convCMProjectPrjTab.mId].ToString().Trim()); //mId
objvCMProjectPrjTabEN.CmPrjId = objRow[convCMProjectPrjTab.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectPrjTabEN.CmPrjName = objRow[convCMProjectPrjTab.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectPrjTabEN.PrjId = objRow[convCMProjectPrjTab.PrjId].ToString().Trim(); //工程ID
objvCMProjectPrjTabEN.TabId = objRow[convCMProjectPrjTab.TabId].ToString().Trim(); //表ID
objvCMProjectPrjTabEN.TabName = objRow[convCMProjectPrjTab.TabName].ToString().Trim(); //表名
objvCMProjectPrjTabEN.FuncModuleAgcId = objRow[convCMProjectPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvCMProjectPrjTabEN.FuncModuleName = objRow[convCMProjectPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvCMProjectPrjTabEN.OrderNum = TransNullToInt(objRow[convCMProjectPrjTab.OrderNum].ToString().Trim()); //序号
objvCMProjectPrjTabEN.UpdDate = objRow[convCMProjectPrjTab.UpdDate] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdDate].ToString().Trim(); //修改日期
objvCMProjectPrjTabEN.UpdUser = objRow[convCMProjectPrjTab.UpdUser] == DBNull.Value ? null : objRow[convCMProjectPrjTab.UpdUser].ToString().Trim(); //修改者
objvCMProjectPrjTabEN.Memo = objRow[convCMProjectPrjTab.Memo] == DBNull.Value ? null : objRow[convCMProjectPrjTab.Memo].ToString().Trim(); //说明
objvCMProjectPrjTabEN.SqlDsTypeId = objRow[convCMProjectPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCMProjectPrjTabEN.SqlDsTypeName = objRow[convCMProjectPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convCMProjectPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvCMProjectPrjTabEN.TabRecNum = objRow[convCMProjectPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectPrjTab.TabRecNum].ToString().Trim()); //记录数
objvCMProjectPrjTabEN.TabTypeId = objRow[convCMProjectPrjTab.TabTypeId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvCMProjectPrjTabEN.TabStateId = objRow[convCMProjectPrjTab.TabStateId] == DBNull.Value ? null : objRow[convCMProjectPrjTab.TabStateId].ToString().Trim(); //表状态ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMProjectPrjTabDA: GetObjByDataRow)", objException.Message));
}
objvCMProjectPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectPrjTabEN;
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
objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectPrjTabEN._CurrTabName, convCMProjectPrjTab.mId, 8, "");
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
objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectPrjTabEN._CurrTabName, convCMProjectPrjTab.mId, 8, strPrefix);
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vCMProjectPrjTab where " + strCondition;
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vCMProjectPrjTab where " + strCondition;
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProjectPrjTab", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMProjectPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProjectPrjTab", strCondition))
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
objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMProjectPrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMProjectPrjTabENS">源对象</param>
 /// <param name = "objvCMProjectPrjTabENT">目标对象</param>
public void CopyTo(clsvCMProjectPrjTabEN objvCMProjectPrjTabENS, clsvCMProjectPrjTabEN objvCMProjectPrjTabENT)
{
objvCMProjectPrjTabENT.mId = objvCMProjectPrjTabENS.mId; //mId
objvCMProjectPrjTabENT.CmPrjId = objvCMProjectPrjTabENS.CmPrjId; //CM工程Id
objvCMProjectPrjTabENT.CmPrjName = objvCMProjectPrjTabENS.CmPrjName; //CM工程名
objvCMProjectPrjTabENT.PrjId = objvCMProjectPrjTabENS.PrjId; //工程ID
objvCMProjectPrjTabENT.TabId = objvCMProjectPrjTabENS.TabId; //表ID
objvCMProjectPrjTabENT.TabName = objvCMProjectPrjTabENS.TabName; //表名
objvCMProjectPrjTabENT.FuncModuleAgcId = objvCMProjectPrjTabENS.FuncModuleAgcId; //功能模块Id
objvCMProjectPrjTabENT.FuncModuleName = objvCMProjectPrjTabENS.FuncModuleName; //功能模块名称
objvCMProjectPrjTabENT.OrderNum = objvCMProjectPrjTabENS.OrderNum; //序号
objvCMProjectPrjTabENT.UpdDate = objvCMProjectPrjTabENS.UpdDate; //修改日期
objvCMProjectPrjTabENT.UpdUser = objvCMProjectPrjTabENS.UpdUser; //修改者
objvCMProjectPrjTabENT.Memo = objvCMProjectPrjTabENS.Memo; //说明
objvCMProjectPrjTabENT.SqlDsTypeId = objvCMProjectPrjTabENS.SqlDsTypeId; //数据源类型Id
objvCMProjectPrjTabENT.SqlDsTypeName = objvCMProjectPrjTabENS.SqlDsTypeName; //Sql数据源名
objvCMProjectPrjTabENT.TabRecNum = objvCMProjectPrjTabENS.TabRecNum; //记录数
objvCMProjectPrjTabENT.TabTypeId = objvCMProjectPrjTabENS.TabTypeId; //表类型Id
objvCMProjectPrjTabENT.TabStateId = objvCMProjectPrjTabENS.TabStateId; //表状态ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMProjectPrjTabEN objvCMProjectPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.CmPrjId, 6, convCMProjectPrjTab.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.CmPrjName, 50, convCMProjectPrjTab.CmPrjName);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.PrjId, 4, convCMProjectPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.TabId, 8, convCMProjectPrjTab.TabId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.TabName, 100, convCMProjectPrjTab.TabName);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.FuncModuleAgcId, 8, convCMProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.FuncModuleName, 30, convCMProjectPrjTab.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.UpdDate, 20, convCMProjectPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.UpdUser, 20, convCMProjectPrjTab.UpdUser);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.Memo, 1000, convCMProjectPrjTab.Memo);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.SqlDsTypeId, 2, convCMProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.SqlDsTypeName, 20, convCMProjectPrjTab.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.TabTypeId, 4, convCMProjectPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objvCMProjectPrjTabEN.TabStateId, 2, convCMProjectPrjTab.TabStateId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.CmPrjId, convCMProjectPrjTab.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.CmPrjName, convCMProjectPrjTab.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.PrjId, convCMProjectPrjTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.TabId, convCMProjectPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.TabName, convCMProjectPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.FuncModuleAgcId, convCMProjectPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.FuncModuleName, convCMProjectPrjTab.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.UpdDate, convCMProjectPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.UpdUser, convCMProjectPrjTab.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.Memo, convCMProjectPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.SqlDsTypeId, convCMProjectPrjTab.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.SqlDsTypeName, convCMProjectPrjTab.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.TabTypeId, convCMProjectPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectPrjTabEN.TabStateId, convCMProjectPrjTab.TabStateId);
//检查外键字段长度
 objvCMProjectPrjTabEN._IsCheckProperty = true;
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectPrjTabEN._CurrTabName);
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsvCMProjectPrjTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}