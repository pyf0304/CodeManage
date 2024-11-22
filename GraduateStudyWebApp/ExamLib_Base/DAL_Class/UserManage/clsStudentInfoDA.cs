
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsStudentInfoDA
 表名:StudentInfo(01120131)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
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
 /// 学生(StudentInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsStudentInfoDA : clsCommBase4DA
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
 return clsStudentInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsStudentInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsStudentInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsStudentInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsStudentInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdStudentInfo">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdStudentInfo)
{
strIdStudentInfo = strIdStudentInfo.Replace("'", "''");
if (strIdStudentInfo.Length > 8)
{
throw new Exception("(errid:Data000001)在表:StudentInfo中,检查关键字,长度不正确!(clsStudentInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdStudentInfo)  ==  true)
{
throw new Exception("(errid:Data000002)在表:StudentInfo中,关键字不能为空 或 null!(clsStudentInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdStudentInfo);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsStudentInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_StudentInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable_StudentInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} StudentInfo.* from StudentInfo Left Join {1} on {2} where {3} and StudentInfo.IdStudentInfo not in (Select top {5} StudentInfo.IdStudentInfo from StudentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1} and IdStudentInfo not in (Select top {2} IdStudentInfo from StudentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1} and IdStudentInfo not in (Select top {3} IdStudentInfo from StudentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsStudentInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} StudentInfo.* from StudentInfo Left Join {1} on {2} where {3} and StudentInfo.IdStudentInfo not in (Select top {5} StudentInfo.IdStudentInfo from StudentInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1} and IdStudentInfo not in (Select top {2} IdStudentInfo from StudentInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from StudentInfo where {1} and IdStudentInfo not in (Select top {3} IdStudentInfo from StudentInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsStudentInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsStudentInfoDA:GetObjLst)", objException.Message));
}
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = TransNullToBool(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = TransNullToBool(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = TransNullToBool(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = TransNullToBool(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsStudentInfoDA: GetObjLst)", objException.Message));
}
objStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objStudentInfoEN);
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
public List<clsStudentInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsStudentInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsStudentInfoEN> arrObjLst = new List<clsStudentInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = TransNullToBool(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = TransNullToBool(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = TransNullToBool(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = TransNullToBool(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsStudentInfoDA: GetObjLst)", objException.Message));
}
objStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objStudentInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetStudentInfo(ref clsStudentInfoEN objStudentInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where IdStudentInfo = " + "'"+ objStudentInfoEN.IdStudentInfo+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objStudentInfoEN.IdStudentInfo = objDT.Rows[0][conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objStudentInfoEN.StuId = objDT.Rows[0][conStudentInfo.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.StuName = objDT.Rows[0][conStudentInfo.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objStudentInfoEN.IdPolitics = objDT.Rows[0][conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdSex = objDT.Rows[0][conStudentInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdEthnic = objDT.Rows[0][conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdUniZone = objDT.Rows[0][conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdStuType = objDT.Rows[0][conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdXzCollege = objDT.Rows[0][conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objStudentInfoEN.IdXzMajor = objDT.Rows[0][conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objStudentInfoEN.IdGradeBase = objDT.Rows[0][conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objStudentInfoEN.IdGrade = objDT.Rows[0][conStudentInfo.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdAdminCls = objDT.Rows[0][conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentInfoEN.Birthday = objDT.Rows[0][conStudentInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objStudentInfoEN.NativePlace = objDT.Rows[0][conStudentInfo.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.Duty = objDT.Rows[0][conStudentInfo.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objStudentInfoEN.IdCardNo = objDT.Rows[0][conStudentInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.StuCardNo = objDT.Rows[0][conStudentInfo.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.LiveAddress = objDT.Rows[0][conStudentInfo.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.HomePhone = objDT.Rows[0][conStudentInfo.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.IdCardNo2 = objDT.Rows[0][conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.CardNo = objDT.Rows[0][conStudentInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objStudentInfoEN.IsGpUser = TransNullToBool(objDT.Rows[0][conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.IsLocalUser = TransNullToBool(objDT.Rows[0][conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.IsLeaved = TransNullToBool(objDT.Rows[0][conStudentInfo.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.UserId = objDT.Rows[0][conStudentInfo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objStudentInfoEN.UserType = objDT.Rows[0][conStudentInfo.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objStudentInfoEN.EnrollmentDate = objDT.Rows[0][conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objStudentInfoEN.PostCode = objDT.Rows[0][conStudentInfo.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objStudentInfoEN.Email = objDT.Rows[0][conStudentInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objStudentInfoEN.IsMessage = TransNullToBool(objDT.Rows[0][conStudentInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.Microblog = objDT.Rows[0][conStudentInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.PhoneNumber = objDT.Rows[0][conStudentInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objStudentInfoEN.Headphoto = objDT.Rows[0][conStudentInfo.Headphoto].ToString().Trim(); //Headphoto(字段类型:varchar,字段长度:500,是否可空:True)
 objStudentInfoEN.QQ = objDT.Rows[0][conStudentInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objStudentInfoEN.RegisterPassword = objDT.Rows[0][conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objStudentInfoEN.UpdDate = objDT.Rows[0][conStudentInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.UpdUser = objDT.Rows[0][conStudentInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.Memo = objDT.Rows[0][conStudentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsStudentInfoDA: GetStudentInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdStudentInfo">表关键字</param>
 /// <returns>表对象</returns>
public clsStudentInfoEN GetObjByIdStudentInfo(string strIdStudentInfo)
{
CheckPrimaryKey(strIdStudentInfo);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where IdStudentInfo = " + "'"+ strIdStudentInfo+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
 objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:False)
 objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位(字段类型:varchar,字段长度:30,是否可空:True)
 objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objStudentInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.IsLeaved = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
 objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期(字段类型:varchar,字段长度:8,是否可空:True)
 objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编(字段类型:char,字段长度:6,是否可空:True)
 objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objStudentInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto(字段类型:varchar,字段长度:500,是否可空:True)
 objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsStudentInfoDA: GetObjByIdStudentInfo)", objException.Message));
}
return objStudentInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsStudentInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsStudentInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN()
{
IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(), //学生流水号
StuId = objRow[conStudentInfo.StuId].ToString().Trim(), //学号
StuName = objRow[conStudentInfo.StuName].ToString().Trim(), //姓名
IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(), //政治面貌流水号
IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(), //性别流水号
IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(), //民族流水号
IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(), //校区流水号
IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(), //学生类别流水号
IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(), //专业流水号
IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(), //年级流水号
IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(), //年级流水号
IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(), //行政班流水号
Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(), //出生日期
NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(), //籍贯
Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(), //职位
IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(), //身份证号
StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(), //学生证号
LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(), //居住地址
HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(), //住宅电话
IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(), //内卡号
CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(), //卡号
IsGpUser = TransNullToBool(objRow[conStudentInfo.IsGpUser].ToString().Trim()), //是否Gp用户
IsLocalUser = TransNullToBool(objRow[conStudentInfo.IsLocalUser].ToString().Trim()), //是否本地用户
IsLeaved = TransNullToBool(objRow[conStudentInfo.IsLeaved].ToString().Trim()), //是否离开
UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(), //用户ID
UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(), //用户类型
EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(), //入校日期
PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(), //邮编
Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(), //电子邮箱
IsMessage = TransNullToBool(objRow[conStudentInfo.IsMessage].ToString().Trim()), //IsMessage
Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(), //Microblog
PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(), //电话
Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(), //Headphoto
QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(), //QQ
RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(), //RegisterPassword
UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim() //备注
};
objStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsStudentInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsStudentInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = TransNullToBool(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = TransNullToBool(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = TransNullToBool(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = TransNullToBool(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsStudentInfoDA: GetObjByDataRowStudentInfo)", objException.Message));
}
objStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsStudentInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsStudentInfoEN objStudentInfoEN = new clsStudentInfoEN();
try
{
objStudentInfoEN.IdStudentInfo = objRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objStudentInfoEN.StuId = objRow[conStudentInfo.StuId].ToString().Trim(); //学号
objStudentInfoEN.StuName = objRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objStudentInfoEN.IdPolitics = objRow[conStudentInfo.IdPolitics] == DBNull.Value ? null : objRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objStudentInfoEN.IdSex = objRow[conStudentInfo.IdSex] == DBNull.Value ? null : objRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objStudentInfoEN.IdEthnic = objRow[conStudentInfo.IdEthnic] == DBNull.Value ? null : objRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objStudentInfoEN.IdUniZone = objRow[conStudentInfo.IdUniZone] == DBNull.Value ? null : objRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objStudentInfoEN.IdStuType = objRow[conStudentInfo.IdStuType] == DBNull.Value ? null : objRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objStudentInfoEN.IdXzCollege = objRow[conStudentInfo.IdXzCollege] == DBNull.Value ? null : objRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objStudentInfoEN.IdXzMajor = objRow[conStudentInfo.IdXzMajor] == DBNull.Value ? null : objRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objStudentInfoEN.IdGradeBase = objRow[conStudentInfo.IdGradeBase] == DBNull.Value ? null : objRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objStudentInfoEN.IdGrade = objRow[conStudentInfo.IdGrade] == DBNull.Value ? null : objRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objStudentInfoEN.IdAdminCls = objRow[conStudentInfo.IdAdminCls] == DBNull.Value ? null : objRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objStudentInfoEN.Birthday = objRow[conStudentInfo.Birthday] == DBNull.Value ? null : objRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objStudentInfoEN.NativePlace = objRow[conStudentInfo.NativePlace] == DBNull.Value ? null : objRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objStudentInfoEN.Duty = objRow[conStudentInfo.Duty] == DBNull.Value ? null : objRow[conStudentInfo.Duty].ToString().Trim(); //职位
objStudentInfoEN.IdCardNo = objRow[conStudentInfo.IdCardNo] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objStudentInfoEN.StuCardNo = objRow[conStudentInfo.StuCardNo] == DBNull.Value ? null : objRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objStudentInfoEN.LiveAddress = objRow[conStudentInfo.LiveAddress] == DBNull.Value ? null : objRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objStudentInfoEN.HomePhone = objRow[conStudentInfo.HomePhone] == DBNull.Value ? null : objRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objStudentInfoEN.IdCardNo2 = objRow[conStudentInfo.IdCardNo2] == DBNull.Value ? null : objRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objStudentInfoEN.CardNo = objRow[conStudentInfo.CardNo] == DBNull.Value ? null : objRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objStudentInfoEN.IsGpUser = TransNullToBool(objRow[conStudentInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objStudentInfoEN.IsLocalUser = TransNullToBool(objRow[conStudentInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objStudentInfoEN.IsLeaved = TransNullToBool(objRow[conStudentInfo.IsLeaved].ToString().Trim()); //是否离开
objStudentInfoEN.UserId = objRow[conStudentInfo.UserId] == DBNull.Value ? null : objRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objStudentInfoEN.UserType = objRow[conStudentInfo.UserType] == DBNull.Value ? null : objRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objStudentInfoEN.EnrollmentDate = objRow[conStudentInfo.EnrollmentDate] == DBNull.Value ? null : objRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objStudentInfoEN.PostCode = objRow[conStudentInfo.PostCode] == DBNull.Value ? null : objRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objStudentInfoEN.Email = objRow[conStudentInfo.Email] == DBNull.Value ? null : objRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objStudentInfoEN.IsMessage = TransNullToBool(objRow[conStudentInfo.IsMessage].ToString().Trim()); //IsMessage
objStudentInfoEN.Microblog = objRow[conStudentInfo.Microblog] == DBNull.Value ? null : objRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objStudentInfoEN.PhoneNumber = objRow[conStudentInfo.PhoneNumber] == DBNull.Value ? null : objRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objStudentInfoEN.Headphoto = objRow[conStudentInfo.Headphoto] == DBNull.Value ? null : objRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objStudentInfoEN.QQ = objRow[conStudentInfo.QQ] == DBNull.Value ? null : objRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objStudentInfoEN.RegisterPassword = objRow[conStudentInfo.RegisterPassword] == DBNull.Value ? null : objRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objStudentInfoEN.UpdDate = objRow[conStudentInfo.UpdDate] == DBNull.Value ? null : objRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objStudentInfoEN.UpdUser = objRow[conStudentInfo.UpdUser] == DBNull.Value ? null : objRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objStudentInfoEN.Memo = objRow[conStudentInfo.Memo] == DBNull.Value ? null : objRow[conStudentInfo.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsStudentInfoDA: GetObjByDataRow)", objException.Message));
}
objStudentInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objStudentInfoEN;
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
objSQL = clsStudentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsStudentInfoEN._CurrTabName, conStudentInfo.IdStudentInfo, 8, "");
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
objSQL = clsStudentInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsStudentInfoEN._CurrTabName, conStudentInfo.IdStudentInfo, 8, strPrefix);
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdStudentInfo from StudentInfo where " + strCondition;
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdStudentInfo from StudentInfo where " + strCondition;
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdStudentInfo)
{
CheckPrimaryKey(strIdStudentInfo);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("StudentInfo", "IdStudentInfo = " + "'"+ strIdStudentInfo+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsStudentInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("StudentInfo", strCondition))
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
objSQL = clsStudentInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("StudentInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsStudentInfoEN objStudentInfoEN)
 {
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "StudentInfo");
objRow = objDS.Tables["StudentInfo"].NewRow();
objRow[conStudentInfo.IdStudentInfo] = objStudentInfoEN.IdStudentInfo; //学生流水号
objRow[conStudentInfo.StuId] = objStudentInfoEN.StuId; //学号
objRow[conStudentInfo.StuName] = objStudentInfoEN.StuName; //姓名
 if (objStudentInfoEN.IdPolitics !=  "")
 {
objRow[conStudentInfo.IdPolitics] = objStudentInfoEN.IdPolitics; //政治面貌流水号
 }
 if (objStudentInfoEN.IdSex !=  "")
 {
objRow[conStudentInfo.IdSex] = objStudentInfoEN.IdSex; //性别流水号
 }
 if (objStudentInfoEN.IdEthnic !=  "")
 {
objRow[conStudentInfo.IdEthnic] = objStudentInfoEN.IdEthnic; //民族流水号
 }
 if (objStudentInfoEN.IdUniZone !=  "")
 {
objRow[conStudentInfo.IdUniZone] = objStudentInfoEN.IdUniZone; //校区流水号
 }
 if (objStudentInfoEN.IdStuType !=  "")
 {
objRow[conStudentInfo.IdStuType] = objStudentInfoEN.IdStuType; //学生类别流水号
 }
 if (objStudentInfoEN.IdXzCollege !=  "")
 {
objRow[conStudentInfo.IdXzCollege] = objStudentInfoEN.IdXzCollege; //学院流水号
 }
 if (objStudentInfoEN.IdXzMajor !=  "")
 {
objRow[conStudentInfo.IdXzMajor] = objStudentInfoEN.IdXzMajor; //专业流水号
 }
 if (objStudentInfoEN.IdGradeBase !=  "")
 {
objRow[conStudentInfo.IdGradeBase] = objStudentInfoEN.IdGradeBase; //年级流水号
 }
 if (objStudentInfoEN.IdGrade !=  "")
 {
objRow[conStudentInfo.IdGrade] = objStudentInfoEN.IdGrade; //年级流水号
 }
 if (objStudentInfoEN.IdAdminCls !=  "")
 {
objRow[conStudentInfo.IdAdminCls] = objStudentInfoEN.IdAdminCls; //行政班流水号
 }
 if (objStudentInfoEN.Birthday !=  "")
 {
objRow[conStudentInfo.Birthday] = objStudentInfoEN.Birthday; //出生日期
 }
 if (objStudentInfoEN.NativePlace !=  "")
 {
objRow[conStudentInfo.NativePlace] = objStudentInfoEN.NativePlace; //籍贯
 }
 if (objStudentInfoEN.Duty !=  "")
 {
objRow[conStudentInfo.Duty] = objStudentInfoEN.Duty; //职位
 }
 if (objStudentInfoEN.IdCardNo !=  "")
 {
objRow[conStudentInfo.IdCardNo] = objStudentInfoEN.IdCardNo; //身份证号
 }
 if (objStudentInfoEN.StuCardNo !=  "")
 {
objRow[conStudentInfo.StuCardNo] = objStudentInfoEN.StuCardNo; //学生证号
 }
 if (objStudentInfoEN.LiveAddress !=  "")
 {
objRow[conStudentInfo.LiveAddress] = objStudentInfoEN.LiveAddress; //居住地址
 }
 if (objStudentInfoEN.HomePhone !=  "")
 {
objRow[conStudentInfo.HomePhone] = objStudentInfoEN.HomePhone; //住宅电话
 }
 if (objStudentInfoEN.IdCardNo2 !=  "")
 {
objRow[conStudentInfo.IdCardNo2] = objStudentInfoEN.IdCardNo2; //内卡号
 }
 if (objStudentInfoEN.CardNo !=  "")
 {
objRow[conStudentInfo.CardNo] = objStudentInfoEN.CardNo; //卡号
 }
objRow[conStudentInfo.IsGpUser] = objStudentInfoEN.IsGpUser; //是否Gp用户
objRow[conStudentInfo.IsLocalUser] = objStudentInfoEN.IsLocalUser; //是否本地用户
objRow[conStudentInfo.IsLeaved] = objStudentInfoEN.IsLeaved; //是否离开
 if (objStudentInfoEN.UserId !=  "")
 {
objRow[conStudentInfo.UserId] = objStudentInfoEN.UserId; //用户ID
 }
 if (objStudentInfoEN.UserType !=  "")
 {
objRow[conStudentInfo.UserType] = objStudentInfoEN.UserType; //用户类型
 }
 if (objStudentInfoEN.EnrollmentDate !=  "")
 {
objRow[conStudentInfo.EnrollmentDate] = objStudentInfoEN.EnrollmentDate; //入校日期
 }
 if (objStudentInfoEN.PostCode !=  "")
 {
objRow[conStudentInfo.PostCode] = objStudentInfoEN.PostCode; //邮编
 }
 if (objStudentInfoEN.Email !=  "")
 {
objRow[conStudentInfo.Email] = objStudentInfoEN.Email; //电子邮箱
 }
objRow[conStudentInfo.IsMessage] = objStudentInfoEN.IsMessage; //IsMessage
 if (objStudentInfoEN.Microblog !=  "")
 {
objRow[conStudentInfo.Microblog] = objStudentInfoEN.Microblog; //Microblog
 }
 if (objStudentInfoEN.PhoneNumber !=  "")
 {
objRow[conStudentInfo.PhoneNumber] = objStudentInfoEN.PhoneNumber; //电话
 }
 if (objStudentInfoEN.Headphoto !=  "")
 {
objRow[conStudentInfo.Headphoto] = objStudentInfoEN.Headphoto; //Headphoto
 }
 if (objStudentInfoEN.QQ !=  "")
 {
objRow[conStudentInfo.QQ] = objStudentInfoEN.QQ; //QQ
 }
 if (objStudentInfoEN.RegisterPassword !=  "")
 {
objRow[conStudentInfo.RegisterPassword] = objStudentInfoEN.RegisterPassword; //RegisterPassword
 }
 if (objStudentInfoEN.UpdDate !=  "")
 {
objRow[conStudentInfo.UpdDate] = objStudentInfoEN.UpdDate; //修改日期
 }
 if (objStudentInfoEN.UpdUser !=  "")
 {
objRow[conStudentInfo.UpdUser] = objStudentInfoEN.UpdUser; //修改人
 }
 if (objStudentInfoEN.Memo !=  "")
 {
objRow[conStudentInfo.Memo] = objStudentInfoEN.Memo; //备注
 }
objDS.Tables[clsStudentInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsStudentInfoEN._CurrTabName);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsStudentInfoEN objStudentInfoEN)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentInfoEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStudentInfo);
 var strIdStudentInfo = objStudentInfoEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objStudentInfoEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuId);
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objStudentInfoEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuName);
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdPolitics);
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objStudentInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdSex);
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdEthnic);
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdUniZone);
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objStudentInfoEN.IdStuType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStuType);
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStuType + "'");
 }
 
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzCollege);
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzMajor);
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGradeBase);
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objStudentInfoEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGrade);
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdAdminCls);
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objStudentInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Birthday);
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objStudentInfoEN.NativePlace !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.NativePlace);
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNativePlace + "'");
 }
 
 if (objStudentInfoEN.Duty !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Duty);
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDuty + "'");
 }
 
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo);
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuCardNo);
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuCardNo + "'");
 }
 
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.LiveAddress);
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveAddress + "'");
 }
 
 if (objStudentInfoEN.HomePhone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.HomePhone);
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePhone + "'");
 }
 
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo2);
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo2 + "'");
 }
 
 if (objStudentInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.CardNo);
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLeaved);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLeaved  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserId);
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objStudentInfoEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserType);
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.EnrollmentDate);
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnrollmentDate + "'");
 }
 
 if (objStudentInfoEN.PostCode !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PostCode);
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPostCode + "'");
 }
 
 if (objStudentInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Email);
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Microblog);
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PhoneNumber);
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objStudentInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Headphoto);
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objStudentInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.QQ);
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.RegisterPassword);
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objStudentInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdDate);
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objStudentInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdUser);
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objStudentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Memo);
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into StudentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsStudentInfoEN objStudentInfoEN)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentInfoEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStudentInfo);
 var strIdStudentInfo = objStudentInfoEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objStudentInfoEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuId);
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objStudentInfoEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuName);
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdPolitics);
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objStudentInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdSex);
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdEthnic);
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdUniZone);
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objStudentInfoEN.IdStuType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStuType);
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStuType + "'");
 }
 
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzCollege);
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzMajor);
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGradeBase);
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objStudentInfoEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGrade);
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdAdminCls);
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objStudentInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Birthday);
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objStudentInfoEN.NativePlace !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.NativePlace);
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNativePlace + "'");
 }
 
 if (objStudentInfoEN.Duty !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Duty);
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDuty + "'");
 }
 
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo);
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuCardNo);
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuCardNo + "'");
 }
 
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.LiveAddress);
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveAddress + "'");
 }
 
 if (objStudentInfoEN.HomePhone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.HomePhone);
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePhone + "'");
 }
 
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo2);
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo2 + "'");
 }
 
 if (objStudentInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.CardNo);
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLeaved);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLeaved  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserId);
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objStudentInfoEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserType);
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.EnrollmentDate);
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnrollmentDate + "'");
 }
 
 if (objStudentInfoEN.PostCode !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PostCode);
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPostCode + "'");
 }
 
 if (objStudentInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Email);
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Microblog);
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PhoneNumber);
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objStudentInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Headphoto);
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objStudentInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.QQ);
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.RegisterPassword);
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objStudentInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdDate);
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objStudentInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdUser);
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objStudentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Memo);
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into StudentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objStudentInfoEN.IdStudentInfo;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsStudentInfoEN objStudentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentInfoEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStudentInfo);
 var strIdStudentInfo = objStudentInfoEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objStudentInfoEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuId);
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objStudentInfoEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuName);
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdPolitics);
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objStudentInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdSex);
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdEthnic);
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdUniZone);
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objStudentInfoEN.IdStuType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStuType);
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStuType + "'");
 }
 
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzCollege);
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzMajor);
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGradeBase);
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objStudentInfoEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGrade);
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdAdminCls);
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objStudentInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Birthday);
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objStudentInfoEN.NativePlace !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.NativePlace);
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNativePlace + "'");
 }
 
 if (objStudentInfoEN.Duty !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Duty);
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDuty + "'");
 }
 
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo);
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuCardNo);
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuCardNo + "'");
 }
 
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.LiveAddress);
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveAddress + "'");
 }
 
 if (objStudentInfoEN.HomePhone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.HomePhone);
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePhone + "'");
 }
 
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo2);
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo2 + "'");
 }
 
 if (objStudentInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.CardNo);
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLeaved);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLeaved  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserId);
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objStudentInfoEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserType);
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.EnrollmentDate);
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnrollmentDate + "'");
 }
 
 if (objStudentInfoEN.PostCode !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PostCode);
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPostCode + "'");
 }
 
 if (objStudentInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Email);
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Microblog);
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PhoneNumber);
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objStudentInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Headphoto);
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objStudentInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.QQ);
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.RegisterPassword);
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objStudentInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdDate);
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objStudentInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdUser);
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objStudentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Memo);
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into StudentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objStudentInfoEN.IdStudentInfo;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsStudentInfoEN objStudentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objStudentInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objStudentInfoEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStudentInfo);
 var strIdStudentInfo = objStudentInfoEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objStudentInfoEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuId);
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objStudentInfoEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuName);
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdPolitics);
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPolitics + "'");
 }
 
 if (objStudentInfoEN.IdSex !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdSex);
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSex + "'");
 }
 
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdEthnic);
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEthnic + "'");
 }
 
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdUniZone);
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 if (objStudentInfoEN.IdStuType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdStuType);
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStuType + "'");
 }
 
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzCollege);
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdXzMajor);
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGradeBase);
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 if (objStudentInfoEN.IdGrade !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdGrade);
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGrade + "'");
 }
 
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdAdminCls);
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdAdminCls + "'");
 }
 
 if (objStudentInfoEN.Birthday !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Birthday);
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBirthday + "'");
 }
 
 if (objStudentInfoEN.NativePlace !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.NativePlace);
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNativePlace + "'");
 }
 
 if (objStudentInfoEN.Duty !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Duty);
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDuty + "'");
 }
 
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo);
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo + "'");
 }
 
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.StuCardNo);
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuCardNo + "'");
 }
 
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.LiveAddress);
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLiveAddress + "'");
 }
 
 if (objStudentInfoEN.HomePhone !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.HomePhone);
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHomePhone + "'");
 }
 
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.IdCardNo2);
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCardNo2 + "'");
 }
 
 if (objStudentInfoEN.CardNo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.CardNo);
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCardNo + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsGpUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsGpUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLocalUser);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLocalUser  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conStudentInfo.IsLeaved);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsLeaved  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserId);
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objStudentInfoEN.UserType !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UserType);
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserType + "'");
 }
 
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.EnrollmentDate);
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEnrollmentDate + "'");
 }
 
 if (objStudentInfoEN.PostCode !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PostCode);
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPostCode + "'");
 }
 
 if (objStudentInfoEN.Email !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Email);
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEmail + "'");
 }
 
 arrFieldListForInsert.Add(conStudentInfo.IsMessage);
 arrValueListForInsert.Add("'" + (objStudentInfoEN.IsMessage  ==  false ? "0" : "1") + "'");
 
 if (objStudentInfoEN.Microblog !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Microblog);
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMicroblog + "'");
 }
 
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.PhoneNumber);
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPhoneNumber + "'");
 }
 
 if (objStudentInfoEN.Headphoto !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Headphoto);
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strHeadphoto + "'");
 }
 
 if (objStudentInfoEN.QQ !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.QQ);
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQQ + "'");
 }
 
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.RegisterPassword);
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRegisterPassword + "'");
 }
 
 if (objStudentInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdDate);
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objStudentInfoEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.UpdUser);
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objStudentInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conStudentInfo.Memo);
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into StudentInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewStudentInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where IdStudentInfo = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "StudentInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdStudentInfo = oRow[conStudentInfo.IdStudentInfo].ToString().Trim();
if (IsExist(strIdStudentInfo))
{
 string strResult = "关键字变量值为:" + string.Format("IdStudentInfo = {0}", strIdStudentInfo) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsStudentInfoEN._CurrTabName ].NewRow();
