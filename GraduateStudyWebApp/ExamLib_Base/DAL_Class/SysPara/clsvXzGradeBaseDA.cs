
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvXzGradeBaseDA
 表名:vXzGradeBase(01120130)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v年级(vXzGradeBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvXzGradeBaseDA : clsCommBase4DA
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
 return clsvXzGradeBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvXzGradeBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvXzGradeBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvXzGradeBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvXzGradeBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdGradeBase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdGradeBase)
{
strIdGradeBase = strIdGradeBase.Replace("'", "''");
if (strIdGradeBase.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vXzGradeBase中,检查关键字,长度不正确!(clsvXzGradeBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdGradeBase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vXzGradeBase中,关键字不能为空 或 null!(clsvXzGradeBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdGradeBase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvXzGradeBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vXzGradeBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable_vXzGradeBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzGradeBase.* from vXzGradeBase Left Join {1} on {2} where {3} and vXzGradeBase.IdGradeBase not in (Select top {5} vXzGradeBase.IdGradeBase from vXzGradeBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1} and IdGradeBase not in (Select top {2} IdGradeBase from vXzGradeBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1} and IdGradeBase not in (Select top {3} IdGradeBase from vXzGradeBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vXzGradeBase.* from vXzGradeBase Left Join {1} on {2} where {3} and vXzGradeBase.IdGradeBase not in (Select top {5} vXzGradeBase.IdGradeBase from vXzGradeBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1} and IdGradeBase not in (Select top {2} IdGradeBase from vXzGradeBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vXzGradeBase where {1} and IdGradeBase not in (Select top {3} IdGradeBase from vXzGradeBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvXzGradeBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA:GetObjLst)", objException.Message));
}
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = TransNullToBool(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = TransNullToBool(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzGradeBaseDA: GetObjLst)", objException.Message));
}
objvXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzGradeBaseEN);
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
public List<clsvXzGradeBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvXzGradeBaseEN> arrObjLst = new List<clsvXzGradeBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = TransNullToBool(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = TransNullToBool(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvXzGradeBaseDA: GetObjLst)", objException.Message));
}
objvXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvXzGradeBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvXzGradeBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvXzGradeBase(ref clsvXzGradeBaseEN objvXzGradeBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where IdGradeBase = " + "'"+ objvXzGradeBaseEN.IdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvXzGradeBaseEN.IdGradeBase = objDT.Rows[0][convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.GradeBaseId = objDT.Rows[0][convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.GradeBaseName = objDT.Rows[0][convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGradeBaseEN.GradeBaseNameA = objDT.Rows[0][convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvXzGradeBaseEN.SchoolYear = objDT.Rows[0][convXzGradeBase.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzGradeBaseEN.SchoolTerm = objDT.Rows[0][convXzGradeBase.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.EnterSchoolDate = objDT.Rows[0][convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objDT.Rows[0][convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期(字段类型:int,字段长度:4,是否可空:False)
 objvXzGradeBaseEN.ExecPlanTermIndex = TransNullToShort(objDT.Rows[0][convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期(字段类型:smallint,字段长度:2,是否可空:True)
 objvXzGradeBaseEN.SetEPTermIndexDate = objDT.Rows[0][convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期(字段类型:char,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.IsOffed = TransNullToBool(objDT.Rows[0][convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.GradeIndex = TransNullToInt(objDT.Rows[0][convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号(字段类型:int,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.BeginYearMonth = objDT.Rows[0][convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.EndYearMonth = objDT.Rows[0][convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objDT.Rows[0][convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.Prefix = objDT.Rows[0][convXzGradeBase.Prefix].ToString().Trim(); //前缀(字段类型:char,字段长度:3,是否可空:True)
 objvXzGradeBaseEN.PointCalcVersionId = objDT.Rows[0][convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id(字段类型:char,字段长度:2,是否可空:False)
 objvXzGradeBaseEN.ModifyUserId = objDT.Rows[0][convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzGradeBaseEN.ModifyDate = objDT.Rows[0][convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzGradeBaseEN.IdStudyLevel = objDT.Rows[0][convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.StudyLevelName = objDT.Rows[0][convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGradeBaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convXzGradeBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.Memo = objDT.Rows[0][convXzGradeBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvXzGradeBaseDA: GetvXzGradeBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdGradeBase">表关键字</param>
 /// <returns>表对象</returns>
public clsvXzGradeBaseEN GetObjByIdGradeBase(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where IdGradeBase = " + "'"+ strIdGradeBase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
 objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期(字段类型:char,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.CurrentTermSeq = Int32.Parse(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期(字段类型:int,字段长度:4,是否可空:False)
 objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期(字段类型:smallint,字段长度:2,是否可空:True)
 objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期(字段类型:char,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.IsOffed = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号(字段类型:int,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月(字段类型:varchar,字段长度:8,是否可空:True)
 objvXzGradeBaseEN.AllowUpBaseInfo = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀(字段类型:char,字段长度:3,是否可空:True)
 objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id(字段类型:char,字段长度:2,是否可空:False)
 objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvXzGradeBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvXzGradeBaseDA: GetObjByIdGradeBase)", objException.Message));
}
return objvXzGradeBaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvXzGradeBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
strSQL = "Select * from vXzGradeBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN()
{
IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(), //年级名称
GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(), //年级名称缩写
SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(), //学期
EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(), //进校日期
CurrentTermSeq = TransNullToInt(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()), //当前学期
ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()), //生成执行计划学期
SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(), //设定执行计划学期日期
IsOffed = TransNullToBool(objRow[convXzGradeBase.IsOffed].ToString().Trim()), //是否毕业
GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGradeBase.GradeIndex].ToString().Trim()), //年级序号
BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(), //开始年月
EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(), //结束年月
AllowUpBaseInfo = TransNullToBool(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()), //允许修改基本信息
Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(), //前缀
PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(), //绩点计算版本Id
ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(), //修改人
ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(), //修改日期
IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(), //学段名称
IsVisible = TransNullToBool(objRow[convXzGradeBase.IsVisible].ToString().Trim()), //是否显示
Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim() //备注
};
objvXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGradeBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvXzGradeBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvXzGradeBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = TransNullToBool(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = TransNullToBool(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvXzGradeBaseDA: GetObjByDataRowvXzGradeBase)", objException.Message));
}
objvXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGradeBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvXzGradeBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvXzGradeBaseEN objvXzGradeBaseEN = new clsvXzGradeBaseEN();
try
{
objvXzGradeBaseEN.IdGradeBase = objRow[convXzGradeBase.IdGradeBase].ToString().Trim(); //年级流水号
objvXzGradeBaseEN.GradeBaseId = objRow[convXzGradeBase.GradeBaseId] == DBNull.Value ? null : objRow[convXzGradeBase.GradeBaseId].ToString().Trim(); //年级代号
objvXzGradeBaseEN.GradeBaseName = objRow[convXzGradeBase.GradeBaseName].ToString().Trim(); //年级名称
objvXzGradeBaseEN.GradeBaseNameA = objRow[convXzGradeBase.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvXzGradeBaseEN.SchoolYear = objRow[convXzGradeBase.SchoolYear] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolYear].ToString().Trim(); //学年
objvXzGradeBaseEN.SchoolTerm = objRow[convXzGradeBase.SchoolTerm] == DBNull.Value ? null : objRow[convXzGradeBase.SchoolTerm].ToString().Trim(); //学期
objvXzGradeBaseEN.EnterSchoolDate = objRow[convXzGradeBase.EnterSchoolDate] == DBNull.Value ? null : objRow[convXzGradeBase.EnterSchoolDate].ToString().Trim(); //进校日期
objvXzGradeBaseEN.CurrentTermSeq = TransNullToInt(objRow[convXzGradeBase.CurrentTermSeq].ToString().Trim()); //当前学期
objvXzGradeBaseEN.ExecPlanTermIndex = objRow[convXzGradeBase.ExecPlanTermIndex] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convXzGradeBase.ExecPlanTermIndex].ToString().Trim()); //生成执行计划学期
objvXzGradeBaseEN.SetEPTermIndexDate = objRow[convXzGradeBase.SetEPTermIndexDate] == DBNull.Value ? null : objRow[convXzGradeBase.SetEPTermIndexDate].ToString().Trim(); //设定执行计划学期日期
objvXzGradeBaseEN.IsOffed = TransNullToBool(objRow[convXzGradeBase.IsOffed].ToString().Trim()); //是否毕业
objvXzGradeBaseEN.GradeIndex = objRow[convXzGradeBase.GradeIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convXzGradeBase.GradeIndex].ToString().Trim()); //年级序号
objvXzGradeBaseEN.BeginYearMonth = objRow[convXzGradeBase.BeginYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.BeginYearMonth].ToString().Trim(); //开始年月
objvXzGradeBaseEN.EndYearMonth = objRow[convXzGradeBase.EndYearMonth] == DBNull.Value ? null : objRow[convXzGradeBase.EndYearMonth].ToString().Trim(); //结束年月
objvXzGradeBaseEN.AllowUpBaseInfo = TransNullToBool(objRow[convXzGradeBase.AllowUpBaseInfo].ToString().Trim()); //允许修改基本信息
objvXzGradeBaseEN.Prefix = objRow[convXzGradeBase.Prefix] == DBNull.Value ? null : objRow[convXzGradeBase.Prefix].ToString().Trim(); //前缀
objvXzGradeBaseEN.PointCalcVersionId = objRow[convXzGradeBase.PointCalcVersionId].ToString().Trim(); //绩点计算版本Id
objvXzGradeBaseEN.ModifyUserId = objRow[convXzGradeBase.ModifyUserId] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyUserId].ToString().Trim(); //修改人
objvXzGradeBaseEN.ModifyDate = objRow[convXzGradeBase.ModifyDate] == DBNull.Value ? null : objRow[convXzGradeBase.ModifyDate].ToString().Trim(); //修改日期
objvXzGradeBaseEN.IdStudyLevel = objRow[convXzGradeBase.IdStudyLevel] == DBNull.Value ? null : objRow[convXzGradeBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvXzGradeBaseEN.StudyLevelName = objRow[convXzGradeBase.StudyLevelName] == DBNull.Value ? null : objRow[convXzGradeBase.StudyLevelName].ToString().Trim(); //学段名称
objvXzGradeBaseEN.IsVisible = TransNullToBool(objRow[convXzGradeBase.IsVisible].ToString().Trim()); //是否显示
objvXzGradeBaseEN.Memo = objRow[convXzGradeBase.Memo] == DBNull.Value ? null : objRow[convXzGradeBase.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvXzGradeBaseDA: GetObjByDataRow)", objException.Message));
}
objvXzGradeBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvXzGradeBaseEN;
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
objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzGradeBaseEN._CurrTabName, convXzGradeBase.IdGradeBase, 4, "");
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
objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvXzGradeBaseEN._CurrTabName, convXzGradeBase.IdGradeBase, 4, strPrefix);
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdGradeBase from vXzGradeBase where " + strCondition;
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdGradeBase from vXzGradeBase where " + strCondition;
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
 /// <param name = "strIdGradeBase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdGradeBase)
{
CheckPrimaryKey(strIdGradeBase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzGradeBase", "IdGradeBase = " + "'"+ strIdGradeBase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvXzGradeBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vXzGradeBase", strCondition))
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
objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vXzGradeBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvXzGradeBaseENS">源对象</param>
 /// <param name = "objvXzGradeBaseENT">目标对象</param>
public void CopyTo(clsvXzGradeBaseEN objvXzGradeBaseENS, clsvXzGradeBaseEN objvXzGradeBaseENT)
{
objvXzGradeBaseENT.IdGradeBase = objvXzGradeBaseENS.IdGradeBase; //年级流水号
objvXzGradeBaseENT.GradeBaseId = objvXzGradeBaseENS.GradeBaseId; //年级代号
objvXzGradeBaseENT.GradeBaseName = objvXzGradeBaseENS.GradeBaseName; //年级名称
objvXzGradeBaseENT.GradeBaseNameA = objvXzGradeBaseENS.GradeBaseNameA; //年级名称缩写
objvXzGradeBaseENT.SchoolYear = objvXzGradeBaseENS.SchoolYear; //学年
objvXzGradeBaseENT.SchoolTerm = objvXzGradeBaseENS.SchoolTerm; //学期
objvXzGradeBaseENT.EnterSchoolDate = objvXzGradeBaseENS.EnterSchoolDate; //进校日期
objvXzGradeBaseENT.CurrentTermSeq = objvXzGradeBaseENS.CurrentTermSeq; //当前学期
objvXzGradeBaseENT.ExecPlanTermIndex = objvXzGradeBaseENS.ExecPlanTermIndex; //生成执行计划学期
objvXzGradeBaseENT.SetEPTermIndexDate = objvXzGradeBaseENS.SetEPTermIndexDate; //设定执行计划学期日期
objvXzGradeBaseENT.IsOffed = objvXzGradeBaseENS.IsOffed; //是否毕业
objvXzGradeBaseENT.GradeIndex = objvXzGradeBaseENS.GradeIndex; //年级序号
objvXzGradeBaseENT.BeginYearMonth = objvXzGradeBaseENS.BeginYearMonth; //开始年月
objvXzGradeBaseENT.EndYearMonth = objvXzGradeBaseENS.EndYearMonth; //结束年月
objvXzGradeBaseENT.AllowUpBaseInfo = objvXzGradeBaseENS.AllowUpBaseInfo; //允许修改基本信息
objvXzGradeBaseENT.Prefix = objvXzGradeBaseENS.Prefix; //前缀
objvXzGradeBaseENT.PointCalcVersionId = objvXzGradeBaseENS.PointCalcVersionId; //绩点计算版本Id
objvXzGradeBaseENT.ModifyUserId = objvXzGradeBaseENS.ModifyUserId; //修改人
objvXzGradeBaseENT.ModifyDate = objvXzGradeBaseENS.ModifyDate; //修改日期
objvXzGradeBaseENT.IdStudyLevel = objvXzGradeBaseENS.IdStudyLevel; //id_StudyLevel
objvXzGradeBaseENT.StudyLevelName = objvXzGradeBaseENS.StudyLevelName; //学段名称
objvXzGradeBaseENT.IsVisible = objvXzGradeBaseENS.IsVisible; //是否显示
objvXzGradeBaseENT.Memo = objvXzGradeBaseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvXzGradeBaseEN objvXzGradeBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.IdGradeBase, 4, convXzGradeBase.IdGradeBase);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.GradeBaseId, 4, convXzGradeBase.GradeBaseId);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.GradeBaseName, 50, convXzGradeBase.GradeBaseName);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.GradeBaseNameA, 10, convXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.SchoolYear, 10, convXzGradeBase.SchoolYear);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.SchoolTerm, 1, convXzGradeBase.SchoolTerm);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.EnterSchoolDate, 8, convXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.SetEPTermIndexDate, 8, convXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.BeginYearMonth, 8, convXzGradeBase.BeginYearMonth);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.EndYearMonth, 8, convXzGradeBase.EndYearMonth);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.Prefix, 3, convXzGradeBase.Prefix);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.PointCalcVersionId, 2, convXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.ModifyUserId, 18, convXzGradeBase.ModifyUserId);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.ModifyDate, 20, convXzGradeBase.ModifyDate);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.IdStudyLevel, 4, convXzGradeBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.StudyLevelName, 50, convXzGradeBase.StudyLevelName);
clsCheckSql.CheckFieldLen(objvXzGradeBaseEN.Memo, 1000, convXzGradeBase.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.IdGradeBase, convXzGradeBase.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.GradeBaseId, convXzGradeBase.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.GradeBaseName, convXzGradeBase.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.GradeBaseNameA, convXzGradeBase.GradeBaseNameA);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.SchoolYear, convXzGradeBase.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.SchoolTerm, convXzGradeBase.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.EnterSchoolDate, convXzGradeBase.EnterSchoolDate);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.SetEPTermIndexDate, convXzGradeBase.SetEPTermIndexDate);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.BeginYearMonth, convXzGradeBase.BeginYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.EndYearMonth, convXzGradeBase.EndYearMonth);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.Prefix, convXzGradeBase.Prefix);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.PointCalcVersionId, convXzGradeBase.PointCalcVersionId);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.ModifyUserId, convXzGradeBase.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.ModifyDate, convXzGradeBase.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.IdStudyLevel, convXzGradeBase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.StudyLevelName, convXzGradeBase.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvXzGradeBaseEN.Memo, convXzGradeBase.Memo);
//检查外键字段长度
 objvXzGradeBaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdGradeBase()
{
//获取某学院所有专业信息
string strSQL = "select IdGradeBase, GradeBaseName from vXzGradeBase ";
 clsSpecSQLforSql mySql = clsvXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzGradeBaseEN._CurrTabName);
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvXzGradeBaseEN._CurrTabName, strCondition);
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
 objSQL = clsvXzGradeBaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}