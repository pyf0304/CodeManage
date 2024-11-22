
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnTotalDA
 表名:KnowledgeLearnTotal(01120155)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:50
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
 /// 知识点学习汇总表(KnowledgeLearnTotal)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsKnowledgeLearnTotalDA : clsCommBase4DA
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
 return clsKnowledgeLearnTotalEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsKnowledgeLearnTotalEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeLearnTotalEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsKnowledgeLearnTotalEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsKnowledgeLearnTotalEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_KnowledgeLearnTotal(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable_KnowledgeLearnTotal)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeLearnTotal.* from KnowledgeLearnTotal Left Join {1} on {2} where {3} and KnowledgeLearnTotal.mId not in (Select top {5} KnowledgeLearnTotal.mId from KnowledgeLearnTotal Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1} and mId not in (Select top {2} mId from KnowledgeLearnTotal where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1} and mId not in (Select top {3} mId from KnowledgeLearnTotal where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeLearnTotal.* from KnowledgeLearnTotal Left Join {1} on {2} where {3} and KnowledgeLearnTotal.mId not in (Select top {5} KnowledgeLearnTotal.mId from KnowledgeLearnTotal Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1} and mId not in (Select top {2} mId from KnowledgeLearnTotal where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnTotal where {1} and mId not in (Select top {3} mId from KnowledgeLearnTotal where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsKnowledgeLearnTotalEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA:GetObjLst)", objException.Message));
}
List<clsKnowledgeLearnTotalEN> arrObjLst = new List<clsKnowledgeLearnTotalEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN();
try
{
objKnowledgeLearnTotalEN.mId = TransNullToInt(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objKnowledgeLearnTotalEN.UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnTotalEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnTotalEN.LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnTotalEN.SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objKnowledgeLearnTotalEN.FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objKnowledgeLearnTotalEN.ContinuousSuccessCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数
objKnowledgeLearnTotalEN.ContinuousFailCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数
objKnowledgeLearnTotalEN.LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objKnowledgeLearnTotalEN.CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnTotalEN.UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnTotalEN.UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnTotalEN.Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetObjLst)", objException.Message));
}
objKnowledgeLearnTotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeLearnTotalEN);
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
public List<clsKnowledgeLearnTotalEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA:GetObjLstByTabName)", objException.Message));
}
List<clsKnowledgeLearnTotalEN> arrObjLst = new List<clsKnowledgeLearnTotalEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN();
try
{
objKnowledgeLearnTotalEN.mId = TransNullToInt(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objKnowledgeLearnTotalEN.UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnTotalEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnTotalEN.LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnTotalEN.SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objKnowledgeLearnTotalEN.FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objKnowledgeLearnTotalEN.ContinuousSuccessCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数
objKnowledgeLearnTotalEN.ContinuousFailCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数
objKnowledgeLearnTotalEN.LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objKnowledgeLearnTotalEN.CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnTotalEN.UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnTotalEN.UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnTotalEN.Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetObjLst)", objException.Message));
}
objKnowledgeLearnTotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeLearnTotalEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetKnowledgeLearnTotal(ref clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where mId = " + ""+ objKnowledgeLearnTotalEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objKnowledgeLearnTotalEN.mId = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objKnowledgeLearnTotalEN.UserId = objDT.Rows[0][conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objKnowledgeLearnTotalEN.MasterDegree = TransNullToDouble(objDT.Rows[0][conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度(字段类型:numeric,字段长度:20,是否可空:False)
 objKnowledgeLearnTotalEN.LearnCount = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.CourseKnowledgeId = objDT.Rows[0][conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnTotalEN.SuccessCount = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.FailCount = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.ContinuousSuccessCount = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数(字段类型:int,字段长度:4,是否可空:False)
 objKnowledgeLearnTotalEN.ContinuousFailCount = TransNullToInt(objDT.Rows[0][conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数(字段类型:int,字段长度:4,是否可空:False)
 objKnowledgeLearnTotalEN.LastLearnDate = objDT.Rows[0][conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objDT.Rows[0][conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnTotalEN.CourseId = objDT.Rows[0][conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeLearnTotalEN.UpdDate = objDT.Rows[0][conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnTotalEN.UpdUser = objDT.Rows[0][conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnTotalEN.Memo = objDT.Rows[0][conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetKnowledgeLearnTotal)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsKnowledgeLearnTotalEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN();
try
{
 objKnowledgeLearnTotalEN.mId = Int32.Parse(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objKnowledgeLearnTotalEN.UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objKnowledgeLearnTotalEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度(字段类型:numeric,字段长度:20,是否可空:False)
 objKnowledgeLearnTotalEN.LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnTotalEN.SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数(字段类型:int,字段长度:4,是否可空:True)
 objKnowledgeLearnTotalEN.ContinuousSuccessCount = Int32.Parse(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数(字段类型:int,字段长度:4,是否可空:False)
 objKnowledgeLearnTotalEN.ContinuousFailCount = Int32.Parse(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数(字段类型:int,字段长度:4,是否可空:False)
 objKnowledgeLearnTotalEN.LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnTotalEN.CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeLearnTotalEN.UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnTotalEN.UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnTotalEN.Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetObjBymId)", objException.Message));
}
return objKnowledgeLearnTotalEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsKnowledgeLearnTotalEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN()
{
mId = TransNullToInt(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()), //mId
UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(), //用户ID
MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()), //掌握程度
LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()), //学习次数
CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(), //知识点Id
SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()), //成功次数
FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()), //失败次数
ContinuousSuccessCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()), //连续成功次数
ContinuousFailCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()), //连续失败次数
LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(), //最后学习日期
RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(), //推荐下次复习日期
CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim() //备注
};
objKnowledgeLearnTotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnTotalEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsKnowledgeLearnTotalEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN();
try
{
objKnowledgeLearnTotalEN.mId = TransNullToInt(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objKnowledgeLearnTotalEN.UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnTotalEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnTotalEN.LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnTotalEN.SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objKnowledgeLearnTotalEN.FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objKnowledgeLearnTotalEN.ContinuousSuccessCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数
objKnowledgeLearnTotalEN.ContinuousFailCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数
objKnowledgeLearnTotalEN.LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objKnowledgeLearnTotalEN.CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnTotalEN.UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnTotalEN.UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnTotalEN.Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetObjByDataRowKnowledgeLearnTotal)", objException.Message));
}
objKnowledgeLearnTotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnTotalEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsKnowledgeLearnTotalEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN = new clsKnowledgeLearnTotalEN();
try
{
objKnowledgeLearnTotalEN.mId = TransNullToInt(objRow[conKnowledgeLearnTotal.mId].ToString().Trim()); //mId
objKnowledgeLearnTotalEN.UserId = objRow[conKnowledgeLearnTotal.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnTotalEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnTotalEN.LearnCount = objRow[conKnowledgeLearnTotal.LearnCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim()); //学习次数
objKnowledgeLearnTotalEN.CourseKnowledgeId = objRow[conKnowledgeLearnTotal.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnTotalEN.SuccessCount = objRow[conKnowledgeLearnTotal.SuccessCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim()); //成功次数
objKnowledgeLearnTotalEN.FailCount = objRow[conKnowledgeLearnTotal.FailCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conKnowledgeLearnTotal.FailCount].ToString().Trim()); //失败次数
objKnowledgeLearnTotalEN.ContinuousSuccessCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim()); //连续成功次数
objKnowledgeLearnTotalEN.ContinuousFailCount = TransNullToInt(objRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim()); //连续失败次数
objKnowledgeLearnTotalEN.LastLearnDate = objRow[conKnowledgeLearnTotal.LastLearnDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objKnowledgeLearnTotalEN.RecommendedNextReviewDate = objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objKnowledgeLearnTotalEN.CourseId = objRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnTotalEN.UpdDate = objRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnTotalEN.UpdUser = objRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnTotalEN.Memo = objRow[conKnowledgeLearnTotal.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsKnowledgeLearnTotalDA: GetObjByDataRow)", objException.Message));
}
objKnowledgeLearnTotalEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnTotalEN;
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
objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeLearnTotalEN._CurrTabName, conKnowledgeLearnTotal.mId, 8, "");
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
objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeLearnTotalEN._CurrTabName, conKnowledgeLearnTotal.mId, 8, strPrefix);
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from KnowledgeLearnTotal where " + strCondition;
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from KnowledgeLearnTotal where " + strCondition;
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeLearnTotal", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeLearnTotal", strCondition))
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
objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("KnowledgeLearnTotal");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
 {
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnTotalEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeLearnTotal");
objRow = objDS.Tables["KnowledgeLearnTotal"].NewRow();
 if (objKnowledgeLearnTotalEN.UserId !=  "")
 {
objRow[conKnowledgeLearnTotal.UserId] = objKnowledgeLearnTotalEN.UserId; //用户ID
 }
objRow[conKnowledgeLearnTotal.MasterDegree] = objKnowledgeLearnTotalEN.MasterDegree; //掌握程度
objRow[conKnowledgeLearnTotal.LearnCount] = objKnowledgeLearnTotalEN.LearnCount; //学习次数
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  "")
 {
objRow[conKnowledgeLearnTotal.CourseKnowledgeId] = objKnowledgeLearnTotalEN.CourseKnowledgeId; //知识点Id
 }
objRow[conKnowledgeLearnTotal.SuccessCount] = objKnowledgeLearnTotalEN.SuccessCount; //成功次数
objRow[conKnowledgeLearnTotal.FailCount] = objKnowledgeLearnTotalEN.FailCount; //失败次数
objRow[conKnowledgeLearnTotal.ContinuousSuccessCount] = objKnowledgeLearnTotalEN.ContinuousSuccessCount; //连续成功次数
objRow[conKnowledgeLearnTotal.ContinuousFailCount] = objKnowledgeLearnTotalEN.ContinuousFailCount; //连续失败次数
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  "")
 {
objRow[conKnowledgeLearnTotal.LastLearnDate] = objKnowledgeLearnTotalEN.LastLearnDate; //最后学习日期
 }
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  "")
 {
objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] = objKnowledgeLearnTotalEN.RecommendedNextReviewDate; //推荐下次复习日期
 }
