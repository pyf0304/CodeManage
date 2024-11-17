
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCodeTypeDA
 表名:CodeType(01160068)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 日期:2023/03/11 03:03:26
 生成者:pyf
 生成服务器IP:
 工程名称:简单工程样例(0116)
 CM工程:简单样例后端(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433SimplePrj
 PrjDataBaseId:0111
 模块中文名:生成代码(GeneCode)
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
using SimplePrj.Entity;

namespace SimplePrj.DAL
{
 /// <summary>
 /// 代码类型(CodeType)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class clsCodeTypeDA : clsCommBase4DA
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
 public override string _CurrTabName_S
 {
 get
 {
 return clsCodeTypeEN._CurrTabName_S;
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
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象！");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象！");
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
if (string.IsNullOrEmpty(clsCodeTypeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCodeTypeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCodeTypeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCodeTypeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeTypeId)
{
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:CodeType中,检查关键字,长度不正确!(clsCodeTypeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CodeType中,关键字不能为空 或 null!(clsCodeTypeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCodeTypeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CodeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable_CodeType)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CodeType where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} CodeType.* from CodeType Left Join {1} on {2} where {3} and CodeType.CodeTypeId not in (Select top {5} CodeType.CodeTypeId from CodeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1} and CodeTypeId not in (Select top {2} CodeTypeId from CodeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1} and CodeTypeId not in (Select top {3} CodeTypeId from CodeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCodeTypeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("在带有特殊排序分页查询中，strOrderBy:[{0}]应该有竖线(|)分隔的3部分组成,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strTabName = arrPart[0];
string strNewOrderBy = arrPart[1];
string strOnCondition = arrPart[2];
strSQL = string.Format("Select Top {0} CodeType.* from CodeType Left Join {1} on {2} where {3} and CodeType.CodeTypeId not in (Select top {5} CodeType.CodeTypeId from CodeType Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1} and CodeTypeId not in (Select top {2} CodeTypeId from CodeType where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CodeType where {1} and CodeTypeId not in (Select top {3} CodeTypeId from CodeType where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCodeTypeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCodeTypeDA:GetObjLst)", objException.Message));
}
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = TransNullToBool(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = TransNullToBool(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = TransNullToBool(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = TransNullToBool(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = TransNullToBool(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = TransNullToBool(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = TransNullToBool(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = TransNullToBool(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = TransNullToBool(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = TransNullToBool(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = TransNullToBool(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = TransNullToBool(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = TransNullToInt(objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = TransNullToBool(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = TransNullToBool(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = TransNullToInt(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = TransNullToInt(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeTypeDA: GetObjLst)", objException.Message));
}
objCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeTypeEN);
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
public List<clsCodeTypeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCodeTypeDA:GetObjLstByTabName)", objException.Message));
}
List<clsCodeTypeEN> arrObjLst = new List<clsCodeTypeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = TransNullToBool(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = TransNullToBool(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = TransNullToBool(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = TransNullToBool(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = TransNullToBool(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = TransNullToBool(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = TransNullToBool(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = TransNullToBool(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = TransNullToBool(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = TransNullToBool(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = TransNullToBool(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = TransNullToBool(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = TransNullToInt(objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = TransNullToBool(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = TransNullToBool(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = TransNullToInt(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = TransNullToInt(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCodeTypeDA: GetObjLst)", objException.Message));
}
objCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCodeTypeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCodeType(ref clsCodeTypeEN objCodeTypeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where CodeTypeId = " + "'"+ objCodeTypeEN.CodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCodeTypeEN.CodeTypeId = objDT.Rows[0][conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeTypeEN.CodeTypeName = objDT.Rows[0][conCodeType.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objCodeTypeEN.CodeTypeSimName = objDT.Rows[0][conCodeType.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objCodeTypeEN.CodeTypeENName = objDT.Rows[0][conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.GroupName = objDT.Rows[0][conCodeType.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objCodeTypeEN.ProgLangTypeId = objDT.Rows[0][conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeTypeEN.RegionTypeId = objDT.Rows[0][conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeTypeEN.Prefix = objDT.Rows[0][conCodeType.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objCodeTypeEN.DependsOn = objDT.Rows[0][conCodeType.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.FrontOrBack = objDT.Rows[0][conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.SqlDsTypeId = objDT.Rows[0][conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeTypeEN.ClassNameFormat = objDT.Rows[0][conCodeType.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.ClassNameFormatEx = objDT.Rows[0][conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.FileNameFormat = objDT.Rows[0][conCodeType.FileNameFormat].ToString().Trim(); //文件名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.ClassNamePattern = objDT.Rows[0][conCodeType.ClassNamePattern].ToString().Trim(); //类名模式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.IsCSharp = TransNullToBool(objDT.Rows[0][conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsJava = TransNullToBool(objDT.Rows[0][conCodeType.IsJava].ToString().Trim()); //是否Java语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsJavaScript = TransNullToBool(objDT.Rows[0][conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsTypeScript = TransNullToBool(objDT.Rows[0][conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsSilverLight = TransNullToBool(objDT.Rows[0][conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsSwift = TransNullToBool(objDT.Rows[0][conCodeType.IsSwift].ToString().Trim()); //是否Swift语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsVB = TransNullToBool(objDT.Rows[0][conCodeType.IsVB].ToString().Trim()); //IsVB语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsTableFldConst = TransNullToBool(objDT.Rows[0][conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objDT.Rows[0][conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWeb = TransNullToBool(objDT.Rows[0][conCodeType.IsWeb].ToString().Trim()); //是否Web应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsAspMvc = TransNullToBool(objDT.Rows[0][conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWebSrvAccess = TransNullToBool(objDT.Rows[0][conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWin = TransNullToBool(objDT.Rows[0][conCodeType.IsWin].ToString().Trim()); //是否Win应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsMobileApp = TransNullToBool(objDT.Rows[0][conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsExtend = TransNullToBool(objDT.Rows[0][conCodeType.IsExtend].ToString().Trim()); //是否扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.OrderNum = TransNullToInt(objDT.Rows[0][conCodeType.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objCodeTypeEN.WinOrWeb = objDT.Rows[0][conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.IsDirByTabName = TransNullToBool(objDT.Rows[0][conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsDefaultOverride = TransNullToBool(objDT.Rows[0][conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objCodeTypeEN.InUse = TransNullToBool(objDT.Rows[0][conCodeType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsAutoParseFile = TransNullToBool(objDT.Rows[0][conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.UpdDate = objDT.Rows[0][conCodeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeTypeEN.UpdUser = objDT.Rows[0][conCodeType.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeTypeEN.Memo = objDT.Rows[0][conCodeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objCodeTypeEN.SqlDsTypeName = objDT.Rows[0][conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objCodeTypeEN.FuncCount = TransNullToInt(objDT.Rows[0][conCodeType.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objCodeTypeEN.AppCount = TransNullToInt(objDT.Rows[0][conCodeType.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCodeTypeDA: GetCodeType)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsCodeTypeEN GetObjByCodeTypeId(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where CodeTypeId = " + "'"+ strCodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
 objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName] == DBNull.Value ? null : objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.GroupName = objRow[conCodeType.GroupName] == DBNull.Value ? null : objRow[conCodeType.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCodeTypeEN.Prefix = objRow[conCodeType.Prefix] == DBNull.Value ? null : objRow[conCodeType.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn] == DBNull.Value ? null : objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack] == DBNull.Value ? null : objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx] == DBNull.Value ? null : objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat] == DBNull.Value ? null : objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern] == DBNull.Value ? null : objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.IsCSharp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsCSharp] == DBNull.Value ? null : objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsJava = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJava] == DBNull.Value ? null : objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsJavaScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsJavaScript] == DBNull.Value ? null : objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsTypeScript = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTypeScript] == DBNull.Value ? null : objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsSilverLight = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSilverLight] == DBNull.Value ? null : objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsSwift = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsSwift] == DBNull.Value ? null : objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsVB = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsVB] == DBNull.Value ? null : objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsTableFldConst = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsTableFldConst] == DBNull.Value ? null : objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsPubApp4WinWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsPubApp4WinWeb] == DBNull.Value ? null : objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWeb = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWeb] == DBNull.Value ? null : objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsAspMvc = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAspMvc] == DBNull.Value ? null : objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWebSrvAccess = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWebSrvAccess] == DBNull.Value ? null : objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsWin = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsWin] == DBNull.Value ? null : objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsMobileApp = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsMobileApp] == DBNull.Value ? null : objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsExtend] == DBNull.Value ? null : objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.OrderNum = clsEntityBase2.TransNullToInt_S(objRow[conCodeType.OrderNum] == DBNull.Value ? null : objRow[conCodeType.OrderNum].ToString().Trim()); //排序(字段类型:int,字段长度:4,是否可空:True)
 objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb] == DBNull.Value ? null : objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb(字段类型:varchar,字段长度:50,是否可空:True)
 objCodeTypeEN.IsDirByTabName = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDirByTabName] == DBNull.Value ? null : objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objCodeTypeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.InUse] == DBNull.Value ? null : objRow[conCodeType.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[conCodeType.IsAutoParseFile] == DBNull.Value ? null : objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件(字段类型:bit,字段长度:1,是否可空:True)
 objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate] == DBNull.Value ? null : objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser] == DBNull.Value ? null : objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCodeTypeEN.Memo = objRow[conCodeType.Memo] == DBNull.Value ? null : objRow[conCodeType.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName] == DBNull.Value ? null : objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objCodeTypeEN.FuncCount = Int32.Parse(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objCodeTypeEN.AppCount = Int32.Parse(objRow[conCodeType.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCodeTypeDA: GetObjByCodeTypeId)", objException.Message));
}
return objCodeTypeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCodeTypeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCodeTypeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN()
{
CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(), //简称
CodeTypeENName = objRow[conCodeType.CodeTypeENName].ToString().Trim(), //代码类型英文名
GroupName = objRow[conCodeType.GroupName].ToString().Trim(), //组名
ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(), //区域类型Id
Prefix = objRow[conCodeType.Prefix].ToString().Trim(), //前缀
DependsOn = objRow[conCodeType.DependsOn].ToString().Trim(), //依赖于
FrontOrBack = objRow[conCodeType.FrontOrBack].ToString().Trim(), //前台Or后台
SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(), //数据源类型Id
ClassNameFormat = objRow[conCodeType.ClassNameFormat].ToString().Trim(), //类名格式
ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx].ToString().Trim(), //类名格式
FileNameFormat = objRow[conCodeType.FileNameFormat].ToString().Trim(), //文件名格式
ClassNamePattern = objRow[conCodeType.ClassNamePattern].ToString().Trim(), //类名模式
IsCSharp = TransNullToBool(objRow[conCodeType.IsCSharp].ToString().Trim()), //是否CSharp语言
IsJava = TransNullToBool(objRow[conCodeType.IsJava].ToString().Trim()), //是否Java语言
IsJavaScript = TransNullToBool(objRow[conCodeType.IsJavaScript].ToString().Trim()), //是否JavaScript语言
IsTypeScript = TransNullToBool(objRow[conCodeType.IsTypeScript].ToString().Trim()), //是否TypeScript语言
IsSilverLight = TransNullToBool(objRow[conCodeType.IsSilverLight].ToString().Trim()), //是否SilverLight语言
IsSwift = TransNullToBool(objRow[conCodeType.IsSwift].ToString().Trim()), //是否Swift语言
IsVB = TransNullToBool(objRow[conCodeType.IsVB].ToString().Trim()), //IsVB语言
IsTableFldConst = TransNullToBool(objRow[conCodeType.IsTableFldConst].ToString().Trim()), //IsTableFldConst
IsPubApp4WinWeb = TransNullToBool(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()), //IsPubApp4WinWeb
IsWeb = TransNullToBool(objRow[conCodeType.IsWeb].ToString().Trim()), //是否Web应用
IsAspMvc = TransNullToBool(objRow[conCodeType.IsAspMvc].ToString().Trim()), //是否AspMvc
IsWebSrvAccess = TransNullToBool(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()), //IsWebSrvAccess
IsWin = TransNullToBool(objRow[conCodeType.IsWin].ToString().Trim()), //是否Win应用
IsMobileApp = TransNullToBool(objRow[conCodeType.IsMobileApp].ToString().Trim()), //是否移动终端应用
IsExtend = TransNullToBool(objRow[conCodeType.IsExtend].ToString().Trim()), //是否扩展类
OrderNum = TransNullToInt(objRow[conCodeType.OrderNum].ToString().Trim()), //排序
WinOrWeb = objRow[conCodeType.WinOrWeb].ToString().Trim(), //WinOrWeb
IsDirByTabName = TransNullToBool(objRow[conCodeType.IsDirByTabName].ToString().Trim()), //是否用表名作为路径
IsDefaultOverride = TransNullToBool(objRow[conCodeType.IsDefaultOverride].ToString().Trim()), //是否默认覆盖
InUse = TransNullToBool(objRow[conCodeType.InUse].ToString().Trim()), //是否在用
IsAutoParseFile = TransNullToBool(objRow[conCodeType.IsAutoParseFile].ToString().Trim()), //是否自动分析文件
UpdDate = objRow[conCodeType.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCodeType.UpdUser].ToString().Trim(), //修改用户
Memo = objRow[conCodeType.Memo].ToString().Trim(), //备注
SqlDsTypeName = objRow[conCodeType.SqlDsTypeName].ToString().Trim(), //Sql数据源名
FuncCount = TransNullToInt(objRow[conCodeType.FuncCount].ToString().Trim()), //函数数目
AppCount = TransNullToInt(objRow[conCodeType.AppCount].ToString().Trim()) //应用数
};
objCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeTypeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCodeTypeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCodeTypeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = TransNullToBool(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = TransNullToBool(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = TransNullToBool(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = TransNullToBool(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = TransNullToBool(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = TransNullToBool(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = TransNullToBool(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = TransNullToBool(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = TransNullToBool(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = TransNullToBool(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = TransNullToBool(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = TransNullToBool(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = TransNullToInt(objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = TransNullToBool(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = TransNullToBool(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = TransNullToInt(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = TransNullToInt(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCodeTypeDA: GetObjByDataRowCodeType)", objException.Message));
}
objCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeTypeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCodeTypeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCodeTypeEN objCodeTypeEN = new clsCodeTypeEN();
try
{
objCodeTypeEN.CodeTypeId = objRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objCodeTypeEN.CodeTypeName = objRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objCodeTypeEN.CodeTypeSimName = objRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objCodeTypeEN.CodeTypeENName = objRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objCodeTypeEN.GroupName = objRow[conCodeType.GroupName].ToString().Trim(); //组名
objCodeTypeEN.ProgLangTypeId = objRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objCodeTypeEN.RegionTypeId = objRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objCodeTypeEN.Prefix = objRow[conCodeType.Prefix].ToString().Trim(); //前缀
objCodeTypeEN.DependsOn = objRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objCodeTypeEN.FrontOrBack = objRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objCodeTypeEN.SqlDsTypeId = objRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objCodeTypeEN.ClassNameFormat = objRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objCodeTypeEN.ClassNameFormatEx = objRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objCodeTypeEN.FileNameFormat = objRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objCodeTypeEN.ClassNamePattern = objRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objCodeTypeEN.IsCSharp = TransNullToBool(objRow[conCodeType.IsCSharp].ToString().Trim()); //是否CSharp语言
objCodeTypeEN.IsJava = TransNullToBool(objRow[conCodeType.IsJava].ToString().Trim()); //是否Java语言
objCodeTypeEN.IsJavaScript = TransNullToBool(objRow[conCodeType.IsJavaScript].ToString().Trim()); //是否JavaScript语言
objCodeTypeEN.IsTypeScript = TransNullToBool(objRow[conCodeType.IsTypeScript].ToString().Trim()); //是否TypeScript语言
objCodeTypeEN.IsSilverLight = TransNullToBool(objRow[conCodeType.IsSilverLight].ToString().Trim()); //是否SilverLight语言
objCodeTypeEN.IsSwift = TransNullToBool(objRow[conCodeType.IsSwift].ToString().Trim()); //是否Swift语言
objCodeTypeEN.IsVB = TransNullToBool(objRow[conCodeType.IsVB].ToString().Trim()); //IsVB语言
objCodeTypeEN.IsTableFldConst = TransNullToBool(objRow[conCodeType.IsTableFldConst].ToString().Trim()); //IsTableFldConst
objCodeTypeEN.IsPubApp4WinWeb = TransNullToBool(objRow[conCodeType.IsPubApp4WinWeb].ToString().Trim()); //IsPubApp4WinWeb
objCodeTypeEN.IsWeb = TransNullToBool(objRow[conCodeType.IsWeb].ToString().Trim()); //是否Web应用
objCodeTypeEN.IsAspMvc = TransNullToBool(objRow[conCodeType.IsAspMvc].ToString().Trim()); //是否AspMvc
objCodeTypeEN.IsWebSrvAccess = TransNullToBool(objRow[conCodeType.IsWebSrvAccess].ToString().Trim()); //IsWebSrvAccess
objCodeTypeEN.IsWin = TransNullToBool(objRow[conCodeType.IsWin].ToString().Trim()); //是否Win应用
objCodeTypeEN.IsMobileApp = TransNullToBool(objRow[conCodeType.IsMobileApp].ToString().Trim()); //是否移动终端应用
objCodeTypeEN.IsExtend = TransNullToBool(objRow[conCodeType.IsExtend].ToString().Trim()); //是否扩展类
objCodeTypeEN.OrderNum = TransNullToInt(objRow[conCodeType.OrderNum].ToString().Trim()); //排序
objCodeTypeEN.WinOrWeb = objRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objCodeTypeEN.IsDirByTabName = TransNullToBool(objRow[conCodeType.IsDirByTabName].ToString().Trim()); //是否用表名作为路径
objCodeTypeEN.IsDefaultOverride = TransNullToBool(objRow[conCodeType.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objCodeTypeEN.InUse = TransNullToBool(objRow[conCodeType.InUse].ToString().Trim()); //是否在用
objCodeTypeEN.IsAutoParseFile = TransNullToBool(objRow[conCodeType.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objCodeTypeEN.UpdDate = objRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objCodeTypeEN.UpdUser = objRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objCodeTypeEN.Memo = objRow[conCodeType.Memo].ToString().Trim(); //备注
objCodeTypeEN.SqlDsTypeName = objRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objCodeTypeEN.FuncCount = TransNullToInt(objRow[conCodeType.FuncCount].ToString().Trim()); //函数数目
objCodeTypeEN.AppCount = TransNullToInt(objRow[conCodeType.AppCount].ToString().Trim()); //应用数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCodeTypeDA: GetObjByDataRow)", objException.Message));
}
objCodeTypeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCodeTypeEN;
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
objSQL = clsCodeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeTypeEN._CurrTabName_S, conCodeType.CodeTypeId, 4, "");
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
objSQL = clsCodeTypeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCodeTypeEN._CurrTabName_S, conCodeType.CodeTypeId, 4, strPrefix);
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeTypeId from CodeType where " + strCondition;
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeTypeId from CodeType where " + strCondition;
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeType", "CodeTypeId = " + "'"+ strCodeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCodeTypeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CodeType", strCondition))
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
objSQL = clsCodeTypeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CodeType");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCodeTypeEN objCodeTypeEN)
 {
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeTypeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeType");
objRow = objDS.Tables["CodeType"].NewRow();
objRow[conCodeType.CodeTypeId] = objCodeTypeEN.CodeTypeId; //代码类型Id
objRow[conCodeType.CodeTypeName] = objCodeTypeEN.CodeTypeName; //代码类型名
objRow[conCodeType.CodeTypeSimName] = objCodeTypeEN.CodeTypeSimName; //简称
 if (objCodeTypeEN.CodeTypeENName !=  "")
 {
objRow[conCodeType.CodeTypeENName] = objCodeTypeEN.CodeTypeENName; //代码类型英文名
 }
 if (objCodeTypeEN.GroupName !=  "")
 {
objRow[conCodeType.GroupName] = objCodeTypeEN.GroupName; //组名
 }
objRow[conCodeType.ProgLangTypeId] = objCodeTypeEN.ProgLangTypeId; //编程语言类型Id
objRow[conCodeType.RegionTypeId] = objCodeTypeEN.RegionTypeId; //区域类型Id
 if (objCodeTypeEN.Prefix !=  "")
 {
objRow[conCodeType.Prefix] = objCodeTypeEN.Prefix; //前缀
 }
 if (objCodeTypeEN.DependsOn !=  "")
 {
objRow[conCodeType.DependsOn] = objCodeTypeEN.DependsOn; //依赖于
 }
 if (objCodeTypeEN.FrontOrBack !=  "")
 {
objRow[conCodeType.FrontOrBack] = objCodeTypeEN.FrontOrBack; //前台Or后台
 }
objRow[conCodeType.SqlDsTypeId] = objCodeTypeEN.SqlDsTypeId; //数据源类型Id
 if (objCodeTypeEN.ClassNameFormat !=  "")
 {
objRow[conCodeType.ClassNameFormat] = objCodeTypeEN.ClassNameFormat; //类名格式
 }
 if (objCodeTypeEN.ClassNameFormatEx !=  "")
 {
objRow[conCodeType.ClassNameFormatEx] = objCodeTypeEN.ClassNameFormatEx; //类名格式
 }
 if (objCodeTypeEN.FileNameFormat !=  "")
 {
objRow[conCodeType.FileNameFormat] = objCodeTypeEN.FileNameFormat; //文件名格式
 }
 if (objCodeTypeEN.ClassNamePattern !=  "")
 {
objRow[conCodeType.ClassNamePattern] = objCodeTypeEN.ClassNamePattern; //类名模式
 }
objRow[conCodeType.IsCSharp] = objCodeTypeEN.IsCSharp; //是否CSharp语言
objRow[conCodeType.IsJava] = objCodeTypeEN.IsJava; //是否Java语言
objRow[conCodeType.IsJavaScript] = objCodeTypeEN.IsJavaScript; //是否JavaScript语言
objRow[conCodeType.IsTypeScript] = objCodeTypeEN.IsTypeScript; //是否TypeScript语言
objRow[conCodeType.IsSilverLight] = objCodeTypeEN.IsSilverLight; //是否SilverLight语言
objRow[conCodeType.IsSwift] = objCodeTypeEN.IsSwift; //是否Swift语言
objRow[conCodeType.IsVB] = objCodeTypeEN.IsVB; //IsVB语言
objRow[conCodeType.IsTableFldConst] = objCodeTypeEN.IsTableFldConst; //IsTableFldConst
objRow[conCodeType.IsPubApp4WinWeb] = objCodeTypeEN.IsPubApp4WinWeb; //IsPubApp4WinWeb
objRow[conCodeType.IsWeb] = objCodeTypeEN.IsWeb; //是否Web应用
objRow[conCodeType.IsAspMvc] = objCodeTypeEN.IsAspMvc; //是否AspMvc
objRow[conCodeType.IsWebSrvAccess] = objCodeTypeEN.IsWebSrvAccess; //IsWebSrvAccess
objRow[conCodeType.IsWin] = objCodeTypeEN.IsWin; //是否Win应用
objRow[conCodeType.IsMobileApp] = objCodeTypeEN.IsMobileApp; //是否移动终端应用
objRow[conCodeType.IsExtend] = objCodeTypeEN.IsExtend; //是否扩展类
objRow[conCodeType.OrderNum] = objCodeTypeEN.OrderNum; //排序
 if (objCodeTypeEN.WinOrWeb !=  "")
 {
objRow[conCodeType.WinOrWeb] = objCodeTypeEN.WinOrWeb; //WinOrWeb
 }
objRow[conCodeType.IsDirByTabName] = objCodeTypeEN.IsDirByTabName; //是否用表名作为路径
objRow[conCodeType.IsDefaultOverride] = objCodeTypeEN.IsDefaultOverride; //是否默认覆盖
objRow[conCodeType.InUse] = objCodeTypeEN.InUse; //是否在用
objRow[conCodeType.IsAutoParseFile] = objCodeTypeEN.IsAutoParseFile; //是否自动分析文件
 if (objCodeTypeEN.UpdDate !=  "")
 {
objRow[conCodeType.UpdDate] = objCodeTypeEN.UpdDate; //修改日期
 }
 if (objCodeTypeEN.UpdUser !=  "")
 {
objRow[conCodeType.UpdUser] = objCodeTypeEN.UpdUser; //修改用户
 }
 if (objCodeTypeEN.Memo !=  "")
 {
objRow[conCodeType.Memo] = objCodeTypeEN.Memo; //备注
 }
 if (objCodeTypeEN.SqlDsTypeName !=  "")
 {
objRow[conCodeType.SqlDsTypeName] = objCodeTypeEN.SqlDsTypeName; //Sql数据源名
 }
objRow[conCodeType.FuncCount] = objCodeTypeEN.FuncCount; //函数数目
objRow[conCodeType.AppCount] = objCodeTypeEN.AppCount; //应用数
objDS.Tables[clsCodeTypeEN._CurrTabName_S].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCodeTypeEN._CurrTabName_S);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeTypeEN objCodeTypeEN)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeId);
 objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeId + "'");
 }
 
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeName);
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeSimName);
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeSimName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeENName);
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeENName + "'");
 }
 
 if (objCodeTypeEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.GroupName);
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.GroupName + "'");
 }
 
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ProgLangTypeId);
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ProgLangTypeId + "'");
 }
 
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.RegionTypeId);
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.RegionTypeId + "'");
 }
 
 if (objCodeTypeEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Prefix);
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Prefix + "'");
 }
 
 if (objCodeTypeEN.DependsOn !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.DependsOn);
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.DependsOn + "'");
 }
 
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FrontOrBack);
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FrontOrBack + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeId);
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeId + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormat);
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormatEx);
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormatEx + "'");
 }
 
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FileNameFormat);
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FileNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNamePattern);
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNamePattern + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsCSharp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJava);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJava  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJavaScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJavaScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTypeScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSilverLight);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSilverLight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSwift);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSwift  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsVB);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsVB  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTableFldConst);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTableFldConst  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsPubApp4WinWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsPubApp4WinWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAspMvc);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAspMvc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWebSrvAccess);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWebSrvAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWin);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWin  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsMobileApp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsExtend);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.OrderNum);
 arrValueListForInsert.Add(objCodeTypeEN.OrderNum.ToString());
 
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.WinOrWeb);
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.WinOrWeb + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsDirByTabName);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDirByTabName  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsDefaultOverride);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDefaultOverride  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.InUse);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAutoParseFile);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAutoParseFile  ==  false ? "0" : "1") + "'");
 
 if (objCodeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdDate);
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdDate + "'");
 }
 
 if (objCodeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdUser);
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdUser + "'");
 }
 
 if (objCodeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Memo);
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Memo + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeName);
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.FuncCount);
 arrValueListForInsert.Add(objCodeTypeEN.FuncCount.ToString());
 
 arrFieldListForInsert.Add(conCodeType.AppCount);
 arrValueListForInsert.Add(objCodeTypeEN.AppCount.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeTypeEN objCodeTypeEN)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeId);
 objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeId + "'");
 }
 
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeName);
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeSimName);
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeSimName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeENName);
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeENName + "'");
 }
 
 if (objCodeTypeEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.GroupName);
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.GroupName + "'");
 }
 
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ProgLangTypeId);
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ProgLangTypeId + "'");
 }
 
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.RegionTypeId);
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.RegionTypeId + "'");
 }
 
 if (objCodeTypeEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Prefix);
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Prefix + "'");
 }
 
 if (objCodeTypeEN.DependsOn !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.DependsOn);
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.DependsOn + "'");
 }
 
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FrontOrBack);
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FrontOrBack + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeId);
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeId + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormat);
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormatEx);
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormatEx + "'");
 }
 
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FileNameFormat);
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FileNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNamePattern);
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNamePattern + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsCSharp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJava);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJava  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJavaScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJavaScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTypeScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSilverLight);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSilverLight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSwift);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSwift  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsVB);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsVB  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTableFldConst);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTableFldConst  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsPubApp4WinWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsPubApp4WinWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAspMvc);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAspMvc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWebSrvAccess);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWebSrvAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWin);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWin  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsMobileApp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsExtend);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.OrderNum);
 arrValueListForInsert.Add(objCodeTypeEN.OrderNum.ToString());
 
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.WinOrWeb);
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.WinOrWeb + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsDirByTabName);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDirByTabName  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsDefaultOverride);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDefaultOverride  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.InUse);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAutoParseFile);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAutoParseFile  ==  false ? "0" : "1") + "'");
 
 if (objCodeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdDate);
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdDate + "'");
 }
 
 if (objCodeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdUser);
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdUser + "'");
 }
 
 if (objCodeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Memo);
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Memo + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeName);
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.FuncCount);
 arrValueListForInsert.Add(objCodeTypeEN.FuncCount.ToString());
 
 arrFieldListForInsert.Add(conCodeType.AppCount);
 arrValueListForInsert.Add(objCodeTypeEN.AppCount.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCodeTypeEN.CodeTypeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCodeTypeEN objCodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeTypeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeId);
 objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeId + "'");
 }
 
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeName);
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeSimName);
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeSimName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeENName);
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeENName + "'");
 }
 
 if (objCodeTypeEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.GroupName);
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.GroupName + "'");
 }
 
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ProgLangTypeId);
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ProgLangTypeId + "'");
 }
 
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.RegionTypeId);
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.RegionTypeId + "'");
 }
 
 if (objCodeTypeEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Prefix);
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Prefix + "'");
 }
 
 if (objCodeTypeEN.DependsOn !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.DependsOn);
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.DependsOn + "'");
 }
 
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FrontOrBack);
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FrontOrBack + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeId);
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeId + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormat);
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormatEx);
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormatEx + "'");
 }
 
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FileNameFormat);
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FileNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNamePattern);
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNamePattern + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsCSharp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJava);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJava  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJavaScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJavaScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTypeScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSilverLight);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSilverLight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSwift);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSwift  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsVB);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsVB  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTableFldConst);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTableFldConst  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsPubApp4WinWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsPubApp4WinWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAspMvc);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAspMvc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWebSrvAccess);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWebSrvAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWin);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWin  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsMobileApp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsExtend);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.OrderNum);
 arrValueListForInsert.Add(objCodeTypeEN.OrderNum.ToString());
 
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.WinOrWeb);
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.WinOrWeb + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsDirByTabName);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDirByTabName  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsDefaultOverride);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDefaultOverride  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.InUse);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAutoParseFile);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAutoParseFile  ==  false ? "0" : "1") + "'");
 
 if (objCodeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdDate);
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdDate + "'");
 }
 
 if (objCodeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdUser);
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdUser + "'");
 }
 
 if (objCodeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Memo);
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Memo + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeName);
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.FuncCount);
 arrValueListForInsert.Add(objCodeTypeEN.FuncCount.ToString());
 
 arrFieldListForInsert.Add(conCodeType.AppCount);
 arrValueListForInsert.Add(objCodeTypeEN.AppCount.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeType");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCodeTypeEN.CodeTypeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCodeTypeEN objCodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCodeTypeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCodeTypeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeId);
 objCodeTypeEN.CodeTypeId = objCodeTypeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeId + "'");
 }
 
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeName);
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeSimName);
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeSimName + "'");
 }
 
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.CodeTypeENName);
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.CodeTypeENName + "'");
 }
 
 if (objCodeTypeEN.GroupName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.GroupName);
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.GroupName + "'");
 }
 
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ProgLangTypeId);
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ProgLangTypeId + "'");
 }
 
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.RegionTypeId);
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.RegionTypeId + "'");
 }
 
 if (objCodeTypeEN.Prefix !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Prefix);
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Prefix + "'");
 }
 
 if (objCodeTypeEN.DependsOn !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.DependsOn);
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.DependsOn + "'");
 }
 
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FrontOrBack);
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FrontOrBack + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeId);
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeId + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormat);
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNameFormatEx);
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNameFormatEx + "'");
 }
 
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.FileNameFormat);
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.FileNameFormat + "'");
 }
 
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.ClassNamePattern);
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.ClassNamePattern + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsCSharp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsCSharp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJava);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJava  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsJavaScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsJavaScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTypeScript);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTypeScript  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSilverLight);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSilverLight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsSwift);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsSwift  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsVB);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsVB  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsTableFldConst);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsTableFldConst  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsPubApp4WinWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsPubApp4WinWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWeb);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAspMvc);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAspMvc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWebSrvAccess);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWebSrvAccess  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsWin);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsWin  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsMobileApp);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsMobileApp  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsExtend);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsExtend  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.OrderNum);
 arrValueListForInsert.Add(objCodeTypeEN.OrderNum.ToString());
 
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.WinOrWeb);
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.WinOrWeb + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.IsDirByTabName);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDirByTabName  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsDefaultOverride);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsDefaultOverride  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.InUse);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.InUse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCodeType.IsAutoParseFile);
 arrValueListForInsert.Add("'" + (objCodeTypeEN.IsAutoParseFile  ==  false ? "0" : "1") + "'");
 
 if (objCodeTypeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdDate);
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdDate + "'");
 }
 
 if (objCodeTypeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.UpdUser);
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.UpdUser + "'");
 }
 
 if (objCodeTypeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.Memo);
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.Memo + "'");
 }
 
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conCodeType.SqlDsTypeName);
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + objCodeTypeEN.SqlDsTypeName + "'");
 }
 
 arrFieldListForInsert.Add(conCodeType.FuncCount);
 arrValueListForInsert.Add(objCodeTypeEN.FuncCount.ToString());
 
 arrFieldListForInsert.Add(conCodeType.AppCount);
 arrValueListForInsert.Add(objCodeTypeEN.AppCount.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CodeType");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCodeTypes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where CodeTypeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CodeType");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCodeTypeId = oRow[conCodeType.CodeTypeId].ToString().Trim();
