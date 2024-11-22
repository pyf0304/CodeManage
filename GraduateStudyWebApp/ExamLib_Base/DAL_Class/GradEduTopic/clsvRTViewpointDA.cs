
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvRTViewpointDA
 表名:vRTViewpoint(01120956)
 * 版本:2024.03.11.1(服务器:WIN-SRV103-116)
 日期:2024/03/19 02:42:20
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
 /// vRTViewpoint(vRTViewpoint)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvRTViewpointDA : clsCommBase4DA
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
 return clsvRTViewpointEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvRTViewpointEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvRTViewpointEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvRTViewpointEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvRTViewpointEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTopicId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTopicId)
{
strTopicId = strTopicId.Replace("'", "''");
if (strTopicId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vRTViewpoint中,检查关键字,长度不正确!(clsvRTViewpointDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTopicId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vRTViewpoint中,关键字不能为空 或 null!(clsvRTViewpointDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvRTViewpointDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vRTViewpoint(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable_vRTViewpoint)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTViewpoint.* from vRTViewpoint Left Join {1} on {2} where {3} and vRTViewpoint.TopicId not in (Select top {5} vRTViewpoint.TopicId from vRTViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1} and TopicId not in (Select top {2} TopicId from vRTViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1} and TopicId not in (Select top {3} TopicId from vRTViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvRTViewpointDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vRTViewpoint.* from vRTViewpoint Left Join {1} on {2} where {3} and vRTViewpoint.TopicId not in (Select top {5} vRTViewpoint.TopicId from vRTViewpoint Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1} and TopicId not in (Select top {2} TopicId from vRTViewpoint where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vRTViewpoint where {1} and TopicId not in (Select top {3} TopicId from vRTViewpoint where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvRTViewpointEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvRTViewpointDA:GetObjLst)", objException.Message));
}
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = TransNullToBool(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = TransNullToBool(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = TransNullToBool(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTViewpointDA: GetObjLst)", objException.Message));
}
objvRTViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTViewpointEN);
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
public List<clsvRTViewpointEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvRTViewpointDA:GetObjLstByTabName)", objException.Message));
}
List<clsvRTViewpointEN> arrObjLst = new List<clsvRTViewpointEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = TransNullToBool(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = TransNullToBool(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = TransNullToBool(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvRTViewpointDA: GetObjLst)", objException.Message));
}
objvRTViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvRTViewpointEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvRTViewpointEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvRTViewpoint(ref clsvRTViewpointEN objvRTViewpointEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where TopicId = " + "'"+ objvRTViewpointEN.TopicId+"'" + " and SubViewpointId = " + ""+ objvRTViewpointEN.SubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvRTViewpointEN.TopicId = objDT.Rows[0][convRTViewpoint.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.SubViewpointId = TransNullToInt(objDT.Rows[0][convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTViewpointEN.TopicName = objDT.Rows[0][convRTViewpoint.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTViewpointEN.VersionCount = TransNullToInt(objDT.Rows[0][convRTViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.CitationCount = TransNullToInt(objDT.Rows[0][convRTViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.TopicContent = objDT.Rows[0][convRTViewpoint.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointEN.TopicProposePeople = objDT.Rows[0][convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.gsKnowledgeTypeName = objDT.Rows[0][convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTViewpointEN.LevelName = objDT.Rows[0][convRTViewpoint.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.OperationTypeName = objDT.Rows[0][convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTViewpointEN.SubViewpointContent = objDT.Rows[0][convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointEN.PaperId = objDT.Rows[0][convRTViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.PaperTitle = objDT.Rows[0][convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTViewpointEN.IsSubmit = TransNullToBool(objDT.Rows[0][convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointEN.SectionId = objDT.Rows[0][convRTViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.SectionName = objDT.Rows[0][convRTViewpoint.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTViewpointEN.SubViewpointTypeId = objDT.Rows[0][convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointEN.SubViewpointTypeName = objDT.Rows[0][convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ExplainTypeId = objDT.Rows[0][convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.ExplainTypeName = objDT.Rows[0][convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ExplainContent = objDT.Rows[0][convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.IsPublic = TransNullToBool(objDT.Rows[0][convRTViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointEN.LiteratureSourcesId = objDT.Rows[0][convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.OperationTypeId = objDT.Rows[0][convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTViewpointEN.LevelId = objDT.Rows[0][convRTViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.Conclusion = objDT.Rows[0][convRTViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.Nationality = objDT.Rows[0][convRTViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.Achievement = objDT.Rows[0][convRTViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.Major = objDT.Rows[0][convRTViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.WorkUnit = objDT.Rows[0][convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTViewpointEN.PageNumber = TransNullToInt(objDT.Rows[0][convRTViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.PdfContent = objDT.Rows[0][convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTViewpointEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.OkCount = TransNullToInt(objDT.Rows[0][convRTViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.Score = TransNullToFloat(objDT.Rows[0][convRTViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.StuScore = TransNullToFloat(objDT.Rows[0][convRTViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.TeaScore = TransNullToFloat(objDT.Rows[0][convRTViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.CreateDate = objDT.Rows[0][convRTViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.ShareId = objDT.Rows[0][convRTViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTViewpointEN.SubViewpointTypeOrderNum = TransNullToInt(objDT.Rows[0][convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.ProposePeople = objDT.Rows[0][convRTViewpoint.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.gsKnowledgeTypeId = objDT.Rows[0][convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.ClassificationId = TransNullToInt(objDT.Rows[0][convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvRTViewpointEN.IdCurrEduCls = objDT.Rows[0][convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointEN.UpdDate = objDT.Rows[0][convRTViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.UpdUser = objDT.Rows[0][convRTViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.Memo = objDT.Rows[0][convRTViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTViewpointEN.ViewPointUserId = objDT.Rows[0][convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ViewPointDate = objDT.Rows[0][convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.IsRecommend = TransNullToBool(objDT.Rows[0][convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvRTViewpointDA: GetvRTViewpoint)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTopicId">表关键字</param>
 /// <param name = "lngSubViewpointId">表关键字</param>
 /// <returns>表对象</returns>
public clsvRTViewpointEN GetObjByKeyLst(string strTopicId,long lngSubViewpointId)
{
CheckPrimaryKey(strTopicId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where TopicId = " + "'"+ strTopicId+"'" + " and SubViewpointId = " + ""+ lngSubViewpointId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
 objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题(字段类型:varchar,字段长度:200,是否可空:True)
 objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容(字段类型:varchar,字段长度:500,是否可空:True)
 objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvRTViewpointEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.IsPublic = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开(字段类型:bit,字段长度:1,是否可空:True)
 objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源(字段类型:char,字段长度:8,是否可空:True)
 objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就(字段类型:varchar,字段长度:5000,是否可空:True)
 objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位(字段类型:varchar,字段长度:100,是否可空:True)
 objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号(字段类型:int,字段长度:4,是否可空:True)
 objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvRTViewpointEN.IsRecommend = clsEntityBase2.TransNullToBool_S(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvRTViewpointDA: GetObjByKeyLst)", objException.Message));
}
return objvRTViewpointEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvRTViewpointEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvRTViewpointDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
strSQL = "Select * from vRTViewpoint where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN()
{
TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(), //主题Id
SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()), //子观点Id
TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(), //栏目主题
VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.VersionCount].ToString().Trim()), //版本统计
CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.CitationCount].ToString().Trim()), //引用统计
TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(), //主题内容
TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(), //主题提出人
gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(), //知识类型名
LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(), //级别名称
OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(), //操作类型名
SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(), //详情内容
PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(), //论文标题
IsSubmit = TransNullToBool(objRow[convRTViewpoint.IsSubmit].ToString().Trim()), //是否提交
SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(), //节Id
SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(), //节名
SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(), //类型Id
SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(), //类型名称
ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(), //说明类型Id
ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(), //说明类型名
ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(), //说明内容
IsPublic = TransNullToBool(objRow[convRTViewpoint.IsPublic].ToString().Trim()), //是否公开
LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(), //文献来源
OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(), //操作类型ID
LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(), //级别Id
Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(), //结论
Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(), //国籍
Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(), //成就
Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(), //专业
WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(), //工作单位
PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.PageNumber].ToString().Trim()), //页码
PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(), //Pdf内容
AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()), //评论数
OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.OkCount].ToString().Trim()), //点赞统计
Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.Score].ToString().Trim()), //评分
StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.TeaScore].ToString().Trim()), //教师评分
CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(), //分享Id
SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()), //子观点类型序号
ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(), //提出人
gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(), //知识类型Id
ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.ClassificationId].ToString().Trim()), //分类Id
IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(), //教学班流水号
UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(), //备注
ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(), //观点用户Id
ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(), //观点日期
IsRecommend = TransNullToBool(objRow[convRTViewpoint.IsRecommend].ToString().Trim()) //是否推荐
};
objvRTViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvRTViewpointDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvRTViewpointEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = TransNullToBool(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = TransNullToBool(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = TransNullToBool(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvRTViewpointDA: GetObjByDataRowvRTViewpoint)", objException.Message));
}
objvRTViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvRTViewpointEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvRTViewpointEN objvRTViewpointEN = new clsvRTViewpointEN();
try
{
objvRTViewpointEN.TopicId = objRow[convRTViewpoint.TopicId] == DBNull.Value ? null : objRow[convRTViewpoint.TopicId].ToString().Trim(); //主题Id
objvRTViewpointEN.SubViewpointId = objRow[convRTViewpoint.SubViewpointId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointId].ToString().Trim()); //子观点Id
objvRTViewpointEN.TopicName = objRow[convRTViewpoint.TopicName] == DBNull.Value ? null : objRow[convRTViewpoint.TopicName].ToString().Trim(); //栏目主题
objvRTViewpointEN.VersionCount = objRow[convRTViewpoint.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.VersionCount].ToString().Trim()); //版本统计
objvRTViewpointEN.CitationCount = objRow[convRTViewpoint.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.CitationCount].ToString().Trim()); //引用统计
objvRTViewpointEN.TopicContent = objRow[convRTViewpoint.TopicContent] == DBNull.Value ? null : objRow[convRTViewpoint.TopicContent].ToString().Trim(); //主题内容
objvRTViewpointEN.TopicProposePeople = objRow[convRTViewpoint.TopicProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.TopicProposePeople].ToString().Trim(); //主题提出人
objvRTViewpointEN.gsKnowledgeTypeName = objRow[convRTViewpoint.gsKnowledgeTypeName].ToString().Trim(); //知识类型名
objvRTViewpointEN.LevelName = objRow[convRTViewpoint.LevelName] == DBNull.Value ? null : objRow[convRTViewpoint.LevelName].ToString().Trim(); //级别名称
objvRTViewpointEN.OperationTypeName = objRow[convRTViewpoint.OperationTypeName].ToString().Trim(); //操作类型名
objvRTViewpointEN.SubViewpointContent = objRow[convRTViewpoint.SubViewpointContent] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointContent].ToString().Trim(); //详情内容
objvRTViewpointEN.PaperId = objRow[convRTViewpoint.PaperId] == DBNull.Value ? null : objRow[convRTViewpoint.PaperId].ToString().Trim(); //论文Id
objvRTViewpointEN.PaperTitle = objRow[convRTViewpoint.PaperTitle].ToString().Trim(); //论文标题
objvRTViewpointEN.IsSubmit = TransNullToBool(objRow[convRTViewpoint.IsSubmit].ToString().Trim()); //是否提交
objvRTViewpointEN.SectionId = objRow[convRTViewpoint.SectionId] == DBNull.Value ? null : objRow[convRTViewpoint.SectionId].ToString().Trim(); //节Id
objvRTViewpointEN.SectionName = objRow[convRTViewpoint.SectionName] == DBNull.Value ? null : objRow[convRTViewpoint.SectionName].ToString().Trim(); //节名
objvRTViewpointEN.SubViewpointTypeId = objRow[convRTViewpoint.SubViewpointTypeId].ToString().Trim(); //类型Id
objvRTViewpointEN.SubViewpointTypeName = objRow[convRTViewpoint.SubViewpointTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.SubViewpointTypeName].ToString().Trim(); //类型名称
objvRTViewpointEN.ExplainTypeId = objRow[convRTViewpoint.ExplainTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeId].ToString().Trim(); //说明类型Id
objvRTViewpointEN.ExplainTypeName = objRow[convRTViewpoint.ExplainTypeName] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainTypeName].ToString().Trim(); //说明类型名
objvRTViewpointEN.ExplainContent = objRow[convRTViewpoint.ExplainContent] == DBNull.Value ? null : objRow[convRTViewpoint.ExplainContent].ToString().Trim(); //说明内容
objvRTViewpointEN.IsPublic = TransNullToBool(objRow[convRTViewpoint.IsPublic].ToString().Trim()); //是否公开
objvRTViewpointEN.LiteratureSourcesId = objRow[convRTViewpoint.LiteratureSourcesId] == DBNull.Value ? null : objRow[convRTViewpoint.LiteratureSourcesId].ToString().Trim(); //文献来源
objvRTViewpointEN.OperationTypeId = objRow[convRTViewpoint.OperationTypeId].ToString().Trim(); //操作类型ID
objvRTViewpointEN.LevelId = objRow[convRTViewpoint.LevelId] == DBNull.Value ? null : objRow[convRTViewpoint.LevelId].ToString().Trim(); //级别Id
objvRTViewpointEN.Conclusion = objRow[convRTViewpoint.Conclusion] == DBNull.Value ? null : objRow[convRTViewpoint.Conclusion].ToString().Trim(); //结论
objvRTViewpointEN.Nationality = objRow[convRTViewpoint.Nationality] == DBNull.Value ? null : objRow[convRTViewpoint.Nationality].ToString().Trim(); //国籍
objvRTViewpointEN.Achievement = objRow[convRTViewpoint.Achievement] == DBNull.Value ? null : objRow[convRTViewpoint.Achievement].ToString().Trim(); //成就
objvRTViewpointEN.Major = objRow[convRTViewpoint.Major] == DBNull.Value ? null : objRow[convRTViewpoint.Major].ToString().Trim(); //专业
objvRTViewpointEN.WorkUnit = objRow[convRTViewpoint.WorkUnit] == DBNull.Value ? null : objRow[convRTViewpoint.WorkUnit].ToString().Trim(); //工作单位
objvRTViewpointEN.PageNumber = objRow[convRTViewpoint.PageNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.PageNumber].ToString().Trim()); //页码
objvRTViewpointEN.PdfContent = objRow[convRTViewpoint.PdfContent] == DBNull.Value ? null : objRow[convRTViewpoint.PdfContent].ToString().Trim(); //Pdf内容
objvRTViewpointEN.AppraiseCount = objRow[convRTViewpoint.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.AppraiseCount].ToString().Trim()); //评论数
objvRTViewpointEN.OkCount = objRow[convRTViewpoint.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.OkCount].ToString().Trim()); //点赞统计
objvRTViewpointEN.Score = objRow[convRTViewpoint.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.Score].ToString().Trim()); //评分
objvRTViewpointEN.StuScore = objRow[convRTViewpoint.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.StuScore].ToString().Trim()); //学生平均分
objvRTViewpointEN.TeaScore = objRow[convRTViewpoint.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convRTViewpoint.TeaScore].ToString().Trim()); //教师评分
objvRTViewpointEN.CreateDate = objRow[convRTViewpoint.CreateDate] == DBNull.Value ? null : objRow[convRTViewpoint.CreateDate].ToString().Trim(); //建立日期
objvRTViewpointEN.ShareId = objRow[convRTViewpoint.ShareId].ToString().Trim(); //分享Id
objvRTViewpointEN.SubViewpointTypeOrderNum = objRow[convRTViewpoint.SubViewpointTypeOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convRTViewpoint.SubViewpointTypeOrderNum].ToString().Trim()); //子观点类型序号
objvRTViewpointEN.ProposePeople = objRow[convRTViewpoint.ProposePeople] == DBNull.Value ? null : objRow[convRTViewpoint.ProposePeople].ToString().Trim(); //提出人
objvRTViewpointEN.gsKnowledgeTypeId = objRow[convRTViewpoint.gsKnowledgeTypeId] == DBNull.Value ? null : objRow[convRTViewpoint.gsKnowledgeTypeId].ToString().Trim(); //知识类型Id
objvRTViewpointEN.ClassificationId = objRow[convRTViewpoint.ClassificationId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convRTViewpoint.ClassificationId].ToString().Trim()); //分类Id
objvRTViewpointEN.IdCurrEduCls = objRow[convRTViewpoint.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvRTViewpointEN.UpdDate = objRow[convRTViewpoint.UpdDate] == DBNull.Value ? null : objRow[convRTViewpoint.UpdDate].ToString().Trim(); //修改日期
objvRTViewpointEN.UpdUser = objRow[convRTViewpoint.UpdUser] == DBNull.Value ? null : objRow[convRTViewpoint.UpdUser].ToString().Trim(); //修改人
objvRTViewpointEN.Memo = objRow[convRTViewpoint.Memo] == DBNull.Value ? null : objRow[convRTViewpoint.Memo].ToString().Trim(); //备注
objvRTViewpointEN.ViewPointUserId = objRow[convRTViewpoint.ViewPointUserId] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointUserId].ToString().Trim(); //观点用户Id
objvRTViewpointEN.ViewPointDate = objRow[convRTViewpoint.ViewPointDate] == DBNull.Value ? null : objRow[convRTViewpoint.ViewPointDate].ToString().Trim(); //观点日期
objvRTViewpointEN.IsRecommend = TransNullToBool(objRow[convRTViewpoint.IsRecommend].ToString().Trim()); //是否推荐
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvRTViewpointDA: GetObjByDataRow)", objException.Message));
}
objvRTViewpointEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvRTViewpointEN;
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
objSQL = clsvRTViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTViewpointEN._CurrTabName, convRTViewpoint.TopicId, 8, "");
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
objSQL = clsvRTViewpointDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvRTViewpointEN._CurrTabName, convRTViewpoint.TopicId, 8, strPrefix);
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicId,SubViewpointId from vRTViewpoint where " + strCondition;
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicId,SubViewpointId from vRTViewpoint where " + strCondition;
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
 /// <param name = "strTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTopicId, long lngSubViewpointId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTViewpoint", "TopicId = " + "'"+ strTopicId+"'" + " and SubViewpointId = " + ""+ lngSubViewpointId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvRTViewpointDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vRTViewpoint", strCondition))
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
objSQL = clsvRTViewpointDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vRTViewpoint");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvRTViewpointENS">源对象</param>
 /// <param name = "objvRTViewpointENT">目标对象</param>
