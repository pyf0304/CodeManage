
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionType4CourseDA
 表名:QuestionType4Course(01120339)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:11:59
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
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
 /// 题目类型4课程(QuestionType4Course)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQuestionType4CourseDA : clsCommBase4DA
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
 return clsQuestionType4CourseEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQuestionType4CourseEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionType4CourseEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQuestionType4CourseEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQuestionType4CourseEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQuestionTypeId4Course)
{
strQuestionTypeId4Course = strQuestionTypeId4Course.Replace("'", "''");
if (strQuestionTypeId4Course.Length > 8)
{
throw new Exception("(errid:Data000001)在表:QuestionType4Course中,检查关键字,长度不正确!(clsQuestionType4CourseDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionTypeId4Course)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QuestionType4Course中,关键字不能为空 或 null!(clsQuestionType4CourseDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionTypeId4Course);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQuestionType4CourseDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QuestionType4Course(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable_QuestionType4Course)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionType4Course.* from QuestionType4Course Left Join {1} on {2} where {3} and QuestionType4Course.QuestionTypeId4Course not in (Select top {5} QuestionType4Course.QuestionTypeId4Course from QuestionType4Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1} and QuestionTypeId4Course not in (Select top {2} QuestionTypeId4Course from QuestionType4Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1} and QuestionTypeId4Course not in (Select top {3} QuestionTypeId4Course from QuestionType4Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionType4Course.* from QuestionType4Course Left Join {1} on {2} where {3} and QuestionType4Course.QuestionTypeId4Course not in (Select top {5} QuestionType4Course.QuestionTypeId4Course from QuestionType4Course Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1} and QuestionTypeId4Course not in (Select top {2} QuestionTypeId4Course from QuestionType4Course where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionType4Course where {1} and QuestionTypeId4Course not in (Select top {3} QuestionTypeId4Course from QuestionType4Course where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQuestionType4CourseEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA:GetObjLst)", objException.Message));
}
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = TransNullToBool(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionType4CourseDA: GetObjLst)", objException.Message));
}
objQuestionType4CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionType4CourseEN);
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
public List<clsQuestionType4CourseEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA:GetObjLstByTabName)", objException.Message));
}
List<clsQuestionType4CourseEN> arrObjLst = new List<clsQuestionType4CourseEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = TransNullToBool(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionType4CourseDA: GetObjLst)", objException.Message));
}
objQuestionType4CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionType4CourseEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQuestionType4Course(ref clsQuestionType4CourseEN objQuestionType4CourseEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where QuestionTypeId4Course = " + "'"+ objQuestionType4CourseEN.QuestionTypeId4Course+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQuestionType4CourseEN.QuestionTypeId4Course = objDT.Rows[0][conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionType4CourseEN.QuestionTypeName4Course = objDT.Rows[0][conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objQuestionType4CourseEN.CourseId = objDT.Rows[0][conQuestionType4Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionType4CourseEN.OrderNum = TransNullToInt(objDT.Rows[0][conQuestionType4Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionType4CourseEN.IsUse = TransNullToBool(objDT.Rows[0][conQuestionType4Course.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionType4CourseEN.UpdDate = objDT.Rows[0][conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionType4CourseEN.UpdUser = objDT.Rows[0][conQuestionType4Course.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionType4CourseEN.Memo = objDT.Rows[0][conQuestionType4Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQuestionType4CourseDA: GetQuestionType4Course)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">表关键字</param>
 /// <returns>表对象</returns>
public clsQuestionType4CourseEN GetObjByQuestionTypeId4Course(string strQuestionTypeId4Course)
{
CheckPrimaryKey(strQuestionTypeId4Course);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where QuestionTypeId4Course = " + "'"+ strQuestionTypeId4Course+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
 objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程(字段类型:char,字段长度:8,是否可空:False)
 objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程(字段类型:varchar,字段长度:30,是否可空:False)
 objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objQuestionType4CourseEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQuestionType4CourseDA: GetObjByQuestionTypeId4Course)", objException.Message));
}
return objQuestionType4CourseEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQuestionType4CourseEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN()
{
QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(), //题目类型Id4课程
QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(), //题目类型名4课程
CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(), //课程Id
OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionType4Course.OrderNum].ToString().Trim()), //序号
IsUse = TransNullToBool(objRow[conQuestionType4Course.IsUse].ToString().Trim()), //是否使用
UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim() //备注
};
objQuestionType4CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionType4CourseEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQuestionType4CourseDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQuestionType4CourseEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = TransNullToBool(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQuestionType4CourseDA: GetObjByDataRowQuestionType4Course)", objException.Message));
}
objQuestionType4CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionType4CourseEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQuestionType4CourseEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionType4CourseEN objQuestionType4CourseEN = new clsQuestionType4CourseEN();
try
{
objQuestionType4CourseEN.QuestionTypeId4Course = objRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objQuestionType4CourseEN.QuestionTypeName4Course = objRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objQuestionType4CourseEN.CourseId = objRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objQuestionType4CourseEN.OrderNum = objRow[conQuestionType4Course.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionType4Course.OrderNum].ToString().Trim()); //序号
objQuestionType4CourseEN.IsUse = TransNullToBool(objRow[conQuestionType4Course.IsUse].ToString().Trim()); //是否使用
objQuestionType4CourseEN.UpdDate = objRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objQuestionType4CourseEN.UpdUser = objRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objQuestionType4CourseEN.Memo = objRow[conQuestionType4Course.Memo] == DBNull.Value ? null : objRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQuestionType4CourseDA: GetObjByDataRow)", objException.Message));
}
objQuestionType4CourseEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionType4CourseEN;
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
objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.QuestionTypeId4Course, 8, "");
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
objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionType4CourseEN._CurrTabName, conQuestionType4Course.QuestionTypeId4Course, 8, strPrefix);
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionTypeId4Course from QuestionType4Course where " + strCondition;
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionTypeId4Course from QuestionType4Course where " + strCondition;
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
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQuestionTypeId4Course)
{
CheckPrimaryKey(strQuestionTypeId4Course);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionType4Course", "QuestionTypeId4Course = " + "'"+ strQuestionTypeId4Course+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionType4Course", strCondition))
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
objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QuestionType4Course");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQuestionType4CourseEN objQuestionType4CourseEN)
 {
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionType4CourseEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionType4Course");
objRow = objDS.Tables["QuestionType4Course"].NewRow();
objRow[conQuestionType4Course.QuestionTypeId4Course] = objQuestionType4CourseEN.QuestionTypeId4Course; //题目类型Id4课程
objRow[conQuestionType4Course.QuestionTypeName4Course] = objQuestionType4CourseEN.QuestionTypeName4Course; //题目类型名4课程
objRow[conQuestionType4Course.CourseId] = objQuestionType4CourseEN.CourseId; //课程Id
objRow[conQuestionType4Course.OrderNum] = objQuestionType4CourseEN.OrderNum; //序号
objRow[conQuestionType4Course.IsUse] = objQuestionType4CourseEN.IsUse; //是否使用
objRow[conQuestionType4Course.UpdDate] = objQuestionType4CourseEN.UpdDate; //修改日期
objRow[conQuestionType4Course.UpdUser] = objQuestionType4CourseEN.UpdUser; //修改人
 if (objQuestionType4CourseEN.Memo !=  "")
 {
objRow[conQuestionType4Course.Memo] = objQuestionType4CourseEN.Memo; //备注
 }
objDS.Tables[clsQuestionType4CourseEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQuestionType4CourseEN._CurrTabName);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionType4CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionType4CourseEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionType4CourseEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeName4Course);
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeName4Course + "'");
 }
 
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.CourseId);
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.OrderNum);
 arrValueListForInsert.Add(objQuestionType4CourseEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionType4Course.IsUse);
 arrValueListForInsert.Add("'" + (objQuestionType4CourseEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdDate);
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdUser);
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.Memo);
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionType4Course");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionType4CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionType4CourseEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionType4CourseEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeName4Course);
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeName4Course + "'");
 }
 
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.CourseId);
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.OrderNum);
 arrValueListForInsert.Add(objQuestionType4CourseEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionType4Course.IsUse);
 arrValueListForInsert.Add("'" + (objQuestionType4CourseEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdDate);
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdUser);
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.Memo);
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionType4Course");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQuestionType4CourseEN.QuestionTypeId4Course;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionType4CourseEN objQuestionType4CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionType4CourseEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionType4CourseEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionType4CourseEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeName4Course);
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeName4Course + "'");
 }
 
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.CourseId);
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.OrderNum);
 arrValueListForInsert.Add(objQuestionType4CourseEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionType4Course.IsUse);
 arrValueListForInsert.Add("'" + (objQuestionType4CourseEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdDate);
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdUser);
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.Memo);
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionType4Course");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQuestionType4CourseEN.QuestionTypeId4Course;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionType4CourseEN objQuestionType4CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionType4CourseEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionType4CourseEN.QuestionTypeId4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeId4Course);
 var strQuestionTypeId4Course = objQuestionType4CourseEN.QuestionTypeId4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId4Course + "'");
 }
 
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.QuestionTypeName4Course);
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeName4Course + "'");
 }
 
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.CourseId);
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.OrderNum);
 arrValueListForInsert.Add(objQuestionType4CourseEN.OrderNum.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionType4Course.IsUse);
 arrValueListForInsert.Add("'" + (objQuestionType4CourseEN.IsUse  ==  false ? "0" : "1") + "'");
 
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdDate);
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.UpdUser);
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionType4Course.Memo);
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionType4Course");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQuestionType4Courses(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where QuestionTypeId4Course = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionType4Course");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strQuestionTypeId4Course = oRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim();
if (IsExist(strQuestionTypeId4Course))
{
 string strResult = "关键字变量值为:" + string.Format("QuestionTypeId4Course = {0}", strQuestionTypeId4Course) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQuestionType4CourseEN._CurrTabName ].NewRow();
