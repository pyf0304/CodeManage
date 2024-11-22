
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTTopicObjectiveRelaDA
 表名:vRTTopicObjectiveRela(01120616)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 13:05:39
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
 /// vRTTopicObjectiveRela(vRTTopicObjectiveRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTTopicObjectiveRelaDA : clsCommBase4DA
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
 return clsvRTTopicObjectiveRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTTopicObjectiveRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTTopicObjectiveRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTTopicObjectiveRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTTopicObjectiveRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTTopicObjectiveRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable_vRTTopicObjectiveRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTTopicObjectiveRela.* from vRTTopicObjectiveRela Left Join {1} on {2} where {3} and vRTTopicObjectiveRela.mId not in (Select top {5} vRTTopicObjectiveRela.mId from vRTTopicObjectiveRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1} and mId not in (Select top {2} mId from vRTTopicObjectiveRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1} and mId not in (Select top {3} mId from vRTTopicObjectiveRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTTopicObjectiveRela.* from vRTTopicObjectiveRela Left Join {1} on {2} where {3} and vRTTopicObjectiveRela.mId not in (Select top {5} vRTTopicObjectiveRela.mId from vRTTopicObjectiveRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1} and mId not in (Select top {2} mId from vRTTopicObjectiveRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTTopicObjectiveRela where {1} and mId not in (Select top {3} mId from vRTTopicObjectiveRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTTopicObjectiveRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA:GetObjLst)", objException.Message));
}
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetObjLst)", objException.Message));
}
objvRTTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
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
public List<clsvRTTopicObjectiveRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTTopicObjectiveRelaEN> arrObjLst = new List<clsvRTTopicObjectiveRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetObjLst)", objException.Message));
}
objvRTTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTTopicObjectiveRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTTopicObjectiveRela(ref clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where mId = " + ""+ objvRTTopicObjectiveRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTTopicObjectiveRelaEN.mId = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicId = objDT.Rows[0][convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicObjectiveId = objDT.Rows[0][convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTTopicObjectiveRelaEN.UpdDate = objDT.Rows[0][convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.UpdUser = objDT.Rows[0][convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objDT.Rows[0][convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveType = objDT.Rows[0][convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvRTTopicObjectiveRelaEN.SourceId = objDT.Rows[0][convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objvRTTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveName = objDT.Rows[0][convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveContent = objDT.Rows[0][convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.Conclusion = objDT.Rows[0][convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicContent = objDT.Rows[0][convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicName = objDT.Rows[0][convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTTopicObjectiveRelaEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.Score = TransNullToFloat(objDT.Rows[0][convRTTopicObjectiveRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjDate = objDT.Rows[0][convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjUserId = objDT.Rows[0][convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTTopicObjectiveRelaEN.IdCurrEduCls = objDT.Rows[0][convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTTopicObjectiveRelaEN.PdfContent = objDT.Rows[0][convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTTopicObjectiveRelaEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.OkCount = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.CreateDate = objDT.Rows[0][convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ShareId = objDT.Rows[0][convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTTopicObjectiveRelaEN.ClassificationId = objDT.Rows[0][convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetvRTTopicObjectiveRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTTopicObjectiveRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
 objvRTTopicObjectiveRelaEN.mId = Int32.Parse(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objvRTTopicObjectiveRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id(字段类型:char,字段长度:10,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetObjBymId)", objException.Message));
}
return objvRTTopicObjectiveRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTTopicObjectiveRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
strSQL = "Select * from vRTTopicObjectiveRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN()
{
mId = TransNullToInt(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()), //mId
TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(), //主题Id
TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(), //客观Id
UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(), //修改人
ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(), //ObjectiveTypeName
ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(), //客观类型
SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(), //来源Id
IsSubmit = TransNullToBool(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()), //是否提交
ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(), //客观内容
Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(), //结论
TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(), //主题内容
TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(), //栏目主题
AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()), //评论数
CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()), //引用统计
Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()), //评分
StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()), //教师评分
ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(), //ObjDate
ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(), //ObjUserId
IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()), //Pdf页码
OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(), //分享Id
ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim() //分类Id
};
objvRTTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTTopicObjectiveRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTTopicObjectiveRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetObjByDataRowvRTTopicObjectiveRela)", objException.Message));
}
objvRTTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTTopicObjectiveRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTTopicObjectiveRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN = new clsvRTTopicObjectiveRelaEN();
try
{
objvRTTopicObjectiveRelaEN.mId = TransNullToInt(objRow[convRTTopicObjectiveRela.mId].ToString().Trim()); //mId
objvRTTopicObjectiveRelaEN.TopicId = objRow[convRTTopicObjectiveRela.TopicId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicId].ToString().Trim(); //主题Id
objvRTTopicObjectiveRelaEN.TopicObjectiveId = objRow[convRTTopicObjectiveRela.TopicObjectiveId].ToString().Trim(); //客观Id
objvRTTopicObjectiveRelaEN.UpdDate = objRow[convRTTopicObjectiveRela.UpdDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.UpdDate].ToString().Trim(); //修改日期
objvRTTopicObjectiveRelaEN.UpdUser = objRow[convRTTopicObjectiveRela.UpdUser].ToString().Trim(); //修改人
objvRTTopicObjectiveRelaEN.ObjectiveTypeName = objRow[convRTTopicObjectiveRela.ObjectiveTypeName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvRTTopicObjectiveRelaEN.ObjectiveType = objRow[convRTTopicObjectiveRela.ObjectiveType] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveType].ToString().Trim(); //客观类型
objvRTTopicObjectiveRelaEN.SourceId = objRow[convRTTopicObjectiveRela.SourceId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.SourceId].ToString().Trim(); //来源Id
objvRTTopicObjectiveRelaEN.IsSubmit = TransNullToBool(objRow[convRTTopicObjectiveRela.IsSubmit].ToString().Trim()); //是否提交
objvRTTopicObjectiveRelaEN.ObjectiveName = objRow[convRTTopicObjectiveRela.ObjectiveName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveName].ToString().Trim(); //客观名称
objvRTTopicObjectiveRelaEN.ObjectiveContent = objRow[convRTTopicObjectiveRela.ObjectiveContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjectiveContent].ToString().Trim(); //客观内容
objvRTTopicObjectiveRelaEN.Conclusion = objRow[convRTTopicObjectiveRela.Conclusion] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.Conclusion].ToString().Trim(); //结论
objvRTTopicObjectiveRelaEN.TopicContent = objRow[convRTTopicObjectiveRela.TopicContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicContent].ToString().Trim(); //主题内容
objvRTTopicObjectiveRelaEN.TopicName = objRow[convRTTopicObjectiveRela.TopicName] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.TopicName].ToString().Trim(); //栏目主题
objvRTTopicObjectiveRelaEN.AppraiseCount = objRow[convRTTopicObjectiveRela.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.AppraiseCount].ToString().Trim()); //评论数
objvRTTopicObjectiveRelaEN.CitationCount = objRow[convRTTopicObjectiveRela.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.CitationCount].ToString().Trim()); //引用统计
objvRTTopicObjectiveRelaEN.Score = objRow[convRTTopicObjectiveRela.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.Score].ToString().Trim()); //评分
objvRTTopicObjectiveRelaEN.StuScore = objRow[convRTTopicObjectiveRela.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.StuScore].ToString().Trim()); //学生平均分
objvRTTopicObjectiveRelaEN.TeaScore = objRow[convRTTopicObjectiveRela.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTTopicObjectiveRela.TeaScore].ToString().Trim()); //教师评分
objvRTTopicObjectiveRelaEN.ObjDate = objRow[convRTTopicObjectiveRela.ObjDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjDate].ToString().Trim(); //ObjDate
objvRTTopicObjectiveRelaEN.ObjUserId = objRow[convRTTopicObjectiveRela.ObjUserId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ObjUserId].ToString().Trim(); //ObjUserId
objvRTTopicObjectiveRelaEN.IdCurrEduCls = objRow[convRTTopicObjectiveRela.IdCurrEduCls] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTTopicObjectiveRelaEN.PdfContent = objRow[convRTTopicObjectiveRela.PdfContent] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.PdfContent].ToString().Trim(); //Pdf内容
objvRTTopicObjectiveRelaEN.PdfPageNum = objRow[convRTTopicObjectiveRela.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.PdfPageNum].ToString().Trim()); //Pdf页码
objvRTTopicObjectiveRelaEN.OkCount = objRow[convRTTopicObjectiveRela.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.OkCount].ToString().Trim()); //点赞统计
objvRTTopicObjectiveRelaEN.VersionCount = objRow[convRTTopicObjectiveRela.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTTopicObjectiveRela.VersionCount].ToString().Trim()); //版本统计
objvRTTopicObjectiveRelaEN.CreateDate = objRow[convRTTopicObjectiveRela.CreateDate] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.CreateDate].ToString().Trim(); //建立日期
objvRTTopicObjectiveRelaEN.ShareId = objRow[convRTTopicObjectiveRela.ShareId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ShareId].ToString().Trim(); //分享Id
objvRTTopicObjectiveRelaEN.ClassificationId = objRow[convRTTopicObjectiveRela.ClassificationId] == DBNull.Value ? null : objRow[convRTTopicObjectiveRela.ClassificationId].ToString().Trim(); //分类Id
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTTopicObjectiveRelaDA: GetObjByDataRow)", objException.Message));
}
objvRTTopicObjectiveRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTTopicObjectiveRelaEN;
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
objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTTopicObjectiveRelaEN._CurrTabName, convRTTopicObjectiveRela.mId, 8, "");
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
objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTTopicObjectiveRelaEN._CurrTabName, convRTTopicObjectiveRela.mId, 8, strPrefix);
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vRTTopicObjectiveRela where " + strCondition;
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vRTTopicObjectiveRela where " + strCondition;
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTTopicObjectiveRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTTopicObjectiveRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTTopicObjectiveRela", strCondition))
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
objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTTopicObjectiveRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTTopicObjectiveRelaENS">源对象</param>
 /// <param name = "objvRTTopicObjectiveRelaENT">目标对象</param>