public void CopyTo(clsvRTViewpointEN objvRTViewpointENS, clsvRTViewpointEN objvRTViewpointENT)
{
objvRTViewpointENT.TopicId = objvRTViewpointENS.TopicId; //主题Id
objvRTViewpointENT.SubViewpointId = objvRTViewpointENS.SubViewpointId; //子观点Id
objvRTViewpointENT.TopicName = objvRTViewpointENS.TopicName; //栏目主题
objvRTViewpointENT.VersionCount = objvRTViewpointENS.VersionCount; //版本统计
objvRTViewpointENT.CitationCount = objvRTViewpointENS.CitationCount; //引用统计
objvRTViewpointENT.TopicContent = objvRTViewpointENS.TopicContent; //主题内容
objvRTViewpointENT.TopicProposePeople = objvRTViewpointENS.TopicProposePeople; //主题提出人
objvRTViewpointENT.gsKnowledgeTypeName = objvRTViewpointENS.gsKnowledgeTypeName; //知识类型名
objvRTViewpointENT.LevelName = objvRTViewpointENS.LevelName; //级别名称
objvRTViewpointENT.OperationTypeName = objvRTViewpointENS.OperationTypeName; //操作类型名
objvRTViewpointENT.SubViewpointContent = objvRTViewpointENS.SubViewpointContent; //详情内容
objvRTViewpointENT.PaperId = objvRTViewpointENS.PaperId; //论文Id
objvRTViewpointENT.PaperTitle = objvRTViewpointENS.PaperTitle; //论文标题
objvRTViewpointENT.IsSubmit = objvRTViewpointENS.IsSubmit; //是否提交
objvRTViewpointENT.SectionId = objvRTViewpointENS.SectionId; //节Id
objvRTViewpointENT.SectionName = objvRTViewpointENS.SectionName; //节名
objvRTViewpointENT.SubViewpointTypeId = objvRTViewpointENS.SubViewpointTypeId; //类型Id
objvRTViewpointENT.SubViewpointTypeName = objvRTViewpointENS.SubViewpointTypeName; //类型名称
objvRTViewpointENT.ExplainTypeId = objvRTViewpointENS.ExplainTypeId; //说明类型Id
objvRTViewpointENT.ExplainTypeName = objvRTViewpointENS.ExplainTypeName; //说明类型名
objvRTViewpointENT.ExplainContent = objvRTViewpointENS.ExplainContent; //说明内容
objvRTViewpointENT.IsPublic = objvRTViewpointENS.IsPublic; //是否公开
objvRTViewpointENT.LiteratureSourcesId = objvRTViewpointENS.LiteratureSourcesId; //文献来源
objvRTViewpointENT.OperationTypeId = objvRTViewpointENS.OperationTypeId; //操作类型ID
objvRTViewpointENT.LevelId = objvRTViewpointENS.LevelId; //级别Id
objvRTViewpointENT.Conclusion = objvRTViewpointENS.Conclusion; //结论
objvRTViewpointENT.Nationality = objvRTViewpointENS.Nationality; //国籍
objvRTViewpointENT.Achievement = objvRTViewpointENS.Achievement; //成就
objvRTViewpointENT.Major = objvRTViewpointENS.Major; //专业
objvRTViewpointENT.WorkUnit = objvRTViewpointENS.WorkUnit; //工作单位
objvRTViewpointENT.PageNumber = objvRTViewpointENS.PageNumber; //页码
objvRTViewpointENT.PdfContent = objvRTViewpointENS.PdfContent; //Pdf内容
objvRTViewpointENT.AppraiseCount = objvRTViewpointENS.AppraiseCount; //评论数
objvRTViewpointENT.OkCount = objvRTViewpointENS.OkCount; //点赞统计
objvRTViewpointENT.Score = objvRTViewpointENS.Score; //评分
objvRTViewpointENT.StuScore = objvRTViewpointENS.StuScore; //学生平均分
objvRTViewpointENT.TeaScore = objvRTViewpointENS.TeaScore; //教师评分
objvRTViewpointENT.CreateDate = objvRTViewpointENS.CreateDate; //建立日期
objvRTViewpointENT.ShareId = objvRTViewpointENS.ShareId; //分享Id
objvRTViewpointENT.SubViewpointTypeOrderNum = objvRTViewpointENS.SubViewpointTypeOrderNum; //子观点类型序号
objvRTViewpointENT.ProposePeople = objvRTViewpointENS.ProposePeople; //提出人
objvRTViewpointENT.gsKnowledgeTypeId = objvRTViewpointENS.gsKnowledgeTypeId; //知识类型Id
objvRTViewpointENT.ClassificationId = objvRTViewpointENS.ClassificationId; //分类Id
objvRTViewpointENT.IdCurrEduCls = objvRTViewpointENS.IdCurrEduCls; //教学班流水号
objvRTViewpointENT.UpdDate = objvRTViewpointENS.UpdDate; //修改日期
objvRTViewpointENT.UpdUser = objvRTViewpointENS.UpdUser; //修改人
objvRTViewpointENT.Memo = objvRTViewpointENS.Memo; //备注
objvRTViewpointENT.ViewPointUserId = objvRTViewpointENS.ViewPointUserId; //观点用户Id
objvRTViewpointENT.ViewPointDate = objvRTViewpointENS.ViewPointDate; //观点日期
objvRTViewpointENT.IsRecommend = objvRTViewpointENS.IsRecommend; //是否推荐
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvRTViewpointEN objvRTViewpointEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvRTViewpointEN.TopicId, 8, convRTViewpoint.TopicId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.TopicName, 200, convRTViewpoint.TopicName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.TopicProposePeople, 50, convRTViewpoint.TopicProposePeople);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.gsKnowledgeTypeName, 50, convRTViewpoint.gsKnowledgeTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.LevelName, 50, convRTViewpoint.LevelName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.OperationTypeName, 50, convRTViewpoint.OperationTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.SubViewpointContent, 500, convRTViewpoint.SubViewpointContent);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.PaperId, 8, convRTViewpoint.PaperId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.PaperTitle, 500, convRTViewpoint.PaperTitle);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.SectionId, 8, convRTViewpoint.SectionId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.SectionName, 100, convRTViewpoint.SectionName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.SubViewpointTypeId, 8, convRTViewpoint.SubViewpointTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.SubViewpointTypeName, 50, convRTViewpoint.SubViewpointTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ExplainTypeId, 2, convRTViewpoint.ExplainTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ExplainTypeName, 50, convRTViewpoint.ExplainTypeName);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ExplainContent, 5000, convRTViewpoint.ExplainContent);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.LiteratureSourcesId, 8, convRTViewpoint.LiteratureSourcesId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.OperationTypeId, 4, convRTViewpoint.OperationTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.LevelId, 2, convRTViewpoint.LevelId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.Conclusion, 5000, convRTViewpoint.Conclusion);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.Nationality, 50, convRTViewpoint.Nationality);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.Achievement, 5000, convRTViewpoint.Achievement);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.Major, 50, convRTViewpoint.Major);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.WorkUnit, 100, convRTViewpoint.WorkUnit);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.PdfContent, 2000, convRTViewpoint.PdfContent);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.CreateDate, 20, convRTViewpoint.CreateDate);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ShareId, 2, convRTViewpoint.ShareId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ProposePeople, 50, convRTViewpoint.ProposePeople);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.gsKnowledgeTypeId, 2, convRTViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.IdCurrEduCls, 8, convRTViewpoint.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.UpdDate, 20, convRTViewpoint.UpdDate);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.UpdUser, 20, convRTViewpoint.UpdUser);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.Memo, 1000, convRTViewpoint.Memo);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ViewPointUserId, 50, convRTViewpoint.ViewPointUserId);
clsCheckSql.CheckFieldLen(objvRTViewpointEN.ViewPointDate, 20, convRTViewpoint.ViewPointDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.TopicId, convRTViewpoint.TopicId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.TopicName, convRTViewpoint.TopicName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.TopicProposePeople, convRTViewpoint.TopicProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.gsKnowledgeTypeName, convRTViewpoint.gsKnowledgeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.LevelName, convRTViewpoint.LevelName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.OperationTypeName, convRTViewpoint.OperationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.SubViewpointContent, convRTViewpoint.SubViewpointContent);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.PaperId, convRTViewpoint.PaperId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.PaperTitle, convRTViewpoint.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.SectionId, convRTViewpoint.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.SectionName, convRTViewpoint.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.SubViewpointTypeId, convRTViewpoint.SubViewpointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.SubViewpointTypeName, convRTViewpoint.SubViewpointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ExplainTypeId, convRTViewpoint.ExplainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ExplainTypeName, convRTViewpoint.ExplainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ExplainContent, convRTViewpoint.ExplainContent);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.LiteratureSourcesId, convRTViewpoint.LiteratureSourcesId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.OperationTypeId, convRTViewpoint.OperationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.LevelId, convRTViewpoint.LevelId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.Conclusion, convRTViewpoint.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.Nationality, convRTViewpoint.Nationality);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.Achievement, convRTViewpoint.Achievement);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.Major, convRTViewpoint.Major);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.WorkUnit, convRTViewpoint.WorkUnit);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.PdfContent, convRTViewpoint.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.CreateDate, convRTViewpoint.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ShareId, convRTViewpoint.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ProposePeople, convRTViewpoint.ProposePeople);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.gsKnowledgeTypeId, convRTViewpoint.gsKnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.IdCurrEduCls, convRTViewpoint.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.UpdDate, convRTViewpoint.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.UpdUser, convRTViewpoint.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.Memo, convRTViewpoint.Memo);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ViewPointUserId, convRTViewpoint.ViewPointUserId);
clsCheckSql.CheckSqlInjection4Field(objvRTViewpointEN.ViewPointDate, convRTViewpoint.ViewPointDate);
//检查外键字段长度
 objvRTViewpointEN._IsCheckProperty = true;
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTViewpointEN._CurrTabName);
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvRTViewpointEN._CurrTabName, strCondition);
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
 objSQL = clsvRTViewpointDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}