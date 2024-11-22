
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserLog4FunctionDA
 表名:vUserLog4Function(01120338)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:50:22
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:日志管理(LogManage)
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
 /// v用户使用功能日志(vUserLog4Function)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvUserLog4FunctionDA : clsCommBase4DA
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
 return clsvUserLog4FunctionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvUserLog4FunctionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvUserLog4FunctionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvUserLog4FunctionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvUserLog4FunctionEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vUserLog4Function(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable_vUserLog4Function)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserLog4Function.* from vUserLog4Function Left Join {1} on {2} where {3} and vUserLog4Function.mId not in (Select top {5} vUserLog4Function.mId from vUserLog4Function Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1} and mId not in (Select top {2} mId from vUserLog4Function where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1} and mId not in (Select top {3} mId from vUserLog4Function where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vUserLog4Function.* from vUserLog4Function Left Join {1} on {2} where {3} and vUserLog4Function.mId not in (Select top {5} vUserLog4Function.mId from vUserLog4Function Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1} and mId not in (Select top {2} mId from vUserLog4Function where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vUserLog4Function where {1} and mId not in (Select top {3} mId from vUserLog4Function where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvUserLog4FunctionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA:GetObjLst)", objException.Message));
}
List<clsvUserLog4FunctionEN> arrObjLst = new List<clsvUserLog4FunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN();
try
{
objvUserLog4FunctionEN.mId = TransNullToInt(objRow[convUserLog4Function.mId].ToString().Trim()); //mId
objvUserLog4FunctionEN.UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(); //用户ID
objvUserLog4FunctionEN.UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(); //用户名
objvUserLog4FunctionEN.RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(); //角色名
objvUserLog4FunctionEN.UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(); //使用时间
objvUserLog4FunctionEN.FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(); //功能Id
objvUserLog4FunctionEN.FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(); //函数名
objvUserLog4FunctionEN.FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名
objvUserLog4FunctionEN.ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(); //模块名
objvUserLog4FunctionEN.IsStudent = TransNullToBool(objRow[convUserLog4Function.IsStudent].ToString().Trim()); //是否学生
objvUserLog4FunctionEN.IsStudentReal = TransNullToBool(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real
objvUserLog4FunctionEN.IsTeacher = TransNullToBool(objRow[convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师
objvUserLog4FunctionEN.IsTeacherReal = TransNullToBool(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real
objvUserLog4FunctionEN.IsQuestion = TransNullToBool(objRow[convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目
objvUserLog4FunctionEN.PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(); //页面路径
objvUserLog4FunctionEN.PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(); //页面名称
objvUserLog4FunctionEN.UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(); //修改日期
objvUserLog4FunctionEN.UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(); //修改人
objvUserLog4FunctionEN.Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetObjLst)", objException.Message));
}
objvUserLog4FunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserLog4FunctionEN);
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
public List<clsvUserLog4FunctionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA:GetObjLstByTabName)", objException.Message));
}
List<clsvUserLog4FunctionEN> arrObjLst = new List<clsvUserLog4FunctionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN();
try
{
objvUserLog4FunctionEN.mId = TransNullToInt(objRow[convUserLog4Function.mId].ToString().Trim()); //mId
objvUserLog4FunctionEN.UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(); //用户ID
objvUserLog4FunctionEN.UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(); //用户名
objvUserLog4FunctionEN.RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(); //角色名
objvUserLog4FunctionEN.UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(); //使用时间
objvUserLog4FunctionEN.FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(); //功能Id
objvUserLog4FunctionEN.FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(); //函数名
objvUserLog4FunctionEN.FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名
objvUserLog4FunctionEN.ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(); //模块名
objvUserLog4FunctionEN.IsStudent = TransNullToBool(objRow[convUserLog4Function.IsStudent].ToString().Trim()); //是否学生
objvUserLog4FunctionEN.IsStudentReal = TransNullToBool(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real
objvUserLog4FunctionEN.IsTeacher = TransNullToBool(objRow[convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师
objvUserLog4FunctionEN.IsTeacherReal = TransNullToBool(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real
objvUserLog4FunctionEN.IsQuestion = TransNullToBool(objRow[convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目
objvUserLog4FunctionEN.PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(); //页面路径
objvUserLog4FunctionEN.PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(); //页面名称
objvUserLog4FunctionEN.UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(); //修改日期
objvUserLog4FunctionEN.UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(); //修改人
objvUserLog4FunctionEN.Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetObjLst)", objException.Message));
}
objvUserLog4FunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvUserLog4FunctionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvUserLog4FunctionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvUserLog4Function(ref clsvUserLog4FunctionEN objvUserLog4FunctionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where mId = " + ""+ objvUserLog4FunctionEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvUserLog4FunctionEN.mId = TransNullToInt(objDT.Rows[0][convUserLog4Function.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserLog4FunctionEN.UserId = objDT.Rows[0][convUserLog4Function.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserLog4FunctionEN.UserName = objDT.Rows[0][convUserLog4Function.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLog4FunctionEN.RoleName = objDT.Rows[0][convUserLog4Function.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.UseTime = objDT.Rows[0][convUserLog4Function.UseTime].ToString().Trim(); //使用时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.FunctionId = objDT.Rows[0][convUserLog4Function.FunctionId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserLog4FunctionEN.FunctionName = objDT.Rows[0][convUserLog4Function.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.FunctionNameCH = objDT.Rows[0][convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名(字段类型:varchar,字段长度:255,是否可空:True)
 objvUserLog4FunctionEN.ModuleName = objDT.Rows[0][convUserLog4Function.ModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:255,是否可空:True)
 objvUserLog4FunctionEN.IsStudent = TransNullToBool(objDT.Rows[0][convUserLog4Function.IsStudent].ToString().Trim()); //是否学生(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsStudentReal = TransNullToBool(objDT.Rows[0][convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsTeacher = TransNullToBool(objDT.Rows[0][convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsTeacherReal = TransNullToBool(objDT.Rows[0][convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsQuestion = TransNullToBool(objDT.Rows[0][convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.PagePath = objDT.Rows[0][convUserLog4Function.PagePath].ToString().Trim(); //页面路径(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserLog4FunctionEN.PageName = objDT.Rows[0][convUserLog4Function.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.UpdDate = objDT.Rows[0][convUserLog4Function.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.UpdUser = objDT.Rows[0][convUserLog4Function.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.Memo = objDT.Rows[0][convUserLog4Function.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetvUserLog4Function)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvUserLog4FunctionEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN();
try
{
 objvUserLog4FunctionEN.mId = Int32.Parse(objRow[convUserLog4Function.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvUserLog4FunctionEN.UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvUserLog4FunctionEN.UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvUserLog4FunctionEN.RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(); //角色名(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(); //使用时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:True)
 objvUserLog4FunctionEN.FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名(字段类型:varchar,字段长度:255,是否可空:True)
 objvUserLog4FunctionEN.ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(); //模块名(字段类型:varchar,字段长度:255,是否可空:True)
 objvUserLog4FunctionEN.IsStudent = clsEntityBase2.TransNullToBool_S(objRow[convUserLog4Function.IsStudent].ToString().Trim()); //是否学生(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsStudentReal = clsEntityBase2.TransNullToBool_S(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsTeacher = clsEntityBase2.TransNullToBool_S(objRow[convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsTeacherReal = clsEntityBase2.TransNullToBool_S(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.IsQuestion = clsEntityBase2.TransNullToBool_S(objRow[convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目(字段类型:bit,字段长度:1,是否可空:True)
 objvUserLog4FunctionEN.PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(); //页面路径(字段类型:varchar,字段长度:50,是否可空:True)
 objvUserLog4FunctionEN.PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(); //页面名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvUserLog4FunctionEN.UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvUserLog4FunctionEN.Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetObjBymId)", objException.Message));
}
return objvUserLog4FunctionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvUserLog4FunctionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
strSQL = "Select * from vUserLog4Function where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN()
{
mId = TransNullToInt(objRow[convUserLog4Function.mId].ToString().Trim()), //mId
UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(), //用户ID
UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(), //用户名
RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(), //角色名
UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(), //使用时间
FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(), //功能Id
FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(), //函数名
FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(), //功能中文名
ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(), //模块名
IsStudent = TransNullToBool(objRow[convUserLog4Function.IsStudent].ToString().Trim()), //是否学生
IsStudentReal = TransNullToBool(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()), //IsStudent_Real
IsTeacher = TransNullToBool(objRow[convUserLog4Function.IsTeacher].ToString().Trim()), //是否教师
IsTeacherReal = TransNullToBool(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()), //IsTeacher_Real
IsQuestion = TransNullToBool(objRow[convUserLog4Function.IsQuestion].ToString().Trim()), //是否题目
PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(), //页面路径
PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(), //页面名称
UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim() //备注
};
objvUserLog4FunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLog4FunctionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvUserLog4FunctionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN();
try
{
objvUserLog4FunctionEN.mId = TransNullToInt(objRow[convUserLog4Function.mId].ToString().Trim()); //mId
objvUserLog4FunctionEN.UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(); //用户ID
objvUserLog4FunctionEN.UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(); //用户名
objvUserLog4FunctionEN.RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(); //角色名
objvUserLog4FunctionEN.UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(); //使用时间
objvUserLog4FunctionEN.FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(); //功能Id
objvUserLog4FunctionEN.FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(); //函数名
objvUserLog4FunctionEN.FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名
objvUserLog4FunctionEN.ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(); //模块名
objvUserLog4FunctionEN.IsStudent = TransNullToBool(objRow[convUserLog4Function.IsStudent].ToString().Trim()); //是否学生
objvUserLog4FunctionEN.IsStudentReal = TransNullToBool(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real
objvUserLog4FunctionEN.IsTeacher = TransNullToBool(objRow[convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师
objvUserLog4FunctionEN.IsTeacherReal = TransNullToBool(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real
objvUserLog4FunctionEN.IsQuestion = TransNullToBool(objRow[convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目
objvUserLog4FunctionEN.PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(); //页面路径
objvUserLog4FunctionEN.PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(); //页面名称
objvUserLog4FunctionEN.UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(); //修改日期
objvUserLog4FunctionEN.UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(); //修改人
objvUserLog4FunctionEN.Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetObjByDataRowvUserLog4Function)", objException.Message));
}
objvUserLog4FunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLog4FunctionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvUserLog4FunctionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvUserLog4FunctionEN objvUserLog4FunctionEN = new clsvUserLog4FunctionEN();
try
{
objvUserLog4FunctionEN.mId = TransNullToInt(objRow[convUserLog4Function.mId].ToString().Trim()); //mId
objvUserLog4FunctionEN.UserId = objRow[convUserLog4Function.UserId] == DBNull.Value ? null : objRow[convUserLog4Function.UserId].ToString().Trim(); //用户ID
objvUserLog4FunctionEN.UserName = objRow[convUserLog4Function.UserName] == DBNull.Value ? null : objRow[convUserLog4Function.UserName].ToString().Trim(); //用户名
objvUserLog4FunctionEN.RoleName = objRow[convUserLog4Function.RoleName] == DBNull.Value ? null : objRow[convUserLog4Function.RoleName].ToString().Trim(); //角色名
objvUserLog4FunctionEN.UseTime = objRow[convUserLog4Function.UseTime] == DBNull.Value ? null : objRow[convUserLog4Function.UseTime].ToString().Trim(); //使用时间
objvUserLog4FunctionEN.FunctionId = objRow[convUserLog4Function.FunctionId] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionId].ToString().Trim(); //功能Id
objvUserLog4FunctionEN.FunctionName = objRow[convUserLog4Function.FunctionName] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionName].ToString().Trim(); //函数名
objvUserLog4FunctionEN.FunctionNameCH = objRow[convUserLog4Function.FunctionNameCH] == DBNull.Value ? null : objRow[convUserLog4Function.FunctionNameCH].ToString().Trim(); //功能中文名
objvUserLog4FunctionEN.ModuleName = objRow[convUserLog4Function.ModuleName] == DBNull.Value ? null : objRow[convUserLog4Function.ModuleName].ToString().Trim(); //模块名
objvUserLog4FunctionEN.IsStudent = TransNullToBool(objRow[convUserLog4Function.IsStudent].ToString().Trim()); //是否学生
objvUserLog4FunctionEN.IsStudentReal = TransNullToBool(objRow[convUserLog4Function.IsStudentReal].ToString().Trim()); //IsStudent_Real
objvUserLog4FunctionEN.IsTeacher = TransNullToBool(objRow[convUserLog4Function.IsTeacher].ToString().Trim()); //是否教师
objvUserLog4FunctionEN.IsTeacherReal = TransNullToBool(objRow[convUserLog4Function.IsTeacherReal].ToString().Trim()); //IsTeacher_Real
objvUserLog4FunctionEN.IsQuestion = TransNullToBool(objRow[convUserLog4Function.IsQuestion].ToString().Trim()); //是否题目
objvUserLog4FunctionEN.PagePath = objRow[convUserLog4Function.PagePath] == DBNull.Value ? null : objRow[convUserLog4Function.PagePath].ToString().Trim(); //页面路径
objvUserLog4FunctionEN.PageName = objRow[convUserLog4Function.PageName] == DBNull.Value ? null : objRow[convUserLog4Function.PageName].ToString().Trim(); //页面名称
objvUserLog4FunctionEN.UpdDate = objRow[convUserLog4Function.UpdDate].ToString().Trim(); //修改日期
objvUserLog4FunctionEN.UpdUser = objRow[convUserLog4Function.UpdUser].ToString().Trim(); //修改人
objvUserLog4FunctionEN.Memo = objRow[convUserLog4Function.Memo] == DBNull.Value ? null : objRow[convUserLog4Function.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvUserLog4FunctionDA: GetObjByDataRow)", objException.Message));
}
objvUserLog4FunctionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvUserLog4FunctionEN;
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
objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserLog4FunctionEN._CurrTabName, convUserLog4Function.mId, 8, "");
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
objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvUserLog4FunctionEN._CurrTabName, convUserLog4Function.mId, 8, strPrefix);
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vUserLog4Function where " + strCondition;
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vUserLog4Function where " + strCondition;
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserLog4Function", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvUserLog4FunctionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vUserLog4Function", strCondition))
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
objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vUserLog4Function");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvUserLog4FunctionENS">源对象</param>
 /// <param name = "objvUserLog4FunctionENT">目标对象</param>
public void CopyTo(clsvUserLog4FunctionEN objvUserLog4FunctionENS, clsvUserLog4FunctionEN objvUserLog4FunctionENT)
{
objvUserLog4FunctionENT.mId = objvUserLog4FunctionENS.mId; //mId
objvUserLog4FunctionENT.UserId = objvUserLog4FunctionENS.UserId; //用户ID
objvUserLog4FunctionENT.UserName = objvUserLog4FunctionENS.UserName; //用户名
objvUserLog4FunctionENT.RoleName = objvUserLog4FunctionENS.RoleName; //角色名
objvUserLog4FunctionENT.UseTime = objvUserLog4FunctionENS.UseTime; //使用时间
objvUserLog4FunctionENT.FunctionId = objvUserLog4FunctionENS.FunctionId; //功能Id
objvUserLog4FunctionENT.FunctionName = objvUserLog4FunctionENS.FunctionName; //函数名
objvUserLog4FunctionENT.FunctionNameCH = objvUserLog4FunctionENS.FunctionNameCH; //功能中文名
objvUserLog4FunctionENT.ModuleName = objvUserLog4FunctionENS.ModuleName; //模块名
objvUserLog4FunctionENT.IsStudent = objvUserLog4FunctionENS.IsStudent; //是否学生
objvUserLog4FunctionENT.IsStudentReal = objvUserLog4FunctionENS.IsStudentReal; //IsStudent_Real
objvUserLog4FunctionENT.IsTeacher = objvUserLog4FunctionENS.IsTeacher; //是否教师
objvUserLog4FunctionENT.IsTeacherReal = objvUserLog4FunctionENS.IsTeacherReal; //IsTeacher_Real
objvUserLog4FunctionENT.IsQuestion = objvUserLog4FunctionENS.IsQuestion; //是否题目
objvUserLog4FunctionENT.PagePath = objvUserLog4FunctionENS.PagePath; //页面路径
objvUserLog4FunctionENT.PageName = objvUserLog4FunctionENS.PageName; //页面名称
objvUserLog4FunctionENT.UpdDate = objvUserLog4FunctionENS.UpdDate; //修改日期
objvUserLog4FunctionENT.UpdUser = objvUserLog4FunctionENS.UpdUser; //修改人
objvUserLog4FunctionENT.Memo = objvUserLog4FunctionENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvUserLog4FunctionEN objvUserLog4FunctionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.UserId, 18, convUserLog4Function.UserId);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.UserName, 30, convUserLog4Function.UserName);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.RoleName, 100, convUserLog4Function.RoleName);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.UseTime, 20, convUserLog4Function.UseTime);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.FunctionId, 4, convUserLog4Function.FunctionId);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.FunctionName, 100, convUserLog4Function.FunctionName);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.FunctionNameCH, 255, convUserLog4Function.FunctionNameCH);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.ModuleName, 255, convUserLog4Function.ModuleName);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.PagePath, 50, convUserLog4Function.PagePath);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.PageName, 100, convUserLog4Function.PageName);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.UpdDate, 20, convUserLog4Function.UpdDate);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.UpdUser, 20, convUserLog4Function.UpdUser);
clsCheckSql.CheckFieldLen(objvUserLog4FunctionEN.Memo, 1000, convUserLog4Function.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.UserId, convUserLog4Function.UserId);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.UserName, convUserLog4Function.UserName);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.RoleName, convUserLog4Function.RoleName);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.UseTime, convUserLog4Function.UseTime);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.FunctionId, convUserLog4Function.FunctionId);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.FunctionName, convUserLog4Function.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.FunctionNameCH, convUserLog4Function.FunctionNameCH);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.ModuleName, convUserLog4Function.ModuleName);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.PagePath, convUserLog4Function.PagePath);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.PageName, convUserLog4Function.PageName);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.UpdDate, convUserLog4Function.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.UpdUser, convUserLog4Function.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvUserLog4FunctionEN.Memo, convUserLog4Function.Memo);
//检查外键字段长度
 objvUserLog4FunctionEN._IsCheckProperty = true;
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserLog4FunctionEN._CurrTabName);
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvUserLog4FunctionEN._CurrTabName, strCondition);
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
 objSQL = clsvUserLog4FunctionDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}