objRow[conStudentInfo.IdStudentInfo] = oRow[conStudentInfo.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[conStudentInfo.StuId] = oRow[conStudentInfo.StuId].ToString().Trim(); //学号
objRow[conStudentInfo.StuName] = oRow[conStudentInfo.StuName].ToString().Trim(); //姓名
objRow[conStudentInfo.IdPolitics] = oRow[conStudentInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objRow[conStudentInfo.IdSex] = oRow[conStudentInfo.IdSex].ToString().Trim(); //性别流水号
objRow[conStudentInfo.IdEthnic] = oRow[conStudentInfo.IdEthnic].ToString().Trim(); //民族流水号
objRow[conStudentInfo.IdUniZone] = oRow[conStudentInfo.IdUniZone].ToString().Trim(); //校区流水号
objRow[conStudentInfo.IdStuType] = oRow[conStudentInfo.IdStuType].ToString().Trim(); //学生类别流水号
objRow[conStudentInfo.IdXzCollege] = oRow[conStudentInfo.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conStudentInfo.IdXzMajor] = oRow[conStudentInfo.IdXzMajor].ToString().Trim(); //专业流水号
objRow[conStudentInfo.IdGradeBase] = oRow[conStudentInfo.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conStudentInfo.IdGrade] = oRow[conStudentInfo.IdGrade].ToString().Trim(); //年级流水号
objRow[conStudentInfo.IdAdminCls] = oRow[conStudentInfo.IdAdminCls].ToString().Trim(); //行政班流水号
objRow[conStudentInfo.Birthday] = oRow[conStudentInfo.Birthday].ToString().Trim(); //出生日期
objRow[conStudentInfo.NativePlace] = oRow[conStudentInfo.NativePlace].ToString().Trim(); //籍贯
objRow[conStudentInfo.Duty] = oRow[conStudentInfo.Duty].ToString().Trim(); //职位
objRow[conStudentInfo.IdCardNo] = oRow[conStudentInfo.IdCardNo].ToString().Trim(); //身份证号
objRow[conStudentInfo.StuCardNo] = oRow[conStudentInfo.StuCardNo].ToString().Trim(); //学生证号
objRow[conStudentInfo.LiveAddress] = oRow[conStudentInfo.LiveAddress].ToString().Trim(); //居住地址
objRow[conStudentInfo.HomePhone] = oRow[conStudentInfo.HomePhone].ToString().Trim(); //住宅电话
objRow[conStudentInfo.IdCardNo2] = oRow[conStudentInfo.IdCardNo2].ToString().Trim(); //内卡号
objRow[conStudentInfo.CardNo] = oRow[conStudentInfo.CardNo].ToString().Trim(); //卡号
objRow[conStudentInfo.IsGpUser] = oRow[conStudentInfo.IsGpUser].ToString().Trim(); //是否Gp用户
objRow[conStudentInfo.IsLocalUser] = oRow[conStudentInfo.IsLocalUser].ToString().Trim(); //是否本地用户
objRow[conStudentInfo.IsLeaved] = oRow[conStudentInfo.IsLeaved].ToString().Trim(); //是否离开
objRow[conStudentInfo.UserId] = oRow[conStudentInfo.UserId].ToString().Trim(); //用户ID
objRow[conStudentInfo.UserType] = oRow[conStudentInfo.UserType].ToString().Trim(); //用户类型
objRow[conStudentInfo.EnrollmentDate] = oRow[conStudentInfo.EnrollmentDate].ToString().Trim(); //入校日期
objRow[conStudentInfo.PostCode] = oRow[conStudentInfo.PostCode].ToString().Trim(); //邮编
objRow[conStudentInfo.Email] = oRow[conStudentInfo.Email].ToString().Trim(); //电子邮箱
objRow[conStudentInfo.IsMessage] = oRow[conStudentInfo.IsMessage].ToString().Trim(); //IsMessage
objRow[conStudentInfo.Microblog] = oRow[conStudentInfo.Microblog].ToString().Trim(); //Microblog
objRow[conStudentInfo.PhoneNumber] = oRow[conStudentInfo.PhoneNumber].ToString().Trim(); //电话
objRow[conStudentInfo.Headphoto] = oRow[conStudentInfo.Headphoto].ToString().Trim(); //Headphoto
objRow[conStudentInfo.QQ] = oRow[conStudentInfo.QQ].ToString().Trim(); //QQ
objRow[conStudentInfo.RegisterPassword] = oRow[conStudentInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objRow[conStudentInfo.UpdDate] = oRow[conStudentInfo.UpdDate].ToString().Trim(); //修改日期
objRow[conStudentInfo.UpdUser] = oRow[conStudentInfo.UpdUser].ToString().Trim(); //修改人
objRow[conStudentInfo.Memo] = oRow[conStudentInfo.Memo].ToString().Trim(); //备注
 objDS.Tables[clsStudentInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsStudentInfoEN._CurrTabName);
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
 /// <param name = "objStudentInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsStudentInfoEN objStudentInfoEN)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
strSQL = "Select * from StudentInfo where IdStudentInfo = " + "'"+ objStudentInfoEN.IdStudentInfo+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsStudentInfoEN._CurrTabName);
if (objDS.Tables[clsStudentInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdStudentInfo = " + "'"+ objStudentInfoEN.IdStudentInfo+"'");
return false;
}
objRow = objDS.Tables[clsStudentInfoEN._CurrTabName].Rows[0];
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStudentInfo))
 {
objRow[conStudentInfo.IdStudentInfo] = objStudentInfoEN.IdStudentInfo; //学生流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuId))
 {
objRow[conStudentInfo.StuId] = objStudentInfoEN.StuId; //学号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuName))
 {
objRow[conStudentInfo.StuName] = objStudentInfoEN.StuName; //姓名
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdPolitics))
 {
objRow[conStudentInfo.IdPolitics] = objStudentInfoEN.IdPolitics; //政治面貌流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdSex))
 {
objRow[conStudentInfo.IdSex] = objStudentInfoEN.IdSex; //性别流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdEthnic))
 {
objRow[conStudentInfo.IdEthnic] = objStudentInfoEN.IdEthnic; //民族流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdUniZone))
 {
objRow[conStudentInfo.IdUniZone] = objStudentInfoEN.IdUniZone; //校区流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStuType))
 {
objRow[conStudentInfo.IdStuType] = objStudentInfoEN.IdStuType; //学生类别流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzCollege))
 {
objRow[conStudentInfo.IdXzCollege] = objStudentInfoEN.IdXzCollege; //学院流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzMajor))
 {
objRow[conStudentInfo.IdXzMajor] = objStudentInfoEN.IdXzMajor; //专业流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGradeBase))
 {
objRow[conStudentInfo.IdGradeBase] = objStudentInfoEN.IdGradeBase; //年级流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGrade))
 {
objRow[conStudentInfo.IdGrade] = objStudentInfoEN.IdGrade; //年级流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdAdminCls))
 {
objRow[conStudentInfo.IdAdminCls] = objStudentInfoEN.IdAdminCls; //行政班流水号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Birthday))
 {
objRow[conStudentInfo.Birthday] = objStudentInfoEN.Birthday; //出生日期
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.NativePlace))
 {
objRow[conStudentInfo.NativePlace] = objStudentInfoEN.NativePlace; //籍贯
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Duty))
 {
objRow[conStudentInfo.Duty] = objStudentInfoEN.Duty; //职位
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo))
 {
objRow[conStudentInfo.IdCardNo] = objStudentInfoEN.IdCardNo; //身份证号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuCardNo))
 {
objRow[conStudentInfo.StuCardNo] = objStudentInfoEN.StuCardNo; //学生证号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.LiveAddress))
 {
objRow[conStudentInfo.LiveAddress] = objStudentInfoEN.LiveAddress; //居住地址
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.HomePhone))
 {
objRow[conStudentInfo.HomePhone] = objStudentInfoEN.HomePhone; //住宅电话
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo2))
 {
objRow[conStudentInfo.IdCardNo2] = objStudentInfoEN.IdCardNo2; //内卡号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.CardNo))
 {
objRow[conStudentInfo.CardNo] = objStudentInfoEN.CardNo; //卡号
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsGpUser))
 {
objRow[conStudentInfo.IsGpUser] = objStudentInfoEN.IsGpUser; //是否Gp用户
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLocalUser))
 {
objRow[conStudentInfo.IsLocalUser] = objStudentInfoEN.IsLocalUser; //是否本地用户
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLeaved))
 {
objRow[conStudentInfo.IsLeaved] = objStudentInfoEN.IsLeaved; //是否离开
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserId))
 {
objRow[conStudentInfo.UserId] = objStudentInfoEN.UserId; //用户ID
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserType))
 {
objRow[conStudentInfo.UserType] = objStudentInfoEN.UserType; //用户类型
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.EnrollmentDate))
 {
objRow[conStudentInfo.EnrollmentDate] = objStudentInfoEN.EnrollmentDate; //入校日期
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PostCode))
 {
objRow[conStudentInfo.PostCode] = objStudentInfoEN.PostCode; //邮编
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Email))
 {
objRow[conStudentInfo.Email] = objStudentInfoEN.Email; //电子邮箱
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsMessage))
 {
objRow[conStudentInfo.IsMessage] = objStudentInfoEN.IsMessage; //IsMessage
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Microblog))
 {
objRow[conStudentInfo.Microblog] = objStudentInfoEN.Microblog; //Microblog
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PhoneNumber))
 {
objRow[conStudentInfo.PhoneNumber] = objStudentInfoEN.PhoneNumber; //电话
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Headphoto))
 {
objRow[conStudentInfo.Headphoto] = objStudentInfoEN.Headphoto; //Headphoto
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.QQ))
 {
objRow[conStudentInfo.QQ] = objStudentInfoEN.QQ; //QQ
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.RegisterPassword))
 {
objRow[conStudentInfo.RegisterPassword] = objStudentInfoEN.RegisterPassword; //RegisterPassword
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdDate))
 {
objRow[conStudentInfo.UpdDate] = objStudentInfoEN.UpdDate; //修改日期
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdUser))
 {
objRow[conStudentInfo.UpdUser] = objStudentInfoEN.UpdUser; //修改人
 }
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Memo))
 {
objRow[conStudentInfo.Memo] = objStudentInfoEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsStudentInfoEN._CurrTabName);
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsStudentInfoEN objStudentInfoEN)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update StudentInfo Set ");
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuId))
 {
 if (objStudentInfoEN.StuId !=  null)
 {
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuId, conStudentInfo.StuId); //学号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuId); //学号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuName))
 {
 if (objStudentInfoEN.StuName !=  null)
 {
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuName, conStudentInfo.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuName); //姓名
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdPolitics))
 {
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPolitics, conStudentInfo.IdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdPolitics); //政治面貌流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdSex))
 {
 if (objStudentInfoEN.IdSex !=  null)
 {
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSex, conStudentInfo.IdSex); //性别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdSex); //性别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdEthnic))
 {
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEthnic, conStudentInfo.IdEthnic); //民族流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdEthnic); //民族流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdUniZone))
 {
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conStudentInfo.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdUniZone); //校区流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStuType))
 {
 if (objStudentInfoEN.IdStuType !=  null)
 {
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStuType, conStudentInfo.IdStuType); //学生类别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdStuType); //学生类别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzCollege))
 {
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conStudentInfo.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdXzCollege); //学院流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzMajor))
 {
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conStudentInfo.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdXzMajor); //专业流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGradeBase))
 {
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conStudentInfo.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdGradeBase); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGrade))
 {
 if (objStudentInfoEN.IdGrade !=  null)
 {
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conStudentInfo.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdGrade); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdAdminCls))
 {
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminCls, conStudentInfo.IdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdAdminCls); //行政班流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Birthday))
 {
 if (objStudentInfoEN.Birthday !=  null)
 {
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBirthday, conStudentInfo.Birthday); //出生日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Birthday); //出生日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.NativePlace))
 {
 if (objStudentInfoEN.NativePlace !=  null)
 {
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNativePlace, conStudentInfo.NativePlace); //籍贯
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.NativePlace); //籍贯
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Duty))
 {
 if (objStudentInfoEN.Duty !=  null)
 {
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDuty, conStudentInfo.Duty); //职位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Duty); //职位
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo))
 {
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo, conStudentInfo.IdCardNo); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdCardNo); //身份证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuCardNo))
 {
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuCardNo, conStudentInfo.StuCardNo); //学生证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuCardNo); //学生证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.LiveAddress))
 {
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveAddress, conStudentInfo.LiveAddress); //居住地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.LiveAddress); //居住地址
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.HomePhone))
 {
 if (objStudentInfoEN.HomePhone !=  null)
 {
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePhone, conStudentInfo.HomePhone); //住宅电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.HomePhone); //住宅电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo2))
 {
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo2, conStudentInfo.IdCardNo2); //内卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdCardNo2); //内卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.CardNo))
 {
 if (objStudentInfoEN.CardNo !=  null)
 {
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCardNo, conStudentInfo.CardNo); //卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.CardNo); //卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsGpUser == true?"1":"0", conStudentInfo.IsGpUser); //是否Gp用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsLocalUser == true?"1":"0", conStudentInfo.IsLocalUser); //是否本地用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLeaved))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsLeaved == true?"1":"0", conStudentInfo.IsLeaved); //是否离开
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserId))
 {
 if (objStudentInfoEN.UserId !=  null)
 {
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conStudentInfo.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UserId); //用户ID
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserType))
 {
 if (objStudentInfoEN.UserType !=  null)
 {
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conStudentInfo.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UserType); //用户类型
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.EnrollmentDate))
 {
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEnrollmentDate, conStudentInfo.EnrollmentDate); //入校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.EnrollmentDate); //入校日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PostCode))
 {
 if (objStudentInfoEN.PostCode !=  null)
 {
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPostCode, conStudentInfo.PostCode); //邮编
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.PostCode); //邮编
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Email))
 {
 if (objStudentInfoEN.Email !=  null)
 {
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conStudentInfo.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Email); //电子邮箱
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsMessage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsMessage == true?"1":"0", conStudentInfo.IsMessage); //IsMessage
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Microblog))
 {
 if (objStudentInfoEN.Microblog !=  null)
 {
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroblog, conStudentInfo.Microblog); //Microblog
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Microblog); //Microblog
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PhoneNumber))
 {
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conStudentInfo.PhoneNumber); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.PhoneNumber); //电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Headphoto))
 {
 if (objStudentInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeadphoto, conStudentInfo.Headphoto); //Headphoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Headphoto); //Headphoto
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.QQ))
 {
 if (objStudentInfoEN.QQ !=  null)
 {
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQQ, conStudentInfo.QQ); //QQ
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.QQ); //QQ
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.RegisterPassword))
 {
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conStudentInfo.RegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.RegisterPassword); //RegisterPassword
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdDate))
 {
 if (objStudentInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conStudentInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UpdDate); //修改日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdUser))
 {
 if (objStudentInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conStudentInfo.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UpdUser); //修改人
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Memo))
 {
 if (objStudentInfoEN.Memo !=  null)
 {
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conStudentInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdStudentInfo = '{0}'", objStudentInfoEN.IdStudentInfo); 
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsStudentInfoEN objStudentInfoEN, string strCondition)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update StudentInfo Set ");
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuId))
 {
 if (objStudentInfoEN.StuId !=  null)
 {
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuId = '{0}',", strStuId); //学号
 }
 else
 {
 sbSQL.Append(" StuId = null,"); //学号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuName))
 {
 if (objStudentInfoEN.StuName !=  null)
 {
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", strStuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdPolitics))
 {
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPolitics = '{0}',", strIdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.Append(" IdPolitics = null,"); //政治面貌流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdSex))
 {
 if (objStudentInfoEN.IdSex !=  null)
 {
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSex = '{0}',", strIdSex); //性别流水号
 }
 else
 {
 sbSQL.Append(" IdSex = null,"); //性别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdEthnic))
 {
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEthnic = '{0}',", strIdEthnic); //民族流水号
 }
 else
 {
 sbSQL.Append(" IdEthnic = null,"); //民族流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdUniZone))
 {
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStuType))
 {
 if (objStudentInfoEN.IdStuType !=  null)
 {
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStuType = '{0}',", strIdStuType); //学生类别流水号
 }
 else
 {
 sbSQL.Append(" IdStuType = null,"); //学生类别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzCollege))
 {
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzMajor))
 {
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGradeBase))
 {
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGrade))
 {
 if (objStudentInfoEN.IdGrade !=  null)
 {
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdAdminCls))
 {
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminCls = '{0}',", strIdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.Append(" IdAdminCls = null,"); //行政班流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Birthday))
 {
 if (objStudentInfoEN.Birthday !=  null)
 {
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Birthday = '{0}',", strBirthday); //出生日期
 }
 else
 {
 sbSQL.Append(" Birthday = null,"); //出生日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.NativePlace))
 {
 if (objStudentInfoEN.NativePlace !=  null)
 {
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NativePlace = '{0}',", strNativePlace); //籍贯
 }
 else
 {
 sbSQL.Append(" NativePlace = null,"); //籍贯
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Duty))
 {
 if (objStudentInfoEN.Duty !=  null)
 {
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Duty = '{0}',", strDuty); //职位
 }
 else
 {
 sbSQL.Append(" Duty = null,"); //职位
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo))
 {
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo = '{0}',", strIdCardNo); //身份证号
 }
 else
 {
 sbSQL.Append(" IdCardNo = null,"); //身份证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuCardNo))
 {
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuCardNo = '{0}',", strStuCardNo); //学生证号
 }
 else
 {
 sbSQL.Append(" StuCardNo = null,"); //学生证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.LiveAddress))
 {
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveAddress = '{0}',", strLiveAddress); //居住地址
 }
 else
 {
 sbSQL.Append(" LiveAddress = null,"); //居住地址
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.HomePhone))
 {
 if (objStudentInfoEN.HomePhone !=  null)
 {
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePhone = '{0}',", strHomePhone); //住宅电话
 }
 else
 {
 sbSQL.Append(" HomePhone = null,"); //住宅电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo2))
 {
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo2 = '{0}',", strIdCardNo2); //内卡号
 }
 else
 {
 sbSQL.Append(" IdCardNo2 = null,"); //内卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.CardNo))
 {
 if (objStudentInfoEN.CardNo !=  null)
 {
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CardNo = '{0}',", strCardNo); //卡号
 }
 else
 {
 sbSQL.Append(" CardNo = null,"); //卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objStudentInfoEN.IsGpUser == true?"1":"0"); //是否Gp用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" IsLocalUser = '{0}',", objStudentInfoEN.IsLocalUser == true?"1":"0"); //是否本地用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLeaved))
 {
 sbSQL.AppendFormat(" IsLeaved = '{0}',", objStudentInfoEN.IsLeaved == true?"1":"0"); //是否离开
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserId))
 {
 if (objStudentInfoEN.UserId !=  null)
 {
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserType))
 {
 if (objStudentInfoEN.UserType !=  null)
 {
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.EnrollmentDate))
 {
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EnrollmentDate = '{0}',", strEnrollmentDate); //入校日期
 }
 else
 {
 sbSQL.Append(" EnrollmentDate = null,"); //入校日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PostCode))
 {
 if (objStudentInfoEN.PostCode !=  null)
 {
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PostCode = '{0}',", strPostCode); //邮编
 }
 else
 {
 sbSQL.Append(" PostCode = null,"); //邮编
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Email))
 {
 if (objStudentInfoEN.Email !=  null)
 {
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsMessage))
 {
 sbSQL.AppendFormat(" IsMessage = '{0}',", objStudentInfoEN.IsMessage == true?"1":"0"); //IsMessage
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Microblog))
 {
 if (objStudentInfoEN.Microblog !=  null)
 {
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Microblog = '{0}',", strMicroblog); //Microblog
 }
 else
 {
 sbSQL.Append(" Microblog = null,"); //Microblog
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PhoneNumber))
 {
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Headphoto))
 {
 if (objStudentInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Headphoto = '{0}',", strHeadphoto); //Headphoto
 }
 else
 {
 sbSQL.Append(" Headphoto = null,"); //Headphoto
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.QQ))
 {
 if (objStudentInfoEN.QQ !=  null)
 {
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QQ = '{0}',", strQQ); //QQ
 }
 else
 {
 sbSQL.Append(" QQ = null,"); //QQ
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.RegisterPassword))
 {
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //RegisterPassword
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdDate))
 {
 if (objStudentInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdUser))
 {
 if (objStudentInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Memo))
 {
 if (objStudentInfoEN.Memo !=  null)
 {
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objStudentInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsStudentInfoEN objStudentInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update StudentInfo Set ");
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuId))
 {
 if (objStudentInfoEN.StuId !=  null)
 {
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuId = '{0}',", strStuId); //学号
 }
 else
 {
 sbSQL.Append(" StuId = null,"); //学号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuName))
 {
 if (objStudentInfoEN.StuName !=  null)
 {
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", strStuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdPolitics))
 {
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPolitics = '{0}',", strIdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.Append(" IdPolitics = null,"); //政治面貌流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdSex))
 {
 if (objStudentInfoEN.IdSex !=  null)
 {
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSex = '{0}',", strIdSex); //性别流水号
 }
 else
 {
 sbSQL.Append(" IdSex = null,"); //性别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdEthnic))
 {
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEthnic = '{0}',", strIdEthnic); //民族流水号
 }
 else
 {
 sbSQL.Append(" IdEthnic = null,"); //民族流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdUniZone))
 {
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStuType))
 {
 if (objStudentInfoEN.IdStuType !=  null)
 {
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStuType = '{0}',", strIdStuType); //学生类别流水号
 }
 else
 {
 sbSQL.Append(" IdStuType = null,"); //学生类别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzCollege))
 {
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzMajor))
 {
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGradeBase))
 {
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGrade))
 {
 if (objStudentInfoEN.IdGrade !=  null)
 {
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGrade = '{0}',", strIdGrade); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGrade = null,"); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdAdminCls))
 {
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdAdminCls = '{0}',", strIdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.Append(" IdAdminCls = null,"); //行政班流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Birthday))
 {
 if (objStudentInfoEN.Birthday !=  null)
 {
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Birthday = '{0}',", strBirthday); //出生日期
 }
 else
 {
 sbSQL.Append(" Birthday = null,"); //出生日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.NativePlace))
 {
 if (objStudentInfoEN.NativePlace !=  null)
 {
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NativePlace = '{0}',", strNativePlace); //籍贯
 }
 else
 {
 sbSQL.Append(" NativePlace = null,"); //籍贯
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Duty))
 {
 if (objStudentInfoEN.Duty !=  null)
 {
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Duty = '{0}',", strDuty); //职位
 }
 else
 {
 sbSQL.Append(" Duty = null,"); //职位
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo))
 {
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo = '{0}',", strIdCardNo); //身份证号
 }
 else
 {
 sbSQL.Append(" IdCardNo = null,"); //身份证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuCardNo))
 {
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuCardNo = '{0}',", strStuCardNo); //学生证号
 }
 else
 {
 sbSQL.Append(" StuCardNo = null,"); //学生证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.LiveAddress))
 {
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LiveAddress = '{0}',", strLiveAddress); //居住地址
 }
 else
 {
 sbSQL.Append(" LiveAddress = null,"); //居住地址
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.HomePhone))
 {
 if (objStudentInfoEN.HomePhone !=  null)
 {
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" HomePhone = '{0}',", strHomePhone); //住宅电话
 }
 else
 {
 sbSQL.Append(" HomePhone = null,"); //住宅电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo2))
 {
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCardNo2 = '{0}',", strIdCardNo2); //内卡号
 }
 else
 {
 sbSQL.Append(" IdCardNo2 = null,"); //内卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.CardNo))
 {
 if (objStudentInfoEN.CardNo !=  null)
 {
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CardNo = '{0}',", strCardNo); //卡号
 }
 else
 {
 sbSQL.Append(" CardNo = null,"); //卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" IsGpUser = '{0}',", objStudentInfoEN.IsGpUser == true?"1":"0"); //是否Gp用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" IsLocalUser = '{0}',", objStudentInfoEN.IsLocalUser == true?"1":"0"); //是否本地用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLeaved))
 {
 sbSQL.AppendFormat(" IsLeaved = '{0}',", objStudentInfoEN.IsLeaved == true?"1":"0"); //是否离开
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserId))
 {
 if (objStudentInfoEN.UserId !=  null)
 {
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserType))
 {
 if (objStudentInfoEN.UserType !=  null)
 {
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserType = '{0}',", strUserType); //用户类型
 }
 else
 {
 sbSQL.Append(" UserType = null,"); //用户类型
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.EnrollmentDate))
 {
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EnrollmentDate = '{0}',", strEnrollmentDate); //入校日期
 }
 else
 {
 sbSQL.Append(" EnrollmentDate = null,"); //入校日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PostCode))
 {
 if (objStudentInfoEN.PostCode !=  null)
 {
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PostCode = '{0}',", strPostCode); //邮编
 }
 else
 {
 sbSQL.Append(" PostCode = null,"); //邮编
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Email))
 {
 if (objStudentInfoEN.Email !=  null)
 {
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Email = '{0}',", strEmail); //电子邮箱
 }
 else
 {
 sbSQL.Append(" Email = null,"); //电子邮箱
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsMessage))
 {
 sbSQL.AppendFormat(" IsMessage = '{0}',", objStudentInfoEN.IsMessage == true?"1":"0"); //IsMessage
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Microblog))
 {
 if (objStudentInfoEN.Microblog !=  null)
 {
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Microblog = '{0}',", strMicroblog); //Microblog
 }
 else
 {
 sbSQL.Append(" Microblog = null,"); //Microblog
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PhoneNumber))
 {
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PhoneNumber = '{0}',", strPhoneNumber); //电话
 }
 else
 {
 sbSQL.Append(" PhoneNumber = null,"); //电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Headphoto))
 {
 if (objStudentInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Headphoto = '{0}',", strHeadphoto); //Headphoto
 }
 else
 {
 sbSQL.Append(" Headphoto = null,"); //Headphoto
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.QQ))
 {
 if (objStudentInfoEN.QQ !=  null)
 {
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QQ = '{0}',", strQQ); //QQ
 }
 else
 {
 sbSQL.Append(" QQ = null,"); //QQ
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.RegisterPassword))
 {
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RegisterPassword = '{0}',", strRegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.Append(" RegisterPassword = null,"); //RegisterPassword
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdDate))
 {
 if (objStudentInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdUser))
 {
 if (objStudentInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Memo))
 {
 if (objStudentInfoEN.Memo !=  null)
 {
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objStudentInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsStudentInfoEN objStudentInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objStudentInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objStudentInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objStudentInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update StudentInfo Set ");
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuId))
 {
 if (objStudentInfoEN.StuId !=  null)
 {
 var strStuId = objStudentInfoEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuId, conStudentInfo.StuId); //学号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuId); //学号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuName))
 {
 if (objStudentInfoEN.StuName !=  null)
 {
 var strStuName = objStudentInfoEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuName, conStudentInfo.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuName); //姓名
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdPolitics))
 {
 if (objStudentInfoEN.IdPolitics !=  null)
 {
 var strIdPolitics = objStudentInfoEN.IdPolitics.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPolitics, conStudentInfo.IdPolitics); //政治面貌流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdPolitics); //政治面貌流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdSex))
 {
 if (objStudentInfoEN.IdSex !=  null)
 {
 var strIdSex = objStudentInfoEN.IdSex.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSex, conStudentInfo.IdSex); //性别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdSex); //性别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdEthnic))
 {
 if (objStudentInfoEN.IdEthnic !=  null)
 {
 var strIdEthnic = objStudentInfoEN.IdEthnic.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEthnic, conStudentInfo.IdEthnic); //民族流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdEthnic); //民族流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdUniZone))
 {
 if (objStudentInfoEN.IdUniZone !=  null)
 {
 var strIdUniZone = objStudentInfoEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conStudentInfo.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdUniZone); //校区流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdStuType))
 {
 if (objStudentInfoEN.IdStuType !=  null)
 {
 var strIdStuType = objStudentInfoEN.IdStuType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStuType, conStudentInfo.IdStuType); //学生类别流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdStuType); //学生类别流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzCollege))
 {
 if (objStudentInfoEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objStudentInfoEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conStudentInfo.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdXzCollege); //学院流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdXzMajor))
 {
 if (objStudentInfoEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objStudentInfoEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, conStudentInfo.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdXzMajor); //专业流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGradeBase))
 {
 if (objStudentInfoEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objStudentInfoEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conStudentInfo.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdGradeBase); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdGrade))
 {
 if (objStudentInfoEN.IdGrade !=  null)
 {
 var strIdGrade = objStudentInfoEN.IdGrade.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGrade, conStudentInfo.IdGrade); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdGrade); //年级流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdAdminCls))
 {
 if (objStudentInfoEN.IdAdminCls !=  null)
 {
 var strIdAdminCls = objStudentInfoEN.IdAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdAdminCls, conStudentInfo.IdAdminCls); //行政班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdAdminCls); //行政班流水号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Birthday))
 {
 if (objStudentInfoEN.Birthday !=  null)
 {
 var strBirthday = objStudentInfoEN.Birthday.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBirthday, conStudentInfo.Birthday); //出生日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Birthday); //出生日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.NativePlace))
 {
 if (objStudentInfoEN.NativePlace !=  null)
 {
 var strNativePlace = objStudentInfoEN.NativePlace.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNativePlace, conStudentInfo.NativePlace); //籍贯
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.NativePlace); //籍贯
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Duty))
 {
 if (objStudentInfoEN.Duty !=  null)
 {
 var strDuty = objStudentInfoEN.Duty.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDuty, conStudentInfo.Duty); //职位
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Duty); //职位
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo))
 {
 if (objStudentInfoEN.IdCardNo !=  null)
 {
 var strIdCardNo = objStudentInfoEN.IdCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo, conStudentInfo.IdCardNo); //身份证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdCardNo); //身份证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.StuCardNo))
 {
 if (objStudentInfoEN.StuCardNo !=  null)
 {
 var strStuCardNo = objStudentInfoEN.StuCardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuCardNo, conStudentInfo.StuCardNo); //学生证号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.StuCardNo); //学生证号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.LiveAddress))
 {
 if (objStudentInfoEN.LiveAddress !=  null)
 {
 var strLiveAddress = objStudentInfoEN.LiveAddress.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLiveAddress, conStudentInfo.LiveAddress); //居住地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.LiveAddress); //居住地址
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.HomePhone))
 {
 if (objStudentInfoEN.HomePhone !=  null)
 {
 var strHomePhone = objStudentInfoEN.HomePhone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHomePhone, conStudentInfo.HomePhone); //住宅电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.HomePhone); //住宅电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IdCardNo2))
 {
 if (objStudentInfoEN.IdCardNo2 !=  null)
 {
 var strIdCardNo2 = objStudentInfoEN.IdCardNo2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCardNo2, conStudentInfo.IdCardNo2); //内卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.IdCardNo2); //内卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.CardNo))
 {
 if (objStudentInfoEN.CardNo !=  null)
 {
 var strCardNo = objStudentInfoEN.CardNo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCardNo, conStudentInfo.CardNo); //卡号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.CardNo); //卡号
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsGpUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsGpUser == true?"1":"0", conStudentInfo.IsGpUser); //是否Gp用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLocalUser))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsLocalUser == true?"1":"0", conStudentInfo.IsLocalUser); //是否本地用户
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsLeaved))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsLeaved == true?"1":"0", conStudentInfo.IsLeaved); //是否离开
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserId))
 {
 if (objStudentInfoEN.UserId !=  null)
 {
 var strUserId = objStudentInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conStudentInfo.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UserId); //用户ID
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UserType))
 {
 if (objStudentInfoEN.UserType !=  null)
 {
 var strUserType = objStudentInfoEN.UserType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserType, conStudentInfo.UserType); //用户类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UserType); //用户类型
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.EnrollmentDate))
 {
 if (objStudentInfoEN.EnrollmentDate !=  null)
 {
 var strEnrollmentDate = objStudentInfoEN.EnrollmentDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEnrollmentDate, conStudentInfo.EnrollmentDate); //入校日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.EnrollmentDate); //入校日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PostCode))
 {
 if (objStudentInfoEN.PostCode !=  null)
 {
 var strPostCode = objStudentInfoEN.PostCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPostCode, conStudentInfo.PostCode); //邮编
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.PostCode); //邮编
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Email))
 {
 if (objStudentInfoEN.Email !=  null)
 {
 var strEmail = objStudentInfoEN.Email.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEmail, conStudentInfo.Email); //电子邮箱
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Email); //电子邮箱
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.IsMessage))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objStudentInfoEN.IsMessage == true?"1":"0", conStudentInfo.IsMessage); //IsMessage
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Microblog))
 {
 if (objStudentInfoEN.Microblog !=  null)
 {
 var strMicroblog = objStudentInfoEN.Microblog.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMicroblog, conStudentInfo.Microblog); //Microblog
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Microblog); //Microblog
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.PhoneNumber))
 {
 if (objStudentInfoEN.PhoneNumber !=  null)
 {
 var strPhoneNumber = objStudentInfoEN.PhoneNumber.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPhoneNumber, conStudentInfo.PhoneNumber); //电话
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.PhoneNumber); //电话
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Headphoto))
 {
 if (objStudentInfoEN.Headphoto !=  null)
 {
 var strHeadphoto = objStudentInfoEN.Headphoto.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strHeadphoto, conStudentInfo.Headphoto); //Headphoto
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Headphoto); //Headphoto
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.QQ))
 {
 if (objStudentInfoEN.QQ !=  null)
 {
 var strQQ = objStudentInfoEN.QQ.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQQ, conStudentInfo.QQ); //QQ
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.QQ); //QQ
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.RegisterPassword))
 {
 if (objStudentInfoEN.RegisterPassword !=  null)
 {
 var strRegisterPassword = objStudentInfoEN.RegisterPassword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRegisterPassword, conStudentInfo.RegisterPassword); //RegisterPassword
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.RegisterPassword); //RegisterPassword
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdDate))
 {
 if (objStudentInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objStudentInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conStudentInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UpdDate); //修改日期
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.UpdUser))
 {
 if (objStudentInfoEN.UpdUser !=  null)
 {
 var strUpdUser = objStudentInfoEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conStudentInfo.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.UpdUser); //修改人
 }
 }
 
 if (objStudentInfoEN.IsUpdated(conStudentInfo.Memo))
 {
 if (objStudentInfoEN.Memo !=  null)
 {
 var strMemo = objStudentInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conStudentInfo.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conStudentInfo.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdStudentInfo = '{0}'", objStudentInfoEN.IdStudentInfo); 
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
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdStudentInfo) 
{
CheckPrimaryKey(strIdStudentInfo);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdStudentInfo,
};
 objSQL.ExecSP("StudentInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdStudentInfo, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdStudentInfo);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
//删除StudentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from StudentInfo where IdStudentInfo = " + "'"+ strIdStudentInfo+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelStudentInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
//删除StudentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from StudentInfo where IdStudentInfo in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdStudentInfo">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdStudentInfo) 
{
CheckPrimaryKey(strIdStudentInfo);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
//删除StudentInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from StudentInfo where IdStudentInfo = " + "'"+ strIdStudentInfo+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelStudentInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsStudentInfoDA: DelStudentInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from StudentInfo where " + strCondition ;
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
public bool DelStudentInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsStudentInfoDA: DelStudentInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from StudentInfo where " + strCondition ;
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
 /// <param name = "objStudentInfoENS">源对象</param>
 /// <param name = "objStudentInfoENT">目标对象</param>
public void CopyTo(clsStudentInfoEN objStudentInfoENS, clsStudentInfoEN objStudentInfoENT)
{
objStudentInfoENT.IdStudentInfo = objStudentInfoENS.IdStudentInfo; //学生流水号
objStudentInfoENT.StuId = objStudentInfoENS.StuId; //学号
objStudentInfoENT.StuName = objStudentInfoENS.StuName; //姓名
objStudentInfoENT.IdPolitics = objStudentInfoENS.IdPolitics; //政治面貌流水号
objStudentInfoENT.IdSex = objStudentInfoENS.IdSex; //性别流水号
objStudentInfoENT.IdEthnic = objStudentInfoENS.IdEthnic; //民族流水号
objStudentInfoENT.IdUniZone = objStudentInfoENS.IdUniZone; //校区流水号
objStudentInfoENT.IdStuType = objStudentInfoENS.IdStuType; //学生类别流水号
objStudentInfoENT.IdXzCollege = objStudentInfoENS.IdXzCollege; //学院流水号
objStudentInfoENT.IdXzMajor = objStudentInfoENS.IdXzMajor; //专业流水号
objStudentInfoENT.IdGradeBase = objStudentInfoENS.IdGradeBase; //年级流水号
objStudentInfoENT.IdGrade = objStudentInfoENS.IdGrade; //年级流水号
objStudentInfoENT.IdAdminCls = objStudentInfoENS.IdAdminCls; //行政班流水号
objStudentInfoENT.Birthday = objStudentInfoENS.Birthday; //出生日期
objStudentInfoENT.NativePlace = objStudentInfoENS.NativePlace; //籍贯
objStudentInfoENT.Duty = objStudentInfoENS.Duty; //职位
objStudentInfoENT.IdCardNo = objStudentInfoENS.IdCardNo; //身份证号
objStudentInfoENT.StuCardNo = objStudentInfoENS.StuCardNo; //学生证号
objStudentInfoENT.LiveAddress = objStudentInfoENS.LiveAddress; //居住地址
objStudentInfoENT.HomePhone = objStudentInfoENS.HomePhone; //住宅电话
objStudentInfoENT.IdCardNo2 = objStudentInfoENS.IdCardNo2; //内卡号
objStudentInfoENT.CardNo = objStudentInfoENS.CardNo; //卡号
objStudentInfoENT.IsGpUser = objStudentInfoENS.IsGpUser; //是否Gp用户
objStudentInfoENT.IsLocalUser = objStudentInfoENS.IsLocalUser; //是否本地用户
objStudentInfoENT.IsLeaved = objStudentInfoENS.IsLeaved; //是否离开
objStudentInfoENT.UserId = objStudentInfoENS.UserId; //用户ID
objStudentInfoENT.UserType = objStudentInfoENS.UserType; //用户类型
objStudentInfoENT.EnrollmentDate = objStudentInfoENS.EnrollmentDate; //入校日期
objStudentInfoENT.PostCode = objStudentInfoENS.PostCode; //邮编
objStudentInfoENT.Email = objStudentInfoENS.Email; //电子邮箱
objStudentInfoENT.IsMessage = objStudentInfoENS.IsMessage; //IsMessage
objStudentInfoENT.Microblog = objStudentInfoENS.Microblog; //Microblog
objStudentInfoENT.PhoneNumber = objStudentInfoENS.PhoneNumber; //电话
objStudentInfoENT.Headphoto = objStudentInfoENS.Headphoto; //Headphoto
objStudentInfoENT.QQ = objStudentInfoENS.QQ; //QQ
objStudentInfoENT.RegisterPassword = objStudentInfoENS.RegisterPassword; //RegisterPassword
objStudentInfoENT.UpdDate = objStudentInfoENS.UpdDate; //修改日期
objStudentInfoENT.UpdUser = objStudentInfoENS.UpdUser; //修改人
objStudentInfoENT.Memo = objStudentInfoENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsStudentInfoEN objStudentInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objStudentInfoEN.StuId, conStudentInfo.StuId);
clsCheckSql.CheckFieldNotNull(objStudentInfoEN.StuName, conStudentInfo.StuName);
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdStudentInfo, 8, conStudentInfo.IdStudentInfo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuId, 20, conStudentInfo.StuId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuName, 50, conStudentInfo.StuName);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdPolitics, 4, conStudentInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdSex, 4, conStudentInfo.IdSex);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdEthnic, 4, conStudentInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdUniZone, 4, conStudentInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdStuType, 4, conStudentInfo.IdStuType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzCollege, 4, conStudentInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzMajor, 8, conStudentInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGradeBase, 4, conStudentInfo.IdGradeBase);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGrade, 4, conStudentInfo.IdGrade);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdAdminCls, 8, conStudentInfo.IdAdminCls);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Birthday, 8, conStudentInfo.Birthday);
clsCheckSql.CheckFieldLen(objStudentInfoEN.NativePlace, 200, conStudentInfo.NativePlace);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Duty, 30, conStudentInfo.Duty);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo, 20, conStudentInfo.IdCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuCardNo, 20, conStudentInfo.StuCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.LiveAddress, 200, conStudentInfo.LiveAddress);
clsCheckSql.CheckFieldLen(objStudentInfoEN.HomePhone, 20, conStudentInfo.HomePhone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo2, 20, conStudentInfo.IdCardNo2);
clsCheckSql.CheckFieldLen(objStudentInfoEN.CardNo, 18, conStudentInfo.CardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserId, 18, conStudentInfo.UserId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserType, 50, conStudentInfo.UserType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.EnrollmentDate, 8, conStudentInfo.EnrollmentDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PostCode, 6, conStudentInfo.PostCode);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Email, 100, conStudentInfo.Email);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Microblog, 200, conStudentInfo.Microblog);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PhoneNumber, 15, conStudentInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Headphoto, 500, conStudentInfo.Headphoto);
clsCheckSql.CheckFieldLen(objStudentInfoEN.QQ, 100, conStudentInfo.QQ);
clsCheckSql.CheckFieldLen(objStudentInfoEN.RegisterPassword, 30, conStudentInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdDate, 20, conStudentInfo.UpdDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdUser, 20, conStudentInfo.UpdUser);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Memo, 1000, conStudentInfo.Memo);
//检查字段外键固定长度
 objStudentInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsStudentInfoEN objStudentInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuId, 20, conStudentInfo.StuId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuName, 50, conStudentInfo.StuName);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdPolitics, 4, conStudentInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdSex, 4, conStudentInfo.IdSex);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdEthnic, 4, conStudentInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdUniZone, 4, conStudentInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdStuType, 4, conStudentInfo.IdStuType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzCollege, 4, conStudentInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzMajor, 8, conStudentInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGradeBase, 4, conStudentInfo.IdGradeBase);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGrade, 4, conStudentInfo.IdGrade);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdAdminCls, 8, conStudentInfo.IdAdminCls);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Birthday, 8, conStudentInfo.Birthday);