public void CopyTo(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENS, clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaENT)
{
objvRTTopicObjectiveRelaENT.mId = objvRTTopicObjectiveRelaENS.mId; //mId
objvRTTopicObjectiveRelaENT.TopicId = objvRTTopicObjectiveRelaENS.TopicId; //主题Id
objvRTTopicObjectiveRelaENT.TopicObjectiveId = objvRTTopicObjectiveRelaENS.TopicObjectiveId; //客观Id
objvRTTopicObjectiveRelaENT.UpdDate = objvRTTopicObjectiveRelaENS.UpdDate; //修改日期
objvRTTopicObjectiveRelaENT.UpdUser = objvRTTopicObjectiveRelaENS.UpdUser; //修改人
objvRTTopicObjectiveRelaENT.ObjectiveTypeName = objvRTTopicObjectiveRelaENS.ObjectiveTypeName; //ObjectiveTypeName
objvRTTopicObjectiveRelaENT.ObjectiveType = objvRTTopicObjectiveRelaENS.ObjectiveType; //客观类型
objvRTTopicObjectiveRelaENT.SourceId = objvRTTopicObjectiveRelaENS.SourceId; //来源Id
objvRTTopicObjectiveRelaENT.IsSubmit = objvRTTopicObjectiveRelaENS.IsSubmit; //是否提交
objvRTTopicObjectiveRelaENT.ObjectiveName = objvRTTopicObjectiveRelaENS.ObjectiveName; //客观名称
objvRTTopicObjectiveRelaENT.ObjectiveContent = objvRTTopicObjectiveRelaENS.ObjectiveContent; //客观内容
objvRTTopicObjectiveRelaENT.Conclusion = objvRTTopicObjectiveRelaENS.Conclusion; //结论
objvRTTopicObjectiveRelaENT.TopicContent = objvRTTopicObjectiveRelaENS.TopicContent; //主题内容
objvRTTopicObjectiveRelaENT.TopicName = objvRTTopicObjectiveRelaENS.TopicName; //栏目主题
objvRTTopicObjectiveRelaENT.AppraiseCount = objvRTTopicObjectiveRelaENS.AppraiseCount; //评论数
objvRTTopicObjectiveRelaENT.CitationCount = objvRTTopicObjectiveRelaENS.CitationCount; //引用统计
objvRTTopicObjectiveRelaENT.Score = objvRTTopicObjectiveRelaENS.Score; //评分
objvRTTopicObjectiveRelaENT.StuScore = objvRTTopicObjectiveRelaENS.StuScore; //学生平均分
objvRTTopicObjectiveRelaENT.TeaScore = objvRTTopicObjectiveRelaENS.TeaScore; //教师评分
objvRTTopicObjectiveRelaENT.ObjDate = objvRTTopicObjectiveRelaENS.ObjDate; //ObjDate
objvRTTopicObjectiveRelaENT.ObjUserId = objvRTTopicObjectiveRelaENS.ObjUserId; //ObjUserId
objvRTTopicObjectiveRelaENT.IdCurrEduCls = objvRTTopicObjectiveRelaENS.IdCurrEduCls; //教学班流水号
objvRTTopicObjectiveRelaENT.PdfContent = objvRTTopicObjectiveRelaENS.PdfContent; //Pdf内容
objvRTTopicObjectiveRelaENT.PdfPageNum = objvRTTopicObjectiveRelaENS.PdfPageNum; //Pdf页码
objvRTTopicObjectiveRelaENT.OkCount = objvRTTopicObjectiveRelaENS.OkCount; //点赞统计
objvRTTopicObjectiveRelaENT.VersionCount = objvRTTopicObjectiveRelaENS.VersionCount; //版本统计
objvRTTopicObjectiveRelaENT.CreateDate = objvRTTopicObjectiveRelaENS.CreateDate; //建立日期
objvRTTopicObjectiveRelaENT.ShareId = objvRTTopicObjectiveRelaENS.ShareId; //分享Id
objvRTTopicObjectiveRelaENT.ClassificationId = objvRTTopicObjectiveRelaENS.ClassificationId; //分类Id
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTTopicObjectiveRelaEN objvRTTopicObjectiveRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.TopicId, 8, convRTTopicObjectiveRela.TopicId);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.TopicObjectiveId, 8, convRTTopicObjectiveRela.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.UpdDate, 20, convRTTopicObjectiveRela.UpdDate);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.UpdUser, 20, convRTTopicObjectiveRela.UpdUser);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ObjectiveTypeName, 8, convRTTopicObjectiveRela.ObjectiveTypeName);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ObjectiveType, 2, convRTTopicObjectiveRela.ObjectiveType);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.SourceId, 10, convRTTopicObjectiveRela.SourceId);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ObjectiveName, 500, convRTTopicObjectiveRela.ObjectiveName);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.TopicName, 200, convRTTopicObjectiveRela.TopicName);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ObjDate, 20, convRTTopicObjectiveRela.ObjDate);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ObjUserId, 50, convRTTopicObjectiveRela.ObjUserId);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.IdCurrEduCls, 8, convRTTopicObjectiveRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.PdfContent, 2000, convRTTopicObjectiveRela.PdfContent);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.CreateDate, 20, convRTTopicObjectiveRela.CreateDate);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ShareId, 2, convRTTopicObjectiveRela.ShareId);
clsCheckSql.CheckFieldLen(objvRTTopicObjectiveRelaEN.ClassificationId, 10, convRTTopicObjectiveRela.ClassificationId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.TopicId, convRTTopicObjectiveRela.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.TopicObjectiveId, convRTTopicObjectiveRela.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.UpdDate, convRTTopicObjectiveRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.UpdUser, convRTTopicObjectiveRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ObjectiveTypeName, convRTTopicObjectiveRela.ObjectiveTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ObjectiveType, convRTTopicObjectiveRela.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.SourceId, convRTTopicObjectiveRela.SourceId);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ObjectiveName, convRTTopicObjectiveRela.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.TopicName, convRTTopicObjectiveRela.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ObjDate, convRTTopicObjectiveRela.ObjDate);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ObjUserId, convRTTopicObjectiveRela.ObjUserId);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.IdCurrEduCls, convRTTopicObjectiveRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.PdfContent, convRTTopicObjectiveRela.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.CreateDate, convRTTopicObjectiveRela.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ShareId, convRTTopicObjectiveRela.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTTopicObjectiveRelaEN.ClassificationId, convRTTopicObjectiveRela.ClassificationId);
//检查外键字段长度
 objvRTTopicObjectiveRelaEN._IsCheckProperty = true;
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTTopicObjectiveRelaEN._CurrTabName);
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTTopicObjectiveRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvRTTopicObjectiveRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}