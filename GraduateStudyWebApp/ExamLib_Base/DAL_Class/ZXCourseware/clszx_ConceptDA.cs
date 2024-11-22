
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clszx_ConceptDA
 表名:zx_Concept(01120709)
 * 版本:2023.11.15.1(服务器:WIN-SRV103-116)
 日期:2023/11/15 22:59:39
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
 /// 中学概念表(zx_Concept)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clszx_ConceptDA : clsCommBase4DA
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
 return clszx_ConceptEN._CurrTabName;
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
if (string.IsNullOrEmpty(clszx_ConceptEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clszx_ConceptEN._ConnectString);
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
 if (string.IsNullOrEmpty(clszx_ConceptEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clszx_ConceptEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strzxConceptId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strzxConceptId)
{
strzxConceptId = strzxConceptId.Replace("'", "''");
if (strzxConceptId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:zx_Concept中,检查关键字,长度不正确!(clszx_ConceptDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxConceptId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:zx_Concept中,关键字不能为空 或 null!(clszx_ConceptDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clszx_ConceptDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_zx_Concept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable_zx_Concept)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Concept.* from zx_Concept Left Join {1} on {2} where {3} and zx_Concept.zxConceptId not in (Select top {5} zx_Concept.zxConceptId from zx_Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1} and zxConceptId not in (Select top {2} zxConceptId from zx_Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1} and zxConceptId not in (Select top {3} zxConceptId from zx_Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clszx_ConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} zx_Concept.* from zx_Concept Left Join {1} on {2} where {3} and zx_Concept.zxConceptId not in (Select top {5} zx_Concept.zxConceptId from zx_Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1} and zxConceptId not in (Select top {2} zxConceptId from zx_Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from zx_Concept where {1} and zxConceptId not in (Select top {3} zxConceptId from zx_Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clszx_ConceptEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clszx_ConceptDA:GetObjLst)", objException.Message));
}
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = TransNullToBool(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ConceptDA: GetObjLst)", objException.Message));
}
objzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ConceptEN);
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
public List<clszx_ConceptEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clszx_ConceptDA:GetObjLstByTabName)", objException.Message));
}
List<clszx_ConceptEN> arrObjLst = new List<clszx_ConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = TransNullToBool(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clszx_ConceptDA: GetObjLst)", objException.Message));
}
objzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objzx_ConceptEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getzx_Concept(ref clszx_ConceptEN objzx_ConceptEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where zxConceptId = " + "'"+ objzx_ConceptEN.zxConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objzx_ConceptEN.zxConceptId = objDT.Rows[0][conzx_Concept.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.ConceptName = objDT.Rows[0][conzx_Concept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ConceptEN.ConceptContent = objDT.Rows[0][conzx_Concept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ConceptEN.TextId = objDT.Rows[0][conzx_Concept.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.IsSubmit = TransNullToBool(objDT.Rows[0][conzx_Concept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ConceptEN.VoteCount = TransNullToInt(objDT.Rows[0][conzx_Concept.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conzx_Concept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.Score = TransNullToFloat(objDT.Rows[0][conzx_Concept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.StuScore = TransNullToFloat(objDT.Rows[0][conzx_Concept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.TeaScore = TransNullToFloat(objDT.Rows[0][conzx_Concept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.IdCurrEduCls = objDT.Rows[0][conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.PdfContent = objDT.Rows[0][conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ConceptEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.CitationCount = TransNullToInt(objDT.Rows[0][conzx_Concept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.VersionCount = TransNullToInt(objDT.Rows[0][conzx_Concept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.zxShareId = objDT.Rows[0][conzx_Concept.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ConceptEN.CreateDate = objDT.Rows[0][conzx_Concept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.UpdDate = objDT.Rows[0][conzx_Concept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.UpdUser = objDT.Rows[0][conzx_Concept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.Memo = objDT.Rows[0][conzx_Concept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ConceptEN.PdfDivLet = objDT.Rows[0][conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfDivTop = objDT.Rows[0][conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfPageNumIn = objDT.Rows[0][conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfPageTop = TransNullToInt(objDT.Rows[0][conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.PdfZoom = objDT.Rows[0][conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.GroupTextId = objDT.Rows[0][conzx_Concept.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clszx_ConceptDA: Getzx_Concept)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public clszx_ConceptEN GetObjByzxConceptId(string strzxConceptId)
{
CheckPrimaryKey(strzxConceptId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where zxConceptId = " + "'"+ strzxConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
 objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clszx_ConceptDA: GetObjByzxConceptId)", objException.Message));
}
return objzx_ConceptEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clszx_ConceptEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clszx_ConceptDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN()
{
zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(), //概念Id
ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(), //概念名称
ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(), //概念内容
TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(), //课件Id
IsSubmit = TransNullToBool(objRow[conzx_Concept.IsSubmit].ToString().Trim()), //是否提交
VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VoteCount].ToString().Trim()), //点赞计数
AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.Score].ToString().Trim()), //评分
StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(), //分享Id
CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim() //小组Id
};
objzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clszx_ConceptDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clszx_ConceptEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = TransNullToBool(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clszx_ConceptDA: GetObjByDataRowzx_Concept)", objException.Message));
}
objzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clszx_ConceptEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clszx_ConceptEN objzx_ConceptEN = new clszx_ConceptEN();
try
{
objzx_ConceptEN.zxConceptId = objRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objzx_ConceptEN.ConceptName = objRow[conzx_Concept.ConceptName] == DBNull.Value ? null : objRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objzx_ConceptEN.ConceptContent = objRow[conzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objzx_ConceptEN.TextId = objRow[conzx_Concept.TextId] == DBNull.Value ? null : objRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objzx_ConceptEN.IsSubmit = TransNullToBool(objRow[conzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objzx_ConceptEN.VoteCount = objRow[conzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objzx_ConceptEN.AppraiseCount = objRow[conzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objzx_ConceptEN.Score = objRow[conzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.Score].ToString().Trim()); //评分
objzx_ConceptEN.StuScore = objRow[conzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.StuScore].ToString().Trim()); //学生平均分
objzx_ConceptEN.TeaScore = objRow[conzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conzx_Concept.TeaScore].ToString().Trim()); //教师评分
objzx_ConceptEN.IdCurrEduCls = objRow[conzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objzx_ConceptEN.PdfContent = objRow[conzx_Concept.PdfContent] == DBNull.Value ? null : objRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objzx_ConceptEN.PdfPageNum = objRow[conzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objzx_ConceptEN.CitationCount = objRow[conzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.CitationCount].ToString().Trim()); //引用统计
objzx_ConceptEN.VersionCount = objRow[conzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.VersionCount].ToString().Trim()); //版本统计
objzx_ConceptEN.zxShareId = objRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objzx_ConceptEN.CreateDate = objRow[conzx_Concept.CreateDate] == DBNull.Value ? null : objRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objzx_ConceptEN.UpdDate = objRow[conzx_Concept.UpdDate] == DBNull.Value ? null : objRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objzx_ConceptEN.UpdUser = objRow[conzx_Concept.UpdUser] == DBNull.Value ? null : objRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objzx_ConceptEN.Memo = objRow[conzx_Concept.Memo] == DBNull.Value ? null : objRow[conzx_Concept.Memo].ToString().Trim(); //备注
objzx_ConceptEN.PdfDivLet = objRow[conzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objzx_ConceptEN.PdfDivTop = objRow[conzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objzx_ConceptEN.PdfPageNumIn = objRow[conzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objzx_ConceptEN.PdfPageTop = objRow[conzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objzx_ConceptEN.PdfZoom = objRow[conzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objzx_ConceptEN.GroupTextId = objRow[conzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clszx_ConceptDA: GetObjByDataRow)", objException.Message));
}
objzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objzx_ConceptEN;
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
objSQL = clszx_ConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ConceptEN._CurrTabName, conzx_Concept.zxConceptId, 8, "");
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
objSQL = clszx_ConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clszx_ConceptEN._CurrTabName, conzx_Concept.zxConceptId, 8, strPrefix);
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxConceptId from zx_Concept where " + strCondition;
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxConceptId from zx_Concept where " + strCondition;
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
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strzxConceptId)
{
CheckPrimaryKey(strzxConceptId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Concept", "zxConceptId = " + "'"+ strzxConceptId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clszx_ConceptDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("zx_Concept", strCondition))
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
objSQL = clszx_ConceptDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("zx_Concept");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clszx_ConceptEN objzx_ConceptEN)
 {
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Concept");
objRow = objDS.Tables["zx_Concept"].NewRow();
objRow[conzx_Concept.zxConceptId] = objzx_ConceptEN.zxConceptId; //概念Id
 if (objzx_ConceptEN.ConceptName !=  "")
 {
objRow[conzx_Concept.ConceptName] = objzx_ConceptEN.ConceptName; //概念名称
 }
 if (objzx_ConceptEN.ConceptContent !=  "")
 {
objRow[conzx_Concept.ConceptContent] = objzx_ConceptEN.ConceptContent; //概念内容
 }
 if (objzx_ConceptEN.TextId !=  "")
 {
objRow[conzx_Concept.TextId] = objzx_ConceptEN.TextId; //课件Id
 }
objRow[conzx_Concept.IsSubmit] = objzx_ConceptEN.IsSubmit; //是否提交
objRow[conzx_Concept.VoteCount] = objzx_ConceptEN.VoteCount; //点赞计数
objRow[conzx_Concept.AppraiseCount] = objzx_ConceptEN.AppraiseCount; //评论数
objRow[conzx_Concept.Score] = objzx_ConceptEN.Score; //评分
objRow[conzx_Concept.StuScore] = objzx_ConceptEN.StuScore; //学生平均分
objRow[conzx_Concept.TeaScore] = objzx_ConceptEN.TeaScore; //教师评分
 if (objzx_ConceptEN.IdCurrEduCls !=  "")
 {
objRow[conzx_Concept.IdCurrEduCls] = objzx_ConceptEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ConceptEN.PdfContent !=  "")
 {
objRow[conzx_Concept.PdfContent] = objzx_ConceptEN.PdfContent; //Pdf内容
 }
objRow[conzx_Concept.PdfPageNum] = objzx_ConceptEN.PdfPageNum; //Pdf页码
objRow[conzx_Concept.CitationCount] = objzx_ConceptEN.CitationCount; //引用统计
objRow[conzx_Concept.VersionCount] = objzx_ConceptEN.VersionCount; //版本统计
objRow[conzx_Concept.zxShareId] = objzx_ConceptEN.zxShareId; //分享Id
 if (objzx_ConceptEN.CreateDate !=  "")
 {
objRow[conzx_Concept.CreateDate] = objzx_ConceptEN.CreateDate; //建立日期
 }
 if (objzx_ConceptEN.UpdDate !=  "")
 {
objRow[conzx_Concept.UpdDate] = objzx_ConceptEN.UpdDate; //修改日期
 }
 if (objzx_ConceptEN.UpdUser !=  "")
 {
objRow[conzx_Concept.UpdUser] = objzx_ConceptEN.UpdUser; //修改人
 }
 if (objzx_ConceptEN.Memo !=  "")
 {
objRow[conzx_Concept.Memo] = objzx_ConceptEN.Memo; //备注
 }
 if (objzx_ConceptEN.PdfDivLet !=  "")
 {
objRow[conzx_Concept.PdfDivLet] = objzx_ConceptEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ConceptEN.PdfDivTop !=  "")
 {
objRow[conzx_Concept.PdfDivTop] = objzx_ConceptEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ConceptEN.PdfPageNumIn !=  "")
 {
objRow[conzx_Concept.PdfPageNumIn] = objzx_ConceptEN.PdfPageNumIn; //PdfPageNumIn
 }
objRow[conzx_Concept.PdfPageTop] = objzx_ConceptEN.PdfPageTop; //pdf页面顶部位置
 if (objzx_ConceptEN.PdfZoom !=  "")
 {
objRow[conzx_Concept.PdfZoom] = objzx_ConceptEN.PdfZoom; //PdfZoom
 }
 if (objzx_ConceptEN.GroupTextId !=  "")
 {
objRow[conzx_Concept.GroupTextId] = objzx_ConceptEN.GroupTextId; //小组Id
 }
objDS.Tables[clszx_ConceptEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clszx_ConceptEN._CurrTabName);
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ConceptEN objzx_ConceptEN)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ConceptEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxConceptId);
 var strzxConceptId = objzx_ConceptEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptName);
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptContent);
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TextId);
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Concept.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Score);
 arrValueListForInsert.Add(objzx_ConceptEN.Score.ToString());
 }
 
 if (objzx_ConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.StuScore);
 arrValueListForInsert.Add(objzx_ConceptEN.StuScore.ToString());
 }
 
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfContent);
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxShareId);
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CreateDate);
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdDate);
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdUser);
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Memo);
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivLet);
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivTop);
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfZoom);
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.GroupTextId);
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Concept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ConceptEN objzx_ConceptEN)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ConceptEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxConceptId);
 var strzxConceptId = objzx_ConceptEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptName);
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptContent);
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TextId);
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Concept.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Score);
 arrValueListForInsert.Add(objzx_ConceptEN.Score.ToString());
 }
 
 if (objzx_ConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.StuScore);
 arrValueListForInsert.Add(objzx_ConceptEN.StuScore.ToString());
 }
 
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfContent);
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxShareId);
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CreateDate);
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdDate);
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdUser);
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Memo);
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivLet);
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivTop);
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfZoom);
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.GroupTextId);
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Concept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objzx_ConceptEN.zxConceptId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clszx_ConceptEN objzx_ConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ConceptEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxConceptId);
 var strzxConceptId = objzx_ConceptEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptName);
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptContent);
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TextId);
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Concept.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Score);
 arrValueListForInsert.Add(objzx_ConceptEN.Score.ToString());
 }
 
 if (objzx_ConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.StuScore);
 arrValueListForInsert.Add(objzx_ConceptEN.StuScore.ToString());
 }
 
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfContent);
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxShareId);
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CreateDate);
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdDate);
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdUser);
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Memo);
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivLet);
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivTop);
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfZoom);
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.GroupTextId);
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Concept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objzx_ConceptEN.zxConceptId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clszx_ConceptEN objzx_ConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objzx_ConceptEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objzx_ConceptEN.zxConceptId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxConceptId);
 var strzxConceptId = objzx_ConceptEN.zxConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxConceptId + "'");
 }
 
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptName);
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.ConceptContent);
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 if (objzx_ConceptEN.TextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TextId);
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextId + "'");
 }
 
 arrFieldListForInsert.Add(conzx_Concept.IsSubmit);
 arrValueListForInsert.Add("'" + (objzx_ConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VoteCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VoteCount.ToString());
 }
 
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.AppraiseCount);
 arrValueListForInsert.Add(objzx_ConceptEN.AppraiseCount.ToString());
 }
 
 if (objzx_ConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Score);
 arrValueListForInsert.Add(objzx_ConceptEN.Score.ToString());
 }
 
 if (objzx_ConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.StuScore);
 arrValueListForInsert.Add(objzx_ConceptEN.StuScore.ToString());
 }
 
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.TeaScore);
 arrValueListForInsert.Add(objzx_ConceptEN.TeaScore.ToString());
 }
 
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.IdCurrEduCls);
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfContent);
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNum);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageNum.ToString());
 }
 
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CitationCount);
 arrValueListForInsert.Add(objzx_ConceptEN.CitationCount.ToString());
 }
 
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.VersionCount);
 arrValueListForInsert.Add(objzx_ConceptEN.VersionCount.ToString());
 }
 
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.zxShareId);
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strzxShareId + "'");
 }
 
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.CreateDate);
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdDate);
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.UpdUser);
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objzx_ConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.Memo);
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivLet);
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivLet + "'");
 }
 
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfDivTop);
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfDivTop + "'");
 }
 
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageNumIn);
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfPageNumIn + "'");
 }
 
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfPageTop);
 arrValueListForInsert.Add(objzx_ConceptEN.PdfPageTop.ToString());
 }
 
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.PdfZoom);
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfZoom + "'");
 }
 
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 arrFieldListForInsert.Add(conzx_Concept.GroupTextId);
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGroupTextId + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into zx_Concept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewzx_Concepts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where zxConceptId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "zx_Concept");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strzxConceptId = oRow[conzx_Concept.zxConceptId].ToString().Trim();
if (IsExist(strzxConceptId))
{
 string strResult = "关键字变量值为:" + string.Format("zxConceptId = {0}", strzxConceptId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clszx_ConceptEN._CurrTabName ].NewRow();
objRow[conzx_Concept.zxConceptId] = oRow[conzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objRow[conzx_Concept.ConceptName] = oRow[conzx_Concept.ConceptName].ToString().Trim(); //概念名称
objRow[conzx_Concept.ConceptContent] = oRow[conzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objRow[conzx_Concept.TextId] = oRow[conzx_Concept.TextId].ToString().Trim(); //课件Id
objRow[conzx_Concept.IsSubmit] = oRow[conzx_Concept.IsSubmit].ToString().Trim(); //是否提交
objRow[conzx_Concept.VoteCount] = oRow[conzx_Concept.VoteCount].ToString().Trim(); //点赞计数
objRow[conzx_Concept.AppraiseCount] = oRow[conzx_Concept.AppraiseCount].ToString().Trim(); //评论数
objRow[conzx_Concept.Score] = oRow[conzx_Concept.Score].ToString().Trim(); //评分
objRow[conzx_Concept.StuScore] = oRow[conzx_Concept.StuScore].ToString().Trim(); //学生平均分
objRow[conzx_Concept.TeaScore] = oRow[conzx_Concept.TeaScore].ToString().Trim(); //教师评分
objRow[conzx_Concept.IdCurrEduCls] = oRow[conzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conzx_Concept.PdfContent] = oRow[conzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objRow[conzx_Concept.PdfPageNum] = oRow[conzx_Concept.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conzx_Concept.CitationCount] = oRow[conzx_Concept.CitationCount].ToString().Trim(); //引用统计
objRow[conzx_Concept.VersionCount] = oRow[conzx_Concept.VersionCount].ToString().Trim(); //版本统计
objRow[conzx_Concept.zxShareId] = oRow[conzx_Concept.zxShareId].ToString().Trim(); //分享Id
objRow[conzx_Concept.CreateDate] = oRow[conzx_Concept.CreateDate].ToString().Trim(); //建立日期
objRow[conzx_Concept.UpdDate] = oRow[conzx_Concept.UpdDate].ToString().Trim(); //修改日期
objRow[conzx_Concept.UpdUser] = oRow[conzx_Concept.UpdUser].ToString().Trim(); //修改人
objRow[conzx_Concept.Memo] = oRow[conzx_Concept.Memo].ToString().Trim(); //备注
objRow[conzx_Concept.PdfDivLet] = oRow[conzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objRow[conzx_Concept.PdfDivTop] = oRow[conzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objRow[conzx_Concept.PdfPageNumIn] = oRow[conzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objRow[conzx_Concept.PdfPageTop] = oRow[conzx_Concept.PdfPageTop].ToString().Trim(); //pdf页面顶部位置
objRow[conzx_Concept.PdfZoom] = oRow[conzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objRow[conzx_Concept.GroupTextId] = oRow[conzx_Concept.GroupTextId].ToString().Trim(); //小组Id
 objDS.Tables[clszx_ConceptEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clszx_ConceptEN._CurrTabName);
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
 /// <param name = "objzx_ConceptEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clszx_ConceptEN objzx_ConceptEN)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from zx_Concept where zxConceptId = " + "'"+ objzx_ConceptEN.zxConceptId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clszx_ConceptEN._CurrTabName);
if (objDS.Tables[clszx_ConceptEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:zxConceptId = " + "'"+ objzx_ConceptEN.zxConceptId+"'");
return false;
}
objRow = objDS.Tables[clszx_ConceptEN._CurrTabName].Rows[0];
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxConceptId))
 {
objRow[conzx_Concept.zxConceptId] = objzx_ConceptEN.zxConceptId; //概念Id
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptName))
 {
objRow[conzx_Concept.ConceptName] = objzx_ConceptEN.ConceptName; //概念名称
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptContent))
 {
objRow[conzx_Concept.ConceptContent] = objzx_ConceptEN.ConceptContent; //概念内容
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TextId))
 {
objRow[conzx_Concept.TextId] = objzx_ConceptEN.TextId; //课件Id
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IsSubmit))
 {
objRow[conzx_Concept.IsSubmit] = objzx_ConceptEN.IsSubmit; //是否提交
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VoteCount))
 {
objRow[conzx_Concept.VoteCount] = objzx_ConceptEN.VoteCount; //点赞计数
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.AppraiseCount))
 {
objRow[conzx_Concept.AppraiseCount] = objzx_ConceptEN.AppraiseCount; //评论数
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Score))
 {
objRow[conzx_Concept.Score] = objzx_ConceptEN.Score; //评分
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.StuScore))
 {
objRow[conzx_Concept.StuScore] = objzx_ConceptEN.StuScore; //学生平均分
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TeaScore))
 {
objRow[conzx_Concept.TeaScore] = objzx_ConceptEN.TeaScore; //教师评分
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IdCurrEduCls))
 {
objRow[conzx_Concept.IdCurrEduCls] = objzx_ConceptEN.IdCurrEduCls; //教学班流水号
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfContent))
 {
objRow[conzx_Concept.PdfContent] = objzx_ConceptEN.PdfContent; //Pdf内容
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNum))
 {
objRow[conzx_Concept.PdfPageNum] = objzx_ConceptEN.PdfPageNum; //Pdf页码
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CitationCount))
 {
objRow[conzx_Concept.CitationCount] = objzx_ConceptEN.CitationCount; //引用统计
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VersionCount))
 {
objRow[conzx_Concept.VersionCount] = objzx_ConceptEN.VersionCount; //版本统计
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxShareId))
 {
objRow[conzx_Concept.zxShareId] = objzx_ConceptEN.zxShareId; //分享Id
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CreateDate))
 {
objRow[conzx_Concept.CreateDate] = objzx_ConceptEN.CreateDate; //建立日期
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdDate))
 {
objRow[conzx_Concept.UpdDate] = objzx_ConceptEN.UpdDate; //修改日期
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdUser))
 {
objRow[conzx_Concept.UpdUser] = objzx_ConceptEN.UpdUser; //修改人
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Memo))
 {
objRow[conzx_Concept.Memo] = objzx_ConceptEN.Memo; //备注
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivLet))
 {
objRow[conzx_Concept.PdfDivLet] = objzx_ConceptEN.PdfDivLet; //PdfDivLet
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivTop))
 {
objRow[conzx_Concept.PdfDivTop] = objzx_ConceptEN.PdfDivTop; //PdfDivTop
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNumIn))
 {
objRow[conzx_Concept.PdfPageNumIn] = objzx_ConceptEN.PdfPageNumIn; //PdfPageNumIn
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageTop))
 {
objRow[conzx_Concept.PdfPageTop] = objzx_ConceptEN.PdfPageTop; //pdf页面顶部位置
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfZoom))
 {
objRow[conzx_Concept.PdfZoom] = objzx_ConceptEN.PdfZoom; //PdfZoom
 }
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.GroupTextId))
 {
objRow[conzx_Concept.GroupTextId] = objzx_ConceptEN.GroupTextId; //小组Id
 }
