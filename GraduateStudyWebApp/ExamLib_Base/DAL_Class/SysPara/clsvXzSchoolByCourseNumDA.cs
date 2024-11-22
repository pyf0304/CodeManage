
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzSchoolByCourseNumDA
 表名:vXzSchoolByCourseNum(01120335)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:51:20
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// vXzSchoolByCourseNum(vXzSchoolByCourseNum)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzSchoolByCourseNumDA : clsCommBase4DA
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
 return clsvXzSchoolByCourseNumEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzSchoolByCourseNumEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzSchoolByCourseNumEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzSchoolByCourseNumEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzSchoolByCourseNumEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdSchool">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdSchool)
{
strIdSchool = strIdSchool.Replace("'", "''");
if (strIdSchool.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vXzSchoolByCourseNum中,检查关键字,长度不正确!(clsvXzSchoolByCourseNumDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdSchool)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzSchoolByCourseNum中,关键字不能为空 或 null!(clsvXzSchoolByCourseNumDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdSchool);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzSchoolByCourseNumDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzSchoolByCourseNum(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable_vXzSchoolByCourseNum)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzSchoolByCourseNum.* from vXzSchoolByCourseNum Left Join {1} on {2} where {3} and vXzSchoolByCourseNum.IdSchool not in (Select top {5} vXzSchoolByCourseNum.IdSchool from vXzSchoolByCourseNum Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1} and IdSchool not in (Select top {2} IdSchool from vXzSchoolByCourseNum where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1} and IdSchool not in (Select top {3} IdSchool from vXzSchoolByCourseNum where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzSchoolByCourseNum.* from vXzSchoolByCourseNum Left Join {1} on {2} where {3} and vXzSchoolByCourseNum.IdSchool not in (Select top {5} vXzSchoolByCourseNum.IdSchool from vXzSchoolByCourseNum Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1} and IdSchool not in (Select top {2} IdSchool from vXzSchoolByCourseNum where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzSchoolByCourseNum where {1} and IdSchool not in (Select top {3} IdSchool from vXzSchoolByCourseNum where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzSchoolByCourseNumEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA:GetObjLst)", objException.Message));
}
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = TransNullToBool(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetObjLst)", objException.Message));
}
objvXzSchoolByCourseNumEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
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
public List<clsvXzSchoolByCourseNumEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzSchoolByCourseNumEN> arrObjLst = new List<clsvXzSchoolByCourseNumEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = TransNullToBool(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetObjLst)", objException.Message));
}
objvXzSchoolByCourseNumEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzSchoolByCourseNumEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzSchoolByCourseNum(ref clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where IdSchool = " + "'"+ objvXzSchoolByCourseNumEN.IdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzSchoolByCourseNumEN.IdSchool = objDT.Rows[0][convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolId = objDT.Rows[0][convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolName = objDT.Rows[0][convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolNameA = objDT.Rows[0][convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolTypeId = objDT.Rows[0][convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolTypeName = objDT.Rows[0][convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzSchoolByCourseNumEN.IsCurrentUse = TransNullToBool(objDT.Rows[0][convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objvXzSchoolByCourseNumEN.UpdDate = objDT.Rows[0][convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolByCourseNumEN.UpdUserId = objDT.Rows[0][convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolByCourseNumEN.Memo = objDT.Rows[0][convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzSchoolByCourseNumEN.CourseNum = TransNullToInt(objDT.Rows[0][convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetvXzSchoolByCourseNum)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdSchool">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzSchoolByCourseNumEN GetObjByIdSchool(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where IdSchool = " + "'"+ strIdSchool+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
 objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称(字段类型:varchar,字段长度:14,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvXzSchoolByCourseNumEN.IsCurrentUse = clsEntityBase2.TransNullToBool_S(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用(字段类型:bit,字段长度:1,是否可空:True)
 objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetObjByIdSchool)", objException.Message));
}
return objvXzSchoolByCourseNumEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzSchoolByCourseNumEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
strSQL = "Select * from vXzSchoolByCourseNum where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN()
{
IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(), //学校流水号
SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(), //学校编号
SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(), //学校名称
SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(), //学校简称
SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(), //学校类型Id
SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(), //学校类型名
IsCurrentUse = TransNullToBool(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()), //是否当前使用
UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(), //备注
CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()) //CourseNum
};
objvXzSchoolByCourseNumEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolByCourseNumEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzSchoolByCourseNumEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = TransNullToBool(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetObjByDataRowvXzSchoolByCourseNum)", objException.Message));
}
objvXzSchoolByCourseNumEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolByCourseNumEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzSchoolByCourseNumEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN = new clsvXzSchoolByCourseNumEN();
try
{
objvXzSchoolByCourseNumEN.IdSchool = objRow[convXzSchoolByCourseNum.IdSchool].ToString().Trim(); //学校流水号
objvXzSchoolByCourseNumEN.SchoolId = objRow[convXzSchoolByCourseNum.SchoolId].ToString().Trim(); //学校编号
objvXzSchoolByCourseNumEN.SchoolName = objRow[convXzSchoolByCourseNum.SchoolName].ToString().Trim(); //学校名称
objvXzSchoolByCourseNumEN.SchoolNameA = objRow[convXzSchoolByCourseNum.SchoolNameA] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolNameA].ToString().Trim(); //学校简称
objvXzSchoolByCourseNumEN.SchoolTypeId = objRow[convXzSchoolByCourseNum.SchoolTypeId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeId].ToString().Trim(); //学校类型Id
objvXzSchoolByCourseNumEN.SchoolTypeName = objRow[convXzSchoolByCourseNum.SchoolTypeName] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.SchoolTypeName].ToString().Trim(); //学校类型名
objvXzSchoolByCourseNumEN.IsCurrentUse = TransNullToBool(objRow[convXzSchoolByCourseNum.IsCurrentUse].ToString().Trim()); //是否当前使用
objvXzSchoolByCourseNumEN.UpdDate = objRow[convXzSchoolByCourseNum.UpdDate] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdDate].ToString().Trim(); //修改日期
objvXzSchoolByCourseNumEN.UpdUserId = objRow[convXzSchoolByCourseNum.UpdUserId] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.UpdUserId].ToString().Trim(); //修改用户Id
objvXzSchoolByCourseNumEN.Memo = objRow[convXzSchoolByCourseNum.Memo] == DBNull.Value ? null : objRow[convXzSchoolByCourseNum.Memo].ToString().Trim(); //备注
objvXzSchoolByCourseNumEN.CourseNum = objRow[convXzSchoolByCourseNum.CourseNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzSchoolByCourseNum.CourseNum].ToString().Trim()); //CourseNum
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzSchoolByCourseNumDA: GetObjByDataRow)", objException.Message));
}
objvXzSchoolByCourseNumEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzSchoolByCourseNumEN;
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
objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzSchoolByCourseNumEN._CurrTabName, convXzSchoolByCourseNum.IdSchool, 4, "");
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
objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzSchoolByCourseNumEN._CurrTabName, convXzSchoolByCourseNum.IdSchool, 4, strPrefix);
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdSchool from vXzSchoolByCourseNum where " + strCondition;
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdSchool from vXzSchoolByCourseNum where " + strCondition;
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
 /// <param name = "strIdSchool">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdSchool)
{
CheckPrimaryKey(strIdSchool);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzSchoolByCourseNum", "IdSchool = " + "'"+ strIdSchool+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzSchoolByCourseNumDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzSchoolByCourseNum", strCondition))
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
objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzSchoolByCourseNum");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzSchoolByCourseNumENS">源对象</param>
 /// <param name = "objvXzSchoolByCourseNumENT">目标对象</param>
public void CopyTo(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENS, clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumENT)
{
objvXzSchoolByCourseNumENT.IdSchool = objvXzSchoolByCourseNumENS.IdSchool; //学校流水号
objvXzSchoolByCourseNumENT.SchoolId = objvXzSchoolByCourseNumENS.SchoolId; //学校编号
objvXzSchoolByCourseNumENT.SchoolName = objvXzSchoolByCourseNumENS.SchoolName; //学校名称
objvXzSchoolByCourseNumENT.SchoolNameA = objvXzSchoolByCourseNumENS.SchoolNameA; //学校简称
objvXzSchoolByCourseNumENT.SchoolTypeId = objvXzSchoolByCourseNumENS.SchoolTypeId; //学校类型Id
objvXzSchoolByCourseNumENT.SchoolTypeName = objvXzSchoolByCourseNumENS.SchoolTypeName; //学校类型名
objvXzSchoolByCourseNumENT.IsCurrentUse = objvXzSchoolByCourseNumENS.IsCurrentUse; //是否当前使用
objvXzSchoolByCourseNumENT.UpdDate = objvXzSchoolByCourseNumENS.UpdDate; //修改日期
objvXzSchoolByCourseNumENT.UpdUserId = objvXzSchoolByCourseNumENS.UpdUserId; //修改用户Id
objvXzSchoolByCourseNumENT.Memo = objvXzSchoolByCourseNumENS.Memo; //备注
objvXzSchoolByCourseNumENT.CourseNum = objvXzSchoolByCourseNumENS.CourseNum; //CourseNum
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzSchoolByCourseNumEN objvXzSchoolByCourseNumEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.IdSchool, 4, convXzSchoolByCourseNum.IdSchool);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.SchoolId, 10, convXzSchoolByCourseNum.SchoolId);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.SchoolName, 50, convXzSchoolByCourseNum.SchoolName);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.SchoolNameA, 14, convXzSchoolByCourseNum.SchoolNameA);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.SchoolTypeId, 2, convXzSchoolByCourseNum.SchoolTypeId);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.SchoolTypeName, 30, convXzSchoolByCourseNum.SchoolTypeName);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.UpdDate, 20, convXzSchoolByCourseNum.UpdDate);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.UpdUserId, 20, convXzSchoolByCourseNum.UpdUserId);
clsCheckSql.CheckFieldLen(objvXzSchoolByCourseNumEN.Memo, 1000, convXzSchoolByCourseNum.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.IdSchool, convXzSchoolByCourseNum.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.SchoolId, convXzSchoolByCourseNum.SchoolId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.SchoolName, convXzSchoolByCourseNum.SchoolName);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.SchoolNameA, convXzSchoolByCourseNum.SchoolNameA);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.SchoolTypeId, convXzSchoolByCourseNum.SchoolTypeId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.SchoolTypeName, convXzSchoolByCourseNum.SchoolTypeName);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.UpdDate, convXzSchoolByCourseNum.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.UpdUserId, convXzSchoolByCourseNum.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvXzSchoolByCourseNumEN.Memo, convXzSchoolByCourseNum.Memo);
//检查外键字段长度
 objvXzSchoolByCourseNumEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdSchool()
{
//获取某学院所有专业信息
string strSQL = "select IdSchool, SchoolName from vXzSchoolByCourseNum ";
 clsSpecSQLforSql mySql = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzSchoolByCourseNumEN._CurrTabName);
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzSchoolByCourseNumEN._CurrTabName, strCondition);
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
 objSQL = clsvXzSchoolByCourseNumDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}