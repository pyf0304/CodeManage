
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvzx_ConceptDA
 表名:vzx_Concept(01120830)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 12:50:44
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
 /// vzx_Concept(vzx_Concept)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvzx_ConceptDA : clsCommBase4DA
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
 return clsvzx_ConceptEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvzx_ConceptEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvzx_ConceptEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvzx_ConceptEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvzx_ConceptEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vzx_Concept中,检查关键字,长度不正确!(clsvzx_ConceptDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strzxConceptId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vzx_Concept中,关键字不能为空 或 null!(clsvzx_ConceptDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strzxConceptId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvzx_ConceptDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vzx_Concept(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable_vzx_Concept)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Concept.* from vzx_Concept Left Join {1} on {2} where {3} and vzx_Concept.zxConceptId not in (Select top {5} vzx_Concept.zxConceptId from vzx_Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1} and zxConceptId not in (Select top {2} zxConceptId from vzx_Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1} and zxConceptId not in (Select top {3} zxConceptId from vzx_Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vzx_Concept.* from vzx_Concept Left Join {1} on {2} where {3} and vzx_Concept.zxConceptId not in (Select top {5} vzx_Concept.zxConceptId from vzx_Concept Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1} and zxConceptId not in (Select top {2} zxConceptId from vzx_Concept where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vzx_Concept where {1} and zxConceptId not in (Select top {3} zxConceptId from vzx_Concept where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvzx_ConceptEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvzx_ConceptDA:GetObjLst)", objException.Message));
}
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = TransNullToBool(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_ConceptDA: GetObjLst)", objException.Message));
}
objvzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_ConceptEN);
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
public List<clsvzx_ConceptEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvzx_ConceptDA:GetObjLstByTabName)", objException.Message));
}
List<clsvzx_ConceptEN> arrObjLst = new List<clsvzx_ConceptEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = TransNullToBool(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvzx_ConceptDA: GetObjLst)", objException.Message));
}
objvzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvzx_ConceptEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvzx_ConceptEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvzx_Concept(ref clsvzx_ConceptEN objvzx_ConceptEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where zxConceptId = " + "'"+ objvzx_ConceptEN.zxConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvzx_ConceptEN.zxConceptId = objDT.Rows[0][convzx_Concept.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.ConceptName = objDT.Rows[0][convzx_Concept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ConceptEN.ConceptContent = objDT.Rows[0][convzx_Concept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ConceptEN.TextId = objDT.Rows[0][convzx_Concept.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.VoteCount = TransNullToInt(objDT.Rows[0][convzx_Concept.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.IsSubmit = TransNullToBool(objDT.Rows[0][convzx_Concept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_ConceptEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convzx_Concept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.Score = TransNullToFloat(objDT.Rows[0][convzx_Concept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.StuScore = TransNullToFloat(objDT.Rows[0][convzx_Concept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.TeaScore = TransNullToFloat(objDT.Rows[0][convzx_Concept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.CreateDate = objDT.Rows[0][convzx_Concept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.UpdDate = objDT.Rows[0][convzx_Concept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.UpdUser = objDT.Rows[0][convzx_Concept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.IdCurrEduCls = objDT.Rows[0][convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.PdfContent = objDT.Rows[0][convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ConceptEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.CitationCount = TransNullToInt(objDT.Rows[0][convzx_Concept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.VersionCount = TransNullToInt(objDT.Rows[0][convzx_Concept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.zxShareId = objDT.Rows[0][convzx_Concept.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_ConceptEN.Memo = objDT.Rows[0][convzx_Concept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ConceptEN.PdfDivLet = objDT.Rows[0][convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfDivTop = objDT.Rows[0][convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfPageNumIn = objDT.Rows[0][convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfPageTop = TransNullToInt(objDT.Rows[0][convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.PdfZoom = objDT.Rows[0][convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.GroupTextId = objDT.Rows[0][convzx_Concept.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.TextTitle = objDT.Rows[0][convzx_Concept.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_ConceptEN.Author = objDT.Rows[0][convzx_Concept.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_ConceptEN.ResearchQuestion = objDT.Rows[0][convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ConceptEN.Keyword = objDT.Rows[0][convzx_Concept.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ConceptEN.Edition = objDT.Rows[0][convzx_Concept.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvzx_ConceptDA: Getvzx_Concept)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strzxConceptId">表关键字</param>
 /// <returns>表对象</returns>
public clsvzx_ConceptEN GetObjByzxConceptId(string strzxConceptId)
{
CheckPrimaryKey(strzxConceptId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where zxConceptId = " + "'"+ strzxConceptId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
 objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置(字段类型:int,字段长度:4,是否可空:True)
 objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom(字段类型:varchar,字段长度:50,是否可空:True)
 objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id(字段类型:char,字段长度:8,是否可空:False)
 objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle(字段类型:varchar,字段长度:500,是否可空:False)
 objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题(字段类型:varchar,字段长度:2000,是否可空:True)
 objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvzx_ConceptDA: GetObjByzxConceptId)", objException.Message));
}
return objvzx_ConceptEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvzx_ConceptEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvzx_ConceptDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
strSQL = "Select * from vzx_Concept where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN()
{
zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(), //概念Id
ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(), //概念名称
ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(), //概念内容
TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(), //课件Id
VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VoteCount].ToString().Trim()), //点赞计数
IsSubmit = TransNullToBool(objRow[convzx_Concept.IsSubmit].ToString().Trim()), //是否提交
AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.Score].ToString().Trim()), //评分
StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(), //建立日期
UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(), //修改人
IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageNum].ToString().Trim()), //Pdf页码
CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.CitationCount].ToString().Trim()), //引用统计
VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VersionCount].ToString().Trim()), //版本统计
zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(), //分享Id
Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(), //备注
PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(), //PdfDivLet
PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(), //PdfDivTop
PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(), //PdfPageNumIn
PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageTop].ToString().Trim()), //pdf页面顶部位置
PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(), //PdfZoom
GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(), //小组Id
TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(), //TextTitle
Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(), //作者
ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(), //研究问题
Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(), //关键字
Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim() //Edition
};
objvzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ConceptEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvzx_ConceptDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvzx_ConceptEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = TransNullToBool(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvzx_ConceptDA: GetObjByDataRowvzx_Concept)", objException.Message));
}
objvzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ConceptEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvzx_ConceptEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvzx_ConceptEN objvzx_ConceptEN = new clsvzx_ConceptEN();
try
{
objvzx_ConceptEN.zxConceptId = objRow[convzx_Concept.zxConceptId].ToString().Trim(); //概念Id
objvzx_ConceptEN.ConceptName = objRow[convzx_Concept.ConceptName] == DBNull.Value ? null : objRow[convzx_Concept.ConceptName].ToString().Trim(); //概念名称
objvzx_ConceptEN.ConceptContent = objRow[convzx_Concept.ConceptContent] == DBNull.Value ? null : objRow[convzx_Concept.ConceptContent].ToString().Trim(); //概念内容
objvzx_ConceptEN.TextId = objRow[convzx_Concept.TextId] == DBNull.Value ? null : objRow[convzx_Concept.TextId].ToString().Trim(); //课件Id
objvzx_ConceptEN.VoteCount = objRow[convzx_Concept.VoteCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VoteCount].ToString().Trim()); //点赞计数
objvzx_ConceptEN.IsSubmit = TransNullToBool(objRow[convzx_Concept.IsSubmit].ToString().Trim()); //是否提交
objvzx_ConceptEN.AppraiseCount = objRow[convzx_Concept.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.AppraiseCount].ToString().Trim()); //评论数
objvzx_ConceptEN.Score = objRow[convzx_Concept.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.Score].ToString().Trim()); //评分
objvzx_ConceptEN.StuScore = objRow[convzx_Concept.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.StuScore].ToString().Trim()); //学生平均分
objvzx_ConceptEN.TeaScore = objRow[convzx_Concept.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convzx_Concept.TeaScore].ToString().Trim()); //教师评分
objvzx_ConceptEN.CreateDate = objRow[convzx_Concept.CreateDate] == DBNull.Value ? null : objRow[convzx_Concept.CreateDate].ToString().Trim(); //建立日期
objvzx_ConceptEN.UpdDate = objRow[convzx_Concept.UpdDate] == DBNull.Value ? null : objRow[convzx_Concept.UpdDate].ToString().Trim(); //修改日期
objvzx_ConceptEN.UpdUser = objRow[convzx_Concept.UpdUser] == DBNull.Value ? null : objRow[convzx_Concept.UpdUser].ToString().Trim(); //修改人
objvzx_ConceptEN.IdCurrEduCls = objRow[convzx_Concept.IdCurrEduCls] == DBNull.Value ? null : objRow[convzx_Concept.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvzx_ConceptEN.PdfContent = objRow[convzx_Concept.PdfContent] == DBNull.Value ? null : objRow[convzx_Concept.PdfContent].ToString().Trim(); //Pdf内容
objvzx_ConceptEN.PdfPageNum = objRow[convzx_Concept.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageNum].ToString().Trim()); //Pdf页码
objvzx_ConceptEN.CitationCount = objRow[convzx_Concept.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.CitationCount].ToString().Trim()); //引用统计
objvzx_ConceptEN.VersionCount = objRow[convzx_Concept.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.VersionCount].ToString().Trim()); //版本统计
objvzx_ConceptEN.zxShareId = objRow[convzx_Concept.zxShareId].ToString().Trim(); //分享Id
objvzx_ConceptEN.Memo = objRow[convzx_Concept.Memo] == DBNull.Value ? null : objRow[convzx_Concept.Memo].ToString().Trim(); //备注
objvzx_ConceptEN.PdfDivLet = objRow[convzx_Concept.PdfDivLet] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivLet].ToString().Trim(); //PdfDivLet
objvzx_ConceptEN.PdfDivTop = objRow[convzx_Concept.PdfDivTop] == DBNull.Value ? null : objRow[convzx_Concept.PdfDivTop].ToString().Trim(); //PdfDivTop
objvzx_ConceptEN.PdfPageNumIn = objRow[convzx_Concept.PdfPageNumIn] == DBNull.Value ? null : objRow[convzx_Concept.PdfPageNumIn].ToString().Trim(); //PdfPageNumIn
objvzx_ConceptEN.PdfPageTop = objRow[convzx_Concept.PdfPageTop] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convzx_Concept.PdfPageTop].ToString().Trim()); //pdf页面顶部位置
objvzx_ConceptEN.PdfZoom = objRow[convzx_Concept.PdfZoom] == DBNull.Value ? null : objRow[convzx_Concept.PdfZoom].ToString().Trim(); //PdfZoom
objvzx_ConceptEN.GroupTextId = objRow[convzx_Concept.GroupTextId] == DBNull.Value ? null : objRow[convzx_Concept.GroupTextId].ToString().Trim(); //小组Id
objvzx_ConceptEN.TextTitle = objRow[convzx_Concept.TextTitle] == DBNull.Value ? null : objRow[convzx_Concept.TextTitle].ToString().Trim(); //TextTitle
objvzx_ConceptEN.Author = objRow[convzx_Concept.Author] == DBNull.Value ? null : objRow[convzx_Concept.Author].ToString().Trim(); //作者
objvzx_ConceptEN.ResearchQuestion = objRow[convzx_Concept.ResearchQuestion] == DBNull.Value ? null : objRow[convzx_Concept.ResearchQuestion].ToString().Trim(); //研究问题
objvzx_ConceptEN.Keyword = objRow[convzx_Concept.Keyword] == DBNull.Value ? null : objRow[convzx_Concept.Keyword].ToString().Trim(); //关键字
objvzx_ConceptEN.Edition = objRow[convzx_Concept.Edition] == DBNull.Value ? null : objRow[convzx_Concept.Edition].ToString().Trim(); //Edition
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvzx_ConceptDA: GetObjByDataRow)", objException.Message));
}
objvzx_ConceptEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvzx_ConceptEN;
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
objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_ConceptEN._CurrTabName, convzx_Concept.zxConceptId, 8, "");
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
objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvzx_ConceptEN._CurrTabName, convzx_Concept.zxConceptId, 8, strPrefix);
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select zxConceptId from vzx_Concept where " + strCondition;
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select zxConceptId from vzx_Concept where " + strCondition;
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Concept", "zxConceptId = " + "'"+ strzxConceptId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvzx_ConceptDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vzx_Concept", strCondition))
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
objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vzx_Concept");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvzx_ConceptENS">源对象</param>
 /// <param name = "objvzx_ConceptENT">目标对象</param>