objRow[conKnowledgeLearnTotal.CourseId] = objKnowledgeLearnTotalEN.CourseId; //课程Id
objRow[conKnowledgeLearnTotal.UpdDate] = objKnowledgeLearnTotalEN.UpdDate; //修改日期
objRow[conKnowledgeLearnTotal.UpdUser] = objKnowledgeLearnTotalEN.UpdUser; //修改人
 if (objKnowledgeLearnTotalEN.Memo !=  "")
 {
objRow[conKnowledgeLearnTotal.Memo] = objKnowledgeLearnTotalEN.Memo; //备注
 }
objDS.Tables[clsKnowledgeLearnTotalEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsKnowledgeLearnTotalEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnTotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UserId);
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LearnCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.LearnCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.SuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.SuccessCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.FailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.FailCount.ToString());
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousSuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousSuccessCount.ToString());
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousFailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousFailCount.ToString());
 
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LastLearnDate);
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastLearnDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate);
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedNextReviewDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseId);
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdDate);
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdUser);
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.Memo);
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnTotal");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnTotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UserId);
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LearnCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.LearnCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.SuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.SuccessCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.FailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.FailCount.ToString());
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousSuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousSuccessCount.ToString());
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousFailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousFailCount.ToString());
 
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LastLearnDate);
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastLearnDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate);
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedNextReviewDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseId);
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdDate);
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdUser);
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.Memo);
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnTotal");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnTotalEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UserId);
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LearnCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.LearnCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.SuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.SuccessCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.FailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.FailCount.ToString());
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousSuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousSuccessCount.ToString());
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousFailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousFailCount.ToString());
 
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LastLearnDate);
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastLearnDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate);
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedNextReviewDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseId);
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdDate);
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdUser);
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.Memo);
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnTotal");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnTotalEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UserId);
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LearnCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.LearnCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.SuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.SuccessCount.ToString());
 }
 
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.FailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.FailCount.ToString());
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousSuccessCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousSuccessCount.ToString());
 
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.ContinuousFailCount);
 arrValueListForInsert.Add(objKnowledgeLearnTotalEN.ContinuousFailCount.ToString());
 
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.LastLearnDate);
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLastLearnDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.RecommendedNextReviewDate);
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecommendedNextReviewDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.CourseId);
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdDate);
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.UpdUser);
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnTotal.Memo);
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnTotal");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewKnowledgeLearnTotals(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeLearnTotal");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsKnowledgeLearnTotalEN._CurrTabName ].NewRow();
objRow[conKnowledgeLearnTotal.UserId] = oRow[conKnowledgeLearnTotal.UserId].ToString().Trim(); //用户ID
objRow[conKnowledgeLearnTotal.MasterDegree] = oRow[conKnowledgeLearnTotal.MasterDegree].ToString().Trim(); //掌握程度
objRow[conKnowledgeLearnTotal.LearnCount] = oRow[conKnowledgeLearnTotal.LearnCount].ToString().Trim(); //学习次数
objRow[conKnowledgeLearnTotal.CourseKnowledgeId] = oRow[conKnowledgeLearnTotal.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[conKnowledgeLearnTotal.SuccessCount] = oRow[conKnowledgeLearnTotal.SuccessCount].ToString().Trim(); //成功次数
objRow[conKnowledgeLearnTotal.FailCount] = oRow[conKnowledgeLearnTotal.FailCount].ToString().Trim(); //失败次数
objRow[conKnowledgeLearnTotal.ContinuousSuccessCount] = oRow[conKnowledgeLearnTotal.ContinuousSuccessCount].ToString().Trim(); //连续成功次数
objRow[conKnowledgeLearnTotal.ContinuousFailCount] = oRow[conKnowledgeLearnTotal.ContinuousFailCount].ToString().Trim(); //连续失败次数
objRow[conKnowledgeLearnTotal.LastLearnDate] = oRow[conKnowledgeLearnTotal.LastLearnDate].ToString().Trim(); //最后学习日期
objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] = oRow[conKnowledgeLearnTotal.RecommendedNextReviewDate].ToString().Trim(); //推荐下次复习日期
objRow[conKnowledgeLearnTotal.CourseId] = oRow[conKnowledgeLearnTotal.CourseId].ToString().Trim(); //课程Id
objRow[conKnowledgeLearnTotal.UpdDate] = oRow[conKnowledgeLearnTotal.UpdDate].ToString().Trim(); //修改日期
objRow[conKnowledgeLearnTotal.UpdUser] = oRow[conKnowledgeLearnTotal.UpdUser].ToString().Trim(); //修改人
objRow[conKnowledgeLearnTotal.Memo] = oRow[conKnowledgeLearnTotal.Memo].ToString().Trim(); //备注
 objDS.Tables[clsKnowledgeLearnTotalEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsKnowledgeLearnTotalEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnTotalEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnTotalEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnTotal where mId = " + ""+ objKnowledgeLearnTotalEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsKnowledgeLearnTotalEN._CurrTabName);
if (objDS.Tables[clsKnowledgeLearnTotalEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objKnowledgeLearnTotalEN.mId+"");
return false;
}
objRow = objDS.Tables[clsKnowledgeLearnTotalEN._CurrTabName].Rows[0];
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UserId))
 {
objRow[conKnowledgeLearnTotal.UserId] = objKnowledgeLearnTotalEN.UserId; //用户ID
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.MasterDegree))
 {
objRow[conKnowledgeLearnTotal.MasterDegree] = objKnowledgeLearnTotalEN.MasterDegree; //掌握程度
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LearnCount))
 {
objRow[conKnowledgeLearnTotal.LearnCount] = objKnowledgeLearnTotalEN.LearnCount; //学习次数
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId))
 {
objRow[conKnowledgeLearnTotal.CourseKnowledgeId] = objKnowledgeLearnTotalEN.CourseKnowledgeId; //知识点Id
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.SuccessCount))
 {
objRow[conKnowledgeLearnTotal.SuccessCount] = objKnowledgeLearnTotalEN.SuccessCount; //成功次数
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.FailCount))
 {
objRow[conKnowledgeLearnTotal.FailCount] = objKnowledgeLearnTotalEN.FailCount; //失败次数
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount))
 {
objRow[conKnowledgeLearnTotal.ContinuousSuccessCount] = objKnowledgeLearnTotalEN.ContinuousSuccessCount; //连续成功次数
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount))
 {
objRow[conKnowledgeLearnTotal.ContinuousFailCount] = objKnowledgeLearnTotalEN.ContinuousFailCount; //连续失败次数
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LastLearnDate))
 {
objRow[conKnowledgeLearnTotal.LastLearnDate] = objKnowledgeLearnTotalEN.LastLearnDate; //最后学习日期
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate))
 {
objRow[conKnowledgeLearnTotal.RecommendedNextReviewDate] = objKnowledgeLearnTotalEN.RecommendedNextReviewDate; //推荐下次复习日期
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseId))
 {
objRow[conKnowledgeLearnTotal.CourseId] = objKnowledgeLearnTotalEN.CourseId; //课程Id
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdDate))
 {
objRow[conKnowledgeLearnTotal.UpdDate] = objKnowledgeLearnTotalEN.UpdDate; //修改日期
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdUser))
 {
objRow[conKnowledgeLearnTotal.UpdUser] = objKnowledgeLearnTotalEN.UpdUser; //修改人
 }
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.Memo))
 {
objRow[conKnowledgeLearnTotal.Memo] = objKnowledgeLearnTotalEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsKnowledgeLearnTotalEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnTotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update KnowledgeLearnTotal Set ");
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UserId))
 {
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conKnowledgeLearnTotal.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UserId); //用户ID
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.MasterDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.MasterDegree, conKnowledgeLearnTotal.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LearnCount))
 {
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.LearnCount, conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId))
 {
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conKnowledgeLearnTotal.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.SuccessCount))
 {
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.SuccessCount, conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.FailCount))
 {
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.FailCount, conKnowledgeLearnTotal.FailCount); //失败次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.FailCount); //失败次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.ContinuousSuccessCount, conKnowledgeLearnTotal.ContinuousSuccessCount); //连续成功次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.ContinuousFailCount, conKnowledgeLearnTotal.ContinuousFailCount); //连续失败次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LastLearnDate))
 {
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastLearnDate, conKnowledgeLearnTotal.LastLearnDate); //最后学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LastLearnDate); //最后学习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate))
 {
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedNextReviewDate, conKnowledgeLearnTotal.RecommendedNextReviewDate); //推荐下次复习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.RecommendedNextReviewDate); //推荐下次复习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseId))
 {
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeLearnTotal.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdDate))
 {
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeLearnTotal.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdUser))
 {
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeLearnTotal.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.Memo))
 {
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeLearnTotal.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objKnowledgeLearnTotalEN.mId); 
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
 /// <param name = "objKnowledgeLearnTotalEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strCondition)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnTotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnTotal Set ");
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UserId))
 {
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.MasterDegree))
 {
 sbSQL.AppendFormat(" MasterDegree = {0},", objKnowledgeLearnTotalEN.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LearnCount))
 {
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.LearnCount, conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId))
 {
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.SuccessCount))
 {
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.SuccessCount, conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.FailCount))
 {
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.FailCount, conKnowledgeLearnTotal.FailCount); //失败次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.FailCount); //失败次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount))
 {
 sbSQL.AppendFormat(" ContinuousSuccessCount = {0},", objKnowledgeLearnTotalEN.ContinuousSuccessCount); //连续成功次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount))
 {
 sbSQL.AppendFormat(" ContinuousFailCount = {0},", objKnowledgeLearnTotalEN.ContinuousFailCount); //连续失败次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LastLearnDate))
 {
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastLearnDate = '{0}',", strLastLearnDate); //最后学习日期
 }
 else
 {
 sbSQL.Append(" LastLearnDate = null,"); //最后学习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate))
 {
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedNextReviewDate = '{0}',", strRecommendedNextReviewDate); //推荐下次复习日期
 }
 else
 {
 sbSQL.Append(" RecommendedNextReviewDate = null,"); //推荐下次复习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseId))
 {
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdDate))
 {
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdUser))
 {
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.Memo))
 {
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeLearnTotalEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnTotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnTotal Set ");
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UserId))
 {
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.MasterDegree))
 {
 sbSQL.AppendFormat(" MasterDegree = {0},", objKnowledgeLearnTotalEN.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LearnCount))
 {
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.LearnCount, conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId))
 {
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.SuccessCount))
 {
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.SuccessCount, conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.FailCount))
 {
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.FailCount, conKnowledgeLearnTotal.FailCount); //失败次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.FailCount); //失败次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount))
 {
 sbSQL.AppendFormat(" ContinuousSuccessCount = {0},", objKnowledgeLearnTotalEN.ContinuousSuccessCount); //连续成功次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount))
 {
 sbSQL.AppendFormat(" ContinuousFailCount = {0},", objKnowledgeLearnTotalEN.ContinuousFailCount); //连续失败次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LastLearnDate))
 {
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LastLearnDate = '{0}',", strLastLearnDate); //最后学习日期
 }
 else
 {
 sbSQL.Append(" LastLearnDate = null,"); //最后学习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate))
 {
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecommendedNextReviewDate = '{0}',", strRecommendedNextReviewDate); //推荐下次复习日期
 }
 else
 {
 sbSQL.Append(" RecommendedNextReviewDate = null,"); //推荐下次复习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseId))
 {
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdDate))
 {
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdUser))
 {
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.Memo))
 {
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeLearnTotalEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeLearnTotalEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnTotalEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnTotalEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnTotal Set ");
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UserId))
 {
 if (objKnowledgeLearnTotalEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnTotalEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conKnowledgeLearnTotal.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UserId); //用户ID
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.MasterDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.MasterDegree, conKnowledgeLearnTotal.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LearnCount))
 {
 if (objKnowledgeLearnTotalEN.LearnCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.LearnCount, conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LearnCount); //学习次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseKnowledgeId))
 {
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnTotalEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnTotalEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conKnowledgeLearnTotal.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.SuccessCount))
 {
 if (objKnowledgeLearnTotalEN.SuccessCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.SuccessCount, conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.SuccessCount); //成功次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.FailCount))
 {
 if (objKnowledgeLearnTotalEN.FailCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.FailCount, conKnowledgeLearnTotal.FailCount); //失败次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.FailCount); //失败次数
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousSuccessCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.ContinuousSuccessCount, conKnowledgeLearnTotal.ContinuousSuccessCount); //连续成功次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.ContinuousFailCount))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnTotalEN.ContinuousFailCount, conKnowledgeLearnTotal.ContinuousFailCount); //连续失败次数
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.LastLearnDate))
 {
 if (objKnowledgeLearnTotalEN.LastLearnDate !=  null)
 {
 var strLastLearnDate = objKnowledgeLearnTotalEN.LastLearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLastLearnDate, conKnowledgeLearnTotal.LastLearnDate); //最后学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.LastLearnDate); //最后学习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.RecommendedNextReviewDate))
 {
 if (objKnowledgeLearnTotalEN.RecommendedNextReviewDate !=  null)
 {
 var strRecommendedNextReviewDate = objKnowledgeLearnTotalEN.RecommendedNextReviewDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecommendedNextReviewDate, conKnowledgeLearnTotal.RecommendedNextReviewDate); //推荐下次复习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.RecommendedNextReviewDate); //推荐下次复习日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.CourseId))
 {
 if (objKnowledgeLearnTotalEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnTotalEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeLearnTotal.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdDate))
 {
 if (objKnowledgeLearnTotalEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnTotalEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeLearnTotal.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.UpdUser))
 {
 if (objKnowledgeLearnTotalEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnTotalEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeLearnTotal.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeLearnTotalEN.IsUpdated(conKnowledgeLearnTotal.Memo))
 {
 if (objKnowledgeLearnTotalEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnTotalEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeLearnTotal.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnTotal.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objKnowledgeLearnTotalEN.mId); 
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("KnowledgeLearnTotal_Delete", values);
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
//删除KnowledgeLearnTotal本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnTotal where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelKnowledgeLearnTotal(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
//删除KnowledgeLearnTotal本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnTotal where mId in (" + strKeyList + ")";
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
//删除KnowledgeLearnTotal本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnTotal where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelKnowledgeLearnTotal(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: DelKnowledgeLearnTotal)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeLearnTotal where " + strCondition ;
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
public bool DelKnowledgeLearnTotalWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsKnowledgeLearnTotalDA: DelKnowledgeLearnTotalWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeLearnTotal where " + strCondition ;
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
 /// <param name = "objKnowledgeLearnTotalENS">源对象</param>
 /// <param name = "objKnowledgeLearnTotalENT">目标对象</param>
public void CopyTo(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalENS, clsKnowledgeLearnTotalEN objKnowledgeLearnTotalENT)
{
objKnowledgeLearnTotalENT.mId = objKnowledgeLearnTotalENS.mId; //mId
objKnowledgeLearnTotalENT.UserId = objKnowledgeLearnTotalENS.UserId; //用户ID
objKnowledgeLearnTotalENT.MasterDegree = objKnowledgeLearnTotalENS.MasterDegree; //掌握程度
objKnowledgeLearnTotalENT.LearnCount = objKnowledgeLearnTotalENS.LearnCount; //学习次数
objKnowledgeLearnTotalENT.CourseKnowledgeId = objKnowledgeLearnTotalENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnTotalENT.SuccessCount = objKnowledgeLearnTotalENS.SuccessCount; //成功次数
objKnowledgeLearnTotalENT.FailCount = objKnowledgeLearnTotalENS.FailCount; //失败次数
objKnowledgeLearnTotalENT.ContinuousSuccessCount = objKnowledgeLearnTotalENS.ContinuousSuccessCount; //连续成功次数
objKnowledgeLearnTotalENT.ContinuousFailCount = objKnowledgeLearnTotalENS.ContinuousFailCount; //连续失败次数
objKnowledgeLearnTotalENT.LastLearnDate = objKnowledgeLearnTotalENS.LastLearnDate; //最后学习日期
objKnowledgeLearnTotalENT.RecommendedNextReviewDate = objKnowledgeLearnTotalENS.RecommendedNextReviewDate; //推荐下次复习日期
objKnowledgeLearnTotalENT.CourseId = objKnowledgeLearnTotalENS.CourseId; //课程Id
objKnowledgeLearnTotalENT.UpdDate = objKnowledgeLearnTotalENS.UpdDate; //修改日期
objKnowledgeLearnTotalENT.UpdUser = objKnowledgeLearnTotalENS.UpdUser; //修改人
objKnowledgeLearnTotalENT.Memo = objKnowledgeLearnTotalENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.MasterDegree, conKnowledgeLearnTotal.MasterDegree);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.ContinuousSuccessCount, conKnowledgeLearnTotal.ContinuousSuccessCount);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.ContinuousFailCount, conKnowledgeLearnTotal.ContinuousFailCount);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.CourseId, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.UpdDate, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnTotalEN.UpdUser, conKnowledgeLearnTotal.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UserId, 18, conKnowledgeLearnTotal.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.LastLearnDate, 14, conKnowledgeLearnTotal.LastLearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.RecommendedNextReviewDate, 14, conKnowledgeLearnTotal.RecommendedNextReviewDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseId, 8, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdDate, 20, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdUser, 20, conKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.Memo, 1000, conKnowledgeLearnTotal.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
 objKnowledgeLearnTotalEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UserId, 18, conKnowledgeLearnTotal.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.LastLearnDate, 14, conKnowledgeLearnTotal.LastLearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.RecommendedNextReviewDate, 14, conKnowledgeLearnTotal.RecommendedNextReviewDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseId, 8, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdDate, 20, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdUser, 20, conKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.Memo, 1000, conKnowledgeLearnTotal.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
 objKnowledgeLearnTotalEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UserId, 18, conKnowledgeLearnTotal.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.LastLearnDate, 14, conKnowledgeLearnTotal.LastLearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.RecommendedNextReviewDate, 14, conKnowledgeLearnTotal.RecommendedNextReviewDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.CourseId, 8, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdDate, 20, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.UpdUser, 20, conKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnTotalEN.Memo, 1000, conKnowledgeLearnTotal.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.UserId, conKnowledgeLearnTotal.UserId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.CourseKnowledgeId, conKnowledgeLearnTotal.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.LastLearnDate, conKnowledgeLearnTotal.LastLearnDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.RecommendedNextReviewDate, conKnowledgeLearnTotal.RecommendedNextReviewDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.CourseId, conKnowledgeLearnTotal.CourseId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.UpdDate, conKnowledgeLearnTotal.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.UpdUser, conKnowledgeLearnTotal.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnTotalEN.Memo, conKnowledgeLearnTotal.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnTotalEN.CourseKnowledgeId, 8, conKnowledgeLearnTotal.CourseKnowledgeId);
 objKnowledgeLearnTotalEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--KnowledgeLearnTotal(知识点学习汇总表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeLearnTotalEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsKnowledgeLearnTotalEN objKnowledgeLearnTotalEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objKnowledgeLearnTotalEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnTotalEN.UserId);
}
 if (objKnowledgeLearnTotalEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnTotalEN.CourseKnowledgeId);
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeLearnTotalEN._CurrTabName);
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeLearnTotalEN._CurrTabName, strCondition);
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnTotalDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}