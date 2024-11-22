
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsKnowledgeLearnDetailDA
 表名:KnowledgeLearnDetail(01120153)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:03:47
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// 知识点学习情况(KnowledgeLearnDetail)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsKnowledgeLearnDetailDA : clsCommBase4DA
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
 return clsKnowledgeLearnDetailEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsKnowledgeLearnDetailEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsKnowledgeLearnDetailEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsKnowledgeLearnDetailEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsKnowledgeLearnDetailEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_KnowledgeLearnDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable_KnowledgeLearnDetail)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeLearnDetail.* from KnowledgeLearnDetail Left Join {1} on {2} where {3} and KnowledgeLearnDetail.mId not in (Select top {5} KnowledgeLearnDetail.mId from KnowledgeLearnDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1} and mId not in (Select top {2} mId from KnowledgeLearnDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1} and mId not in (Select top {3} mId from KnowledgeLearnDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} KnowledgeLearnDetail.* from KnowledgeLearnDetail Left Join {1} on {2} where {3} and KnowledgeLearnDetail.mId not in (Select top {5} KnowledgeLearnDetail.mId from KnowledgeLearnDetail Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1} and mId not in (Select top {2} mId from KnowledgeLearnDetail where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from KnowledgeLearnDetail where {1} and mId not in (Select top {3} mId from KnowledgeLearnDetail where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsKnowledgeLearnDetailEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA:GetObjLst)", objException.Message));
}
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = TransNullToBool(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = TransNullToBool(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetObjLst)", objException.Message));
}
objKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeLearnDetailEN);
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
public List<clsKnowledgeLearnDetailEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA:GetObjLstByTabName)", objException.Message));
}
List<clsKnowledgeLearnDetailEN> arrObjLst = new List<clsKnowledgeLearnDetailEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = TransNullToBool(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = TransNullToBool(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetObjLst)", objException.Message));
}
objKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objKnowledgeLearnDetailEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetKnowledgeLearnDetail(ref clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where mId = " + ""+ objKnowledgeLearnDetailEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objKnowledgeLearnDetailEN.mId = TransNullToInt(objDT.Rows[0][conKnowledgeLearnDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objKnowledgeLearnDetailEN.UserId = objDT.Rows[0][conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objKnowledgeLearnDetailEN.LearnDate = objDT.Rows[0][conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期(字段类型:varchar,字段长度:20,是否可空:False)
 objKnowledgeLearnDetailEN.LearnModeId = objDT.Rows[0][conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id(字段类型:char,字段长度:4,是否可空:False)
 objKnowledgeLearnDetailEN.CourseKnowledgeId = objDT.Rows[0][conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnDetailEN.IdCase = objDT.Rows[0][conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnDetailEN.IdCaseType = objDT.Rows[0][conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objKnowledgeLearnDetailEN.IsRight = TransNullToBool(objDT.Rows[0][conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objDT.Rows[0][conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握(字段类型:bit,字段长度:1,是否可空:False)
 objKnowledgeLearnDetailEN.MasterDegree = TransNullToDouble(objDT.Rows[0][conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度(字段类型:numeric,字段长度:20,是否可空:False)
 objKnowledgeLearnDetailEN.MarkerId = objDT.Rows[0][conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.MarkTime = objDT.Rows[0][conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnDetailEN.IsAnalysis = TransNullToBool(objDT.Rows[0][conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析(字段类型:bit,字段长度:1,是否可空:False)
 objKnowledgeLearnDetailEN.CourseId = objDT.Rows[0][conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeLearnDetailEN.UpdDate = objDT.Rows[0][conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.UpdUser = objDT.Rows[0][conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.Memo = objDT.Rows[0][conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetKnowledgeLearnDetail)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsKnowledgeLearnDetailEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
 objKnowledgeLearnDetailEN.mId = Int32.Parse(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期(字段类型:varchar,字段长度:20,是否可空:False)
 objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id(字段类型:char,字段长度:4,是否可空:False)
 objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objKnowledgeLearnDetailEN.IsRight = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确(字段类型:bit,字段长度:1,是否可空:True)
 objKnowledgeLearnDetailEN.IsMaster = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握(字段类型:bit,字段长度:1,是否可空:False)
 objKnowledgeLearnDetailEN.MasterDegree = Double.Parse(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度(字段类型:numeric,字段长度:20,是否可空:False)
 objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间(字段类型:varchar,字段长度:14,是否可空:True)
 objKnowledgeLearnDetailEN.IsAnalysis = clsEntityBase2.TransNullToBool_S(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析(字段类型:bit,字段长度:1,是否可空:False)
 objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetObjBymId)", objException.Message));
}
return objKnowledgeLearnDetailEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsKnowledgeLearnDetailEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN()
{
mId = TransNullToInt(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()), //mId
UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(), //用户ID
LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(), //学习日期
LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(), //学习模式Id
CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(), //知识点Id
IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(), //案例流水号
IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(), //案例类型流水号
IsRight = TransNullToBool(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()), //是否正确
IsMaster = TransNullToBool(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()), //是否掌握
MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()), //掌握程度
MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(), //打分者
MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(), //批改时间
IsAnalysis = TransNullToBool(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()), //是否分析
CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(), //课程Id
UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim() //备注
};
objKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnDetailEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsKnowledgeLearnDetailEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = TransNullToBool(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = TransNullToBool(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetObjByDataRowKnowledgeLearnDetail)", objException.Message));
}
objKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnDetailEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsKnowledgeLearnDetailEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN = new clsKnowledgeLearnDetailEN();
try
{
objKnowledgeLearnDetailEN.mId = TransNullToInt(objRow[conKnowledgeLearnDetail.mId].ToString().Trim()); //mId
objKnowledgeLearnDetailEN.UserId = objRow[conKnowledgeLearnDetail.UserId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objKnowledgeLearnDetailEN.LearnDate = objRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objKnowledgeLearnDetailEN.LearnModeId = objRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objKnowledgeLearnDetailEN.CourseKnowledgeId = objRow[conKnowledgeLearnDetail.CourseKnowledgeId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objKnowledgeLearnDetailEN.IdCase = objRow[conKnowledgeLearnDetail.IdCase] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objKnowledgeLearnDetailEN.IdCaseType = objRow[conKnowledgeLearnDetail.IdCaseType] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objKnowledgeLearnDetailEN.IsRight = TransNullToBool(objRow[conKnowledgeLearnDetail.IsRight].ToString().Trim()); //是否正确
objKnowledgeLearnDetailEN.IsMaster = TransNullToBool(objRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim()); //是否掌握
objKnowledgeLearnDetailEN.MasterDegree = TransNullToDouble(objRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim()); //掌握程度
objKnowledgeLearnDetailEN.MarkerId = objRow[conKnowledgeLearnDetail.MarkerId] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objKnowledgeLearnDetailEN.MarkTime = objRow[conKnowledgeLearnDetail.MarkTime] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objKnowledgeLearnDetailEN.IsAnalysis = TransNullToBool(objRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim()); //是否分析
objKnowledgeLearnDetailEN.CourseId = objRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objKnowledgeLearnDetailEN.UpdDate = objRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objKnowledgeLearnDetailEN.UpdUser = objRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objKnowledgeLearnDetailEN.Memo = objRow[conKnowledgeLearnDetail.Memo] == DBNull.Value ? null : objRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsKnowledgeLearnDetailDA: GetObjByDataRow)", objException.Message));
}
objKnowledgeLearnDetailEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objKnowledgeLearnDetailEN;
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
objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeLearnDetailEN._CurrTabName, conKnowledgeLearnDetail.mId, 8, "");
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
objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsKnowledgeLearnDetailEN._CurrTabName, conKnowledgeLearnDetail.mId, 8, strPrefix);
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from KnowledgeLearnDetail where " + strCondition;
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from KnowledgeLearnDetail where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeLearnDetail", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("KnowledgeLearnDetail", strCondition))
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
objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("KnowledgeLearnDetail");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
 {
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnDetailEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeLearnDetail");
objRow = objDS.Tables["KnowledgeLearnDetail"].NewRow();
 if (objKnowledgeLearnDetailEN.UserId !=  "")
 {
objRow[conKnowledgeLearnDetail.UserId] = objKnowledgeLearnDetailEN.UserId; //用户ID
 }
objRow[conKnowledgeLearnDetail.LearnDate] = objKnowledgeLearnDetailEN.LearnDate; //学习日期
objRow[conKnowledgeLearnDetail.LearnModeId] = objKnowledgeLearnDetailEN.LearnModeId; //学习模式Id
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  "")
 {
objRow[conKnowledgeLearnDetail.CourseKnowledgeId] = objKnowledgeLearnDetailEN.CourseKnowledgeId; //知识点Id
 }
 if (objKnowledgeLearnDetailEN.IdCase !=  "")
 {
objRow[conKnowledgeLearnDetail.IdCase] = objKnowledgeLearnDetailEN.IdCase; //案例流水号
 }
 if (objKnowledgeLearnDetailEN.IdCaseType !=  "")
 {
objRow[conKnowledgeLearnDetail.IdCaseType] = objKnowledgeLearnDetailEN.IdCaseType; //案例类型流水号
 }
objRow[conKnowledgeLearnDetail.IsRight] = objKnowledgeLearnDetailEN.IsRight; //是否正确
objRow[conKnowledgeLearnDetail.IsMaster] = objKnowledgeLearnDetailEN.IsMaster; //是否掌握
objRow[conKnowledgeLearnDetail.MasterDegree] = objKnowledgeLearnDetailEN.MasterDegree; //掌握程度
 if (objKnowledgeLearnDetailEN.MarkerId !=  "")
 {
objRow[conKnowledgeLearnDetail.MarkerId] = objKnowledgeLearnDetailEN.MarkerId; //打分者
 }
 if (objKnowledgeLearnDetailEN.MarkTime !=  "")
 {
objRow[conKnowledgeLearnDetail.MarkTime] = objKnowledgeLearnDetailEN.MarkTime; //批改时间
 }
objRow[conKnowledgeLearnDetail.IsAnalysis] = objKnowledgeLearnDetailEN.IsAnalysis; //是否分析
objRow[conKnowledgeLearnDetail.CourseId] = objKnowledgeLearnDetailEN.CourseId; //课程Id
objRow[conKnowledgeLearnDetail.UpdDate] = objKnowledgeLearnDetailEN.UpdDate; //修改日期
objRow[conKnowledgeLearnDetail.UpdUser] = objKnowledgeLearnDetailEN.UpdUser; //修改人
 if (objKnowledgeLearnDetailEN.Memo !=  "")
 {
objRow[conKnowledgeLearnDetail.Memo] = objKnowledgeLearnDetailEN.Memo; //备注
 }
objDS.Tables[clsKnowledgeLearnDetailEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsKnowledgeLearnDetailEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UserId);
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnDate);
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnModeId);
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnModeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCase);
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCaseType);
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsRight);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsMaster);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsMaster  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnDetailEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkerId);
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkTime);
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsAnalysis);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsAnalysis  ==  false ? "0" : "1") + "'");
 
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseId);
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdDate);
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdUser);
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.Memo);
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UserId);
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnDate);
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnModeId);
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnModeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCase);
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCaseType);
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsRight);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsMaster);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsMaster  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnDetailEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkerId);
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkTime);
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsAnalysis);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsAnalysis  ==  false ? "0" : "1") + "'");
 
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseId);
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdDate);
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdUser);
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.Memo);
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnDetailEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UserId);
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnDate);
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnModeId);
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnModeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCase);
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCaseType);
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsRight);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsMaster);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsMaster  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnDetailEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkerId);
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkTime);
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsAnalysis);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsAnalysis  ==  false ? "0" : "1") + "'");
 
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseId);
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdDate);
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdUser);
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.Memo);
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnDetail");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objKnowledgeLearnDetailEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UserId);
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnDate);
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.LearnModeId);
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLearnModeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseKnowledgeId);
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCase);
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCase + "'");
 }
 
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IdCaseType);
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCaseType + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsRight);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsRight  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsMaster);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsMaster  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MasterDegree);
 arrValueListForInsert.Add(objKnowledgeLearnDetailEN.MasterDegree.ToString());
 
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkerId);
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.MarkTime);
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkTime + "'");
 }
 
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.IsAnalysis);
 arrValueListForInsert.Add("'" + (objKnowledgeLearnDetailEN.IsAnalysis  ==  false ? "0" : "1") + "'");
 
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.CourseId);
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdDate);
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.UpdUser);
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conKnowledgeLearnDetail.Memo);
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into KnowledgeLearnDetail");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewKnowledgeLearnDetails(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "KnowledgeLearnDetail");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsKnowledgeLearnDetailEN._CurrTabName ].NewRow();
objRow[conKnowledgeLearnDetail.UserId] = oRow[conKnowledgeLearnDetail.UserId].ToString().Trim(); //用户ID
objRow[conKnowledgeLearnDetail.LearnDate] = oRow[conKnowledgeLearnDetail.LearnDate].ToString().Trim(); //学习日期
objRow[conKnowledgeLearnDetail.LearnModeId] = oRow[conKnowledgeLearnDetail.LearnModeId].ToString().Trim(); //学习模式Id
objRow[conKnowledgeLearnDetail.CourseKnowledgeId] = oRow[conKnowledgeLearnDetail.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[conKnowledgeLearnDetail.IdCase] = oRow[conKnowledgeLearnDetail.IdCase].ToString().Trim(); //案例流水号
objRow[conKnowledgeLearnDetail.IdCaseType] = oRow[conKnowledgeLearnDetail.IdCaseType].ToString().Trim(); //案例类型流水号
objRow[conKnowledgeLearnDetail.IsRight] = oRow[conKnowledgeLearnDetail.IsRight].ToString().Trim(); //是否正确
objRow[conKnowledgeLearnDetail.IsMaster] = oRow[conKnowledgeLearnDetail.IsMaster].ToString().Trim(); //是否掌握
objRow[conKnowledgeLearnDetail.MasterDegree] = oRow[conKnowledgeLearnDetail.MasterDegree].ToString().Trim(); //掌握程度
objRow[conKnowledgeLearnDetail.MarkerId] = oRow[conKnowledgeLearnDetail.MarkerId].ToString().Trim(); //打分者
objRow[conKnowledgeLearnDetail.MarkTime] = oRow[conKnowledgeLearnDetail.MarkTime].ToString().Trim(); //批改时间
objRow[conKnowledgeLearnDetail.IsAnalysis] = oRow[conKnowledgeLearnDetail.IsAnalysis].ToString().Trim(); //是否分析
objRow[conKnowledgeLearnDetail.CourseId] = oRow[conKnowledgeLearnDetail.CourseId].ToString().Trim(); //课程Id
objRow[conKnowledgeLearnDetail.UpdDate] = oRow[conKnowledgeLearnDetail.UpdDate].ToString().Trim(); //修改日期
objRow[conKnowledgeLearnDetail.UpdUser] = oRow[conKnowledgeLearnDetail.UpdUser].ToString().Trim(); //修改人
objRow[conKnowledgeLearnDetail.Memo] = oRow[conKnowledgeLearnDetail.Memo].ToString().Trim(); //备注
 objDS.Tables[clsKnowledgeLearnDetailEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsKnowledgeLearnDetailEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnDetailEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
strSQL = "Select * from KnowledgeLearnDetail where mId = " + ""+ objKnowledgeLearnDetailEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsKnowledgeLearnDetailEN._CurrTabName);
if (objDS.Tables[clsKnowledgeLearnDetailEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objKnowledgeLearnDetailEN.mId+"");
return false;
}
objRow = objDS.Tables[clsKnowledgeLearnDetailEN._CurrTabName].Rows[0];
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UserId))
 {
objRow[conKnowledgeLearnDetail.UserId] = objKnowledgeLearnDetailEN.UserId; //用户ID
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnDate))
 {
objRow[conKnowledgeLearnDetail.LearnDate] = objKnowledgeLearnDetailEN.LearnDate; //学习日期
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnModeId))
 {
objRow[conKnowledgeLearnDetail.LearnModeId] = objKnowledgeLearnDetailEN.LearnModeId; //学习模式Id
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId))
 {
objRow[conKnowledgeLearnDetail.CourseKnowledgeId] = objKnowledgeLearnDetailEN.CourseKnowledgeId; //知识点Id
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCase))
 {
objRow[conKnowledgeLearnDetail.IdCase] = objKnowledgeLearnDetailEN.IdCase; //案例流水号
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCaseType))
 {
objRow[conKnowledgeLearnDetail.IdCaseType] = objKnowledgeLearnDetailEN.IdCaseType; //案例类型流水号
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsRight))
 {
objRow[conKnowledgeLearnDetail.IsRight] = objKnowledgeLearnDetailEN.IsRight; //是否正确
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsMaster))
 {
objRow[conKnowledgeLearnDetail.IsMaster] = objKnowledgeLearnDetailEN.IsMaster; //是否掌握
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MasterDegree))
 {
objRow[conKnowledgeLearnDetail.MasterDegree] = objKnowledgeLearnDetailEN.MasterDegree; //掌握程度
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkerId))
 {
objRow[conKnowledgeLearnDetail.MarkerId] = objKnowledgeLearnDetailEN.MarkerId; //打分者
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkTime))
 {
objRow[conKnowledgeLearnDetail.MarkTime] = objKnowledgeLearnDetailEN.MarkTime; //批改时间
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsAnalysis))
 {
objRow[conKnowledgeLearnDetail.IsAnalysis] = objKnowledgeLearnDetailEN.IsAnalysis; //是否分析
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseId))
 {
objRow[conKnowledgeLearnDetail.CourseId] = objKnowledgeLearnDetailEN.CourseId; //课程Id
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdDate))
 {
objRow[conKnowledgeLearnDetail.UpdDate] = objKnowledgeLearnDetailEN.UpdDate; //修改日期
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdUser))
 {
objRow[conKnowledgeLearnDetail.UpdUser] = objKnowledgeLearnDetailEN.UpdUser; //修改人
 }
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.Memo))
 {
objRow[conKnowledgeLearnDetail.Memo] = objKnowledgeLearnDetailEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsKnowledgeLearnDetailEN._CurrTabName);
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update KnowledgeLearnDetail Set ");
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UserId))
 {
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conKnowledgeLearnDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UserId); //用户ID
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnDate))
 {
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnDate, conKnowledgeLearnDetail.LearnDate); //学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.LearnDate); //学习日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnModeId))
 {
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnModeId, conKnowledgeLearnDetail.LearnModeId); //学习模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.LearnModeId); //学习模式Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId))
 {
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conKnowledgeLearnDetail.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCase))
 {
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCase, conKnowledgeLearnDetail.IdCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.IdCase); //案例流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCaseType))
 {
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conKnowledgeLearnDetail.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.IdCaseType); //案例类型流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsRight == true?"1":"0", conKnowledgeLearnDetail.IsRight); //是否正确
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsMaster))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsMaster == true?"1":"0", conKnowledgeLearnDetail.IsMaster); //是否掌握
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MasterDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnDetailEN.MasterDegree, conKnowledgeLearnDetail.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkerId))
 {
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conKnowledgeLearnDetail.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.MarkerId); //打分者
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkTime))
 {
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkTime, conKnowledgeLearnDetail.MarkTime); //批改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.MarkTime); //批改时间
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsAnalysis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsAnalysis == true?"1":"0", conKnowledgeLearnDetail.IsAnalysis); //是否分析
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseId))
 {
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeLearnDetail.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdDate))
 {
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeLearnDetail.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdUser))
 {
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeLearnDetail.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.Memo))
 {
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeLearnDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objKnowledgeLearnDetailEN.mId); 
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCondition)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnDetail Set ");
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UserId))
 {
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnDate))
 {
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnDate = '{0}',", strLearnDate); //学习日期
 }
 else
 {
 sbSQL.Append(" LearnDate = null,"); //学习日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnModeId))
 {
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnModeId = '{0}',", strLearnModeId); //学习模式Id
 }
 else
 {
 sbSQL.Append(" LearnModeId = null,"); //学习模式Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId))
 {
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCase))
 {
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCase = '{0}',", strIdCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdCase = null,"); //案例流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCaseType))
 {
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objKnowledgeLearnDetailEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsMaster))
 {
 sbSQL.AppendFormat(" IsMaster = '{0}',", objKnowledgeLearnDetailEN.IsMaster == true?"1":"0"); //是否掌握
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MasterDegree))
 {
 sbSQL.AppendFormat(" MasterDegree = {0},", objKnowledgeLearnDetailEN.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkerId))
 {
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkTime))
 {
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkTime = '{0}',", strMarkTime); //批改时间
 }
 else
 {
 sbSQL.Append(" MarkTime = null,"); //批改时间
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsAnalysis))
 {
 sbSQL.AppendFormat(" IsAnalysis = '{0}',", objKnowledgeLearnDetailEN.IsAnalysis == true?"1":"0"); //是否分析
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseId))
 {
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdDate))
 {
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdUser))
 {
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.Memo))
 {
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeLearnDetailEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnDetail Set ");
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UserId))
 {
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnDate))
 {
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnDate = '{0}',", strLearnDate); //学习日期
 }
 else
 {
 sbSQL.Append(" LearnDate = null,"); //学习日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnModeId))
 {
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LearnModeId = '{0}',", strLearnModeId); //学习模式Id
 }
 else
 {
 sbSQL.Append(" LearnModeId = null,"); //学习模式Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId))
 {
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCase))
 {
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCase = '{0}',", strIdCase); //案例流水号
 }
 else
 {
 sbSQL.Append(" IdCase = null,"); //案例流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCaseType))
 {
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCaseType = '{0}',", strIdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.Append(" IdCaseType = null,"); //案例类型流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsRight))
 {
 sbSQL.AppendFormat(" IsRight = '{0}',", objKnowledgeLearnDetailEN.IsRight == true?"1":"0"); //是否正确
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsMaster))
 {
 sbSQL.AppendFormat(" IsMaster = '{0}',", objKnowledgeLearnDetailEN.IsMaster == true?"1":"0"); //是否掌握
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MasterDegree))
 {
 sbSQL.AppendFormat(" MasterDegree = {0},", objKnowledgeLearnDetailEN.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkerId))
 {
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkTime))
 {
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkTime = '{0}',", strMarkTime); //批改时间
 }
 else
 {
 sbSQL.Append(" MarkTime = null,"); //批改时间
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsAnalysis))
 {
 sbSQL.AppendFormat(" IsAnalysis = '{0}',", objKnowledgeLearnDetailEN.IsAnalysis == true?"1":"0"); //是否分析
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseId))
 {
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdDate))
 {
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdUser))
 {
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.Memo))
 {
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objKnowledgeLearnDetailEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objKnowledgeLearnDetailEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objKnowledgeLearnDetailEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objKnowledgeLearnDetailEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update KnowledgeLearnDetail Set ");
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UserId))
 {
 if (objKnowledgeLearnDetailEN.UserId !=  null)
 {
 var strUserId = objKnowledgeLearnDetailEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conKnowledgeLearnDetail.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UserId); //用户ID
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnDate))
 {
 if (objKnowledgeLearnDetailEN.LearnDate !=  null)
 {
 var strLearnDate = objKnowledgeLearnDetailEN.LearnDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnDate, conKnowledgeLearnDetail.LearnDate); //学习日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.LearnDate); //学习日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.LearnModeId))
 {
 if (objKnowledgeLearnDetailEN.LearnModeId !=  null)
 {
 var strLearnModeId = objKnowledgeLearnDetailEN.LearnModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLearnModeId, conKnowledgeLearnDetail.LearnModeId); //学习模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.LearnModeId); //学习模式Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseKnowledgeId))
 {
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId  ==  "")
 {
 objKnowledgeLearnDetailEN.CourseKnowledgeId = null;
 }
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objKnowledgeLearnDetailEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, conKnowledgeLearnDetail.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCase))
 {
 if (objKnowledgeLearnDetailEN.IdCase !=  null)
 {
 var strIdCase = objKnowledgeLearnDetailEN.IdCase.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCase, conKnowledgeLearnDetail.IdCase); //案例流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.IdCase); //案例流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IdCaseType))
 {
 if (objKnowledgeLearnDetailEN.IdCaseType !=  null)
 {
 var strIdCaseType = objKnowledgeLearnDetailEN.IdCaseType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCaseType, conKnowledgeLearnDetail.IdCaseType); //案例类型流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.IdCaseType); //案例类型流水号
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsRight))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsRight == true?"1":"0", conKnowledgeLearnDetail.IsRight); //是否正确
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsMaster))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsMaster == true?"1":"0", conKnowledgeLearnDetail.IsMaster); //是否掌握
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MasterDegree))
 {
 sbSQL.AppendFormat("{1} = {0},",objKnowledgeLearnDetailEN.MasterDegree, conKnowledgeLearnDetail.MasterDegree); //掌握程度
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkerId))
 {
 if (objKnowledgeLearnDetailEN.MarkerId !=  null)
 {
 var strMarkerId = objKnowledgeLearnDetailEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, conKnowledgeLearnDetail.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.MarkerId); //打分者
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.MarkTime))
 {
 if (objKnowledgeLearnDetailEN.MarkTime !=  null)
 {
 var strMarkTime = objKnowledgeLearnDetailEN.MarkTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkTime, conKnowledgeLearnDetail.MarkTime); //批改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.MarkTime); //批改时间
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.IsAnalysis))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objKnowledgeLearnDetailEN.IsAnalysis == true?"1":"0", conKnowledgeLearnDetail.IsAnalysis); //是否分析
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.CourseId))
 {
 if (objKnowledgeLearnDetailEN.CourseId !=  null)
 {
 var strCourseId = objKnowledgeLearnDetailEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, conKnowledgeLearnDetail.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.CourseId); //课程Id
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdDate))
 {
 if (objKnowledgeLearnDetailEN.UpdDate !=  null)
 {
 var strUpdDate = objKnowledgeLearnDetailEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conKnowledgeLearnDetail.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UpdDate); //修改日期
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.UpdUser))
 {
 if (objKnowledgeLearnDetailEN.UpdUser !=  null)
 {
 var strUpdUser = objKnowledgeLearnDetailEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conKnowledgeLearnDetail.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.UpdUser); //修改人
 }
 }
 
 if (objKnowledgeLearnDetailEN.IsUpdated(conKnowledgeLearnDetail.Memo))
 {
 if (objKnowledgeLearnDetailEN.Memo !=  null)
 {
 var strMemo = objKnowledgeLearnDetailEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conKnowledgeLearnDetail.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conKnowledgeLearnDetail.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objKnowledgeLearnDetailEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("KnowledgeLearnDetail_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
//删除KnowledgeLearnDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnDetail where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelKnowledgeLearnDetail(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除KnowledgeLearnDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnDetail where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
//删除KnowledgeLearnDetail本表中与当前对象有关的记录
strSQL = strSQL + "Delete from KnowledgeLearnDetail where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelKnowledgeLearnDetail(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: DelKnowledgeLearnDetail)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeLearnDetail where " + strCondition ;
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
public bool DelKnowledgeLearnDetailWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsKnowledgeLearnDetailDA: DelKnowledgeLearnDetailWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from KnowledgeLearnDetail where " + strCondition ;
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
 /// <param name = "objKnowledgeLearnDetailENS">源对象</param>
 /// <param name = "objKnowledgeLearnDetailENT">目标对象</param>
public void CopyTo(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENS, clsKnowledgeLearnDetailEN objKnowledgeLearnDetailENT)
{
objKnowledgeLearnDetailENT.mId = objKnowledgeLearnDetailENS.mId; //mId
objKnowledgeLearnDetailENT.UserId = objKnowledgeLearnDetailENS.UserId; //用户ID
objKnowledgeLearnDetailENT.LearnDate = objKnowledgeLearnDetailENS.LearnDate; //学习日期
objKnowledgeLearnDetailENT.LearnModeId = objKnowledgeLearnDetailENS.LearnModeId; //学习模式Id
objKnowledgeLearnDetailENT.CourseKnowledgeId = objKnowledgeLearnDetailENS.CourseKnowledgeId; //知识点Id
objKnowledgeLearnDetailENT.IdCase = objKnowledgeLearnDetailENS.IdCase; //案例流水号
objKnowledgeLearnDetailENT.IdCaseType = objKnowledgeLearnDetailENS.IdCaseType; //案例类型流水号
objKnowledgeLearnDetailENT.IsRight = objKnowledgeLearnDetailENS.IsRight; //是否正确
objKnowledgeLearnDetailENT.IsMaster = objKnowledgeLearnDetailENS.IsMaster; //是否掌握
objKnowledgeLearnDetailENT.MasterDegree = objKnowledgeLearnDetailENS.MasterDegree; //掌握程度
objKnowledgeLearnDetailENT.MarkerId = objKnowledgeLearnDetailENS.MarkerId; //打分者
objKnowledgeLearnDetailENT.MarkTime = objKnowledgeLearnDetailENS.MarkTime; //批改时间
objKnowledgeLearnDetailENT.IsAnalysis = objKnowledgeLearnDetailENS.IsAnalysis; //是否分析
objKnowledgeLearnDetailENT.CourseId = objKnowledgeLearnDetailENS.CourseId; //课程Id
objKnowledgeLearnDetailENT.UpdDate = objKnowledgeLearnDetailENS.UpdDate; //修改日期
objKnowledgeLearnDetailENT.UpdUser = objKnowledgeLearnDetailENS.UpdUser; //修改人
objKnowledgeLearnDetailENT.Memo = objKnowledgeLearnDetailENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.LearnDate, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.LearnModeId, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.IsMaster, conKnowledgeLearnDetail.IsMaster);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.MasterDegree, conKnowledgeLearnDetail.MasterDegree);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.IsAnalysis, conKnowledgeLearnDetail.IsAnalysis);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.CourseId, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.UpdDate, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldNotNull(objKnowledgeLearnDetailEN.UpdUser, conKnowledgeLearnDetail.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UserId, 18, conKnowledgeLearnDetail.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnDate, 20, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCase, 8, conKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCaseType, 4, conKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkerId, 20, conKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkTime, 14, conKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseId, 8, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdDate, 20, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdUser, 20, conKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.Memo, 1000, conKnowledgeLearnDetail.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
 objKnowledgeLearnDetailEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UserId, 18, conKnowledgeLearnDetail.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnDate, 20, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCase, 8, conKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCaseType, 4, conKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkerId, 20, conKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkTime, 14, conKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseId, 8, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdDate, 20, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdUser, 20, conKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.Memo, 1000, conKnowledgeLearnDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
 objKnowledgeLearnDetailEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UserId, 18, conKnowledgeLearnDetail.UserId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnDate, 20, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.LearnModeId, 4, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCase, 8, conKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.IdCaseType, 4, conKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkerId, 20, conKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.MarkTime, 14, conKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.CourseId, 8, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdDate, 20, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.UpdUser, 20, conKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckFieldLen(objKnowledgeLearnDetailEN.Memo, 1000, conKnowledgeLearnDetail.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.UserId, conKnowledgeLearnDetail.UserId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.LearnDate, conKnowledgeLearnDetail.LearnDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.LearnModeId, conKnowledgeLearnDetail.LearnModeId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.CourseKnowledgeId, conKnowledgeLearnDetail.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.IdCase, conKnowledgeLearnDetail.IdCase);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.IdCaseType, conKnowledgeLearnDetail.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.MarkerId, conKnowledgeLearnDetail.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.MarkTime, conKnowledgeLearnDetail.MarkTime);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.CourseId, conKnowledgeLearnDetail.CourseId);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.UpdDate, conKnowledgeLearnDetail.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.UpdUser, conKnowledgeLearnDetail.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objKnowledgeLearnDetailEN.Memo, conKnowledgeLearnDetail.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objKnowledgeLearnDetailEN.CourseKnowledgeId, 8, conKnowledgeLearnDetail.CourseKnowledgeId);
 objKnowledgeLearnDetailEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--KnowledgeLearnDetail(知识点学习情况),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objKnowledgeLearnDetailEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsKnowledgeLearnDetailEN objKnowledgeLearnDetailEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objKnowledgeLearnDetailEN.UserId == null)
{
 sbCondition.AppendFormat(" and UserId is null");
}
else
{
 sbCondition.AppendFormat(" and UserId = '{0}'", objKnowledgeLearnDetailEN.UserId);
}
 if (objKnowledgeLearnDetailEN.IdCase == null)
{
 sbCondition.AppendFormat(" and IdCase is null");
}
else
{
 sbCondition.AppendFormat(" and IdCase = '{0}'", objKnowledgeLearnDetailEN.IdCase);
}
 if (objKnowledgeLearnDetailEN.CourseKnowledgeId == null)
{
 sbCondition.AppendFormat(" and CourseKnowledgeId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objKnowledgeLearnDetailEN.CourseKnowledgeId);
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeLearnDetailEN._CurrTabName);
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsKnowledgeLearnDetailEN._CurrTabName, strCondition);
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
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
 objSQL = clsKnowledgeLearnDetailDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}