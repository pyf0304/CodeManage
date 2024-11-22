
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsTeacherDA
 表名:CurrEduClsTeacher(01120124)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:59:32
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
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
 /// 当前教学班教师(CurrEduClsTeacher)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduClsTeacherDA : clsCommBase4DA
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
 return clsCurrEduClsTeacherEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCurrEduClsTeacherEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsTeacherEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCurrEduClsTeacherEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduClsTeacherEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduClsTeacher(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable_CurrEduClsTeacher)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsTeacher.* from CurrEduClsTeacher Left Join {1} on {2} where {3} and CurrEduClsTeacher.IdEduClsTeacher not in (Select top {5} CurrEduClsTeacher.IdEduClsTeacher from CurrEduClsTeacher Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {2} IdEduClsTeacher from CurrEduClsTeacher where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {3} IdEduClsTeacher from CurrEduClsTeacher where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsTeacher.* from CurrEduClsTeacher Left Join {1} on {2} where {3} and CurrEduClsTeacher.IdEduClsTeacher not in (Select top {5} CurrEduClsTeacher.IdEduClsTeacher from CurrEduClsTeacher Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {2} IdEduClsTeacher from CurrEduClsTeacher where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsTeacher where {1} and IdEduClsTeacher not in (Select top {3} IdEduClsTeacher from CurrEduClsTeacher where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCurrEduClsTeacherEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA:GetObjLst)", objException.Message));
}
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetObjLst)", objException.Message));
}
objCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsTeacherEN);
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
public List<clsCurrEduClsTeacherEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduClsTeacherEN> arrObjLst = new List<clsCurrEduClsTeacherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetObjLst)", objException.Message));
}
objCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsTeacherEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduClsTeacher(ref clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where IdEduClsTeacher = " + ""+ objCurrEduClsTeacherEN.IdEduClsTeacher+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objDT.Rows[0][conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdCurrEduCls = objDT.Rows[0][conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdTeacher = objDT.Rows[0][conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objDT.Rows[0][conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsTeacherEN.SchoolTerm = objDT.Rows[0][conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsTeacherEN.SchoolYear = objDT.Rows[0][conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsTeacherEN.OpenBeginDate = objDT.Rows[0][conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsTeacherEN.OpenEndDate = objDT.Rows[0][conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsTeacherEN.OrderNum = TransNullToInt(objDT.Rows[0][conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsTeacherEN.UpdDate = objDT.Rows[0][conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.LastVisitedDate = objDT.Rows[0][conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.UpdUser = objDT.Rows[0][conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.Memo = objDT.Rows[0][conCurrEduClsTeacher.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetCurrEduClsTeacher)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduClsTeacherEN GetObjByIdEduClsTeacher(long lngIdEduClsTeacher)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
 objCurrEduClsTeacherEN.IdEduClsTeacher = Int32.Parse(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetObjByIdEduClsTeacher)", objException.Message));
}
return objCurrEduClsTeacherEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduClsTeacherEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN()
{
IdEduClsTeacher = TransNullToInt(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()), //教学班老师流水号
IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(), //教学班流水号
IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(), //教师流水号
IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(), //教学班老师角色(主讲,辅导)流水号
SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(), //学年
OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(), //开放开始日期
OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(), //开放结束日期
OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(), //修改日期
LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim() //备注
};
objCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsTeacherEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsTeacherEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetObjByDataRowCurrEduClsTeacher)", objException.Message));
}
objCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsTeacherEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsTeacherEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsTeacherEN objCurrEduClsTeacherEN = new clsCurrEduClsTeacherEN();
try
{
objCurrEduClsTeacherEN.IdEduClsTeacher = TransNullToInt(objRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim()); //教学班老师流水号
objCurrEduClsTeacherEN.IdCurrEduCls = objRow[conCurrEduClsTeacher.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsTeacherEN.IdTeacher = objRow[conCurrEduClsTeacher.IdTeacher] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherEN.SchoolTerm = objRow[conCurrEduClsTeacher.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsTeacherEN.SchoolYear = objRow[conCurrEduClsTeacher.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objCurrEduClsTeacherEN.OpenBeginDate = objRow[conCurrEduClsTeacher.OpenBeginDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objCurrEduClsTeacherEN.OpenEndDate = objRow[conCurrEduClsTeacher.OpenEndDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objCurrEduClsTeacherEN.OrderNum = objRow[conCurrEduClsTeacher.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduClsTeacher.OrderNum].ToString().Trim()); //序号
objCurrEduClsTeacherEN.UpdDate = objRow[conCurrEduClsTeacher.UpdDate] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.LastVisitedDate = objRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objCurrEduClsTeacherEN.UpdUser = objRow[conCurrEduClsTeacher.UpdUser] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objCurrEduClsTeacherEN.Memo = objRow[conCurrEduClsTeacher.Memo] == DBNull.Value ? null : objRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduClsTeacherDA: GetObjByDataRow)", objException.Message));
}
objCurrEduClsTeacherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsTeacherEN;
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
objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.IdEduClsTeacher, 8, "");
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
objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsTeacherEN._CurrTabName, conCurrEduClsTeacher.IdEduClsTeacher, 8, strPrefix);
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdEduClsTeacher from CurrEduClsTeacher where " + strCondition;
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdEduClsTeacher from CurrEduClsTeacher where " + strCondition;
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsTeacher", "IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsTeacher", strCondition))
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
objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduClsTeacher");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
 {
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsTeacherEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsTeacher");
objRow = objDS.Tables["CurrEduClsTeacher"].NewRow();
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  "")
 {
objRow[conCurrEduClsTeacher.IdCurrEduCls] = objCurrEduClsTeacherEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  "")
 {
objRow[conCurrEduClsTeacher.IdTeacher] = objCurrEduClsTeacherEN.IdTeacher; //教师流水号
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  "")
 {
objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
 }
 if (objCurrEduClsTeacherEN.SchoolTerm !=  "")
 {
objRow[conCurrEduClsTeacher.SchoolTerm] = objCurrEduClsTeacherEN.SchoolTerm; //学期
 }
 if (objCurrEduClsTeacherEN.SchoolYear !=  "")
 {
objRow[conCurrEduClsTeacher.SchoolYear] = objCurrEduClsTeacherEN.SchoolYear; //学年
 }
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  "")
 {
objRow[conCurrEduClsTeacher.OpenBeginDate] = objCurrEduClsTeacherEN.OpenBeginDate; //开放开始日期
 }
 if (objCurrEduClsTeacherEN.OpenEndDate !=  "")
 {
objRow[conCurrEduClsTeacher.OpenEndDate] = objCurrEduClsTeacherEN.OpenEndDate; //开放结束日期
 }
