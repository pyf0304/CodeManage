
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_TobeStudiedProblemVerDA
 表名:zx_TobeStudiedProblemVer(01120805)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 23:06:48
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 中学待研究问题历史版本表(zx_TobeStudiedProblemVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_TobeStudiedProblemVerDA : clsCommBase4DA
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
 return clszx_TobeStudiedProblemVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_TobeStudiedProblemVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_TobeStudiedProblemVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_TobeStudiedProblemVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_TobeStudiedProblemVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_TobeStudiedProblemVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable_zx_TobeStudiedProblemVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TobeStudiedProblemVer.* from zx_TobeStudiedProblemVer Left Join {1} on {2} where {3} and zx_TobeStudiedProblemVer.ProblemVId not in (Select top {5} zx_TobeStudiedProblemVer.ProblemVId from zx_TobeStudiedProblemVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {2} ProblemVId from zx_TobeStudiedProblemVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {3} ProblemVId from zx_TobeStudiedProblemVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_TobeStudiedProblemVer.* from zx_TobeStudiedProblemVer Left Join {1} on {2} where {3} and zx_TobeStudiedProblemVer.ProblemVId not in (Select top {5} zx_TobeStudiedProblemVer.ProblemVId from zx_TobeStudiedProblemVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {2} ProblemVId from zx_TobeStudiedProblemVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_TobeStudiedProblemVer where {1} and ProblemVId not in (Select top {3} ProblemVId from zx_TobeStudiedProblemVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_TobeStudiedProblemVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA:GetObjLst)", objException.Message));
}
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetObjLst)", objException.Message));
}
objzx_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
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
public List<clszx_TobeStudiedProblemVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_TobeStudiedProblemVerEN> arrObjLst = new List<clszx_TobeStudiedProblemVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetObjLst)", objException.Message));
}
objzx_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_TobeStudiedProblemVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_TobeStudiedProblemVer(ref clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where ProblemVId = " + ""+ objzx_TobeStudiedProblemVerEN.ProblemVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objDT.Rows[0][conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemVerEN.ProblemId = objDT.Rows[0][conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TobeStudiedProblemVerEN.GroupTextId = objDT.Rows[0][conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemContent = objDT.Rows[0][conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemDate = objDT.Rows[0][conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Participant = objDT.Rows[0][conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TobeStudiedProblemVerEN.UpdDate = objDT.Rows[0][conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.UpdUser = objDT.Rows[0][conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Year = objDT.Rows[0][conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Month = objDT.Rows[0][conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Memo = objDT.Rows[0][conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemTitle = objDT.Rows[0][conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: Getzx_TobeStudiedProblemVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngProblemVId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_TobeStudiedProblemVerEN GetObjByProblemVId(long lngProblemVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
 objzx_TobeStudiedProblemVerEN.ProblemVId = Int32.Parse(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId(字段类型:bigint,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_TobeStudiedProblemVerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年(字段类型:char,字段长度:4,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月(字段类型:char,字段长度:2,是否可空:True)
 objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetObjByProblemVId)", objException.Message));
}
return objzx_TobeStudiedProblemVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_TobeStudiedProblemVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN()
{
ProblemVId = TransNullToInt(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()), //ProblemVId
ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(), //问题Id
GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(), //小组Id
IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()), //是否提交
ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(), //问题内容
ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(), //问题日期
Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(), //参与者
UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(), //修改人
Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(), //年
Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(), //月
Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(), //备注
ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim() //问题标题
};
objzx_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_TobeStudiedProblemVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetObjByDataRowzx_TobeStudiedProblemVer)", objException.Message));
}
objzx_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_TobeStudiedProblemVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN = new clszx_TobeStudiedProblemVerEN();
try
{
objzx_TobeStudiedProblemVerEN.ProblemVId = TransNullToInt(objRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim()); //ProblemVId
objzx_TobeStudiedProblemVerEN.ProblemId = objRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objzx_TobeStudiedProblemVerEN.GroupTextId = objRow[conzx_TobeStudiedProblemVer.GroupTextId] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objzx_TobeStudiedProblemVerEN.IsSubmit = TransNullToBool(objRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim()); //是否提交
objzx_TobeStudiedProblemVerEN.ProblemContent = objRow[conzx_TobeStudiedProblemVer.ProblemContent] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objzx_TobeStudiedProblemVerEN.ProblemDate = objRow[conzx_TobeStudiedProblemVer.ProblemDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objzx_TobeStudiedProblemVerEN.Participant = objRow[conzx_TobeStudiedProblemVer.Participant] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objzx_TobeStudiedProblemVerEN.UpdDate = objRow[conzx_TobeStudiedProblemVer.UpdDate] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objzx_TobeStudiedProblemVerEN.UpdUser = objRow[conzx_TobeStudiedProblemVer.UpdUser] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objzx_TobeStudiedProblemVerEN.Year = objRow[conzx_TobeStudiedProblemVer.Year] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objzx_TobeStudiedProblemVerEN.Month = objRow[conzx_TobeStudiedProblemVer.Month] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objzx_TobeStudiedProblemVerEN.Memo = objRow[conzx_TobeStudiedProblemVer.Memo] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objzx_TobeStudiedProblemVerEN.ProblemTitle = objRow[conzx_TobeStudiedProblemVer.ProblemTitle] == DBNull.Value ? null : objRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_TobeStudiedProblemVerDA: GetObjByDataRow)", objException.Message));
}
objzx_TobeStudiedProblemVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_TobeStudiedProblemVerEN;
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
objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TobeStudiedProblemVerEN._CurrTabName, conzx_TobeStudiedProblemVer.ProblemVId, 8, "");
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
objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_TobeStudiedProblemVerEN._CurrTabName, conzx_TobeStudiedProblemVer.ProblemVId, 8, strPrefix);
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ProblemVId from zx_TobeStudiedProblemVer where " + strCondition;
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ProblemVId from zx_TobeStudiedProblemVer where " + strCondition;
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngProblemVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TobeStudiedProblemVer", "ProblemVId = " + ""+ lngProblemVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_TobeStudiedProblemVer", strCondition))
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
objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_TobeStudiedProblemVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
 {
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TobeStudiedProblemVer");
objRow = objDS.Tables["zx_TobeStudiedProblemVer"].NewRow();
objRow[conzx_TobeStudiedProblemVer.ProblemId] = objzx_TobeStudiedProblemVerEN.ProblemId; //问题Id
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.GroupTextId] = objzx_TobeStudiedProblemVerEN.GroupTextId; //小组Id
 }
