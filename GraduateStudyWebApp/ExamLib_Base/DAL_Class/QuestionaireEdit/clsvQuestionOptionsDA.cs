
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionOptionsDA
 表名:vQuestionOptions(01120189)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:31
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
 /// v题目选项(vQuestionOptions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvQuestionOptionsDA : clsCommBase4DA
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
 return clsvQuestionOptionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvQuestionOptionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionOptionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvQuestionOptionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvQuestionOptionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQuestionOptionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQuestionOptionId)
{
strQuestionOptionId = strQuestionOptionId.Replace("'", "''");
if (strQuestionOptionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vQuestionOptions中,检查关键字,长度不正确!(clsvQuestionOptionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionOptionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vQuestionOptions中,关键字不能为空 或 null!(clsvQuestionOptionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionOptionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvQuestionOptionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vQuestionOptions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable_vQuestionOptions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionOptions.* from vQuestionOptions Left Join {1} on {2} where {3} and vQuestionOptions.QuestionOptionId not in (Select top {5} vQuestionOptions.QuestionOptionId from vQuestionOptions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1} and QuestionOptionId not in (Select top {2} QuestionOptionId from vQuestionOptions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1} and QuestionOptionId not in (Select top {3} QuestionOptionId from vQuestionOptions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vQuestionOptions.* from vQuestionOptions Left Join {1} on {2} where {3} and vQuestionOptions.QuestionOptionId not in (Select top {5} vQuestionOptions.QuestionOptionId from vQuestionOptions Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1} and QuestionOptionId not in (Select top {2} QuestionOptionId from vQuestionOptions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vQuestionOptions where {1} and QuestionOptionId not in (Select top {3} QuestionOptionId from vQuestionOptions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvQuestionOptionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA:GetObjLst)", objException.Message));
}
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = TransNullToInt(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = TransNullToBool(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = TransNullToBool(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionOptionsDA: GetObjLst)", objException.Message));
}
objvQuestionOptionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionOptionsEN);
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
public List<clsvQuestionOptionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvQuestionOptionsEN> arrObjLst = new List<clsvQuestionOptionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = TransNullToInt(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = TransNullToBool(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = TransNullToBool(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvQuestionOptionsDA: GetObjLst)", objException.Message));
}
objvQuestionOptionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvQuestionOptionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvQuestionOptionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvQuestionOptions(ref clsvQuestionOptionsEN objvQuestionOptionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where QuestionOptionId = " + "'"+ objvQuestionOptionsEN.QuestionOptionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvQuestionOptionsEN.QuestionOptionId = objDT.Rows[0][convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionOptionsEN.OptionName = objDT.Rows[0][convQuestionOptions.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvQuestionOptionsEN.QuestionId = TransNullToInt(objDT.Rows[0][convQuestionOptions.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.QuestionName = objDT.Rows[0][convQuestionOptions.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionOptionsEN.QuestionMemo = objDT.Rows[0][convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionOptionsEN.CourseId = objDT.Rows[0][convQuestionOptions.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeId = objDT.Rows[0][convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeName = objDT.Rows[0][convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeId4Course = objDT.Rows[0][convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionOptionsEN.GridTitle = objDT.Rows[0][convQuestionOptions.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionOptionsEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.OptionIndex = TransNullToInt(objDT.Rows[0][convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号(字段类型:int,字段长度:4,是否可空:False)
 objvQuestionOptionsEN.OptionTitle = objDT.Rows[0][convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.OptionContent = objDT.Rows[0][convQuestionOptions.OptionContent].ToString().Trim(); //选项内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionOptionsEN.IsCorrect = TransNullToBool(objDT.Rows[0][convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionOptionsEN.Score = TransNullToDouble(objDT.Rows[0][convQuestionOptions.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvQuestionOptionsEN.IsShow = TransNullToBool(objDT.Rows[0][convQuestionOptions.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionOptionsEN.UpdDate = objDT.Rows[0][convQuestionOptions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.UpdUser = objDT.Rows[0][convQuestionOptions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.Memo = objDT.Rows[0][convQuestionOptions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvQuestionOptionsDA: GetvQuestionOptions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionOptionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvQuestionOptionsEN GetObjByQuestionOptionId(string strQuestionOptionId)
{
CheckPrimaryKey(strQuestionOptionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where QuestionOptionId = " + "'"+ strQuestionOptionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
 objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称(字段类型:varchar,字段长度:4000,是否可空:False)
 objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvQuestionOptionsEN.OptionIndex = Int32.Parse(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号(字段类型:int,字段长度:4,是否可空:False)
 objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvQuestionOptionsEN.IsCorrect = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convQuestionOptions.Score].ToString().Trim()); //得分(字段类型:decimal,字段长度:6,是否可空:True)
 objvQuestionOptionsEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvQuestionOptionsDA: GetObjByQuestionOptionId)", objException.Message));
}
return objvQuestionOptionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvQuestionOptionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
strSQL = "Select * from vQuestionOptions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN()
{
QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(), //题目选项Id
OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(), //选项名称
QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionOptions.QuestionId].ToString().Trim()), //题目Id
QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(), //题目名称
QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(), //题目说明
CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(), //课程Id
QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(), //题目类型名
QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(), //表格标题
QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionOptions.QuestionScore].ToString().Trim()), //题目得分
OptionIndex = TransNullToInt(objRow[convQuestionOptions.OptionIndex].ToString().Trim()), //选项序号
OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(), //选项标题
OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(), //选项内容
IsCorrect = TransNullToBool(objRow[convQuestionOptions.IsCorrect].ToString().Trim()), //是否正确
Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionOptions.Score].ToString().Trim()), //得分
IsShow = TransNullToBool(objRow[convQuestionOptions.IsShow].ToString().Trim()), //是否启用
UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim() //备注
};
objvQuestionOptionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionOptionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvQuestionOptionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvQuestionOptionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = TransNullToInt(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = TransNullToBool(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = TransNullToBool(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvQuestionOptionsDA: GetObjByDataRowvQuestionOptions)", objException.Message));
}
objvQuestionOptionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionOptionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvQuestionOptionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvQuestionOptionsEN objvQuestionOptionsEN = new clsvQuestionOptionsEN();
try
{
objvQuestionOptionsEN.QuestionOptionId = objRow[convQuestionOptions.QuestionOptionId].ToString().Trim(); //题目选项Id
objvQuestionOptionsEN.OptionName = objRow[convQuestionOptions.OptionName].ToString().Trim(); //选项名称
objvQuestionOptionsEN.QuestionId = objRow[convQuestionOptions.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convQuestionOptions.QuestionId].ToString().Trim()); //题目Id
objvQuestionOptionsEN.QuestionName = objRow[convQuestionOptions.QuestionName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionName].ToString().Trim(); //题目名称
objvQuestionOptionsEN.QuestionMemo = objRow[convQuestionOptions.QuestionMemo] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionMemo].ToString().Trim(); //题目说明
objvQuestionOptionsEN.CourseId = objRow[convQuestionOptions.CourseId] == DBNull.Value ? null : objRow[convQuestionOptions.CourseId].ToString().Trim(); //课程Id
objvQuestionOptionsEN.QuestionTypeId = objRow[convQuestionOptions.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionOptionsEN.QuestionTypeName = objRow[convQuestionOptions.QuestionTypeName] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeName].ToString().Trim(); //题目类型名
objvQuestionOptionsEN.QuestionTypeId4Course = objRow[convQuestionOptions.QuestionTypeId4Course] == DBNull.Value ? null : objRow[convQuestionOptions.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionOptionsEN.GridTitle = objRow[convQuestionOptions.GridTitle] == DBNull.Value ? null : objRow[convQuestionOptions.GridTitle].ToString().Trim(); //表格标题
objvQuestionOptionsEN.QuestionScore = objRow[convQuestionOptions.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convQuestionOptions.QuestionScore].ToString().Trim()); //题目得分
objvQuestionOptionsEN.OptionIndex = TransNullToInt(objRow[convQuestionOptions.OptionIndex].ToString().Trim()); //选项序号
objvQuestionOptionsEN.OptionTitle = objRow[convQuestionOptions.OptionTitle] == DBNull.Value ? null : objRow[convQuestionOptions.OptionTitle].ToString().Trim(); //选项标题
objvQuestionOptionsEN.OptionContent = objRow[convQuestionOptions.OptionContent] == DBNull.Value ? null : objRow[convQuestionOptions.OptionContent].ToString().Trim(); //选项内容
objvQuestionOptionsEN.IsCorrect = TransNullToBool(objRow[convQuestionOptions.IsCorrect].ToString().Trim()); //是否正确
objvQuestionOptionsEN.Score = objRow[convQuestionOptions.Score] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convQuestionOptions.Score].ToString().Trim()); //得分
objvQuestionOptionsEN.IsShow = TransNullToBool(objRow[convQuestionOptions.IsShow].ToString().Trim()); //是否启用
objvQuestionOptionsEN.UpdDate = objRow[convQuestionOptions.UpdDate].ToString().Trim(); //修改日期
objvQuestionOptionsEN.UpdUser = objRow[convQuestionOptions.UpdUser].ToString().Trim(); //修改人
objvQuestionOptionsEN.Memo = objRow[convQuestionOptions.Memo] == DBNull.Value ? null : objRow[convQuestionOptions.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvQuestionOptionsDA: GetObjByDataRow)", objException.Message));
}
objvQuestionOptionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvQuestionOptionsEN;
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
objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionOptionsEN._CurrTabName, convQuestionOptions.QuestionOptionId, 8, "");
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
objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvQuestionOptionsEN._CurrTabName, convQuestionOptions.QuestionOptionId, 8, strPrefix);
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionOptionId from vQuestionOptions where " + strCondition;
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionOptionId from vQuestionOptions where " + strCondition;
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
 /// <param name = "strQuestionOptionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQuestionOptionId)
{
CheckPrimaryKey(strQuestionOptionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionOptions", "QuestionOptionId = " + "'"+ strQuestionOptionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvQuestionOptionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vQuestionOptions", strCondition))
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
objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vQuestionOptions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionOptionsENS">源对象</param>
 /// <param name = "objvQuestionOptionsENT">目标对象</param>
public void CopyTo(clsvQuestionOptionsEN objvQuestionOptionsENS, clsvQuestionOptionsEN objvQuestionOptionsENT)
{
objvQuestionOptionsENT.QuestionOptionId = objvQuestionOptionsENS.QuestionOptionId; //题目选项Id
objvQuestionOptionsENT.OptionName = objvQuestionOptionsENS.OptionName; //选项名称
objvQuestionOptionsENT.QuestionId = objvQuestionOptionsENS.QuestionId; //题目Id
objvQuestionOptionsENT.QuestionName = objvQuestionOptionsENS.QuestionName; //题目名称
objvQuestionOptionsENT.QuestionMemo = objvQuestionOptionsENS.QuestionMemo; //题目说明
objvQuestionOptionsENT.CourseId = objvQuestionOptionsENS.CourseId; //课程Id
objvQuestionOptionsENT.QuestionTypeId = objvQuestionOptionsENS.QuestionTypeId; //题目类型Id
objvQuestionOptionsENT.QuestionTypeName = objvQuestionOptionsENS.QuestionTypeName; //题目类型名
objvQuestionOptionsENT.QuestionTypeId4Course = objvQuestionOptionsENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionOptionsENT.GridTitle = objvQuestionOptionsENS.GridTitle; //表格标题
objvQuestionOptionsENT.QuestionScore = objvQuestionOptionsENS.QuestionScore; //题目得分
objvQuestionOptionsENT.OptionIndex = objvQuestionOptionsENS.OptionIndex; //选项序号
objvQuestionOptionsENT.OptionTitle = objvQuestionOptionsENS.OptionTitle; //选项标题
objvQuestionOptionsENT.OptionContent = objvQuestionOptionsENS.OptionContent; //选项内容
objvQuestionOptionsENT.IsCorrect = objvQuestionOptionsENS.IsCorrect; //是否正确
objvQuestionOptionsENT.Score = objvQuestionOptionsENS.Score; //得分
objvQuestionOptionsENT.IsShow = objvQuestionOptionsENS.IsShow; //是否启用
objvQuestionOptionsENT.UpdDate = objvQuestionOptionsENS.UpdDate; //修改日期
objvQuestionOptionsENT.UpdUser = objvQuestionOptionsENS.UpdUser; //修改人
objvQuestionOptionsENT.Memo = objvQuestionOptionsENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvQuestionOptionsEN objvQuestionOptionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionOptionId, 8, convQuestionOptions.QuestionOptionId);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.OptionName, 4000, convQuestionOptions.OptionName);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionName, 500, convQuestionOptions.QuestionName);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionMemo, 1000, convQuestionOptions.QuestionMemo);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.CourseId, 8, convQuestionOptions.CourseId);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionTypeId, 2, convQuestionOptions.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionTypeName, 20, convQuestionOptions.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.QuestionTypeId4Course, 8, convQuestionOptions.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.GridTitle, 30, convQuestionOptions.GridTitle);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.OptionTitle, 20, convQuestionOptions.OptionTitle);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.OptionContent, 4000, convQuestionOptions.OptionContent);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.UpdDate, 20, convQuestionOptions.UpdDate);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.UpdUser, 20, convQuestionOptions.UpdUser);
clsCheckSql.CheckFieldLen(objvQuestionOptionsEN.Memo, 1000, convQuestionOptions.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionOptionId, convQuestionOptions.QuestionOptionId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.OptionName, convQuestionOptions.OptionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionName, convQuestionOptions.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionMemo, convQuestionOptions.QuestionMemo);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.CourseId, convQuestionOptions.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionTypeId, convQuestionOptions.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionTypeName, convQuestionOptions.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.QuestionTypeId4Course, convQuestionOptions.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.GridTitle, convQuestionOptions.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.OptionTitle, convQuestionOptions.OptionTitle);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.OptionContent, convQuestionOptions.OptionContent);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.UpdDate, convQuestionOptions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.UpdUser, convQuestionOptions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvQuestionOptionsEN.Memo, convQuestionOptions.Memo);
//检查外键字段长度
 objvQuestionOptionsEN._IsCheckProperty = true;
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionOptionsEN._CurrTabName);
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvQuestionOptionsEN._CurrTabName, strCondition);
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
 objSQL = clsvQuestionOptionsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}