
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCurrEduCls_SynDA
 表名:CurrEduCls_Syn(01120927)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:36
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
 /// 当前教学班_动态(CurrEduCls_Syn)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCurrEduCls_SynDA : clsCommBase4DA
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
 return clsCurrEduCls_SynEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCurrEduCls_SynEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCurrEduCls_SynEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCurrEduCls_SynEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCurrEduCls_SynEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:CurrEduCls_Syn中,检查关键字,长度不正确!(clsCurrEduCls_SynDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCurrEduCls)  ==  true)
{
throw new Exception("(errid:Data000002)在表:CurrEduCls_Syn中,关键字不能为空 或 null!(clsCurrEduCls_SynDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCurrEduCls);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsCurrEduCls_SynDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CurrEduCls_Syn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable_CurrEduCls_Syn)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduCls_Syn.* from CurrEduCls_Syn Left Join {1} on {2} where {3} and CurrEduCls_Syn.IdCurrEduCls not in (Select top {5} CurrEduCls_Syn.IdCurrEduCls from CurrEduCls_Syn Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from CurrEduCls_Syn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from CurrEduCls_Syn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} CurrEduCls_Syn.* from CurrEduCls_Syn Left Join {1} on {2} where {3} and CurrEduCls_Syn.IdCurrEduCls not in (Select top {5} CurrEduCls_Syn.IdCurrEduCls from CurrEduCls_Syn Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {2} IdCurrEduCls from CurrEduCls_Syn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CurrEduCls_Syn where {1} and IdCurrEduCls not in (Select top {3} IdCurrEduCls from CurrEduCls_Syn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCurrEduCls_SynEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA:GetObjLst)", objException.Message));
}
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = TransNullToBool(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = TransNullToBool(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = TransNullToBool(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetObjLst)", objException.Message));
}
objCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduCls_SynEN);
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
public List<clsCurrEduCls_SynEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA:GetObjLstByTabName)", objException.Message));
}
List<clsCurrEduCls_SynEN> arrObjLst = new List<clsCurrEduCls_SynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = TransNullToBool(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = TransNullToBool(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = TransNullToBool(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetObjLst)", objException.Message));
}
objCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCurrEduCls_SynEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCurrEduCls_Syn(ref clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where IdCurrEduCls = " + "'"+ objCurrEduCls_SynEN.IdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCurrEduCls_SynEN.IdCurrEduCls = objDT.Rows[0][conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.CurrEduClsId = objDT.Rows[0][conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduCls_SynEN.EduClsName = objDT.Rows[0][conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduCls_SynEN.EduClsTypeId = objDT.Rows[0][conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.CourseId = objDT.Rows[0][conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.TeachingSolutionId = objDT.Rows[0][conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.IdXzCollege = objDT.Rows[0][conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.IdMajor = objDT.Rows[0][conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.IdEduWay = objDT.Rows[0][conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.IdClassRoomType = objDT.Rows[0][conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.TotalLessonQty = TransNullToInt(objDT.Rows[0][conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.MaxStuQty = TransNullToInt(objDT.Rows[0][conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.CurrentStuQty = TransNullToInt(objDT.Rows[0][conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.WeekQty = TransNullToInt(objDT.Rows[0][conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.ScheUnitPW = TransNullToShort(objDT.Rows[0][conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.WeekStatusId = objDT.Rows[0][conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.CustomerWeek = objDT.Rows[0][conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdExecPlan = objDT.Rows[0][conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.LessonQtyPerWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls_SynEN.Mark = TransNullToDouble(objDT.Rows[0][conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduCls_SynEN.CheckClassRoom = objDT.Rows[0][conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.CheckAdminCls = objDT.Rows[0][conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.CheckTeacher = objDT.Rows[0][conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.EditLocked = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.Sched = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdUniZone = objDT.Rows[0][conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.Locked = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdGradeBase = objDT.Rows[0][conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.IsEffective = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.SchoolYear = objDT.Rows[0][conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduCls_SynEN.SchoolTerm = objDT.Rows[0][conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.ArrangeCourseMemo = objDT.Rows[0][conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls_SynEN.IdCourseType = objDT.Rows[0][conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.ExportDate = objDT.Rows[0][conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.IsDegree = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.IdScoreType = objDT.Rows[0][conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.GetScoreWayId = objDT.Rows[0][conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdExamType = objDT.Rows[0][conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.ExamPortion = TransNullToShort(objDT.Rows[0][conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls_SynEN.MidExamScorePortion = TransNullToShort(objDT.Rows[0][conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.IsClearScore = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.GeneratePwdDate = objDT.Rows[0][conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.IsExportToGP = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsExportToGPWeb = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsReservedDecimal = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.ExamTime = objDT.Rows[0][conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.CheckState = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.CheckDate = objDT.Rows[0][conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objCurrEduCls_SynEN.IdEduClassInPk = objDT.Rows[0][conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.PkWeekTime = objDT.Rows[0][conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.PkClassRooms = objDT.Rows[0][conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objCurrEduCls_SynEN.BeginWeek = TransNullToShort(objDT.Rows[0][conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.TeacherNames = objDT.Rows[0][conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objCurrEduCls_SynEN.IsSynch = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.SynchDate = objDT.Rows[0][conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objCurrEduCls_SynEN.ModifyDate = objDT.Rows[0][conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.ModifyUserId = objDT.Rows[0][conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.Memo = objDT.Rows[0][conCurrEduCls_Syn.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objCurrEduCls_SynEN.SignInDate = objDT.Rows[0][conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.SignInStateID = objDT.Rows[0][conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.SignInUser = objDT.Rows[0][conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.SynchToWebUser = objDT.Rows[0][conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objDT.Rows[0][conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.SynchToWebDate = objDT.Rows[0][conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetCurrEduCls_Syn)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public clsCurrEduCls_SynEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
 objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id(字段类型:varchar,字段长度:15,是否可空:True)
 objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名(字段类型:varchar,字段长度:100,是否可空:False)
 objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数(字段类型:int,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数(字段类型:int,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls_SynEN.IsCompleteScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号(字段类型:char,字段长度:8,是否可空:False)
 objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分(字段类型:decimal,字段长度:7,是否可空:True)
 objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.EditLocked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.Sched = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.Locked = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号(字段类型:char,字段长度:4,是否可空:True)
 objCurrEduCls_SynEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsForPaperReading = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsUnDeterminedClsRm = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年(字段类型:varchar,字段长度:10,是否可空:True)
 objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期(字段类型:char,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注(字段类型:varchar,字段长度:50,是否可空:True)
 objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.IsDegree = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.IsProportionalCtrl = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号(字段类型:char,字段长度:4,是否可空:False)
 objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例(字段类型:smallint,字段长度:2,是否可空:False)
 objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.IsClearScore = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsGeneratePwd = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.IsExportToGP = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsExportToGPWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.IsReservedDecimal = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间(字段类型:varchar,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.CheckState = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期(字段类型:varchar,字段长度:20,是否可空:False)
 objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk(字段类型:char,字段长度:8,是否可空:True)
 objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间(字段类型:varchar,字段长度:2000,是否可空:True)
 objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室(字段类型:varchar,字段长度:150,是否可空:True)
 objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : clsEntityBase2.TransNullToShort_S(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周(字段类型:smallint,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名(字段类型:varchar,字段长度:100,是否可空:True)
 objCurrEduCls_SynEN.IsSynch = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步(字段类型:bit,字段长度:1,是否可空:False)
 objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期(字段类型:varchar,字段长度:30,是否可空:False)
 objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间(字段类型:varchar,字段长度:20,是否可空:True)
 objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号(字段类型:char,字段长度:2,是否可空:True)
 objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户(字段类型:varchar,字段长度:18,是否可空:True)
 objCurrEduCls_SynEN.IsSynchToWeb = clsEntityBase2.TransNullToBool_S(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web(字段类型:bit,字段长度:1,是否可空:True)
 objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetObjByIdCurrEduCls)", objException.Message));
}
return objCurrEduCls_SynEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCurrEduCls_SynEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN()
{
IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(), //教学班流水号
CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(), //教学班Id
EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(), //教学班名
EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(), //教学班类型Id
CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(), //课程Id
TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(), //教学方案Id
IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(), //学院流水号
IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(), //专业流水号
IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(), //教学方式流水号
IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(), //教室类型流水号
TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()), //总课时数
MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()), //最大学生数
CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()), //当前学生数
WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()), //总周数
ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()), //周排课次数
WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(), //周状态编号(单,双,全周)
CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(), //自定义上课周
IsCompleteScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()), //是否成绩齐全
IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(), //执行计划流水号
LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()), //周课时数
Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()), //获得学分
CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(), //检查教室结果
CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(), //检查行政班结果
CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(), //检查教师结果
EditLocked = TransNullToBool(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()), //编辑锁定
Sched = TransNullToBool(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()), //是否排课
IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(), //校区流水号
Locked = TransNullToBool(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()), //锁定状态
IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(), //年级流水号
IsEffective = TransNullToBool(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()), //是否有效
IsForPaperReading = TransNullToBool(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()), //是否参与论文阅读
IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()), //是否待定教室
SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(), //学年
SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(), //学期
ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(), //排课备注
IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(), //课程类型流水号
ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(), //导出日期
IsDegree = TransNullToBool(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()), //是否学位课
IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(), //成绩类型流水号
GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(), //获得成绩方式Id
IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()), //是否比例控制
IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(), //考试方式流水号
ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()), //平时成绩所占比例
MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()), //期末成绩所占比例
IsClearScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()), //是否重录成绩
IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()), //是否生成口令
GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(), //生成口令时间
IsExportToGP = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()), //是否导出到平台
IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()), //是否导出到Web平台
IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()), //是否保留小数
ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(), //考试时间
CheckState = TransNullToBool(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()), //检查状态
CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(), //检查日期
IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(), //id_EduClassInPk
PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(), //排课时间
PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(), //排课教室
BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()), //开始周
TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(), //教师姓名
IsSynch = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()), //是否同步
SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(), //同步日期
ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(), //修改日期
ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(), //修改人
Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(), //备注
SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(), //签入时间
SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(), //签入状态表流水号
SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(), //签入人
SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(), //同步Web用户
IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()), //是否同步Web
SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim() //同步Web日期
};
objCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls_SynEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCurrEduCls_SynEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = TransNullToBool(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = TransNullToBool(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = TransNullToBool(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetObjByDataRowCurrEduCls_Syn)", objException.Message));
}
objCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls_SynEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCurrEduCls_SynEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCurrEduCls_SynEN objCurrEduCls_SynEN = new clsCurrEduCls_SynEN();
try
{
objCurrEduCls_SynEN.IdCurrEduCls = objRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objCurrEduCls_SynEN.CurrEduClsId = objRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objCurrEduCls_SynEN.EduClsName = objRow[conCurrEduCls_Syn.EduClsName] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objCurrEduCls_SynEN.EduClsTypeId = objRow[conCurrEduCls_Syn.EduClsTypeId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objCurrEduCls_SynEN.CourseId = objRow[conCurrEduCls_Syn.CourseId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objCurrEduCls_SynEN.TeachingSolutionId = objRow[conCurrEduCls_Syn.TeachingSolutionId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objCurrEduCls_SynEN.IdXzCollege = objRow[conCurrEduCls_Syn.IdXzCollege] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objCurrEduCls_SynEN.IdMajor = objRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objCurrEduCls_SynEN.IdEduWay = objRow[conCurrEduCls_Syn.IdEduWay] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objCurrEduCls_SynEN.IdClassRoomType = objRow[conCurrEduCls_Syn.IdClassRoomType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objCurrEduCls_SynEN.TotalLessonQty = objRow[conCurrEduCls_Syn.TotalLessonQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim()); //总课时数
objCurrEduCls_SynEN.MaxStuQty = objRow[conCurrEduCls_Syn.MaxStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim()); //最大学生数
objCurrEduCls_SynEN.CurrentStuQty = objRow[conCurrEduCls_Syn.CurrentStuQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim()); //当前学生数
objCurrEduCls_SynEN.WeekQty = objRow[conCurrEduCls_Syn.WeekQty] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conCurrEduCls_Syn.WeekQty].ToString().Trim()); //总周数
objCurrEduCls_SynEN.ScheUnitPW = objRow[conCurrEduCls_Syn.ScheUnitPW] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim()); //周排课次数
objCurrEduCls_SynEN.WeekStatusId = objRow[conCurrEduCls_Syn.WeekStatusId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objCurrEduCls_SynEN.CustomerWeek = objRow[conCurrEduCls_Syn.CustomerWeek] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objCurrEduCls_SynEN.IsCompleteScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim()); //是否成绩齐全
objCurrEduCls_SynEN.IdExecPlan = objRow[conCurrEduCls_Syn.IdExecPlan] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objCurrEduCls_SynEN.LessonQtyPerWeek = objRow[conCurrEduCls_Syn.LessonQtyPerWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim()); //周课时数
objCurrEduCls_SynEN.Mark = objRow[conCurrEduCls_Syn.Mark] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conCurrEduCls_Syn.Mark].ToString().Trim()); //获得学分
objCurrEduCls_SynEN.CheckClassRoom = objRow[conCurrEduCls_Syn.CheckClassRoom] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objCurrEduCls_SynEN.CheckAdminCls = objRow[conCurrEduCls_Syn.CheckAdminCls] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objCurrEduCls_SynEN.CheckTeacher = objRow[conCurrEduCls_Syn.CheckTeacher] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objCurrEduCls_SynEN.EditLocked = TransNullToBool(objRow[conCurrEduCls_Syn.EditLocked].ToString().Trim()); //编辑锁定
objCurrEduCls_SynEN.Sched = TransNullToBool(objRow[conCurrEduCls_Syn.Sched].ToString().Trim()); //是否排课
objCurrEduCls_SynEN.IdUniZone = objRow[conCurrEduCls_Syn.IdUniZone] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objCurrEduCls_SynEN.Locked = TransNullToBool(objRow[conCurrEduCls_Syn.Locked].ToString().Trim()); //锁定状态
objCurrEduCls_SynEN.IdGradeBase = objRow[conCurrEduCls_Syn.IdGradeBase] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objCurrEduCls_SynEN.IsEffective = TransNullToBool(objRow[conCurrEduCls_Syn.IsEffective].ToString().Trim()); //是否有效
objCurrEduCls_SynEN.IsForPaperReading = TransNullToBool(objRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim()); //是否参与论文阅读
objCurrEduCls_SynEN.IsUnDeterminedClsRm = TransNullToBool(objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim()); //是否待定教室
objCurrEduCls_SynEN.SchoolYear = objRow[conCurrEduCls_Syn.SchoolYear] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objCurrEduCls_SynEN.SchoolTerm = objRow[conCurrEduCls_Syn.SchoolTerm] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objCurrEduCls_SynEN.ArrangeCourseMemo = objRow[conCurrEduCls_Syn.ArrangeCourseMemo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objCurrEduCls_SynEN.IdCourseType = objRow[conCurrEduCls_Syn.IdCourseType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objCurrEduCls_SynEN.ExportDate = objRow[conCurrEduCls_Syn.ExportDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objCurrEduCls_SynEN.IsDegree = TransNullToBool(objRow[conCurrEduCls_Syn.IsDegree].ToString().Trim()); //是否学位课
objCurrEduCls_SynEN.IdScoreType = objRow[conCurrEduCls_Syn.IdScoreType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objCurrEduCls_SynEN.GetScoreWayId = objRow[conCurrEduCls_Syn.GetScoreWayId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objCurrEduCls_SynEN.IsProportionalCtrl = TransNullToBool(objRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim()); //是否比例控制
objCurrEduCls_SynEN.IdExamType = objRow[conCurrEduCls_Syn.IdExamType] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objCurrEduCls_SynEN.ExamPortion = objRow[conCurrEduCls_Syn.ExamPortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim()); //平时成绩所占比例
objCurrEduCls_SynEN.MidExamScorePortion = objRow[conCurrEduCls_Syn.MidExamScorePortion] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim()); //期末成绩所占比例
objCurrEduCls_SynEN.IsClearScore = TransNullToBool(objRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim()); //是否重录成绩
objCurrEduCls_SynEN.IsGeneratePwd = TransNullToBool(objRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim()); //是否生成口令
objCurrEduCls_SynEN.GeneratePwdDate = objRow[conCurrEduCls_Syn.GeneratePwdDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objCurrEduCls_SynEN.IsExportToGP = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim()); //是否导出到平台
objCurrEduCls_SynEN.IsExportToGPWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim()); //是否导出到Web平台
objCurrEduCls_SynEN.IsReservedDecimal = TransNullToBool(objRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim()); //是否保留小数
objCurrEduCls_SynEN.ExamTime = objRow[conCurrEduCls_Syn.ExamTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objCurrEduCls_SynEN.CheckState = TransNullToBool(objRow[conCurrEduCls_Syn.CheckState].ToString().Trim()); //检查状态
objCurrEduCls_SynEN.CheckDate = objRow[conCurrEduCls_Syn.CheckDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objCurrEduCls_SynEN.IdEduClassInPk = objRow[conCurrEduCls_Syn.IdEduClassInPk] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objCurrEduCls_SynEN.PkWeekTime = objRow[conCurrEduCls_Syn.PkWeekTime] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objCurrEduCls_SynEN.PkClassRooms = objRow[conCurrEduCls_Syn.PkClassRooms] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objCurrEduCls_SynEN.BeginWeek = objRow[conCurrEduCls_Syn.BeginWeek] == DBNull.Value ? (short?)null : TransNullToShort(objRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim()); //开始周
objCurrEduCls_SynEN.TeacherNames = objRow[conCurrEduCls_Syn.TeacherNames] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objCurrEduCls_SynEN.IsSynch = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynch].ToString().Trim()); //是否同步
objCurrEduCls_SynEN.SynchDate = objRow[conCurrEduCls_Syn.SynchDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objCurrEduCls_SynEN.ModifyDate = objRow[conCurrEduCls_Syn.ModifyDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objCurrEduCls_SynEN.ModifyUserId = objRow[conCurrEduCls_Syn.ModifyUserId] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objCurrEduCls_SynEN.Memo = objRow[conCurrEduCls_Syn.Memo] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objCurrEduCls_SynEN.SignInDate = objRow[conCurrEduCls_Syn.SignInDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objCurrEduCls_SynEN.SignInStateID = objRow[conCurrEduCls_Syn.SignInStateID] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objCurrEduCls_SynEN.SignInUser = objRow[conCurrEduCls_Syn.SignInUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objCurrEduCls_SynEN.SynchToWebUser = objRow[conCurrEduCls_Syn.SynchToWebUser] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objCurrEduCls_SynEN.IsSynchToWeb = TransNullToBool(objRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim()); //是否同步Web
objCurrEduCls_SynEN.SynchToWebDate = objRow[conCurrEduCls_Syn.SynchToWebDate] == DBNull.Value ? null : objRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCurrEduCls_SynDA: GetObjByDataRow)", objException.Message));
}
objCurrEduCls_SynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCurrEduCls_SynEN;
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
objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduCls_SynEN._CurrTabName, conCurrEduCls_Syn.IdCurrEduCls, 8, "");
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
objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCurrEduCls_SynEN._CurrTabName, conCurrEduCls_Syn.IdCurrEduCls, 8, strPrefix);
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCurrEduCls from CurrEduCls_Syn where " + strCondition;
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCurrEduCls from CurrEduCls_Syn where " + strCondition;
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls_Syn", "IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CurrEduCls_Syn", strCondition))
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
objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CurrEduCls_Syn");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
 {
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls_SynEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls_Syn");
objRow = objDS.Tables["CurrEduCls_Syn"].NewRow();
objRow[conCurrEduCls_Syn.IdCurrEduCls] = objCurrEduCls_SynEN.IdCurrEduCls; //教学班流水号
objRow[conCurrEduCls_Syn.CurrEduClsId] = objCurrEduCls_SynEN.CurrEduClsId; //教学班Id
 if (objCurrEduCls_SynEN.EduClsName !=  "")
 {
objRow[conCurrEduCls_Syn.EduClsName] = objCurrEduCls_SynEN.EduClsName; //教学班名
 }
 if (objCurrEduCls_SynEN.EduClsTypeId !=  "")
 {
objRow[conCurrEduCls_Syn.EduClsTypeId] = objCurrEduCls_SynEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduCls_SynEN.CourseId !=  "")
 {
objRow[conCurrEduCls_Syn.CourseId] = objCurrEduCls_SynEN.CourseId; //课程Id
 }
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  "")
 {
objRow[conCurrEduCls_Syn.TeachingSolutionId] = objCurrEduCls_SynEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduCls_SynEN.IdXzCollege !=  "")
 {
objRow[conCurrEduCls_Syn.IdXzCollege] = objCurrEduCls_SynEN.IdXzCollege; //学院流水号
 }
objRow[conCurrEduCls_Syn.IdMajor] = objCurrEduCls_SynEN.IdMajor; //专业流水号
 if (objCurrEduCls_SynEN.IdEduWay !=  "")
 {
objRow[conCurrEduCls_Syn.IdEduWay] = objCurrEduCls_SynEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  "")
 {
objRow[conCurrEduCls_Syn.IdClassRoomType] = objCurrEduCls_SynEN.IdClassRoomType; //教室类型流水号
 }
objRow[conCurrEduCls_Syn.TotalLessonQty] = objCurrEduCls_SynEN.TotalLessonQty; //总课时数
objRow[conCurrEduCls_Syn.MaxStuQty] = objCurrEduCls_SynEN.MaxStuQty; //最大学生数
objRow[conCurrEduCls_Syn.CurrentStuQty] = objCurrEduCls_SynEN.CurrentStuQty; //当前学生数
objRow[conCurrEduCls_Syn.WeekQty] = objCurrEduCls_SynEN.WeekQty; //总周数
objRow[conCurrEduCls_Syn.ScheUnitPW] = objCurrEduCls_SynEN.ScheUnitPW; //周排课次数
 if (objCurrEduCls_SynEN.WeekStatusId !=  "")
 {
objRow[conCurrEduCls_Syn.WeekStatusId] = objCurrEduCls_SynEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduCls_SynEN.CustomerWeek !=  "")
 {
objRow[conCurrEduCls_Syn.CustomerWeek] = objCurrEduCls_SynEN.CustomerWeek; //自定义上课周
 }
objRow[conCurrEduCls_Syn.IsCompleteScore] = objCurrEduCls_SynEN.IsCompleteScore; //是否成绩齐全
 if (objCurrEduCls_SynEN.IdExecPlan !=  "")
 {
objRow[conCurrEduCls_Syn.IdExecPlan] = objCurrEduCls_SynEN.IdExecPlan; //执行计划流水号
 }
objRow[conCurrEduCls_Syn.LessonQtyPerWeek] = objCurrEduCls_SynEN.LessonQtyPerWeek; //周课时数
objRow[conCurrEduCls_Syn.Mark] = objCurrEduCls_SynEN.Mark; //获得学分
 if (objCurrEduCls_SynEN.CheckClassRoom !=  "")
 {
objRow[conCurrEduCls_Syn.CheckClassRoom] = objCurrEduCls_SynEN.CheckClassRoom; //检查教室结果
 }
 if (objCurrEduCls_SynEN.CheckAdminCls !=  "")
 {
objRow[conCurrEduCls_Syn.CheckAdminCls] = objCurrEduCls_SynEN.CheckAdminCls; //检查行政班结果
 }
 if (objCurrEduCls_SynEN.CheckTeacher !=  "")
 {
objRow[conCurrEduCls_Syn.CheckTeacher] = objCurrEduCls_SynEN.CheckTeacher; //检查教师结果
 }
objRow[conCurrEduCls_Syn.EditLocked] = objCurrEduCls_SynEN.EditLocked; //编辑锁定
objRow[conCurrEduCls_Syn.Sched] = objCurrEduCls_SynEN.Sched; //是否排课
 if (objCurrEduCls_SynEN.IdUniZone !=  "")
 {
objRow[conCurrEduCls_Syn.IdUniZone] = objCurrEduCls_SynEN.IdUniZone; //校区流水号
 }
objRow[conCurrEduCls_Syn.Locked] = objCurrEduCls_SynEN.Locked; //锁定状态
 if (objCurrEduCls_SynEN.IdGradeBase !=  "")
 {
objRow[conCurrEduCls_Syn.IdGradeBase] = objCurrEduCls_SynEN.IdGradeBase; //年级流水号
 }
objRow[conCurrEduCls_Syn.IsEffective] = objCurrEduCls_SynEN.IsEffective; //是否有效
objRow[conCurrEduCls_Syn.IsForPaperReading] = objCurrEduCls_SynEN.IsForPaperReading; //是否参与论文阅读
objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm] = objCurrEduCls_SynEN.IsUnDeterminedClsRm; //是否待定教室
 if (objCurrEduCls_SynEN.SchoolYear !=  "")
 {
objRow[conCurrEduCls_Syn.SchoolYear] = objCurrEduCls_SynEN.SchoolYear; //学年
 }
 if (objCurrEduCls_SynEN.SchoolTerm !=  "")
 {
objRow[conCurrEduCls_Syn.SchoolTerm] = objCurrEduCls_SynEN.SchoolTerm; //学期
 }
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  "")
 {
objRow[conCurrEduCls_Syn.ArrangeCourseMemo] = objCurrEduCls_SynEN.ArrangeCourseMemo; //排课备注
 }
 if (objCurrEduCls_SynEN.IdCourseType !=  "")
 {
objRow[conCurrEduCls_Syn.IdCourseType] = objCurrEduCls_SynEN.IdCourseType; //课程类型流水号
 }
 if (objCurrEduCls_SynEN.ExportDate !=  "")
 {
objRow[conCurrEduCls_Syn.ExportDate] = objCurrEduCls_SynEN.ExportDate; //导出日期
 }
objRow[conCurrEduCls_Syn.IsDegree] = objCurrEduCls_SynEN.IsDegree; //是否学位课
 if (objCurrEduCls_SynEN.IdScoreType !=  "")
 {
objRow[conCurrEduCls_Syn.IdScoreType] = objCurrEduCls_SynEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduCls_SynEN.GetScoreWayId !=  "")
 {
objRow[conCurrEduCls_Syn.GetScoreWayId] = objCurrEduCls_SynEN.GetScoreWayId; //获得成绩方式Id
 }
objRow[conCurrEduCls_Syn.IsProportionalCtrl] = objCurrEduCls_SynEN.IsProportionalCtrl; //是否比例控制
 if (objCurrEduCls_SynEN.IdExamType !=  "")
 {
objRow[conCurrEduCls_Syn.IdExamType] = objCurrEduCls_SynEN.IdExamType; //考试方式流水号
 }
objRow[conCurrEduCls_Syn.ExamPortion] = objCurrEduCls_SynEN.ExamPortion; //平时成绩所占比例
objRow[conCurrEduCls_Syn.MidExamScorePortion] = objCurrEduCls_SynEN.MidExamScorePortion; //期末成绩所占比例
objRow[conCurrEduCls_Syn.IsClearScore] = objCurrEduCls_SynEN.IsClearScore; //是否重录成绩
objRow[conCurrEduCls_Syn.IsGeneratePwd] = objCurrEduCls_SynEN.IsGeneratePwd; //是否生成口令
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  "")
 {
objRow[conCurrEduCls_Syn.GeneratePwdDate] = objCurrEduCls_SynEN.GeneratePwdDate; //生成口令时间
 }
objRow[conCurrEduCls_Syn.IsExportToGP] = objCurrEduCls_SynEN.IsExportToGP; //是否导出到平台
objRow[conCurrEduCls_Syn.IsExportToGPWeb] = objCurrEduCls_SynEN.IsExportToGPWeb; //是否导出到Web平台
objRow[conCurrEduCls_Syn.IsReservedDecimal] = objCurrEduCls_SynEN.IsReservedDecimal; //是否保留小数
 if (objCurrEduCls_SynEN.ExamTime !=  "")
 {
objRow[conCurrEduCls_Syn.ExamTime] = objCurrEduCls_SynEN.ExamTime; //考试时间
 }
objRow[conCurrEduCls_Syn.CheckState] = objCurrEduCls_SynEN.CheckState; //检查状态
 if (objCurrEduCls_SynEN.CheckDate !=  "")
 {
objRow[conCurrEduCls_Syn.CheckDate] = objCurrEduCls_SynEN.CheckDate; //检查日期
 }
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  "")
 {
objRow[conCurrEduCls_Syn.IdEduClassInPk] = objCurrEduCls_SynEN.IdEduClassInPk; //id_EduClassInPk
 }
 if (objCurrEduCls_SynEN.PkWeekTime !=  "")
 {
objRow[conCurrEduCls_Syn.PkWeekTime] = objCurrEduCls_SynEN.PkWeekTime; //排课时间
 }
 if (objCurrEduCls_SynEN.PkClassRooms !=  "")
 {
objRow[conCurrEduCls_Syn.PkClassRooms] = objCurrEduCls_SynEN.PkClassRooms; //排课教室
 }
