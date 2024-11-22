
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsge_GameLevelDA
 表名:ge_GameLevel(01120904)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:15
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
 /// 游戏关卡表(ge_GameLevel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsge_GameLevelDA : clsCommBase4DA
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
 return clsge_GameLevelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsge_GameLevelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsge_GameLevelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsge_GameLevelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsge_GameLevelEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strGameLevelId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strGameLevelId)
{
strGameLevelId = strGameLevelId.Replace("'", "''");
if (strGameLevelId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ge_GameLevel中,检查关键字,长度不正确!(clsge_GameLevelDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strGameLevelId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ge_GameLevel中,关键字不能为空 或 null!(clsge_GameLevelDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strGameLevelId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsge_GameLevelDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ge_GameLevel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable_ge_GameLevel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_GameLevel.* from ge_GameLevel Left Join {1} on {2} where {3} and ge_GameLevel.GameLevelId not in (Select top {5} ge_GameLevel.GameLevelId from ge_GameLevel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1} and GameLevelId not in (Select top {2} GameLevelId from ge_GameLevel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1} and GameLevelId not in (Select top {3} GameLevelId from ge_GameLevel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsge_GameLevelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ge_GameLevel.* from ge_GameLevel Left Join {1} on {2} where {3} and ge_GameLevel.GameLevelId not in (Select top {5} ge_GameLevel.GameLevelId from ge_GameLevel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1} and GameLevelId not in (Select top {2} GameLevelId from ge_GameLevel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ge_GameLevel where {1} and GameLevelId not in (Select top {3} GameLevelId from ge_GameLevel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsge_GameLevelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsge_GameLevelDA:GetObjLst)", objException.Message));
}
List<clsge_GameLevelEN> arrObjLst = new List<clsge_GameLevelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN();
try
{
objge_GameLevelEN.GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_GameLevelEN.GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称
objge_GameLevelEN.IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_GameLevelEN.CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id
objge_GameLevelEN.OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.OrderNum].ToString().Trim()); //序号
objge_GameLevelEN.DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id
objge_GameLevelEN.LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id
objge_GameLevelEN.QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id
objge_GameLevelEN.QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionNum].ToString().Trim()); //题目数
objge_GameLevelEN.QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionScore].ToString().Trim()); //题目分
objge_GameLevelEN.IsRecommend = TransNullToBool(objRow[conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐
objge_GameLevelEN.UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期
objge_GameLevelEN.UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人
objge_GameLevelEN.Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(); //备注
objge_GameLevelEN.TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_GameLevel.TotalScore].ToString().Trim()); //总得分
objge_GameLevelEN.InUse = TransNullToBool(objRow[conge_GameLevel.InUse].ToString().Trim()); //是否在用
objge_GameLevelEN.StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间
objge_GameLevelEN.EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_GameLevelDA: GetObjLst)", objException.Message));
}
objge_GameLevelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_GameLevelEN);
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
public List<clsge_GameLevelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsge_GameLevelDA:GetObjLstByTabName)", objException.Message));
}
List<clsge_GameLevelEN> arrObjLst = new List<clsge_GameLevelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN();
try
{
objge_GameLevelEN.GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_GameLevelEN.GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称
objge_GameLevelEN.IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_GameLevelEN.CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id
objge_GameLevelEN.OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.OrderNum].ToString().Trim()); //序号
objge_GameLevelEN.DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id
objge_GameLevelEN.LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id
objge_GameLevelEN.QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id
objge_GameLevelEN.QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionNum].ToString().Trim()); //题目数
objge_GameLevelEN.QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionScore].ToString().Trim()); //题目分
objge_GameLevelEN.IsRecommend = TransNullToBool(objRow[conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐
objge_GameLevelEN.UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期
objge_GameLevelEN.UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人
objge_GameLevelEN.Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(); //备注
objge_GameLevelEN.TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_GameLevel.TotalScore].ToString().Trim()); //总得分
objge_GameLevelEN.InUse = TransNullToBool(objRow[conge_GameLevel.InUse].ToString().Trim()); //是否在用
objge_GameLevelEN.StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间
objge_GameLevelEN.EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsge_GameLevelDA: GetObjLst)", objException.Message));
}
objge_GameLevelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objge_GameLevelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objge_GameLevelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getge_GameLevel(ref clsge_GameLevelEN objge_GameLevelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where GameLevelId = " + "'"+ objge_GameLevelEN.GameLevelId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objge_GameLevelEN.GameLevelId = objDT.Rows[0][conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_GameLevelEN.GameLevelName = objDT.Rows[0][conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_GameLevelEN.IdCurrEduCls = objDT.Rows[0][conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_GameLevelEN.CourseId = objDT.Rows[0][conge_GameLevel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_GameLevelEN.OrderNum = TransNullToInt(objDT.Rows[0][conge_GameLevel.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.DifficultyLevelId = objDT.Rows[0][conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objge_GameLevelEN.LevelModeTypeId = objDT.Rows[0][conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objge_GameLevelEN.QuestionTypeId = objDT.Rows[0][conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objge_GameLevelEN.QuestionNum = TransNullToInt(objDT.Rows[0][conge_GameLevel.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.QuestionScore = TransNullToInt(objDT.Rows[0][conge_GameLevel.QuestionScore].ToString().Trim()); //题目分(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.IsRecommend = TransNullToBool(objDT.Rows[0][conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_GameLevelEN.UpdDate = objDT.Rows[0][conge_GameLevel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.UpdUser = objDT.Rows[0][conge_GameLevel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.Memo = objDT.Rows[0][conge_GameLevel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_GameLevelEN.TotalScore = TransNullToDouble(objDT.Rows[0][conge_GameLevel.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objge_GameLevelEN.InUse = TransNullToBool(objDT.Rows[0][conge_GameLevel.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objge_GameLevelEN.StartTime = objDT.Rows[0][conge_GameLevel.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.EndTime = objDT.Rows[0][conge_GameLevel.EndTime].ToString().Trim(); //结束时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsge_GameLevelDA: Getge_GameLevel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strGameLevelId">表关键字</param>
 /// <returns>表对象</returns>
public clsge_GameLevelEN GetObjByGameLevelId(string strGameLevelId)
{
CheckPrimaryKey(strGameLevelId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where GameLevelId = " + "'"+ strGameLevelId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN();
try
{
 objge_GameLevelEN.GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id(字段类型:char,字段长度:8,是否可空:True)
 objge_GameLevelEN.GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称(字段类型:varchar,字段长度:100,是否可空:True)
 objge_GameLevelEN.IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objge_GameLevelEN.CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objge_GameLevelEN.OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_GameLevel.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
 objge_GameLevelEN.LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id(字段类型:char,字段长度:2,是否可空:False)
 objge_GameLevelEN.QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objge_GameLevelEN.QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_GameLevel.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conge_GameLevel.QuestionScore].ToString().Trim()); //题目分(字段类型:int,字段长度:4,是否可空:True)
 objge_GameLevelEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objge_GameLevelEN.UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objge_GameLevelEN.TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conge_GameLevel.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objge_GameLevelEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conge_GameLevel.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objge_GameLevelEN.StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间(字段类型:varchar,字段长度:20,是否可空:True)
 objge_GameLevelEN.EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsge_GameLevelDA: GetObjByGameLevelId)", objException.Message));
}
return objge_GameLevelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsge_GameLevelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsge_GameLevelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN()
{
GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(), //游戏关卡Id
GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(), //游戏关卡名称
IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(), //教学班流水号
CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(), //课程Id
OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.OrderNum].ToString().Trim()), //序号
DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(), //难度等级Id
LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(), //模式Id
QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionNum].ToString().Trim()), //题目数
QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionScore].ToString().Trim()), //题目分
IsRecommend = TransNullToBool(objRow[conge_GameLevel.IsRecommend].ToString().Trim()), //是否推荐
UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(), //备注
TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_GameLevel.TotalScore].ToString().Trim()), //总得分
InUse = TransNullToBool(objRow[conge_GameLevel.InUse].ToString().Trim()), //是否在用
StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(), //开始时间
EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim() //结束时间
};
objge_GameLevelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_GameLevelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsge_GameLevelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsge_GameLevelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN();
try
{
objge_GameLevelEN.GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_GameLevelEN.GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称
objge_GameLevelEN.IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_GameLevelEN.CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id
objge_GameLevelEN.OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.OrderNum].ToString().Trim()); //序号
objge_GameLevelEN.DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id
objge_GameLevelEN.LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id
objge_GameLevelEN.QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id
objge_GameLevelEN.QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionNum].ToString().Trim()); //题目数
objge_GameLevelEN.QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionScore].ToString().Trim()); //题目分
objge_GameLevelEN.IsRecommend = TransNullToBool(objRow[conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐
objge_GameLevelEN.UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期
objge_GameLevelEN.UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人
objge_GameLevelEN.Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(); //备注
objge_GameLevelEN.TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_GameLevel.TotalScore].ToString().Trim()); //总得分
objge_GameLevelEN.InUse = TransNullToBool(objRow[conge_GameLevel.InUse].ToString().Trim()); //是否在用
objge_GameLevelEN.StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间
objge_GameLevelEN.EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsge_GameLevelDA: GetObjByDataRowge_GameLevel)", objException.Message));
}
objge_GameLevelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_GameLevelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsge_GameLevelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsge_GameLevelEN objge_GameLevelEN = new clsge_GameLevelEN();
try
{
objge_GameLevelEN.GameLevelId = objRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id
objge_GameLevelEN.GameLevelName = objRow[conge_GameLevel.GameLevelName] == DBNull.Value ? null : objRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称
objge_GameLevelEN.IdCurrEduCls = objRow[conge_GameLevel.IdCurrEduCls] == DBNull.Value ? null : objRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号
objge_GameLevelEN.CourseId = objRow[conge_GameLevel.CourseId] == DBNull.Value ? null : objRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id
objge_GameLevelEN.OrderNum = objRow[conge_GameLevel.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.OrderNum].ToString().Trim()); //序号
objge_GameLevelEN.DifficultyLevelId = objRow[conge_GameLevel.DifficultyLevelId] == DBNull.Value ? null : objRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id
objge_GameLevelEN.LevelModeTypeId = objRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id
objge_GameLevelEN.QuestionTypeId = objRow[conge_GameLevel.QuestionTypeId] == DBNull.Value ? null : objRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id
objge_GameLevelEN.QuestionNum = objRow[conge_GameLevel.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionNum].ToString().Trim()); //题目数
objge_GameLevelEN.QuestionScore = objRow[conge_GameLevel.QuestionScore] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conge_GameLevel.QuestionScore].ToString().Trim()); //题目分
objge_GameLevelEN.IsRecommend = TransNullToBool(objRow[conge_GameLevel.IsRecommend].ToString().Trim()); //是否推荐
objge_GameLevelEN.UpdDate = objRow[conge_GameLevel.UpdDate] == DBNull.Value ? null : objRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期
objge_GameLevelEN.UpdUser = objRow[conge_GameLevel.UpdUser] == DBNull.Value ? null : objRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人
objge_GameLevelEN.Memo = objRow[conge_GameLevel.Memo] == DBNull.Value ? null : objRow[conge_GameLevel.Memo].ToString().Trim(); //备注
objge_GameLevelEN.TotalScore = objRow[conge_GameLevel.TotalScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conge_GameLevel.TotalScore].ToString().Trim()); //总得分
objge_GameLevelEN.InUse = TransNullToBool(objRow[conge_GameLevel.InUse].ToString().Trim()); //是否在用
objge_GameLevelEN.StartTime = objRow[conge_GameLevel.StartTime] == DBNull.Value ? null : objRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间
objge_GameLevelEN.EndTime = objRow[conge_GameLevel.EndTime] == DBNull.Value ? null : objRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsge_GameLevelDA: GetObjByDataRow)", objException.Message));
}
objge_GameLevelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objge_GameLevelEN;
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
objSQL = clsge_GameLevelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_GameLevelEN._CurrTabName, conge_GameLevel.GameLevelId, 8, "");
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
objSQL = clsge_GameLevelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsge_GameLevelEN._CurrTabName, conge_GameLevel.GameLevelId, 8, strPrefix);
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select GameLevelId from ge_GameLevel where " + strCondition;
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select GameLevelId from ge_GameLevel where " + strCondition;
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
 /// <param name = "strGameLevelId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strGameLevelId)
{
CheckPrimaryKey(strGameLevelId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_GameLevel", "GameLevelId = " + "'"+ strGameLevelId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsge_GameLevelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ge_GameLevel", strCondition))
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
objSQL = clsge_GameLevelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ge_GameLevel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsge_GameLevelEN objge_GameLevelEN)
 {
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_GameLevelEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_GameLevel");
objRow = objDS.Tables["ge_GameLevel"].NewRow();
objRow[conge_GameLevel.GameLevelId] = objge_GameLevelEN.GameLevelId; //游戏关卡Id
 if (objge_GameLevelEN.GameLevelName !=  "")
 {
objRow[conge_GameLevel.GameLevelName] = objge_GameLevelEN.GameLevelName; //游戏关卡名称
 }
 if (objge_GameLevelEN.IdCurrEduCls !=  "")
 {
objRow[conge_GameLevel.IdCurrEduCls] = objge_GameLevelEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_GameLevelEN.CourseId !=  "")
 {
objRow[conge_GameLevel.CourseId] = objge_GameLevelEN.CourseId; //课程Id
 }
objRow[conge_GameLevel.OrderNum] = objge_GameLevelEN.OrderNum; //序号
 if (objge_GameLevelEN.DifficultyLevelId !=  "")
 {
objRow[conge_GameLevel.DifficultyLevelId] = objge_GameLevelEN.DifficultyLevelId; //难度等级Id
 }
objRow[conge_GameLevel.LevelModeTypeId] = objge_GameLevelEN.LevelModeTypeId; //模式Id
 if (objge_GameLevelEN.QuestionTypeId !=  "")
 {
objRow[conge_GameLevel.QuestionTypeId] = objge_GameLevelEN.QuestionTypeId; //题目类型Id
 }
objRow[conge_GameLevel.QuestionNum] = objge_GameLevelEN.QuestionNum; //题目数
objRow[conge_GameLevel.QuestionScore] = objge_GameLevelEN.QuestionScore; //题目分
objRow[conge_GameLevel.IsRecommend] = objge_GameLevelEN.IsRecommend; //是否推荐
 if (objge_GameLevelEN.UpdDate !=  "")
 {
objRow[conge_GameLevel.UpdDate] = objge_GameLevelEN.UpdDate; //修改日期
 }
 if (objge_GameLevelEN.UpdUser !=  "")
 {
objRow[conge_GameLevel.UpdUser] = objge_GameLevelEN.UpdUser; //修改人
 }
 if (objge_GameLevelEN.Memo !=  "")
 {
objRow[conge_GameLevel.Memo] = objge_GameLevelEN.Memo; //备注
 }
objRow[conge_GameLevel.TotalScore] = objge_GameLevelEN.TotalScore; //总得分
objRow[conge_GameLevel.InUse] = objge_GameLevelEN.InUse; //是否在用
 if (objge_GameLevelEN.StartTime !=  "")
 {
objRow[conge_GameLevel.StartTime] = objge_GameLevelEN.StartTime; //开始时间
 }
 if (objge_GameLevelEN.EndTime !=  "")
 {
objRow[conge_GameLevel.EndTime] = objge_GameLevelEN.EndTime; //结束时间
 }
objDS.Tables[clsge_GameLevelEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsge_GameLevelEN._CurrTabName);
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
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_GameLevelEN objge_GameLevelEN)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_GameLevelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_GameLevelEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelId);
 var strGameLevelId = objge_GameLevelEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelName);
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelName + "'");
 }
 
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.IdCurrEduCls);
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_GameLevelEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.CourseId);
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.OrderNum);
 arrValueListForInsert.Add(objge_GameLevelEN.OrderNum.ToString());
 }
 
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.DifficultyLevelId);
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.LevelModeTypeId);
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionTypeId);
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionNum);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionNum.ToString());
 }
 
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionScore);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdDate);
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdUser);
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_GameLevelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.Memo);
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.TotalScore);
 arrValueListForInsert.Add(objge_GameLevelEN.TotalScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.InUse);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.StartTime);
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_GameLevelEN.EndTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.EndTime);
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_GameLevel");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_GameLevelEN objge_GameLevelEN)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_GameLevelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_GameLevelEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelId);
 var strGameLevelId = objge_GameLevelEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelName);
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelName + "'");
 }
 
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.IdCurrEduCls);
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_GameLevelEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.CourseId);
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.OrderNum);
 arrValueListForInsert.Add(objge_GameLevelEN.OrderNum.ToString());
 }
 
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.DifficultyLevelId);
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.LevelModeTypeId);
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionTypeId);
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionNum);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionNum.ToString());
 }
 
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionScore);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdDate);
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdUser);
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_GameLevelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.Memo);
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.TotalScore);
 arrValueListForInsert.Add(objge_GameLevelEN.TotalScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.InUse);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.StartTime);
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_GameLevelEN.EndTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.EndTime);
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_GameLevel");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objge_GameLevelEN.GameLevelId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsge_GameLevelEN objge_GameLevelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_GameLevelEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_GameLevelEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelId);
 var strGameLevelId = objge_GameLevelEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelName);
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelName + "'");
 }
 
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.IdCurrEduCls);
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_GameLevelEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.CourseId);
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.OrderNum);
 arrValueListForInsert.Add(objge_GameLevelEN.OrderNum.ToString());
 }
 
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.DifficultyLevelId);
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.LevelModeTypeId);
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionTypeId);
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionNum);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionNum.ToString());
 }
 
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionScore);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdDate);
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdUser);
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_GameLevelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.Memo);
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.TotalScore);
 arrValueListForInsert.Add(objge_GameLevelEN.TotalScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.InUse);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.StartTime);
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_GameLevelEN.EndTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.EndTime);
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_GameLevel");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objge_GameLevelEN.GameLevelId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsge_GameLevelEN objge_GameLevelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objge_GameLevelEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objge_GameLevelEN.GameLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelId);
 var strGameLevelId = objge_GameLevelEN.GameLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelId + "'");
 }
 
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.GameLevelName);
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGameLevelName + "'");
 }
 
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.IdCurrEduCls);
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objge_GameLevelEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.CourseId);
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.OrderNum);
 arrValueListForInsert.Add(objge_GameLevelEN.OrderNum.ToString());
 }
 
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.DifficultyLevelId);
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDifficultyLevelId + "'");
 }
 
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.LevelModeTypeId);
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLevelModeTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionTypeId);
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionNum);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionNum.ToString());
 }
 
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.QuestionScore);
 arrValueListForInsert.Add(objge_GameLevelEN.QuestionScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.IsRecommend);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdDate);
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.UpdUser);
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objge_GameLevelEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.Memo);
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.TotalScore);
 arrValueListForInsert.Add(objge_GameLevelEN.TotalScore.ToString());
 }
 
 arrFieldListForInsert.Add(conge_GameLevel.InUse);
 arrValueListForInsert.Add("'" + (objge_GameLevelEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objge_GameLevelEN.StartTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.StartTime);
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStartTime + "'");
 }
 
 if (objge_GameLevelEN.EndTime !=  null)
 {
 arrFieldListForInsert.Add(conge_GameLevel.EndTime);
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEndTime + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ge_GameLevel");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewge_GameLevels(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where GameLevelId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ge_GameLevel");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strGameLevelId = oRow[conge_GameLevel.GameLevelId].ToString().Trim();
if (IsExist(strGameLevelId))
{
 string strResult = "关键字变量值为:" + string.Format("GameLevelId = {0}", strGameLevelId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsge_GameLevelEN._CurrTabName ].NewRow();
objRow[conge_GameLevel.GameLevelId] = oRow[conge_GameLevel.GameLevelId].ToString().Trim(); //游戏关卡Id
objRow[conge_GameLevel.GameLevelName] = oRow[conge_GameLevel.GameLevelName].ToString().Trim(); //游戏关卡名称
objRow[conge_GameLevel.IdCurrEduCls] = oRow[conge_GameLevel.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conge_GameLevel.CourseId] = oRow[conge_GameLevel.CourseId].ToString().Trim(); //课程Id
objRow[conge_GameLevel.OrderNum] = oRow[conge_GameLevel.OrderNum].ToString().Trim(); //序号
objRow[conge_GameLevel.DifficultyLevelId] = oRow[conge_GameLevel.DifficultyLevelId].ToString().Trim(); //难度等级Id
objRow[conge_GameLevel.LevelModeTypeId] = oRow[conge_GameLevel.LevelModeTypeId].ToString().Trim(); //模式Id
objRow[conge_GameLevel.QuestionTypeId] = oRow[conge_GameLevel.QuestionTypeId].ToString().Trim(); //题目类型Id
objRow[conge_GameLevel.QuestionNum] = oRow[conge_GameLevel.QuestionNum].ToString().Trim(); //题目数
objRow[conge_GameLevel.QuestionScore] = oRow[conge_GameLevel.QuestionScore].ToString().Trim(); //题目分
objRow[conge_GameLevel.IsRecommend] = oRow[conge_GameLevel.IsRecommend].ToString().Trim(); //是否推荐
objRow[conge_GameLevel.UpdDate] = oRow[conge_GameLevel.UpdDate].ToString().Trim(); //修改日期
objRow[conge_GameLevel.UpdUser] = oRow[conge_GameLevel.UpdUser].ToString().Trim(); //修改人
objRow[conge_GameLevel.Memo] = oRow[conge_GameLevel.Memo].ToString().Trim(); //备注
objRow[conge_GameLevel.TotalScore] = oRow[conge_GameLevel.TotalScore].ToString().Trim(); //总得分
objRow[conge_GameLevel.InUse] = oRow[conge_GameLevel.InUse].ToString().Trim(); //是否在用
objRow[conge_GameLevel.StartTime] = oRow[conge_GameLevel.StartTime].ToString().Trim(); //开始时间
objRow[conge_GameLevel.EndTime] = oRow[conge_GameLevel.EndTime].ToString().Trim(); //结束时间
 objDS.Tables[clsge_GameLevelEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsge_GameLevelEN._CurrTabName);
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
 /// <param name = "objge_GameLevelEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsge_GameLevelEN objge_GameLevelEN)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_GameLevelEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
strSQL = "Select * from ge_GameLevel where GameLevelId = " + "'"+ objge_GameLevelEN.GameLevelId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsge_GameLevelEN._CurrTabName);
if (objDS.Tables[clsge_GameLevelEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:GameLevelId = " + "'"+ objge_GameLevelEN.GameLevelId+"'");
return false;
}
objRow = objDS.Tables[clsge_GameLevelEN._CurrTabName].Rows[0];
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelId))
 {
objRow[conge_GameLevel.GameLevelId] = objge_GameLevelEN.GameLevelId; //游戏关卡Id
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelName))
 {
objRow[conge_GameLevel.GameLevelName] = objge_GameLevelEN.GameLevelName; //游戏关卡名称
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IdCurrEduCls))
 {
objRow[conge_GameLevel.IdCurrEduCls] = objge_GameLevelEN.IdCurrEduCls; //教学班流水号
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.CourseId))
 {
objRow[conge_GameLevel.CourseId] = objge_GameLevelEN.CourseId; //课程Id
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.OrderNum))
 {
objRow[conge_GameLevel.OrderNum] = objge_GameLevelEN.OrderNum; //序号
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.DifficultyLevelId))
 {
objRow[conge_GameLevel.DifficultyLevelId] = objge_GameLevelEN.DifficultyLevelId; //难度等级Id
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.LevelModeTypeId))
 {
objRow[conge_GameLevel.LevelModeTypeId] = objge_GameLevelEN.LevelModeTypeId; //模式Id
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionTypeId))
 {
objRow[conge_GameLevel.QuestionTypeId] = objge_GameLevelEN.QuestionTypeId; //题目类型Id
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionNum))
 {
objRow[conge_GameLevel.QuestionNum] = objge_GameLevelEN.QuestionNum; //题目数
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionScore))
 {
objRow[conge_GameLevel.QuestionScore] = objge_GameLevelEN.QuestionScore; //题目分
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IsRecommend))
 {
objRow[conge_GameLevel.IsRecommend] = objge_GameLevelEN.IsRecommend; //是否推荐
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdDate))
 {
objRow[conge_GameLevel.UpdDate] = objge_GameLevelEN.UpdDate; //修改日期
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdUser))
 {
objRow[conge_GameLevel.UpdUser] = objge_GameLevelEN.UpdUser; //修改人
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.Memo))
 {
objRow[conge_GameLevel.Memo] = objge_GameLevelEN.Memo; //备注
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.TotalScore))
 {
objRow[conge_GameLevel.TotalScore] = objge_GameLevelEN.TotalScore; //总得分
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.InUse))
 {
objRow[conge_GameLevel.InUse] = objge_GameLevelEN.InUse; //是否在用
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.StartTime))
 {
objRow[conge_GameLevel.StartTime] = objge_GameLevelEN.StartTime; //开始时间
 }
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.EndTime))
 {
objRow[conge_GameLevel.EndTime] = objge_GameLevelEN.EndTime; //结束时间
 }
