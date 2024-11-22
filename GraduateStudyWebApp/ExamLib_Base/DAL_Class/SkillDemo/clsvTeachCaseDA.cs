
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachCaseDA
 表名:vTeachCase(01120384)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:49
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
 /// 技能案例视图(vTeachCase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachCaseDA : clsCommBase4DA
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
 return clsvTeachCaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachCaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachCaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachCaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachCaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdTeachCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdTeachCase)
{
strIdTeachCase = strIdTeachCase.Replace("'", "''");
if (strIdTeachCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTeachCase中,检查关键字,长度不正确!(clsvTeachCaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdTeachCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachCase中,关键字不能为空 或 null!(clsvTeachCaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdTeachCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachCaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachCase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable_vTeachCase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCase.* from vTeachCase Left Join {1} on {2} where {3} and vTeachCase.IdTeachCase not in (Select top {5} vTeachCase.IdTeachCase from vTeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1} and IdTeachCase not in (Select top {2} IdTeachCase from vTeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1} and IdTeachCase not in (Select top {3} IdTeachCase from vTeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachCaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachCase.* from vTeachCase Left Join {1} on {2} where {3} and vTeachCase.IdTeachCase not in (Select top {5} vTeachCase.IdTeachCase from vTeachCase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1} and IdTeachCase not in (Select top {2} IdTeachCase from vTeachCase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachCase where {1} and IdTeachCase not in (Select top {3} IdTeachCase from vTeachCase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachCaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachCaseDA:GetObjLst)", objException.Message));
}
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = TransNullToBool(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCaseDA: GetObjLst)", objException.Message));
}
objvTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCaseEN);
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
public List<clsvTeachCaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachCaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachCaseEN> arrObjLst = new List<clsvTeachCaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = TransNullToBool(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachCaseDA: GetObjLst)", objException.Message));
}
objvTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachCaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachCaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachCase(ref clsvTeachCaseEN objvTeachCaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where IdTeachCase = " + "'"+ objvTeachCaseEN.IdTeachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachCaseEN.IdTeachCase = objDT.Rows[0][convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseID = objDT.Rows[0][convTeachCase.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseName = objDT.Rows[0][convTeachCase.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCaseEN.TeachCaseExecutor = objDT.Rows[0][convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseEN.TeachCaseTheme = objDT.Rows[0][convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseEN.TeachCaseBG = objDT.Rows[0][convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCaseEN.IdTeachSkill = objDT.Rows[0][convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachSkillID = objDT.Rows[0][convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.SkillTypeName = objDT.Rows[0][convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachSkillName = objDT.Rows[0][convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachSkillTheory = objDT.Rows[0][convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCaseEN.TeachSkillOperMethod = objDT.Rows[0][convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachCaseEN.IdSkillType = objDT.Rows[0][convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.SkillTypeID = objDT.Rows[0][convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.IdDiscipline = objDT.Rows[0][convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.DisciplineName = objDT.Rows[0][convTeachCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.IdStudyLevel = objDT.Rows[0][convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCaseEN.StudyLevelName = objDT.Rows[0][convTeachCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachCaseDateIn = objDT.Rows[0][convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseEN.IdTeachingPlan = objDT.Rows[0][convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseTimeIn = objDT.Rows[0][convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseEN.WorkUnit = objDT.Rows[0][convTeachCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachCaseEN.CDID = objDT.Rows[0][convTeachCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachCaseEN.IdXzCollege = objDT.Rows[0][convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCaseEN.CollegeID = objDT.Rows[0][convTeachCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachCaseEN.CollegeName = objDT.Rows[0][convTeachCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCaseEN.CollegeNameA = objDT.Rows[0][convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachCaseEN.RecommendedDegreeId = objDT.Rows[0][convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachCaseEN.RecommendedDegreeName = objDT.Rows[0][convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachCaseEN.ftpFileType = objDT.Rows[0][convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseEN.VideoUrl = objDT.Rows[0][convTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.VideoPath = objDT.Rows[0][convTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.ResErrMsg = objDT.Rows[0][convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseEN.Memo = objDT.Rows[0][convTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachCaseDA: GetvTeachCase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdTeachCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachCaseEN GetObjByIdTeachCase(string strIdTeachCase)
{
CheckPrimaryKey(strIdTeachCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where IdTeachCase = " + "'"+ strIdTeachCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
 objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:200,是否可空:False)
 objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号(字段类型:varchar,字段长度:50,是否可空:True)
 objvTeachCaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvTeachCaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息(字段类型:varchar,字段长度:30,是否可空:True)
 objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachCaseDA: GetObjByIdTeachCase)", objException.Message));
}
return objvTeachCaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachCaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachCaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
strSQL = "Select * from vTeachCase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN()
{
IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(), //案例流水号
TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(), //案例ID
TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(), //案例名称
TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(), //案例执教者
TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(), //案例主题词
TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(), //案例背景资料
IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(), //技能类型ID
IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(), //学科名称
IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(), //学段名称
TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(), //案例入库日期
IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(), //教案流水号
TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(), //案例入库时间
WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(), //工作单位
CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(), //光盘编号
IsVisible = TransNullToBool(objRow[convTeachCase.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convTeachCase.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(), //学院名称简写
RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(), //推荐度名称
ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(), //ftp文件类型
VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(), //视频Url
VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(), //视频目录
ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(), //资源错误信息
Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()) //课例浏览次数
};
objvTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachCaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachCaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = TransNullToBool(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachCaseDA: GetObjByDataRowvTeachCase)", objException.Message));
}
objvTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachCaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachCaseEN objvTeachCaseEN = new clsvTeachCaseEN();
try
{
objvTeachCaseEN.IdTeachCase = objRow[convTeachCase.IdTeachCase].ToString().Trim(); //案例流水号
objvTeachCaseEN.TeachCaseID = objRow[convTeachCase.TeachCaseID].ToString().Trim(); //案例ID
objvTeachCaseEN.TeachCaseName = objRow[convTeachCase.TeachCaseName].ToString().Trim(); //案例名称
objvTeachCaseEN.TeachCaseExecutor = objRow[convTeachCase.TeachCaseExecutor] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseExecutor].ToString().Trim(); //案例执教者
objvTeachCaseEN.TeachCaseTheme = objRow[convTeachCase.TeachCaseTheme] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTheme].ToString().Trim(); //案例主题词
objvTeachCaseEN.TeachCaseBG = objRow[convTeachCase.TeachCaseBG] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseBG].ToString().Trim(); //案例背景资料
objvTeachCaseEN.IdTeachSkill = objRow[convTeachCase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvTeachCaseEN.TeachSkillID = objRow[convTeachCase.TeachSkillID].ToString().Trim(); //教学技能ID
objvTeachCaseEN.SkillTypeName = objRow[convTeachCase.SkillTypeName] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeName].ToString().Trim(); //技能类型名称
objvTeachCaseEN.TeachSkillName = objRow[convTeachCase.TeachSkillName].ToString().Trim(); //教学技能名称
objvTeachCaseEN.TeachSkillTheory = objRow[convTeachCase.TeachSkillTheory] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvTeachCaseEN.TeachSkillOperMethod = objRow[convTeachCase.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convTeachCase.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvTeachCaseEN.IdSkillType = objRow[convTeachCase.IdSkillType] == DBNull.Value ? null : objRow[convTeachCase.IdSkillType].ToString().Trim(); //技能类型流水号
objvTeachCaseEN.SkillTypeID = objRow[convTeachCase.SkillTypeID] == DBNull.Value ? null : objRow[convTeachCase.SkillTypeID].ToString().Trim(); //技能类型ID
objvTeachCaseEN.IdDiscipline = objRow[convTeachCase.IdDiscipline].ToString().Trim(); //学科流水号
objvTeachCaseEN.DisciplineName = objRow[convTeachCase.DisciplineName].ToString().Trim(); //学科名称
objvTeachCaseEN.IdStudyLevel = objRow[convTeachCase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvTeachCaseEN.StudyLevelName = objRow[convTeachCase.StudyLevelName].ToString().Trim(); //学段名称
objvTeachCaseEN.TeachCaseDateIn = objRow[convTeachCase.TeachCaseDateIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseDateIn].ToString().Trim(); //案例入库日期
objvTeachCaseEN.IdTeachingPlan = objRow[convTeachCase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvTeachCaseEN.TeachCaseTimeIn = objRow[convTeachCase.TeachCaseTimeIn] == DBNull.Value ? null : objRow[convTeachCase.TeachCaseTimeIn].ToString().Trim(); //案例入库时间
objvTeachCaseEN.WorkUnit = objRow[convTeachCase.WorkUnit] == DBNull.Value ? null : objRow[convTeachCase.WorkUnit].ToString().Trim(); //工作单位
objvTeachCaseEN.CDID = objRow[convTeachCase.CDID] == DBNull.Value ? null : objRow[convTeachCase.CDID].ToString().Trim(); //光盘编号
objvTeachCaseEN.IsVisible = TransNullToBool(objRow[convTeachCase.IsVisible].ToString().Trim()); //是否显示
objvTeachCaseEN.IsDualVideo = TransNullToBool(objRow[convTeachCase.IsDualVideo].ToString().Trim()); //是否双视频
objvTeachCaseEN.IdXzCollege = objRow[convTeachCase.IdXzCollege] == DBNull.Value ? null : objRow[convTeachCase.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachCaseEN.CollegeID = objRow[convTeachCase.CollegeID] == DBNull.Value ? null : objRow[convTeachCase.CollegeID].ToString().Trim(); //学院ID
objvTeachCaseEN.CollegeName = objRow[convTeachCase.CollegeName] == DBNull.Value ? null : objRow[convTeachCase.CollegeName].ToString().Trim(); //学院名称
objvTeachCaseEN.CollegeNameA = objRow[convTeachCase.CollegeNameA] == DBNull.Value ? null : objRow[convTeachCase.CollegeNameA].ToString().Trim(); //学院名称简写
objvTeachCaseEN.RecommendedDegreeId = objRow[convTeachCase.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvTeachCaseEN.RecommendedDegreeName = objRow[convTeachCase.RecommendedDegreeName] == DBNull.Value ? null : objRow[convTeachCase.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvTeachCaseEN.ftpFileType = objRow[convTeachCase.ftpFileType] == DBNull.Value ? null : objRow[convTeachCase.ftpFileType].ToString().Trim(); //ftp文件类型
objvTeachCaseEN.VideoUrl = objRow[convTeachCase.VideoUrl] == DBNull.Value ? null : objRow[convTeachCase.VideoUrl].ToString().Trim(); //视频Url
objvTeachCaseEN.VideoPath = objRow[convTeachCase.VideoPath] == DBNull.Value ? null : objRow[convTeachCase.VideoPath].ToString().Trim(); //视频目录
objvTeachCaseEN.ResErrMsg = objRow[convTeachCase.ResErrMsg] == DBNull.Value ? null : objRow[convTeachCase.ResErrMsg].ToString().Trim(); //资源错误信息
objvTeachCaseEN.Memo = objRow[convTeachCase.Memo] == DBNull.Value ? null : objRow[convTeachCase.Memo].ToString().Trim(); //备注
objvTeachCaseEN.BrowseCount4Case = objRow[convTeachCase.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTeachCase.BrowseCount4Case].ToString().Trim()); //课例浏览次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachCaseDA: GetObjByDataRow)", objException.Message));
}
objvTeachCaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachCaseEN;
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
objSQL = clsvTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCaseEN._CurrTabName, convTeachCase.IdTeachCase, 8, "");
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
objSQL = clsvTeachCaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachCaseEN._CurrTabName, convTeachCase.IdTeachCase, 8, strPrefix);
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdTeachCase from vTeachCase where " + strCondition;
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdTeachCase from vTeachCase where " + strCondition;
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
 /// <param name = "strIdTeachCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdTeachCase)
{
CheckPrimaryKey(strIdTeachCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCase", "IdTeachCase = " + "'"+ strIdTeachCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachCaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachCase", strCondition))
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
objSQL = clsvTeachCaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachCase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachCaseENS">源对象</param>
 /// <param name = "objvTeachCaseENT">目标对象</param>
public void CopyTo(clsvTeachCaseEN objvTeachCaseENS, clsvTeachCaseEN objvTeachCaseENT)
{
objvTeachCaseENT.IdTeachCase = objvTeachCaseENS.IdTeachCase; //案例流水号
objvTeachCaseENT.TeachCaseID = objvTeachCaseENS.TeachCaseID; //案例ID
objvTeachCaseENT.TeachCaseName = objvTeachCaseENS.TeachCaseName; //案例名称
objvTeachCaseENT.TeachCaseExecutor = objvTeachCaseENS.TeachCaseExecutor; //案例执教者
objvTeachCaseENT.TeachCaseTheme = objvTeachCaseENS.TeachCaseTheme; //案例主题词
objvTeachCaseENT.TeachCaseBG = objvTeachCaseENS.TeachCaseBG; //案例背景资料
objvTeachCaseENT.IdTeachSkill = objvTeachCaseENS.IdTeachSkill; //教学技能流水号
objvTeachCaseENT.TeachSkillID = objvTeachCaseENS.TeachSkillID; //教学技能ID
objvTeachCaseENT.SkillTypeName = objvTeachCaseENS.SkillTypeName; //技能类型名称
objvTeachCaseENT.TeachSkillName = objvTeachCaseENS.TeachSkillName; //教学技能名称
objvTeachCaseENT.TeachSkillTheory = objvTeachCaseENS.TeachSkillTheory; //教学技能理论阐述
objvTeachCaseENT.TeachSkillOperMethod = objvTeachCaseENS.TeachSkillOperMethod; //教学技能实践操作方法
objvTeachCaseENT.IdSkillType = objvTeachCaseENS.IdSkillType; //技能类型流水号
objvTeachCaseENT.SkillTypeID = objvTeachCaseENS.SkillTypeID; //技能类型ID
objvTeachCaseENT.IdDiscipline = objvTeachCaseENS.IdDiscipline; //学科流水号
objvTeachCaseENT.DisciplineName = objvTeachCaseENS.DisciplineName; //学科名称
objvTeachCaseENT.IdStudyLevel = objvTeachCaseENS.IdStudyLevel; //id_StudyLevel
objvTeachCaseENT.StudyLevelName = objvTeachCaseENS.StudyLevelName; //学段名称
objvTeachCaseENT.TeachCaseDateIn = objvTeachCaseENS.TeachCaseDateIn; //案例入库日期
objvTeachCaseENT.IdTeachingPlan = objvTeachCaseENS.IdTeachingPlan; //教案流水号
objvTeachCaseENT.TeachCaseTimeIn = objvTeachCaseENS.TeachCaseTimeIn; //案例入库时间
objvTeachCaseENT.WorkUnit = objvTeachCaseENS.WorkUnit; //工作单位
objvTeachCaseENT.CDID = objvTeachCaseENS.CDID; //光盘编号
objvTeachCaseENT.IsVisible = objvTeachCaseENS.IsVisible; //是否显示
objvTeachCaseENT.IsDualVideo = objvTeachCaseENS.IsDualVideo; //是否双视频
objvTeachCaseENT.IdXzCollege = objvTeachCaseENS.IdXzCollege; //学院流水号
objvTeachCaseENT.CollegeID = objvTeachCaseENS.CollegeID; //学院ID
objvTeachCaseENT.CollegeName = objvTeachCaseENS.CollegeName; //学院名称
objvTeachCaseENT.CollegeNameA = objvTeachCaseENS.CollegeNameA; //学院名称简写
objvTeachCaseENT.RecommendedDegreeId = objvTeachCaseENS.RecommendedDegreeId; //推荐度Id
objvTeachCaseENT.RecommendedDegreeName = objvTeachCaseENS.RecommendedDegreeName; //推荐度名称
objvTeachCaseENT.ftpFileType = objvTeachCaseENS.ftpFileType; //ftp文件类型
objvTeachCaseENT.VideoUrl = objvTeachCaseENS.VideoUrl; //视频Url
objvTeachCaseENT.VideoPath = objvTeachCaseENS.VideoPath; //视频目录
objvTeachCaseENT.ResErrMsg = objvTeachCaseENS.ResErrMsg; //资源错误信息
objvTeachCaseENT.Memo = objvTeachCaseENS.Memo; //备注
objvTeachCaseENT.BrowseCount4Case = objvTeachCaseENS.BrowseCount4Case; //课例浏览次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachCaseEN objvTeachCaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdTeachCase, 8, convTeachCase.IdTeachCase);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseID, 8, convTeachCase.TeachCaseID);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseName, 200, convTeachCase.TeachCaseName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseExecutor, 50, convTeachCase.TeachCaseExecutor);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseTheme, 200, convTeachCase.TeachCaseTheme);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseBG, 8000, convTeachCase.TeachCaseBG);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdTeachSkill, 8, convTeachCase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachSkillID, 8, convTeachCase.TeachSkillID);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.SkillTypeName, 50, convTeachCase.SkillTypeName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachSkillName, 50, convTeachCase.TeachSkillName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachSkillTheory, 8000, convTeachCase.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachSkillOperMethod, 2000, convTeachCase.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdSkillType, 4, convTeachCase.IdSkillType);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.SkillTypeID, 4, convTeachCase.SkillTypeID);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdDiscipline, 4, convTeachCase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.DisciplineName, 50, convTeachCase.DisciplineName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdStudyLevel, 4, convTeachCase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.StudyLevelName, 50, convTeachCase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseDateIn, 8, convTeachCase.TeachCaseDateIn);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdTeachingPlan, 8, convTeachCase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.TeachCaseTimeIn, 6, convTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.WorkUnit, 100, convTeachCase.WorkUnit);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.CDID, 50, convTeachCase.CDID);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.IdXzCollege, 4, convTeachCase.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.CollegeID, 4, convTeachCase.CollegeID);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.CollegeName, 100, convTeachCase.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.CollegeNameA, 12, convTeachCase.CollegeNameA);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.RecommendedDegreeId, 2, convTeachCase.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.RecommendedDegreeName, 30, convTeachCase.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.ftpFileType, 30, convTeachCase.ftpFileType);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.VideoUrl, 1000, convTeachCase.VideoUrl);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.VideoPath, 1000, convTeachCase.VideoPath);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.ResErrMsg, 30, convTeachCase.ResErrMsg);
clsCheckSql.CheckFieldLen(objvTeachCaseEN.Memo, 1000, convTeachCase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdTeachCase, convTeachCase.IdTeachCase);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseID, convTeachCase.TeachCaseID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseName, convTeachCase.TeachCaseName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseExecutor, convTeachCase.TeachCaseExecutor);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseTheme, convTeachCase.TeachCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseBG, convTeachCase.TeachCaseBG);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdTeachSkill, convTeachCase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachSkillID, convTeachCase.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.SkillTypeName, convTeachCase.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachSkillName, convTeachCase.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachSkillTheory, convTeachCase.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachSkillOperMethod, convTeachCase.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdSkillType, convTeachCase.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.SkillTypeID, convTeachCase.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdDiscipline, convTeachCase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.DisciplineName, convTeachCase.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdStudyLevel, convTeachCase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.StudyLevelName, convTeachCase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseDateIn, convTeachCase.TeachCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdTeachingPlan, convTeachCase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.TeachCaseTimeIn, convTeachCase.TeachCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.WorkUnit, convTeachCase.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.CDID, convTeachCase.CDID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.IdXzCollege, convTeachCase.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.CollegeID, convTeachCase.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.CollegeName, convTeachCase.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.CollegeNameA, convTeachCase.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.RecommendedDegreeId, convTeachCase.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.RecommendedDegreeName, convTeachCase.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.ftpFileType, convTeachCase.ftpFileType);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.VideoUrl, convTeachCase.VideoUrl);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.VideoPath, convTeachCase.VideoPath);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.ResErrMsg, convTeachCase.ResErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvTeachCaseEN.Memo, convTeachCase.Memo);
//检查外键字段长度
 objvTeachCaseEN._IsCheckProperty = true;
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCaseEN._CurrTabName);
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachCaseEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachCaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}