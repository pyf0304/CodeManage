
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseDA
 表名:cc_Course(01120056)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:46
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// 课程(cc_Course)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseDA : clsCommBase4DA
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
 return clscc_CourseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseId)
{
strCourseId = strCourseId.Replace("'", "''");
if (strCourseId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_Course中,检查关键字,长度不正确!(clscc_CourseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_Course中,关键字不能为空 或 null!(clscc_CourseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_Course(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable_cc_Course)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_Course where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Course.* from cc_Course Left Join {1} on {2} where {3} and cc_Course.CourseId not in (Select top {5} cc_Course.CourseId from cc_Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1} and CourseId not in (Select top {2} CourseId from cc_Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1} and CourseId not in (Select top {3} CourseId from cc_Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_Course.* from cc_Course Left Join {1} on {2} where {3} and cc_Course.CourseId not in (Select top {5} cc_Course.CourseId from cc_Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1} and CourseId not in (Select top {2} CourseId from cc_Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_Course where {1} and CourseId not in (Select top {3} CourseId from cc_Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseDA:GetObjLst)", objException.Message));
}
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = TransNullToBool(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = TransNullToBool(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseDA: GetObjLst)", objException.Message));
}
objcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseEN);
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
public List<clscc_CourseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseEN> arrObjLst = new List<clscc_CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = TransNullToBool(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = TransNullToBool(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseDA: GetObjLst)", objException.Message));
}
objcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_Course(ref clscc_CourseEN objcc_CourseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where CourseId = " + "'"+ objcc_CourseEN.CourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseEN.CourseId = objDT.Rows[0][concc_Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseEN.CourseCode = objDT.Rows[0][concc_Course.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.CourseDescription = objDT.Rows[0][concc_Course.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_CourseEN.CourseName = objDT.Rows[0][concc_Course.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseEN.CourseTypeId = objDT.Rows[0][concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objcc_CourseEN.CreateDate = objDT.Rows[0][concc_Course.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.ExcellentTypeId = objDT.Rows[0][concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.ExcellentYear = TransNullToInt(objDT.Rows[0][concc_Course.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.IsBuildingCourse = TransNullToBool(objDT.Rows[0][concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objDT.Rows[0][concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsOpen = TransNullToBool(objDT.Rows[0][concc_Course.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsRecommendedCourse = TransNullToBool(objDT.Rows[0][concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objDT.Rows[0][concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.OperationDate = objDT.Rows[0][concc_Course.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.OrderNum = TransNullToInt(objDT.Rows[0][concc_Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.OuterLink = objDT.Rows[0][concc_Course.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseEN.ViewCount = TransNullToInt(objDT.Rows[0][concc_Course.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.ThemeId = objDT.Rows[0][concc_Course.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objcc_CourseEN.IdSchool = objDT.Rows[0][concc_Course.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.IdXzMajor = objDT.Rows[0][concc_Course.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseEN.IdXzCollege = objDT.Rows[0][concc_Course.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.IsHasOpQues = TransNullToBool(objDT.Rows[0][concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题(字段类型:bit,字段长度:1,是否可空:False)
 objcc_CourseEN.UpdDate = objDT.Rows[0][concc_Course.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.UpdUserId = objDT.Rows[0][concc_Course.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.Memo = objDT.Rows[0][concc_Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseDA: Getcc_Course)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseEN GetObjByCourseId(string strCourseId)
{
CheckPrimaryKey(strCourseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where CourseId = " + "'"+ strCourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
 objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseEN.IsHasOpQues = clsEntityBase2.TransNullToBool_S(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题(字段类型:bit,字段长度:1,是否可空:False)
 objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseDA: GetObjByCourseId)", objException.Message));
}
return objcc_CourseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN()
{
CourseId = objRow[concc_Course.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[concc_Course.CourseName].ToString().Trim(), //课程名称
CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(), //课程类型ID
CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(), //建立日期
ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(), //精品课程类型Id
ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ExcellentYear].ToString().Trim()), //课程年份
IsBuildingCourse = TransNullToBool(objRow[concc_Course.IsBuildingCourse].ToString().Trim()), //是否已建设课程
IsDoubleLanguageCourse = TransNullToBool(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()), //是否双语课程
IsOpen = TransNullToBool(objRow[concc_Course.IsOpen].ToString().Trim()), //是否公开
IsRecommendedCourse = TransNullToBool(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()), //是否推荐课程
IsSelfPropelledCourse = TransNullToBool(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()), //是否自荐课程
OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(), //操作时间
OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.OrderNum].ToString().Trim()), //序号
OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(), //外链地址
ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ViewCount].ToString().Trim()), //浏览量
ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(), //主题Id
IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(), //学校流水号
IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(), //专业流水号
IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(), //学院流水号
IsHasOpQues = TransNullToBool(objRow[concc_Course.IsHasOpQues].ToString().Trim()), //是否有操作题
UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim() //备注
};
objcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = TransNullToBool(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = TransNullToBool(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseDA: GetObjByDataRowcc_Course)", objException.Message));
}
objcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseEN objcc_CourseEN = new clscc_CourseEN();
try
{
objcc_CourseEN.CourseId = objRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objcc_CourseEN.CourseCode = objRow[concc_Course.CourseCode] == DBNull.Value ? null : objRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objcc_CourseEN.CourseDescription = objRow[concc_Course.CourseDescription] == DBNull.Value ? null : objRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objcc_CourseEN.CourseName = objRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objcc_CourseEN.CourseTypeId = objRow[concc_Course.CourseTypeId] == DBNull.Value ? null : objRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objcc_CourseEN.CreateDate = objRow[concc_Course.CreateDate] == DBNull.Value ? null : objRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objcc_CourseEN.ExcellentTypeId = objRow[concc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objcc_CourseEN.ExcellentYear = objRow[concc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ExcellentYear].ToString().Trim()); //课程年份
objcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[concc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objcc_CourseEN.IsOpen = TransNullToBool(objRow[concc_Course.IsOpen].ToString().Trim()); //是否公开
objcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[concc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[concc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objcc_CourseEN.OperationDate = objRow[concc_Course.OperationDate] == DBNull.Value ? null : objRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objcc_CourseEN.OrderNum = objRow[concc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.OrderNum].ToString().Trim()); //序号
objcc_CourseEN.OuterLink = objRow[concc_Course.OuterLink] == DBNull.Value ? null : objRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objcc_CourseEN.ViewCount = objRow[concc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_Course.ViewCount].ToString().Trim()); //浏览量
objcc_CourseEN.ThemeId = objRow[concc_Course.ThemeId] == DBNull.Value ? null : objRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objcc_CourseEN.IdSchool = objRow[concc_Course.IdSchool] == DBNull.Value ? null : objRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objcc_CourseEN.IdXzMajor = objRow[concc_Course.IdXzMajor] == DBNull.Value ? null : objRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objcc_CourseEN.IdXzCollege = objRow[concc_Course.IdXzCollege] == DBNull.Value ? null : objRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objcc_CourseEN.IsHasOpQues = TransNullToBool(objRow[concc_Course.IsHasOpQues].ToString().Trim()); //是否有操作题
objcc_CourseEN.UpdDate = objRow[concc_Course.UpdDate] == DBNull.Value ? null : objRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objcc_CourseEN.UpdUserId = objRow[concc_Course.UpdUserId] == DBNull.Value ? null : objRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objcc_CourseEN.Memo = objRow[concc_Course.Memo] == DBNull.Value ? null : objRow[concc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseEN;
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
objSQL = clscc_CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseEN._CurrTabName, concc_Course.CourseId, 8, "");
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
objSQL = clscc_CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseEN._CurrTabName, concc_Course.CourseId, 8, strPrefix);
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseId from cc_Course where " + strCondition;
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseId from cc_Course where " + strCondition;
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
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseId)
{
CheckPrimaryKey(strCourseId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Course", "CourseId = " + "'"+ strCourseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_Course", strCondition))
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
objSQL = clscc_CourseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_Course");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseEN objcc_CourseEN)
 {
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Course");
objRow = objDS.Tables["cc_Course"].NewRow();
objRow[concc_Course.CourseId] = objcc_CourseEN.CourseId; //课程Id
 if (objcc_CourseEN.CourseCode !=  "")
 {
objRow[concc_Course.CourseCode] = objcc_CourseEN.CourseCode; //课程代码
 }
 if (objcc_CourseEN.CourseDescription !=  "")
 {
objRow[concc_Course.CourseDescription] = objcc_CourseEN.CourseDescription; //课程描述
 }
objRow[concc_Course.CourseName] = objcc_CourseEN.CourseName; //课程名称
 if (objcc_CourseEN.CourseTypeId !=  "")
 {
objRow[concc_Course.CourseTypeId] = objcc_CourseEN.CourseTypeId; //课程类型ID
 }
 if (objcc_CourseEN.CreateDate !=  "")
 {
objRow[concc_Course.CreateDate] = objcc_CourseEN.CreateDate; //建立日期
 }
 if (objcc_CourseEN.ExcellentTypeId !=  "")
 {
objRow[concc_Course.ExcellentTypeId] = objcc_CourseEN.ExcellentTypeId; //精品课程类型Id
 }
objRow[concc_Course.ExcellentYear] = objcc_CourseEN.ExcellentYear; //课程年份
objRow[concc_Course.IsBuildingCourse] = objcc_CourseEN.IsBuildingCourse; //是否已建设课程
objRow[concc_Course.IsDoubleLanguageCourse] = objcc_CourseEN.IsDoubleLanguageCourse; //是否双语课程
objRow[concc_Course.IsOpen] = objcc_CourseEN.IsOpen; //是否公开
objRow[concc_Course.IsRecommendedCourse] = objcc_CourseEN.IsRecommendedCourse; //是否推荐课程
objRow[concc_Course.IsSelfPropelledCourse] = objcc_CourseEN.IsSelfPropelledCourse; //是否自荐课程
 if (objcc_CourseEN.OperationDate !=  "")
 {
objRow[concc_Course.OperationDate] = objcc_CourseEN.OperationDate; //操作时间
 }
objRow[concc_Course.OrderNum] = objcc_CourseEN.OrderNum; //序号
 if (objcc_CourseEN.OuterLink !=  "")
 {
objRow[concc_Course.OuterLink] = objcc_CourseEN.OuterLink; //外链地址
 }
objRow[concc_Course.ViewCount] = objcc_CourseEN.ViewCount; //浏览量
 if (objcc_CourseEN.ThemeId !=  "")
 {
objRow[concc_Course.ThemeId] = objcc_CourseEN.ThemeId; //主题Id
 }
 if (objcc_CourseEN.IdSchool !=  "")
 {
objRow[concc_Course.IdSchool] = objcc_CourseEN.IdSchool; //学校流水号
 }
 if (objcc_CourseEN.IdXzMajor !=  "")
 {
objRow[concc_Course.IdXzMajor] = objcc_CourseEN.IdXzMajor; //专业流水号
 }
 if (objcc_CourseEN.IdXzCollege !=  "")
 {
objRow[concc_Course.IdXzCollege] = objcc_CourseEN.IdXzCollege; //学院流水号
 }
objRow[concc_Course.IsHasOpQues] = objcc_CourseEN.IsHasOpQues; //是否有操作题
 if (objcc_CourseEN.UpdDate !=  "")
 {
objRow[concc_Course.UpdDate] = objcc_CourseEN.UpdDate; //修改日期
 }
 if (objcc_CourseEN.UpdUserId !=  "")
 {
objRow[concc_Course.UpdUserId] = objcc_CourseEN.UpdUserId; //修改用户Id
 }
 if (objcc_CourseEN.Memo !=  "")
 {
objRow[concc_Course.Memo] = objcc_CourseEN.Memo; //备注
 }
objDS.Tables[clscc_CourseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseEN._CurrTabName);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseEN objcc_CourseEN)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseId);
 var strCourseId = objcc_CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseEN.CourseCode !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseCode);
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCode + "'");
 }
 
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseDescription);
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseDescription + "'");
 }
 
 if (objcc_CourseEN.CourseName !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseName);
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseName + "'");
 }
 
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseTypeId);
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeId + "'");
 }
 
 if (objcc_CourseEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CreateDate);
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentTypeId);
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTypeId + "'");
 }
 
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentYear);
 arrValueListForInsert.Add(objcc_CourseEN.ExcellentYear.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Course.IsBuildingCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsBuildingCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsDoubleLanguageCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsDoubleLanguageCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsOpen);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsRecommendedCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsRecommendedCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsSelfPropelledCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsSelfPropelledCourse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.OperationDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OperationDate);
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationDate + "'");
 }
 
 if (objcc_CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OrderNum);
 arrValueListForInsert.Add(objcc_CourseEN.OrderNum.ToString());
 }
 
 if (objcc_CourseEN.OuterLink !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OuterLink);
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOuterLink + "'");
 }
 
 if (objcc_CourseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ViewCount);
 arrValueListForInsert.Add(objcc_CourseEN.ViewCount.ToString());
 }
 
 if (objcc_CourseEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ThemeId);
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_CourseEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdSchool);
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzMajor);
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzCollege);
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 arrFieldListForInsert.Add(concc_Course.IsHasOpQues);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsHasOpQues  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdDate);
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdUserId);
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.Memo);
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Course");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseEN objcc_CourseEN)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseId);
 var strCourseId = objcc_CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseEN.CourseCode !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseCode);
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCode + "'");
 }
 
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseDescription);
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseDescription + "'");
 }
 
 if (objcc_CourseEN.CourseName !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseName);
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseName + "'");
 }
 
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseTypeId);
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeId + "'");
 }
 
 if (objcc_CourseEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CreateDate);
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentTypeId);
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTypeId + "'");
 }
 
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentYear);
 arrValueListForInsert.Add(objcc_CourseEN.ExcellentYear.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Course.IsBuildingCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsBuildingCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsDoubleLanguageCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsDoubleLanguageCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsOpen);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsRecommendedCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsRecommendedCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsSelfPropelledCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsSelfPropelledCourse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.OperationDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OperationDate);
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationDate + "'");
 }
 
 if (objcc_CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OrderNum);
 arrValueListForInsert.Add(objcc_CourseEN.OrderNum.ToString());
 }
 
 if (objcc_CourseEN.OuterLink !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OuterLink);
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOuterLink + "'");
 }
 
 if (objcc_CourseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ViewCount);
 arrValueListForInsert.Add(objcc_CourseEN.ViewCount.ToString());
 }
 
 if (objcc_CourseEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ThemeId);
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_CourseEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdSchool);
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzMajor);
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzCollege);
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 arrFieldListForInsert.Add(concc_Course.IsHasOpQues);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsHasOpQues  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdDate);
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdUserId);
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.Memo);
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Course");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseEN.CourseId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseEN objcc_CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseId);
 var strCourseId = objcc_CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseEN.CourseCode !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseCode);
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCode + "'");
 }
 
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseDescription);
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseDescription + "'");
 }
 
 if (objcc_CourseEN.CourseName !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseName);
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseName + "'");
 }
 
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseTypeId);
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeId + "'");
 }
 
 if (objcc_CourseEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CreateDate);
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentTypeId);
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTypeId + "'");
 }
 
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentYear);
 arrValueListForInsert.Add(objcc_CourseEN.ExcellentYear.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Course.IsBuildingCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsBuildingCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsDoubleLanguageCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsDoubleLanguageCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsOpen);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsRecommendedCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsRecommendedCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsSelfPropelledCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsSelfPropelledCourse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.OperationDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OperationDate);
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationDate + "'");
 }
 
 if (objcc_CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OrderNum);
 arrValueListForInsert.Add(objcc_CourseEN.OrderNum.ToString());
 }
 
 if (objcc_CourseEN.OuterLink !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OuterLink);
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOuterLink + "'");
 }
 
 if (objcc_CourseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ViewCount);
 arrValueListForInsert.Add(objcc_CourseEN.ViewCount.ToString());
 }
 
 if (objcc_CourseEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ThemeId);
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_CourseEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdSchool);
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzMajor);
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzCollege);
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 arrFieldListForInsert.Add(concc_Course.IsHasOpQues);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsHasOpQues  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdDate);
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdUserId);
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.Memo);
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Course");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseEN.CourseId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseEN objcc_CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseId);
 var strCourseId = objcc_CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseEN.CourseCode !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseCode);
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseCode + "'");
 }
 
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseDescription);
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseDescription + "'");
 }
 
 if (objcc_CourseEN.CourseName !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseName);
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseName + "'");
 }
 
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CourseTypeId);
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseTypeId + "'");
 }
 
 if (objcc_CourseEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.CreateDate);
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentTypeId);
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExcellentTypeId + "'");
 }
 
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ExcellentYear);
 arrValueListForInsert.Add(objcc_CourseEN.ExcellentYear.ToString());
 }
 
 arrFieldListForInsert.Add(concc_Course.IsBuildingCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsBuildingCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsDoubleLanguageCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsDoubleLanguageCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsOpen);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsOpen  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsRecommendedCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsRecommendedCourse  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_Course.IsSelfPropelledCourse);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsSelfPropelledCourse  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.OperationDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OperationDate);
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperationDate + "'");
 }
 
 if (objcc_CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OrderNum);
 arrValueListForInsert.Add(objcc_CourseEN.OrderNum.ToString());
 }
 
 if (objcc_CourseEN.OuterLink !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.OuterLink);
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOuterLink + "'");
 }
 
 if (objcc_CourseEN.ViewCount !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ViewCount);
 arrValueListForInsert.Add(objcc_CourseEN.ViewCount.ToString());
 }
 
 if (objcc_CourseEN.ThemeId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.ThemeId);
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strThemeId + "'");
 }
 
 if (objcc_CourseEN.IdSchool !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdSchool);
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdSchool + "'");
 }
 
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzMajor);
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzMajor + "'");
 }
 
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.IdXzCollege);
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 arrFieldListForInsert.Add(concc_Course.IsHasOpQues);
 arrValueListForInsert.Add("'" + (objcc_CourseEN.IsHasOpQues  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdDate);
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.UpdUserId);
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_Course.Memo);
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_Course");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_Courses(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where CourseId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_Course");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseId = oRow[concc_Course.CourseId].ToString().Trim();
if (IsExist(strCourseId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseId = {0}", strCourseId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseEN._CurrTabName ].NewRow();
objRow[concc_Course.CourseId] = oRow[concc_Course.CourseId].ToString().Trim(); //课程Id
objRow[concc_Course.CourseCode] = oRow[concc_Course.CourseCode].ToString().Trim(); //课程代码
objRow[concc_Course.CourseDescription] = oRow[concc_Course.CourseDescription].ToString().Trim(); //课程描述
objRow[concc_Course.CourseName] = oRow[concc_Course.CourseName].ToString().Trim(); //课程名称
objRow[concc_Course.CourseTypeId] = oRow[concc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objRow[concc_Course.CreateDate] = oRow[concc_Course.CreateDate].ToString().Trim(); //建立日期
objRow[concc_Course.ExcellentTypeId] = oRow[concc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objRow[concc_Course.ExcellentYear] = oRow[concc_Course.ExcellentYear].ToString().Trim(); //课程年份
objRow[concc_Course.IsBuildingCourse] = oRow[concc_Course.IsBuildingCourse].ToString().Trim(); //是否已建设课程
objRow[concc_Course.IsDoubleLanguageCourse] = oRow[concc_Course.IsDoubleLanguageCourse].ToString().Trim(); //是否双语课程
objRow[concc_Course.IsOpen] = oRow[concc_Course.IsOpen].ToString().Trim(); //是否公开
objRow[concc_Course.IsRecommendedCourse] = oRow[concc_Course.IsRecommendedCourse].ToString().Trim(); //是否推荐课程
objRow[concc_Course.IsSelfPropelledCourse] = oRow[concc_Course.IsSelfPropelledCourse].ToString().Trim(); //是否自荐课程
objRow[concc_Course.OperationDate] = oRow[concc_Course.OperationDate].ToString().Trim(); //操作时间
objRow[concc_Course.OrderNum] = oRow[concc_Course.OrderNum].ToString().Trim(); //序号
objRow[concc_Course.OuterLink] = oRow[concc_Course.OuterLink].ToString().Trim(); //外链地址
objRow[concc_Course.ViewCount] = oRow[concc_Course.ViewCount].ToString().Trim(); //浏览量
objRow[concc_Course.ThemeId] = oRow[concc_Course.ThemeId].ToString().Trim(); //主题Id
objRow[concc_Course.IdSchool] = oRow[concc_Course.IdSchool].ToString().Trim(); //学校流水号
objRow[concc_Course.IdXzMajor] = oRow[concc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objRow[concc_Course.IdXzCollege] = oRow[concc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objRow[concc_Course.IsHasOpQues] = oRow[concc_Course.IsHasOpQues].ToString().Trim(); //是否有操作题
objRow[concc_Course.UpdDate] = oRow[concc_Course.UpdDate].ToString().Trim(); //修改日期
objRow[concc_Course.UpdUserId] = oRow[concc_Course.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_Course.Memo] = oRow[concc_Course.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_CourseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseEN._CurrTabName);
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
 /// <param name = "objcc_CourseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseEN objcc_CourseEN)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from cc_Course where CourseId = " + "'"+ objcc_CourseEN.CourseId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseEN._CurrTabName);
if (objDS.Tables[clscc_CourseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseId = " + "'"+ objcc_CourseEN.CourseId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseEN._CurrTabName].Rows[0];
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseId))
 {
objRow[concc_Course.CourseId] = objcc_CourseEN.CourseId; //课程Id
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseCode))
 {
objRow[concc_Course.CourseCode] = objcc_CourseEN.CourseCode; //课程代码
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseDescription))
 {
objRow[concc_Course.CourseDescription] = objcc_CourseEN.CourseDescription; //课程描述
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseName))
 {
objRow[concc_Course.CourseName] = objcc_CourseEN.CourseName; //课程名称
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseTypeId))
 {
objRow[concc_Course.CourseTypeId] = objcc_CourseEN.CourseTypeId; //课程类型ID
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.CreateDate))
 {
objRow[concc_Course.CreateDate] = objcc_CourseEN.CreateDate; //建立日期
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentTypeId))
 {
objRow[concc_Course.ExcellentTypeId] = objcc_CourseEN.ExcellentTypeId; //精品课程类型Id
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentYear))
 {
objRow[concc_Course.ExcellentYear] = objcc_CourseEN.ExcellentYear; //课程年份
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsBuildingCourse))
 {
objRow[concc_Course.IsBuildingCourse] = objcc_CourseEN.IsBuildingCourse; //是否已建设课程
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsDoubleLanguageCourse))
 {
objRow[concc_Course.IsDoubleLanguageCourse] = objcc_CourseEN.IsDoubleLanguageCourse; //是否双语课程
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsOpen))
 {
objRow[concc_Course.IsOpen] = objcc_CourseEN.IsOpen; //是否公开
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsRecommendedCourse))
 {
objRow[concc_Course.IsRecommendedCourse] = objcc_CourseEN.IsRecommendedCourse; //是否推荐课程
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsSelfPropelledCourse))
 {
objRow[concc_Course.IsSelfPropelledCourse] = objcc_CourseEN.IsSelfPropelledCourse; //是否自荐课程
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.OperationDate))
 {
objRow[concc_Course.OperationDate] = objcc_CourseEN.OperationDate; //操作时间
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.OrderNum))
 {
objRow[concc_Course.OrderNum] = objcc_CourseEN.OrderNum; //序号
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.OuterLink))
 {
objRow[concc_Course.OuterLink] = objcc_CourseEN.OuterLink; //外链地址
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.ViewCount))
 {
objRow[concc_Course.ViewCount] = objcc_CourseEN.ViewCount; //浏览量
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.ThemeId))
 {
objRow[concc_Course.ThemeId] = objcc_CourseEN.ThemeId; //主题Id
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IdSchool))
 {
objRow[concc_Course.IdSchool] = objcc_CourseEN.IdSchool; //学校流水号
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzMajor))
 {
objRow[concc_Course.IdXzMajor] = objcc_CourseEN.IdXzMajor; //专业流水号
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzCollege))
 {
objRow[concc_Course.IdXzCollege] = objcc_CourseEN.IdXzCollege; //学院流水号
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.IsHasOpQues))
 {
objRow[concc_Course.IsHasOpQues] = objcc_CourseEN.IsHasOpQues; //是否有操作题
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdDate))
 {
objRow[concc_Course.UpdDate] = objcc_CourseEN.UpdDate; //修改日期
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdUserId))
 {
objRow[concc_Course.UpdUserId] = objcc_CourseEN.UpdUserId; //修改用户Id
 }
 if (objcc_CourseEN.IsUpdated(concc_Course.Memo))
 {
objRow[concc_Course.Memo] = objcc_CourseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_CourseEN._CurrTabName);
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseEN objcc_CourseEN)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_Course Set ");
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseCode))
 {
 if (objcc_CourseEN.CourseCode !=  null)
 {
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseCode, concc_Course.CourseCode); //课程代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseCode); //课程代码
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseDescription))
 {
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseDescription, concc_Course.CourseDescription); //课程描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseDescription); //课程描述
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseName))
 {
 if (objcc_CourseEN.CourseName !=  null)
 {
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseName, concc_Course.CourseName); //课程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseName); //课程名称
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseTypeId))
 {
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseTypeId, concc_Course.CourseTypeId); //课程类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseTypeId); //课程类型ID
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CreateDate))
 {
 if (objcc_CourseEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_Course.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CreateDate); //建立日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentTypeId))
 {
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentTypeId, concc_Course.ExcellentTypeId); //精品课程类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentTypeId); //精品课程类型Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentYear))
 {
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ExcellentYear, concc_Course.ExcellentYear); //课程年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentYear); //课程年份
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsBuildingCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsBuildingCourse == true?"1":"0", concc_Course.IsBuildingCourse); //是否已建设课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsDoubleLanguageCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsDoubleLanguageCourse == true?"1":"0", concc_Course.IsDoubleLanguageCourse); //是否双语课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsOpen == true?"1":"0", concc_Course.IsOpen); //是否公开
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsRecommendedCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsRecommendedCourse == true?"1":"0", concc_Course.IsRecommendedCourse); //是否推荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsSelfPropelledCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsSelfPropelledCourse == true?"1":"0", concc_Course.IsSelfPropelledCourse); //是否自荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OperationDate))
 {
 if (objcc_CourseEN.OperationDate !=  null)
 {
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationDate, concc_Course.OperationDate); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OperationDate); //操作时间
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OrderNum))
 {
 if (objcc_CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.OrderNum, concc_Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OrderNum); //序号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OuterLink))
 {
 if (objcc_CourseEN.OuterLink !=  null)
 {
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOuterLink, concc_Course.OuterLink); //外链地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OuterLink); //外链地址
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ViewCount))
 {
 if (objcc_CourseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ViewCount, concc_Course.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ThemeId))
 {
 if (objcc_CourseEN.ThemeId !=  null)
 {
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeId, concc_Course.ThemeId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ThemeId); //主题Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdSchool))
 {
 if (objcc_CourseEN.IdSchool !=  null)
 {
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, concc_Course.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdSchool); //学校流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzMajor))
 {
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, concc_Course.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdXzMajor); //专业流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzCollege))
 {
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, concc_Course.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdXzCollege); //学院流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsHasOpQues))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsHasOpQues == true?"1":"0", concc_Course.IsHasOpQues); //是否有操作题
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdDate))
 {
 if (objcc_CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Course.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdUserId))
 {
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Course.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.Memo))
 {
 if (objcc_CourseEN.Memo !=  null)
 {
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Course.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseId = '{0}'", objcc_CourseEN.CourseId); 
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
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseEN objcc_CourseEN, string strCondition)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Course Set ");
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseCode))
 {
 if (objcc_CourseEN.CourseCode !=  null)
 {
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseCode = '{0}',", strCourseCode); //课程代码
 }
 else
 {
 sbSQL.Append(" CourseCode = null,"); //课程代码
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseDescription))
 {
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseDescription = '{0}',", strCourseDescription); //课程描述
 }
 else
 {
 sbSQL.Append(" CourseDescription = null,"); //课程描述
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseName))
 {
 if (objcc_CourseEN.CourseName !=  null)
 {
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseName = '{0}',", strCourseName); //课程名称
 }
 else
 {
 sbSQL.Append(" CourseName = null,"); //课程名称
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseTypeId))
 {
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseTypeId = '{0}',", strCourseTypeId); //课程类型ID
 }
 else
 {
 sbSQL.Append(" CourseTypeId = null,"); //课程类型ID
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CreateDate))
 {
 if (objcc_CourseEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentTypeId))
 {
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentTypeId = '{0}',", strExcellentTypeId); //精品课程类型Id
 }
 else
 {
 sbSQL.Append(" ExcellentTypeId = null,"); //精品课程类型Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentYear))
 {
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ExcellentYear, concc_Course.ExcellentYear); //课程年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentYear); //课程年份
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsBuildingCourse))
 {
 sbSQL.AppendFormat(" IsBuildingCourse = '{0}',", objcc_CourseEN.IsBuildingCourse == true?"1":"0"); //是否已建设课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsDoubleLanguageCourse))
 {
 sbSQL.AppendFormat(" IsDoubleLanguageCourse = '{0}',", objcc_CourseEN.IsDoubleLanguageCourse == true?"1":"0"); //是否双语课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objcc_CourseEN.IsOpen == true?"1":"0"); //是否公开
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsRecommendedCourse))
 {
 sbSQL.AppendFormat(" IsRecommendedCourse = '{0}',", objcc_CourseEN.IsRecommendedCourse == true?"1":"0"); //是否推荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsSelfPropelledCourse))
 {
 sbSQL.AppendFormat(" IsSelfPropelledCourse = '{0}',", objcc_CourseEN.IsSelfPropelledCourse == true?"1":"0"); //是否自荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OperationDate))
 {
 if (objcc_CourseEN.OperationDate !=  null)
 {
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationDate = '{0}',", strOperationDate); //操作时间
 }
 else
 {
 sbSQL.Append(" OperationDate = null,"); //操作时间
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OrderNum))
 {
 if (objcc_CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.OrderNum, concc_Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OrderNum); //序号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OuterLink))
 {
 if (objcc_CourseEN.OuterLink !=  null)
 {
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OuterLink = '{0}',", strOuterLink); //外链地址
 }
 else
 {
 sbSQL.Append(" OuterLink = null,"); //外链地址
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ViewCount))
 {
 if (objcc_CourseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ViewCount, concc_Course.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ThemeId))
 {
 if (objcc_CourseEN.ThemeId !=  null)
 {
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeId = '{0}',", strThemeId); //主题Id
 }
 else
 {
 sbSQL.Append(" ThemeId = null,"); //主题Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdSchool))
 {
 if (objcc_CourseEN.IdSchool !=  null)
 {
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzMajor))
 {
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzCollege))
 {
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsHasOpQues))
 {
 sbSQL.AppendFormat(" IsHasOpQues = '{0}',", objcc_CourseEN.IsHasOpQues == true?"1":"0"); //是否有操作题
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdDate))
 {
 if (objcc_CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdUserId))
 {
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.Memo))
 {
 if (objcc_CourseEN.Memo !=  null)
 {
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseEN objcc_CourseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Course Set ");
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseCode))
 {
 if (objcc_CourseEN.CourseCode !=  null)
 {
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseCode = '{0}',", strCourseCode); //课程代码
 }
 else
 {
 sbSQL.Append(" CourseCode = null,"); //课程代码
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseDescription))
 {
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseDescription = '{0}',", strCourseDescription); //课程描述
 }
 else
 {
 sbSQL.Append(" CourseDescription = null,"); //课程描述
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseName))
 {
 if (objcc_CourseEN.CourseName !=  null)
 {
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseName = '{0}',", strCourseName); //课程名称
 }
 else
 {
 sbSQL.Append(" CourseName = null,"); //课程名称
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseTypeId))
 {
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseTypeId = '{0}',", strCourseTypeId); //课程类型ID
 }
 else
 {
 sbSQL.Append(" CourseTypeId = null,"); //课程类型ID
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CreateDate))
 {
 if (objcc_CourseEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentTypeId))
 {
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExcellentTypeId = '{0}',", strExcellentTypeId); //精品课程类型Id
 }
 else
 {
 sbSQL.Append(" ExcellentTypeId = null,"); //精品课程类型Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentYear))
 {
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ExcellentYear, concc_Course.ExcellentYear); //课程年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentYear); //课程年份
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsBuildingCourse))
 {
 sbSQL.AppendFormat(" IsBuildingCourse = '{0}',", objcc_CourseEN.IsBuildingCourse == true?"1":"0"); //是否已建设课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsDoubleLanguageCourse))
 {
 sbSQL.AppendFormat(" IsDoubleLanguageCourse = '{0}',", objcc_CourseEN.IsDoubleLanguageCourse == true?"1":"0"); //是否双语课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsOpen))
 {
 sbSQL.AppendFormat(" IsOpen = '{0}',", objcc_CourseEN.IsOpen == true?"1":"0"); //是否公开
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsRecommendedCourse))
 {
 sbSQL.AppendFormat(" IsRecommendedCourse = '{0}',", objcc_CourseEN.IsRecommendedCourse == true?"1":"0"); //是否推荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsSelfPropelledCourse))
 {
 sbSQL.AppendFormat(" IsSelfPropelledCourse = '{0}',", objcc_CourseEN.IsSelfPropelledCourse == true?"1":"0"); //是否自荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OperationDate))
 {
 if (objcc_CourseEN.OperationDate !=  null)
 {
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperationDate = '{0}',", strOperationDate); //操作时间
 }
 else
 {
 sbSQL.Append(" OperationDate = null,"); //操作时间
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OrderNum))
 {
 if (objcc_CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.OrderNum, concc_Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OrderNum); //序号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OuterLink))
 {
 if (objcc_CourseEN.OuterLink !=  null)
 {
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OuterLink = '{0}',", strOuterLink); //外链地址
 }
 else
 {
 sbSQL.Append(" OuterLink = null,"); //外链地址
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ViewCount))
 {
 if (objcc_CourseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ViewCount, concc_Course.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ThemeId))
 {
 if (objcc_CourseEN.ThemeId !=  null)
 {
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ThemeId = '{0}',", strThemeId); //主题Id
 }
 else
 {
 sbSQL.Append(" ThemeId = null,"); //主题Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdSchool))
 {
 if (objcc_CourseEN.IdSchool !=  null)
 {
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdSchool = '{0}',", strIdSchool); //学校流水号
 }
 else
 {
 sbSQL.Append(" IdSchool = null,"); //学校流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzMajor))
 {
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzMajor = '{0}',", strIdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdXzMajor = null,"); //专业流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzCollege))
 {
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsHasOpQues))
 {
 sbSQL.AppendFormat(" IsHasOpQues = '{0}',", objcc_CourseEN.IsHasOpQues == true?"1":"0"); //是否有操作题
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdDate))
 {
 if (objcc_CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdUserId))
 {
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.Memo))
 {
 if (objcc_CourseEN.Memo !=  null)
 {
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseEN objcc_CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_Course Set ");
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseCode))
 {
 if (objcc_CourseEN.CourseCode !=  null)
 {
 var strCourseCode = objcc_CourseEN.CourseCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseCode, concc_Course.CourseCode); //课程代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseCode); //课程代码
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseDescription))
 {
 if (objcc_CourseEN.CourseDescription !=  null)
 {
 var strCourseDescription = objcc_CourseEN.CourseDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseDescription, concc_Course.CourseDescription); //课程描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseDescription); //课程描述
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseName))
 {
 if (objcc_CourseEN.CourseName !=  null)
 {
 var strCourseName = objcc_CourseEN.CourseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseName, concc_Course.CourseName); //课程名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseName); //课程名称
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CourseTypeId))
 {
 if (objcc_CourseEN.CourseTypeId  ==  "")
 {
 objcc_CourseEN.CourseTypeId = null;
 }
 if (objcc_CourseEN.CourseTypeId !=  null)
 {
 var strCourseTypeId = objcc_CourseEN.CourseTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseTypeId, concc_Course.CourseTypeId); //课程类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CourseTypeId); //课程类型ID
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.CreateDate))
 {
 if (objcc_CourseEN.CreateDate !=  null)
 {
 var strCreateDate = objcc_CourseEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, concc_Course.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.CreateDate); //建立日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentTypeId))
 {
 if (objcc_CourseEN.ExcellentTypeId  ==  "")
 {
 objcc_CourseEN.ExcellentTypeId = null;
 }
 if (objcc_CourseEN.ExcellentTypeId !=  null)
 {
 var strExcellentTypeId = objcc_CourseEN.ExcellentTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExcellentTypeId, concc_Course.ExcellentTypeId); //精品课程类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentTypeId); //精品课程类型Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ExcellentYear))
 {
 if (objcc_CourseEN.ExcellentYear !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ExcellentYear, concc_Course.ExcellentYear); //课程年份
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ExcellentYear); //课程年份
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsBuildingCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsBuildingCourse == true?"1":"0", concc_Course.IsBuildingCourse); //是否已建设课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsDoubleLanguageCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsDoubleLanguageCourse == true?"1":"0", concc_Course.IsDoubleLanguageCourse); //是否双语课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsOpen))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsOpen == true?"1":"0", concc_Course.IsOpen); //是否公开
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsRecommendedCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsRecommendedCourse == true?"1":"0", concc_Course.IsRecommendedCourse); //是否推荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsSelfPropelledCourse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsSelfPropelledCourse == true?"1":"0", concc_Course.IsSelfPropelledCourse); //是否自荐课程
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OperationDate))
 {
 if (objcc_CourseEN.OperationDate !=  null)
 {
 var strOperationDate = objcc_CourseEN.OperationDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperationDate, concc_Course.OperationDate); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OperationDate); //操作时间
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OrderNum))
 {
 if (objcc_CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.OrderNum, concc_Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OrderNum); //序号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.OuterLink))
 {
 if (objcc_CourseEN.OuterLink !=  null)
 {
 var strOuterLink = objcc_CourseEN.OuterLink.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOuterLink, concc_Course.OuterLink); //外链地址
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.OuterLink); //外链地址
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ViewCount))
 {
 if (objcc_CourseEN.ViewCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseEN.ViewCount, concc_Course.ViewCount); //浏览量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ViewCount); //浏览量
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.ThemeId))
 {
 if (objcc_CourseEN.ThemeId !=  null)
 {
 var strThemeId = objcc_CourseEN.ThemeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strThemeId, concc_Course.ThemeId); //主题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.ThemeId); //主题Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdSchool))
 {
 if (objcc_CourseEN.IdSchool !=  null)
 {
 var strIdSchool = objcc_CourseEN.IdSchool.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdSchool, concc_Course.IdSchool); //学校流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdSchool); //学校流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzMajor))
 {
 if (objcc_CourseEN.IdXzMajor !=  null)
 {
 var strIdXzMajor = objcc_CourseEN.IdXzMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzMajor, concc_Course.IdXzMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdXzMajor); //专业流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IdXzCollege))
 {
 if (objcc_CourseEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objcc_CourseEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, concc_Course.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.IdXzCollege); //学院流水号
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.IsHasOpQues))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseEN.IsHasOpQues == true?"1":"0", concc_Course.IsHasOpQues); //是否有操作题
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdDate))
 {
 if (objcc_CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_Course.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.UpdUserId))
 {
 if (objcc_CourseEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_CourseEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_Course.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_CourseEN.IsUpdated(concc_Course.Memo))
 {
 if (objcc_CourseEN.Memo !=  null)
 {
 var strMemo = objcc_CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_Course.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_Course.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseId = '{0}'", objcc_CourseEN.CourseId); 
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
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseId) 
{
CheckPrimaryKey(strCourseId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseId,
};
 objSQL.ExecSP("cc_Course_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
//删除cc_Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Course where CourseId = " + "'"+ strCourseId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_Course(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
//删除cc_Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Course where CourseId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseId) 
{
CheckPrimaryKey(strCourseId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
//删除cc_Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_Course where CourseId = " + "'"+ strCourseId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_Course(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseDA: Delcc_Course)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Course where " + strCondition ;
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
public bool Delcc_CourseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseDA: Delcc_CourseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_Course where " + strCondition ;
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
 /// <param name = "objcc_CourseENS">源对象</param>
 /// <param name = "objcc_CourseENT">目标对象</param>
public void CopyTo(clscc_CourseEN objcc_CourseENS, clscc_CourseEN objcc_CourseENT)
{
objcc_CourseENT.CourseId = objcc_CourseENS.CourseId; //课程Id
objcc_CourseENT.CourseCode = objcc_CourseENS.CourseCode; //课程代码
objcc_CourseENT.CourseDescription = objcc_CourseENS.CourseDescription; //课程描述
objcc_CourseENT.CourseName = objcc_CourseENS.CourseName; //课程名称
objcc_CourseENT.CourseTypeId = objcc_CourseENS.CourseTypeId; //课程类型ID
objcc_CourseENT.CreateDate = objcc_CourseENS.CreateDate; //建立日期
objcc_CourseENT.ExcellentTypeId = objcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objcc_CourseENT.ExcellentYear = objcc_CourseENS.ExcellentYear; //课程年份
objcc_CourseENT.IsBuildingCourse = objcc_CourseENS.IsBuildingCourse; //是否已建设课程
objcc_CourseENT.IsDoubleLanguageCourse = objcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objcc_CourseENT.IsOpen = objcc_CourseENS.IsOpen; //是否公开
objcc_CourseENT.IsRecommendedCourse = objcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objcc_CourseENT.IsSelfPropelledCourse = objcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objcc_CourseENT.OperationDate = objcc_CourseENS.OperationDate; //操作时间
objcc_CourseENT.OrderNum = objcc_CourseENS.OrderNum; //序号
objcc_CourseENT.OuterLink = objcc_CourseENS.OuterLink; //外链地址
objcc_CourseENT.ViewCount = objcc_CourseENS.ViewCount; //浏览量
objcc_CourseENT.ThemeId = objcc_CourseENS.ThemeId; //主题Id
objcc_CourseENT.IdSchool = objcc_CourseENS.IdSchool; //学校流水号
objcc_CourseENT.IdXzMajor = objcc_CourseENS.IdXzMajor; //专业流水号
objcc_CourseENT.IdXzCollege = objcc_CourseENS.IdXzCollege; //学院流水号
objcc_CourseENT.IsHasOpQues = objcc_CourseENS.IsHasOpQues; //是否有操作题
objcc_CourseENT.UpdDate = objcc_CourseENS.UpdDate; //修改日期
objcc_CourseENT.UpdUserId = objcc_CourseENS.UpdUserId; //修改用户Id
objcc_CourseENT.Memo = objcc_CourseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseEN objcc_CourseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseEN.CourseName, concc_Course.CourseName);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseId, 8, concc_Course.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseCode, 20, concc_Course.CourseCode);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseDescription, 8000, concc_Course.CourseDescription);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseName, 100, concc_Course.CourseName);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CreateDate, 20, concc_Course.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OperationDate, 20, concc_Course.OperationDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OuterLink, 500, concc_Course.OuterLink);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ThemeId, 4, concc_Course.ThemeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdSchool, 4, concc_Course.IdSchool);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzMajor, 8, concc_Course.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzCollege, 4, concc_Course.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdDate, 20, concc_Course.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdUserId, 20, concc_Course.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.Memo, 1000, concc_Course.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
 objcc_CourseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseEN objcc_CourseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseCode, 20, concc_Course.CourseCode);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseDescription, 8000, concc_Course.CourseDescription);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseName, 100, concc_Course.CourseName);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CreateDate, 20, concc_Course.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OperationDate, 20, concc_Course.OperationDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OuterLink, 500, concc_Course.OuterLink);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ThemeId, 4, concc_Course.ThemeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdSchool, 4, concc_Course.IdSchool);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzMajor, 8, concc_Course.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzCollege, 4, concc_Course.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdDate, 20, concc_Course.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdUserId, 20, concc_Course.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.Memo, 1000, concc_Course.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
 objcc_CourseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseEN objcc_CourseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseId, 8, concc_Course.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseCode, 20, concc_Course.CourseCode);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseDescription, 8000, concc_Course.CourseDescription);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseName, 100, concc_Course.CourseName);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.CreateDate, 20, concc_Course.CreateDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OperationDate, 20, concc_Course.OperationDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.OuterLink, 500, concc_Course.OuterLink);
