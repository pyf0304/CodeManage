
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoResCaseQuantitySenateItemsDA
 表名:vVideoResCaseQuantitySenateItems(01120447)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:02
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频资源库(VideoResLib)
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
 /// v视频资源量化评价详细(vVideoResCaseQuantitySenateItems)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvVideoResCaseQuantitySenateItemsDA : clsCommBase4DA
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
 return clsvVideoResCaseQuantitySenateItemsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvVideoResCaseQuantitySenateItemsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvVideoResCaseQuantitySenateItemsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvVideoResCaseQuantitySenateItemsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvVideoResCaseQuantitySenateItemsEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vVideoResCaseQuantitySenateItems(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable_vVideoResCaseQuantitySenateItems)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseQuantitySenateItems.* from vVideoResCaseQuantitySenateItems Left Join {1} on {2} where {3} and vVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem not in (Select top {5} vVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {2} IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {3} IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vVideoResCaseQuantitySenateItems.* from vVideoResCaseQuantitySenateItems Left Join {1} on {2} where {3} and vVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem not in (Select top {5} vVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {2} IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vVideoResCaseQuantitySenateItems where {1} and IdmicroteachCaseQuantitySenateItem not in (Select top {3} IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA:GetObjLst)", objException.Message));
}
List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = new List<clsvVideoResCaseQuantitySenateItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN();
try
{
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateItemsEN.UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateItemsEN.CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateItemsEN.CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateItemsEN.SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateItemsEN.SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateItemsEN.SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateItemsEN.SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateItemsEN.UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsEN.UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateItemsEN.UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvVideoResCaseQuantitySenateItemsEN.GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvVideoResCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvVideoResCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvVideoResCaseQuantitySenateItemsEN.UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseQuantitySenateItemsEN.UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetObjLst)", objException.Message));
}
objvVideoResCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseQuantitySenateItemsEN);
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
public List<clsvVideoResCaseQuantitySenateItemsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvVideoResCaseQuantitySenateItemsEN> arrObjLst = new List<clsvVideoResCaseQuantitySenateItemsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN();
try
{
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateItemsEN.UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateItemsEN.CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateItemsEN.CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateItemsEN.SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateItemsEN.SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateItemsEN.SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateItemsEN.SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateItemsEN.UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsEN.UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateItemsEN.UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvVideoResCaseQuantitySenateItemsEN.GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvVideoResCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvVideoResCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvVideoResCaseQuantitySenateItemsEN.UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseQuantitySenateItemsEN.UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetObjLst)", objException.Message));
}
objvVideoResCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvVideoResCaseQuantitySenateItemsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvVideoResCaseQuantitySenateItems(ref clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where IdmicroteachCaseQuantitySenateItem = " + ""+ objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objDT.Rows[0][convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeID = objDT.Rows[0][convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CourseId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateContent = objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.SenateDate = objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTime = objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateIp = objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserKindId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserKindName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objDT.Rows[0][convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.GridTitle = objDT.Rows[0][convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objDT.Rows[0][convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objDT.Rows[0][convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerNum = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objDT.Rows[0][convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = TransNullToFloat(objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = TransNullToInt(objDT.Rows[0][convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objDT.Rows[0][convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objDT.Rows[0][convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objDT.Rows[0][convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UpdDate = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UpdUser = objDT.Rows[0][convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetvVideoResCaseQuantitySenateItems)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">表关键字</param>
 /// <returns>表对象</returns>
public clsvVideoResCaseQuantitySenateItemsEN GetObjByIdmicroteachCaseQuantitySenateItem(long lngIdmicroteachCaseQuantitySenateItem)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where IdmicroteachCaseQuantitySenateItem = " + ""+ lngIdmicroteachCaseQuantitySenateItem+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN();
try
{
 objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = Int32.Parse(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号(字段类型:bigint,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.SenateScore = Single.Parse(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder(字段类型:varchar,字段长度:204,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID(字段类型:char,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数(字段类型:float,字段长度:8,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明(字段类型:varchar,字段长度:2000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号(字段类型:int,字段长度:4,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IsAccess = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.IsAccessC = clsEntityBase2.TransNullToBool_S(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC(字段类型:bit,字段长度:1,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvVideoResCaseQuantitySenateItemsEN.UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetObjByIdmicroteachCaseQuantitySenateItem)", objException.Message));
}
return objvVideoResCaseQuantitySenateItemsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvVideoResCaseQuantitySenateItemsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
strSQL = "Select * from vVideoResCaseQuantitySenateItems where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN()
{
IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()), //微格量化评价指标流水号
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(), //视频资源案例ID
VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(), //视频资源案例名称
IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(), //评议类型名称
UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(), //用户ID
IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(), //学院名称
CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(), //课程Id
SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(), //评价时间
IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(), //功能模块Id
SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(), //评议Ip
UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(), //用户类型名称
UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(), //用户名
UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(), //用户类别Id
UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(), //用户类别名
IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(), //专业流水号
CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(), //学院名称简写
SenateScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()), //指标得分
IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(), //量表指标流水号
senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(), //量表指标ID
senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(), //量表指标名称
senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(), //量表指标说明
senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()), //量表指标权重
AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(), //答案类型ID
GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(), //表格标题
QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()), //题目序号
senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(), //题目编号
QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(), //题目类型Id
senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(), //答案类型名
AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(), //答案模式名称
senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(), //备注
QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()), //答案数
senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(), //量表指标名称WithOrder
IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(), //量表指标子项流水号
senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(), //量表指标子项ID
senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(), //量表指标子项名称
senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()), //量表指标子项分数
senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(), //量表指标子项说明
AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(), //答案标题
AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()), //问答序号
senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(), //量表指标子项备注
IsAccess = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()), //IsAccess
IsAccessC = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()), //IsAccessC
UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim() //修改人
};
objvVideoResCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateItemsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseQuantitySenateItemsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN();
try
{
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateItemsEN.UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateItemsEN.CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateItemsEN.CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateItemsEN.SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateItemsEN.SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateItemsEN.SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateItemsEN.SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateItemsEN.UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsEN.UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateItemsEN.UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvVideoResCaseQuantitySenateItemsEN.GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvVideoResCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvVideoResCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvVideoResCaseQuantitySenateItemsEN.UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseQuantitySenateItemsEN.UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetObjByDataRowvVideoResCaseQuantitySenateItems)", objException.Message));
}
objvVideoResCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateItemsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvVideoResCaseQuantitySenateItemsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN = new clsvVideoResCaseQuantitySenateItemsEN();
try
{
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenateItem = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem].ToString().Trim()); //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseID].ToString().Trim(); //视频资源案例ID
objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName = objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.VideoResCaseName].ToString().Trim(); //视频资源案例名称
objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType = objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName = objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvVideoResCaseQuantitySenateItemsEN.UserId = objRow[convVideoResCaseQuantitySenateItems.UserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserId].ToString().Trim(); //用户ID
objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase = objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeID = objRow[convVideoResCaseQuantitySenateItems.CollegeID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeID].ToString().Trim(); //学院ID
objvVideoResCaseQuantitySenateItemsEN.CollegeName = objRow[convVideoResCaseQuantitySenateItems.CollegeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeName].ToString().Trim(); //学院名称
objvVideoResCaseQuantitySenateItemsEN.CourseId = objRow[convVideoResCaseQuantitySenateItems.CourseId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CourseId].ToString().Trim(); //课程Id
objvVideoResCaseQuantitySenateItemsEN.SenateTheme = objRow[convVideoResCaseQuantitySenateItems.SenateTheme] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTheme].ToString().Trim(); //量化评价主题
objvVideoResCaseQuantitySenateItemsEN.SenateContent = objRow[convVideoResCaseQuantitySenateItems.SenateContent] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateContent].ToString().Trim(); //评价内容
objvVideoResCaseQuantitySenateItemsEN.SenateTotalScore = objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateTotalScore].ToString().Trim()); //评价分数
objvVideoResCaseQuantitySenateItemsEN.SenateDate = objRow[convVideoResCaseQuantitySenateItems.SenateDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateDate].ToString().Trim(); //评价日期
objvVideoResCaseQuantitySenateItemsEN.SenateTime = objRow[convVideoResCaseQuantitySenateItems.SenateTime] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateTime].ToString().Trim(); //评价时间
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsEN.FuncModuleName = objRow[convVideoResCaseQuantitySenateItems.FuncModuleName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleName].ToString().Trim(); //功能模块名称
objvVideoResCaseQuantitySenateItemsEN.FuncModuleId = objRow[convVideoResCaseQuantitySenateItems.FuncModuleId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.FuncModuleId].ToString().Trim(); //功能模块Id
objvVideoResCaseQuantitySenateItemsEN.SenateIp = objRow[convVideoResCaseQuantitySenateItems.SenateIp] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.SenateIp].ToString().Trim(); //评议Ip
objvVideoResCaseQuantitySenateItemsEN.UserTypeName = objRow[convVideoResCaseQuantitySenateItems.UserTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserTypeName].ToString().Trim(); //用户类型名称
objvVideoResCaseQuantitySenateItemsEN.UserName = objRow[convVideoResCaseQuantitySenateItems.UserName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserName].ToString().Trim(); //用户名
objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId = objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsEN.UserKindId = objRow[convVideoResCaseQuantitySenateItems.UserKindId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindId].ToString().Trim(); //用户类别Id
objvVideoResCaseQuantitySenateItemsEN.UserKindName = objRow[convVideoResCaseQuantitySenateItems.UserKindName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UserKindName].ToString().Trim(); //用户类别名
objvVideoResCaseQuantitySenateItemsEN.IdXzCollege = objRow[convVideoResCaseQuantitySenateItems.IdXzCollege] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzCollege].ToString().Trim(); //学院流水号
objvVideoResCaseQuantitySenateItemsEN.IdXzMajor = objRow[convVideoResCaseQuantitySenateItems.IdXzMajor] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.IdXzMajor].ToString().Trim(); //专业流水号
objvVideoResCaseQuantitySenateItemsEN.CollegeNameA = objRow[convVideoResCaseQuantitySenateItems.CollegeNameA] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.CollegeNameA].ToString().Trim(); //学院名称简写
objvVideoResCaseQuantitySenateItemsEN.SenateScore = TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.SenateScore].ToString().Trim()); //指标得分
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeItem].ToString().Trim(); //量表指标流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemID].ToString().Trim(); //量表指标ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemName].ToString().Trim(); //量表指标名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemDesc].ToString().Trim(); //量表指标说明
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemWeight = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemWeight].ToString().Trim()); //量表指标权重
objvVideoResCaseQuantitySenateItemsEN.AnswerModeId = objRow[convVideoResCaseQuantitySenateItems.AnswerModeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeId].ToString().Trim(); //答案模式Id
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeId].ToString().Trim(); //答案类型ID
objvVideoResCaseQuantitySenateItemsEN.GridTitle = objRow[convVideoResCaseQuantitySenateItems.GridTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.GridTitle].ToString().Trim(); //表格标题
objvVideoResCaseQuantitySenateItemsEN.QuestionIndex = objRow[convVideoResCaseQuantitySenateItems.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.QuestionIndex].ToString().Trim()); //题目序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvVideoResCaseQuantitySenateItemsEN.QuestionNo = objRow[convVideoResCaseQuantitySenateItems.QuestionNo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionNo].ToString().Trim(); //题目编号
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeId].ToString().Trim(); //题目类型Id
objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionTtlScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName = objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTypeName].ToString().Trim(); //答案类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerModeName = objRow[convVideoResCaseQuantitySenateItems.AnswerModeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerModeName].ToString().Trim(); //答案模式名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemMemo].ToString().Trim(); //备注
objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName = objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.QuestionTypeName].ToString().Trim(); //题目类型名
objvVideoResCaseQuantitySenateItemsEN.AnswerNum = objRow[convVideoResCaseQuantitySenateItems.AnswerNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerNum].ToString().Trim()); //答案数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder = objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder].ToString().Trim(); //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem = objRow[convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem].ToString().Trim(); //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemID].ToString().Trim(); //量表指标子项ID
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemName].ToString().Trim(); //量表指标子项名称
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemScore = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemScore].ToString().Trim()); //量表指标子项分数
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc].ToString().Trim(); //量表指标子项说明
objvVideoResCaseQuantitySenateItemsEN.AnswerTitle = objRow[convVideoResCaseQuantitySenateItems.AnswerTitle] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.AnswerTitle].ToString().Trim(); //答案标题
objvVideoResCaseQuantitySenateItemsEN.AnswerIndex = objRow[convVideoResCaseQuantitySenateItems.AnswerIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convVideoResCaseQuantitySenateItems.AnswerIndex].ToString().Trim()); //问答序号
objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo = objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo].ToString().Trim(); //量表指标子项备注
objvVideoResCaseQuantitySenateItemsEN.IsAccess = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccess].ToString().Trim()); //IsAccess
objvVideoResCaseQuantitySenateItemsEN.IsAccessC = TransNullToBool(objRow[convVideoResCaseQuantitySenateItems.IsAccessC].ToString().Trim()); //IsAccessC
objvVideoResCaseQuantitySenateItemsEN.UpdDate = objRow[convVideoResCaseQuantitySenateItems.UpdDate] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdDate].ToString().Trim(); //修改日期
objvVideoResCaseQuantitySenateItemsEN.UpdUser = objRow[convVideoResCaseQuantitySenateItems.UpdUser] == DBNull.Value ? null : objRow[convVideoResCaseQuantitySenateItems.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA: GetObjByDataRow)", objException.Message));
}
objvVideoResCaseQuantitySenateItemsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvVideoResCaseQuantitySenateItemsEN;
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
objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseQuantitySenateItemsEN._CurrTabName, convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, 8, "");
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
objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvVideoResCaseQuantitySenateItemsEN._CurrTabName, convVideoResCaseQuantitySenateItems.IdmicroteachCaseQuantitySenateItem, 8, strPrefix);
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where " + strCondition;
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenateItem from vVideoResCaseQuantitySenateItems where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenateItem">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenateItem)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseQuantitySenateItems", "IdmicroteachCaseQuantitySenateItem = " + ""+ lngIdmicroteachCaseQuantitySenateItem+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvVideoResCaseQuantitySenateItemsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vVideoResCaseQuantitySenateItems", strCondition))
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
objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vVideoResCaseQuantitySenateItems");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvVideoResCaseQuantitySenateItemsENS">源对象</param>
 /// <param name = "objvVideoResCaseQuantitySenateItemsENT">目标对象</param>
