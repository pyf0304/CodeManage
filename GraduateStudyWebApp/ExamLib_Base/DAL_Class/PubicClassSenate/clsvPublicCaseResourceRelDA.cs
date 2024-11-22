
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPublicCaseResourceRelDA
 表名:vPublicCaseResourceRel(01120406)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:48:54
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课例观摩(PubicClassSenate)
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
 /// vPublicCaseResourceRel(vPublicCaseResourceRel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPublicCaseResourceRelDA : clsCommBase4DA
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
 return clsvPublicCaseResourceRelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPublicCaseResourceRelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPublicCaseResourceRelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPublicCaseResourceRelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPublicCaseResourceRelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPublicCaseResourceRel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable_vPublicCaseResourceRel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPublicCaseResourceRel.* from vPublicCaseResourceRel Left Join {1} on {2} where {3} and vPublicCaseResourceRel.IdPubClassCaseResourceRel not in (Select top {5} vPublicCaseResourceRel.IdPubClassCaseResourceRel from vPublicCaseResourceRel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1} and IdPubClassCaseResourceRel not in (Select top {2} IdPubClassCaseResourceRel from vPublicCaseResourceRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1} and IdPubClassCaseResourceRel not in (Select top {3} IdPubClassCaseResourceRel from vPublicCaseResourceRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vPublicCaseResourceRel.* from vPublicCaseResourceRel Left Join {1} on {2} where {3} and vPublicCaseResourceRel.IdPubClassCaseResourceRel not in (Select top {5} vPublicCaseResourceRel.IdPubClassCaseResourceRel from vPublicCaseResourceRel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1} and IdPubClassCaseResourceRel not in (Select top {2} IdPubClassCaseResourceRel from vPublicCaseResourceRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPublicCaseResourceRel where {1} and IdPubClassCaseResourceRel not in (Select top {3} IdPubClassCaseResourceRel from vPublicCaseResourceRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPublicCaseResourceRelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA:GetObjLst)", objException.Message));
}
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = TransNullToBool(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = TransNullToBool(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = TransNullToBool(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = TransNullToBool(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetObjLst)", objException.Message));
}
objvPublicCaseResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPublicCaseResourceRelEN);
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
public List<clsvPublicCaseResourceRelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPublicCaseResourceRelEN> arrObjLst = new List<clsvPublicCaseResourceRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = TransNullToBool(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = TransNullToBool(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = TransNullToBool(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = TransNullToBool(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetObjLst)", objException.Message));
}
objvPublicCaseResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPublicCaseResourceRelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPublicCaseResourceRel(ref clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where IdPubClassCaseResourceRel = " + ""+ objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = TransNullToInt(objDT.Rows[0][convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.IdPubClassCase = objDT.Rows[0][convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.PubClassCaseName = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPublicCaseResourceRelEN.PubClassCaseExecutor = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTheme = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseBG = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseDateIn = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.IdDiscipline = objDT.Rows[0][convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.DisciplineID = objDT.Rows[0][convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.DisciplineName = objDT.Rows[0][convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.IdTeachingPlan = objDT.Rows[0][convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.SubjectName = objDT.Rows[0][convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPublicCaseResourceRelEN.TeachingPlanAuthor = objDT.Rows[0][convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingObject = objDT.Rows[0][convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingEmphases = objDT.Rows[0][convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingDifficulty = objDT.Rows[0][convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingTool = objDT.Rows[0][convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingProcess = objDT.Rows[0][convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingPlanType = objDT.Rows[0][convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.SimplePlanContent = objDT.Rows[0][convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objDT.Rows[0][convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.PubCaseTypeName = objDT.Rows[0][convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.IdStudyLevel = objDT.Rows[0][convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPublicCaseResourceRelEN.StudyLevelName = objDT.Rows[0][convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.Introduction = objDT.Rows[0][convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPublicCaseResourceRelEN.CaseIsVisible = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPublicCaseResourceRelEN.RecommendedDegreeId = objDT.Rows[0][convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPublicCaseResourceRelEN.RecommendedDegreeName = objDT.Rows[0][convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPublicCaseResourceRelEN.IdResource = objDT.Rows[0][convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceID = objDT.Rows[0][convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceName = objDT.Rows[0][convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPublicCaseResourceRelEN.IdFtpResource = objDT.Rows[0][convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.IdFile = objDT.Rows[0][convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileName = objDT.Rows[0][convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.FileType = objDT.Rows[0][convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPublicCaseResourceRelEN.SaveDate = objDT.Rows[0][convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileSize = objDT.Rows[0][convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.SaveTime = objDT.Rows[0][convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.FtpResourceID = objDT.Rows[0][convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.FileOriginalName = objDT.Rows[0][convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileDirName = objDT.Rows[0][convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileRename = objDT.Rows[0][convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileUpDate = objDT.Rows[0][convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileUpTime = objDT.Rows[0][convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.SaveMode = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IdResourceType = objDT.Rows[0][convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceTypeID = objDT.Rows[0][convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceTypeName = objDT.Rows[0][convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceOwner = objDT.Rows[0][convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.ftpFileType = objDT.Rows[0][convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPublicCaseResourceRelEN.ftpFileSize = objDT.Rows[0][convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.ftpResourceOwner = objDT.Rows[0][convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.FileOriginName = objDT.Rows[0][convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.FileNewName = objDT.Rows[0][convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPublicCaseResourceRelEN.FileOldName = objDT.Rows[0][convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPublicCaseResourceRelEN.IsMain = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IndexNO = TransNullToInt(objDT.Rows[0][convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPublicCaseResourceRelEN.Memo = objDT.Rows[0][convPublicCaseResourceRel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPublicCaseResourceRelEN.IsVisible = TransNullToBool(objDT.Rows[0][convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetvPublicCaseResourceRel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdPubClassCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvPublicCaseResourceRelEN GetObjByIdPubClassCaseResourceRel(long lngIdPubClassCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where IdPubClassCaseResourceRel = " + ""+ lngIdPubClassCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
 objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = Int32.Parse(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料(字段类型:text,字段长度:16,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具(字段类型:varchar,字段长度:5000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型(字段类型:char,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍(字段类型:varchar,字段长度:4000,是否可空:True)
 objvPublicCaseResourceRelEN.CaseIsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvPublicCaseResourceRelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvPublicCaseResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvPublicCaseResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPublicCaseResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetObjByIdPubClassCaseResourceRel)", objException.Message));
}
return objvPublicCaseResourceRelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPublicCaseResourceRelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vPublicCaseResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN()
{
IdPubClassCaseResourceRel = TransNullToInt(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()), //案例与资源关系表流水号
IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(), //案例流水号
PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(), //案例课题名称
PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(), //案例执教者
PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(), //案例主题词
PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(), //案例背景资料
PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(), //案例授课日期
PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(), //案例入库日期
IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(), //学科名称
IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(), //教案流水号
SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(), //课题名称
TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(), //教案撰写人
TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(), //教学目标
TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(), //教学重点
TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(), //教学难点
TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(), //教学用具
TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(), //教学过程
TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(), //教案类型
SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(), //简案内容
PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(), //案例入库时间
PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(), //公开课案例类型名称
IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(), //学段名称
Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(), //简要介绍
CaseIsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()), //CaseIsVisible
IsDualVideo = TransNullToBool(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()), //是否双视频
RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()), //是否主资源
IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()), //序号
Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(), //备注
IsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()) //浏览次数
};
objvPublicCaseResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPublicCaseResourceRelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPublicCaseResourceRelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = TransNullToBool(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = TransNullToBool(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = TransNullToBool(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = TransNullToBool(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetObjByDataRowvPublicCaseResourceRel)", objException.Message));
}
objvPublicCaseResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPublicCaseResourceRelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPublicCaseResourceRelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN = new clsvPublicCaseResourceRelEN();
try
{
objvPublicCaseResourceRelEN.IdPubClassCaseResourceRel = TransNullToInt(objRow[convPublicCaseResourceRel.IdPubClassCaseResourceRel].ToString().Trim()); //案例与资源关系表流水号
objvPublicCaseResourceRelEN.IdPubClassCase = objRow[convPublicCaseResourceRel.IdPubClassCase].ToString().Trim(); //案例流水号
objvPublicCaseResourceRelEN.PubClassCaseName = objRow[convPublicCaseResourceRel.PubClassCaseName].ToString().Trim(); //案例课题名称
objvPublicCaseResourceRelEN.PubClassCaseExecutor = objRow[convPublicCaseResourceRel.PubClassCaseExecutor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseExecutor].ToString().Trim(); //案例执教者
objvPublicCaseResourceRelEN.PubClassCaseTheme = objRow[convPublicCaseResourceRel.PubClassCaseTheme] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTheme].ToString().Trim(); //案例主题词
objvPublicCaseResourceRelEN.PubClassCaseBG = objRow[convPublicCaseResourceRel.PubClassCaseBG] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseBG].ToString().Trim(); //案例背景资料
objvPublicCaseResourceRelEN.PubClassCaseTeachDate = objRow[convPublicCaseResourceRel.PubClassCaseTeachDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTeachDate].ToString().Trim(); //案例授课日期
objvPublicCaseResourceRelEN.PubClassCaseDateIn = objRow[convPublicCaseResourceRel.PubClassCaseDateIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseDateIn].ToString().Trim(); //案例入库日期
objvPublicCaseResourceRelEN.IdDiscipline = objRow[convPublicCaseResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvPublicCaseResourceRelEN.DisciplineID = objRow[convPublicCaseResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvPublicCaseResourceRelEN.DisciplineName = objRow[convPublicCaseResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvPublicCaseResourceRelEN.IdTeachingPlan = objRow[convPublicCaseResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvPublicCaseResourceRelEN.SubjectName = objRow[convPublicCaseResourceRel.SubjectName].ToString().Trim(); //课题名称
objvPublicCaseResourceRelEN.TeachingPlanAuthor = objRow[convPublicCaseResourceRel.TeachingPlanAuthor] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanAuthor].ToString().Trim(); //教案撰写人
objvPublicCaseResourceRelEN.TeachingObject = objRow[convPublicCaseResourceRel.TeachingObject] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingObject].ToString().Trim(); //教学目标
objvPublicCaseResourceRelEN.TeachingEmphases = objRow[convPublicCaseResourceRel.TeachingEmphases] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingEmphases].ToString().Trim(); //教学重点
objvPublicCaseResourceRelEN.TeachingDifficulty = objRow[convPublicCaseResourceRel.TeachingDifficulty] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingDifficulty].ToString().Trim(); //教学难点
objvPublicCaseResourceRelEN.TeachingTool = objRow[convPublicCaseResourceRel.TeachingTool] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingTool].ToString().Trim(); //教学用具
objvPublicCaseResourceRelEN.TeachingProcess = objRow[convPublicCaseResourceRel.TeachingProcess] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingProcess].ToString().Trim(); //教学过程
objvPublicCaseResourceRelEN.TeachingPlanType = objRow[convPublicCaseResourceRel.TeachingPlanType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.TeachingPlanType].ToString().Trim(); //教案类型
objvPublicCaseResourceRelEN.SimplePlanContent = objRow[convPublicCaseResourceRel.SimplePlanContent] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SimplePlanContent].ToString().Trim(); //简案内容
objvPublicCaseResourceRelEN.PubClassCaseTimeIn = objRow[convPublicCaseResourceRel.PubClassCaseTimeIn] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubClassCaseTimeIn].ToString().Trim(); //案例入库时间
objvPublicCaseResourceRelEN.PubCaseTypeName = objRow[convPublicCaseResourceRel.PubCaseTypeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.PubCaseTypeName].ToString().Trim(); //公开课案例类型名称
objvPublicCaseResourceRelEN.IdStudyLevel = objRow[convPublicCaseResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvPublicCaseResourceRelEN.StudyLevelName = objRow[convPublicCaseResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvPublicCaseResourceRelEN.Introduction = objRow[convPublicCaseResourceRel.Introduction] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Introduction].ToString().Trim(); //简要介绍
objvPublicCaseResourceRelEN.CaseIsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.CaseIsVisible].ToString().Trim()); //CaseIsVisible
objvPublicCaseResourceRelEN.IsDualVideo = TransNullToBool(objRow[convPublicCaseResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvPublicCaseResourceRelEN.RecommendedDegreeId = objRow[convPublicCaseResourceRel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvPublicCaseResourceRelEN.RecommendedDegreeName = objRow[convPublicCaseResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvPublicCaseResourceRelEN.IdResource = objRow[convPublicCaseResourceRel.IdResource].ToString().Trim(); //资源流水号
objvPublicCaseResourceRelEN.ResourceID = objRow[convPublicCaseResourceRel.ResourceID].ToString().Trim(); //资源ID
objvPublicCaseResourceRelEN.ResourceName = objRow[convPublicCaseResourceRel.ResourceName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ResourceName].ToString().Trim(); //资源名称
objvPublicCaseResourceRelEN.IdFtpResource = objRow[convPublicCaseResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvPublicCaseResourceRelEN.IdFile = objRow[convPublicCaseResourceRel.IdFile] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.IdFile].ToString().Trim(); //文件流水号
objvPublicCaseResourceRelEN.FileName = objRow[convPublicCaseResourceRel.FileName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileName].ToString().Trim(); //文件名称
objvPublicCaseResourceRelEN.FileType = objRow[convPublicCaseResourceRel.FileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileType].ToString().Trim(); //文件类型
objvPublicCaseResourceRelEN.SaveDate = objRow[convPublicCaseResourceRel.SaveDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileSize = objRow[convPublicCaseResourceRel.FileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileSize].ToString().Trim(); //文件大小
objvPublicCaseResourceRelEN.SaveTime = objRow[convPublicCaseResourceRel.SaveTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.SaveTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.FtpResourceID = objRow[convPublicCaseResourceRel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvPublicCaseResourceRelEN.FileOriginalName = objRow[convPublicCaseResourceRel.FileOriginalName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginalName].ToString().Trim(); //文件原名
objvPublicCaseResourceRelEN.FileDirName = objRow[convPublicCaseResourceRel.FileDirName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileDirName].ToString().Trim(); //文件目录名
objvPublicCaseResourceRelEN.FileRename = objRow[convPublicCaseResourceRel.FileRename] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileRename].ToString().Trim(); //文件新名
objvPublicCaseResourceRelEN.FileUpDate = objRow[convPublicCaseResourceRel.FileUpDate] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpDate].ToString().Trim(); //创建日期
objvPublicCaseResourceRelEN.FileUpTime = objRow[convPublicCaseResourceRel.FileUpTime] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileUpTime].ToString().Trim(); //创建时间
objvPublicCaseResourceRelEN.SaveMode = TransNullToBool(objRow[convPublicCaseResourceRel.SaveMode].ToString().Trim()); //文件存放方式
objvPublicCaseResourceRelEN.IdResourceType = objRow[convPublicCaseResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvPublicCaseResourceRelEN.ResourceTypeID = objRow[convPublicCaseResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvPublicCaseResourceRelEN.ResourceTypeName = objRow[convPublicCaseResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvPublicCaseResourceRelEN.ResourceOwner = objRow[convPublicCaseResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvPublicCaseResourceRelEN.ftpFileType = objRow[convPublicCaseResourceRel.ftpFileType] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileType].ToString().Trim(); //ftp文件类型
objvPublicCaseResourceRelEN.ftpFileSize = objRow[convPublicCaseResourceRel.ftpFileSize] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvPublicCaseResourceRelEN.ftpResourceOwner = objRow[convPublicCaseResourceRel.ftpResourceOwner] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvPublicCaseResourceRelEN.FileOriginName = objRow[convPublicCaseResourceRel.FileOriginName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOriginName].ToString().Trim(); //原文件名
objvPublicCaseResourceRelEN.IsExistFile = TransNullToBool(objRow[convPublicCaseResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvPublicCaseResourceRelEN.FileNewName = objRow[convPublicCaseResourceRel.FileNewName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileNewName].ToString().Trim(); //新文件名
objvPublicCaseResourceRelEN.FileOldName = objRow[convPublicCaseResourceRel.FileOldName] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.FileOldName].ToString().Trim(); //旧文件名
objvPublicCaseResourceRelEN.IsMain = TransNullToBool(objRow[convPublicCaseResourceRel.IsMain].ToString().Trim()); //是否主资源
objvPublicCaseResourceRelEN.IndexNO = objRow[convPublicCaseResourceRel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.IndexNO].ToString().Trim()); //序号
objvPublicCaseResourceRelEN.Memo = objRow[convPublicCaseResourceRel.Memo] == DBNull.Value ? null : objRow[convPublicCaseResourceRel.Memo].ToString().Trim(); //备注
objvPublicCaseResourceRelEN.IsVisible = TransNullToBool(objRow[convPublicCaseResourceRel.IsVisible].ToString().Trim()); //是否显示
objvPublicCaseResourceRelEN.BrowseCount = objRow[convPublicCaseResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPublicCaseResourceRel.BrowseCount].ToString().Trim()); //浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPublicCaseResourceRelDA: GetObjByDataRow)", objException.Message));
}
objvPublicCaseResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPublicCaseResourceRelEN;
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
objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPublicCaseResourceRelEN._CurrTabName, convPublicCaseResourceRel.IdPubClassCaseResourceRel, 8, "");
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
objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPublicCaseResourceRelEN._CurrTabName, convPublicCaseResourceRel.IdPubClassCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPubClassCaseResourceRel from vPublicCaseResourceRel where " + strCondition;
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPubClassCaseResourceRel from vPublicCaseResourceRel where " + strCondition;
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
 /// <param name = "lngIdPubClassCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdPubClassCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPublicCaseResourceRel", "IdPubClassCaseResourceRel = " + ""+ lngIdPubClassCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPublicCaseResourceRelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPublicCaseResourceRel", strCondition))
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
objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPublicCaseResourceRel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPublicCaseResourceRelENS">源对象</param>
 /// <param name = "objvPublicCaseResourceRelENT">目标对象</param>
public void CopyTo(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENS, clsvPublicCaseResourceRelEN objvPublicCaseResourceRelENT)
{
objvPublicCaseResourceRelENT.IdPubClassCaseResourceRel = objvPublicCaseResourceRelENS.IdPubClassCaseResourceRel; //案例与资源关系表流水号
objvPublicCaseResourceRelENT.IdPubClassCase = objvPublicCaseResourceRelENS.IdPubClassCase; //案例流水号
objvPublicCaseResourceRelENT.PubClassCaseName = objvPublicCaseResourceRelENS.PubClassCaseName; //案例课题名称
objvPublicCaseResourceRelENT.PubClassCaseExecutor = objvPublicCaseResourceRelENS.PubClassCaseExecutor; //案例执教者
objvPublicCaseResourceRelENT.PubClassCaseTheme = objvPublicCaseResourceRelENS.PubClassCaseTheme; //案例主题词
objvPublicCaseResourceRelENT.PubClassCaseBG = objvPublicCaseResourceRelENS.PubClassCaseBG; //案例背景资料
objvPublicCaseResourceRelENT.PubClassCaseTeachDate = objvPublicCaseResourceRelENS.PubClassCaseTeachDate; //案例授课日期
objvPublicCaseResourceRelENT.PubClassCaseDateIn = objvPublicCaseResourceRelENS.PubClassCaseDateIn; //案例入库日期
objvPublicCaseResourceRelENT.IdDiscipline = objvPublicCaseResourceRelENS.IdDiscipline; //学科流水号
objvPublicCaseResourceRelENT.DisciplineID = objvPublicCaseResourceRelENS.DisciplineID; //学科ID
objvPublicCaseResourceRelENT.DisciplineName = objvPublicCaseResourceRelENS.DisciplineName; //学科名称
objvPublicCaseResourceRelENT.IdTeachingPlan = objvPublicCaseResourceRelENS.IdTeachingPlan; //教案流水号
objvPublicCaseResourceRelENT.SubjectName = objvPublicCaseResourceRelENS.SubjectName; //课题名称
objvPublicCaseResourceRelENT.TeachingPlanAuthor = objvPublicCaseResourceRelENS.TeachingPlanAuthor; //教案撰写人
objvPublicCaseResourceRelENT.TeachingObject = objvPublicCaseResourceRelENS.TeachingObject; //教学目标
objvPublicCaseResourceRelENT.TeachingEmphases = objvPublicCaseResourceRelENS.TeachingEmphases; //教学重点
objvPublicCaseResourceRelENT.TeachingDifficulty = objvPublicCaseResourceRelENS.TeachingDifficulty; //教学难点
objvPublicCaseResourceRelENT.TeachingTool = objvPublicCaseResourceRelENS.TeachingTool; //教学用具
objvPublicCaseResourceRelENT.TeachingProcess = objvPublicCaseResourceRelENS.TeachingProcess; //教学过程
objvPublicCaseResourceRelENT.TeachingPlanType = objvPublicCaseResourceRelENS.TeachingPlanType; //教案类型
objvPublicCaseResourceRelENT.SimplePlanContent = objvPublicCaseResourceRelENS.SimplePlanContent; //简案内容
objvPublicCaseResourceRelENT.PubClassCaseTimeIn = objvPublicCaseResourceRelENS.PubClassCaseTimeIn; //案例入库时间
objvPublicCaseResourceRelENT.PubCaseTypeName = objvPublicCaseResourceRelENS.PubCaseTypeName; //公开课案例类型名称
objvPublicCaseResourceRelENT.IdStudyLevel = objvPublicCaseResourceRelENS.IdStudyLevel; //id_StudyLevel
objvPublicCaseResourceRelENT.StudyLevelName = objvPublicCaseResourceRelENS.StudyLevelName; //学段名称
objvPublicCaseResourceRelENT.Introduction = objvPublicCaseResourceRelENS.Introduction; //简要介绍
objvPublicCaseResourceRelENT.CaseIsVisible = objvPublicCaseResourceRelENS.CaseIsVisible; //CaseIsVisible
objvPublicCaseResourceRelENT.IsDualVideo = objvPublicCaseResourceRelENS.IsDualVideo; //是否双视频
objvPublicCaseResourceRelENT.RecommendedDegreeId = objvPublicCaseResourceRelENS.RecommendedDegreeId; //推荐度Id
objvPublicCaseResourceRelENT.RecommendedDegreeName = objvPublicCaseResourceRelENS.RecommendedDegreeName; //推荐度名称
objvPublicCaseResourceRelENT.IdResource = objvPublicCaseResourceRelENS.IdResource; //资源流水号
objvPublicCaseResourceRelENT.ResourceID = objvPublicCaseResourceRelENS.ResourceID; //资源ID
objvPublicCaseResourceRelENT.ResourceName = objvPublicCaseResourceRelENS.ResourceName; //资源名称
objvPublicCaseResourceRelENT.IdFtpResource = objvPublicCaseResourceRelENS.IdFtpResource; //FTP资源流水号
objvPublicCaseResourceRelENT.IdFile = objvPublicCaseResourceRelENS.IdFile; //文件流水号
objvPublicCaseResourceRelENT.FileName = objvPublicCaseResourceRelENS.FileName; //文件名称
objvPublicCaseResourceRelENT.FileType = objvPublicCaseResourceRelENS.FileType; //文件类型
objvPublicCaseResourceRelENT.SaveDate = objvPublicCaseResourceRelENS.SaveDate; //创建日期
objvPublicCaseResourceRelENT.FileSize = objvPublicCaseResourceRelENS.FileSize; //文件大小
objvPublicCaseResourceRelENT.SaveTime = objvPublicCaseResourceRelENS.SaveTime; //创建时间
objvPublicCaseResourceRelENT.FtpResourceID = objvPublicCaseResourceRelENS.FtpResourceID; //FTP资源ID
objvPublicCaseResourceRelENT.FileOriginalName = objvPublicCaseResourceRelENS.FileOriginalName; //文件原名
objvPublicCaseResourceRelENT.FileDirName = objvPublicCaseResourceRelENS.FileDirName; //文件目录名
objvPublicCaseResourceRelENT.FileRename = objvPublicCaseResourceRelENS.FileRename; //文件新名
objvPublicCaseResourceRelENT.FileUpDate = objvPublicCaseResourceRelENS.FileUpDate; //创建日期
objvPublicCaseResourceRelENT.FileUpTime = objvPublicCaseResourceRelENS.FileUpTime; //创建时间
objvPublicCaseResourceRelENT.SaveMode = objvPublicCaseResourceRelENS.SaveMode; //文件存放方式
objvPublicCaseResourceRelENT.IdResourceType = objvPublicCaseResourceRelENS.IdResourceType; //资源类型流水号
objvPublicCaseResourceRelENT.ResourceTypeID = objvPublicCaseResourceRelENS.ResourceTypeID; //资源类型ID
objvPublicCaseResourceRelENT.ResourceTypeName = objvPublicCaseResourceRelENS.ResourceTypeName; //资源类型名称
objvPublicCaseResourceRelENT.ResourceOwner = objvPublicCaseResourceRelENS.ResourceOwner; //上传者
objvPublicCaseResourceRelENT.ftpFileType = objvPublicCaseResourceRelENS.ftpFileType; //ftp文件类型
objvPublicCaseResourceRelENT.ftpFileSize = objvPublicCaseResourceRelENS.ftpFileSize; //ftp文件大小
objvPublicCaseResourceRelENT.ftpResourceOwner = objvPublicCaseResourceRelENS.ftpResourceOwner; //Ftp资源拥有者
objvPublicCaseResourceRelENT.FileOriginName = objvPublicCaseResourceRelENS.FileOriginName; //原文件名
objvPublicCaseResourceRelENT.IsExistFile = objvPublicCaseResourceRelENS.IsExistFile; //是否存在文件
objvPublicCaseResourceRelENT.FileNewName = objvPublicCaseResourceRelENS.FileNewName; //新文件名
objvPublicCaseResourceRelENT.FileOldName = objvPublicCaseResourceRelENS.FileOldName; //旧文件名
objvPublicCaseResourceRelENT.IsMain = objvPublicCaseResourceRelENS.IsMain; //是否主资源
objvPublicCaseResourceRelENT.IndexNO = objvPublicCaseResourceRelENS.IndexNO; //序号
objvPublicCaseResourceRelENT.Memo = objvPublicCaseResourceRelENS.Memo; //备注
objvPublicCaseResourceRelENT.IsVisible = objvPublicCaseResourceRelENS.IsVisible; //是否显示
objvPublicCaseResourceRelENT.BrowseCount = objvPublicCaseResourceRelENS.BrowseCount; //浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPublicCaseResourceRelEN objvPublicCaseResourceRelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdPubClassCase, 8, convPublicCaseResourceRel.IdPubClassCase);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseName, 200, convPublicCaseResourceRel.PubClassCaseName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseExecutor, 50, convPublicCaseResourceRel.PubClassCaseExecutor);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseTheme, 500, convPublicCaseResourceRel.PubClassCaseTheme);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseTeachDate, 8, convPublicCaseResourceRel.PubClassCaseTeachDate);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseDateIn, 8, convPublicCaseResourceRel.PubClassCaseDateIn);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdDiscipline, 4, convPublicCaseResourceRel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.DisciplineID, 4, convPublicCaseResourceRel.DisciplineID);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.DisciplineName, 50, convPublicCaseResourceRel.DisciplineName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdTeachingPlan, 8, convPublicCaseResourceRel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.SubjectName, 200, convPublicCaseResourceRel.SubjectName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingPlanAuthor, 50, convPublicCaseResourceRel.TeachingPlanAuthor);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingObject, 5000, convPublicCaseResourceRel.TeachingObject);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingEmphases, 5000, convPublicCaseResourceRel.TeachingEmphases);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingDifficulty, 5000, convPublicCaseResourceRel.TeachingDifficulty);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingTool, 5000, convPublicCaseResourceRel.TeachingTool);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingProcess, 8000, convPublicCaseResourceRel.TeachingProcess);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.TeachingPlanType, 1, convPublicCaseResourceRel.TeachingPlanType);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubClassCaseTimeIn, 6, convPublicCaseResourceRel.PubClassCaseTimeIn);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.PubCaseTypeName, 50, convPublicCaseResourceRel.PubCaseTypeName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdStudyLevel, 4, convPublicCaseResourceRel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.StudyLevelName, 50, convPublicCaseResourceRel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.Introduction, 4000, convPublicCaseResourceRel.Introduction);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.RecommendedDegreeId, 2, convPublicCaseResourceRel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.RecommendedDegreeName, 30, convPublicCaseResourceRel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdResource, 8, convPublicCaseResourceRel.IdResource);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ResourceID, 8, convPublicCaseResourceRel.ResourceID);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ResourceName, 100, convPublicCaseResourceRel.ResourceName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdFtpResource, 8, convPublicCaseResourceRel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdFile, 8, convPublicCaseResourceRel.IdFile);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileName, 500, convPublicCaseResourceRel.FileName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileType, 30, convPublicCaseResourceRel.FileType);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.SaveDate, 8, convPublicCaseResourceRel.SaveDate);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileSize, 50, convPublicCaseResourceRel.FileSize);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.SaveTime, 6, convPublicCaseResourceRel.SaveTime);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FtpResourceID, 8, convPublicCaseResourceRel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileOriginalName, 200, convPublicCaseResourceRel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileDirName, 200, convPublicCaseResourceRel.FileDirName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileRename, 200, convPublicCaseResourceRel.FileRename);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileUpDate, 8, convPublicCaseResourceRel.FileUpDate);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileUpTime, 6, convPublicCaseResourceRel.FileUpTime);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.IdResourceType, 4, convPublicCaseResourceRel.IdResourceType);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ResourceTypeID, 4, convPublicCaseResourceRel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ResourceTypeName, 50, convPublicCaseResourceRel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ResourceOwner, 50, convPublicCaseResourceRel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ftpFileType, 30, convPublicCaseResourceRel.ftpFileType);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ftpFileSize, 50, convPublicCaseResourceRel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.ftpResourceOwner, 50, convPublicCaseResourceRel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileOriginName, 500, convPublicCaseResourceRel.FileOriginName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileNewName, 530, convPublicCaseResourceRel.FileNewName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.FileOldName, 530, convPublicCaseResourceRel.FileOldName);
clsCheckSql.CheckFieldLen(objvPublicCaseResourceRelEN.Memo, 1000, convPublicCaseResourceRel.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdPubClassCase, convPublicCaseResourceRel.IdPubClassCase);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseName, convPublicCaseResourceRel.PubClassCaseName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseExecutor, convPublicCaseResourceRel.PubClassCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseTheme, convPublicCaseResourceRel.PubClassCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseTeachDate, convPublicCaseResourceRel.PubClassCaseTeachDate);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseDateIn, convPublicCaseResourceRel.PubClassCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdDiscipline, convPublicCaseResourceRel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.DisciplineID, convPublicCaseResourceRel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.DisciplineName, convPublicCaseResourceRel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdTeachingPlan, convPublicCaseResourceRel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.SubjectName, convPublicCaseResourceRel.SubjectName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingPlanAuthor, convPublicCaseResourceRel.TeachingPlanAuthor);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingObject, convPublicCaseResourceRel.TeachingObject);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingEmphases, convPublicCaseResourceRel.TeachingEmphases);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingDifficulty, convPublicCaseResourceRel.TeachingDifficulty);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingTool, convPublicCaseResourceRel.TeachingTool);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingProcess, convPublicCaseResourceRel.TeachingProcess);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.TeachingPlanType, convPublicCaseResourceRel.TeachingPlanType);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubClassCaseTimeIn, convPublicCaseResourceRel.PubClassCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.PubCaseTypeName, convPublicCaseResourceRel.PubCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdStudyLevel, convPublicCaseResourceRel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.StudyLevelName, convPublicCaseResourceRel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.Introduction, convPublicCaseResourceRel.Introduction);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.RecommendedDegreeId, convPublicCaseResourceRel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.RecommendedDegreeName, convPublicCaseResourceRel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdResource, convPublicCaseResourceRel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ResourceID, convPublicCaseResourceRel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ResourceName, convPublicCaseResourceRel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdFtpResource, convPublicCaseResourceRel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdFile, convPublicCaseResourceRel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileName, convPublicCaseResourceRel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileType, convPublicCaseResourceRel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.SaveDate, convPublicCaseResourceRel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileSize, convPublicCaseResourceRel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.SaveTime, convPublicCaseResourceRel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FtpResourceID, convPublicCaseResourceRel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileOriginalName, convPublicCaseResourceRel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileDirName, convPublicCaseResourceRel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileRename, convPublicCaseResourceRel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileUpDate, convPublicCaseResourceRel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileUpTime, convPublicCaseResourceRel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.IdResourceType, convPublicCaseResourceRel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ResourceTypeID, convPublicCaseResourceRel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ResourceTypeName, convPublicCaseResourceRel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ResourceOwner, convPublicCaseResourceRel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ftpFileType, convPublicCaseResourceRel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ftpFileSize, convPublicCaseResourceRel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.ftpResourceOwner, convPublicCaseResourceRel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileOriginName, convPublicCaseResourceRel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileNewName, convPublicCaseResourceRel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.FileOldName, convPublicCaseResourceRel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvPublicCaseResourceRelEN.Memo, convPublicCaseResourceRel.Memo);
//检查外键字段长度
 objvPublicCaseResourceRelEN._IsCheckProperty = true;
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPublicCaseResourceRelEN._CurrTabName);
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPublicCaseResourceRelEN._CurrTabName, strCondition);
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
 objSQL = clsvPublicCaseResourceRelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}