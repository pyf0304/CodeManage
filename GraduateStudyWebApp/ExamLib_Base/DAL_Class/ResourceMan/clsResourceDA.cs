
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsResourceDA
 表名:Resource(01120320)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:13:05
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
 /// 资源(Resource)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsResourceDA : clsCommBase4DA
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
 return clsResourceEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsResourceEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsResourceEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsResourceEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsResourceEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdResource">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdResource)
{
strIdResource = strIdResource.Replace("'", "''");
if (strIdResource.Length > 8)
{
throw new Exception("(errid:Data000001)在表:Resource中,检查关键字,长度不正确!(clsResourceDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdResource)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Resource中,关键字不能为空 或 null!(clsResourceDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdResource);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsResourceDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Resource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable_Resource)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsResourceDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Resource where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Resource.* from Resource Left Join {1} on {2} where {3} and Resource.IdResource not in (Select top {5} Resource.IdResource from Resource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1} and IdResource not in (Select top {2} IdResource from Resource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1} and IdResource not in (Select top {3} IdResource from Resource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsResourceDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Resource.* from Resource Left Join {1} on {2} where {3} and Resource.IdResource not in (Select top {5} Resource.IdResource from Resource Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1} and IdResource not in (Select top {2} IdResource from Resource where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Resource where {1} and IdResource not in (Select top {3} IdResource from Resource where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsResourceEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsResourceDA:GetObjLst)", objException.Message));
}
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = TransNullToBool(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResourceDA: GetObjLst)", objException.Message));
}
objResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResourceEN);
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
public List<clsResourceEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsResourceDA:GetObjLstByTabName)", objException.Message));
}
List<clsResourceEN> arrObjLst = new List<clsResourceEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = TransNullToBool(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsResourceDA: GetObjLst)", objException.Message));
}
objResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objResourceEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objResourceEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetResource(ref clsResourceEN objResourceEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where IdResource = " + "'"+ objResourceEN.IdResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objResourceEN.IdResource = objDT.Rows[0][conResource.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objResourceEN.ResourceID = objDT.Rows[0][conResource.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objResourceEN.ResourceName = objDT.Rows[0][conResource.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objResourceEN.SaveMode = TransNullToBool(objDT.Rows[0][conResource.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objResourceEN.IdFtpResource = objDT.Rows[0][conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objResourceEN.IdFile = objDT.Rows[0][conResource.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objResourceEN.IdResourceType = objDT.Rows[0][conResource.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objResourceEN.UpdDate = objDT.Rows[0][conResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objResourceEN.UpdTime = objDT.Rows[0][conResource.UpdTime].ToString().Trim(); //UpdTime(字段类型:varchar,字段长度:6,是否可空:True)
 objResourceEN.Memo = objDT.Rows[0][conResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objResourceEN.FuncModuleId = objDT.Rows[0][conResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objResourceEN.CheckDate = objDT.Rows[0][conResource.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objResourceEN.CheckUser = objDT.Rows[0][conResource.CheckUser].ToString().Trim(); //检查用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objResourceEN.CheckResult = objDT.Rows[0][conResource.CheckResult].ToString().Trim(); //检查结果(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsResourceDA: GetResource)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdResource">表关键字</param>
 /// <returns>表对象</returns>
public clsResourceEN GetObjByIdResource(string strIdResource)
{
CheckPrimaryKey(strIdResource);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where IdResource = " + "'"+ strIdResource+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsResourceEN objResourceEN = new clsResourceEN();
try
{
 objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objResourceEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime(字段类型:varchar,字段长度:6,是否可空:True)
 objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsResourceDA: GetObjByIdResource)", objException.Message));
}
return objResourceEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsResourceEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsResourceDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsResourceEN objResourceEN = new clsResourceEN()
{
IdResource = objRow[conResource.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[conResource.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[conResource.ResourceName].ToString().Trim(), //资源名称
SaveMode = TransNullToBool(objRow[conResource.SaveMode].ToString().Trim()), //文件存放方式
IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(), //文件流水号
IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(), //资源类型流水号
UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(), //修改日期
UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(), //UpdTime
Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(), //备注
FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(), //功能模块Id
CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(), //检查日期
CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(), //检查用户Id
CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim() //检查结果
};
objResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsResourceDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsResourceEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = TransNullToBool(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsResourceDA: GetObjByDataRowResource)", objException.Message));
}
objResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsResourceEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsResourceEN objResourceEN = new clsResourceEN();
try
{
objResourceEN.IdResource = objRow[conResource.IdResource].ToString().Trim(); //资源流水号
objResourceEN.ResourceID = objRow[conResource.ResourceID].ToString().Trim(); //资源ID
objResourceEN.ResourceName = objRow[conResource.ResourceName].ToString().Trim(); //资源名称
objResourceEN.SaveMode = TransNullToBool(objRow[conResource.SaveMode].ToString().Trim()); //文件存放方式
objResourceEN.IdFtpResource = objRow[conResource.IdFtpResource] == DBNull.Value ? null : objRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objResourceEN.IdFile = objRow[conResource.IdFile] == DBNull.Value ? null : objRow[conResource.IdFile].ToString().Trim(); //文件流水号
objResourceEN.IdResourceType = objRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objResourceEN.UpdDate = objRow[conResource.UpdDate] == DBNull.Value ? null : objRow[conResource.UpdDate].ToString().Trim(); //修改日期
objResourceEN.UpdTime = objRow[conResource.UpdTime] == DBNull.Value ? null : objRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objResourceEN.Memo = objRow[conResource.Memo] == DBNull.Value ? null : objRow[conResource.Memo].ToString().Trim(); //备注
objResourceEN.FuncModuleId = objRow[conResource.FuncModuleId] == DBNull.Value ? null : objRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objResourceEN.CheckDate = objRow[conResource.CheckDate] == DBNull.Value ? null : objRow[conResource.CheckDate].ToString().Trim(); //检查日期
objResourceEN.CheckUser = objRow[conResource.CheckUser] == DBNull.Value ? null : objRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objResourceEN.CheckResult = objRow[conResource.CheckResult] == DBNull.Value ? null : objRow[conResource.CheckResult].ToString().Trim(); //检查结果
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsResourceDA: GetObjByDataRow)", objException.Message));
}
objResourceEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objResourceEN;
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
objSQL = clsResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResourceEN._CurrTabName, conResource.IdResource, 8, "");
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
objSQL = clsResourceDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsResourceEN._CurrTabName, conResource.IdResource, 8, strPrefix);
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
 objSQL = clsResourceDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdResource from Resource where " + strCondition;
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
 objSQL = clsResourceDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdResource from Resource where " + strCondition;
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdResource)
{
CheckPrimaryKey(strIdResource);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Resource", "IdResource = " + "'"+ strIdResource+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsResourceDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Resource", strCondition))
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
objSQL = clsResourceDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Resource");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsResourceEN objResourceEN)
 {
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Resource");
objRow = objDS.Tables["Resource"].NewRow();
objRow[conResource.IdResource] = objResourceEN.IdResource; //资源流水号
objRow[conResource.ResourceID] = objResourceEN.ResourceID; //资源ID
objRow[conResource.ResourceName] = objResourceEN.ResourceName; //资源名称
objRow[conResource.SaveMode] = objResourceEN.SaveMode; //文件存放方式
 if (objResourceEN.IdFtpResource !=  "")
 {
objRow[conResource.IdFtpResource] = objResourceEN.IdFtpResource; //FTP资源流水号
 }
 if (objResourceEN.IdFile !=  "")
 {
objRow[conResource.IdFile] = objResourceEN.IdFile; //文件流水号
 }
objRow[conResource.IdResourceType] = objResourceEN.IdResourceType; //资源类型流水号
 if (objResourceEN.UpdDate !=  "")
 {
objRow[conResource.UpdDate] = objResourceEN.UpdDate; //修改日期
 }
 if (objResourceEN.UpdTime !=  "")
 {
objRow[conResource.UpdTime] = objResourceEN.UpdTime; //UpdTime
 }
 if (objResourceEN.Memo !=  "")
 {
objRow[conResource.Memo] = objResourceEN.Memo; //备注
 }
 if (objResourceEN.FuncModuleId !=  "")
 {
objRow[conResource.FuncModuleId] = objResourceEN.FuncModuleId; //功能模块Id
 }
 if (objResourceEN.CheckDate !=  "")
 {
objRow[conResource.CheckDate] = objResourceEN.CheckDate; //检查日期
 }
 if (objResourceEN.CheckUser !=  "")
 {
objRow[conResource.CheckUser] = objResourceEN.CheckUser; //检查用户Id
 }
 if (objResourceEN.CheckResult !=  "")
 {
objRow[conResource.CheckResult] = objResourceEN.CheckResult; //检查结果
 }
objDS.Tables[clsResourceEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsResourceEN._CurrTabName);
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResourceEN objResourceEN)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResource);
 var strIdResource = objResourceEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objResourceEN.ResourceID !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceID);
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceID + "'");
 }
 
 if (objResourceEN.ResourceName !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceName);
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceName + "'");
 }
 
 arrFieldListForInsert.Add(conResource.SaveMode);
 arrValueListForInsert.Add("'" + (objResourceEN.SaveMode  ==  false ? "0" : "1") + "'");
 
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFtpResource);
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFile);
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResourceType);
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdDate);
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResourceEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdTime);
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResource.Memo);
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objResourceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conResource.FuncModuleId);
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objResourceEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckDate);
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objResourceEN.CheckUser !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckUser);
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckUser + "'");
 }
 
 if (objResourceEN.CheckResult !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckResult);
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckResult + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Resource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResourceEN objResourceEN)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResource);
 var strIdResource = objResourceEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objResourceEN.ResourceID !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceID);
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceID + "'");
 }
 
 if (objResourceEN.ResourceName !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceName);
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceName + "'");
 }
 
 arrFieldListForInsert.Add(conResource.SaveMode);
 arrValueListForInsert.Add("'" + (objResourceEN.SaveMode  ==  false ? "0" : "1") + "'");
 
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFtpResource);
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFile);
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResourceType);
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdDate);
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResourceEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdTime);
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResource.Memo);
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objResourceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conResource.FuncModuleId);
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objResourceEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckDate);
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objResourceEN.CheckUser !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckUser);
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckUser + "'");
 }
 
 if (objResourceEN.CheckResult !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckResult);
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckResult + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Resource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objResourceEN.IdResource;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsResourceEN objResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResource);
 var strIdResource = objResourceEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objResourceEN.ResourceID !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceID);
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceID + "'");
 }
 
 if (objResourceEN.ResourceName !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceName);
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceName + "'");
 }
 
 arrFieldListForInsert.Add(conResource.SaveMode);
 arrValueListForInsert.Add("'" + (objResourceEN.SaveMode  ==  false ? "0" : "1") + "'");
 
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFtpResource);
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFile);
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResourceType);
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdDate);
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResourceEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdTime);
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResource.Memo);
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objResourceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conResource.FuncModuleId);
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objResourceEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckDate);
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objResourceEN.CheckUser !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckUser);
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckUser + "'");
 }
 
 if (objResourceEN.CheckResult !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckResult);
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckResult + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Resource");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objResourceEN.IdResource;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsResourceEN objResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objResourceEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objResourceEN.IdResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResource);
 var strIdResource = objResourceEN.IdResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResource + "'");
 }
 
 if (objResourceEN.ResourceID !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceID);
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceID + "'");
 }
 
 if (objResourceEN.ResourceName !=  null)
 {
 arrFieldListForInsert.Add(conResource.ResourceName);
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strResourceName + "'");
 }
 
 arrFieldListForInsert.Add(conResource.SaveMode);
 arrValueListForInsert.Add("'" + (objResourceEN.SaveMode  ==  false ? "0" : "1") + "'");
 
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFtpResource);
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFtpResource + "'");
 }
 
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdFile);
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdFile + "'");
 }
 
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 arrFieldListForInsert.Add(conResource.IdResourceType);
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdResourceType + "'");
 }
 
 if (objResourceEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdDate);
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objResourceEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conResource.UpdTime);
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objResourceEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conResource.Memo);
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objResourceEN.FuncModuleId !=  null)
 {
 arrFieldListForInsert.Add(conResource.FuncModuleId);
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleId + "'");
 }
 
 if (objResourceEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckDate);
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objResourceEN.CheckUser !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckUser);
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckUser + "'");
 }
 
 if (objResourceEN.CheckResult !=  null)
 {
 arrFieldListForInsert.Add(conResource.CheckResult);
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckResult + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Resource");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewResources(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where IdResource = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Resource");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdResource = oRow[conResource.IdResource].ToString().Trim();
if (IsExist(strIdResource))
{
 string strResult = "关键字变量值为:" + string.Format("IdResource = {0}", strIdResource) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsResourceEN._CurrTabName ].NewRow();
