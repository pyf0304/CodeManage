
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTConceptRelaDA
 表名:vRTConceptRela(01120607)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// vRTConceptRela(vRTConceptRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTConceptRelaDA : clsCommBase4DA
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
 return clsvRTConceptRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTConceptRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTConceptRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTConceptRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTConceptRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTConceptRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable_vRTConceptRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTConceptRela.* from vRTConceptRela Left Join {1} on {2} where {3} and vRTConceptRela.mId not in (Select top {5} vRTConceptRela.mId from vRTConceptRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1} and mId not in (Select top {2} mId from vRTConceptRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1} and mId not in (Select top {3} mId from vRTConceptRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTConceptRela.* from vRTConceptRela Left Join {1} on {2} where {3} and vRTConceptRela.mId not in (Select top {5} vRTConceptRela.mId from vRTConceptRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1} and mId not in (Select top {2} mId from vRTConceptRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTConceptRela where {1} and mId not in (Select top {3} mId from vRTConceptRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTConceptRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = TransNullToInt(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = TransNullToBool(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTConceptRelaDA: GetObjLst)", objException.Message));
}
objvRTConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTConceptRelaEN);
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
public List<clsvRTConceptRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTConceptRelaEN> arrObjLst = new List<clsvRTConceptRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = TransNullToInt(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = TransNullToBool(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTConceptRelaDA: GetObjLst)", objException.Message));
}
objvRTConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTConceptRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTConceptRela(ref clsvRTConceptRelaEN objvRTConceptRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where mId = " + ""+ objvRTConceptRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTConceptRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTConceptRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.TopicId = objDT.Rows[0][convRTConceptRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.ConceptId = objDT.Rows[0][convRTConceptRela.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTConceptRelaEN.UpdDate = objDT.Rows[0][convRTConceptRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.Memo = objDT.Rows[0][convRTConceptRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTConceptRelaEN.TopicName = objDT.Rows[0][convRTConceptRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTConceptRelaEN.TopicContent = objDT.Rows[0][convRTConceptRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTConceptRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convRTConceptRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.TopicProposePeople = objDT.Rows[0][convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTConceptRelaEN.ConceptContent = objDT.Rows[0][convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTConceptRelaEN.ConceptName = objDT.Rows[0][convRTConceptRela.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTConceptRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTConceptRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CitationId = objDT.Rows[0][convRTConceptRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTConceptRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTConceptRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTConceptRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTConceptRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.ConcepDate = objDT.Rows[0][convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ConcepUserId = objDT.Rows[0][convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTConceptRelaEN.IdCurrEduCls = objDT.Rows[0][convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTConceptRelaEN.PdfContent = objDT.Rows[0][convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTConceptRelaEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTConceptRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTConceptRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CreateDate = objDT.Rows[0][convRTConceptRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ShareId = objDT.Rows[0][convRTConceptRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTConceptRelaEN.UpdUser = objDT.Rows[0][convRTConceptRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ClassificationId = objDT.Rows[0][convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTConceptRelaDA: GetvRTConceptRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTConceptRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
 objvRTConceptRelaEN.mId = Int32.Parse(objRow[convRTConceptRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTConceptRelaDA: GetObjBymId)", objException.Message));
}
return objvRTConceptRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTConceptRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTConceptRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN()
{
mId = TransNullToInt(objRow[convRTConceptRela.mId].ToString().Trim()), //mId
TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(), //主题Id
ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(), //概念Id
UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(), //备注
TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(), //栏目主题
TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(), //主题内容
OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OrderNum].ToString().Trim()), //序号
TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(), //主题提出人
ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(), //概念内容
ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(), //概念名称
AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()), //评论数
CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.CitationCount].ToString().Trim()), //引用统计
CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(), //引用Id
IsSubmit = TransNullToBool(objRow[convRTConceptRela.IsSubmit].ToString().Trim()), //是否提交
Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.Score].ToString().Trim()), //评分
StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.TeaScore].ToString().Trim()), //教师评分
ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(), //ConcepDate
ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(), //ConcepUserId
IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()), //Pdf页码
OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(), //修改人
ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim() //分类Id
};
objvRTConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTConceptRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTConceptRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTConceptRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = TransNullToInt(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = TransNullToBool(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTConceptRelaDA: GetObjByDataRowvRTConceptRela)", objException.Message));
}
objvRTConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTConceptRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTConceptRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTConceptRelaEN objvRTConceptRelaEN = new clsvRTConceptRelaEN();
try
{
objvRTConceptRelaEN.mId = TransNullToInt(objRow[convRTConceptRela.mId].ToString().Trim()); //mId
objvRTConceptRelaEN.TopicId = objRow[convRTConceptRela.TopicId] == DBNull.Value ? null : objRow[convRTConceptRela.TopicId].ToString().Trim(); //主题Id
objvRTConceptRelaEN.ConceptId = objRow[convRTConceptRela.ConceptId].ToString().Trim(); //概念Id
objvRTConceptRelaEN.UpdDate = objRow[convRTConceptRela.UpdDate] == DBNull.Value ? null : objRow[convRTConceptRela.UpdDate].ToString().Trim(); //修改日期
objvRTConceptRelaEN.Memo = objRow[convRTConceptRela.Memo] == DBNull.Value ? null : objRow[convRTConceptRela.Memo].ToString().Trim(); //备注
objvRTConceptRelaEN.TopicName = objRow[convRTConceptRela.TopicName] == DBNull.Value ? null : objRow[convRTConceptRela.TopicName].ToString().Trim(); //栏目主题
objvRTConceptRelaEN.TopicContent = objRow[convRTConceptRela.TopicContent] == DBNull.Value ? null : objRow[convRTConceptRela.TopicContent].ToString().Trim(); //主题内容
objvRTConceptRelaEN.OrderNum = objRow[convRTConceptRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OrderNum].ToString().Trim()); //序号
objvRTConceptRelaEN.TopicProposePeople = objRow[convRTConceptRela.TopicProposePeople] == DBNull.Value ? null : objRow[convRTConceptRela.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTConceptRelaEN.ConceptContent = objRow[convRTConceptRela.ConceptContent] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptContent].ToString().Trim(); //概念内容
objvRTConceptRelaEN.ConceptName = objRow[convRTConceptRela.ConceptName] == DBNull.Value ? null : objRow[convRTConceptRela.ConceptName].ToString().Trim(); //概念名称
objvRTConceptRelaEN.AppraiseCount = objRow[convRTConceptRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.AppraiseCount].ToString().Trim()); //评论数
objvRTConceptRelaEN.CitationCount = objRow[convRTConceptRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.CitationCount].ToString().Trim()); //引用统计
objvRTConceptRelaEN.CitationId = objRow[convRTConceptRela.CitationId] == DBNull.Value ? null : objRow[convRTConceptRela.CitationId].ToString().Trim(); //引用Id
objvRTConceptRelaEN.IsSubmit = TransNullToBool(objRow[convRTConceptRela.IsSubmit].ToString().Trim()); //是否提交
objvRTConceptRelaEN.Score = objRow[convRTConceptRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.Score].ToString().Trim()); //评分
objvRTConceptRelaEN.StuScore = objRow[convRTConceptRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.StuScore].ToString().Trim()); //学生平均分
objvRTConceptRelaEN.TeaScore = objRow[convRTConceptRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTConceptRela.TeaScore].ToString().Trim()); //教师评分
objvRTConceptRelaEN.ConcepDate = objRow[convRTConceptRela.ConcepDate] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepDate].ToString().Trim(); //ConcepDate
objvRTConceptRelaEN.ConcepUserId = objRow[convRTConceptRela.ConcepUserId] == DBNull.Value ? null : objRow[convRTConceptRela.ConcepUserId].ToString().Trim(); //ConcepUserId
objvRTConceptRelaEN.IdCurrEduCls = objRow[convRTConceptRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTConceptRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTConceptRelaEN.PdfContent = objRow[convRTConceptRela.PdfContent] == DBNull.Value ? null : objRow[convRTConceptRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTConceptRelaEN.PdfPageNum = objRow[convRTConceptRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTConceptRelaEN.OkCount = objRow[convRTConceptRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.OkCount].ToString().Trim()); //点赞统计
objvRTConceptRelaEN.VersionCount = objRow[convRTConceptRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTConceptRela.VersionCount].ToString().Trim()); //版本统计
objvRTConceptRelaEN.CreateDate = objRow[convRTConceptRela.CreateDate] == DBNull.Value ? null : objRow[convRTConceptRela.CreateDate].ToString().Trim(); //建立日期
objvRTConceptRelaEN.ShareId = objRow[convRTConceptRela.ShareId] == DBNull.Value ? null : objRow[convRTConceptRela.ShareId].ToString().Trim(); //分享Id
objvRTConceptRelaEN.UpdUser = objRow[convRTConceptRela.UpdUser] == DBNull.Value ? null : objRow[convRTConceptRela.UpdUser].ToString().Trim(); //修改人
objvRTConceptRelaEN.ClassificationId = objRow[convRTConceptRela.ClassificationId] == DBNull.Value ? null : objRow[convRTConceptRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTConceptRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTConceptRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTConceptRelaEN;
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
objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTConceptRelaEN._CurrTabName, convRTConceptRela.mId, 8, "");
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
objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTConceptRelaEN._CurrTabName, convRTConceptRela.mId, 8, strPrefix);
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTConceptRela where " + strCondition;
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTConceptRela where " + strCondition;
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTConceptRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTConceptRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTConceptRela", strCondition))
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
objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTConceptRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTConceptRelaENS">源对象</param>
 /// <param name = "objvRTConceptRelaENT">目标对象</param>
