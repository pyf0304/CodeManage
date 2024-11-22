
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeacherInfoDA
 表名:TeacherInfo(01120093)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// 教师(TeacherInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTeacherInfoDA : clsCommBase4DA
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
 return clsTeacherInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTeacherInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTeacherInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTeacherInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTeacherInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeacher">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeacher)
{
strIdTeacher = strIdTeacher.Replace("'", "''");
if (strIdTeacher.Length > 8)
{
throw new Exception("(errid:Data000001)在表:TeacherInfo中,检查关键字,长度不正确!(clsTeacherInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeacher)  ==  true)
{
throw new Exception("(errid:Data000002)在表:TeacherInfo中,关键字不能为空 或 null!(clsTeacherInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeacher);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsTeacherInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TeacherInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable_TeacherInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeacherInfo.* from TeacherInfo Left Join {1} on {2} where {3} and TeacherInfo.IdTeacher not in (Select top {5} TeacherInfo.IdTeacher from TeacherInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1} and IdTeacher not in (Select top {2} IdTeacher from TeacherInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1} and IdTeacher not in (Select top {3} IdTeacher from TeacherInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTeacherInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TeacherInfo.* from TeacherInfo Left Join {1} on {2} where {3} and TeacherInfo.IdTeacher not in (Select top {5} TeacherInfo.IdTeacher from TeacherInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1} and IdTeacher not in (Select top {2} IdTeacher from TeacherInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TeacherInfo where {1} and IdTeacher not in (Select top {3} IdTeacher from TeacherInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTeacherInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTeacherInfoDA:GetObjLst)", objException.Message));
}
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = TransNullToBool(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = TransNullToBool(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = TransNullToBool(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = TransNullToBool(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeacherInfoDA: GetObjLst)", objException.Message));
}
objTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeacherInfoEN);
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
public List<clsTeacherInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTeacherInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsTeacherInfoEN> arrObjLst = new List<clsTeacherInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = TransNullToBool(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = TransNullToBool(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = TransNullToBool(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = TransNullToBool(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTeacherInfoDA: GetObjLst)", objException.Message));
}
objTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTeacherInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTeacherInfo(ref clsTeacherInfoEN objTeacherInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where IdTeacher = " + "'"+ objTeacherInfoEN.IdTeacher+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTeacherInfoEN.IdTeacher = objDT.Rows[0][conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeacherInfoEN.TeacherId = objDT.Rows[0][conTeacherInfo.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objTeacherInfoEN.TeacherName = objDT.Rows[0][conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objTeacherInfoEN.IdSex = objDT.Rows[0][conTeacherInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdSchoolPs = objDT.Rows[0][conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdDisciplinePs = objDT.Rows[0][conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IdUniZone = objDT.Rows[0][conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdEthnic = objDT.Rows[0][conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdPolitics = objDT.Rows[0][conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdAdminGrade = objDT.Rows[0][conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdProfGrade = objDT.Rows[0][conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdQualif = objDT.Rows[0][conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdDegree = objDT.Rows[0][conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdStaffType = objDT.Rows[0][conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdProvince = objDT.Rows[0][conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.CitizenId = objDT.Rows[0][conTeacherInfo.CitizenId].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:25,是否可空:True)
 objTeacherInfoEN.CardNo = objDT.Rows[0][conTeacherInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objTeacherInfoEN.Birthday = objDT.Rows[0][conTeacherInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.GraduationMajor = objDT.Rows[0][conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业(字段类型:varchar,字段长度:40,是否可空:True)
 objTeacherInfoEN.TelNo = objDT.Rows[0][conTeacherInfo.TelNo].ToString().Trim(); //电话(字段类型:varchar,字段长度:50,是否可空:True)
 objTeacherInfoEN.Email = objDT.Rows[0][conTeacherInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.WebSite = objDT.Rows[0][conTeacherInfo.WebSite].ToString().Trim(); //个人主页(字段类型:varchar,字段长度:60,是否可空:True)
 objTeacherInfoEN.PersonBlog = objDT.Rows[0][conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客(字段类型:varchar,字段长度:60,是否可空:True)
 objTeacherInfoEN.EntryDate = objDT.Rows[0][conTeacherInfo.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.Offed = TransNullToBool(objDT.Rows[0][conTeacherInfo.Offed].ToString().Trim()); //是否离校(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsAvconUser = TransNullToBool(objDT.Rows[0][conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsGpUser = TransNullToBool(objDT.Rows[0][conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsLocalUser = TransNullToBool(objDT.Rows[0][conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.FromUnit = objDT.Rows[0][conTeacherInfo.FromUnit].ToString().Trim(); //来自单位(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.Memo = objDT.Rows[0][conTeacherInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeacherInfoEN.IdXzCollege = objDT.Rows[0][conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IdXzMajor = objDT.Rows[0][conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeacherInfoEN.EntryDay = objDT.Rows[0][conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.IdPhoto = objDT.Rows[0][conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.IdReligion = objDT.Rows[0][conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IsMessage = TransNullToBool(objDT.Rows[0][conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.Microblog = objDT.Rows[0][conTeacherInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objTeacherInfoEN.ModifyUserId = objDT.Rows[0][conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objTeacherInfoEN.OffedBak = TransNullToBool(objDT.Rows[0][conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.PhoneNumber = objDT.Rows[0][conTeacherInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objTeacherInfoEN.QQ = objDT.Rows[0][conTeacherInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.TeachIdCollege = objDT.Rows[0][conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College(字段类型:varchar,字段长度:6,是否可空:True)
 objTeacherInfoEN.TeachIdMajor = objDT.Rows[0][conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.Tel = objDT.Rows[0][conTeacherInfo.Tel].ToString().Trim(); //Tel(字段类型:varchar,字段长度:50,是否可空:True)
 objTeacherInfoEN.Headphoto = objDT.Rows[0][conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto(字段类型:varchar,字段长度:500,是否可空:True)
 objTeacherInfoEN.ModifyDate = objDT.Rows[0][conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeacherInfoEN.RegisterPassword = objDT.Rows[0][conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objTeacherInfoEN.TeacherPhoto = objDT.Rows[0][conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto(字段类型:varchar,字段长度:500,是否可空:True)
 objTeacherInfoEN.IdCardNo = objDT.Rows[0][conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTeacherInfoDA: GetTeacherInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public clsTeacherInfoEN GetObjByIdTeacher(string strIdTeacher)
{
CheckPrimaryKey(strIdTeacher);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where IdTeacher = " + "'"+ strIdTeacher+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
 objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号(字段类型:char,字段长度:4,是否可空:False)
 objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:25,是否可空:True)
 objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业(字段类型:varchar,字段长度:40,是否可空:True)
 objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话(字段类型:varchar,字段长度:50,是否可空:True)
 objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页(字段类型:varchar,字段长度:60,是否可空:True)
 objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客(字段类型:varchar,字段长度:60,是否可空:True)
 objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion(字段类型:char,字段长度:4,是否可空:True)
 objTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak(字段类型:bit,字段长度:1,是否可空:True)
 objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College(字段类型:varchar,字段长度:6,是否可空:True)
 objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major(字段类型:char,字段长度:8,是否可空:True)
 objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel(字段类型:varchar,字段长度:50,是否可空:True)
 objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto(字段类型:varchar,字段长度:500,是否可空:True)
 objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto(字段类型:varchar,字段长度:500,是否可空:True)
 objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTeacherInfoDA: GetObjByIdTeacher)", objException.Message));
}
return objTeacherInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTeacherInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTeacherInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN()
{
IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(), //教师姓名
IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(), //性别流水号
IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(), //学校流水号
IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(), //学科流水号
IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(), //校区流水号
IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(), //民族流水号
IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(), //政治面貌流水号
IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(), //行政职务流水号
IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(), //专业职称流水号
IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(), //学历流水号
IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(), //学位流水号
IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(), //职工类型流水号
IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(), //省份流水号
CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(), //身份证号
CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(), //卡号
Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(), //出生日期
GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(), //毕业专业
TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(), //电话
Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(), //电子邮箱
WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(), //个人主页
PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(), //个人博客
EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(), //进校日期
Offed = TransNullToBool(objRow[conTeacherInfo.Offed].ToString().Trim()), //是否离校
IsAvconUser = TransNullToBool(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()), //IsAvconUser
IsGpUser = TransNullToBool(objRow[conTeacherInfo.IsGpUser].ToString().Trim()), //是否Gp用户
IsLocalUser = TransNullToBool(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()), //是否本地用户
FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(), //来自单位
Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(), //备注
IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(), //专业流水号
EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(), //EntryDay
IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(), //id_Photo
IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(), //id_Religion
IsMessage = TransNullToBool(objRow[conTeacherInfo.IsMessage].ToString().Trim()), //IsMessage
Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(), //Microblog
ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(), //修改人
OffedBak = TransNullToBool(objRow[conTeacherInfo.OffedBak].ToString().Trim()), //OffedBak
PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(), //电话
QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(), //QQ
TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(), //Teach_id_College
TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(), //Teach_id_Major
Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(), //Tel
Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(), //Headphoto
ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(), //修改日期
RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(), //RegisterPassword
TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(), //TeacherPhoto
IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim() //身份证号
};
objTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeacherInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTeacherInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTeacherInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = TransNullToBool(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = TransNullToBool(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = TransNullToBool(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = TransNullToBool(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTeacherInfoDA: GetObjByDataRowTeacherInfo)", objException.Message));
}
objTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeacherInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTeacherInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTeacherInfoEN objTeacherInfoEN = new clsTeacherInfoEN();
try
{
objTeacherInfoEN.IdTeacher = objRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objTeacherInfoEN.TeacherId = objRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objTeacherInfoEN.TeacherName = objRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objTeacherInfoEN.IdSex = objRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objTeacherInfoEN.IdSchoolPs = objRow[conTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objTeacherInfoEN.IdDisciplinePs = objRow[conTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objTeacherInfoEN.IdUniZone = objRow[conTeacherInfo.IdUniZone] == DBNull.Value ? null : objRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objTeacherInfoEN.IdEthnic = objRow[conTeacherInfo.IdEthnic] == DBNull.Value ? null : objRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objTeacherInfoEN.IdPolitics = objRow[conTeacherInfo.IdPolitics] == DBNull.Value ? null : objRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objTeacherInfoEN.IdAdminGrade = objRow[conTeacherInfo.IdAdminGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objTeacherInfoEN.IdProfGrade = objRow[conTeacherInfo.IdProfGrade] == DBNull.Value ? null : objRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objTeacherInfoEN.IdQualif = objRow[conTeacherInfo.IdQualif] == DBNull.Value ? null : objRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objTeacherInfoEN.IdDegree = objRow[conTeacherInfo.IdDegree] == DBNull.Value ? null : objRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objTeacherInfoEN.IdStaffType = objRow[conTeacherInfo.IdStaffType] == DBNull.Value ? null : objRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objTeacherInfoEN.IdProvince = objRow[conTeacherInfo.IdProvince] == DBNull.Value ? null : objRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objTeacherInfoEN.CitizenId = objRow[conTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objTeacherInfoEN.CardNo = objRow[conTeacherInfo.CardNo] == DBNull.Value ? null : objRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objTeacherInfoEN.Birthday = objRow[conTeacherInfo.Birthday] == DBNull.Value ? null : objRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objTeacherInfoEN.GraduationMajor = objRow[conTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objTeacherInfoEN.TelNo = objRow[conTeacherInfo.TelNo] == DBNull.Value ? null : objRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objTeacherInfoEN.Email = objRow[conTeacherInfo.Email] == DBNull.Value ? null : objRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objTeacherInfoEN.WebSite = objRow[conTeacherInfo.WebSite] == DBNull.Value ? null : objRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objTeacherInfoEN.PersonBlog = objRow[conTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objTeacherInfoEN.EntryDate = objRow[conTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objTeacherInfoEN.Offed = TransNullToBool(objRow[conTeacherInfo.Offed].ToString().Trim()); //是否离校
objTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[conTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objTeacherInfoEN.IsGpUser = TransNullToBool(objRow[conTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[conTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objTeacherInfoEN.FromUnit = objRow[conTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objTeacherInfoEN.Memo = objRow[conTeacherInfo.Memo] == DBNull.Value ? null : objRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objTeacherInfoEN.IdXzCollege = objRow[conTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objTeacherInfoEN.IdXzMajor = objRow[conTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objTeacherInfoEN.EntryDay = objRow[conTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objTeacherInfoEN.IdPhoto = objRow[conTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objTeacherInfoEN.IdReligion = objRow[conTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objTeacherInfoEN.IsMessage = TransNullToBool(objRow[conTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objTeacherInfoEN.Microblog = objRow[conTeacherInfo.Microblog] == DBNull.Value ? null : objRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objTeacherInfoEN.ModifyUserId = objRow[conTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objTeacherInfoEN.OffedBak = TransNullToBool(objRow[conTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objTeacherInfoEN.PhoneNumber = objRow[conTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objTeacherInfoEN.QQ = objRow[conTeacherInfo.QQ] == DBNull.Value ? null : objRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objTeacherInfoEN.TeachIdCollege = objRow[conTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objTeacherInfoEN.TeachIdMajor = objRow[conTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objTeacherInfoEN.Tel = objRow[conTeacherInfo.Tel] == DBNull.Value ? null : objRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objTeacherInfoEN.Headphoto = objRow[conTeacherInfo.Headphoto] == DBNull.Value ? null : objRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objTeacherInfoEN.ModifyDate = objRow[conTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objTeacherInfoEN.RegisterPassword = objRow[conTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objTeacherInfoEN.TeacherPhoto = objRow[conTeacherInfo.TeacherPhoto] == DBNull.Value ? null : objRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objTeacherInfoEN.IdCardNo = objRow[conTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTeacherInfoDA: GetObjByDataRow)", objException.Message));
}
objTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTeacherInfoEN;
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
objSQL = clsTeacherInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeacherInfoEN._CurrTabName, conTeacherInfo.IdTeacher, 8, "");
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
objSQL = clsTeacherInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTeacherInfoEN._CurrTabName, conTeacherInfo.IdTeacher, 8, strPrefix);
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeacher from TeacherInfo where " + strCondition;
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeacher from TeacherInfo where " + strCondition;
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
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeacher)
{
CheckPrimaryKey(strIdTeacher);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeacherInfo", "IdTeacher = " + "'"+ strIdTeacher+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTeacherInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TeacherInfo", strCondition))
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
objSQL = clsTeacherInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TeacherInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTeacherInfoEN objTeacherInfoEN)
 {
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeacherInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeacherInfo");
objRow = objDS.Tables["TeacherInfo"].NewRow();
objRow[conTeacherInfo.IdTeacher] = objTeacherInfoEN.IdTeacher; //教师流水号
objRow[conTeacherInfo.TeacherId] = objTeacherInfoEN.TeacherId; //教师工号
objRow[conTeacherInfo.TeacherName] = objTeacherInfoEN.TeacherName; //教师姓名
objRow[conTeacherInfo.IdSex] = objTeacherInfoEN.IdSex; //性别流水号
 if (objTeacherInfoEN.IdSchoolPs !=  "")
 {
objRow[conTeacherInfo.IdSchoolPs] = objTeacherInfoEN.IdSchoolPs; //学校流水号
 }
 if (objTeacherInfoEN.IdDisciplinePs !=  "")
 {
objRow[conTeacherInfo.IdDisciplinePs] = objTeacherInfoEN.IdDisciplinePs; //学科流水号
 }
 if (objTeacherInfoEN.IdUniZone !=  "")
 {
objRow[conTeacherInfo.IdUniZone] = objTeacherInfoEN.IdUniZone; //校区流水号
 }
 if (objTeacherInfoEN.IdEthnic !=  "")
 {
objRow[conTeacherInfo.IdEthnic] = objTeacherInfoEN.IdEthnic; //民族流水号
 }
 if (objTeacherInfoEN.IdPolitics !=  "")
 {
objRow[conTeacherInfo.IdPolitics] = objTeacherInfoEN.IdPolitics; //政治面貌流水号
 }
 if (objTeacherInfoEN.IdAdminGrade !=  "")
 {
objRow[conTeacherInfo.IdAdminGrade] = objTeacherInfoEN.IdAdminGrade; //行政职务流水号
 }
 if (objTeacherInfoEN.IdProfGrade !=  "")
 {
objRow[conTeacherInfo.IdProfGrade] = objTeacherInfoEN.IdProfGrade; //专业职称流水号
 }
 if (objTeacherInfoEN.IdQualif !=  "")
 {
objRow[conTeacherInfo.IdQualif] = objTeacherInfoEN.IdQualif; //学历流水号
 }
 if (objTeacherInfoEN.IdDegree !=  "")
 {
objRow[conTeacherInfo.IdDegree] = objTeacherInfoEN.IdDegree; //学位流水号
 }
 if (objTeacherInfoEN.IdStaffType !=  "")
 {
objRow[conTeacherInfo.IdStaffType] = objTeacherInfoEN.IdStaffType; //职工类型流水号
 }
 if (objTeacherInfoEN.IdProvince !=  "")
 {
objRow[conTeacherInfo.IdProvince] = objTeacherInfoEN.IdProvince; //省份流水号
 }
 if (objTeacherInfoEN.CitizenId !=  "")
 {
objRow[conTeacherInfo.CitizenId] = objTeacherInfoEN.CitizenId; //身份证号
 }
 if (objTeacherInfoEN.CardNo !=  "")
 {
objRow[conTeacherInfo.CardNo] = objTeacherInfoEN.CardNo; //卡号
 }
 if (objTeacherInfoEN.Birthday !=  "")
 {
objRow[conTeacherInfo.Birthday] = objTeacherInfoEN.Birthday; //出生日期
 }
 if (objTeacherInfoEN.GraduationMajor !=  "")
 {
objRow[conTeacherInfo.GraduationMajor] = objTeacherInfoEN.GraduationMajor; //毕业专业
 }
 if (objTeacherInfoEN.TelNo !=  "")
 {
objRow[conTeacherInfo.TelNo] = objTeacherInfoEN.TelNo; //电话
 }
 if (objTeacherInfoEN.Email !=  "")
 {
objRow[conTeacherInfo.Email] = objTeacherInfoEN.Email; //电子邮箱
 }
 if (objTeacherInfoEN.WebSite !=  "")
 {
objRow[conTeacherInfo.WebSite] = objTeacherInfoEN.WebSite; //个人主页
 }
 if (objTeacherInfoEN.PersonBlog !=  "")
 {
objRow[conTeacherInfo.PersonBlog] = objTeacherInfoEN.PersonBlog; //个人博客
 }
 if (objTeacherInfoEN.EntryDate !=  "")
 {
objRow[conTeacherInfo.EntryDate] = objTeacherInfoEN.EntryDate; //进校日期
 }
objRow[conTeacherInfo.Offed] = objTeacherInfoEN.Offed; //是否离校
objRow[conTeacherInfo.IsAvconUser] = objTeacherInfoEN.IsAvconUser; //IsAvconUser
objRow[conTeacherInfo.IsGpUser] = objTeacherInfoEN.IsGpUser; //是否Gp用户
objRow[conTeacherInfo.IsLocalUser] = objTeacherInfoEN.IsLocalUser; //是否本地用户
 if (objTeacherInfoEN.FromUnit !=  "")
 {
objRow[conTeacherInfo.FromUnit] = objTeacherInfoEN.FromUnit; //来自单位
 }
 if (objTeacherInfoEN.Memo !=  "")
 {
objRow[conTeacherInfo.Memo] = objTeacherInfoEN.Memo; //备注
 }
 if (objTeacherInfoEN.IdXzCollege !=  "")
 {
objRow[conTeacherInfo.IdXzCollege] = objTeacherInfoEN.IdXzCollege; //学院流水号
 }
 if (objTeacherInfoEN.IdXzMajor !=  "")
 {
objRow[conTeacherInfo.IdXzMajor] = objTeacherInfoEN.IdXzMajor; //专业流水号
 }
 if (objTeacherInfoEN.EntryDay !=  "")
 {
objRow[conTeacherInfo.EntryDay] = objTeacherInfoEN.EntryDay; //EntryDay
 }
 if (objTeacherInfoEN.IdPhoto !=  "")
 {
objRow[conTeacherInfo.IdPhoto] = objTeacherInfoEN.IdPhoto; //id_Photo
 }
 if (objTeacherInfoEN.IdReligion !=  "")
 {
objRow[conTeacherInfo.IdReligion] = objTeacherInfoEN.IdReligion; //id_Religion
 }
objRow[conTeacherInfo.IsMessage] = objTeacherInfoEN.IsMessage; //IsMessage
 if (objTeacherInfoEN.Microblog !=  "")
 {
objRow[conTeacherInfo.Microblog] = objTeacherInfoEN.Microblog; //Microblog
 }
 if (objTeacherInfoEN.ModifyUserId !=  "")
 {
objRow[conTeacherInfo.ModifyUserId] = objTeacherInfoEN.ModifyUserId; //修改人
 }
objRow[conTeacherInfo.OffedBak] = objTeacherInfoEN.OffedBak; //OffedBak
 if (objTeacherInfoEN.PhoneNumber !=  "")
 {
objRow[conTeacherInfo.PhoneNumber] = objTeacherInfoEN.PhoneNumber; //电话
 }
 if (objTeacherInfoEN.QQ !=  "")
 {
objRow[conTeacherInfo.QQ] = objTeacherInfoEN.QQ; //QQ
 }
 if (objTeacherInfoEN.TeachIdCollege !=  "")
 {
objRow[conTeacherInfo.TeachIdCollege] = objTeacherInfoEN.TeachIdCollege; //Teach_id_College
 }
 if (objTeacherInfoEN.TeachIdMajor !=  "")
 {
objRow[conTeacherInfo.TeachIdMajor] = objTeacherInfoEN.TeachIdMajor; //Teach_id_Major
 }
 if (objTeacherInfoEN.Tel !=  "")
 {
objRow[conTeacherInfo.Tel] = objTeacherInfoEN.Tel; //Tel
 }
 if (objTeacherInfoEN.Headphoto !=  "")
 {
objRow[conTeacherInfo.Headphoto] = objTeacherInfoEN.Headphoto; //Headphoto
 }
 if (objTeacherInfoEN.ModifyDate !=  "")
 {
objRow[conTeacherInfo.ModifyDate] = objTeacherInfoEN.ModifyDate; //修改日期
 }
 if (objTeacherInfoEN.RegisterPassword !=  "")
 {
objRow[conTeacherInfo.RegisterPassword] = objTeacherInfoEN.RegisterPassword; //RegisterPassword
 }
 if (objTeacherInfoEN.TeacherPhoto !=  "")
 {
objRow[conTeacherInfo.TeacherPhoto] = objTeacherInfoEN.TeacherPhoto; //TeacherPhoto
 }
 if (objTeacherInfoEN.IdCardNo !=  "")
 {
objRow[conTeacherInfo.IdCardNo] = objTeacherInfoEN.IdCardNo; //身份证号
 }
objDS.Tables[clsTeacherInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTeacherInfoEN._CurrTabName);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeacherInfoEN objTeacherInfoEN)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeacherInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeacherInfoEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdTeacher);
 var strIdTeacher = objTeacherInfoEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherId);
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherName);
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherName + "'");
 }
 
 if (objTeacherInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSex);
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSchoolPs);
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDisciplinePs);
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdUniZone);
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdEthnic);
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPolitics);
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdAdminGrade);
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProfGrade);
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProfGrade + "'");
 }
 
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdQualif);
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDegree);
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDegree + "'");
 }
 
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdStaffType);
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStaffType + "'");
 }
 
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProvince);
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProvince + "'");
 }
 
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CitizenId);
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitizenId + "'");
 }
 
 if (objTeacherInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CardNo);
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 if (objTeacherInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Birthday);
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.GraduationMajor);
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraduationMajor + "'");
 }
 
 if (objTeacherInfoEN.TelNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TelNo);
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTelNo + "'");
 }
 
 if (objTeacherInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Email);
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objTeacherInfoEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.WebSite);
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PersonBlog);
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPersonBlog + "'");
 }
 
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDate);
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.Offed);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.Offed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsAvconUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsAvconUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.FromUnit);
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFromUnit + "'");
 }
 
 if (objTeacherInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Memo);
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzCollege);
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzMajor);
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDay);
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDay + "'");
 }
 
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPhoto);
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdReligion);
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdReligion + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Microblog);
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyUserId);
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.OffedBak);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.OffedBak  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PhoneNumber);
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objTeacherInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.QQ);
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdCollege);
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdCollege + "'");
 }
 
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdMajor);
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdMajor + "'");
 }
 
 if (objTeacherInfoEN.Tel !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Tel);
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTel + "'");
 }
 
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Headphoto);
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyDate);
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.RegisterPassword);
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherPhoto);
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdCardNo);
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeacherInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeacherInfoEN objTeacherInfoEN)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeacherInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeacherInfoEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdTeacher);
 var strIdTeacher = objTeacherInfoEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherId);
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherName);
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherName + "'");
 }
 
 if (objTeacherInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSex);
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSchoolPs);
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDisciplinePs);
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdUniZone);
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdEthnic);
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPolitics);
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdAdminGrade);
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProfGrade);
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProfGrade + "'");
 }
 
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdQualif);
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDegree);
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDegree + "'");
 }
 
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdStaffType);
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStaffType + "'");
 }
 
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProvince);
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProvince + "'");
 }
 
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CitizenId);
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitizenId + "'");
 }
 
 if (objTeacherInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CardNo);
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 if (objTeacherInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Birthday);
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.GraduationMajor);
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraduationMajor + "'");
 }
 
 if (objTeacherInfoEN.TelNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TelNo);
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTelNo + "'");
 }
 
 if (objTeacherInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Email);
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objTeacherInfoEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.WebSite);
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PersonBlog);
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPersonBlog + "'");
 }
 
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDate);
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.Offed);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.Offed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsAvconUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsAvconUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.FromUnit);
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFromUnit + "'");
 }
 
 if (objTeacherInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Memo);
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzCollege);
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzMajor);
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDay);
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDay + "'");
 }
 
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPhoto);
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdReligion);
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdReligion + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Microblog);
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyUserId);
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.OffedBak);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.OffedBak  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PhoneNumber);
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objTeacherInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.QQ);
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdCollege);
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdCollege + "'");
 }
 
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdMajor);
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdMajor + "'");
 }
 
 if (objTeacherInfoEN.Tel !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Tel);
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTel + "'");
 }
 
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Headphoto);
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyDate);
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.RegisterPassword);
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherPhoto);
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdCardNo);
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeacherInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objTeacherInfoEN.IdTeacher;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTeacherInfoEN objTeacherInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeacherInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeacherInfoEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdTeacher);
 var strIdTeacher = objTeacherInfoEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherId);
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherName);
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherName + "'");
 }
 
 if (objTeacherInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSex);
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSchoolPs);
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDisciplinePs);
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdUniZone);
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdEthnic);
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPolitics);
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdAdminGrade);
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProfGrade);
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProfGrade + "'");
 }
 
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdQualif);
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDegree);
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDegree + "'");
 }
 
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdStaffType);
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStaffType + "'");
 }
 
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProvince);
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProvince + "'");
 }
 
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CitizenId);
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitizenId + "'");
 }
 
 if (objTeacherInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CardNo);
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 if (objTeacherInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Birthday);
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.GraduationMajor);
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraduationMajor + "'");
 }
 
 if (objTeacherInfoEN.TelNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TelNo);
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTelNo + "'");
 }
 
 if (objTeacherInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Email);
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objTeacherInfoEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.WebSite);
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PersonBlog);
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPersonBlog + "'");
 }
 
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDate);
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.Offed);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.Offed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsAvconUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsAvconUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.FromUnit);
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFromUnit + "'");
 }
 
 if (objTeacherInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Memo);
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzCollege);
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzMajor);
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDay);
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDay + "'");
 }
 
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPhoto);
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdReligion);
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdReligion + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Microblog);
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyUserId);
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.OffedBak);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.OffedBak  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PhoneNumber);
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objTeacherInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.QQ);
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdCollege);
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdCollege + "'");
 }
 
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdMajor);
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdMajor + "'");
 }
 
 if (objTeacherInfoEN.Tel !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Tel);
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTel + "'");
 }
 
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Headphoto);
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyDate);
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.RegisterPassword);
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherPhoto);
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdCardNo);
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeacherInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objTeacherInfoEN.IdTeacher;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTeacherInfoEN objTeacherInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTeacherInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objTeacherInfoEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdTeacher);
 var strIdTeacher = objTeacherInfoEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherId);
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherId + "'");
 }
 
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherName);
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherName + "'");
 }
 
 if (objTeacherInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSex);
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdSchoolPs);
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchoolPs + "'");
 }
 
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDisciplinePs);
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDisciplinePs + "'");
 }
 
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdUniZone);
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdEthnic);
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPolitics);
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdAdminGrade);
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminGrade + "'");
 }
 
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProfGrade);
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProfGrade + "'");
 }
 
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdQualif);
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdQualif + "'");
 }
 
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdDegree);
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdDegree + "'");
 }
 
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdStaffType);
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStaffType + "'");
 }
 
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdProvince);
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdProvince + "'");
 }
 
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CitizenId);
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitizenId + "'");
 }
 
 if (objTeacherInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.CardNo);
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 if (objTeacherInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Birthday);
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.GraduationMajor);
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGraduationMajor + "'");
 }
 
 if (objTeacherInfoEN.TelNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TelNo);
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTelNo + "'");
 }
 
 if (objTeacherInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Email);
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 if (objTeacherInfoEN.WebSite !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.WebSite);
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSite + "'");
 }
 
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PersonBlog);
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPersonBlog + "'");
 }
 
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDate);
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDate + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.Offed);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.Offed  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsAvconUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsAvconUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTeacherInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.FromUnit);
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFromUnit + "'");
 }
 
 if (objTeacherInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Memo);
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzCollege);
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdXzMajor);
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.EntryDay);
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryDay + "'");
 }
 
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdPhoto);
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdReligion);
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdReligion + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Microblog);
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyUserId);
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 arrFieldListForInsert.Add(conTeacherInfo.OffedBak);
 arrValueListForInsert.Add("'" + (objTeacherInfoEN.OffedBak  ==  false ? "0" : "1") + "'");
 
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.PhoneNumber);
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objTeacherInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.QQ);
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdCollege);
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdCollege + "'");
 }
 
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeachIdMajor);
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachIdMajor + "'");
 }
 
 if (objTeacherInfoEN.Tel !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Tel);
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTel + "'");
 }
 
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.Headphoto);
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.ModifyDate);
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.RegisterPassword);
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.TeacherPhoto);
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherPhoto + "'");
 }
 
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conTeacherInfo.IdCardNo);
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TeacherInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTeacherInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where IdTeacher = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TeacherInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdTeacher = oRow[conTeacherInfo.IdTeacher].ToString().Trim();
if (IsExist(strIdTeacher))
{
 string strResult = "关键字变量值为:" + string.Format("IdTeacher = {0}", strIdTeacher) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTeacherInfoEN._CurrTabName ].NewRow();
