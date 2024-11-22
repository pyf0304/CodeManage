
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceTypeDA
 表名:ResourceType(01120089)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:04:07
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:资源管理(ResourceMan)
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
using ExamLib.Entity;

namespace ExamLib.DAL
{
 /// <summary>
 /// 资源类型(ResourceType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsResourceTypeDA : clsCommBase4DA
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
 return clsResourceTypeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsResourceTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResourceTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsResourceTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsResourceTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdResourceType">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdResourceType)
{
strIdResourceType = strIdResourceType.Replace("'", "''");
if (strIdResourceType.Length > 4)
{
throw new Exception("(errid:Data000001)在表:ResourceType中,检查关键字,长度不正确!(clsResourceTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdResourceType)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ResourceType中,关键字不能为空 或 null!(clsResourceTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResourceType);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsResourceTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ResourceType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable_ResourceType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ResourceType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ResourceType.* from ResourceType Left Join {1} on {2} where {3} and ResourceType.IdResourceType not in (Select top {5} ResourceType.IdResourceType from ResourceType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1} and IdResourceType not in (Select top {2} IdResourceType from ResourceType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1} and IdResourceType not in (Select top {3} IdResourceType from ResourceType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsResourceTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ResourceType.* from ResourceType Left Join {1} on {2} where {3} and ResourceType.IdResourceType not in (Select top {5} ResourceType.IdResourceType from ResourceType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1} and IdResourceType not in (Select top {2} IdResourceType from ResourceType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ResourceType where {1} and IdResourceType not in (Select top {3} IdResourceType from ResourceType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsResourceTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsResourceTypeDA:GetObjLst)", objException.Message));
}
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = TransNullToBool(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResourceTypeDA: GetObjLst)", objException.Message));
}
objResourceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResourceTypeEN);
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
public List<clsResourceTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsResourceTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsResourceTypeEN> arrObjLst = new List<clsResourceTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = TransNullToBool(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResourceTypeDA: GetObjLst)", objException.Message));
}
objResourceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResourceTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetResourceType(ref clsResourceTypeEN objResourceTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where IdResourceType = " + "'"+ objResourceTypeEN.IdResourceType+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objResourceTypeEN.IdResourceType = objDT.Rows[0][conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objResourceTypeEN.ResourceTypeID = objDT.Rows[0][conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objResourceTypeEN.ResourceTypeName = objDT.Rows[0][conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objResourceTypeEN.ResourceTypeENName = objDT.Rows[0][conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objResourceTypeEN.FileExtentNameLst = objDT.Rows[0][conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表(字段类型:varchar,字段长度:200,是否可空:True)
 objResourceTypeEN.FileExtentNameLst2 = objDT.Rows[0][conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2(字段类型:varchar,字段长度:200,是否可空:True)
 objResourceTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conResourceType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objResourceTypeEN.IsUse = TransNullToBool(objDT.Rows[0][conResourceType.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objResourceTypeEN.Memo = objDT.Rows[0][conResourceType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsResourceTypeDA: GetResourceType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdResourceType">表关键字</param>
 /// <returns>表对象</returns>
public clsResourceTypeEN GetObjByIdResourceType(string strIdResourceType)
{
CheckPrimaryKey(strIdResourceType);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where IdResourceType = " + "'"+ strIdResourceType+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
 objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表(字段类型:varchar,字段长度:200,是否可空:True)
 objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2(字段类型:varchar,字段长度:200,是否可空:True)
 objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conResourceType.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objResourceTypeEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsResourceTypeDA: GetObjByIdResourceType)", objException.Message));
}
return objResourceTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsResourceTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsResourceTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN()
{
IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(), //ResourceTypeENName
FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(), //文件扩展名列表
FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(), //文件扩展名列表2
OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResourceType.OrderNum].ToString().Trim()), //序号
IsUse = TransNullToBool(objRow[conResourceType.IsUse].ToString().Trim()), //是否使用
Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim() //备注
};
objResourceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsResourceTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsResourceTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = TransNullToBool(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsResourceTypeDA: GetObjByDataRowResourceType)", objException.Message));
}
objResourceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsResourceTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResourceTypeEN objResourceTypeEN = new clsResourceTypeEN();
try
{
objResourceTypeEN.IdResourceType = objRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceTypeEN.ResourceTypeID = objRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objResourceTypeEN.ResourceTypeName = objRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objResourceTypeEN.ResourceTypeENName = objRow[conResourceType.ResourceTypeENName] == DBNull.Value ? null : objRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objResourceTypeEN.FileExtentNameLst = objRow[conResourceType.FileExtentNameLst] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objResourceTypeEN.FileExtentNameLst2 = objRow[conResourceType.FileExtentNameLst2] == DBNull.Value ? null : objRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objResourceTypeEN.OrderNum = objRow[conResourceType.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conResourceType.OrderNum].ToString().Trim()); //序号
objResourceTypeEN.IsUse = TransNullToBool(objRow[conResourceType.IsUse].ToString().Trim()); //是否使用
objResourceTypeEN.Memo = objRow[conResourceType.Memo] == DBNull.Value ? null : objRow[conResourceType.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsResourceTypeDA: GetObjByDataRow)", objException.Message));
}
objResourceTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceTypeEN;
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
objSQL = clsResourceTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResourceTypeEN._CurrTabName, conResourceType.IdResourceType, 4, "");
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
objSQL = clsResourceTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResourceTypeEN._CurrTabName, conResourceType.IdResourceType, 4, strPrefix);
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdResourceType from ResourceType where " + strCondition;
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdResourceType from ResourceType where " + strCondition;
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
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdResourceType)
{
CheckPrimaryKey(strIdResourceType);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ResourceType", "IdResourceType = " + "'"+ strIdResourceType+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsResourceTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ResourceType", strCondition))
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
objSQL = clsResourceTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ResourceType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsResourceTypeEN objResourceTypeEN)
 {
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ResourceType");
objRow = objDS.Tables["ResourceType"].NewRow();
objRow[conResourceType.IdResourceType] = objResourceTypeEN.IdResourceType; //资源类型流水号
objRow[conResourceType.ResourceTypeID] = objResourceTypeEN.ResourceTypeID; //资源类型ID
objRow[conResourceType.ResourceTypeName] = objResourceTypeEN.ResourceTypeName; //资源类型名称
 if (objResourceTypeEN.ResourceTypeENName !=  "")
 {
objRow[conResourceType.ResourceTypeENName] = objResourceTypeEN.ResourceTypeENName; //ResourceTypeENName
 }
 if (objResourceTypeEN.FileExtentNameLst !=  "")
 {
objRow[conResourceType.FileExtentNameLst] = objResourceTypeEN.FileExtentNameLst; //文件扩展名列表
 }
 if (objResourceTypeEN.FileExtentNameLst2 !=  "")
 {
objRow[conResourceType.FileExtentNameLst2] = objResourceTypeEN.FileExtentNameLst2; //文件扩展名列表2
 }
objRow[conResourceType.OrderNum] = objResourceTypeEN.OrderNum; //序号
objRow[conResourceType.IsUse] = objResourceTypeEN.IsUse; //是否使用
 if (objResourceTypeEN.Memo !=  "")
 {
objRow[conResourceType.Memo] = objResourceTypeEN.Memo; //备注
 }
objDS.Tables[clsResourceTypeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsResourceTypeEN._CurrTabName);
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResourceTypeEN objResourceTypeEN)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceTypeEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.IdResourceType);
 var strIdResourceType = objResourceTypeEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeID);
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeID + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeName);
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeENName);
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeENName + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst);
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst2);
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst2 + "'");
 }
 
 if (objResourceTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.OrderNum);
 arrValueListForInsert.Add(objResourceTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResourceType.IsUse);
 arrValueListForInsert.Add("'" + (objResourceTypeEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objResourceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.Memo);
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResourceType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResourceTypeEN objResourceTypeEN)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceTypeEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.IdResourceType);
 var strIdResourceType = objResourceTypeEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeID);
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeID + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeName);
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeENName);
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeENName + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst);
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst2);
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst2 + "'");
 }
 
 if (objResourceTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.OrderNum);
 arrValueListForInsert.Add(objResourceTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResourceType.IsUse);
 arrValueListForInsert.Add("'" + (objResourceTypeEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objResourceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.Memo);
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResourceType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objResourceTypeEN.IdResourceType;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResourceTypeEN objResourceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceTypeEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.IdResourceType);
 var strIdResourceType = objResourceTypeEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeID);
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeID + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeName);
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeENName);
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeENName + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst);
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst2);
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst2 + "'");
 }
 
 if (objResourceTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.OrderNum);
 arrValueListForInsert.Add(objResourceTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResourceType.IsUse);
 arrValueListForInsert.Add("'" + (objResourceTypeEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objResourceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.Memo);
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResourceType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objResourceTypeEN.IdResourceType;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResourceTypeEN objResourceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceTypeEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.IdResourceType);
 var strIdResourceType = objResourceTypeEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeID);
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeID + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeName);
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeName + "'");
 }
 
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.ResourceTypeENName);
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceTypeENName + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst);
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst + "'");
 }
 
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.FileExtentNameLst2);
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileExtentNameLst2 + "'");
 }
 
 if (objResourceTypeEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.OrderNum);
 arrValueListForInsert.Add(objResourceTypeEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conResourceType.IsUse);
 arrValueListForInsert.Add("'" + (objResourceTypeEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objResourceTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResourceType.Memo);
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ResourceType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewResourceTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where IdResourceType = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ResourceType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdResourceType = oRow[conResourceType.IdResourceType].ToString().Trim();
if (IsExist(strIdResourceType))
{
 string strResult = "关键字变量值为:" + string.Format("IdResourceType = {0}", strIdResourceType) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsResourceTypeEN._CurrTabName ].NewRow();
objRow[conResourceType.IdResourceType] = oRow[conResourceType.IdResourceType].ToString().Trim(); //资源类型流水号
objRow[conResourceType.ResourceTypeID] = oRow[conResourceType.ResourceTypeID].ToString().Trim(); //资源类型ID
objRow[conResourceType.ResourceTypeName] = oRow[conResourceType.ResourceTypeName].ToString().Trim(); //资源类型名称
objRow[conResourceType.ResourceTypeENName] = oRow[conResourceType.ResourceTypeENName].ToString().Trim(); //ResourceTypeENName
objRow[conResourceType.FileExtentNameLst] = oRow[conResourceType.FileExtentNameLst].ToString().Trim(); //文件扩展名列表
objRow[conResourceType.FileExtentNameLst2] = oRow[conResourceType.FileExtentNameLst2].ToString().Trim(); //文件扩展名列表2
objRow[conResourceType.OrderNum] = oRow[conResourceType.OrderNum].ToString().Trim(); //序号
objRow[conResourceType.IsUse] = oRow[conResourceType.IsUse].ToString().Trim(); //是否使用
objRow[conResourceType.Memo] = oRow[conResourceType.Memo].ToString().Trim(); //备注
 objDS.Tables[clsResourceTypeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsResourceTypeEN._CurrTabName);
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
 /// <param name = "objResourceTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsResourceTypeEN objResourceTypeEN)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
strSQL = "Select * from ResourceType where IdResourceType = " + "'"+ objResourceTypeEN.IdResourceType+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsResourceTypeEN._CurrTabName);
if (objDS.Tables[clsResourceTypeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdResourceType = " + "'"+ objResourceTypeEN.IdResourceType+"'");
return false;
}
objRow = objDS.Tables[clsResourceTypeEN._CurrTabName].Rows[0];
 if (objResourceTypeEN.IsUpdated(conResourceType.IdResourceType))
 {
objRow[conResourceType.IdResourceType] = objResourceTypeEN.IdResourceType; //资源类型流水号
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeID))
 {
objRow[conResourceType.ResourceTypeID] = objResourceTypeEN.ResourceTypeID; //资源类型ID
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeName))
 {
objRow[conResourceType.ResourceTypeName] = objResourceTypeEN.ResourceTypeName; //资源类型名称
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeENName))
 {
objRow[conResourceType.ResourceTypeENName] = objResourceTypeEN.ResourceTypeENName; //ResourceTypeENName
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst))
 {
objRow[conResourceType.FileExtentNameLst] = objResourceTypeEN.FileExtentNameLst; //文件扩展名列表
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst2))
 {
objRow[conResourceType.FileExtentNameLst2] = objResourceTypeEN.FileExtentNameLst2; //文件扩展名列表2
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.OrderNum))
 {
objRow[conResourceType.OrderNum] = objResourceTypeEN.OrderNum; //序号
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.IsUse))
 {
objRow[conResourceType.IsUse] = objResourceTypeEN.IsUse; //是否使用
 }
 if (objResourceTypeEN.IsUpdated(conResourceType.Memo))
 {
objRow[conResourceType.Memo] = objResourceTypeEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsResourceTypeEN._CurrTabName);
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResourceTypeEN objResourceTypeEN)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ResourceType Set ");
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeID))
 {
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeID, conResourceType.ResourceTypeID); //资源类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeID); //资源类型ID
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeName))
 {
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeName, conResourceType.ResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeName); //资源类型名称
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeENName))
 {
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeENName, conResourceType.ResourceTypeENName); //ResourceTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeENName); //ResourceTypeENName
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst))
 {
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileExtentNameLst, conResourceType.FileExtentNameLst); //文件扩展名列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.FileExtentNameLst); //文件扩展名列表
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst2))
 {
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileExtentNameLst2, conResourceType.FileExtentNameLst2); //文件扩展名列表2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.FileExtentNameLst2); //文件扩展名列表2
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.OrderNum))
 {
 if (objResourceTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResourceTypeEN.OrderNum, conResourceType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.OrderNum); //序号
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResourceTypeEN.IsUse == true?"1":"0", conResourceType.IsUse); //是否使用
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.Memo))
 {
 if (objResourceTypeEN.Memo !=  null)
 {
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResourceType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdResourceType = '{0}'", objResourceTypeEN.IdResourceType); 
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsResourceTypeEN objResourceTypeEN, string strCondition)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResourceType Set ");
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeID))
 {
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeID = '{0}',", strResourceTypeID); //资源类型ID
 }
 else
 {
 sbSQL.Append(" ResourceTypeID = null,"); //资源类型ID
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeName))
 {
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeName = '{0}',", strResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.Append(" ResourceTypeName = null,"); //资源类型名称
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeENName))
 {
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeENName = '{0}',", strResourceTypeENName); //ResourceTypeENName
 }
 else
 {
 sbSQL.Append(" ResourceTypeENName = null,"); //ResourceTypeENName
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst))
 {
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileExtentNameLst = '{0}',", strFileExtentNameLst); //文件扩展名列表
 }
 else
 {
 sbSQL.Append(" FileExtentNameLst = null,"); //文件扩展名列表
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst2))
 {
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileExtentNameLst2 = '{0}',", strFileExtentNameLst2); //文件扩展名列表2
 }
 else
 {
 sbSQL.Append(" FileExtentNameLst2 = null,"); //文件扩展名列表2
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.OrderNum))
 {
 if (objResourceTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResourceTypeEN.OrderNum, conResourceType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.OrderNum); //序号
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objResourceTypeEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.Memo))
 {
 if (objResourceTypeEN.Memo !=  null)
 {
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objResourceTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsResourceTypeEN objResourceTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResourceType Set ");
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeID))
 {
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeID = '{0}',", strResourceTypeID); //资源类型ID
 }
 else
 {
 sbSQL.Append(" ResourceTypeID = null,"); //资源类型ID
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeName))
 {
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeName = '{0}',", strResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.Append(" ResourceTypeName = null,"); //资源类型名称
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeENName))
 {
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceTypeENName = '{0}',", strResourceTypeENName); //ResourceTypeENName
 }
 else
 {
 sbSQL.Append(" ResourceTypeENName = null,"); //ResourceTypeENName
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst))
 {
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileExtentNameLst = '{0}',", strFileExtentNameLst); //文件扩展名列表
 }
 else
 {
 sbSQL.Append(" FileExtentNameLst = null,"); //文件扩展名列表
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst2))
 {
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileExtentNameLst2 = '{0}',", strFileExtentNameLst2); //文件扩展名列表2
 }
 else
 {
 sbSQL.Append(" FileExtentNameLst2 = null,"); //文件扩展名列表2
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.OrderNum))
 {
 if (objResourceTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResourceTypeEN.OrderNum, conResourceType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.OrderNum); //序号
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objResourceTypeEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.Memo))
 {
 if (objResourceTypeEN.Memo !=  null)
 {
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objResourceTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResourceTypeEN objResourceTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objResourceTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ResourceType Set ");
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeID))
 {
 if (objResourceTypeEN.ResourceTypeID !=  null)
 {
 var strResourceTypeID = objResourceTypeEN.ResourceTypeID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeID, conResourceType.ResourceTypeID); //资源类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeID); //资源类型ID
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeName))
 {
 if (objResourceTypeEN.ResourceTypeName !=  null)
 {
 var strResourceTypeName = objResourceTypeEN.ResourceTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeName, conResourceType.ResourceTypeName); //资源类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeName); //资源类型名称
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.ResourceTypeENName))
 {
 if (objResourceTypeEN.ResourceTypeENName !=  null)
 {
 var strResourceTypeENName = objResourceTypeEN.ResourceTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceTypeENName, conResourceType.ResourceTypeENName); //ResourceTypeENName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.ResourceTypeENName); //ResourceTypeENName
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst))
 {
 if (objResourceTypeEN.FileExtentNameLst !=  null)
 {
 var strFileExtentNameLst = objResourceTypeEN.FileExtentNameLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileExtentNameLst, conResourceType.FileExtentNameLst); //文件扩展名列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.FileExtentNameLst); //文件扩展名列表
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.FileExtentNameLst2))
 {
 if (objResourceTypeEN.FileExtentNameLst2 !=  null)
 {
 var strFileExtentNameLst2 = objResourceTypeEN.FileExtentNameLst2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileExtentNameLst2, conResourceType.FileExtentNameLst2); //文件扩展名列表2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.FileExtentNameLst2); //文件扩展名列表2
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.OrderNum))
 {
 if (objResourceTypeEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objResourceTypeEN.OrderNum, conResourceType.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.OrderNum); //序号
 }
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResourceTypeEN.IsUse == true?"1":"0", conResourceType.IsUse); //是否使用
 }
 
 if (objResourceTypeEN.IsUpdated(conResourceType.Memo))
 {
 if (objResourceTypeEN.Memo !=  null)
 {
 var strMemo = objResourceTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResourceType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResourceType.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdResourceType = '{0}'", objResourceTypeEN.IdResourceType); 
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
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdResourceType) 
{
CheckPrimaryKey(strIdResourceType);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdResourceType,
};
 objSQL.ExecSP("ResourceType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdResourceType, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdResourceType);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
//删除ResourceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResourceType where IdResourceType = " + "'"+ strIdResourceType+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelResourceType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
//删除ResourceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResourceType where IdResourceType in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdResourceType">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdResourceType) 
{
CheckPrimaryKey(strIdResourceType);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
//删除ResourceType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ResourceType where IdResourceType = " + "'"+ strIdResourceType+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelResourceType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsResourceTypeDA: DelResourceType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ResourceType where " + strCondition ;
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
public bool DelResourceTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsResourceTypeDA: DelResourceTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ResourceType where " + strCondition ;
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
 /// <param name = "objResourceTypeENS">源对象</param>
 /// <param name = "objResourceTypeENT">目标对象</param>
public void CopyTo(clsResourceTypeEN objResourceTypeENS, clsResourceTypeEN objResourceTypeENT)
{
objResourceTypeENT.IdResourceType = objResourceTypeENS.IdResourceType; //资源类型流水号
objResourceTypeENT.ResourceTypeID = objResourceTypeENS.ResourceTypeID; //资源类型ID
objResourceTypeENT.ResourceTypeName = objResourceTypeENS.ResourceTypeName; //资源类型名称
objResourceTypeENT.ResourceTypeENName = objResourceTypeENS.ResourceTypeENName; //ResourceTypeENName
objResourceTypeENT.FileExtentNameLst = objResourceTypeENS.FileExtentNameLst; //文件扩展名列表
objResourceTypeENT.FileExtentNameLst2 = objResourceTypeENS.FileExtentNameLst2; //文件扩展名列表2
objResourceTypeENT.OrderNum = objResourceTypeENS.OrderNum; //序号
objResourceTypeENT.IsUse = objResourceTypeENS.IsUse; //是否使用
objResourceTypeENT.Memo = objResourceTypeENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsResourceTypeEN objResourceTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objResourceTypeEN.ResourceTypeID, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldNotNull(objResourceTypeEN.ResourceTypeName, conResourceType.ResourceTypeName);
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceTypeEN.IdResourceType, 4, conResourceType.IdResourceType);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeID, 4, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeName, 50, conResourceType.ResourceTypeName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeENName, 50, conResourceType.ResourceTypeENName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst, 200, conResourceType.FileExtentNameLst);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst2, 200, conResourceType.FileExtentNameLst2);
clsCheckSql.CheckFieldLen(objResourceTypeEN.Memo, 1000, conResourceType.Memo);
//检查字段外键固定长度
 objResourceTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsResourceTypeEN objResourceTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeID, 4, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeName, 50, conResourceType.ResourceTypeName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeENName, 50, conResourceType.ResourceTypeENName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst, 200, conResourceType.FileExtentNameLst);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst2, 200, conResourceType.FileExtentNameLst2);
