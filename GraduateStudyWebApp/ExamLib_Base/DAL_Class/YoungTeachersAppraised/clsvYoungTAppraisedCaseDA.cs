
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseDA
 表名:vYoungTAppraisedCase(01120464)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:青教评优(YoungTeachersAppraised)
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
 /// v青教评优案例(vYoungTAppraisedCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvYoungTAppraisedCaseDA : clsCommBase4DA
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
 return clsvYoungTAppraisedCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdYoungTAppraisedCase)
{
strIdYoungTAppraisedCase = strIdYoungTAppraisedCase.Replace("'", "''");
if (strIdYoungTAppraisedCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vYoungTAppraisedCase中,检查关键字,长度不正确!(clsvYoungTAppraisedCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdYoungTAppraisedCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vYoungTAppraisedCase中,关键字不能为空 或 null!(clsvYoungTAppraisedCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdYoungTAppraisedCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvYoungTAppraisedCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vYoungTAppraisedCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable_vYoungTAppraisedCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase.* from vYoungTAppraisedCase Left Join {1} on {2} where {3} and vYoungTAppraisedCase.IdYoungTAppraisedCase not in (Select top {5} vYoungTAppraisedCase.IdYoungTAppraisedCase from vYoungTAppraisedCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from vYoungTAppraisedCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from vYoungTAppraisedCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCase.* from vYoungTAppraisedCase Left Join {1} on {2} where {3} and vYoungTAppraisedCase.IdYoungTAppraisedCase not in (Select top {5} vYoungTAppraisedCase.IdYoungTAppraisedCase from vYoungTAppraisedCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {2} IdYoungTAppraisedCase from vYoungTAppraisedCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCase where {1} and IdYoungTAppraisedCase not in (Select top {3} IdYoungTAppraisedCase from vYoungTAppraisedCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvYoungTAppraisedCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA:GetObjLst)", objException.Message));
}
List<clsvYoungTAppraisedCaseEN> arrObjLst = new List<clsvYoungTAppraisedCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN();
try
{
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseEN.IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objvYoungTAppraisedCaseEN.FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCaseEN.IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCaseEN.StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCaseEN.IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCaseEN.IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCaseEN.IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCaseEN.DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCaseEN.DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseEN.VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCaseEN.IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCaseEN.TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCaseEN.SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCaseEN.TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCaseEN.TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCaseEN.IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCaseEN.SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCaseEN.CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCaseEN.DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCaseEN.WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseEN.OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseEN.TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseEN.TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseEN.IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseEN.CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseEN.CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseEN.CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCaseEN.EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseEN.UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCaseEN.UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCaseEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCaseEN.ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseEN.VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objvYoungTAppraisedCaseEN.VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objvYoungTAppraisedCaseEN.ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvYoungTAppraisedCaseEN.UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objvYoungTAppraisedCaseEN.UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseEN.Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCaseEN.OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvYoungTAppraisedCaseEN.OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseEN.AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName
objvYoungTAppraisedCaseEN.BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCaseEN.EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseEN);
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
public List<clsvYoungTAppraisedCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvYoungTAppraisedCaseEN> arrObjLst = new List<clsvYoungTAppraisedCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN();
try
{
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseEN.IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objvYoungTAppraisedCaseEN.FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCaseEN.IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCaseEN.StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCaseEN.IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCaseEN.IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCaseEN.IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCaseEN.DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCaseEN.DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseEN.VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCaseEN.IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCaseEN.TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCaseEN.SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCaseEN.TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCaseEN.TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCaseEN.IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCaseEN.SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCaseEN.CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCaseEN.DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCaseEN.WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseEN.OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseEN.TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseEN.TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseEN.IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseEN.CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseEN.CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseEN.CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCaseEN.EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseEN.UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCaseEN.UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCaseEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCaseEN.ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseEN.VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objvYoungTAppraisedCaseEN.VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objvYoungTAppraisedCaseEN.ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvYoungTAppraisedCaseEN.UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objvYoungTAppraisedCaseEN.UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseEN.Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCaseEN.OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvYoungTAppraisedCaseEN.OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseEN.AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName
objvYoungTAppraisedCaseEN.BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCaseEN.EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvYoungTAppraisedCase(ref clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objDT.Rows[0][convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.IdDecompressionFile = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.FuncModuleName = objDT.Rows[0][convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseEN.IdStudyLevel = objDT.Rows[0][convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.StudyLevelName = objDT.Rows[0][convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdTeachingPlan = objDT.Rows[0][convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.IdCaseType = objDT.Rows[0][convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.IdDiscipline = objDT.Rows[0][convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.DisciplineID = objDT.Rows[0][convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.DisciplineName = objDT.Rows[0][convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objDT.Rows[0][convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.senateGaugeVersionID = objDT.Rows[0][convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.senateGaugeVersionName = objDT.Rows[0][convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.VersionNo = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.IdTeachSkill = objDT.Rows[0][convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillID = objDT.Rows[0][convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.SkillTypeName = objDT.Rows[0][convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillName = objDT.Rows[0][convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillTheory = objDT.Rows[0][convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objDT.Rows[0][convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCaseEN.IdSkillType = objDT.Rows[0][convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.SkillTypeID = objDT.Rows[0][convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.CaseLevelId = objDT.Rows[0][convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCaseEN.DocFile = objDT.Rows[0][convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseEN.WordCreateDate = objDT.Rows[0][convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerId = objDT.Rows[0][convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCaseEN.TeacherID = objDT.Rows[0][convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCaseEN.TeacherName = objDT.Rows[0][convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdXzCollege = objDT.Rows[0][convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.CollegeID = objDT.Rows[0][convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.CollegeName = objDT.Rows[0][convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseEN.CollegeNameA = objDT.Rows[0][convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvYoungTAppraisedCaseEN.EntryDate = objDT.Rows[0][convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objDT.Rows[0][convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objDT.Rows[0][convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.UserTypeId = objDT.Rows[0][convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCaseEN.UserTypeName = objDT.Rows[0][convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.RecommendedDegreeId = objDT.Rows[0][convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCaseEN.RecommendedDegreeName = objDT.Rows[0][convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseEN.ftpFileType = objDT.Rows[0][convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.VideoUrl = objDT.Rows[0][convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.VideoPath = objDT.Rows[0][convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.ResErrMsg = objDT.Rows[0][convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.UpdUserId = objDT.Rows[0][convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.UpdDate = objDT.Rows[0][convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.Memo = objDT.Rows[0][convYoungTAppraisedCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerNameWithId = objDT.Rows[0][convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerName = objDT.Rows[0][convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.AddiSiteName = objDT.Rows[0][convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.EntryYear = objDT.Rows[0][convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetvYoungTAppraisedCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdYoungTAppraisedCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvYoungTAppraisedCaseEN GetObjByIdYoungTAppraisedCase(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN();
try
{
 objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseEN.IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = Single.Parse(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseEN.SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCaseEN.IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCaseEN.DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseEN.WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvYoungTAppraisedCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCaseEN.TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCaseEN.TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseEN.CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvYoungTAppraisedCaseEN.EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseEN.UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvYoungTAppraisedCaseEN.UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvYoungTAppraisedCaseEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseEN.ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseEN.Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvYoungTAppraisedCaseEN.OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseEN.AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName(字段类型:varchar,字段长度:500,是否可空:True)
 objvYoungTAppraisedCaseEN.BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseEN.EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetObjByIdYoungTAppraisedCase)", objException.Message));
}
return objvYoungTAppraisedCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvYoungTAppraisedCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN()
{
IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()), //解压缩文件流水号
FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(), //功能模块名称
YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(), //青教评优案例ID
YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(), //案例文本内容
YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(), //青教评优教学日期
YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(), //青教评优教学时间
YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(), //青教评优案例主题词
YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(), //案例入库日期
YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(), //案例入库时间
IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()), //是否显示
OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(), //拥有者Id
TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(), //教师姓名
IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(), //学院名称简写
EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(), //进校日期
IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()), //是否双视频
IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(), //青教案例类型流水号
YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(), //青教案例类型名称
UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(), //用户类型Id
UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(), //用户类型名称
RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(), //资源错误信息
UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(), //备注
OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(), //拥有者姓名
AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(), //AddiSiteName
BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()), //课例浏览次数
EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim() //EntryYear
};
objvYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN();
try
{
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseEN.IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objvYoungTAppraisedCaseEN.FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCaseEN.IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCaseEN.StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCaseEN.IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCaseEN.IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCaseEN.IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCaseEN.DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCaseEN.DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseEN.VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCaseEN.IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCaseEN.TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCaseEN.SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCaseEN.TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCaseEN.TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCaseEN.IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCaseEN.SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCaseEN.CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCaseEN.DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCaseEN.WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseEN.OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseEN.TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseEN.TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseEN.IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseEN.CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseEN.CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseEN.CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCaseEN.EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseEN.UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCaseEN.UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCaseEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCaseEN.ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseEN.VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objvYoungTAppraisedCaseEN.VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objvYoungTAppraisedCaseEN.ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvYoungTAppraisedCaseEN.UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objvYoungTAppraisedCaseEN.UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseEN.Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCaseEN.OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvYoungTAppraisedCaseEN.OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseEN.AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName
objvYoungTAppraisedCaseEN.BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCaseEN.EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetObjByDataRowvYoungTAppraisedCase)", objException.Message));
}
objvYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN = new clsvYoungTAppraisedCaseEN();
try
{
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseEN.IdDecompressionFile = objRow[convYoungTAppraisedCase.IdDecompressionFile] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convYoungTAppraisedCase.IdDecompressionFile].ToString().Trim()); //解压缩文件流水号
objvYoungTAppraisedCaseEN.FuncModuleName = objRow[convYoungTAppraisedCase.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseText].ToString().Trim(); //案例文本内容
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTime].ToString().Trim(); //青教评优教学时间
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTheme].ToString().Trim(); //青教评优案例主题词
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseDateIn].ToString().Trim(); //案例入库日期
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn].ToString().Trim(); //案例入库时间
objvYoungTAppraisedCaseEN.IdStudyLevel = objRow[convYoungTAppraisedCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvYoungTAppraisedCaseEN.StudyLevelName = objRow[convYoungTAppraisedCase.StudyLevelName].ToString().Trim(); //学段名称
objvYoungTAppraisedCaseEN.IdTeachingPlan = objRow[convYoungTAppraisedCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvYoungTAppraisedCaseEN.IdCaseType = objRow[convYoungTAppraisedCase.IdCaseType].ToString().Trim(); //案例类型流水号
objvYoungTAppraisedCaseEN.IdDiscipline = objRow[convYoungTAppraisedCase.IdDiscipline].ToString().Trim(); //学科流水号
objvYoungTAppraisedCaseEN.DisciplineID = objRow[convYoungTAppraisedCase.DisciplineID].ToString().Trim(); //学科ID
objvYoungTAppraisedCaseEN.DisciplineName = objRow[convYoungTAppraisedCase.DisciplineName].ToString().Trim(); //学科名称
objvYoungTAppraisedCaseEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseEN.senateGaugeVersionID = objRow[convYoungTAppraisedCase.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseEN.senateGaugeVersionName = objRow[convYoungTAppraisedCase.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseEN.senateGaugeVersionTtlScore = TransNullToFloat(objRow[convYoungTAppraisedCase.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseEN.VersionNo = objRow[convYoungTAppraisedCase.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.VersionNo].ToString().Trim()); //版本号
objvYoungTAppraisedCaseEN.IdTeachSkill = objRow[convYoungTAppraisedCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvYoungTAppraisedCaseEN.TeachSkillID = objRow[convYoungTAppraisedCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvYoungTAppraisedCaseEN.SkillTypeName = objRow[convYoungTAppraisedCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvYoungTAppraisedCaseEN.TeachSkillName = objRow[convYoungTAppraisedCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvYoungTAppraisedCaseEN.TeachSkillTheory = objRow[convYoungTAppraisedCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvYoungTAppraisedCaseEN.TeachSkillOperMethod = objRow[convYoungTAppraisedCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvYoungTAppraisedCaseEN.IdSkillType = objRow[convYoungTAppraisedCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvYoungTAppraisedCaseEN.SkillTypeID = objRow[convYoungTAppraisedCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvYoungTAppraisedCaseEN.CaseLevelId = objRow[convYoungTAppraisedCase.CaseLevelId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CaseLevelId].ToString().Trim(); //课例等级Id
objvYoungTAppraisedCaseEN.DocFile = objRow[convYoungTAppraisedCase.DocFile] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.DocFile].ToString().Trim(); //生成的Word文件名
objvYoungTAppraisedCaseEN.IsNeedGeneWord = TransNullToBool(objRow[convYoungTAppraisedCase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvYoungTAppraisedCaseEN.WordCreateDate = objRow[convYoungTAppraisedCase.WordCreateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.WordCreateDate].ToString().Trim(); //Word生成日期
objvYoungTAppraisedCaseEN.IsVisible = TransNullToBool(objRow[convYoungTAppraisedCase.IsVisible].ToString().Trim()); //是否显示
objvYoungTAppraisedCaseEN.OwnerId = objRow[convYoungTAppraisedCase.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseEN.TeacherID = objRow[convYoungTAppraisedCase.TeacherID] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseEN.TeacherName = objRow[convYoungTAppraisedCase.TeacherName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseEN.IdXzCollege = objRow[convYoungTAppraisedCase.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseEN.CollegeID = objRow[convYoungTAppraisedCase.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseEN.CollegeName = objRow[convYoungTAppraisedCase.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseEN.CollegeNameA = objRow[convYoungTAppraisedCase.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvYoungTAppraisedCaseEN.EntryDate = objRow[convYoungTAppraisedCase.EntryDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryDate].ToString().Trim(); //进校日期
objvYoungTAppraisedCaseEN.IsDualVideo = TransNullToBool(objRow[convYoungTAppraisedCase.IsDualVideo].ToString().Trim()); //是否双视频
objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType = objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.IdYoungTAppraisedCaseType].ToString().Trim(); //青教案例类型流水号
objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseEN.UserTypeId = objRow[convYoungTAppraisedCase.UserTypeId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeId].ToString().Trim(); //用户类型Id
objvYoungTAppraisedCaseEN.UserTypeName = objRow[convYoungTAppraisedCase.UserTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UserTypeName].ToString().Trim(); //用户类型名称
objvYoungTAppraisedCaseEN.RecommendedDegreeId = objRow[convYoungTAppraisedCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvYoungTAppraisedCaseEN.RecommendedDegreeName = objRow[convYoungTAppraisedCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvYoungTAppraisedCaseEN.ftpFileType = objRow[convYoungTAppraisedCase.ftpFileType] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvYoungTAppraisedCaseEN.VideoUrl = objRow[convYoungTAppraisedCase.VideoUrl] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoUrl].ToString().Trim(); //视频Url
objvYoungTAppraisedCaseEN.VideoPath = objRow[convYoungTAppraisedCase.VideoPath] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.VideoPath].ToString().Trim(); //视频目录
objvYoungTAppraisedCaseEN.ResErrMsg = objRow[convYoungTAppraisedCase.ResErrMsg] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvYoungTAppraisedCaseEN.UpdUserId = objRow[convYoungTAppraisedCase.UpdUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdUserId].ToString().Trim(); //修改用户Id
objvYoungTAppraisedCaseEN.UpdDate = objRow[convYoungTAppraisedCase.UpdDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.UpdDate].ToString().Trim(); //修改日期
objvYoungTAppraisedCaseEN.Memo = objRow[convYoungTAppraisedCase.Memo] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.Memo].ToString().Trim(); //备注
objvYoungTAppraisedCaseEN.OwnerNameWithId = objRow[convYoungTAppraisedCase.OwnerNameWithId] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvYoungTAppraisedCaseEN.OwnerName = objRow[convYoungTAppraisedCase.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseEN.AddiSiteName = objRow[convYoungTAppraisedCase.AddiSiteName] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.AddiSiteName].ToString().Trim(); //AddiSiteName
objvYoungTAppraisedCaseEN.BrowseCount4Case = objRow[convYoungTAppraisedCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvYoungTAppraisedCaseEN.EntryYear = objRow[convYoungTAppraisedCase.EntryYear] == DBNull.Value ? null : objRow[convYoungTAppraisedCase.EntryYear].ToString().Trim(); //EntryYear
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseDA: GetObjByDataRow)", objException.Message));
}
objvYoungTAppraisedCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseEN;
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
objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseEN._CurrTabName, convYoungTAppraisedCase.IdYoungTAppraisedCase, 8, "");
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
objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseEN._CurrTabName, convYoungTAppraisedCase.IdYoungTAppraisedCase, 8, strPrefix);
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from vYoungTAppraisedCase where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdYoungTAppraisedCase from vYoungTAppraisedCase where " + strCondition;
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
 /// <param name = "strIdYoungTAppraisedCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdYoungTAppraisedCase)
{
CheckPrimaryKey(strIdYoungTAppraisedCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase", "IdYoungTAppraisedCase = " + "'"+ strIdYoungTAppraisedCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCase", strCondition))
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
objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vYoungTAppraisedCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseENT">目标对象</param>
public void CopyTo(clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseENS, clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseENT)
{
objvYoungTAppraisedCaseENT.IdYoungTAppraisedCase = objvYoungTAppraisedCaseENS.IdYoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseENT.IdDecompressionFile = objvYoungTAppraisedCaseENS.IdDecompressionFile; //解压缩文件流水号
objvYoungTAppraisedCaseENT.FuncModuleName = objvYoungTAppraisedCaseENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseID = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseText = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseText; //案例文本内容
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTime = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTime; //青教评优教学时间
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTheme = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTheme; //青教评优案例主题词
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseDateIn = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseDateIn; //案例入库日期
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTimeIn = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTimeIn; //案例入库时间
objvYoungTAppraisedCaseENT.IdStudyLevel = objvYoungTAppraisedCaseENS.IdStudyLevel; //id_StudyLevel
objvYoungTAppraisedCaseENT.StudyLevelName = objvYoungTAppraisedCaseENS.StudyLevelName; //学段名称
objvYoungTAppraisedCaseENT.IdTeachingPlan = objvYoungTAppraisedCaseENS.IdTeachingPlan; //教案流水号
objvYoungTAppraisedCaseENT.IdCaseType = objvYoungTAppraisedCaseENS.IdCaseType; //案例类型流水号
objvYoungTAppraisedCaseENT.IdDiscipline = objvYoungTAppraisedCaseENS.IdDiscipline; //学科流水号
objvYoungTAppraisedCaseENT.DisciplineID = objvYoungTAppraisedCaseENS.DisciplineID; //学科ID
objvYoungTAppraisedCaseENT.DisciplineName = objvYoungTAppraisedCaseENS.DisciplineName; //学科名称
objvYoungTAppraisedCaseENT.IdSenateGaugeVersion = objvYoungTAppraisedCaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCaseENT.senateGaugeVersionID = objvYoungTAppraisedCaseENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCaseENT.senateGaugeVersionName = objvYoungTAppraisedCaseENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCaseENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCaseENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCaseENT.VersionNo = objvYoungTAppraisedCaseENS.VersionNo; //版本号
objvYoungTAppraisedCaseENT.IdTeachSkill = objvYoungTAppraisedCaseENS.IdTeachSkill; //教学技能流水号
objvYoungTAppraisedCaseENT.TeachSkillID = objvYoungTAppraisedCaseENS.TeachSkillID; //教学技能ID
objvYoungTAppraisedCaseENT.SkillTypeName = objvYoungTAppraisedCaseENS.SkillTypeName; //技能类型名称
objvYoungTAppraisedCaseENT.TeachSkillName = objvYoungTAppraisedCaseENS.TeachSkillName; //教学技能名称
objvYoungTAppraisedCaseENT.TeachSkillTheory = objvYoungTAppraisedCaseENS.TeachSkillTheory; //教学技能理论阐述
objvYoungTAppraisedCaseENT.TeachSkillOperMethod = objvYoungTAppraisedCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvYoungTAppraisedCaseENT.IdSkillType = objvYoungTAppraisedCaseENS.IdSkillType; //技能类型流水号
objvYoungTAppraisedCaseENT.SkillTypeID = objvYoungTAppraisedCaseENS.SkillTypeID; //技能类型ID
objvYoungTAppraisedCaseENT.CaseLevelId = objvYoungTAppraisedCaseENS.CaseLevelId; //课例等级Id
objvYoungTAppraisedCaseENT.DocFile = objvYoungTAppraisedCaseENS.DocFile; //生成的Word文件名
objvYoungTAppraisedCaseENT.IsNeedGeneWord = objvYoungTAppraisedCaseENS.IsNeedGeneWord; //是否需要生成Word
objvYoungTAppraisedCaseENT.WordCreateDate = objvYoungTAppraisedCaseENS.WordCreateDate; //Word生成日期
objvYoungTAppraisedCaseENT.IsVisible = objvYoungTAppraisedCaseENS.IsVisible; //是否显示
objvYoungTAppraisedCaseENT.OwnerId = objvYoungTAppraisedCaseENS.OwnerId; //拥有者Id
objvYoungTAppraisedCaseENT.TeacherID = objvYoungTAppraisedCaseENS.TeacherID; //教师工号
objvYoungTAppraisedCaseENT.TeacherName = objvYoungTAppraisedCaseENS.TeacherName; //教师姓名
objvYoungTAppraisedCaseENT.IdXzCollege = objvYoungTAppraisedCaseENS.IdXzCollege; //学院流水号
objvYoungTAppraisedCaseENT.CollegeID = objvYoungTAppraisedCaseENS.CollegeID; //学院ID
objvYoungTAppraisedCaseENT.CollegeName = objvYoungTAppraisedCaseENS.CollegeName; //学院名称
objvYoungTAppraisedCaseENT.CollegeNameA = objvYoungTAppraisedCaseENS.CollegeNameA; //学院名称简写
objvYoungTAppraisedCaseENT.EntryDate = objvYoungTAppraisedCaseENS.EntryDate; //进校日期
objvYoungTAppraisedCaseENT.IsDualVideo = objvYoungTAppraisedCaseENS.IsDualVideo; //是否双视频
objvYoungTAppraisedCaseENT.IdYoungTAppraisedCaseType = objvYoungTAppraisedCaseENS.IdYoungTAppraisedCaseType; //青教案例类型流水号
objvYoungTAppraisedCaseENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCaseENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCaseENT.UserTypeId = objvYoungTAppraisedCaseENS.UserTypeId; //用户类型Id
objvYoungTAppraisedCaseENT.UserTypeName = objvYoungTAppraisedCaseENS.UserTypeName; //用户类型名称
objvYoungTAppraisedCaseENT.RecommendedDegreeId = objvYoungTAppraisedCaseENS.RecommendedDegreeId; //推荐度Id
objvYoungTAppraisedCaseENT.RecommendedDegreeName = objvYoungTAppraisedCaseENS.RecommendedDegreeName; //推荐度名称
objvYoungTAppraisedCaseENT.ftpFileType = objvYoungTAppraisedCaseENS.ftpFileType; //ftp文件类型
objvYoungTAppraisedCaseENT.VideoUrl = objvYoungTAppraisedCaseENS.VideoUrl; //视频Url
objvYoungTAppraisedCaseENT.VideoPath = objvYoungTAppraisedCaseENS.VideoPath; //视频目录
objvYoungTAppraisedCaseENT.ResErrMsg = objvYoungTAppraisedCaseENS.ResErrMsg; //资源错误信息
objvYoungTAppraisedCaseENT.UpdUserId = objvYoungTAppraisedCaseENS.UpdUserId; //修改用户Id
objvYoungTAppraisedCaseENT.UpdDate = objvYoungTAppraisedCaseENS.UpdDate; //修改日期
objvYoungTAppraisedCaseENT.Memo = objvYoungTAppraisedCaseENS.Memo; //备注
objvYoungTAppraisedCaseENT.OwnerNameWithId = objvYoungTAppraisedCaseENS.OwnerNameWithId; //拥有者名称附Id
objvYoungTAppraisedCaseENT.OwnerName = objvYoungTAppraisedCaseENS.OwnerName; //拥有者姓名
objvYoungTAppraisedCaseENT.AddiSiteName = objvYoungTAppraisedCaseENS.AddiSiteName; //AddiSiteName
objvYoungTAppraisedCaseENT.BrowseCount4Case = objvYoungTAppraisedCaseENS.BrowseCount4Case; //课例浏览次数
objvYoungTAppraisedCaseENT.EntryYear = objvYoungTAppraisedCaseENS.EntryYear; //EntryYear
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvYoungTAppraisedCaseEN objvYoungTAppraisedCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase, 8, convYoungTAppraisedCase.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.FuncModuleName, 30, convYoungTAppraisedCase.FuncModuleName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID, 8, convYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName, 100, convYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText, 8000, convYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, 200, convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, 8, convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, 6, convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdStudyLevel, 4, convYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.StudyLevelName, 50, convYoungTAppraisedCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdTeachingPlan, 8, convYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdCaseType, 4, convYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdDiscipline, 4, convYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.DisciplineID, 4, convYoungTAppraisedCase.DisciplineID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.DisciplineName, 50, convYoungTAppraisedCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdSenateGaugeVersion, 4, convYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.senateGaugeVersionID, 4, convYoungTAppraisedCase.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.senateGaugeVersionName, 200, convYoungTAppraisedCase.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdTeachSkill, 8, convYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeachSkillID, 8, convYoungTAppraisedCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.SkillTypeName, 50, convYoungTAppraisedCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeachSkillName, 50, convYoungTAppraisedCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeachSkillTheory, 8000, convYoungTAppraisedCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeachSkillOperMethod, 2000, convYoungTAppraisedCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdSkillType, 4, convYoungTAppraisedCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.SkillTypeID, 4, convYoungTAppraisedCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.CaseLevelId, 2, convYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.DocFile, 200, convYoungTAppraisedCase.DocFile);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.WordCreateDate, 14, convYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.OwnerId, 20, convYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeacherID, 12, convYoungTAppraisedCase.TeacherID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.TeacherName, 50, convYoungTAppraisedCase.TeacherName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdXzCollege, 4, convYoungTAppraisedCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.CollegeID, 4, convYoungTAppraisedCase.CollegeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.CollegeName, 100, convYoungTAppraisedCase.CollegeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.CollegeNameA, 12, convYoungTAppraisedCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.EntryDate, 8, convYoungTAppraisedCase.EntryDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, 4, convYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.UserTypeId, 2, convYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.UserTypeName, 20, convYoungTAppraisedCase.UserTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.RecommendedDegreeId, 2, convYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.RecommendedDegreeName, 30, convYoungTAppraisedCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.ftpFileType, 30, convYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.VideoUrl, 1000, convYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.VideoPath, 1000, convYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.ResErrMsg, 30, convYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.UpdUserId, 20, convYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.UpdDate, 20, convYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.Memo, 1000, convYoungTAppraisedCase.Memo);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.OwnerNameWithId, 51, convYoungTAppraisedCase.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.OwnerName, 30, convYoungTAppraisedCase.OwnerName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.AddiSiteName, 500, convYoungTAppraisedCase.AddiSiteName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseEN.EntryYear, 8, convYoungTAppraisedCase.EntryYear);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdYoungTAppraisedCase, convYoungTAppraisedCase.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.FuncModuleName, convYoungTAppraisedCase.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseID, convYoungTAppraisedCase.YoungTAppraisedCaseID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseName, convYoungTAppraisedCase.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseText, convYoungTAppraisedCase.YoungTAppraisedCaseText);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDate, convYoungTAppraisedCase.YoungTAppraisedCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTime, convYoungTAppraisedCase.YoungTAppraisedCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTheme, convYoungTAppraisedCase.YoungTAppraisedCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseDateIn, convYoungTAppraisedCase.YoungTAppraisedCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTimeIn, convYoungTAppraisedCase.YoungTAppraisedCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdStudyLevel, convYoungTAppraisedCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.StudyLevelName, convYoungTAppraisedCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdTeachingPlan, convYoungTAppraisedCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdCaseType, convYoungTAppraisedCase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdDiscipline, convYoungTAppraisedCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.DisciplineID, convYoungTAppraisedCase.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.DisciplineName, convYoungTAppraisedCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdSenateGaugeVersion, convYoungTAppraisedCase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.senateGaugeVersionID, convYoungTAppraisedCase.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.senateGaugeVersionName, convYoungTAppraisedCase.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdTeachSkill, convYoungTAppraisedCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeachSkillID, convYoungTAppraisedCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.SkillTypeName, convYoungTAppraisedCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeachSkillName, convYoungTAppraisedCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeachSkillTheory, convYoungTAppraisedCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeachSkillOperMethod, convYoungTAppraisedCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdSkillType, convYoungTAppraisedCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.SkillTypeID, convYoungTAppraisedCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.CaseLevelId, convYoungTAppraisedCase.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.DocFile, convYoungTAppraisedCase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.WordCreateDate, convYoungTAppraisedCase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.OwnerId, convYoungTAppraisedCase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeacherID, convYoungTAppraisedCase.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.TeacherName, convYoungTAppraisedCase.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdXzCollege, convYoungTAppraisedCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.CollegeID, convYoungTAppraisedCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.CollegeName, convYoungTAppraisedCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.CollegeNameA, convYoungTAppraisedCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.EntryDate, convYoungTAppraisedCase.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.IdYoungTAppraisedCaseType, convYoungTAppraisedCase.IdYoungTAppraisedCaseType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.YoungTAppraisedCaseTypeName, convYoungTAppraisedCase.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.UserTypeId, convYoungTAppraisedCase.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.UserTypeName, convYoungTAppraisedCase.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.RecommendedDegreeId, convYoungTAppraisedCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.RecommendedDegreeName, convYoungTAppraisedCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.ftpFileType, convYoungTAppraisedCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.VideoUrl, convYoungTAppraisedCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.VideoPath, convYoungTAppraisedCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.ResErrMsg, convYoungTAppraisedCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.UpdUserId, convYoungTAppraisedCase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.UpdDate, convYoungTAppraisedCase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.Memo, convYoungTAppraisedCase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.OwnerNameWithId, convYoungTAppraisedCase.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.OwnerName, convYoungTAppraisedCase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.AddiSiteName, convYoungTAppraisedCase.AddiSiteName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseEN.EntryYear, convYoungTAppraisedCase.EntryYear);
//检查外键字段长度
 objvYoungTAppraisedCaseEN._IsCheckProperty = true;
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseEN._CurrTabName);
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvYoungTAppraisedCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}