objRow[conzx_TobeStudiedProblemVer.IsSubmit] = objzx_TobeStudiedProblemVerEN.IsSubmit; //是否提交
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.ProblemContent] = objzx_TobeStudiedProblemVerEN.ProblemContent; //问题内容
 }
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.ProblemDate] = objzx_TobeStudiedProblemVerEN.ProblemDate; //问题日期
 }
 if (objzx_TobeStudiedProblemVerEN.Participant !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.Participant] = objzx_TobeStudiedProblemVerEN.Participant; //参与者
 }
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.UpdDate] = objzx_TobeStudiedProblemVerEN.UpdDate; //修改日期
 }
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.UpdUser] = objzx_TobeStudiedProblemVerEN.UpdUser; //修改人
 }
 if (objzx_TobeStudiedProblemVerEN.Year !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.Year] = objzx_TobeStudiedProblemVerEN.Year; //年
 }
 if (objzx_TobeStudiedProblemVerEN.Month !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.Month] = objzx_TobeStudiedProblemVerEN.Month; //月
 }
 if (objzx_TobeStudiedProblemVerEN.Memo !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.Memo] = objzx_TobeStudiedProblemVerEN.Memo; //备注
 }
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  "")
 {
objRow[conzx_TobeStudiedProblemVer.ProblemTitle] = objzx_TobeStudiedProblemVerEN.ProblemTitle; //问题标题
 }