objRow[conCurrEduCls_Syn.BeginWeek] = objCurrEduCls_SynEN.BeginWeek; //开始周
 if (objCurrEduCls_SynEN.TeacherNames !=  "")
 {
objRow[conCurrEduCls_Syn.TeacherNames] = objCurrEduCls_SynEN.TeacherNames; //教师姓名
 }
objRow[conCurrEduCls_Syn.IsSynch] = objCurrEduCls_SynEN.IsSynch; //是否同步
 if (objCurrEduCls_SynEN.SynchDate !=  "")
 {
objRow[conCurrEduCls_Syn.SynchDate] = objCurrEduCls_SynEN.SynchDate; //同步日期
 }
 if (objCurrEduCls_SynEN.ModifyDate !=  "")
 {
objRow[conCurrEduCls_Syn.ModifyDate] = objCurrEduCls_SynEN.ModifyDate; //修改日期
 }
 if (objCurrEduCls_SynEN.ModifyUserId !=  "")
 {
objRow[conCurrEduCls_Syn.ModifyUserId] = objCurrEduCls_SynEN.ModifyUserId; //修改人
 }
 if (objCurrEduCls_SynEN.Memo !=  "")
 {
objRow[conCurrEduCls_Syn.Memo] = objCurrEduCls_SynEN.Memo; //备注
 }
 if (objCurrEduCls_SynEN.SignInDate !=  "")
 {
objRow[conCurrEduCls_Syn.SignInDate] = objCurrEduCls_SynEN.SignInDate; //签入时间
 }
 if (objCurrEduCls_SynEN.SignInStateID !=  "")
 {
objRow[conCurrEduCls_Syn.SignInStateID] = objCurrEduCls_SynEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduCls_SynEN.SignInUser !=  "")
 {
objRow[conCurrEduCls_Syn.SignInUser] = objCurrEduCls_SynEN.SignInUser; //签入人
 }
 if (objCurrEduCls_SynEN.SynchToWebUser !=  "")
 {
objRow[conCurrEduCls_Syn.SynchToWebUser] = objCurrEduCls_SynEN.SynchToWebUser; //同步Web用户
 }