objRow[conCurrEduClsTeacher.OrderNum] = objCurrEduClsTeacherEN.OrderNum; //序号
 if (objCurrEduClsTeacherEN.UpdDate !=  "")
 {
objRow[conCurrEduClsTeacher.UpdDate] = objCurrEduClsTeacherEN.UpdDate; //修改日期
 }
objRow[conCurrEduClsTeacher.LastVisitedDate] = objCurrEduClsTeacherEN.LastVisitedDate; //修改日期
 if (objCurrEduClsTeacherEN.UpdUser !=  "")
 {
objRow[conCurrEduClsTeacher.UpdUser] = objCurrEduClsTeacherEN.UpdUser; //修改人
 }
 if (objCurrEduClsTeacherEN.Memo !=  "")
 {
objRow[conCurrEduClsTeacher.Memo] = objCurrEduClsTeacherEN.Memo; //备注
 }
objDS.Tables[clsCurrEduClsTeacherEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduClsTeacherEN._CurrTabName);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsTeacherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdTeacher);
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPk2EduClsTeacherType + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolTerm);
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolYear);
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenBeginDate);
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenBeginDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenEndDate);
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenEndDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OrderNum);
 arrValueListForInsert.Add(objCurrEduClsTeacherEN.OrderNum.ToString());
 }
 
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdDate);
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdUser);
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.Memo);
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsTeacher");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsTeacherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdTeacher);
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPk2EduClsTeacherType + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolTerm);
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolYear);
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenBeginDate);
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenBeginDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenEndDate);
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenEndDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OrderNum);
 arrValueListForInsert.Add(objCurrEduClsTeacherEN.OrderNum.ToString());
 }
 
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdDate);
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdUser);
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.Memo);
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsTeacher");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsTeacherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdTeacher);
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPk2EduClsTeacherType + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolTerm);
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolYear);
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenBeginDate);
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenBeginDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenEndDate);
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenEndDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OrderNum);
 arrValueListForInsert.Add(objCurrEduClsTeacherEN.OrderNum.ToString());
 }
 
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdDate);
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdUser);
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.Memo);
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsTeacher");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsTeacherEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdTeacher);
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdTeacher + "'");
 }
 
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPk2EduClsTeacherType + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolTerm);
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.SchoolYear);
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenBeginDate);
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenBeginDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OpenEndDate);
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpenEndDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.OrderNum);
 arrValueListForInsert.Add(objCurrEduClsTeacherEN.OrderNum.ToString());
 }
 
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdDate);
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.LastVisitedDate);
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastVisitedDate + "'");
 }
 
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.UpdUser);
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsTeacher.Memo);
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsTeacher");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduClsTeachers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where IdEduClsTeacher = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsTeacher");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdEduClsTeacher = TransNullToInt(oRow[conCurrEduClsTeacher.IdEduClsTeacher].ToString().Trim());
if (IsExist(lngIdEduClsTeacher))
{
 string strResult = "关键字变量值为:" + string.Format("IdEduClsTeacher = {0}", lngIdEduClsTeacher) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduClsTeacherEN._CurrTabName ].NewRow();