clsCheckSql.CheckFieldLen(objStudentInfoEN.NativePlace, 200, conStudentInfo.NativePlace);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Duty, 30, conStudentInfo.Duty);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo, 20, conStudentInfo.IdCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuCardNo, 20, conStudentInfo.StuCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.LiveAddress, 200, conStudentInfo.LiveAddress);
clsCheckSql.CheckFieldLen(objStudentInfoEN.HomePhone, 20, conStudentInfo.HomePhone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo2, 20, conStudentInfo.IdCardNo2);
clsCheckSql.CheckFieldLen(objStudentInfoEN.CardNo, 18, conStudentInfo.CardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserId, 18, conStudentInfo.UserId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserType, 50, conStudentInfo.UserType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.EnrollmentDate, 8, conStudentInfo.EnrollmentDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PostCode, 6, conStudentInfo.PostCode);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Email, 100, conStudentInfo.Email);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Microblog, 200, conStudentInfo.Microblog);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PhoneNumber, 15, conStudentInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Headphoto, 500, conStudentInfo.Headphoto);
clsCheckSql.CheckFieldLen(objStudentInfoEN.QQ, 100, conStudentInfo.QQ);
clsCheckSql.CheckFieldLen(objStudentInfoEN.RegisterPassword, 30, conStudentInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdDate, 20, conStudentInfo.UpdDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdUser, 20, conStudentInfo.UpdUser);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Memo, 1000, conStudentInfo.Memo);
//检查外键字段长度
 objStudentInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsStudentInfoEN objStudentInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdStudentInfo, 8, conStudentInfo.IdStudentInfo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuId, 20, conStudentInfo.StuId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuName, 50, conStudentInfo.StuName);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdPolitics, 4, conStudentInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdSex, 4, conStudentInfo.IdSex);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdEthnic, 4, conStudentInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdUniZone, 4, conStudentInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdStuType, 4, conStudentInfo.IdStuType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzCollege, 4, conStudentInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdXzMajor, 8, conStudentInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGradeBase, 4, conStudentInfo.IdGradeBase);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdGrade, 4, conStudentInfo.IdGrade);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdAdminCls, 8, conStudentInfo.IdAdminCls);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Birthday, 8, conStudentInfo.Birthday);