try
{
objDA.Update(objDS, clszx_ConceptEN._CurrTabName);
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ConceptEN objzx_ConceptEN)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update zx_Concept Set ");
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptName))
 {
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conzx_Concept.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.ConceptName); //概念名称
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptContent))
 {
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conzx_Concept.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.ConceptContent); //概念内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TextId))
 {
 if (objzx_ConceptEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Concept.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TextId); //课件Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ConceptEN.IsSubmit == true?"1":"0", conzx_Concept.IsSubmit); //是否提交
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VoteCount))
 {
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VoteCount, conzx_Concept.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.AppraiseCount))
 {
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.AppraiseCount, conzx_Concept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Score))
 {
 if (objzx_ConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.Score, conzx_Concept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Score); //评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.StuScore))
 {
 if (objzx_ConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.StuScore, conzx_Concept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TeaScore))
 {
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.TeaScore, conzx_Concept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IdCurrEduCls))
 {
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Concept.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfContent))
 {
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Concept.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNum))
 {
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageNum, conzx_Concept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CitationCount))
 {
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.CitationCount, conzx_Concept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VersionCount))
 {
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VersionCount, conzx_Concept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxShareId))
 {
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Concept.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.zxShareId); //分享Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CreateDate))
 {
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Concept.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CreateDate); //建立日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdDate))
 {
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Concept.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.UpdDate); //修改日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdUser))
 {
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Concept.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.UpdUser); //修改人
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Memo))
 {
 if (objzx_ConceptEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Concept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Memo); //备注
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivLet))
 {
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Concept.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivTop))
 {
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Concept.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNumIn))
 {
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Concept.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageTop))
 {
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageTop, conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfZoom))
 {
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Concept.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.GroupTextId))
 {
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Concept.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxConceptId = '{0}'", objzx_ConceptEN.zxConceptId); 
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
 /// <param name = "objzx_ConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clszx_ConceptEN objzx_ConceptEN, string strCondition)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Concept Set ");
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptName))
 {
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptContent))
 {
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TextId))
 {
 if (objzx_ConceptEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ConceptEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VoteCount))
 {
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VoteCount, conzx_Concept.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.AppraiseCount))
 {
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.AppraiseCount, conzx_Concept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Score))
 {
 if (objzx_ConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.Score, conzx_Concept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Score); //评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.StuScore))
 {
 if (objzx_ConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.StuScore, conzx_Concept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TeaScore))
 {
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.TeaScore, conzx_Concept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IdCurrEduCls))
 {
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfContent))
 {
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNum))
 {
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageNum, conzx_Concept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CitationCount))
 {
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.CitationCount, conzx_Concept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VersionCount))
 {
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VersionCount, conzx_Concept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxShareId))
 {
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CreateDate))
 {
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdDate))
 {
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdUser))
 {
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Memo))
 {
 if (objzx_ConceptEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivLet))
 {
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivTop))
 {
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNumIn))
 {
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageTop))
 {
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageTop, conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfZoom))
 {
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.GroupTextId))
 {
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clszx_ConceptEN objzx_ConceptEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Concept Set ");
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptName))
 {
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptContent))
 {
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TextId))
 {
 if (objzx_ConceptEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextId = '{0}',", strTextId); //课件Id
 }
 else
 {
 sbSQL.Append(" TextId = null,"); //课件Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objzx_ConceptEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VoteCount))
 {
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VoteCount, conzx_Concept.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.AppraiseCount))
 {
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.AppraiseCount, conzx_Concept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Score))
 {
 if (objzx_ConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.Score, conzx_Concept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Score); //评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.StuScore))
 {
 if (objzx_ConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.StuScore, conzx_Concept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TeaScore))
 {
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.TeaScore, conzx_Concept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IdCurrEduCls))
 {
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfContent))
 {
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNum))
 {
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageNum, conzx_Concept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CitationCount))
 {
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.CitationCount, conzx_Concept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VersionCount))
 {
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VersionCount, conzx_Concept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxShareId))
 {
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" zxShareId = '{0}',", strzxShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" zxShareId = null,"); //分享Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CreateDate))
 {
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdDate))
 {
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdUser))
 {
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Memo))
 {
 if (objzx_ConceptEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivLet))
 {
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivLet = '{0}',", strPdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.Append(" PdfDivLet = null,"); //PdfDivLet
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivTop))
 {
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfDivTop = '{0}',", strPdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.Append(" PdfDivTop = null,"); //PdfDivTop
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNumIn))
 {
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfPageNumIn = '{0}',", strPdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.Append(" PdfPageNumIn = null,"); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageTop))
 {
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageTop, conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfZoom))
 {
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfZoom = '{0}',", strPdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.Append(" PdfZoom = null,"); //PdfZoom
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.GroupTextId))
 {
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GroupTextId = '{0}',", strGroupTextId); //小组Id
 }
 else
 {
 sbSQL.Append(" GroupTextId = null,"); //小组Id
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
 /// <param name = "objzx_ConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clszx_ConceptEN objzx_ConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objzx_ConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objzx_ConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update zx_Concept Set ");
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptName))
 {
 if (objzx_ConceptEN.ConceptName !=  null)
 {
 var strConceptName = objzx_ConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conzx_Concept.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.ConceptName); //概念名称
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.ConceptContent))
 {
 if (objzx_ConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objzx_ConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conzx_Concept.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.ConceptContent); //概念内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TextId))
 {
 if (objzx_ConceptEN.TextId !=  null)
 {
 var strTextId = objzx_ConceptEN.TextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextId, conzx_Concept.TextId); //课件Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TextId); //课件Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objzx_ConceptEN.IsSubmit == true?"1":"0", conzx_Concept.IsSubmit); //是否提交
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VoteCount))
 {
 if (objzx_ConceptEN.VoteCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VoteCount, conzx_Concept.VoteCount); //点赞计数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VoteCount); //点赞计数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.AppraiseCount))
 {
 if (objzx_ConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.AppraiseCount, conzx_Concept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.AppraiseCount); //评论数
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Score))
 {
 if (objzx_ConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.Score, conzx_Concept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Score); //评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.StuScore))
 {
 if (objzx_ConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.StuScore, conzx_Concept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.StuScore); //学生平均分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.TeaScore))
 {
 if (objzx_ConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.TeaScore, conzx_Concept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.TeaScore); //教师评分
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.IdCurrEduCls))
 {
 if (objzx_ConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objzx_ConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conzx_Concept.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfContent))
 {
 if (objzx_ConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objzx_ConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conzx_Concept.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfContent); //Pdf内容
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNum))
 {
 if (objzx_ConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageNum, conzx_Concept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CitationCount))
 {
 if (objzx_ConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.CitationCount, conzx_Concept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CitationCount); //引用统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.VersionCount))
 {
 if (objzx_ConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.VersionCount, conzx_Concept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.VersionCount); //版本统计
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.zxShareId))
 {
 if (objzx_ConceptEN.zxShareId !=  null)
 {
 var strzxShareId = objzx_ConceptEN.zxShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strzxShareId, conzx_Concept.zxShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.zxShareId); //分享Id
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.CreateDate))
 {
 if (objzx_ConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objzx_ConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conzx_Concept.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.CreateDate); //建立日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdDate))
 {
 if (objzx_ConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objzx_ConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conzx_Concept.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.UpdDate); //修改日期
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.UpdUser))
 {
 if (objzx_ConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objzx_ConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conzx_Concept.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.UpdUser); //修改人
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.Memo))
 {
 if (objzx_ConceptEN.Memo !=  null)
 {
 var strMemo = objzx_ConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conzx_Concept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.Memo); //备注
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivLet))
 {
 if (objzx_ConceptEN.PdfDivLet !=  null)
 {
 var strPdfDivLet = objzx_ConceptEN.PdfDivLet.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivLet, conzx_Concept.PdfDivLet); //PdfDivLet
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfDivLet); //PdfDivLet
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfDivTop))
 {
 if (objzx_ConceptEN.PdfDivTop !=  null)
 {
 var strPdfDivTop = objzx_ConceptEN.PdfDivTop.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfDivTop, conzx_Concept.PdfDivTop); //PdfDivTop
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfDivTop); //PdfDivTop
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageNumIn))
 {
 if (objzx_ConceptEN.PdfPageNumIn !=  null)
 {
 var strPdfPageNumIn = objzx_ConceptEN.PdfPageNumIn.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfPageNumIn, conzx_Concept.PdfPageNumIn); //PdfPageNumIn
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageNumIn); //PdfPageNumIn
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfPageTop))
 {
 if (objzx_ConceptEN.PdfPageTop !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objzx_ConceptEN.PdfPageTop, conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfPageTop); //pdf页面顶部位置
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.PdfZoom))
 {
 if (objzx_ConceptEN.PdfZoom !=  null)
 {
 var strPdfZoom = objzx_ConceptEN.PdfZoom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfZoom, conzx_Concept.PdfZoom); //PdfZoom
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.PdfZoom); //PdfZoom
 }
 }
 
 if (objzx_ConceptEN.IsUpdated(conzx_Concept.GroupTextId))
 {
 if (objzx_ConceptEN.GroupTextId !=  null)
 {
 var strGroupTextId = objzx_ConceptEN.GroupTextId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGroupTextId, conzx_Concept.GroupTextId); //小组Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conzx_Concept.GroupTextId); //小组Id
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where zxConceptId = '{0}'", objzx_ConceptEN.zxConceptId); 
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
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strzxConceptId) 
{
CheckPrimaryKey(strzxConceptId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strzxConceptId,
};
 objSQL.ExecSP("zx_Concept_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strzxConceptId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strzxConceptId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
//删除zx_Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Concept where zxConceptId = " + "'"+ strzxConceptId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delzx_Concept(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
//删除zx_Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Concept where zxConceptId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strzxConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strzxConceptId) 
{
CheckPrimaryKey(strzxConceptId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
//删除zx_Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from zx_Concept where zxConceptId = " + "'"+ strzxConceptId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delzx_Concept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clszx_ConceptDA: Delzx_Concept)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Concept where " + strCondition ;
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
public bool Delzx_ConceptWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clszx_ConceptDA: Delzx_ConceptWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from zx_Concept where " + strCondition ;
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
 /// <param name = "objzx_ConceptENS">源对象</param>
 /// <param name = "objzx_ConceptENT">目标对象</param>
public void CopyTo(clszx_ConceptEN objzx_ConceptENS, clszx_ConceptEN objzx_ConceptENT)
{
objzx_ConceptENT.zxConceptId = objzx_ConceptENS.zxConceptId; //概念Id
objzx_ConceptENT.ConceptName = objzx_ConceptENS.ConceptName; //概念名称
objzx_ConceptENT.ConceptContent = objzx_ConceptENS.ConceptContent; //概念内容
objzx_ConceptENT.TextId = objzx_ConceptENS.TextId; //课件Id
objzx_ConceptENT.IsSubmit = objzx_ConceptENS.IsSubmit; //是否提交
objzx_ConceptENT.VoteCount = objzx_ConceptENS.VoteCount; //点赞计数
objzx_ConceptENT.AppraiseCount = objzx_ConceptENS.AppraiseCount; //评论数
objzx_ConceptENT.Score = objzx_ConceptENS.Score; //评分
objzx_ConceptENT.StuScore = objzx_ConceptENS.StuScore; //学生平均分
objzx_ConceptENT.TeaScore = objzx_ConceptENS.TeaScore; //教师评分
objzx_ConceptENT.IdCurrEduCls = objzx_ConceptENS.IdCurrEduCls; //教学班流水号
objzx_ConceptENT.PdfContent = objzx_ConceptENS.PdfContent; //Pdf内容
objzx_ConceptENT.PdfPageNum = objzx_ConceptENS.PdfPageNum; //Pdf页码
objzx_ConceptENT.CitationCount = objzx_ConceptENS.CitationCount; //引用统计
objzx_ConceptENT.VersionCount = objzx_ConceptENS.VersionCount; //版本统计
objzx_ConceptENT.zxShareId = objzx_ConceptENS.zxShareId; //分享Id
objzx_ConceptENT.CreateDate = objzx_ConceptENS.CreateDate; //建立日期
objzx_ConceptENT.UpdDate = objzx_ConceptENS.UpdDate; //修改日期
objzx_ConceptENT.UpdUser = objzx_ConceptENS.UpdUser; //修改人
objzx_ConceptENT.Memo = objzx_ConceptENS.Memo; //备注
objzx_ConceptENT.PdfDivLet = objzx_ConceptENS.PdfDivLet; //PdfDivLet
objzx_ConceptENT.PdfDivTop = objzx_ConceptENS.PdfDivTop; //PdfDivTop
objzx_ConceptENT.PdfPageNumIn = objzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objzx_ConceptENT.PdfPageTop = objzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objzx_ConceptENT.PdfZoom = objzx_ConceptENS.PdfZoom; //PdfZoom
objzx_ConceptENT.GroupTextId = objzx_ConceptENS.GroupTextId; //小组Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clszx_ConceptEN objzx_ConceptEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objzx_ConceptEN.zxShareId, conzx_Concept.zxShareId);
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptEN.zxConceptId, 8, conzx_Concept.zxConceptId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.ConceptName, 500, conzx_Concept.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.TextId, 8, conzx_Concept.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.IdCurrEduCls, 8, conzx_Concept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfContent, 2000, conzx_Concept.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.zxShareId, 2, conzx_Concept.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.CreateDate, 20, conzx_Concept.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdDate, 20, conzx_Concept.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdUser, 20, conzx_Concept.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.Memo, 1000, conzx_Concept.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivLet, 50, conzx_Concept.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivTop, 50, conzx_Concept.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfPageNumIn, 50, conzx_Concept.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfZoom, 50, conzx_Concept.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.GroupTextId, 8, conzx_Concept.GroupTextId);
//检查字段外键固定长度
 objzx_ConceptEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clszx_ConceptEN objzx_ConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptEN.ConceptName, 500, conzx_Concept.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.TextId, 8, conzx_Concept.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.IdCurrEduCls, 8, conzx_Concept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfContent, 2000, conzx_Concept.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.zxShareId, 2, conzx_Concept.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.CreateDate, 20, conzx_Concept.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdDate, 20, conzx_Concept.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdUser, 20, conzx_Concept.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.Memo, 1000, conzx_Concept.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivLet, 50, conzx_Concept.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivTop, 50, conzx_Concept.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfPageNumIn, 50, conzx_Concept.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfZoom, 50, conzx_Concept.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.GroupTextId, 8, conzx_Concept.GroupTextId);
//检查外键字段长度
 objzx_ConceptEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clszx_ConceptEN objzx_ConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objzx_ConceptEN.zxConceptId, 8, conzx_Concept.zxConceptId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.ConceptName, 500, conzx_Concept.ConceptName);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.TextId, 8, conzx_Concept.TextId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.IdCurrEduCls, 8, conzx_Concept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfContent, 2000, conzx_Concept.PdfContent);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.zxShareId, 2, conzx_Concept.zxShareId);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.CreateDate, 20, conzx_Concept.CreateDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdDate, 20, conzx_Concept.UpdDate);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.UpdUser, 20, conzx_Concept.UpdUser);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.Memo, 1000, conzx_Concept.Memo);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivLet, 50, conzx_Concept.PdfDivLet);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfDivTop, 50, conzx_Concept.PdfDivTop);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfPageNumIn, 50, conzx_Concept.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.PdfZoom, 50, conzx_Concept.PdfZoom);