public void CopyTo(clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsENS, clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsENT)
{
objvVideoResCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenateItem = objvVideoResCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenateItem; //微格量化评价指标流水号
objvVideoResCaseQuantitySenateItemsENT.IdmicroteachCaseQuantitySenate = objvVideoResCaseQuantitySenateItemsENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvVideoResCaseQuantitySenateItemsENT.VideoResCaseID = objvVideoResCaseQuantitySenateItemsENS.VideoResCaseID; //视频资源案例ID
objvVideoResCaseQuantitySenateItemsENT.VideoResCaseName = objvVideoResCaseQuantitySenateItemsENS.VideoResCaseName; //视频资源案例名称
objvVideoResCaseQuantitySenateItemsENT.IdAppraiseType = objvVideoResCaseQuantitySenateItemsENS.IdAppraiseType; //评议类型流水号
objvVideoResCaseQuantitySenateItemsENT.AppraiseTypeName = objvVideoResCaseQuantitySenateItemsENS.AppraiseTypeName; //评议类型名称
objvVideoResCaseQuantitySenateItemsENT.UserId = objvVideoResCaseQuantitySenateItemsENS.UserId; //用户ID
objvVideoResCaseQuantitySenateItemsENT.IdMicroteachCase = objvVideoResCaseQuantitySenateItemsENS.IdMicroteachCase; //微格教学案例流水号
objvVideoResCaseQuantitySenateItemsENT.CollegeID = objvVideoResCaseQuantitySenateItemsENS.CollegeID; //学院ID
objvVideoResCaseQuantitySenateItemsENT.CollegeName = objvVideoResCaseQuantitySenateItemsENS.CollegeName; //学院名称
objvVideoResCaseQuantitySenateItemsENT.CourseId = objvVideoResCaseQuantitySenateItemsENS.CourseId; //课程Id
objvVideoResCaseQuantitySenateItemsENT.SenateTheme = objvVideoResCaseQuantitySenateItemsENS.SenateTheme; //量化评价主题
objvVideoResCaseQuantitySenateItemsENT.SenateContent = objvVideoResCaseQuantitySenateItemsENS.SenateContent; //评价内容
objvVideoResCaseQuantitySenateItemsENT.SenateTotalScore = objvVideoResCaseQuantitySenateItemsENS.SenateTotalScore; //评价分数
objvVideoResCaseQuantitySenateItemsENT.SenateDate = objvVideoResCaseQuantitySenateItemsENS.SenateDate; //评价日期
objvVideoResCaseQuantitySenateItemsENT.SenateTime = objvVideoResCaseQuantitySenateItemsENS.SenateTime; //评价时间
objvVideoResCaseQuantitySenateItemsENT.IdSenateGaugeVersion = objvVideoResCaseQuantitySenateItemsENS.IdSenateGaugeVersion; //评价量表版本流水号
objvVideoResCaseQuantitySenateItemsENT.FuncModuleName = objvVideoResCaseQuantitySenateItemsENS.FuncModuleName; //功能模块名称
objvVideoResCaseQuantitySenateItemsENT.FuncModuleId = objvVideoResCaseQuantitySenateItemsENS.FuncModuleId; //功能模块Id
objvVideoResCaseQuantitySenateItemsENT.SenateIp = objvVideoResCaseQuantitySenateItemsENS.SenateIp; //评议Ip
objvVideoResCaseQuantitySenateItemsENT.UserTypeName = objvVideoResCaseQuantitySenateItemsENS.UserTypeName; //用户类型名称
objvVideoResCaseQuantitySenateItemsENT.UserName = objvVideoResCaseQuantitySenateItemsENS.UserName; //用户名
objvVideoResCaseQuantitySenateItemsENT.UserNameWithUserId = objvVideoResCaseQuantitySenateItemsENS.UserNameWithUserId; //UserNameWithUserId
objvVideoResCaseQuantitySenateItemsENT.UserKindId = objvVideoResCaseQuantitySenateItemsENS.UserKindId; //用户类别Id
objvVideoResCaseQuantitySenateItemsENT.UserKindName = objvVideoResCaseQuantitySenateItemsENS.UserKindName; //用户类别名
objvVideoResCaseQuantitySenateItemsENT.IdXzCollege = objvVideoResCaseQuantitySenateItemsENS.IdXzCollege; //学院流水号
objvVideoResCaseQuantitySenateItemsENT.IdXzMajor = objvVideoResCaseQuantitySenateItemsENS.IdXzMajor; //专业流水号
objvVideoResCaseQuantitySenateItemsENT.CollegeNameA = objvVideoResCaseQuantitySenateItemsENS.CollegeNameA; //学院名称简写
objvVideoResCaseQuantitySenateItemsENT.SenateScore = objvVideoResCaseQuantitySenateItemsENS.SenateScore; //指标得分
objvVideoResCaseQuantitySenateItemsENT.IdSenateGaugeItem = objvVideoResCaseQuantitySenateItemsENS.IdSenateGaugeItem; //量表指标流水号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemID; //量表指标ID
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemName; //量表指标名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionName; //评价量表版本名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemDesc = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemDesc; //量表指标说明
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemWeight = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemWeight; //量表指标权重
objvVideoResCaseQuantitySenateItemsENT.AnswerModeId = objvVideoResCaseQuantitySenateItemsENS.AnswerModeId; //答案模式Id
objvVideoResCaseQuantitySenateItemsENT.AnswerTypeId = objvVideoResCaseQuantitySenateItemsENS.AnswerTypeId; //答案类型ID
objvVideoResCaseQuantitySenateItemsENT.GridTitle = objvVideoResCaseQuantitySenateItemsENS.GridTitle; //表格标题
objvVideoResCaseQuantitySenateItemsENT.QuestionIndex = objvVideoResCaseQuantitySenateItemsENS.QuestionIndex; //题目序号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionID; //评价量表版本ID
objvVideoResCaseQuantitySenateItemsENT.QuestionNo = objvVideoResCaseQuantitySenateItemsENS.QuestionNo; //题目编号
objvVideoResCaseQuantitySenateItemsENT.QuestionTypeId = objvVideoResCaseQuantitySenateItemsENS.QuestionTypeId; //题目类型Id
objvVideoResCaseQuantitySenateItemsENT.senateGaugeVersionTtlScore = objvVideoResCaseQuantitySenateItemsENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvVideoResCaseQuantitySenateItemsENT.AnswerTypeName = objvVideoResCaseQuantitySenateItemsENS.AnswerTypeName; //答案类型名
objvVideoResCaseQuantitySenateItemsENT.AnswerModeName = objvVideoResCaseQuantitySenateItemsENS.AnswerModeName; //答案模式名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemMemo = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemMemo; //备注
objvVideoResCaseQuantitySenateItemsENT.QuestionTypeName = objvVideoResCaseQuantitySenateItemsENS.QuestionTypeName; //题目类型名
objvVideoResCaseQuantitySenateItemsENT.AnswerNum = objvVideoResCaseQuantitySenateItemsENS.AnswerNum; //答案数
objvVideoResCaseQuantitySenateItemsENT.senateGaugeItemNameWithOrder = objvVideoResCaseQuantitySenateItemsENS.senateGaugeItemNameWithOrder; //量表指标名称WithOrder
objvVideoResCaseQuantitySenateItemsENT.IdSenateGaugeSubItem = objvVideoResCaseQuantitySenateItemsENS.IdSenateGaugeSubItem; //量表指标子项流水号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemID = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemID; //量表指标子项ID
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemName = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemName; //量表指标子项名称
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemScore = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemScore; //量表指标子项分数
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemDesc = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemDesc; //量表指标子项说明
objvVideoResCaseQuantitySenateItemsENT.AnswerTitle = objvVideoResCaseQuantitySenateItemsENS.AnswerTitle; //答案标题
objvVideoResCaseQuantitySenateItemsENT.AnswerIndex = objvVideoResCaseQuantitySenateItemsENS.AnswerIndex; //问答序号
objvVideoResCaseQuantitySenateItemsENT.senateGaugeSubItemMemo = objvVideoResCaseQuantitySenateItemsENS.senateGaugeSubItemMemo; //量表指标子项备注
objvVideoResCaseQuantitySenateItemsENT.IsAccess = objvVideoResCaseQuantitySenateItemsENS.IsAccess; //IsAccess
objvVideoResCaseQuantitySenateItemsENT.IsAccessC = objvVideoResCaseQuantitySenateItemsENS.IsAccessC; //IsAccessC
objvVideoResCaseQuantitySenateItemsENT.UpdDate = objvVideoResCaseQuantitySenateItemsENS.UpdDate; //修改日期
objvVideoResCaseQuantitySenateItemsENT.UpdUser = objvVideoResCaseQuantitySenateItemsENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvVideoResCaseQuantitySenateItemsEN objvVideoResCaseQuantitySenateItemsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID, 8, convVideoResCaseQuantitySenateItems.VideoResCaseID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName, 100, convVideoResCaseQuantitySenateItems.VideoResCaseName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType, 4, convVideoResCaseQuantitySenateItems.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName, 50, convVideoResCaseQuantitySenateItems.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserId, 18, convVideoResCaseQuantitySenateItems.UserId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase, 8, convVideoResCaseQuantitySenateItems.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.CollegeID, 4, convVideoResCaseQuantitySenateItems.CollegeID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.CollegeName, 100, convVideoResCaseQuantitySenateItems.CollegeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.CourseId, 8, convVideoResCaseQuantitySenateItems.CourseId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.SenateTheme, 200, convVideoResCaseQuantitySenateItems.SenateTheme);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.SenateContent, 2000, convVideoResCaseQuantitySenateItems.SenateContent);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.SenateDate, 8, convVideoResCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.SenateTime, 6, convVideoResCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion, 4, convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.FuncModuleName, 30, convVideoResCaseQuantitySenateItems.FuncModuleName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.FuncModuleId, 4, convVideoResCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.SenateIp, 50, convVideoResCaseQuantitySenateItems.SenateIp);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserTypeName, 20, convVideoResCaseQuantitySenateItems.UserTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserName, 30, convVideoResCaseQuantitySenateItems.UserName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId, 51, convVideoResCaseQuantitySenateItems.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserKindId, 2, convVideoResCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UserKindName, 30, convVideoResCaseQuantitySenateItems.UserKindName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdXzCollege, 4, convVideoResCaseQuantitySenateItems.IdXzCollege);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdXzMajor, 8, convVideoResCaseQuantitySenateItems.IdXzMajor);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.CollegeNameA, 12, convVideoResCaseQuantitySenateItems.CollegeNameA);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem, 4, convVideoResCaseQuantitySenateItems.IdSenateGaugeItem);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName, 200, convVideoResCaseQuantitySenateItems.senateGaugeItemName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName, 200, convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc, 2000, convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AnswerModeId, 4, convVideoResCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId, 2, convVideoResCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.GridTitle, 30, convVideoResCaseQuantitySenateItems.GridTitle);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID, 4, convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.QuestionNo, 10, convVideoResCaseQuantitySenateItems.QuestionNo);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId, 2, convVideoResCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName, 50, convVideoResCaseQuantitySenateItems.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AnswerModeName, 30, convVideoResCaseQuantitySenateItems.AnswerModeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo, 1000, convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName, 20, convVideoResCaseQuantitySenateItems.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder, 204, convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem, 4, convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID, 4, convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName, 200, convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc, 2000, convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.AnswerTitle, 20, convVideoResCaseQuantitySenateItems.AnswerTitle);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo, 1000, convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UpdDate, 20, convVideoResCaseQuantitySenateItems.UpdDate);
clsCheckSql.CheckFieldLen(objvVideoResCaseQuantitySenateItemsEN.UpdUser, 20, convVideoResCaseQuantitySenateItems.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.VideoResCaseID, convVideoResCaseQuantitySenateItems.VideoResCaseID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.VideoResCaseName, convVideoResCaseQuantitySenateItems.VideoResCaseName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdAppraiseType, convVideoResCaseQuantitySenateItems.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AppraiseTypeName, convVideoResCaseQuantitySenateItems.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserId, convVideoResCaseQuantitySenateItems.UserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdMicroteachCase, convVideoResCaseQuantitySenateItems.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.CollegeID, convVideoResCaseQuantitySenateItems.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.CollegeName, convVideoResCaseQuantitySenateItems.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.CourseId, convVideoResCaseQuantitySenateItems.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.SenateTheme, convVideoResCaseQuantitySenateItems.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.SenateContent, convVideoResCaseQuantitySenateItems.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.SenateDate, convVideoResCaseQuantitySenateItems.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.SenateTime, convVideoResCaseQuantitySenateItems.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeVersion, convVideoResCaseQuantitySenateItems.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.FuncModuleName, convVideoResCaseQuantitySenateItems.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.FuncModuleId, convVideoResCaseQuantitySenateItems.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.SenateIp, convVideoResCaseQuantitySenateItems.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserTypeName, convVideoResCaseQuantitySenateItems.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserName, convVideoResCaseQuantitySenateItems.UserName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserNameWithUserId, convVideoResCaseQuantitySenateItems.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserKindId, convVideoResCaseQuantitySenateItems.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UserKindName, convVideoResCaseQuantitySenateItems.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdXzCollege, convVideoResCaseQuantitySenateItems.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdXzMajor, convVideoResCaseQuantitySenateItems.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.CollegeNameA, convVideoResCaseQuantitySenateItems.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeItem, convVideoResCaseQuantitySenateItems.IdSenateGaugeItem);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemID, convVideoResCaseQuantitySenateItems.senateGaugeItemID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemName, convVideoResCaseQuantitySenateItems.senateGaugeItemName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionName, convVideoResCaseQuantitySenateItems.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemDesc, convVideoResCaseQuantitySenateItems.senateGaugeItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AnswerModeId, convVideoResCaseQuantitySenateItems.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AnswerTypeId, convVideoResCaseQuantitySenateItems.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.GridTitle, convVideoResCaseQuantitySenateItems.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeVersionID, convVideoResCaseQuantitySenateItems.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.QuestionNo, convVideoResCaseQuantitySenateItems.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.QuestionTypeId, convVideoResCaseQuantitySenateItems.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AnswerTypeName, convVideoResCaseQuantitySenateItems.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AnswerModeName, convVideoResCaseQuantitySenateItems.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemMemo, convVideoResCaseQuantitySenateItems.senateGaugeItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.QuestionTypeName, convVideoResCaseQuantitySenateItems.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeItemNameWithOrder, convVideoResCaseQuantitySenateItems.senateGaugeItemNameWithOrder);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.IdSenateGaugeSubItem, convVideoResCaseQuantitySenateItems.IdSenateGaugeSubItem);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemID, convVideoResCaseQuantitySenateItems.senateGaugeSubItemID);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemName, convVideoResCaseQuantitySenateItems.senateGaugeSubItemName);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemDesc, convVideoResCaseQuantitySenateItems.senateGaugeSubItemDesc);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.AnswerTitle, convVideoResCaseQuantitySenateItems.AnswerTitle);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.senateGaugeSubItemMemo, convVideoResCaseQuantitySenateItems.senateGaugeSubItemMemo);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UpdDate, convVideoResCaseQuantitySenateItems.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvVideoResCaseQuantitySenateItemsEN.UpdUser, convVideoResCaseQuantitySenateItems.UpdUser);
//检查外键字段长度
 objvVideoResCaseQuantitySenateItemsEN._IsCheckProperty = true;
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseQuantitySenateItemsEN._CurrTabName);
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvVideoResCaseQuantitySenateItemsEN._CurrTabName, strCondition);
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
 objSQL = clsvVideoResCaseQuantitySenateItemsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}