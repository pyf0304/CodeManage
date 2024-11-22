
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeacherInfoDA
 表名:vTeacherInfo(01120094)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:19:55
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
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
 /// v教师(vTeacherInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeacherInfoDA : clsCommBase4DA
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
 return clsvTeacherInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeacherInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeacherInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeacherInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeacherInfoEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vTeacherInfo中,检查关键字,长度不正确!(clsvTeacherInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeacher)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeacherInfo中,关键字不能为空 或 null!(clsvTeacherInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeacher);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeacherInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeacherInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable_vTeacherInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeacherInfo.* from vTeacherInfo Left Join {1} on {2} where {3} and vTeacherInfo.IdTeacher not in (Select top {5} vTeacherInfo.IdTeacher from vTeacherInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1} and IdTeacher not in (Select top {2} IdTeacher from vTeacherInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1} and IdTeacher not in (Select top {3} IdTeacher from vTeacherInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeacherInfo.* from vTeacherInfo Left Join {1} on {2} where {3} and vTeacherInfo.IdTeacher not in (Select top {5} vTeacherInfo.IdTeacher from vTeacherInfo Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1} and IdTeacher not in (Select top {2} IdTeacher from vTeacherInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeacherInfo where {1} and IdTeacher not in (Select top {3} IdTeacher from vTeacherInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeacherInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeacherInfoDA:GetObjLst)", objException.Message));
}
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = TransNullToBool(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = TransNullToBool(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = TransNullToBool(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = TransNullToBool(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeacherInfoDA: GetObjLst)", objException.Message));
}
objvTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeacherInfoEN);
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
public List<clsvTeacherInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeacherInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeacherInfoEN> arrObjLst = new List<clsvTeacherInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = TransNullToBool(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = TransNullToBool(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = TransNullToBool(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = TransNullToBool(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeacherInfoDA: GetObjLst)", objException.Message));
}
objvTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeacherInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeacherInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeacherInfo(ref clsvTeacherInfoEN objvTeacherInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where IdTeacher = " + "'"+ objvTeacherInfoEN.IdTeacher+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeacherInfoEN.IdTeacher = objDT.Rows[0][convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeacherInfoEN.TeacherId = objDT.Rows[0][convTeacherInfo.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvTeacherInfoEN.TeacherName = objDT.Rows[0][convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeacherInfoEN.IdSex = objDT.Rows[0][convTeacherInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.SexDesc = objDT.Rows[0][convTeacherInfo.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeacherInfoEN.IdSchoolPs = objDT.Rows[0][convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.IdDisciplinePs = objDT.Rows[0][convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.IdUniZone = objDT.Rows[0][convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.UniZoneDesc = objDT.Rows[0][convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeacherInfoEN.IdEthnic = objDT.Rows[0][convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.EthnicName = objDT.Rows[0][convTeacherInfo.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdPolitics = objDT.Rows[0][convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.PoliticsName = objDT.Rows[0][convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdAdminGrade = objDT.Rows[0][convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.AdminGradeDesc = objDT.Rows[0][convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdProfGrade = objDT.Rows[0][convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.ProfenssionalGradeName = objDT.Rows[0][convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdQualif = objDT.Rows[0][convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.QualifDesc = objDT.Rows[0][convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IdDegree = objDT.Rows[0][convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.DegreeName = objDT.Rows[0][convTeacherInfo.DegreeName].ToString().Trim(); //学位名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdStaffType = objDT.Rows[0][convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.StaffTypeName = objDT.Rows[0][convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IdProvince = objDT.Rows[0][convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.ProvinceName = objDT.Rows[0][convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.CitizenId = objDT.Rows[0][convTeacherInfo.CitizenId].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:25,是否可空:True)
 objvTeacherInfoEN.CardNo = objDT.Rows[0][convTeacherInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeacherInfoEN.Birthday = objDT.Rows[0][convTeacherInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.GraduationMajor = objDT.Rows[0][convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业(字段类型:varchar,字段长度:40,是否可空:True)
 objvTeacherInfoEN.TelNo = objDT.Rows[0][convTeacherInfo.TelNo].ToString().Trim(); //电话(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeacherInfoEN.Email = objDT.Rows[0][convTeacherInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.WebSite = objDT.Rows[0][convTeacherInfo.WebSite].ToString().Trim(); //个人主页(字段类型:varchar,字段长度:60,是否可空:True)
 objvTeacherInfoEN.PersonBlog = objDT.Rows[0][convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客(字段类型:varchar,字段长度:60,是否可空:True)
 objvTeacherInfoEN.EntryDate = objDT.Rows[0][convTeacherInfo.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.Offed = TransNullToBool(objDT.Rows[0][convTeacherInfo.Offed].ToString().Trim()); //是否离校(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsAvconUser = TransNullToBool(objDT.Rows[0][convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsGpUser = TransNullToBool(objDT.Rows[0][convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsLocalUser = TransNullToBool(objDT.Rows[0][convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.FromUnit = objDT.Rows[0][convTeacherInfo.FromUnit].ToString().Trim(); //来自单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.Memo = objDT.Rows[0][convTeacherInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeacherInfoEN.IdXzCollege = objDT.Rows[0][convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.CollegeId = objDT.Rows[0][convTeacherInfo.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeacherInfoEN.CollegeName = objDT.Rows[0][convTeacherInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeacherInfoEN.CollegeNameA = objDT.Rows[0][convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeacherInfoEN.IdXzMajor = objDT.Rows[0][convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeacherInfoEN.EntryDay = objDT.Rows[0][convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdPhoto = objDT.Rows[0][convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdReligion = objDT.Rows[0][convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.ReligionName = objDT.Rows[0][convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IsMessage = TransNullToBool(objDT.Rows[0][convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.Microblog = objDT.Rows[0][convTeacherInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeacherInfoEN.ModifyUserId = objDT.Rows[0][convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeacherInfoEN.OffedBak = TransNullToBool(objDT.Rows[0][convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.PhoneNumber = objDT.Rows[0][convTeacherInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvTeacherInfoEN.QQ = objDT.Rows[0][convTeacherInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.TeachIdCollege = objDT.Rows[0][convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College(字段类型:varchar,字段长度:6,是否可空:True)
 objvTeacherInfoEN.TeachIdMajor = objDT.Rows[0][convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.Tel = objDT.Rows[0][convTeacherInfo.Tel].ToString().Trim(); //Tel(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeacherInfoEN.ModifyDate = objDT.Rows[0][convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeacherInfoEN.RegisterPassword = objDT.Rows[0][convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.EntryYear = objDT.Rows[0][convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdCardNo = objDT.Rows[0][convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeacherInfoDA: GetvTeacherInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeacher">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeacherInfoEN GetObjByIdTeacher(string strIdTeacher)
{
CheckPrimaryKey(strIdTeacher);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where IdTeacher = " + "'"+ strIdTeacher+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
 objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称(字段类型:varchar,字段长度:20,是否可空:False)
 objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:25,是否可空:True)
 objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业(字段类型:varchar,字段长度:40,是否可空:True)
 objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页(字段类型:varchar,字段长度:60,是否可空:True)
 objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客(字段类型:varchar,字段长度:60,是否可空:True)
 objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.Offed = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsAvconUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.IsLocalUser = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion(字段类型:char,字段长度:4,是否可空:True)
 objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.IsMessage = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvTeacherInfoEN.OffedBak = clsEntityBase2.TransNullToBool_S(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak(字段类型:bit,字段长度:1,是否可空:True)
 objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话(字段类型:varchar,字段长度:15,是否可空:True)
 objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College(字段类型:varchar,字段长度:6,是否可空:True)
 objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major(字段类型:char,字段长度:8,是否可空:True)
 objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear(字段类型:varchar,字段长度:8,是否可空:True)
 objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeacherInfoDA: GetObjByIdTeacher)", objException.Message));
}
return objvTeacherInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeacherInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeacherInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
strSQL = "Select * from vTeacherInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN()
{
IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(), //教师姓名
IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(), //性别流水号
SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(), //性别名称
IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(), //学校流水号
IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(), //学科流水号
IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(), //校区流水号
UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(), //校区名称
IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(), //民族流水号
EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(), //民族名称
IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(), //政治面貌流水号
PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(), //政治面貌
IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(), //行政职务流水号
AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(), //行政职务描述
IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(), //专业职称流水号
ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(), //专业职称
IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(), //学历流水号
QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(), //QualifDesc
IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(), //学位流水号
DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(), //学位名称
IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(), //职工类型流水号
StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(), //职工类型名称
IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(), //省份流水号
ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(), //ProvinceName
CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(), //身份证号
CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(), //卡号
Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(), //出生日期
GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(), //毕业专业
TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(), //电话
Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(), //电子邮箱
WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(), //个人主页
PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(), //个人博客
EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(), //进校日期
Offed = TransNullToBool(objRow[convTeacherInfo.Offed].ToString().Trim()), //是否离校
IsAvconUser = TransNullToBool(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()), //IsAvconUser
IsGpUser = TransNullToBool(objRow[convTeacherInfo.IsGpUser].ToString().Trim()), //是否Gp用户
IsLocalUser = TransNullToBool(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()), //是否本地用户
FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(), //来自单位
Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(), //备注
IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(), //专业流水号
EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(), //EntryDay
IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(), //id_Photo
IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(), //id_Religion
ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(), //ReligionName
IsMessage = TransNullToBool(objRow[convTeacherInfo.IsMessage].ToString().Trim()), //IsMessage
Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(), //Microblog
ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(), //修改人
OffedBak = TransNullToBool(objRow[convTeacherInfo.OffedBak].ToString().Trim()), //OffedBak
PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(), //电话
QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(), //QQ
TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(), //Teach_id_College
TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(), //Teach_id_Major
Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(), //Tel
ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(), //修改日期
RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(), //RegisterPassword
EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(), //EntryYear
IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim() //身份证号
};
objvTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeacherInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeacherInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeacherInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = TransNullToBool(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = TransNullToBool(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = TransNullToBool(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = TransNullToBool(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeacherInfoDA: GetObjByDataRowvTeacherInfo)", objException.Message));
}
objvTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeacherInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeacherInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeacherInfoEN objvTeacherInfoEN = new clsvTeacherInfoEN();
try
{
objvTeacherInfoEN.IdTeacher = objRow[convTeacherInfo.IdTeacher].ToString().Trim(); //教师流水号
objvTeacherInfoEN.TeacherId = objRow[convTeacherInfo.TeacherId].ToString().Trim(); //教师工号
objvTeacherInfoEN.TeacherName = objRow[convTeacherInfo.TeacherName].ToString().Trim(); //教师姓名
objvTeacherInfoEN.IdSex = objRow[convTeacherInfo.IdSex].ToString().Trim(); //性别流水号
objvTeacherInfoEN.SexDesc = objRow[convTeacherInfo.SexDesc] == DBNull.Value ? null : objRow[convTeacherInfo.SexDesc].ToString().Trim(); //性别名称
objvTeacherInfoEN.IdSchoolPs = objRow[convTeacherInfo.IdSchoolPs] == DBNull.Value ? null : objRow[convTeacherInfo.IdSchoolPs].ToString().Trim(); //学校流水号
objvTeacherInfoEN.IdDisciplinePs = objRow[convTeacherInfo.IdDisciplinePs] == DBNull.Value ? null : objRow[convTeacherInfo.IdDisciplinePs].ToString().Trim(); //学科流水号
objvTeacherInfoEN.IdUniZone = objRow[convTeacherInfo.IdUniZone].ToString().Trim(); //校区流水号
objvTeacherInfoEN.UniZoneDesc = objRow[convTeacherInfo.UniZoneDesc] == DBNull.Value ? null : objRow[convTeacherInfo.UniZoneDesc].ToString().Trim(); //校区名称
objvTeacherInfoEN.IdEthnic = objRow[convTeacherInfo.IdEthnic].ToString().Trim(); //民族流水号
objvTeacherInfoEN.EthnicName = objRow[convTeacherInfo.EthnicName] == DBNull.Value ? null : objRow[convTeacherInfo.EthnicName].ToString().Trim(); //民族名称
objvTeacherInfoEN.IdPolitics = objRow[convTeacherInfo.IdPolitics].ToString().Trim(); //政治面貌流水号
objvTeacherInfoEN.PoliticsName = objRow[convTeacherInfo.PoliticsName].ToString().Trim(); //政治面貌
objvTeacherInfoEN.IdAdminGrade = objRow[convTeacherInfo.IdAdminGrade].ToString().Trim(); //行政职务流水号
objvTeacherInfoEN.AdminGradeDesc = objRow[convTeacherInfo.AdminGradeDesc].ToString().Trim(); //行政职务描述
objvTeacherInfoEN.IdProfGrade = objRow[convTeacherInfo.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeacherInfoEN.ProfenssionalGradeName = objRow[convTeacherInfo.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeacherInfoEN.IdQualif = objRow[convTeacherInfo.IdQualif].ToString().Trim(); //学历流水号
objvTeacherInfoEN.QualifDesc = objRow[convTeacherInfo.QualifDesc] == DBNull.Value ? null : objRow[convTeacherInfo.QualifDesc].ToString().Trim(); //QualifDesc
objvTeacherInfoEN.IdDegree = objRow[convTeacherInfo.IdDegree].ToString().Trim(); //学位流水号
objvTeacherInfoEN.DegreeName = objRow[convTeacherInfo.DegreeName].ToString().Trim(); //学位名称
objvTeacherInfoEN.IdStaffType = objRow[convTeacherInfo.IdStaffType].ToString().Trim(); //职工类型流水号
objvTeacherInfoEN.StaffTypeName = objRow[convTeacherInfo.StaffTypeName] == DBNull.Value ? null : objRow[convTeacherInfo.StaffTypeName].ToString().Trim(); //职工类型名称
objvTeacherInfoEN.IdProvince = objRow[convTeacherInfo.IdProvince].ToString().Trim(); //省份流水号
objvTeacherInfoEN.ProvinceName = objRow[convTeacherInfo.ProvinceName] == DBNull.Value ? null : objRow[convTeacherInfo.ProvinceName].ToString().Trim(); //ProvinceName
objvTeacherInfoEN.CitizenId = objRow[convTeacherInfo.CitizenId] == DBNull.Value ? null : objRow[convTeacherInfo.CitizenId].ToString().Trim(); //身份证号
objvTeacherInfoEN.CardNo = objRow[convTeacherInfo.CardNo] == DBNull.Value ? null : objRow[convTeacherInfo.CardNo].ToString().Trim(); //卡号
objvTeacherInfoEN.Birthday = objRow[convTeacherInfo.Birthday] == DBNull.Value ? null : objRow[convTeacherInfo.Birthday].ToString().Trim(); //出生日期
objvTeacherInfoEN.GraduationMajor = objRow[convTeacherInfo.GraduationMajor] == DBNull.Value ? null : objRow[convTeacherInfo.GraduationMajor].ToString().Trim(); //毕业专业
objvTeacherInfoEN.TelNo = objRow[convTeacherInfo.TelNo] == DBNull.Value ? null : objRow[convTeacherInfo.TelNo].ToString().Trim(); //电话
objvTeacherInfoEN.Email = objRow[convTeacherInfo.Email] == DBNull.Value ? null : objRow[convTeacherInfo.Email].ToString().Trim(); //电子邮箱
objvTeacherInfoEN.WebSite = objRow[convTeacherInfo.WebSite] == DBNull.Value ? null : objRow[convTeacherInfo.WebSite].ToString().Trim(); //个人主页
objvTeacherInfoEN.PersonBlog = objRow[convTeacherInfo.PersonBlog] == DBNull.Value ? null : objRow[convTeacherInfo.PersonBlog].ToString().Trim(); //个人博客
objvTeacherInfoEN.EntryDate = objRow[convTeacherInfo.EntryDate] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDate].ToString().Trim(); //进校日期
objvTeacherInfoEN.Offed = TransNullToBool(objRow[convTeacherInfo.Offed].ToString().Trim()); //是否离校
objvTeacherInfoEN.IsAvconUser = TransNullToBool(objRow[convTeacherInfo.IsAvconUser].ToString().Trim()); //IsAvconUser
objvTeacherInfoEN.IsGpUser = TransNullToBool(objRow[convTeacherInfo.IsGpUser].ToString().Trim()); //是否Gp用户
objvTeacherInfoEN.IsLocalUser = TransNullToBool(objRow[convTeacherInfo.IsLocalUser].ToString().Trim()); //是否本地用户
objvTeacherInfoEN.FromUnit = objRow[convTeacherInfo.FromUnit] == DBNull.Value ? null : objRow[convTeacherInfo.FromUnit].ToString().Trim(); //来自单位
objvTeacherInfoEN.Memo = objRow[convTeacherInfo.Memo] == DBNull.Value ? null : objRow[convTeacherInfo.Memo].ToString().Trim(); //备注
objvTeacherInfoEN.IdXzCollege = objRow[convTeacherInfo.IdXzCollege] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzCollege].ToString().Trim(); //学院流水号
objvTeacherInfoEN.CollegeId = objRow[convTeacherInfo.CollegeId] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeId].ToString().Trim(); //学院ID
objvTeacherInfoEN.CollegeName = objRow[convTeacherInfo.CollegeName].ToString().Trim(); //学院名称
objvTeacherInfoEN.CollegeNameA = objRow[convTeacherInfo.CollegeNameA] == DBNull.Value ? null : objRow[convTeacherInfo.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeacherInfoEN.IdXzMajor = objRow[convTeacherInfo.IdXzMajor] == DBNull.Value ? null : objRow[convTeacherInfo.IdXzMajor].ToString().Trim(); //专业流水号
objvTeacherInfoEN.EntryDay = objRow[convTeacherInfo.EntryDay] == DBNull.Value ? null : objRow[convTeacherInfo.EntryDay].ToString().Trim(); //EntryDay
objvTeacherInfoEN.IdPhoto = objRow[convTeacherInfo.IdPhoto] == DBNull.Value ? null : objRow[convTeacherInfo.IdPhoto].ToString().Trim(); //id_Photo
objvTeacherInfoEN.IdReligion = objRow[convTeacherInfo.IdReligion] == DBNull.Value ? null : objRow[convTeacherInfo.IdReligion].ToString().Trim(); //id_Religion
objvTeacherInfoEN.ReligionName = objRow[convTeacherInfo.ReligionName] == DBNull.Value ? null : objRow[convTeacherInfo.ReligionName].ToString().Trim(); //ReligionName
objvTeacherInfoEN.IsMessage = TransNullToBool(objRow[convTeacherInfo.IsMessage].ToString().Trim()); //IsMessage
objvTeacherInfoEN.Microblog = objRow[convTeacherInfo.Microblog] == DBNull.Value ? null : objRow[convTeacherInfo.Microblog].ToString().Trim(); //Microblog
objvTeacherInfoEN.ModifyUserId = objRow[convTeacherInfo.ModifyUserId] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyUserId].ToString().Trim(); //修改人
objvTeacherInfoEN.OffedBak = TransNullToBool(objRow[convTeacherInfo.OffedBak].ToString().Trim()); //OffedBak
objvTeacherInfoEN.PhoneNumber = objRow[convTeacherInfo.PhoneNumber] == DBNull.Value ? null : objRow[convTeacherInfo.PhoneNumber].ToString().Trim(); //电话
objvTeacherInfoEN.QQ = objRow[convTeacherInfo.QQ] == DBNull.Value ? null : objRow[convTeacherInfo.QQ].ToString().Trim(); //QQ
objvTeacherInfoEN.TeachIdCollege = objRow[convTeacherInfo.TeachIdCollege] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdCollege].ToString().Trim(); //Teach_id_College
objvTeacherInfoEN.TeachIdMajor = objRow[convTeacherInfo.TeachIdMajor] == DBNull.Value ? null : objRow[convTeacherInfo.TeachIdMajor].ToString().Trim(); //Teach_id_Major
objvTeacherInfoEN.Tel = objRow[convTeacherInfo.Tel] == DBNull.Value ? null : objRow[convTeacherInfo.Tel].ToString().Trim(); //Tel
objvTeacherInfoEN.ModifyDate = objRow[convTeacherInfo.ModifyDate] == DBNull.Value ? null : objRow[convTeacherInfo.ModifyDate].ToString().Trim(); //修改日期
objvTeacherInfoEN.RegisterPassword = objRow[convTeacherInfo.RegisterPassword] == DBNull.Value ? null : objRow[convTeacherInfo.RegisterPassword].ToString().Trim(); //RegisterPassword
objvTeacherInfoEN.EntryYear = objRow[convTeacherInfo.EntryYear] == DBNull.Value ? null : objRow[convTeacherInfo.EntryYear].ToString().Trim(); //EntryYear
objvTeacherInfoEN.IdCardNo = objRow[convTeacherInfo.IdCardNo] == DBNull.Value ? null : objRow[convTeacherInfo.IdCardNo].ToString().Trim(); //身份证号
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeacherInfoDA: GetObjByDataRow)", objException.Message));
}
objvTeacherInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeacherInfoEN;
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
objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeacherInfoEN._CurrTabName, convTeacherInfo.IdTeacher, 8, "");
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
objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeacherInfoEN._CurrTabName, convTeacherInfo.IdTeacher, 8, strPrefix);
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeacher from vTeacherInfo where " + strCondition;
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeacher from vTeacherInfo where " + strCondition;
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeacherInfo", "IdTeacher = " + "'"+ strIdTeacher+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeacherInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeacherInfo", strCondition))
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
objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeacherInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeacherInfoENS">源对象</param>
 /// <param name = "objvTeacherInfoENT">目标对象</param>
public void CopyTo(clsvTeacherInfoEN objvTeacherInfoENS, clsvTeacherInfoEN objvTeacherInfoENT)
{
objvTeacherInfoENT.IdTeacher = objvTeacherInfoENS.IdTeacher; //教师流水号
objvTeacherInfoENT.TeacherId = objvTeacherInfoENS.TeacherId; //教师工号
objvTeacherInfoENT.TeacherName = objvTeacherInfoENS.TeacherName; //教师姓名
objvTeacherInfoENT.IdSex = objvTeacherInfoENS.IdSex; //性别流水号
objvTeacherInfoENT.SexDesc = objvTeacherInfoENS.SexDesc; //性别名称
objvTeacherInfoENT.IdSchoolPs = objvTeacherInfoENS.IdSchoolPs; //学校流水号
objvTeacherInfoENT.IdDisciplinePs = objvTeacherInfoENS.IdDisciplinePs; //学科流水号
objvTeacherInfoENT.IdUniZone = objvTeacherInfoENS.IdUniZone; //校区流水号
objvTeacherInfoENT.UniZoneDesc = objvTeacherInfoENS.UniZoneDesc; //校区名称
objvTeacherInfoENT.IdEthnic = objvTeacherInfoENS.IdEthnic; //民族流水号
objvTeacherInfoENT.EthnicName = objvTeacherInfoENS.EthnicName; //民族名称
objvTeacherInfoENT.IdPolitics = objvTeacherInfoENS.IdPolitics; //政治面貌流水号
objvTeacherInfoENT.PoliticsName = objvTeacherInfoENS.PoliticsName; //政治面貌
objvTeacherInfoENT.IdAdminGrade = objvTeacherInfoENS.IdAdminGrade; //行政职务流水号
objvTeacherInfoENT.AdminGradeDesc = objvTeacherInfoENS.AdminGradeDesc; //行政职务描述
objvTeacherInfoENT.IdProfGrade = objvTeacherInfoENS.IdProfGrade; //专业职称流水号
objvTeacherInfoENT.ProfenssionalGradeName = objvTeacherInfoENS.ProfenssionalGradeName; //专业职称
objvTeacherInfoENT.IdQualif = objvTeacherInfoENS.IdQualif; //学历流水号
objvTeacherInfoENT.QualifDesc = objvTeacherInfoENS.QualifDesc; //QualifDesc
objvTeacherInfoENT.IdDegree = objvTeacherInfoENS.IdDegree; //学位流水号
objvTeacherInfoENT.DegreeName = objvTeacherInfoENS.DegreeName; //学位名称
objvTeacherInfoENT.IdStaffType = objvTeacherInfoENS.IdStaffType; //职工类型流水号
objvTeacherInfoENT.StaffTypeName = objvTeacherInfoENS.StaffTypeName; //职工类型名称
objvTeacherInfoENT.IdProvince = objvTeacherInfoENS.IdProvince; //省份流水号
objvTeacherInfoENT.ProvinceName = objvTeacherInfoENS.ProvinceName; //ProvinceName
objvTeacherInfoENT.CitizenId = objvTeacherInfoENS.CitizenId; //身份证号
objvTeacherInfoENT.CardNo = objvTeacherInfoENS.CardNo; //卡号
objvTeacherInfoENT.Birthday = objvTeacherInfoENS.Birthday; //出生日期
objvTeacherInfoENT.GraduationMajor = objvTeacherInfoENS.GraduationMajor; //毕业专业
objvTeacherInfoENT.TelNo = objvTeacherInfoENS.TelNo; //电话
objvTeacherInfoENT.Email = objvTeacherInfoENS.Email; //电子邮箱
objvTeacherInfoENT.WebSite = objvTeacherInfoENS.WebSite; //个人主页
objvTeacherInfoENT.PersonBlog = objvTeacherInfoENS.PersonBlog; //个人博客
objvTeacherInfoENT.EntryDate = objvTeacherInfoENS.EntryDate; //进校日期
objvTeacherInfoENT.Offed = objvTeacherInfoENS.Offed; //是否离校
objvTeacherInfoENT.IsAvconUser = objvTeacherInfoENS.IsAvconUser; //IsAvconUser
objvTeacherInfoENT.IsGpUser = objvTeacherInfoENS.IsGpUser; //是否Gp用户
objvTeacherInfoENT.IsLocalUser = objvTeacherInfoENS.IsLocalUser; //是否本地用户
objvTeacherInfoENT.FromUnit = objvTeacherInfoENS.FromUnit; //来自单位
objvTeacherInfoENT.Memo = objvTeacherInfoENS.Memo; //备注
objvTeacherInfoENT.IdXzCollege = objvTeacherInfoENS.IdXzCollege; //学院流水号
objvTeacherInfoENT.CollegeId = objvTeacherInfoENS.CollegeId; //学院ID
objvTeacherInfoENT.CollegeName = objvTeacherInfoENS.CollegeName; //学院名称
objvTeacherInfoENT.CollegeNameA = objvTeacherInfoENS.CollegeNameA; //学院名称简写
objvTeacherInfoENT.IdXzMajor = objvTeacherInfoENS.IdXzMajor; //专业流水号
objvTeacherInfoENT.EntryDay = objvTeacherInfoENS.EntryDay; //EntryDay
objvTeacherInfoENT.IdPhoto = objvTeacherInfoENS.IdPhoto; //id_Photo
objvTeacherInfoENT.IdReligion = objvTeacherInfoENS.IdReligion; //id_Religion
objvTeacherInfoENT.ReligionName = objvTeacherInfoENS.ReligionName; //ReligionName
objvTeacherInfoENT.IsMessage = objvTeacherInfoENS.IsMessage; //IsMessage
objvTeacherInfoENT.Microblog = objvTeacherInfoENS.Microblog; //Microblog
objvTeacherInfoENT.ModifyUserId = objvTeacherInfoENS.ModifyUserId; //修改人
objvTeacherInfoENT.OffedBak = objvTeacherInfoENS.OffedBak; //OffedBak
objvTeacherInfoENT.PhoneNumber = objvTeacherInfoENS.PhoneNumber; //电话
objvTeacherInfoENT.QQ = objvTeacherInfoENS.QQ; //QQ
objvTeacherInfoENT.TeachIdCollege = objvTeacherInfoENS.TeachIdCollege; //Teach_id_College
objvTeacherInfoENT.TeachIdMajor = objvTeacherInfoENS.TeachIdMajor; //Teach_id_Major
objvTeacherInfoENT.Tel = objvTeacherInfoENS.Tel; //Tel
objvTeacherInfoENT.ModifyDate = objvTeacherInfoENS.ModifyDate; //修改日期
objvTeacherInfoENT.RegisterPassword = objvTeacherInfoENS.RegisterPassword; //RegisterPassword
objvTeacherInfoENT.EntryYear = objvTeacherInfoENS.EntryYear; //EntryYear
objvTeacherInfoENT.IdCardNo = objvTeacherInfoENS.IdCardNo; //身份证号
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeacherInfoEN objvTeacherInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdTeacher, 8, convTeacherInfo.IdTeacher);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.TeacherId, 12, convTeacherInfo.TeacherId);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.TeacherName, 50, convTeacherInfo.TeacherName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdSex, 4, convTeacherInfo.IdSex);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.SexDesc, 10, convTeacherInfo.SexDesc);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdSchoolPs, 4, convTeacherInfo.IdSchoolPs);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdDisciplinePs, 4, convTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdUniZone, 4, convTeacherInfo.IdUniZone);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.UniZoneDesc, 20, convTeacherInfo.UniZoneDesc);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdEthnic, 4, convTeacherInfo.IdEthnic);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.EthnicName, 30, convTeacherInfo.EthnicName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdPolitics, 4, convTeacherInfo.IdPolitics);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.PoliticsName, 30, convTeacherInfo.PoliticsName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdAdminGrade, 4, convTeacherInfo.IdAdminGrade);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.AdminGradeDesc, 30, convTeacherInfo.AdminGradeDesc);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdProfGrade, 4, convTeacherInfo.IdProfGrade);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.ProfenssionalGradeName, 30, convTeacherInfo.ProfenssionalGradeName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdQualif, 4, convTeacherInfo.IdQualif);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.QualifDesc, 30, convTeacherInfo.QualifDesc);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdDegree, 4, convTeacherInfo.IdDegree);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.DegreeName, 30, convTeacherInfo.DegreeName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdStaffType, 4, convTeacherInfo.IdStaffType);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.StaffTypeName, 30, convTeacherInfo.StaffTypeName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdProvince, 4, convTeacherInfo.IdProvince);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.ProvinceName, 30, convTeacherInfo.ProvinceName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.CitizenId, 25, convTeacherInfo.CitizenId);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.CardNo, 18, convTeacherInfo.CardNo);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.Birthday, 8, convTeacherInfo.Birthday);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.GraduationMajor, 40, convTeacherInfo.GraduationMajor);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.TelNo, 50, convTeacherInfo.TelNo);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.Email, 100, convTeacherInfo.Email);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.WebSite, 60, convTeacherInfo.WebSite);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.PersonBlog, 60, convTeacherInfo.PersonBlog);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.EntryDate, 8, convTeacherInfo.EntryDate);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.FromUnit, 100, convTeacherInfo.FromUnit);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.Memo, 1000, convTeacherInfo.Memo);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdXzCollege, 4, convTeacherInfo.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.CollegeId, 4, convTeacherInfo.CollegeId);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.CollegeName, 100, convTeacherInfo.CollegeName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.CollegeNameA, 12, convTeacherInfo.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdXzMajor, 8, convTeacherInfo.IdXzMajor);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.EntryDay, 8, convTeacherInfo.EntryDay);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdPhoto, 8, convTeacherInfo.IdPhoto);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdReligion, 4, convTeacherInfo.IdReligion);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.ReligionName, 30, convTeacherInfo.ReligionName);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.Microblog, 200, convTeacherInfo.Microblog);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.ModifyUserId, 18, convTeacherInfo.ModifyUserId);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.PhoneNumber, 15, convTeacherInfo.PhoneNumber);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.QQ, 100, convTeacherInfo.QQ);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.TeachIdCollege, 6, convTeacherInfo.TeachIdCollege);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.TeachIdMajor, 8, convTeacherInfo.TeachIdMajor);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.Tel, 50, convTeacherInfo.Tel);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.ModifyDate, 20, convTeacherInfo.ModifyDate);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.RegisterPassword, 30, convTeacherInfo.RegisterPassword);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.EntryYear, 8, convTeacherInfo.EntryYear);
clsCheckSql.CheckFieldLen(objvTeacherInfoEN.IdCardNo, 20, convTeacherInfo.IdCardNo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdTeacher, convTeacherInfo.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.TeacherId, convTeacherInfo.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.TeacherName, convTeacherInfo.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdSex, convTeacherInfo.IdSex);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.SexDesc, convTeacherInfo.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdSchoolPs, convTeacherInfo.IdSchoolPs);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdDisciplinePs, convTeacherInfo.IdDisciplinePs);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdUniZone, convTeacherInfo.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.UniZoneDesc, convTeacherInfo.UniZoneDesc);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdEthnic, convTeacherInfo.IdEthnic);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.EthnicName, convTeacherInfo.EthnicName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdPolitics, convTeacherInfo.IdPolitics);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.PoliticsName, convTeacherInfo.PoliticsName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdAdminGrade, convTeacherInfo.IdAdminGrade);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.AdminGradeDesc, convTeacherInfo.AdminGradeDesc);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdProfGrade, convTeacherInfo.IdProfGrade);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.ProfenssionalGradeName, convTeacherInfo.ProfenssionalGradeName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdQualif, convTeacherInfo.IdQualif);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.QualifDesc, convTeacherInfo.QualifDesc);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdDegree, convTeacherInfo.IdDegree);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.DegreeName, convTeacherInfo.DegreeName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdStaffType, convTeacherInfo.IdStaffType);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.StaffTypeName, convTeacherInfo.StaffTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdProvince, convTeacherInfo.IdProvince);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.ProvinceName, convTeacherInfo.ProvinceName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.CitizenId, convTeacherInfo.CitizenId);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.CardNo, convTeacherInfo.CardNo);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.Birthday, convTeacherInfo.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.GraduationMajor, convTeacherInfo.GraduationMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.TelNo, convTeacherInfo.TelNo);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.Email, convTeacherInfo.Email);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.WebSite, convTeacherInfo.WebSite);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.PersonBlog, convTeacherInfo.PersonBlog);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.EntryDate, convTeacherInfo.EntryDate);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.FromUnit, convTeacherInfo.FromUnit);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.Memo, convTeacherInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdXzCollege, convTeacherInfo.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.CollegeId, convTeacherInfo.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.CollegeName, convTeacherInfo.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.CollegeNameA, convTeacherInfo.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdXzMajor, convTeacherInfo.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.EntryDay, convTeacherInfo.EntryDay);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdPhoto, convTeacherInfo.IdPhoto);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdReligion, convTeacherInfo.IdReligion);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.ReligionName, convTeacherInfo.ReligionName);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.Microblog, convTeacherInfo.Microblog);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.ModifyUserId, convTeacherInfo.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.PhoneNumber, convTeacherInfo.PhoneNumber);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.QQ, convTeacherInfo.QQ);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.TeachIdCollege, convTeacherInfo.TeachIdCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.TeachIdMajor, convTeacherInfo.TeachIdMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.Tel, convTeacherInfo.Tel);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.ModifyDate, convTeacherInfo.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.RegisterPassword, convTeacherInfo.RegisterPassword);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.EntryYear, convTeacherInfo.EntryYear);
clsCheckSql.CheckSqlInjection4Field(objvTeacherInfoEN.IdCardNo, convTeacherInfo.IdCardNo);
//检查外键字段长度
 objvTeacherInfoEN._IsCheckProperty = true;
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
string strSQL = "select IdTeacher, TeacherName from vTeacherInfo ";
 clsSpecSQLforSql mySql = clsvTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeacherInfoEN._CurrTabName);
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeacherInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvTeacherInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}