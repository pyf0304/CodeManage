
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCase_Resource_RelDA
 表名:vTeachCase_Resource_Rel(01120426)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:52
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范(SkillDemo)
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
 /// 案例与资源关系表视图(vTeachCase_Resource_Rel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachCase_Resource_RelDA : clsCommBase4DA
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
 return clsvTeachCase_Resource_RelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachCase_Resource_RelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCase_Resource_RelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachCase_Resource_RelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachCase_Resource_RelEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachCase_Resource_Rel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable_vTeachCase_Resource_Rel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCase_Resource_Rel.* from vTeachCase_Resource_Rel Left Join {1} on {2} where {3} and vTeachCase_Resource_Rel.IdTeachCaseResourceRel not in (Select top {5} vTeachCase_Resource_Rel.IdTeachCaseResourceRel from vTeachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {2} IdTeachCaseResourceRel from vTeachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {3} IdTeachCaseResourceRel from vTeachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCase_Resource_Rel.* from vTeachCase_Resource_Rel Left Join {1} on {2} where {3} and vTeachCase_Resource_Rel.IdTeachCaseResourceRel not in (Select top {5} vTeachCase_Resource_Rel.IdTeachCaseResourceRel from vTeachCase_Resource_Rel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {2} IdTeachCaseResourceRel from vTeachCase_Resource_Rel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase_Resource_Rel where {1} and IdTeachCaseResourceRel not in (Select top {3} IdTeachCaseResourceRel from vTeachCase_Resource_Rel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachCase_Resource_RelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA:GetObjLst)", objException.Message));
}
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
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
public List<clsvTeachCase_Resource_RelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachCase_Resource_RelEN> arrObjLst = new List<clsvTeachCase_Resource_RelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetObjLst)", objException.Message));
}
objvTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCase_Resource_RelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachCase_Resource_Rel(ref clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objDT.Rows[0][convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.IdTeachCase = objDT.Rows[0][convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseID = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseName = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseExecutor = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachCaseTheme = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachCaseBG = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCase_Resource_RelEN.IdTeachSkill = objDT.Rows[0][convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillID = objDT.Rows[0][convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.SkillTypeName = objDT.Rows[0][convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillName = objDT.Rows[0][convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillTheory = objDT.Rows[0][convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objDT.Rows[0][convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachCase_Resource_RelEN.IdSkillType = objDT.Rows[0][convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.SkillTypeID = objDT.Rows[0][convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.IdDiscipline = objDT.Rows[0][convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.DisciplineName = objDT.Rows[0][convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.IdStudyLevel = objDT.Rows[0][convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.StudyLevelName = objDT.Rows[0][convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseDateIn = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.IdTeachingPlan = objDT.Rows[0][convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objDT.Rows[0][convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.WorkUnit = objDT.Rows[0][convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachCase_Resource_RelEN.CDID = objDT.Rows[0][convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachCase_Resource_RelEN.IdXzCollege = objDT.Rows[0][convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.CollegeID = objDT.Rows[0][convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.CollegeName = objDT.Rows[0][convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCase_Resource_RelEN.RecommendedDegreeId = objDT.Rows[0][convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachCase_Resource_RelEN.RecommendedDegreeName = objDT.Rows[0][convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachCase_Resource_RelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.IdResource = objDT.Rows[0][convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceID = objDT.Rows[0][convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceName = objDT.Rows[0][convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCase_Resource_RelEN.IdFtpResource = objDT.Rows[0][convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.IdFile = objDT.Rows[0][convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileName = objDT.Rows[0][convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCase_Resource_RelEN.FileType = objDT.Rows[0][convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveDate = objDT.Rows[0][convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileSize = objDT.Rows[0][convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveTime = objDT.Rows[0][convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.FtpResourceID = objDT.Rows[0][convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.FileOriginalName = objDT.Rows[0][convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileDirName = objDT.Rows[0][convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileRename = objDT.Rows[0][convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileUpDate = objDT.Rows[0][convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileUpTime = objDT.Rows[0][convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveMode = TransNullToBool(objDT.Rows[0][convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.IdResourceType = objDT.Rows[0][convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceTypeID = objDT.Rows[0][convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceTypeName = objDT.Rows[0][convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceOwner = objDT.Rows[0][convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.ftpFileType = objDT.Rows[0][convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCase_Resource_RelEN.ftpFileSize = objDT.Rows[0][convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.ftpResourceOwner = objDT.Rows[0][convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.FileOriginName = objDT.Rows[0][convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCase_Resource_RelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.FileNewName = objDT.Rows[0][convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCase_Resource_RelEN.FileOldName = objDT.Rows[0][convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCase_Resource_RelEN.IsMain = TransNullToBool(objDT.Rows[0][convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.Memo = objDT.Rows[0][convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCase_Resource_RelEN.IndexNO = TransNullToInt(objDT.Rows[0][convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.CollegeNameA = objDT.Rows[0][convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetvTeachCase_Resource_Rel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdTeachCaseResourceRel">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachCase_Resource_RelEN GetObjByIdTeachCaseResourceRel(long lngIdTeachCaseResourceRel)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
 objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = Int32.Parse(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCase_Resource_RelEN.SaveMode = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名(字段类型:varchar,字段长度:500,是否可空:True)
 objvTeachCase_Resource_RelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvTeachCase_Resource_RelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetObjByIdTeachCaseResourceRel)", objException.Message));
}
return objvTeachCase_Resource_RelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachCase_Resource_RelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase_Resource_Rel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN()
{
IdTeachCaseResourceRel = TransNullToInt(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()), //案例与资源表系表流水号
IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(), //案例流水号
TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(), //案例ID
TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(), //案例名称
TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(), //案例执教者
TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(), //案例主题词
TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(), //案例背景资料
IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(), //技能类型ID
IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(), //学段名称
TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(), //案例入库日期
IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(), //教案流水号
TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(), //案例入库时间
WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(), //工作单位
CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(), //光盘编号
IsDualVideo = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(), //学院名称
RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(), //文件流水号
FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(), //文件名称
FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(), //文件类型
SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(), //创建日期
FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(), //创建时间
FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(), //FTP资源ID
FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(), //文件原名
FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(), //文件目录名
FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(), //文件新名
FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(), //创建日期
FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(), //创建时间
SaveMode = TransNullToBool(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()), //文件存放方式
IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(), //上传者
ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(), //ftp文件类型
ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(), //ftp文件大小
ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(), //Ftp资源拥有者
FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(), //原文件名
IsExistFile = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(), //新文件名
FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(), //旧文件名
IsMain = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()), //是否主资源
Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(), //备注
IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()), //序号
IsVisible = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()), //是否显示
BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()), //浏览次数
CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim() //学院名称简写
};
objvTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCase_Resource_RelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachCase_Resource_RelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetObjByDataRowvTeachCase_Resource_Rel)", objException.Message));
}
objvTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCase_Resource_RelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachCase_Resource_RelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN = new clsvTeachCase_Resource_RelEN();
try
{
objvTeachCase_Resource_RelEN.IdTeachCaseResourceRel = TransNullToInt(objRow[convTeachCase_Resource_Rel.IdTeachCaseResourceRel].ToString().Trim()); //案例与资源表系表流水号
objvTeachCase_Resource_RelEN.IdTeachCase = objRow[convTeachCase_Resource_Rel.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCase_Resource_RelEN.TeachCaseID = objRow[convTeachCase_Resource_Rel.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCase_Resource_RelEN.TeachCaseName = objRow[convTeachCase_Resource_Rel.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCase_Resource_RelEN.TeachCaseExecutor = objRow[convTeachCase_Resource_Rel.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCase_Resource_RelEN.TeachCaseTheme = objRow[convTeachCase_Resource_Rel.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCase_Resource_RelEN.TeachCaseBG = objRow[convTeachCase_Resource_Rel.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCase_Resource_RelEN.IdTeachSkill = objRow[convTeachCase_Resource_Rel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCase_Resource_RelEN.TeachSkillID = objRow[convTeachCase_Resource_Rel.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCase_Resource_RelEN.SkillTypeName = objRow[convTeachCase_Resource_Rel.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCase_Resource_RelEN.TeachSkillName = objRow[convTeachCase_Resource_Rel.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCase_Resource_RelEN.TeachSkillTheory = objRow[convTeachCase_Resource_Rel.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCase_Resource_RelEN.TeachSkillOperMethod = objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCase_Resource_RelEN.IdSkillType = objRow[convTeachCase_Resource_Rel.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCase_Resource_RelEN.SkillTypeID = objRow[convTeachCase_Resource_Rel.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCase_Resource_RelEN.IdDiscipline = objRow[convTeachCase_Resource_Rel.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCase_Resource_RelEN.DisciplineName = objRow[convTeachCase_Resource_Rel.DisciplineName].ToString().Trim(); //学科名称
objvTeachCase_Resource_RelEN.IdStudyLevel = objRow[convTeachCase_Resource_Rel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCase_Resource_RelEN.StudyLevelName = objRow[convTeachCase_Resource_Rel.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCase_Resource_RelEN.TeachCaseDateIn = objRow[convTeachCase_Resource_Rel.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCase_Resource_RelEN.IdTeachingPlan = objRow[convTeachCase_Resource_Rel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCase_Resource_RelEN.TeachCaseTimeIn = objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCase_Resource_RelEN.WorkUnit = objRow[convTeachCase_Resource_Rel.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.WorkUnit].ToString().Trim(); //工作单位
objvTeachCase_Resource_RelEN.CDID = objRow[convTeachCase_Resource_Rel.CDID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CDID].ToString().Trim(); //光盘编号
objvTeachCase_Resource_RelEN.IsDualVideo = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCase_Resource_RelEN.IdXzCollege = objRow[convTeachCase_Resource_Rel.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCase_Resource_RelEN.CollegeID = objRow[convTeachCase_Resource_Rel.CollegeID] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeID].ToString().Trim(); //学院ID
objvTeachCase_Resource_RelEN.CollegeName = objRow[convTeachCase_Resource_Rel.CollegeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeName].ToString().Trim(); //学院名称
objvTeachCase_Resource_RelEN.RecommendedDegreeId = objRow[convTeachCase_Resource_Rel.RecommendedDegreeId] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCase_Resource_RelEN.RecommendedDegreeName = objRow[convTeachCase_Resource_Rel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCase_Resource_RelEN.BrowseCount4Case = objRow[convTeachCase_Resource_Rel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvTeachCase_Resource_RelEN.IdResource = objRow[convTeachCase_Resource_Rel.IdResource].ToString().Trim(); //资源流水号
objvTeachCase_Resource_RelEN.ResourceID = objRow[convTeachCase_Resource_Rel.ResourceID].ToString().Trim(); //资源ID
objvTeachCase_Resource_RelEN.ResourceName = objRow[convTeachCase_Resource_Rel.ResourceName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ResourceName].ToString().Trim(); //资源名称
objvTeachCase_Resource_RelEN.IdFtpResource = objRow[convTeachCase_Resource_Rel.IdFtpResource] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvTeachCase_Resource_RelEN.IdFile = objRow[convTeachCase_Resource_Rel.IdFile] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.IdFile].ToString().Trim(); //文件流水号
objvTeachCase_Resource_RelEN.FileName = objRow[convTeachCase_Resource_Rel.FileName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileName].ToString().Trim(); //文件名称
objvTeachCase_Resource_RelEN.FileType = objRow[convTeachCase_Resource_Rel.FileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileType].ToString().Trim(); //文件类型
objvTeachCase_Resource_RelEN.SaveDate = objRow[convTeachCase_Resource_Rel.SaveDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileSize = objRow[convTeachCase_Resource_Rel.FileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileSize].ToString().Trim(); //文件大小
objvTeachCase_Resource_RelEN.SaveTime = objRow[convTeachCase_Resource_Rel.SaveTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.SaveTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.FtpResourceID = objRow[convTeachCase_Resource_Rel.FtpResourceID].ToString().Trim(); //FTP资源ID
objvTeachCase_Resource_RelEN.FileOriginalName = objRow[convTeachCase_Resource_Rel.FileOriginalName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginalName].ToString().Trim(); //文件原名
objvTeachCase_Resource_RelEN.FileDirName = objRow[convTeachCase_Resource_Rel.FileDirName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileDirName].ToString().Trim(); //文件目录名
objvTeachCase_Resource_RelEN.FileRename = objRow[convTeachCase_Resource_Rel.FileRename] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileRename].ToString().Trim(); //文件新名
objvTeachCase_Resource_RelEN.FileUpDate = objRow[convTeachCase_Resource_Rel.FileUpDate] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpDate].ToString().Trim(); //创建日期
objvTeachCase_Resource_RelEN.FileUpTime = objRow[convTeachCase_Resource_Rel.FileUpTime] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileUpTime].ToString().Trim(); //创建时间
objvTeachCase_Resource_RelEN.SaveMode = TransNullToBool(objRow[convTeachCase_Resource_Rel.SaveMode].ToString().Trim()); //文件存放方式
objvTeachCase_Resource_RelEN.IdResourceType = objRow[convTeachCase_Resource_Rel.IdResourceType].ToString().Trim(); //资源类型流水号
objvTeachCase_Resource_RelEN.ResourceTypeID = objRow[convTeachCase_Resource_Rel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvTeachCase_Resource_RelEN.ResourceTypeName = objRow[convTeachCase_Resource_Rel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvTeachCase_Resource_RelEN.ResourceOwner = objRow[convTeachCase_Resource_Rel.ResourceOwner].ToString().Trim(); //上传者
objvTeachCase_Resource_RelEN.ftpFileType = objRow[convTeachCase_Resource_Rel.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCase_Resource_RelEN.ftpFileSize = objRow[convTeachCase_Resource_Rel.ftpFileSize] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpFileSize].ToString().Trim(); //ftp文件大小
objvTeachCase_Resource_RelEN.ftpResourceOwner = objRow[convTeachCase_Resource_Rel.ftpResourceOwner] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.ftpResourceOwner].ToString().Trim(); //Ftp资源拥有者
objvTeachCase_Resource_RelEN.FileOriginName = objRow[convTeachCase_Resource_Rel.FileOriginName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOriginName].ToString().Trim(); //原文件名
objvTeachCase_Resource_RelEN.IsExistFile = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsExistFile].ToString().Trim()); //是否存在文件
objvTeachCase_Resource_RelEN.FileNewName = objRow[convTeachCase_Resource_Rel.FileNewName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileNewName].ToString().Trim(); //新文件名
objvTeachCase_Resource_RelEN.FileOldName = objRow[convTeachCase_Resource_Rel.FileOldName] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.FileOldName].ToString().Trim(); //旧文件名
objvTeachCase_Resource_RelEN.IsMain = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsMain].ToString().Trim()); //是否主资源
objvTeachCase_Resource_RelEN.Memo = objRow[convTeachCase_Resource_Rel.Memo] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.Memo].ToString().Trim(); //备注
objvTeachCase_Resource_RelEN.IndexNO = objRow[convTeachCase_Resource_Rel.IndexNO] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.IndexNO].ToString().Trim()); //序号
objvTeachCase_Resource_RelEN.IsVisible = TransNullToBool(objRow[convTeachCase_Resource_Rel.IsVisible].ToString().Trim()); //是否显示
objvTeachCase_Resource_RelEN.BrowseCount = objRow[convTeachCase_Resource_Rel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase_Resource_Rel.BrowseCount].ToString().Trim()); //浏览次数
objvTeachCase_Resource_RelEN.CollegeNameA = objRow[convTeachCase_Resource_Rel.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase_Resource_Rel.CollegeNameA].ToString().Trim(); //学院名称简写
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachCase_Resource_RelDA: GetObjByDataRow)", objException.Message));
}
objvTeachCase_Resource_RelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCase_Resource_RelEN;
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
objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCase_Resource_RelEN._CurrTabName, convTeachCase_Resource_Rel.IdTeachCaseResourceRel, 8, "");
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
objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCase_Resource_RelEN._CurrTabName, convTeachCase_Resource_Rel.IdTeachCaseResourceRel, 8, strPrefix);
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCaseResourceRel from vTeachCase_Resource_Rel where " + strCondition;
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCaseResourceRel from vTeachCase_Resource_Rel where " + strCondition;
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
 /// <param name = "lngIdTeachCaseResourceRel">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdTeachCaseResourceRel)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCase_Resource_Rel", "IdTeachCaseResourceRel = " + ""+ lngIdTeachCaseResourceRel+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachCase_Resource_RelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCase_Resource_Rel", strCondition))
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
objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachCase_Resource_Rel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachCase_Resource_RelENS">源对象</param>
 /// <param name = "objvTeachCase_Resource_RelENT">目标对象</param>
public void CopyTo(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENS, clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelENT)
{
objvTeachCase_Resource_RelENT.IdTeachCaseResourceRel = objvTeachCase_Resource_RelENS.IdTeachCaseResourceRel; //案例与资源表系表流水号
objvTeachCase_Resource_RelENT.IdTeachCase = objvTeachCase_Resource_RelENS.IdTeachCase; //案例流水号
objvTeachCase_Resource_RelENT.TeachCaseID = objvTeachCase_Resource_RelENS.TeachCaseID; //案例ID
objvTeachCase_Resource_RelENT.TeachCaseName = objvTeachCase_Resource_RelENS.TeachCaseName; //案例名称
objvTeachCase_Resource_RelENT.TeachCaseExecutor = objvTeachCase_Resource_RelENS.TeachCaseExecutor; //案例执教者
objvTeachCase_Resource_RelENT.TeachCaseTheme = objvTeachCase_Resource_RelENS.TeachCaseTheme; //案例主题词
objvTeachCase_Resource_RelENT.TeachCaseBG = objvTeachCase_Resource_RelENS.TeachCaseBG; //案例背景资料
objvTeachCase_Resource_RelENT.IdTeachSkill = objvTeachCase_Resource_RelENS.IdTeachSkill; //教学技能流水号
objvTeachCase_Resource_RelENT.TeachSkillID = objvTeachCase_Resource_RelENS.TeachSkillID; //教学技能ID
objvTeachCase_Resource_RelENT.SkillTypeName = objvTeachCase_Resource_RelENS.SkillTypeName; //技能类型名称
objvTeachCase_Resource_RelENT.TeachSkillName = objvTeachCase_Resource_RelENS.TeachSkillName; //教学技能名称
objvTeachCase_Resource_RelENT.TeachSkillTheory = objvTeachCase_Resource_RelENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCase_Resource_RelENT.TeachSkillOperMethod = objvTeachCase_Resource_RelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCase_Resource_RelENT.IdSkillType = objvTeachCase_Resource_RelENS.IdSkillType; //技能类型流水号
objvTeachCase_Resource_RelENT.SkillTypeID = objvTeachCase_Resource_RelENS.SkillTypeID; //技能类型ID
objvTeachCase_Resource_RelENT.IdDiscipline = objvTeachCase_Resource_RelENS.IdDiscipline; //学科流水号
objvTeachCase_Resource_RelENT.DisciplineName = objvTeachCase_Resource_RelENS.DisciplineName; //学科名称
objvTeachCase_Resource_RelENT.IdStudyLevel = objvTeachCase_Resource_RelENS.IdStudyLevel; //id_StudyLevel
objvTeachCase_Resource_RelENT.StudyLevelName = objvTeachCase_Resource_RelENS.StudyLevelName; //学段名称
objvTeachCase_Resource_RelENT.TeachCaseDateIn = objvTeachCase_Resource_RelENS.TeachCaseDateIn; //案例入库日期
objvTeachCase_Resource_RelENT.IdTeachingPlan = objvTeachCase_Resource_RelENS.IdTeachingPlan; //教案流水号
objvTeachCase_Resource_RelENT.TeachCaseTimeIn = objvTeachCase_Resource_RelENS.TeachCaseTimeIn; //案例入库时间
objvTeachCase_Resource_RelENT.WorkUnit = objvTeachCase_Resource_RelENS.WorkUnit; //工作单位
objvTeachCase_Resource_RelENT.CDID = objvTeachCase_Resource_RelENS.CDID; //光盘编号
objvTeachCase_Resource_RelENT.IsDualVideo = objvTeachCase_Resource_RelENS.IsDualVideo; //是否双视频
objvTeachCase_Resource_RelENT.IdXzCollege = objvTeachCase_Resource_RelENS.IdXzCollege; //学院流水号
objvTeachCase_Resource_RelENT.CollegeID = objvTeachCase_Resource_RelENS.CollegeID; //学院ID
objvTeachCase_Resource_RelENT.CollegeName = objvTeachCase_Resource_RelENS.CollegeName; //学院名称
objvTeachCase_Resource_RelENT.RecommendedDegreeId = objvTeachCase_Resource_RelENS.RecommendedDegreeId; //推荐度Id
objvTeachCase_Resource_RelENT.RecommendedDegreeName = objvTeachCase_Resource_RelENS.RecommendedDegreeName; //推荐度名称
objvTeachCase_Resource_RelENT.BrowseCount4Case = objvTeachCase_Resource_RelENS.BrowseCount4Case; //课例浏览次数
objvTeachCase_Resource_RelENT.IdResource = objvTeachCase_Resource_RelENS.IdResource; //资源流水号
objvTeachCase_Resource_RelENT.ResourceID = objvTeachCase_Resource_RelENS.ResourceID; //资源ID
objvTeachCase_Resource_RelENT.ResourceName = objvTeachCase_Resource_RelENS.ResourceName; //资源名称
objvTeachCase_Resource_RelENT.IdFtpResource = objvTeachCase_Resource_RelENS.IdFtpResource; //FTP资源流水号
objvTeachCase_Resource_RelENT.IdFile = objvTeachCase_Resource_RelENS.IdFile; //文件流水号
objvTeachCase_Resource_RelENT.FileName = objvTeachCase_Resource_RelENS.FileName; //文件名称
objvTeachCase_Resource_RelENT.FileType = objvTeachCase_Resource_RelENS.FileType; //文件类型
objvTeachCase_Resource_RelENT.SaveDate = objvTeachCase_Resource_RelENS.SaveDate; //创建日期
objvTeachCase_Resource_RelENT.FileSize = objvTeachCase_Resource_RelENS.FileSize; //文件大小
objvTeachCase_Resource_RelENT.SaveTime = objvTeachCase_Resource_RelENS.SaveTime; //创建时间
objvTeachCase_Resource_RelENT.FtpResourceID = objvTeachCase_Resource_RelENS.FtpResourceID; //FTP资源ID
objvTeachCase_Resource_RelENT.FileOriginalName = objvTeachCase_Resource_RelENS.FileOriginalName; //文件原名
objvTeachCase_Resource_RelENT.FileDirName = objvTeachCase_Resource_RelENS.FileDirName; //文件目录名
objvTeachCase_Resource_RelENT.FileRename = objvTeachCase_Resource_RelENS.FileRename; //文件新名
objvTeachCase_Resource_RelENT.FileUpDate = objvTeachCase_Resource_RelENS.FileUpDate; //创建日期
objvTeachCase_Resource_RelENT.FileUpTime = objvTeachCase_Resource_RelENS.FileUpTime; //创建时间
objvTeachCase_Resource_RelENT.SaveMode = objvTeachCase_Resource_RelENS.SaveMode; //文件存放方式
objvTeachCase_Resource_RelENT.IdResourceType = objvTeachCase_Resource_RelENS.IdResourceType; //资源类型流水号
objvTeachCase_Resource_RelENT.ResourceTypeID = objvTeachCase_Resource_RelENS.ResourceTypeID; //资源类型ID
objvTeachCase_Resource_RelENT.ResourceTypeName = objvTeachCase_Resource_RelENS.ResourceTypeName; //资源类型名称
objvTeachCase_Resource_RelENT.ResourceOwner = objvTeachCase_Resource_RelENS.ResourceOwner; //上传者
objvTeachCase_Resource_RelENT.ftpFileType = objvTeachCase_Resource_RelENS.ftpFileType; //ftp文件类型
objvTeachCase_Resource_RelENT.ftpFileSize = objvTeachCase_Resource_RelENS.ftpFileSize; //ftp文件大小
objvTeachCase_Resource_RelENT.ftpResourceOwner = objvTeachCase_Resource_RelENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachCase_Resource_RelENT.FileOriginName = objvTeachCase_Resource_RelENS.FileOriginName; //原文件名
objvTeachCase_Resource_RelENT.IsExistFile = objvTeachCase_Resource_RelENS.IsExistFile; //是否存在文件
objvTeachCase_Resource_RelENT.FileNewName = objvTeachCase_Resource_RelENS.FileNewName; //新文件名
objvTeachCase_Resource_RelENT.FileOldName = objvTeachCase_Resource_RelENS.FileOldName; //旧文件名
objvTeachCase_Resource_RelENT.IsMain = objvTeachCase_Resource_RelENS.IsMain; //是否主资源
objvTeachCase_Resource_RelENT.Memo = objvTeachCase_Resource_RelENS.Memo; //备注
objvTeachCase_Resource_RelENT.IndexNO = objvTeachCase_Resource_RelENS.IndexNO; //序号
objvTeachCase_Resource_RelENT.IsVisible = objvTeachCase_Resource_RelENS.IsVisible; //是否显示
objvTeachCase_Resource_RelENT.BrowseCount = objvTeachCase_Resource_RelENS.BrowseCount; //浏览次数
objvTeachCase_Resource_RelENT.CollegeNameA = objvTeachCase_Resource_RelENS.CollegeNameA; //学院名称简写
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachCase_Resource_RelEN objvTeachCase_Resource_RelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdTeachCase, 8, convTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseID, 8, convTeachCase_Resource_Rel.TeachCaseID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseName, 200, convTeachCase_Resource_Rel.TeachCaseName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseExecutor, 50, convTeachCase_Resource_Rel.TeachCaseExecutor);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseTheme, 200, convTeachCase_Resource_Rel.TeachCaseTheme);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseBG, 8000, convTeachCase_Resource_Rel.TeachCaseBG);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdTeachSkill, 8, convTeachCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachSkillID, 8, convTeachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.SkillTypeName, 50, convTeachCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachSkillName, 50, convTeachCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachSkillTheory, 8000, convTeachCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachSkillOperMethod, 2000, convTeachCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdSkillType, 4, convTeachCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.SkillTypeID, 4, convTeachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdDiscipline, 4, convTeachCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.DisciplineName, 50, convTeachCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdStudyLevel, 4, convTeachCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.StudyLevelName, 50, convTeachCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseDateIn, 8, convTeachCase_Resource_Rel.TeachCaseDateIn);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdTeachingPlan, 8, convTeachCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.TeachCaseTimeIn, 6, convTeachCase_Resource_Rel.TeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.WorkUnit, 100, convTeachCase_Resource_Rel.WorkUnit);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.CDID, 50, convTeachCase_Resource_Rel.CDID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdXzCollege, 4, convTeachCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.CollegeID, 4, convTeachCase_Resource_Rel.CollegeID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.CollegeName, 100, convTeachCase_Resource_Rel.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.RecommendedDegreeId, 2, convTeachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.RecommendedDegreeName, 30, convTeachCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdResource, 8, convTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ResourceID, 8, convTeachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ResourceName, 100, convTeachCase_Resource_Rel.ResourceName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdFtpResource, 8, convTeachCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdFile, 8, convTeachCase_Resource_Rel.IdFile);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileName, 500, convTeachCase_Resource_Rel.FileName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileType, 30, convTeachCase_Resource_Rel.FileType);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.SaveDate, 8, convTeachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileSize, 50, convTeachCase_Resource_Rel.FileSize);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.SaveTime, 6, convTeachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FtpResourceID, 8, convTeachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileOriginalName, 200, convTeachCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileDirName, 200, convTeachCase_Resource_Rel.FileDirName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileRename, 200, convTeachCase_Resource_Rel.FileRename);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileUpDate, 8, convTeachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileUpTime, 6, convTeachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.IdResourceType, 4, convTeachCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ResourceTypeID, 4, convTeachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ResourceTypeName, 50, convTeachCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ResourceOwner, 50, convTeachCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ftpFileType, 30, convTeachCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ftpFileSize, 50, convTeachCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.ftpResourceOwner, 50, convTeachCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileOriginName, 500, convTeachCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileNewName, 530, convTeachCase_Resource_Rel.FileNewName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.FileOldName, 530, convTeachCase_Resource_Rel.FileOldName);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.Memo, 1000, convTeachCase_Resource_Rel.Memo);
clsCheckSql.CheckFieldLen(objvTeachCase_Resource_RelEN.CollegeNameA, 12, convTeachCase_Resource_Rel.CollegeNameA);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdTeachCase, convTeachCase_Resource_Rel.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseID, convTeachCase_Resource_Rel.TeachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseName, convTeachCase_Resource_Rel.TeachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseExecutor, convTeachCase_Resource_Rel.TeachCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseTheme, convTeachCase_Resource_Rel.TeachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseBG, convTeachCase_Resource_Rel.TeachCaseBG);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdTeachSkill, convTeachCase_Resource_Rel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachSkillID, convTeachCase_Resource_Rel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.SkillTypeName, convTeachCase_Resource_Rel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachSkillName, convTeachCase_Resource_Rel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachSkillTheory, convTeachCase_Resource_Rel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachSkillOperMethod, convTeachCase_Resource_Rel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdSkillType, convTeachCase_Resource_Rel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.SkillTypeID, convTeachCase_Resource_Rel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdDiscipline, convTeachCase_Resource_Rel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.DisciplineName, convTeachCase_Resource_Rel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdStudyLevel, convTeachCase_Resource_Rel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.StudyLevelName, convTeachCase_Resource_Rel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseDateIn, convTeachCase_Resource_Rel.TeachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdTeachingPlan, convTeachCase_Resource_Rel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.TeachCaseTimeIn, convTeachCase_Resource_Rel.TeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.WorkUnit, convTeachCase_Resource_Rel.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.CDID, convTeachCase_Resource_Rel.CDID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdXzCollege, convTeachCase_Resource_Rel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.CollegeID, convTeachCase_Resource_Rel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.CollegeName, convTeachCase_Resource_Rel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.RecommendedDegreeId, convTeachCase_Resource_Rel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.RecommendedDegreeName, convTeachCase_Resource_Rel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdResource, convTeachCase_Resource_Rel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ResourceID, convTeachCase_Resource_Rel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ResourceName, convTeachCase_Resource_Rel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdFtpResource, convTeachCase_Resource_Rel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdFile, convTeachCase_Resource_Rel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileName, convTeachCase_Resource_Rel.FileName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileType, convTeachCase_Resource_Rel.FileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.SaveDate, convTeachCase_Resource_Rel.SaveDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileSize, convTeachCase_Resource_Rel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.SaveTime, convTeachCase_Resource_Rel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FtpResourceID, convTeachCase_Resource_Rel.FtpResourceID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileOriginalName, convTeachCase_Resource_Rel.FileOriginalName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileDirName, convTeachCase_Resource_Rel.FileDirName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileRename, convTeachCase_Resource_Rel.FileRename);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileUpDate, convTeachCase_Resource_Rel.FileUpDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileUpTime, convTeachCase_Resource_Rel.FileUpTime);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.IdResourceType, convTeachCase_Resource_Rel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ResourceTypeID, convTeachCase_Resource_Rel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ResourceTypeName, convTeachCase_Resource_Rel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ResourceOwner, convTeachCase_Resource_Rel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ftpFileType, convTeachCase_Resource_Rel.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ftpFileSize, convTeachCase_Resource_Rel.ftpFileSize);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.ftpResourceOwner, convTeachCase_Resource_Rel.ftpResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileOriginName, convTeachCase_Resource_Rel.FileOriginName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileNewName, convTeachCase_Resource_Rel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.FileOldName, convTeachCase_Resource_Rel.FileOldName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.Memo, convTeachCase_Resource_Rel.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTeachCase_Resource_RelEN.CollegeNameA, convTeachCase_Resource_Rel.CollegeNameA);
//检查外键字段长度
 objvTeachCase_Resource_RelEN._IsCheckProperty = true;
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCase_Resource_RelEN._CurrTabName);
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCase_Resource_RelEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachCase_Resource_RelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}