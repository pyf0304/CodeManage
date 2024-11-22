
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduClsStu4CorrectDA
 表名:CurrEduClsStu4Correct(01120180)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:08:38
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
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
 /// 教学班学生_批改作业(CurrEduClsStu4Correct)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduClsStu4CorrectDA : clsCommBase4DA
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
 return clsCurrEduClsStu4CorrectEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCurrEduClsStu4CorrectEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduClsStu4CorrectEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCurrEduClsStu4CorrectEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduClsStu4CorrectEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduClsStu4Correct(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable_CurrEduClsStu4Correct)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsStu4Correct.* from CurrEduClsStu4Correct Left Join {1} on {2} where {3} and CurrEduClsStu4Correct.IdCurrEduClsStu4Correct not in (Select top {5} CurrEduClsStu4Correct.IdCurrEduClsStu4Correct from CurrEduClsStu4Correct Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1} and IdCurrEduClsStu4Correct not in (Select top {2} IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1} and IdCurrEduClsStu4Correct not in (Select top {3} IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduClsStu4Correct.* from CurrEduClsStu4Correct Left Join {1} on {2} where {3} and CurrEduClsStu4Correct.IdCurrEduClsStu4Correct not in (Select top {5} CurrEduClsStu4Correct.IdCurrEduClsStu4Correct from CurrEduClsStu4Correct Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1} and IdCurrEduClsStu4Correct not in (Select top {2} IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduClsStu4Correct where {1} and IdCurrEduClsStu4Correct not in (Select top {3} IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCurrEduClsStu4CorrectEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA:GetObjLst)", objException.Message));
}
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = TransNullToInt(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetObjLst)", objException.Message));
}
objCurrEduClsStu4CorrectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
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
public List<clsCurrEduClsStu4CorrectEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduClsStu4CorrectEN> arrObjLst = new List<clsCurrEduClsStu4CorrectEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = TransNullToInt(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetObjLst)", objException.Message));
}
objCurrEduClsStu4CorrectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduClsStu4CorrectEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduClsStu4Correct(ref clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = " + ""+ objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = TransNullToInt(objDT.Rows[0][conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = objDT.Rows[0][conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.IdStu = objDT.Rows[0][conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsStu4CorrectEN.RightId = objDT.Rows[0][conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.SchoolTerm = objDT.Rows[0][conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsStu4CorrectEN.SchoolYear = objDT.Rows[0][conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsStu4CorrectEN.ModifyDate = objDT.Rows[0][conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStu4CorrectEN.ModifyUserID = objDT.Rows[0][conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStu4CorrectEN.Memo = objDT.Rows[0][conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetCurrEduClsStu4Correct)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduClsStu4CorrectEN GetObjByIdCurrEduClsStu4Correct(long lngIdCurrEduClsStu4Correct)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = " + ""+ lngIdCurrEduClsStu4Correct+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
 objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = Int32.Parse(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetObjByIdCurrEduClsStu4Correct)", objException.Message));
}
return objCurrEduClsStu4CorrectEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduClsStu4CorrectEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN()
{
IdCurrEduClsStu4Correct = TransNullToInt(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()), //教学班学生_批改作业流水号
IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(), //教学班流水号
IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(), //学生流水号
RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(), //权限编号
SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(), //学期
SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(), //学年
ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(), //修改日期
ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(), //修改人
Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim() //备注
};
objCurrEduClsStu4CorrectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStu4CorrectEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsStu4CorrectEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = TransNullToInt(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetObjByDataRowCurrEduClsStu4Correct)", objException.Message));
}
objCurrEduClsStu4CorrectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStu4CorrectEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduClsStu4CorrectEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN = new clsCurrEduClsStu4CorrectEN();
try
{
objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct = TransNullToInt(objRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim()); //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectEN.IdCurrEduCls = objRow[conCurrEduClsStu4Correct.IdCurrEduCls] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduClsStu4CorrectEN.IdStu = objRow[conCurrEduClsStu4Correct.IdStu] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objCurrEduClsStu4CorrectEN.RightId = objRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objCurrEduClsStu4CorrectEN.SchoolTerm = objRow[conCurrEduClsStu4Correct.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objCurrEduClsStu4CorrectEN.SchoolYear = objRow[conCurrEduClsStu4Correct.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objCurrEduClsStu4CorrectEN.ModifyDate = objRow[conCurrEduClsStu4Correct.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objCurrEduClsStu4CorrectEN.ModifyUserID = objRow[conCurrEduClsStu4Correct.ModifyUserID] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objCurrEduClsStu4CorrectEN.Memo = objRow[conCurrEduClsStu4Correct.Memo] == DBNull.Value ? null : objRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduClsStu4CorrectDA: GetObjByDataRow)", objException.Message));
}
objCurrEduClsStu4CorrectEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduClsStu4CorrectEN;
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
objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsStu4CorrectEN._CurrTabName, conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct, 8, "");
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
objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduClsStu4CorrectEN._CurrTabName, conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct, 8, strPrefix);
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where " + strCondition;
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduClsStu4Correct from CurrEduClsStu4Correct where " + strCondition;
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
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdCurrEduClsStu4Correct)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsStu4Correct", "IdCurrEduClsStu4Correct = " + ""+ lngIdCurrEduClsStu4Correct+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduClsStu4Correct", strCondition))
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
objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduClsStu4Correct");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
 {
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsStu4Correct");
objRow = objDS.Tables["CurrEduClsStu4Correct"].NewRow();
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  "")
 {
objRow[conCurrEduClsStu4Correct.IdCurrEduCls] = objCurrEduClsStu4CorrectEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  "")
 {
objRow[conCurrEduClsStu4Correct.IdStu] = objCurrEduClsStu4CorrectEN.IdStu; //学生流水号
 }
