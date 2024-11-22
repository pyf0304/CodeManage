﻿
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSysScoreSummaryDA
 表名:vSysScoreSummary(01120627)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:03:35
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培设置(GradEduTools)
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
 /// v分数汇总视图(vSysScoreSummary)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSysScoreSummaryDA : clsCommBase4DA
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
 return clsvSysScoreSummaryEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSysScoreSummaryEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSysScoreSummaryEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSysScoreSummaryEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSysScoreSummaryEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSysScoreSummary(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable_vSysScoreSummary)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysScoreSummary.* from vSysScoreSummary Left Join {1} on {2} where {3} and vSysScoreSummary.mId not in (Select top {5} vSysScoreSummary.mId from vSysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1} and mId not in (Select top {2} mId from vSysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1} and mId not in (Select top {3} mId from vSysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vSysScoreSummary.* from vSysScoreSummary Left Join {1} on {2} where {3} and vSysScoreSummary.mId not in (Select top {5} vSysScoreSummary.mId from vSysScoreSummary Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1} and mId not in (Select top {2} mId from vSysScoreSummary where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSysScoreSummary where {1} and mId not in (Select top {3} mId from vSysScoreSummary where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSysScoreSummaryEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA:GetObjLst)", objException.Message));
}
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = TransNullToInt(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetObjLst)", objException.Message));
}
objvSysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysScoreSummaryEN);
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
public List<clsvSysScoreSummaryEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSysScoreSummaryEN> arrObjLst = new List<clsvSysScoreSummaryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = TransNullToInt(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetObjLst)", objException.Message));
}
objvSysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSysScoreSummaryEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSysScoreSummaryEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSysScoreSummary(ref clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where mId = " + ""+ objvSysScoreSummaryEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSysScoreSummaryEN.mId = TransNullToInt(objDT.Rows[0][convSysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvSysScoreSummaryEN.UserId = objDT.Rows[0][convSysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvSysScoreSummaryEN.SchoolYear = objDT.Rows[0][convSysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvSysScoreSummaryEN.UpdDate = objDT.Rows[0][convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.Memo = objDT.Rows[0][convSysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysScoreSummaryEN.UserName = objDT.Rows[0][convSysScoreSummary.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvSysScoreSummaryEN.IdXzCollege = objDT.Rows[0][convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSysScoreSummaryEN.CollegeName = objDT.Rows[0][convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IdXzMajor = objDT.Rows[0][convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysScoreSummaryEN.MajorName = objDT.Rows[0][convSysScoreSummary.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IdGradeBase = objDT.Rows[0][convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSysScoreSummaryEN.GradeBaseName = objDT.Rows[0][convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSysScoreSummaryEN.OnlyId = objDT.Rows[0][convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.ScoreTypeId = objDT.Rows[0][convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSysScoreSummaryEN.ScoreTypeName = objDT.Rows[0][convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称(字段类型:varchar,字段长度:10,是否可空:False)
 objvSysScoreSummaryEN.UpdUser = objDT.Rows[0][convSysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.Score = TransNullToFloat(objDT.Rows[0][convSysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysScoreSummaryEN.IdCurrEduCls = objDT.Rows[0][convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysScoreSummaryEN.EduClsName = objDT.Rows[0][convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IsSubmit = TransNullToBool(objDT.Rows[0][convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetvSysScoreSummary)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSysScoreSummaryEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
 objvSysScoreSummaryEN.mId = Int32.Parse(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称(字段类型:varchar,字段长度:10,是否可空:False)
 objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSysScoreSummaryEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetObjBymId)", objException.Message));
}
return objvSysScoreSummaryEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSysScoreSummaryEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
strSQL = "Select * from vSysScoreSummary where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN()
{
mId = TransNullToInt(objRow[convSysScoreSummary.mId].ToString().Trim()), //mId
UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(), //用户ID
SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(), //学年
UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(), //备注
UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(), //用户名
IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(), //学院流水号
CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(), //专业名称
IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(), //年级流水号
GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(), //年级名称
OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(), //OnlyId
ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(), //分数类型Id
ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(), //分数类型名称
UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(), //修改人
Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysScoreSummary.Score].ToString().Trim()), //评分
IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(), //教学班流水号
EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(), //教学班名
IsSubmit = TransNullToBool(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()) //是否提交
};
objvSysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysScoreSummaryEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSysScoreSummaryEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = TransNullToInt(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetObjByDataRowvSysScoreSummary)", objException.Message));
}
objvSysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysScoreSummaryEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSysScoreSummaryEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSysScoreSummaryEN objvSysScoreSummaryEN = new clsvSysScoreSummaryEN();
try
{
objvSysScoreSummaryEN.mId = TransNullToInt(objRow[convSysScoreSummary.mId].ToString().Trim()); //mId
objvSysScoreSummaryEN.UserId = objRow[convSysScoreSummary.UserId].ToString().Trim(); //用户ID
objvSysScoreSummaryEN.SchoolYear = objRow[convSysScoreSummary.SchoolYear] == DBNull.Value ? null : objRow[convSysScoreSummary.SchoolYear].ToString().Trim(); //学年
objvSysScoreSummaryEN.UpdDate = objRow[convSysScoreSummary.UpdDate] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdDate].ToString().Trim(); //修改日期
objvSysScoreSummaryEN.Memo = objRow[convSysScoreSummary.Memo] == DBNull.Value ? null : objRow[convSysScoreSummary.Memo].ToString().Trim(); //备注
objvSysScoreSummaryEN.UserName = objRow[convSysScoreSummary.UserName] == DBNull.Value ? null : objRow[convSysScoreSummary.UserName].ToString().Trim(); //用户名
objvSysScoreSummaryEN.IdXzCollege = objRow[convSysScoreSummary.IdXzCollege] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzCollege].ToString().Trim(); //学院流水号
objvSysScoreSummaryEN.CollegeName = objRow[convSysScoreSummary.CollegeName] == DBNull.Value ? null : objRow[convSysScoreSummary.CollegeName].ToString().Trim(); //学院名称
objvSysScoreSummaryEN.IdXzMajor = objRow[convSysScoreSummary.IdXzMajor] == DBNull.Value ? null : objRow[convSysScoreSummary.IdXzMajor].ToString().Trim(); //专业流水号
objvSysScoreSummaryEN.MajorName = objRow[convSysScoreSummary.MajorName] == DBNull.Value ? null : objRow[convSysScoreSummary.MajorName].ToString().Trim(); //专业名称
objvSysScoreSummaryEN.IdGradeBase = objRow[convSysScoreSummary.IdGradeBase] == DBNull.Value ? null : objRow[convSysScoreSummary.IdGradeBase].ToString().Trim(); //年级流水号
objvSysScoreSummaryEN.GradeBaseName = objRow[convSysScoreSummary.GradeBaseName] == DBNull.Value ? null : objRow[convSysScoreSummary.GradeBaseName].ToString().Trim(); //年级名称
objvSysScoreSummaryEN.OnlyId = objRow[convSysScoreSummary.OnlyId] == DBNull.Value ? null : objRow[convSysScoreSummary.OnlyId].ToString().Trim(); //OnlyId
objvSysScoreSummaryEN.ScoreTypeId = objRow[convSysScoreSummary.ScoreTypeId] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeId].ToString().Trim(); //分数类型Id
objvSysScoreSummaryEN.ScoreTypeName = objRow[convSysScoreSummary.ScoreTypeName] == DBNull.Value ? null : objRow[convSysScoreSummary.ScoreTypeName].ToString().Trim(); //分数类型名称
objvSysScoreSummaryEN.UpdUser = objRow[convSysScoreSummary.UpdUser] == DBNull.Value ? null : objRow[convSysScoreSummary.UpdUser].ToString().Trim(); //修改人
objvSysScoreSummaryEN.Score = objRow[convSysScoreSummary.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convSysScoreSummary.Score].ToString().Trim()); //评分
objvSysScoreSummaryEN.IdCurrEduCls = objRow[convSysScoreSummary.IdCurrEduCls] == DBNull.Value ? null : objRow[convSysScoreSummary.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvSysScoreSummaryEN.EduClsName = objRow[convSysScoreSummary.EduClsName] == DBNull.Value ? null : objRow[convSysScoreSummary.EduClsName].ToString().Trim(); //教学班名
objvSysScoreSummaryEN.IsSubmit = TransNullToBool(objRow[convSysScoreSummary.IsSubmit].ToString().Trim()); //是否提交
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSysScoreSummaryDA: GetObjByDataRow)", objException.Message));
}
objvSysScoreSummaryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSysScoreSummaryEN;
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
objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysScoreSummaryEN._CurrTabName, convSysScoreSummary.mId, 8, "");
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
objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSysScoreSummaryEN._CurrTabName, convSysScoreSummary.mId, 8, strPrefix);
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vSysScoreSummary where " + strCondition;
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vSysScoreSummary where " + strCondition;
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysScoreSummary", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSysScoreSummaryDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSysScoreSummary", strCondition))
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
objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSysScoreSummary");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSysScoreSummaryENS">源对象</param>
 /// <param name = "objvSysScoreSummaryENT">目标对象</param>