objDS.Tables[clszx_TobeStudiedProblemVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Participant);
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Year);
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Month);
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Memo);
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Participant);
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Year);
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Month);
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Memo);
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Participant);
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Year);
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Month);
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Memo);
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_TobeStudiedProblemVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemId);
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemId + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.GroupTextId);
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_TobeStudiedProblemVerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemContent);
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemContent + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemDate);
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Participant);
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParticipant + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdDate);
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.UpdUser);
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Year);
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strYear + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Month);
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMonth + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.Memo);
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 arrFieldListForInsert.Add(conzx_TobeStudiedProblemVer.ProblemTitle);
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProblemTitle + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_TobeStudiedProblemVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_TobeStudiedProblemVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where ProblemVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_TobeStudiedProblemVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngProblemVId = TransNullToInt(oRow[conzx_TobeStudiedProblemVer.ProblemVId].ToString().Trim());
if (IsExist(lngProblemVId))
{
 string strResult = "关键字变量值为:" + string.Format("ProblemVId = {0}", lngProblemVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_TobeStudiedProblemVerEN._CurrTabName ].NewRow();
objRow[conzx_TobeStudiedProblemVer.ProblemId] = oRow[conzx_TobeStudiedProblemVer.ProblemId].ToString().Trim(); //问题Id
objRow[conzx_TobeStudiedProblemVer.GroupTextId] = oRow[conzx_TobeStudiedProblemVer.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_TobeStudiedProblemVer.IsSubmit] = oRow[conzx_TobeStudiedProblemVer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_TobeStudiedProblemVer.ProblemContent] = oRow[conzx_TobeStudiedProblemVer.ProblemContent].ToString().Trim(); //问题内容
objRow[conzx_TobeStudiedProblemVer.ProblemDate] = oRow[conzx_TobeStudiedProblemVer.ProblemDate].ToString().Trim(); //问题日期
objRow[conzx_TobeStudiedProblemVer.Participant] = oRow[conzx_TobeStudiedProblemVer.Participant].ToString().Trim(); //参与者
objRow[conzx_TobeStudiedProblemVer.UpdDate] = oRow[conzx_TobeStudiedProblemVer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_TobeStudiedProblemVer.UpdUser] = oRow[conzx_TobeStudiedProblemVer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_TobeStudiedProblemVer.Year] = oRow[conzx_TobeStudiedProblemVer.Year].ToString().Trim(); //年
objRow[conzx_TobeStudiedProblemVer.Month] = oRow[conzx_TobeStudiedProblemVer.Month].ToString().Trim(); //月
objRow[conzx_TobeStudiedProblemVer.Memo] = oRow[conzx_TobeStudiedProblemVer.Memo].ToString().Trim(); //备注
objRow[conzx_TobeStudiedProblemVer.ProblemTitle] = oRow[conzx_TobeStudiedProblemVer.ProblemTitle].ToString().Trim(); //问题标题
 objDS.Tables[clszx_TobeStudiedProblemVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
strSQL = "Select * from zx_TobeStudiedProblemVer where ProblemVId = " + ""+ objzx_TobeStudiedProblemVerEN.ProblemVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_TobeStudiedProblemVerEN._CurrTabName);
if (objDS.Tables[clszx_TobeStudiedProblemVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ProblemVId = " + ""+ objzx_TobeStudiedProblemVerEN.ProblemVId+"");
return false;
}
objRow = objDS.Tables[clszx_TobeStudiedProblemVerEN._CurrTabName].Rows[0];
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId))
 {
objRow[conzx_TobeStudiedProblemVer.ProblemId] = objzx_TobeStudiedProblemVerEN.ProblemId; //问题Id
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId))
 {
objRow[conzx_TobeStudiedProblemVer.GroupTextId] = objzx_TobeStudiedProblemVerEN.GroupTextId; //小组Id
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit))
 {
objRow[conzx_TobeStudiedProblemVer.IsSubmit] = objzx_TobeStudiedProblemVerEN.IsSubmit; //是否提交
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent))
 {
objRow[conzx_TobeStudiedProblemVer.ProblemContent] = objzx_TobeStudiedProblemVerEN.ProblemContent; //问题内容
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate))
 {
objRow[conzx_TobeStudiedProblemVer.ProblemDate] = objzx_TobeStudiedProblemVerEN.ProblemDate; //问题日期
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Participant))
 {
objRow[conzx_TobeStudiedProblemVer.Participant] = objzx_TobeStudiedProblemVerEN.Participant; //参与者
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate))
 {
objRow[conzx_TobeStudiedProblemVer.UpdDate] = objzx_TobeStudiedProblemVerEN.UpdDate; //修改日期
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser))
 {
objRow[conzx_TobeStudiedProblemVer.UpdUser] = objzx_TobeStudiedProblemVerEN.UpdUser; //修改人
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Year))
 {
objRow[conzx_TobeStudiedProblemVer.Year] = objzx_TobeStudiedProblemVerEN.Year; //年
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Month))
 {
objRow[conzx_TobeStudiedProblemVer.Month] = objzx_TobeStudiedProblemVerEN.Month; //月
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Memo))
 {
objRow[conzx_TobeStudiedProblemVer.Memo] = objzx_TobeStudiedProblemVerEN.Memo; //备注
 }
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle))
 {
objRow[conzx_TobeStudiedProblemVer.ProblemTitle] = objzx_TobeStudiedProblemVerEN.ProblemTitle; //问题标题
 }