objRow[conResource.IdResource] = oRow[conResource.IdResource].ToString().Trim(); //资源流水号
objRow[conResource.ResourceID] = oRow[conResource.ResourceID].ToString().Trim(); //资源ID
objRow[conResource.ResourceName] = oRow[conResource.ResourceName].ToString().Trim(); //资源名称
objRow[conResource.SaveMode] = oRow[conResource.SaveMode].ToString().Trim(); //文件存放方式
objRow[conResource.IdFtpResource] = oRow[conResource.IdFtpResource].ToString().Trim(); //FTP资源流水号
objRow[conResource.IdFile] = oRow[conResource.IdFile].ToString().Trim(); //文件流水号
objRow[conResource.IdResourceType] = oRow[conResource.IdResourceType].ToString().Trim(); //资源类型流水号
objRow[conResource.UpdDate] = oRow[conResource.UpdDate].ToString().Trim(); //修改日期
objRow[conResource.UpdTime] = oRow[conResource.UpdTime].ToString().Trim(); //UpdTime
objRow[conResource.Memo] = oRow[conResource.Memo].ToString().Trim(); //备注
objRow[conResource.FuncModuleId] = oRow[conResource.FuncModuleId].ToString().Trim(); //功能模块Id
objRow[conResource.CheckDate] = oRow[conResource.CheckDate].ToString().Trim(); //检查日期
objRow[conResource.CheckUser] = oRow[conResource.CheckUser].ToString().Trim(); //检查用户Id
objRow[conResource.CheckResult] = oRow[conResource.CheckResult].ToString().Trim(); //检查结果
 objDS.Tables[clsResourceEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsResourceEN._CurrTabName);
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
 /// <param name = "objResourceEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsResourceEN objResourceEN)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
