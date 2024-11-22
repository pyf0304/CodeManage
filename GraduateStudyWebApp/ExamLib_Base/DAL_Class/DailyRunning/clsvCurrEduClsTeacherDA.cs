
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsTeacherDA
 表名:vCurrEduClsTeacher(01120128)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:12
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// v当前教学班教师(vCurrEduClsTeacher)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCurrEduClsTeacherDA : clsCommBase4DA
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
 return clsvCurrEduClsTeacherEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCurrEduClsTeacherEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsTeacherEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCurrEduClsTeacherEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCurrEduClsTeacherEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCurrEduClsTeacher(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable_vCurrEduClsTeacher)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduClsTeacher.* from vCurrEduClsTeacher Left Join {1} on {2} where {3} and vCurrEduClsTeacher.IdEduClsTeacher not in (Select top {5} vCurrEduClsTeacher.IdEduClsTeacher from vCurrEduClsTeacher Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {2} IdEduClsTeacher from vCurrEduClsTeacher where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {3} IdEduClsTeacher from vCurrEduClsTeacher where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduClsTeacher.* from vCurrEduClsTeacher Left Join {1} on {2} where {3} and vCurrEduClsTeacher.IdEduClsTeacher not in (Select top {5} vCurrEduClsTeacher.IdEduClsTeacher from vCurrEduClsTeacher Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {2} IdEduClsTeacher from vCurrEduClsTeacher where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {3} IdEduClsTeacher from vCurrEduClsTeacher where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCurrEduClsTeacherEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA:GetObjLst)", objException.Message));
}
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = TransNullToBool(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = TransNullToBool(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = TransNullToBool(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetObjLst)", objException.Message));
}
objvCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsTeacherEN);
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
public List<clsvCurrEduClsTeacherEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCurrEduClsTeacherEN> arrObjLst = new List<clsvCurrEduClsTeacherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = TransNullToBool(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = TransNullToBool(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = TransNullToBool(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetObjLst)", objException.Message));
}
objvCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCurrEduClsTeacher(ref clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where IdEduClsTeacher = " + ""+ objvCurrEduClsTeacherEN.IdEduClsTeacher+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.IdCurrEduCls = objDT.Rows[0][convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.CurrEduClsId = objDT.Rows[0][convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsTeacherEN.EduClsName = objDT.Rows[0][convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTypeId = objDT.Rows[0][convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTypeName = objDT.Rows[0][convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsTeacherEN.CourseId = objDT.Rows[0][convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.CourseCode = objDT.Rows[0][convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.CourseName = objDT.Rows[0][convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsTeacherEN.ExampleImgPath = objDT.Rows[0][convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduClsTeacherEN.TeachingSolutionId = objDT.Rows[0][convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.TeachingSolutionName = objDT.Rows[0][convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.IdXzCollege = objDT.Rows[0][convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeId = objDT.Rows[0][convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IdEduWay = objDT.Rows[0][convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.MaxStuQty = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.WeekQty = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.WeekStatusId = objDT.Rows[0][convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.CustomerWeek = objDT.Rows[0][convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsTeacherEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsTeacherEN.IdUniZone = objDT.Rows[0][convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IdGradeBase = objDT.Rows[0][convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.GradeBaseId = objDT.Rows[0][convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.GradeBaseName = objDT.Rows[0][convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsTeacherEN.IsEffective = TransNullToBool(objDT.Rows[0][convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.IdCourseType = objDT.Rows[0][convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.CourseTypeId = objDT.Rows[0][convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.CourseTypeName = objDT.Rows[0][convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.IsDegree = TransNullToBool(objDT.Rows[0][convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsTeacherEN.IdScoreType = objDT.Rows[0][convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.IdExamType = objDT.Rows[0][convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.BeginWeek = TransNullToShort(objDT.Rows[0][convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.CurrStuNumValid = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.CurrStuNum = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.IdTeacher = objDT.Rows[0][convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.TeacherId = objDT.Rows[0][convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduClsTeacherEN.TeacherName = objDT.Rows[0][convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsTeacherEN.IdProfGrade = objDT.Rows[0][convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.ProfenssionalGradeName = objDT.Rows[0][convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.DegreeName = objDT.Rows[0][convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.Birthday = objDT.Rows[0][convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.IsGpUser = TransNullToBool(objDT.Rows[0][convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName = objDT.Rows[0][convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objDT.Rows[0][convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objDT.Rows[0][convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objDT.Rows[0][convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.SchoolTerm = objDT.Rows[0][convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.SchoolYear = objDT.Rows[0][convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsTeacherEN.OpenBeginDate = objDT.Rows[0][convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.OpenEndDate = objDT.Rows[0][convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.OrderNum = TransNullToInt(objDT.Rows[0][convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.UpdDate = objDT.Rows[0][convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.UpdUser = objDT.Rows[0][convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.Memo = objDT.Rows[0][convCurrEduClsTeacher.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName4EduCls = objDT.Rows[0][convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName4Teacher = objDT.Rows[0][convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsTeacherEN.UserType = objDT.Rows[0][convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetvCurrEduClsTeacher)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public clsvCurrEduClsTeacherEN GetObjByIdEduClsTeacher(long lngIdEduClsTeacher)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
 objvCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsTeacherEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.IsGpUser = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期(字段类型:varchar,字段长度:8,是否可空:True)
 objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师(字段类型:varchar,字段长度:60,是否可空:True)
 objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetObjByIdEduClsTeacher)", objException.Message));
}
return objvCurrEduClsTeacherEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCurrEduClsTeacherEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN()
{
IdEduClsTeacher = TransNullToInt(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()), //教学班老师流水号
IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(), //教学班类型Id
EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(), //教学班类型名称
CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(), //课程名称
ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(), //示例图路径
TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(), //教学方案Id
TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(), //教学方案名称
IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(), //学院ID
IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(), //教学方式流水号
TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()), //最大学生数
WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(), //自定义上课周
LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()), //周课时数
IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(), //校区流水号
IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(), //年级名称
IsEffective = TransNullToBool(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()), //是否有效
IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(), //课程类型流水号
CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(), //课程类型名称
IsDegree = TransNullToBool(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(), //成绩类型流水号
IsProportionalCtrl = TransNullToBool(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(), //考试方式流水号
BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()), //开始周
CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()), //CurrStuNum_Valid
CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()), //当前学生数
IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(), //教师姓名
IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(), //专业职称流水号
ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(), //专业职称
DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(), //学位名称
Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(), //出生日期
IsGpUser = TransNullToBool(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()), //是否Gp用户
CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(), //学院名称
IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(), //教学班老师角色(主讲,辅导)流水号
EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(), //教学班教学类型ID
EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(), //教学班教师类型名
SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(), //学年
OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(), //开放开始日期
OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(), //开放结束日期
OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(), //备注
CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(), //学院名_教学班
CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(), //学院名_教师
UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim() //用户类型
};
objvCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsTeacherEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsTeacherEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = TransNullToBool(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = TransNullToBool(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = TransNullToBool(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetObjByDataRowvCurrEduClsTeacher)", objException.Message));
}
objvCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsTeacherEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsTeacherEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN();
try
{
objvCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[convCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objvCurrEduClsTeacherEN.IdCurrEduCls = objRow[convCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsTeacherEN.CurrEduClsId = objRow[convCurrEduClsTeacher.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsTeacherEN.EduClsName = objRow[convCurrEduClsTeacher.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsTeacherEN.EduClsTypeId = objRow[convCurrEduClsTeacher.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsTeacherEN.EduClsTypeName = objRow[convCurrEduClsTeacher.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsTeacherEN.CourseId = objRow[convCurrEduClsTeacher.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsTeacherEN.CourseCode = objRow[convCurrEduClsTeacher.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsTeacherEN.CourseName = objRow[convCurrEduClsTeacher.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsTeacherEN.ExampleImgPath = objRow[convCurrEduClsTeacher.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduClsTeacherEN.TeachingSolutionId = objRow[convCurrEduClsTeacher.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsTeacherEN.TeachingSolutionName = objRow[convCurrEduClsTeacher.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsTeacherEN.IdXzCollege = objRow[convCurrEduClsTeacher.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsTeacherEN.CollegeId = objRow[convCurrEduClsTeacher.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsTeacherEN.IdEduWay = objRow[convCurrEduClsTeacher.IdEduWay] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduClsTeacherEN.TotalLessonQty = objRow[convCurrEduClsTeacher.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduClsTeacherEN.MaxStuQty = objRow[convCurrEduClsTeacher.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduClsTeacherEN.WeekQty = objRow[convCurrEduClsTeacher.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.WeekQty].ToString().Trim()); //总周数
objvCurrEduClsTeacherEN.ScheUnitPW = objRow[convCurrEduClsTeacher.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduClsTeacherEN.WeekStatusId = objRow[convCurrEduClsTeacher.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduClsTeacherEN.CustomerWeek = objRow[convCurrEduClsTeacher.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduClsTeacherEN.LessonQtyPerWeek = objRow[convCurrEduClsTeacher.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsTeacherEN.IdUniZone = objRow[convCurrEduClsTeacher.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsTeacherEN.IdGradeBase = objRow[convCurrEduClsTeacher.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduClsTeacherEN.GradeBaseId = objRow[convCurrEduClsTeacher.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduClsTeacherEN.GradeBaseName = objRow[convCurrEduClsTeacher.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsTeacherEN.IsEffective = TransNullToBool(objRow[convCurrEduClsTeacher.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsTeacherEN.IdCourseType = objRow[convCurrEduClsTeacher.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsTeacherEN.CourseTypeId = objRow[convCurrEduClsTeacher.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsTeacherEN.CourseTypeName = objRow[convCurrEduClsTeacher.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsTeacherEN.IsDegree = TransNullToBool(objRow[convCurrEduClsTeacher.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsTeacherEN.IdScoreType = objRow[convCurrEduClsTeacher.IdScoreType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduClsTeacherEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduClsTeacher.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduClsTeacherEN.IdExamType = objRow[convCurrEduClsTeacher.IdExamType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduClsTeacherEN.BeginWeek = objRow[convCurrEduClsTeacher.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsTeacher.BeginWeek].ToString().Trim()); //开始周
objvCurrEduClsTeacherEN.CurrStuNumValid = objRow[convCurrEduClsTeacher.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduClsTeacherEN.CurrStuNum = objRow[convCurrEduClsTeacher.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsTeacherEN.IdTeacher = objRow[convCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduClsTeacherEN.TeacherId = objRow[convCurrEduClsTeacher.TeacherId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherId].ToString().Trim(); //教师工号
objvCurrEduClsTeacherEN.TeacherName = objRow[convCurrEduClsTeacher.TeacherName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduClsTeacherEN.IdProfGrade = objRow[convCurrEduClsTeacher.IdProfGrade] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.IdProfGrade].ToString().Trim(); //专业职称流水号
objvCurrEduClsTeacherEN.ProfenssionalGradeName = objRow[convCurrEduClsTeacher.ProfenssionalGradeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvCurrEduClsTeacherEN.DegreeName = objRow[convCurrEduClsTeacher.DegreeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.DegreeName].ToString().Trim(); //学位名称
objvCurrEduClsTeacherEN.Birthday = objRow[convCurrEduClsTeacher.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsTeacherEN.IsGpUser = TransNullToBool(objRow[convCurrEduClsTeacher.IsGpUser].ToString().Trim()); //是否Gp用户
objvCurrEduClsTeacherEN.CollegeName = objRow[convCurrEduClsTeacher.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[convCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherEN.EduClsTeacherTypeId = objRow[convCurrEduClsTeacher.EduClsTeacherTypeId] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeId].ToString().Trim(); //教学班教学类型ID
objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc = objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.EduClsTeacherTypeDesc].ToString().Trim(); //教学班教师类型名
objvCurrEduClsTeacherEN.SchoolTerm = objRow[convCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsTeacherEN.SchoolYear = objRow[convCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsTeacherEN.OpenBeginDate = objRow[convCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objvCurrEduClsTeacherEN.OpenEndDate = objRow[convCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objvCurrEduClsTeacherEN.OrderNum = objRow[convCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objvCurrEduClsTeacherEN.UpdDate = objRow[convCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objvCurrEduClsTeacherEN.UpdUser = objRow[convCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objvCurrEduClsTeacherEN.Memo = objRow[convCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.Memo].ToString().Trim(); //备注
objvCurrEduClsTeacherEN.CollegeName4EduCls = objRow[convCurrEduClsTeacher.CollegeName4EduCls] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4EduCls].ToString().Trim(); //学院名_教学班
objvCurrEduClsTeacherEN.CollegeName4Teacher = objRow[convCurrEduClsTeacher.CollegeName4Teacher] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.CollegeName4Teacher].ToString().Trim(); //学院名_教师
objvCurrEduClsTeacherEN.UserType = objRow[convCurrEduClsTeacher.UserType] == DBNull.Value ? null : objRow[convCurrEduClsTeacher.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsTeacherDA: GetObjByDataRow)", objException.Message));
}
objvCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsTeacherEN;
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
objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsTeacherEN._CurrTabName, convCurrEduClsTeacher.IdEduClsTeacher, 8, "");
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
objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsTeacherEN._CurrTabName, convCurrEduClsTeacher.IdEduClsTeacher, 8, strPrefix);
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduClsTeacher from vCurrEduClsTeacher where " + strCondition;
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduClsTeacher from vCurrEduClsTeacher where " + strCondition;
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
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdEduClsTeacher)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduClsTeacher", "IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCurrEduClsTeacherDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduClsTeacher", strCondition))
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
objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCurrEduClsTeacher");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objvCurrEduClsTeacherENT">目标对象</param>
public void CopyTo(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENS, clsvCurrEduClsTeacherEN objvCurrEduClsTeacherENT)
{
objvCurrEduClsTeacherENT.IdEduClsTeacher = objvCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objvCurrEduClsTeacherENT.IdCurrEduCls = objvCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsTeacherENT.CurrEduClsId = objvCurrEduClsTeacherENS.CurrEduClsId; //教学班Id
objvCurrEduClsTeacherENT.EduClsName = objvCurrEduClsTeacherENS.EduClsName; //教学班名
objvCurrEduClsTeacherENT.EduClsTypeId = objvCurrEduClsTeacherENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsTeacherENT.EduClsTypeName = objvCurrEduClsTeacherENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsTeacherENT.CourseId = objvCurrEduClsTeacherENS.CourseId; //课程Id
objvCurrEduClsTeacherENT.CourseCode = objvCurrEduClsTeacherENS.CourseCode; //课程代码
objvCurrEduClsTeacherENT.CourseName = objvCurrEduClsTeacherENS.CourseName; //课程名称
objvCurrEduClsTeacherENT.ExampleImgPath = objvCurrEduClsTeacherENS.ExampleImgPath; //示例图路径
objvCurrEduClsTeacherENT.TeachingSolutionId = objvCurrEduClsTeacherENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsTeacherENT.TeachingSolutionName = objvCurrEduClsTeacherENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsTeacherENT.IdXzCollege = objvCurrEduClsTeacherENS.IdXzCollege; //学院流水号
objvCurrEduClsTeacherENT.CollegeId = objvCurrEduClsTeacherENS.CollegeId; //学院ID
objvCurrEduClsTeacherENT.IdEduWay = objvCurrEduClsTeacherENS.IdEduWay; //教学方式流水号
objvCurrEduClsTeacherENT.TotalLessonQty = objvCurrEduClsTeacherENS.TotalLessonQty; //总课时数
objvCurrEduClsTeacherENT.MaxStuQty = objvCurrEduClsTeacherENS.MaxStuQty; //最大学生数
objvCurrEduClsTeacherENT.WeekQty = objvCurrEduClsTeacherENS.WeekQty; //总周数
objvCurrEduClsTeacherENT.ScheUnitPW = objvCurrEduClsTeacherENS.ScheUnitPW; //周排课次数
objvCurrEduClsTeacherENT.WeekStatusId = objvCurrEduClsTeacherENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduClsTeacherENT.CustomerWeek = objvCurrEduClsTeacherENS.CustomerWeek; //自定义上课周
objvCurrEduClsTeacherENT.LessonQtyPerWeek = objvCurrEduClsTeacherENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsTeacherENT.IdUniZone = objvCurrEduClsTeacherENS.IdUniZone; //校区流水号
objvCurrEduClsTeacherENT.IdGradeBase = objvCurrEduClsTeacherENS.IdGradeBase; //年级流水号
objvCurrEduClsTeacherENT.GradeBaseId = objvCurrEduClsTeacherENS.GradeBaseId; //年级代号
objvCurrEduClsTeacherENT.GradeBaseName = objvCurrEduClsTeacherENS.GradeBaseName; //年级名称
objvCurrEduClsTeacherENT.IsEffective = objvCurrEduClsTeacherENS.IsEffective; //是否有效
objvCurrEduClsTeacherENT.IdCourseType = objvCurrEduClsTeacherENS.IdCourseType; //课程类型流水号
objvCurrEduClsTeacherENT.CourseTypeId = objvCurrEduClsTeacherENS.CourseTypeId; //课程类型ID
objvCurrEduClsTeacherENT.CourseTypeName = objvCurrEduClsTeacherENS.CourseTypeName; //课程类型名称
objvCurrEduClsTeacherENT.IsDegree = objvCurrEduClsTeacherENS.IsDegree; //是否学位课
objvCurrEduClsTeacherENT.IdScoreType = objvCurrEduClsTeacherENS.IdScoreType; //成绩类型流水号
objvCurrEduClsTeacherENT.IsProportionalCtrl = objvCurrEduClsTeacherENS.IsProportionalCtrl; //是否比例控制
objvCurrEduClsTeacherENT.IdExamType = objvCurrEduClsTeacherENS.IdExamType; //考试方式流水号
objvCurrEduClsTeacherENT.BeginWeek = objvCurrEduClsTeacherENS.BeginWeek; //开始周
objvCurrEduClsTeacherENT.CurrStuNumValid = objvCurrEduClsTeacherENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduClsTeacherENT.CurrStuNum = objvCurrEduClsTeacherENS.CurrStuNum; //当前学生数
objvCurrEduClsTeacherENT.IdTeacher = objvCurrEduClsTeacherENS.IdTeacher; //教师流水号
objvCurrEduClsTeacherENT.TeacherId = objvCurrEduClsTeacherENS.TeacherId; //教师工号
objvCurrEduClsTeacherENT.TeacherName = objvCurrEduClsTeacherENS.TeacherName; //教师姓名
objvCurrEduClsTeacherENT.IdProfGrade = objvCurrEduClsTeacherENS.IdProfGrade; //专业职称流水号
objvCurrEduClsTeacherENT.ProfenssionalGradeName = objvCurrEduClsTeacherENS.ProfenssionalGradeName; //专业职称
objvCurrEduClsTeacherENT.DegreeName = objvCurrEduClsTeacherENS.DegreeName; //学位名称
objvCurrEduClsTeacherENT.Birthday = objvCurrEduClsTeacherENS.Birthday; //出生日期
objvCurrEduClsTeacherENT.IsGpUser = objvCurrEduClsTeacherENS.IsGpUser; //是否Gp用户
objvCurrEduClsTeacherENT.CollegeName = objvCurrEduClsTeacherENS.CollegeName; //学院名称
objvCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objvCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objvCurrEduClsTeacherENT.EduClsTeacherTypeId = objvCurrEduClsTeacherENS.EduClsTeacherTypeId; //教学班教学类型ID
objvCurrEduClsTeacherENT.EduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.EduClsTeacherTypeDesc; //教学班教师类型名
objvCurrEduClsTeacherENT.SchoolTerm = objvCurrEduClsTeacherENS.SchoolTerm; //学期
objvCurrEduClsTeacherENT.SchoolYear = objvCurrEduClsTeacherENS.SchoolYear; //学年
objvCurrEduClsTeacherENT.OpenBeginDate = objvCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objvCurrEduClsTeacherENT.OpenEndDate = objvCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objvCurrEduClsTeacherENT.OrderNum = objvCurrEduClsTeacherENS.OrderNum; //序号
objvCurrEduClsTeacherENT.UpdDate = objvCurrEduClsTeacherENS.UpdDate; //修改日期
objvCurrEduClsTeacherENT.UpdUser = objvCurrEduClsTeacherENS.UpdUser; //修改人
objvCurrEduClsTeacherENT.Memo = objvCurrEduClsTeacherENS.Memo; //备注
objvCurrEduClsTeacherENT.CollegeName4EduCls = objvCurrEduClsTeacherENS.CollegeName4EduCls; //学院名_教学班
objvCurrEduClsTeacherENT.CollegeName4Teacher = objvCurrEduClsTeacherENS.CollegeName4Teacher; //学院名_教师
objvCurrEduClsTeacherENT.UserType = objvCurrEduClsTeacherENS.UserType; //用户类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCurrEduClsTeacherEN objvCurrEduClsTeacherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdCurrEduCls, 8, convCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CurrEduClsId, 15, convCurrEduClsTeacher.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.EduClsName, 100, convCurrEduClsTeacher.EduClsName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.EduClsTypeId, 4, convCurrEduClsTeacher.EduClsTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.EduClsTypeName, 100, convCurrEduClsTeacher.EduClsTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CourseId, 8, convCurrEduClsTeacher.CourseId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CourseCode, 20, convCurrEduClsTeacher.CourseCode);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CourseName, 100, convCurrEduClsTeacher.CourseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.ExampleImgPath, 300, convCurrEduClsTeacher.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.TeachingSolutionId, 8, convCurrEduClsTeacher.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.TeachingSolutionName, 100, convCurrEduClsTeacher.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdXzCollege, 4, convCurrEduClsTeacher.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CollegeId, 4, convCurrEduClsTeacher.CollegeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdEduWay, 4, convCurrEduClsTeacher.IdEduWay);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.WeekStatusId, 2, convCurrEduClsTeacher.WeekStatusId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CustomerWeek, 50, convCurrEduClsTeacher.CustomerWeek);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdUniZone, 4, convCurrEduClsTeacher.IdUniZone);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdGradeBase, 4, convCurrEduClsTeacher.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.GradeBaseId, 4, convCurrEduClsTeacher.GradeBaseId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.GradeBaseName, 50, convCurrEduClsTeacher.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdCourseType, 4, convCurrEduClsTeacher.IdCourseType);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CourseTypeId, 4, convCurrEduClsTeacher.CourseTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CourseTypeName, 30, convCurrEduClsTeacher.CourseTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdScoreType, 4, convCurrEduClsTeacher.IdScoreType);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdExamType, 4, convCurrEduClsTeacher.IdExamType);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdTeacher, 8, convCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.TeacherId, 12, convCurrEduClsTeacher.TeacherId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.TeacherName, 50, convCurrEduClsTeacher.TeacherName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdProfGrade, 4, convCurrEduClsTeacher.IdProfGrade);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.ProfenssionalGradeName, 30, convCurrEduClsTeacher.ProfenssionalGradeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.DegreeName, 30, convCurrEduClsTeacher.DegreeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.Birthday, 8, convCurrEduClsTeacher.Birthday);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CollegeName, 100, convCurrEduClsTeacher.CollegeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, convCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.EduClsTeacherTypeId, 4, convCurrEduClsTeacher.EduClsTeacherTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc, 20, convCurrEduClsTeacher.EduClsTeacherTypeDesc);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.SchoolTerm, 1, convCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.SchoolYear, 10, convCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.OpenBeginDate, 8, convCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.OpenEndDate, 8, convCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.UpdDate, 20, convCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.UpdUser, 20, convCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.Memo, 1000, convCurrEduClsTeacher.Memo);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CollegeName4EduCls, 60, convCurrEduClsTeacher.CollegeName4EduCls);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.CollegeName4Teacher, 60, convCurrEduClsTeacher.CollegeName4Teacher);
clsCheckSql.CheckFieldLen(objvCurrEduClsTeacherEN.UserType, 50, convCurrEduClsTeacher.UserType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdCurrEduCls, convCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CurrEduClsId, convCurrEduClsTeacher.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.EduClsName, convCurrEduClsTeacher.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.EduClsTypeId, convCurrEduClsTeacher.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.EduClsTypeName, convCurrEduClsTeacher.EduClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CourseId, convCurrEduClsTeacher.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CourseCode, convCurrEduClsTeacher.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CourseName, convCurrEduClsTeacher.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.ExampleImgPath, convCurrEduClsTeacher.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.TeachingSolutionId, convCurrEduClsTeacher.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.TeachingSolutionName, convCurrEduClsTeacher.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdXzCollege, convCurrEduClsTeacher.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CollegeId, convCurrEduClsTeacher.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdEduWay, convCurrEduClsTeacher.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.WeekStatusId, convCurrEduClsTeacher.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CustomerWeek, convCurrEduClsTeacher.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdUniZone, convCurrEduClsTeacher.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdGradeBase, convCurrEduClsTeacher.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.GradeBaseId, convCurrEduClsTeacher.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.GradeBaseName, convCurrEduClsTeacher.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdCourseType, convCurrEduClsTeacher.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CourseTypeId, convCurrEduClsTeacher.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CourseTypeName, convCurrEduClsTeacher.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdScoreType, convCurrEduClsTeacher.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdExamType, convCurrEduClsTeacher.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdTeacher, convCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.TeacherId, convCurrEduClsTeacher.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.TeacherName, convCurrEduClsTeacher.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdProfGrade, convCurrEduClsTeacher.IdProfGrade);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.ProfenssionalGradeName, convCurrEduClsTeacher.ProfenssionalGradeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.DegreeName, convCurrEduClsTeacher.DegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.Birthday, convCurrEduClsTeacher.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CollegeName, convCurrEduClsTeacher.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.IdPk2EduClsTeacherType, convCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.EduClsTeacherTypeId, convCurrEduClsTeacher.EduClsTeacherTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.EduClsTeacherTypeDesc, convCurrEduClsTeacher.EduClsTeacherTypeDesc);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.SchoolTerm, convCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.SchoolYear, convCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.OpenBeginDate, convCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.OpenEndDate, convCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.UpdDate, convCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.UpdUser, convCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.Memo, convCurrEduClsTeacher.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CollegeName4EduCls, convCurrEduClsTeacher.CollegeName4EduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.CollegeName4Teacher, convCurrEduClsTeacher.CollegeName4Teacher);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsTeacherEN.UserType, convCurrEduClsTeacher.UserType);
//检查外键字段长度
 objvCurrEduClsTeacherEN._IsCheckProperty = true;
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsTeacherEN._CurrTabName);
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsTeacherEN._CurrTabName, strCondition);
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
 objSQL = clsvCurrEduClsTeacherDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}