objRow[conCurrEduClsStu4Correct.RightId] = objCurrEduClsStu4CorrectEN.RightId; //权限编号
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  "")
 {
objRow[conCurrEduClsStu4Correct.SchoolTerm] = objCurrEduClsStu4CorrectEN.SchoolTerm; //学期
 }
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  "")
 {
objRow[conCurrEduClsStu4Correct.SchoolYear] = objCurrEduClsStu4CorrectEN.SchoolYear; //学年
 }
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  "")
 {
objRow[conCurrEduClsStu4Correct.ModifyDate] = objCurrEduClsStu4CorrectEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  "")
 {
objRow[conCurrEduClsStu4Correct.ModifyUserID] = objCurrEduClsStu4CorrectEN.ModifyUserID; //修改人
 }
 if (objCurrEduClsStu4CorrectEN.Memo !=  "")
 {
objRow[conCurrEduClsStu4Correct.Memo] = objCurrEduClsStu4CorrectEN.Memo; //备注
 }
objDS.Tables[clsCurrEduClsStu4CorrectEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduClsStu4CorrectEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdStu);
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.RightId);
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolYear);
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyDate);
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyUserID);
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserID + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.Memo);
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu4Correct");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdStu);
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.RightId);
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolYear);
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyDate);
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyUserID);
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserID + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.Memo);
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu4Correct");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdStu);
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.RightId);
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolYear);
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyDate);
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyUserID);
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserID + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.Memo);
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu4Correct");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduClsStu4CorrectEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.IdStu);
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStu + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.RightId);
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRightId + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolTerm);
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.SchoolYear);
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyDate);
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.ModifyUserID);
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserID + "'");
 }
 
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduClsStu4Correct.Memo);
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduClsStu4Correct");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduClsStu4Corrects(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduClsStu4Correct");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngIdCurrEduClsStu4Correct = TransNullToInt(oRow[conCurrEduClsStu4Correct.IdCurrEduClsStu4Correct].ToString().Trim());
if (IsExist(lngIdCurrEduClsStu4Correct))
{
 string strResult = "关键字变量值为:" + string.Format("IdCurrEduClsStu4Correct = {0}", lngIdCurrEduClsStu4Correct) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduClsStu4CorrectEN._CurrTabName ].NewRow();