if (IsExist(strCodeTypeId))
{
 string strResult = "关键字变量值为:" + string.Format("CodeTypeId = {0}", strCodeTypeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCodeTypeEN._CurrTabName_S ].NewRow();
objRow[conCodeType.CodeTypeId] = oRow[conCodeType.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conCodeType.CodeTypeName] = oRow[conCodeType.CodeTypeName].ToString().Trim(); //代码类型名
objRow[conCodeType.CodeTypeSimName] = oRow[conCodeType.CodeTypeSimName].ToString().Trim(); //简称
objRow[conCodeType.CodeTypeENName] = oRow[conCodeType.CodeTypeENName].ToString().Trim(); //代码类型英文名
objRow[conCodeType.GroupName] = oRow[conCodeType.GroupName].ToString().Trim(); //组名
objRow[conCodeType.ProgLangTypeId] = oRow[conCodeType.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conCodeType.RegionTypeId] = oRow[conCodeType.RegionTypeId].ToString().Trim(); //区域类型Id
objRow[conCodeType.Prefix] = oRow[conCodeType.Prefix].ToString().Trim(); //前缀
objRow[conCodeType.DependsOn] = oRow[conCodeType.DependsOn].ToString().Trim(); //依赖于
objRow[conCodeType.FrontOrBack] = oRow[conCodeType.FrontOrBack].ToString().Trim(); //前台Or后台
objRow[conCodeType.SqlDsTypeId] = oRow[conCodeType.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objRow[conCodeType.ClassNameFormat] = oRow[conCodeType.ClassNameFormat].ToString().Trim(); //类名格式
objRow[conCodeType.ClassNameFormatEx] = oRow[conCodeType.ClassNameFormatEx].ToString().Trim(); //类名格式
objRow[conCodeType.FileNameFormat] = oRow[conCodeType.FileNameFormat].ToString().Trim(); //文件名格式
objRow[conCodeType.ClassNamePattern] = oRow[conCodeType.ClassNamePattern].ToString().Trim(); //类名模式
objRow[conCodeType.IsCSharp] = oRow[conCodeType.IsCSharp].ToString().Trim(); //是否CSharp语言
objRow[conCodeType.IsJava] = oRow[conCodeType.IsJava].ToString().Trim(); //是否Java语言
objRow[conCodeType.IsJavaScript] = oRow[conCodeType.IsJavaScript].ToString().Trim(); //是否JavaScript语言
objRow[conCodeType.IsTypeScript] = oRow[conCodeType.IsTypeScript].ToString().Trim(); //是否TypeScript语言
objRow[conCodeType.IsSilverLight] = oRow[conCodeType.IsSilverLight].ToString().Trim(); //是否SilverLight语言
objRow[conCodeType.IsSwift] = oRow[conCodeType.IsSwift].ToString().Trim(); //是否Swift语言
objRow[conCodeType.IsVB] = oRow[conCodeType.IsVB].ToString().Trim(); //IsVB语言
objRow[conCodeType.IsTableFldConst] = oRow[conCodeType.IsTableFldConst].ToString().Trim(); //IsTableFldConst
objRow[conCodeType.IsPubApp4WinWeb] = oRow[conCodeType.IsPubApp4WinWeb].ToString().Trim(); //IsPubApp4WinWeb
objRow[conCodeType.IsWeb] = oRow[conCodeType.IsWeb].ToString().Trim(); //是否Web应用
objRow[conCodeType.IsAspMvc] = oRow[conCodeType.IsAspMvc].ToString().Trim(); //是否AspMvc
objRow[conCodeType.IsWebSrvAccess] = oRow[conCodeType.IsWebSrvAccess].ToString().Trim(); //IsWebSrvAccess
objRow[conCodeType.IsWin] = oRow[conCodeType.IsWin].ToString().Trim(); //是否Win应用
objRow[conCodeType.IsMobileApp] = oRow[conCodeType.IsMobileApp].ToString().Trim(); //是否移动终端应用
objRow[conCodeType.IsExtend] = oRow[conCodeType.IsExtend].ToString().Trim(); //是否扩展类
objRow[conCodeType.OrderNum] = oRow[conCodeType.OrderNum].ToString().Trim(); //排序
objRow[conCodeType.WinOrWeb] = oRow[conCodeType.WinOrWeb].ToString().Trim(); //WinOrWeb
objRow[conCodeType.IsDirByTabName] = oRow[conCodeType.IsDirByTabName].ToString().Trim(); //是否用表名作为路径
objRow[conCodeType.IsDefaultOverride] = oRow[conCodeType.IsDefaultOverride].ToString().Trim(); //是否默认覆盖
objRow[conCodeType.InUse] = oRow[conCodeType.InUse].ToString().Trim(); //是否在用
objRow[conCodeType.IsAutoParseFile] = oRow[conCodeType.IsAutoParseFile].ToString().Trim(); //是否自动分析文件
objRow[conCodeType.UpdDate] = oRow[conCodeType.UpdDate].ToString().Trim(); //修改日期
objRow[conCodeType.UpdUser] = oRow[conCodeType.UpdUser].ToString().Trim(); //修改用户
objRow[conCodeType.Memo] = oRow[conCodeType.Memo].ToString().Trim(); //备注
objRow[conCodeType.SqlDsTypeName] = oRow[conCodeType.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objRow[conCodeType.FuncCount] = oRow[conCodeType.FuncCount].ToString().Trim(); //函数数目
objRow[conCodeType.AppCount] = oRow[conCodeType.AppCount].ToString().Trim(); //应用数
 objDS.Tables[clsCodeTypeEN._CurrTabName_S].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCodeTypeEN._CurrTabName_S);
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
 /// <param name = "objCodeTypeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCodeTypeEN objCodeTypeEN)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeTypeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
strSQL = "Select * from CodeType where CodeTypeId = " + "'"+ objCodeTypeEN.CodeTypeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCodeTypeEN._CurrTabName_S);
if (objDS.Tables[clsCodeTypeEN._CurrTabName_S].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CodeTypeId = " + "'"+ objCodeTypeEN.CodeTypeId+"'");
return false;
}
objRow = objDS.Tables[clsCodeTypeEN._CurrTabName_S].Rows[0];
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeId))
 {
objRow[conCodeType.CodeTypeId] = objCodeTypeEN.CodeTypeId; //代码类型Id
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeName))
 {
objRow[conCodeType.CodeTypeName] = objCodeTypeEN.CodeTypeName; //代码类型名
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeSimName))
 {
objRow[conCodeType.CodeTypeSimName] = objCodeTypeEN.CodeTypeSimName; //简称
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeENName))
 {
objRow[conCodeType.CodeTypeENName] = objCodeTypeEN.CodeTypeENName; //代码类型英文名
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.GroupName))
 {
objRow[conCodeType.GroupName] = objCodeTypeEN.GroupName; //组名
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.ProgLangTypeId))
 {
objRow[conCodeType.ProgLangTypeId] = objCodeTypeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.RegionTypeId))
 {
objRow[conCodeType.RegionTypeId] = objCodeTypeEN.RegionTypeId; //区域类型Id
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.Prefix))
 {
objRow[conCodeType.Prefix] = objCodeTypeEN.Prefix; //前缀
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.DependsOn))
 {
objRow[conCodeType.DependsOn] = objCodeTypeEN.DependsOn; //依赖于
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.FrontOrBack))
 {
objRow[conCodeType.FrontOrBack] = objCodeTypeEN.FrontOrBack; //前台Or后台
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeId))
 {
objRow[conCodeType.SqlDsTypeId] = objCodeTypeEN.SqlDsTypeId; //数据源类型Id
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormat))
 {
objRow[conCodeType.ClassNameFormat] = objCodeTypeEN.ClassNameFormat; //类名格式
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormatEx))
 {
objRow[conCodeType.ClassNameFormatEx] = objCodeTypeEN.ClassNameFormatEx; //类名格式
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.FileNameFormat))
 {
objRow[conCodeType.FileNameFormat] = objCodeTypeEN.FileNameFormat; //文件名格式
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNamePattern))
 {
objRow[conCodeType.ClassNamePattern] = objCodeTypeEN.ClassNamePattern; //类名模式
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsCSharp))
 {
objRow[conCodeType.IsCSharp] = objCodeTypeEN.IsCSharp; //是否CSharp语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJava))
 {
objRow[conCodeType.IsJava] = objCodeTypeEN.IsJava; //是否Java语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJavaScript))
 {
objRow[conCodeType.IsJavaScript] = objCodeTypeEN.IsJavaScript; //是否JavaScript语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTypeScript))
 {
objRow[conCodeType.IsTypeScript] = objCodeTypeEN.IsTypeScript; //是否TypeScript语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSilverLight))
 {
objRow[conCodeType.IsSilverLight] = objCodeTypeEN.IsSilverLight; //是否SilverLight语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSwift))
 {
objRow[conCodeType.IsSwift] = objCodeTypeEN.IsSwift; //是否Swift语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsVB))
 {
objRow[conCodeType.IsVB] = objCodeTypeEN.IsVB; //IsVB语言
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTableFldConst))
 {
objRow[conCodeType.IsTableFldConst] = objCodeTypeEN.IsTableFldConst; //IsTableFldConst
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsPubApp4WinWeb))
 {
objRow[conCodeType.IsPubApp4WinWeb] = objCodeTypeEN.IsPubApp4WinWeb; //IsPubApp4WinWeb
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWeb))
 {
objRow[conCodeType.IsWeb] = objCodeTypeEN.IsWeb; //是否Web应用
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAspMvc))
 {
objRow[conCodeType.IsAspMvc] = objCodeTypeEN.IsAspMvc; //是否AspMvc
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWebSrvAccess))
 {
objRow[conCodeType.IsWebSrvAccess] = objCodeTypeEN.IsWebSrvAccess; //IsWebSrvAccess
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWin))
 {
objRow[conCodeType.IsWin] = objCodeTypeEN.IsWin; //是否Win应用
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsMobileApp))
 {
objRow[conCodeType.IsMobileApp] = objCodeTypeEN.IsMobileApp; //是否移动终端应用
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsExtend))
 {
objRow[conCodeType.IsExtend] = objCodeTypeEN.IsExtend; //是否扩展类
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.OrderNum))
 {
objRow[conCodeType.OrderNum] = objCodeTypeEN.OrderNum; //排序
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.WinOrWeb))
 {
objRow[conCodeType.WinOrWeb] = objCodeTypeEN.WinOrWeb; //WinOrWeb
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDirByTabName))
 {
objRow[conCodeType.IsDirByTabName] = objCodeTypeEN.IsDirByTabName; //是否用表名作为路径
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDefaultOverride))
 {
objRow[conCodeType.IsDefaultOverride] = objCodeTypeEN.IsDefaultOverride; //是否默认覆盖
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.InUse))
 {
objRow[conCodeType.InUse] = objCodeTypeEN.InUse; //是否在用
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAutoParseFile))
 {
objRow[conCodeType.IsAutoParseFile] = objCodeTypeEN.IsAutoParseFile; //是否自动分析文件
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdDate))
 {
objRow[conCodeType.UpdDate] = objCodeTypeEN.UpdDate; //修改日期
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdUser))
 {
objRow[conCodeType.UpdUser] = objCodeTypeEN.UpdUser; //修改用户
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.Memo))
 {
objRow[conCodeType.Memo] = objCodeTypeEN.Memo; //备注
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeName))
 {
objRow[conCodeType.SqlDsTypeName] = objCodeTypeEN.SqlDsTypeName; //Sql数据源名
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.FuncCount))
 {
objRow[conCodeType.FuncCount] = objCodeTypeEN.FuncCount; //函数数目
 }
 if (objCodeTypeEN.IsUpdated(conCodeType.AppCount))
 {
objRow[conCodeType.AppCount] = objCodeTypeEN.AppCount; //应用数
 }
