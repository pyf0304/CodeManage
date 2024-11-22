
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorCourseRelaDA
 表名:vMajorCourseRela(01120540)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:04
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
 /// v专业课程关系(vMajorCourseRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvMajorCourseRelaDA : clsCommBase4DA
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
 return clsvMajorCourseRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvMajorCourseRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMajorCourseRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvMajorCourseRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvMajorCourseRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vMajorCourseRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable_vMajorCourseRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMajorCourseRela.* from vMajorCourseRela Left Join {1} on {2} where {3} and vMajorCourseRela.mId not in (Select top {5} vMajorCourseRela.mId from vMajorCourseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1} and mId not in (Select top {2} mId from vMajorCourseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1} and mId not in (Select top {3} mId from vMajorCourseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vMajorCourseRela.* from vMajorCourseRela Left Join {1} on {2} where {3} and vMajorCourseRela.mId not in (Select top {5} vMajorCourseRela.mId from vMajorCourseRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1} and mId not in (Select top {2} mId from vMajorCourseRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vMajorCourseRela where {1} and mId not in (Select top {3} mId from vMajorCourseRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvMajorCourseRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA:GetObjLst)", objException.Message));
}
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = TransNullToInt(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = TransNullToBool(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetObjLst)", objException.Message));
}
objvMajorCourseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMajorCourseRelaEN);
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
public List<clsvMajorCourseRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = TransNullToInt(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = TransNullToBool(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetObjLst)", objException.Message));
}
objvMajorCourseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvMajorCourseRela(ref clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where mId = " + ""+ objvMajorCourseRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvMajorCourseRelaEN.mId = TransNullToInt(objDT.Rows[0][convMajorCourseRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvMajorCourseRelaEN.CourseId = objDT.Rows[0][convMajorCourseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorCourseRelaEN.CourseCode = objDT.Rows[0][convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.CourseDescription = objDT.Rows[0][convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMajorCourseRelaEN.CourseName = objDT.Rows[0][convMajorCourseRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMajorCourseRelaEN.CourseTypeID = objDT.Rows[0][convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorCourseRelaEN.IsOpen = TransNullToBool(objDT.Rows[0][convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorCourseRelaEN.IdXzMajor = objDT.Rows[0][convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMajorCourseRelaEN.MajorID = objDT.Rows[0][convMajorCourseRela.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorCourseRelaEN.MajorName = objDT.Rows[0][convMajorCourseRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorCourseRelaEN.UpdDate = objDT.Rows[0][convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.UpdUserId = objDT.Rows[0][convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.Memo = objDT.Rows[0][convMajorCourseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetvMajorCourseRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvMajorCourseRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
 objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetObjBymId)", objException.Message));
}
return objvMajorCourseRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvMajorCourseRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
strSQL = "Select * from vMajorCourseRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN()
{
mId = TransNullToInt(objRow[convMajorCourseRela.mId].ToString().Trim()), //mId
CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(), //课程名称
CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(), //课程类型ID
IsOpen = TransNullToBool(objRow[convMajorCourseRela.IsOpen].ToString().Trim()), //是否公开
IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(), //专业名称
UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim() //备注
};
objvMajorCourseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorCourseRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvMajorCourseRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = TransNullToInt(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = TransNullToBool(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetObjByDataRowvMajorCourseRela)", objException.Message));
}
objvMajorCourseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorCourseRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvMajorCourseRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = TransNullToInt(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = TransNullToBool(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvMajorCourseRelaDA: GetObjByDataRow)", objException.Message));
}
objvMajorCourseRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvMajorCourseRelaEN;
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
objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMajorCourseRelaEN._CurrTabName, convMajorCourseRela.mId, 8, "");
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
objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvMajorCourseRelaEN._CurrTabName, convMajorCourseRela.mId, 8, strPrefix);
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vMajorCourseRela where " + strCondition;
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vMajorCourseRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMajorCourseRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvMajorCourseRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vMajorCourseRela", strCondition))
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
objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vMajorCourseRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvMajorCourseRelaENS">源对象</param>
 /// <param name = "objvMajorCourseRelaENT">目标对象</param>
public void CopyTo(clsvMajorCourseRelaEN objvMajorCourseRelaENS, clsvMajorCourseRelaEN objvMajorCourseRelaENT)
{
objvMajorCourseRelaENT.mId = objvMajorCourseRelaENS.mId; //mId
objvMajorCourseRelaENT.CourseId = objvMajorCourseRelaENS.CourseId; //课程Id
objvMajorCourseRelaENT.CourseCode = objvMajorCourseRelaENS.CourseCode; //课程代码
objvMajorCourseRelaENT.CourseDescription = objvMajorCourseRelaENS.CourseDescription; //课程描述
objvMajorCourseRelaENT.CourseName = objvMajorCourseRelaENS.CourseName; //课程名称
objvMajorCourseRelaENT.CourseTypeID = objvMajorCourseRelaENS.CourseTypeID; //课程类型ID
objvMajorCourseRelaENT.IsOpen = objvMajorCourseRelaENS.IsOpen; //是否公开
objvMajorCourseRelaENT.IdXzMajor = objvMajorCourseRelaENS.IdXzMajor; //专业流水号
objvMajorCourseRelaENT.MajorID = objvMajorCourseRelaENS.MajorID; //专业ID
objvMajorCourseRelaENT.MajorName = objvMajorCourseRelaENS.MajorName; //专业名称
objvMajorCourseRelaENT.UpdDate = objvMajorCourseRelaENS.UpdDate; //修改日期
objvMajorCourseRelaENT.UpdUserId = objvMajorCourseRelaENS.UpdUserId; //修改用户Id
objvMajorCourseRelaENT.Memo = objvMajorCourseRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.CourseId, 8, convMajorCourseRela.CourseId);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.CourseCode, 20, convMajorCourseRela.CourseCode);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.CourseDescription, 8000, convMajorCourseRela.CourseDescription);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.CourseName, 100, convMajorCourseRela.CourseName);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.CourseTypeID, 4, convMajorCourseRela.CourseTypeID);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.IdXzMajor, 8, convMajorCourseRela.IdXzMajor);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.MajorID, 4, convMajorCourseRela.MajorID);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.MajorName, 100, convMajorCourseRela.MajorName);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.UpdDate, 20, convMajorCourseRela.UpdDate);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.UpdUserId, 20, convMajorCourseRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvMajorCourseRelaEN.Memo, 1000, convMajorCourseRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.CourseId, convMajorCourseRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.CourseCode, convMajorCourseRela.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.CourseDescription, convMajorCourseRela.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.CourseName, convMajorCourseRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.CourseTypeID, convMajorCourseRela.CourseTypeID);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.IdXzMajor, convMajorCourseRela.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.MajorID, convMajorCourseRela.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.MajorName, convMajorCourseRela.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.UpdDate, convMajorCourseRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.UpdUserId, convMajorCourseRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvMajorCourseRelaEN.Memo, convMajorCourseRela.Memo);
//检查外键字段长度
 objvMajorCourseRelaEN._IsCheckProperty = true;
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMajorCourseRelaEN._CurrTabName);
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvMajorCourseRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvMajorCourseRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}