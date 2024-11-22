
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFriendLinkDA
 表名:FriendLink(01120439)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:09:10
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:链接管理(LinkManage)
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
 /// 友情链接(FriendLink)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFriendLinkDA : clsCommBase4DA
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
 return clsFriendLinkEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFriendLinkEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFriendLinkEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFriendLinkEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFriendLinkEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FriendLink(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable_FriendLink)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FriendLink where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FriendLink.* from FriendLink Left Join {1} on {2} where {3} and FriendLink.FriendLinkId not in (Select top {5} FriendLink.FriendLinkId from FriendLink Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1} and FriendLinkId not in (Select top {2} FriendLinkId from FriendLink where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1} and FriendLinkId not in (Select top {3} FriendLinkId from FriendLink where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFriendLinkDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} FriendLink.* from FriendLink Left Join {1} on {2} where {3} and FriendLink.FriendLinkId not in (Select top {5} FriendLink.FriendLinkId from FriendLink Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1} and FriendLinkId not in (Select top {2} FriendLinkId from FriendLink where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FriendLink where {1} and FriendLinkId not in (Select top {3} FriendLinkId from FriendLink where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFriendLinkEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFriendLinkDA:GetObjLst)", objException.Message));
}
List<clsFriendLinkEN> arrObjLst = new List<clsFriendLinkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN();
try
{
objFriendLinkEN.FriendLinkId = TransNullToInt(objRow[conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id
objFriendLinkEN.LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id
objFriendLinkEN.FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名
objFriendLinkEN.FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址
objFriendLinkEN.IsMark = TransNullToBool(objRow[conFriendLink.IsMark].ToString().Trim()); //是否启用
objFriendLinkEN.ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl
objFriendLinkEN.LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId
objFriendLinkEN.IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号
objFriendLinkEN.UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期
objFriendLinkEN.UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id
objFriendLinkEN.Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFriendLinkDA: GetObjLst)", objException.Message));
}
objFriendLinkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFriendLinkEN);
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
public List<clsFriendLinkEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFriendLinkDA:GetObjLstByTabName)", objException.Message));
}
List<clsFriendLinkEN> arrObjLst = new List<clsFriendLinkEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN();
try
{
objFriendLinkEN.FriendLinkId = TransNullToInt(objRow[conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id
objFriendLinkEN.LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id
objFriendLinkEN.FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名
objFriendLinkEN.FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址
objFriendLinkEN.IsMark = TransNullToBool(objRow[conFriendLink.IsMark].ToString().Trim()); //是否启用
objFriendLinkEN.ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl
objFriendLinkEN.LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId
objFriendLinkEN.IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号
objFriendLinkEN.UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期
objFriendLinkEN.UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id
objFriendLinkEN.Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFriendLinkDA: GetObjLst)", objException.Message));
}
objFriendLinkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFriendLinkEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFriendLink(ref clsFriendLinkEN objFriendLinkEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where FriendLinkId = " + ""+ objFriendLinkEN.FriendLinkId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFriendLinkEN.FriendLinkId = TransNullToInt(objDT.Rows[0][conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFriendLinkEN.LinkCategoriesId = objDT.Rows[0][conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id(字段类型:char,字段长度:2,是否可空:True)
 objFriendLinkEN.FriendLinkName = objDT.Rows[0][conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名(字段类型:varchar,字段长度:100,是否可空:True)
 objFriendLinkEN.FriendLinkUrl = objDT.Rows[0][conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址(字段类型:varchar,字段长度:500,是否可空:True)
 objFriendLinkEN.IsMark = TransNullToBool(objDT.Rows[0][conFriendLink.IsMark].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objFriendLinkEN.ImageUrl = objDT.Rows[0][conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objFriendLinkEN.LinkTypeId = objDT.Rows[0][conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId(字段类型:char,字段长度:4,是否可空:True)
 objFriendLinkEN.IdXzMajor = objDT.Rows[0][conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objFriendLinkEN.UpdDate = objDT.Rows[0][conFriendLink.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFriendLinkEN.UpdUserId = objDT.Rows[0][conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objFriendLinkEN.Memo = objDT.Rows[0][conFriendLink.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFriendLinkDA: GetFriendLink)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngFriendLinkId">表关键字</param>
 /// <returns>表对象</returns>
public clsFriendLinkEN GetObjByFriendLinkId(long lngFriendLinkId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where FriendLinkId = " + ""+ lngFriendLinkId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN();
try
{
 objFriendLinkEN.FriendLinkId = Int32.Parse(objRow[conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id(字段类型:bigint,字段长度:8,是否可空:True)
 objFriendLinkEN.LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id(字段类型:char,字段长度:2,是否可空:True)
 objFriendLinkEN.FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名(字段类型:varchar,字段长度:100,是否可空:True)
 objFriendLinkEN.FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址(字段类型:varchar,字段长度:500,是否可空:True)
 objFriendLinkEN.IsMark = clsEntityBase2.TransNullToBool_S(objRow[conFriendLink.IsMark].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objFriendLinkEN.ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl(字段类型:varchar,字段长度:100,是否可空:True)
 objFriendLinkEN.LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId(字段类型:char,字段长度:4,是否可空:True)
 objFriendLinkEN.IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objFriendLinkEN.UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFriendLinkEN.UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objFriendLinkEN.Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFriendLinkDA: GetObjByFriendLinkId)", objException.Message));
}
return objFriendLinkEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFriendLinkEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFriendLinkDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN()
{
FriendLinkId = TransNullToInt(objRow[conFriendLink.FriendLinkId].ToString().Trim()), //友情链接Id
LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(), //链接分类Id
FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(), //友情链接名
FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(), //友情链接地址
IsMark = TransNullToBool(objRow[conFriendLink.IsMark].ToString().Trim()), //是否启用
ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(), //ImageUrl
LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(), //LinkTypeId
IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(), //专业流水号
UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim() //备注
};
objFriendLinkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFriendLinkEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFriendLinkDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFriendLinkEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN();
try
{
objFriendLinkEN.FriendLinkId = TransNullToInt(objRow[conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id
objFriendLinkEN.LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id
objFriendLinkEN.FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名
objFriendLinkEN.FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址
objFriendLinkEN.IsMark = TransNullToBool(objRow[conFriendLink.IsMark].ToString().Trim()); //是否启用
objFriendLinkEN.ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl
objFriendLinkEN.LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId
objFriendLinkEN.IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号
objFriendLinkEN.UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期
objFriendLinkEN.UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id
objFriendLinkEN.Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFriendLinkDA: GetObjByDataRowFriendLink)", objException.Message));
}
objFriendLinkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFriendLinkEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFriendLinkEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFriendLinkEN objFriendLinkEN = new clsFriendLinkEN();
try
{
objFriendLinkEN.FriendLinkId = TransNullToInt(objRow[conFriendLink.FriendLinkId].ToString().Trim()); //友情链接Id
objFriendLinkEN.LinkCategoriesId = objRow[conFriendLink.LinkCategoriesId] == DBNull.Value ? null : objRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id
objFriendLinkEN.FriendLinkName = objRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名
objFriendLinkEN.FriendLinkUrl = objRow[conFriendLink.FriendLinkUrl] == DBNull.Value ? null : objRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址
objFriendLinkEN.IsMark = TransNullToBool(objRow[conFriendLink.IsMark].ToString().Trim()); //是否启用
objFriendLinkEN.ImageUrl = objRow[conFriendLink.ImageUrl] == DBNull.Value ? null : objRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl
objFriendLinkEN.LinkTypeId = objRow[conFriendLink.LinkTypeId] == DBNull.Value ? null : objRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId
objFriendLinkEN.IdXzMajor = objRow[conFriendLink.IdXzMajor] == DBNull.Value ? null : objRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号
objFriendLinkEN.UpdDate = objRow[conFriendLink.UpdDate] == DBNull.Value ? null : objRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期
objFriendLinkEN.UpdUserId = objRow[conFriendLink.UpdUserId] == DBNull.Value ? null : objRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id
objFriendLinkEN.Memo = objRow[conFriendLink.Memo] == DBNull.Value ? null : objRow[conFriendLink.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFriendLinkDA: GetObjByDataRow)", objException.Message));
}
objFriendLinkEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFriendLinkEN;
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
objSQL = clsFriendLinkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFriendLinkEN._CurrTabName, conFriendLink.FriendLinkId, 8, "");
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
objSQL = clsFriendLinkDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFriendLinkEN._CurrTabName, conFriendLink.FriendLinkId, 8, strPrefix);
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FriendLinkId from FriendLink where " + strCondition;
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FriendLinkId from FriendLink where " + strCondition;
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
 /// <param name = "lngFriendLinkId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngFriendLinkId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FriendLink", "FriendLinkId = " + ""+ lngFriendLinkId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFriendLinkDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FriendLink", strCondition))
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
objSQL = clsFriendLinkDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FriendLink");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFriendLinkEN objFriendLinkEN)
 {
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFriendLinkEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FriendLink");
objRow = objDS.Tables["FriendLink"].NewRow();
 if (objFriendLinkEN.LinkCategoriesId !=  "")
 {
objRow[conFriendLink.LinkCategoriesId] = objFriendLinkEN.LinkCategoriesId; //链接分类Id
 }
objRow[conFriendLink.FriendLinkName] = objFriendLinkEN.FriendLinkName; //友情链接名
 if (objFriendLinkEN.FriendLinkUrl !=  "")
 {
objRow[conFriendLink.FriendLinkUrl] = objFriendLinkEN.FriendLinkUrl; //友情链接地址
 }
objRow[conFriendLink.IsMark] = objFriendLinkEN.IsMark; //是否启用
 if (objFriendLinkEN.ImageUrl !=  "")
 {
objRow[conFriendLink.ImageUrl] = objFriendLinkEN.ImageUrl; //ImageUrl
 }
 if (objFriendLinkEN.LinkTypeId !=  "")
 {
objRow[conFriendLink.LinkTypeId] = objFriendLinkEN.LinkTypeId; //LinkTypeId
 }
 if (objFriendLinkEN.IdXzMajor !=  "")
 {
objRow[conFriendLink.IdXzMajor] = objFriendLinkEN.IdXzMajor; //专业流水号
 }
 if (objFriendLinkEN.UpdDate !=  "")
 {
objRow[conFriendLink.UpdDate] = objFriendLinkEN.UpdDate; //修改日期
 }
 if (objFriendLinkEN.UpdUserId !=  "")
 {
objRow[conFriendLink.UpdUserId] = objFriendLinkEN.UpdUserId; //修改用户Id
 }
 if (objFriendLinkEN.Memo !=  "")
 {
objRow[conFriendLink.Memo] = objFriendLinkEN.Memo; //备注
 }
objDS.Tables[clsFriendLinkEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFriendLinkEN._CurrTabName);
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
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFriendLinkEN objFriendLinkEN)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFriendLinkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkCategoriesId);
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkCategoriesId + "'");
 }
 
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkName);
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkName + "'");
 }
 
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkUrl);
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFriendLink.IsMark);
 arrValueListForInsert.Add("'" + (objFriendLinkEN.IsMark  ==  false ? "0" : "1") + "'");
 
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.ImageUrl);
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkTypeId);
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkTypeId + "'");
 }
 
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.IdXzMajor);
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objFriendLinkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdDate);
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdUserId);
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFriendLinkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.Memo);
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FriendLink");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFriendLinkEN objFriendLinkEN)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFriendLinkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkCategoriesId);
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkCategoriesId + "'");
 }
 
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkName);
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkName + "'");
 }
 
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkUrl);
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFriendLink.IsMark);
 arrValueListForInsert.Add("'" + (objFriendLinkEN.IsMark  ==  false ? "0" : "1") + "'");
 
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.ImageUrl);
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkTypeId);
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkTypeId + "'");
 }
 
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.IdXzMajor);
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objFriendLinkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdDate);
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdUserId);
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFriendLinkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.Memo);
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FriendLink");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFriendLinkEN objFriendLinkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFriendLinkEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkCategoriesId);
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkCategoriesId + "'");
 }
 
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkName);
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkName + "'");
 }
 
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkUrl);
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFriendLink.IsMark);
 arrValueListForInsert.Add("'" + (objFriendLinkEN.IsMark  ==  false ? "0" : "1") + "'");
 
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.ImageUrl);
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkTypeId);
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkTypeId + "'");
 }
 
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.IdXzMajor);
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objFriendLinkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdDate);
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdUserId);
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFriendLinkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.Memo);
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FriendLink");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFriendLinkEN objFriendLinkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFriendLinkEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkCategoriesId);
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkCategoriesId + "'");
 }
 
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkName);
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkName + "'");
 }
 
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.FriendLinkUrl);
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFriendLinkUrl + "'");
 }
 
 arrFieldListForInsert.Add(conFriendLink.IsMark);
 arrValueListForInsert.Add("'" + (objFriendLinkEN.IsMark  ==  false ? "0" : "1") + "'");
 
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.ImageUrl);
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strImageUrl + "'");
 }
 
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.LinkTypeId);
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLinkTypeId + "'");
 }
 
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.IdXzMajor);
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objFriendLinkEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdDate);
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.UpdUserId);
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objFriendLinkEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFriendLink.Memo);
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FriendLink");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFriendLinks(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where FriendLinkId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FriendLink");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngFriendLinkId = TransNullToInt(oRow[conFriendLink.FriendLinkId].ToString().Trim());
if (IsExist(lngFriendLinkId))
{
 string strResult = "关键字变量值为:" + string.Format("FriendLinkId = {0}", lngFriendLinkId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFriendLinkEN._CurrTabName ].NewRow();
objRow[conFriendLink.LinkCategoriesId] = oRow[conFriendLink.LinkCategoriesId].ToString().Trim(); //链接分类Id
objRow[conFriendLink.FriendLinkName] = oRow[conFriendLink.FriendLinkName].ToString().Trim(); //友情链接名
objRow[conFriendLink.FriendLinkUrl] = oRow[conFriendLink.FriendLinkUrl].ToString().Trim(); //友情链接地址
objRow[conFriendLink.IsMark] = oRow[conFriendLink.IsMark].ToString().Trim(); //是否启用
objRow[conFriendLink.ImageUrl] = oRow[conFriendLink.ImageUrl].ToString().Trim(); //ImageUrl
objRow[conFriendLink.LinkTypeId] = oRow[conFriendLink.LinkTypeId].ToString().Trim(); //LinkTypeId
objRow[conFriendLink.IdXzMajor] = oRow[conFriendLink.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conFriendLink.UpdDate] = oRow[conFriendLink.UpdDate].ToString().Trim(); //修改日期
objRow[conFriendLink.UpdUserId] = oRow[conFriendLink.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conFriendLink.Memo] = oRow[conFriendLink.Memo].ToString().Trim(); //备注
 objDS.Tables[clsFriendLinkEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFriendLinkEN._CurrTabName);
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
 /// <param name = "objFriendLinkEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFriendLinkEN objFriendLinkEN)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFriendLinkEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
strSQL = "Select * from FriendLink where FriendLinkId = " + ""+ objFriendLinkEN.FriendLinkId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFriendLinkEN._CurrTabName);
if (objDS.Tables[clsFriendLinkEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FriendLinkId = " + ""+ objFriendLinkEN.FriendLinkId+"");
return false;
}
objRow = objDS.Tables[clsFriendLinkEN._CurrTabName].Rows[0];
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkCategoriesId))
 {
objRow[conFriendLink.LinkCategoriesId] = objFriendLinkEN.LinkCategoriesId; //链接分类Id
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkName))
 {
objRow[conFriendLink.FriendLinkName] = objFriendLinkEN.FriendLinkName; //友情链接名
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkUrl))
 {
objRow[conFriendLink.FriendLinkUrl] = objFriendLinkEN.FriendLinkUrl; //友情链接地址
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.IsMark))
 {
objRow[conFriendLink.IsMark] = objFriendLinkEN.IsMark; //是否启用
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.ImageUrl))
 {
objRow[conFriendLink.ImageUrl] = objFriendLinkEN.ImageUrl; //ImageUrl
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkTypeId))
 {
objRow[conFriendLink.LinkTypeId] = objFriendLinkEN.LinkTypeId; //LinkTypeId
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.IdXzMajor))
 {
objRow[conFriendLink.IdXzMajor] = objFriendLinkEN.IdXzMajor; //专业流水号
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdDate))
 {
objRow[conFriendLink.UpdDate] = objFriendLinkEN.UpdDate; //修改日期
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdUserId))
 {
objRow[conFriendLink.UpdUserId] = objFriendLinkEN.UpdUserId; //修改用户Id
 }
 if (objFriendLinkEN.IsUpdated(conFriendLink.Memo))
 {
objRow[conFriendLink.Memo] = objFriendLinkEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsFriendLinkEN._CurrTabName);
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
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFriendLinkEN objFriendLinkEN)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFriendLinkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FriendLink Set ");
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkCategoriesId))
 {
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkCategoriesId, conFriendLink.LinkCategoriesId); //链接分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.LinkCategoriesId); //链接分类Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkName))
 {
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFriendLinkName, conFriendLink.FriendLinkName); //友情链接名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.FriendLinkName); //友情链接名
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkUrl))
 {
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFriendLinkUrl, conFriendLink.FriendLinkUrl); //友情链接地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.FriendLinkUrl); //友情链接地址
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IsMark))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFriendLinkEN.IsMark == true?"1":"0", conFriendLink.IsMark); //是否启用
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.ImageUrl))
 {
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conFriendLink.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.ImageUrl); //ImageUrl
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkTypeId))
 {
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkTypeId, conFriendLink.LinkTypeId); //LinkTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.LinkTypeId); //LinkTypeId
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IdXzMajor))
 {
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conFriendLink.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.IdXzMajor); //专业流水号
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdDate))
 {
 if (objFriendLinkEN.UpdDate !=  null)
 {
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFriendLink.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.UpdDate); //修改日期
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdUserId))
 {
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conFriendLink.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.UpdUserId); //修改用户Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.Memo))
 {
 if (objFriendLinkEN.Memo !=  null)
 {
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFriendLink.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FriendLinkId = {0}", objFriendLinkEN.FriendLinkId); 
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
 /// <param name = "objFriendLinkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFriendLinkEN objFriendLinkEN, string strCondition)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFriendLinkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FriendLink Set ");
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkCategoriesId))
 {
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkCategoriesId = '{0}',", strLinkCategoriesId); //链接分类Id
 }
 else
 {
 sbSQL.Append(" LinkCategoriesId = null,"); //链接分类Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkName))
 {
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FriendLinkName = '{0}',", strFriendLinkName); //友情链接名
 }
 else
 {
 sbSQL.Append(" FriendLinkName = null,"); //友情链接名
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkUrl))
 {
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FriendLinkUrl = '{0}',", strFriendLinkUrl); //友情链接地址
 }
 else
 {
 sbSQL.Append(" FriendLinkUrl = null,"); //友情链接地址
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IsMark))
 {
 sbSQL.AppendFormat(" IsMark = '{0}',", objFriendLinkEN.IsMark == true?"1":"0"); //是否启用
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.ImageUrl))
 {
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkTypeId))
 {
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkTypeId = '{0}',", strLinkTypeId); //LinkTypeId
 }
 else
 {
 sbSQL.Append(" LinkTypeId = null,"); //LinkTypeId
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IdXzMajor))
 {
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdDate))
 {
 if (objFriendLinkEN.UpdDate !=  null)
 {
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdUserId))
 {
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.Memo))
 {
 if (objFriendLinkEN.Memo !=  null)
 {
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFriendLinkEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFriendLinkEN objFriendLinkEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFriendLinkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FriendLink Set ");
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkCategoriesId))
 {
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkCategoriesId = '{0}',", strLinkCategoriesId); //链接分类Id
 }
 else
 {
 sbSQL.Append(" LinkCategoriesId = null,"); //链接分类Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkName))
 {
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FriendLinkName = '{0}',", strFriendLinkName); //友情链接名
 }
 else
 {
 sbSQL.Append(" FriendLinkName = null,"); //友情链接名
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkUrl))
 {
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FriendLinkUrl = '{0}',", strFriendLinkUrl); //友情链接地址
 }
 else
 {
 sbSQL.Append(" FriendLinkUrl = null,"); //友情链接地址
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IsMark))
 {
 sbSQL.AppendFormat(" IsMark = '{0}',", objFriendLinkEN.IsMark == true?"1":"0"); //是否启用
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.ImageUrl))
 {
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ImageUrl = '{0}',", strImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.Append(" ImageUrl = null,"); //ImageUrl
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkTypeId))
 {
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LinkTypeId = '{0}',", strLinkTypeId); //LinkTypeId
 }
 else
 {
 sbSQL.Append(" LinkTypeId = null,"); //LinkTypeId
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IdXzMajor))
 {
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdDate))
 {
 if (objFriendLinkEN.UpdDate !=  null)
 {
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdUserId))
 {
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.Memo))
 {
 if (objFriendLinkEN.Memo !=  null)
 {
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objFriendLinkEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFriendLinkEN objFriendLinkEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFriendLinkEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFriendLinkEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFriendLinkEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FriendLink Set ");
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkCategoriesId))
 {
 if (objFriendLinkEN.LinkCategoriesId !=  null)
 {
 var strLinkCategoriesId = objFriendLinkEN.LinkCategoriesId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkCategoriesId, conFriendLink.LinkCategoriesId); //链接分类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.LinkCategoriesId); //链接分类Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkName))
 {
 if (objFriendLinkEN.FriendLinkName !=  null)
 {
 var strFriendLinkName = objFriendLinkEN.FriendLinkName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFriendLinkName, conFriendLink.FriendLinkName); //友情链接名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.FriendLinkName); //友情链接名
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.FriendLinkUrl))
 {
 if (objFriendLinkEN.FriendLinkUrl !=  null)
 {
 var strFriendLinkUrl = objFriendLinkEN.FriendLinkUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFriendLinkUrl, conFriendLink.FriendLinkUrl); //友情链接地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.FriendLinkUrl); //友情链接地址
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IsMark))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFriendLinkEN.IsMark == true?"1":"0", conFriendLink.IsMark); //是否启用
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.ImageUrl))
 {
 if (objFriendLinkEN.ImageUrl !=  null)
 {
 var strImageUrl = objFriendLinkEN.ImageUrl.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strImageUrl, conFriendLink.ImageUrl); //ImageUrl
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.ImageUrl); //ImageUrl
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.LinkTypeId))
 {
 if (objFriendLinkEN.LinkTypeId !=  null)
 {
 var strLinkTypeId = objFriendLinkEN.LinkTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLinkTypeId, conFriendLink.LinkTypeId); //LinkTypeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.LinkTypeId); //LinkTypeId
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.IdXzMajor))
 {
 if (objFriendLinkEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objFriendLinkEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conFriendLink.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.IdXzMajor); //专业流水号
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdDate))
 {
 if (objFriendLinkEN.UpdDate !=  null)
 {
 var strUpdDate = objFriendLinkEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFriendLink.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.UpdDate); //修改日期
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.UpdUserId))
 {
 if (objFriendLinkEN.UpdUserId !=  null)
 {
 var strUpdUserId = objFriendLinkEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conFriendLink.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.UpdUserId); //修改用户Id
 }
 }
 
 if (objFriendLinkEN.IsUpdated(conFriendLink.Memo))
 {
 if (objFriendLinkEN.Memo !=  null)
 {
 var strMemo = objFriendLinkEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFriendLink.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFriendLink.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FriendLinkId = {0}", objFriendLinkEN.FriendLinkId); 
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
 /// <param name = "lngFriendLinkId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngFriendLinkId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngFriendLinkId,
};
 objSQL.ExecSP("FriendLink_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngFriendLinkId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngFriendLinkId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
//删除FriendLink本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FriendLink where FriendLinkId = " + ""+ lngFriendLinkId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFriendLink(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
//删除FriendLink本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FriendLink where FriendLinkId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngFriendLinkId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngFriendLinkId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
//删除FriendLink本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FriendLink where FriendLinkId = " + ""+ lngFriendLinkId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFriendLink(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFriendLinkDA: DelFriendLink)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FriendLink where " + strCondition ;
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
public bool DelFriendLinkWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFriendLinkDA: DelFriendLinkWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FriendLink where " + strCondition ;
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
 /// <param name = "objFriendLinkENS">源对象</param>
 /// <param name = "objFriendLinkENT">目标对象</param>
public void CopyTo(clsFriendLinkEN objFriendLinkENS, clsFriendLinkEN objFriendLinkENT)
{
objFriendLinkENT.FriendLinkId = objFriendLinkENS.FriendLinkId; //友情链接Id
objFriendLinkENT.LinkCategoriesId = objFriendLinkENS.LinkCategoriesId; //链接分类Id
objFriendLinkENT.FriendLinkName = objFriendLinkENS.FriendLinkName; //友情链接名
objFriendLinkENT.FriendLinkUrl = objFriendLinkENS.FriendLinkUrl; //友情链接地址
objFriendLinkENT.IsMark = objFriendLinkENS.IsMark; //是否启用
objFriendLinkENT.ImageUrl = objFriendLinkENS.ImageUrl; //ImageUrl
objFriendLinkENT.LinkTypeId = objFriendLinkENS.LinkTypeId; //LinkTypeId
objFriendLinkENT.IdXzMajor = objFriendLinkENS.IdXzMajor; //专业流水号
objFriendLinkENT.UpdDate = objFriendLinkENS.UpdDate; //修改日期
objFriendLinkENT.UpdUserId = objFriendLinkENS.UpdUserId; //修改用户Id
objFriendLinkENT.Memo = objFriendLinkENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFriendLinkEN objFriendLinkEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFriendLinkEN.FriendLinkName, conFriendLink.FriendLinkName);
//检查字段长度
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkCategoriesId, 2, conFriendLink.LinkCategoriesId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkName, 100, conFriendLink.FriendLinkName);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkUrl, 500, conFriendLink.FriendLinkUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.ImageUrl, 100, conFriendLink.ImageUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkTypeId, 4, conFriendLink.LinkTypeId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.IdXzMajor, 8, conFriendLink.IdXzMajor);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdDate, 20, conFriendLink.UpdDate);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdUserId, 20, conFriendLink.UpdUserId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.Memo, 1000, conFriendLink.Memo);
//检查字段外键固定长度
 objFriendLinkEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFriendLinkEN objFriendLinkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkCategoriesId, 2, conFriendLink.LinkCategoriesId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkName, 100, conFriendLink.FriendLinkName);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkUrl, 500, conFriendLink.FriendLinkUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.ImageUrl, 100, conFriendLink.ImageUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkTypeId, 4, conFriendLink.LinkTypeId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.IdXzMajor, 8, conFriendLink.IdXzMajor);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdDate, 20, conFriendLink.UpdDate);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdUserId, 20, conFriendLink.UpdUserId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.Memo, 1000, conFriendLink.Memo);
