
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_SimDA
 表名:vQuestionnaire_Sim(01120949)
 * 版本:2024.11.10.1(服务器:WIN-SRV103-116)
 日期:2024/11/12 09:24:57
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// vQuestionnaire_Sim(vQuestionnaire_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaire_SimDA : clsCommBase4DA
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
 return clsvQuestionnaire_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaire_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaire_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaire_SimEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable_vQuestionnaire_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Sim.* from vQuestionnaire_Sim Left Join {1} on {2} where {3} and vQuestionnaire_Sim.QuestionId not in (Select top {5} vQuestionnaire_Sim.QuestionId from vQuestionnaire_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire_Sim.* from vQuestionnaire_Sim Left Join {1} on {2} where {3} and vQuestionnaire_Sim.QuestionId not in (Select top {5} vQuestionnaire_Sim.QuestionId from vQuestionnaire_Sim Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire_Sim where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaire_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
public List<clsvQuestionnaire_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetObjLst)", objException.Message));
}
objvQuestionnaire_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire_Sim(ref clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where QuestionId = " + ""+ objvQuestionnaire_SimEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaire_SimEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.QuestionName = objDT.Rows[0][convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_SimEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_SimEN.QuestionNo = objDT.Rows[0][convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_SimEN.CourseId = objDT.Rows[0][convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.CourseChapterId = objDT.Rows[0][convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_SimEN.ParentQuestionId = objDT.Rows[0][convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.QuestionTypeId = objDT.Rows[0][convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_SimEN.QuestionTypeId4Course = objDT.Rows[0][convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_SimEN.AnswerTypeId = objDT.Rows[0][convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_SimEN.IsShow = TransNullToBool(objDT.Rows[0][convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_SimEN.DifficultyLevelId = objDT.Rows[0][convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetvQuestionnaire_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaire_SimEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
 objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaire_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaire_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()), //题目Id
QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(), //题目名称
QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()), //题目序号
QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(), //题目编号
CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(), //课程Id
CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(), //课程章节ID
ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(), //父题目Id
QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(), //答案类型ID
IsShow = TransNullToBool(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()), //是否启用
DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim() //难度等级Id
};
objvQuestionnaire_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetObjByDataRowvQuestionnaire_Sim)", objException.Message));
}
objvQuestionnaire_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = TransNullToInt(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = TransNullToBool(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire_SimDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaire_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire_SimEN;
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
objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_SimEN._CurrTabName, convQuestionnaire_Sim.QuestionId, 8, "");
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
objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire_SimEN._CurrTabName, convQuestionnaire_Sim.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Sim where " + strCondition;
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire_Sim where " + strCondition;
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
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngQuestionId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Sim", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaire_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire_Sim", strCondition))
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
objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <param name = "objvQuestionnaire_SimENT">目标对象</param>
public void CopyTo(clsvQuestionnaire_SimEN objvQuestionnaire_SimENS, clsvQuestionnaire_SimEN objvQuestionnaire_SimENT)
{
objvQuestionnaire_SimENT.QuestionId = objvQuestionnaire_SimENS.QuestionId; //题目Id
objvQuestionnaire_SimENT.QuestionName = objvQuestionnaire_SimENS.QuestionName; //题目名称
objvQuestionnaire_SimENT.QuestionIndex = objvQuestionnaire_SimENS.QuestionIndex; //题目序号
objvQuestionnaire_SimENT.QuestionNo = objvQuestionnaire_SimENS.QuestionNo; //题目编号
objvQuestionnaire_SimENT.CourseId = objvQuestionnaire_SimENS.CourseId; //课程Id
objvQuestionnaire_SimENT.CourseChapterId = objvQuestionnaire_SimENS.CourseChapterId; //课程章节ID
objvQuestionnaire_SimENT.ParentQuestionId = objvQuestionnaire_SimENS.ParentQuestionId; //父题目Id
objvQuestionnaire_SimENT.QuestionTypeId = objvQuestionnaire_SimENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_SimENT.QuestionTypeId4Course = objvQuestionnaire_SimENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionnaire_SimENT.AnswerTypeId = objvQuestionnaire_SimENS.AnswerTypeId; //答案类型ID
objvQuestionnaire_SimENT.IsShow = objvQuestionnaire_SimENS.IsShow; //是否启用
objvQuestionnaire_SimENT.DifficultyLevelId = objvQuestionnaire_SimENS.DifficultyLevelId; //难度等级Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.QuestionName, 500, convQuestionnaire_Sim.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.QuestionNo, 10, convQuestionnaire_Sim.QuestionNo);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.CourseId, 8, convQuestionnaire_Sim.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.CourseChapterId, 8, convQuestionnaire_Sim.CourseChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.ParentQuestionId, 8, convQuestionnaire_Sim.ParentQuestionId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.QuestionTypeId, 2, convQuestionnaire_Sim.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.QuestionTypeId4Course, 8, convQuestionnaire_Sim.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.AnswerTypeId, 2, convQuestionnaire_Sim.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvQuestionnaire_SimEN.DifficultyLevelId, 2, convQuestionnaire_Sim.DifficultyLevelId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.QuestionName, convQuestionnaire_Sim.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.QuestionNo, convQuestionnaire_Sim.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.CourseId, convQuestionnaire_Sim.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.CourseChapterId, convQuestionnaire_Sim.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.ParentQuestionId, convQuestionnaire_Sim.ParentQuestionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.QuestionTypeId, convQuestionnaire_Sim.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.QuestionTypeId4Course, convQuestionnaire_Sim.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.AnswerTypeId, convQuestionnaire_Sim.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire_SimEN.DifficultyLevelId, convQuestionnaire_Sim.DifficultyLevelId);
//检查外键字段长度
 objvQuestionnaire_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionId()
{
//获取某学院所有专业信息
string strSQL = "select QuestionId, QuestionName from vQuestionnaire_Sim ";
 clsSpecSQLforSql mySql = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_SimEN._CurrTabName);
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaire_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}