strSQL = "Select * from Resource where IdResource = " + "'"+ objResourceEN.IdResource+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsResourceEN._CurrTabName);
if (objDS.Tables[clsResourceEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdResource = " + "'"+ objResourceEN.IdResource+"'");
return false;
}
objRow = objDS.Tables[clsResourceEN._CurrTabName].Rows[0];
 if (objResourceEN.IsUpdated(conResource.IdResource))
 {
objRow[conResource.IdResource] = objResourceEN.IdResource; //资源流水号
 }
 if (objResourceEN.IsUpdated(conResource.ResourceID))
 {
objRow[conResource.ResourceID] = objResourceEN.ResourceID; //资源ID
 }
 if (objResourceEN.IsUpdated(conResource.ResourceName))
 {
objRow[conResource.ResourceName] = objResourceEN.ResourceName; //资源名称
 }
 if (objResourceEN.IsUpdated(conResource.SaveMode))
 {
objRow[conResource.SaveMode] = objResourceEN.SaveMode; //文件存放方式
 }
 if (objResourceEN.IsUpdated(conResource.IdFtpResource))
 {
objRow[conResource.IdFtpResource] = objResourceEN.IdFtpResource; //FTP资源流水号
 }
 if (objResourceEN.IsUpdated(conResource.IdFile))
 {
objRow[conResource.IdFile] = objResourceEN.IdFile; //文件流水号
 }
 if (objResourceEN.IsUpdated(conResource.IdResourceType))
 {
objRow[conResource.IdResourceType] = objResourceEN.IdResourceType; //资源类型流水号
 }
 if (objResourceEN.IsUpdated(conResource.UpdDate))
 {
objRow[conResource.UpdDate] = objResourceEN.UpdDate; //修改日期
 }
 if (objResourceEN.IsUpdated(conResource.UpdTime))
 {
objRow[conResource.UpdTime] = objResourceEN.UpdTime; //UpdTime
 }
 if (objResourceEN.IsUpdated(conResource.Memo))
 {
objRow[conResource.Memo] = objResourceEN.Memo; //备注
 }
 if (objResourceEN.IsUpdated(conResource.FuncModuleId))
 {
objRow[conResource.FuncModuleId] = objResourceEN.FuncModuleId; //功能模块Id
 }
 if (objResourceEN.IsUpdated(conResource.CheckDate))
 {
objRow[conResource.CheckDate] = objResourceEN.CheckDate; //检查日期
 }
 if (objResourceEN.IsUpdated(conResource.CheckUser))
 {
objRow[conResource.CheckUser] = objResourceEN.CheckUser; //检查用户Id
 }
 if (objResourceEN.IsUpdated(conResource.CheckResult))
 {
objRow[conResource.CheckResult] = objResourceEN.CheckResult; //检查结果
 }
try
{
objDA.Update(objDS, clsResourceEN._CurrTabName);
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResourceEN objResourceEN)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Resource Set ");
 
 if (objResourceEN.IsUpdated(conResource.ResourceID))
 {
 if (objResourceEN.ResourceID !=  null)
 {
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceID, conResource.ResourceID); //资源ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.ResourceID); //资源ID
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.ResourceName))
 {
 if (objResourceEN.ResourceName !=  null)
 {
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceName, conResource.ResourceName); //资源名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.ResourceName); //资源名称
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.SaveMode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResourceEN.SaveMode == true?"1":"0", conResource.SaveMode); //文件存放方式
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFtpResource))
 {
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFtpResource, conResource.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFile))
 {
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFile, conResource.IdFile); //文件流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdFile); //文件流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdResourceType))
 {
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, conResource.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdResourceType); //资源类型流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdDate))
 {
 if (objResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conResource.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.UpdDate); //修改日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdTime))
 {
 if (objResourceEN.UpdTime !=  null)
 {
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conResource.UpdTime); //UpdTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.UpdTime); //UpdTime
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.Memo))
 {
 if (objResourceEN.Memo !=  null)
 {
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResource.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.Memo); //备注
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.FuncModuleId))
 {
 if (objResourceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conResource.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.FuncModuleId); //功能模块Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckDate))
 {
 if (objResourceEN.CheckDate !=  null)
 {
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conResource.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckDate); //检查日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckUser))
 {
 if (objResourceEN.CheckUser !=  null)
 {
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckUser, conResource.CheckUser); //检查用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckUser); //检查用户Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckResult))
 {
 if (objResourceEN.CheckResult !=  null)
 {
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckResult, conResource.CheckResult); //检查结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckResult); //检查结果
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdResource = '{0}'", objResourceEN.IdResource); 
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsResourceEN objResourceEN, string strCondition)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Resource Set ");
 
 if (objResourceEN.IsUpdated(conResource.ResourceID))
 {
 if (objResourceEN.ResourceID !=  null)
 {
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceID = '{0}',", strResourceID); //资源ID
 }
 else
 {
 sbSQL.Append(" ResourceID = null,"); //资源ID
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.ResourceName))
 {
 if (objResourceEN.ResourceName !=  null)
 {
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceName = '{0}',", strResourceName); //资源名称
 }
 else
 {
 sbSQL.Append(" ResourceName = null,"); //资源名称
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.SaveMode))
 {
 sbSQL.AppendFormat(" SaveMode = '{0}',", objResourceEN.SaveMode == true?"1":"0"); //文件存放方式
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFtpResource))
 {
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", strIdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFile))
 {
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFile = '{0}',", strIdFile); //文件流水号
 }
 else
 {
 sbSQL.Append(" IdFile = null,"); //文件流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdResourceType))
 {
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdDate))
 {
 if (objResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdTime))
 {
 if (objResourceEN.UpdTime !=  null)
 {
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //UpdTime
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //UpdTime
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.Memo))
 {
 if (objResourceEN.Memo !=  null)
 {
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.FuncModuleId))
 {
 if (objResourceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckDate))
 {
 if (objResourceEN.CheckDate !=  null)
 {
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckUser))
 {
 if (objResourceEN.CheckUser !=  null)
 {
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckUser = '{0}',", strCheckUser); //检查用户Id
 }
 else
 {
 sbSQL.Append(" CheckUser = null,"); //检查用户Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckResult))
 {
 if (objResourceEN.CheckResult !=  null)
 {
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckResult = '{0}',", strCheckResult); //检查结果
 }
 else
 {
 sbSQL.Append(" CheckResult = null,"); //检查结果
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
 /// <param name = "objResourceEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsResourceEN objResourceEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Resource Set ");
 
 if (objResourceEN.IsUpdated(conResource.ResourceID))
 {
 if (objResourceEN.ResourceID !=  null)
 {
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceID = '{0}',", strResourceID); //资源ID
 }
 else
 {
 sbSQL.Append(" ResourceID = null,"); //资源ID
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.ResourceName))
 {
 if (objResourceEN.ResourceName !=  null)
 {
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ResourceName = '{0}',", strResourceName); //资源名称
 }
 else
 {
 sbSQL.Append(" ResourceName = null,"); //资源名称
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.SaveMode))
 {
 sbSQL.AppendFormat(" SaveMode = '{0}',", objResourceEN.SaveMode == true?"1":"0"); //文件存放方式
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFtpResource))
 {
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFtpResource = '{0}',", strIdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.Append(" IdFtpResource = null,"); //FTP资源流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFile))
 {
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdFile = '{0}',", strIdFile); //文件流水号
 }
 else
 {
 sbSQL.Append(" IdFile = null,"); //文件流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdResourceType))
 {
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdResourceType = '{0}',", strIdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.Append(" IdResourceType = null,"); //资源类型流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdDate))
 {
 if (objResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdTime))
 {
 if (objResourceEN.UpdTime !=  null)
 {
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //UpdTime
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //UpdTime
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.Memo))
 {
 if (objResourceEN.Memo !=  null)
 {
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.FuncModuleId))
 {
 if (objResourceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleId = '{0}',", strFuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleId = null,"); //功能模块Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckDate))
 {
 if (objResourceEN.CheckDate !=  null)
 {
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckUser))
 {
 if (objResourceEN.CheckUser !=  null)
 {
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckUser = '{0}',", strCheckUser); //检查用户Id
 }
 else
 {
 sbSQL.Append(" CheckUser = null,"); //检查用户Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckResult))
 {
 if (objResourceEN.CheckResult !=  null)
 {
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckResult = '{0}',", strCheckResult); //检查结果
 }
 else
 {
 sbSQL.Append(" CheckResult = null,"); //检查结果
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
 /// <param name = "objResourceEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsResourceEN objResourceEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objResourceEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objResourceEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objResourceEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Resource Set ");
 
 if (objResourceEN.IsUpdated(conResource.ResourceID))
 {
 if (objResourceEN.ResourceID !=  null)
 {
 var strResourceID = objResourceEN.ResourceID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceID, conResource.ResourceID); //资源ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.ResourceID); //资源ID
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.ResourceName))
 {
 if (objResourceEN.ResourceName !=  null)
 {
 var strResourceName = objResourceEN.ResourceName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strResourceName, conResource.ResourceName); //资源名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.ResourceName); //资源名称
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.SaveMode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objResourceEN.SaveMode == true?"1":"0", conResource.SaveMode); //文件存放方式
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFtpResource))
 {
 if (objResourceEN.IdFtpResource  ==  "")
 {
 objResourceEN.IdFtpResource = null;
 }
 if (objResourceEN.IdFtpResource !=  null)
 {
 var strIdFtpResource = objResourceEN.IdFtpResource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFtpResource, conResource.IdFtpResource); //FTP资源流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdFtpResource); //FTP资源流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdFile))
 {
 if (objResourceEN.IdFile  ==  "")
 {
 objResourceEN.IdFile = null;
 }
 if (objResourceEN.IdFile !=  null)
 {
 var strIdFile = objResourceEN.IdFile.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdFile, conResource.IdFile); //文件流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdFile); //文件流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.IdResourceType))
 {
 if (objResourceEN.IdResourceType  ==  "")
 {
 objResourceEN.IdResourceType = null;
 }
 if (objResourceEN.IdResourceType !=  null)
 {
 var strIdResourceType = objResourceEN.IdResourceType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdResourceType, conResource.IdResourceType); //资源类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.IdResourceType); //资源类型流水号
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdDate))
 {
 if (objResourceEN.UpdDate !=  null)
 {
 var strUpdDate = objResourceEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conResource.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.UpdDate); //修改日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.UpdTime))
 {
 if (objResourceEN.UpdTime !=  null)
 {
 var strUpdTime = objResourceEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conResource.UpdTime); //UpdTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.UpdTime); //UpdTime
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.Memo))
 {
 if (objResourceEN.Memo !=  null)
 {
 var strMemo = objResourceEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conResource.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.Memo); //备注
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.FuncModuleId))
 {
 if (objResourceEN.FuncModuleId !=  null)
 {
 var strFuncModuleId = objResourceEN.FuncModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleId, conResource.FuncModuleId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.FuncModuleId); //功能模块Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckDate))
 {
 if (objResourceEN.CheckDate !=  null)
 {
 var strCheckDate = objResourceEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conResource.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckDate); //检查日期
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckUser))
 {
 if (objResourceEN.CheckUser !=  null)
 {
 var strCheckUser = objResourceEN.CheckUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckUser, conResource.CheckUser); //检查用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckUser); //检查用户Id
 }
 }
 
 if (objResourceEN.IsUpdated(conResource.CheckResult))
 {
 if (objResourceEN.CheckResult !=  null)
 {
 var strCheckResult = objResourceEN.CheckResult.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckResult, conResource.CheckResult); //检查结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conResource.CheckResult); //检查结果
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdResource = '{0}'", objResourceEN.IdResource); 
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
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdResource) 
{
CheckPrimaryKey(strIdResource);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdResource,
};
 objSQL.ExecSP("Resource_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdResource, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdResource);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
//删除Resource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Resource where IdResource = " + "'"+ strIdResource+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelResource(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
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
//删除Resource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Resource where IdResource in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdResource">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdResource) 
{
CheckPrimaryKey(strIdResource);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
//删除Resource本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Resource where IdResource = " + "'"+ strIdResource+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelResource(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsResourceDA: DelResource)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Resource where " + strCondition ;
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
public bool DelResourceWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsResourceDA: DelResourceWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsResourceDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Resource where " + strCondition ;
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
 /// <param name = "objResourceENS">源对象</param>
 /// <param name = "objResourceENT">目标对象</param>
public void CopyTo(clsResourceEN objResourceENS, clsResourceEN objResourceENT)
{
objResourceENT.IdResource = objResourceENS.IdResource; //资源流水号
objResourceENT.ResourceID = objResourceENS.ResourceID; //资源ID
objResourceENT.ResourceName = objResourceENS.ResourceName; //资源名称
objResourceENT.SaveMode = objResourceENS.SaveMode; //文件存放方式
objResourceENT.IdFtpResource = objResourceENS.IdFtpResource; //FTP资源流水号
objResourceENT.IdFile = objResourceENS.IdFile; //文件流水号
objResourceENT.IdResourceType = objResourceENS.IdResourceType; //资源类型流水号
objResourceENT.UpdDate = objResourceENS.UpdDate; //修改日期
objResourceENT.UpdTime = objResourceENS.UpdTime; //UpdTime
objResourceENT.Memo = objResourceENS.Memo; //备注
objResourceENT.FuncModuleId = objResourceENS.FuncModuleId; //功能模块Id
objResourceENT.CheckDate = objResourceENS.CheckDate; //检查日期
objResourceENT.CheckUser = objResourceENS.CheckUser; //检查用户Id
objResourceENT.CheckResult = objResourceENS.CheckResult; //检查结果
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsResourceEN objResourceEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objResourceEN.ResourceID, conResource.ResourceID);
clsCheckSql.CheckFieldNotNull(objResourceEN.ResourceName, conResource.ResourceName);
clsCheckSql.CheckFieldNotNull(objResourceEN.IdResourceType, conResource.IdResourceType);
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceEN.IdResource, 8, conResource.IdResource);
clsCheckSql.CheckFieldLen(objResourceEN.ResourceID, 8, conResource.ResourceID);
clsCheckSql.CheckFieldLen(objResourceEN.ResourceName, 100, conResource.ResourceName);
clsCheckSql.CheckFieldLen(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldLen(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
clsCheckSql.CheckFieldLen(objResourceEN.UpdDate, 20, conResource.UpdDate);
clsCheckSql.CheckFieldLen(objResourceEN.UpdTime, 6, conResource.UpdTime);
clsCheckSql.CheckFieldLen(objResourceEN.Memo, 1000, conResource.Memo);
clsCheckSql.CheckFieldLen(objResourceEN.FuncModuleId, 4, conResource.FuncModuleId);
clsCheckSql.CheckFieldLen(objResourceEN.CheckDate, 20, conResource.CheckDate);
clsCheckSql.CheckFieldLen(objResourceEN.CheckUser, 18, conResource.CheckUser);
clsCheckSql.CheckFieldLen(objResourceEN.CheckResult, 1000, conResource.CheckResult);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
 objResourceEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsResourceEN objResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceEN.ResourceID, 8, conResource.ResourceID);
clsCheckSql.CheckFieldLen(objResourceEN.ResourceName, 100, conResource.ResourceName);
clsCheckSql.CheckFieldLen(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldLen(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
clsCheckSql.CheckFieldLen(objResourceEN.UpdDate, 20, conResource.UpdDate);
clsCheckSql.CheckFieldLen(objResourceEN.UpdTime, 6, conResource.UpdTime);
clsCheckSql.CheckFieldLen(objResourceEN.Memo, 1000, conResource.Memo);
clsCheckSql.CheckFieldLen(objResourceEN.FuncModuleId, 4, conResource.FuncModuleId);
clsCheckSql.CheckFieldLen(objResourceEN.CheckDate, 20, conResource.CheckDate);
clsCheckSql.CheckFieldLen(objResourceEN.CheckUser, 18, conResource.CheckUser);
clsCheckSql.CheckFieldLen(objResourceEN.CheckResult, 1000, conResource.CheckResult);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
 objResourceEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsResourceEN objResourceEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objResourceEN.IdResource, 8, conResource.IdResource);
clsCheckSql.CheckFieldLen(objResourceEN.ResourceID, 8, conResource.ResourceID);
clsCheckSql.CheckFieldLen(objResourceEN.ResourceName, 100, conResource.ResourceName);
clsCheckSql.CheckFieldLen(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldLen(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldLen(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
clsCheckSql.CheckFieldLen(objResourceEN.UpdDate, 20, conResource.UpdDate);
clsCheckSql.CheckFieldLen(objResourceEN.UpdTime, 6, conResource.UpdTime);
clsCheckSql.CheckFieldLen(objResourceEN.Memo, 1000, conResource.Memo);
clsCheckSql.CheckFieldLen(objResourceEN.FuncModuleId, 4, conResource.FuncModuleId);
clsCheckSql.CheckFieldLen(objResourceEN.CheckDate, 20, conResource.CheckDate);
clsCheckSql.CheckFieldLen(objResourceEN.CheckUser, 18, conResource.CheckUser);
clsCheckSql.CheckFieldLen(objResourceEN.CheckResult, 1000, conResource.CheckResult);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objResourceEN.IdResource, conResource.IdResource);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.ResourceID, conResource.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.ResourceName, conResource.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.IdFtpResource, conResource.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.IdFile, conResource.IdFile);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.IdResourceType, conResource.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.UpdDate, conResource.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.UpdTime, conResource.UpdTime);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.Memo, conResource.Memo);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.FuncModuleId, conResource.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.CheckDate, conResource.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.CheckUser, conResource.CheckUser);
clsCheckSql.CheckSqlInjection4Field(objResourceEN.CheckResult, conResource.CheckResult);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFtpResource, 8, conResource.IdFtpResource);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdFile, 8, conResource.IdFile);
clsCheckSql.CheckFieldForeignKey(objResourceEN.IdResourceType, 4, conResource.IdResourceType);
 objResourceEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdResource()
{
//获取某学院所有专业信息
string strSQL = "select IdResource, ResourceName from Resource ";
 clsSpecSQLforSql mySql = clsResourceDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Resource(资源),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objResourceEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsResourceEN objResourceEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ResourceID = '{0}'", objResourceEN.ResourceID);
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
 objSQL = clsResourceDA.GetSpecSQLObj();
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
 objSQL = clsResourceDA.GetSpecSQLObj();
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
 objSQL = clsResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResourceEN._CurrTabName);
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
 objSQL = clsResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsResourceEN._CurrTabName, strCondition);
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
 objSQL = clsResourceDA.GetSpecSQLObj();
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
 objSQL = clsResourceDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}