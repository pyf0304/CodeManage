
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_KnowledgesUserMasterDA
 表名:ge_KnowledgesUserMaster(01120892)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:25
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 知识点用户掌握(ge_KnowledgesUserMaster)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_KnowledgesUserMasterDA : clsCommBase4DA
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
 return clsge_KnowledgesUserMasterEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_KnowledgesUserMasterEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_KnowledgesUserMasterEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_KnowledgesUserMasterEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_KnowledgesUserMasterEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_KnowledgesUserMaster(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable_ge_KnowledgesUserMaster)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_KnowledgesUserMaster.* from ge_KnowledgesUserMaster Left Join {1} on {2} where {3} and ge_KnowledgesUserMaster.mId not in (Select top {5} ge_KnowledgesUserMaster.mId from ge_KnowledgesUserMaster Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1} and mId not in (Select top {2} mId from ge_KnowledgesUserMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1} and mId not in (Select top {3} mId from ge_KnowledgesUserMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_KnowledgesUserMaster.* from ge_KnowledgesUserMaster Left Join {1} on {2} where {3} and ge_KnowledgesUserMaster.mId not in (Select top {5} ge_KnowledgesUserMaster.mId from ge_KnowledgesUserMaster Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1} and mId not in (Select top {2} mId from ge_KnowledgesUserMaster where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_KnowledgesUserMaster where {1} and mId not in (Select top {3} mId from ge_KnowledgesUserMaster where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_KnowledgesUserMasterEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA:GetObjLst)", objException.Message));
}
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = TransNullToInt(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetObjLst)", objException.Message));
}
objge_KnowledgesUserMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
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
public List<clsge_KnowledgesUserMasterEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_KnowledgesUserMasterEN> arrObjLst = new List<clsge_KnowledgesUserMasterEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = TransNullToInt(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetObjLst)", objException.Message));
}
objge_KnowledgesUserMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_KnowledgesUserMasterEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_KnowledgesUserMaster(ref clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where mId = " + ""+ objge_KnowledgesUserMasterEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_KnowledgesUserMasterEN.mId = TransNullToInt(objDT.Rows[0][conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_KnowledgesUserMasterEN.CourseId = objDT.Rows[0][conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_KnowledgesUserMasterEN.UserId = objDT.Rows[0][conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_KnowledgesUserMasterEN.CourseKnowledgeId = objDT.Rows[0][conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objge_KnowledgesUserMasterEN.RightCount = TransNullToInt(objDT.Rows[0][conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数(字段类型:int,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasterTypeId = objDT.Rows[0][conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id(字段类型:char,字段长度:1,是否可空:True)
 objge_KnowledgesUserMasterEN.ErrorCount = TransNullToInt(objDT.Rows[0][conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数(字段类型:int,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasterLevelId = objDT.Rows[0][conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id(字段类型:char,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasteryValue = TransNullToDouble(objDT.Rows[0][conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.UpdDate = objDT.Rows[0][conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.GoalValue = TransNullToDouble(objDT.Rows[0][conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.SelfPerceivedValue = TransNullToDouble(objDT.Rows[0][conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.UpdUser = objDT.Rows[0][conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.Memo = objDT.Rows[0][conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: Getge_KnowledgesUserMaster)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_KnowledgesUserMasterEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
 objge_KnowledgesUserMasterEN.mId = Int32.Parse(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数(字段类型:int,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id(字段类型:char,字段长度:1,是否可空:True)
 objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数(字段类型:int,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id(字段类型:char,字段长度:4,是否可空:True)
 objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值(字段类型:numeric,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetObjBymId)", objException.Message));
}
return objge_KnowledgesUserMasterEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_KnowledgesUserMasterEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN()
{
mId = TransNullToInt(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()), //mId
CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(), //课程Id
UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(), //用户ID
CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(), //知识点Id
RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()), //正确次数
MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(), //掌握类型Id
ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()), //错误次数
MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(), //掌握度Id
MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()), //掌握度
UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(), //修改日期
GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()), //目标值
SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()), //自我认为值
UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim() //备注
};
objge_KnowledgesUserMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_KnowledgesUserMasterEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_KnowledgesUserMasterEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = TransNullToInt(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetObjByDataRowge_KnowledgesUserMaster)", objException.Message));
}
objge_KnowledgesUserMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_KnowledgesUserMasterEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_KnowledgesUserMasterEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN = new clsge_KnowledgesUserMasterEN();
try
{
objge_KnowledgesUserMasterEN.mId = TransNullToInt(objRow[conge_KnowledgesUserMaster.mId].ToString().Trim()); //mId
objge_KnowledgesUserMasterEN.CourseId = objRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objge_KnowledgesUserMasterEN.UserId = objRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objge_KnowledgesUserMasterEN.CourseKnowledgeId = objRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objge_KnowledgesUserMasterEN.RightCount = objRow[conge_KnowledgesUserMaster.RightCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim()); //正确次数
objge_KnowledgesUserMasterEN.MasterTypeId = objRow[conge_KnowledgesUserMaster.MasterTypeId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objge_KnowledgesUserMasterEN.ErrorCount = objRow[conge_KnowledgesUserMaster.ErrorCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim()); //错误次数
objge_KnowledgesUserMasterEN.MasterLevelId = objRow[conge_KnowledgesUserMaster.MasterLevelId] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objge_KnowledgesUserMasterEN.MasteryValue = objRow[conge_KnowledgesUserMaster.MasteryValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim()); //掌握度
objge_KnowledgesUserMasterEN.UpdDate = objRow[conge_KnowledgesUserMaster.UpdDate] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objge_KnowledgesUserMasterEN.GoalValue = objRow[conge_KnowledgesUserMaster.GoalValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim()); //目标值
objge_KnowledgesUserMasterEN.SelfPerceivedValue = objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim()); //自我认为值
objge_KnowledgesUserMasterEN.UpdUser = objRow[conge_KnowledgesUserMaster.UpdUser] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objge_KnowledgesUserMasterEN.Memo = objRow[conge_KnowledgesUserMaster.Memo] == DBNull.Value ? null : objRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_KnowledgesUserMasterDA: GetObjByDataRow)", objException.Message));
}
objge_KnowledgesUserMasterEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_KnowledgesUserMasterEN;
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
objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_KnowledgesUserMasterEN._CurrTabName, conge_KnowledgesUserMaster.mId, 8, "");
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
objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_KnowledgesUserMasterEN._CurrTabName, conge_KnowledgesUserMaster.mId, 8, strPrefix);
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from ge_KnowledgesUserMaster where " + strCondition;
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from ge_KnowledgesUserMaster where " + strCondition;
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_KnowledgesUserMaster", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_KnowledgesUserMaster", strCondition))
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
objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_KnowledgesUserMaster");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
 {
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_KnowledgesUserMaster");
objRow = objDS.Tables["ge_KnowledgesUserMaster"].NewRow();
objRow[conge_KnowledgesUserMaster.CourseId] = objge_KnowledgesUserMasterEN.CourseId; //课程Id
objRow[conge_KnowledgesUserMaster.UserId] = objge_KnowledgesUserMasterEN.UserId; //用户ID
objRow[conge_KnowledgesUserMaster.CourseKnowledgeId] = objge_KnowledgesUserMasterEN.CourseKnowledgeId; //知识点Id
objRow[conge_KnowledgesUserMaster.RightCount] = objge_KnowledgesUserMasterEN.RightCount; //正确次数
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  "")
 {
objRow[conge_KnowledgesUserMaster.MasterTypeId] = objge_KnowledgesUserMasterEN.MasterTypeId; //掌握类型Id
 }
objRow[conge_KnowledgesUserMaster.ErrorCount] = objge_KnowledgesUserMasterEN.ErrorCount; //错误次数
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  "")
 {
objRow[conge_KnowledgesUserMaster.MasterLevelId] = objge_KnowledgesUserMasterEN.MasterLevelId; //掌握度Id
 }
objRow[conge_KnowledgesUserMaster.MasteryValue] = objge_KnowledgesUserMasterEN.MasteryValue; //掌握度
 if (objge_KnowledgesUserMasterEN.UpdDate !=  "")
 {
objRow[conge_KnowledgesUserMaster.UpdDate] = objge_KnowledgesUserMasterEN.UpdDate; //修改日期
 }
objRow[conge_KnowledgesUserMaster.GoalValue] = objge_KnowledgesUserMasterEN.GoalValue; //目标值
objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] = objge_KnowledgesUserMasterEN.SelfPerceivedValue; //自我认为值
 if (objge_KnowledgesUserMasterEN.UpdUser !=  "")
 {
objRow[conge_KnowledgesUserMaster.UpdUser] = objge_KnowledgesUserMasterEN.UpdUser; //修改人
 }
 if (objge_KnowledgesUserMasterEN.Memo !=  "")
 {
objRow[conge_KnowledgesUserMaster.Memo] = objge_KnowledgesUserMasterEN.Memo; //备注
 }
objDS.Tables[clsge_KnowledgesUserMasterEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_KnowledgesUserMasterEN._CurrTabName);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseId);
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UserId);
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseKnowledgeId);
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.RightCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.RightCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterTypeId);
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.ErrorCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.ErrorCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterLevelId);
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterLevelId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasteryValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.MasteryValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdDate);
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.GoalValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.GoalValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.SelfPerceivedValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.SelfPerceivedValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdUser);
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.Memo);
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_KnowledgesUserMaster");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseId);
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UserId);
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseKnowledgeId);
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.RightCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.RightCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterTypeId);
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.ErrorCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.ErrorCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterLevelId);
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterLevelId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasteryValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.MasteryValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdDate);
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.GoalValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.GoalValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.SelfPerceivedValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.SelfPerceivedValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdUser);
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.Memo);
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_KnowledgesUserMaster");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseId);
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UserId);
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseKnowledgeId);
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.RightCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.RightCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterTypeId);
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.ErrorCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.ErrorCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterLevelId);
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterLevelId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasteryValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.MasteryValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdDate);
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.GoalValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.GoalValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.SelfPerceivedValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.SelfPerceivedValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdUser);
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.Memo);
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_KnowledgesUserMaster");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_KnowledgesUserMasterEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseId);
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UserId);
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.CourseKnowledgeId);
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.RightCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.RightCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterTypeId);
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterTypeId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.ErrorCount);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.ErrorCount.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasterLevelId);
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMasterLevelId + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.MasteryValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.MasteryValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdDate);
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.GoalValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.GoalValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.SelfPerceivedValue);
 arrValueListForInsert.Add(objge_KnowledgesUserMasterEN.SelfPerceivedValue.ToString());
 }
 
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.UpdUser);
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_KnowledgesUserMaster.Memo);
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_KnowledgesUserMaster");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_KnowledgesUserMasters(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_KnowledgesUserMaster");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_KnowledgesUserMasterEN._CurrTabName ].NewRow();
objRow[conge_KnowledgesUserMaster.CourseId] = oRow[conge_KnowledgesUserMaster.CourseId].ToString().Trim(); //课程Id
objRow[conge_KnowledgesUserMaster.UserId] = oRow[conge_KnowledgesUserMaster.UserId].ToString().Trim(); //用户ID
objRow[conge_KnowledgesUserMaster.CourseKnowledgeId] = oRow[conge_KnowledgesUserMaster.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[conge_KnowledgesUserMaster.RightCount] = oRow[conge_KnowledgesUserMaster.RightCount].ToString().Trim(); //正确次数
objRow[conge_KnowledgesUserMaster.MasterTypeId] = oRow[conge_KnowledgesUserMaster.MasterTypeId].ToString().Trim(); //掌握类型Id
objRow[conge_KnowledgesUserMaster.ErrorCount] = oRow[conge_KnowledgesUserMaster.ErrorCount].ToString().Trim(); //错误次数
objRow[conge_KnowledgesUserMaster.MasterLevelId] = oRow[conge_KnowledgesUserMaster.MasterLevelId].ToString().Trim(); //掌握度Id
objRow[conge_KnowledgesUserMaster.MasteryValue] = oRow[conge_KnowledgesUserMaster.MasteryValue].ToString().Trim(); //掌握度
objRow[conge_KnowledgesUserMaster.UpdDate] = oRow[conge_KnowledgesUserMaster.UpdDate].ToString().Trim(); //修改日期
objRow[conge_KnowledgesUserMaster.GoalValue] = oRow[conge_KnowledgesUserMaster.GoalValue].ToString().Trim(); //目标值
objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] = oRow[conge_KnowledgesUserMaster.SelfPerceivedValue].ToString().Trim(); //自我认为值
objRow[conge_KnowledgesUserMaster.UpdUser] = oRow[conge_KnowledgesUserMaster.UpdUser].ToString().Trim(); //修改人
objRow[conge_KnowledgesUserMaster.Memo] = oRow[conge_KnowledgesUserMaster.Memo].ToString().Trim(); //备注
 objDS.Tables[clsge_KnowledgesUserMasterEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_KnowledgesUserMasterEN._CurrTabName);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_KnowledgesUserMasterEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
