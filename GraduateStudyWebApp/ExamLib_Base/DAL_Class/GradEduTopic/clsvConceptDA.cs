
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvConceptDA
 表名:vConcept(01120619)
 * 版本:2023.10.02.1(服务器:WIN-SRV103-116)
 日期:2023/10/08 16:37:26
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 概念视图(vConcept)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvConceptDA : clsCommBase4DA
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
 return clsvConceptEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvConceptEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvConceptEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvConceptEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvConceptEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strConceptId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strConceptId)
{
strConceptId = strConceptId.Replace("'", "''");
if (strConceptId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vConcept中,检查关键字,长度不正确!(clsvConceptDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strConceptId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vConcept中,关键字不能为空 或 null!(clsvConceptDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvConceptDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vConcept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable_vConcept)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vConcept where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vConcept.* from vConcept Left Join {1} on {2} where {3} and vConcept.ConceptId not in (Select top {5} vConcept.ConceptId from vConcept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1} and ConceptId not in (Select top {2} ConceptId from vConcept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1} and ConceptId not in (Select top {3} ConceptId from vConcept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vConcept.* from vConcept Left Join {1} on {2} where {3} and vConcept.ConceptId not in (Select top {5} vConcept.ConceptId from vConcept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1} and ConceptId not in (Select top {2} ConceptId from vConcept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vConcept where {1} and ConceptId not in (Select top {3} ConceptId from vConcept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvConceptEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvConceptDA:GetObjLst)", objException.Message));
}
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = TransNullToBool(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvConceptDA: GetObjLst)", objException.Message));
}
objvConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvConceptEN);
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
public List<clsvConceptEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvConceptDA:GetObjLstByTabName)", objException.Message));
}
List<clsvConceptEN> arrObjLst = new List<clsvConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = TransNullToBool(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvConceptDA: GetObjLst)", objException.Message));
}
objvConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvConceptEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvConceptEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvConcept(ref clsvConceptEN objvConceptEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where ConceptId = " + "'"+ objvConceptEN.ConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvConceptEN.ConceptContent = objDT.Rows[0][convConcept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvConceptEN.ConceptName = objDT.Rows[0][convConcept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvConceptEN.IsSubmit = TransNullToBool(objDT.Rows[0][convConcept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvConceptEN.ConceptId = objDT.Rows[0][convConcept.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvConceptEN.UpdDate = objDT.Rows[0][convConcept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.Memo = objDT.Rows[0][convConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvConceptEN.Author = objDT.Rows[0][convConcept.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvConceptEN.CitationId = objDT.Rows[0][convConcept.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvConceptEN.Keyword = objDT.Rows[0][convConcept.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvConceptEN.PaperTitle = objDT.Rows[0][convConcept.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvConceptEN.Periodical = objDT.Rows[0][convConcept.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvConceptEN.ResearchQuestion = objDT.Rows[0][convConcept.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvConceptEN.CitationCount = TransNullToInt(objDT.Rows[0][convConcept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convConcept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.Score = TransNullToFloat(objDT.Rows[0][convConcept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.StuScore = TransNullToFloat(objDT.Rows[0][convConcept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.TeaScore = TransNullToFloat(objDT.Rows[0][convConcept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.IdCurrEduCls = objDT.Rows[0][convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvConceptEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convConcept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.OkCount = TransNullToInt(objDT.Rows[0][convConcept.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.VersionCount = TransNullToInt(objDT.Rows[0][convConcept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.CreateDate = objDT.Rows[0][convConcept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.ShareId = objDT.Rows[0][convConcept.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvConceptEN.UpdUser = objDT.Rows[0][convConcept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.PdfContent = objDT.Rows[0][convConcept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvConceptDA: GetvConcept)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public clsvConceptEN GetObjByConceptId(string strConceptId)
{
CheckPrimaryKey(strConceptId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where ConceptId = " + "'"+ strConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
 objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊(字段类型:varchar,字段长度:100,是否可空:True)
 objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvConceptDA: GetObjByConceptId)", objException.Message));
}
return objvConceptEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvConceptEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvConceptDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
strSQL = "Select * from vConcept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvConceptEN objvConceptEN = new clsvConceptEN()
{
ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(), //概念内容
ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(), //概念名称
IsSubmit = TransNullToBool(objRow[convConcept.IsSubmit].ToString().Trim()), //是否提交
ConceptId = objRow[convConcept.ConceptId].ToString().Trim(), //概念Id
UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(), //备注
Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(), //作者
CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(), //引用Id
Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(), //关键字
PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(), //论文标题
Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(), //期刊
ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(), //研究问题
CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.CitationCount].ToString().Trim()), //引用统计
AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.Score].ToString().Trim()), //评分
StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.PdfPageNum].ToString().Trim()), //Pdf页码
OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convConcept.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(), //修改人
PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim() //Pdf内容
};
objvConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConceptEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvConceptDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvConceptEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = TransNullToBool(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvConceptDA: GetObjByDataRowvConcept)", objException.Message));
}
objvConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConceptEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvConceptEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvConceptEN objvConceptEN = new clsvConceptEN();
try
{
objvConceptEN.ConceptContent = objRow[convConcept.ConceptContent] == DBNull.Value ? null : objRow[convConcept.ConceptContent].ToString().Trim(); //概念内容
objvConceptEN.ConceptName = objRow[convConcept.ConceptName] == DBNull.Value ? null : objRow[convConcept.ConceptName].ToString().Trim(); //概念名称
objvConceptEN.IsSubmit = TransNullToBool(objRow[convConcept.IsSubmit].ToString().Trim()); //是否提交
objvConceptEN.ConceptId = objRow[convConcept.ConceptId].ToString().Trim(); //概念Id
objvConceptEN.UpdDate = objRow[convConcept.UpdDate] == DBNull.Value ? null : objRow[convConcept.UpdDate].ToString().Trim(); //修改日期
objvConceptEN.Memo = objRow[convConcept.Memo] == DBNull.Value ? null : objRow[convConcept.Memo].ToString().Trim(); //备注
objvConceptEN.Author = objRow[convConcept.Author] == DBNull.Value ? null : objRow[convConcept.Author].ToString().Trim(); //作者
objvConceptEN.CitationId = objRow[convConcept.CitationId] == DBNull.Value ? null : objRow[convConcept.CitationId].ToString().Trim(); //引用Id
objvConceptEN.Keyword = objRow[convConcept.Keyword] == DBNull.Value ? null : objRow[convConcept.Keyword].ToString().Trim(); //关键字
objvConceptEN.PaperTitle = objRow[convConcept.PaperTitle] == DBNull.Value ? null : objRow[convConcept.PaperTitle].ToString().Trim(); //论文标题
objvConceptEN.Periodical = objRow[convConcept.Periodical] == DBNull.Value ? null : objRow[convConcept.Periodical].ToString().Trim(); //期刊
objvConceptEN.ResearchQuestion = objRow[convConcept.ResearchQuestion] == DBNull.Value ? null : objRow[convConcept.ResearchQuestion].ToString().Trim(); //研究问题
objvConceptEN.CitationCount = objRow[convConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.CitationCount].ToString().Trim()); //引用统计
objvConceptEN.AppraiseCount = objRow[convConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.AppraiseCount].ToString().Trim()); //评论数
objvConceptEN.Score = objRow[convConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.Score].ToString().Trim()); //评分
objvConceptEN.StuScore = objRow[convConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.StuScore].ToString().Trim()); //学生平均分
objvConceptEN.TeaScore = objRow[convConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convConcept.TeaScore].ToString().Trim()); //教师评分
objvConceptEN.IdCurrEduCls = objRow[convConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[convConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvConceptEN.PdfPageNum = objRow[convConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objvConceptEN.OkCount = objRow[convConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.OkCount].ToString().Trim()); //点赞统计
objvConceptEN.VersionCount = objRow[convConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convConcept.VersionCount].ToString().Trim()); //版本统计
objvConceptEN.CreateDate = objRow[convConcept.CreateDate] == DBNull.Value ? null : objRow[convConcept.CreateDate].ToString().Trim(); //建立日期
objvConceptEN.ShareId = objRow[convConcept.ShareId].ToString().Trim(); //分享Id
objvConceptEN.UpdUser = objRow[convConcept.UpdUser] == DBNull.Value ? null : objRow[convConcept.UpdUser].ToString().Trim(); //修改人
objvConceptEN.PdfContent = objRow[convConcept.PdfContent] == DBNull.Value ? null : objRow[convConcept.PdfContent].ToString().Trim(); //Pdf内容
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvConceptDA: GetObjByDataRow)", objException.Message));
}
objvConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvConceptEN;
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
objSQL = clsvConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvConceptEN._CurrTabName, convConcept.ConceptId, 8, "");
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
objSQL = clsvConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvConceptEN._CurrTabName, convConcept.ConceptId, 8, strPrefix);
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ConceptId from vConcept where " + strCondition;
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ConceptId from vConcept where " + strCondition;
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
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strConceptId)
{
CheckPrimaryKey(strConceptId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vConcept", "ConceptId = " + "'"+ strConceptId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvConceptDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vConcept", strCondition))
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
objSQL = clsvConceptDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vConcept");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvConceptENS">源对象</param>
 /// <param name = "objvConceptENT">目标对象</param>
public void CopyTo(clsvConceptEN objvConceptENS, clsvConceptEN objvConceptENT)
{
objvConceptENT.ConceptContent = objvConceptENS.ConceptContent; //概念内容
objvConceptENT.ConceptName = objvConceptENS.ConceptName; //概念名称
objvConceptENT.IsSubmit = objvConceptENS.IsSubmit; //是否提交
objvConceptENT.ConceptId = objvConceptENS.ConceptId; //概念Id
objvConceptENT.UpdDate = objvConceptENS.UpdDate; //修改日期
objvConceptENT.Memo = objvConceptENS.Memo; //备注
objvConceptENT.Author = objvConceptENS.Author; //作者
objvConceptENT.CitationId = objvConceptENS.CitationId; //引用Id
objvConceptENT.Keyword = objvConceptENS.Keyword; //关键字
objvConceptENT.PaperTitle = objvConceptENS.PaperTitle; //论文标题
objvConceptENT.Periodical = objvConceptENS.Periodical; //期刊
objvConceptENT.ResearchQuestion = objvConceptENS.ResearchQuestion; //研究问题
objvConceptENT.CitationCount = objvConceptENS.CitationCount; //引用统计
objvConceptENT.AppraiseCount = objvConceptENS.AppraiseCount; //评论数
objvConceptENT.Score = objvConceptENS.Score; //评分
objvConceptENT.StuScore = objvConceptENS.StuScore; //学生平均分
objvConceptENT.TeaScore = objvConceptENS.TeaScore; //教师评分
objvConceptENT.IdCurrEduCls = objvConceptENS.IdCurrEduCls; //教学班流水号
objvConceptENT.PdfPageNum = objvConceptENS.PdfPageNum; //Pdf页码
objvConceptENT.OkCount = objvConceptENS.OkCount; //点赞统计
objvConceptENT.VersionCount = objvConceptENS.VersionCount; //版本统计
objvConceptENT.CreateDate = objvConceptENS.CreateDate; //建立日期
objvConceptENT.ShareId = objvConceptENS.ShareId; //分享Id
objvConceptENT.UpdUser = objvConceptENS.UpdUser; //修改人
objvConceptENT.PdfContent = objvConceptENS.PdfContent; //Pdf内容
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvConceptEN objvConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvConceptEN.ConceptName, 500, convConcept.ConceptName);
clsCheckSql.CheckFieldLen(objvConceptEN.ConceptId, 8, convConcept.ConceptId);
clsCheckSql.CheckFieldLen(objvConceptEN.UpdDate, 20, convConcept.UpdDate);
clsCheckSql.CheckFieldLen(objvConceptEN.Memo, 1000, convConcept.Memo);
clsCheckSql.CheckFieldLen(objvConceptEN.Author, 200, convConcept.Author);
clsCheckSql.CheckFieldLen(objvConceptEN.CitationId, 8, convConcept.CitationId);
clsCheckSql.CheckFieldLen(objvConceptEN.Keyword, 1000, convConcept.Keyword);
clsCheckSql.CheckFieldLen(objvConceptEN.PaperTitle, 500, convConcept.PaperTitle);
clsCheckSql.CheckFieldLen(objvConceptEN.Periodical, 100, convConcept.Periodical);
clsCheckSql.CheckFieldLen(objvConceptEN.ResearchQuestion, 2000, convConcept.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvConceptEN.IdCurrEduCls, 8, convConcept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvConceptEN.CreateDate, 20, convConcept.CreateDate);
clsCheckSql.CheckFieldLen(objvConceptEN.ShareId, 2, convConcept.ShareId);
clsCheckSql.CheckFieldLen(objvConceptEN.UpdUser, 20, convConcept.UpdUser);
clsCheckSql.CheckFieldLen(objvConceptEN.PdfContent, 2000, convConcept.PdfContent);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.ConceptName, convConcept.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.ConceptId, convConcept.ConceptId);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.UpdDate, convConcept.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.Memo, convConcept.Memo);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.Author, convConcept.Author);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.CitationId, convConcept.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.Keyword, convConcept.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.PaperTitle, convConcept.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.Periodical, convConcept.Periodical);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.ResearchQuestion, convConcept.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.IdCurrEduCls, convConcept.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.CreateDate, convConcept.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.ShareId, convConcept.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.UpdUser, convConcept.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvConceptEN.PdfContent, convConcept.PdfContent);
//检查外键字段长度
 objvConceptEN._IsCheckProperty = true;
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvConceptEN._CurrTabName);
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvConceptEN._CurrTabName, strCondition);
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
 objSQL = clsvConceptDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}