clsCheckSql.CheckFieldLen(objcc_CourseEN.ThemeId, 4, concc_Course.ThemeId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdSchool, 4, concc_Course.IdSchool);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzMajor, 8, concc_Course.IdXzMajor);
clsCheckSql.CheckFieldLen(objcc_CourseEN.IdXzCollege, 4, concc_Course.IdXzCollege);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdDate, 20, concc_Course.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseEN.UpdUserId, 20, concc_Course.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_CourseEN.Memo, 1000, concc_Course.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CourseId, concc_Course.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CourseCode, concc_Course.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CourseDescription, concc_Course.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CourseName, concc_Course.CourseName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CourseTypeId, concc_Course.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.CreateDate, concc_Course.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.ExcellentTypeId, concc_Course.ExcellentTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.OperationDate, concc_Course.OperationDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.OuterLink, concc_Course.OuterLink);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.ThemeId, concc_Course.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.IdSchool, concc_Course.IdSchool);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.IdXzMajor, concc_Course.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.IdXzCollege, concc_Course.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.UpdDate, concc_Course.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.UpdUserId, concc_Course.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseEN.Memo, concc_Course.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.CourseTypeId, 4, concc_Course.CourseTypeId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseEN.ExcellentTypeId, 4, concc_Course.ExcellentTypeId);
 objcc_CourseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCourseId()
{
//获取某学院所有专业信息
string strSQL = "select CourseId, CourseName from cc_Course ";
 clsSpecSQLforSql mySql = clscc_CourseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_Course(课程),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_CourseEN objcc_CourseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseEN.CourseId);
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseEN._CurrTabName);
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}