try
{
objDA.Update(objDS, clsge_GameLevelEN._CurrTabName);
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
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_GameLevelEN objge_GameLevelEN)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_GameLevelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ge_GameLevel Set ");
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelName))
 {
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelName, conge_GameLevel.GameLevelName); //游戏关卡名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.GameLevelName); //游戏关卡名称
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IdCurrEduCls))
 {
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_GameLevel.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.CourseId))
 {
 if (objge_GameLevelEN.CourseId !=  null)
 {
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_GameLevel.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.CourseId); //课程Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.OrderNum))
 {
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.OrderNum, conge_GameLevel.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.OrderNum); //序号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.DifficultyLevelId))
 {
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDifficultyLevelId, conge_GameLevel.DifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.DifficultyLevelId); //难度等级Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.LevelModeTypeId))
 {
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeId, conge_GameLevel.LevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.LevelModeTypeId); //模式Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionTypeId))
 {
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conge_GameLevel.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionNum))
 {
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionNum, conge_GameLevel.QuestionNum); //题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionNum); //题目数
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionScore))
 {
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionScore, conge_GameLevel.QuestionScore); //题目分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionScore); //题目分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_GameLevelEN.IsRecommend == true?"1":"0", conge_GameLevel.IsRecommend); //是否推荐
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdDate))
 {
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_GameLevel.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.UpdDate); //修改日期
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdUser))
 {
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_GameLevel.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.UpdUser); //修改人
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.Memo))
 {
 if (objge_GameLevelEN.Memo !=  null)
 {
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_GameLevel.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.Memo); //备注
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.TotalScore))
 {
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.TotalScore, conge_GameLevel.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.TotalScore); //总得分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_GameLevelEN.InUse == true?"1":"0", conge_GameLevel.InUse); //是否在用
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.StartTime))
 {
 if (objge_GameLevelEN.StartTime !=  null)
 {
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, conge_GameLevel.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.StartTime); //开始时间
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.EndTime))
 {
 if (objge_GameLevelEN.EndTime !=  null)
 {
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndTime, conge_GameLevel.EndTime); //结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.EndTime); //结束时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GameLevelId = '{0}'", objge_GameLevelEN.GameLevelId); 
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
 /// <param name = "objge_GameLevelEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsge_GameLevelEN objge_GameLevelEN, string strCondition)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_GameLevelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_GameLevel Set ");
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelName))
 {
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelName = '{0}',", strGameLevelName); //游戏关卡名称
 }
 else
 {
 sbSQL.Append(" GameLevelName = null,"); //游戏关卡名称
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IdCurrEduCls))
 {
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.CourseId))
 {
 if (objge_GameLevelEN.CourseId !=  null)
 {
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.OrderNum))
 {
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.OrderNum, conge_GameLevel.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.OrderNum); //序号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.DifficultyLevelId))
 {
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DifficultyLevelId = '{0}',", strDifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.Append(" DifficultyLevelId = null,"); //难度等级Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.LevelModeTypeId))
 {
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeId = '{0}',", strLevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.Append(" LevelModeTypeId = null,"); //模式Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionTypeId))
 {
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionNum))
 {
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionNum, conge_GameLevel.QuestionNum); //题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionNum); //题目数
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionScore))
 {
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionScore, conge_GameLevel.QuestionScore); //题目分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionScore); //题目分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_GameLevelEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdDate))
 {
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdUser))
 {
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.Memo))
 {
 if (objge_GameLevelEN.Memo !=  null)
 {
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.TotalScore))
 {
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.TotalScore, conge_GameLevel.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.TotalScore); //总得分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objge_GameLevelEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.StartTime))
 {
 if (objge_GameLevelEN.StartTime !=  null)
 {
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.EndTime))
 {
 if (objge_GameLevelEN.EndTime !=  null)
 {
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndTime = '{0}',", strEndTime); //结束时间
 }
 else
 {
 sbSQL.Append(" EndTime = null,"); //结束时间
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
 /// <param name = "objge_GameLevelEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsge_GameLevelEN objge_GameLevelEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_GameLevelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_GameLevel Set ");
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelName))
 {
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GameLevelName = '{0}',", strGameLevelName); //游戏关卡名称
 }
 else
 {
 sbSQL.Append(" GameLevelName = null,"); //游戏关卡名称
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IdCurrEduCls))
 {
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.CourseId))
 {
 if (objge_GameLevelEN.CourseId !=  null)
 {
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.OrderNum))
 {
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.OrderNum, conge_GameLevel.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.OrderNum); //序号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.DifficultyLevelId))
 {
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DifficultyLevelId = '{0}',", strDifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.Append(" DifficultyLevelId = null,"); //难度等级Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.LevelModeTypeId))
 {
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LevelModeTypeId = '{0}',", strLevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.Append(" LevelModeTypeId = null,"); //模式Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionTypeId))
 {
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionNum))
 {
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionNum, conge_GameLevel.QuestionNum); //题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionNum); //题目数
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionScore))
 {
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionScore, conge_GameLevel.QuestionScore); //题目分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionScore); //题目分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objge_GameLevelEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdDate))
 {
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdUser))
 {
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.Memo))
 {
 if (objge_GameLevelEN.Memo !=  null)
 {
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.TotalScore))
 {
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.TotalScore, conge_GameLevel.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.TotalScore); //总得分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objge_GameLevelEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.StartTime))
 {
 if (objge_GameLevelEN.StartTime !=  null)
 {
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StartTime = '{0}',", strStartTime); //开始时间
 }
 else
 {
 sbSQL.Append(" StartTime = null,"); //开始时间
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.EndTime))
 {
 if (objge_GameLevelEN.EndTime !=  null)
 {
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EndTime = '{0}',", strEndTime); //结束时间
 }
 else
 {
 sbSQL.Append(" EndTime = null,"); //结束时间
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
 /// <param name = "objge_GameLevelEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsge_GameLevelEN objge_GameLevelEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objge_GameLevelEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objge_GameLevelEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ge_GameLevel Set ");
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.GameLevelName))
 {
 if (objge_GameLevelEN.GameLevelName !=  null)
 {
 var strGameLevelName = objge_GameLevelEN.GameLevelName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGameLevelName, conge_GameLevel.GameLevelName); //游戏关卡名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.GameLevelName); //游戏关卡名称
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IdCurrEduCls))
 {
 if (objge_GameLevelEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objge_GameLevelEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conge_GameLevel.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.CourseId))
 {
 if (objge_GameLevelEN.CourseId !=  null)
 {
 var strCourseId = objge_GameLevelEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conge_GameLevel.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.CourseId); //课程Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.OrderNum))
 {
 if (objge_GameLevelEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.OrderNum, conge_GameLevel.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.OrderNum); //序号
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.DifficultyLevelId))
 {
 if (objge_GameLevelEN.DifficultyLevelId !=  null)
 {
 var strDifficultyLevelId = objge_GameLevelEN.DifficultyLevelId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDifficultyLevelId, conge_GameLevel.DifficultyLevelId); //难度等级Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.DifficultyLevelId); //难度等级Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.LevelModeTypeId))
 {
 if (objge_GameLevelEN.LevelModeTypeId !=  null)
 {
 var strLevelModeTypeId = objge_GameLevelEN.LevelModeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLevelModeTypeId, conge_GameLevel.LevelModeTypeId); //模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.LevelModeTypeId); //模式Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionTypeId))
 {
 if (objge_GameLevelEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objge_GameLevelEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, conge_GameLevel.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionNum))
 {
 if (objge_GameLevelEN.QuestionNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionNum, conge_GameLevel.QuestionNum); //题目数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionNum); //题目数
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.QuestionScore))
 {
 if (objge_GameLevelEN.QuestionScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.QuestionScore, conge_GameLevel.QuestionScore); //题目分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.QuestionScore); //题目分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_GameLevelEN.IsRecommend == true?"1":"0", conge_GameLevel.IsRecommend); //是否推荐
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdDate))
 {
 if (objge_GameLevelEN.UpdDate !=  null)
 {
 var strUpdDate = objge_GameLevelEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conge_GameLevel.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.UpdDate); //修改日期
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.UpdUser))
 {
 if (objge_GameLevelEN.UpdUser !=  null)
 {
 var strUpdUser = objge_GameLevelEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conge_GameLevel.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.UpdUser); //修改人
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.Memo))
 {
 if (objge_GameLevelEN.Memo !=  null)
 {
 var strMemo = objge_GameLevelEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conge_GameLevel.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.Memo); //备注
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.TotalScore))
 {
 if (objge_GameLevelEN.TotalScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objge_GameLevelEN.TotalScore, conge_GameLevel.TotalScore); //总得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.TotalScore); //总得分
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objge_GameLevelEN.InUse == true?"1":"0", conge_GameLevel.InUse); //是否在用
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.StartTime))
 {
 if (objge_GameLevelEN.StartTime !=  null)
 {
 var strStartTime = objge_GameLevelEN.StartTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStartTime, conge_GameLevel.StartTime); //开始时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.StartTime); //开始时间
 }
 }
 
 if (objge_GameLevelEN.IsUpdated(conge_GameLevel.EndTime))
 {
 if (objge_GameLevelEN.EndTime !=  null)
 {
 var strEndTime = objge_GameLevelEN.EndTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEndTime, conge_GameLevel.EndTime); //结束时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conge_GameLevel.EndTime); //结束时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where GameLevelId = '{0}'", objge_GameLevelEN.GameLevelId); 
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
 /// <param name = "strGameLevelId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strGameLevelId) 
{
CheckPrimaryKey(strGameLevelId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strGameLevelId,
};
 objSQL.ExecSP("ge_GameLevel_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strGameLevelId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strGameLevelId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strGameLevelId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
//删除ge_GameLevel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_GameLevel where GameLevelId = " + "'"+ strGameLevelId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delge_GameLevel(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
//删除ge_GameLevel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_GameLevel where GameLevelId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strGameLevelId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strGameLevelId) 
{
CheckPrimaryKey(strGameLevelId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
//删除ge_GameLevel本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ge_GameLevel where GameLevelId = " + "'"+ strGameLevelId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delge_GameLevel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsge_GameLevelDA: Delge_GameLevel)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_GameLevel where " + strCondition ;
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
public bool Delge_GameLevelWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsge_GameLevelDA: Delge_GameLevelWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ge_GameLevel where " + strCondition ;
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
 /// <param name = "objge_GameLevelENS">源对象</param>
 /// <param name = "objge_GameLevelENT">目标对象</param>
public void CopyTo(clsge_GameLevelEN objge_GameLevelENS, clsge_GameLevelEN objge_GameLevelENT)
{
objge_GameLevelENT.GameLevelId = objge_GameLevelENS.GameLevelId; //游戏关卡Id
objge_GameLevelENT.GameLevelName = objge_GameLevelENS.GameLevelName; //游戏关卡名称
objge_GameLevelENT.IdCurrEduCls = objge_GameLevelENS.IdCurrEduCls; //教学班流水号
objge_GameLevelENT.CourseId = objge_GameLevelENS.CourseId; //课程Id
objge_GameLevelENT.OrderNum = objge_GameLevelENS.OrderNum; //序号
objge_GameLevelENT.DifficultyLevelId = objge_GameLevelENS.DifficultyLevelId; //难度等级Id
objge_GameLevelENT.LevelModeTypeId = objge_GameLevelENS.LevelModeTypeId; //模式Id
objge_GameLevelENT.QuestionTypeId = objge_GameLevelENS.QuestionTypeId; //题目类型Id
objge_GameLevelENT.QuestionNum = objge_GameLevelENS.QuestionNum; //题目数
objge_GameLevelENT.QuestionScore = objge_GameLevelENS.QuestionScore; //题目分
objge_GameLevelENT.IsRecommend = objge_GameLevelENS.IsRecommend; //是否推荐
objge_GameLevelENT.UpdDate = objge_GameLevelENS.UpdDate; //修改日期
objge_GameLevelENT.UpdUser = objge_GameLevelENS.UpdUser; //修改人
objge_GameLevelENT.Memo = objge_GameLevelENS.Memo; //备注
objge_GameLevelENT.TotalScore = objge_GameLevelENS.TotalScore; //总得分
objge_GameLevelENT.InUse = objge_GameLevelENS.InUse; //是否在用
objge_GameLevelENT.StartTime = objge_GameLevelENS.StartTime; //开始时间
objge_GameLevelENT.EndTime = objge_GameLevelENS.EndTime; //结束时间
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsge_GameLevelEN objge_GameLevelEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objge_GameLevelEN.LevelModeTypeId, conge_GameLevel.LevelModeTypeId);
//检查字段长度
clsCheckSql.CheckFieldLen(objge_GameLevelEN.GameLevelId, 8, conge_GameLevel.GameLevelId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.GameLevelName, 100, conge_GameLevel.GameLevelName);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.IdCurrEduCls, 8, conge_GameLevel.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.CourseId, 8, conge_GameLevel.CourseId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.DifficultyLevelId, 2, conge_GameLevel.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.LevelModeTypeId, 2, conge_GameLevel.LevelModeTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.QuestionTypeId, 2, conge_GameLevel.QuestionTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdDate, 20, conge_GameLevel.UpdDate);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdUser, 20, conge_GameLevel.UpdUser);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.Memo, 1000, conge_GameLevel.Memo);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.StartTime, 20, conge_GameLevel.StartTime);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.EndTime, 20, conge_GameLevel.EndTime);
//检查字段外键固定长度
 objge_GameLevelEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsge_GameLevelEN objge_GameLevelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_GameLevelEN.GameLevelName, 100, conge_GameLevel.GameLevelName);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.IdCurrEduCls, 8, conge_GameLevel.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.CourseId, 8, conge_GameLevel.CourseId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.DifficultyLevelId, 2, conge_GameLevel.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.LevelModeTypeId, 2, conge_GameLevel.LevelModeTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.QuestionTypeId, 2, conge_GameLevel.QuestionTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdDate, 20, conge_GameLevel.UpdDate);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdUser, 20, conge_GameLevel.UpdUser);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.Memo, 1000, conge_GameLevel.Memo);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.StartTime, 20, conge_GameLevel.StartTime);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.EndTime, 20, conge_GameLevel.EndTime);
