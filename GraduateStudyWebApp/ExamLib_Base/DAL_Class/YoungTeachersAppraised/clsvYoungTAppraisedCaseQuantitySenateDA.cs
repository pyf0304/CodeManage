
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvYoungTAppraisedCaseQuantitySenateDA
 表名:vYoungTAppraisedCaseQuantitySenate(01120445)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:28
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
 /// v青教评优专家量化评价(vYoungTAppraisedCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvYoungTAppraisedCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvYoungTAppraisedCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvYoungTAppraisedCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vYoungTAppraisedCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable_vYoungTAppraisedCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCaseQuantitySenate.* from vYoungTAppraisedCaseQuantitySenate Left Join {1} on {2} where {3} and vYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vYoungTAppraisedCaseQuantitySenate.* from vYoungTAppraisedCaseQuantitySenate Left Join {1} on {2} where {3} and vYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vYoungTAppraisedCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = new List<clsvYoungTAppraisedCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN();
try
{
objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvYoungTAppraisedCaseQuantitySenateEN.UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvYoungTAppraisedCaseQuantitySenateEN.UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseQuantitySenateEN);
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
public List<clsvYoungTAppraisedCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvYoungTAppraisedCaseQuantitySenateEN> arrObjLst = new List<clsvYoungTAppraisedCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN();
try
{
objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvYoungTAppraisedCaseQuantitySenateEN.UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvYoungTAppraisedCaseQuantitySenateEN.UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvYoungTAppraisedCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvYoungTAppraisedCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvYoungTAppraisedCaseQuantitySenate(ref clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark(字段类型:varchar,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark(字段类型:varchar,字段长度:100,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UserId = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UserName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetvYoungTAppraisedCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvYoungTAppraisedCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN();
try
{
 objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark(字段类型:varchar,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark(字段类型:varchar,字段长度:100,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期(字段类型:char,字段长度:8,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvYoungTAppraisedCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvYoungTAppraisedCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(), //青教评优案例流水号
YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(), //青教评优案例ID
YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(), //青教评优案例名称
TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(), //教师姓名
BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(), //CollegeID_Mark
CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(), //CollegeName_Mark
IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(), //id_College_Mark
StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(), //学工号
UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(), //用户名
OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(), //青教评优教学日期
YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(), //青教案例类型名称
UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim() //学院名称简写
};
objvYoungTAppraisedCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN();
try
{
objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvYoungTAppraisedCaseQuantitySenateEN.UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvYoungTAppraisedCaseQuantitySenateEN.UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetObjByDataRowvYoungTAppraisedCaseQuantitySenate)", objException.Message));
}
objvYoungTAppraisedCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvYoungTAppraisedCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN = new clsvYoungTAppraisedCaseQuantitySenateEN();
try
{
objvYoungTAppraisedCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase].ToString().Trim(); //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID].ToString().Trim(); //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName].ToString().Trim(); //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateEN.TeacherID = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherID].ToString().Trim(); //教师工号
objvYoungTAppraisedCaseQuantitySenateEN.TeacherName = objRow[convYoungTAppraisedCaseQuantitySenate.TeacherName].ToString().Trim(); //教师姓名
objvYoungTAppraisedCaseQuantitySenateEN.BrowseCount = objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convYoungTAppraisedCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvYoungTAppraisedCaseQuantitySenateEN.SenateContent = objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvYoungTAppraisedCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvYoungTAppraisedCaseQuantitySenateEN.SenateDate = objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvYoungTAppraisedCaseQuantitySenateEN.SenateTime = objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateEN.UpdUser = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName = objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvYoungTAppraisedCaseQuantitySenateEN.CollegeID = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvYoungTAppraisedCaseQuantitySenateEN.CollegeName = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvYoungTAppraisedCaseQuantitySenateEN.SenateIp = objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeIDMark].ToString().Trim(); //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameMark].ToString().Trim(); //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark = objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdCollegeMark].ToString().Trim(); //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId = objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvYoungTAppraisedCaseQuantitySenateEN.UserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvYoungTAppraisedCaseQuantitySenateEN.UserName = objRow[convYoungTAppraisedCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvYoungTAppraisedCaseQuantitySenateEN.OwnerId = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName = objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType = objRow[convYoungTAppraisedCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase = objRow[convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateEN.OwnerName = objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate].ToString().Trim(); //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName = objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName].ToString().Trim(); //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId = objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege = objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA = objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convYoungTAppraisedCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvYoungTAppraisedCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvYoungTAppraisedCaseQuantitySenateEN;
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
objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName, convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName, convYoungTAppraisedCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vYoungTAppraisedCaseQuantitySenate where " + strCondition;
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
 /// <param name = "lngIdmicroteachCaseQuantitySenate">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdmicroteachCaseQuantitySenate)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvYoungTAppraisedCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vYoungTAppraisedCaseQuantitySenate", strCondition))
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
objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vYoungTAppraisedCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvYoungTAppraisedCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateENS, clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateENT)
{
objvYoungTAppraisedCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvYoungTAppraisedCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvYoungTAppraisedCaseQuantitySenateENT.IdYoungTAppraisedCase = objvYoungTAppraisedCaseQuantitySenateENS.IdYoungTAppraisedCase; //青教评优案例流水号
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseID = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseID; //青教评优案例ID
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseName = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseName; //青教评优案例名称
objvYoungTAppraisedCaseQuantitySenateENT.TeacherID = objvYoungTAppraisedCaseQuantitySenateENS.TeacherID; //教师工号
objvYoungTAppraisedCaseQuantitySenateENT.TeacherName = objvYoungTAppraisedCaseQuantitySenateENS.TeacherName; //教师姓名
objvYoungTAppraisedCaseQuantitySenateENT.BrowseCount = objvYoungTAppraisedCaseQuantitySenateENS.BrowseCount; //浏览次数
objvYoungTAppraisedCaseQuantitySenateENT.SenateTheme = objvYoungTAppraisedCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvYoungTAppraisedCaseQuantitySenateENT.SenateContent = objvYoungTAppraisedCaseQuantitySenateENS.SenateContent; //评价内容
objvYoungTAppraisedCaseQuantitySenateENT.SenateTotalScore = objvYoungTAppraisedCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvYoungTAppraisedCaseQuantitySenateENT.SenateDate = objvYoungTAppraisedCaseQuantitySenateENS.SenateDate; //评价日期
objvYoungTAppraisedCaseQuantitySenateENT.SenateTime = objvYoungTAppraisedCaseQuantitySenateENS.SenateTime; //评价时间
objvYoungTAppraisedCaseQuantitySenateENT.IdSenateGaugeVersion = objvYoungTAppraisedCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionID = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionName = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvYoungTAppraisedCaseQuantitySenateENT.UpdUser = objvYoungTAppraisedCaseQuantitySenateENS.UpdUser; //修改人
objvYoungTAppraisedCaseQuantitySenateENT.UpdUserName = objvYoungTAppraisedCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvYoungTAppraisedCaseQuantitySenateENT.CollegeID = objvYoungTAppraisedCaseQuantitySenateENS.CollegeID; //学院ID
objvYoungTAppraisedCaseQuantitySenateENT.CollegeName = objvYoungTAppraisedCaseQuantitySenateENS.CollegeName; //学院名称
objvYoungTAppraisedCaseQuantitySenateENT.SenateIp = objvYoungTAppraisedCaseQuantitySenateENS.SenateIp; //评议Ip
objvYoungTAppraisedCaseQuantitySenateENT.CollegeIDMark = objvYoungTAppraisedCaseQuantitySenateENS.CollegeIDMark; //CollegeID_Mark
objvYoungTAppraisedCaseQuantitySenateENT.CollegeNameMark = objvYoungTAppraisedCaseQuantitySenateENS.CollegeNameMark; //CollegeName_Mark
objvYoungTAppraisedCaseQuantitySenateENT.IdCollegeMark = objvYoungTAppraisedCaseQuantitySenateENS.IdCollegeMark; //id_College_Mark
objvYoungTAppraisedCaseQuantitySenateENT.StuIdTeacherId = objvYoungTAppraisedCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvYoungTAppraisedCaseQuantitySenateENT.UserId = objvYoungTAppraisedCaseQuantitySenateENS.UserId; //用户ID
objvYoungTAppraisedCaseQuantitySenateENT.UserName = objvYoungTAppraisedCaseQuantitySenateENS.UserName; //用户名
objvYoungTAppraisedCaseQuantitySenateENT.OwnerId = objvYoungTAppraisedCaseQuantitySenateENS.OwnerId; //拥有者Id
objvYoungTAppraisedCaseQuantitySenateENT.AppraiseTypeName = objvYoungTAppraisedCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvYoungTAppraisedCaseQuantitySenateENT.FuncModuleId = objvYoungTAppraisedCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvYoungTAppraisedCaseQuantitySenateENT.FuncModuleName = objvYoungTAppraisedCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvYoungTAppraisedCaseQuantitySenateENT.IdAppraiseType = objvYoungTAppraisedCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvYoungTAppraisedCaseQuantitySenateENT.IdMicroteachCase = objvYoungTAppraisedCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvYoungTAppraisedCaseQuantitySenateENT.OwnerName = objvYoungTAppraisedCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvYoungTAppraisedCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvYoungTAppraisedCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseDate = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseDate; //青教评优教学日期
objvYoungTAppraisedCaseQuantitySenateENT.YoungTAppraisedCaseTypeName = objvYoungTAppraisedCaseQuantitySenateENS.YoungTAppraisedCaseTypeName; //青教案例类型名称
objvYoungTAppraisedCaseQuantitySenateENT.UserNameWithUserId = objvYoungTAppraisedCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvYoungTAppraisedCaseQuantitySenateENT.IdXzCollege = objvYoungTAppraisedCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvYoungTAppraisedCaseQuantitySenateENT.CollegeNameA = objvYoungTAppraisedCaseQuantitySenateENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvYoungTAppraisedCaseQuantitySenateEN objvYoungTAppraisedCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase, 8, convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName, 100, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.TeacherID, 12, convYoungTAppraisedCaseQuantitySenate.TeacherID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.TeacherName, 50, convYoungTAppraisedCaseQuantitySenate.TeacherName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme, 200, convYoungTAppraisedCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.SenateContent, 2000, convYoungTAppraisedCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.SenateDate, 8, convYoungTAppraisedCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.SenateTime, 6, convYoungTAppraisedCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID, 4, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName, 200, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.UpdUser, 20, convYoungTAppraisedCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName, 20, convYoungTAppraisedCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.CollegeID, 4, convYoungTAppraisedCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.CollegeName, 100, convYoungTAppraisedCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.SenateIp, 50, convYoungTAppraisedCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark, 4, convYoungTAppraisedCaseQuantitySenate.CollegeIDMark);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark, 100, convYoungTAppraisedCaseQuantitySenate.CollegeNameMark);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark, 4, convYoungTAppraisedCaseQuantitySenate.IdCollegeMark);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId, 20, convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.UserId, 18, convYoungTAppraisedCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.UserName, 30, convYoungTAppraisedCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.OwnerId, 20, convYoungTAppraisedCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName, 50, convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId, 4, convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName, 30, convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType, 4, convYoungTAppraisedCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase, 8, convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.OwnerName, 30, convYoungTAppraisedCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate, 8, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName, 50, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId, 51, convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege, 4, convYoungTAppraisedCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA, 12, convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdYoungTAppraisedCase, convYoungTAppraisedCaseQuantitySenate.IdYoungTAppraisedCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseID, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseName, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.TeacherID, convYoungTAppraisedCaseQuantitySenate.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.TeacherName, convYoungTAppraisedCaseQuantitySenate.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.SenateTheme, convYoungTAppraisedCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.SenateContent, convYoungTAppraisedCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.SenateDate, convYoungTAppraisedCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.SenateTime, convYoungTAppraisedCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdSenateGaugeVersion, convYoungTAppraisedCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionID, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.senateGaugeVersionName, convYoungTAppraisedCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.UpdUser, convYoungTAppraisedCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.UpdUserName, convYoungTAppraisedCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.CollegeID, convYoungTAppraisedCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.CollegeName, convYoungTAppraisedCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.SenateIp, convYoungTAppraisedCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.CollegeIDMark, convYoungTAppraisedCaseQuantitySenate.CollegeIDMark);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameMark, convYoungTAppraisedCaseQuantitySenate.CollegeNameMark);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdCollegeMark, convYoungTAppraisedCaseQuantitySenate.IdCollegeMark);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.StuIdTeacherId, convYoungTAppraisedCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.UserId, convYoungTAppraisedCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.UserName, convYoungTAppraisedCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.OwnerId, convYoungTAppraisedCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.AppraiseTypeName, convYoungTAppraisedCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleId, convYoungTAppraisedCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.FuncModuleName, convYoungTAppraisedCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdAppraiseType, convYoungTAppraisedCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdMicroteachCase, convYoungTAppraisedCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.OwnerName, convYoungTAppraisedCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseDate, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.YoungTAppraisedCaseTypeName, convYoungTAppraisedCaseQuantitySenate.YoungTAppraisedCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.UserNameWithUserId, convYoungTAppraisedCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.IdXzCollege, convYoungTAppraisedCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvYoungTAppraisedCaseQuantitySenateEN.CollegeNameA, convYoungTAppraisedCaseQuantitySenate.CollegeNameA);
//检查外键字段长度
 objvYoungTAppraisedCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvYoungTAppraisedCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvYoungTAppraisedCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}