public void CopyTo(clsvSysScoreSummaryEN objvSysScoreSummaryENS, clsvSysScoreSummaryEN objvSysScoreSummaryENT)
{
objvSysScoreSummaryENT.mId = objvSysScoreSummaryENS.mId; //mId
objvSysScoreSummaryENT.UserId = objvSysScoreSummaryENS.UserId; //用户ID
objvSysScoreSummaryENT.SchoolYear = objvSysScoreSummaryENS.SchoolYear; //学年
objvSysScoreSummaryENT.UpdDate = objvSysScoreSummaryENS.UpdDate; //修改日期
objvSysScoreSummaryENT.Memo = objvSysScoreSummaryENS.Memo; //备注
objvSysScoreSummaryENT.UserName = objvSysScoreSummaryENS.UserName; //用户名
objvSysScoreSummaryENT.IdXzCollege = objvSysScoreSummaryENS.IdXzCollege; //学院流水号
objvSysScoreSummaryENT.CollegeName = objvSysScoreSummaryENS.CollegeName; //学院名称
objvSysScoreSummaryENT.IdXzMajor = objvSysScoreSummaryENS.IdXzMajor; //专业流水号
objvSysScoreSummaryENT.MajorName = objvSysScoreSummaryENS.MajorName; //专业名称
objvSysScoreSummaryENT.IdGradeBase = objvSysScoreSummaryENS.IdGradeBase; //年级流水号
objvSysScoreSummaryENT.GradeBaseName = objvSysScoreSummaryENS.GradeBaseName; //年级名称
objvSysScoreSummaryENT.OnlyId = objvSysScoreSummaryENS.OnlyId; //OnlyId
objvSysScoreSummaryENT.ScoreTypeId = objvSysScoreSummaryENS.ScoreTypeId; //分数类型Id
objvSysScoreSummaryENT.ScoreTypeName = objvSysScoreSummaryENS.ScoreTypeName; //分数类型名称
objvSysScoreSummaryENT.UpdUser = objvSysScoreSummaryENS.UpdUser; //修改人
objvSysScoreSummaryENT.Score = objvSysScoreSummaryENS.Score; //评分
objvSysScoreSummaryENT.IdCurrEduCls = objvSysScoreSummaryENS.IdCurrEduCls; //教学班流水号
objvSysScoreSummaryENT.EduClsName = objvSysScoreSummaryENS.EduClsName; //教学班名
objvSysScoreSummaryENT.IsSubmit = objvSysScoreSummaryENS.IsSubmit; //是否提交
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSysScoreSummaryEN objvSysScoreSummaryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.UserId, 18, convSysScoreSummary.UserId);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.SchoolYear, 10, convSysScoreSummary.SchoolYear);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.UpdDate, 20, convSysScoreSummary.UpdDate);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.Memo, 1000, convSysScoreSummary.Memo);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.UserName, 30, convSysScoreSummary.UserName);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.IdXzCollege, 4, convSysScoreSummary.IdXzCollege);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.CollegeName, 100, convSysScoreSummary.CollegeName);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.IdXzMajor, 8, convSysScoreSummary.IdXzMajor);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.MajorName, 100, convSysScoreSummary.MajorName);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.IdGradeBase, 4, convSysScoreSummary.IdGradeBase);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.GradeBaseName, 50, convSysScoreSummary.GradeBaseName);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.OnlyId, 20, convSysScoreSummary.OnlyId);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.ScoreTypeId, 4, convSysScoreSummary.ScoreTypeId);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.ScoreTypeName, 10, convSysScoreSummary.ScoreTypeName);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.UpdUser, 20, convSysScoreSummary.UpdUser);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.IdCurrEduCls, 8, convSysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvSysScoreSummaryEN.EduClsName, 100, convSysScoreSummary.EduClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.UserId, convSysScoreSummary.UserId);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.SchoolYear, convSysScoreSummary.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.UpdDate, convSysScoreSummary.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.Memo, convSysScoreSummary.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.UserName, convSysScoreSummary.UserName);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.IdXzCollege, convSysScoreSummary.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.CollegeName, convSysScoreSummary.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.IdXzMajor, convSysScoreSummary.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.MajorName, convSysScoreSummary.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.IdGradeBase, convSysScoreSummary.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.GradeBaseName, convSysScoreSummary.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.OnlyId, convSysScoreSummary.OnlyId);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.ScoreTypeId, convSysScoreSummary.ScoreTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.ScoreTypeName, convSysScoreSummary.ScoreTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.UpdUser, convSysScoreSummary.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.IdCurrEduCls, convSysScoreSummary.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvSysScoreSummaryEN.EduClsName, convSysScoreSummary.EduClsName);
//检查外键字段长度
 objvSysScoreSummaryEN._IsCheckProperty = true;
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysScoreSummaryEN._CurrTabName);
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSysScoreSummaryEN._CurrTabName, strCondition);
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
 objSQL = clsvSysScoreSummaryDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}