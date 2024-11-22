
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCMProjectAppRelaDA
 表名:vCMProjectAppRela(00050634)
 * 版本:2024.10.15.1(服务器:WIN-SRV103-116)
 日期:2024/10/15 11:46:16
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
 /// vCMProjectAppRela(vCMProjectAppRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCMProjectAppRelaDA : clsCommBase4DA
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
 return clsvCMProjectAppRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCMProjectAppRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCMProjectAppRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCMProjectAppRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCMProjectAppRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCMProjectAppRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable_vCMProjectAppRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMProjectAppRela.* from vCMProjectAppRela Left Join {1} on {2} where {3} and vCMProjectAppRela.CMProjectAppRelaId not in (Select top {5} vCMProjectAppRela.CMProjectAppRelaId from vCMProjectAppRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from vCMProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from vCMProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCMProjectAppRela.* from vCMProjectAppRela Left Join {1} on {2} where {3} and vCMProjectAppRela.CMProjectAppRelaId not in (Select top {5} vCMProjectAppRela.CMProjectAppRelaId from vCMProjectAppRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {2} CMProjectAppRelaId from vCMProjectAppRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCMProjectAppRela where {1} and CMProjectAppRelaId not in (Select top {3} CMProjectAppRelaId from vCMProjectAppRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCMProjectAppRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA:GetObjLst)", objException.Message));
}
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetObjLst)", objException.Message));
}
objvCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectAppRelaEN);
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
public List<clsvCMProjectAppRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCMProjectAppRelaEN> arrObjLst = new List<clsvCMProjectAppRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetObjLst)", objException.Message));
}
objvCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCMProjectAppRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCMProjectAppRela(ref clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where CMProjectAppRelaId = " + ""+ objvCMProjectAppRelaEN.CMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objDT.Rows[0][convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMProjectAppRelaEN.PrjId = objDT.Rows[0][convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.PrjName = objDT.Rows[0][convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.Memo = objDT.Rows[0][convCMProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMProjectAppRelaEN.UpdDate = objDT.Rows[0][convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectAppRelaEN.ApplicationTypeName = objDT.Rows[0][convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.ApplicationTypeENName = objDT.Rows[0][convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.ApplicationTypeSimName = objDT.Rows[0][convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMProjectAppRelaEN.CmPrjName = objDT.Rows[0][convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.CmPrjId = objDT.Rows[0][convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectAppRelaEN.UpdUser = objDT.Rows[0][convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectAppRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convCMProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.AppOrderNum = TransNullToInt(objDT.Rows[0][convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvCMProjectAppRelaEN.AppIsVisible = TransNullToBool(objDT.Rows[0][convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetvCMProjectAppRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCMProjectAppRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCMProjectAppRelaEN GetObjByCMProjectAppRelaId(long lngCMProjectAppRelaId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
 objvCMProjectAppRelaEN.CMProjectAppRelaId = Int32.Parse(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID(字段类型:char,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCMProjectAppRelaEN.ApplicationTypeId = Int32.Parse(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id(字段类型:char,字段长度:6,是否可空:False)
 objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvCMProjectAppRelaEN.OrderNum = Int32.Parse(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvCMProjectAppRelaEN.AppIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetObjByCMProjectAppRelaId)", objException.Message));
}
return objvCMProjectAppRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCMProjectAppRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
strSQL = "Select * from vCMProjectAppRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN()
{
CMProjectAppRelaId = TransNullToInt(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()), //Cm工程应用关系Id
PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(), //工程ID
PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(), //工程名称
Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(), //说明
UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(), //修改日期
ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(), //应用类型英文名
ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(), //CM工程名
ApplicationTypeId = TransNullToInt(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(), //CM工程Id
UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(), //修改者
OrderNum = TransNullToInt(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()), //序号
AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()), //AppOrderNum
AppIsVisible = TransNullToBool(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()) //AppIsVisible
};
objvCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectAppRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCMProjectAppRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetObjByDataRowvCMProjectAppRela)", objException.Message));
}
objvCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectAppRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCMProjectAppRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCMProjectAppRelaEN objvCMProjectAppRelaEN = new clsvCMProjectAppRelaEN();
try
{
objvCMProjectAppRelaEN.CMProjectAppRelaId = TransNullToInt(objRow[convCMProjectAppRela.CMProjectAppRelaId].ToString().Trim()); //Cm工程应用关系Id
objvCMProjectAppRelaEN.PrjId = objRow[convCMProjectAppRela.PrjId].ToString().Trim(); //工程ID
objvCMProjectAppRelaEN.PrjName = objRow[convCMProjectAppRela.PrjName].ToString().Trim(); //工程名称
objvCMProjectAppRelaEN.Memo = objRow[convCMProjectAppRela.Memo] == DBNull.Value ? null : objRow[convCMProjectAppRela.Memo].ToString().Trim(); //说明
objvCMProjectAppRelaEN.UpdDate = objRow[convCMProjectAppRela.UpdDate] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdDate].ToString().Trim(); //修改日期
objvCMProjectAppRelaEN.ApplicationTypeName = objRow[convCMProjectAppRela.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvCMProjectAppRelaEN.ApplicationTypeENName = objRow[convCMProjectAppRela.ApplicationTypeENName].ToString().Trim(); //应用类型英文名
objvCMProjectAppRelaEN.ApplicationTypeSimName = objRow[convCMProjectAppRela.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convCMProjectAppRela.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvCMProjectAppRelaEN.CmPrjName = objRow[convCMProjectAppRela.CmPrjName] == DBNull.Value ? null : objRow[convCMProjectAppRela.CmPrjName].ToString().Trim(); //CM工程名
objvCMProjectAppRelaEN.ApplicationTypeId = TransNullToInt(objRow[convCMProjectAppRela.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvCMProjectAppRelaEN.CmPrjId = objRow[convCMProjectAppRela.CmPrjId].ToString().Trim(); //CM工程Id
objvCMProjectAppRelaEN.UpdUser = objRow[convCMProjectAppRela.UpdUser] == DBNull.Value ? null : objRow[convCMProjectAppRela.UpdUser].ToString().Trim(); //修改者
objvCMProjectAppRelaEN.OrderNum = TransNullToInt(objRow[convCMProjectAppRela.OrderNum].ToString().Trim()); //序号
objvCMProjectAppRelaEN.AppOrderNum = objRow[convCMProjectAppRela.AppOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCMProjectAppRela.AppOrderNum].ToString().Trim()); //AppOrderNum
objvCMProjectAppRelaEN.AppIsVisible = TransNullToBool(objRow[convCMProjectAppRela.AppIsVisible].ToString().Trim()); //AppIsVisible
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCMProjectAppRelaDA: GetObjByDataRow)", objException.Message));
}
objvCMProjectAppRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCMProjectAppRelaEN;
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
objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectAppRelaEN._CurrTabName, convCMProjectAppRela.CMProjectAppRelaId, 8, "");
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
objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCMProjectAppRelaEN._CurrTabName, convCMProjectAppRela.CMProjectAppRelaId, 8, strPrefix);
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from vCMProjectAppRela where " + strCondition;
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CMProjectAppRelaId from vCMProjectAppRela where " + strCondition;
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
 /// <param name = "lngCMProjectAppRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngCMProjectAppRelaId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProjectAppRela", "CMProjectAppRelaId = " + ""+ lngCMProjectAppRelaId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCMProjectAppRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCMProjectAppRela", strCondition))
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
objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCMProjectAppRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaENS">源对象</param>
 /// <param name = "objvCMProjectAppRelaENT">目标对象</param>
