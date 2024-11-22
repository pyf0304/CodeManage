
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls_SynDA
 表名:vCurrEduCls_Syn(01120928)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:23:25
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
 /// vCurrEduCls_Syn(vCurrEduCls_Syn)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCurrEduCls_SynDA : clsCommBase4DA
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
 return clsvCurrEduCls_SynEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCurrEduCls_SynEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SynEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCurrEduCls_SynEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCurrEduCls_SynEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCurrEduCls)
{
strIdCurrEduCls = strIdCurrEduCls.Replace("'", "''");
if (strIdCurrEduCls.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCurrEduCls_Syn中,检查关键字,长度不正确!(clsvCurrEduCls_SynDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCurrEduCls_Syn中,关键字不能为空 或 null!(clsvCurrEduCls_SynDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCurrEduCls_SynDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCurrEduCls_Syn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable_vCurrEduCls_Syn)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduCls_Syn.* from vCurrEduCls_Syn Left Join {1} on {2} where {3} and vCurrEduCls_Syn.IdCurrEduCls not in (Select top {5} vCurrEduCls_Syn.IdCurrEduCls from vCurrEduCls_Syn Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls_Syn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls_Syn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCurrEduCls_Syn.* from vCurrEduCls_Syn Left Join {1} on {2} where {3} and vCurrEduCls_Syn.IdCurrEduCls not in (Select top {5} vCurrEduCls_Syn.IdCurrEduCls from vCurrEduCls_Syn Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from vCurrEduCls_Syn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from vCurrEduCls_Syn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCurrEduCls_SynEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA:GetObjLst)", objException.Message));
}
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = TransNullToBool(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = TransNullToBool(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = TransNullToShort(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetObjLst)", objException.Message));
}
objvCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduCls_SynEN);
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
public List<clsvCurrEduCls_SynEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCurrEduCls_SynEN> arrObjLst = new List<clsvCurrEduCls_SynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = TransNullToBool(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = TransNullToBool(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = TransNullToShort(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetObjLst)", objException.Message));
}
objvCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCurrEduCls_SynEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCurrEduCls_Syn(ref clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where IdCurrEduCls = " + "'"+ objvCurrEduCls_SynEN.IdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCurrEduCls_SynEN.IdCurrEduCls = objDT.Rows[0][convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.EduClsTypeName = objDT.Rows[0][convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.CourseCode = objDT.Rows[0][convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.CourseDescription = objDT.Rows[0][convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCurrEduCls_SynEN.CourseName = objDT.Rows[0][convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.ViewCount = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.ExampleImgPath = objDT.Rows[0][convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduCls_SynEN.TeachingSolutionName = objDT.Rows[0][convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.IdTeacher = objDT.Rows[0][convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.TeacherId = objDT.Rows[0][convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduCls_SynEN.TeacherName = objDT.Rows[0][convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduCls_SynEN.CollegeId = objDT.Rows[0][convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CollegeName = objDT.Rows[0][convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.IdXzMajor = objDT.Rows[0][convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.MajorName = objDT.Rows[0][convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.GradeBaseId = objDT.Rows[0][convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.GradeBaseName = objDT.Rows[0][convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduCls_SynEN.GradeBaseNameA = objDT.Rows[0][convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvCurrEduCls_SynEN.CourseTypeId = objDT.Rows[0][convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CourseTypeName = objDT.Rows[0][convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduCls_SynEN.CurrStuNumValid = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.CurrStuNum = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.CurrEduClsId = objDT.Rows[0][convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduCls_SynEN.EduClsName = objDT.Rows[0][convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.EduClsTypeId = objDT.Rows[0][convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CourseId = objDT.Rows[0][convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduCls_SynEN.TeachingSolutionId = objDT.Rows[0][convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.IdXzCollege = objDT.Rows[0][convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.IdEduWay = objDT.Rows[0][convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.IdClassRoomType = objDT.Rows[0][convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.MaxStuQty = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.WeekQty = TransNullToInt(objDT.Rows[0][convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.WeekStatusId = objDT.Rows[0][convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.CustomerWeek = objDT.Rows[0][convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdExecPlan = objDT.Rows[0][convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduCls_SynEN.Mark = TransNullToDouble(objDT.Rows[0][convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduCls_SynEN.CheckClassRoom = objDT.Rows[0][convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.CheckAdminCls = objDT.Rows[0][convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.CheckTeacher = objDT.Rows[0][convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.EditLocked = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.Sched = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdUniZone = objDT.Rows[0][convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.Locked = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdGradeBase = objDT.Rows[0][convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.IsEffective = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.SchoolYear = objDT.Rows[0][convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduCls_SynEN.SchoolTerm = objDT.Rows[0][convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.ArrangeCourseMemo = objDT.Rows[0][convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduCls_SynEN.IdCourseType = objDT.Rows[0][convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.IsDegree = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.IdScoreType = objDT.Rows[0][convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.GetScoreWayId = objDT.Rows[0][convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdExamType = objDT.Rows[0][convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.ExamPortion = TransNullToShort(objDT.Rows[0][convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduCls_SynEN.MidExamScorePortion = TransNullToShort(objDT.Rows[0][convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.IsClearScore = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.GeneratePwdDate = objDT.Rows[0][convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.PkWeekTime = objDT.Rows[0][convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.PkClassRooms = objDT.Rows[0][convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objvCurrEduCls_SynEN.BeginWeek = TransNullToShort(objDT.Rows[0][convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.TeacherNames = objDT.Rows[0][convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.IsSynch = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.SynchDate = objDT.Rows[0][convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduCls_SynEN.ModifyDate = objDT.Rows[0][convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.ModifyUserId = objDT.Rows[0][convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.Memo = objDT.Rows[0][convCurrEduCls_Syn.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduCls_SynEN.SignInDate = objDT.Rows[0][convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.SignInStateID = objDT.Rows[0][convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.SignInUser = objDT.Rows[0][convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.SynchToWebUser = objDT.Rows[0][convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objDT.Rows[0][convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.SynchToWebDate = objDT.Rows[0][convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetvCurrEduCls_Syn)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public clsvCurrEduCls_SynEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
 objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径(字段类型:varchar,字段长度:300,是否可空:True)
 objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号(字段类型:varchar,字段长度:12,是否可空:False)
 objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写(字段类型:varchar,字段长度:10,是否可空:False)
 objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.TotalLessonQty = Int32.Parse(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCurrEduCls_SynEN.LessonQtyPerWeek = short.Parse(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCurrEduCls_SynEN.ExamPortion = short.Parse(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objvCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objvCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetObjByIdCurrEduCls)", objException.Message));
}
return objvCurrEduCls_SynEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCurrEduCls_SynEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from vCurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN()
{
IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(), //教学班流水号
EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(), //教学班类型名称
CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(), //课程代码
CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(), //课程描述
CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(), //课程名称
ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()), //浏览量
ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(), //示例图路径
TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(), //教学方案名称
IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(), //教师流水号
TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(), //教师工号
TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(), //教师姓名
CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(), //学院ID
CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(), //学院名称
IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(), //专业流水号
MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(), //专业名称
GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(), //年级代号
GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(), //年级名称
GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(), //年级名称缩写
CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(), //课程类型ID
CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(), //课程类型名称
CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()), //CurrStuNum_Valid
CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()), //当前学生数
CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(), //教学班类型Id
CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(), //课程Id
TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(), //教学方案Id
IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(), //学院流水号
IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(), //教学方式流水号
IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(), //教室类型流水号
TotalLessonQty = TransNullToInt(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()), //最大学生数
WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(), //自定义上课周
IsCompleteScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()), //是否成绩齐全
IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(), //执行计划流水号
LessonQtyPerWeek = TransNullToShort(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()), //获得学分
CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(), //检查教室结果
CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(), //检查行政班结果
CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(), //检查教师结果
EditLocked = TransNullToBool(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()), //编辑锁定
Sched = TransNullToBool(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()), //是否排课
IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(), //校区流水号
Locked = TransNullToBool(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()), //锁定状态
IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(), //年级流水号
IsEffective = TransNullToBool(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()), //是否有效
IsForPaperReading = TransNullToBool(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()), //是否参与论文阅读
IsUnDeterminedClsRm = TransNullToBool(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()), //是否待定教室
SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(), //学期
ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(), //排课备注
IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(), //课程类型流水号
IsDegree = TransNullToBool(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(), //成绩类型流水号
GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(), //获得成绩方式Id
IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(), //考试方式流水号
ExamPortion = TransNullToShort(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()), //平时成绩所占比例
MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()), //期末成绩所占比例
IsClearScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()), //是否重录成绩
IsGeneratePwd = TransNullToBool(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()), //是否生成口令
GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(), //生成口令时间
PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(), //排课时间
PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(), //排课教室
BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()), //开始周
TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(), //教师姓名
IsSynch = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(), //同步日期
ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(), //备注
SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(), //签入时间
SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(), //签入状态表流水号
SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(), //签入人
SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(), //同步Web用户
IsSynchToWeb = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()), //是否同步Web
SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim() //同步Web日期
};
objvCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SynEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCurrEduCls_SynEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = TransNullToBool(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = TransNullToBool(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = TransNullToShort(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetObjByDataRowvCurrEduCls_Syn)", objException.Message));
}
objvCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SynEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCurrEduCls_SynEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCurrEduCls_SynEN objvCurrEduCls_SynEN = new clsvCurrEduCls_SynEN();
try
{
objvCurrEduCls_SynEN.IdCurrEduCls = objRow[convCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvCurrEduCls_SynEN.EduClsTypeName = objRow[convCurrEduCls_Syn.EduClsTypeName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.EduClsTypeName].ToString().Trim(); //教学班类型名称
objvCurrEduCls_SynEN.CourseCode = objRow[convCurrEduCls_Syn.CourseCode] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseCode].ToString().Trim(); //课程代码
objvCurrEduCls_SynEN.CourseDescription = objRow[convCurrEduCls_Syn.CourseDescription] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseDescription].ToString().Trim(); //课程描述
objvCurrEduCls_SynEN.CourseName = objRow[convCurrEduCls_Syn.CourseName] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseName].ToString().Trim(); //课程名称
objvCurrEduCls_SynEN.ViewCount = objRow[convCurrEduCls_Syn.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.ViewCount].ToString().Trim()); //浏览量
objvCurrEduCls_SynEN.ExampleImgPath = objRow[convCurrEduCls_Syn.ExampleImgPath] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ExampleImgPath].ToString().Trim(); //示例图路径
objvCurrEduCls_SynEN.TeachingSolutionName = objRow[convCurrEduCls_Syn.TeachingSolutionName].ToString().Trim(); //教学方案名称
objvCurrEduCls_SynEN.IdTeacher = objRow[convCurrEduCls_Syn.IdTeacher].ToString().Trim(); //教师流水号
objvCurrEduCls_SynEN.TeacherId = objRow[convCurrEduCls_Syn.TeacherId].ToString().Trim(); //教师工号
objvCurrEduCls_SynEN.TeacherName = objRow[convCurrEduCls_Syn.TeacherName].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.CollegeId = objRow[convCurrEduCls_Syn.CollegeId].ToString().Trim(); //学院ID
objvCurrEduCls_SynEN.CollegeName = objRow[convCurrEduCls_Syn.CollegeName].ToString().Trim(); //学院名称
objvCurrEduCls_SynEN.IdXzMajor = objRow[convCurrEduCls_Syn.IdXzMajor].ToString().Trim(); //专业流水号
objvCurrEduCls_SynEN.MajorName = objRow[convCurrEduCls_Syn.MajorName].ToString().Trim(); //专业名称
objvCurrEduCls_SynEN.GradeBaseId = objRow[convCurrEduCls_Syn.GradeBaseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GradeBaseId].ToString().Trim(); //年级代号
objvCurrEduCls_SynEN.GradeBaseName = objRow[convCurrEduCls_Syn.GradeBaseName].ToString().Trim(); //年级名称
objvCurrEduCls_SynEN.GradeBaseNameA = objRow[convCurrEduCls_Syn.GradeBaseNameA].ToString().Trim(); //年级名称缩写
objvCurrEduCls_SynEN.CourseTypeId = objRow[convCurrEduCls_Syn.CourseTypeId].ToString().Trim(); //课程类型ID
objvCurrEduCls_SynEN.CourseTypeName = objRow[convCurrEduCls_Syn.CourseTypeName].ToString().Trim(); //课程类型名称
objvCurrEduCls_SynEN.CurrStuNumValid = objRow[convCurrEduCls_Syn.CurrStuNumValid] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNumValid].ToString().Trim()); //CurrStuNum_Valid
objvCurrEduCls_SynEN.CurrStuNum = objRow[convCurrEduCls_Syn.CurrStuNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.CurrStuNum].ToString().Trim()); //当前学生数
objvCurrEduCls_SynEN.CurrEduClsId = objRow[convCurrEduCls_Syn.CurrEduClsId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objvCurrEduCls_SynEN.EduClsName = objRow[convCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objvCurrEduCls_SynEN.EduClsTypeId = objRow[convCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objvCurrEduCls_SynEN.CourseId = objRow[convCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objvCurrEduCls_SynEN.TeachingSolutionId = objRow[convCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCurrEduCls_SynEN.IdXzCollege = objRow[convCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objvCurrEduCls_SynEN.IdEduWay = objRow[convCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objvCurrEduCls_SynEN.IdClassRoomType = objRow[convCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objvCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objRow[convCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objvCurrEduCls_SynEN.MaxStuQty = objRow[convCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objvCurrEduCls_SynEN.WeekQty = objRow[convCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objvCurrEduCls_SynEN.ScheUnitPW = objRow[convCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objvCurrEduCls_SynEN.WeekStatusId = objRow[convCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objvCurrEduCls_SynEN.CustomerWeek = objRow[convCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objvCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objvCurrEduCls_SynEN.IdExecPlan = objRow[convCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objvCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objRow[convCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objvCurrEduCls_SynEN.Mark = objRow[convCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objvCurrEduCls_SynEN.CheckClassRoom = objRow[convCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objvCurrEduCls_SynEN.CheckAdminCls = objRow[convCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objvCurrEduCls_SynEN.CheckTeacher = objRow[convCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objvCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[convCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objvCurrEduCls_SynEN.Sched = TransNullToBool(objRow[convCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objvCurrEduCls_SynEN.IdUniZone = objRow[convCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objvCurrEduCls_SynEN.Locked = TransNullToBool(objRow[convCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objvCurrEduCls_SynEN.IdGradeBase = objRow[convCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objvCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[convCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objvCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[convCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objvCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[convCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objvCurrEduCls_SynEN.SchoolYear = objRow[convCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objvCurrEduCls_SynEN.SchoolTerm = objRow[convCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objvCurrEduCls_SynEN.ArrangeCourseMemo = objRow[convCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objvCurrEduCls_SynEN.IdCourseType = objRow[convCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objvCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[convCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objvCurrEduCls_SynEN.IdScoreType = objRow[convCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objvCurrEduCls_SynEN.GetScoreWayId = objRow[convCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objvCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[convCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objvCurrEduCls_SynEN.IdExamType = objRow[convCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objvCurrEduCls_SynEN.ExamPortion = TransNullToShort(objRow[convCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objvCurrEduCls_SynEN.MidExamScorePortion = objRow[convCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objvCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[convCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objvCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[convCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objvCurrEduCls_SynEN.GeneratePwdDate = objRow[convCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objvCurrEduCls_SynEN.PkWeekTime = objRow[convCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objvCurrEduCls_SynEN.PkClassRooms = objRow[convCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objvCurrEduCls_SynEN.BeginWeek = objRow[convCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[convCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objvCurrEduCls_SynEN.TeacherNames = objRow[convCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objvCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objvCurrEduCls_SynEN.SynchDate = objRow[convCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objvCurrEduCls_SynEN.ModifyDate = objRow[convCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objvCurrEduCls_SynEN.ModifyUserId = objRow[convCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objvCurrEduCls_SynEN.Memo = objRow[convCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objvCurrEduCls_SynEN.SignInDate = objRow[convCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objvCurrEduCls_SynEN.SignInStateID = objRow[convCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objvCurrEduCls_SynEN.SignInUser = objRow[convCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objvCurrEduCls_SynEN.SynchToWebUser = objRow[convCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objvCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[convCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objvCurrEduCls_SynEN.SynchToWebDate = objRow[convCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[convCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCurrEduCls_SynDA: GetObjByDataRow)", objException.Message));
}
objvCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCurrEduCls_SynEN;
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
objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduCls_SynEN._CurrTabName, convCurrEduCls_Syn.IdCurrEduCls, 8, "");
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
objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCurrEduCls_SynEN._CurrTabName, convCurrEduCls_Syn.IdCurrEduCls, 8, strPrefix);
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls_Syn where " + strCondition;
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls from vCurrEduCls_Syn where " + strCondition;
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls_Syn", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCurrEduCls_SynDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCurrEduCls_Syn", strCondition))
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
objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCurrEduCls_Syn");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCurrEduCls_SynENS">源对象</param>
 /// <param name = "objvCurrEduCls_SynENT">目标对象</param>
public void CopyTo(clsvCurrEduCls_SynEN objvCurrEduCls_SynENS, clsvCurrEduCls_SynEN objvCurrEduCls_SynENT)
{
objvCurrEduCls_SynENT.IdCurrEduCls = objvCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objvCurrEduCls_SynENT.EduClsTypeName = objvCurrEduCls_SynENS.EduClsTypeName; //教学班类型名称
objvCurrEduCls_SynENT.CourseCode = objvCurrEduCls_SynENS.CourseCode; //课程代码
objvCurrEduCls_SynENT.CourseDescription = objvCurrEduCls_SynENS.CourseDescription; //课程描述
objvCurrEduCls_SynENT.CourseName = objvCurrEduCls_SynENS.CourseName; //课程名称
objvCurrEduCls_SynENT.ViewCount = objvCurrEduCls_SynENS.ViewCount; //浏览量
objvCurrEduCls_SynENT.ExampleImgPath = objvCurrEduCls_SynENS.ExampleImgPath; //示例图路径
objvCurrEduCls_SynENT.TeachingSolutionName = objvCurrEduCls_SynENS.TeachingSolutionName; //教学方案名称
objvCurrEduCls_SynENT.IdTeacher = objvCurrEduCls_SynENS.IdTeacher; //教师流水号
objvCurrEduCls_SynENT.TeacherId = objvCurrEduCls_SynENS.TeacherId; //教师工号
objvCurrEduCls_SynENT.TeacherName = objvCurrEduCls_SynENS.TeacherName; //教师姓名
objvCurrEduCls_SynENT.CollegeId = objvCurrEduCls_SynENS.CollegeId; //学院ID
objvCurrEduCls_SynENT.CollegeName = objvCurrEduCls_SynENS.CollegeName; //学院名称
objvCurrEduCls_SynENT.IdXzMajor = objvCurrEduCls_SynENS.IdXzMajor; //专业流水号
objvCurrEduCls_SynENT.MajorName = objvCurrEduCls_SynENS.MajorName; //专业名称
objvCurrEduCls_SynENT.GradeBaseId = objvCurrEduCls_SynENS.GradeBaseId; //年级代号
objvCurrEduCls_SynENT.GradeBaseName = objvCurrEduCls_SynENS.GradeBaseName; //年级名称
objvCurrEduCls_SynENT.GradeBaseNameA = objvCurrEduCls_SynENS.GradeBaseNameA; //年级名称缩写
objvCurrEduCls_SynENT.CourseTypeId = objvCurrEduCls_SynENS.CourseTypeId; //课程类型ID
objvCurrEduCls_SynENT.CourseTypeName = objvCurrEduCls_SynENS.CourseTypeName; //课程类型名称
objvCurrEduCls_SynENT.CurrStuNumValid = objvCurrEduCls_SynENS.CurrStuNumValid; //CurrStuNum_Valid
objvCurrEduCls_SynENT.CurrStuNum = objvCurrEduCls_SynENS.CurrStuNum; //当前学生数
objvCurrEduCls_SynENT.CurrEduClsId = objvCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objvCurrEduCls_SynENT.EduClsName = objvCurrEduCls_SynENS.EduClsName; //教学班名
objvCurrEduCls_SynENT.EduClsTypeId = objvCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objvCurrEduCls_SynENT.CourseId = objvCurrEduCls_SynENS.CourseId; //课程Id
objvCurrEduCls_SynENT.TeachingSolutionId = objvCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objvCurrEduCls_SynENT.IdXzCollege = objvCurrEduCls_SynENS.IdXzCollege; //学院流水号
objvCurrEduCls_SynENT.IdEduWay = objvCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objvCurrEduCls_SynENT.IdClassRoomType = objvCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objvCurrEduCls_SynENT.TotalLessonQty = objvCurrEduCls_SynENS.TotalLessonQty; //总课时数
objvCurrEduCls_SynENT.MaxStuQty = objvCurrEduCls_SynENS.MaxStuQty; //最大学生数
objvCurrEduCls_SynENT.WeekQty = objvCurrEduCls_SynENS.WeekQty; //总周数
objvCurrEduCls_SynENT.ScheUnitPW = objvCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objvCurrEduCls_SynENT.WeekStatusId = objvCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objvCurrEduCls_SynENT.CustomerWeek = objvCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objvCurrEduCls_SynENT.IsCompleteScore = objvCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objvCurrEduCls_SynENT.IdExecPlan = objvCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objvCurrEduCls_SynENT.LessonQtyPerWeek = objvCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objvCurrEduCls_SynENT.Mark = objvCurrEduCls_SynENS.Mark; //获得学分
objvCurrEduCls_SynENT.CheckClassRoom = objvCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objvCurrEduCls_SynENT.CheckAdminCls = objvCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objvCurrEduCls_SynENT.CheckTeacher = objvCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objvCurrEduCls_SynENT.EditLocked = objvCurrEduCls_SynENS.EditLocked; //编辑锁定
objvCurrEduCls_SynENT.Sched = objvCurrEduCls_SynENS.Sched; //是否排课
objvCurrEduCls_SynENT.IdUniZone = objvCurrEduCls_SynENS.IdUniZone; //校区流水号
objvCurrEduCls_SynENT.Locked = objvCurrEduCls_SynENS.Locked; //锁定状态
objvCurrEduCls_SynENT.IdGradeBase = objvCurrEduCls_SynENS.IdGradeBase; //年级流水号
objvCurrEduCls_SynENT.IsEffective = objvCurrEduCls_SynENS.IsEffective; //是否有效
objvCurrEduCls_SynENT.IsForPaperReading = objvCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objvCurrEduCls_SynENT.IsUnDeterminedClsRm = objvCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objvCurrEduCls_SynENT.SchoolYear = objvCurrEduCls_SynENS.SchoolYear; //学年
objvCurrEduCls_SynENT.SchoolTerm = objvCurrEduCls_SynENS.SchoolTerm; //学期
objvCurrEduCls_SynENT.ArrangeCourseMemo = objvCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objvCurrEduCls_SynENT.IdCourseType = objvCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objvCurrEduCls_SynENT.IsDegree = objvCurrEduCls_SynENS.IsDegree; //是否学位课
objvCurrEduCls_SynENT.IdScoreType = objvCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objvCurrEduCls_SynENT.GetScoreWayId = objvCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduCls_SynENT.IsProportionalCtrl = objvCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objvCurrEduCls_SynENT.IdExamType = objvCurrEduCls_SynENS.IdExamType; //考试方式流水号
objvCurrEduCls_SynENT.ExamPortion = objvCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objvCurrEduCls_SynENT.MidExamScorePortion = objvCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objvCurrEduCls_SynENT.IsClearScore = objvCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objvCurrEduCls_SynENT.IsGeneratePwd = objvCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objvCurrEduCls_SynENT.GeneratePwdDate = objvCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objvCurrEduCls_SynENT.PkWeekTime = objvCurrEduCls_SynENS.PkWeekTime; //排课时间
objvCurrEduCls_SynENT.PkClassRooms = objvCurrEduCls_SynENS.PkClassRooms; //排课教室
objvCurrEduCls_SynENT.BeginWeek = objvCurrEduCls_SynENS.BeginWeek; //开始周
objvCurrEduCls_SynENT.TeacherNames = objvCurrEduCls_SynENS.TeacherNames; //教师姓名
objvCurrEduCls_SynENT.IsSynch = objvCurrEduCls_SynENS.IsSynch; //是否同步
objvCurrEduCls_SynENT.SynchDate = objvCurrEduCls_SynENS.SynchDate; //同步日期
objvCurrEduCls_SynENT.ModifyDate = objvCurrEduCls_SynENS.ModifyDate; //修改日期
objvCurrEduCls_SynENT.ModifyUserId = objvCurrEduCls_SynENS.ModifyUserId; //修改人
objvCurrEduCls_SynENT.Memo = objvCurrEduCls_SynENS.Memo; //备注
objvCurrEduCls_SynENT.SignInDate = objvCurrEduCls_SynENS.SignInDate; //签入时间
objvCurrEduCls_SynENT.SignInStateID = objvCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objvCurrEduCls_SynENT.SignInUser = objvCurrEduCls_SynENS.SignInUser; //签入人
objvCurrEduCls_SynENT.SynchToWebUser = objvCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objvCurrEduCls_SynENT.IsSynchToWeb = objvCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objvCurrEduCls_SynENT.SynchToWebDate = objvCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCurrEduCls_SynEN objvCurrEduCls_SynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdCurrEduCls, 8, convCurrEduCls_Syn.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.EduClsTypeName, 100, convCurrEduCls_Syn.EduClsTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseCode, 20, convCurrEduCls_Syn.CourseCode);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseDescription, 8000, convCurrEduCls_Syn.CourseDescription);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseName, 100, convCurrEduCls_Syn.CourseName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.ExampleImgPath, 300, convCurrEduCls_Syn.ExampleImgPath);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.TeachingSolutionName, 100, convCurrEduCls_Syn.TeachingSolutionName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdTeacher, 8, convCurrEduCls_Syn.IdTeacher);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.TeacherId, 12, convCurrEduCls_Syn.TeacherId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.TeacherName, 50, convCurrEduCls_Syn.TeacherName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CollegeId, 4, convCurrEduCls_Syn.CollegeId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CollegeName, 100, convCurrEduCls_Syn.CollegeName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdXzMajor, 8, convCurrEduCls_Syn.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.MajorName, 100, convCurrEduCls_Syn.MajorName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.GradeBaseId, 4, convCurrEduCls_Syn.GradeBaseId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.GradeBaseName, 50, convCurrEduCls_Syn.GradeBaseName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.GradeBaseNameA, 10, convCurrEduCls_Syn.GradeBaseNameA);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseTypeId, 4, convCurrEduCls_Syn.CourseTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseTypeName, 30, convCurrEduCls_Syn.CourseTypeName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CurrEduClsId, 15, convCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.EduClsName, 100, convCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.EduClsTypeId, 4, convCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CourseId, 8, convCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.TeachingSolutionId, 8, convCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdXzCollege, 4, convCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdEduWay, 4, convCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdClassRoomType, 4, convCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.WeekStatusId, 2, convCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CustomerWeek, 50, convCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdExecPlan, 8, convCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CheckClassRoom, 2000, convCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CheckAdminCls, 2000, convCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.CheckTeacher, 2000, convCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdUniZone, 4, convCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdGradeBase, 4, convCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SchoolYear, 10, convCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SchoolTerm, 1, convCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.ArrangeCourseMemo, 50, convCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdCourseType, 4, convCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdScoreType, 4, convCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.GetScoreWayId, 2, convCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.IdExamType, 4, convCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.GeneratePwdDate, 20, convCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.PkWeekTime, 2000, convCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.PkClassRooms, 150, convCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.TeacherNames, 100, convCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SynchDate, 30, convCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.ModifyDate, 20, convCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.ModifyUserId, 18, convCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.Memo, 1000, convCurrEduCls_Syn.Memo);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SignInDate, 20, convCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SignInStateID, 2, convCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SignInUser, 18, convCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SynchToWebUser, 18, convCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckFieldLen(objvCurrEduCls_SynEN.SynchToWebDate, 20, convCurrEduCls_Syn.SynchToWebDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdCurrEduCls, convCurrEduCls_Syn.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.EduClsTypeName, convCurrEduCls_Syn.EduClsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseCode, convCurrEduCls_Syn.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseDescription, convCurrEduCls_Syn.CourseDescription);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseName, convCurrEduCls_Syn.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.ExampleImgPath, convCurrEduCls_Syn.ExampleImgPath);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.TeachingSolutionName, convCurrEduCls_Syn.TeachingSolutionName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdTeacher, convCurrEduCls_Syn.IdTeacher);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.TeacherId, convCurrEduCls_Syn.TeacherId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.TeacherName, convCurrEduCls_Syn.TeacherName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CollegeId, convCurrEduCls_Syn.CollegeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CollegeName, convCurrEduCls_Syn.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdXzMajor, convCurrEduCls_Syn.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.MajorName, convCurrEduCls_Syn.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.GradeBaseId, convCurrEduCls_Syn.GradeBaseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.GradeBaseName, convCurrEduCls_Syn.GradeBaseName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.GradeBaseNameA, convCurrEduCls_Syn.GradeBaseNameA);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseTypeId, convCurrEduCls_Syn.CourseTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseTypeName, convCurrEduCls_Syn.CourseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CurrEduClsId, convCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.EduClsName, convCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.EduClsTypeId, convCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CourseId, convCurrEduCls_Syn.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.TeachingSolutionId, convCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdXzCollege, convCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdEduWay, convCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdClassRoomType, convCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.WeekStatusId, convCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CustomerWeek, convCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdExecPlan, convCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CheckClassRoom, convCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CheckAdminCls, convCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.CheckTeacher, convCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdUniZone, convCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdGradeBase, convCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SchoolYear, convCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SchoolTerm, convCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.ArrangeCourseMemo, convCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdCourseType, convCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdScoreType, convCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.GetScoreWayId, convCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.IdExamType, convCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.GeneratePwdDate, convCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.PkWeekTime, convCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.PkClassRooms, convCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.TeacherNames, convCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SynchDate, convCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.ModifyDate, convCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.ModifyUserId, convCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.Memo, convCurrEduCls_Syn.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SignInDate, convCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SignInStateID, convCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SignInUser, convCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SynchToWebUser, convCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckSqlInjection4Field(objvCurrEduCls_SynEN.SynchToWebDate, convCurrEduCls_Syn.SynchToWebDate);
//检查外键字段长度
 objvCurrEduCls_SynEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetIdCurrEduCls()
{
//获取某学院所有专业信息
string strSQL = "select IdCurrEduCls, CourseName from vCurrEduCls_Syn ";
 clsSpecSQLforSql mySql = clsvCurrEduCls_SynDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduCls_SynEN._CurrTabName);
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCurrEduCls_SynEN._CurrTabName, strCondition);
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
 objSQL = clsvCurrEduCls_SynDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}