public void CopyTo(clsvRTConceptRelaEN objvRTConceptRelaENS, clsvRTConceptRelaEN objvRTConceptRelaENT)
{
objvRTConceptRelaENT.mId = objvRTConceptRelaENS.mId; //mId
objvRTConceptRelaENT.TopicId = objvRTConceptRelaENS.TopicId; //主题Id
objvRTConceptRelaENT.ConceptId = objvRTConceptRelaENS.ConceptId; //概念Id
objvRTConceptRelaENT.UpdDate = objvRTConceptRelaENS.UpdDate; //修改日期
objvRTConceptRelaENT.Memo = objvRTConceptRelaENS.Memo; //备注
objvRTConceptRelaENT.TopicName = objvRTConceptRelaENS.TopicName; //栏目主题
objvRTConceptRelaENT.TopicContent = objvRTConceptRelaENS.TopicContent; //主题内容
objvRTConceptRelaENT.OrderNum = objvRTConceptRelaENS.OrderNum; //序号
objvRTConceptRelaENT.TopicProposePeople = objvRTConceptRelaENS.TopicProposePeople; //主题提出人
objvRTConceptRelaENT.ConceptContent = objvRTConceptRelaENS.ConceptContent; //概念内容
objvRTConceptRelaENT.ConceptName = objvRTConceptRelaENS.ConceptName; //概念名称
objvRTConceptRelaENT.AppraiseCount = objvRTConceptRelaENS.AppraiseCount; //评论数
objvRTConceptRelaENT.CitationCount = objvRTConceptRelaENS.CitationCount; //引用统计
objvRTConceptRelaENT.CitationId = objvRTConceptRelaENS.CitationId; //引用Id
objvRTConceptRelaENT.IsSubmit = objvRTConceptRelaENS.IsSubmit; //是否提交
objvRTConceptRelaENT.Score = objvRTConceptRelaENS.Score; //评分
objvRTConceptRelaENT.StuScore = objvRTConceptRelaENS.StuScore; //学生平均分
objvRTConceptRelaENT.TeaScore = objvRTConceptRelaENS.TeaScore; //教师评分
objvRTConceptRelaENT.ConcepDate = objvRTConceptRelaENS.ConcepDate; //ConcepDate
objvRTConceptRelaENT.ConcepUserId = objvRTConceptRelaENS.ConcepUserId; //ConcepUserId
objvRTConceptRelaENT.IdCurrEduCls = objvRTConceptRelaENS.IdCurrEduCls; //教学班流水号
objvRTConceptRelaENT.PdfContent = objvRTConceptRelaENS.PdfContent; //Pdf内容
objvRTConceptRelaENT.PdfPageNum = objvRTConceptRelaENS.PdfPageNum; //Pdf页码
objvRTConceptRelaENT.OkCount = objvRTConceptRelaENS.OkCount; //点赞统计
objvRTConceptRelaENT.VersionCount = objvRTConceptRelaENS.VersionCount; //版本统计
objvRTConceptRelaENT.CreateDate = objvRTConceptRelaENS.CreateDate; //建立日期
objvRTConceptRelaENT.ShareId = objvRTConceptRelaENS.ShareId; //分享Id
objvRTConceptRelaENT.UpdUser = objvRTConceptRelaENS.UpdUser; //修改人
objvRTConceptRelaENT.ClassificationId = objvRTConceptRelaENS.ClassificationId; //分类Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.TopicId, 8, convRTConceptRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ConceptId, 8, convRTConceptRela.ConceptId);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.UpdDate, 20, convRTConceptRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.Memo, 1000, convRTConceptRela.Memo);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.TopicName, 200, convRTConceptRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.TopicProposePeople, 50, convRTConceptRela.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ConceptName, 500, convRTConceptRela.ConceptName);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.CitationId, 8, convRTConceptRela.CitationId);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ConcepDate, 20, convRTConceptRela.ConcepDate);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ConcepUserId, 50, convRTConceptRela.ConcepUserId);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.IdCurrEduCls, 8, convRTConceptRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.PdfContent, 2000, convRTConceptRela.PdfContent);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.CreateDate, 20, convRTConceptRela.CreateDate);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ShareId, 2, convRTConceptRela.ShareId);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.UpdUser, 20, convRTConceptRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTConceptRelaEN.ClassificationId, 10, convRTConceptRela.ClassificationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.TopicId, convRTConceptRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ConceptId, convRTConceptRela.ConceptId);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.UpdDate, convRTConceptRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.Memo, convRTConceptRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.TopicName, convRTConceptRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.TopicProposePeople, convRTConceptRela.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ConceptName, convRTConceptRela.ConceptName);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.CitationId, convRTConceptRela.CitationId);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ConcepDate, convRTConceptRela.ConcepDate);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ConcepUserId, convRTConceptRela.ConcepUserId);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.IdCurrEduCls, convRTConceptRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.PdfContent, convRTConceptRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.CreateDate, convRTConceptRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ShareId, convRTConceptRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.UpdUser, convRTConceptRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTConceptRelaEN.ClassificationId, convRTConceptRela.ClassificationId);
//检查外键字段长度
 objvRTConceptRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--vRTConceptRela(vRTConceptRela),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objvRTConceptRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsvRTConceptRelaEN objvRTConceptRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and mId = '{0}'", objvRTConceptRelaEN.mId);
 if (objvRTConceptRelaEN.TopicId == null)
{
 sbCondition.AppendFormat(" and TopicId is null");
}
else
{
 sbCondition.AppendFormat(" and TopicId = '{0}'", objvRTConceptRelaEN.TopicId);
}
 sbCondition.AppendFormat(" and ConceptId = '{0}'", objvRTConceptRelaEN.ConceptId);
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTConceptRelaEN._CurrTabName);
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTConceptRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTConceptRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}