//检查外键字段长度
 objFriendLinkEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFriendLinkEN objFriendLinkEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkCategoriesId, 2, conFriendLink.LinkCategoriesId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkName, 100, conFriendLink.FriendLinkName);
clsCheckSql.CheckFieldLen(objFriendLinkEN.FriendLinkUrl, 500, conFriendLink.FriendLinkUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.ImageUrl, 100, conFriendLink.ImageUrl);
clsCheckSql.CheckFieldLen(objFriendLinkEN.LinkTypeId, 4, conFriendLink.LinkTypeId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.IdXzMajor, 8, conFriendLink.IdXzMajor);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdDate, 20, conFriendLink.UpdDate);
clsCheckSql.CheckFieldLen(objFriendLinkEN.UpdUserId, 20, conFriendLink.UpdUserId);
clsCheckSql.CheckFieldLen(objFriendLinkEN.Memo, 1000, conFriendLink.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.LinkCategoriesId, conFriendLink.LinkCategoriesId);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.FriendLinkName, conFriendLink.FriendLinkName);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.FriendLinkUrl, conFriendLink.FriendLinkUrl);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.ImageUrl, conFriendLink.ImageUrl);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.LinkTypeId, conFriendLink.LinkTypeId);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.IdXzMajor, conFriendLink.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.UpdDate, conFriendLink.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.UpdUserId, conFriendLink.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objFriendLinkEN.Memo, conFriendLink.Memo);
//检查外键字段长度
 objFriendLinkEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FriendLink(友情链接),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFriendLinkEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFriendLinkEN objFriendLinkEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FriendLinkName = '{0}'", objFriendLinkEN.FriendLinkName);
 if (objFriendLinkEN.LinkCategoriesId == null)
{
 sbCondition.AppendFormat(" and LinkCategoriesId is null");
}
else
{
 sbCondition.AppendFormat(" and LinkCategoriesId = '{0}'", objFriendLinkEN.LinkCategoriesId);
}
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFriendLinkEN._CurrTabName);
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFriendLinkEN._CurrTabName, strCondition);
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
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
 objSQL = clsFriendLinkDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}