try
{
objDA.Update(objDS, clszx_TobeStudiedProblemVerEN._CurrTabName);
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_TobeStudiedProblemVer Set ");
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemId, conzx_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId))
 {
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TobeStudiedProblemVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.GroupTextId); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0", conzx_TobeStudiedProblemVer.IsSubmit); //是否提交
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, conzx_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, conzx_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Participant))
 {
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, conzx_TobeStudiedProblemVer.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Participant); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TobeStudiedProblemVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.UpdUser); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Year))
 {
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_TobeStudiedProblemVer.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Year); //年
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Month))
 {
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_TobeStudiedProblemVer.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Month); //月
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Memo))
 {
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TobeStudiedProblemVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Memo); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, conzx_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemVId = {0}", objzx_TobeStudiedProblemVerEN.ProblemVId); 
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strCondition)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblemVer Set ");
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemId = '{0}',", strProblemId); //问题Id
 }
 else
 {
 sbSQL.Append(" ProblemId = null,"); //问题Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId))
 {
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Participant))
 {
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Year))
 {
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Month))
 {
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Memo))
 {
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblemVer Set ");
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemId = '{0}',", strProblemId); //问题Id
 }
 else
 {
 sbSQL.Append(" ProblemId = null,"); //问题Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId))
 {
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemContent = '{0}',", strProblemContent); //问题内容
 }
 else
 {
 sbSQL.Append(" ProblemContent = null,"); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemDate = '{0}',", strProblemDate); //问题日期
 }
 else
 {
 sbSQL.Append(" ProblemDate = null,"); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Participant))
 {
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Participant = '{0}',", strParticipant); //参与者
 }
 else
 {
 sbSQL.Append(" Participant = null,"); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Year))
 {
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Year = '{0}',", strYear); //年
 }
 else
 {
 sbSQL.Append(" Year = null,"); //年
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Month))
 {
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Month = '{0}',", strMonth); //月
 }
 else
 {
 sbSQL.Append(" Month = null,"); //月
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Memo))
 {
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProblemTitle = '{0}',", strProblemTitle); //问题标题
 }
 else
 {
 sbSQL.Append(" ProblemTitle = null,"); //问题标题
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
 /// <param name = "objzx_TobeStudiedProblemVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_TobeStudiedProblemVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_TobeStudiedProblemVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_TobeStudiedProblemVer Set ");
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemId))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemId !=  null)
 {
 var strProblemId = objzx_TobeStudiedProblemVerEN.ProblemId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemId, conzx_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemId); //问题Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.GroupTextId))
 {
 if (objzx_TobeStudiedProblemVerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_TobeStudiedProblemVerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_TobeStudiedProblemVer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.GroupTextId); //小组Id
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_TobeStudiedProblemVerEN.IsSubmit == true?"1":"0", conzx_TobeStudiedProblemVer.IsSubmit); //是否提交
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemContent))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemContent !=  null)
 {
 var strProblemContent = objzx_TobeStudiedProblemVerEN.ProblemContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemContent, conzx_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemContent); //问题内容
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemDate))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemDate !=  null)
 {
 var strProblemDate = objzx_TobeStudiedProblemVerEN.ProblemDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemDate, conzx_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemDate); //问题日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Participant))
 {
 if (objzx_TobeStudiedProblemVerEN.Participant !=  null)
 {
 var strParticipant = objzx_TobeStudiedProblemVerEN.Participant.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParticipant, conzx_TobeStudiedProblemVer.Participant); //参与者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Participant); //参与者
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdDate))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_TobeStudiedProblemVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.UpdDate); //修改日期
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.UpdUser))
 {
 if (objzx_TobeStudiedProblemVerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_TobeStudiedProblemVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_TobeStudiedProblemVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.UpdUser); //修改人
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Year))
 {
 if (objzx_TobeStudiedProblemVerEN.Year !=  null)
 {
 var strYear = objzx_TobeStudiedProblemVerEN.Year.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strYear, conzx_TobeStudiedProblemVer.Year); //年
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Year); //年
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Month))
 {
 if (objzx_TobeStudiedProblemVerEN.Month !=  null)
 {
 var strMonth = objzx_TobeStudiedProblemVerEN.Month.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMonth, conzx_TobeStudiedProblemVer.Month); //月
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Month); //月
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.Memo))
 {
 if (objzx_TobeStudiedProblemVerEN.Memo !=  null)
 {
 var strMemo = objzx_TobeStudiedProblemVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_TobeStudiedProblemVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.Memo); //备注
 }
 }
 
 if (objzx_TobeStudiedProblemVerEN.IsUpdated(conzx_TobeStudiedProblemVer.ProblemTitle))
 {
 if (objzx_TobeStudiedProblemVerEN.ProblemTitle !=  null)
 {
 var strProblemTitle = objzx_TobeStudiedProblemVerEN.ProblemTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProblemTitle, conzx_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_TobeStudiedProblemVer.ProblemTitle); //问题标题
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ProblemVId = {0}", objzx_TobeStudiedProblemVerEN.ProblemVId); 
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
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngProblemVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngProblemVId,
};
 objSQL.ExecSP("zx_TobeStudiedProblemVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngProblemVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
//删除zx_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_TobeStudiedProblemVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
//删除zx_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblemVer where ProblemVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngProblemVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngProblemVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
//删除zx_TobeStudiedProblemVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_TobeStudiedProblemVer where ProblemVId = " + ""+ lngProblemVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_TobeStudiedProblemVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: Delzx_TobeStudiedProblemVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TobeStudiedProblemVer where " + strCondition ;
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
public bool Delzx_TobeStudiedProblemVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_TobeStudiedProblemVerDA: Delzx_TobeStudiedProblemVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_TobeStudiedProblemVer where " + strCondition ;
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
 /// <param name = "objzx_TobeStudiedProblemVerENS">源对象</param>
 /// <param name = "objzx_TobeStudiedProblemVerENT">目标对象</param>
public void CopyTo(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENS, clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerENT)
{
objzx_TobeStudiedProblemVerENT.ProblemVId = objzx_TobeStudiedProblemVerENS.ProblemVId; //ProblemVId
objzx_TobeStudiedProblemVerENT.ProblemId = objzx_TobeStudiedProblemVerENS.ProblemId; //问题Id
objzx_TobeStudiedProblemVerENT.GroupTextId = objzx_TobeStudiedProblemVerENS.GroupTextId; //小组Id
objzx_TobeStudiedProblemVerENT.IsSubmit = objzx_TobeStudiedProblemVerENS.IsSubmit; //是否提交
objzx_TobeStudiedProblemVerENT.ProblemContent = objzx_TobeStudiedProblemVerENS.ProblemContent; //问题内容
objzx_TobeStudiedProblemVerENT.ProblemDate = objzx_TobeStudiedProblemVerENS.ProblemDate; //问题日期
objzx_TobeStudiedProblemVerENT.Participant = objzx_TobeStudiedProblemVerENS.Participant; //参与者
objzx_TobeStudiedProblemVerENT.UpdDate = objzx_TobeStudiedProblemVerENS.UpdDate; //修改日期
objzx_TobeStudiedProblemVerENT.UpdUser = objzx_TobeStudiedProblemVerENS.UpdUser; //修改人
objzx_TobeStudiedProblemVerENT.Year = objzx_TobeStudiedProblemVerENS.Year; //年
objzx_TobeStudiedProblemVerENT.Month = objzx_TobeStudiedProblemVerENS.Month; //月
objzx_TobeStudiedProblemVerENT.Memo = objzx_TobeStudiedProblemVerENS.Memo; //备注
objzx_TobeStudiedProblemVerENT.ProblemTitle = objzx_TobeStudiedProblemVerENS.ProblemTitle; //问题标题
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_TobeStudiedProblemVerEN.ProblemId, conzx_TobeStudiedProblemVer.ProblemId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemId, 10, conzx_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.GroupTextId, 8, conzx_TobeStudiedProblemVer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemContent, 5000, conzx_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemDate, 20, conzx_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Participant, 500, conzx_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdDate, 20, conzx_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdUser, 20, conzx_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Year, 4, conzx_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Month, 2, conzx_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Memo, 1000, conzx_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemTitle, 1000, conzx_TobeStudiedProblemVer.ProblemTitle);
//检查字段外键固定长度
 objzx_TobeStudiedProblemVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemId, 10, conzx_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.GroupTextId, 8, conzx_TobeStudiedProblemVer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemContent, 5000, conzx_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemDate, 20, conzx_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Participant, 500, conzx_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdDate, 20, conzx_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdUser, 20, conzx_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Year, 4, conzx_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Month, 2, conzx_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Memo, 1000, conzx_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemTitle, 1000, conzx_TobeStudiedProblemVer.ProblemTitle);
