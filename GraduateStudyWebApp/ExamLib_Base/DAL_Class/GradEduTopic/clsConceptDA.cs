
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsConceptDA
 表名:Concept(01120602)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:07:15
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培主题(GradEduTopic)
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
 /// 观点概念(Concept)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsConceptDA : clsCommBase4DA
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
 return clsConceptEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsConceptEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsConceptEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsConceptEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsConceptEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:Concept中,检查关键字,长度不正确!(clsConceptDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strConceptId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Concept中,关键字不能为空 或 null!(clsConceptDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsConceptDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Concept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable_Concept)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Concept where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Concept.* from Concept Left Join {1} on {2} where {3} and Concept.ConceptId not in (Select top {5} Concept.ConceptId from Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1} and ConceptId not in (Select top {2} ConceptId from Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1} and ConceptId not in (Select top {3} ConceptId from Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Concept.* from Concept Left Join {1} on {2} where {3} and Concept.ConceptId not in (Select top {5} Concept.ConceptId from Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1} and ConceptId not in (Select top {2} ConceptId from Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Concept where {1} and ConceptId not in (Select top {3} ConceptId from Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsConceptEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsConceptDA:GetObjLst)", objException.Message));
}
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = TransNullToBool(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsConceptDA: GetObjLst)", objException.Message));
}
objConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objConceptEN);
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
public List<clsConceptEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsConceptDA:GetObjLstByTabName)", objException.Message));
}
List<clsConceptEN> arrObjLst = new List<clsConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = TransNullToBool(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsConceptDA: GetObjLst)", objException.Message));
}
objConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objConceptEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objConceptEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetConcept(ref clsConceptEN objConceptEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where ConceptId = " + "'"+ objConceptEN.ConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objConceptEN.ConceptId = objDT.Rows[0][conConcept.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objConceptEN.ConceptName = objDT.Rows[0][conConcept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objConceptEN.ConceptContent = objDT.Rows[0][conConcept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objConceptEN.IsSubmit = TransNullToBool(objDT.Rows[0][conConcept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objConceptEN.UpdDate = objDT.Rows[0][conConcept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConceptEN.Memo = objDT.Rows[0][conConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objConceptEN.CitationId = objDT.Rows[0][conConcept.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objConceptEN.AppraiseCount = TransNullToInt(objDT.Rows[0][conConcept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.OkCount = TransNullToInt(objDT.Rows[0][conConcept.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.Score = TransNullToFloat(objDT.Rows[0][conConcept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.StuScore = TransNullToFloat(objDT.Rows[0][conConcept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.TeaScore = TransNullToFloat(objDT.Rows[0][conConcept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.IdCurrEduCls = objDT.Rows[0][conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objConceptEN.PdfContent = objDT.Rows[0][conConcept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objConceptEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conConcept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.CitationCount = TransNullToInt(objDT.Rows[0][conConcept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.VersionCount = TransNullToInt(objDT.Rows[0][conConcept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.CreateDate = objDT.Rows[0][conConcept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConceptEN.ShareId = objDT.Rows[0][conConcept.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objConceptEN.UpdUser = objDT.Rows[0][conConcept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsConceptDA: GetConcept)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strConceptId">表关键字</param>
 /// <returns>表对象</returns>
public clsConceptEN GetObjByConceptId(string strConceptId)
{
CheckPrimaryKey(strConceptId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where ConceptId = " + "'"+ strConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsConceptEN objConceptEN = new clsConceptEN();
try
{
 objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsConceptDA: GetObjByConceptId)", objException.Message));
}
return objConceptEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsConceptEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsConceptDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsConceptEN objConceptEN = new clsConceptEN()
{
ConceptId = objRow[conConcept.ConceptId].ToString().Trim(), //概念Id
ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(), //概念名称
ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(), //概念内容
IsSubmit = TransNullToBool(objRow[conConcept.IsSubmit].ToString().Trim()), //是否提交
UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(), //备注
CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(), //引用Id
AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.OkCount].ToString().Trim()), //点赞统计
Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.Score].ToString().Trim()), //评分
StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[conConcept.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim() //修改人
};
objConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConceptEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsConceptDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsConceptEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = TransNullToBool(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsConceptDA: GetObjByDataRowConcept)", objException.Message));
}
objConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConceptEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsConceptEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsConceptEN objConceptEN = new clsConceptEN();
try
{
objConceptEN.ConceptId = objRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objConceptEN.ConceptName = objRow[conConcept.ConceptName] == DBNull.Value ? null : objRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objConceptEN.ConceptContent = objRow[conConcept.ConceptContent] == DBNull.Value ? null : objRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objConceptEN.IsSubmit = TransNullToBool(objRow[conConcept.IsSubmit].ToString().Trim()); //是否提交
objConceptEN.UpdDate = objRow[conConcept.UpdDate] == DBNull.Value ? null : objRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objConceptEN.Memo = objRow[conConcept.Memo] == DBNull.Value ? null : objRow[conConcept.Memo].ToString().Trim(); //备注
objConceptEN.CitationId = objRow[conConcept.CitationId] == DBNull.Value ? null : objRow[conConcept.CitationId].ToString().Trim(); //引用Id
objConceptEN.AppraiseCount = objRow[conConcept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.AppraiseCount].ToString().Trim()); //评论数
objConceptEN.OkCount = objRow[conConcept.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.OkCount].ToString().Trim()); //点赞统计
objConceptEN.Score = objRow[conConcept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.Score].ToString().Trim()); //评分
objConceptEN.StuScore = objRow[conConcept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.StuScore].ToString().Trim()); //学生平均分
objConceptEN.TeaScore = objRow[conConcept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[conConcept.TeaScore].ToString().Trim()); //教师评分
objConceptEN.IdCurrEduCls = objRow[conConcept.IdCurrEduCls] == DBNull.Value ? null : objRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objConceptEN.PdfContent = objRow[conConcept.PdfContent] == DBNull.Value ? null : objRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objConceptEN.PdfPageNum = objRow[conConcept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.PdfPageNum].ToString().Trim()); //Pdf页码
objConceptEN.CitationCount = objRow[conConcept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.CitationCount].ToString().Trim()); //引用统计
objConceptEN.VersionCount = objRow[conConcept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conConcept.VersionCount].ToString().Trim()); //版本统计
objConceptEN.CreateDate = objRow[conConcept.CreateDate] == DBNull.Value ? null : objRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objConceptEN.ShareId = objRow[conConcept.ShareId].ToString().Trim(); //分享Id
objConceptEN.UpdUser = objRow[conConcept.UpdUser] == DBNull.Value ? null : objRow[conConcept.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsConceptDA: GetObjByDataRow)", objException.Message));
}
objConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objConceptEN;
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
objSQL = clsConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsConceptEN._CurrTabName, conConcept.ConceptId, 8, "");
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
objSQL = clsConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsConceptEN._CurrTabName, conConcept.ConceptId, 8, strPrefix);
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
 objSQL = clsConceptDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ConceptId from Concept where " + strCondition;
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
 objSQL = clsConceptDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ConceptId from Concept where " + strCondition;
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
 objSQL = clsConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Concept", "ConceptId = " + "'"+ strConceptId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsConceptDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Concept", strCondition))
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
objSQL = clsConceptDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Concept");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsConceptEN objConceptEN)
 {
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConceptEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Concept");
objRow = objDS.Tables["Concept"].NewRow();
objRow[conConcept.ConceptId] = objConceptEN.ConceptId; //概念Id
 if (objConceptEN.ConceptName !=  "")
 {
objRow[conConcept.ConceptName] = objConceptEN.ConceptName; //概念名称
 }
 if (objConceptEN.ConceptContent !=  "")
 {
objRow[conConcept.ConceptContent] = objConceptEN.ConceptContent; //概念内容
 }
objRow[conConcept.IsSubmit] = objConceptEN.IsSubmit; //是否提交
 if (objConceptEN.UpdDate !=  "")
 {
objRow[conConcept.UpdDate] = objConceptEN.UpdDate; //修改日期
 }
 if (objConceptEN.Memo !=  "")
 {
objRow[conConcept.Memo] = objConceptEN.Memo; //备注
 }
 if (objConceptEN.CitationId !=  "")
 {
objRow[conConcept.CitationId] = objConceptEN.CitationId; //引用Id
 }
objRow[conConcept.AppraiseCount] = objConceptEN.AppraiseCount; //评论数
objRow[conConcept.OkCount] = objConceptEN.OkCount; //点赞统计
objRow[conConcept.Score] = objConceptEN.Score; //评分
objRow[conConcept.StuScore] = objConceptEN.StuScore; //学生平均分
objRow[conConcept.TeaScore] = objConceptEN.TeaScore; //教师评分
 if (objConceptEN.IdCurrEduCls !=  "")
 {
objRow[conConcept.IdCurrEduCls] = objConceptEN.IdCurrEduCls; //教学班流水号
 }
 if (objConceptEN.PdfContent !=  "")
 {
objRow[conConcept.PdfContent] = objConceptEN.PdfContent; //Pdf内容
 }
objRow[conConcept.PdfPageNum] = objConceptEN.PdfPageNum; //Pdf页码
objRow[conConcept.CitationCount] = objConceptEN.CitationCount; //引用统计
objRow[conConcept.VersionCount] = objConceptEN.VersionCount; //版本统计
 if (objConceptEN.CreateDate !=  "")
 {
objRow[conConcept.CreateDate] = objConceptEN.CreateDate; //建立日期
 }
objRow[conConcept.ShareId] = objConceptEN.ShareId; //分享Id
 if (objConceptEN.UpdUser !=  "")
 {
objRow[conConcept.UpdUser] = objConceptEN.UpdUser; //修改人
 }
objDS.Tables[clsConceptEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsConceptEN._CurrTabName);
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsConceptEN objConceptEN)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objConceptEN.ConceptId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptId);
 var strConceptId = objConceptEN.ConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptId + "'");
 }
 
 if (objConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptName);
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptContent);
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 arrFieldListForInsert.Add(conConcept.IsSubmit);
 arrValueListForInsert.Add("'" + (objConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdDate);
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Memo);
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objConceptEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationId);
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.AppraiseCount);
 arrValueListForInsert.Add(objConceptEN.AppraiseCount.ToString());
 }
 
 if (objConceptEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.OkCount);
 arrValueListForInsert.Add(objConceptEN.OkCount.ToString());
 }
 
 if (objConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Score);
 arrValueListForInsert.Add(objConceptEN.Score.ToString());
 }
 
 if (objConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.StuScore);
 arrValueListForInsert.Add(objConceptEN.StuScore.ToString());
 }
 
 if (objConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.TeaScore);
 arrValueListForInsert.Add(objConceptEN.TeaScore.ToString());
 }
 
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conConcept.IdCurrEduCls);
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfContent);
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfPageNum);
 arrValueListForInsert.Add(objConceptEN.PdfPageNum.ToString());
 }
 
 if (objConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationCount);
 arrValueListForInsert.Add(objConceptEN.CitationCount.ToString());
 }
 
 if (objConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.VersionCount);
 arrValueListForInsert.Add(objConceptEN.VersionCount.ToString());
 }
 
 if (objConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CreateDate);
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objConceptEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ShareId);
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdUser);
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Concept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsConceptEN objConceptEN)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objConceptEN.ConceptId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptId);
 var strConceptId = objConceptEN.ConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptId + "'");
 }
 
 if (objConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptName);
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptContent);
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 arrFieldListForInsert.Add(conConcept.IsSubmit);
 arrValueListForInsert.Add("'" + (objConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdDate);
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Memo);
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objConceptEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationId);
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.AppraiseCount);
 arrValueListForInsert.Add(objConceptEN.AppraiseCount.ToString());
 }
 
 if (objConceptEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.OkCount);
 arrValueListForInsert.Add(objConceptEN.OkCount.ToString());
 }
 
 if (objConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Score);
 arrValueListForInsert.Add(objConceptEN.Score.ToString());
 }
 
 if (objConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.StuScore);
 arrValueListForInsert.Add(objConceptEN.StuScore.ToString());
 }
 
 if (objConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.TeaScore);
 arrValueListForInsert.Add(objConceptEN.TeaScore.ToString());
 }
 
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conConcept.IdCurrEduCls);
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfContent);
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfPageNum);
 arrValueListForInsert.Add(objConceptEN.PdfPageNum.ToString());
 }
 
 if (objConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationCount);
 arrValueListForInsert.Add(objConceptEN.CitationCount.ToString());
 }
 
 if (objConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.VersionCount);
 arrValueListForInsert.Add(objConceptEN.VersionCount.ToString());
 }
 
 if (objConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CreateDate);
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objConceptEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ShareId);
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdUser);
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Concept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objConceptEN.ConceptId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsConceptEN objConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConceptEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objConceptEN.ConceptId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptId);
 var strConceptId = objConceptEN.ConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptId + "'");
 }
 
 if (objConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptName);
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptContent);
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 arrFieldListForInsert.Add(conConcept.IsSubmit);
 arrValueListForInsert.Add("'" + (objConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdDate);
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Memo);
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objConceptEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationId);
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.AppraiseCount);
 arrValueListForInsert.Add(objConceptEN.AppraiseCount.ToString());
 }
 
 if (objConceptEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.OkCount);
 arrValueListForInsert.Add(objConceptEN.OkCount.ToString());
 }
 
 if (objConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Score);
 arrValueListForInsert.Add(objConceptEN.Score.ToString());
 }
 
 if (objConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.StuScore);
 arrValueListForInsert.Add(objConceptEN.StuScore.ToString());
 }
 
 if (objConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.TeaScore);
 arrValueListForInsert.Add(objConceptEN.TeaScore.ToString());
 }
 
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conConcept.IdCurrEduCls);
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfContent);
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfPageNum);
 arrValueListForInsert.Add(objConceptEN.PdfPageNum.ToString());
 }
 
 if (objConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationCount);
 arrValueListForInsert.Add(objConceptEN.CitationCount.ToString());
 }
 
 if (objConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.VersionCount);
 arrValueListForInsert.Add(objConceptEN.VersionCount.ToString());
 }
 
 if (objConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CreateDate);
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objConceptEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ShareId);
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdUser);
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Concept");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objConceptEN.ConceptId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsConceptEN objConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objConceptEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objConceptEN.ConceptId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptId);
 var strConceptId = objConceptEN.ConceptId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptId + "'");
 }
 
 if (objConceptEN.ConceptName !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptName);
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptName + "'");
 }
 
 if (objConceptEN.ConceptContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ConceptContent);
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConceptContent + "'");
 }
 
 arrFieldListForInsert.Add(conConcept.IsSubmit);
 arrValueListForInsert.Add("'" + (objConceptEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objConceptEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdDate);
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objConceptEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Memo);
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objConceptEN.CitationId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationId);
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCitationId + "'");
 }
 
 if (objConceptEN.AppraiseCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.AppraiseCount);
 arrValueListForInsert.Add(objConceptEN.AppraiseCount.ToString());
 }
 
 if (objConceptEN.OkCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.OkCount);
 arrValueListForInsert.Add(objConceptEN.OkCount.ToString());
 }
 
 if (objConceptEN.Score !=  null)
 {
 arrFieldListForInsert.Add(conConcept.Score);
 arrValueListForInsert.Add(objConceptEN.Score.ToString());
 }
 
 if (objConceptEN.StuScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.StuScore);
 arrValueListForInsert.Add(objConceptEN.StuScore.ToString());
 }
 
 if (objConceptEN.TeaScore !=  null)
 {
 arrFieldListForInsert.Add(conConcept.TeaScore);
 arrValueListForInsert.Add(objConceptEN.TeaScore.ToString());
 }
 
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conConcept.IdCurrEduCls);
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objConceptEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfContent);
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objConceptEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conConcept.PdfPageNum);
 arrValueListForInsert.Add(objConceptEN.PdfPageNum.ToString());
 }
 
 if (objConceptEN.CitationCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CitationCount);
 arrValueListForInsert.Add(objConceptEN.CitationCount.ToString());
 }
 
 if (objConceptEN.VersionCount !=  null)
 {
 arrFieldListForInsert.Add(conConcept.VersionCount);
 arrValueListForInsert.Add(objConceptEN.VersionCount.ToString());
 }
 
 if (objConceptEN.CreateDate !=  null)
 {
 arrFieldListForInsert.Add(conConcept.CreateDate);
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreateDate + "'");
 }
 
 if (objConceptEN.ShareId !=  null)
 {
 arrFieldListForInsert.Add(conConcept.ShareId);
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strShareId + "'");
 }
 
 if (objConceptEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conConcept.UpdUser);
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Concept");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewConcepts(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where ConceptId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Concept");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strConceptId = oRow[conConcept.ConceptId].ToString().Trim();
if (IsExist(strConceptId))
{
 string strResult = "关键字变量值为:" + string.Format("ConceptId = {0}", strConceptId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsConceptEN._CurrTabName ].NewRow();
objRow[conConcept.ConceptId] = oRow[conConcept.ConceptId].ToString().Trim(); //概念Id
objRow[conConcept.ConceptName] = oRow[conConcept.ConceptName].ToString().Trim(); //概念名称
objRow[conConcept.ConceptContent] = oRow[conConcept.ConceptContent].ToString().Trim(); //概念内容
objRow[conConcept.IsSubmit] = oRow[conConcept.IsSubmit].ToString().Trim(); //是否提交
objRow[conConcept.UpdDate] = oRow[conConcept.UpdDate].ToString().Trim(); //修改日期
objRow[conConcept.Memo] = oRow[conConcept.Memo].ToString().Trim(); //备注
objRow[conConcept.CitationId] = oRow[conConcept.CitationId].ToString().Trim(); //引用Id
objRow[conConcept.AppraiseCount] = oRow[conConcept.AppraiseCount].ToString().Trim(); //评论数
objRow[conConcept.OkCount] = oRow[conConcept.OkCount].ToString().Trim(); //点赞统计
objRow[conConcept.Score] = oRow[conConcept.Score].ToString().Trim(); //评分
objRow[conConcept.StuScore] = oRow[conConcept.StuScore].ToString().Trim(); //学生平均分
objRow[conConcept.TeaScore] = oRow[conConcept.TeaScore].ToString().Trim(); //教师评分
objRow[conConcept.IdCurrEduCls] = oRow[conConcept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conConcept.PdfContent] = oRow[conConcept.PdfContent].ToString().Trim(); //Pdf内容
objRow[conConcept.PdfPageNum] = oRow[conConcept.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conConcept.CitationCount] = oRow[conConcept.CitationCount].ToString().Trim(); //引用统计
objRow[conConcept.VersionCount] = oRow[conConcept.VersionCount].ToString().Trim(); //版本统计
objRow[conConcept.CreateDate] = oRow[conConcept.CreateDate].ToString().Trim(); //建立日期
objRow[conConcept.ShareId] = oRow[conConcept.ShareId].ToString().Trim(); //分享Id
objRow[conConcept.UpdUser] = oRow[conConcept.UpdUser].ToString().Trim(); //修改人
 objDS.Tables[clsConceptEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsConceptEN._CurrTabName);
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
 /// <param name = "objConceptEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsConceptEN objConceptEN)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConceptEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
strSQL = "Select * from Concept where ConceptId = " + "'"+ objConceptEN.ConceptId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsConceptEN._CurrTabName);
if (objDS.Tables[clsConceptEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ConceptId = " + "'"+ objConceptEN.ConceptId+"'");
return false;
}
objRow = objDS.Tables[clsConceptEN._CurrTabName].Rows[0];
 if (objConceptEN.IsUpdated(conConcept.ConceptId))
 {
objRow[conConcept.ConceptId] = objConceptEN.ConceptId; //概念Id
 }
 if (objConceptEN.IsUpdated(conConcept.ConceptName))
 {
objRow[conConcept.ConceptName] = objConceptEN.ConceptName; //概念名称
 }
 if (objConceptEN.IsUpdated(conConcept.ConceptContent))
 {
objRow[conConcept.ConceptContent] = objConceptEN.ConceptContent; //概念内容
 }
 if (objConceptEN.IsUpdated(conConcept.IsSubmit))
 {
objRow[conConcept.IsSubmit] = objConceptEN.IsSubmit; //是否提交
 }
 if (objConceptEN.IsUpdated(conConcept.UpdDate))
 {
objRow[conConcept.UpdDate] = objConceptEN.UpdDate; //修改日期
 }
 if (objConceptEN.IsUpdated(conConcept.Memo))
 {
objRow[conConcept.Memo] = objConceptEN.Memo; //备注
 }
 if (objConceptEN.IsUpdated(conConcept.CitationId))
 {
objRow[conConcept.CitationId] = objConceptEN.CitationId; //引用Id
 }
 if (objConceptEN.IsUpdated(conConcept.AppraiseCount))
 {
objRow[conConcept.AppraiseCount] = objConceptEN.AppraiseCount; //评论数
 }
 if (objConceptEN.IsUpdated(conConcept.OkCount))
 {
objRow[conConcept.OkCount] = objConceptEN.OkCount; //点赞统计
 }
 if (objConceptEN.IsUpdated(conConcept.Score))
 {
objRow[conConcept.Score] = objConceptEN.Score; //评分
 }
 if (objConceptEN.IsUpdated(conConcept.StuScore))
 {
objRow[conConcept.StuScore] = objConceptEN.StuScore; //学生平均分
 }
 if (objConceptEN.IsUpdated(conConcept.TeaScore))
 {
objRow[conConcept.TeaScore] = objConceptEN.TeaScore; //教师评分
 }
 if (objConceptEN.IsUpdated(conConcept.IdCurrEduCls))
 {
objRow[conConcept.IdCurrEduCls] = objConceptEN.IdCurrEduCls; //教学班流水号
 }
 if (objConceptEN.IsUpdated(conConcept.PdfContent))
 {
objRow[conConcept.PdfContent] = objConceptEN.PdfContent; //Pdf内容
 }
 if (objConceptEN.IsUpdated(conConcept.PdfPageNum))
 {
objRow[conConcept.PdfPageNum] = objConceptEN.PdfPageNum; //Pdf页码
 }
 if (objConceptEN.IsUpdated(conConcept.CitationCount))
 {
objRow[conConcept.CitationCount] = objConceptEN.CitationCount; //引用统计
 }
 if (objConceptEN.IsUpdated(conConcept.VersionCount))
 {
objRow[conConcept.VersionCount] = objConceptEN.VersionCount; //版本统计
 }
 if (objConceptEN.IsUpdated(conConcept.CreateDate))
 {
objRow[conConcept.CreateDate] = objConceptEN.CreateDate; //建立日期
 }
 if (objConceptEN.IsUpdated(conConcept.ShareId))
 {
objRow[conConcept.ShareId] = objConceptEN.ShareId; //分享Id
 }
 if (objConceptEN.IsUpdated(conConcept.UpdUser))
 {
objRow[conConcept.UpdUser] = objConceptEN.UpdUser; //修改人
 }
try
{
objDA.Update(objDS, clsConceptEN._CurrTabName);
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsConceptEN objConceptEN)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Concept Set ");
 
 if (objConceptEN.IsUpdated(conConcept.ConceptName))
 {
 if (objConceptEN.ConceptName !=  null)
 {
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conConcept.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ConceptName); //概念名称
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ConceptContent))
 {
 if (objConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conConcept.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ConceptContent); //概念内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objConceptEN.IsSubmit == true?"1":"0", conConcept.IsSubmit); //是否提交
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdDate))
 {
 if (objConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conConcept.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.UpdDate); //修改日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Memo))
 {
 if (objConceptEN.Memo !=  null)
 {
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conConcept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Memo); //备注
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationId))
 {
 if (objConceptEN.CitationId !=  null)
 {
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conConcept.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationId); //引用Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.AppraiseCount))
 {
 if (objConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.AppraiseCount, conConcept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.AppraiseCount); //评论数
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.OkCount))
 {
 if (objConceptEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.OkCount, conConcept.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.OkCount); //点赞统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Score))
 {
 if (objConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.Score, conConcept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Score); //评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.StuScore))
 {
 if (objConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.StuScore, conConcept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.StuScore); //学生平均分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.TeaScore))
 {
 if (objConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.TeaScore, conConcept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.TeaScore); //教师评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IdCurrEduCls))
 {
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conConcept.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfContent))
 {
 if (objConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conConcept.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfContent); //Pdf内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfPageNum))
 {
 if (objConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.PdfPageNum, conConcept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationCount))
 {
 if (objConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.CitationCount, conConcept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationCount); //引用统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.VersionCount))
 {
 if (objConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.VersionCount, conConcept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.VersionCount); //版本统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CreateDate))
 {
 if (objConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conConcept.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CreateDate); //建立日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ShareId))
 {
 if (objConceptEN.ShareId !=  null)
 {
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conConcept.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ShareId); //分享Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdUser))
 {
 if (objConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conConcept.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.UpdUser); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConceptId = '{0}'", objConceptEN.ConceptId); 
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
 /// <param name = "objConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsConceptEN objConceptEN, string strCondition)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Concept Set ");
 
 if (objConceptEN.IsUpdated(conConcept.ConceptName))
 {
 if (objConceptEN.ConceptName !=  null)
 {
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ConceptContent))
 {
 if (objConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objConceptEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdDate))
 {
 if (objConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Memo))
 {
 if (objConceptEN.Memo !=  null)
 {
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationId))
 {
 if (objConceptEN.CitationId !=  null)
 {
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.AppraiseCount))
 {
 if (objConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.AppraiseCount, conConcept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.AppraiseCount); //评论数
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.OkCount))
 {
 if (objConceptEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.OkCount, conConcept.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.OkCount); //点赞统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Score))
 {
 if (objConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.Score, conConcept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Score); //评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.StuScore))
 {
 if (objConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.StuScore, conConcept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.StuScore); //学生平均分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.TeaScore))
 {
 if (objConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.TeaScore, conConcept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.TeaScore); //教师评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IdCurrEduCls))
 {
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfContent))
 {
 if (objConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfPageNum))
 {
 if (objConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.PdfPageNum, conConcept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationCount))
 {
 if (objConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.CitationCount, conConcept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationCount); //引用统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.VersionCount))
 {
 if (objConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.VersionCount, conConcept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.VersionCount); //版本统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CreateDate))
 {
 if (objConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ShareId))
 {
 if (objConceptEN.ShareId !=  null)
 {
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdUser))
 {
 if (objConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
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
 /// <param name = "objConceptEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsConceptEN objConceptEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Concept Set ");
 
 if (objConceptEN.IsUpdated(conConcept.ConceptName))
 {
 if (objConceptEN.ConceptName !=  null)
 {
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptName = '{0}',", strConceptName); //概念名称
 }
 else
 {
 sbSQL.Append(" ConceptName = null,"); //概念名称
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ConceptContent))
 {
 if (objConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConceptContent = '{0}',", strConceptContent); //概念内容
 }
 else
 {
 sbSQL.Append(" ConceptContent = null,"); //概念内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objConceptEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdDate))
 {
 if (objConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Memo))
 {
 if (objConceptEN.Memo !=  null)
 {
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //备注
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //备注
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationId))
 {
 if (objConceptEN.CitationId !=  null)
 {
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CitationId = '{0}',", strCitationId); //引用Id
 }
 else
 {
 sbSQL.Append(" CitationId = null,"); //引用Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.AppraiseCount))
 {
 if (objConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.AppraiseCount, conConcept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.AppraiseCount); //评论数
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.OkCount))
 {
 if (objConceptEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.OkCount, conConcept.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.OkCount); //点赞统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Score))
 {
 if (objConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.Score, conConcept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Score); //评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.StuScore))
 {
 if (objConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.StuScore, conConcept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.StuScore); //学生平均分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.TeaScore))
 {
 if (objConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.TeaScore, conConcept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.TeaScore); //教师评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IdCurrEduCls))
 {
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfContent))
 {
 if (objConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfPageNum))
 {
 if (objConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.PdfPageNum, conConcept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationCount))
 {
 if (objConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.CitationCount, conConcept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationCount); //引用统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.VersionCount))
 {
 if (objConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.VersionCount, conConcept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.VersionCount); //版本统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CreateDate))
 {
 if (objConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreateDate = '{0}',", strCreateDate); //建立日期
 }
 else
 {
 sbSQL.Append(" CreateDate = null,"); //建立日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ShareId))
 {
 if (objConceptEN.ShareId !=  null)
 {
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ShareId = '{0}',", strShareId); //分享Id
 }
 else
 {
 sbSQL.Append(" ShareId = null,"); //分享Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdUser))
 {
 if (objConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
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
 /// <param name = "objConceptEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsConceptEN objConceptEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objConceptEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objConceptEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Concept Set ");
 
 if (objConceptEN.IsUpdated(conConcept.ConceptName))
 {
 if (objConceptEN.ConceptName !=  null)
 {
 var strConceptName = objConceptEN.ConceptName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptName, conConcept.ConceptName); //概念名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ConceptName); //概念名称
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ConceptContent))
 {
 if (objConceptEN.ConceptContent !=  null)
 {
 var strConceptContent = objConceptEN.ConceptContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConceptContent, conConcept.ConceptContent); //概念内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ConceptContent); //概念内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objConceptEN.IsSubmit == true?"1":"0", conConcept.IsSubmit); //是否提交
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdDate))
 {
 if (objConceptEN.UpdDate !=  null)
 {
 var strUpdDate = objConceptEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conConcept.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.UpdDate); //修改日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Memo))
 {
 if (objConceptEN.Memo !=  null)
 {
 var strMemo = objConceptEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conConcept.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Memo); //备注
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationId))
 {
 if (objConceptEN.CitationId !=  null)
 {
 var strCitationId = objConceptEN.CitationId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCitationId, conConcept.CitationId); //引用Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationId); //引用Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.AppraiseCount))
 {
 if (objConceptEN.AppraiseCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.AppraiseCount, conConcept.AppraiseCount); //评论数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.AppraiseCount); //评论数
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.OkCount))
 {
 if (objConceptEN.OkCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.OkCount, conConcept.OkCount); //点赞统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.OkCount); //点赞统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.Score))
 {
 if (objConceptEN.Score !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.Score, conConcept.Score); //评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.Score); //评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.StuScore))
 {
 if (objConceptEN.StuScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.StuScore, conConcept.StuScore); //学生平均分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.StuScore); //学生平均分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.TeaScore))
 {
 if (objConceptEN.TeaScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.TeaScore, conConcept.TeaScore); //教师评分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.TeaScore); //教师评分
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.IdCurrEduCls))
 {
 if (objConceptEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objConceptEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conConcept.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfContent))
 {
 if (objConceptEN.PdfContent !=  null)
 {
 var strPdfContent = objConceptEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conConcept.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfContent); //Pdf内容
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.PdfPageNum))
 {
 if (objConceptEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.PdfPageNum, conConcept.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.PdfPageNum); //Pdf页码
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CitationCount))
 {
 if (objConceptEN.CitationCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.CitationCount, conConcept.CitationCount); //引用统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CitationCount); //引用统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.VersionCount))
 {
 if (objConceptEN.VersionCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objConceptEN.VersionCount, conConcept.VersionCount); //版本统计
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.VersionCount); //版本统计
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.CreateDate))
 {
 if (objConceptEN.CreateDate !=  null)
 {
 var strCreateDate = objConceptEN.CreateDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreateDate, conConcept.CreateDate); //建立日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.CreateDate); //建立日期
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.ShareId))
 {
 if (objConceptEN.ShareId !=  null)
 {
 var strShareId = objConceptEN.ShareId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strShareId, conConcept.ShareId); //分享Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.ShareId); //分享Id
 }
 }
 
 if (objConceptEN.IsUpdated(conConcept.UpdUser))
 {
 if (objConceptEN.UpdUser !=  null)
 {
 var strUpdUser = objConceptEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conConcept.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conConcept.UpdUser); //修改人
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ConceptId = '{0}'", objConceptEN.ConceptId); 
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
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strConceptId) 
{
CheckPrimaryKey(strConceptId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strConceptId,
};
 objSQL.ExecSP("Concept_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strConceptId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strConceptId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
//删除Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Concept where ConceptId = " + "'"+ strConceptId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelConcept(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
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
//删除Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Concept where ConceptId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strConceptId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strConceptId) 
{
CheckPrimaryKey(strConceptId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
//删除Concept本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Concept where ConceptId = " + "'"+ strConceptId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelConcept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsConceptDA: DelConcept)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Concept where " + strCondition ;
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
public bool DelConceptWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsConceptDA: DelConceptWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsConceptDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Concept where " + strCondition ;
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
 /// <param name = "objConceptENS">源对象</param>
 /// <param name = "objConceptENT">目标对象</param>
public void CopyTo(clsConceptEN objConceptENS, clsConceptEN objConceptENT)
{
objConceptENT.ConceptId = objConceptENS.ConceptId; //概念Id
objConceptENT.ConceptName = objConceptENS.ConceptName; //概念名称
objConceptENT.ConceptContent = objConceptENS.ConceptContent; //概念内容
objConceptENT.IsSubmit = objConceptENS.IsSubmit; //是否提交
objConceptENT.UpdDate = objConceptENS.UpdDate; //修改日期
objConceptENT.Memo = objConceptENS.Memo; //备注
objConceptENT.CitationId = objConceptENS.CitationId; //引用Id
objConceptENT.AppraiseCount = objConceptENS.AppraiseCount; //评论数
objConceptENT.OkCount = objConceptENS.OkCount; //点赞统计
objConceptENT.Score = objConceptENS.Score; //评分
objConceptENT.StuScore = objConceptENS.StuScore; //学生平均分
objConceptENT.TeaScore = objConceptENS.TeaScore; //教师评分
objConceptENT.IdCurrEduCls = objConceptENS.IdCurrEduCls; //教学班流水号
objConceptENT.PdfContent = objConceptENS.PdfContent; //Pdf内容
objConceptENT.PdfPageNum = objConceptENS.PdfPageNum; //Pdf页码
objConceptENT.CitationCount = objConceptENS.CitationCount; //引用统计
objConceptENT.VersionCount = objConceptENS.VersionCount; //版本统计
objConceptENT.CreateDate = objConceptENS.CreateDate; //建立日期
objConceptENT.ShareId = objConceptENS.ShareId; //分享Id
objConceptENT.UpdUser = objConceptENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsConceptEN objConceptEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objConceptEN.ShareId, conConcept.ShareId);
//检查字段长度
clsCheckSql.CheckFieldLen(objConceptEN.ConceptId, 8, conConcept.ConceptId);
clsCheckSql.CheckFieldLen(objConceptEN.ConceptName, 500, conConcept.ConceptName);
clsCheckSql.CheckFieldLen(objConceptEN.UpdDate, 20, conConcept.UpdDate);
clsCheckSql.CheckFieldLen(objConceptEN.Memo, 1000, conConcept.Memo);
clsCheckSql.CheckFieldLen(objConceptEN.CitationId, 8, conConcept.CitationId);
clsCheckSql.CheckFieldLen(objConceptEN.IdCurrEduCls, 8, conConcept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objConceptEN.PdfContent, 2000, conConcept.PdfContent);
clsCheckSql.CheckFieldLen(objConceptEN.CreateDate, 20, conConcept.CreateDate);
clsCheckSql.CheckFieldLen(objConceptEN.ShareId, 2, conConcept.ShareId);
clsCheckSql.CheckFieldLen(objConceptEN.UpdUser, 20, conConcept.UpdUser);
//检查字段外键固定长度
 objConceptEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsConceptEN objConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objConceptEN.ConceptName, 500, conConcept.ConceptName);
clsCheckSql.CheckFieldLen(objConceptEN.UpdDate, 20, conConcept.UpdDate);
clsCheckSql.CheckFieldLen(objConceptEN.Memo, 1000, conConcept.Memo);
clsCheckSql.CheckFieldLen(objConceptEN.CitationId, 8, conConcept.CitationId);
clsCheckSql.CheckFieldLen(objConceptEN.IdCurrEduCls, 8, conConcept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objConceptEN.PdfContent, 2000, conConcept.PdfContent);
clsCheckSql.CheckFieldLen(objConceptEN.CreateDate, 20, conConcept.CreateDate);
clsCheckSql.CheckFieldLen(objConceptEN.ShareId, 2, conConcept.ShareId);
clsCheckSql.CheckFieldLen(objConceptEN.UpdUser, 20, conConcept.UpdUser);
//检查外键字段长度
 objConceptEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsConceptEN objConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objConceptEN.ConceptId, 8, conConcept.ConceptId);
clsCheckSql.CheckFieldLen(objConceptEN.ConceptName, 500, conConcept.ConceptName);
clsCheckSql.CheckFieldLen(objConceptEN.UpdDate, 20, conConcept.UpdDate);
clsCheckSql.CheckFieldLen(objConceptEN.Memo, 1000, conConcept.Memo);
clsCheckSql.CheckFieldLen(objConceptEN.CitationId, 8, conConcept.CitationId);
clsCheckSql.CheckFieldLen(objConceptEN.IdCurrEduCls, 8, conConcept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objConceptEN.PdfContent, 2000, conConcept.PdfContent);
clsCheckSql.CheckFieldLen(objConceptEN.CreateDate, 20, conConcept.CreateDate);
clsCheckSql.CheckFieldLen(objConceptEN.ShareId, 2, conConcept.ShareId);
clsCheckSql.CheckFieldLen(objConceptEN.UpdUser, 20, conConcept.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objConceptEN.ConceptId, conConcept.ConceptId);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.ConceptName, conConcept.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.UpdDate, conConcept.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.Memo, conConcept.Memo);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.CitationId, conConcept.CitationId);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.IdCurrEduCls, conConcept.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.PdfContent, conConcept.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.CreateDate, conConcept.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.ShareId, conConcept.ShareId);
clsCheckSql.CheckSqlInjection4Field(objConceptEN.UpdUser, conConcept.UpdUser);
//检查外键字段长度
 objConceptEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetConceptId()
{
//获取某学院所有专业信息
string strSQL = "select ConceptId, ConceptName from Concept ";
 clsSpecSQLforSql mySql = clsConceptDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Concept(观点概念),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objConceptEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsConceptEN objConceptEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objConceptEN.IdCurrEduCls == null)
{
 sbCondition.AppendFormat(" and IdCurrEduCls is null");
}
else
{
 sbCondition.AppendFormat(" and IdCurrEduCls = '{0}'", objConceptEN.IdCurrEduCls);
}
 if (objConceptEN.ConceptName == null)
{
 sbCondition.AppendFormat(" and ConceptName is null");
}
else
{
 sbCondition.AppendFormat(" and ConceptName = '{0}'", objConceptEN.ConceptName);
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
 objSQL = clsConceptDA.GetSpecSQLObj();
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
 objSQL = clsConceptDA.GetSpecSQLObj();
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
 objSQL = clsConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsConceptEN._CurrTabName);
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
 objSQL = clsConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsConceptEN._CurrTabName, strCondition);
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
 objSQL = clsConceptDA.GetSpecSQLObj();
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
 objSQL = clsConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}