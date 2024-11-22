
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseDA
 表名:vcc_Course(01120058)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:25
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
 /// v课程(vcc_Course)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseDA : clsCommBase4DA
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
 return clsvcc_CourseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vcc_Course中,检查关键字,长度不正确!(clsvcc_CourseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_Course中,关键字不能为空 或 null!(clsvcc_CourseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_Course(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable_vcc_Course)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Course.* from vcc_Course Left Join {1} on {2} where {3} and vcc_Course.CourseId not in (Select top {5} vcc_Course.CourseId from vcc_Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1} and CourseId not in (Select top {2} CourseId from vcc_Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1} and CourseId not in (Select top {3} CourseId from vcc_Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_Course.* from vcc_Course Left Join {1} on {2} where {3} and vcc_Course.CourseId not in (Select top {5} vcc_Course.CourseId from vcc_Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1} and CourseId not in (Select top {2} CourseId from vcc_Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_Course where {1} and CourseId not in (Select top {3} CourseId from vcc_Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = TransNullToBool(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseDA: GetObjLst)", objException.Message));
}
objvcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseEN);
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
public List<clsvcc_CourseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseEN> arrObjLst = new List<clsvcc_CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = TransNullToBool(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseDA: GetObjLst)", objException.Message));
}
objvcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_Course(ref clsvcc_CourseEN objvcc_CourseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where CourseId = " + "'"+ objvcc_CourseEN.CourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseEN.CourseId = objDT.Rows[0][convcc_Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseEN.LikeCount = TransNullToInt(objDT.Rows[0][convcc_Course.LikeCount].ToString().Trim()); //LikeCount(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.CourseCode = objDT.Rows[0][convcc_Course.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.CourseDescription = objDT.Rows[0][convcc_Course.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseEN.CourseName = objDT.Rows[0][convcc_Course.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseEN.CourseTypeId = objDT.Rows[0][convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.CourseTypeName = objDT.Rows[0][convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseEN.CreateDate = objDT.Rows[0][convcc_Course.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.ExcellentTypeId = objDT.Rows[0][convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseEN.ExcellentTypeName = objDT.Rows[0][convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseEN.ExcellentYear = TransNullToInt(objDT.Rows[0][convcc_Course.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.IsBuildingCourse = TransNullToBool(objDT.Rows[0][convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objDT.Rows[0][convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsOpen = TransNullToBool(objDT.Rows[0][convcc_Course.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsRecommendedCourse = TransNullToBool(objDT.Rows[0][convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objDT.Rows[0][convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.OperationDate = objDT.Rows[0][convcc_Course.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.OuterLink = objDT.Rows[0][convcc_Course.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_Course.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.ThemeId = objDT.Rows[0][convcc_Course.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.ThemeName = objDT.Rows[0][convcc_Course.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseEN.ExampleImgPath = objDT.Rows[0][convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseEN.IdXzMajor = objDT.Rows[0][convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseEN.MajorID = objDT.Rows[0][convcc_Course.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.MajorName = objDT.Rows[0][convcc_Course.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseEN.IdXzCollege = objDT.Rows[0][convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseEN.CollegeId = objDT.Rows[0][convcc_Course.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvcc_CourseEN.CollegeName = objDT.Rows[0][convcc_Course.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseEN.CollegeNameA = objDT.Rows[0][convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_CourseEN.Memo = objDT.Rows[0][convcc_Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseDA: Getvcc_Course)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseEN GetObjByCourseId(string strCourseId)
{
CheckPrimaryKey(strCourseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where CourseId = " + "'"+ strCourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
 objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseDA: GetObjByCourseId)", objException.Message));
}
return objvcc_CourseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
strSQL = "Select * from vcc_Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN()
{
CourseId = objRow[convcc_Course.CourseId].ToString().Trim(), //课程Id
LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.LikeCount].ToString().Trim()), //LikeCount
CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(), //课程名称
CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(), //课程类型名称
CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(), //建立日期
ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(), //精品课程类型Id
ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(), //精品课程类型名称
ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ExcellentYear].ToString().Trim()), //课程年份
IsBuildingCourse = TransNullToBool(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()), //是否已建设课程
IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()), //是否双语课程
IsOpen = TransNullToBool(objRow[convcc_Course.IsOpen].ToString().Trim()), //是否公开
IsRecommendedCourse = TransNullToBool(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()), //是否推荐课程
IsSelfPropelledCourse = TransNullToBool(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()), //是否自荐课程
OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(), //操作时间
OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.OrderNum].ToString().Trim()), //序号
OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(), //外链地址
ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ViewCount].ToString().Trim()), //浏览量
ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(), //主题Id
ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(), //主题名
ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(), //示例图路径
IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convcc_Course.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(), //学院名称简写
Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim() //备注
};
objvcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = TransNullToBool(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseDA: GetObjByDataRowvcc_Course)", objException.Message));
}
objvcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseEN objvcc_CourseEN = new clsvcc_CourseEN();
try
{
objvcc_CourseEN.CourseId = objRow[convcc_Course.CourseId].ToString().Trim(); //课程Id
objvcc_CourseEN.LikeCount = objRow[convcc_Course.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseEN.CourseCode = objRow[convcc_Course.CourseCode] == DBNull.Value ? null : objRow[convcc_Course.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseEN.CourseDescription = objRow[convcc_Course.CourseDescription] == DBNull.Value ? null : objRow[convcc_Course.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseEN.CourseName = objRow[convcc_Course.CourseName] == DBNull.Value ? null : objRow[convcc_Course.CourseName].ToString().Trim(); //课程名称
objvcc_CourseEN.CourseTypeId = objRow[convcc_Course.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseEN.CourseTypeName = objRow[convcc_Course.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseEN.CreateDate = objRow[convcc_Course.CreateDate] == DBNull.Value ? null : objRow[convcc_Course.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseEN.ExcellentTypeId = objRow[convcc_Course.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseEN.ExcellentTypeName = objRow[convcc_Course.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_Course.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseEN.ExcellentYear = objRow[convcc_Course.ExcellentYear] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseEN.IsBuildingCourse = TransNullToBool(objRow[convcc_Course.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_Course.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseEN.IsOpen = TransNullToBool(objRow[convcc_Course.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_Course.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_Course.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseEN.OperationDate = objRow[convcc_Course.OperationDate] == DBNull.Value ? null : objRow[convcc_Course.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseEN.OrderNum = objRow[convcc_Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.OrderNum].ToString().Trim()); //序号
objvcc_CourseEN.OuterLink = objRow[convcc_Course.OuterLink] == DBNull.Value ? null : objRow[convcc_Course.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseEN.ViewCount = objRow[convcc_Course.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_Course.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseEN.ThemeId = objRow[convcc_Course.ThemeId] == DBNull.Value ? null : objRow[convcc_Course.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseEN.ThemeName = objRow[convcc_Course.ThemeName] == DBNull.Value ? null : objRow[convcc_Course.ThemeName].ToString().Trim(); //主题名
objvcc_CourseEN.ExampleImgPath = objRow[convcc_Course.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_Course.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseEN.IdXzMajor = objRow[convcc_Course.IdXzMajor] == DBNull.Value ? null : objRow[convcc_Course.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseEN.MajorID = objRow[convcc_Course.MajorID] == DBNull.Value ? null : objRow[convcc_Course.MajorID].ToString().Trim(); //专业ID
objvcc_CourseEN.MajorName = objRow[convcc_Course.MajorName].ToString().Trim(); //专业名称
objvcc_CourseEN.IdXzCollege = objRow[convcc_Course.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseEN.CollegeId = objRow[convcc_Course.CollegeId] == DBNull.Value ? null : objRow[convcc_Course.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseEN.CollegeName = objRow[convcc_Course.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseEN.CollegeNameA = objRow[convcc_Course.CollegeNameA] == DBNull.Value ? null : objRow[convcc_Course.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseEN.Memo = objRow[convcc_Course.Memo] == DBNull.Value ? null : objRow[convcc_Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseEN;
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
objSQL = clsvcc_CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseEN._CurrTabName, convcc_Course.CourseId, 8, "");
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
objSQL = clsvcc_CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseEN._CurrTabName, convcc_Course.CourseId, 8, strPrefix);
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseId from vcc_Course where " + strCondition;
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseId from vcc_Course where " + strCondition;
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Course", "CourseId = " + "'"+ strCourseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_Course", strCondition))
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
objSQL = clsvcc_CourseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_Course");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseENS">源对象</param>
 /// <param name = "objvcc_CourseENT">目标对象</param>
public void CopyTo(clsvcc_CourseEN objvcc_CourseENS, clsvcc_CourseEN objvcc_CourseENT)
{
objvcc_CourseENT.CourseId = objvcc_CourseENS.CourseId; //课程Id
objvcc_CourseENT.LikeCount = objvcc_CourseENS.LikeCount; //LikeCount
objvcc_CourseENT.CourseCode = objvcc_CourseENS.CourseCode; //课程代码
objvcc_CourseENT.CourseDescription = objvcc_CourseENS.CourseDescription; //课程描述
objvcc_CourseENT.CourseName = objvcc_CourseENS.CourseName; //课程名称
objvcc_CourseENT.CourseTypeId = objvcc_CourseENS.CourseTypeId; //课程类型ID
objvcc_CourseENT.CourseTypeName = objvcc_CourseENS.CourseTypeName; //课程类型名称
objvcc_CourseENT.CreateDate = objvcc_CourseENS.CreateDate; //建立日期
objvcc_CourseENT.ExcellentTypeId = objvcc_CourseENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseENT.ExcellentTypeName = objvcc_CourseENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseENT.ExcellentYear = objvcc_CourseENS.ExcellentYear; //课程年份
objvcc_CourseENT.IsBuildingCourse = objvcc_CourseENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseENT.IsDoubleLanguageCourse = objvcc_CourseENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseENT.IsOpen = objvcc_CourseENS.IsOpen; //是否公开
objvcc_CourseENT.IsRecommendedCourse = objvcc_CourseENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseENT.IsSelfPropelledCourse = objvcc_CourseENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseENT.OperationDate = objvcc_CourseENS.OperationDate; //操作时间
objvcc_CourseENT.OrderNum = objvcc_CourseENS.OrderNum; //序号
objvcc_CourseENT.OuterLink = objvcc_CourseENS.OuterLink; //外链地址
objvcc_CourseENT.ViewCount = objvcc_CourseENS.ViewCount; //浏览量
objvcc_CourseENT.ThemeId = objvcc_CourseENS.ThemeId; //主题Id
objvcc_CourseENT.ThemeName = objvcc_CourseENS.ThemeName; //主题名
objvcc_CourseENT.ExampleImgPath = objvcc_CourseENS.ExampleImgPath; //示例图路径
objvcc_CourseENT.IdXzMajor = objvcc_CourseENS.IdXzMajor; //专业流水号
objvcc_CourseENT.MajorID = objvcc_CourseENS.MajorID; //专业ID
objvcc_CourseENT.MajorName = objvcc_CourseENS.MajorName; //专业名称
objvcc_CourseENT.IdXzCollege = objvcc_CourseENS.IdXzCollege; //学院流水号
objvcc_CourseENT.CollegeId = objvcc_CourseENS.CollegeId; //学院ID
objvcc_CourseENT.CollegeName = objvcc_CourseENS.CollegeName; //学院名称
objvcc_CourseENT.CollegeNameA = objvcc_CourseENS.CollegeNameA; //学院名称简写
objvcc_CourseENT.Memo = objvcc_CourseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseEN objvcc_CourseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseId, 8, convcc_Course.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseCode, 20, convcc_Course.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseDescription, 8000, convcc_Course.CourseDescription);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseName, 100, convcc_Course.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseTypeId, 4, convcc_Course.CourseTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CourseTypeName, 30, convcc_Course.CourseTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CreateDate, 20, convcc_Course.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.ExcellentTypeId, 4, convcc_Course.ExcellentTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.ExcellentTypeName, 30, convcc_Course.ExcellentTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.OperationDate, 20, convcc_Course.OperationDate);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.OuterLink, 500, convcc_Course.OuterLink);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.ThemeId, 4, convcc_Course.ThemeId);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.ThemeName, 200, convcc_Course.ThemeName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.ExampleImgPath, 300, convcc_Course.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.IdXzMajor, 8, convcc_Course.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.MajorID, 4, convcc_Course.MajorID);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.MajorName, 100, convcc_Course.MajorName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.IdXzCollege, 4, convcc_Course.IdXzCollege);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CollegeId, 4, convcc_Course.CollegeId);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CollegeName, 100, convcc_Course.CollegeName);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.CollegeNameA, 12, convcc_Course.CollegeNameA);
clsCheckSql.CheckFieldLen(objvcc_CourseEN.Memo, 1000, convcc_Course.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseId, convcc_Course.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseCode, convcc_Course.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseDescription, convcc_Course.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseName, convcc_Course.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseTypeId, convcc_Course.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CourseTypeName, convcc_Course.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CreateDate, convcc_Course.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.ExcellentTypeId, convcc_Course.ExcellentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.ExcellentTypeName, convcc_Course.ExcellentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.OperationDate, convcc_Course.OperationDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.OuterLink, convcc_Course.OuterLink);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.ThemeId, convcc_Course.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.ThemeName, convcc_Course.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.ExampleImgPath, convcc_Course.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.IdXzMajor, convcc_Course.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.MajorID, convcc_Course.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.MajorName, convcc_Course.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.IdXzCollege, convcc_Course.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CollegeId, convcc_Course.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CollegeName, convcc_Course.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.CollegeNameA, convcc_Course.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseEN.Memo, convcc_Course.Memo);
//检查外键字段长度
 objvcc_CourseEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseEN._CurrTabName);
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}