objRow[conCurrEduCls_Syn.IsSynchToWeb] = objCurrEduCls_SynEN.IsSynchToWeb; //是否同步Web
 if (objCurrEduCls_SynEN.SynchToWebDate !=  "")
 {
objRow[conCurrEduCls_Syn.SynchToWebDate] = objCurrEduCls_SynEN.SynchToWebDate; //同步Web日期
 }
objDS.Tables[clsCurrEduCls_SynEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCurrEduCls_SynEN._CurrTabName);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls_SynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduCls_SynEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls_SynEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsName);
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CourseId);
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdXzCollege);
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdMajor);
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduWay);
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekStatusId);
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CustomerWeek);
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExecPlan);
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Mark);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.Mark.ToString());
 }
 
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckTeacher);
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdUniZone);
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdGradeBase);
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolYear);
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolTerm);
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCourseType);
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExportDate);
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdScoreType);
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExamType);
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamTime);
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckDate);
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkWeekTime);
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkClassRooms);
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeacherNames);
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchDate);
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyDate);
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyUserId);
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Memo);
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInDate);
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInStateID);
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInUser);
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls_Syn");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls_SynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduCls_SynEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls_SynEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsName);
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CourseId);
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdXzCollege);
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdMajor);
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduWay);
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekStatusId);
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CustomerWeek);
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExecPlan);
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Mark);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.Mark.ToString());
 }
 
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckTeacher);
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdUniZone);
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdGradeBase);
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolYear);
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolTerm);
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCourseType);
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExportDate);
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdScoreType);
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExamType);
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamTime);
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckDate);
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkWeekTime);
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkClassRooms);
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeacherNames);
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchDate);
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyDate);
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyUserId);
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Memo);
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInDate);
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInStateID);
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInUser);
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls_Syn");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objCurrEduCls_SynEN.IdCurrEduCls;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCurrEduCls_SynEN objCurrEduCls_SynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls_SynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduCls_SynEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls_SynEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsName);
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CourseId);
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdXzCollege);
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdMajor);
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduWay);
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekStatusId);
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CustomerWeek);
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExecPlan);
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Mark);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.Mark.ToString());
 }
 
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckTeacher);
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdUniZone);
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdGradeBase);
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolYear);
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolTerm);
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCourseType);
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExportDate);
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdScoreType);
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExamType);
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamTime);
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckDate);
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkWeekTime);
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkClassRooms);
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeacherNames);
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchDate);
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyDate);
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyUserId);
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Memo);
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInDate);
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInStateID);
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInUser);
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls_Syn");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objCurrEduCls_SynEN.IdCurrEduCls;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCurrEduCls_SynEN objCurrEduCls_SynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCurrEduCls_SynEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objCurrEduCls_SynEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCurrEduCls);
 var strIdCurrEduCls = objCurrEduCls_SynEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrEduClsId);
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrEduClsId + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsName);
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsName + "'");
 }
 
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EduClsTypeId);
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEduClsTypeId + "'");
 }
 
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CourseId);
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeachingSolutionId);
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeachingSolutionId + "'");
 }
 
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdXzCollege);
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdXzCollege + "'");
 }
 
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdMajor);
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdMajor + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduWay);
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduWay + "'");
 }
 
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdClassRoomType);
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdClassRoomType + "'");
 }
 
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TotalLessonQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.TotalLessonQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MaxStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MaxStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CurrentStuQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.CurrentStuQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekQty);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.WeekQty.ToString());
 }
 
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ScheUnitPW);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ScheUnitPW.ToString());
 }
 
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.WeekStatusId);
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWeekStatusId + "'");
 }
 
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CustomerWeek);
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCustomerWeek + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsCompleteScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsCompleteScore  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExecPlan);
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExecPlan + "'");
 }
 
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.LessonQtyPerWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.LessonQtyPerWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Mark);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.Mark.ToString());
 }
 
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckClassRoom);
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckClassRoom + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckAdminCls);
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckAdminCls + "'");
 }
 
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckTeacher);
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckTeacher + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.EditLocked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.EditLocked  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Sched);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Sched  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdUniZone);
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdUniZone + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Locked);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.Locked  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdGradeBase);
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdGradeBase + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsEffective);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsEffective  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsForPaperReading);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsForPaperReading  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsUnDeterminedClsRm);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsUnDeterminedClsRm  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolYear);
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolYear + "'");
 }
 
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SchoolTerm);
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSchoolTerm + "'");
 }
 
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ArrangeCourseMemo);
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strArrangeCourseMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdCourseType);
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCourseType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExportDate);
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExportDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsDegree);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsDegree  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdScoreType);
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdScoreType + "'");
 }
 
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GetScoreWayId);
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGetScoreWayId + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsProportionalCtrl);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsProportionalCtrl  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdExamType);
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdExamType + "'");
 }
 
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamPortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.ExamPortion.ToString());
 }
 
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.MidExamScorePortion);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.MidExamScorePortion.ToString());
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsClearScore);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsClearScore  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsGeneratePwd);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsGeneratePwd  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.GeneratePwdDate);
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneratePwdDate + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGP);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGP  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsExportToGPWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsExportToGPWeb  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsReservedDecimal);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsReservedDecimal  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ExamTime);
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExamTime + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckState);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.CheckState  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.CheckDate);
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCheckDate + "'");
 }
 
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IdEduClassInPk);
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdEduClassInPk + "'");
 }
 
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkWeekTime);
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkWeekTime + "'");
 }
 
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.PkClassRooms);
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPkClassRooms + "'");
 }
 
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.BeginWeek);
 arrValueListForInsert.Add(objCurrEduCls_SynEN.BeginWeek.ToString());
 }
 
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.TeacherNames);
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTeacherNames + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynch);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynch  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchDate);
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyDate);
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyDate + "'");
 }
 
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.ModifyUserId);
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strModifyUserId + "'");
 }
 
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.Memo);
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInDate);
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInDate + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInStateID);
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInStateID + "'");
 }
 
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SignInUser);
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignInUser + "'");
 }
 
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebUser);
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebUser + "'");
 }
 
 arrFieldListForInsert.Add(conCurrEduCls_Syn.IsSynchToWeb);
 arrValueListForInsert.Add("'" + (objCurrEduCls_SynEN.IsSynchToWeb  ==  false ? "0" : "1") + "'");
 
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 arrFieldListForInsert.Add(conCurrEduCls_Syn.SynchToWebDate);
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToWebDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CurrEduCls_Syn");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCurrEduCls_Syns(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where IdCurrEduCls = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CurrEduCls_Syn");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdCurrEduCls = oRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim();
if (IsExist(strIdCurrEduCls))
{
 string strResult = "关键字变量值为:" + string.Format("IdCurrEduCls = {0}", strIdCurrEduCls) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCurrEduCls_SynEN._CurrTabName ].NewRow();
objRow[conCurrEduCls_Syn.IdCurrEduCls] = oRow[conCurrEduCls_Syn.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conCurrEduCls_Syn.CurrEduClsId] = oRow[conCurrEduCls_Syn.CurrEduClsId].ToString().Trim(); //教学班Id
objRow[conCurrEduCls_Syn.EduClsName] = oRow[conCurrEduCls_Syn.EduClsName].ToString().Trim(); //教学班名
objRow[conCurrEduCls_Syn.EduClsTypeId] = oRow[conCurrEduCls_Syn.EduClsTypeId].ToString().Trim(); //教学班类型Id
objRow[conCurrEduCls_Syn.CourseId] = oRow[conCurrEduCls_Syn.CourseId].ToString().Trim(); //课程Id
objRow[conCurrEduCls_Syn.TeachingSolutionId] = oRow[conCurrEduCls_Syn.TeachingSolutionId].ToString().Trim(); //教学方案Id
objRow[conCurrEduCls_Syn.IdXzCollege] = oRow[conCurrEduCls_Syn.IdXzCollege].ToString().Trim(); //学院流水号
objRow[conCurrEduCls_Syn.IdMajor] = oRow[conCurrEduCls_Syn.IdMajor].ToString().Trim(); //专业流水号
objRow[conCurrEduCls_Syn.IdEduWay] = oRow[conCurrEduCls_Syn.IdEduWay].ToString().Trim(); //教学方式流水号
objRow[conCurrEduCls_Syn.IdClassRoomType] = oRow[conCurrEduCls_Syn.IdClassRoomType].ToString().Trim(); //教室类型流水号
objRow[conCurrEduCls_Syn.TotalLessonQty] = oRow[conCurrEduCls_Syn.TotalLessonQty].ToString().Trim(); //总课时数
objRow[conCurrEduCls_Syn.MaxStuQty] = oRow[conCurrEduCls_Syn.MaxStuQty].ToString().Trim(); //最大学生数
objRow[conCurrEduCls_Syn.CurrentStuQty] = oRow[conCurrEduCls_Syn.CurrentStuQty].ToString().Trim(); //当前学生数
objRow[conCurrEduCls_Syn.WeekQty] = oRow[conCurrEduCls_Syn.WeekQty].ToString().Trim(); //总周数
objRow[conCurrEduCls_Syn.ScheUnitPW] = oRow[conCurrEduCls_Syn.ScheUnitPW].ToString().Trim(); //周排课次数
objRow[conCurrEduCls_Syn.WeekStatusId] = oRow[conCurrEduCls_Syn.WeekStatusId].ToString().Trim(); //周状态编号(单,双,全周)
objRow[conCurrEduCls_Syn.CustomerWeek] = oRow[conCurrEduCls_Syn.CustomerWeek].ToString().Trim(); //自定义上课周
objRow[conCurrEduCls_Syn.IsCompleteScore] = oRow[conCurrEduCls_Syn.IsCompleteScore].ToString().Trim(); //是否成绩齐全
objRow[conCurrEduCls_Syn.IdExecPlan] = oRow[conCurrEduCls_Syn.IdExecPlan].ToString().Trim(); //执行计划流水号
objRow[conCurrEduCls_Syn.LessonQtyPerWeek] = oRow[conCurrEduCls_Syn.LessonQtyPerWeek].ToString().Trim(); //周课时数
objRow[conCurrEduCls_Syn.Mark] = oRow[conCurrEduCls_Syn.Mark].ToString().Trim(); //获得学分
objRow[conCurrEduCls_Syn.CheckClassRoom] = oRow[conCurrEduCls_Syn.CheckClassRoom].ToString().Trim(); //检查教室结果
objRow[conCurrEduCls_Syn.CheckAdminCls] = oRow[conCurrEduCls_Syn.CheckAdminCls].ToString().Trim(); //检查行政班结果
objRow[conCurrEduCls_Syn.CheckTeacher] = oRow[conCurrEduCls_Syn.CheckTeacher].ToString().Trim(); //检查教师结果
objRow[conCurrEduCls_Syn.EditLocked] = oRow[conCurrEduCls_Syn.EditLocked].ToString().Trim(); //编辑锁定
objRow[conCurrEduCls_Syn.Sched] = oRow[conCurrEduCls_Syn.Sched].ToString().Trim(); //是否排课
objRow[conCurrEduCls_Syn.IdUniZone] = oRow[conCurrEduCls_Syn.IdUniZone].ToString().Trim(); //校区流水号
objRow[conCurrEduCls_Syn.Locked] = oRow[conCurrEduCls_Syn.Locked].ToString().Trim(); //锁定状态
objRow[conCurrEduCls_Syn.IdGradeBase] = oRow[conCurrEduCls_Syn.IdGradeBase].ToString().Trim(); //年级流水号
objRow[conCurrEduCls_Syn.IsEffective] = oRow[conCurrEduCls_Syn.IsEffective].ToString().Trim(); //是否有效
objRow[conCurrEduCls_Syn.IsForPaperReading] = oRow[conCurrEduCls_Syn.IsForPaperReading].ToString().Trim(); //是否参与论文阅读
objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm] = oRow[conCurrEduCls_Syn.IsUnDeterminedClsRm].ToString().Trim(); //是否待定教室
objRow[conCurrEduCls_Syn.SchoolYear] = oRow[conCurrEduCls_Syn.SchoolYear].ToString().Trim(); //学年
objRow[conCurrEduCls_Syn.SchoolTerm] = oRow[conCurrEduCls_Syn.SchoolTerm].ToString().Trim(); //学期
objRow[conCurrEduCls_Syn.ArrangeCourseMemo] = oRow[conCurrEduCls_Syn.ArrangeCourseMemo].ToString().Trim(); //排课备注
objRow[conCurrEduCls_Syn.IdCourseType] = oRow[conCurrEduCls_Syn.IdCourseType].ToString().Trim(); //课程类型流水号
objRow[conCurrEduCls_Syn.ExportDate] = oRow[conCurrEduCls_Syn.ExportDate].ToString().Trim(); //导出日期
objRow[conCurrEduCls_Syn.IsDegree] = oRow[conCurrEduCls_Syn.IsDegree].ToString().Trim(); //是否学位课
objRow[conCurrEduCls_Syn.IdScoreType] = oRow[conCurrEduCls_Syn.IdScoreType].ToString().Trim(); //成绩类型流水号
objRow[conCurrEduCls_Syn.GetScoreWayId] = oRow[conCurrEduCls_Syn.GetScoreWayId].ToString().Trim(); //获得成绩方式Id
objRow[conCurrEduCls_Syn.IsProportionalCtrl] = oRow[conCurrEduCls_Syn.IsProportionalCtrl].ToString().Trim(); //是否比例控制
objRow[conCurrEduCls_Syn.IdExamType] = oRow[conCurrEduCls_Syn.IdExamType].ToString().Trim(); //考试方式流水号
objRow[conCurrEduCls_Syn.ExamPortion] = oRow[conCurrEduCls_Syn.ExamPortion].ToString().Trim(); //平时成绩所占比例
objRow[conCurrEduCls_Syn.MidExamScorePortion] = oRow[conCurrEduCls_Syn.MidExamScorePortion].ToString().Trim(); //期末成绩所占比例
objRow[conCurrEduCls_Syn.IsClearScore] = oRow[conCurrEduCls_Syn.IsClearScore].ToString().Trim(); //是否重录成绩
objRow[conCurrEduCls_Syn.IsGeneratePwd] = oRow[conCurrEduCls_Syn.IsGeneratePwd].ToString().Trim(); //是否生成口令
objRow[conCurrEduCls_Syn.GeneratePwdDate] = oRow[conCurrEduCls_Syn.GeneratePwdDate].ToString().Trim(); //生成口令时间
objRow[conCurrEduCls_Syn.IsExportToGP] = oRow[conCurrEduCls_Syn.IsExportToGP].ToString().Trim(); //是否导出到平台
objRow[conCurrEduCls_Syn.IsExportToGPWeb] = oRow[conCurrEduCls_Syn.IsExportToGPWeb].ToString().Trim(); //是否导出到Web平台
objRow[conCurrEduCls_Syn.IsReservedDecimal] = oRow[conCurrEduCls_Syn.IsReservedDecimal].ToString().Trim(); //是否保留小数
objRow[conCurrEduCls_Syn.ExamTime] = oRow[conCurrEduCls_Syn.ExamTime].ToString().Trim(); //考试时间
objRow[conCurrEduCls_Syn.CheckState] = oRow[conCurrEduCls_Syn.CheckState].ToString().Trim(); //检查状态
objRow[conCurrEduCls_Syn.CheckDate] = oRow[conCurrEduCls_Syn.CheckDate].ToString().Trim(); //检查日期
objRow[conCurrEduCls_Syn.IdEduClassInPk] = oRow[conCurrEduCls_Syn.IdEduClassInPk].ToString().Trim(); //id_EduClassInPk
objRow[conCurrEduCls_Syn.PkWeekTime] = oRow[conCurrEduCls_Syn.PkWeekTime].ToString().Trim(); //排课时间
objRow[conCurrEduCls_Syn.PkClassRooms] = oRow[conCurrEduCls_Syn.PkClassRooms].ToString().Trim(); //排课教室
objRow[conCurrEduCls_Syn.BeginWeek] = oRow[conCurrEduCls_Syn.BeginWeek].ToString().Trim(); //开始周
objRow[conCurrEduCls_Syn.TeacherNames] = oRow[conCurrEduCls_Syn.TeacherNames].ToString().Trim(); //教师姓名
objRow[conCurrEduCls_Syn.IsSynch] = oRow[conCurrEduCls_Syn.IsSynch].ToString().Trim(); //是否同步
objRow[conCurrEduCls_Syn.SynchDate] = oRow[conCurrEduCls_Syn.SynchDate].ToString().Trim(); //同步日期
objRow[conCurrEduCls_Syn.ModifyDate] = oRow[conCurrEduCls_Syn.ModifyDate].ToString().Trim(); //修改日期
objRow[conCurrEduCls_Syn.ModifyUserId] = oRow[conCurrEduCls_Syn.ModifyUserId].ToString().Trim(); //修改人
objRow[conCurrEduCls_Syn.Memo] = oRow[conCurrEduCls_Syn.Memo].ToString().Trim(); //备注
objRow[conCurrEduCls_Syn.SignInDate] = oRow[conCurrEduCls_Syn.SignInDate].ToString().Trim(); //签入时间
objRow[conCurrEduCls_Syn.SignInStateID] = oRow[conCurrEduCls_Syn.SignInStateID].ToString().Trim(); //签入状态表流水号
objRow[conCurrEduCls_Syn.SignInUser] = oRow[conCurrEduCls_Syn.SignInUser].ToString().Trim(); //签入人
objRow[conCurrEduCls_Syn.SynchToWebUser] = oRow[conCurrEduCls_Syn.SynchToWebUser].ToString().Trim(); //同步Web用户
objRow[conCurrEduCls_Syn.IsSynchToWeb] = oRow[conCurrEduCls_Syn.IsSynchToWeb].ToString().Trim(); //是否同步Web
objRow[conCurrEduCls_Syn.SynchToWebDate] = oRow[conCurrEduCls_Syn.SynchToWebDate].ToString().Trim(); //同步Web日期
 objDS.Tables[clsCurrEduCls_SynEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCurrEduCls_SynEN._CurrTabName);
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
 /// <param name = "objCurrEduCls_SynEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls_SynEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