clsCheckSql.CheckFieldLen(objResourceTypeEN.Memo, 1000, conResourceType.Memo);
//检查外键字段长度
 objResourceTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsResourceTypeEN objResourceTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceTypeEN.IdResourceType, 4, conResourceType.IdResourceType);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeID, 4, conResourceType.ResourceTypeID);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeName, 50, conResourceType.ResourceTypeName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.ResourceTypeENName, 50, conResourceType.ResourceTypeENName);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst, 200, conResourceType.FileExtentNameLst);
clsCheckSql.CheckFieldLen(objResourceTypeEN.FileExtentNameLst2, 200, conResourceType.FileExtentNameLst2);
clsCheckSql.CheckFieldLen(objResourceTypeEN.Memo, 1000, conResourceType.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.IdResourceType, conResourceType.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.ResourceTypeID, conResourceType.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.ResourceTypeName, conResourceType.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.ResourceTypeENName, conResourceType.ResourceTypeENName);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.FileExtentNameLst, conResourceType.FileExtentNameLst);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.FileExtentNameLst2, conResourceType.FileExtentNameLst2);
clsCheckSql.CheckSqlInjection4Field(objResourceTypeEN.Memo, conResourceType.Memo);
//检查外键字段长度
 objResourceTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdResourceType()
{
//获取某学院所有专业信息
string strSQL = "select IdResourceType, ResourceTypeName from ResourceType ";
 clsSpecSQLforSql mySql = clsResourceTypeDA.GetSpecSQLObj();
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResourceTypeEN._CurrTabName);
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResourceTypeEN._CurrTabName, strCondition);
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
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
 objSQL = clsResourceTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}