objRow[conQuestionType4Course.QuestionTypeId4Course] = oRow[conQuestionType4Course.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objRow[conQuestionType4Course.QuestionTypeName4Course] = oRow[conQuestionType4Course.QuestionTypeName4Course].ToString().Trim(); //题目类型名4课程
objRow[conQuestionType4Course.CourseId] = oRow[conQuestionType4Course.CourseId].ToString().Trim(); //课程Id
objRow[conQuestionType4Course.OrderNum] = oRow[conQuestionType4Course.OrderNum].ToString().Trim(); //序号
objRow[conQuestionType4Course.IsUse] = oRow[conQuestionType4Course.IsUse].ToString().Trim(); //是否使用
objRow[conQuestionType4Course.UpdDate] = oRow[conQuestionType4Course.UpdDate].ToString().Trim(); //修改日期
objRow[conQuestionType4Course.UpdUser] = oRow[conQuestionType4Course.UpdUser].ToString().Trim(); //修改人
objRow[conQuestionType4Course.Memo] = oRow[conQuestionType4Course.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQuestionType4CourseEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQuestionType4CourseEN._CurrTabName);
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
 /// <param name = "objQuestionType4CourseEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionType4CourseEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
strSQL = "Select * from QuestionType4Course where QuestionTypeId4Course = " + "'"+ objQuestionType4CourseEN.QuestionTypeId4Course+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQuestionType4CourseEN._CurrTabName);
if (objDS.Tables[clsQuestionType4CourseEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QuestionTypeId4Course = " + "'"+ objQuestionType4CourseEN.QuestionTypeId4Course+"'");
return false;
}
objRow = objDS.Tables[clsQuestionType4CourseEN._CurrTabName].Rows[0];
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeId4Course))
 {
objRow[conQuestionType4Course.QuestionTypeId4Course] = objQuestionType4CourseEN.QuestionTypeId4Course; //题目类型Id4课程
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeName4Course))
 {
objRow[conQuestionType4Course.QuestionTypeName4Course] = objQuestionType4CourseEN.QuestionTypeName4Course; //题目类型名4课程
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.CourseId))
 {
objRow[conQuestionType4Course.CourseId] = objQuestionType4CourseEN.CourseId; //课程Id
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.OrderNum))
 {
objRow[conQuestionType4Course.OrderNum] = objQuestionType4CourseEN.OrderNum; //序号
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.IsUse))
 {
objRow[conQuestionType4Course.IsUse] = objQuestionType4CourseEN.IsUse; //是否使用
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdDate))
 {
objRow[conQuestionType4Course.UpdDate] = objQuestionType4CourseEN.UpdDate; //修改日期
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdUser))
 {
objRow[conQuestionType4Course.UpdUser] = objQuestionType4CourseEN.UpdUser; //修改人
 }
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.Memo))
 {
objRow[conQuestionType4Course.Memo] = objQuestionType4CourseEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQuestionType4CourseEN._CurrTabName);
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionType4CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QuestionType4Course Set ");
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeName4Course))
 {
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course); //题目类型名4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.QuestionTypeName4Course); //题目类型名4课程
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.CourseId))
 {
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionType4Course.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.CourseId); //课程Id
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.OrderNum))
 {
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionType4CourseEN.OrderNum, conQuestionType4Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.OrderNum); //序号
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionType4CourseEN.IsUse == true?"1":"0", conQuestionType4Course.IsUse); //是否使用
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdDate))
 {
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionType4Course.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.UpdDate); //修改日期
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdUser))
 {
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionType4Course.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.UpdUser); //修改人
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.Memo))
 {
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionType4Course.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionTypeId4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeId4Course); 
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQuestionType4CourseEN objQuestionType4CourseEN, string strCondition)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionType4CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionType4Course Set ");
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeName4Course))
 {
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeName4Course = '{0}',", strQuestionTypeName4Course); //题目类型名4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeName4Course = null,"); //题目类型名4课程
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.CourseId))
 {
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.OrderNum))
 {
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionType4CourseEN.OrderNum, conQuestionType4Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.OrderNum); //序号
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objQuestionType4CourseEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdDate))
 {
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdUser))
 {
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.Memo))
 {
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionType4CourseEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQuestionType4CourseEN objQuestionType4CourseEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionType4CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionType4Course Set ");
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeName4Course))
 {
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeName4Course = '{0}',", strQuestionTypeName4Course); //题目类型名4课程
 }
 else
 {
 sbSQL.Append(" QuestionTypeName4Course = null,"); //题目类型名4课程
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.CourseId))
 {
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.OrderNum))
 {
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionType4CourseEN.OrderNum, conQuestionType4Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.OrderNum); //序号
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.IsUse))
 {
 sbSQL.AppendFormat(" IsUse = '{0}',", objQuestionType4CourseEN.IsUse == true?"1":"0"); //是否使用
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdDate))
 {
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdUser))
 {
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.Memo))
 {
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionType4CourseEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionType4CourseEN objQuestionType4CourseEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionType4CourseEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionType4CourseEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionType4CourseEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionType4Course Set ");
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.QuestionTypeName4Course))
 {
 if (objQuestionType4CourseEN.QuestionTypeName4Course !=  null)
 {
 var strQuestionTypeName4Course = objQuestionType4CourseEN.QuestionTypeName4Course.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course); //题目类型名4课程
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.QuestionTypeName4Course); //题目类型名4课程
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.CourseId))
 {
 if (objQuestionType4CourseEN.CourseId !=  null)
 {
 var strCourseId = objQuestionType4CourseEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conQuestionType4Course.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.CourseId); //课程Id
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.OrderNum))
 {
 if (objQuestionType4CourseEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionType4CourseEN.OrderNum, conQuestionType4Course.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.OrderNum); //序号
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.IsUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionType4CourseEN.IsUse == true?"1":"0", conQuestionType4Course.IsUse); //是否使用
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdDate))
 {
 if (objQuestionType4CourseEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionType4CourseEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionType4Course.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.UpdDate); //修改日期
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.UpdUser))
 {
 if (objQuestionType4CourseEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionType4CourseEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionType4Course.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.UpdUser); //修改人
 }
 }
 
 if (objQuestionType4CourseEN.IsUpdated(conQuestionType4Course.Memo))
 {
 if (objQuestionType4CourseEN.Memo !=  null)
 {
 var strMemo = objQuestionType4CourseEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionType4Course.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionType4Course.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionTypeId4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeId4Course); 
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
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQuestionTypeId4Course) 
{
CheckPrimaryKey(strQuestionTypeId4Course);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strQuestionTypeId4Course,
};
 objSQL.ExecSP("QuestionType4Course_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strQuestionTypeId4Course, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strQuestionTypeId4Course);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
//删除QuestionType4Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionType4Course where QuestionTypeId4Course = " + "'"+ strQuestionTypeId4Course+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQuestionType4Course(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
//删除QuestionType4Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionType4Course where QuestionTypeId4Course in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strQuestionTypeId4Course">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strQuestionTypeId4Course) 
{
CheckPrimaryKey(strQuestionTypeId4Course);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
//删除QuestionType4Course本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionType4Course where QuestionTypeId4Course = " + "'"+ strQuestionTypeId4Course+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQuestionType4Course(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: DelQuestionType4Course)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionType4Course where " + strCondition ;
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
public bool DelQuestionType4CourseWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQuestionType4CourseDA: DelQuestionType4CourseWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionType4Course where " + strCondition ;
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
 /// <param name = "objQuestionType4CourseENS">源对象</param>
 /// <param name = "objQuestionType4CourseENT">目标对象</param>
public void CopyTo(clsQuestionType4CourseEN objQuestionType4CourseENS, clsQuestionType4CourseEN objQuestionType4CourseENT)
{
objQuestionType4CourseENT.QuestionTypeId4Course = objQuestionType4CourseENS.QuestionTypeId4Course; //题目类型Id4课程
objQuestionType4CourseENT.QuestionTypeName4Course = objQuestionType4CourseENS.QuestionTypeName4Course; //题目类型名4课程
objQuestionType4CourseENT.CourseId = objQuestionType4CourseENS.CourseId; //课程Id
objQuestionType4CourseENT.OrderNum = objQuestionType4CourseENS.OrderNum; //序号
objQuestionType4CourseENT.IsUse = objQuestionType4CourseENS.IsUse; //是否使用
objQuestionType4CourseENT.UpdDate = objQuestionType4CourseENS.UpdDate; //修改日期
objQuestionType4CourseENT.UpdUser = objQuestionType4CourseENS.UpdUser; //修改人
objQuestionType4CourseENT.Memo = objQuestionType4CourseENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQuestionType4CourseEN.QuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldNotNull(objQuestionType4CourseEN.CourseId, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldNotNull(objQuestionType4CourseEN.UpdDate, conQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldNotNull(objQuestionType4CourseEN.UpdUser, conQuestionType4Course.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.QuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.QuestionTypeName4Course, 30, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.CourseId, 8, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdDate, 20, conQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdUser, 20, conQuestionType4Course.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.Memo, 1000, conQuestionType4Course.Memo);
//检查字段外键固定长度
 objQuestionType4CourseEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.QuestionTypeName4Course, 30, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.CourseId, 8, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdDate, 20, conQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdUser, 20, conQuestionType4Course.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.Memo, 1000, conQuestionType4Course.Memo);
//检查外键字段长度
 objQuestionType4CourseEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.QuestionTypeId4Course, 8, conQuestionType4Course.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.QuestionTypeName4Course, 30, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.CourseId, 8, conQuestionType4Course.CourseId);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdDate, 20, conQuestionType4Course.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.UpdUser, 20, conQuestionType4Course.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionType4CourseEN.Memo, 1000, conQuestionType4Course.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.QuestionTypeId4Course, conQuestionType4Course.QuestionTypeId4Course);
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.QuestionTypeName4Course, conQuestionType4Course.QuestionTypeName4Course);
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.CourseId, conQuestionType4Course.CourseId);
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.UpdDate, conQuestionType4Course.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.UpdUser, conQuestionType4Course.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionType4CourseEN.Memo, conQuestionType4Course.Memo);
//检查外键字段长度
 objQuestionType4CourseEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionTypeId4Course()
{
//获取某学院所有专业信息
string strSQL = "select QuestionTypeId4Course, QuestionTypeName4Course from QuestionType4Course ";
 clsSpecSQLforSql mySql = clsQuestionType4CourseDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QuestionType4Course(题目类型4课程),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionType4CourseEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQuestionType4CourseEN objQuestionType4CourseEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionTypeName4Course = '{0}'", objQuestionType4CourseEN.QuestionTypeName4Course);
 sbCondition.AppendFormat(" and CourseId = '{0}'", objQuestionType4CourseEN.CourseId);
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionType4CourseEN._CurrTabName);
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionType4CourseEN._CurrTabName, strCondition);
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
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
 objSQL = clsQuestionType4CourseDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}