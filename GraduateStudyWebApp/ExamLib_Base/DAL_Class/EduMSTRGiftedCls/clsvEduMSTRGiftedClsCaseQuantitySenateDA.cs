
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseQuantitySenateDA
 表名:vEduMSTRGiftedClsCaseQuantitySenate(01120452)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:30
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评(EduMSTRGiftedCls)
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
 /// v教育硕士优课教师量化评价(vEduMSTRGiftedClsCaseQuantitySenate)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvEduMSTRGiftedClsCaseQuantitySenateDA : clsCommBase4DA
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
 return clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseQuantitySenateEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseQuantitySenateEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvEduMSTRGiftedClsCaseQuantitySenateEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvEduMSTRGiftedClsCaseQuantitySenateEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vEduMSTRGiftedClsCaseQuantitySenate(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable_vEduMSTRGiftedClsCaseQuantitySenate)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCaseQuantitySenate.* from vEduMSTRGiftedClsCaseQuantitySenate Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vEduMSTRGiftedClsCaseQuantitySenate.* from vEduMSTRGiftedClsCaseQuantitySenate Left Join {1} on {2} where {3} and vEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate not in (Select top {5} vEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {2} IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vEduMSTRGiftedClsCaseQuantitySenate where {1} and IdmicroteachCaseQuantitySenate not in (Select top {3} IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA:GetObjLst)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN();
try
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseQuantitySenateEN);
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
public List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA:GetObjLstByTabName)", objException.Message));
}
List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = new List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN();
try
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetObjLst)", objException.Message));
}
objvEduMSTRGiftedClsCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvEduMSTRGiftedClsCaseQuantitySenateEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvEduMSTRGiftedClsCaseQuantitySenate(ref clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = TransNullToInt(objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = TransNullToBool(objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objDT.Rows[0][convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetvEduMSTRGiftedClsCaseQuantitySenate)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdmicroteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByIdmicroteachCaseQuantitySenate(long lngIdmicroteachCaseQuantitySenate)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN();
try
{
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = Int32.Parse(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名(字段类型:varchar,字段长度:30,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = Single.Parse(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数(字段类型:float,字段长度:8,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期(字段类型:char,字段长度:8,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间(字段类型:char,字段长度:6,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip(字段类型:varchar,字段长度:50,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved(字段类型:bit,字段长度:1,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId(字段类型:varchar,字段长度:51,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id(字段类型:char,字段长度:2,是否可空:False)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName(字段类型:varchar,字段长度:20,是否可空:True)
 objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetObjByIdmicroteachCaseQuantitySenate)", objException.Message));
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvEduMSTRGiftedClsCaseQuantitySenateEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
strSQL = "Select * from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN()
{
IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()), //微格量化评价流水号
FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(), //功能模块名称
IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(), //微格教学案例流水号
IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(), //教育硕士优课案例流水号
EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(), //教育硕士优课案例ID
EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(), //教育硕士优课案例名称
EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(), //教育硕士优课案例日期
EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(), //教育硕士优课案例类型名称
senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(), //拥有者Id
StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(), //姓名
StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(), //学号
IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(), //学院流水号
UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(), //用户类别名
UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(), //用户类型名称
OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(), //拥有者姓名
IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(), //评议类型流水号
AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(), //评议类型名称
SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(), //量化评价主题
SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(), //评价内容
SenateTotalScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()), //评价分数
SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(), //评价日期
SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(), //评价时间
SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(), //评议Ip
BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(), //用户ID
CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(), //学院名称
IsLeaved = TransNullToBool(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()), //IsLeaved
StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(), //学工号
UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(), //UserNameWithUserId
CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(), //学院名称简写
UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(), //用户名
UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(), //用户类别Id
UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(), //用户类型Id
UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(), //修改人
UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(), //UpdUserName
OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim() //拥有者名称附Id
};
objvEduMSTRGiftedClsCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN();
try
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetObjByDataRowvEduMSTRGiftedClsCaseQuantitySenate)", objException.Message));
}
objvEduMSTRGiftedClsCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = new clsvEduMSTRGiftedClsCaseQuantitySenateEN();
try
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdmicroteachCaseQuantitySenate = TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate].ToString().Trim()); //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId].ToString().Trim(); //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName].ToString().Trim(); //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase].ToString().Trim(); //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID].ToString().Trim(); //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName].ToString().Trim(); //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate].ToString().Trim(); //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName].ToString().Trim(); //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId].ToString().Trim(); //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuName].ToString().Trim(); //姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuID].ToString().Trim(); //学号
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege].ToString().Trim(); //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName].ToString().Trim(); //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName].ToString().Trim(); //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName].ToString().Trim(); //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme].ToString().Trim(); //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent].ToString().Trim(); //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = TransNullToFloat(objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore].ToString().Trim()); //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate].ToString().Trim(); //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime].ToString().Trim(); //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp].ToString().Trim(); //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount].ToString().Trim()); //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion = objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserId].ToString().Trim(); //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID].ToString().Trim(); //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName].ToString().Trim(); //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = TransNullToBool(objRow[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved].ToString().Trim()); //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId].ToString().Trim(); //学工号
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId].ToString().Trim(); //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA].ToString().Trim(); //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserName].ToString().Trim(); //用户名
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId].ToString().Trim(); //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId].ToString().Trim(); //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser].ToString().Trim(); //修改人
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName].ToString().Trim(); //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] == DBNull.Value ? null : objRow[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA: GetObjByDataRow)", objException.Message));
}
objvEduMSTRGiftedClsCaseQuantitySenateEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
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
objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName, convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, "");
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
objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName, convEduMSTRGiftedClsCaseQuantitySenate.IdmicroteachCaseQuantitySenate, 8, strPrefix);
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdmicroteachCaseQuantitySenate from vEduMSTRGiftedClsCaseQuantitySenate where " + strCondition;
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCaseQuantitySenate", "IdmicroteachCaseQuantitySenate = " + ""+ lngIdmicroteachCaseQuantitySenate+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvEduMSTRGiftedClsCaseQuantitySenateDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vEduMSTRGiftedClsCaseQuantitySenate", strCondition))
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
objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vEduMSTRGiftedClsCaseQuantitySenate");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateENT">目标对象</param>
public void CopyTo(clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateENS, clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateENT)
{
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdmicroteachCaseQuantitySenate = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdmicroteachCaseQuantitySenate; //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.FuncModuleId = objvEduMSTRGiftedClsCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.FuncModuleName = objvEduMSTRGiftedClsCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdMicroteachCase = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdMicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdEduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdEduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerId = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuName = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuName; //姓名
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuID = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuID; //学号
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdXzCollege = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdXzCollege; //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserKindName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserKindName; //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerName = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdAppraiseType = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdAppraiseType; //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.AppraiseTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTheme = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateContent = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateContent; //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTotalScore = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateDate = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateDate; //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTime = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTime; //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateIp = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateIp; //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateENT.BrowseCount = objvEduMSTRGiftedClsCaseQuantitySenateENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateENT.IdSenateGaugeVersion = objvEduMSTRGiftedClsCaseQuantitySenateENS.IdSenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserId; //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeID = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.IsLeaved = objvEduMSTRGiftedClsCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuIdTeacherId = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserNameWithUserId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeNameA = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserName; //用户名
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserKindId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserKindId; //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserTypeId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.UpdUser = objvEduMSTRGiftedClsCaseQuantitySenateENS.UpdUser; //修改人
objvEduMSTRGiftedClsCaseQuantitySenateENT.UpdUserName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerNameWithId = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId, 4, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName, 30, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId, 20, convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName, 50, convEduMSTRGiftedClsCaseQuantitySenate.StuName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID, 20, convEduMSTRGiftedClsCaseQuantitySenate.StuID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege, 4, convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName, 30, convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName, 20, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName, 30, convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType, 4, convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName, 50, convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme, 200, convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent, 2000, convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime, 6, convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp, 50, convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion, 4, convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID, 4, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName, 200, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId, 18, convEduMSTRGiftedClsCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID, 4, convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName, 100, convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId, 20, convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId, 51, convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA, 12, convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName, 30, convEduMSTRGiftedClsCaseQuantitySenate.UserName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser, 20, convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName, 20, convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckFieldLen(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId, 51, convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdMicroteachCase, convEduMSTRGiftedClsCaseQuantitySenate.IdMicroteachCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdEduMSTRGiftedClsCase, convEduMSTRGiftedClsCaseQuantitySenate.IdEduMSTRGiftedClsCase);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId, convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName, convEduMSTRGiftedClsCaseQuantitySenate.StuName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID, convEduMSTRGiftedClsCaseQuantitySenate.StuID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdXzCollege, convEduMSTRGiftedClsCaseQuantitySenate.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName, convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName, convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdAppraiseType, convEduMSTRGiftedClsCaseQuantitySenate.IdAppraiseType);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName, convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme, convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent, convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate, convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime, convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp, convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.IdSenateGaugeVersion, convEduMSTRGiftedClsCaseQuantitySenate.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId, convEduMSTRGiftedClsCaseQuantitySenate.UserId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID, convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName, convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId, convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId, convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA, convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName, convEduMSTRGiftedClsCaseQuantitySenate.UserName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId, convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser, convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName, convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
clsCheckSql.CheckSqlInjection4Field(objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId, convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
//检查外键字段长度
 objvEduMSTRGiftedClsCaseQuantitySenateEN._IsCheckProperty = true;
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName);
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName, strCondition);
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
 objSQL = clsvEduMSTRGiftedClsCaseQuantitySenateDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}