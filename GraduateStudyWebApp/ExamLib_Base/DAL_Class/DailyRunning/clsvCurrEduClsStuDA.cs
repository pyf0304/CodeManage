
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduClsStuDA
 表名:vCurrEduClsStu(01120127)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/18 17:50:17
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
 /// v教学班与学生关系(vCurrEduClsStu)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCurrEduClsStuDA : clsCommBase4DA
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
 return clsvCurrEduClsStuEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCurrEduClsStuEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduClsStuEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCurrEduClsStuEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCurrEduClsStuEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCurrEduClsStu(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable_vCurrEduClsStu)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduClsStu.* from vCurrEduClsStu Left Join {1} on {2} where {3} and vCurrEduClsStu.IdEduClsStu not in (Select top {5} vCurrEduClsStu.IdEduClsStu from vCurrEduClsStu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1} and IdEduClsStu not in (Select top {2} IdEduClsStu from vCurrEduClsStu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1} and IdEduClsStu not in (Select top {3} IdEduClsStu from vCurrEduClsStu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduClsStu.* from vCurrEduClsStu Left Join {1} on {2} where {3} and vCurrEduClsStu.IdEduClsStu not in (Select top {5} vCurrEduClsStu.IdEduClsStu from vCurrEduClsStu Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1} and IdEduClsStu not in (Select top {2} IdEduClsStu from vCurrEduClsStu where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduClsStu where {1} and IdEduClsStu not in (Select top {3} IdEduClsStu from vCurrEduClsStu where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCurrEduClsStuEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA:GetObjLst)", objException.Message));
}
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = TransNullToBool(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = TransNullToBool(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetObjLst)", objException.Message));
}
objvCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsStuEN);
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
public List<clsvCurrEduClsStuEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCurrEduClsStuEN> arrObjLst = new List<clsvCurrEduClsStuEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = TransNullToBool(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = TransNullToBool(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetObjLst)", objException.Message));
}
objvCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduClsStuEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCurrEduClsStuEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCurrEduClsStu(ref clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where IdEduClsStu = " + ""+ objvCurrEduClsStuEN.IdEduClsStu+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objDT.Rows[0][convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.IdCurrEduCls = objDT.Rows[0][convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.CurrEduClsId = objDT.Rows[0][convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsStuEN.EduClsName = objDT.Rows[0][convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.CourseId = objDT.Rows[0][convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.CourseCode = objDT.Rows[0][convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.CourseName = objDT.Rows[0][convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.TeachingSolutionId = objDT.Rows[0][convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.TeachingSolutionName = objDT.Rows[0][convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.IdXzCollege = objDT.Rows[0][convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.CollegeId = objDT.Rows[0][convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CollegeName = objDT.Rows[0][convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsStuEN.Mark = TransNullToDouble(objDT.Rows[0][convCurrEduClsStu.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduClsStuEN.IdUniZone = objDT.Rows[0][convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.GradeBaseName = objDT.Rows[0][convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsStuEN.IsEffective = TransNullToBool(objDT.Rows[0][convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.IdCourseType = objDT.Rows[0][convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CourseTypeId = objDT.Rows[0][convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CourseTypeName = objDT.Rows[0][convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsStuEN.IsDegree = TransNullToBool(objDT.Rows[0][convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsStuEN.CurrStuNum = TransNullToInt(objDT.Rows[0][convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.IdStu = objDT.Rows[0][convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.StuId = objDT.Rows[0][convCurrEduClsStu.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.StuName = objDT.Rows[0][convCurrEduClsStu.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsStuEN.IdSex = objDT.Rows[0][convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.SexDesc = objDT.Rows[0][convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.MajorID = objDT.Rows[0][convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.MajorName = objDT.Rows[0][convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.IdAdminCls = objDT.Rows[0][convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.Birthday = objDT.Rows[0][convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.EduClsStuStateId = objDT.Rows[0][convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsStuEN.GetScoreTimes = TransNullToShort(objDT.Rows[0][convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数(字段类型:tinyint,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.Score = TransNullToDouble(objDT.Rows[0][convCurrEduClsStu.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvCurrEduClsStuEN.TotalScores = TransNullToDouble(objDT.Rows[0][convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.Ranking = TransNullToInt(objDT.Rows[0][convCurrEduClsStu.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.Percentile = TransNullToDouble(objDT.Rows[0][convCurrEduClsStu.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.Confirmed = TransNullToBool(objDT.Rows[0][convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsStuEN.SchoolTerm = objDT.Rows[0][convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.SchoolYear = objDT.Rows[0][convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.SignInDate = objDT.Rows[0][convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.SignInStateID = objDT.Rows[0][convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsStuEN.SignInUser = objDT.Rows[0][convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsStuEN.ModifyDate = objDT.Rows[0][convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.ModifyUserId = objDT.Rows[0][convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsStuEN.CollegeName4Stu = objDT.Rows[0][convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.EduClsTypeName = objDT.Rows[0][convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.IsSynScore = TransNullToBool(objDT.Rows[0][convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.EduClsTypeId = objDT.Rows[0][convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.UserType = objDT.Rows[0][convCurrEduClsStu.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetvCurrEduClsStu)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdEduClsStu">表关键字</param>
 /// <returns>表对象</returns>
public clsvCurrEduClsStuEN GetObjByIdEduClsStu(long lngIdEduClsStu)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where IdEduClsStu = " + ""+ lngIdEduClsStu+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
 objvCurrEduClsStuEN.IdEduClsStu = Int32.Parse(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduClsStuEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduClsStuEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数(字段类型:tinyint,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值(字段类型:decimal,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位(字段类型:decimal,字段长度:8,是否可空:True)
 objvCurrEduClsStuEN.Confirmed = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduClsStuEN.IsSynScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetObjByIdEduClsStu)", objException.Message));
}
return objvCurrEduClsStuEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCurrEduClsStuEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduClsStu where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN()
{
IdEduClsStu = TransNullToInt(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()), //教学班学生流水号
IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(), //教学班名
CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(), //课程名称
TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(), //教学方案Id
TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(), //教学方案名称
IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(), //学院名称
LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Mark].ToString().Trim()), //获得学分
IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(), //校区流水号
GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(), //年级名称
IsEffective = TransNullToBool(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()), //是否有效
IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(), //课程类型流水号
CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(), //课程类型名称
IsDegree = TransNullToBool(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()), //是否学位课
CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()), //当前学生数
IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(), //学生流水号
StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(), //学号
StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(), //姓名
IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(), //性别流水号
SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(), //性别名称
MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(), //专业名称
IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(), //行政班流水号
Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(), //出生日期
EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(), //教学班学生状态编号
GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()), //获得成绩次数
Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Score].ToString().Trim()), //得分
TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()), //总分值
Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.Ranking].ToString().Trim()), //名次
Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Percentile].ToString().Trim()), //百分位
Confirmed = TransNullToBool(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()), //是否确认
SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(), //学年
SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(), //签入时间
SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(), //签入状态表流水号
SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(), //签入人
ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(), //修改人
CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(), //CollegeName4Stu
EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(), //教学班类型名称
IsSynScore = TransNullToBool(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()), //是否同步成绩
EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(), //教学班类型Id
UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim() //用户类型
};
objvCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsStuEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsStuEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = TransNullToBool(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = TransNullToBool(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetObjByDataRowvCurrEduClsStu)", objException.Message));
}
objvCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsStuEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCurrEduClsStuEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduClsStuEN objvCurrEduClsStuEN = new clsvCurrEduClsStuEN();
try
{
objvCurrEduClsStuEN.IdEduClsStu = TransNullToInt(objRow[convCurrEduClsStu.IdEduClsStu].ToString().Trim()); //教学班学生流水号
objvCurrEduClsStuEN.IdCurrEduCls = objRow[convCurrEduClsStu.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduClsStuEN.CurrEduClsId = objRow[convCurrEduClsStu.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduClsStuEN.EduClsName = objRow[convCurrEduClsStu.EduClsName].ToString().Trim(); //教学班名
objvCurrEduClsStuEN.CourseId = objRow[convCurrEduClsStu.CourseId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseId].ToString().Trim(); //课程Id
objvCurrEduClsStuEN.CourseCode = objRow[convCurrEduClsStu.CourseCode] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseCode].ToString().Trim(); //课程代码
objvCurrEduClsStuEN.CourseName = objRow[convCurrEduClsStu.CourseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseName].ToString().Trim(); //课程名称
objvCurrEduClsStuEN.TeachingSolutionId = objRow[convCurrEduClsStu.TeachingSolutionId] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduClsStuEN.TeachingSolutionName = objRow[convCurrEduClsStu.TeachingSolutionName] == DBNull.Value ? null : objRow[convCurrEduClsStu.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduClsStuEN.IdXzCollege = objRow[convCurrEduClsStu.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduClsStuEN.CollegeId = objRow[convCurrEduClsStu.CollegeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeId].ToString().Trim(); //学院ID
objvCurrEduClsStuEN.CollegeName = objRow[convCurrEduClsStu.CollegeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName].ToString().Trim(); //学院名称
objvCurrEduClsStuEN.LessonQtyPerWeek = objRow[convCurrEduClsStu.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduClsStuEN.Mark = objRow[convCurrEduClsStu.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Mark].ToString().Trim()); //获得学分
objvCurrEduClsStuEN.IdUniZone = objRow[convCurrEduClsStu.IdUniZone] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduClsStuEN.GradeBaseName = objRow[convCurrEduClsStu.GradeBaseName] == DBNull.Value ? null : objRow[convCurrEduClsStu.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduClsStuEN.IsEffective = TransNullToBool(objRow[convCurrEduClsStu.IsEffective].ToString().Trim()); //是否有效
objvCurrEduClsStuEN.IdCourseType = objRow[convCurrEduClsStu.IdCourseType] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduClsStuEN.CourseTypeId = objRow[convCurrEduClsStu.CourseTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduClsStuEN.CourseTypeName = objRow[convCurrEduClsStu.CourseTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduClsStuEN.IsDegree = TransNullToBool(objRow[convCurrEduClsStu.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduClsStuEN.CurrStuNum = objRow[convCurrEduClsStu.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduClsStuEN.IdStu = objRow[convCurrEduClsStu.IdStu] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdStu].ToString().Trim(); //学生流水号
objvCurrEduClsStuEN.StuId = objRow[convCurrEduClsStu.StuId] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuId].ToString().Trim(); //学号
objvCurrEduClsStuEN.StuName = objRow[convCurrEduClsStu.StuName] == DBNull.Value ? null : objRow[convCurrEduClsStu.StuName].ToString().Trim(); //姓名
objvCurrEduClsStuEN.IdSex = objRow[convCurrEduClsStu.IdSex].ToString().Trim(); //性别流水号
objvCurrEduClsStuEN.SexDesc = objRow[convCurrEduClsStu.SexDesc] == DBNull.Value ? null : objRow[convCurrEduClsStu.SexDesc].ToString().Trim(); //性别名称
objvCurrEduClsStuEN.MajorID = objRow[convCurrEduClsStu.MajorID] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorID].ToString().Trim(); //专业ID
objvCurrEduClsStuEN.MajorName = objRow[convCurrEduClsStu.MajorName] == DBNull.Value ? null : objRow[convCurrEduClsStu.MajorName].ToString().Trim(); //专业名称
objvCurrEduClsStuEN.IdAdminCls = objRow[convCurrEduClsStu.IdAdminCls] == DBNull.Value ? null : objRow[convCurrEduClsStu.IdAdminCls].ToString().Trim(); //行政班流水号
objvCurrEduClsStuEN.Birthday = objRow[convCurrEduClsStu.Birthday] == DBNull.Value ? null : objRow[convCurrEduClsStu.Birthday].ToString().Trim(); //出生日期
objvCurrEduClsStuEN.EduClsStuStateId = objRow[convCurrEduClsStu.EduClsStuStateId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsStuStateId].ToString().Trim(); //教学班学生状态编号
objvCurrEduClsStuEN.GetScoreTimes = objRow[convCurrEduClsStu.GetScoreTimes] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduClsStu.GetScoreTimes].ToString().Trim()); //获得成绩次数
objvCurrEduClsStuEN.Score = objRow[convCurrEduClsStu.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Score].ToString().Trim()); //得分
objvCurrEduClsStuEN.TotalScores = objRow[convCurrEduClsStu.TotalScores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.TotalScores].ToString().Trim()); //总分值
objvCurrEduClsStuEN.Ranking = objRow[convCurrEduClsStu.Ranking] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduClsStu.Ranking].ToString().Trim()); //名次
objvCurrEduClsStuEN.Percentile = objRow[convCurrEduClsStu.Percentile] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduClsStu.Percentile].ToString().Trim()); //百分位
objvCurrEduClsStuEN.Confirmed = TransNullToBool(objRow[convCurrEduClsStu.Confirmed].ToString().Trim()); //是否确认
objvCurrEduClsStuEN.SchoolTerm = objRow[convCurrEduClsStu.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolTerm].ToString().Trim(); //学期
objvCurrEduClsStuEN.SchoolYear = objRow[convCurrEduClsStu.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduClsStu.SchoolYear].ToString().Trim(); //学年
objvCurrEduClsStuEN.SignInDate = objRow[convCurrEduClsStu.SignInDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInDate].ToString().Trim(); //签入时间
objvCurrEduClsStuEN.SignInStateID = objRow[convCurrEduClsStu.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduClsStuEN.SignInUser = objRow[convCurrEduClsStu.SignInUser] == DBNull.Value ? null : objRow[convCurrEduClsStu.SignInUser].ToString().Trim(); //签入人
objvCurrEduClsStuEN.ModifyDate = objRow[convCurrEduClsStu.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduClsStuEN.ModifyUserId = objRow[convCurrEduClsStu.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduClsStu.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduClsStuEN.CollegeName4Stu = objRow[convCurrEduClsStu.CollegeName4Stu] == DBNull.Value ? null : objRow[convCurrEduClsStu.CollegeName4Stu].ToString().Trim(); //CollegeName4Stu
objvCurrEduClsStuEN.EduClsTypeName = objRow[convCurrEduClsStu.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduClsStuEN.IsSynScore = TransNullToBool(objRow[convCurrEduClsStu.IsSynScore].ToString().Trim()); //是否同步成绩
objvCurrEduClsStuEN.EduClsTypeId = objRow[convCurrEduClsStu.EduClsTypeId] == DBNull.Value ? null : objRow[convCurrEduClsStu.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduClsStuEN.UserType = objRow[convCurrEduClsStu.UserType] == DBNull.Value ? null : objRow[convCurrEduClsStu.UserType].ToString().Trim(); //用户类型
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCurrEduClsStuDA: GetObjByDataRow)", objException.Message));
}
objvCurrEduClsStuEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduClsStuEN;
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
objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsStuEN._CurrTabName, convCurrEduClsStu.IdEduClsStu, 8, "");
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
objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduClsStuEN._CurrTabName, convCurrEduClsStu.IdEduClsStu, 8, strPrefix);
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduClsStu from vCurrEduClsStu where " + strCondition;
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduClsStu from vCurrEduClsStu where " + strCondition;
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
 /// <param name = "lngIdEduClsStu">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdEduClsStu)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduClsStu", "IdEduClsStu = " + ""+ lngIdEduClsStu+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCurrEduClsStuDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduClsStu", strCondition))
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
objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCurrEduClsStu");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCurrEduClsStuENS">源对象</param>
 /// <param name = "objvCurrEduClsStuENT">目标对象</param>
public void CopyTo(clsvCurrEduClsStuEN objvCurrEduClsStuENS, clsvCurrEduClsStuEN objvCurrEduClsStuENT)
{
objvCurrEduClsStuENT.IdEduClsStu = objvCurrEduClsStuENS.IdEduClsStu; //教学班学生流水号
objvCurrEduClsStuENT.IdCurrEduCls = objvCurrEduClsStuENS.IdCurrEduCls; //教学班流水号
objvCurrEduClsStuENT.CurrEduClsId = objvCurrEduClsStuENS.CurrEduClsId; //教学班Id
objvCurrEduClsStuENT.EduClsName = objvCurrEduClsStuENS.EduClsName; //教学班名
objvCurrEduClsStuENT.CourseId = objvCurrEduClsStuENS.CourseId; //课程Id
objvCurrEduClsStuENT.CourseCode = objvCurrEduClsStuENS.CourseCode; //课程代码
objvCurrEduClsStuENT.CourseName = objvCurrEduClsStuENS.CourseName; //课程名称
objvCurrEduClsStuENT.TeachingSolutionId = objvCurrEduClsStuENS.TeachingSolutionId; //教学方案Id
objvCurrEduClsStuENT.TeachingSolutionName = objvCurrEduClsStuENS.TeachingSolutionName; //教学方案名称
objvCurrEduClsStuENT.IdXzCollege = objvCurrEduClsStuENS.IdXzCollege; //学院流水号
objvCurrEduClsStuENT.CollegeId = objvCurrEduClsStuENS.CollegeId; //学院ID
objvCurrEduClsStuENT.CollegeName = objvCurrEduClsStuENS.CollegeName; //学院名称
objvCurrEduClsStuENT.LessonQtyPerWeek = objvCurrEduClsStuENS.LessonQtyPerWeek; //周课时数
objvCurrEduClsStuENT.Mark = objvCurrEduClsStuENS.Mark; //获得学分
objvCurrEduClsStuENT.IdUniZone = objvCurrEduClsStuENS.IdUniZone; //校区流水号
objvCurrEduClsStuENT.GradeBaseName = objvCurrEduClsStuENS.GradeBaseName; //年级名称
objvCurrEduClsStuENT.IsEffective = objvCurrEduClsStuENS.IsEffective; //是否有效
objvCurrEduClsStuENT.IdCourseType = objvCurrEduClsStuENS.IdCourseType; //课程类型流水号
objvCurrEduClsStuENT.CourseTypeId = objvCurrEduClsStuENS.CourseTypeId; //课程类型ID
objvCurrEduClsStuENT.CourseTypeName = objvCurrEduClsStuENS.CourseTypeName; //课程类型名称
objvCurrEduClsStuENT.IsDegree = objvCurrEduClsStuENS.IsDegree; //是否学位课
objvCurrEduClsStuENT.CurrStuNum = objvCurrEduClsStuENS.CurrStuNum; //当前学生数
objvCurrEduClsStuENT.IdStu = objvCurrEduClsStuENS.IdStu; //学生流水号
objvCurrEduClsStuENT.StuId = objvCurrEduClsStuENS.StuId; //学号
objvCurrEduClsStuENT.StuName = objvCurrEduClsStuENS.StuName; //姓名
objvCurrEduClsStuENT.IdSex = objvCurrEduClsStuENS.IdSex; //性别流水号
objvCurrEduClsStuENT.SexDesc = objvCurrEduClsStuENS.SexDesc; //性别名称
objvCurrEduClsStuENT.MajorID = objvCurrEduClsStuENS.MajorID; //专业ID
objvCurrEduClsStuENT.MajorName = objvCurrEduClsStuENS.MajorName; //专业名称
objvCurrEduClsStuENT.IdAdminCls = objvCurrEduClsStuENS.IdAdminCls; //行政班流水号
objvCurrEduClsStuENT.Birthday = objvCurrEduClsStuENS.Birthday; //出生日期
objvCurrEduClsStuENT.EduClsStuStateId = objvCurrEduClsStuENS.EduClsStuStateId; //教学班学生状态编号
objvCurrEduClsStuENT.GetScoreTimes = objvCurrEduClsStuENS.GetScoreTimes; //获得成绩次数
objvCurrEduClsStuENT.Score = objvCurrEduClsStuENS.Score; //得分
objvCurrEduClsStuENT.TotalScores = objvCurrEduClsStuENS.TotalScores; //总分值
objvCurrEduClsStuENT.Ranking = objvCurrEduClsStuENS.Ranking; //名次
objvCurrEduClsStuENT.Percentile = objvCurrEduClsStuENS.Percentile; //百分位
objvCurrEduClsStuENT.Confirmed = objvCurrEduClsStuENS.Confirmed; //是否确认
objvCurrEduClsStuENT.SchoolTerm = objvCurrEduClsStuENS.SchoolTerm; //学期
objvCurrEduClsStuENT.SchoolYear = objvCurrEduClsStuENS.SchoolYear; //学年
objvCurrEduClsStuENT.SignInDate = objvCurrEduClsStuENS.SignInDate; //签入时间
objvCurrEduClsStuENT.SignInStateID = objvCurrEduClsStuENS.SignInStateID; //签入状态表流水号
objvCurrEduClsStuENT.SignInUser = objvCurrEduClsStuENS.SignInUser; //签入人
objvCurrEduClsStuENT.ModifyDate = objvCurrEduClsStuENS.ModifyDate; //修改日期
objvCurrEduClsStuENT.ModifyUserId = objvCurrEduClsStuENS.ModifyUserId; //修改人
objvCurrEduClsStuENT.CollegeName4Stu = objvCurrEduClsStuENS.CollegeName4Stu; //CollegeName4Stu
objvCurrEduClsStuENT.EduClsTypeName = objvCurrEduClsStuENS.EduClsTypeName; //教学班类型名称
objvCurrEduClsStuENT.IsSynScore = objvCurrEduClsStuENS.IsSynScore; //是否同步成绩
objvCurrEduClsStuENT.EduClsTypeId = objvCurrEduClsStuENS.EduClsTypeId; //教学班类型Id
objvCurrEduClsStuENT.UserType = objvCurrEduClsStuENS.UserType; //用户类型
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCurrEduClsStuEN objvCurrEduClsStuEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdCurrEduCls, 8, convCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CurrEduClsId, 15, convCurrEduClsStu.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.EduClsName, 100, convCurrEduClsStu.EduClsName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CourseId, 8, convCurrEduClsStu.CourseId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CourseCode, 20, convCurrEduClsStu.CourseCode);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CourseName, 100, convCurrEduClsStu.CourseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.TeachingSolutionId, 8, convCurrEduClsStu.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.TeachingSolutionName, 100, convCurrEduClsStu.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdXzCollege, 4, convCurrEduClsStu.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CollegeId, 4, convCurrEduClsStu.CollegeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CollegeName, 100, convCurrEduClsStu.CollegeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdUniZone, 4, convCurrEduClsStu.IdUniZone);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.GradeBaseName, 50, convCurrEduClsStu.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdCourseType, 4, convCurrEduClsStu.IdCourseType);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CourseTypeId, 4, convCurrEduClsStu.CourseTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CourseTypeName, 30, convCurrEduClsStu.CourseTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdStu, 8, convCurrEduClsStu.IdStu);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.StuId, 20, convCurrEduClsStu.StuId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.StuName, 50, convCurrEduClsStu.StuName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdSex, 4, convCurrEduClsStu.IdSex);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SexDesc, 10, convCurrEduClsStu.SexDesc);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.MajorID, 4, convCurrEduClsStu.MajorID);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.MajorName, 100, convCurrEduClsStu.MajorName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.IdAdminCls, 8, convCurrEduClsStu.IdAdminCls);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.Birthday, 8, convCurrEduClsStu.Birthday);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.EduClsStuStateId, 2, convCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SchoolTerm, 1, convCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SchoolYear, 10, convCurrEduClsStu.SchoolYear);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SignInDate, 20, convCurrEduClsStu.SignInDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SignInStateID, 2, convCurrEduClsStu.SignInStateID);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.SignInUser, 18, convCurrEduClsStu.SignInUser);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.ModifyDate, 20, convCurrEduClsStu.ModifyDate);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.ModifyUserId, 18, convCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.CollegeName4Stu, 100, convCurrEduClsStu.CollegeName4Stu);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.EduClsTypeName, 100, convCurrEduClsStu.EduClsTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.EduClsTypeId, 4, convCurrEduClsStu.EduClsTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduClsStuEN.UserType, 50, convCurrEduClsStu.UserType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdCurrEduCls, convCurrEduClsStu.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CurrEduClsId, convCurrEduClsStu.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.EduClsName, convCurrEduClsStu.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CourseId, convCurrEduClsStu.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CourseCode, convCurrEduClsStu.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CourseName, convCurrEduClsStu.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.TeachingSolutionId, convCurrEduClsStu.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.TeachingSolutionName, convCurrEduClsStu.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdXzCollege, convCurrEduClsStu.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CollegeId, convCurrEduClsStu.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CollegeName, convCurrEduClsStu.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdUniZone, convCurrEduClsStu.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.GradeBaseName, convCurrEduClsStu.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdCourseType, convCurrEduClsStu.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CourseTypeId, convCurrEduClsStu.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CourseTypeName, convCurrEduClsStu.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdStu, convCurrEduClsStu.IdStu);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.StuId, convCurrEduClsStu.StuId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.StuName, convCurrEduClsStu.StuName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdSex, convCurrEduClsStu.IdSex);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SexDesc, convCurrEduClsStu.SexDesc);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.MajorID, convCurrEduClsStu.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.MajorName, convCurrEduClsStu.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.IdAdminCls, convCurrEduClsStu.IdAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.Birthday, convCurrEduClsStu.Birthday);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.EduClsStuStateId, convCurrEduClsStu.EduClsStuStateId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SchoolTerm, convCurrEduClsStu.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SchoolYear, convCurrEduClsStu.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SignInDate, convCurrEduClsStu.SignInDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SignInStateID, convCurrEduClsStu.SignInStateID);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.SignInUser, convCurrEduClsStu.SignInUser);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.ModifyDate, convCurrEduClsStu.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.ModifyUserId, convCurrEduClsStu.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.CollegeName4Stu, convCurrEduClsStu.CollegeName4Stu);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.EduClsTypeName, convCurrEduClsStu.EduClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.EduClsTypeId, convCurrEduClsStu.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduClsStuEN.UserType, convCurrEduClsStu.UserType);
//检查外键字段长度
 objvCurrEduClsStuEN._IsCheckProperty = true;
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsStuEN._CurrTabName);
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduClsStuEN._CurrTabName, strCondition);
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
 objSQL = clsvCurrEduClsStuDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}