clsCheckSql.CheckFieldLen(objStudentInfoEN.NativePlace, 200, conStudentInfo.NativePlace);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Duty, 30, conStudentInfo.Duty);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo, 20, conStudentInfo.IdCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.StuCardNo, 20, conStudentInfo.StuCardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.LiveAddress, 200, conStudentInfo.LiveAddress);
clsCheckSql.CheckFieldLen(objStudentInfoEN.HomePhone, 20, conStudentInfo.HomePhone);
clsCheckSql.CheckFieldLen(objStudentInfoEN.IdCardNo2, 20, conStudentInfo.IdCardNo2);
clsCheckSql.CheckFieldLen(objStudentInfoEN.CardNo, 18, conStudentInfo.CardNo);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserId, 18, conStudentInfo.UserId);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UserType, 50, conStudentInfo.UserType);
clsCheckSql.CheckFieldLen(objStudentInfoEN.EnrollmentDate, 8, conStudentInfo.EnrollmentDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PostCode, 6, conStudentInfo.PostCode);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Email, 100, conStudentInfo.Email);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Microblog, 200, conStudentInfo.Microblog);
clsCheckSql.CheckFieldLen(objStudentInfoEN.PhoneNumber, 15, conStudentInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Headphoto, 500, conStudentInfo.Headphoto);
clsCheckSql.CheckFieldLen(objStudentInfoEN.QQ, 100, conStudentInfo.QQ);
clsCheckSql.CheckFieldLen(objStudentInfoEN.RegisterPassword, 30, conStudentInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdDate, 20, conStudentInfo.UpdDate);
clsCheckSql.CheckFieldLen(objStudentInfoEN.UpdUser, 20, conStudentInfo.UpdUser);
clsCheckSql.CheckFieldLen(objStudentInfoEN.Memo, 1000, conStudentInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdStudentInfo, conStudentInfo.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.StuId, conStudentInfo.StuId);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.StuName, conStudentInfo.StuName);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdPolitics, conStudentInfo.IdPolitics);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdSex, conStudentInfo.IdSex);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdEthnic, conStudentInfo.IdEthnic);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdUniZone, conStudentInfo.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdStuType, conStudentInfo.IdStuType);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdXzCollege, conStudentInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdXzMajor, conStudentInfo.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdGradeBase, conStudentInfo.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdGrade, conStudentInfo.IdGrade);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdAdminCls, conStudentInfo.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Birthday, conStudentInfo.Birthday);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.NativePlace, conStudentInfo.NativePlace);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Duty, conStudentInfo.Duty);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdCardNo, conStudentInfo.IdCardNo);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.StuCardNo, conStudentInfo.StuCardNo);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.LiveAddress, conStudentInfo.LiveAddress);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.HomePhone, conStudentInfo.HomePhone);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.IdCardNo2, conStudentInfo.IdCardNo2);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.CardNo, conStudentInfo.CardNo);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.UserId, conStudentInfo.UserId);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.UserType, conStudentInfo.UserType);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.EnrollmentDate, conStudentInfo.EnrollmentDate);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.PostCode, conStudentInfo.PostCode);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Email, conStudentInfo.Email);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Microblog, conStudentInfo.Microblog);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.PhoneNumber, conStudentInfo.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Headphoto, conStudentInfo.Headphoto);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.QQ, conStudentInfo.QQ);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.RegisterPassword, conStudentInfo.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.UpdDate, conStudentInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.UpdUser, conStudentInfo.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objStudentInfoEN.Memo, conStudentInfo.Memo);
//检查外键字段长度
 objStudentInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--StudentInfo(学生),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objStudentInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsStudentInfoEN objStudentInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and StuId = '{0}'", objStudentInfoEN.StuId);
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsStudentInfoEN._CurrTabName);
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsStudentInfoEN._CurrTabName, strCondition);
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
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
 objSQL = clsStudentInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}