objRow[conCurrEduClsStu4Correct.IdCurrEduCls] = oRow[conCurrEduClsStu4Correct.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduClsStu4Correct.IdStu] = oRow[conCurrEduClsStu4Correct.IdStu].ToString().Trim(); //学生流水号
objRow[conCurrEduClsStu4Correct.RightId] = oRow[conCurrEduClsStu4Correct.RightId].ToString().Trim(); //权限编号
objRow[conCurrEduClsStu4Correct.SchoolTerm] = oRow[conCurrEduClsStu4Correct.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduClsStu4Correct.SchoolYear] = oRow[conCurrEduClsStu4Correct.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduClsStu4Correct.ModifyDate] = oRow[conCurrEduClsStu4Correct.ModifyDate].ToString().Trim(); //修改日期
objRow[conCurrEduClsStu4Correct.ModifyUserID] = oRow[conCurrEduClsStu4Correct.ModifyUserID].ToString().Trim(); //修改人
objRow[conCurrEduClsStu4Correct.Memo] = oRow[conCurrEduClsStu4Correct.Memo].ToString().Trim(); //备注
 objDS.Tables[clsCurrEduClsStu4CorrectEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduClsStu4CorrectEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStu4CorrectEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = " + ""+ objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduClsStu4CorrectEN._CurrTabName);
if (objDS.Tables[clsCurrEduClsStu4CorrectEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCurrEduClsStu4Correct = " + ""+ objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct+"");
return false;
}
objRow = objDS.Tables[clsCurrEduClsStu4CorrectEN._CurrTabName].Rows[0];
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls))
 {
objRow[conCurrEduClsStu4Correct.IdCurrEduCls] = objCurrEduClsStu4CorrectEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdStu))
 {
objRow[conCurrEduClsStu4Correct.IdStu] = objCurrEduClsStu4CorrectEN.IdStu; //学生流水号
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.RightId))
 {
objRow[conCurrEduClsStu4Correct.RightId] = objCurrEduClsStu4CorrectEN.RightId; //权限编号
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm))
 {
objRow[conCurrEduClsStu4Correct.SchoolTerm] = objCurrEduClsStu4CorrectEN.SchoolTerm; //学期
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolYear))
 {
objRow[conCurrEduClsStu4Correct.SchoolYear] = objCurrEduClsStu4CorrectEN.SchoolYear; //学年
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyDate))
 {
objRow[conCurrEduClsStu4Correct.ModifyDate] = objCurrEduClsStu4CorrectEN.ModifyDate; //修改日期
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID))
 {
objRow[conCurrEduClsStu4Correct.ModifyUserID] = objCurrEduClsStu4CorrectEN.ModifyUserID; //修改人
 }
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.Memo))
 {
objRow[conCurrEduClsStu4Correct.Memo] = objCurrEduClsStu4CorrectEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsCurrEduClsStu4CorrectEN._CurrTabName);
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStu4CorrectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduClsStu4Correct Set ");
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls))
 {
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsStu4Correct.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdStu))
 {
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStu, conCurrEduClsStu4Correct.IdStu); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.IdStu); //学生流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.RightId))
 {
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRightId, conCurrEduClsStu4Correct.RightId); //权限编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.RightId); //权限编号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsStu4Correct.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolYear))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsStu4Correct.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyDate))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduClsStu4Correct.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserID, conCurrEduClsStu4Correct.ModifyUserID); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.ModifyUserID); //修改人
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.Memo))
 {
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsStu4Correct.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduClsStu4Correct = {0}", objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct); 
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strCondition)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStu4CorrectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu4Correct Set ");
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls))
 {
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdStu))
 {
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStu = '{0}',", strIdStu); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStu = null,"); //学生流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.RightId))
 {
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RightId = '{0}',", strRightId); //权限编号
 }
 else
 {
 sbSQL.Append(" RightId = null,"); //权限编号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolYear))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyDate))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserID = '{0}',", strModifyUserID); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserID = null,"); //修改人
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.Memo))
 {
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStu4CorrectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu4Correct Set ");
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls))
 {
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdStu))
 {
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStu = '{0}',", strIdStu); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStu = null,"); //学生流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.RightId))
 {
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RightId = '{0}',", strRightId); //权限编号
 }
 else
 {
 sbSQL.Append(" RightId = null,"); //权限编号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolYear))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyDate))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserID = '{0}',", strModifyUserID); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserID = null,"); //修改人
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.Memo))
 {
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objCurrEduClsStu4CorrectEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCurrEduClsStu4CorrectEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduClsStu4CorrectEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduClsStu4Correct Set ");
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdCurrEduCls))
 {
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdCurrEduCls = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objCurrEduClsStu4CorrectEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conCurrEduClsStu4Correct.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.IdStu))
 {
 if (objCurrEduClsStu4CorrectEN.IdStu  ==  "")
 {
 objCurrEduClsStu4CorrectEN.IdStu = null;
 }
 if (objCurrEduClsStu4CorrectEN.IdStu !=  null)
 {
 var strIdStu = objCurrEduClsStu4CorrectEN.IdStu.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStu, conCurrEduClsStu4Correct.IdStu); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.IdStu); //学生流水号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.RightId))
 {
 if (objCurrEduClsStu4CorrectEN.RightId !=  null)
 {
 var strRightId = objCurrEduClsStu4CorrectEN.RightId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRightId, conCurrEduClsStu4Correct.RightId); //权限编号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.RightId); //权限编号
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolTerm))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduClsStu4CorrectEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduClsStu4Correct.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.SchoolYear))
 {
 if (objCurrEduClsStu4CorrectEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduClsStu4CorrectEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduClsStu4Correct.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.SchoolYear); //学年
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyDate))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduClsStu4CorrectEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduClsStu4Correct.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.ModifyUserID))
 {
 if (objCurrEduClsStu4CorrectEN.ModifyUserID !=  null)
 {
 var strModifyUserID = objCurrEduClsStu4CorrectEN.ModifyUserID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserID, conCurrEduClsStu4Correct.ModifyUserID); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.ModifyUserID); //修改人
 }
 }
 
 if (objCurrEduClsStu4CorrectEN.IsUpdated(conCurrEduClsStu4Correct.Memo))
 {
 if (objCurrEduClsStu4CorrectEN.Memo !=  null)
 {
 var strMemo = objCurrEduClsStu4CorrectEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduClsStu4Correct.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduClsStu4Correct.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduClsStu4Correct = {0}", objCurrEduClsStu4CorrectEN.IdCurrEduClsStu4Correct); 
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
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngIdCurrEduClsStu4Correct) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngIdCurrEduClsStu4Correct,
};
 objSQL.ExecSP("CurrEduClsStu4Correct_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngIdCurrEduClsStu4Correct, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
//删除CurrEduClsStu4Correct本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = " + ""+ lngIdCurrEduClsStu4Correct+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduClsStu4Correct(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
//删除CurrEduClsStu4Correct本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngIdCurrEduClsStu4Correct">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngIdCurrEduClsStu4Correct) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
//删除CurrEduClsStu4Correct本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduClsStu4Correct where IdCurrEduClsStu4Correct = " + ""+ lngIdCurrEduClsStu4Correct+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduClsStu4Correct(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: DelCurrEduClsStu4Correct)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsStu4Correct where " + strCondition ;
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
public bool DelCurrEduClsStu4CorrectWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduClsStu4CorrectDA: DelCurrEduClsStu4CorrectWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduClsStu4Correct where " + strCondition ;
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
 /// <param name = "objCurrEduClsStu4CorrectENS">源对象</param>
 /// <param name = "objCurrEduClsStu4CorrectENT">目标对象</param>
public void CopyTo(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENS, clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectENT)
{
objCurrEduClsStu4CorrectENT.IdCurrEduClsStu4Correct = objCurrEduClsStu4CorrectENS.IdCurrEduClsStu4Correct; //教学班学生_批改作业流水号
objCurrEduClsStu4CorrectENT.IdCurrEduCls = objCurrEduClsStu4CorrectENS.IdCurrEduCls; //教学班流水号
objCurrEduClsStu4CorrectENT.IdStu = objCurrEduClsStu4CorrectENS.IdStu; //学生流水号
objCurrEduClsStu4CorrectENT.RightId = objCurrEduClsStu4CorrectENS.RightId; //权限编号
objCurrEduClsStu4CorrectENT.SchoolTerm = objCurrEduClsStu4CorrectENS.SchoolTerm; //学期
objCurrEduClsStu4CorrectENT.SchoolYear = objCurrEduClsStu4CorrectENS.SchoolYear; //学年
objCurrEduClsStu4CorrectENT.ModifyDate = objCurrEduClsStu4CorrectENS.ModifyDate; //修改日期
objCurrEduClsStu4CorrectENT.ModifyUserID = objCurrEduClsStu4CorrectENS.ModifyUserID; //修改人
objCurrEduClsStu4CorrectENT.Memo = objCurrEduClsStu4CorrectENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCurrEduClsStu4CorrectEN.RightId, conCurrEduClsStu4Correct.RightId);
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.RightId, 8, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolYear, 10, conCurrEduClsStu4Correct.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyDate, 20, conCurrEduClsStu4Correct.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyUserID, 18, conCurrEduClsStu4Correct.ModifyUserID);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.Memo, 1000, conCurrEduClsStu4Correct.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
 objCurrEduClsStu4CorrectEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.RightId, 8, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolYear, 10, conCurrEduClsStu4Correct.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyDate, 20, conCurrEduClsStu4Correct.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyUserID, 18, conCurrEduClsStu4Correct.ModifyUserID);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.Memo, 1000, conCurrEduClsStu4Correct.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
 objCurrEduClsStu4CorrectEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.RightId, 8, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolTerm, 1, conCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.SchoolYear, 10, conCurrEduClsStu4Correct.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyDate, 20, conCurrEduClsStu4Correct.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.ModifyUserID, 18, conCurrEduClsStu4Correct.ModifyUserID);
