
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCaseCommonBaseDA
 表名:vCaseCommonBase(01120344)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:33
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// v案例公共基类(vCaseCommonBase)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCaseCommonBaseDA : clsCommBase4DA
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
 return clsvCaseCommonBaseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCaseCommonBaseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCaseCommonBaseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCaseCommonBaseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCaseCommonBaseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCase)
{
strIdCase = strIdCase.Replace("'", "''");
if (strIdCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCaseCommonBase中,检查关键字,长度不正确!(clsvCaseCommonBaseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCaseCommonBase中,关键字不能为空 或 null!(clsvCaseCommonBaseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCaseCommonBaseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCaseCommonBase(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable_vCaseCommonBase)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCommonBase.* from vCaseCommonBase Left Join {1} on {2} where {3} and vCaseCommonBase.IdCase not in (Select top {5} vCaseCommonBase.IdCase from vCaseCommonBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1} and IdCase not in (Select top {2} IdCase from vCaseCommonBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1} and IdCase not in (Select top {3} IdCase from vCaseCommonBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCaseCommonBase.* from vCaseCommonBase Left Join {1} on {2} where {3} and vCaseCommonBase.IdCase not in (Select top {5} vCaseCommonBase.IdCase from vCaseCommonBase Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1} and IdCase not in (Select top {2} IdCase from vCaseCommonBase where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCaseCommonBase where {1} and IdCase not in (Select top {3} IdCase from vCaseCommonBase where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCaseCommonBaseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA:GetObjLst)", objException.Message));
}
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = TransNullToBool(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetObjLst)", objException.Message));
}
objvCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCommonBaseEN);
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
public List<clsvCaseCommonBaseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCaseCommonBaseEN> arrObjLst = new List<clsvCaseCommonBaseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = TransNullToBool(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetObjLst)", objException.Message));
}
objvCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCaseCommonBaseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCaseCommonBaseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCaseCommonBase(ref clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where IdCase = " + "'"+ objvCaseCommonBaseEN.IdCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCaseCommonBaseEN.IdCase = objDT.Rows[0][convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.CaseId = objDT.Rows[0][convCaseCommonBase.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseName = objDT.Rows[0][convCaseCommonBase.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCommonBaseEN.CourseName = objDT.Rows[0][convCaseCommonBase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCommonBaseEN.FuncModuleId = objDT.Rows[0][convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.FuncModuleName = objDT.Rows[0][convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCommonBaseEN.FuncModuleNameSim = objDT.Rows[0][convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCommonBaseEN.OwnerId = objDT.Rows[0][convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCommonBaseEN.OwnerName = objDT.Rows[0][convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCommonBaseEN.CourseId = objDT.Rows[0][convCaseCommonBase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CourseCode = objDT.Rows[0][convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.CourseChapterId = objDT.Rows[0][convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.CourseChapterName = objDT.Rows[0][convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseCommonBaseEN.CaseDate = objDT.Rows[0][convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseDateIn = objDT.Rows[0][convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseText = objDT.Rows[0][convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCaseCommonBaseEN.CaseTheme = objDT.Rows[0][convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCaseCommonBaseEN.CaseTime = objDT.Rows[0][convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间(字段类型:char,字段长度:6,是否可空:True)
 objvCaseCommonBaseEN.CaseTimeIn = objDT.Rows[0][convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCaseCommonBaseEN.IsVisible = TransNullToBool(objDT.Rows[0][convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.IdTeachSkill = objDT.Rows[0][convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.IdDiscipline = objDT.Rows[0][convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCommonBaseEN.IdStudyLevel = objDT.Rows[0][convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdCaseType = objDT.Rows[0][convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdTeachingPlan = objDT.Rows[0][convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.IdXzMajor = objDT.Rows[0][convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdSenateGaugeVersion = objDT.Rows[0][convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCommonBaseEN.DocFile = objDT.Rows[0][convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.Memo = objDT.Rows[0][convCaseCommonBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCaseCommonBaseEN.UpdUserId = objDT.Rows[0][convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCaseCommonBaseEN.LikeCount = TransNullToInt(objDT.Rows[0][convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.WordCreateDate = objDT.Rows[0][convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCaseCommonBaseEN.UpdDate = objDT.Rows[0][convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.CaseLevelId = objDT.Rows[0][convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCaseCommonBaseEN.ViewCount = TransNullToInt(objDT.Rows[0][convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IsShow = TransNullToBool(objDT.Rows[0][convCaseCommonBase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetvCaseCommonBase)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCaseCommonBaseEN GetObjByIdCase(string strIdCase)
{
CheckPrimaryKey(strIdCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where IdCase = " + "'"+ strIdCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
 objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间(字段类型:char,字段长度:6,是否可空:True)
 objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCaseCommonBaseEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCaseCommonBaseEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetObjByIdCase)", objException.Message));
}
return objvCaseCommonBaseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCaseCommonBaseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
strSQL = "Select * from vCaseCommonBase where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN()
{
IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(), //案例流水号
CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(), //案例Id
CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(), //案例名称
CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(), //课程名称
FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(), //功能模块简称
OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(), //拥有者Id
OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(), //拥有者姓名
CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(), //课程代码
CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(), //课程章节名称
CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(), //案例建立日期
CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(), //案例入库日期
CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(), //案例文本内容
CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(), //案例主题词
CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(), //案例建立时间
CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(), //案例入库时间
IsVisible = TransNullToBool(objRow[convCaseCommonBase.IsVisible].ToString().Trim()), //是否显示
IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(), //教学技能流水号
IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(), //学科流水号
IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(), //id_StudyLevel
IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(), //案例类型流水号
IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(), //教案流水号
IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(), //专业流水号
BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(), //备注
UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(), //修改用户Id
IsDualVideo = TransNullToBool(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()), //是否双视频
LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.LikeCount].ToString().Trim()), //资源喜欢数量
WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(), //Word生成日期
UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(), //修改日期
CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(), //课例等级Id
ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCaseCommonBase.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()), //文件积分
CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()) //收藏数量
};
objvCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCommonBaseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCaseCommonBaseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = TransNullToBool(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetObjByDataRowvCaseCommonBase)", objException.Message));
}
objvCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCommonBaseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCaseCommonBaseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCaseCommonBaseEN objvCaseCommonBaseEN = new clsvCaseCommonBaseEN();
try
{
objvCaseCommonBaseEN.IdCase = objRow[convCaseCommonBase.IdCase].ToString().Trim(); //案例流水号
objvCaseCommonBaseEN.CaseId = objRow[convCaseCommonBase.CaseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseId].ToString().Trim(); //案例Id
objvCaseCommonBaseEN.CaseName = objRow[convCaseCommonBase.CaseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseName].ToString().Trim(); //案例名称
objvCaseCommonBaseEN.CourseName = objRow[convCaseCommonBase.CourseName] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseName].ToString().Trim(); //课程名称
objvCaseCommonBaseEN.FuncModuleId = objRow[convCaseCommonBase.FuncModuleId].ToString().Trim(); //功能模块Id
objvCaseCommonBaseEN.FuncModuleName = objRow[convCaseCommonBase.FuncModuleName].ToString().Trim(); //功能模块名称
objvCaseCommonBaseEN.FuncModuleNameSim = objRow[convCaseCommonBase.FuncModuleNameSim] == DBNull.Value ? null : objRow[convCaseCommonBase.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvCaseCommonBaseEN.OwnerId = objRow[convCaseCommonBase.OwnerId].ToString().Trim(); //拥有者Id
objvCaseCommonBaseEN.OwnerName = objRow[convCaseCommonBase.OwnerName] == DBNull.Value ? null : objRow[convCaseCommonBase.OwnerName].ToString().Trim(); //拥有者姓名
objvCaseCommonBaseEN.CourseId = objRow[convCaseCommonBase.CourseId] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseId].ToString().Trim(); //课程Id
objvCaseCommonBaseEN.CourseCode = objRow[convCaseCommonBase.CourseCode] == DBNull.Value ? null : objRow[convCaseCommonBase.CourseCode].ToString().Trim(); //课程代码
objvCaseCommonBaseEN.CourseChapterId = objRow[convCaseCommonBase.CourseChapterId].ToString().Trim(); //课程章节ID
objvCaseCommonBaseEN.CourseChapterName = objRow[convCaseCommonBase.CourseChapterName].ToString().Trim(); //课程章节名称
objvCaseCommonBaseEN.CaseDate = objRow[convCaseCommonBase.CaseDate] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDate].ToString().Trim(); //案例建立日期
objvCaseCommonBaseEN.CaseDateIn = objRow[convCaseCommonBase.CaseDateIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseDateIn].ToString().Trim(); //案例入库日期
objvCaseCommonBaseEN.CaseText = objRow[convCaseCommonBase.CaseText] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseText].ToString().Trim(); //案例文本内容
objvCaseCommonBaseEN.CaseTheme = objRow[convCaseCommonBase.CaseTheme] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTheme].ToString().Trim(); //案例主题词
objvCaseCommonBaseEN.CaseTime = objRow[convCaseCommonBase.CaseTime] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTime].ToString().Trim(); //案例建立时间
objvCaseCommonBaseEN.CaseTimeIn = objRow[convCaseCommonBase.CaseTimeIn] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseTimeIn].ToString().Trim(); //案例入库时间
objvCaseCommonBaseEN.IsVisible = TransNullToBool(objRow[convCaseCommonBase.IsVisible].ToString().Trim()); //是否显示
objvCaseCommonBaseEN.IdTeachSkill = objRow[convCaseCommonBase.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCaseCommonBaseEN.IdDiscipline = objRow[convCaseCommonBase.IdDiscipline].ToString().Trim(); //学科流水号
objvCaseCommonBaseEN.IdStudyLevel = objRow[convCaseCommonBase.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCaseCommonBaseEN.IdCaseType = objRow[convCaseCommonBase.IdCaseType].ToString().Trim(); //案例类型流水号
objvCaseCommonBaseEN.IdTeachingPlan = objRow[convCaseCommonBase.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCaseCommonBaseEN.IdXzMajor = objRow[convCaseCommonBase.IdXzMajor].ToString().Trim(); //专业流水号
objvCaseCommonBaseEN.BrowseCount = objRow[convCaseCommonBase.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.BrowseCount].ToString().Trim()); //浏览次数
objvCaseCommonBaseEN.IdSenateGaugeVersion = objRow[convCaseCommonBase.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCaseCommonBaseEN.DocFile = objRow[convCaseCommonBase.DocFile] == DBNull.Value ? null : objRow[convCaseCommonBase.DocFile].ToString().Trim(); //生成的Word文件名
objvCaseCommonBaseEN.IsNeedGeneWord = TransNullToBool(objRow[convCaseCommonBase.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCaseCommonBaseEN.Memo = objRow[convCaseCommonBase.Memo] == DBNull.Value ? null : objRow[convCaseCommonBase.Memo].ToString().Trim(); //备注
objvCaseCommonBaseEN.UpdUserId = objRow[convCaseCommonBase.UpdUserId] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdUserId].ToString().Trim(); //修改用户Id
objvCaseCommonBaseEN.IsDualVideo = TransNullToBool(objRow[convCaseCommonBase.IsDualVideo].ToString().Trim()); //是否双视频
objvCaseCommonBaseEN.LikeCount = objRow[convCaseCommonBase.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.LikeCount].ToString().Trim()); //资源喜欢数量
objvCaseCommonBaseEN.WordCreateDate = objRow[convCaseCommonBase.WordCreateDate] == DBNull.Value ? null : objRow[convCaseCommonBase.WordCreateDate].ToString().Trim(); //Word生成日期
objvCaseCommonBaseEN.UpdDate = objRow[convCaseCommonBase.UpdDate] == DBNull.Value ? null : objRow[convCaseCommonBase.UpdDate].ToString().Trim(); //修改日期
objvCaseCommonBaseEN.CaseLevelId = objRow[convCaseCommonBase.CaseLevelId] == DBNull.Value ? null : objRow[convCaseCommonBase.CaseLevelId].ToString().Trim(); //课例等级Id
objvCaseCommonBaseEN.ViewCount = objRow[convCaseCommonBase.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.ViewCount].ToString().Trim()); //浏览量
objvCaseCommonBaseEN.IsShow = TransNullToBool(objRow[convCaseCommonBase.IsShow].ToString().Trim()); //是否启用
objvCaseCommonBaseEN.DownloadNumber = objRow[convCaseCommonBase.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.DownloadNumber].ToString().Trim()); //下载数目
objvCaseCommonBaseEN.FileIntegration = objRow[convCaseCommonBase.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCaseCommonBase.FileIntegration].ToString().Trim()); //文件积分
objvCaseCommonBaseEN.CollectionCount = objRow[convCaseCommonBase.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCaseCommonBase.CollectionCount].ToString().Trim()); //收藏数量
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCaseCommonBaseDA: GetObjByDataRow)", objException.Message));
}
objvCaseCommonBaseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCaseCommonBaseEN;
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
objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCommonBaseEN._CurrTabName, convCaseCommonBase.IdCase, 8, "");
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
objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCaseCommonBaseEN._CurrTabName, convCaseCommonBase.IdCase, 8, strPrefix);
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCase from vCaseCommonBase where " + strCondition;
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCase from vCaseCommonBase where " + strCondition;
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
 /// <param name = "strIdCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCase)
{
CheckPrimaryKey(strIdCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCommonBase", "IdCase = " + "'"+ strIdCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCaseCommonBaseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCaseCommonBase", strCondition))
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
objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCaseCommonBase");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCaseCommonBaseENS">源对象</param>
 /// <param name = "objvCaseCommonBaseENT">目标对象</param>
public void CopyTo(clsvCaseCommonBaseEN objvCaseCommonBaseENS, clsvCaseCommonBaseEN objvCaseCommonBaseENT)
{
objvCaseCommonBaseENT.IdCase = objvCaseCommonBaseENS.IdCase; //案例流水号
objvCaseCommonBaseENT.CaseId = objvCaseCommonBaseENS.CaseId; //案例Id
objvCaseCommonBaseENT.CaseName = objvCaseCommonBaseENS.CaseName; //案例名称
objvCaseCommonBaseENT.CourseName = objvCaseCommonBaseENS.CourseName; //课程名称
objvCaseCommonBaseENT.FuncModuleId = objvCaseCommonBaseENS.FuncModuleId; //功能模块Id
objvCaseCommonBaseENT.FuncModuleName = objvCaseCommonBaseENS.FuncModuleName; //功能模块名称
objvCaseCommonBaseENT.FuncModuleNameSim = objvCaseCommonBaseENS.FuncModuleNameSim; //功能模块简称
objvCaseCommonBaseENT.OwnerId = objvCaseCommonBaseENS.OwnerId; //拥有者Id
objvCaseCommonBaseENT.OwnerName = objvCaseCommonBaseENS.OwnerName; //拥有者姓名
objvCaseCommonBaseENT.CourseId = objvCaseCommonBaseENS.CourseId; //课程Id
objvCaseCommonBaseENT.CourseCode = objvCaseCommonBaseENS.CourseCode; //课程代码
objvCaseCommonBaseENT.CourseChapterId = objvCaseCommonBaseENS.CourseChapterId; //课程章节ID
objvCaseCommonBaseENT.CourseChapterName = objvCaseCommonBaseENS.CourseChapterName; //课程章节名称
objvCaseCommonBaseENT.CaseDate = objvCaseCommonBaseENS.CaseDate; //案例建立日期
objvCaseCommonBaseENT.CaseDateIn = objvCaseCommonBaseENS.CaseDateIn; //案例入库日期
objvCaseCommonBaseENT.CaseText = objvCaseCommonBaseENS.CaseText; //案例文本内容
objvCaseCommonBaseENT.CaseTheme = objvCaseCommonBaseENS.CaseTheme; //案例主题词
objvCaseCommonBaseENT.CaseTime = objvCaseCommonBaseENS.CaseTime; //案例建立时间
objvCaseCommonBaseENT.CaseTimeIn = objvCaseCommonBaseENS.CaseTimeIn; //案例入库时间
objvCaseCommonBaseENT.IsVisible = objvCaseCommonBaseENS.IsVisible; //是否显示
objvCaseCommonBaseENT.IdTeachSkill = objvCaseCommonBaseENS.IdTeachSkill; //教学技能流水号
objvCaseCommonBaseENT.IdDiscipline = objvCaseCommonBaseENS.IdDiscipline; //学科流水号
objvCaseCommonBaseENT.IdStudyLevel = objvCaseCommonBaseENS.IdStudyLevel; //id_StudyLevel
objvCaseCommonBaseENT.IdCaseType = objvCaseCommonBaseENS.IdCaseType; //案例类型流水号
objvCaseCommonBaseENT.IdTeachingPlan = objvCaseCommonBaseENS.IdTeachingPlan; //教案流水号
objvCaseCommonBaseENT.IdXzMajor = objvCaseCommonBaseENS.IdXzMajor; //专业流水号
objvCaseCommonBaseENT.BrowseCount = objvCaseCommonBaseENS.BrowseCount; //浏览次数
objvCaseCommonBaseENT.IdSenateGaugeVersion = objvCaseCommonBaseENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCaseCommonBaseENT.DocFile = objvCaseCommonBaseENS.DocFile; //生成的Word文件名
objvCaseCommonBaseENT.IsNeedGeneWord = objvCaseCommonBaseENS.IsNeedGeneWord; //是否需要生成Word
objvCaseCommonBaseENT.Memo = objvCaseCommonBaseENS.Memo; //备注
objvCaseCommonBaseENT.UpdUserId = objvCaseCommonBaseENS.UpdUserId; //修改用户Id
objvCaseCommonBaseENT.IsDualVideo = objvCaseCommonBaseENS.IsDualVideo; //是否双视频
objvCaseCommonBaseENT.LikeCount = objvCaseCommonBaseENS.LikeCount; //资源喜欢数量
objvCaseCommonBaseENT.WordCreateDate = objvCaseCommonBaseENS.WordCreateDate; //Word生成日期
objvCaseCommonBaseENT.UpdDate = objvCaseCommonBaseENS.UpdDate; //修改日期
objvCaseCommonBaseENT.CaseLevelId = objvCaseCommonBaseENS.CaseLevelId; //课例等级Id
objvCaseCommonBaseENT.ViewCount = objvCaseCommonBaseENS.ViewCount; //浏览量
objvCaseCommonBaseENT.IsShow = objvCaseCommonBaseENS.IsShow; //是否启用
objvCaseCommonBaseENT.DownloadNumber = objvCaseCommonBaseENS.DownloadNumber; //下载数目
objvCaseCommonBaseENT.FileIntegration = objvCaseCommonBaseENS.FileIntegration; //文件积分
objvCaseCommonBaseENT.CollectionCount = objvCaseCommonBaseENS.CollectionCount; //收藏数量
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCaseCommonBaseEN objvCaseCommonBaseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdCase, 8, convCaseCommonBase.IdCase);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseId, 8, convCaseCommonBase.CaseId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseName, 100, convCaseCommonBase.CaseName);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CourseName, 100, convCaseCommonBase.CourseName);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.FuncModuleId, 4, convCaseCommonBase.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.FuncModuleName, 30, convCaseCommonBase.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.FuncModuleNameSim, 30, convCaseCommonBase.FuncModuleNameSim);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.OwnerId, 20, convCaseCommonBase.OwnerId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.OwnerName, 30, convCaseCommonBase.OwnerName);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CourseId, 8, convCaseCommonBase.CourseId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CourseCode, 20, convCaseCommonBase.CourseCode);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CourseChapterId, 8, convCaseCommonBase.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CourseChapterName, 100, convCaseCommonBase.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseDate, 8, convCaseCommonBase.CaseDate);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseDateIn, 8, convCaseCommonBase.CaseDateIn);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseText, 8000, convCaseCommonBase.CaseText);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseTheme, 200, convCaseCommonBase.CaseTheme);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseTime, 6, convCaseCommonBase.CaseTime);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseTimeIn, 6, convCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdTeachSkill, 8, convCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdDiscipline, 4, convCaseCommonBase.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdStudyLevel, 4, convCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdCaseType, 4, convCaseCommonBase.IdCaseType);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdTeachingPlan, 8, convCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdXzMajor, 8, convCaseCommonBase.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.IdSenateGaugeVersion, 4, convCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.DocFile, 200, convCaseCommonBase.DocFile);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.Memo, 1000, convCaseCommonBase.Memo);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.UpdUserId, 20, convCaseCommonBase.UpdUserId);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.WordCreateDate, 14, convCaseCommonBase.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.UpdDate, 20, convCaseCommonBase.UpdDate);
clsCheckSql.CheckFieldLen(objvCaseCommonBaseEN.CaseLevelId, 2, convCaseCommonBase.CaseLevelId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdCase, convCaseCommonBase.IdCase);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseId, convCaseCommonBase.CaseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseName, convCaseCommonBase.CaseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CourseName, convCaseCommonBase.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.FuncModuleId, convCaseCommonBase.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.FuncModuleName, convCaseCommonBase.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.FuncModuleNameSim, convCaseCommonBase.FuncModuleNameSim);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.OwnerId, convCaseCommonBase.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.OwnerName, convCaseCommonBase.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CourseId, convCaseCommonBase.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CourseCode, convCaseCommonBase.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CourseChapterId, convCaseCommonBase.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CourseChapterName, convCaseCommonBase.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseDate, convCaseCommonBase.CaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseDateIn, convCaseCommonBase.CaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseText, convCaseCommonBase.CaseText);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseTheme, convCaseCommonBase.CaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseTime, convCaseCommonBase.CaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseTimeIn, convCaseCommonBase.CaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdTeachSkill, convCaseCommonBase.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdDiscipline, convCaseCommonBase.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdStudyLevel, convCaseCommonBase.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdCaseType, convCaseCommonBase.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdTeachingPlan, convCaseCommonBase.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdXzMajor, convCaseCommonBase.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.IdSenateGaugeVersion, convCaseCommonBase.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.DocFile, convCaseCommonBase.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.Memo, convCaseCommonBase.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.UpdUserId, convCaseCommonBase.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.WordCreateDate, convCaseCommonBase.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.UpdDate, convCaseCommonBase.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCaseCommonBaseEN.CaseLevelId, convCaseCommonBase.CaseLevelId);
//检查外键字段长度
 objvCaseCommonBaseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCase()
{
//获取某学院所有专业信息
string strSQL = "select IdCase, CaseName from vCaseCommonBase ";
 clsSpecSQLforSql mySql = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCommonBaseEN._CurrTabName);
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCaseCommonBaseEN._CurrTabName, strCondition);
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
 objSQL = clsvCaseCommonBaseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}