strSQL = "Select * from ge_KnowledgesUserMaster where mId = " + ""+ objge_KnowledgesUserMasterEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_KnowledgesUserMasterEN._CurrTabName);
if (objDS.Tables[clsge_KnowledgesUserMasterEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objge_KnowledgesUserMasterEN.mId+"");
return false;
}
objRow = objDS.Tables[clsge_KnowledgesUserMasterEN._CurrTabName].Rows[0];
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseId))
 {
objRow[conge_KnowledgesUserMaster.CourseId] = objge_KnowledgesUserMasterEN.CourseId; //课程Id
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UserId))
 {
objRow[conge_KnowledgesUserMaster.UserId] = objge_KnowledgesUserMasterEN.UserId; //用户ID
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId))
 {
objRow[conge_KnowledgesUserMaster.CourseKnowledgeId] = objge_KnowledgesUserMasterEN.CourseKnowledgeId; //知识点Id
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.RightCount))
 {
objRow[conge_KnowledgesUserMaster.RightCount] = objge_KnowledgesUserMasterEN.RightCount; //正确次数
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId))
 {
objRow[conge_KnowledgesUserMaster.MasterTypeId] = objge_KnowledgesUserMasterEN.MasterTypeId; //掌握类型Id
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.ErrorCount))
 {
objRow[conge_KnowledgesUserMaster.ErrorCount] = objge_KnowledgesUserMasterEN.ErrorCount; //错误次数
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId))
 {
objRow[conge_KnowledgesUserMaster.MasterLevelId] = objge_KnowledgesUserMasterEN.MasterLevelId; //掌握度Id
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasteryValue))
 {
objRow[conge_KnowledgesUserMaster.MasteryValue] = objge_KnowledgesUserMasterEN.MasteryValue; //掌握度
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdDate))
 {
objRow[conge_KnowledgesUserMaster.UpdDate] = objge_KnowledgesUserMasterEN.UpdDate; //修改日期
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.GoalValue))
 {
objRow[conge_KnowledgesUserMaster.GoalValue] = objge_KnowledgesUserMasterEN.GoalValue; //目标值
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.SelfPerceivedValue))
 {
objRow[conge_KnowledgesUserMaster.SelfPerceivedValue] = objge_KnowledgesUserMasterEN.SelfPerceivedValue; //自我认为值
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdUser))
 {
objRow[conge_KnowledgesUserMaster.UpdUser] = objge_KnowledgesUserMasterEN.UpdUser; //修改人
 }
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.Memo))
 {
objRow[conge_KnowledgesUserMaster.Memo] = objge_KnowledgesUserMasterEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsge_KnowledgesUserMasterEN._CurrTabName);
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_KnowledgesUserMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_KnowledgesUserMaster Set ");
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseId))
 {
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_KnowledgesUserMaster.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.CourseId); //课程Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UserId))
 {
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_KnowledgesUserMaster.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UserId); //用户ID
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId))
 {
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conge_KnowledgesUserMaster.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.RightCount))
 {
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.RightCount, conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId))
 {
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeId, conge_KnowledgesUserMaster.MasterTypeId); //掌握类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasterTypeId); //掌握类型Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.ErrorCount))
 {
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.ErrorCount, conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId))
 {
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterLevelId, conge_KnowledgesUserMaster.MasterLevelId); //掌握度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasterLevelId); //掌握度Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasteryValue))
 {
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.MasteryValue, conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdDate))
 {
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_KnowledgesUserMaster.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UpdDate); //修改日期
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.GoalValue))
 {
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.GoalValue, conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.SelfPerceivedValue))
 {
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.SelfPerceivedValue, conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdUser))
 {
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_KnowledgesUserMaster.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UpdUser); //修改人
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.Memo))
 {
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_KnowledgesUserMaster.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_KnowledgesUserMasterEN.mId); 
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strCondition)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_KnowledgesUserMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_KnowledgesUserMaster Set ");
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseId))
 {
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UserId))
 {
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId))
 {
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.RightCount))
 {
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.RightCount, conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId))
 {
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeId = '{0}',", strMasterTypeId); //掌握类型Id
 }
 else
 {
 sbSQL.Append(" MasterTypeId = null,"); //掌握类型Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.ErrorCount))
 {
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.ErrorCount, conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId))
 {
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterLevelId = '{0}',", strMasterLevelId); //掌握度Id
 }
 else
 {
 sbSQL.Append(" MasterLevelId = null,"); //掌握度Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasteryValue))
 {
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.MasteryValue, conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdDate))
 {
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.GoalValue))
 {
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.GoalValue, conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.SelfPerceivedValue))
 {
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.SelfPerceivedValue, conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdUser))
 {
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.Memo))
 {
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_KnowledgesUserMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_KnowledgesUserMaster Set ");
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseId))
 {
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UserId))
 {
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId))
 {
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.RightCount))
 {
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.RightCount, conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId))
 {
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterTypeId = '{0}',", strMasterTypeId); //掌握类型Id
 }
 else
 {
 sbSQL.Append(" MasterTypeId = null,"); //掌握类型Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.ErrorCount))
 {
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.ErrorCount, conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId))
 {
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MasterLevelId = '{0}',", strMasterLevelId); //掌握度Id
 }
 else
 {
 sbSQL.Append(" MasterLevelId = null,"); //掌握度Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasteryValue))
 {
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.MasteryValue, conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdDate))
 {
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.GoalValue))
 {
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.GoalValue, conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.SelfPerceivedValue))
 {
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.SelfPerceivedValue, conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdUser))
 {
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.Memo))
 {
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objge_KnowledgesUserMasterEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objge_KnowledgesUserMasterEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objge_KnowledgesUserMasterEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_KnowledgesUserMasterEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_KnowledgesUserMaster Set ");
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseId))
 {
 if (objge_KnowledgesUserMasterEN.CourseId  ==  "")
 {
 objge_KnowledgesUserMasterEN.CourseId = null;
 }
 if (objge_KnowledgesUserMasterEN.CourseId !=  null)
 {
 var strCourseId = objge_KnowledgesUserMasterEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_KnowledgesUserMaster.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.CourseId); //课程Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UserId))
 {
 if (objge_KnowledgesUserMasterEN.UserId !=  null)
 {
 var strUserId = objge_KnowledgesUserMasterEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conge_KnowledgesUserMaster.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UserId); //用户ID
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.CourseKnowledgeId))
 {
 if (objge_KnowledgesUserMasterEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objge_KnowledgesUserMasterEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conge_KnowledgesUserMaster.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.RightCount))
 {
 if (objge_KnowledgesUserMasterEN.RightCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.RightCount, conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.RightCount); //正确次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterTypeId))
 {
 if (objge_KnowledgesUserMasterEN.MasterTypeId !=  null)
 {
 var strMasterTypeId = objge_KnowledgesUserMasterEN.MasterTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterTypeId, conge_KnowledgesUserMaster.MasterTypeId); //掌握类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasterTypeId); //掌握类型Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.ErrorCount))
 {
 if (objge_KnowledgesUserMasterEN.ErrorCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.ErrorCount, conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.ErrorCount); //错误次数
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasterLevelId))
 {
 if (objge_KnowledgesUserMasterEN.MasterLevelId !=  null)
 {
 var strMasterLevelId = objge_KnowledgesUserMasterEN.MasterLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMasterLevelId, conge_KnowledgesUserMaster.MasterLevelId); //掌握度Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasterLevelId); //掌握度Id
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.MasteryValue))
 {
 if (objge_KnowledgesUserMasterEN.MasteryValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.MasteryValue, conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.MasteryValue); //掌握度
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdDate))
 {
 if (objge_KnowledgesUserMasterEN.UpdDate !=  null)
 {
 var strUpdDate = objge_KnowledgesUserMasterEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_KnowledgesUserMaster.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UpdDate); //修改日期
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.GoalValue))
 {
 if (objge_KnowledgesUserMasterEN.GoalValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.GoalValue, conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.GoalValue); //目标值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.SelfPerceivedValue))
 {
 if (objge_KnowledgesUserMasterEN.SelfPerceivedValue !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_KnowledgesUserMasterEN.SelfPerceivedValue, conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.SelfPerceivedValue); //自我认为值
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.UpdUser))
 {
 if (objge_KnowledgesUserMasterEN.UpdUser !=  null)
 {
 var strUpdUser = objge_KnowledgesUserMasterEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_KnowledgesUserMaster.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.UpdUser); //修改人
 }
 }
 
 if (objge_KnowledgesUserMasterEN.IsUpdated(conge_KnowledgesUserMaster.Memo))
 {
 if (objge_KnowledgesUserMasterEN.Memo !=  null)
 {
 var strMemo = objge_KnowledgesUserMasterEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_KnowledgesUserMaster.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_KnowledgesUserMaster.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objge_KnowledgesUserMasterEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("ge_KnowledgesUserMaster_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
//删除ge_KnowledgesUserMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_KnowledgesUserMaster where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_KnowledgesUserMaster(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
//删除ge_KnowledgesUserMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_KnowledgesUserMaster where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
//删除ge_KnowledgesUserMaster本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_KnowledgesUserMaster where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_KnowledgesUserMaster(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: Delge_KnowledgesUserMaster)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_KnowledgesUserMaster where " + strCondition ;
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
public bool Delge_KnowledgesUserMasterWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_KnowledgesUserMasterDA: Delge_KnowledgesUserMasterWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_KnowledgesUserMaster where " + strCondition ;
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
 /// <param name = "objge_KnowledgesUserMasterENS">源对象</param>
 /// <param name = "objge_KnowledgesUserMasterENT">目标对象</param>
public void CopyTo(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENS, clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterENT)
{
objge_KnowledgesUserMasterENT.mId = objge_KnowledgesUserMasterENS.mId; //mId
objge_KnowledgesUserMasterENT.CourseId = objge_KnowledgesUserMasterENS.CourseId; //课程Id
objge_KnowledgesUserMasterENT.UserId = objge_KnowledgesUserMasterENS.UserId; //用户ID
objge_KnowledgesUserMasterENT.CourseKnowledgeId = objge_KnowledgesUserMasterENS.CourseKnowledgeId; //知识点Id
objge_KnowledgesUserMasterENT.RightCount = objge_KnowledgesUserMasterENS.RightCount; //正确次数
objge_KnowledgesUserMasterENT.MasterTypeId = objge_KnowledgesUserMasterENS.MasterTypeId; //掌握类型Id
objge_KnowledgesUserMasterENT.ErrorCount = objge_KnowledgesUserMasterENS.ErrorCount; //错误次数
objge_KnowledgesUserMasterENT.MasterLevelId = objge_KnowledgesUserMasterENS.MasterLevelId; //掌握度Id
objge_KnowledgesUserMasterENT.MasteryValue = objge_KnowledgesUserMasterENS.MasteryValue; //掌握度
objge_KnowledgesUserMasterENT.UpdDate = objge_KnowledgesUserMasterENS.UpdDate; //修改日期
objge_KnowledgesUserMasterENT.GoalValue = objge_KnowledgesUserMasterENS.GoalValue; //目标值
objge_KnowledgesUserMasterENT.SelfPerceivedValue = objge_KnowledgesUserMasterENS.SelfPerceivedValue; //自我认为值
objge_KnowledgesUserMasterENT.UpdUser = objge_KnowledgesUserMasterENS.UpdUser; //修改人
objge_KnowledgesUserMasterENT.Memo = objge_KnowledgesUserMasterENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_KnowledgesUserMasterEN.CourseId, conge_KnowledgesUserMaster.CourseId);
clsCheckSql.CheckFieldNotNull(objge_KnowledgesUserMasterEN.UserId, conge_KnowledgesUserMaster.UserId);
clsCheckSql.CheckFieldNotNull(objge_KnowledgesUserMasterEN.CourseKnowledgeId, conge_KnowledgesUserMaster.CourseKnowledgeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UserId, 18, conge_KnowledgesUserMaster.UserId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseKnowledgeId, 8, conge_KnowledgesUserMaster.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterTypeId, 1, conge_KnowledgesUserMaster.MasterTypeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterLevelId, 4, conge_KnowledgesUserMaster.MasterLevelId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdDate, 20, conge_KnowledgesUserMaster.UpdDate);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdUser, 20, conge_KnowledgesUserMaster.UpdUser);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.Memo, 1000, conge_KnowledgesUserMaster.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
 objge_KnowledgesUserMasterEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UserId, 18, conge_KnowledgesUserMaster.UserId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseKnowledgeId, 8, conge_KnowledgesUserMaster.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterTypeId, 1, conge_KnowledgesUserMaster.MasterTypeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterLevelId, 4, conge_KnowledgesUserMaster.MasterLevelId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdDate, 20, conge_KnowledgesUserMaster.UpdDate);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdUser, 20, conge_KnowledgesUserMaster.UpdUser);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.Memo, 1000, conge_KnowledgesUserMaster.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
 objge_KnowledgesUserMasterEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UserId, 18, conge_KnowledgesUserMaster.UserId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.CourseKnowledgeId, 8, conge_KnowledgesUserMaster.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterTypeId, 1, conge_KnowledgesUserMaster.MasterTypeId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.MasterLevelId, 4, conge_KnowledgesUserMaster.MasterLevelId);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdDate, 20, conge_KnowledgesUserMaster.UpdDate);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.UpdUser, 20, conge_KnowledgesUserMaster.UpdUser);