public void CopyTo(clsvzx_ConceptEN objvzx_ConceptENS, clsvzx_ConceptEN objvzx_ConceptENT)
{
objvzx_ConceptENT.zxConceptId = objvzx_ConceptENS.zxConceptId; //概念Id
objvzx_ConceptENT.ConceptName = objvzx_ConceptENS.ConceptName; //概念名称
objvzx_ConceptENT.ConceptContent = objvzx_ConceptENS.ConceptContent; //概念内容
objvzx_ConceptENT.TextId = objvzx_ConceptENS.TextId; //课件Id
objvzx_ConceptENT.VoteCount = objvzx_ConceptENS.VoteCount; //点赞计数
objvzx_ConceptENT.IsSubmit = objvzx_ConceptENS.IsSubmit; //是否提交
objvzx_ConceptENT.AppraiseCount = objvzx_ConceptENS.AppraiseCount; //评论数
objvzx_ConceptENT.Score = objvzx_ConceptENS.Score; //评分
objvzx_ConceptENT.StuScore = objvzx_ConceptENS.StuScore; //学生平均分
objvzx_ConceptENT.TeaScore = objvzx_ConceptENS.TeaScore; //教师评分
objvzx_ConceptENT.CreateDate = objvzx_ConceptENS.CreateDate; //建立日期
objvzx_ConceptENT.UpdDate = objvzx_ConceptENS.UpdDate; //修改日期
objvzx_ConceptENT.UpdUser = objvzx_ConceptENS.UpdUser; //修改人
objvzx_ConceptENT.IdCurrEduCls = objvzx_ConceptENS.IdCurrEduCls; //教学班流水号
objvzx_ConceptENT.PdfContent = objvzx_ConceptENS.PdfContent; //Pdf内容
objvzx_ConceptENT.PdfPageNum = objvzx_ConceptENS.PdfPageNum; //Pdf页码
objvzx_ConceptENT.CitationCount = objvzx_ConceptENS.CitationCount; //引用统计
objvzx_ConceptENT.VersionCount = objvzx_ConceptENS.VersionCount; //版本统计
objvzx_ConceptENT.zxShareId = objvzx_ConceptENS.zxShareId; //分享Id
objvzx_ConceptENT.Memo = objvzx_ConceptENS.Memo; //备注
objvzx_ConceptENT.PdfDivLet = objvzx_ConceptENS.PdfDivLet; //PdfDivLet
objvzx_ConceptENT.PdfDivTop = objvzx_ConceptENS.PdfDivTop; //PdfDivTop
objvzx_ConceptENT.PdfPageNumIn = objvzx_ConceptENS.PdfPageNumIn; //PdfPageNumIn
objvzx_ConceptENT.PdfPageTop = objvzx_ConceptENS.PdfPageTop; //pdf页面顶部位置
objvzx_ConceptENT.PdfZoom = objvzx_ConceptENS.PdfZoom; //PdfZoom
objvzx_ConceptENT.GroupTextId = objvzx_ConceptENS.GroupTextId; //小组Id
objvzx_ConceptENT.TextTitle = objvzx_ConceptENS.TextTitle; //TextTitle
objvzx_ConceptENT.Author = objvzx_ConceptENS.Author; //作者
objvzx_ConceptENT.ResearchQuestion = objvzx_ConceptENS.ResearchQuestion; //研究问题
objvzx_ConceptENT.Keyword = objvzx_ConceptENS.Keyword; //关键字
objvzx_ConceptENT.Edition = objvzx_ConceptENS.Edition; //Edition
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvzx_ConceptEN objvzx_ConceptEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.zxConceptId, 8, convzx_Concept.zxConceptId);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.ConceptName, 500, convzx_Concept.ConceptName);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.TextId, 8, convzx_Concept.TextId);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.CreateDate, 20, convzx_Concept.CreateDate);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.UpdDate, 20, convzx_Concept.UpdDate);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.UpdUser, 20, convzx_Concept.UpdUser);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.IdCurrEduCls, 8, convzx_Concept.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.PdfContent, 2000, convzx_Concept.PdfContent);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.zxShareId, 2, convzx_Concept.zxShareId);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.Memo, 1000, convzx_Concept.Memo);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.PdfDivLet, 50, convzx_Concept.PdfDivLet);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.PdfDivTop, 50, convzx_Concept.PdfDivTop);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.PdfPageNumIn, 50, convzx_Concept.PdfPageNumIn);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.PdfZoom, 50, convzx_Concept.PdfZoom);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.GroupTextId, 8, convzx_Concept.GroupTextId);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.TextTitle, 500, convzx_Concept.TextTitle);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.Author, 200, convzx_Concept.Author);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.ResearchQuestion, 2000, convzx_Concept.ResearchQuestion);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.Keyword, 1000, convzx_Concept.Keyword);
clsCheckSql.CheckFieldLen(objvzx_ConceptEN.Edition, 100, convzx_Concept.Edition);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.zxConceptId, convzx_Concept.zxConceptId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.ConceptName, convzx_Concept.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.TextId, convzx_Concept.TextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.CreateDate, convzx_Concept.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.UpdDate, convzx_Concept.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.UpdUser, convzx_Concept.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.IdCurrEduCls, convzx_Concept.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.PdfContent, convzx_Concept.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.zxShareId, convzx_Concept.zxShareId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.Memo, convzx_Concept.Memo);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.PdfDivLet, convzx_Concept.PdfDivLet);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.PdfDivTop, convzx_Concept.PdfDivTop);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.PdfPageNumIn, convzx_Concept.PdfPageNumIn);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.PdfZoom, convzx_Concept.PdfZoom);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.GroupTextId, convzx_Concept.GroupTextId);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.TextTitle, convzx_Concept.TextTitle);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.Author, convzx_Concept.Author);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.ResearchQuestion, convzx_Concept.ResearchQuestion);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.Keyword, convzx_Concept.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvzx_ConceptEN.Edition, convzx_Concept.Edition);
//检查外键字段长度
 objvzx_ConceptEN._IsCheckProperty = true;
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_ConceptEN._CurrTabName);
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvzx_ConceptEN._CurrTabName, strCondition);
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
 objSQL = clsvzx_ConceptDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}