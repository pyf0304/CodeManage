
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_AnswerDA
 表名:zx_Answer(01120721)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:56:42
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
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
 /// zx_Answer(zx_Answer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_AnswerDA : clsCommBase4DA
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
 return clszx_AnswerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_AnswerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_AnswerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_AnswerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_AnswerEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:zx_Answer中,检查关键字,长度不正确!(clszx_AnswerDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxAnswerId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Answer中,关键字不能为空 或 null!(clszx_AnswerDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxAnswerId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_AnswerDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable_zx_Answer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Answer.* from zx_Answer Left Join {1} on {2} where {3} and zx_Answer.zxAnswerId not in (Select top {5} zx_Answer.zxAnswerId from zx_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1} and zxAnswerId not in (Select top {2} zxAnswerId from zx_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1} and zxAnswerId not in (Select top {3} zxAnswerId from zx_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_AnswerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Answer.* from zx_Answer Left Join {1} on {2} where {3} and zx_Answer.zxAnswerId not in (Select top {5} zx_Answer.zxAnswerId from zx_Answer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1} and zxAnswerId not in (Select top {2} zxAnswerId from zx_Answer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Answer where {1} and zxAnswerId not in (Select top {3} zxAnswerId from zx_Answer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_AnswerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_AnswerDA:GetObjLst)", objException.Message));
}
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = TransNullToBool(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = TransNullToBool(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = TransNullToBool(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = TransNullToBool(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_AnswerDA: GetObjLst)", objException.Message));
}
objzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_AnswerEN);
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
public List<clszx_AnswerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_AnswerDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_AnswerEN> arrObjLst = new List<clszx_AnswerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = TransNullToBool(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = TransNullToBool(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = TransNullToBool(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = TransNullToBool(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_AnswerDA: GetObjLst)", objException.Message));
}
objzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_AnswerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Answer(ref clszx_AnswerEN objzx_AnswerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where zxAnswerId = " + "'"+ objzx_AnswerEN.zxAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_AnswerEN.zxAnswerId = objDT.Rows[0][conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerEN.zxQuestionsId = objDT.Rows[0][conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.AnswerContent = objDT.Rows[0][conzx_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_AnswerEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.ScoreType = objDT.Rows[0][conzx_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objzx_AnswerEN.IsRight = TransNullToBool(objDT.Rows[0][conzx_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.ParentId = objDT.Rows[0][conzx_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objzx_AnswerEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerEN.UpdUser = objDT.Rows[0][conzx_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerEN.UpdDate = objDT.Rows[0][conzx_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerEN.Memo = objDT.Rows[0][conzx_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_AnswerEN.IsPublic = TransNullToBool(objDT.Rows[0][conzx_Answer.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.IsRecommend = TransNullToBool(objDT.Rows[0][conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.GroupTextId = objDT.Rows[0][conzx_Answer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.TextId = objDT.Rows[0][conzx_Answer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.AnswerTypeId = objDT.Rows[0][conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objzx_AnswerEN.IdCurrEduCls = objDT.Rows[0][conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.CreateDate = objDT.Rows[0][conzx_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_AnswerDA: Getzx_Answer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxAnswerId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_AnswerEN GetObjByzxAnswerId(string strzxAnswerId)
{
CheckPrimaryKey(strzxAnswerId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where zxAnswerId = " + "'"+ strzxAnswerId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
 objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id(字段类型:char,字段长度:10,是否可空:False)
 objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型(字段类型:char,字段长度:1,是否可空:True)
 objzx_AnswerEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id(字段类型:char,字段长度:10,是否可空:True)
 objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_AnswerEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_AnswerDA: GetObjByzxAnswerId)", objException.Message));
}
return objzx_AnswerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_AnswerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_AnswerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN()
{
zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(), //回答Id
zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(), //提问Id
AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(), //答案内容
Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.Score].ToString().Trim()), //评分
ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(), //评分类型
IsRight = TransNullToBool(objRow[conzx_Answer.IsRight].ToString().Trim()), //是否正确
ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(), //父节点Id
VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.VoteCount].ToString().Trim()), //点赞计数
UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(), //备注
IsPublic = TransNullToBool(objRow[conzx_Answer.IsPublic].ToString().Trim()), //是否公开
IsRecommend = TransNullToBool(objRow[conzx_Answer.IsRecommend].ToString().Trim()), //是否推荐
GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(), //小组Id
IsSubmit = TransNullToBool(objRow[conzx_Answer.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.AppraiseCount].ToString().Trim()), //评论数
StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.TeaScore].ToString().Trim()), //教师评分
TextId = objRow[conzx_Answer.TextId].ToString().Trim(), //课件Id
AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(), //答案类型ID
IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(), //教学班流水号
CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim() //建立日期
};
objzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_AnswerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_AnswerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = TransNullToBool(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = TransNullToBool(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = TransNullToBool(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = TransNullToBool(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_AnswerDA: GetObjByDataRowzx_Answer)", objException.Message));
}
objzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_AnswerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_AnswerEN objzx_AnswerEN = new clszx_AnswerEN();
try
{
objzx_AnswerEN.zxAnswerId = objRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objzx_AnswerEN.zxQuestionsId = objRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objzx_AnswerEN.AnswerContent = objRow[conzx_Answer.AnswerContent] == DBNull.Value ? null : objRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objzx_AnswerEN.Score = objRow[conzx_Answer.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.Score].ToString().Trim()); //评分
objzx_AnswerEN.ScoreType = objRow[conzx_Answer.ScoreType] == DBNull.Value ? null : objRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objzx_AnswerEN.IsRight = TransNullToBool(objRow[conzx_Answer.IsRight].ToString().Trim()); //是否正确
objzx_AnswerEN.ParentId = objRow[conzx_Answer.ParentId] == DBNull.Value ? null : objRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objzx_AnswerEN.VoteCount = objRow[conzx_Answer.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.VoteCount].ToString().Trim()); //点赞计数
objzx_AnswerEN.UpdUser = objRow[conzx_Answer.UpdUser] == DBNull.Value ? null : objRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objzx_AnswerEN.UpdDate = objRow[conzx_Answer.UpdDate] == DBNull.Value ? null : objRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objzx_AnswerEN.Memo = objRow[conzx_Answer.Memo] == DBNull.Value ? null : objRow[conzx_Answer.Memo].ToString().Trim(); //备注
objzx_AnswerEN.IsPublic = TransNullToBool(objRow[conzx_Answer.IsPublic].ToString().Trim()); //是否公开
objzx_AnswerEN.IsRecommend = TransNullToBool(objRow[conzx_Answer.IsRecommend].ToString().Trim()); //是否推荐
objzx_AnswerEN.GroupTextId = objRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objzx_AnswerEN.IsSubmit = TransNullToBool(objRow[conzx_Answer.IsSubmit].ToString().Trim()); //是否提交
objzx_AnswerEN.AppraiseCount = objRow[conzx_Answer.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Answer.AppraiseCount].ToString().Trim()); //评论数
objzx_AnswerEN.StuScore = objRow[conzx_Answer.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.StuScore].ToString().Trim()); //学生平均分
objzx_AnswerEN.TeaScore = objRow[conzx_Answer.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Answer.TeaScore].ToString().Trim()); //教师评分
objzx_AnswerEN.TextId = objRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objzx_AnswerEN.AnswerTypeId = objRow[conzx_Answer.AnswerTypeId] == DBNull.Value ? null : objRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objzx_AnswerEN.IdCurrEduCls = objRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_AnswerEN.CreateDate = objRow[conzx_Answer.CreateDate] == DBNull.Value ? null : objRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_AnswerDA: GetObjByDataRow)", objException.Message));
}
objzx_AnswerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_AnswerEN;
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
objSQL = clszx_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_AnswerEN._CurrTabName, conzx_Answer.zxAnswerId, 10, "");
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
objSQL = clszx_AnswerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_AnswerEN._CurrTabName, conzx_Answer.zxAnswerId, 10, strPrefix);
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxAnswerId from zx_Answer where " + strCondition;
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxAnswerId from zx_Answer where " + strCondition;
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Answer", "zxAnswerId = " + "'"+ strzxAnswerId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_AnswerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Answer", strCondition))
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
objSQL = clszx_AnswerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Answer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_AnswerEN objzx_AnswerEN)
 {
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Answer");
objRow = objDS.Tables["zx_Answer"].NewRow();
objRow[conzx_Answer.zxAnswerId] = objzx_AnswerEN.zxAnswerId; //回答Id
objRow[conzx_Answer.zxQuestionsId] = objzx_AnswerEN.zxQuestionsId; //提问Id
 if (objzx_AnswerEN.AnswerContent !=  "")
 {
objRow[conzx_Answer.AnswerContent] = objzx_AnswerEN.AnswerContent; //答案内容
 }
objRow[conzx_Answer.Score] = objzx_AnswerEN.Score; //评分
 if (objzx_AnswerEN.ScoreType !=  "")
 {
objRow[conzx_Answer.ScoreType] = objzx_AnswerEN.ScoreType; //评分类型
 }
objRow[conzx_Answer.IsRight] = objzx_AnswerEN.IsRight; //是否正确
 if (objzx_AnswerEN.ParentId !=  "")
 {
objRow[conzx_Answer.ParentId] = objzx_AnswerEN.ParentId; //父节点Id
 }
objRow[conzx_Answer.VoteCount] = objzx_AnswerEN.VoteCount; //点赞计数
 if (objzx_AnswerEN.UpdUser !=  "")
 {
objRow[conzx_Answer.UpdUser] = objzx_AnswerEN.UpdUser; //修改人
 }
 if (objzx_AnswerEN.UpdDate !=  "")
 {
objRow[conzx_Answer.UpdDate] = objzx_AnswerEN.UpdDate; //修改日期
 }
 if (objzx_AnswerEN.Memo !=  "")
 {
objRow[conzx_Answer.Memo] = objzx_AnswerEN.Memo; //备注
 }
objRow[conzx_Answer.IsPublic] = objzx_AnswerEN.IsPublic; //是否公开
objRow[conzx_Answer.IsRecommend] = objzx_AnswerEN.IsRecommend; //是否推荐
objRow[conzx_Answer.GroupTextId] = objzx_AnswerEN.GroupTextId; //小组Id
objRow[conzx_Answer.IsSubmit] = objzx_AnswerEN.IsSubmit; //是否提交
objRow[conzx_Answer.AppraiseCount] = objzx_AnswerEN.AppraiseCount; //评论数
objRow[conzx_Answer.StuScore] = objzx_AnswerEN.StuScore; //学生平均分
objRow[conzx_Answer.TeaScore] = objzx_AnswerEN.TeaScore; //教师评分
objRow[conzx_Answer.TextId] = objzx_AnswerEN.TextId; //课件Id
 if (objzx_AnswerEN.AnswerTypeId !=  "")
 {
objRow[conzx_Answer.AnswerTypeId] = objzx_AnswerEN.AnswerTypeId; //答案类型ID
 }
objRow[conzx_Answer.IdCurrEduCls] = objzx_AnswerEN.IdCurrEduCls; //教学班流水号
 if (objzx_AnswerEN.CreateDate !=  "")
 {
objRow[conzx_Answer.CreateDate] = objzx_AnswerEN.CreateDate; //建立日期
 }
objDS.Tables[clszx_AnswerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_AnswerEN._CurrTabName);
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_AnswerEN objzx_AnswerEN)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxAnswerId);
 var strzxAnswerId = objzx_AnswerEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerContent);
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Score);
 arrValueListForInsert.Add(objzx_AnswerEN.Score.ToString());
 }
 
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ScoreType);
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ParentId);
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.VoteCount);
 arrValueListForInsert.Add(objzx_AnswerEN.VoteCount.ToString());
 }
 
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdUser);
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdDate);
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Memo);
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.GroupTextId);
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AppraiseCount);
 arrValueListForInsert.Add(objzx_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objzx_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.StuScore);
 arrValueListForInsert.Add(objzx_AnswerEN.StuScore.ToString());
 }
 
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TeaScore);
 arrValueListForInsert.Add(objzx_AnswerEN.TeaScore.ToString());
 }
 
 if (objzx_AnswerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TextId);
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.CreateDate);
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_AnswerEN objzx_AnswerEN)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxAnswerId);
 var strzxAnswerId = objzx_AnswerEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerContent);
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Score);
 arrValueListForInsert.Add(objzx_AnswerEN.Score.ToString());
 }
 
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ScoreType);
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ParentId);
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.VoteCount);
 arrValueListForInsert.Add(objzx_AnswerEN.VoteCount.ToString());
 }
 
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdUser);
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdDate);
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Memo);
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.GroupTextId);
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AppraiseCount);
 arrValueListForInsert.Add(objzx_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objzx_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.StuScore);
 arrValueListForInsert.Add(objzx_AnswerEN.StuScore.ToString());
 }
 
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TeaScore);
 arrValueListForInsert.Add(objzx_AnswerEN.TeaScore.ToString());
 }
 
 if (objzx_AnswerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TextId);
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.CreateDate);
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_AnswerEN.zxAnswerId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_AnswerEN objzx_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxAnswerId);
 var strzxAnswerId = objzx_AnswerEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerContent);
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Score);
 arrValueListForInsert.Add(objzx_AnswerEN.Score.ToString());
 }
 
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ScoreType);
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ParentId);
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.VoteCount);
 arrValueListForInsert.Add(objzx_AnswerEN.VoteCount.ToString());
 }
 
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdUser);
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdDate);
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Memo);
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.GroupTextId);
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AppraiseCount);
 arrValueListForInsert.Add(objzx_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objzx_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.StuScore);
 arrValueListForInsert.Add(objzx_AnswerEN.StuScore.ToString());
 }
 
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TeaScore);
 arrValueListForInsert.Add(objzx_AnswerEN.TeaScore.ToString());
 }
 
 if (objzx_AnswerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TextId);
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.CreateDate);
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_AnswerEN.zxAnswerId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_AnswerEN objzx_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_AnswerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_AnswerEN.zxAnswerId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxAnswerId);
 var strzxAnswerId = objzx_AnswerEN.zxAnswerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxAnswerId + "'");
 }
 
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.zxQuestionsId);
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxQuestionsId + "'");
 }
 
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerContent);
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerContent + "'");
 }
 
 if (objzx_AnswerEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Score);
 arrValueListForInsert.Add(objzx_AnswerEN.Score.ToString());
 }
 
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ScoreType);
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strScoreType + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsRight);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRight  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.ParentId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.ParentId);
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentId + "'");
 }
 
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.VoteCount);
 arrValueListForInsert.Add(objzx_AnswerEN.VoteCount.ToString());
 }
 
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdUser);
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.UpdDate);
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_AnswerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.Memo);
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsPublic);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsPublic  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conzx_Answer.IsRecommend);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsRecommend  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.GroupTextId);
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Answer.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_AnswerEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AppraiseCount);
 arrValueListForInsert.Add(objzx_AnswerEN.AppraiseCount.ToString());
 }
 
 if (objzx_AnswerEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.StuScore);
 arrValueListForInsert.Add(objzx_AnswerEN.StuScore.ToString());
 }
 
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TeaScore);
 arrValueListForInsert.Add(objzx_AnswerEN.TeaScore.ToString());
 }
 
 if (objzx_AnswerEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.TextId);
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.AnswerTypeId);
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTypeId + "'");
 }
 
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.IdCurrEduCls);
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Answer.CreateDate);
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Answer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Answers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where zxAnswerId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Answer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxAnswerId = oRow[conzx_Answer.zxAnswerId].ToString().Trim();
if (IsExist(strzxAnswerId))
{
 string strResult = "关键字变量值为:" + string.Format("zxAnswerId = {0}", strzxAnswerId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_AnswerEN._CurrTabName ].NewRow();
objRow[conzx_Answer.zxAnswerId] = oRow[conzx_Answer.zxAnswerId].ToString().Trim(); //回答Id
objRow[conzx_Answer.zxQuestionsId] = oRow[conzx_Answer.zxQuestionsId].ToString().Trim(); //提问Id
objRow[conzx_Answer.AnswerContent] = oRow[conzx_Answer.AnswerContent].ToString().Trim(); //答案内容
objRow[conzx_Answer.Score] = oRow[conzx_Answer.Score].ToString().Trim(); //评分
objRow[conzx_Answer.ScoreType] = oRow[conzx_Answer.ScoreType].ToString().Trim(); //评分类型
objRow[conzx_Answer.IsRight] = oRow[conzx_Answer.IsRight].ToString().Trim(); //是否正确
objRow[conzx_Answer.ParentId] = oRow[conzx_Answer.ParentId].ToString().Trim(); //父节点Id
objRow[conzx_Answer.VoteCount] = oRow[conzx_Answer.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Answer.UpdUser] = oRow[conzx_Answer.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Answer.UpdDate] = oRow[conzx_Answer.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Answer.Memo] = oRow[conzx_Answer.Memo].ToString().Trim(); //备注
objRow[conzx_Answer.IsPublic] = oRow[conzx_Answer.IsPublic].ToString().Trim(); //是否公开
objRow[conzx_Answer.IsRecommend] = oRow[conzx_Answer.IsRecommend].ToString().Trim(); //是否推荐
objRow[conzx_Answer.GroupTextId] = oRow[conzx_Answer.GroupTextId].ToString().Trim(); //小组Id
objRow[conzx_Answer.IsSubmit] = oRow[conzx_Answer.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Answer.AppraiseCount] = oRow[conzx_Answer.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Answer.StuScore] = oRow[conzx_Answer.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Answer.TeaScore] = oRow[conzx_Answer.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Answer.TextId] = oRow[conzx_Answer.TextId].ToString().Trim(); //课件Id
objRow[conzx_Answer.AnswerTypeId] = oRow[conzx_Answer.AnswerTypeId].ToString().Trim(); //答案类型ID
objRow[conzx_Answer.IdCurrEduCls] = oRow[conzx_Answer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Answer.CreateDate] = oRow[conzx_Answer.CreateDate].ToString().Trim(); //建立日期
 objDS.Tables[clszx_AnswerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_AnswerEN._CurrTabName);
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
 /// <param name = "objzx_AnswerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_AnswerEN objzx_AnswerEN)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
strSQL = "Select * from zx_Answer where zxAnswerId = " + "'"+ objzx_AnswerEN.zxAnswerId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_AnswerEN._CurrTabName);
if (objDS.Tables[clszx_AnswerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxAnswerId = " + "'"+ objzx_AnswerEN.zxAnswerId+"'");
return false;
}
objRow = objDS.Tables[clszx_AnswerEN._CurrTabName].Rows[0];
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxAnswerId))
 {
objRow[conzx_Answer.zxAnswerId] = objzx_AnswerEN.zxAnswerId; //回答Id
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxQuestionsId))
 {
objRow[conzx_Answer.zxQuestionsId] = objzx_AnswerEN.zxQuestionsId; //提问Id
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerContent))
 {
objRow[conzx_Answer.AnswerContent] = objzx_AnswerEN.AnswerContent; //答案内容
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Score))
 {
objRow[conzx_Answer.Score] = objzx_AnswerEN.Score; //评分
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ScoreType))
 {
objRow[conzx_Answer.ScoreType] = objzx_AnswerEN.ScoreType; //评分类型
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRight))
 {
objRow[conzx_Answer.IsRight] = objzx_AnswerEN.IsRight; //是否正确
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ParentId))
 {
objRow[conzx_Answer.ParentId] = objzx_AnswerEN.ParentId; //父节点Id
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.VoteCount))
 {
objRow[conzx_Answer.VoteCount] = objzx_AnswerEN.VoteCount; //点赞计数
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdUser))
 {
objRow[conzx_Answer.UpdUser] = objzx_AnswerEN.UpdUser; //修改人
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdDate))
 {
objRow[conzx_Answer.UpdDate] = objzx_AnswerEN.UpdDate; //修改日期
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Memo))
 {
objRow[conzx_Answer.Memo] = objzx_AnswerEN.Memo; //备注
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsPublic))
 {
objRow[conzx_Answer.IsPublic] = objzx_AnswerEN.IsPublic; //是否公开
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRecommend))
 {
objRow[conzx_Answer.IsRecommend] = objzx_AnswerEN.IsRecommend; //是否推荐
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.GroupTextId))
 {
objRow[conzx_Answer.GroupTextId] = objzx_AnswerEN.GroupTextId; //小组Id
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsSubmit))
 {
objRow[conzx_Answer.IsSubmit] = objzx_AnswerEN.IsSubmit; //是否提交
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AppraiseCount))
 {
objRow[conzx_Answer.AppraiseCount] = objzx_AnswerEN.AppraiseCount; //评论数
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.StuScore))
 {
objRow[conzx_Answer.StuScore] = objzx_AnswerEN.StuScore; //学生平均分
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TeaScore))
 {
objRow[conzx_Answer.TeaScore] = objzx_AnswerEN.TeaScore; //教师评分
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TextId))
 {
objRow[conzx_Answer.TextId] = objzx_AnswerEN.TextId; //课件Id
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerTypeId))
 {
objRow[conzx_Answer.AnswerTypeId] = objzx_AnswerEN.AnswerTypeId; //答案类型ID
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IdCurrEduCls))
 {
objRow[conzx_Answer.IdCurrEduCls] = objzx_AnswerEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.CreateDate))
 {
objRow[conzx_Answer.CreateDate] = objzx_AnswerEN.CreateDate; //建立日期
 }