//检查外键字段长度
 objzx_TobeStudiedProblemVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemId, 10, conzx_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.GroupTextId, 8, conzx_TobeStudiedProblemVer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemContent, 5000, conzx_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemDate, 20, conzx_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Participant, 500, conzx_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdDate, 20, conzx_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.UpdUser, 20, conzx_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Year, 4, conzx_TobeStudiedProblemVer.Year);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Month, 2, conzx_TobeStudiedProblemVer.Month);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.Memo, 1000, conzx_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckFieldLen(objzx_TobeStudiedProblemVerEN.ProblemTitle, 1000, conzx_TobeStudiedProblemVer.ProblemTitle);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.ProblemId, conzx_TobeStudiedProblemVer.ProblemId);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.GroupTextId, conzx_TobeStudiedProblemVer.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.ProblemContent, conzx_TobeStudiedProblemVer.ProblemContent);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.ProblemDate, conzx_TobeStudiedProblemVer.ProblemDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.Participant, conzx_TobeStudiedProblemVer.Participant);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.UpdDate, conzx_TobeStudiedProblemVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.UpdUser, conzx_TobeStudiedProblemVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.Year, conzx_TobeStudiedProblemVer.Year);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.Month, conzx_TobeStudiedProblemVer.Month);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.Memo, conzx_TobeStudiedProblemVer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_TobeStudiedProblemVerEN.ProblemTitle, conzx_TobeStudiedProblemVer.ProblemTitle);
//检查外键字段长度
 objzx_TobeStudiedProblemVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_TobeStudiedProblemVer(中学待研究问题历史版本表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_TobeStudiedProblemVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_TobeStudiedProblemVerEN objzx_TobeStudiedProblemVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and ProblemVId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemVId);
 sbCondition.AppendFormat(" and ProblemId = '{0}'", objzx_TobeStudiedProblemVerEN.ProblemId);
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TobeStudiedProblemVerEN._CurrTabName);
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_TobeStudiedProblemVerEN._CurrTabName, strCondition);
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
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
 objSQL = clszx_TobeStudiedProblemVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}