objRow[conTeacherInfo.IdTeacher] = oRow[conTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objRow[conTeacherInfo.TeacherId] = oRow[conTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objRow[conTeacherInfo.TeacherName] = oRow[conTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objRow[conTeacherInfo.IdSex] = oRow[conTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objRow[conTeacherInfo.IdSchoolPs] = oRow[conTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objRow[conTeacherInfo.IdDisciplinePs] = oRow[conTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objRow[conTeacherInfo.IdUniZone] = oRow[conTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objRow[conTeacherInfo.IdEthnic] = oRow[conTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objRow[conTeacherInfo.IdPolitics] = oRow[conTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objRow[conTeacherInfo.IdAdminGrade] = oRow[conTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objRow[conTeacherInfo.IdProfGrade] = oRow[conTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objRow[conTeacherInfo.IdQualif] = oRow[conTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objRow[conTeacherInfo.IdDegree] = oRow[conTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objRow[conTeacherInfo.IdStaffType] = oRow[conTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objRow[conTeacherInfo.IdProvince] = oRow[conTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objRow[conTeacherInfo.CitizenId] = oRow[conTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objRow[conTeacherInfo.CardNo] = oRow[conTeacherInfo.CardNo].ToString().Trim(); //卡号
objRow[conTeacherInfo.Birthday] = oRow[conTeacherInfo.Birthday].ToString().Trim(); //出生日期
objRow[conTeacherInfo.GraduationMajor] = oRow[conTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objRow[conTeacherInfo.TelNo] = oRow[conTeacherInfo.TelNo].ToString().Trim(); //电话
objRow[conTeacherInfo.Email] = oRow[conTeacherInfo.Email].ToString().Trim(); //电子邮箱
objRow[conTeacherInfo.WebSite] = oRow[conTeacherInfo.WebSite].ToString().Trim(); //个人主页
objRow[conTeacherInfo.PersonBlog] = oRow[conTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objRow[conTeacherInfo.EntryDate] = oRow[conTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objRow[conTeacherInfo.Offed] = oRow[conTeacherInfo.Offed].ToString().Trim(); //是否离校
objRow[conTeacherInfo.IsAvconUser] = oRow[conTeacherInfo.IsAvconUser].ToString().Trim(); //IsAvconUser
objRow[conTeacherInfo.IsGpUser] = oRow[conTeacherInfo.IsGpUser].ToString().Trim(); //是否Gp用户
objRow[conTeacherInfo.IsLocalUser] = oRow[conTeacherInfo.IsLocalUser].ToString().Trim(); //是否本地用户
objRow[conTeacherInfo.FromUnit] = oRow[conTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objRow[conTeacherInfo.Memo] = oRow[conTeacherInfo.Memo].ToString().Trim(); //备注
objRow[conTeacherInfo.IdXzCollege] = oRow[conTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conTeacherInfo.IdXzMajor] = oRow[conTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conTeacherInfo.EntryDay] = oRow[conTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objRow[conTeacherInfo.IdPhoto] = oRow[conTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objRow[conTeacherInfo.IdReligion] = oRow[conTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objRow[conTeacherInfo.IsMessage] = oRow[conTeacherInfo.IsMessage].ToString().Trim(); //IsMessage
objRow[conTeacherInfo.Microblog] = oRow[conTeacherInfo.Microblog].ToString().Trim(); //Microblog
objRow[conTeacherInfo.ModifyUserId] = oRow[conTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objRow[conTeacherInfo.OffedBak] = oRow[conTeacherInfo.OffedBak].ToString().Trim(); //OffedBak
objRow[conTeacherInfo.PhoneNumber] = oRow[conTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objRow[conTeacherInfo.QQ] = oRow[conTeacherInfo.QQ].ToString().Trim(); //QQ
objRow[conTeacherInfo.TeachIdCollege] = oRow[conTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objRow[conTeacherInfo.TeachIdMajor] = oRow[conTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objRow[conTeacherInfo.Tel] = oRow[conTeacherInfo.Tel].ToString().Trim(); //Tel
objRow[conTeacherInfo.Headphoto] = oRow[conTeacherInfo.Headphoto].ToString().Trim(); //Headphoto
objRow[conTeacherInfo.ModifyDate] = oRow[conTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objRow[conTeacherInfo.RegisterPassword] = oRow[conTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objRow[conTeacherInfo.TeacherPhoto] = oRow[conTeacherInfo.TeacherPhoto].ToString().Trim(); //TeacherPhoto
objRow[conTeacherInfo.IdCardNo] = oRow[conTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
 objDS.Tables[clsTeacherInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTeacherInfoEN._CurrTabName);
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
 /// <param name = "objTeacherInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTeacherInfoEN objTeacherInfoEN)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeacherInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from TeacherInfo where IdTeacher = " + "'"+ objTeacherInfoEN.IdTeacher+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTeacherInfoEN._CurrTabName);
if (objDS.Tables[clsTeacherInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdTeacher = " + "'"+ objTeacherInfoEN.IdTeacher+"'");
return false;
}
objRow = objDS.Tables[clsTeacherInfoEN._CurrTabName].Rows[0];
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdTeacher))
 {
objRow[conTeacherInfo.IdTeacher] = objTeacherInfoEN.IdTeacher; //教师流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherId))
 {
objRow[conTeacherInfo.TeacherId] = objTeacherInfoEN.TeacherId; //教师工号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherName))
 {
objRow[conTeacherInfo.TeacherName] = objTeacherInfoEN.TeacherName; //教师姓名
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSex))
 {
objRow[conTeacherInfo.IdSex] = objTeacherInfoEN.IdSex; //性别流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSchoolPs))
 {
objRow[conTeacherInfo.IdSchoolPs] = objTeacherInfoEN.IdSchoolPs; //学校流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDisciplinePs))
 {
objRow[conTeacherInfo.IdDisciplinePs] = objTeacherInfoEN.IdDisciplinePs; //学科流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdUniZone))
 {
objRow[conTeacherInfo.IdUniZone] = objTeacherInfoEN.IdUniZone; //校区流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdEthnic))
 {
objRow[conTeacherInfo.IdEthnic] = objTeacherInfoEN.IdEthnic; //民族流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPolitics))
 {
objRow[conTeacherInfo.IdPolitics] = objTeacherInfoEN.IdPolitics; //政治面貌流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdAdminGrade))
 {
objRow[conTeacherInfo.IdAdminGrade] = objTeacherInfoEN.IdAdminGrade; //行政职务流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProfGrade))
 {
objRow[conTeacherInfo.IdProfGrade] = objTeacherInfoEN.IdProfGrade; //专业职称流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdQualif))
 {
objRow[conTeacherInfo.IdQualif] = objTeacherInfoEN.IdQualif; //学历流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDegree))
 {
objRow[conTeacherInfo.IdDegree] = objTeacherInfoEN.IdDegree; //学位流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdStaffType))
 {
objRow[conTeacherInfo.IdStaffType] = objTeacherInfoEN.IdStaffType; //职工类型流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProvince))
 {
objRow[conTeacherInfo.IdProvince] = objTeacherInfoEN.IdProvince; //省份流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CitizenId))
 {
objRow[conTeacherInfo.CitizenId] = objTeacherInfoEN.CitizenId; //身份证号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CardNo))
 {
objRow[conTeacherInfo.CardNo] = objTeacherInfoEN.CardNo; //卡号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Birthday))
 {
objRow[conTeacherInfo.Birthday] = objTeacherInfoEN.Birthday; //出生日期
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.GraduationMajor))
 {
objRow[conTeacherInfo.GraduationMajor] = objTeacherInfoEN.GraduationMajor; //毕业专业
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TelNo))
 {
objRow[conTeacherInfo.TelNo] = objTeacherInfoEN.TelNo; //电话
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Email))
 {
objRow[conTeacherInfo.Email] = objTeacherInfoEN.Email; //电子邮箱
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.WebSite))
 {
objRow[conTeacherInfo.WebSite] = objTeacherInfoEN.WebSite; //个人主页
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PersonBlog))
 {
objRow[conTeacherInfo.PersonBlog] = objTeacherInfoEN.PersonBlog; //个人博客
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDate))
 {
objRow[conTeacherInfo.EntryDate] = objTeacherInfoEN.EntryDate; //进校日期
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Offed))
 {
objRow[conTeacherInfo.Offed] = objTeacherInfoEN.Offed; //是否离校
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsAvconUser))
 {
objRow[conTeacherInfo.IsAvconUser] = objTeacherInfoEN.IsAvconUser; //IsAvconUser
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsGpUser))
 {
objRow[conTeacherInfo.IsGpUser] = objTeacherInfoEN.IsGpUser; //是否Gp用户
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsLocalUser))
 {
objRow[conTeacherInfo.IsLocalUser] = objTeacherInfoEN.IsLocalUser; //是否本地用户
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.FromUnit))
 {
objRow[conTeacherInfo.FromUnit] = objTeacherInfoEN.FromUnit; //来自单位
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Memo))
 {
objRow[conTeacherInfo.Memo] = objTeacherInfoEN.Memo; //备注
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzCollege))
 {
objRow[conTeacherInfo.IdXzCollege] = objTeacherInfoEN.IdXzCollege; //学院流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzMajor))
 {
objRow[conTeacherInfo.IdXzMajor] = objTeacherInfoEN.IdXzMajor; //专业流水号
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDay))
 {
objRow[conTeacherInfo.EntryDay] = objTeacherInfoEN.EntryDay; //EntryDay
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPhoto))
 {
objRow[conTeacherInfo.IdPhoto] = objTeacherInfoEN.IdPhoto; //id_Photo
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdReligion))
 {
objRow[conTeacherInfo.IdReligion] = objTeacherInfoEN.IdReligion; //id_Religion
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsMessage))
 {
objRow[conTeacherInfo.IsMessage] = objTeacherInfoEN.IsMessage; //IsMessage
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Microblog))
 {
objRow[conTeacherInfo.Microblog] = objTeacherInfoEN.Microblog; //Microblog
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyUserId))
 {
objRow[conTeacherInfo.ModifyUserId] = objTeacherInfoEN.ModifyUserId; //修改人
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.OffedBak))
 {
objRow[conTeacherInfo.OffedBak] = objTeacherInfoEN.OffedBak; //OffedBak
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PhoneNumber))
 {
objRow[conTeacherInfo.PhoneNumber] = objTeacherInfoEN.PhoneNumber; //电话
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.QQ))
 {
objRow[conTeacherInfo.QQ] = objTeacherInfoEN.QQ; //QQ
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdCollege))
 {
objRow[conTeacherInfo.TeachIdCollege] = objTeacherInfoEN.TeachIdCollege; //Teach_id_College
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdMajor))
 {
objRow[conTeacherInfo.TeachIdMajor] = objTeacherInfoEN.TeachIdMajor; //Teach_id_Major
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Tel))
 {
objRow[conTeacherInfo.Tel] = objTeacherInfoEN.Tel; //Tel
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Headphoto))
 {
objRow[conTeacherInfo.Headphoto] = objTeacherInfoEN.Headphoto; //Headphoto
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyDate))
 {
objRow[conTeacherInfo.ModifyDate] = objTeacherInfoEN.ModifyDate; //修改日期
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.RegisterPassword))
 {
objRow[conTeacherInfo.RegisterPassword] = objTeacherInfoEN.RegisterPassword; //RegisterPassword
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherPhoto))
 {
objRow[conTeacherInfo.TeacherPhoto] = objTeacherInfoEN.TeacherPhoto; //TeacherPhoto
 }
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdCardNo))
 {
objRow[conTeacherInfo.IdCardNo] = objTeacherInfoEN.IdCardNo; //身份证号
 }
try
{
objDA.Update(objDS, clsTeacherInfoEN._CurrTabName);
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeacherInfoEN objTeacherInfoEN)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeacherInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TeacherInfo Set ");
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherId))
 {
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherId, conTeacherInfo.TeacherId); //教师工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherId); //教师工号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherName))
 {
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherName, conTeacherInfo.TeacherName); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherName); //教师姓名
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSex))
 {
 if (objTeacherInfoEN.IdSex !=  null)
 {
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSex, conTeacherInfo.IdSex); //性别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdSex); //性别流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSchoolPs))
 {
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchoolPs, conTeacherInfo.IdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdSchoolPs); //学校流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDisciplinePs))
 {
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDisciplinePs, conTeacherInfo.IdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdDisciplinePs); //学科流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdUniZone))
 {
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conTeacherInfo.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdUniZone); //校区流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdEthnic))
 {
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEthnic, conTeacherInfo.IdEthnic); //民族流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdEthnic); //民族流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPolitics))
 {
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPolitics, conTeacherInfo.IdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdPolitics); //政治面貌流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdAdminGrade))
 {
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminGrade, conTeacherInfo.IdAdminGrade); //行政职务流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdAdminGrade); //行政职务流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProfGrade))
 {
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdProfGrade, conTeacherInfo.IdProfGrade); //专业职称流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdProfGrade); //专业职称流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdQualif))
 {
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdQualif, conTeacherInfo.IdQualif); //学历流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdQualif); //学历流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDegree))
 {
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDegree, conTeacherInfo.IdDegree); //学位流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdDegree); //学位流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdStaffType))
 {
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStaffType, conTeacherInfo.IdStaffType); //职工类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdStaffType); //职工类型流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProvince))
 {
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdProvince, conTeacherInfo.IdProvince); //省份流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdProvince); //省份流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CitizenId))
 {
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitizenId, conTeacherInfo.CitizenId); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.CitizenId); //身份证号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CardNo))
 {
 if (objTeacherInfoEN.CardNo !=  null)
 {
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCardNo, conTeacherInfo.CardNo); //卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.CardNo); //卡号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Birthday))
 {
 if (objTeacherInfoEN.Birthday !=  null)
 {
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBirthday, conTeacherInfo.Birthday); //出生日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Birthday); //出生日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.GraduationMajor))
 {
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraduationMajor, conTeacherInfo.GraduationMajor); //毕业专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.GraduationMajor); //毕业专业
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TelNo))
 {
 if (objTeacherInfoEN.TelNo !=  null)
 {
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTelNo, conTeacherInfo.TelNo); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TelNo); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Email))
 {
 if (objTeacherInfoEN.Email !=  null)
 {
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conTeacherInfo.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Email); //电子邮箱
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.WebSite))
 {
 if (objTeacherInfoEN.WebSite !=  null)
 {
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSite, conTeacherInfo.WebSite); //个人主页
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.WebSite); //个人主页
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PersonBlog))
 {
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPersonBlog, conTeacherInfo.PersonBlog); //个人博客
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.PersonBlog); //个人博客
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDate))
 {
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryDate, conTeacherInfo.EntryDate); //进校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.EntryDate); //进校日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Offed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.Offed == true?"1":"0", conTeacherInfo.Offed); //是否离校
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsAvconUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsAvconUser == true?"1":"0", conTeacherInfo.IsAvconUser); //IsAvconUser
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsGpUser == true?"1":"0", conTeacherInfo.IsGpUser); //是否Gp用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsLocalUser == true?"1":"0", conTeacherInfo.IsLocalUser); //是否本地用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.FromUnit))
 {
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFromUnit, conTeacherInfo.FromUnit); //来自单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.FromUnit); //来自单位
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Memo))
 {
 if (objTeacherInfoEN.Memo !=  null)
 {
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeacherInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Memo); //备注
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzCollege))
 {
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeacherInfo.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzMajor))
 {
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conTeacherInfo.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdXzMajor); //专业流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDay))
 {
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryDay, conTeacherInfo.EntryDay); //EntryDay
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.EntryDay); //EntryDay
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPhoto))
 {
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPhoto, conTeacherInfo.IdPhoto); //id_Photo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdPhoto); //id_Photo
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdReligion))
 {
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdReligion, conTeacherInfo.IdReligion); //id_Religion
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdReligion); //id_Religion
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsMessage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsMessage == true?"1":"0", conTeacherInfo.IsMessage); //IsMessage
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Microblog))
 {
 if (objTeacherInfoEN.Microblog !=  null)
 {
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroblog, conTeacherInfo.Microblog); //Microblog
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Microblog); //Microblog
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyUserId))
 {
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conTeacherInfo.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.ModifyUserId); //修改人
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.OffedBak))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.OffedBak == true?"1":"0", conTeacherInfo.OffedBak); //OffedBak
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PhoneNumber))
 {
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conTeacherInfo.PhoneNumber); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.PhoneNumber); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.QQ))
 {
 if (objTeacherInfoEN.QQ !=  null)
 {
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQQ, conTeacherInfo.QQ); //QQ
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.QQ); //QQ
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdCollege))
 {
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachIdCollege, conTeacherInfo.TeachIdCollege); //Teach_id_College
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeachIdCollege); //Teach_id_College
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdMajor))
 {
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachIdMajor, conTeacherInfo.TeachIdMajor); //Teach_id_Major
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeachIdMajor); //Teach_id_Major
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Tel))
 {
 if (objTeacherInfoEN.Tel !=  null)
 {
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTel, conTeacherInfo.Tel); //Tel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Tel); //Tel
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Headphoto))
 {
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeadphoto, conTeacherInfo.Headphoto); //Headphoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Headphoto); //Headphoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyDate))
 {
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conTeacherInfo.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.ModifyDate); //修改日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.RegisterPassword))
 {
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conTeacherInfo.RegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.RegisterPassword); //RegisterPassword
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherPhoto))
 {
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherPhoto, conTeacherInfo.TeacherPhoto); //TeacherPhoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherPhoto); //TeacherPhoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdCardNo))
 {
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo, conTeacherInfo.IdCardNo); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdCardNo); //身份证号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeacher = '{0}'", objTeacherInfoEN.IdTeacher); 
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTeacherInfoEN objTeacherInfoEN, string strCondition)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeacherInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeacherInfo Set ");
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherId))
 {
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherId = '{0}',", strTeacherId); //教师工号
 }
 else
 {
 sbSQL.Append(" TeacherId = null,"); //教师工号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherName))
 {
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherName = '{0}',", strTeacherName); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherName = null,"); //教师姓名
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSex))
 {
 if (objTeacherInfoEN.IdSex !=  null)
 {
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSex = '{0}',", strIdSex); //性别流水号
 }
 else
 {
 sbSQL.Append(" IdSex = null,"); //性别流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSchoolPs))
 {
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchoolPs = '{0}',", strIdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchoolPs = null,"); //学校流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDisciplinePs))
 {
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDisciplinePs = '{0}',", strIdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDisciplinePs = null,"); //学科流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdUniZone))
 {
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdEthnic))
 {
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEthnic = '{0}',", strIdEthnic); //民族流水号
 }
 else
 {
 sbSQL.Append(" IdEthnic = null,"); //民族流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPolitics))
 {
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPolitics = '{0}',", strIdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.Append(" IdPolitics = null,"); //政治面貌流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdAdminGrade))
 {
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminGrade = '{0}',", strIdAdminGrade); //行政职务流水号
 }
 else
 {
 sbSQL.Append(" IdAdminGrade = null,"); //行政职务流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProfGrade))
 {
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdProfGrade = '{0}',", strIdProfGrade); //专业职称流水号
 }
 else
 {
 sbSQL.Append(" IdProfGrade = null,"); //专业职称流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdQualif))
 {
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdQualif = '{0}',", strIdQualif); //学历流水号
 }
 else
 {
 sbSQL.Append(" IdQualif = null,"); //学历流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDegree))
 {
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDegree = '{0}',", strIdDegree); //学位流水号
 }
 else
 {
 sbSQL.Append(" IdDegree = null,"); //学位流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdStaffType))
 {
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStaffType = '{0}',", strIdStaffType); //职工类型流水号
 }
 else
 {
 sbSQL.Append(" IdStaffType = null,"); //职工类型流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProvince))
 {
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdProvince = '{0}',", strIdProvince); //省份流水号
 }
 else
 {
 sbSQL.Append(" IdProvince = null,"); //省份流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CitizenId))
 {
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitizenId = '{0}',", strCitizenId); //身份证号
 }
 else
 {
 sbSQL.Append(" CitizenId = null,"); //身份证号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CardNo))
 {
 if (objTeacherInfoEN.CardNo !=  null)
 {
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CardNo = '{0}',", strCardNo); //卡号
 }
 else
 {
 sbSQL.Append(" CardNo = null,"); //卡号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Birthday))
 {
 if (objTeacherInfoEN.Birthday !=  null)
 {
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Birthday = '{0}',", strBirthday); //出生日期
 }
 else
 {
 sbSQL.Append(" Birthday = null,"); //出生日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.GraduationMajor))
 {
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraduationMajor = '{0}',", strGraduationMajor); //毕业专业
 }
 else
 {
 sbSQL.Append(" GraduationMajor = null,"); //毕业专业
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TelNo))
 {
 if (objTeacherInfoEN.TelNo !=  null)
 {
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TelNo = '{0}',", strTelNo); //电话
 }
 else
 {
 sbSQL.Append(" TelNo = null,"); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Email))
 {
 if (objTeacherInfoEN.Email !=  null)
 {
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.WebSite))
 {
 if (objTeacherInfoEN.WebSite !=  null)
 {
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSite = '{0}',", strWebSite); //个人主页
 }
 else
 {
 sbSQL.Append(" WebSite = null,"); //个人主页
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PersonBlog))
 {
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PersonBlog = '{0}',", strPersonBlog); //个人博客
 }
 else
 {
 sbSQL.Append(" PersonBlog = null,"); //个人博客
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDate))
 {
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryDate = '{0}',", strEntryDate); //进校日期
 }
 else
 {
 sbSQL.Append(" EntryDate = null,"); //进校日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Offed))
 {
 sbSQL.AppendFormat(" Offed = '{0}',", objTeacherInfoEN.Offed == true?"1":"0"); //是否离校
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsAvconUser))
 {
 sbSQL.AppendFormat(" IsAvconUser = '{0}',", objTeacherInfoEN.IsAvconUser == true?"1":"0"); //IsAvconUser
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objTeacherInfoEN.IsGpUser == true?"1":"0"); //是否Gp用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" IsLocalUser = '{0}',", objTeacherInfoEN.IsLocalUser == true?"1":"0"); //是否本地用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.FromUnit))
 {
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FromUnit = '{0}',", strFromUnit); //来自单位
 }
 else
 {
 sbSQL.Append(" FromUnit = null,"); //来自单位
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Memo))
 {
 if (objTeacherInfoEN.Memo !=  null)
 {
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzCollege))
 {
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzMajor))
 {
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDay))
 {
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryDay = '{0}',", strEntryDay); //EntryDay
 }
 else
 {
 sbSQL.Append(" EntryDay = null,"); //EntryDay
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPhoto))
 {
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPhoto = '{0}',", strIdPhoto); //id_Photo
 }
 else
 {
 sbSQL.Append(" IdPhoto = null,"); //id_Photo
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdReligion))
 {
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdReligion = '{0}',", strIdReligion); //id_Religion
 }
 else
 {
 sbSQL.Append(" IdReligion = null,"); //id_Religion
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsMessage))
 {
 sbSQL.AppendFormat(" IsMessage = '{0}',", objTeacherInfoEN.IsMessage == true?"1":"0"); //IsMessage
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Microblog))
 {
 if (objTeacherInfoEN.Microblog !=  null)
 {
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Microblog = '{0}',", strMicroblog); //Microblog
 }
 else
 {
 sbSQL.Append(" Microblog = null,"); //Microblog
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyUserId))
 {
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.OffedBak))
 {
 sbSQL.AppendFormat(" OffedBak = '{0}',", objTeacherInfoEN.OffedBak == true?"1":"0"); //OffedBak
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PhoneNumber))
 {
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.QQ))
 {
 if (objTeacherInfoEN.QQ !=  null)
 {
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QQ = '{0}',", strQQ); //QQ
 }
 else
 {
 sbSQL.Append(" QQ = null,"); //QQ
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdCollege))
 {
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachIdCollege = '{0}',", strTeachIdCollege); //Teach_id_College
 }
 else
 {
 sbSQL.Append(" TeachIdCollege = null,"); //Teach_id_College
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdMajor))
 {
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachIdMajor = '{0}',", strTeachIdMajor); //Teach_id_Major
 }
 else
 {
 sbSQL.Append(" TeachIdMajor = null,"); //Teach_id_Major
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Tel))
 {
 if (objTeacherInfoEN.Tel !=  null)
 {
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Tel = '{0}',", strTel); //Tel
 }
 else
 {
 sbSQL.Append(" Tel = null,"); //Tel
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Headphoto))
 {
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Headphoto = '{0}',", strHeadphoto); //Headphoto
 }
 else
 {
 sbSQL.Append(" Headphoto = null,"); //Headphoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyDate))
 {
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.RegisterPassword))
 {
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //RegisterPassword
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherPhoto))
 {
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherPhoto = '{0}',", strTeacherPhoto); //TeacherPhoto
 }
 else
 {
 sbSQL.Append(" TeacherPhoto = null,"); //TeacherPhoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdCardNo))
 {
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo = '{0}',", strIdCardNo); //身份证号
 }
 else
 {
 sbSQL.Append(" IdCardNo = null,"); //身份证号
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
 /// <param name = "objTeacherInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTeacherInfoEN objTeacherInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeacherInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeacherInfo Set ");
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherId))
 {
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherId = '{0}',", strTeacherId); //教师工号
 }
 else
 {
 sbSQL.Append(" TeacherId = null,"); //教师工号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherName))
 {
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherName = '{0}',", strTeacherName); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherName = null,"); //教师姓名
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSex))
 {
 if (objTeacherInfoEN.IdSex !=  null)
 {
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSex = '{0}',", strIdSex); //性别流水号
 }
 else
 {
 sbSQL.Append(" IdSex = null,"); //性别流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSchoolPs))
 {
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchoolPs = '{0}',", strIdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchoolPs = null,"); //学校流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDisciplinePs))
 {
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDisciplinePs = '{0}',", strIdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.Append(" IdDisciplinePs = null,"); //学科流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdUniZone))
 {
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdEthnic))
 {
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEthnic = '{0}',", strIdEthnic); //民族流水号
 }
 else
 {
 sbSQL.Append(" IdEthnic = null,"); //民族流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPolitics))
 {
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPolitics = '{0}',", strIdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.Append(" IdPolitics = null,"); //政治面貌流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdAdminGrade))
 {
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminGrade = '{0}',", strIdAdminGrade); //行政职务流水号
 }
 else
 {
 sbSQL.Append(" IdAdminGrade = null,"); //行政职务流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProfGrade))
 {
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdProfGrade = '{0}',", strIdProfGrade); //专业职称流水号
 }
 else
 {
 sbSQL.Append(" IdProfGrade = null,"); //专业职称流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdQualif))
 {
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdQualif = '{0}',", strIdQualif); //学历流水号
 }
 else
 {
 sbSQL.Append(" IdQualif = null,"); //学历流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDegree))
 {
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdDegree = '{0}',", strIdDegree); //学位流水号
 }
 else
 {
 sbSQL.Append(" IdDegree = null,"); //学位流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdStaffType))
 {
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStaffType = '{0}',", strIdStaffType); //职工类型流水号
 }
 else
 {
 sbSQL.Append(" IdStaffType = null,"); //职工类型流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProvince))
 {
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdProvince = '{0}',", strIdProvince); //省份流水号
 }
 else
 {
 sbSQL.Append(" IdProvince = null,"); //省份流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CitizenId))
 {
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitizenId = '{0}',", strCitizenId); //身份证号
 }
 else
 {
 sbSQL.Append(" CitizenId = null,"); //身份证号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CardNo))
 {
 if (objTeacherInfoEN.CardNo !=  null)
 {
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CardNo = '{0}',", strCardNo); //卡号
 }
 else
 {
 sbSQL.Append(" CardNo = null,"); //卡号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Birthday))
 {
 if (objTeacherInfoEN.Birthday !=  null)
 {
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Birthday = '{0}',", strBirthday); //出生日期
 }
 else
 {
 sbSQL.Append(" Birthday = null,"); //出生日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.GraduationMajor))
 {
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GraduationMajor = '{0}',", strGraduationMajor); //毕业专业
 }
 else
 {
 sbSQL.Append(" GraduationMajor = null,"); //毕业专业
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TelNo))
 {
 if (objTeacherInfoEN.TelNo !=  null)
 {
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TelNo = '{0}',", strTelNo); //电话
 }
 else
 {
 sbSQL.Append(" TelNo = null,"); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Email))
 {
 if (objTeacherInfoEN.Email !=  null)
 {
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.WebSite))
 {
 if (objTeacherInfoEN.WebSite !=  null)
 {
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSite = '{0}',", strWebSite); //个人主页
 }
 else
 {
 sbSQL.Append(" WebSite = null,"); //个人主页
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PersonBlog))
 {
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PersonBlog = '{0}',", strPersonBlog); //个人博客
 }
 else
 {
 sbSQL.Append(" PersonBlog = null,"); //个人博客
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDate))
 {
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryDate = '{0}',", strEntryDate); //进校日期
 }
 else
 {
 sbSQL.Append(" EntryDate = null,"); //进校日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Offed))
 {
 sbSQL.AppendFormat(" Offed = '{0}',", objTeacherInfoEN.Offed == true?"1":"0"); //是否离校
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsAvconUser))
 {
 sbSQL.AppendFormat(" IsAvconUser = '{0}',", objTeacherInfoEN.IsAvconUser == true?"1":"0"); //IsAvconUser
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objTeacherInfoEN.IsGpUser == true?"1":"0"); //是否Gp用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" IsLocalUser = '{0}',", objTeacherInfoEN.IsLocalUser == true?"1":"0"); //是否本地用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.FromUnit))
 {
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FromUnit = '{0}',", strFromUnit); //来自单位
 }
 else
 {
 sbSQL.Append(" FromUnit = null,"); //来自单位
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Memo))
 {
 if (objTeacherInfoEN.Memo !=  null)
 {
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzCollege))
 {
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzMajor))
 {
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDay))
 {
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryDay = '{0}',", strEntryDay); //EntryDay
 }
 else
 {
 sbSQL.Append(" EntryDay = null,"); //EntryDay
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPhoto))
 {
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPhoto = '{0}',", strIdPhoto); //id_Photo
 }
 else
 {
 sbSQL.Append(" IdPhoto = null,"); //id_Photo
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdReligion))
 {
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdReligion = '{0}',", strIdReligion); //id_Religion
 }
 else
 {
 sbSQL.Append(" IdReligion = null,"); //id_Religion
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsMessage))
 {
 sbSQL.AppendFormat(" IsMessage = '{0}',", objTeacherInfoEN.IsMessage == true?"1":"0"); //IsMessage
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Microblog))
 {
 if (objTeacherInfoEN.Microblog !=  null)
 {
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Microblog = '{0}',", strMicroblog); //Microblog
 }
 else
 {
 sbSQL.Append(" Microblog = null,"); //Microblog
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyUserId))
 {
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.OffedBak))
 {
 sbSQL.AppendFormat(" OffedBak = '{0}',", objTeacherInfoEN.OffedBak == true?"1":"0"); //OffedBak
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PhoneNumber))
 {
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.QQ))
 {
 if (objTeacherInfoEN.QQ !=  null)
 {
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QQ = '{0}',", strQQ); //QQ
 }
 else
 {
 sbSQL.Append(" QQ = null,"); //QQ
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdCollege))
 {
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachIdCollege = '{0}',", strTeachIdCollege); //Teach_id_College
 }
 else
 {
 sbSQL.Append(" TeachIdCollege = null,"); //Teach_id_College
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdMajor))
 {
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachIdMajor = '{0}',", strTeachIdMajor); //Teach_id_Major
 }
 else
 {
 sbSQL.Append(" TeachIdMajor = null,"); //Teach_id_Major
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Tel))
 {
 if (objTeacherInfoEN.Tel !=  null)
 {
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Tel = '{0}',", strTel); //Tel
 }
 else
 {
 sbSQL.Append(" Tel = null,"); //Tel
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Headphoto))
 {
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Headphoto = '{0}',", strHeadphoto); //Headphoto
 }
 else
 {
 sbSQL.Append(" Headphoto = null,"); //Headphoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyDate))
 {
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.RegisterPassword))
 {
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //RegisterPassword
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherPhoto))
 {
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherPhoto = '{0}',", strTeacherPhoto); //TeacherPhoto
 }
 else
 {
 sbSQL.Append(" TeacherPhoto = null,"); //TeacherPhoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdCardNo))
 {
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo = '{0}',", strIdCardNo); //身份证号
 }
 else
 {
 sbSQL.Append(" IdCardNo = null,"); //身份证号
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
 /// <param name = "objTeacherInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTeacherInfoEN objTeacherInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTeacherInfoEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTeacherInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTeacherInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TeacherInfo Set ");
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherId))
 {
 if (objTeacherInfoEN.TeacherId !=  null)
 {
 var strTeacherId = objTeacherInfoEN.TeacherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherId, conTeacherInfo.TeacherId); //教师工号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherId); //教师工号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherName))
 {
 if (objTeacherInfoEN.TeacherName !=  null)
 {
 var strTeacherName = objTeacherInfoEN.TeacherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherName, conTeacherInfo.TeacherName); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherName); //教师姓名
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSex))
 {
 if (objTeacherInfoEN.IdSex !=  null)
 {
 var strIdSex = objTeacherInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSex, conTeacherInfo.IdSex); //性别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdSex); //性别流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdSchoolPs))
 {
 if (objTeacherInfoEN.IdSchoolPs !=  null)
 {
 var strIdSchoolPs = objTeacherInfoEN.IdSchoolPs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchoolPs, conTeacherInfo.IdSchoolPs); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdSchoolPs); //学校流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDisciplinePs))
 {
 if (objTeacherInfoEN.IdDisciplinePs !=  null)
 {
 var strIdDisciplinePs = objTeacherInfoEN.IdDisciplinePs.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDisciplinePs, conTeacherInfo.IdDisciplinePs); //学科流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdDisciplinePs); //学科流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdUniZone))
 {
 if (objTeacherInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objTeacherInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conTeacherInfo.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdUniZone); //校区流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdEthnic))
 {
 if (objTeacherInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objTeacherInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEthnic, conTeacherInfo.IdEthnic); //民族流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdEthnic); //民族流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPolitics))
 {
 if (objTeacherInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objTeacherInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPolitics, conTeacherInfo.IdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdPolitics); //政治面貌流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdAdminGrade))
 {
 if (objTeacherInfoEN.IdAdminGrade !=  null)
 {
 var strIdAdminGrade = objTeacherInfoEN.IdAdminGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminGrade, conTeacherInfo.IdAdminGrade); //行政职务流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdAdminGrade); //行政职务流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProfGrade))
 {
 if (objTeacherInfoEN.IdProfGrade !=  null)
 {
 var strIdProfGrade = objTeacherInfoEN.IdProfGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdProfGrade, conTeacherInfo.IdProfGrade); //专业职称流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdProfGrade); //专业职称流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdQualif))
 {
 if (objTeacherInfoEN.IdQualif !=  null)
 {
 var strIdQualif = objTeacherInfoEN.IdQualif.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdQualif, conTeacherInfo.IdQualif); //学历流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdQualif); //学历流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdDegree))
 {
 if (objTeacherInfoEN.IdDegree !=  null)
 {
 var strIdDegree = objTeacherInfoEN.IdDegree.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdDegree, conTeacherInfo.IdDegree); //学位流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdDegree); //学位流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdStaffType))
 {
 if (objTeacherInfoEN.IdStaffType  ==  "")
 {
 objTeacherInfoEN.IdStaffType = null;
 }
 if (objTeacherInfoEN.IdStaffType !=  null)
 {
 var strIdStaffType = objTeacherInfoEN.IdStaffType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStaffType, conTeacherInfo.IdStaffType); //职工类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdStaffType); //职工类型流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdProvince))
 {
 if (objTeacherInfoEN.IdProvince !=  null)
 {
 var strIdProvince = objTeacherInfoEN.IdProvince.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdProvince, conTeacherInfo.IdProvince); //省份流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdProvince); //省份流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CitizenId))
 {
 if (objTeacherInfoEN.CitizenId !=  null)
 {
 var strCitizenId = objTeacherInfoEN.CitizenId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitizenId, conTeacherInfo.CitizenId); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.CitizenId); //身份证号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.CardNo))
 {
 if (objTeacherInfoEN.CardNo !=  null)
 {
 var strCardNo = objTeacherInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCardNo, conTeacherInfo.CardNo); //卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.CardNo); //卡号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Birthday))
 {
 if (objTeacherInfoEN.Birthday !=  null)
 {
 var strBirthday = objTeacherInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBirthday, conTeacherInfo.Birthday); //出生日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Birthday); //出生日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.GraduationMajor))
 {
 if (objTeacherInfoEN.GraduationMajor !=  null)
 {
 var strGraduationMajor = objTeacherInfoEN.GraduationMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGraduationMajor, conTeacherInfo.GraduationMajor); //毕业专业
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.GraduationMajor); //毕业专业
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TelNo))
 {
 if (objTeacherInfoEN.TelNo !=  null)
 {
 var strTelNo = objTeacherInfoEN.TelNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTelNo, conTeacherInfo.TelNo); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TelNo); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Email))
 {
 if (objTeacherInfoEN.Email !=  null)
 {
 var strEmail = objTeacherInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conTeacherInfo.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Email); //电子邮箱
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.WebSite))
 {
 if (objTeacherInfoEN.WebSite !=  null)
 {
 var strWebSite = objTeacherInfoEN.WebSite.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSite, conTeacherInfo.WebSite); //个人主页
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.WebSite); //个人主页
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PersonBlog))
 {
 if (objTeacherInfoEN.PersonBlog !=  null)
 {
 var strPersonBlog = objTeacherInfoEN.PersonBlog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPersonBlog, conTeacherInfo.PersonBlog); //个人博客
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.PersonBlog); //个人博客
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDate))
 {
 if (objTeacherInfoEN.EntryDate !=  null)
 {
 var strEntryDate = objTeacherInfoEN.EntryDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryDate, conTeacherInfo.EntryDate); //进校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.EntryDate); //进校日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Offed))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.Offed == true?"1":"0", conTeacherInfo.Offed); //是否离校
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsAvconUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsAvconUser == true?"1":"0", conTeacherInfo.IsAvconUser); //IsAvconUser
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsGpUser == true?"1":"0", conTeacherInfo.IsGpUser); //是否Gp用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsLocalUser == true?"1":"0", conTeacherInfo.IsLocalUser); //是否本地用户
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.FromUnit))
 {
 if (objTeacherInfoEN.FromUnit !=  null)
 {
 var strFromUnit = objTeacherInfoEN.FromUnit.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFromUnit, conTeacherInfo.FromUnit); //来自单位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.FromUnit); //来自单位
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Memo))
 {
 if (objTeacherInfoEN.Memo !=  null)
 {
 var strMemo = objTeacherInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTeacherInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Memo); //备注
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzCollege))
 {
 if (objTeacherInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objTeacherInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conTeacherInfo.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdXzCollege); //学院流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdXzMajor))
 {
 if (objTeacherInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objTeacherInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conTeacherInfo.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdXzMajor); //专业流水号
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.EntryDay))
 {
 if (objTeacherInfoEN.EntryDay !=  null)
 {
 var strEntryDay = objTeacherInfoEN.EntryDay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryDay, conTeacherInfo.EntryDay); //EntryDay
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.EntryDay); //EntryDay
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdPhoto))
 {
 if (objTeacherInfoEN.IdPhoto !=  null)
 {
 var strIdPhoto = objTeacherInfoEN.IdPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPhoto, conTeacherInfo.IdPhoto); //id_Photo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdPhoto); //id_Photo
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdReligion))
 {
 if (objTeacherInfoEN.IdReligion !=  null)
 {
 var strIdReligion = objTeacherInfoEN.IdReligion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdReligion, conTeacherInfo.IdReligion); //id_Religion
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdReligion); //id_Religion
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IsMessage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.IsMessage == true?"1":"0", conTeacherInfo.IsMessage); //IsMessage
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Microblog))
 {
 if (objTeacherInfoEN.Microblog !=  null)
 {
 var strMicroblog = objTeacherInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroblog, conTeacherInfo.Microblog); //Microblog
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Microblog); //Microblog
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyUserId))
 {
 if (objTeacherInfoEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objTeacherInfoEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conTeacherInfo.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.ModifyUserId); //修改人
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.OffedBak))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTeacherInfoEN.OffedBak == true?"1":"0", conTeacherInfo.OffedBak); //OffedBak
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.PhoneNumber))
 {
 if (objTeacherInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objTeacherInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conTeacherInfo.PhoneNumber); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.PhoneNumber); //电话
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.QQ))
 {
 if (objTeacherInfoEN.QQ !=  null)
 {
 var strQQ = objTeacherInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQQ, conTeacherInfo.QQ); //QQ
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.QQ); //QQ
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdCollege))
 {
 if (objTeacherInfoEN.TeachIdCollege !=  null)
 {
 var strTeachIdCollege = objTeacherInfoEN.TeachIdCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachIdCollege, conTeacherInfo.TeachIdCollege); //Teach_id_College
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeachIdCollege); //Teach_id_College
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeachIdMajor))
 {
 if (objTeacherInfoEN.TeachIdMajor !=  null)
 {
 var strTeachIdMajor = objTeacherInfoEN.TeachIdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachIdMajor, conTeacherInfo.TeachIdMajor); //Teach_id_Major
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeachIdMajor); //Teach_id_Major
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Tel))
 {
 if (objTeacherInfoEN.Tel !=  null)
 {
 var strTel = objTeacherInfoEN.Tel.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTel, conTeacherInfo.Tel); //Tel
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Tel); //Tel
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.Headphoto))
 {
 if (objTeacherInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objTeacherInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeadphoto, conTeacherInfo.Headphoto); //Headphoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.Headphoto); //Headphoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.ModifyDate))
 {
 if (objTeacherInfoEN.ModifyDate !=  null)
 {
 var strModifyDate = objTeacherInfoEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conTeacherInfo.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.ModifyDate); //修改日期
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.RegisterPassword))
 {
 if (objTeacherInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objTeacherInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conTeacherInfo.RegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.RegisterPassword); //RegisterPassword
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.TeacherPhoto))
 {
 if (objTeacherInfoEN.TeacherPhoto !=  null)
 {
 var strTeacherPhoto = objTeacherInfoEN.TeacherPhoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherPhoto, conTeacherInfo.TeacherPhoto); //TeacherPhoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.TeacherPhoto); //TeacherPhoto
 }
 }
 
 if (objTeacherInfoEN.IsUpdated(conTeacherInfo.IdCardNo))
 {
 if (objTeacherInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objTeacherInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo, conTeacherInfo.IdCardNo); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTeacherInfo.IdCardNo); //身份证号
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdTeacher = '{0}'", objTeacherInfoEN.IdTeacher); 
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
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdTeacher) 
{
CheckPrimaryKey(strIdTeacher);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdTeacher,
};
 objSQL.ExecSP("TeacherInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdTeacher, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdTeacher);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeacherInfo where IdTeacher = " + "'"+ strIdTeacher+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTeacherInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
//删除TeacherInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeacherInfo where IdTeacher in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdTeacher) 
{
CheckPrimaryKey(strIdTeacher);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
//删除TeacherInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TeacherInfo where IdTeacher = " + "'"+ strIdTeacher+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTeacherInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTeacherInfoDA: DelTeacherInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeacherInfo where " + strCondition ;
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
public bool DelTeacherInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTeacherInfoDA: DelTeacherInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TeacherInfo where " + strCondition ;
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
 /// <param name = "objTeacherInfoENS">源对象</param>
 /// <param name = "objTeacherInfoENT">目标对象</param>
public void CopyTo(clsTeacherInfoEN objTeacherInfoENS, clsTeacherInfoEN objTeacherInfoENT)
{
objTeacherInfoENT.IdTeacher = objTeacherInfoENS.IdTeacher; //教师流水号
objTeacherInfoENT.TeacherId = objTeacherInfoENS.TeacherId; //教师工号
objTeacherInfoENT.TeacherName = objTeacherInfoENS.TeacherName; //教师姓名
objTeacherInfoENT.IdSex = objTeacherInfoENS.IdSex; //性别流水号
objTeacherInfoENT.IdSchoolPs = objTeacherInfoENS.IdSchoolPs; //学校流水号
objTeacherInfoENT.IdDisciplinePs = objTeacherInfoENS.IdDisciplinePs; //学科流水号
objTeacherInfoENT.IdUniZone = objTeacherInfoENS.IdUniZone; //校区流水号
objTeacherInfoENT.IdEthnic = objTeacherInfoENS.IdEthnic; //民族流水号
objTeacherInfoENT.IdPolitics = objTeacherInfoENS.IdPolitics; //政治面貌流水号
objTeacherInfoENT.IdAdminGrade = objTeacherInfoENS.IdAdminGrade; //行政职务流水号
objTeacherInfoENT.IdProfGrade = objTeacherInfoENS.IdProfGrade; //专业职称流水号
objTeacherInfoENT.IdQualif = objTeacherInfoENS.IdQualif; //学历流水号
objTeacherInfoENT.IdDegree = objTeacherInfoENS.IdDegree; //学位流水号
objTeacherInfoENT.IdStaffType = objTeacherInfoENS.IdStaffType; //职工类型流水号
objTeacherInfoENT.IdProvince = objTeacherInfoENS.IdProvince; //省份流水号
objTeacherInfoENT.CitizenId = objTeacherInfoENS.CitizenId; //身份证号
objTeacherInfoENT.CardNo = objTeacherInfoENS.CardNo; //卡号
objTeacherInfoENT.Birthday = objTeacherInfoENS.Birthday; //出生日期
objTeacherInfoENT.GraduationMajor = objTeacherInfoENS.GraduationMajor; //毕业专业
objTeacherInfoENT.TelNo = objTeacherInfoENS.TelNo; //电话
objTeacherInfoENT.Email = objTeacherInfoENS.Email; //电子邮箱
objTeacherInfoENT.WebSite = objTeacherInfoENS.WebSite; //个人主页
objTeacherInfoENT.PersonBlog = objTeacherInfoENS.PersonBlog; //个人博客
objTeacherInfoENT.EntryDate = objTeacherInfoENS.EntryDate; //进校日期
objTeacherInfoENT.Offed = objTeacherInfoENS.Offed; //是否离校
objTeacherInfoENT.IsAvconUser = objTeacherInfoENS.IsAvconUser; //IsAvconUser
objTeacherInfoENT.IsGpUser = objTeacherInfoENS.IsGpUser; //是否Gp用户
objTeacherInfoENT.IsLocalUser = objTeacherInfoENS.IsLocalUser; //是否本地用户
objTeacherInfoENT.FromUnit = objTeacherInfoENS.FromUnit; //来自单位
objTeacherInfoENT.Memo = objTeacherInfoENS.Memo; //备注
objTeacherInfoENT.IdXzCollege = objTeacherInfoENS.IdXzCollege; //学院流水号
objTeacherInfoENT.IdXzMajor = objTeacherInfoENS.IdXzMajor; //专业流水号
objTeacherInfoENT.EntryDay = objTeacherInfoENS.EntryDay; //EntryDay
objTeacherInfoENT.IdPhoto = objTeacherInfoENS.IdPhoto; //id_Photo
objTeacherInfoENT.IdReligion = objTeacherInfoENS.IdReligion; //id_Religion
objTeacherInfoENT.IsMessage = objTeacherInfoENS.IsMessage; //IsMessage
objTeacherInfoENT.Microblog = objTeacherInfoENS.Microblog; //Microblog
objTeacherInfoENT.ModifyUserId = objTeacherInfoENS.ModifyUserId; //修改人
objTeacherInfoENT.OffedBak = objTeacherInfoENS.OffedBak; //OffedBak
objTeacherInfoENT.PhoneNumber = objTeacherInfoENS.PhoneNumber; //电话
objTeacherInfoENT.QQ = objTeacherInfoENS.QQ; //QQ
objTeacherInfoENT.TeachIdCollege = objTeacherInfoENS.TeachIdCollege; //Teach_id_College
objTeacherInfoENT.TeachIdMajor = objTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objTeacherInfoENT.Tel = objTeacherInfoENS.Tel; //Tel
objTeacherInfoENT.Headphoto = objTeacherInfoENS.Headphoto; //Headphoto
objTeacherInfoENT.ModifyDate = objTeacherInfoENS.ModifyDate; //修改日期
objTeacherInfoENT.RegisterPassword = objTeacherInfoENS.RegisterPassword; //RegisterPassword
objTeacherInfoENT.TeacherPhoto = objTeacherInfoENS.TeacherPhoto; //TeacherPhoto
objTeacherInfoENT.IdCardNo = objTeacherInfoENS.IdCardNo; //身份证号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTeacherInfoEN objTeacherInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTeacherInfoEN.TeacherId, conTeacherInfo.TeacherId);
clsCheckSql.CheckFieldNotNull(objTeacherInfoEN.TeacherName, conTeacherInfo.TeacherName);
clsCheckSql.CheckFieldNotNull(objTeacherInfoEN.IdSex, conTeacherInfo.IdSex);
//检查字段长度
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdTeacher, 8, conTeacherInfo.IdTeacher);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherId, 12, conTeacherInfo.TeacherId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherName, 50, conTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSex, 4, conTeacherInfo.IdSex);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSchoolPs, 4, conTeacherInfo.IdSchoolPs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDisciplinePs, 4, conTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdUniZone, 4, conTeacherInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdEthnic, 4, conTeacherInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPolitics, 4, conTeacherInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdAdminGrade, 4, conTeacherInfo.IdAdminGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProfGrade, 4, conTeacherInfo.IdProfGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdQualif, 4, conTeacherInfo.IdQualif);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDegree, 4, conTeacherInfo.IdDegree);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProvince, 4, conTeacherInfo.IdProvince);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CitizenId, 25, conTeacherInfo.CitizenId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CardNo, 18, conTeacherInfo.CardNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Birthday, 8, conTeacherInfo.Birthday);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.GraduationMajor, 40, conTeacherInfo.GraduationMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TelNo, 50, conTeacherInfo.TelNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Email, 100, conTeacherInfo.Email);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.WebSite, 60, conTeacherInfo.WebSite);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PersonBlog, 60, conTeacherInfo.PersonBlog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDate, 8, conTeacherInfo.EntryDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.FromUnit, 100, conTeacherInfo.FromUnit);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Memo, 1000, conTeacherInfo.Memo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzCollege, 4, conTeacherInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzMajor, 8, conTeacherInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDay, 8, conTeacherInfo.EntryDay);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPhoto, 8, conTeacherInfo.IdPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdReligion, 4, conTeacherInfo.IdReligion);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Microblog, 200, conTeacherInfo.Microblog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyUserId, 18, conTeacherInfo.ModifyUserId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PhoneNumber, 15, conTeacherInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.QQ, 100, conTeacherInfo.QQ);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdCollege, 6, conTeacherInfo.TeachIdCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdMajor, 8, conTeacherInfo.TeachIdMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Tel, 50, conTeacherInfo.Tel);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Headphoto, 500, conTeacherInfo.Headphoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyDate, 20, conTeacherInfo.ModifyDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.RegisterPassword, 30, conTeacherInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherPhoto, 500, conTeacherInfo.TeacherPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdCardNo, 20, conTeacherInfo.IdCardNo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
 objTeacherInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTeacherInfoEN objTeacherInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherId, 12, conTeacherInfo.TeacherId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherName, 50, conTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSex, 4, conTeacherInfo.IdSex);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSchoolPs, 4, conTeacherInfo.IdSchoolPs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDisciplinePs, 4, conTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdUniZone, 4, conTeacherInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdEthnic, 4, conTeacherInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPolitics, 4, conTeacherInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdAdminGrade, 4, conTeacherInfo.IdAdminGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProfGrade, 4, conTeacherInfo.IdProfGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdQualif, 4, conTeacherInfo.IdQualif);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDegree, 4, conTeacherInfo.IdDegree);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProvince, 4, conTeacherInfo.IdProvince);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CitizenId, 25, conTeacherInfo.CitizenId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CardNo, 18, conTeacherInfo.CardNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Birthday, 8, conTeacherInfo.Birthday);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.GraduationMajor, 40, conTeacherInfo.GraduationMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TelNo, 50, conTeacherInfo.TelNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Email, 100, conTeacherInfo.Email);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.WebSite, 60, conTeacherInfo.WebSite);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PersonBlog, 60, conTeacherInfo.PersonBlog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDate, 8, conTeacherInfo.EntryDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.FromUnit, 100, conTeacherInfo.FromUnit);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Memo, 1000, conTeacherInfo.Memo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzCollege, 4, conTeacherInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzMajor, 8, conTeacherInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDay, 8, conTeacherInfo.EntryDay);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPhoto, 8, conTeacherInfo.IdPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdReligion, 4, conTeacherInfo.IdReligion);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Microblog, 200, conTeacherInfo.Microblog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyUserId, 18, conTeacherInfo.ModifyUserId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PhoneNumber, 15, conTeacherInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.QQ, 100, conTeacherInfo.QQ);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdCollege, 6, conTeacherInfo.TeachIdCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdMajor, 8, conTeacherInfo.TeachIdMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Tel, 50, conTeacherInfo.Tel);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Headphoto, 500, conTeacherInfo.Headphoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyDate, 20, conTeacherInfo.ModifyDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.RegisterPassword, 30, conTeacherInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherPhoto, 500, conTeacherInfo.TeacherPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdCardNo, 20, conTeacherInfo.IdCardNo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
 objTeacherInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTeacherInfoEN objTeacherInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdTeacher, 8, conTeacherInfo.IdTeacher);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherId, 12, conTeacherInfo.TeacherId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherName, 50, conTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSex, 4, conTeacherInfo.IdSex);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdSchoolPs, 4, conTeacherInfo.IdSchoolPs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDisciplinePs, 4, conTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdUniZone, 4, conTeacherInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdEthnic, 4, conTeacherInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPolitics, 4, conTeacherInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdAdminGrade, 4, conTeacherInfo.IdAdminGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProfGrade, 4, conTeacherInfo.IdProfGrade);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdQualif, 4, conTeacherInfo.IdQualif);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdDegree, 4, conTeacherInfo.IdDegree);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdProvince, 4, conTeacherInfo.IdProvince);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CitizenId, 25, conTeacherInfo.CitizenId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.CardNo, 18, conTeacherInfo.CardNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Birthday, 8, conTeacherInfo.Birthday);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.GraduationMajor, 40, conTeacherInfo.GraduationMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TelNo, 50, conTeacherInfo.TelNo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Email, 100, conTeacherInfo.Email);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.WebSite, 60, conTeacherInfo.WebSite);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PersonBlog, 60, conTeacherInfo.PersonBlog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDate, 8, conTeacherInfo.EntryDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.FromUnit, 100, conTeacherInfo.FromUnit);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Memo, 1000, conTeacherInfo.Memo);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzCollege, 4, conTeacherInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdXzMajor, 8, conTeacherInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.EntryDay, 8, conTeacherInfo.EntryDay);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdPhoto, 8, conTeacherInfo.IdPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdReligion, 4, conTeacherInfo.IdReligion);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Microblog, 200, conTeacherInfo.Microblog);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyUserId, 18, conTeacherInfo.ModifyUserId);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.PhoneNumber, 15, conTeacherInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.QQ, 100, conTeacherInfo.QQ);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdCollege, 6, conTeacherInfo.TeachIdCollege);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeachIdMajor, 8, conTeacherInfo.TeachIdMajor);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Tel, 50, conTeacherInfo.Tel);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.Headphoto, 500, conTeacherInfo.Headphoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.ModifyDate, 20, conTeacherInfo.ModifyDate);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.RegisterPassword, 30, conTeacherInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.TeacherPhoto, 500, conTeacherInfo.TeacherPhoto);