try
{
objDA.Update(objDS, clsCodeTypeEN._CurrTabName_S);
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeTypeEN objCodeTypeEN)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CodeType Set ");
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeName))
 {
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeName, conCodeType.CodeTypeName); //代码类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeName); //代码类型名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeSimName))
 {
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeSimName, conCodeType.CodeTypeSimName); //简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeSimName); //简称
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeENName))
 {
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeENName, conCodeType.CodeTypeENName); //代码类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeENName); //代码类型英文名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.GroupName))
 {
 if (objCodeTypeEN.GroupName !=  null)
 {
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.GroupName, conCodeType.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.GroupName); //组名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ProgLangTypeId))
 {
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ProgLangTypeId, conCodeType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.RegionTypeId))
 {
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.RegionTypeId, conCodeType.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.RegionTypeId); //区域类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Prefix))
 {
 if (objCodeTypeEN.Prefix !=  null)
 {
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.Prefix, conCodeType.Prefix); //前缀
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.Prefix); //前缀
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.DependsOn))
 {
 if (objCodeTypeEN.DependsOn !=  null)
 {
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.DependsOn, conCodeType.DependsOn); //依赖于
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.DependsOn); //依赖于
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FrontOrBack))
 {
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.FrontOrBack, conCodeType.FrontOrBack); //前台Or后台
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.FrontOrBack); //前台Or后台
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeId))
 {
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.SqlDsTypeId, conCodeType.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormat))
 {
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNameFormat, conCodeType.ClassNameFormat); //类名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNameFormat); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormatEx))
 {
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNameFormatEx, conCodeType.ClassNameFormatEx); //类名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNameFormatEx); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FileNameFormat))
 {
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.FileNameFormat, conCodeType.FileNameFormat); //文件名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.FileNameFormat); //文件名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNamePattern))
 {
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNamePattern, conCodeType.ClassNamePattern); //类名模式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNamePattern); //类名模式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsCSharp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsCSharp == true?"1":"0", conCodeType.IsCSharp); //是否CSharp语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJava))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsJava == true?"1":"0", conCodeType.IsJava); //是否Java语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJavaScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsJavaScript == true?"1":"0", conCodeType.IsJavaScript); //是否JavaScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTypeScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsTypeScript == true?"1":"0", conCodeType.IsTypeScript); //是否TypeScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSilverLight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsSilverLight == true?"1":"0", conCodeType.IsSilverLight); //是否SilverLight语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSwift))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsSwift == true?"1":"0", conCodeType.IsSwift); //是否Swift语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsVB))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsVB == true?"1":"0", conCodeType.IsVB); //IsVB语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTableFldConst))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsTableFldConst == true?"1":"0", conCodeType.IsTableFldConst); //IsTableFldConst
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsPubApp4WinWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsPubApp4WinWeb == true?"1":"0", conCodeType.IsPubApp4WinWeb); //IsPubApp4WinWeb
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWeb == true?"1":"0", conCodeType.IsWeb); //是否Web应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAspMvc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsAspMvc == true?"1":"0", conCodeType.IsAspMvc); //是否AspMvc
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWebSrvAccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWebSrvAccess == true?"1":"0", conCodeType.IsWebSrvAccess); //IsWebSrvAccess
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWin))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWin == true?"1":"0", conCodeType.IsWin); //是否Win应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsMobileApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsMobileApp == true?"1":"0", conCodeType.IsMobileApp); //是否移动终端应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsExtend == true?"1":"0", conCodeType.IsExtend); //是否扩展类
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.OrderNum, conCodeType.OrderNum); //排序
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.WinOrWeb))
 {
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.WinOrWeb, conCodeType.WinOrWeb); //WinOrWeb
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.WinOrWeb); //WinOrWeb
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDirByTabName))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsDirByTabName == true?"1":"0", conCodeType.IsDirByTabName); //是否用表名作为路径
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDefaultOverride))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsDefaultOverride == true?"1":"0", conCodeType.IsDefaultOverride); //是否默认覆盖
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.InUse == true?"1":"0", conCodeType.InUse); //是否在用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAutoParseFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsAutoParseFile == true?"1":"0", conCodeType.IsAutoParseFile); //是否自动分析文件
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdDate))
 {
 if (objCodeTypeEN.UpdDate !=  null)
 {
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.UpdDate, conCodeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.UpdDate); //修改日期
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdUser))
 {
 if (objCodeTypeEN.UpdUser !=  null)
 {
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.UpdUser, conCodeType.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.UpdUser); //修改用户
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Memo))
 {
 if (objCodeTypeEN.Memo !=  null)
 {
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.Memo, conCodeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.Memo); //备注
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeName))
 {
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.SqlDsTypeName, conCodeType.SqlDsTypeName); //Sql数据源名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.SqlDsTypeName); //Sql数据源名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FuncCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.FuncCount, conCodeType.FuncCount); //函数数目
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.AppCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.AppCount, conCodeType.AppCount); //应用数
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeTypeId = '{0}'", objCodeTypeEN.CodeTypeId); 
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCodeTypeEN objCodeTypeEN, string strCondition)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeType Set ");
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeName))
 {
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeName = '{0}',", objCodeTypeEN.CodeTypeName); //代码类型名
 }
 else
 {
 sbSQL.Append(" CodeTypeName = null,"); //代码类型名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeSimName))
 {
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeSimName = '{0}',", objCodeTypeEN.CodeTypeSimName); //简称
 }
 else
 {
 sbSQL.Append(" CodeTypeSimName = null,"); //简称
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeENName))
 {
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeENName = '{0}',", objCodeTypeEN.CodeTypeENName); //代码类型英文名
 }
 else
 {
 sbSQL.Append(" CodeTypeENName = null,"); //代码类型英文名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.GroupName))
 {
 if (objCodeTypeEN.GroupName !=  null)
 {
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", objCodeTypeEN.GroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ProgLangTypeId))
 {
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", objCodeTypeEN.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.RegionTypeId))
 {
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", objCodeTypeEN.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Prefix))
 {
 if (objCodeTypeEN.Prefix !=  null)
 {
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", objCodeTypeEN.Prefix); //前缀
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //前缀
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.DependsOn))
 {
 if (objCodeTypeEN.DependsOn !=  null)
 {
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DependsOn = '{0}',", objCodeTypeEN.DependsOn); //依赖于
 }
 else
 {
 sbSQL.Append(" DependsOn = null,"); //依赖于
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FrontOrBack))
 {
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FrontOrBack = '{0}',", objCodeTypeEN.FrontOrBack); //前台Or后台
 }
 else
 {
 sbSQL.Append(" FrontOrBack = null,"); //前台Or后台
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeId))
 {
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", objCodeTypeEN.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormat))
 {
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameFormat = '{0}',", objCodeTypeEN.ClassNameFormat); //类名格式
 }
 else
 {
 sbSQL.Append(" ClassNameFormat = null,"); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormatEx))
 {
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameFormatEx = '{0}',", objCodeTypeEN.ClassNameFormatEx); //类名格式
 }
 else
 {
 sbSQL.Append(" ClassNameFormatEx = null,"); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FileNameFormat))
 {
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNameFormat = '{0}',", objCodeTypeEN.FileNameFormat); //文件名格式
 }
 else
 {
 sbSQL.Append(" FileNameFormat = null,"); //文件名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNamePattern))
 {
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNamePattern = '{0}',", objCodeTypeEN.ClassNamePattern); //类名模式
 }
 else
 {
 sbSQL.Append(" ClassNamePattern = null,"); //类名模式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsCSharp))
 {
 sbSQL.AppendFormat(" IsCSharp = '{0}',", objCodeTypeEN.IsCSharp == true?"1":"0"); //是否CSharp语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJava))
 {
 sbSQL.AppendFormat(" IsJava = '{0}',", objCodeTypeEN.IsJava == true?"1":"0"); //是否Java语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJavaScript))
 {
 sbSQL.AppendFormat(" IsJavaScript = '{0}',", objCodeTypeEN.IsJavaScript == true?"1":"0"); //是否JavaScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTypeScript))
 {
 sbSQL.AppendFormat(" IsTypeScript = '{0}',", objCodeTypeEN.IsTypeScript == true?"1":"0"); //是否TypeScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSilverLight))
 {
 sbSQL.AppendFormat(" IsSilverLight = '{0}',", objCodeTypeEN.IsSilverLight == true?"1":"0"); //是否SilverLight语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSwift))
 {
 sbSQL.AppendFormat(" IsSwift = '{0}',", objCodeTypeEN.IsSwift == true?"1":"0"); //是否Swift语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsVB))
 {
 sbSQL.AppendFormat(" IsVB = '{0}',", objCodeTypeEN.IsVB == true?"1":"0"); //IsVB语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTableFldConst))
 {
 sbSQL.AppendFormat(" IsTableFldConst = '{0}',", objCodeTypeEN.IsTableFldConst == true?"1":"0"); //IsTableFldConst
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsPubApp4WinWeb))
 {
 sbSQL.AppendFormat(" IsPubApp4WinWeb = '{0}',", objCodeTypeEN.IsPubApp4WinWeb == true?"1":"0"); //IsPubApp4WinWeb
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWeb))
 {
 sbSQL.AppendFormat(" IsWeb = '{0}',", objCodeTypeEN.IsWeb == true?"1":"0"); //是否Web应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAspMvc))
 {
 sbSQL.AppendFormat(" IsAspMvc = '{0}',", objCodeTypeEN.IsAspMvc == true?"1":"0"); //是否AspMvc
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWebSrvAccess))
 {
 sbSQL.AppendFormat(" IsWebSrvAccess = '{0}',", objCodeTypeEN.IsWebSrvAccess == true?"1":"0"); //IsWebSrvAccess
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWin))
 {
 sbSQL.AppendFormat(" IsWin = '{0}',", objCodeTypeEN.IsWin == true?"1":"0"); //是否Win应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsMobileApp))
 {
 sbSQL.AppendFormat(" IsMobileApp = '{0}',", objCodeTypeEN.IsMobileApp == true?"1":"0"); //是否移动终端应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objCodeTypeEN.IsExtend == true?"1":"0"); //是否扩展类
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCodeTypeEN.OrderNum); //排序
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.WinOrWeb))
 {
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WinOrWeb = '{0}',", objCodeTypeEN.WinOrWeb); //WinOrWeb
 }
 else
 {
 sbSQL.Append(" WinOrWeb = null,"); //WinOrWeb
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDirByTabName))
 {
 sbSQL.AppendFormat(" IsDirByTabName = '{0}',", objCodeTypeEN.IsDirByTabName == true?"1":"0"); //是否用表名作为路径
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDefaultOverride))
 {
 sbSQL.AppendFormat(" IsDefaultOverride = '{0}',", objCodeTypeEN.IsDefaultOverride == true?"1":"0"); //是否默认覆盖
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCodeTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAutoParseFile))
 {
 sbSQL.AppendFormat(" IsAutoParseFile = '{0}',", objCodeTypeEN.IsAutoParseFile == true?"1":"0"); //是否自动分析文件
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdDate))
 {
 if (objCodeTypeEN.UpdDate !=  null)
 {
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objCodeTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdUser))
 {
 if (objCodeTypeEN.UpdUser !=  null)
 {
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objCodeTypeEN.UpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Memo))
 {
 if (objCodeTypeEN.Memo !=  null)
 {
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objCodeTypeEN.Memo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeName))
 {
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeName = '{0}',", objCodeTypeEN.SqlDsTypeName); //Sql数据源名
 }
 else
 {
 sbSQL.Append(" SqlDsTypeName = null,"); //Sql数据源名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FuncCount))
 {
 sbSQL.AppendFormat(" FuncCount = {0},", objCodeTypeEN.FuncCount); //函数数目
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.AppCount))
 {
 sbSQL.AppendFormat(" AppCount = {0},", objCodeTypeEN.AppCount); //应用数
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
 /// <param name = "objCodeTypeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCodeTypeEN objCodeTypeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeType Set ");
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeName))
 {
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeName = '{0}',", objCodeTypeEN.CodeTypeName); //代码类型名
 }
 else
 {
 sbSQL.Append(" CodeTypeName = null,"); //代码类型名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeSimName))
 {
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeSimName = '{0}',", objCodeTypeEN.CodeTypeSimName); //简称
 }
 else
 {
 sbSQL.Append(" CodeTypeSimName = null,"); //简称
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeENName))
 {
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeENName = '{0}',", objCodeTypeEN.CodeTypeENName); //代码类型英文名
 }
 else
 {
 sbSQL.Append(" CodeTypeENName = null,"); //代码类型英文名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.GroupName))
 {
 if (objCodeTypeEN.GroupName !=  null)
 {
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupName = '{0}',", objCodeTypeEN.GroupName); //组名
 }
 else
 {
 sbSQL.Append(" GroupName = null,"); //组名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ProgLangTypeId))
 {
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", objCodeTypeEN.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.RegionTypeId))
 {
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegionTypeId = '{0}',", objCodeTypeEN.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.Append(" RegionTypeId = null,"); //区域类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Prefix))
 {
 if (objCodeTypeEN.Prefix !=  null)
 {
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Prefix = '{0}',", objCodeTypeEN.Prefix); //前缀
 }
 else
 {
 sbSQL.Append(" Prefix = null,"); //前缀
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.DependsOn))
 {
 if (objCodeTypeEN.DependsOn !=  null)
 {
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DependsOn = '{0}',", objCodeTypeEN.DependsOn); //依赖于
 }
 else
 {
 sbSQL.Append(" DependsOn = null,"); //依赖于
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FrontOrBack))
 {
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FrontOrBack = '{0}',", objCodeTypeEN.FrontOrBack); //前台Or后台
 }
 else
 {
 sbSQL.Append(" FrontOrBack = null,"); //前台Or后台
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeId))
 {
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", objCodeTypeEN.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormat))
 {
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameFormat = '{0}',", objCodeTypeEN.ClassNameFormat); //类名格式
 }
 else
 {
 sbSQL.Append(" ClassNameFormat = null,"); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormatEx))
 {
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNameFormatEx = '{0}',", objCodeTypeEN.ClassNameFormatEx); //类名格式
 }
 else
 {
 sbSQL.Append(" ClassNameFormatEx = null,"); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FileNameFormat))
 {
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileNameFormat = '{0}',", objCodeTypeEN.FileNameFormat); //文件名格式
 }
 else
 {
 sbSQL.Append(" FileNameFormat = null,"); //文件名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNamePattern))
 {
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassNamePattern = '{0}',", objCodeTypeEN.ClassNamePattern); //类名模式
 }
 else
 {
 sbSQL.Append(" ClassNamePattern = null,"); //类名模式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsCSharp))
 {
 sbSQL.AppendFormat(" IsCSharp = '{0}',", objCodeTypeEN.IsCSharp == true?"1":"0"); //是否CSharp语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJava))
 {
 sbSQL.AppendFormat(" IsJava = '{0}',", objCodeTypeEN.IsJava == true?"1":"0"); //是否Java语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJavaScript))
 {
 sbSQL.AppendFormat(" IsJavaScript = '{0}',", objCodeTypeEN.IsJavaScript == true?"1":"0"); //是否JavaScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTypeScript))
 {
 sbSQL.AppendFormat(" IsTypeScript = '{0}',", objCodeTypeEN.IsTypeScript == true?"1":"0"); //是否TypeScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSilverLight))
 {
 sbSQL.AppendFormat(" IsSilverLight = '{0}',", objCodeTypeEN.IsSilverLight == true?"1":"0"); //是否SilverLight语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSwift))
 {
 sbSQL.AppendFormat(" IsSwift = '{0}',", objCodeTypeEN.IsSwift == true?"1":"0"); //是否Swift语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsVB))
 {
 sbSQL.AppendFormat(" IsVB = '{0}',", objCodeTypeEN.IsVB == true?"1":"0"); //IsVB语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTableFldConst))
 {
 sbSQL.AppendFormat(" IsTableFldConst = '{0}',", objCodeTypeEN.IsTableFldConst == true?"1":"0"); //IsTableFldConst
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsPubApp4WinWeb))
 {
 sbSQL.AppendFormat(" IsPubApp4WinWeb = '{0}',", objCodeTypeEN.IsPubApp4WinWeb == true?"1":"0"); //IsPubApp4WinWeb
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWeb))
 {
 sbSQL.AppendFormat(" IsWeb = '{0}',", objCodeTypeEN.IsWeb == true?"1":"0"); //是否Web应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAspMvc))
 {
 sbSQL.AppendFormat(" IsAspMvc = '{0}',", objCodeTypeEN.IsAspMvc == true?"1":"0"); //是否AspMvc
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWebSrvAccess))
 {
 sbSQL.AppendFormat(" IsWebSrvAccess = '{0}',", objCodeTypeEN.IsWebSrvAccess == true?"1":"0"); //IsWebSrvAccess
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWin))
 {
 sbSQL.AppendFormat(" IsWin = '{0}',", objCodeTypeEN.IsWin == true?"1":"0"); //是否Win应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsMobileApp))
 {
 sbSQL.AppendFormat(" IsMobileApp = '{0}',", objCodeTypeEN.IsMobileApp == true?"1":"0"); //是否移动终端应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsExtend))
 {
 sbSQL.AppendFormat(" IsExtend = '{0}',", objCodeTypeEN.IsExtend == true?"1":"0"); //是否扩展类
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objCodeTypeEN.OrderNum); //排序
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.WinOrWeb))
 {
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WinOrWeb = '{0}',", objCodeTypeEN.WinOrWeb); //WinOrWeb
 }
 else
 {
 sbSQL.Append(" WinOrWeb = null,"); //WinOrWeb
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDirByTabName))
 {
 sbSQL.AppendFormat(" IsDirByTabName = '{0}',", objCodeTypeEN.IsDirByTabName == true?"1":"0"); //是否用表名作为路径
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDefaultOverride))
 {
 sbSQL.AppendFormat(" IsDefaultOverride = '{0}',", objCodeTypeEN.IsDefaultOverride == true?"1":"0"); //是否默认覆盖
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objCodeTypeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAutoParseFile))
 {
 sbSQL.AppendFormat(" IsAutoParseFile = '{0}',", objCodeTypeEN.IsAutoParseFile == true?"1":"0"); //是否自动分析文件
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdDate))
 {
 if (objCodeTypeEN.UpdDate !=  null)
 {
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", objCodeTypeEN.UpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdUser))
 {
 if (objCodeTypeEN.UpdUser !=  null)
 {
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", objCodeTypeEN.UpdUser); //修改用户
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改用户
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Memo))
 {
 if (objCodeTypeEN.Memo !=  null)
 {
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", objCodeTypeEN.Memo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeName))
 {
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeName = '{0}',", objCodeTypeEN.SqlDsTypeName); //Sql数据源名
 }
 else
 {
 sbSQL.Append(" SqlDsTypeName = null,"); //Sql数据源名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FuncCount))
 {
 sbSQL.AppendFormat(" FuncCount = {0},", objCodeTypeEN.FuncCount); //函数数目
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.AppCount))
 {
 sbSQL.AppendFormat(" AppCount = {0},", objCodeTypeEN.AppCount); //应用数
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
 /// <param name = "objCodeTypeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCodeTypeEN objCodeTypeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCodeTypeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCodeTypeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCodeTypeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CodeType Set ");
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeName))
 {
 if (objCodeTypeEN.CodeTypeName !=  null)
 {
 objCodeTypeEN.CodeTypeName = objCodeTypeEN.CodeTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeName, conCodeType.CodeTypeName); //代码类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeName); //代码类型名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeSimName))
 {
 if (objCodeTypeEN.CodeTypeSimName !=  null)
 {
 objCodeTypeEN.CodeTypeSimName = objCodeTypeEN.CodeTypeSimName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeSimName, conCodeType.CodeTypeSimName); //简称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeSimName); //简称
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.CodeTypeENName))
 {
 if (objCodeTypeEN.CodeTypeENName !=  null)
 {
 objCodeTypeEN.CodeTypeENName = objCodeTypeEN.CodeTypeENName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.CodeTypeENName, conCodeType.CodeTypeENName); //代码类型英文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.CodeTypeENName); //代码类型英文名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.GroupName))
 {
 if (objCodeTypeEN.GroupName !=  null)
 {
 objCodeTypeEN.GroupName = objCodeTypeEN.GroupName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.GroupName, conCodeType.GroupName); //组名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.GroupName); //组名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ProgLangTypeId))
 {
 if (objCodeTypeEN.ProgLangTypeId !=  null)
 {
 objCodeTypeEN.ProgLangTypeId = objCodeTypeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ProgLangTypeId, conCodeType.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.RegionTypeId))
 {
 if (objCodeTypeEN.RegionTypeId !=  null)
 {
 objCodeTypeEN.RegionTypeId = objCodeTypeEN.RegionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.RegionTypeId, conCodeType.RegionTypeId); //区域类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.RegionTypeId); //区域类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Prefix))
 {
 if (objCodeTypeEN.Prefix !=  null)
 {
 objCodeTypeEN.Prefix = objCodeTypeEN.Prefix.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.Prefix, conCodeType.Prefix); //前缀
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.Prefix); //前缀
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.DependsOn))
 {
 if (objCodeTypeEN.DependsOn !=  null)
 {
 objCodeTypeEN.DependsOn = objCodeTypeEN.DependsOn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.DependsOn, conCodeType.DependsOn); //依赖于
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.DependsOn); //依赖于
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FrontOrBack))
 {
 if (objCodeTypeEN.FrontOrBack !=  null)
 {
 objCodeTypeEN.FrontOrBack = objCodeTypeEN.FrontOrBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.FrontOrBack, conCodeType.FrontOrBack); //前台Or后台
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.FrontOrBack); //前台Or后台
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeId))
 {
 if (objCodeTypeEN.SqlDsTypeId !=  null)
 {
 objCodeTypeEN.SqlDsTypeId = objCodeTypeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.SqlDsTypeId, conCodeType.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormat))
 {
 if (objCodeTypeEN.ClassNameFormat !=  null)
 {
 objCodeTypeEN.ClassNameFormat = objCodeTypeEN.ClassNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNameFormat, conCodeType.ClassNameFormat); //类名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNameFormat); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNameFormatEx))
 {
 if (objCodeTypeEN.ClassNameFormatEx !=  null)
 {
 objCodeTypeEN.ClassNameFormatEx = objCodeTypeEN.ClassNameFormatEx.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNameFormatEx, conCodeType.ClassNameFormatEx); //类名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNameFormatEx); //类名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FileNameFormat))
 {
 if (objCodeTypeEN.FileNameFormat !=  null)
 {
 objCodeTypeEN.FileNameFormat = objCodeTypeEN.FileNameFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.FileNameFormat, conCodeType.FileNameFormat); //文件名格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.FileNameFormat); //文件名格式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.ClassNamePattern))
 {
 if (objCodeTypeEN.ClassNamePattern !=  null)
 {
 objCodeTypeEN.ClassNamePattern = objCodeTypeEN.ClassNamePattern.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.ClassNamePattern, conCodeType.ClassNamePattern); //类名模式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.ClassNamePattern); //类名模式
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsCSharp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsCSharp == true?"1":"0", conCodeType.IsCSharp); //是否CSharp语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJava))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsJava == true?"1":"0", conCodeType.IsJava); //是否Java语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsJavaScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsJavaScript == true?"1":"0", conCodeType.IsJavaScript); //是否JavaScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTypeScript))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsTypeScript == true?"1":"0", conCodeType.IsTypeScript); //是否TypeScript语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSilverLight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsSilverLight == true?"1":"0", conCodeType.IsSilverLight); //是否SilverLight语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsSwift))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsSwift == true?"1":"0", conCodeType.IsSwift); //是否Swift语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsVB))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsVB == true?"1":"0", conCodeType.IsVB); //IsVB语言
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsTableFldConst))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsTableFldConst == true?"1":"0", conCodeType.IsTableFldConst); //IsTableFldConst
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsPubApp4WinWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsPubApp4WinWeb == true?"1":"0", conCodeType.IsPubApp4WinWeb); //IsPubApp4WinWeb
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWeb == true?"1":"0", conCodeType.IsWeb); //是否Web应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAspMvc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsAspMvc == true?"1":"0", conCodeType.IsAspMvc); //是否AspMvc
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWebSrvAccess))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWebSrvAccess == true?"1":"0", conCodeType.IsWebSrvAccess); //IsWebSrvAccess
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsWin))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsWin == true?"1":"0", conCodeType.IsWin); //是否Win应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsMobileApp))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsMobileApp == true?"1":"0", conCodeType.IsMobileApp); //是否移动终端应用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsExtend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsExtend == true?"1":"0", conCodeType.IsExtend); //是否扩展类
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.OrderNum, conCodeType.OrderNum); //排序
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.WinOrWeb))
 {
 if (objCodeTypeEN.WinOrWeb !=  null)
 {
 objCodeTypeEN.WinOrWeb = objCodeTypeEN.WinOrWeb.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.WinOrWeb, conCodeType.WinOrWeb); //WinOrWeb
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.WinOrWeb); //WinOrWeb
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDirByTabName))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsDirByTabName == true?"1":"0", conCodeType.IsDirByTabName); //是否用表名作为路径
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsDefaultOverride))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsDefaultOverride == true?"1":"0", conCodeType.IsDefaultOverride); //是否默认覆盖
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.InUse == true?"1":"0", conCodeType.InUse); //是否在用
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.IsAutoParseFile))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCodeTypeEN.IsAutoParseFile == true?"1":"0", conCodeType.IsAutoParseFile); //是否自动分析文件
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdDate))
 {
 if (objCodeTypeEN.UpdDate !=  null)
 {
 objCodeTypeEN.UpdDate = objCodeTypeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.UpdDate, conCodeType.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.UpdDate); //修改日期
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.UpdUser))
 {
 if (objCodeTypeEN.UpdUser !=  null)
 {
 objCodeTypeEN.UpdUser = objCodeTypeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.UpdUser, conCodeType.UpdUser); //修改用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.UpdUser); //修改用户
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.Memo))
 {
 if (objCodeTypeEN.Memo !=  null)
 {
 objCodeTypeEN.Memo = objCodeTypeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.Memo, conCodeType.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.Memo); //备注
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.SqlDsTypeName))
 {
 if (objCodeTypeEN.SqlDsTypeName !=  null)
 {
 objCodeTypeEN.SqlDsTypeName = objCodeTypeEN.SqlDsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", objCodeTypeEN.SqlDsTypeName, conCodeType.SqlDsTypeName); //Sql数据源名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCodeType.SqlDsTypeName); //Sql数据源名
 }
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.FuncCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.FuncCount, conCodeType.FuncCount); //函数数目
 }
 
 if (objCodeTypeEN.IsUpdated(conCodeType.AppCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objCodeTypeEN.AppCount, conCodeType.AppCount); //应用数
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CodeTypeId = '{0}'", objCodeTypeEN.CodeTypeId); 
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCodeTypeId) 
{
CheckPrimaryKey(strCodeTypeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCodeTypeId,
};
 objSQL.ExecSP("CodeType_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCodeTypeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCodeTypeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
//删除CodeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeType where CodeTypeId = " + "'"+ strCodeTypeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCodeType(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
//删除CodeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeType where CodeTypeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCodeTypeId) 
{
CheckPrimaryKey(strCodeTypeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
//删除CodeType本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CodeType where CodeTypeId = " + "'"+ strCodeTypeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCodeType(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCodeTypeDA: DelCodeType)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeType where " + strCondition ;
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
public bool DelCodeTypeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCodeTypeDA: DelCodeTypeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CodeType where " + strCondition ;
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
 /// <param name = "objCodeTypeENS">源对象</param>
 /// <param name = "objCodeTypeENT">目标对象</param>
public void CopyTo(clsCodeTypeEN objCodeTypeENS, clsCodeTypeEN objCodeTypeENT)
{
objCodeTypeENT.CodeTypeId = objCodeTypeENS.CodeTypeId; //代码类型Id
objCodeTypeENT.CodeTypeName = objCodeTypeENS.CodeTypeName; //代码类型名
objCodeTypeENT.CodeTypeSimName = objCodeTypeENS.CodeTypeSimName; //简称
objCodeTypeENT.CodeTypeENName = objCodeTypeENS.CodeTypeENName; //代码类型英文名
objCodeTypeENT.GroupName = objCodeTypeENS.GroupName; //组名
objCodeTypeENT.ProgLangTypeId = objCodeTypeENS.ProgLangTypeId; //编程语言类型Id
objCodeTypeENT.RegionTypeId = objCodeTypeENS.RegionTypeId; //区域类型Id
objCodeTypeENT.Prefix = objCodeTypeENS.Prefix; //前缀
objCodeTypeENT.DependsOn = objCodeTypeENS.DependsOn; //依赖于
objCodeTypeENT.FrontOrBack = objCodeTypeENS.FrontOrBack; //前台Or后台
objCodeTypeENT.SqlDsTypeId = objCodeTypeENS.SqlDsTypeId; //数据源类型Id
objCodeTypeENT.ClassNameFormat = objCodeTypeENS.ClassNameFormat; //类名格式
objCodeTypeENT.ClassNameFormatEx = objCodeTypeENS.ClassNameFormatEx; //类名格式
objCodeTypeENT.FileNameFormat = objCodeTypeENS.FileNameFormat; //文件名格式
objCodeTypeENT.ClassNamePattern = objCodeTypeENS.ClassNamePattern; //类名模式
objCodeTypeENT.IsCSharp = objCodeTypeENS.IsCSharp; //是否CSharp语言
objCodeTypeENT.IsJava = objCodeTypeENS.IsJava; //是否Java语言
objCodeTypeENT.IsJavaScript = objCodeTypeENS.IsJavaScript; //是否JavaScript语言
objCodeTypeENT.IsTypeScript = objCodeTypeENS.IsTypeScript; //是否TypeScript语言
objCodeTypeENT.IsSilverLight = objCodeTypeENS.IsSilverLight; //是否SilverLight语言
objCodeTypeENT.IsSwift = objCodeTypeENS.IsSwift; //是否Swift语言
objCodeTypeENT.IsVB = objCodeTypeENS.IsVB; //IsVB语言
objCodeTypeENT.IsTableFldConst = objCodeTypeENS.IsTableFldConst; //IsTableFldConst
objCodeTypeENT.IsPubApp4WinWeb = objCodeTypeENS.IsPubApp4WinWeb; //IsPubApp4WinWeb
objCodeTypeENT.IsWeb = objCodeTypeENS.IsWeb; //是否Web应用
objCodeTypeENT.IsAspMvc = objCodeTypeENS.IsAspMvc; //是否AspMvc
objCodeTypeENT.IsWebSrvAccess = objCodeTypeENS.IsWebSrvAccess; //IsWebSrvAccess
objCodeTypeENT.IsWin = objCodeTypeENS.IsWin; //是否Win应用
objCodeTypeENT.IsMobileApp = objCodeTypeENS.IsMobileApp; //是否移动终端应用
objCodeTypeENT.IsExtend = objCodeTypeENS.IsExtend; //是否扩展类
objCodeTypeENT.OrderNum = objCodeTypeENS.OrderNum; //排序
objCodeTypeENT.WinOrWeb = objCodeTypeENS.WinOrWeb; //WinOrWeb
objCodeTypeENT.IsDirByTabName = objCodeTypeENS.IsDirByTabName; //是否用表名作为路径
objCodeTypeENT.IsDefaultOverride = objCodeTypeENS.IsDefaultOverride; //是否默认覆盖
objCodeTypeENT.InUse = objCodeTypeENS.InUse; //是否在用
objCodeTypeENT.IsAutoParseFile = objCodeTypeENS.IsAutoParseFile; //是否自动分析文件
objCodeTypeENT.UpdDate = objCodeTypeENS.UpdDate; //修改日期
objCodeTypeENT.UpdUser = objCodeTypeENS.UpdUser; //修改用户
objCodeTypeENT.Memo = objCodeTypeENS.Memo; //备注
objCodeTypeENT.SqlDsTypeName = objCodeTypeENS.SqlDsTypeName; //Sql数据源名
objCodeTypeENT.FuncCount = objCodeTypeENS.FuncCount; //函数数目
objCodeTypeENT.AppCount = objCodeTypeENS.AppCount; //应用数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCodeTypeEN objCodeTypeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.CodeTypeName, conCodeType.CodeTypeName);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.CodeTypeSimName, conCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.ProgLangTypeId, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.RegionTypeId, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.SqlDsTypeId, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.IsDefaultOverride, conCodeType.IsDefaultOverride);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.FuncCount, conCodeType.FuncCount);
clsCheckSql.CheckFieldNotNull(objCodeTypeEN.AppCount, conCodeType.AppCount);
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeId, 4, conCodeType.CodeTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeName, 50, conCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeSimName, 50, conCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeENName, 50, conCodeType.CodeTypeENName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.GroupName, 30, conCodeType.GroupName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ProgLangTypeId, 2, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.RegionTypeId, 4, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Prefix, 10, conCodeType.Prefix);
clsCheckSql.CheckFieldLen(objCodeTypeEN.DependsOn, 50, conCodeType.DependsOn);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FrontOrBack, 50, conCodeType.FrontOrBack);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeId, 2, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormat, 50, conCodeType.ClassNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormatEx, 50, conCodeType.ClassNameFormatEx);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FileNameFormat, 50, conCodeType.FileNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNamePattern, 50, conCodeType.ClassNamePattern);
clsCheckSql.CheckFieldLen(objCodeTypeEN.WinOrWeb, 50, conCodeType.WinOrWeb);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdDate, 20, conCodeType.UpdDate);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdUser, 20, conCodeType.UpdUser);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Memo, 1000, conCodeType.Memo);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeName, 20, conCodeType.SqlDsTypeName);
//检查字段外键固定长度
 objCodeTypeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCodeTypeEN objCodeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeName, 50, conCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeSimName, 50, conCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeENName, 50, conCodeType.CodeTypeENName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.GroupName, 30, conCodeType.GroupName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ProgLangTypeId, 2, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.RegionTypeId, 4, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Prefix, 10, conCodeType.Prefix);
