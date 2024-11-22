
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseTeacherRelation4AppDA
 表名:vcc_CourseTeacherRelation4App(01120260)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:56
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// v课程和教师关系4App(vcc_CourseTeacherRelation4App)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseTeacherRelation4AppDA : clsCommBase4DA
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
 return clsvcc_CourseTeacherRelation4AppEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseTeacherRelation4AppEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseTeacherRelation4AppEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseTeacherRelation4AppEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseTeacherRelation4AppEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseTeacherRelation4App(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable_vcc_CourseTeacherRelation4App)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseTeacherRelation4App.* from vcc_CourseTeacherRelation4App Left Join {1} on {2} where {3} and vcc_CourseTeacherRelation4App.CourseTeacherRelationId not in (Select top {5} vcc_CourseTeacherRelation4App.CourseTeacherRelationId from vcc_CourseTeacherRelation4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1} and CourseTeacherRelationId not in (Select top {2} CourseTeacherRelationId from vcc_CourseTeacherRelation4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1} and CourseTeacherRelationId not in (Select top {3} CourseTeacherRelationId from vcc_CourseTeacherRelation4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseTeacherRelation4App.* from vcc_CourseTeacherRelation4App Left Join {1} on {2} where {3} and vcc_CourseTeacherRelation4App.CourseTeacherRelationId not in (Select top {5} vcc_CourseTeacherRelation4App.CourseTeacherRelationId from vcc_CourseTeacherRelation4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1} and CourseTeacherRelationId not in (Select top {2} CourseTeacherRelationId from vcc_CourseTeacherRelation4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseTeacherRelation4App where {1} and CourseTeacherRelationId not in (Select top {3} CourseTeacherRelationId from vcc_CourseTeacherRelation4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseTeacherRelation4AppEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = TransNullToInt(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetObjLst)", objException.Message));
}
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
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
public List<clsvcc_CourseTeacherRelation4AppEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseTeacherRelation4AppEN> arrObjLst = new List<clsvcc_CourseTeacherRelation4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = TransNullToInt(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetObjLst)", objException.Message));
}
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseTeacherRelation4AppEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseTeacherRelation4App(ref clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where CourseTeacherRelationId = " + ""+ objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = TransNullToInt(objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.CourseId = objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseCode = objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseDescription = objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseName = objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objDT.Rows[0][convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.CreateDate = objDT.Rows[0][convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IsOpen = TransNullToBool(objDT.Rows[0][convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = TransNullToBool(objDT.Rows[0][convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objDT.Rows[0][convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objDT.Rows[0][convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objDT.Rows[0][convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IdTeacher = objDT.Rows[0][convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.TeacherID = objDT.Rows[0][convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.TeacherName = objDT.Rows[0][convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.IsCourseManager = TransNullToBool(objDT.Rows[0][convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objDT.Rows[0][convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.UpdDate = objDT.Rows[0][convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.UpdUser = objDT.Rows[0][convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.Memo = objDT.Rows[0][convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: Getvcc_CourseTeacherRelation4App)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngCourseTeacherRelationId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseTeacherRelation4AppEN GetObjByCourseTeacherRelationId(long lngCourseTeacherRelationId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where CourseTeacherRelationId = " + ""+ lngCourseTeacherRelationId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
 objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = Int32.Parse(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.IsCourseManager = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人(字段类型:bit,字段长度:1,是否可空:False)
 objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetObjByCourseTeacherRelationId)", objException.Message));
}
return objvcc_CourseTeacherRelation4AppEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseTeacherRelation4AppEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseTeacherRelation4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN()
{
CourseTeacherRelationId = TransNullToInt(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()), //课程教师关系表流水号
CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(), //课程名称
CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(), //课程类型ID
CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(), //建立日期
IsOpen = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()), //是否公开
IsRecommendedCourse = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()), //是否推荐课程
OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()), //序号
ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(), //示例图路径
ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()), //浏览量
IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(), //专业流水号
IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(), //学院流水号
IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(), //教师流水号
TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(), //教师工号
TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(), //教师姓名
IsCourseManager = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()), //是否课程主要人
LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(), //最后访问时间
UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim() //备注
};
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseTeacherRelation4AppEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseTeacherRelation4AppEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = TransNullToInt(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetObjByDataRowvcc_CourseTeacherRelation4App)", objException.Message));
}
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseTeacherRelation4AppEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseTeacherRelation4AppEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN = new clsvcc_CourseTeacherRelation4AppEN();
try
{
objvcc_CourseTeacherRelation4AppEN.CourseTeacherRelationId = TransNullToInt(objRow[convcc_CourseTeacherRelation4App.CourseTeacherRelationId].ToString().Trim()); //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppEN.CourseId = objRow[convcc_CourseTeacherRelation4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseTeacherRelation4AppEN.CourseCode = objRow[convcc_CourseTeacherRelation4App.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseTeacherRelation4AppEN.CourseDescription = objRow[convcc_CourseTeacherRelation4App.CourseDescription] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseDescription].ToString().Trim(); //课程描述
objvcc_CourseTeacherRelation4AppEN.CourseName = objRow[convcc_CourseTeacherRelation4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseTeacherRelation4AppEN.CourseTypeID = objRow[convcc_CourseTeacherRelation4App.CourseTypeID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CourseTypeID].ToString().Trim(); //课程类型ID
objvcc_CourseTeacherRelation4AppEN.CreateDate = objRow[convcc_CourseTeacherRelation4App.CreateDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.CreateDate].ToString().Trim(); //建立日期
objvcc_CourseTeacherRelation4AppEN.IsOpen = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsOpen].ToString().Trim()); //是否公开
objvcc_CourseTeacherRelation4AppEN.IsRecommendedCourse = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsRecommendedCourse].ToString().Trim()); //是否推荐课程
objvcc_CourseTeacherRelation4AppEN.OrderNum = objRow[convcc_CourseTeacherRelation4App.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseTeacherRelation4AppEN.ExampleImgPath = objRow[convcc_CourseTeacherRelation4App.ExampleImgPath] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.ExampleImgPath].ToString().Trim(); //示例图路径
objvcc_CourseTeacherRelation4AppEN.ViewCount = objRow[convcc_CourseTeacherRelation4App.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseTeacherRelation4App.ViewCount].ToString().Trim()); //浏览量
objvcc_CourseTeacherRelation4AppEN.IdXzMajor = objRow[convcc_CourseTeacherRelation4App.IdXzMajor] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzMajor].ToString().Trim(); //专业流水号
objvcc_CourseTeacherRelation4AppEN.IdXzCollege = objRow[convcc_CourseTeacherRelation4App.IdXzCollege] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.IdXzCollege].ToString().Trim(); //学院流水号
objvcc_CourseTeacherRelation4AppEN.IdTeacher = objRow[convcc_CourseTeacherRelation4App.IdTeacher].ToString().Trim(); //教师流水号
objvcc_CourseTeacherRelation4AppEN.TeacherID = objRow[convcc_CourseTeacherRelation4App.TeacherID] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherID].ToString().Trim(); //教师工号
objvcc_CourseTeacherRelation4AppEN.TeacherName = objRow[convcc_CourseTeacherRelation4App.TeacherName] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.TeacherName].ToString().Trim(); //教师姓名
objvcc_CourseTeacherRelation4AppEN.IsCourseManager = TransNullToBool(objRow[convcc_CourseTeacherRelation4App.IsCourseManager].ToString().Trim()); //是否课程主要人
objvcc_CourseTeacherRelation4AppEN.LastVisitedDate = objRow[convcc_CourseTeacherRelation4App.LastVisitedDate] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.LastVisitedDate].ToString().Trim(); //最后访问时间
objvcc_CourseTeacherRelation4AppEN.UpdDate = objRow[convcc_CourseTeacherRelation4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseTeacherRelation4AppEN.UpdUser = objRow[convcc_CourseTeacherRelation4App.UpdUser].ToString().Trim(); //修改人
objvcc_CourseTeacherRelation4AppEN.Memo = objRow[convcc_CourseTeacherRelation4App.Memo] == DBNull.Value ? null : objRow[convcc_CourseTeacherRelation4App.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseTeacherRelation4AppDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseTeacherRelation4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseTeacherRelation4AppEN;
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
objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseTeacherRelation4AppEN._CurrTabName, convcc_CourseTeacherRelation4App.CourseTeacherRelationId, 8, "");
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
objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseTeacherRelation4AppEN._CurrTabName, convcc_CourseTeacherRelation4App.CourseTeacherRelationId, 8, strPrefix);
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseTeacherRelationId from vcc_CourseTeacherRelation4App where " + strCondition;
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseTeacherRelationId from vcc_CourseTeacherRelation4App where " + strCondition;
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
 /// <param name = "lngCourseTeacherRelationId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngCourseTeacherRelationId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseTeacherRelation4App", "CourseTeacherRelationId = " + ""+ lngCourseTeacherRelationId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseTeacherRelation4AppDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseTeacherRelation4App", strCondition))
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
objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseTeacherRelation4App");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseTeacherRelation4AppENS">源对象</param>
 /// <param name = "objvcc_CourseTeacherRelation4AppENT">目标对象</param>
