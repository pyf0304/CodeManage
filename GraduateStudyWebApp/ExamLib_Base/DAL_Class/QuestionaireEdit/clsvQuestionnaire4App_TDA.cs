
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4App_TDA
 表名:vQuestionnaire4App_T(01120222)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:28
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
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionnaire4App_TDA : clsCommBase4DA
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
 return clsvQuestionnaire4App_TEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionnaire4App_TEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire4App_TEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionnaire4App_TEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionnaire4App_TEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionnaire4App_T(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable_vQuestionnaire4App_T)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire4App_T.* from vQuestionnaire4App_T Left Join {1} on {2} where {3} and vQuestionnaire4App_T.QuestionId not in (Select top {5} vQuestionnaire4App_T.QuestionId from vQuestionnaire4App_T Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire4App_T where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire4App_T where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionnaire4App_T.* from vQuestionnaire4App_T Left Join {1} on {2} where {3} and vQuestionnaire4App_T.QuestionId not in (Select top {5} vQuestionnaire4App_T.QuestionId from vQuestionnaire4App_T Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1} and QuestionId not in (Select top {2} QuestionId from vQuestionnaire4App_T where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionnaire4App_T where {1} and QuestionId not in (Select top {3} QuestionId from vQuestionnaire4App_T where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionnaire4App_TEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA:GetObjLst)", objException.Message));
}
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetObjLst)", objException.Message));
}
objvQuestionnaire4App_TEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
public List<clsvQuestionnaire4App_TEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetObjLst)", objException.Message));
}
objvQuestionnaire4App_TEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionnaire4App_T(ref clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where QuestionId = " + ""+ objvQuestionnaire4App_TEN.QuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionnaire4App_TEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionName = objDT.Rows[0][convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionNo = objDT.Rows[0][convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4App_TEN.CourseId = objDT.Rows[0][convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.CourseChapterId = objDT.Rows[0][convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire4App_TEN.ChapterId = objDT.Rows[0][convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterName = objDT.Rows[0][convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterNameSim = objDT.Rows[0][convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterOrderNum = TransNullToInt(objDT.Rows[0][convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionTypeId4Course = objDT.Rows[0][convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetvQuestionnaire4App_T)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionnaire4App_TEN GetObjByQuestionId(long lngQuestionId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where QuestionId = " + ""+ lngQuestionId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
 objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号(字段类型:int,字段长度:4,是否可空:True)
 objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetObjByQuestionId)", objException.Message));
}
return objvQuestionnaire4App_TEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionnaire4App_TEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionnaire4App_T where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN()
{
QuestionId = TransNullToInt(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(), //题目名称
QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(), //题目编号
CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(), //课程Id
CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(), //课程章节ID
ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(), //章Id
ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(), //章名
ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(), //章名简称
ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()), //章排序号
QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim() //题目类型Id4课程
};
objvQuestionnaire4App_TEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4App_TEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire4App_TEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetObjByDataRowvQuestionnaire4App_T)", objException.Message));
}
objvQuestionnaire4App_TEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4App_TEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionnaire4App_TEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = TransNullToInt(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionnaire4App_TDA: GetObjByDataRow)", objException.Message));
}
objvQuestionnaire4App_TEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionnaire4App_TEN;
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
objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire4App_TEN._CurrTabName, convQuestionnaire4App_T.QuestionId, 8, "");
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
objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionnaire4App_TEN._CurrTabName, convQuestionnaire4App_T.QuestionId, 8, strPrefix);
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire4App_T where " + strCondition;
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionId from vQuestionnaire4App_T where " + strCondition;
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire4App_T", "QuestionId = " + ""+ lngQuestionId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionnaire4App_TDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionnaire4App_T", strCondition))
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
objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionnaire4App_T");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <param name = "objvQuestionnaire4App_TENT">目标对象</param>
public void CopyTo(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS, clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT)
{
objvQuestionnaire4App_TENT.QuestionId = objvQuestionnaire4App_TENS.QuestionId; //题目Id
objvQuestionnaire4App_TENT.QuestionIndex = objvQuestionnaire4App_TENS.QuestionIndex; //题目序号
objvQuestionnaire4App_TENT.QuestionName = objvQuestionnaire4App_TENS.QuestionName; //题目名称
objvQuestionnaire4App_TENT.QuestionNo = objvQuestionnaire4App_TENS.QuestionNo; //题目编号
objvQuestionnaire4App_TENT.CourseId = objvQuestionnaire4App_TENS.CourseId; //课程Id
objvQuestionnaire4App_TENT.CourseChapterId = objvQuestionnaire4App_TENS.CourseChapterId; //课程章节ID
objvQuestionnaire4App_TENT.ChapterId = objvQuestionnaire4App_TENS.ChapterId; //章Id
objvQuestionnaire4App_TENT.ChapterName = objvQuestionnaire4App_TENS.ChapterName; //章名
objvQuestionnaire4App_TENT.ChapterNameSim = objvQuestionnaire4App_TENS.ChapterNameSim; //章名简称
objvQuestionnaire4App_TENT.ChapterOrderNum = objvQuestionnaire4App_TENS.ChapterOrderNum; //章排序号
objvQuestionnaire4App_TENT.QuestionTypeId4Course = objvQuestionnaire4App_TENS.QuestionTypeId4Course; //题目类型Id4课程
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.QuestionName, 500, convQuestionnaire4App_T.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.QuestionNo, 10, convQuestionnaire4App_T.QuestionNo);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.CourseId, 8, convQuestionnaire4App_T.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.CourseChapterId, 8, convQuestionnaire4App_T.CourseChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.ChapterId, 8, convQuestionnaire4App_T.ChapterId);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.ChapterName, 100, convQuestionnaire4App_T.ChapterName);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.ChapterNameSim, 10, convQuestionnaire4App_T.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvQuestionnaire4App_TEN.QuestionTypeId4Course, 8, convQuestionnaire4App_T.QuestionTypeId4Course);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.QuestionName, convQuestionnaire4App_T.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.QuestionNo, convQuestionnaire4App_T.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.CourseId, convQuestionnaire4App_T.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.CourseChapterId, convQuestionnaire4App_T.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.ChapterId, convQuestionnaire4App_T.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.ChapterName, convQuestionnaire4App_T.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.ChapterNameSim, convQuestionnaire4App_T.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvQuestionnaire4App_TEN.QuestionTypeId4Course, convQuestionnaire4App_T.QuestionTypeId4Course);
//检查外键字段长度
 objvQuestionnaire4App_TEN._IsCheckProperty = true;
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
string strSQL = "select QuestionId, QuestionName from vQuestionnaire4App_T ";
 clsSpecSQLforSql mySql = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire4App_TEN._CurrTabName);
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionnaire4App_TEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionnaire4App_TDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}