clsCheckSql.CheckFieldLen(objzx_ConceptEN.GroupTextId, 8, conzx_Concept.GroupTextId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.zxConceptId, conzx_Concept.zxConceptId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.ConceptName, conzx_Concept.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.TextId, conzx_Concept.TextId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.IdCurrEduCls, conzx_Concept.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.PdfContent, conzx_Concept.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.zxShareId, conzx_Concept.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.CreateDate, conzx_Concept.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.UpdDate, conzx_Concept.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.UpdUser, conzx_Concept.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.Memo, conzx_Concept.Memo);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.PdfDivLet, conzx_Concept.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.PdfDivTop, conzx_Concept.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.PdfPageNumIn, conzx_Concept.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.PdfZoom, conzx_Concept.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objzx_ConceptEN.GroupTextId, conzx_Concept.GroupTextId);
//检查外键字段长度
 objzx_ConceptEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--zx_Concept(中学概念表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objzx_ConceptEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clszx_ConceptEN objzx_ConceptEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objzx_ConceptEN.TextId == null)
{
 sbCondition.AppendFormat(" and TextId is null");
}
else
{
 sbCondition.AppendFormat(" and TextId = '{0}'", objzx_ConceptEN.TextId);
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ConceptEN._CurrTabName);
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clszx_ConceptEN._CurrTabName, strCondition);
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
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
 objSQL = clszx_ConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}