try
{
objDA.Update(objDS, clszx_AnswerEN._CurrTabName);
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_AnswerEN objzx_AnswerEN)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Answer Set ");
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxQuestionsId))
 {
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsId, conzx_Answer.zxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.zxQuestionsId); //提问Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerContent))
 {
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conzx_Answer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AnswerContent); //答案内容
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Score))
 {
 if (objzx_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.Score, conzx_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Score); //评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ScoreType))
 {
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conzx_Answer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.ScoreType); //评分类型
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsRight == true?"1":"0", conzx_Answer.IsRight); //是否正确
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ParentId))
 {
 if (objzx_AnswerEN.ParentId !=  null)
 {
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conzx_Answer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.ParentId); //父节点Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.VoteCount))
 {
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.VoteCount, conzx_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdUser))
 {
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Answer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.UpdUser); //修改人
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdDate))
 {
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Answer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.UpdDate); //修改日期
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Memo))
 {
 if (objzx_AnswerEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Answer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Memo); //备注
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsPublic == true?"1":"0", conzx_Answer.IsPublic); //是否公开
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsRecommend == true?"1":"0", conzx_Answer.IsRecommend); //是否推荐
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.GroupTextId))
 {
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Answer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.GroupTextId); //小组Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsSubmit == true?"1":"0", conzx_Answer.IsSubmit); //是否提交
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AppraiseCount))
 {
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.AppraiseCount, conzx_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.StuScore))
 {
 if (objzx_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.StuScore, conzx_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.StuScore); //学生平均分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TeaScore))
 {
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.TeaScore, conzx_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TeaScore); //教师评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TextId))
 {
 if (objzx_AnswerEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Answer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TextId); //课件Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerTypeId))
 {
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conzx_Answer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IdCurrEduCls))
 {
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Answer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.CreateDate))
 {
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Answer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.CreateDate); //建立日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxAnswerId = '{0}'", objzx_AnswerEN.zxAnswerId); 
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
 /// <param name = "objzx_AnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_AnswerEN objzx_AnswerEN, string strCondition)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Answer Set ");
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxQuestionsId))
 {
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsId = '{0}',", strzxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsId = null,"); //提问Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerContent))
 {
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Score))
 {
 if (objzx_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.Score, conzx_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Score); //评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ScoreType))
 {
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objzx_AnswerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ParentId))
 {
 if (objzx_AnswerEN.ParentId !=  null)
 {
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.VoteCount))
 {
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.VoteCount, conzx_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdUser))
 {
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdDate))
 {
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Memo))
 {
 if (objzx_AnswerEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_AnswerEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objzx_AnswerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.GroupTextId))
 {
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_AnswerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AppraiseCount))
 {
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.AppraiseCount, conzx_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.StuScore))
 {
 if (objzx_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.StuScore, conzx_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.StuScore); //学生平均分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TeaScore))
 {
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.TeaScore, conzx_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TeaScore); //教师评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TextId))
 {
 if (objzx_AnswerEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerTypeId))
 {
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IdCurrEduCls))
 {
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.CreateDate))
 {
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
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
 /// <param name = "objzx_AnswerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_AnswerEN objzx_AnswerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Answer Set ");
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxQuestionsId))
 {
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxQuestionsId = '{0}',", strzxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.Append(" zxQuestionsId = null,"); //提问Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerContent))
 {
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerContent = '{0}',", strAnswerContent); //答案内容
 }
 else
 {
 sbSQL.Append(" AnswerContent = null,"); //答案内容
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Score))
 {
 if (objzx_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.Score, conzx_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Score); //评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ScoreType))
 {
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ScoreType = '{0}',", strScoreType); //评分类型
 }
 else
 {
 sbSQL.Append(" ScoreType = null,"); //评分类型
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objzx_AnswerEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ParentId))
 {
 if (objzx_AnswerEN.ParentId !=  null)
 {
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentId = '{0}',", strParentId); //父节点Id
 }
 else
 {
 sbSQL.Append(" ParentId = null,"); //父节点Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.VoteCount))
 {
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.VoteCount, conzx_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdUser))
 {
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdDate))
 {
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Memo))
 {
 if (objzx_AnswerEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsPublic))
 {
 sbSQL.AppendFormat(" IsPublic = '{0}',", objzx_AnswerEN.IsPublic == true?"1":"0"); //是否公开
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" IsRecommend = '{0}',", objzx_AnswerEN.IsRecommend == true?"1":"0"); //是否推荐
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.GroupTextId))
 {
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_AnswerEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AppraiseCount))
 {
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.AppraiseCount, conzx_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.StuScore))
 {
 if (objzx_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.StuScore, conzx_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.StuScore); //学生平均分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TeaScore))
 {
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.TeaScore, conzx_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TeaScore); //教师评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TextId))
 {
 if (objzx_AnswerEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerTypeId))
 {
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTypeId = '{0}',", strAnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.Append(" AnswerTypeId = null,"); //答案类型ID
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IdCurrEduCls))
 {
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.CreateDate))
 {
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
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
 /// <param name = "objzx_AnswerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_AnswerEN objzx_AnswerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_AnswerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_AnswerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Answer Set ");
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.zxQuestionsId))
 {
 if (objzx_AnswerEN.zxQuestionsId !=  null)
 {
 var strzxQuestionsId = objzx_AnswerEN.zxQuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxQuestionsId, conzx_Answer.zxQuestionsId); //提问Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.zxQuestionsId); //提问Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerContent))
 {
 if (objzx_AnswerEN.AnswerContent !=  null)
 {
 var strAnswerContent = objzx_AnswerEN.AnswerContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerContent, conzx_Answer.AnswerContent); //答案内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AnswerContent); //答案内容
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Score))
 {
 if (objzx_AnswerEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.Score, conzx_Answer.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Score); //评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ScoreType))
 {
 if (objzx_AnswerEN.ScoreType !=  null)
 {
 var strScoreType = objzx_AnswerEN.ScoreType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strScoreType, conzx_Answer.ScoreType); //评分类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.ScoreType); //评分类型
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsRight == true?"1":"0", conzx_Answer.IsRight); //是否正确
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.ParentId))
 {
 if (objzx_AnswerEN.ParentId !=  null)
 {
 var strParentId = objzx_AnswerEN.ParentId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentId, conzx_Answer.ParentId); //父节点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.ParentId); //父节点Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.VoteCount))
 {
 if (objzx_AnswerEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.VoteCount, conzx_Answer.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.VoteCount); //点赞计数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdUser))
 {
 if (objzx_AnswerEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_AnswerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Answer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.UpdUser); //修改人
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.UpdDate))
 {
 if (objzx_AnswerEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_AnswerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Answer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.UpdDate); //修改日期
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.Memo))
 {
 if (objzx_AnswerEN.Memo !=  null)
 {
 var strMemo = objzx_AnswerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Answer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.Memo); //备注
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsPublic))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsPublic == true?"1":"0", conzx_Answer.IsPublic); //是否公开
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsRecommend))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsRecommend == true?"1":"0", conzx_Answer.IsRecommend); //是否推荐
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.GroupTextId))
 {
 if (objzx_AnswerEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_AnswerEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Answer.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.GroupTextId); //小组Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_AnswerEN.IsSubmit == true?"1":"0", conzx_Answer.IsSubmit); //是否提交
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AppraiseCount))
 {
 if (objzx_AnswerEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.AppraiseCount, conzx_Answer.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AppraiseCount); //评论数
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.StuScore))
 {
 if (objzx_AnswerEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.StuScore, conzx_Answer.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.StuScore); //学生平均分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TeaScore))
 {
 if (objzx_AnswerEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_AnswerEN.TeaScore, conzx_Answer.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TeaScore); //教师评分
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.TextId))
 {
 if (objzx_AnswerEN.TextId !=  null)
 {
 var strTextId = objzx_AnswerEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Answer.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.TextId); //课件Id
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.AnswerTypeId))
 {
 if (objzx_AnswerEN.AnswerTypeId !=  null)
 {
 var strAnswerTypeId = objzx_AnswerEN.AnswerTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTypeId, conzx_Answer.AnswerTypeId); //答案类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.AnswerTypeId); //答案类型ID
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.IdCurrEduCls))
 {
 if (objzx_AnswerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_AnswerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Answer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_AnswerEN.IsUpdated(conzx_Answer.CreateDate))
 {
 if (objzx_AnswerEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_AnswerEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Answer.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Answer.CreateDate); //建立日期
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxAnswerId = '{0}'", objzx_AnswerEN.zxAnswerId); 
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
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxAnswerId) 
{
CheckPrimaryKey(strzxAnswerId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxAnswerId,
};
 objSQL.ExecSP("zx_Answer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxAnswerId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxAnswerId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
//删除zx_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Answer where zxAnswerId = " + "'"+ strzxAnswerId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Answer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
//删除zx_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Answer where zxAnswerId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxAnswerId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxAnswerId) 
{
CheckPrimaryKey(strzxAnswerId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
//删除zx_Answer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Answer where zxAnswerId = " + "'"+ strzxAnswerId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Answer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_AnswerDA: Delzx_Answer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Answer where " + strCondition ;
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
public bool Delzx_AnswerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_AnswerDA: Delzx_AnswerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Answer where " + strCondition ;
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
 /// <param name = "objzx_AnswerENS">源对象</param>
 /// <param name = "objzx_AnswerENT">目标对象</param>
public void CopyTo(clszx_AnswerEN objzx_AnswerENS, clszx_AnswerEN objzx_AnswerENT)
{
objzx_AnswerENT.zxAnswerId = objzx_AnswerENS.zxAnswerId; //回答Id
objzx_AnswerENT.zxQuestionsId = objzx_AnswerENS.zxQuestionsId; //提问Id
objzx_AnswerENT.AnswerContent = objzx_AnswerENS.AnswerContent; //答案内容
objzx_AnswerENT.Score = objzx_AnswerENS.Score; //评分
objzx_AnswerENT.ScoreType = objzx_AnswerENS.ScoreType; //评分类型
objzx_AnswerENT.IsRight = objzx_AnswerENS.IsRight; //是否正确
objzx_AnswerENT.ParentId = objzx_AnswerENS.ParentId; //父节点Id
objzx_AnswerENT.VoteCount = objzx_AnswerENS.VoteCount; //点赞计数
objzx_AnswerENT.UpdUser = objzx_AnswerENS.UpdUser; //修改人
objzx_AnswerENT.UpdDate = objzx_AnswerENS.UpdDate; //修改日期
objzx_AnswerENT.Memo = objzx_AnswerENS.Memo; //备注
objzx_AnswerENT.IsPublic = objzx_AnswerENS.IsPublic; //是否公开
objzx_AnswerENT.IsRecommend = objzx_AnswerENS.IsRecommend; //是否推荐
objzx_AnswerENT.GroupTextId = objzx_AnswerENS.GroupTextId; //小组Id
objzx_AnswerENT.IsSubmit = objzx_AnswerENS.IsSubmit; //是否提交
objzx_AnswerENT.AppraiseCount = objzx_AnswerENS.AppraiseCount; //评论数
objzx_AnswerENT.StuScore = objzx_AnswerENS.StuScore; //学生平均分
objzx_AnswerENT.TeaScore = objzx_AnswerENS.TeaScore; //教师评分
objzx_AnswerENT.TextId = objzx_AnswerENS.TextId; //课件Id
objzx_AnswerENT.AnswerTypeId = objzx_AnswerENS.AnswerTypeId; //答案类型ID
objzx_AnswerENT.IdCurrEduCls = objzx_AnswerENS.IdCurrEduCls; //教学班流水号
objzx_AnswerENT.CreateDate = objzx_AnswerENS.CreateDate; //建立日期
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_AnswerEN objzx_AnswerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_AnswerEN.zxQuestionsId, conzx_Answer.zxQuestionsId);
clsCheckSql.CheckFieldNotNull(objzx_AnswerEN.GroupTextId, conzx_Answer.GroupTextId);
clsCheckSql.CheckFieldNotNull(objzx_AnswerEN.TextId, conzx_Answer.TextId);
clsCheckSql.CheckFieldNotNull(objzx_AnswerEN.IdCurrEduCls, conzx_Answer.IdCurrEduCls);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerEN.zxAnswerId, 10, conzx_Answer.zxAnswerId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.zxQuestionsId, 8, conzx_Answer.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ScoreType, 1, conzx_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ParentId, 10, conzx_Answer.ParentId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdUser, 20, conzx_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdDate, 20, conzx_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.Memo, 1000, conzx_Answer.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.GroupTextId, 8, conzx_Answer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.TextId, 8, conzx_Answer.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.AnswerTypeId, 2, conzx_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.IdCurrEduCls, 8, conzx_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.CreateDate, 20, conzx_Answer.CreateDate);
//检查字段外键固定长度
 objzx_AnswerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_AnswerEN objzx_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerEN.zxQuestionsId, 8, conzx_Answer.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ScoreType, 1, conzx_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ParentId, 10, conzx_Answer.ParentId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdUser, 20, conzx_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdDate, 20, conzx_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.Memo, 1000, conzx_Answer.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.GroupTextId, 8, conzx_Answer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.TextId, 8, conzx_Answer.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.AnswerTypeId, 2, conzx_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.IdCurrEduCls, 8, conzx_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.CreateDate, 20, conzx_Answer.CreateDate);
//检查外键字段长度
 objzx_AnswerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_AnswerEN objzx_AnswerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_AnswerEN.zxAnswerId, 10, conzx_Answer.zxAnswerId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.zxQuestionsId, 8, conzx_Answer.zxQuestionsId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ScoreType, 1, conzx_Answer.ScoreType);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.ParentId, 10, conzx_Answer.ParentId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdUser, 20, conzx_Answer.UpdUser);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.UpdDate, 20, conzx_Answer.UpdDate);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.Memo, 1000, conzx_Answer.Memo);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.GroupTextId, 8, conzx_Answer.GroupTextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.TextId, 8, conzx_Answer.TextId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.AnswerTypeId, 2, conzx_Answer.AnswerTypeId);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.IdCurrEduCls, 8, conzx_Answer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_AnswerEN.CreateDate, 20, conzx_Answer.CreateDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.zxAnswerId, conzx_Answer.zxAnswerId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.zxQuestionsId, conzx_Answer.zxQuestionsId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.ScoreType, conzx_Answer.ScoreType);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.ParentId, conzx_Answer.ParentId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.UpdUser, conzx_Answer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.UpdDate, conzx_Answer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.Memo, conzx_Answer.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.GroupTextId, conzx_Answer.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.TextId, conzx_Answer.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.AnswerTypeId, conzx_Answer.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.IdCurrEduCls, conzx_Answer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_AnswerEN.CreateDate, conzx_Answer.CreateDate);
//检查外键字段长度
 objzx_AnswerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Answer(zx_Answer),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_AnswerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_AnswerEN objzx_AnswerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and zxQuestionsId = '{0}'", objzx_AnswerEN.zxQuestionsId);
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_AnswerEN._CurrTabName);
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_AnswerEN._CurrTabName, strCondition);
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
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
 objSQL = clszx_AnswerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}