clsCheckSql.CheckFieldLen(objCodeTypeEN.DependsOn, 50, conCodeType.DependsOn);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FrontOrBack, 50, conCodeType.FrontOrBack);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeId, 2, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormat, 50, conCodeType.ClassNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormatEx, 50, conCodeType.ClassNameFormatEx);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FileNameFormat, 50, conCodeType.FileNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNamePattern, 50, conCodeType.ClassNamePattern);
clsCheckSql.CheckFieldLen(objCodeTypeEN.WinOrWeb, 50, conCodeType.WinOrWeb);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdDate, 20, conCodeType.UpdDate);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdUser, 20, conCodeType.UpdUser);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Memo, 1000, conCodeType.Memo);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeName, 20, conCodeType.SqlDsTypeName);
//检查外键字段长度
 objCodeTypeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCodeTypeEN objCodeTypeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeId, 4, conCodeType.CodeTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeName, 50, conCodeType.CodeTypeName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeSimName, 50, conCodeType.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.CodeTypeENName, 50, conCodeType.CodeTypeENName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.GroupName, 30, conCodeType.GroupName);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ProgLangTypeId, 2, conCodeType.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.RegionTypeId, 4, conCodeType.RegionTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Prefix, 10, conCodeType.Prefix);
clsCheckSql.CheckFieldLen(objCodeTypeEN.DependsOn, 50, conCodeType.DependsOn);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FrontOrBack, 50, conCodeType.FrontOrBack);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeId, 2, conCodeType.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormat, 50, conCodeType.ClassNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNameFormatEx, 50, conCodeType.ClassNameFormatEx);
clsCheckSql.CheckFieldLen(objCodeTypeEN.FileNameFormat, 50, conCodeType.FileNameFormat);
clsCheckSql.CheckFieldLen(objCodeTypeEN.ClassNamePattern, 50, conCodeType.ClassNamePattern);
clsCheckSql.CheckFieldLen(objCodeTypeEN.WinOrWeb, 50, conCodeType.WinOrWeb);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdDate, 20, conCodeType.UpdDate);
clsCheckSql.CheckFieldLen(objCodeTypeEN.UpdUser, 20, conCodeType.UpdUser);
clsCheckSql.CheckFieldLen(objCodeTypeEN.Memo, 1000, conCodeType.Memo);
clsCheckSql.CheckFieldLen(objCodeTypeEN.SqlDsTypeName, 20, conCodeType.SqlDsTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.CodeTypeId, conCodeType.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.CodeTypeName, conCodeType.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.CodeTypeSimName, conCodeType.CodeTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.CodeTypeENName, conCodeType.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.GroupName, conCodeType.GroupName);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.ProgLangTypeId, conCodeType.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.RegionTypeId, conCodeType.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.Prefix, conCodeType.Prefix);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.DependsOn, conCodeType.DependsOn);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.FrontOrBack, conCodeType.FrontOrBack);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.SqlDsTypeId, conCodeType.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.ClassNameFormat, conCodeType.ClassNameFormat);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.ClassNameFormatEx, conCodeType.ClassNameFormatEx);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.FileNameFormat, conCodeType.FileNameFormat);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.ClassNamePattern, conCodeType.ClassNamePattern);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.WinOrWeb, conCodeType.WinOrWeb);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.UpdDate, conCodeType.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.UpdUser, conCodeType.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.Memo, conCodeType.Memo);
clsCheckSql.CheckSqlInjection4Field(objCodeTypeEN.SqlDsTypeName, conCodeType.SqlDsTypeName);
//检查外键字段长度
 objCodeTypeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCodeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CodeTypeId, CodeTypeName from CodeType ";
 clsSpecSQLforSql mySql = clsCodeTypeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <param name = "strCodeTypeId">代码类型Id(主键)</param>
 /// <returns></returns>
public bool CheckCodeTypeUniqueness(string strCodeTypeId )
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("CodeTypeId !=  '{0}'", strCodeTypeId);
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}
 /// <summary>
 /// 检查唯一性(Uniqueness)--CodeType(代码类型), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.clsGeneCodeBase:GenCheckUniquenessV3)
 /// </summary>
 /// <returns></returns>
public bool CheckCodeTypeUniqueness()
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
if (IsExistCondRec(sbCondition.ToString())  ==  true)
{
return false;
}
else
{
return true;
}
}

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CodeType(代码类型),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCodeTypeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr_CodeTypeName(clsCodeTypeEN objCodeTypeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CodeTypeName = '{0}'", objCodeTypeEN.CodeTypeName);
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeTypeEN._CurrTabName_S);
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCodeTypeEN._CurrTabName_S, strCondition);
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
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
 objSQL = clsCodeTypeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}