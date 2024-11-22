
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_AnswerDA
 表名:vzx_Answer(01120847)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:49:36
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:中学生课件管理(ZXCourseware)
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
 /// vzx_Answer(vzx_Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_AnswerDA : clsCommBase4DA
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
 return clsvzx_AnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_AnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_AnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_AnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_AnswerEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxAnswerId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxAnswerId)
{
strzxAnswerId = strzxAnswerId.Replace("'", "''");
if (strzxAnswerId.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vzx_Answer中,检查关键字,长度不正确!(clsvzx_AnswerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxAnswerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Answer中,关键字不能为空 或 null!(clsvzx_AnswerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_AnswerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable_vzx_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Answer.* from vzx_Answer Left Join {1} on {2} where {3} and vzx_Answer.zxAnswerId not in (Select top {5} vzx_Answer.zxAnswerId from vzx_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1} and zxAnswerId not in (Select top {2} zxAnswerId from vzx_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1} and zxAnswerId not in (Select top {3} zxAnswerId from vzx_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Answer.* from vzx_Answer Left Join {1} on {2} where {3} and vzx_Answer.zxAnswerId not in (Select top {5} vzx_Answer.zxAnswerId from vzx_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1} and zxAnswerId not in (Select top {2} zxAnswerId from vzx_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Answer where {1} and zxAnswerId not in (Select top {3} zxAnswerId from vzx_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_AnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_AnswerDA:GetObjLst)", objException.Message));
}
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = TransNullToBool(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = TransNullToBool(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = TransNullToBool(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = TransNullToBool(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_AnswerDA: GetObjLst)", objException.Message));
}
objvzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_AnswerEN);
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
public List<clsvzx_AnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_AnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_AnswerEN> arrObjLst = new List<clsvzx_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = TransNullToBool(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = TransNullToBool(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = TransNullToBool(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = TransNullToBool(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_AnswerDA: GetObjLst)", objException.Message));
}
objvzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_AnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_AnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Answer(ref clsvzx_AnswerEN objvzx_AnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where zxAnswerId = " + "'"+ objvzx_AnswerEN.zxAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_AnswerEN.AnswerContent = objDT.Rows[0][convzx_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvzx_AnswerEN.zxAnswerId = objDT.Rows[0][convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_AnswerEN.zxQuestionsId = objDT.Rows[0][convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.QuestionsTypeName = objDT.Rows[0][convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_AnswerEN.TextTitle = objDT.Rows[0][convzx_Answer.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_AnswerEN.QuestionsContent = objDT.Rows[0][convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_AnswerEN.zxQuestionsTypeId = objDT.Rows[0][convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_AnswerEN.UserId = objDT.Rows[0][convzx_Answer.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_AnswerEN.Score = TransNullToFloat(objDT.Rows[0][convzx_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.ScoreType = objDT.Rows[0][convzx_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvzx_AnswerEN.IsRight = TransNullToBool(objDT.Rows[0][convzx_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.ParentId = objDT.Rows[0][convzx_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvzx_AnswerEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_AnswerEN.UpdUser = objDT.Rows[0][convzx_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.UserName = objDT.Rows[0][convzx_Answer.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_AnswerEN.UpdDate = objDT.Rows[0][convzx_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.Memo = objDT.Rows[0][convzx_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_AnswerEN.IsPublic = TransNullToBool(objDT.Rows[0][convzx_Answer.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.IsRecommend = TransNullToBool(objDT.Rows[0][convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.GroupTextId = objDT.Rows[0][convzx_Answer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_AnswerEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.TextId = objDT.Rows[0][convzx_Answer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.AnswerTypeId = objDT.Rows[0][convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvzx_AnswerEN.IdCurrEduCls = objDT.Rows[0][convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.CreateDate = objDT.Rows[0][convzx_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.QuestUserName = objDT.Rows[0][convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_AnswerDA: Getvzx_Answer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_AnswerEN GetObjByzxAnswerId(string strzxAnswerId)
{
CheckPrimaryKey(strzxAnswerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where zxAnswerId = " + "'"+ strzxAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
 objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objvzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName(字段类型:varchar,字段长度:30,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_AnswerDA: GetObjByzxAnswerId)", objException.Message));
}
return objvzx_AnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_AnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_AnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN()
{
AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(), //答案内容
zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(), //回答Id
zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(), //提问Id
QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(), //问题类型名称
TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(), //TextTitle
QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(), //提问内容
zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(), //问题类型Id
UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(), //用户ID
Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.Score].ToString().Trim()), //评分
ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(), //评分类型
IsRight = TransNullToBool(objRow[convzx_Answer.IsRight].ToString().Trim()), //是否正确
ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(), //父节点Id
VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.VoteCount].ToString().Trim()), //点赞计数
UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(), //修改人
UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(), //用户名
UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(), //备注
IsPublic = TransNullToBool(objRow[convzx_Answer.IsPublic].ToString().Trim()), //是否公开
IsRecommend = TransNullToBool(objRow[convzx_Answer.IsRecommend].ToString().Trim()), //是否推荐
GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(), //小组Id
IsSubmit = TransNullToBool(objRow[convzx_Answer.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.AppraiseCount].ToString().Trim()), //评论数
StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.TeaScore].ToString().Trim()), //教师评分
TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(), //课件Id
AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(), //答案类型ID
IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(), //教学班流水号
CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(), //建立日期
QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim() //QuestUserName
};
objvzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_AnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_AnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_AnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = TransNullToBool(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = TransNullToBool(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = TransNullToBool(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = TransNullToBool(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_AnswerDA: GetObjByDataRowvzx_Answer)", objException.Message));
}
objvzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_AnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_AnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_AnswerEN objvzx_AnswerEN = new clsvzx_AnswerEN();
try
{
objvzx_AnswerEN.AnswerContent = objRow[convzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[convzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objvzx_AnswerEN.zxAnswerId = objRow[convzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objvzx_AnswerEN.zxQuestionsId = objRow[convzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objvzx_AnswerEN.QuestionsTypeName = objRow[convzx_Answer.QuestionsTypeName] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsTypeName].ToString().Trim(); //问题类型名称
objvzx_AnswerEN.TextTitle = objRow[convzx_Answer.TextTitle] == DBNull.Value ? null : objRow[convzx_Answer.TextTitle].ToString().Trim(); //TextTitle
objvzx_AnswerEN.QuestionsContent = objRow[convzx_Answer.QuestionsContent] == DBNull.Value ? null : objRow[convzx_Answer.QuestionsContent].ToString().Trim(); //提问内容
objvzx_AnswerEN.zxQuestionsTypeId = objRow[convzx_Answer.zxQuestionsTypeId] == DBNull.Value ? null : objRow[convzx_Answer.zxQuestionsTypeId].ToString().Trim(); //问题类型Id
objvzx_AnswerEN.UserId = objRow[convzx_Answer.UserId] == DBNull.Value ? null : objRow[convzx_Answer.UserId].ToString().Trim(); //用户ID
objvzx_AnswerEN.Score = objRow[convzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.Score].ToString().Trim()); //评分
objvzx_AnswerEN.ScoreType = objRow[convzx_Answer.ScoreType] == DBNull.Value ? null : objRow[convzx_Answer.ScoreType].ToString().Trim(); //评分类型
objvzx_AnswerEN.IsRight = TransNullToBool(objRow[convzx_Answer.IsRight].ToString().Trim()); //是否正确
objvzx_AnswerEN.ParentId = objRow[convzx_Answer.ParentId] == DBNull.Value ? null : objRow[convzx_Answer.ParentId].ToString().Trim(); //父节点Id
objvzx_AnswerEN.VoteCount = objRow[convzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objvzx_AnswerEN.UpdUser = objRow[convzx_Answer.UpdUser] == DBNull.Value ? null : objRow[convzx_Answer.UpdUser].ToString().Trim(); //修改人
objvzx_AnswerEN.UserName = objRow[convzx_Answer.UserName] == DBNull.Value ? null : objRow[convzx_Answer.UserName].ToString().Trim(); //用户名
objvzx_AnswerEN.UpdDate = objRow[convzx_Answer.UpdDate] == DBNull.Value ? null : objRow[convzx_Answer.UpdDate].ToString().Trim(); //修改日期
objvzx_AnswerEN.Memo = objRow[convzx_Answer.Memo] == DBNull.Value ? null : objRow[convzx_Answer.Memo].ToString().Trim(); //备注
objvzx_AnswerEN.IsPublic = TransNullToBool(objRow[convzx_Answer.IsPublic].ToString().Trim()); //是否公开
objvzx_AnswerEN.IsRecommend = TransNullToBool(objRow[convzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objvzx_AnswerEN.GroupTextId = objRow[convzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objvzx_AnswerEN.IsSubmit = TransNullToBool(objRow[convzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objvzx_AnswerEN.AppraiseCount = objRow[convzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objvzx_AnswerEN.StuScore = objRow[convzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.StuScore].ToString().Trim()); //学生平均分
objvzx_AnswerEN.TeaScore = objRow[convzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Answer.TeaScore].ToString().Trim()); //教师评分
objvzx_AnswerEN.TextId = objRow[convzx_Answer.TextId] == DBNull.Value ? null : objRow[convzx_Answer.TextId].ToString().Trim(); //课件Id
objvzx_AnswerEN.AnswerTypeId = objRow[convzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[convzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objvzx_AnswerEN.IdCurrEduCls = objRow[convzx_Answer.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_AnswerEN.CreateDate = objRow[convzx_Answer.CreateDate] == DBNull.Value ? null : objRow[convzx_Answer.CreateDate].ToString().Trim(); //建立日期
objvzx_AnswerEN.QuestUserName = objRow[convzx_Answer.QuestUserName] == DBNull.Value ? null : objRow[convzx_Answer.QuestUserName].ToString().Trim(); //QuestUserName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_AnswerDA: GetObjByDataRow)", objException.Message));
}
objvzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_AnswerEN;
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
objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_AnswerEN._CurrTabName, convzx_Answer.zxAnswerId, 10, "");
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
objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_AnswerEN._CurrTabName, convzx_Answer.zxAnswerId, 10, strPrefix);
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxAnswerId from vzx_Answer where " + strCondition;
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxAnswerId from vzx_Answer where " + strCondition;
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
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxAnswerId)
{
CheckPrimaryKey(strzxAnswerId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Answer", "zxAnswerId = " + "'"+ strzxAnswerId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_AnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Answer", strCondition))
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
objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_AnswerENS">源对象</param>
 /// <param name = "objvzx_AnswerENT">目标对象</param>
public void CopyTo(clsvzx_AnswerEN objvzx_AnswerENS, clsvzx_AnswerEN objvzx_AnswerENT)
{
objvzx_AnswerENT.AnswerContent = objvzx_AnswerENS.AnswerContent; //答案内容
objvzx_AnswerENT.zxAnswerId = objvzx_AnswerENS.zxAnswerId; //回答Id
objvzx_AnswerENT.zxQuestionsId = objvzx_AnswerENS.zxQuestionsId; //提问Id
objvzx_AnswerENT.QuestionsTypeName = objvzx_AnswerENS.QuestionsTypeName; //问题类型名称
objvzx_AnswerENT.TextTitle = objvzx_AnswerENS.TextTitle; //TextTitle
objvzx_AnswerENT.QuestionsContent = objvzx_AnswerENS.QuestionsContent; //提问内容
objvzx_AnswerENT.zxQuestionsTypeId = objvzx_AnswerENS.zxQuestionsTypeId; //问题类型Id
objvzx_AnswerENT.UserId = objvzx_AnswerENS.UserId; //用户ID
objvzx_AnswerENT.Score = objvzx_AnswerENS.Score; //评分
objvzx_AnswerENT.ScoreType = objvzx_AnswerENS.ScoreType; //评分类型
objvzx_AnswerENT.IsRight = objvzx_AnswerENS.IsRight; //是否正确
objvzx_AnswerENT.ParentId = objvzx_AnswerENS.ParentId; //父节点Id
objvzx_AnswerENT.VoteCount = objvzx_AnswerENS.VoteCount; //点赞计数
objvzx_AnswerENT.UpdUser = objvzx_AnswerENS.UpdUser; //修改人
objvzx_AnswerENT.UserName = objvzx_AnswerENS.UserName; //用户名
objvzx_AnswerENT.UpdDate = objvzx_AnswerENS.UpdDate; //修改日期
objvzx_AnswerENT.Memo = objvzx_AnswerENS.Memo; //备注
objvzx_AnswerENT.IsPublic = objvzx_AnswerENS.IsPublic; //是否公开
objvzx_AnswerENT.IsRecommend = objvzx_AnswerENS.IsRecommend; //是否推荐
objvzx_AnswerENT.GroupTextId = objvzx_AnswerENS.GroupTextId; //小组Id
objvzx_AnswerENT.IsSubmit = objvzx_AnswerENS.IsSubmit; //是否提交
objvzx_AnswerENT.AppraiseCount = objvzx_AnswerENS.AppraiseCount; //评论数
objvzx_AnswerENT.StuScore = objvzx_AnswerENS.StuScore; //学生平均分
objvzx_AnswerENT.TeaScore = objvzx_AnswerENS.TeaScore; //教师评分
objvzx_AnswerENT.TextId = objvzx_AnswerENS.TextId; //课件Id
objvzx_AnswerENT.AnswerTypeId = objvzx_AnswerENS.AnswerTypeId; //答案类型ID
objvzx_AnswerENT.IdCurrEduCls = objvzx_AnswerENS.IdCurrEduCls; //教学班流水号
objvzx_AnswerENT.CreateDate = objvzx_AnswerENS.CreateDate; //建立日期
objvzx_AnswerENT.QuestUserName = objvzx_AnswerENS.QuestUserName; //QuestUserName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_AnswerEN objvzx_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.AnswerContent, 8000, convzx_Answer.AnswerContent);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.zxAnswerId, 10, convzx_Answer.zxAnswerId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.zxQuestionsId, 8, convzx_Answer.zxQuestionsId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.QuestionsTypeName, 50, convzx_Answer.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.TextTitle, 500, convzx_Answer.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.QuestionsContent, 1000, convzx_Answer.QuestionsContent);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.zxQuestionsTypeId, 2, convzx_Answer.zxQuestionsTypeId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.UserId, 18, convzx_Answer.UserId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.ScoreType, 1, convzx_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.ParentId, 10, convzx_Answer.ParentId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.UpdUser, 20, convzx_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.UserName, 30, convzx_Answer.UserName);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.UpdDate, 20, convzx_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.Memo, 1000, convzx_Answer.Memo);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.GroupTextId, 8, convzx_Answer.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.TextId, 8, convzx_Answer.TextId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.AnswerTypeId, 2, convzx_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.IdCurrEduCls, 8, convzx_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.CreateDate, 20, convzx_Answer.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_AnswerEN.QuestUserName, 30, convzx_Answer.QuestUserName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.AnswerContent, convzx_Answer.AnswerContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.zxAnswerId, convzx_Answer.zxAnswerId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.zxQuestionsId, convzx_Answer.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.QuestionsTypeName, convzx_Answer.QuestionsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.TextTitle, convzx_Answer.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.QuestionsContent, convzx_Answer.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.zxQuestionsTypeId, convzx_Answer.zxQuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.UserId, convzx_Answer.UserId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.ScoreType, convzx_Answer.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.ParentId, convzx_Answer.ParentId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.UpdUser, convzx_Answer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.UserName, convzx_Answer.UserName);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.UpdDate, convzx_Answer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.Memo, convzx_Answer.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.GroupTextId, convzx_Answer.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.TextId, convzx_Answer.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.AnswerTypeId, convzx_Answer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.IdCurrEduCls, convzx_Answer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.CreateDate, convzx_Answer.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_AnswerEN.QuestUserName, convzx_Answer.QuestUserName);
//检查外键字段长度
 objvzx_AnswerEN._IsCheckProperty = true;
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_AnswerEN._CurrTabName);
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_AnswerEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_AnswerDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}