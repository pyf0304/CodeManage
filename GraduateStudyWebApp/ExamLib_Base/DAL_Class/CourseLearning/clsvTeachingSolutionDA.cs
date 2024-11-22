
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingSolutionDA
 表名:vTeachingSolution(01120138)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// v教学方案(vTeachingSolution)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTeachingSolutionDA : clsCommBase4DA
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
 return clsvTeachingSolutionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTeachingSolutionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTeachingSolutionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTeachingSolutionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTeachingSolutionEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTeachingSolutionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTeachingSolutionId)
{
strTeachingSolutionId = strTeachingSolutionId.Replace("'", "''");
if (strTeachingSolutionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTeachingSolution中,检查关键字,长度不正确!(clsvTeachingSolutionDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTeachingSolutionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTeachingSolution中,关键字不能为空 或 null!(clsvTeachingSolutionDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTeachingSolutionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTeachingSolutionDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTeachingSolution(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable_vTeachingSolution)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingSolution.* from vTeachingSolution Left Join {1} on {2} where {3} and vTeachingSolution.TeachingSolutionId not in (Select top {5} vTeachingSolution.TeachingSolutionId from vTeachingSolution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1} and TeachingSolutionId not in (Select top {2} TeachingSolutionId from vTeachingSolution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1} and TeachingSolutionId not in (Select top {3} TeachingSolutionId from vTeachingSolution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTeachingSolution.* from vTeachingSolution Left Join {1} on {2} where {3} and vTeachingSolution.TeachingSolutionId not in (Select top {5} vTeachingSolution.TeachingSolutionId from vTeachingSolution Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1} and TeachingSolutionId not in (Select top {2} TeachingSolutionId from vTeachingSolution where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTeachingSolution where {1} and TeachingSolutionId not in (Select top {3} TeachingSolutionId from vTeachingSolution where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTeachingSolutionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA:GetObjLst)", objException.Message));
}
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingSolutionDA: GetObjLst)", objException.Message));
}
objvTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingSolutionEN);
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
public List<clsvTeachingSolutionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTeachingSolutionEN> arrObjLst = new List<clsvTeachingSolutionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTeachingSolutionDA: GetObjLst)", objException.Message));
}
objvTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTeachingSolutionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTeachingSolutionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTeachingSolution(ref clsvTeachingSolutionEN objvTeachingSolutionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where TeachingSolutionId = " + "'"+ objvTeachingSolutionEN.TeachingSolutionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTeachingSolutionEN.TeachingSolutionId = objDT.Rows[0][convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.TeachingSolutionName = objDT.Rows[0][convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingSolutionEN.CourseId = objDT.Rows[0][convTeachingSolution.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingSolutionEN.CourseCode = objDT.Rows[0][convTeachingSolution.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.CourseDescription = objDT.Rows[0][convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingSolutionEN.IdTeacher = objDT.Rows[0][convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.TeacherId = objDT.Rows[0][convTeachingSolution.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvTeachingSolutionEN.TeacherName = objDT.Rows[0][convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingSolutionEN.IdSex = objDT.Rows[0][convTeachingSolution.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.SexDesc = objDT.Rows[0][convTeachingSolution.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingSolutionEN.CollegeName = objDT.Rows[0][convTeachingSolution.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingSolutionEN.IdProfGrade = objDT.Rows[0][convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.ProfenssionalGradeName = objDT.Rows[0][convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingSolutionEN.CollegeId = objDT.Rows[0][convTeachingSolution.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.IdXzCollege = objDT.Rows[0][convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingSolutionEN.IdXzMajor = objDT.Rows[0][convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.BriefIntroduction = objDT.Rows[0][convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingSolutionEN.UpdDate = objDT.Rows[0][convTeachingSolution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.UpdUser = objDT.Rows[0][convTeachingSolution.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.Memo = objDT.Rows[0][convTeachingSolution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTeachingSolutionDA: GetvTeachingSolution)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingSolutionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTeachingSolutionEN GetObjByTeachingSolutionId(string strTeachingSolutionId)
{
CheckPrimaryKey(strTeachingSolutionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
 objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号(字段类型:char,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称(字段类型:varchar,字段长度:30,是否可空:False)
 objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介(字段类型:varchar,字段长度:8000,是否可空:True)
 objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTeachingSolutionDA: GetObjByTeachingSolutionId)", objException.Message));
}
return objvTeachingSolutionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTeachingSolutionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
strSQL = "Select * from vTeachingSolution where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN()
{
TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(), //教学方案Id
TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(), //教学方案名称
CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(), //课程描述
IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(), //教师姓名
IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(), //性别流水号
SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(), //性别名称
CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(), //学院名称
IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(), //专业职称流水号
ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(), //专业职称
CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(), //学院ID
IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(), //学院流水号
IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(), //专业流水号
BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(), //简介
UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim() //备注
};
objvTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingSolutionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTeachingSolutionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTeachingSolutionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTeachingSolutionDA: GetObjByDataRowvTeachingSolution)", objException.Message));
}
objvTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingSolutionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTeachingSolutionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTeachingSolutionEN objvTeachingSolutionEN = new clsvTeachingSolutionEN();
try
{
objvTeachingSolutionEN.TeachingSolutionId = objRow[convTeachingSolution.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvTeachingSolutionEN.TeachingSolutionName = objRow[convTeachingSolution.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvTeachingSolutionEN.CourseId = objRow[convTeachingSolution.CourseId] == DBNull.Value ? null : objRow[convTeachingSolution.CourseId].ToString().Trim(); //课程Id
objvTeachingSolutionEN.CourseCode = objRow[convTeachingSolution.CourseCode] == DBNull.Value ? null : objRow[convTeachingSolution.CourseCode].ToString().Trim(); //课程代码
objvTeachingSolutionEN.CourseDescription = objRow[convTeachingSolution.CourseDescription] == DBNull.Value ? null : objRow[convTeachingSolution.CourseDescription].ToString().Trim(); //课程描述
objvTeachingSolutionEN.IdTeacher = objRow[convTeachingSolution.IdTeacher].ToString().Trim(); //教师流水号
objvTeachingSolutionEN.TeacherId = objRow[convTeachingSolution.TeacherId].ToString().Trim(); //教师工号
objvTeachingSolutionEN.TeacherName = objRow[convTeachingSolution.TeacherName].ToString().Trim(); //教师姓名
objvTeachingSolutionEN.IdSex = objRow[convTeachingSolution.IdSex].ToString().Trim(); //性别流水号
objvTeachingSolutionEN.SexDesc = objRow[convTeachingSolution.SexDesc] == DBNull.Value ? null : objRow[convTeachingSolution.SexDesc].ToString().Trim(); //性别名称
objvTeachingSolutionEN.CollegeName = objRow[convTeachingSolution.CollegeName].ToString().Trim(); //学院名称
objvTeachingSolutionEN.IdProfGrade = objRow[convTeachingSolution.IdProfGrade].ToString().Trim(); //专业职称流水号
objvTeachingSolutionEN.ProfenssionalGradeName = objRow[convTeachingSolution.ProfenssionalGradeName].ToString().Trim(); //专业职称
objvTeachingSolutionEN.CollegeId = objRow[convTeachingSolution.CollegeId].ToString().Trim(); //学院ID
objvTeachingSolutionEN.IdXzCollege = objRow[convTeachingSolution.IdXzCollege] == DBNull.Value ? null : objRow[convTeachingSolution.IdXzCollege].ToString().Trim(); //学院流水号
objvTeachingSolutionEN.IdXzMajor = objRow[convTeachingSolution.IdXzMajor].ToString().Trim(); //专业流水号
objvTeachingSolutionEN.BriefIntroduction = objRow[convTeachingSolution.BriefIntroduction] == DBNull.Value ? null : objRow[convTeachingSolution.BriefIntroduction].ToString().Trim(); //简介
objvTeachingSolutionEN.UpdDate = objRow[convTeachingSolution.UpdDate].ToString().Trim(); //修改日期
objvTeachingSolutionEN.UpdUser = objRow[convTeachingSolution.UpdUser].ToString().Trim(); //修改人
objvTeachingSolutionEN.Memo = objRow[convTeachingSolution.Memo] == DBNull.Value ? null : objRow[convTeachingSolution.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTeachingSolutionDA: GetObjByDataRow)", objException.Message));
}
objvTeachingSolutionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTeachingSolutionEN;
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
objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingSolutionEN._CurrTabName, convTeachingSolution.TeachingSolutionId, 8, "");
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
objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTeachingSolutionEN._CurrTabName, convTeachingSolution.TeachingSolutionId, 8, strPrefix);
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TeachingSolutionId from vTeachingSolution where " + strCondition;
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TeachingSolutionId from vTeachingSolution where " + strCondition;
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
 /// <param name = "strTeachingSolutionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTeachingSolutionId)
{
CheckPrimaryKey(strTeachingSolutionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingSolution", "TeachingSolutionId = " + "'"+ strTeachingSolutionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTeachingSolutionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTeachingSolution", strCondition))
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
objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTeachingSolution");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTeachingSolutionENS">源对象</param>
 /// <param name = "objvTeachingSolutionENT">目标对象</param>
public void CopyTo(clsvTeachingSolutionEN objvTeachingSolutionENS, clsvTeachingSolutionEN objvTeachingSolutionENT)
{
objvTeachingSolutionENT.TeachingSolutionId = objvTeachingSolutionENS.TeachingSolutionId; //教学方案Id
objvTeachingSolutionENT.TeachingSolutionName = objvTeachingSolutionENS.TeachingSolutionName; //教学方案名称
objvTeachingSolutionENT.CourseId = objvTeachingSolutionENS.CourseId; //课程Id
objvTeachingSolutionENT.CourseCode = objvTeachingSolutionENS.CourseCode; //课程代码
objvTeachingSolutionENT.CourseDescription = objvTeachingSolutionENS.CourseDescription; //课程描述
objvTeachingSolutionENT.IdTeacher = objvTeachingSolutionENS.IdTeacher; //教师流水号
objvTeachingSolutionENT.TeacherId = objvTeachingSolutionENS.TeacherId; //教师工号
objvTeachingSolutionENT.TeacherName = objvTeachingSolutionENS.TeacherName; //教师姓名
objvTeachingSolutionENT.IdSex = objvTeachingSolutionENS.IdSex; //性别流水号
objvTeachingSolutionENT.SexDesc = objvTeachingSolutionENS.SexDesc; //性别名称
objvTeachingSolutionENT.CollegeName = objvTeachingSolutionENS.CollegeName; //学院名称
objvTeachingSolutionENT.IdProfGrade = objvTeachingSolutionENS.IdProfGrade; //专业职称流水号
objvTeachingSolutionENT.ProfenssionalGradeName = objvTeachingSolutionENS.ProfenssionalGradeName; //专业职称
objvTeachingSolutionENT.CollegeId = objvTeachingSolutionENS.CollegeId; //学院ID
objvTeachingSolutionENT.IdXzCollege = objvTeachingSolutionENS.IdXzCollege; //学院流水号
objvTeachingSolutionENT.IdXzMajor = objvTeachingSolutionENS.IdXzMajor; //专业流水号
objvTeachingSolutionENT.BriefIntroduction = objvTeachingSolutionENS.BriefIntroduction; //简介
objvTeachingSolutionENT.UpdDate = objvTeachingSolutionENS.UpdDate; //修改日期
objvTeachingSolutionENT.UpdUser = objvTeachingSolutionENS.UpdUser; //修改人
objvTeachingSolutionENT.Memo = objvTeachingSolutionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTeachingSolutionEN objvTeachingSolutionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.TeachingSolutionId, 8, convTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.TeachingSolutionName, 100, convTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.CourseId, 8, convTeachingSolution.CourseId);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.CourseCode, 20, convTeachingSolution.CourseCode);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.CourseDescription, 8000, convTeachingSolution.CourseDescription);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.IdTeacher, 8, convTeachingSolution.IdTeacher);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.TeacherId, 12, convTeachingSolution.TeacherId);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.TeacherName, 50, convTeachingSolution.TeacherName);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.IdSex, 4, convTeachingSolution.IdSex);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.SexDesc, 10, convTeachingSolution.SexDesc);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.CollegeName, 100, convTeachingSolution.CollegeName);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.IdProfGrade, 4, convTeachingSolution.IdProfGrade);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.ProfenssionalGradeName, 30, convTeachingSolution.ProfenssionalGradeName);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.CollegeId, 4, convTeachingSolution.CollegeId);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.IdXzCollege, 4, convTeachingSolution.IdXzCollege);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.IdXzMajor, 8, convTeachingSolution.IdXzMajor);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.BriefIntroduction, 8000, convTeachingSolution.BriefIntroduction);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.UpdDate, 20, convTeachingSolution.UpdDate);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.UpdUser, 20, convTeachingSolution.UpdUser);
clsCheckSql.CheckFieldLen(objvTeachingSolutionEN.Memo, 1000, convTeachingSolution.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.TeachingSolutionId, convTeachingSolution.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.TeachingSolutionName, convTeachingSolution.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.CourseId, convTeachingSolution.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.CourseCode, convTeachingSolution.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.CourseDescription, convTeachingSolution.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.IdTeacher, convTeachingSolution.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.TeacherId, convTeachingSolution.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.TeacherName, convTeachingSolution.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.IdSex, convTeachingSolution.IdSex);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.SexDesc, convTeachingSolution.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.CollegeName, convTeachingSolution.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.IdProfGrade, convTeachingSolution.IdProfGrade);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.ProfenssionalGradeName, convTeachingSolution.ProfenssionalGradeName);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.CollegeId, convTeachingSolution.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.IdXzCollege, convTeachingSolution.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.IdXzMajor, convTeachingSolution.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.BriefIntroduction, convTeachingSolution.BriefIntroduction);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.UpdDate, convTeachingSolution.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.UpdUser, convTeachingSolution.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvTeachingSolutionEN.Memo, convTeachingSolution.Memo);
//检查外键字段长度
 objvTeachingSolutionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTeachingSolutionId()
{
//获取某学院所有专业信息
string strSQL = "select TeachingSolutionId, TeachingSolutionName from vTeachingSolution ";
 clsSpecSQLforSql mySql = clsvTeachingSolutionDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingSolutionEN._CurrTabName);
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTeachingSolutionEN._CurrTabName, strCondition);
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
 objSQL = clsvTeachingSolutionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}