strSQL = "Select * from CurrEduCls_Syn where IdCurrEduCls = " + "'"+ objCurrEduCls_SynEN.IdCurrEduCls+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCurrEduCls_SynEN._CurrTabName);
if (objDS.Tables[clsCurrEduCls_SynEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdCurrEduCls = " + "'"+ objCurrEduCls_SynEN.IdCurrEduCls+"'");
return false;
}
objRow = objDS.Tables[clsCurrEduCls_SynEN._CurrTabName].Rows[0];
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCurrEduCls))
 {
objRow[conCurrEduCls_Syn.IdCurrEduCls] = objCurrEduCls_SynEN.IdCurrEduCls; //教学班流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrEduClsId))
 {
objRow[conCurrEduCls_Syn.CurrEduClsId] = objCurrEduCls_SynEN.CurrEduClsId; //教学班Id
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsName))
 {
objRow[conCurrEduCls_Syn.EduClsName] = objCurrEduCls_SynEN.EduClsName; //教学班名
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsTypeId))
 {
objRow[conCurrEduCls_Syn.EduClsTypeId] = objCurrEduCls_SynEN.EduClsTypeId; //教学班类型Id
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CourseId))
 {
objRow[conCurrEduCls_Syn.CourseId] = objCurrEduCls_SynEN.CourseId; //课程Id
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId))
 {
objRow[conCurrEduCls_Syn.TeachingSolutionId] = objCurrEduCls_SynEN.TeachingSolutionId; //教学方案Id
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdXzCollege))
 {
objRow[conCurrEduCls_Syn.IdXzCollege] = objCurrEduCls_SynEN.IdXzCollege; //学院流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdMajor))
 {
objRow[conCurrEduCls_Syn.IdMajor] = objCurrEduCls_SynEN.IdMajor; //专业流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduWay))
 {
objRow[conCurrEduCls_Syn.IdEduWay] = objCurrEduCls_SynEN.IdEduWay; //教学方式流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdClassRoomType))
 {
objRow[conCurrEduCls_Syn.IdClassRoomType] = objCurrEduCls_SynEN.IdClassRoomType; //教室类型流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TotalLessonQty))
 {
objRow[conCurrEduCls_Syn.TotalLessonQty] = objCurrEduCls_SynEN.TotalLessonQty; //总课时数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MaxStuQty))
 {
objRow[conCurrEduCls_Syn.MaxStuQty] = objCurrEduCls_SynEN.MaxStuQty; //最大学生数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrentStuQty))
 {
objRow[conCurrEduCls_Syn.CurrentStuQty] = objCurrEduCls_SynEN.CurrentStuQty; //当前学生数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekQty))
 {
objRow[conCurrEduCls_Syn.WeekQty] = objCurrEduCls_SynEN.WeekQty; //总周数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ScheUnitPW))
 {
objRow[conCurrEduCls_Syn.ScheUnitPW] = objCurrEduCls_SynEN.ScheUnitPW; //周排课次数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekStatusId))
 {
objRow[conCurrEduCls_Syn.WeekStatusId] = objCurrEduCls_SynEN.WeekStatusId; //周状态编号(单,双,全周)
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CustomerWeek))
 {
objRow[conCurrEduCls_Syn.CustomerWeek] = objCurrEduCls_SynEN.CustomerWeek; //自定义上课周
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsCompleteScore))
 {
objRow[conCurrEduCls_Syn.IsCompleteScore] = objCurrEduCls_SynEN.IsCompleteScore; //是否成绩齐全
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExecPlan))
 {
objRow[conCurrEduCls_Syn.IdExecPlan] = objCurrEduCls_SynEN.IdExecPlan; //执行计划流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.LessonQtyPerWeek))
 {
objRow[conCurrEduCls_Syn.LessonQtyPerWeek] = objCurrEduCls_SynEN.LessonQtyPerWeek; //周课时数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Mark))
 {
objRow[conCurrEduCls_Syn.Mark] = objCurrEduCls_SynEN.Mark; //获得学分
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckClassRoom))
 {
objRow[conCurrEduCls_Syn.CheckClassRoom] = objCurrEduCls_SynEN.CheckClassRoom; //检查教室结果
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckAdminCls))
 {
objRow[conCurrEduCls_Syn.CheckAdminCls] = objCurrEduCls_SynEN.CheckAdminCls; //检查行政班结果
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckTeacher))
 {
objRow[conCurrEduCls_Syn.CheckTeacher] = objCurrEduCls_SynEN.CheckTeacher; //检查教师结果
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EditLocked))
 {
objRow[conCurrEduCls_Syn.EditLocked] = objCurrEduCls_SynEN.EditLocked; //编辑锁定
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Sched))
 {
objRow[conCurrEduCls_Syn.Sched] = objCurrEduCls_SynEN.Sched; //是否排课
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdUniZone))
 {
objRow[conCurrEduCls_Syn.IdUniZone] = objCurrEduCls_SynEN.IdUniZone; //校区流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Locked))
 {
objRow[conCurrEduCls_Syn.Locked] = objCurrEduCls_SynEN.Locked; //锁定状态
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdGradeBase))
 {
objRow[conCurrEduCls_Syn.IdGradeBase] = objCurrEduCls_SynEN.IdGradeBase; //年级流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsEffective))
 {
objRow[conCurrEduCls_Syn.IsEffective] = objCurrEduCls_SynEN.IsEffective; //是否有效
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsForPaperReading))
 {
objRow[conCurrEduCls_Syn.IsForPaperReading] = objCurrEduCls_SynEN.IsForPaperReading; //是否参与论文阅读
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm))
 {
objRow[conCurrEduCls_Syn.IsUnDeterminedClsRm] = objCurrEduCls_SynEN.IsUnDeterminedClsRm; //是否待定教室
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolYear))
 {
objRow[conCurrEduCls_Syn.SchoolYear] = objCurrEduCls_SynEN.SchoolYear; //学年
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolTerm))
 {
objRow[conCurrEduCls_Syn.SchoolTerm] = objCurrEduCls_SynEN.SchoolTerm; //学期
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo))
 {
objRow[conCurrEduCls_Syn.ArrangeCourseMemo] = objCurrEduCls_SynEN.ArrangeCourseMemo; //排课备注
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCourseType))
 {
objRow[conCurrEduCls_Syn.IdCourseType] = objCurrEduCls_SynEN.IdCourseType; //课程类型流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExportDate))
 {
objRow[conCurrEduCls_Syn.ExportDate] = objCurrEduCls_SynEN.ExportDate; //导出日期
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsDegree))
 {
objRow[conCurrEduCls_Syn.IsDegree] = objCurrEduCls_SynEN.IsDegree; //是否学位课
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdScoreType))
 {
objRow[conCurrEduCls_Syn.IdScoreType] = objCurrEduCls_SynEN.IdScoreType; //成绩类型流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GetScoreWayId))
 {
objRow[conCurrEduCls_Syn.GetScoreWayId] = objCurrEduCls_SynEN.GetScoreWayId; //获得成绩方式Id
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl))
 {
objRow[conCurrEduCls_Syn.IsProportionalCtrl] = objCurrEduCls_SynEN.IsProportionalCtrl; //是否比例控制
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExamType))
 {
objRow[conCurrEduCls_Syn.IdExamType] = objCurrEduCls_SynEN.IdExamType; //考试方式流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamPortion))
 {
objRow[conCurrEduCls_Syn.ExamPortion] = objCurrEduCls_SynEN.ExamPortion; //平时成绩所占比例
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MidExamScorePortion))
 {
objRow[conCurrEduCls_Syn.MidExamScorePortion] = objCurrEduCls_SynEN.MidExamScorePortion; //期末成绩所占比例
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsClearScore))
 {
objRow[conCurrEduCls_Syn.IsClearScore] = objCurrEduCls_SynEN.IsClearScore; //是否重录成绩
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd))
 {
objRow[conCurrEduCls_Syn.IsGeneratePwd] = objCurrEduCls_SynEN.IsGeneratePwd; //是否生成口令
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate))
 {
objRow[conCurrEduCls_Syn.GeneratePwdDate] = objCurrEduCls_SynEN.GeneratePwdDate; //生成口令时间
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGP))
 {
objRow[conCurrEduCls_Syn.IsExportToGP] = objCurrEduCls_SynEN.IsExportToGP; //是否导出到平台
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb))
 {
objRow[conCurrEduCls_Syn.IsExportToGPWeb] = objCurrEduCls_SynEN.IsExportToGPWeb; //是否导出到Web平台
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal))
 {
objRow[conCurrEduCls_Syn.IsReservedDecimal] = objCurrEduCls_SynEN.IsReservedDecimal; //是否保留小数
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamTime))
 {
objRow[conCurrEduCls_Syn.ExamTime] = objCurrEduCls_SynEN.ExamTime; //考试时间
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckState))
 {
objRow[conCurrEduCls_Syn.CheckState] = objCurrEduCls_SynEN.CheckState; //检查状态
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckDate))
 {
objRow[conCurrEduCls_Syn.CheckDate] = objCurrEduCls_SynEN.CheckDate; //检查日期
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk))
 {
objRow[conCurrEduCls_Syn.IdEduClassInPk] = objCurrEduCls_SynEN.IdEduClassInPk; //id_EduClassInPk
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkWeekTime))
 {
objRow[conCurrEduCls_Syn.PkWeekTime] = objCurrEduCls_SynEN.PkWeekTime; //排课时间
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkClassRooms))
 {
objRow[conCurrEduCls_Syn.PkClassRooms] = objCurrEduCls_SynEN.PkClassRooms; //排课教室
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.BeginWeek))
 {
objRow[conCurrEduCls_Syn.BeginWeek] = objCurrEduCls_SynEN.BeginWeek; //开始周
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeacherNames))
 {
objRow[conCurrEduCls_Syn.TeacherNames] = objCurrEduCls_SynEN.TeacherNames; //教师姓名
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynch))
 {
objRow[conCurrEduCls_Syn.IsSynch] = objCurrEduCls_SynEN.IsSynch; //是否同步
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchDate))
 {
objRow[conCurrEduCls_Syn.SynchDate] = objCurrEduCls_SynEN.SynchDate; //同步日期
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyDate))
 {
objRow[conCurrEduCls_Syn.ModifyDate] = objCurrEduCls_SynEN.ModifyDate; //修改日期
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyUserId))
 {
objRow[conCurrEduCls_Syn.ModifyUserId] = objCurrEduCls_SynEN.ModifyUserId; //修改人
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Memo))
 {
objRow[conCurrEduCls_Syn.Memo] = objCurrEduCls_SynEN.Memo; //备注
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInDate))
 {
objRow[conCurrEduCls_Syn.SignInDate] = objCurrEduCls_SynEN.SignInDate; //签入时间
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInStateID))
 {
objRow[conCurrEduCls_Syn.SignInStateID] = objCurrEduCls_SynEN.SignInStateID; //签入状态表流水号
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInUser))
 {
objRow[conCurrEduCls_Syn.SignInUser] = objCurrEduCls_SynEN.SignInUser; //签入人
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebUser))
 {
objRow[conCurrEduCls_Syn.SynchToWebUser] = objCurrEduCls_SynEN.SynchToWebUser; //同步Web用户
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb))
 {
objRow[conCurrEduCls_Syn.IsSynchToWeb] = objCurrEduCls_SynEN.IsSynchToWeb; //是否同步Web
 }
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebDate))
 {
objRow[conCurrEduCls_Syn.SynchToWebDate] = objCurrEduCls_SynEN.SynchToWebDate; //同步Web日期
 }