clsCheckSql.CheckFieldLen(objge_KnowledgesUserMasterEN.Memo, 1000, conge_KnowledgesUserMaster.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.CourseId, conge_KnowledgesUserMaster.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.UserId, conge_KnowledgesUserMaster.UserId);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.CourseKnowledgeId, conge_KnowledgesUserMaster.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.MasterTypeId, conge_KnowledgesUserMaster.MasterTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.MasterLevelId, conge_KnowledgesUserMaster.MasterLevelId);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.UpdDate, conge_KnowledgesUserMaster.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.UpdUser, conge_KnowledgesUserMaster.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_KnowledgesUserMasterEN.Memo, conge_KnowledgesUserMaster.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objge_KnowledgesUserMasterEN.CourseId, 8, conge_KnowledgesUserMaster.CourseId);
 objge_KnowledgesUserMasterEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_KnowledgesUserMaster(知识点用户掌握),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_KnowledgesUserMasterEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_KnowledgesUserMasterEN objge_KnowledgesUserMasterEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objge_KnowledgesUserMasterEN.CourseKnowledgeId);
 sbCondition.AppendFormat(" and UserId = '{0}'", objge_KnowledgesUserMasterEN.UserId);
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_KnowledgesUserMasterEN._CurrTabName);
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_KnowledgesUserMasterEN._CurrTabName, strCondition);
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
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
 objSQL = clsge_KnowledgesUserMasterDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}