clsCheckSql.CheckFieldLen(objCurrEduClsStu4CorrectEN.Memo, 1000, conCurrEduClsStu4Correct.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.IdCurrEduCls, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.IdStu, conCurrEduClsStu4Correct.IdStu);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.RightId, conCurrEduClsStu4Correct.RightId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.SchoolTerm, conCurrEduClsStu4Correct.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.SchoolYear, conCurrEduClsStu4Correct.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.ModifyDate, conCurrEduClsStu4Correct.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.ModifyUserID, conCurrEduClsStu4Correct.ModifyUserID);
clsCheckSql.CheckSqlInjection4Field(objCurrEduClsStu4CorrectEN.Memo, conCurrEduClsStu4Correct.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdCurrEduCls, 8, conCurrEduClsStu4Correct.IdCurrEduCls);
clsCheckSql.CheckFieldForeignKey(objCurrEduClsStu4CorrectEN.IdStu, 8, conCurrEduClsStu4Correct.IdStu);
 objCurrEduClsStu4CorrectEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CurrEduClsStu4Correct(教学班学生_批改作业),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCurrEduClsStu4CorrectEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCurrEduClsStu4CorrectEN objCurrEduClsStu4CorrectEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objCurrEduClsStu4CorrectEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objCurrEduClsStu4CorrectEN.IdCurrEduCls);
}
 if (objCurrEduClsStu4CorrectEN.IdStu == null)
{
 sbCondition.AppendFormat(" and IdStu is null");
}
else
{
 sbCondition.AppendFormat(" and IdStu = '{0}'", objCurrEduClsStu4CorrectEN.IdStu);
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsStu4CorrectEN._CurrTabName);
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduClsStu4CorrectEN._CurrTabName, strCondition);
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduClsStu4CorrectDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}