public void CopyTo(clsvCMProjectAppRelaEN objvCMProjectAppRelaENS, clsvCMProjectAppRelaEN objvCMProjectAppRelaENT)
{
objvCMProjectAppRelaENT.CMProjectAppRelaId = objvCMProjectAppRelaENS.CMProjectAppRelaId; //Cm工程应用关系Id
objvCMProjectAppRelaENT.PrjId = objvCMProjectAppRelaENS.PrjId; //工程ID
objvCMProjectAppRelaENT.PrjName = objvCMProjectAppRelaENS.PrjName; //工程名称
objvCMProjectAppRelaENT.Memo = objvCMProjectAppRelaENS.Memo; //说明
objvCMProjectAppRelaENT.UpdDate = objvCMProjectAppRelaENS.UpdDate; //修改日期
objvCMProjectAppRelaENT.ApplicationTypeName = objvCMProjectAppRelaENS.ApplicationTypeName; //应用程序类型名称
objvCMProjectAppRelaENT.ApplicationTypeENName = objvCMProjectAppRelaENS.ApplicationTypeENName; //应用类型英文名
objvCMProjectAppRelaENT.ApplicationTypeSimName = objvCMProjectAppRelaENS.ApplicationTypeSimName; //应用程序类型简称
objvCMProjectAppRelaENT.CmPrjName = objvCMProjectAppRelaENS.CmPrjName; //CM工程名
objvCMProjectAppRelaENT.ApplicationTypeId = objvCMProjectAppRelaENS.ApplicationTypeId; //应用程序类型ID
objvCMProjectAppRelaENT.CmPrjId = objvCMProjectAppRelaENS.CmPrjId; //CM工程Id
objvCMProjectAppRelaENT.UpdUser = objvCMProjectAppRelaENS.UpdUser; //修改者
objvCMProjectAppRelaENT.OrderNum = objvCMProjectAppRelaENS.OrderNum; //序号
objvCMProjectAppRelaENT.AppOrderNum = objvCMProjectAppRelaENS.AppOrderNum; //AppOrderNum
objvCMProjectAppRelaENT.AppIsVisible = objvCMProjectAppRelaENS.AppIsVisible; //AppIsVisible
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.PrjId, 4, convCMProjectAppRela.PrjId);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.PrjName, 30, convCMProjectAppRela.PrjName);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.Memo, 1000, convCMProjectAppRela.Memo);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.UpdDate, 20, convCMProjectAppRela.UpdDate);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.ApplicationTypeName, 30, convCMProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.ApplicationTypeENName, 30, convCMProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.ApplicationTypeSimName, 30, convCMProjectAppRela.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.CmPrjName, 50, convCMProjectAppRela.CmPrjName);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.CmPrjId, 6, convCMProjectAppRela.CmPrjId);
clsCheckSql.CheckFieldLen(objvCMProjectAppRelaEN.UpdUser, 20, convCMProjectAppRela.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.PrjId, convCMProjectAppRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.PrjName, convCMProjectAppRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.Memo, convCMProjectAppRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.UpdDate, convCMProjectAppRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.ApplicationTypeName, convCMProjectAppRela.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.ApplicationTypeENName, convCMProjectAppRela.ApplicationTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.ApplicationTypeSimName, convCMProjectAppRela.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.CmPrjName, convCMProjectAppRela.CmPrjName);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.CmPrjId, convCMProjectAppRela.CmPrjId);
clsCheckSql.CheckSqlInjection4Field(objvCMProjectAppRelaEN.UpdUser, convCMProjectAppRela.UpdUser);
//检查外键字段长度
 objvCMProjectAppRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vCMProjectAppRela(vCMProjectAppRela),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvCMProjectAppRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvCMProjectAppRelaEN objvCMProjectAppRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objvCMProjectAppRelaEN.ApplicationTypeId);
 sbCondition.AppendFormat(" and CmPrjId = '{0}'", objvCMProjectAppRelaEN.CmPrjId);
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectAppRelaEN._CurrTabName);
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCMProjectAppRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvCMProjectAppRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}