try
{
objDA.Update(objDS, clsCurrEduCls_SynEN._CurrTabName);
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls_SynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CurrEduCls_Syn Set ");
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrEduClsId))
 {
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls_Syn.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsName))
 {
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls_Syn.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsTypeId))
 {
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls_Syn.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CourseId))
 {
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls_Syn.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CourseId); //课程Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId))
 {
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls_Syn.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdXzCollege))
 {
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls_Syn.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdMajor))
 {
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMajor, conCurrEduCls_Syn.IdMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdMajor); //专业流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduWay))
 {
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls_Syn.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdClassRoomType))
 {
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls_Syn.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TotalLessonQty))
 {
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.TotalLessonQty, conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MaxStuQty))
 {
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MaxStuQty, conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrentStuQty))
 {
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.CurrentStuQty, conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekQty))
 {
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.WeekQty, conCurrEduCls_Syn.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ScheUnitPW))
 {
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ScheUnitPW, conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekStatusId))
 {
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls_Syn.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CustomerWeek))
 {
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls_Syn.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsCompleteScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsCompleteScore == true?"1":"0", conCurrEduCls_Syn.IsCompleteScore); //是否成绩齐全
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExecPlan))
 {
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExecPlan, conCurrEduCls_Syn.IdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdExecPlan); //执行计划流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.LessonQtyPerWeek))
 {
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.LessonQtyPerWeek, conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Mark))
 {
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.Mark, conCurrEduCls_Syn.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckClassRoom))
 {
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckClassRoom, conCurrEduCls_Syn.CheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckClassRoom); //检查教室结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckAdminCls))
 {
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckAdminCls, conCurrEduCls_Syn.CheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckAdminCls); //检查行政班结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckTeacher))
 {
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTeacher, conCurrEduCls_Syn.CheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckTeacher); //检查教师结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EditLocked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.EditLocked == true?"1":"0", conCurrEduCls_Syn.EditLocked); //编辑锁定
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Sched))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.Sched == true?"1":"0", conCurrEduCls_Syn.Sched); //是否排课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdUniZone))
 {
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls_Syn.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Locked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.Locked == true?"1":"0", conCurrEduCls_Syn.Locked); //锁定状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdGradeBase))
 {
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls_Syn.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsEffective == true?"1":"0", conCurrEduCls_Syn.IsEffective); //是否有效
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsForPaperReading))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsForPaperReading == true?"1":"0", conCurrEduCls_Syn.IsForPaperReading); //是否参与论文阅读
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsUnDeterminedClsRm == true?"1":"0", conCurrEduCls_Syn.IsUnDeterminedClsRm); //是否待定教室
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolYear))
 {
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls_Syn.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SchoolYear); //学年
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolTerm))
 {
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls_Syn.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo))
 {
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrangeCourseMemo, conCurrEduCls_Syn.ArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ArrangeCourseMemo); //排课备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCourseType))
 {
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls_Syn.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExportDate))
 {
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduCls_Syn.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsDegree == true?"1":"0", conCurrEduCls_Syn.IsDegree); //是否学位课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdScoreType))
 {
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls_Syn.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GetScoreWayId))
 {
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls_Syn.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls_Syn.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExamType))
 {
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls_Syn.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamPortion))
 {
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ExamPortion, conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MidExamScorePortion))
 {
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MidExamScorePortion, conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsClearScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsClearScore == true?"1":"0", conCurrEduCls_Syn.IsClearScore); //是否重录成绩
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsGeneratePwd == true?"1":"0", conCurrEduCls_Syn.IsGeneratePwd); //是否生成口令
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate))
 {
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneratePwdDate, conCurrEduCls_Syn.GeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.GeneratePwdDate); //生成口令时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGP))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsExportToGP == true?"1":"0", conCurrEduCls_Syn.IsExportToGP); //是否导出到平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsExportToGPWeb == true?"1":"0", conCurrEduCls_Syn.IsExportToGPWeb); //是否导出到Web平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsReservedDecimal == true?"1":"0", conCurrEduCls_Syn.IsReservedDecimal); //是否保留小数
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamTime))
 {
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls_Syn.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.CheckState == true?"1":"0", conCurrEduCls_Syn.CheckState); //检查状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckDate))
 {
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conCurrEduCls_Syn.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckDate); //检查日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk))
 {
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduClassInPk, conCurrEduCls_Syn.IdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdEduClassInPk); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkWeekTime))
 {
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkWeekTime, conCurrEduCls_Syn.PkWeekTime); //排课时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.PkWeekTime); //排课时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkClassRooms))
 {
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkClassRooms, conCurrEduCls_Syn.PkClassRooms); //排课教室
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.PkClassRooms); //排课教室
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.BeginWeek))
 {
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.BeginWeek, conCurrEduCls_Syn.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeacherNames))
 {
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherNames, conCurrEduCls_Syn.TeacherNames); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TeacherNames); //教师姓名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsSynch == true?"1":"0", conCurrEduCls_Syn.IsSynch); //是否同步
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchDate))
 {
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conCurrEduCls_Syn.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchDate); //同步日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyDate))
 {
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls_Syn.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyUserId))
 {
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls_Syn.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Memo))
 {
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls_Syn.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Memo); //备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInDate))
 {
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduCls_Syn.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInStateID))
 {
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduCls_Syn.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInUser))
 {
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduCls_Syn.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInUser); //签入人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebUser))
 {
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebUser, conCurrEduCls_Syn.SynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchToWebUser); //同步Web用户
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsSynchToWeb == true?"1":"0", conCurrEduCls_Syn.IsSynchToWeb); //是否同步Web
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebDate))
 {
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebDate, conCurrEduCls_Syn.SynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchToWebDate); //同步Web日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}'", objCurrEduCls_SynEN.IdCurrEduCls); 
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCondition)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls_SynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls_Syn Set ");
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrEduClsId))
 {
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsName))
 {
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsTypeId))
 {
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CourseId))
 {
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId))
 {
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdXzCollege))
 {
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdMajor))
 {
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMajor = '{0}',", strIdMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdMajor = null,"); //专业流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduWay))
 {
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdClassRoomType))
 {
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TotalLessonQty))
 {
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.TotalLessonQty, conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MaxStuQty))
 {
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MaxStuQty, conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrentStuQty))
 {
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.CurrentStuQty, conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekQty))
 {
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.WeekQty, conCurrEduCls_Syn.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ScheUnitPW))
 {
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ScheUnitPW, conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekStatusId))
 {
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CustomerWeek))
 {
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsCompleteScore))
 {
 sbSQL.AppendFormat(" IsCompleteScore = '{0}',", objCurrEduCls_SynEN.IsCompleteScore == true?"1":"0"); //是否成绩齐全
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExecPlan))
 {
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExecPlan = '{0}',", strIdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.Append(" IdExecPlan = null,"); //执行计划流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.LessonQtyPerWeek))
 {
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.LessonQtyPerWeek, conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Mark))
 {
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.Mark, conCurrEduCls_Syn.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckClassRoom))
 {
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckClassRoom = '{0}',", strCheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.Append(" CheckClassRoom = null,"); //检查教室结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckAdminCls))
 {
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckAdminCls = '{0}',", strCheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.Append(" CheckAdminCls = null,"); //检查行政班结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckTeacher))
 {
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTeacher = '{0}',", strCheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.Append(" CheckTeacher = null,"); //检查教师结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EditLocked))
 {
 sbSQL.AppendFormat(" EditLocked = '{0}',", objCurrEduCls_SynEN.EditLocked == true?"1":"0"); //编辑锁定
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Sched))
 {
 sbSQL.AppendFormat(" Sched = '{0}',", objCurrEduCls_SynEN.Sched == true?"1":"0"); //是否排课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdUniZone))
 {
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Locked))
 {
 sbSQL.AppendFormat(" Locked = '{0}',", objCurrEduCls_SynEN.Locked == true?"1":"0"); //锁定状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdGradeBase))
 {
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduCls_SynEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsForPaperReading))
 {
 sbSQL.AppendFormat(" IsForPaperReading = '{0}',", objCurrEduCls_SynEN.IsForPaperReading == true?"1":"0"); //是否参与论文阅读
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" IsUnDeterminedClsRm = '{0}',", objCurrEduCls_SynEN.IsUnDeterminedClsRm == true?"1":"0"); //是否待定教室
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolYear))
 {
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolTerm))
 {
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo))
 {
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrangeCourseMemo = '{0}',", strArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.Append(" ArrangeCourseMemo = null,"); //排课备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCourseType))
 {
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExportDate))
 {
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduCls_SynEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdScoreType))
 {
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GetScoreWayId))
 {
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduCls_SynEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExamType))
 {
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamPortion))
 {
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ExamPortion, conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MidExamScorePortion))
 {
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MidExamScorePortion, conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsClearScore))
 {
 sbSQL.AppendFormat(" IsClearScore = '{0}',", objCurrEduCls_SynEN.IsClearScore == true?"1":"0"); //是否重录成绩
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" IsGeneratePwd = '{0}',", objCurrEduCls_SynEN.IsGeneratePwd == true?"1":"0"); //是否生成口令
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate))
 {
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneratePwdDate = '{0}',", strGeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.Append(" GeneratePwdDate = null,"); //生成口令时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGP))
 {
 sbSQL.AppendFormat(" IsExportToGP = '{0}',", objCurrEduCls_SynEN.IsExportToGP == true?"1":"0"); //是否导出到平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" IsExportToGPWeb = '{0}',", objCurrEduCls_SynEN.IsExportToGPWeb == true?"1":"0"); //是否导出到Web平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" IsReservedDecimal = '{0}',", objCurrEduCls_SynEN.IsReservedDecimal == true?"1":"0"); //是否保留小数
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamTime))
 {
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckState))
 {
 sbSQL.AppendFormat(" CheckState = '{0}',", objCurrEduCls_SynEN.CheckState == true?"1":"0"); //检查状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckDate))
 {
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk))
 {
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduClassInPk = '{0}',", strIdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.Append(" IdEduClassInPk = null,"); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkWeekTime))
 {
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkWeekTime = '{0}',", strPkWeekTime); //排课时间
 }
 else
 {
 sbSQL.Append(" PkWeekTime = null,"); //排课时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkClassRooms))
 {
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkClassRooms = '{0}',", strPkClassRooms); //排课教室
 }
 else
 {
 sbSQL.Append(" PkClassRooms = null,"); //排课教室
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.BeginWeek))
 {
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.BeginWeek, conCurrEduCls_Syn.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeacherNames))
 {
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherNames = '{0}',", strTeacherNames); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherNames = null,"); //教师姓名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objCurrEduCls_SynEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchDate))
 {
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyDate))
 {
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyUserId))
 {
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Memo))
 {
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInDate))
 {
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInStateID))
 {
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInUser))
 {
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebUser))
 {
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebUser = '{0}',", strSynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.Append(" SynchToWebUser = null,"); //同步Web用户
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" IsSynchToWeb = '{0}',", objCurrEduCls_SynEN.IsSynchToWeb == true?"1":"0"); //是否同步Web
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebDate))
 {
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebDate = '{0}',", strSynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.Append(" SynchToWebDate = null,"); //同步Web日期
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
 /// <param name = "objCurrEduCls_SynEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCurrEduCls_SynEN objCurrEduCls_SynEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls_SynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls_Syn Set ");
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrEduClsId))
 {
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrEduClsId = '{0}',", strCurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.Append(" CurrEduClsId = null,"); //教学班Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsName))
 {
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsName = '{0}',", strEduClsName); //教学班名
 }
 else
 {
 sbSQL.Append(" EduClsName = null,"); //教学班名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsTypeId))
 {
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EduClsTypeId = '{0}',", strEduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.Append(" EduClsTypeId = null,"); //教学班类型Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CourseId))
 {
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId))
 {
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeachingSolutionId = '{0}',", strTeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.Append(" TeachingSolutionId = null,"); //教学方案Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdXzCollege))
 {
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdXzCollege = '{0}',", strIdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.Append(" IdXzCollege = null,"); //学院流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdMajor))
 {
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdMajor = '{0}',", strIdMajor); //专业流水号
 }
 else
 {
 sbSQL.Append(" IdMajor = null,"); //专业流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduWay))
 {
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduWay = '{0}',", strIdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.Append(" IdEduWay = null,"); //教学方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdClassRoomType))
 {
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdClassRoomType = '{0}',", strIdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.Append(" IdClassRoomType = null,"); //教室类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TotalLessonQty))
 {
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.TotalLessonQty, conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MaxStuQty))
 {
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MaxStuQty, conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrentStuQty))
 {
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.CurrentStuQty, conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekQty))
 {
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.WeekQty, conCurrEduCls_Syn.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ScheUnitPW))
 {
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ScheUnitPW, conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekStatusId))
 {
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WeekStatusId = '{0}',", strWeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.Append(" WeekStatusId = null,"); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CustomerWeek))
 {
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CustomerWeek = '{0}',", strCustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.Append(" CustomerWeek = null,"); //自定义上课周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsCompleteScore))
 {
 sbSQL.AppendFormat(" IsCompleteScore = '{0}',", objCurrEduCls_SynEN.IsCompleteScore == true?"1":"0"); //是否成绩齐全
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExecPlan))
 {
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExecPlan = '{0}',", strIdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.Append(" IdExecPlan = null,"); //执行计划流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.LessonQtyPerWeek))
 {
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.LessonQtyPerWeek, conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Mark))
 {
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.Mark, conCurrEduCls_Syn.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckClassRoom))
 {
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckClassRoom = '{0}',", strCheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.Append(" CheckClassRoom = null,"); //检查教室结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckAdminCls))
 {
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckAdminCls = '{0}',", strCheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.Append(" CheckAdminCls = null,"); //检查行政班结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckTeacher))
 {
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckTeacher = '{0}',", strCheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.Append(" CheckTeacher = null,"); //检查教师结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EditLocked))
 {
 sbSQL.AppendFormat(" EditLocked = '{0}',", objCurrEduCls_SynEN.EditLocked == true?"1":"0"); //编辑锁定
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Sched))
 {
 sbSQL.AppendFormat(" Sched = '{0}',", objCurrEduCls_SynEN.Sched == true?"1":"0"); //是否排课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdUniZone))
 {
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdUniZone = '{0}',", strIdUniZone); //校区流水号
 }
 else
 {
 sbSQL.Append(" IdUniZone = null,"); //校区流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Locked))
 {
 sbSQL.AppendFormat(" Locked = '{0}',", objCurrEduCls_SynEN.Locked == true?"1":"0"); //锁定状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdGradeBase))
 {
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdGradeBase = '{0}',", strIdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.Append(" IdGradeBase = null,"); //年级流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsEffective))
 {
 sbSQL.AppendFormat(" IsEffective = '{0}',", objCurrEduCls_SynEN.IsEffective == true?"1":"0"); //是否有效
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsForPaperReading))
 {
 sbSQL.AppendFormat(" IsForPaperReading = '{0}',", objCurrEduCls_SynEN.IsForPaperReading == true?"1":"0"); //是否参与论文阅读
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" IsUnDeterminedClsRm = '{0}',", objCurrEduCls_SynEN.IsUnDeterminedClsRm == true?"1":"0"); //是否待定教室
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolYear))
 {
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolYear = '{0}',", strSchoolYear); //学年
 }
 else
 {
 sbSQL.Append(" SchoolYear = null,"); //学年
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolTerm))
 {
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SchoolTerm = '{0}',", strSchoolTerm); //学期
 }
 else
 {
 sbSQL.Append(" SchoolTerm = null,"); //学期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo))
 {
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ArrangeCourseMemo = '{0}',", strArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.Append(" ArrangeCourseMemo = null,"); //排课备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCourseType))
 {
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCourseType = '{0}',", strIdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.Append(" IdCourseType = null,"); //课程类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExportDate))
 {
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExportDate = '{0}',", strExportDate); //导出日期
 }
 else
 {
 sbSQL.Append(" ExportDate = null,"); //导出日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsDegree))
 {
 sbSQL.AppendFormat(" IsDegree = '{0}',", objCurrEduCls_SynEN.IsDegree == true?"1":"0"); //是否学位课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdScoreType))
 {
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdScoreType = '{0}',", strIdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.Append(" IdScoreType = null,"); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GetScoreWayId))
 {
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GetScoreWayId = '{0}',", strGetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.Append(" GetScoreWayId = null,"); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" IsProportionalCtrl = '{0}',", objCurrEduCls_SynEN.IsProportionalCtrl == true?"1":"0"); //是否比例控制
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExamType))
 {
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdExamType = '{0}',", strIdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.Append(" IdExamType = null,"); //考试方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamPortion))
 {
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ExamPortion, conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MidExamScorePortion))
 {
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MidExamScorePortion, conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsClearScore))
 {
 sbSQL.AppendFormat(" IsClearScore = '{0}',", objCurrEduCls_SynEN.IsClearScore == true?"1":"0"); //是否重录成绩
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" IsGeneratePwd = '{0}',", objCurrEduCls_SynEN.IsGeneratePwd == true?"1":"0"); //是否生成口令
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate))
 {
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneratePwdDate = '{0}',", strGeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.Append(" GeneratePwdDate = null,"); //生成口令时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGP))
 {
 sbSQL.AppendFormat(" IsExportToGP = '{0}',", objCurrEduCls_SynEN.IsExportToGP == true?"1":"0"); //是否导出到平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" IsExportToGPWeb = '{0}',", objCurrEduCls_SynEN.IsExportToGPWeb == true?"1":"0"); //是否导出到Web平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" IsReservedDecimal = '{0}',", objCurrEduCls_SynEN.IsReservedDecimal == true?"1":"0"); //是否保留小数
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamTime))
 {
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExamTime = '{0}',", strExamTime); //考试时间
 }
 else
 {
 sbSQL.Append(" ExamTime = null,"); //考试时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckState))
 {
 sbSQL.AppendFormat(" CheckState = '{0}',", objCurrEduCls_SynEN.CheckState == true?"1":"0"); //检查状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckDate))
 {
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CheckDate = '{0}',", strCheckDate); //检查日期
 }
 else
 {
 sbSQL.Append(" CheckDate = null,"); //检查日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk))
 {
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdEduClassInPk = '{0}',", strIdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.Append(" IdEduClassInPk = null,"); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkWeekTime))
 {
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkWeekTime = '{0}',", strPkWeekTime); //排课时间
 }
 else
 {
 sbSQL.Append(" PkWeekTime = null,"); //排课时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkClassRooms))
 {
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PkClassRooms = '{0}',", strPkClassRooms); //排课教室
 }
 else
 {
 sbSQL.Append(" PkClassRooms = null,"); //排课教室
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.BeginWeek))
 {
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.BeginWeek, conCurrEduCls_Syn.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeacherNames))
 {
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TeacherNames = '{0}',", strTeacherNames); //教师姓名
 }
 else
 {
 sbSQL.Append(" TeacherNames = null,"); //教师姓名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynch))
 {
 sbSQL.AppendFormat(" IsSynch = '{0}',", objCurrEduCls_SynEN.IsSynch == true?"1":"0"); //是否同步
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchDate))
 {
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchDate = '{0}',", strSynchDate); //同步日期
 }
 else
 {
 sbSQL.Append(" SynchDate = null,"); //同步日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyDate))
 {
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyDate = '{0}',", strModifyDate); //修改日期
 }
 else
 {
 sbSQL.Append(" ModifyDate = null,"); //修改日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyUserId))
 {
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ModifyUserId = '{0}',", strModifyUserId); //修改人
 }
 else
 {
 sbSQL.Append(" ModifyUserId = null,"); //修改人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Memo))
 {
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInDate))
 {
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInDate = '{0}',", strSignInDate); //签入时间
 }
 else
 {
 sbSQL.Append(" SignInDate = null,"); //签入时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInStateID))
 {
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInStateID = '{0}',", strSignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.Append(" SignInStateID = null,"); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInUser))
 {
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SignInUser = '{0}',", strSignInUser); //签入人
 }
 else
 {
 sbSQL.Append(" SignInUser = null,"); //签入人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebUser))
 {
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebUser = '{0}',", strSynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.Append(" SynchToWebUser = null,"); //同步Web用户
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" IsSynchToWeb = '{0}',", objCurrEduCls_SynEN.IsSynchToWeb == true?"1":"0"); //是否同步Web
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebDate))
 {
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToWebDate = '{0}',", strSynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.Append(" SynchToWebDate = null,"); //同步Web日期
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
 /// <param name = "objCurrEduCls_SynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCurrEduCls_SynEN objCurrEduCls_SynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCurrEduCls_SynEN.ModifyDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCurrEduCls_SynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCurrEduCls_SynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CurrEduCls_Syn Set ");
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrEduClsId))
 {
 if (objCurrEduCls_SynEN.CurrEduClsId !=  null)
 {
 var strCurrEduClsId = objCurrEduCls_SynEN.CurrEduClsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrEduClsId, conCurrEduCls_Syn.CurrEduClsId); //教学班Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrEduClsId); //教学班Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsName))
 {
 if (objCurrEduCls_SynEN.EduClsName !=  null)
 {
 var strEduClsName = objCurrEduCls_SynEN.EduClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsName, conCurrEduCls_Syn.EduClsName); //教学班名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.EduClsName); //教学班名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EduClsTypeId))
 {
 if (objCurrEduCls_SynEN.EduClsTypeId !=  null)
 {
 var strEduClsTypeId = objCurrEduCls_SynEN.EduClsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEduClsTypeId, conCurrEduCls_Syn.EduClsTypeId); //教学班类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.EduClsTypeId); //教学班类型Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CourseId))
 {
 if (objCurrEduCls_SynEN.CourseId  ==  "")
 {
 objCurrEduCls_SynEN.CourseId = null;
 }
 if (objCurrEduCls_SynEN.CourseId !=  null)
 {
 var strCourseId = objCurrEduCls_SynEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conCurrEduCls_Syn.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CourseId); //课程Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeachingSolutionId))
 {
 if (objCurrEduCls_SynEN.TeachingSolutionId !=  null)
 {
 var strTeachingSolutionId = objCurrEduCls_SynEN.TeachingSolutionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeachingSolutionId, conCurrEduCls_Syn.TeachingSolutionId); //教学方案Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TeachingSolutionId); //教学方案Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdXzCollege))
 {
 if (objCurrEduCls_SynEN.IdXzCollege !=  null)
 {
 var strIdXzCollege = objCurrEduCls_SynEN.IdXzCollege.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdXzCollege, conCurrEduCls_Syn.IdXzCollege); //学院流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdXzCollege); //学院流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdMajor))
 {
 if (objCurrEduCls_SynEN.IdMajor !=  null)
 {
 var strIdMajor = objCurrEduCls_SynEN.IdMajor.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdMajor, conCurrEduCls_Syn.IdMajor); //专业流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdMajor); //专业流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduWay))
 {
 if (objCurrEduCls_SynEN.IdEduWay  ==  "")
 {
 objCurrEduCls_SynEN.IdEduWay = null;
 }
 if (objCurrEduCls_SynEN.IdEduWay !=  null)
 {
 var strIdEduWay = objCurrEduCls_SynEN.IdEduWay.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduWay, conCurrEduCls_Syn.IdEduWay); //教学方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdEduWay); //教学方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdClassRoomType))
 {
 if (objCurrEduCls_SynEN.IdClassRoomType  ==  "")
 {
 objCurrEduCls_SynEN.IdClassRoomType = null;
 }
 if (objCurrEduCls_SynEN.IdClassRoomType !=  null)
 {
 var strIdClassRoomType = objCurrEduCls_SynEN.IdClassRoomType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdClassRoomType, conCurrEduCls_Syn.IdClassRoomType); //教室类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdClassRoomType); //教室类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TotalLessonQty))
 {
 if (objCurrEduCls_SynEN.TotalLessonQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.TotalLessonQty, conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TotalLessonQty); //总课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MaxStuQty))
 {
 if (objCurrEduCls_SynEN.MaxStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MaxStuQty, conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MaxStuQty); //最大学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CurrentStuQty))
 {
 if (objCurrEduCls_SynEN.CurrentStuQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.CurrentStuQty, conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CurrentStuQty); //当前学生数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekQty))
 {
 if (objCurrEduCls_SynEN.WeekQty !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.WeekQty, conCurrEduCls_Syn.WeekQty); //总周数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekQty); //总周数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ScheUnitPW))
 {
 if (objCurrEduCls_SynEN.ScheUnitPW !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ScheUnitPW, conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ScheUnitPW); //周排课次数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.WeekStatusId))
 {
 if (objCurrEduCls_SynEN.WeekStatusId  ==  "")
 {
 objCurrEduCls_SynEN.WeekStatusId = null;
 }
 if (objCurrEduCls_SynEN.WeekStatusId !=  null)
 {
 var strWeekStatusId = objCurrEduCls_SynEN.WeekStatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWeekStatusId, conCurrEduCls_Syn.WeekStatusId); //周状态编号(单,双,全周)
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.WeekStatusId); //周状态编号(单,双,全周)
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CustomerWeek))
 {
 if (objCurrEduCls_SynEN.CustomerWeek !=  null)
 {
 var strCustomerWeek = objCurrEduCls_SynEN.CustomerWeek.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCustomerWeek, conCurrEduCls_Syn.CustomerWeek); //自定义上课周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CustomerWeek); //自定义上课周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsCompleteScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsCompleteScore == true?"1":"0", conCurrEduCls_Syn.IsCompleteScore); //是否成绩齐全
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExecPlan))
 {
 if (objCurrEduCls_SynEN.IdExecPlan !=  null)
 {
 var strIdExecPlan = objCurrEduCls_SynEN.IdExecPlan.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExecPlan, conCurrEduCls_Syn.IdExecPlan); //执行计划流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdExecPlan); //执行计划流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.LessonQtyPerWeek))
 {
 if (objCurrEduCls_SynEN.LessonQtyPerWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.LessonQtyPerWeek, conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.LessonQtyPerWeek); //周课时数
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Mark))
 {
 if (objCurrEduCls_SynEN.Mark !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.Mark, conCurrEduCls_Syn.Mark); //获得学分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Mark); //获得学分
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckClassRoom))
 {
 if (objCurrEduCls_SynEN.CheckClassRoom !=  null)
 {
 var strCheckClassRoom = objCurrEduCls_SynEN.CheckClassRoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckClassRoom, conCurrEduCls_Syn.CheckClassRoom); //检查教室结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckClassRoom); //检查教室结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckAdminCls))
 {
 if (objCurrEduCls_SynEN.CheckAdminCls !=  null)
 {
 var strCheckAdminCls = objCurrEduCls_SynEN.CheckAdminCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckAdminCls, conCurrEduCls_Syn.CheckAdminCls); //检查行政班结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckAdminCls); //检查行政班结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckTeacher))
 {
 if (objCurrEduCls_SynEN.CheckTeacher !=  null)
 {
 var strCheckTeacher = objCurrEduCls_SynEN.CheckTeacher.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckTeacher, conCurrEduCls_Syn.CheckTeacher); //检查教师结果
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckTeacher); //检查教师结果
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.EditLocked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.EditLocked == true?"1":"0", conCurrEduCls_Syn.EditLocked); //编辑锁定
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Sched))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.Sched == true?"1":"0", conCurrEduCls_Syn.Sched); //是否排课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdUniZone))
 {
 if (objCurrEduCls_SynEN.IdUniZone  ==  "")
 {
 objCurrEduCls_SynEN.IdUniZone = null;
 }
 if (objCurrEduCls_SynEN.IdUniZone !=  null)
 {
 var strIdUniZone = objCurrEduCls_SynEN.IdUniZone.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdUniZone, conCurrEduCls_Syn.IdUniZone); //校区流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdUniZone); //校区流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Locked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.Locked == true?"1":"0", conCurrEduCls_Syn.Locked); //锁定状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdGradeBase))
 {
 if (objCurrEduCls_SynEN.IdGradeBase  ==  "")
 {
 objCurrEduCls_SynEN.IdGradeBase = null;
 }
 if (objCurrEduCls_SynEN.IdGradeBase !=  null)
 {
 var strIdGradeBase = objCurrEduCls_SynEN.IdGradeBase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdGradeBase, conCurrEduCls_Syn.IdGradeBase); //年级流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdGradeBase); //年级流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsEffective))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsEffective == true?"1":"0", conCurrEduCls_Syn.IsEffective); //是否有效
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsForPaperReading))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsForPaperReading == true?"1":"0", conCurrEduCls_Syn.IsForPaperReading); //是否参与论文阅读
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsUnDeterminedClsRm))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsUnDeterminedClsRm == true?"1":"0", conCurrEduCls_Syn.IsUnDeterminedClsRm); //是否待定教室
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolYear))
 {
 if (objCurrEduCls_SynEN.SchoolYear !=  null)
 {
 var strSchoolYear = objCurrEduCls_SynEN.SchoolYear.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolYear, conCurrEduCls_Syn.SchoolYear); //学年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SchoolYear); //学年
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SchoolTerm))
 {
 if (objCurrEduCls_SynEN.SchoolTerm !=  null)
 {
 var strSchoolTerm = objCurrEduCls_SynEN.SchoolTerm.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSchoolTerm, conCurrEduCls_Syn.SchoolTerm); //学期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SchoolTerm); //学期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ArrangeCourseMemo))
 {
 if (objCurrEduCls_SynEN.ArrangeCourseMemo !=  null)
 {
 var strArrangeCourseMemo = objCurrEduCls_SynEN.ArrangeCourseMemo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strArrangeCourseMemo, conCurrEduCls_Syn.ArrangeCourseMemo); //排课备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ArrangeCourseMemo); //排课备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdCourseType))
 {
 if (objCurrEduCls_SynEN.IdCourseType !=  null)
 {
 var strIdCourseType = objCurrEduCls_SynEN.IdCourseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCourseType, conCurrEduCls_Syn.IdCourseType); //课程类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdCourseType); //课程类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExportDate))
 {
 if (objCurrEduCls_SynEN.ExportDate !=  null)
 {
 var strExportDate = objCurrEduCls_SynEN.ExportDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExportDate, conCurrEduCls_Syn.ExportDate); //导出日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExportDate); //导出日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsDegree))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsDegree == true?"1":"0", conCurrEduCls_Syn.IsDegree); //是否学位课
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdScoreType))
 {
 if (objCurrEduCls_SynEN.IdScoreType !=  null)
 {
 var strIdScoreType = objCurrEduCls_SynEN.IdScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdScoreType, conCurrEduCls_Syn.IdScoreType); //成绩类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdScoreType); //成绩类型流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GetScoreWayId))
 {
 if (objCurrEduCls_SynEN.GetScoreWayId !=  null)
 {
 var strGetScoreWayId = objCurrEduCls_SynEN.GetScoreWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGetScoreWayId, conCurrEduCls_Syn.GetScoreWayId); //获得成绩方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.GetScoreWayId); //获得成绩方式Id
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsProportionalCtrl))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsProportionalCtrl == true?"1":"0", conCurrEduCls_Syn.IsProportionalCtrl); //是否比例控制
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdExamType))
 {
 if (objCurrEduCls_SynEN.IdExamType !=  null)
 {
 var strIdExamType = objCurrEduCls_SynEN.IdExamType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdExamType, conCurrEduCls_Syn.IdExamType); //考试方式流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdExamType); //考试方式流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamPortion))
 {
 if (objCurrEduCls_SynEN.ExamPortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.ExamPortion, conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamPortion); //平时成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.MidExamScorePortion))
 {
 if (objCurrEduCls_SynEN.MidExamScorePortion !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.MidExamScorePortion, conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.MidExamScorePortion); //期末成绩所占比例
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsClearScore))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsClearScore == true?"1":"0", conCurrEduCls_Syn.IsClearScore); //是否重录成绩
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsGeneratePwd))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsGeneratePwd == true?"1":"0", conCurrEduCls_Syn.IsGeneratePwd); //是否生成口令
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.GeneratePwdDate))
 {
 if (objCurrEduCls_SynEN.GeneratePwdDate !=  null)
 {
 var strGeneratePwdDate = objCurrEduCls_SynEN.GeneratePwdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneratePwdDate, conCurrEduCls_Syn.GeneratePwdDate); //生成口令时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.GeneratePwdDate); //生成口令时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGP))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsExportToGP == true?"1":"0", conCurrEduCls_Syn.IsExportToGP); //是否导出到平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsExportToGPWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsExportToGPWeb == true?"1":"0", conCurrEduCls_Syn.IsExportToGPWeb); //是否导出到Web平台
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsReservedDecimal))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsReservedDecimal == true?"1":"0", conCurrEduCls_Syn.IsReservedDecimal); //是否保留小数
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ExamTime))
 {
 if (objCurrEduCls_SynEN.ExamTime !=  null)
 {
 var strExamTime = objCurrEduCls_SynEN.ExamTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExamTime, conCurrEduCls_Syn.ExamTime); //考试时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ExamTime); //考试时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckState))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.CheckState == true?"1":"0", conCurrEduCls_Syn.CheckState); //检查状态
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.CheckDate))
 {
 if (objCurrEduCls_SynEN.CheckDate !=  null)
 {
 var strCheckDate = objCurrEduCls_SynEN.CheckDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCheckDate, conCurrEduCls_Syn.CheckDate); //检查日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.CheckDate); //检查日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IdEduClassInPk))
 {
 if (objCurrEduCls_SynEN.IdEduClassInPk !=  null)
 {
 var strIdEduClassInPk = objCurrEduCls_SynEN.IdEduClassInPk.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdEduClassInPk, conCurrEduCls_Syn.IdEduClassInPk); //id_EduClassInPk
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.IdEduClassInPk); //id_EduClassInPk
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkWeekTime))
 {
 if (objCurrEduCls_SynEN.PkWeekTime !=  null)
 {
 var strPkWeekTime = objCurrEduCls_SynEN.PkWeekTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkWeekTime, conCurrEduCls_Syn.PkWeekTime); //排课时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.PkWeekTime); //排课时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.PkClassRooms))
 {
 if (objCurrEduCls_SynEN.PkClassRooms !=  null)
 {
 var strPkClassRooms = objCurrEduCls_SynEN.PkClassRooms.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPkClassRooms, conCurrEduCls_Syn.PkClassRooms); //排课教室
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.PkClassRooms); //排课教室
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.BeginWeek))
 {
 if (objCurrEduCls_SynEN.BeginWeek !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objCurrEduCls_SynEN.BeginWeek, conCurrEduCls_Syn.BeginWeek); //开始周
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.BeginWeek); //开始周
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.TeacherNames))
 {
 if (objCurrEduCls_SynEN.TeacherNames !=  null)
 {
 var strTeacherNames = objCurrEduCls_SynEN.TeacherNames.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTeacherNames, conCurrEduCls_Syn.TeacherNames); //教师姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.TeacherNames); //教师姓名
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynch))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsSynch == true?"1":"0", conCurrEduCls_Syn.IsSynch); //是否同步
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchDate))
 {
 if (objCurrEduCls_SynEN.SynchDate !=  null)
 {
 var strSynchDate = objCurrEduCls_SynEN.SynchDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchDate, conCurrEduCls_Syn.SynchDate); //同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchDate); //同步日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyDate))
 {
 if (objCurrEduCls_SynEN.ModifyDate !=  null)
 {
 var strModifyDate = objCurrEduCls_SynEN.ModifyDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyDate, conCurrEduCls_Syn.ModifyDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ModifyDate); //修改日期
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.ModifyUserId))
 {
 if (objCurrEduCls_SynEN.ModifyUserId !=  null)
 {
 var strModifyUserId = objCurrEduCls_SynEN.ModifyUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strModifyUserId, conCurrEduCls_Syn.ModifyUserId); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.ModifyUserId); //修改人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.Memo))
 {
 if (objCurrEduCls_SynEN.Memo !=  null)
 {
 var strMemo = objCurrEduCls_SynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCurrEduCls_Syn.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.Memo); //备注
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInDate))
 {
 if (objCurrEduCls_SynEN.SignInDate !=  null)
 {
 var strSignInDate = objCurrEduCls_SynEN.SignInDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInDate, conCurrEduCls_Syn.SignInDate); //签入时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInDate); //签入时间
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInStateID))
 {
 if (objCurrEduCls_SynEN.SignInStateID !=  null)
 {
 var strSignInStateID = objCurrEduCls_SynEN.SignInStateID.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInStateID, conCurrEduCls_Syn.SignInStateID); //签入状态表流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInStateID); //签入状态表流水号
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SignInUser))
 {
 if (objCurrEduCls_SynEN.SignInUser !=  null)
 {
 var strSignInUser = objCurrEduCls_SynEN.SignInUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignInUser, conCurrEduCls_Syn.SignInUser); //签入人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SignInUser); //签入人
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebUser))
 {
 if (objCurrEduCls_SynEN.SynchToWebUser !=  null)
 {
 var strSynchToWebUser = objCurrEduCls_SynEN.SynchToWebUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebUser, conCurrEduCls_Syn.SynchToWebUser); //同步Web用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchToWebUser); //同步Web用户
 }
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.IsSynchToWeb))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCurrEduCls_SynEN.IsSynchToWeb == true?"1":"0", conCurrEduCls_Syn.IsSynchToWeb); //是否同步Web
 }
 
 if (objCurrEduCls_SynEN.IsUpdated(conCurrEduCls_Syn.SynchToWebDate))
 {
 if (objCurrEduCls_SynEN.SynchToWebDate !=  null)
 {
 var strSynchToWebDate = objCurrEduCls_SynEN.SynchToWebDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToWebDate, conCurrEduCls_Syn.SynchToWebDate); //同步Web日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCurrEduCls_Syn.SynchToWebDate); //同步Web日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdCurrEduCls = '{0}'", objCurrEduCls_SynEN.IdCurrEduCls); 
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
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdCurrEduCls) 
{
CheckPrimaryKey(strIdCurrEduCls);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdCurrEduCls,
};
 objSQL.ExecSP("CurrEduCls_Syn_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdCurrEduCls, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdCurrEduCls);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
//删除CurrEduCls_Syn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls_Syn where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCurrEduCls_Syn(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
//删除CurrEduCls_Syn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls_Syn where IdCurrEduCls in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdCurrEduCls) 
{
CheckPrimaryKey(strIdCurrEduCls);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
//删除CurrEduCls_Syn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CurrEduCls_Syn where IdCurrEduCls = " + "'"+ strIdCurrEduCls+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCurrEduCls_Syn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: DelCurrEduCls_Syn)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls_Syn where " + strCondition ;
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
public bool DelCurrEduCls_SynWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCurrEduCls_SynDA: DelCurrEduCls_SynWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CurrEduCls_Syn where " + strCondition ;
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
 /// <param name = "objCurrEduCls_SynENS">源对象</param>
 /// <param name = "objCurrEduCls_SynENT">目标对象</param>
public void CopyTo(clsCurrEduCls_SynEN objCurrEduCls_SynENS, clsCurrEduCls_SynEN objCurrEduCls_SynENT)
{
objCurrEduCls_SynENT.IdCurrEduCls = objCurrEduCls_SynENS.IdCurrEduCls; //教学班流水号
objCurrEduCls_SynENT.CurrEduClsId = objCurrEduCls_SynENS.CurrEduClsId; //教学班Id
objCurrEduCls_SynENT.EduClsName = objCurrEduCls_SynENS.EduClsName; //教学班名
objCurrEduCls_SynENT.EduClsTypeId = objCurrEduCls_SynENS.EduClsTypeId; //教学班类型Id
objCurrEduCls_SynENT.CourseId = objCurrEduCls_SynENS.CourseId; //课程Id
objCurrEduCls_SynENT.TeachingSolutionId = objCurrEduCls_SynENS.TeachingSolutionId; //教学方案Id
objCurrEduCls_SynENT.IdXzCollege = objCurrEduCls_SynENS.IdXzCollege; //学院流水号
objCurrEduCls_SynENT.IdMajor = objCurrEduCls_SynENS.IdMajor; //专业流水号
objCurrEduCls_SynENT.IdEduWay = objCurrEduCls_SynENS.IdEduWay; //教学方式流水号
objCurrEduCls_SynENT.IdClassRoomType = objCurrEduCls_SynENS.IdClassRoomType; //教室类型流水号
objCurrEduCls_SynENT.TotalLessonQty = objCurrEduCls_SynENS.TotalLessonQty; //总课时数
objCurrEduCls_SynENT.MaxStuQty = objCurrEduCls_SynENS.MaxStuQty; //最大学生数
objCurrEduCls_SynENT.CurrentStuQty = objCurrEduCls_SynENS.CurrentStuQty; //当前学生数
objCurrEduCls_SynENT.WeekQty = objCurrEduCls_SynENS.WeekQty; //总周数
objCurrEduCls_SynENT.ScheUnitPW = objCurrEduCls_SynENS.ScheUnitPW; //周排课次数
objCurrEduCls_SynENT.WeekStatusId = objCurrEduCls_SynENS.WeekStatusId; //周状态编号(单,双,全周)
objCurrEduCls_SynENT.CustomerWeek = objCurrEduCls_SynENS.CustomerWeek; //自定义上课周
objCurrEduCls_SynENT.IsCompleteScore = objCurrEduCls_SynENS.IsCompleteScore; //是否成绩齐全
objCurrEduCls_SynENT.IdExecPlan = objCurrEduCls_SynENS.IdExecPlan; //执行计划流水号
objCurrEduCls_SynENT.LessonQtyPerWeek = objCurrEduCls_SynENS.LessonQtyPerWeek; //周课时数
objCurrEduCls_SynENT.Mark = objCurrEduCls_SynENS.Mark; //获得学分
objCurrEduCls_SynENT.CheckClassRoom = objCurrEduCls_SynENS.CheckClassRoom; //检查教室结果
objCurrEduCls_SynENT.CheckAdminCls = objCurrEduCls_SynENS.CheckAdminCls; //检查行政班结果
objCurrEduCls_SynENT.CheckTeacher = objCurrEduCls_SynENS.CheckTeacher; //检查教师结果
objCurrEduCls_SynENT.EditLocked = objCurrEduCls_SynENS.EditLocked; //编辑锁定
objCurrEduCls_SynENT.Sched = objCurrEduCls_SynENS.Sched; //是否排课
objCurrEduCls_SynENT.IdUniZone = objCurrEduCls_SynENS.IdUniZone; //校区流水号
objCurrEduCls_SynENT.Locked = objCurrEduCls_SynENS.Locked; //锁定状态
objCurrEduCls_SynENT.IdGradeBase = objCurrEduCls_SynENS.IdGradeBase; //年级流水号
objCurrEduCls_SynENT.IsEffective = objCurrEduCls_SynENS.IsEffective; //是否有效
objCurrEduCls_SynENT.IsForPaperReading = objCurrEduCls_SynENS.IsForPaperReading; //是否参与论文阅读
objCurrEduCls_SynENT.IsUnDeterminedClsRm = objCurrEduCls_SynENS.IsUnDeterminedClsRm; //是否待定教室
objCurrEduCls_SynENT.SchoolYear = objCurrEduCls_SynENS.SchoolYear; //学年
objCurrEduCls_SynENT.SchoolTerm = objCurrEduCls_SynENS.SchoolTerm; //学期
objCurrEduCls_SynENT.ArrangeCourseMemo = objCurrEduCls_SynENS.ArrangeCourseMemo; //排课备注
objCurrEduCls_SynENT.IdCourseType = objCurrEduCls_SynENS.IdCourseType; //课程类型流水号
objCurrEduCls_SynENT.ExportDate = objCurrEduCls_SynENS.ExportDate; //导出日期
objCurrEduCls_SynENT.IsDegree = objCurrEduCls_SynENS.IsDegree; //是否学位课
objCurrEduCls_SynENT.IdScoreType = objCurrEduCls_SynENS.IdScoreType; //成绩类型流水号
objCurrEduCls_SynENT.GetScoreWayId = objCurrEduCls_SynENS.GetScoreWayId; //获得成绩方式Id
objCurrEduCls_SynENT.IsProportionalCtrl = objCurrEduCls_SynENS.IsProportionalCtrl; //是否比例控制
objCurrEduCls_SynENT.IdExamType = objCurrEduCls_SynENS.IdExamType; //考试方式流水号
objCurrEduCls_SynENT.ExamPortion = objCurrEduCls_SynENS.ExamPortion; //平时成绩所占比例
objCurrEduCls_SynENT.MidExamScorePortion = objCurrEduCls_SynENS.MidExamScorePortion; //期末成绩所占比例
objCurrEduCls_SynENT.IsClearScore = objCurrEduCls_SynENS.IsClearScore; //是否重录成绩
objCurrEduCls_SynENT.IsGeneratePwd = objCurrEduCls_SynENS.IsGeneratePwd; //是否生成口令
objCurrEduCls_SynENT.GeneratePwdDate = objCurrEduCls_SynENS.GeneratePwdDate; //生成口令时间
objCurrEduCls_SynENT.IsExportToGP = objCurrEduCls_SynENS.IsExportToGP; //是否导出到平台
objCurrEduCls_SynENT.IsExportToGPWeb = objCurrEduCls_SynENS.IsExportToGPWeb; //是否导出到Web平台
objCurrEduCls_SynENT.IsReservedDecimal = objCurrEduCls_SynENS.IsReservedDecimal; //是否保留小数
objCurrEduCls_SynENT.ExamTime = objCurrEduCls_SynENS.ExamTime; //考试时间
objCurrEduCls_SynENT.CheckState = objCurrEduCls_SynENS.CheckState; //检查状态
objCurrEduCls_SynENT.CheckDate = objCurrEduCls_SynENS.CheckDate; //检查日期
objCurrEduCls_SynENT.IdEduClassInPk = objCurrEduCls_SynENS.IdEduClassInPk; //id_EduClassInPk
objCurrEduCls_SynENT.PkWeekTime = objCurrEduCls_SynENS.PkWeekTime; //排课时间
objCurrEduCls_SynENT.PkClassRooms = objCurrEduCls_SynENS.PkClassRooms; //排课教室
objCurrEduCls_SynENT.BeginWeek = objCurrEduCls_SynENS.BeginWeek; //开始周
objCurrEduCls_SynENT.TeacherNames = objCurrEduCls_SynENS.TeacherNames; //教师姓名
objCurrEduCls_SynENT.IsSynch = objCurrEduCls_SynENS.IsSynch; //是否同步
objCurrEduCls_SynENT.SynchDate = objCurrEduCls_SynENS.SynchDate; //同步日期
objCurrEduCls_SynENT.ModifyDate = objCurrEduCls_SynENS.ModifyDate; //修改日期
objCurrEduCls_SynENT.ModifyUserId = objCurrEduCls_SynENS.ModifyUserId; //修改人
objCurrEduCls_SynENT.Memo = objCurrEduCls_SynENS.Memo; //备注
objCurrEduCls_SynENT.SignInDate = objCurrEduCls_SynENS.SignInDate; //签入时间
objCurrEduCls_SynENT.SignInStateID = objCurrEduCls_SynENS.SignInStateID; //签入状态表流水号
objCurrEduCls_SynENT.SignInUser = objCurrEduCls_SynENS.SignInUser; //签入人
objCurrEduCls_SynENT.SynchToWebUser = objCurrEduCls_SynENS.SynchToWebUser; //同步Web用户
objCurrEduCls_SynENT.IsSynchToWeb = objCurrEduCls_SynENS.IsSynchToWeb; //是否同步Web
objCurrEduCls_SynENT.SynchToWebDate = objCurrEduCls_SynENS.SynchToWebDate; //同步Web日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCurrEduCls_SynEN.CurrEduClsId, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldNotNull(objCurrEduCls_SynEN.IdMajor, conCurrEduCls_Syn.IdMajor);
clsCheckSql.CheckFieldNotNull(objCurrEduCls_SynEN.IsSynch, conCurrEduCls_Syn.IsSynch);
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdCurrEduCls, 8, conCurrEduCls_Syn.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CurrEduClsId, 15, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsName, 100, conCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdXzCollege, 4, conCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdMajor, 8, conCurrEduCls_Syn.IdMajor);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CustomerWeek, 50, conCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExecPlan, 8, conCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckClassRoom, 2000, conCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckAdminCls, 2000, conCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckTeacher, 2000, conCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolYear, 10, conCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ArrangeCourseMemo, 50, conCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdCourseType, 4, conCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExportDate, 8, conCurrEduCls_Syn.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdScoreType, 4, conCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExamType, 4, conCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GeneratePwdDate, 20, conCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExamTime, 8, conCurrEduCls_Syn.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckDate, 20, conCurrEduCls_Syn.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduClassInPk, 8, conCurrEduCls_Syn.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkWeekTime, 2000, conCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkClassRooms, 150, conCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeacherNames, 100, conCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchDate, 30, conCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyDate, 20, conCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyUserId, 18, conCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.Memo, 1000, conCurrEduCls_Syn.Memo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInDate, 20, conCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInUser, 18, conCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebUser, 18, conCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebDate, 20, conCurrEduCls_Syn.SynchToWebDate);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
 objCurrEduCls_SynEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CurrEduClsId, 15, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsName, 100, conCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdXzCollege, 4, conCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdMajor, 8, conCurrEduCls_Syn.IdMajor);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CustomerWeek, 50, conCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExecPlan, 8, conCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckClassRoom, 2000, conCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckAdminCls, 2000, conCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckTeacher, 2000, conCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolYear, 10, conCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ArrangeCourseMemo, 50, conCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdCourseType, 4, conCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExportDate, 8, conCurrEduCls_Syn.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdScoreType, 4, conCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExamType, 4, conCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GeneratePwdDate, 20, conCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExamTime, 8, conCurrEduCls_Syn.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckDate, 20, conCurrEduCls_Syn.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduClassInPk, 8, conCurrEduCls_Syn.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkWeekTime, 2000, conCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkClassRooms, 150, conCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeacherNames, 100, conCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchDate, 30, conCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyDate, 20, conCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyUserId, 18, conCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.Memo, 1000, conCurrEduCls_Syn.Memo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInDate, 20, conCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInUser, 18, conCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebUser, 18, conCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebDate, 20, conCurrEduCls_Syn.SynchToWebDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
 objCurrEduCls_SynEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCurrEduCls_SynEN objCurrEduCls_SynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdCurrEduCls, 8, conCurrEduCls_Syn.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CurrEduClsId, 15, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsName, 100, conCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.EduClsTypeId, 4, conCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeachingSolutionId, 8, conCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdXzCollege, 4, conCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdMajor, 8, conCurrEduCls_Syn.IdMajor);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CustomerWeek, 50, conCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExecPlan, 8, conCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckClassRoom, 2000, conCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckAdminCls, 2000, conCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckTeacher, 2000, conCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolYear, 10, conCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SchoolTerm, 1, conCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ArrangeCourseMemo, 50, conCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdCourseType, 4, conCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExportDate, 8, conCurrEduCls_Syn.ExportDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdScoreType, 4, conCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GetScoreWayId, 2, conCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdExamType, 4, conCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.GeneratePwdDate, 20, conCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ExamTime, 8, conCurrEduCls_Syn.ExamTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.CheckDate, 20, conCurrEduCls_Syn.CheckDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.IdEduClassInPk, 8, conCurrEduCls_Syn.IdEduClassInPk);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkWeekTime, 2000, conCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.PkClassRooms, 150, conCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.TeacherNames, 100, conCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchDate, 30, conCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyDate, 20, conCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.ModifyUserId, 18, conCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.Memo, 1000, conCurrEduCls_Syn.Memo);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInDate, 20, conCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInStateID, 2, conCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SignInUser, 18, conCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebUser, 18, conCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckFieldLen(objCurrEduCls_SynEN.SynchToWebDate, 20, conCurrEduCls_Syn.SynchToWebDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdCurrEduCls, conCurrEduCls_Syn.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CurrEduClsId, conCurrEduCls_Syn.CurrEduClsId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.EduClsName, conCurrEduCls_Syn.EduClsName);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.EduClsTypeId, conCurrEduCls_Syn.EduClsTypeId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CourseId, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.TeachingSolutionId, conCurrEduCls_Syn.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdXzCollege, conCurrEduCls_Syn.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdMajor, conCurrEduCls_Syn.IdMajor);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdEduWay, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdClassRoomType, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.WeekStatusId, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CustomerWeek, conCurrEduCls_Syn.CustomerWeek);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdExecPlan, conCurrEduCls_Syn.IdExecPlan);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CheckClassRoom, conCurrEduCls_Syn.CheckClassRoom);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CheckAdminCls, conCurrEduCls_Syn.CheckAdminCls);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CheckTeacher, conCurrEduCls_Syn.CheckTeacher);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdUniZone, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdGradeBase, conCurrEduCls_Syn.IdGradeBase);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SchoolYear, conCurrEduCls_Syn.SchoolYear);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SchoolTerm, conCurrEduCls_Syn.SchoolTerm);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.ArrangeCourseMemo, conCurrEduCls_Syn.ArrangeCourseMemo);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdCourseType, conCurrEduCls_Syn.IdCourseType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.ExportDate, conCurrEduCls_Syn.ExportDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdScoreType, conCurrEduCls_Syn.IdScoreType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.GetScoreWayId, conCurrEduCls_Syn.GetScoreWayId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdExamType, conCurrEduCls_Syn.IdExamType);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.GeneratePwdDate, conCurrEduCls_Syn.GeneratePwdDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.ExamTime, conCurrEduCls_Syn.ExamTime);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.CheckDate, conCurrEduCls_Syn.CheckDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.IdEduClassInPk, conCurrEduCls_Syn.IdEduClassInPk);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.PkWeekTime, conCurrEduCls_Syn.PkWeekTime);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.PkClassRooms, conCurrEduCls_Syn.PkClassRooms);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.TeacherNames, conCurrEduCls_Syn.TeacherNames);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SynchDate, conCurrEduCls_Syn.SynchDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.ModifyDate, conCurrEduCls_Syn.ModifyDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.ModifyUserId, conCurrEduCls_Syn.ModifyUserId);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.Memo, conCurrEduCls_Syn.Memo);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SignInDate, conCurrEduCls_Syn.SignInDate);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SignInStateID, conCurrEduCls_Syn.SignInStateID);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SignInUser, conCurrEduCls_Syn.SignInUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SynchToWebUser, conCurrEduCls_Syn.SynchToWebUser);
clsCheckSql.CheckSqlInjection4Field(objCurrEduCls_SynEN.SynchToWebDate, conCurrEduCls_Syn.SynchToWebDate);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.CourseId, 8, conCurrEduCls_Syn.CourseId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdEduWay, 4, conCurrEduCls_Syn.IdEduWay);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdClassRoomType, 4, conCurrEduCls_Syn.IdClassRoomType);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.WeekStatusId, 2, conCurrEduCls_Syn.WeekStatusId);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdUniZone, 4, conCurrEduCls_Syn.IdUniZone);
clsCheckSql.CheckFieldForeignKey(objCurrEduCls_SynEN.IdGradeBase, 4, conCurrEduCls_Syn.IdGradeBase);
 objCurrEduCls_SynEN._IsCheckProperty = true;
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
string strSQL = "select IdCurrEduCls, EduClsName from CurrEduCls_Syn ";
 clsSpecSQLforSql mySql = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduCls_SynEN._CurrTabName);
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCurrEduCls_SynEN._CurrTabName, strCondition);
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
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
 objSQL = clsCurrEduCls_SynDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}