//检查外键字段长度
 objge_GameLevelEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsge_GameLevelEN objge_GameLevelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objge_GameLevelEN.GameLevelId, 8, conge_GameLevel.GameLevelId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.GameLevelName, 100, conge_GameLevel.GameLevelName);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.IdCurrEduCls, 8, conge_GameLevel.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.CourseId, 8, conge_GameLevel.CourseId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.DifficultyLevelId, 2, conge_GameLevel.DifficultyLevelId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.LevelModeTypeId, 2, conge_GameLevel.LevelModeTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.QuestionTypeId, 2, conge_GameLevel.QuestionTypeId);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdDate, 20, conge_GameLevel.UpdDate);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.UpdUser, 20, conge_GameLevel.UpdUser);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.Memo, 1000, conge_GameLevel.Memo);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.StartTime, 20, conge_GameLevel.StartTime);
clsCheckSql.CheckFieldLen(objge_GameLevelEN.EndTime, 20, conge_GameLevel.EndTime);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.GameLevelId, conge_GameLevel.GameLevelId);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.GameLevelName, conge_GameLevel.GameLevelName);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.IdCurrEduCls, conge_GameLevel.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.CourseId, conge_GameLevel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.DifficultyLevelId, conge_GameLevel.DifficultyLevelId);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.LevelModeTypeId, conge_GameLevel.LevelModeTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.QuestionTypeId, conge_GameLevel.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.UpdDate, conge_GameLevel.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.UpdUser, conge_GameLevel.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.Memo, conge_GameLevel.Memo);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.StartTime, conge_GameLevel.StartTime);
clsCheckSql.CheckSqlInjection4Field(objge_GameLevelEN.EndTime, conge_GameLevel.EndTime);
//检查外键字段长度
 objge_GameLevelEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetGameLevelId()
{
//获取某学院所有专业信息
string strSQL = "select GameLevelId, GameLevelName from ge_GameLevel ";
 clsSpecSQLforSql mySql = clsge_GameLevelDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ge_GameLevel(游戏关卡表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objge_GameLevelEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsge_GameLevelEN objge_GameLevelEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objge_GameLevelEN.GameLevelName == null)
{
 sbCondition.AppendFormat(" and GameLevelName is null");
}
else
{
 sbCondition.AppendFormat(" and GameLevelName = '{0}'", objge_GameLevelEN.GameLevelName);
}
 if (objge_GameLevelEN.CourseId == null)
{
 sbCondition.AppendFormat(" and CourseId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseId = '{0}'", objge_GameLevelEN.CourseId);
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_GameLevelEN._CurrTabName);
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsge_GameLevelEN._CurrTabName, strCondition);
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
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
 objSQL = clsge_GameLevelDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}