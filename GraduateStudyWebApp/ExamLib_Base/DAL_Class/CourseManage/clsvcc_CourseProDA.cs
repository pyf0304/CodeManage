
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseProDA
 表名:vcc_CoursePro(01120213)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:25:44
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程管理(CourseManage)
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
 /// v课程Pro(vcc_CoursePro)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseProDA : clsCommBase4DA
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
 return clsvcc_CourseProEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseProEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseProEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseProEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseProEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vcc_CoursePro中,检查关键字,长度不正确!(clsvcc_CourseProDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_CoursePro中,关键字不能为空 或 null!(clsvcc_CourseProDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseProDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CoursePro(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable_vcc_CoursePro)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CoursePro.* from vcc_CoursePro Left Join {1} on {2} where {3} and vcc_CoursePro.CourseId not in (Select top {5} vcc_CoursePro.CourseId from vcc_CoursePro Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1} and CourseId not in (Select top {2} CourseId from vcc_CoursePro where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1} and CourseId not in (Select top {3} CourseId from vcc_CoursePro where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CoursePro.* from vcc_CoursePro Left Join {1} on {2} where {3} and vcc_CoursePro.CourseId not in (Select top {5} vcc_CoursePro.CourseId from vcc_CoursePro Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1} and CourseId not in (Select top {2} CourseId from vcc_CoursePro where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CoursePro where {1} and CourseId not in (Select top {3} CourseId from vcc_CoursePro where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseProEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseProDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = TransNullToInt(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = TransNullToBool(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = TransNullToBool(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = TransNullToInt(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseProDA: GetObjLst)", objException.Message));
}
objvcc_CourseProEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseProEN);
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
public List<clsvcc_CourseProEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseProDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseProEN> arrObjLst = new List<clsvcc_CourseProEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = TransNullToInt(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = TransNullToBool(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = TransNullToBool(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = TransNullToInt(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseProDA: GetObjLst)", objException.Message));
}
objvcc_CourseProEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseProEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseProEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CoursePro(ref clsvcc_CourseProEN objvcc_CourseProEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where CourseId = " + "'"+ objvcc_CourseProEN.CourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseProEN.CourseId = objDT.Rows[0][convcc_CoursePro.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseProEN.LikeCount = TransNullToInt(objDT.Rows[0][convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.CourseCode = objDT.Rows[0][convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.CourseDescription = objDT.Rows[0][convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseProEN.CourseName = objDT.Rows[0][convcc_CoursePro.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseProEN.CourseTypeId = objDT.Rows[0][convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.CourseTypeName = objDT.Rows[0][convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseProEN.CreateDate = objDT.Rows[0][convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.ExcellentTypeId = objDT.Rows[0][convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ExcellentTypeName = objDT.Rows[0][convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseProEN.ExcellentYear = TransNullToInt(objDT.Rows[0][convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.IsBuildingCourse = TransNullToBool(objDT.Rows[0][convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsDoubleLanguageCourse = TransNullToBool(objDT.Rows[0][convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsOpen = TransNullToBool(objDT.Rows[0][convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsRecommendedCourse = TransNullToBool(objDT.Rows[0][convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsSelfPropelledCourse = TransNullToBool(objDT.Rows[0][convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.OperationDate = objDT.Rows[0][convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CoursePro.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.OuterLink = objDT.Rows[0][convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseProEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ThemeId = objDT.Rows[0][convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.ThemeName = objDT.Rows[0][convcc_CoursePro.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseProEN.ExampleImgPath = objDT.Rows[0][convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseProEN.IdXzMajor = objDT.Rows[0][convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseProEN.MajorID = objDT.Rows[0][convcc_CoursePro.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.MajorName = objDT.Rows[0][convcc_CoursePro.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseProEN.IdXzCollege = objDT.Rows[0][convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseProEN.CollegeId = objDT.Rows[0][convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvcc_CourseProEN.CollegeName = objDT.Rows[0][convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseProEN.CollegeNameA = objDT.Rows[0][convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_CourseProEN.Memo = objDT.Rows[0][convcc_CoursePro.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseProEN.QuestionNum = TransNullToInt(objDT.Rows[0][convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.KnowledgesNum = TransNullToInt(objDT.Rows[0][convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.TeacherNum = TransNullToInt(objDT.Rows[0][convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ChapterNum = TransNullToInt(objDT.Rows[0][convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseProDA: Getvcc_CoursePro)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseProEN GetObjByCourseId(string strCourseId)
{
CheckPrimaryKey(strCourseId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where CourseId = " + "'"+ strCourseId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
 objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_CourseProEN.ExcellentYear = Int32.Parse(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.IsBuildingCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsDoubleLanguageCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.IsSelfPropelledCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseProEN.ViewCount = Int32.Parse(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名(字段类型:varchar,字段长度:200,是否可空:False)
 objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseProDA: GetObjByCourseId)", objException.Message));
}
return objvcc_CourseProEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseProEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseProDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CoursePro where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN()
{
CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(), //课程Id
LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.LikeCount].ToString().Trim()), //LikeCount
CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(), //课程名称
CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(), //课程类型名称
CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(), //建立日期
ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(), //精品课程类型Id
ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(), //精品课程类型名称
ExcellentYear = TransNullToInt(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()), //课程年份
IsBuildingCourse = TransNullToBool(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()), //是否已建设课程
IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()), //是否双语课程
IsOpen = TransNullToBool(objRow[convcc_CoursePro.IsOpen].ToString().Trim()), //是否公开
IsRecommendedCourse = TransNullToBool(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()), //是否推荐课程
IsSelfPropelledCourse = TransNullToBool(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()), //是否自荐课程
OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(), //操作时间
OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.OrderNum].ToString().Trim()), //序号
OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(), //外链地址
ViewCount = TransNullToInt(objRow[convcc_CoursePro.ViewCount].ToString().Trim()), //浏览量
ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(), //主题Id
ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(), //主题名
ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(), //示例图路径
IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(), //专业名称
IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(), //学院流水号
CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(), //学院名称简写
Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(), //备注
QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()), //题目数
KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()), //知识点数
TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()), //教师数
ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()) //章节数
};
objvcc_CourseProEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseProEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseProDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseProEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = TransNullToInt(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = TransNullToBool(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = TransNullToBool(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = TransNullToInt(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseProDA: GetObjByDataRowvcc_CoursePro)", objException.Message));
}
objvcc_CourseProEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseProEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseProEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseProEN objvcc_CourseProEN = new clsvcc_CourseProEN();
try
{
objvcc_CourseProEN.CourseId = objRow[convcc_CoursePro.CourseId].ToString().Trim(); //课程Id
objvcc_CourseProEN.LikeCount = objRow[convcc_CoursePro.LikeCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.LikeCount].ToString().Trim()); //LikeCount
objvcc_CourseProEN.CourseCode = objRow[convcc_CoursePro.CourseCode] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseProEN.CourseDescription = objRow[convcc_CoursePro.CourseDescription] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseProEN.CourseName = objRow[convcc_CoursePro.CourseName].ToString().Trim(); //课程名称
objvcc_CourseProEN.CourseTypeId = objRow[convcc_CoursePro.CourseTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeId].ToString().Trim(); //课程类型ID
objvcc_CourseProEN.CourseTypeName = objRow[convcc_CoursePro.CourseTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CourseTypeName].ToString().Trim(); //课程类型名称
objvcc_CourseProEN.CreateDate = objRow[convcc_CoursePro.CreateDate] == DBNull.Value ? null : objRow[convcc_CoursePro.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseProEN.ExcellentTypeId = objRow[convcc_CoursePro.ExcellentTypeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeId].ToString().Trim(); //精品课程类型Id
objvcc_CourseProEN.ExcellentTypeName = objRow[convcc_CoursePro.ExcellentTypeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ExcellentTypeName].ToString().Trim(); //精品课程类型名称
objvcc_CourseProEN.ExcellentYear = TransNullToInt(objRow[convcc_CoursePro.ExcellentYear].ToString().Trim()); //课程年份
objvcc_CourseProEN.IsBuildingCourse = TransNullToBool(objRow[convcc_CoursePro.IsBuildingCourse].ToString().Trim()); //是否已建设课程
objvcc_CourseProEN.IsDoubleLanguageCourse = TransNullToBool(objRow[convcc_CoursePro.IsDoubleLanguageCourse].ToString().Trim()); //是否双语课程
objvcc_CourseProEN.IsOpen = TransNullToBool(objRow[convcc_CoursePro.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseProEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CoursePro.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseProEN.IsSelfPropelledCourse = TransNullToBool(objRow[convcc_CoursePro.IsSelfPropelledCourse].ToString().Trim()); //是否自荐课程
objvcc_CourseProEN.OperationDate = objRow[convcc_CoursePro.OperationDate] == DBNull.Value ? null : objRow[convcc_CoursePro.OperationDate].ToString().Trim(); //操作时间
objvcc_CourseProEN.OrderNum = objRow[convcc_CoursePro.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.OrderNum].ToString().Trim()); //序号
objvcc_CourseProEN.OuterLink = objRow[convcc_CoursePro.OuterLink] == DBNull.Value ? null : objRow[convcc_CoursePro.OuterLink].ToString().Trim(); //外链地址
objvcc_CourseProEN.ViewCount = TransNullToInt(objRow[convcc_CoursePro.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseProEN.ThemeId = objRow[convcc_CoursePro.ThemeId] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeId].ToString().Trim(); //主题Id
objvcc_CourseProEN.ThemeName = objRow[convcc_CoursePro.ThemeName] == DBNull.Value ? null : objRow[convcc_CoursePro.ThemeName].ToString().Trim(); //主题名
objvcc_CourseProEN.ExampleImgPath = objRow[convcc_CoursePro.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CoursePro.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseProEN.IdXzMajor = objRow[convcc_CoursePro.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseProEN.MajorID = objRow[convcc_CoursePro.MajorID] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorID].ToString().Trim(); //专业ID
objvcc_CourseProEN.MajorName = objRow[convcc_CoursePro.MajorName] == DBNull.Value ? null : objRow[convcc_CoursePro.MajorName].ToString().Trim(); //专业名称
objvcc_CourseProEN.IdXzCollege = objRow[convcc_CoursePro.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseProEN.CollegeId = objRow[convcc_CoursePro.CollegeId] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeId].ToString().Trim(); //学院ID
objvcc_CourseProEN.CollegeName = objRow[convcc_CoursePro.CollegeName] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeName].ToString().Trim(); //学院名称
objvcc_CourseProEN.CollegeNameA = objRow[convcc_CoursePro.CollegeNameA] == DBNull.Value ? null : objRow[convcc_CoursePro.CollegeNameA].ToString().Trim(); //学院名称简写
objvcc_CourseProEN.Memo = objRow[convcc_CoursePro.Memo] == DBNull.Value ? null : objRow[convcc_CoursePro.Memo].ToString().Trim(); //备注
objvcc_CourseProEN.QuestionNum = objRow[convcc_CoursePro.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseProEN.KnowledgesNum = objRow[convcc_CoursePro.KnowledgesNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.KnowledgesNum].ToString().Trim()); //知识点数
objvcc_CourseProEN.TeacherNum = objRow[convcc_CoursePro.TeacherNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.TeacherNum].ToString().Trim()); //教师数
objvcc_CourseProEN.ChapterNum = objRow[convcc_CoursePro.ChapterNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CoursePro.ChapterNum].ToString().Trim()); //章节数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseProDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseProEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseProEN;
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
objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseProEN._CurrTabName, convcc_CoursePro.CourseId, 8, "");
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
objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseProEN._CurrTabName, convcc_CoursePro.CourseId, 8, strPrefix);
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseId from vcc_CoursePro where " + strCondition;
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseId from vcc_CoursePro where " + strCondition;
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CoursePro", "CourseId = " + "'"+ strCourseId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseProDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CoursePro", strCondition))
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
objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CoursePro");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseProENS">源对象</param>
 /// <param name = "objvcc_CourseProENT">目标对象</param>
public void CopyTo(clsvcc_CourseProEN objvcc_CourseProENS, clsvcc_CourseProEN objvcc_CourseProENT)
{
objvcc_CourseProENT.CourseId = objvcc_CourseProENS.CourseId; //课程Id
objvcc_CourseProENT.LikeCount = objvcc_CourseProENS.LikeCount; //LikeCount
objvcc_CourseProENT.CourseCode = objvcc_CourseProENS.CourseCode; //课程代码
objvcc_CourseProENT.CourseDescription = objvcc_CourseProENS.CourseDescription; //课程描述
objvcc_CourseProENT.CourseName = objvcc_CourseProENS.CourseName; //课程名称
objvcc_CourseProENT.CourseTypeId = objvcc_CourseProENS.CourseTypeId; //课程类型ID
objvcc_CourseProENT.CourseTypeName = objvcc_CourseProENS.CourseTypeName; //课程类型名称
objvcc_CourseProENT.CreateDate = objvcc_CourseProENS.CreateDate; //建立日期
objvcc_CourseProENT.ExcellentTypeId = objvcc_CourseProENS.ExcellentTypeId; //精品课程类型Id
objvcc_CourseProENT.ExcellentTypeName = objvcc_CourseProENS.ExcellentTypeName; //精品课程类型名称
objvcc_CourseProENT.ExcellentYear = objvcc_CourseProENS.ExcellentYear; //课程年份
objvcc_CourseProENT.IsBuildingCourse = objvcc_CourseProENS.IsBuildingCourse; //是否已建设课程
objvcc_CourseProENT.IsDoubleLanguageCourse = objvcc_CourseProENS.IsDoubleLanguageCourse; //是否双语课程
objvcc_CourseProENT.IsOpen = objvcc_CourseProENS.IsOpen; //是否公开
objvcc_CourseProENT.IsRecommendedCourse = objvcc_CourseProENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseProENT.IsSelfPropelledCourse = objvcc_CourseProENS.IsSelfPropelledCourse; //是否自荐课程
objvcc_CourseProENT.OperationDate = objvcc_CourseProENS.OperationDate; //操作时间
objvcc_CourseProENT.OrderNum = objvcc_CourseProENS.OrderNum; //序号
objvcc_CourseProENT.OuterLink = objvcc_CourseProENS.OuterLink; //外链地址
objvcc_CourseProENT.ViewCount = objvcc_CourseProENS.ViewCount; //浏览量
objvcc_CourseProENT.ThemeId = objvcc_CourseProENS.ThemeId; //主题Id
objvcc_CourseProENT.ThemeName = objvcc_CourseProENS.ThemeName; //主题名
objvcc_CourseProENT.ExampleImgPath = objvcc_CourseProENS.ExampleImgPath; //示例图路径
objvcc_CourseProENT.IdXzMajor = objvcc_CourseProENS.IdXzMajor; //专业流水号
objvcc_CourseProENT.MajorID = objvcc_CourseProENS.MajorID; //专业ID
objvcc_CourseProENT.MajorName = objvcc_CourseProENS.MajorName; //专业名称
objvcc_CourseProENT.IdXzCollege = objvcc_CourseProENS.IdXzCollege; //学院流水号
objvcc_CourseProENT.CollegeId = objvcc_CourseProENS.CollegeId; //学院ID
objvcc_CourseProENT.CollegeName = objvcc_CourseProENS.CollegeName; //学院名称
objvcc_CourseProENT.CollegeNameA = objvcc_CourseProENS.CollegeNameA; //学院名称简写
objvcc_CourseProENT.Memo = objvcc_CourseProENS.Memo; //备注
objvcc_CourseProENT.QuestionNum = objvcc_CourseProENS.QuestionNum; //题目数
objvcc_CourseProENT.KnowledgesNum = objvcc_CourseProENS.KnowledgesNum; //知识点数
objvcc_CourseProENT.TeacherNum = objvcc_CourseProENS.TeacherNum; //教师数
objvcc_CourseProENT.ChapterNum = objvcc_CourseProENS.ChapterNum; //章节数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseProEN objvcc_CourseProEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseId, 8, convcc_CoursePro.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseCode, 20, convcc_CoursePro.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseDescription, 8000, convcc_CoursePro.CourseDescription);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseName, 100, convcc_CoursePro.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseTypeId, 4, convcc_CoursePro.CourseTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CourseTypeName, 30, convcc_CoursePro.CourseTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CreateDate, 20, convcc_CoursePro.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.ExcellentTypeId, 4, convcc_CoursePro.ExcellentTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.ExcellentTypeName, 30, convcc_CoursePro.ExcellentTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.OperationDate, 20, convcc_CoursePro.OperationDate);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.OuterLink, 500, convcc_CoursePro.OuterLink);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.ThemeId, 4, convcc_CoursePro.ThemeId);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.ThemeName, 200, convcc_CoursePro.ThemeName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.ExampleImgPath, 300, convcc_CoursePro.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.IdXzMajor, 8, convcc_CoursePro.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.MajorID, 4, convcc_CoursePro.MajorID);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.MajorName, 100, convcc_CoursePro.MajorName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.IdXzCollege, 4, convcc_CoursePro.IdXzCollege);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CollegeId, 4, convcc_CoursePro.CollegeId);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CollegeName, 100, convcc_CoursePro.CollegeName);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.CollegeNameA, 12, convcc_CoursePro.CollegeNameA);
clsCheckSql.CheckFieldLen(objvcc_CourseProEN.Memo, 1000, convcc_CoursePro.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseId, convcc_CoursePro.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseCode, convcc_CoursePro.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseDescription, convcc_CoursePro.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseName, convcc_CoursePro.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseTypeId, convcc_CoursePro.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CourseTypeName, convcc_CoursePro.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CreateDate, convcc_CoursePro.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.ExcellentTypeId, convcc_CoursePro.ExcellentTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.ExcellentTypeName, convcc_CoursePro.ExcellentTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.OperationDate, convcc_CoursePro.OperationDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.OuterLink, convcc_CoursePro.OuterLink);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.ThemeId, convcc_CoursePro.ThemeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.ThemeName, convcc_CoursePro.ThemeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.ExampleImgPath, convcc_CoursePro.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.IdXzMajor, convcc_CoursePro.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.MajorID, convcc_CoursePro.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.MajorName, convcc_CoursePro.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.IdXzCollege, convcc_CoursePro.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CollegeId, convcc_CoursePro.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CollegeName, convcc_CoursePro.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.CollegeNameA, convcc_CoursePro.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseProEN.Memo, convcc_CoursePro.Memo);
//检查外键字段长度
 objvcc_CourseProEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseProEN._CurrTabName);
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseProEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseProDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}