public void CopyTo(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENS, clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppENT)
{
objvcc_CourseTeacherRelation4AppENT.CourseTeacherRelationId = objvcc_CourseTeacherRelation4AppENS.CourseTeacherRelationId; //课程教师关系表流水号
objvcc_CourseTeacherRelation4AppENT.CourseId = objvcc_CourseTeacherRelation4AppENS.CourseId; //课程Id
objvcc_CourseTeacherRelation4AppENT.CourseCode = objvcc_CourseTeacherRelation4AppENS.CourseCode; //课程代码
objvcc_CourseTeacherRelation4AppENT.CourseDescription = objvcc_CourseTeacherRelation4AppENS.CourseDescription; //课程描述
objvcc_CourseTeacherRelation4AppENT.CourseName = objvcc_CourseTeacherRelation4AppENS.CourseName; //课程名称
objvcc_CourseTeacherRelation4AppENT.CourseTypeID = objvcc_CourseTeacherRelation4AppENS.CourseTypeID; //课程类型ID
objvcc_CourseTeacherRelation4AppENT.CreateDate = objvcc_CourseTeacherRelation4AppENS.CreateDate; //建立日期
objvcc_CourseTeacherRelation4AppENT.IsOpen = objvcc_CourseTeacherRelation4AppENS.IsOpen; //是否公开
objvcc_CourseTeacherRelation4AppENT.IsRecommendedCourse = objvcc_CourseTeacherRelation4AppENS.IsRecommendedCourse; //是否推荐课程
objvcc_CourseTeacherRelation4AppENT.OrderNum = objvcc_CourseTeacherRelation4AppENS.OrderNum; //序号
objvcc_CourseTeacherRelation4AppENT.ExampleImgPath = objvcc_CourseTeacherRelation4AppENS.ExampleImgPath; //示例图路径
objvcc_CourseTeacherRelation4AppENT.ViewCount = objvcc_CourseTeacherRelation4AppENS.ViewCount; //浏览量
objvcc_CourseTeacherRelation4AppENT.IdXzMajor = objvcc_CourseTeacherRelation4AppENS.IdXzMajor; //专业流水号
objvcc_CourseTeacherRelation4AppENT.IdXzCollege = objvcc_CourseTeacherRelation4AppENS.IdXzCollege; //学院流水号
objvcc_CourseTeacherRelation4AppENT.IdTeacher = objvcc_CourseTeacherRelation4AppENS.IdTeacher; //教师流水号
objvcc_CourseTeacherRelation4AppENT.TeacherID = objvcc_CourseTeacherRelation4AppENS.TeacherID; //教师工号
objvcc_CourseTeacherRelation4AppENT.TeacherName = objvcc_CourseTeacherRelation4AppENS.TeacherName; //教师姓名
objvcc_CourseTeacherRelation4AppENT.IsCourseManager = objvcc_CourseTeacherRelation4AppENS.IsCourseManager; //是否课程主要人
objvcc_CourseTeacherRelation4AppENT.LastVisitedDate = objvcc_CourseTeacherRelation4AppENS.LastVisitedDate; //最后访问时间
objvcc_CourseTeacherRelation4AppENT.UpdDate = objvcc_CourseTeacherRelation4AppENS.UpdDate; //修改日期
objvcc_CourseTeacherRelation4AppENT.UpdUser = objvcc_CourseTeacherRelation4AppENS.UpdUser; //修改人
objvcc_CourseTeacherRelation4AppENT.Memo = objvcc_CourseTeacherRelation4AppENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseTeacherRelation4AppEN objvcc_CourseTeacherRelation4AppEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CourseId, 8, convcc_CourseTeacherRelation4App.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CourseCode, 20, convcc_CourseTeacherRelation4App.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CourseDescription, 8000, convcc_CourseTeacherRelation4App.CourseDescription);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CourseName, 100, convcc_CourseTeacherRelation4App.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CourseTypeID, 4, convcc_CourseTeacherRelation4App.CourseTypeID);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.CreateDate, 20, convcc_CourseTeacherRelation4App.CreateDate);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.ExampleImgPath, 300, convcc_CourseTeacherRelation4App.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.IdXzMajor, 8, convcc_CourseTeacherRelation4App.IdXzMajor);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.IdXzCollege, 4, convcc_CourseTeacherRelation4App.IdXzCollege);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.IdTeacher, 8, convcc_CourseTeacherRelation4App.IdTeacher);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.TeacherID, 12, convcc_CourseTeacherRelation4App.TeacherID);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.TeacherName, 50, convcc_CourseTeacherRelation4App.TeacherName);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.LastVisitedDate, 14, convcc_CourseTeacherRelation4App.LastVisitedDate);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.UpdDate, 20, convcc_CourseTeacherRelation4App.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.UpdUser, 20, convcc_CourseTeacherRelation4App.UpdUser);
clsCheckSql.CheckFieldLen(objvcc_CourseTeacherRelation4AppEN.Memo, 1000, convcc_CourseTeacherRelation4App.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CourseId, convcc_CourseTeacherRelation4App.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CourseCode, convcc_CourseTeacherRelation4App.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CourseDescription, convcc_CourseTeacherRelation4App.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CourseName, convcc_CourseTeacherRelation4App.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CourseTypeID, convcc_CourseTeacherRelation4App.CourseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.CreateDate, convcc_CourseTeacherRelation4App.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.ExampleImgPath, convcc_CourseTeacherRelation4App.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.IdXzMajor, convcc_CourseTeacherRelation4App.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.IdXzCollege, convcc_CourseTeacherRelation4App.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.IdTeacher, convcc_CourseTeacherRelation4App.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.TeacherID, convcc_CourseTeacherRelation4App.TeacherID);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.TeacherName, convcc_CourseTeacherRelation4App.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.LastVisitedDate, convcc_CourseTeacherRelation4App.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.UpdDate, convcc_CourseTeacherRelation4App.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.UpdUser, convcc_CourseTeacherRelation4App.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseTeacherRelation4AppEN.Memo, convcc_CourseTeacherRelation4App.Memo);
//检查外键字段长度
 objvcc_CourseTeacherRelation4AppEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseTeacherRelation4AppEN._CurrTabName);
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseTeacherRelation4AppEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseTeacherRelation4AppDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}