clsCheckSql.CheckFieldLen(objTeacherInfoEN.IdCardNo, 20, conTeacherInfo.IdCardNo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdTeacher, conTeacherInfo.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TeacherId, conTeacherInfo.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TeacherName, conTeacherInfo.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdSex, conTeacherInfo.IdSex);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdSchoolPs, conTeacherInfo.IdSchoolPs);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdDisciplinePs, conTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdUniZone, conTeacherInfo.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdEthnic, conTeacherInfo.IdEthnic);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdPolitics, conTeacherInfo.IdPolitics);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdAdminGrade, conTeacherInfo.IdAdminGrade);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdProfGrade, conTeacherInfo.IdProfGrade);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdQualif, conTeacherInfo.IdQualif);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdDegree, conTeacherInfo.IdDegree);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdStaffType, conTeacherInfo.IdStaffType);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdProvince, conTeacherInfo.IdProvince);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.CitizenId, conTeacherInfo.CitizenId);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.CardNo, conTeacherInfo.CardNo);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Birthday, conTeacherInfo.Birthday);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.GraduationMajor, conTeacherInfo.GraduationMajor);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TelNo, conTeacherInfo.TelNo);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Email, conTeacherInfo.Email);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.WebSite, conTeacherInfo.WebSite);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.PersonBlog, conTeacherInfo.PersonBlog);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.EntryDate, conTeacherInfo.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.FromUnit, conTeacherInfo.FromUnit);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Memo, conTeacherInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdXzCollege, conTeacherInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdXzMajor, conTeacherInfo.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.EntryDay, conTeacherInfo.EntryDay);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdPhoto, conTeacherInfo.IdPhoto);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdReligion, conTeacherInfo.IdReligion);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Microblog, conTeacherInfo.Microblog);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.ModifyUserId, conTeacherInfo.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.PhoneNumber, conTeacherInfo.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.QQ, conTeacherInfo.QQ);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TeachIdCollege, conTeacherInfo.TeachIdCollege);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TeachIdMajor, conTeacherInfo.TeachIdMajor);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Tel, conTeacherInfo.Tel);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.Headphoto, conTeacherInfo.Headphoto);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.ModifyDate, conTeacherInfo.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.RegisterPassword, conTeacherInfo.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.TeacherPhoto, conTeacherInfo.TeacherPhoto);
clsCheckSql.CheckSqlInjection4Field(objTeacherInfoEN.IdCardNo, conTeacherInfo.IdCardNo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objTeacherInfoEN.IdStaffType, 4, conTeacherInfo.IdStaffType);
 objTeacherInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdTeacher()
{
//获取某学院所有专业信息
string strSQL = "select IdTeacher, TeacherName from TeacherInfo ";
 clsSpecSQLforSql mySql = clsTeacherInfoDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TeacherInfo(教师),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTeacherInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTeacherInfoEN objTeacherInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TeacherId = '{0}'", objTeacherInfoEN.TeacherId);
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeacherInfoEN._CurrTabName);
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTeacherInfoEN._CurrTabName, strCondition);
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsTeacherInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}