objRow[conCurrEduClsTeacher.IdCurrEduCls] = oRow[conCurrEduClsTeacher.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduClsTeacher.IdTeacher] = oRow[conCurrEduClsTeacher.IdTeacher].ToString().Trim(); //教师流水号
objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] = oRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType].ToString().Trim(); //教学班老师角色(主讲,辅导)流水号
objRow[conCurrEduClsTeacher.SchoolTerm] = oRow[conCurrEduClsTeacher.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduClsTeacher.SchoolYear] = oRow[conCurrEduClsTeacher.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduClsTeacher.OpenBeginDate] = oRow[conCurrEduClsTeacher.OpenBeginDate].ToString().Trim(); //开放开始日期
objRow[conCurrEduClsTeacher.OpenEndDate] = oRow[conCurrEduClsTeacher.OpenEndDate].ToString().Trim(); //开放结束日期
objRow[conCurrEduClsTeacher.OrderNum] = oRow[conCurrEduClsTeacher.OrderNum].ToString().Trim(); //序号
objRow[conCurrEduClsTeacher.UpdDate] = oRow[conCurrEduClsTeacher.UpdDate].ToString().Trim(); //修改日期
objRow[conCurrEduClsTeacher.LastVisitedDate] = oRow[conCurrEduClsTeacher.LastVisitedDate].ToString().Trim(); //修改日期
objRow[conCurrEduClsTeacher.UpdUser] = oRow[conCurrEduClsTeacher.UpdUser].ToString().Trim(); //修改人
objRow[conCurrEduClsTeacher.Memo] = oRow[conCurrEduClsTeacher.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCurrEduClsTeacherEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduClsTeacherEN._CurrTabName);
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsTeacherEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsTeacher where IdEduClsTeacher = " + ""+ objCurrEduClsTeacherEN.IdEduClsTeacher+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduClsTeacherEN._CurrTabName);
if (objDS.Tables[clsCurrEduClsTeacherEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdEduClsTeacher = " + ""+ objCurrEduClsTeacherEN.IdEduClsTeacher+"");
return false;
}
objRow = objDS.Tables[clsCurrEduClsTeacherEN._CurrTabName].Rows[0];
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls))
 {
objRow[conCurrEduClsTeacher.IdCurrEduCls] = objCurrEduClsTeacherEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdTeacher))
 {
objRow[conCurrEduClsTeacher.IdTeacher] = objCurrEduClsTeacherEN.IdTeacher; //教师流水号
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType))
 {
objRow[conCurrEduClsTeacher.IdPk2EduClsTeacherType] = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolTerm))
 {
objRow[conCurrEduClsTeacher.SchoolTerm] = objCurrEduClsTeacherEN.SchoolTerm; //学期
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolYear))
 {
objRow[conCurrEduClsTeacher.SchoolYear] = objCurrEduClsTeacherEN.SchoolYear; //学年
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenBeginDate))
 {
objRow[conCurrEduClsTeacher.OpenBeginDate] = objCurrEduClsTeacherEN.OpenBeginDate; //开放开始日期
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenEndDate))
 {
objRow[conCurrEduClsTeacher.OpenEndDate] = objCurrEduClsTeacherEN.OpenEndDate; //开放结束日期
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OrderNum))
 {
objRow[conCurrEduClsTeacher.OrderNum] = objCurrEduClsTeacherEN.OrderNum; //序号
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdDate))
 {
objRow[conCurrEduClsTeacher.UpdDate] = objCurrEduClsTeacherEN.UpdDate; //修改日期
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.LastVisitedDate))
 {
objRow[conCurrEduClsTeacher.LastVisitedDate] = objCurrEduClsTeacherEN.LastVisitedDate; //修改日期
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdUser))
 {
objRow[conCurrEduClsTeacher.UpdUser] = objCurrEduClsTeacherEN.UpdUser; //修改人
 }
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.Memo))
 {
objRow[conCurrEduClsTeacher.Memo] = objCurrEduClsTeacherEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCurrEduClsTeacherEN._CurrTabName);
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsTeacherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduClsTeacher Set ");
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls))
 {
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsTeacher.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdTeacher))
 {
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeacher, conCurrEduClsTeacher.IdTeacher); //教师流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdTeacher); //教师流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType))
 {
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPk2EduClsTeacherType, conCurrEduClsTeacher.IdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolTerm))
 {
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsTeacher.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolYear))
 {
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsTeacher.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenBeginDate))
 {
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenBeginDate, conCurrEduClsTeacher.OpenBeginDate); //开放开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OpenBeginDate); //开放开始日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenEndDate))
 {
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenEndDate, conCurrEduClsTeacher.OpenEndDate); //开放结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OpenEndDate); //开放结束日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OrderNum))
 {
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsTeacherEN.OrderNum, conCurrEduClsTeacher.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OrderNum); //序号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdDate))
 {
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCurrEduClsTeacher.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.UpdDate); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.LastVisitedDate))
 {
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conCurrEduClsTeacher.LastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.LastVisitedDate); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdUser))
 {
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCurrEduClsTeacher.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.UpdUser); //修改人
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.Memo))
 {
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsTeacher.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduClsTeacher = {0}", objCurrEduClsTeacherEN.IdEduClsTeacher); 
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strCondition)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsTeacherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsTeacher Set ");
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls))
 {
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdTeacher))
 {
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeacher = '{0}',", strIdTeacher); //教师流水号
 }
 else
 {
 sbSQL.Append(" IdTeacher = null,"); //教师流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType))
 {
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPk2EduClsTeacherType = '{0}',", strIdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 else
 {
 sbSQL.Append(" IdPk2EduClsTeacherType = null,"); //教学班老师角色(主讲,辅导)流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolTerm))
 {
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolYear))
 {
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenBeginDate))
 {
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenBeginDate = '{0}',", strOpenBeginDate); //开放开始日期
 }
 else
 {
 sbSQL.Append(" OpenBeginDate = null,"); //开放开始日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenEndDate))
 {
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenEndDate = '{0}',", strOpenEndDate); //开放结束日期
 }
 else
 {
 sbSQL.Append(" OpenEndDate = null,"); //开放结束日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OrderNum))
 {
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsTeacherEN.OrderNum, conCurrEduClsTeacher.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OrderNum); //序号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdDate))
 {
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.LastVisitedDate))
 {
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdUser))
 {
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.Memo))
 {
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsTeacherEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsTeacherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsTeacher Set ");
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls))
 {
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdTeacher))
 {
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdTeacher = '{0}',", strIdTeacher); //教师流水号
 }
 else
 {
 sbSQL.Append(" IdTeacher = null,"); //教师流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType))
 {
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdPk2EduClsTeacherType = '{0}',", strIdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 else
 {
 sbSQL.Append(" IdPk2EduClsTeacherType = null,"); //教学班老师角色(主讲,辅导)流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolTerm))
 {
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolYear))
 {
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenBeginDate))
 {
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenBeginDate = '{0}',", strOpenBeginDate); //开放开始日期
 }
 else
 {
 sbSQL.Append(" OpenBeginDate = null,"); //开放开始日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenEndDate))
 {
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpenEndDate = '{0}',", strOpenEndDate); //开放结束日期
 }
 else
 {
 sbSQL.Append(" OpenEndDate = null,"); //开放结束日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OrderNum))
 {
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsTeacherEN.OrderNum, conCurrEduClsTeacher.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OrderNum); //序号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdDate))
 {
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.LastVisitedDate))
 {
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastVisitedDate = '{0}',", strLastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.Append(" LastVisitedDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdUser))
 {
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.Memo))
 {
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsTeacherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduClsTeacherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 objCurrEduClsTeacherEN.LastVisitedDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduClsTeacherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsTeacherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsTeacher Set ");
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdCurrEduCls))
 {
 if (objCurrEduClsTeacherEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsTeacherEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsTeacherEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsTeacherEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsTeacher.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdTeacher))
 {
 if (objCurrEduClsTeacherEN.IdTeacher  ==  "")
 {
 objCurrEduClsTeacherEN.IdTeacher = null;
 }
 if (objCurrEduClsTeacherEN.IdTeacher !=  null)
 {
 var strIdTeacher = objCurrEduClsTeacherEN.IdTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdTeacher, conCurrEduClsTeacher.IdTeacher); //教师流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdTeacher); //教师流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.IdPk2EduClsTeacherType))
 {
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType  ==  "")
 {
 objCurrEduClsTeacherEN.IdPk2EduClsTeacherType = null;
 }
 if (objCurrEduClsTeacherEN.IdPk2EduClsTeacherType !=  null)
 {
 var strIdPk2EduClsTeacherType = objCurrEduClsTeacherEN.IdPk2EduClsTeacherType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdPk2EduClsTeacherType, conCurrEduClsTeacher.IdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.IdPk2EduClsTeacherType); //教学班老师角色(主讲,辅导)流水号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolTerm))
 {
 if (objCurrEduClsTeacherEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsTeacherEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsTeacher.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.SchoolYear))
 {
 if (objCurrEduClsTeacherEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsTeacherEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsTeacher.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenBeginDate))
 {
 if (objCurrEduClsTeacherEN.OpenBeginDate !=  null)
 {
 var strOpenBeginDate = objCurrEduClsTeacherEN.OpenBeginDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenBeginDate, conCurrEduClsTeacher.OpenBeginDate); //开放开始日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OpenBeginDate); //开放开始日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OpenEndDate))
 {
 if (objCurrEduClsTeacherEN.OpenEndDate !=  null)
 {
 var strOpenEndDate = objCurrEduClsTeacherEN.OpenEndDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpenEndDate, conCurrEduClsTeacher.OpenEndDate); //开放结束日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OpenEndDate); //开放结束日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.OrderNum))
 {
 if (objCurrEduClsTeacherEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduClsTeacherEN.OrderNum, conCurrEduClsTeacher.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.OrderNum); //序号
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdDate))
 {
 if (objCurrEduClsTeacherEN.UpdDate !=  null)
 {
 var strUpdDate = objCurrEduClsTeacherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCurrEduClsTeacher.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.UpdDate); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.LastVisitedDate))
 {
 if (objCurrEduClsTeacherEN.LastVisitedDate !=  null)
 {
 var strLastVisitedDate = objCurrEduClsTeacherEN.LastVisitedDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastVisitedDate, conCurrEduClsTeacher.LastVisitedDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.LastVisitedDate); //修改日期
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.UpdUser))
 {
 if (objCurrEduClsTeacherEN.UpdUser !=  null)
 {
 var strUpdUser = objCurrEduClsTeacherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCurrEduClsTeacher.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.UpdUser); //修改人
 }
 }
 
 if (objCurrEduClsTeacherEN.IsUpdated(conCurrEduClsTeacher.Memo))
 {
 if (objCurrEduClsTeacherEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsTeacherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsTeacher.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsTeacher.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdEduClsTeacher = {0}", objCurrEduClsTeacherEN.IdEduClsTeacher); 
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
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdEduClsTeacher) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdEduClsTeacher,
};
 objSQL.ExecSP("CurrEduClsTeacher_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdEduClsTeacher, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
//删除CurrEduClsTeacher本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsTeacher where IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduClsTeacher(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除CurrEduClsTeacher本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsTeacher where IdEduClsTeacher in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdEduClsTeacher">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdEduClsTeacher) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
//删除CurrEduClsTeacher本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsTeacher where IdEduClsTeacher = " + ""+ lngIdEduClsTeacher+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduClsTeacher(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: DelCurrEduClsTeacher)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsTeacher where " + strCondition ;
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
public bool DelCurrEduClsTeacherWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduClsTeacherDA: DelCurrEduClsTeacherWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsTeacher where " + strCondition ;
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
 /// <param name = "objCurrEduClsTeacherENS">源对象</param>
 /// <param name = "objCurrEduClsTeacherENT">目标对象</param>
public void CopyTo(clsCurrEduClsTeacherEN objCurrEduClsTeacherENS, clsCurrEduClsTeacherEN objCurrEduClsTeacherENT)
{
objCurrEduClsTeacherENT.IdEduClsTeacher = objCurrEduClsTeacherENS.IdEduClsTeacher; //教学班老师流水号
objCurrEduClsTeacherENT.IdCurrEduCls = objCurrEduClsTeacherENS.IdCurrEduCls; //教学班流水号
objCurrEduClsTeacherENT.IdTeacher = objCurrEduClsTeacherENS.IdTeacher; //教师流水号
objCurrEduClsTeacherENT.IdPk2EduClsTeacherType = objCurrEduClsTeacherENS.IdPk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
objCurrEduClsTeacherENT.SchoolTerm = objCurrEduClsTeacherENS.SchoolTerm; //学期
objCurrEduClsTeacherENT.SchoolYear = objCurrEduClsTeacherENS.SchoolYear; //学年
objCurrEduClsTeacherENT.OpenBeginDate = objCurrEduClsTeacherENS.OpenBeginDate; //开放开始日期
objCurrEduClsTeacherENT.OpenEndDate = objCurrEduClsTeacherENS.OpenEndDate; //开放结束日期
objCurrEduClsTeacherENT.OrderNum = objCurrEduClsTeacherENS.OrderNum; //序号
objCurrEduClsTeacherENT.UpdDate = objCurrEduClsTeacherENS.UpdDate; //修改日期
objCurrEduClsTeacherENT.LastVisitedDate = objCurrEduClsTeacherENS.LastVisitedDate; //修改日期
objCurrEduClsTeacherENT.UpdUser = objCurrEduClsTeacherENS.UpdUser; //修改人
objCurrEduClsTeacherENT.Memo = objCurrEduClsTeacherENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCurrEduClsTeacherEN.LastVisitedDate, conCurrEduClsTeacher.LastVisitedDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolYear, 10, conCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenBeginDate, 8, conCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenEndDate, 8, conCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdDate, 20, conCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.LastVisitedDate, 20, conCurrEduClsTeacher.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdUser, 20, conCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.Memo, 1000, conCurrEduClsTeacher.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 objCurrEduClsTeacherEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolYear, 10, conCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenBeginDate, 8, conCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenEndDate, 8, conCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdDate, 20, conCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.LastVisitedDate, 20, conCurrEduClsTeacher.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdUser, 20, conCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.Memo, 1000, conCurrEduClsTeacher.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 objCurrEduClsTeacherEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolTerm, 1, conCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.SchoolYear, 10, conCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenBeginDate, 8, conCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.OpenEndDate, 8, conCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdDate, 20, conCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.LastVisitedDate, 20, conCurrEduClsTeacher.LastVisitedDate);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.UpdUser, 20, conCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckFieldLen(objCurrEduClsTeacherEN.Memo, 1000, conCurrEduClsTeacher.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.IdCurrEduCls, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.IdTeacher, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.SchoolTerm, conCurrEduClsTeacher.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.SchoolYear, conCurrEduClsTeacher.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.OpenBeginDate, conCurrEduClsTeacher.OpenBeginDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.OpenEndDate, conCurrEduClsTeacher.OpenEndDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.UpdDate, conCurrEduClsTeacher.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.LastVisitedDate, conCurrEduClsTeacher.LastVisitedDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.UpdUser, conCurrEduClsTeacher.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsTeacherEN.Memo, conCurrEduClsTeacher.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdCurrEduCls, 8, conCurrEduClsTeacher.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdTeacher, 8, conCurrEduClsTeacher.IdTeacher);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsTeacherEN.IdPk2EduClsTeacherType, 4, conCurrEduClsTeacher.IdPk2EduClsTeacherType);
 objCurrEduClsTeacherEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CurrEduClsTeacher(当前教学班教师),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsTeacherEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCurrEduClsTeacherEN objCurrEduClsTeacherEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsTeacherEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsTeacherEN.IdCurrEduCls);
}
 if (objCurrEduClsTeacherEN.IdTeacher == null)
{
 sbCondition.AppendFormat(" and IdTeacher is null");
}
else
{
 sbCondition.AppendFormat(" and IdTeacher = '{0}'", objCurrEduClsTeacherEN.IdTeacher);
}
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsTeacherEN._CurrTabName);
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsTeacherEN._CurrTabName, strCondition);
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsTeacherDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}