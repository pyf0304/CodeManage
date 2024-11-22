
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMicroteachCase4TeaDA
 表名:vMicroteachCase4Tea(01120503)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
 /// vMicroteachCase4Tea(vMicroteachCase4Tea)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMicroteachCase4TeaDA : clsCommBase4DA
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
 return clsvMicroteachCase4TeaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMicroteachCase4TeaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMicroteachCase4TeaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMicroteachCase4TeaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMicroteachCase4TeaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdMicroteachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdMicroteachCase)
{
strIdMicroteachCase = strIdMicroteachCase.Replace("'", "''");
if (strIdMicroteachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vMicroteachCase4Tea中,检查关键字,长度不正确!(clsvMicroteachCase4TeaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdMicroteachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vMicroteachCase4Tea中,关键字不能为空 或 null!(clsvMicroteachCase4TeaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdMicroteachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvMicroteachCase4TeaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMicroteachCase4Tea(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable_vMicroteachCase4Tea)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase4Tea.* from vMicroteachCase4Tea Left Join {1} on {2} where {3} and vMicroteachCase4Tea.IdMicroteachCase not in (Select top {5} vMicroteachCase4Tea.IdMicroteachCase from vMicroteachCase4Tea Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroteachCase4Tea where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroteachCase4Tea where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMicroteachCase4Tea.* from vMicroteachCase4Tea Left Join {1} on {2} where {3} and vMicroteachCase4Tea.IdMicroteachCase not in (Select top {5} vMicroteachCase4Tea.IdMicroteachCase from vMicroteachCase4Tea Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1} and IdMicroteachCase not in (Select top {2} IdMicroteachCase from vMicroteachCase4Tea where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMicroteachCase4Tea where {1} and IdMicroteachCase not in (Select top {3} IdMicroteachCase from vMicroteachCase4Tea where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMicroteachCase4TeaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA:GetObjLst)", objException.Message));
}
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetObjLst)", objException.Message));
}
objvMicroteachCase4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase4TeaEN);
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
public List<clsvMicroteachCase4TeaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMicroteachCase4TeaEN> arrObjLst = new List<clsvMicroteachCase4TeaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetObjLst)", objException.Message));
}
objvMicroteachCase4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMicroteachCase4TeaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMicroteachCase4Tea(ref clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where IdMicroteachCase = " + "'"+ objvMicroteachCase4TeaEN.IdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMicroteachCase4TeaEN.IdMicroteachCase = objDT.Rows[0][convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseID = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseName = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseTheme = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseDate = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseTime = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objDT.Rows[0][convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.IdStudyLevel = objDT.Rows[0][convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.StudyLevelName = objDT.Rows[0][convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdTeachingPlan = objDT.Rows[0][convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objDT.Rows[0][convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4TeaEN.IdMicroteachCaseType = objDT.Rows[0][convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.IdCaseType = objDT.Rows[0][convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.IdDiscipline = objDT.Rows[0][convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.DisciplineID = objDT.Rows[0][convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.DisciplineName = objDT.Rows[0][convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objDT.Rows[0][convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.senateGaugeVersionID = objDT.Rows[0][convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.senateGaugeVersionName = objDT.Rows[0][convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.VersionNo = TransNullToInt(objDT.Rows[0][convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.IdTeachSkill = objDT.Rows[0][convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillID = objDT.Rows[0][convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.SkillTypeName = objDT.Rows[0][convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillName = objDT.Rows[0][convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillTheory = objDT.Rows[0][convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4TeaEN.TeachSkillOperMethod = objDT.Rows[0][convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase4TeaEN.IdSkillType = objDT.Rows[0][convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.SkillTypeID = objDT.Rows[0][convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.CaseLevelId = objDT.Rows[0][convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4TeaEN.DocFile = objDT.Rows[0][convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4TeaEN.WordCreateDate = objDT.Rows[0][convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroteachCase4TeaEN.IsVisible = TransNullToBool(objDT.Rows[0][convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4TeaEN.microteachCaseText = objDT.Rows[0][convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4TeaEN.OwnerId = objDT.Rows[0][convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase4TeaEN.OwnerName = objDT.Rows[0][convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4TeaEN.TeacherId = objDT.Rows[0][convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvMicroteachCase4TeaEN.TeacherName = objDT.Rows[0][convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdXzCollege = objDT.Rows[0][convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeName = objDT.Rows[0][convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4TeaEN.EntryDate = objDT.Rows[0][convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeId = objDT.Rows[0][convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.EntryYear = objDT.Rows[0][convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase4TeaEN.UserTypeId = objDT.Rows[0][convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4TeaEN.RecommendedDegreeId = objDT.Rows[0][convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4TeaEN.RecommendedDegreeName = objDT.Rows[0][convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4TeaEN.Memo = objDT.Rows[0][convMicroteachCase4Tea.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase4TeaEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeNameA = objDT.Rows[0][convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase4TeaEN.ftpFileType = objDT.Rows[0][convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetvMicroteachCase4Tea)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdMicroteachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvMicroteachCase4TeaEN GetObjByIdMicroteachCase(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
 objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvMicroteachCase4TeaEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvMicroteachCase4TeaEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvMicroteachCase4TeaEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetObjByIdMicroteachCase)", objException.Message));
}
return objvMicroteachCase4TeaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMicroteachCase4TeaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
strSQL = "Select * from vMicroteachCase4Tea where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN()
{
IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(), //微格案例类型名称
MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(), //微格教学案例ID
MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(), //微格教学案例名称
MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(), //微格教学案例主题词
MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(), //微格教学日期
MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(), //微格教学时间
MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(), //案例入库日期
IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(), //教案流水号
MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(), //案例入库时间
IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(), //微格案例类型流水号
IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(), //案例类型流水号
IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(), //学科名称
IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(), //课例等级Id
DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()), //是否显示
microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(), //案例文本内容
OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(), //拥有者姓名
TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(), //教师姓名
IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(), //学院名称
EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(), //进校日期
CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(), //学院ID
EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(), //EntryYear
IsDualVideo = TransNullToBool(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()), //是否双视频
UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(), //用户类型Id
RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()), //课例浏览次数
CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(), //学院名称简写
ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim() //ftp文件类型
};
objvMicroteachCase4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4TeaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase4TeaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetObjByDataRowvMicroteachCase4Tea)", objException.Message));
}
objvMicroteachCase4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4TeaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMicroteachCase4TeaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN = new clsvMicroteachCase4TeaEN();
try
{
objvMicroteachCase4TeaEN.IdMicroteachCase = objRow[convMicroteachCase4Tea.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvMicroteachCase4TeaEN.MicroteachCaseTypeName = objRow[convMicroteachCase4Tea.MicroteachCaseTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTypeName].ToString().Trim(); //微格案例类型名称
objvMicroteachCase4TeaEN.MicroteachCaseID = objRow[convMicroteachCase4Tea.MicroteachCaseID].ToString().Trim(); //微格教学案例ID
objvMicroteachCase4TeaEN.MicroteachCaseName = objRow[convMicroteachCase4Tea.MicroteachCaseName].ToString().Trim(); //微格教学案例名称
objvMicroteachCase4TeaEN.MicroteachCaseTheme = objRow[convMicroteachCase4Tea.MicroteachCaseTheme] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTheme].ToString().Trim(); //微格教学案例主题词
objvMicroteachCase4TeaEN.MicroteachCaseDate = objRow[convMicroteachCase4Tea.MicroteachCaseDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDate].ToString().Trim(); //微格教学日期
objvMicroteachCase4TeaEN.MicroteachCaseTime = objRow[convMicroteachCase4Tea.MicroteachCaseTime] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseTime].ToString().Trim(); //微格教学时间
objvMicroteachCase4TeaEN.MicroteachCaseDateIn = objRow[convMicroteachCase4Tea.MicroteachCaseDateIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroteachCaseDateIn].ToString().Trim(); //案例入库日期
objvMicroteachCase4TeaEN.IdStudyLevel = objRow[convMicroteachCase4Tea.IdStudyLevel] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvMicroteachCase4TeaEN.StudyLevelName = objRow[convMicroteachCase4Tea.StudyLevelName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.StudyLevelName].ToString().Trim(); //学段名称
objvMicroteachCase4TeaEN.IdTeachingPlan = objRow[convMicroteachCase4Tea.IdTeachingPlan] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdTeachingPlan].ToString().Trim(); //教案流水号
objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn = objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.MicroTeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvMicroteachCase4TeaEN.IdMicroteachCaseType = objRow[convMicroteachCase4Tea.IdMicroteachCaseType].ToString().Trim(); //微格案例类型流水号
objvMicroteachCase4TeaEN.IdCaseType = objRow[convMicroteachCase4Tea.IdCaseType].ToString().Trim(); //案例类型流水号
objvMicroteachCase4TeaEN.IdDiscipline = objRow[convMicroteachCase4Tea.IdDiscipline].ToString().Trim(); //学科流水号
objvMicroteachCase4TeaEN.DisciplineID = objRow[convMicroteachCase4Tea.DisciplineID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineID].ToString().Trim(); //学科ID
objvMicroteachCase4TeaEN.DisciplineName = objRow[convMicroteachCase4Tea.DisciplineName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DisciplineName].ToString().Trim(); //学科名称
objvMicroteachCase4TeaEN.IdSenateGaugeVersion = objRow[convMicroteachCase4Tea.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvMicroteachCase4TeaEN.senateGaugeVersionID = objRow[convMicroteachCase4Tea.senateGaugeVersionID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvMicroteachCase4TeaEN.senateGaugeVersionName = objRow[convMicroteachCase4Tea.senateGaugeVersionName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvMicroteachCase4TeaEN.senateGaugeVersionTtlScore = objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convMicroteachCase4Tea.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvMicroteachCase4TeaEN.VersionNo = objRow[convMicroteachCase4Tea.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.VersionNo].ToString().Trim()); //版本号
objvMicroteachCase4TeaEN.IdTeachSkill = objRow[convMicroteachCase4Tea.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvMicroteachCase4TeaEN.TeachSkillID = objRow[convMicroteachCase4Tea.TeachSkillID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillID].ToString().Trim(); //教学技能ID
objvMicroteachCase4TeaEN.SkillTypeName = objRow[convMicroteachCase4Tea.SkillTypeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeName].ToString().Trim(); //技能类型名称
objvMicroteachCase4TeaEN.TeachSkillName = objRow[convMicroteachCase4Tea.TeachSkillName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillName].ToString().Trim(); //教学技能名称
objvMicroteachCase4TeaEN.TeachSkillTheory = objRow[convMicroteachCase4Tea.TeachSkillTheory] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvMicroteachCase4TeaEN.TeachSkillOperMethod = objRow[convMicroteachCase4Tea.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvMicroteachCase4TeaEN.IdSkillType = objRow[convMicroteachCase4Tea.IdSkillType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdSkillType].ToString().Trim(); //技能类型流水号
objvMicroteachCase4TeaEN.SkillTypeID = objRow[convMicroteachCase4Tea.SkillTypeID] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.SkillTypeID].ToString().Trim(); //技能类型ID
objvMicroteachCase4TeaEN.CaseLevelId = objRow[convMicroteachCase4Tea.CaseLevelId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CaseLevelId].ToString().Trim(); //课例等级Id
objvMicroteachCase4TeaEN.DocFile = objRow[convMicroteachCase4Tea.DocFile] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.DocFile].ToString().Trim(); //生成的Word文件名
objvMicroteachCase4TeaEN.IsNeedGeneWord = TransNullToBool(objRow[convMicroteachCase4Tea.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvMicroteachCase4TeaEN.WordCreateDate = objRow[convMicroteachCase4Tea.WordCreateDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.WordCreateDate].ToString().Trim(); //Word生成日期
objvMicroteachCase4TeaEN.IsVisible = TransNullToBool(objRow[convMicroteachCase4Tea.IsVisible].ToString().Trim()); //是否显示
objvMicroteachCase4TeaEN.microteachCaseText = objRow[convMicroteachCase4Tea.microteachCaseText] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.microteachCaseText].ToString().Trim(); //案例文本内容
objvMicroteachCase4TeaEN.OwnerId = objRow[convMicroteachCase4Tea.OwnerId].ToString().Trim(); //拥有者Id
objvMicroteachCase4TeaEN.OwnerName = objRow[convMicroteachCase4Tea.OwnerName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.OwnerName].ToString().Trim(); //拥有者姓名
objvMicroteachCase4TeaEN.TeacherId = objRow[convMicroteachCase4Tea.TeacherId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherId].ToString().Trim(); //教师工号
objvMicroteachCase4TeaEN.TeacherName = objRow[convMicroteachCase4Tea.TeacherName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.TeacherName].ToString().Trim(); //教师姓名
objvMicroteachCase4TeaEN.IdXzCollege = objRow[convMicroteachCase4Tea.IdXzCollege] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.IdXzCollege].ToString().Trim(); //学院流水号
objvMicroteachCase4TeaEN.CollegeName = objRow[convMicroteachCase4Tea.CollegeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeName].ToString().Trim(); //学院名称
objvMicroteachCase4TeaEN.EntryDate = objRow[convMicroteachCase4Tea.EntryDate] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryDate].ToString().Trim(); //进校日期
objvMicroteachCase4TeaEN.CollegeId = objRow[convMicroteachCase4Tea.CollegeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeId].ToString().Trim(); //学院ID
objvMicroteachCase4TeaEN.EntryYear = objRow[convMicroteachCase4Tea.EntryYear] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.EntryYear].ToString().Trim(); //EntryYear
objvMicroteachCase4TeaEN.IsDualVideo = TransNullToBool(objRow[convMicroteachCase4Tea.IsDualVideo].ToString().Trim()); //是否双视频
objvMicroteachCase4TeaEN.UserTypeId = objRow[convMicroteachCase4Tea.UserTypeId] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.UserTypeId].ToString().Trim(); //用户类型Id
objvMicroteachCase4TeaEN.RecommendedDegreeId = objRow[convMicroteachCase4Tea.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvMicroteachCase4TeaEN.RecommendedDegreeName = objRow[convMicroteachCase4Tea.RecommendedDegreeName] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvMicroteachCase4TeaEN.Memo = objRow[convMicroteachCase4Tea.Memo] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.Memo].ToString().Trim(); //备注
objvMicroteachCase4TeaEN.BrowseCount4Case = objRow[convMicroteachCase4Tea.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convMicroteachCase4Tea.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvMicroteachCase4TeaEN.CollegeNameA = objRow[convMicroteachCase4Tea.CollegeNameA] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.CollegeNameA].ToString().Trim(); //学院名称简写
objvMicroteachCase4TeaEN.ftpFileType = objRow[convMicroteachCase4Tea.ftpFileType] == DBNull.Value ? null : objRow[convMicroteachCase4Tea.ftpFileType].ToString().Trim(); //ftp文件类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMicroteachCase4TeaDA: GetObjByDataRow)", objException.Message));
}
objvMicroteachCase4TeaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMicroteachCase4TeaEN;
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
objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase4TeaEN._CurrTabName, convMicroteachCase4Tea.IdMicroteachCase, 8, "");
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
objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMicroteachCase4TeaEN._CurrTabName, convMicroteachCase4Tea.IdMicroteachCase, 8, strPrefix);
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroteachCase4Tea where " + strCondition;
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdMicroteachCase from vMicroteachCase4Tea where " + strCondition;
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
 /// <param name = "strIdMicroteachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdMicroteachCase)
{
CheckPrimaryKey(strIdMicroteachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase4Tea", "IdMicroteachCase = " + "'"+ strIdMicroteachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMicroteachCase4TeaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMicroteachCase4Tea", strCondition))
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
objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMicroteachCase4Tea");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMicroteachCase4TeaENS">源对象</param>
 /// <param name = "objvMicroteachCase4TeaENT">目标对象</param>
public void CopyTo(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENS, clsvMicroteachCase4TeaEN objvMicroteachCase4TeaENT)
{
objvMicroteachCase4TeaENT.IdMicroteachCase = objvMicroteachCase4TeaENS.IdMicroteachCase; //微格教学案例流水号
objvMicroteachCase4TeaENT.MicroteachCaseTypeName = objvMicroteachCase4TeaENS.MicroteachCaseTypeName; //微格案例类型名称
objvMicroteachCase4TeaENT.MicroteachCaseID = objvMicroteachCase4TeaENS.MicroteachCaseID; //微格教学案例ID
objvMicroteachCase4TeaENT.MicroteachCaseName = objvMicroteachCase4TeaENS.MicroteachCaseName; //微格教学案例名称
objvMicroteachCase4TeaENT.MicroteachCaseTheme = objvMicroteachCase4TeaENS.MicroteachCaseTheme; //微格教学案例主题词
objvMicroteachCase4TeaENT.MicroteachCaseDate = objvMicroteachCase4TeaENS.MicroteachCaseDate; //微格教学日期
objvMicroteachCase4TeaENT.MicroteachCaseTime = objvMicroteachCase4TeaENS.MicroteachCaseTime; //微格教学时间
objvMicroteachCase4TeaENT.MicroteachCaseDateIn = objvMicroteachCase4TeaENS.MicroteachCaseDateIn; //案例入库日期
objvMicroteachCase4TeaENT.IdStudyLevel = objvMicroteachCase4TeaENS.IdStudyLevel; //id_StudyLevel
objvMicroteachCase4TeaENT.StudyLevelName = objvMicroteachCase4TeaENS.StudyLevelName; //学段名称
objvMicroteachCase4TeaENT.IdTeachingPlan = objvMicroteachCase4TeaENS.IdTeachingPlan; //教案流水号
objvMicroteachCase4TeaENT.MicroTeachCaseTimeIn = objvMicroteachCase4TeaENS.MicroTeachCaseTimeIn; //案例入库时间
objvMicroteachCase4TeaENT.IdMicroteachCaseType = objvMicroteachCase4TeaENS.IdMicroteachCaseType; //微格案例类型流水号
objvMicroteachCase4TeaENT.IdCaseType = objvMicroteachCase4TeaENS.IdCaseType; //案例类型流水号
objvMicroteachCase4TeaENT.IdDiscipline = objvMicroteachCase4TeaENS.IdDiscipline; //学科流水号
objvMicroteachCase4TeaENT.DisciplineID = objvMicroteachCase4TeaENS.DisciplineID; //学科ID
objvMicroteachCase4TeaENT.DisciplineName = objvMicroteachCase4TeaENS.DisciplineName; //学科名称
objvMicroteachCase4TeaENT.IdSenateGaugeVersion = objvMicroteachCase4TeaENS.IdSenateGaugeVersion; //评价量表版本流水号
objvMicroteachCase4TeaENT.senateGaugeVersionID = objvMicroteachCase4TeaENS.senateGaugeVersionID; //评价量表版本ID
objvMicroteachCase4TeaENT.senateGaugeVersionName = objvMicroteachCase4TeaENS.senateGaugeVersionName; //评价量表版本名称
objvMicroteachCase4TeaENT.senateGaugeVersionTtlScore = objvMicroteachCase4TeaENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvMicroteachCase4TeaENT.VersionNo = objvMicroteachCase4TeaENS.VersionNo; //版本号
objvMicroteachCase4TeaENT.IdTeachSkill = objvMicroteachCase4TeaENS.IdTeachSkill; //教学技能流水号
objvMicroteachCase4TeaENT.TeachSkillID = objvMicroteachCase4TeaENS.TeachSkillID; //教学技能ID
objvMicroteachCase4TeaENT.SkillTypeName = objvMicroteachCase4TeaENS.SkillTypeName; //技能类型名称
objvMicroteachCase4TeaENT.TeachSkillName = objvMicroteachCase4TeaENS.TeachSkillName; //教学技能名称
objvMicroteachCase4TeaENT.TeachSkillTheory = objvMicroteachCase4TeaENS.TeachSkillTheory; //教学技能理论阐述
objvMicroteachCase4TeaENT.TeachSkillOperMethod = objvMicroteachCase4TeaENS.TeachSkillOperMethod; //教学技能实践操作方法
objvMicroteachCase4TeaENT.IdSkillType = objvMicroteachCase4TeaENS.IdSkillType; //技能类型流水号
objvMicroteachCase4TeaENT.SkillTypeID = objvMicroteachCase4TeaENS.SkillTypeID; //技能类型ID
objvMicroteachCase4TeaENT.CaseLevelId = objvMicroteachCase4TeaENS.CaseLevelId; //课例等级Id
objvMicroteachCase4TeaENT.DocFile = objvMicroteachCase4TeaENS.DocFile; //生成的Word文件名
objvMicroteachCase4TeaENT.IsNeedGeneWord = objvMicroteachCase4TeaENS.IsNeedGeneWord; //是否需要生成Word
objvMicroteachCase4TeaENT.WordCreateDate = objvMicroteachCase4TeaENS.WordCreateDate; //Word生成日期
objvMicroteachCase4TeaENT.IsVisible = objvMicroteachCase4TeaENS.IsVisible; //是否显示
objvMicroteachCase4TeaENT.microteachCaseText = objvMicroteachCase4TeaENS.microteachCaseText; //案例文本内容
objvMicroteachCase4TeaENT.OwnerId = objvMicroteachCase4TeaENS.OwnerId; //拥有者Id
objvMicroteachCase4TeaENT.OwnerName = objvMicroteachCase4TeaENS.OwnerName; //拥有者姓名
objvMicroteachCase4TeaENT.TeacherId = objvMicroteachCase4TeaENS.TeacherId; //教师工号
objvMicroteachCase4TeaENT.TeacherName = objvMicroteachCase4TeaENS.TeacherName; //教师姓名
objvMicroteachCase4TeaENT.IdXzCollege = objvMicroteachCase4TeaENS.IdXzCollege; //学院流水号
objvMicroteachCase4TeaENT.CollegeName = objvMicroteachCase4TeaENS.CollegeName; //学院名称
objvMicroteachCase4TeaENT.EntryDate = objvMicroteachCase4TeaENS.EntryDate; //进校日期
objvMicroteachCase4TeaENT.CollegeId = objvMicroteachCase4TeaENS.CollegeId; //学院ID
objvMicroteachCase4TeaENT.EntryYear = objvMicroteachCase4TeaENS.EntryYear; //EntryYear
objvMicroteachCase4TeaENT.IsDualVideo = objvMicroteachCase4TeaENS.IsDualVideo; //是否双视频
objvMicroteachCase4TeaENT.UserTypeId = objvMicroteachCase4TeaENS.UserTypeId; //用户类型Id
objvMicroteachCase4TeaENT.RecommendedDegreeId = objvMicroteachCase4TeaENS.RecommendedDegreeId; //推荐度Id
objvMicroteachCase4TeaENT.RecommendedDegreeName = objvMicroteachCase4TeaENS.RecommendedDegreeName; //推荐度名称
objvMicroteachCase4TeaENT.Memo = objvMicroteachCase4TeaENS.Memo; //备注
objvMicroteachCase4TeaENT.BrowseCount4Case = objvMicroteachCase4TeaENS.BrowseCount4Case; //课例浏览次数
objvMicroteachCase4TeaENT.CollegeNameA = objvMicroteachCase4TeaENS.CollegeNameA; //学院名称简写
objvMicroteachCase4TeaENT.ftpFileType = objvMicroteachCase4TeaENS.ftpFileType; //ftp文件类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMicroteachCase4TeaEN objvMicroteachCase4TeaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdMicroteachCase, 8, convMicroteachCase4Tea.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseTypeName, 50, convMicroteachCase4Tea.MicroteachCaseTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseID, 8, convMicroteachCase4Tea.MicroteachCaseID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseName, 100, convMicroteachCase4Tea.MicroteachCaseName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseTheme, 200, convMicroteachCase4Tea.MicroteachCaseTheme);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseDate, 8, convMicroteachCase4Tea.MicroteachCaseDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseTime, 6, convMicroteachCase4Tea.MicroteachCaseTime);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroteachCaseDateIn, 8, convMicroteachCase4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdStudyLevel, 4, convMicroteachCase4Tea.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.StudyLevelName, 50, convMicroteachCase4Tea.StudyLevelName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdTeachingPlan, 8, convMicroteachCase4Tea.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn, 6, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdMicroteachCaseType, 4, convMicroteachCase4Tea.IdMicroteachCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdCaseType, 4, convMicroteachCase4Tea.IdCaseType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdDiscipline, 4, convMicroteachCase4Tea.IdDiscipline);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.DisciplineID, 4, convMicroteachCase4Tea.DisciplineID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.DisciplineName, 50, convMicroteachCase4Tea.DisciplineName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdSenateGaugeVersion, 4, convMicroteachCase4Tea.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.senateGaugeVersionID, 4, convMicroteachCase4Tea.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.senateGaugeVersionName, 200, convMicroteachCase4Tea.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdTeachSkill, 8, convMicroteachCase4Tea.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeachSkillID, 8, convMicroteachCase4Tea.TeachSkillID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.SkillTypeName, 50, convMicroteachCase4Tea.SkillTypeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeachSkillName, 50, convMicroteachCase4Tea.TeachSkillName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeachSkillTheory, 8000, convMicroteachCase4Tea.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeachSkillOperMethod, 2000, convMicroteachCase4Tea.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdSkillType, 4, convMicroteachCase4Tea.IdSkillType);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.SkillTypeID, 4, convMicroteachCase4Tea.SkillTypeID);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.CaseLevelId, 2, convMicroteachCase4Tea.CaseLevelId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.DocFile, 200, convMicroteachCase4Tea.DocFile);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.WordCreateDate, 14, convMicroteachCase4Tea.WordCreateDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.microteachCaseText, 8000, convMicroteachCase4Tea.microteachCaseText);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.OwnerId, 20, convMicroteachCase4Tea.OwnerId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.OwnerName, 30, convMicroteachCase4Tea.OwnerName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeacherId, 12, convMicroteachCase4Tea.TeacherId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.TeacherName, 50, convMicroteachCase4Tea.TeacherName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.IdXzCollege, 4, convMicroteachCase4Tea.IdXzCollege);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.CollegeName, 100, convMicroteachCase4Tea.CollegeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.EntryDate, 8, convMicroteachCase4Tea.EntryDate);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.CollegeId, 4, convMicroteachCase4Tea.CollegeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.EntryYear, 8, convMicroteachCase4Tea.EntryYear);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.UserTypeId, 2, convMicroteachCase4Tea.UserTypeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.RecommendedDegreeId, 2, convMicroteachCase4Tea.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.RecommendedDegreeName, 30, convMicroteachCase4Tea.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.Memo, 1000, convMicroteachCase4Tea.Memo);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.CollegeNameA, 12, convMicroteachCase4Tea.CollegeNameA);
clsCheckSql.CheckFieldLen(objvMicroteachCase4TeaEN.ftpFileType, 30, convMicroteachCase4Tea.ftpFileType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdMicroteachCase, convMicroteachCase4Tea.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseTypeName, convMicroteachCase4Tea.MicroteachCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseID, convMicroteachCase4Tea.MicroteachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseName, convMicroteachCase4Tea.MicroteachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseTheme, convMicroteachCase4Tea.MicroteachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseDate, convMicroteachCase4Tea.MicroteachCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseTime, convMicroteachCase4Tea.MicroteachCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroteachCaseDateIn, convMicroteachCase4Tea.MicroteachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdStudyLevel, convMicroteachCase4Tea.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.StudyLevelName, convMicroteachCase4Tea.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdTeachingPlan, convMicroteachCase4Tea.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.MicroTeachCaseTimeIn, convMicroteachCase4Tea.MicroTeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdMicroteachCaseType, convMicroteachCase4Tea.IdMicroteachCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdCaseType, convMicroteachCase4Tea.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdDiscipline, convMicroteachCase4Tea.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.DisciplineID, convMicroteachCase4Tea.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.DisciplineName, convMicroteachCase4Tea.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdSenateGaugeVersion, convMicroteachCase4Tea.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.senateGaugeVersionID, convMicroteachCase4Tea.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.senateGaugeVersionName, convMicroteachCase4Tea.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdTeachSkill, convMicroteachCase4Tea.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeachSkillID, convMicroteachCase4Tea.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.SkillTypeName, convMicroteachCase4Tea.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeachSkillName, convMicroteachCase4Tea.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeachSkillTheory, convMicroteachCase4Tea.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeachSkillOperMethod, convMicroteachCase4Tea.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdSkillType, convMicroteachCase4Tea.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.SkillTypeID, convMicroteachCase4Tea.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.CaseLevelId, convMicroteachCase4Tea.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.DocFile, convMicroteachCase4Tea.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.WordCreateDate, convMicroteachCase4Tea.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.microteachCaseText, convMicroteachCase4Tea.microteachCaseText);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.OwnerId, convMicroteachCase4Tea.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.OwnerName, convMicroteachCase4Tea.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeacherId, convMicroteachCase4Tea.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.TeacherName, convMicroteachCase4Tea.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.IdXzCollege, convMicroteachCase4Tea.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.CollegeName, convMicroteachCase4Tea.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.EntryDate, convMicroteachCase4Tea.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.CollegeId, convMicroteachCase4Tea.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.EntryYear, convMicroteachCase4Tea.EntryYear);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.UserTypeId, convMicroteachCase4Tea.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.RecommendedDegreeId, convMicroteachCase4Tea.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.RecommendedDegreeName, convMicroteachCase4Tea.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.Memo, convMicroteachCase4Tea.Memo);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.CollegeNameA, convMicroteachCase4Tea.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvMicroteachCase4TeaEN.ftpFileType, convMicroteachCase4Tea.ftpFileType);
//检查外键字段长度
 objvMicroteachCase4TeaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdMicroteachCase()
{
//获取某学院所有专业信息
string strSQL = "select IdMicroteachCase, MicroteachCaseName from vMicroteachCase4Tea ";
 clsSpecSQLforSql mySql = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase4TeaEN._CurrTabName);
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMicroteachCase4TeaEN._CurrTabName, strCondition);
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
 objSQL = clsvMicroteachCase4TeaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}