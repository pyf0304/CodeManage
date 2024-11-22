
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTopicObjectiveDA
 表名:vTopicObjective(01120617)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:22:06
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
 /// 客观表视图(vTopicObjective)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvTopicObjectiveDA : clsCommBase4DA
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
 return clsvTopicObjectiveEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvTopicObjectiveEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvTopicObjectiveEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvTopicObjectiveEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvTopicObjectiveEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTopicObjectiveId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTopicObjectiveId)
{
strTopicObjectiveId = strTopicObjectiveId.Replace("'", "''");
if (strTopicObjectiveId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vTopicObjective中,检查关键字,长度不正确!(clsvTopicObjectiveDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTopicObjectiveId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vTopicObjective中,关键字不能为空 或 null!(clsvTopicObjectiveDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTopicObjectiveId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvTopicObjectiveDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vTopicObjective(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable_vTopicObjective)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTopicObjective.* from vTopicObjective Left Join {1} on {2} where {3} and vTopicObjective.TopicObjectiveId not in (Select top {5} vTopicObjective.TopicObjectiveId from vTopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1} and TopicObjectiveId not in (Select top {2} TopicObjectiveId from vTopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1} and TopicObjectiveId not in (Select top {3} TopicObjectiveId from vTopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vTopicObjective.* from vTopicObjective Left Join {1} on {2} where {3} and vTopicObjective.TopicObjectiveId not in (Select top {5} vTopicObjective.TopicObjectiveId from vTopicObjective Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1} and TopicObjectiveId not in (Select top {2} TopicObjectiveId from vTopicObjective where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vTopicObjective where {1} and TopicObjectiveId not in (Select top {3} TopicObjectiveId from vTopicObjective where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvTopicObjectiveEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA:GetObjLst)", objException.Message));
}
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTopicObjectiveDA: GetObjLst)", objException.Message));
}
objvTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTopicObjectiveEN);
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
public List<clsvTopicObjectiveEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA:GetObjLstByTabName)", objException.Message));
}
List<clsvTopicObjectiveEN> arrObjLst = new List<clsvTopicObjectiveEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvTopicObjectiveDA: GetObjLst)", objException.Message));
}
objvTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvTopicObjectiveEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvTopicObjectiveEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvTopicObjective(ref clsvTopicObjectiveEN objvTopicObjectiveEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where TopicObjectiveId = " + "'"+ objvTopicObjectiveEN.TopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvTopicObjectiveEN.PaperTitle = objDT.Rows[0][convTopicObjective.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvTopicObjectiveEN.PaperContent = objDT.Rows[0][convTopicObjective.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTopicObjectiveEN.Author = objDT.Rows[0][convTopicObjective.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvTopicObjectiveEN.Keyword = objDT.Rows[0][convTopicObjective.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTopicObjectiveEN.TopicObjectiveId = objDT.Rows[0][convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvTopicObjectiveEN.ObjectiveName = objDT.Rows[0][convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTopicObjectiveEN.ObjectiveContent = objDT.Rows[0][convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTopicObjectiveEN.ObjectiveType = objDT.Rows[0][convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvTopicObjectiveEN.SourceId = objDT.Rows[0][convTopicObjective.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objvTopicObjectiveEN.Conclusion = objDT.Rows[0][convTopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTopicObjectiveEN.IsSubmit = TransNullToBool(objDT.Rows[0][convTopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvTopicObjectiveEN.UpdDate = objDT.Rows[0][convTopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTopicObjectiveEN.Memo = objDT.Rows[0][convTopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTopicObjectiveEN.ObjectiveTypeName = objDT.Rows[0][convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.CitationCount = TransNullToInt(objDT.Rows[0][convTopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.AppraiseCount = TransNullToInt(objDT.Rows[0][convTopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.Score = TransNullToFloat(objDT.Rows[0][convTopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.StuScore = TransNullToFloat(objDT.Rows[0][convTopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.TeaScore = TransNullToFloat(objDT.Rows[0][convTopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.IdCurrEduCls = objDT.Rows[0][convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTopicObjectiveEN.PdfContent = objDT.Rows[0][convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTopicObjectiveEN.PdfPageNum = TransNullToInt(objDT.Rows[0][convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.OkCount = TransNullToInt(objDT.Rows[0][convTopicObjective.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.VersionCount = TransNullToInt(objDT.Rows[0][convTopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.CreateDate = objDT.Rows[0][convTopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTopicObjectiveEN.ShareId = objDT.Rows[0][convTopicObjective.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvTopicObjectiveEN.UpdUser = objDT.Rows[0][convTopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvTopicObjectiveDA: GetvTopicObjective)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTopicObjectiveId">表关键字</param>
 /// <returns>表对象</returns>
public clsvTopicObjectiveEN GetObjByTopicObjectiveId(string strTopicObjectiveId)
{
CheckPrimaryKey(strTopicObjectiveId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
 objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者(字段类型:varchar,字段长度:200,是否可空:True)
 objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objvTopicObjectiveEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName(字段类型:varchar,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.Score].ToString().Trim()); //评分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分(字段类型:float,字段长度:8,是否可空:True)
 objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计(字段类型:int,字段长度:4,是否可空:True)
 objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id(字段类型:char,字段长度:2,是否可空:False)
 objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvTopicObjectiveDA: GetObjByTopicObjectiveId)", objException.Message));
}
return objvTopicObjectiveEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvTopicObjectiveEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
strSQL = "Select * from vTopicObjective where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN()
{
PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(), //论文标题
PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(), //主题内容
Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(), //作者
Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(), //关键字
TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(), //客观类型
SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(), //来源Id
Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(), //结论
IsSubmit = TransNullToBool(objRow[convTopicObjective.IsSubmit].ToString().Trim()), //是否提交
UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(), //备注
ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(), //ObjectiveTypeName
CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.CitationCount].ToString().Trim()), //引用统计
AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.AppraiseCount].ToString().Trim()), //评论数
Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.Score].ToString().Trim()), //评分
StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.StuScore].ToString().Trim()), //学生平均分
TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.TeaScore].ToString().Trim()), //教师评分
IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.PdfPageNum].ToString().Trim()), //Pdf页码
OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.OkCount].ToString().Trim()), //点赞统计
VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.VersionCount].ToString().Trim()), //版本统计
CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(), //建立日期
ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(), //分享Id
UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim() //修改人
};
objvTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTopicObjectiveEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvTopicObjectiveDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvTopicObjectiveEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvTopicObjectiveDA: GetObjByDataRowvTopicObjective)", objException.Message));
}
objvTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTopicObjectiveEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvTopicObjectiveEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvTopicObjectiveEN objvTopicObjectiveEN = new clsvTopicObjectiveEN();
try
{
objvTopicObjectiveEN.PaperTitle = objRow[convTopicObjective.PaperTitle] == DBNull.Value ? null : objRow[convTopicObjective.PaperTitle].ToString().Trim(); //论文标题
objvTopicObjectiveEN.PaperContent = objRow[convTopicObjective.PaperContent] == DBNull.Value ? null : objRow[convTopicObjective.PaperContent].ToString().Trim(); //主题内容
objvTopicObjectiveEN.Author = objRow[convTopicObjective.Author] == DBNull.Value ? null : objRow[convTopicObjective.Author].ToString().Trim(); //作者
objvTopicObjectiveEN.Keyword = objRow[convTopicObjective.Keyword] == DBNull.Value ? null : objRow[convTopicObjective.Keyword].ToString().Trim(); //关键字
objvTopicObjectiveEN.TopicObjectiveId = objRow[convTopicObjective.TopicObjectiveId].ToString().Trim(); //客观Id
objvTopicObjectiveEN.ObjectiveName = objRow[convTopicObjective.ObjectiveName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveName].ToString().Trim(); //客观名称
objvTopicObjectiveEN.ObjectiveContent = objRow[convTopicObjective.ObjectiveContent] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveContent].ToString().Trim(); //客观内容
objvTopicObjectiveEN.ObjectiveType = objRow[convTopicObjective.ObjectiveType] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveType].ToString().Trim(); //客观类型
objvTopicObjectiveEN.SourceId = objRow[convTopicObjective.SourceId] == DBNull.Value ? null : objRow[convTopicObjective.SourceId].ToString().Trim(); //来源Id
objvTopicObjectiveEN.Conclusion = objRow[convTopicObjective.Conclusion] == DBNull.Value ? null : objRow[convTopicObjective.Conclusion].ToString().Trim(); //结论
objvTopicObjectiveEN.IsSubmit = TransNullToBool(objRow[convTopicObjective.IsSubmit].ToString().Trim()); //是否提交
objvTopicObjectiveEN.UpdDate = objRow[convTopicObjective.UpdDate] == DBNull.Value ? null : objRow[convTopicObjective.UpdDate].ToString().Trim(); //修改日期
objvTopicObjectiveEN.Memo = objRow[convTopicObjective.Memo] == DBNull.Value ? null : objRow[convTopicObjective.Memo].ToString().Trim(); //备注
objvTopicObjectiveEN.ObjectiveTypeName = objRow[convTopicObjective.ObjectiveTypeName] == DBNull.Value ? null : objRow[convTopicObjective.ObjectiveTypeName].ToString().Trim(); //ObjectiveTypeName
objvTopicObjectiveEN.CitationCount = objRow[convTopicObjective.CitationCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.CitationCount].ToString().Trim()); //引用统计
objvTopicObjectiveEN.AppraiseCount = objRow[convTopicObjective.AppraiseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.AppraiseCount].ToString().Trim()); //评论数
objvTopicObjectiveEN.Score = objRow[convTopicObjective.Score] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.Score].ToString().Trim()); //评分
objvTopicObjectiveEN.StuScore = objRow[convTopicObjective.StuScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.StuScore].ToString().Trim()); //学生平均分
objvTopicObjectiveEN.TeaScore = objRow[convTopicObjective.TeaScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convTopicObjective.TeaScore].ToString().Trim()); //教师评分
objvTopicObjectiveEN.IdCurrEduCls = objRow[convTopicObjective.IdCurrEduCls] == DBNull.Value ? null : objRow[convTopicObjective.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvTopicObjectiveEN.PdfContent = objRow[convTopicObjective.PdfContent] == DBNull.Value ? null : objRow[convTopicObjective.PdfContent].ToString().Trim(); //Pdf内容
objvTopicObjectiveEN.PdfPageNum = objRow[convTopicObjective.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.PdfPageNum].ToString().Trim()); //Pdf页码
objvTopicObjectiveEN.OkCount = objRow[convTopicObjective.OkCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.OkCount].ToString().Trim()); //点赞统计
objvTopicObjectiveEN.VersionCount = objRow[convTopicObjective.VersionCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convTopicObjective.VersionCount].ToString().Trim()); //版本统计
objvTopicObjectiveEN.CreateDate = objRow[convTopicObjective.CreateDate] == DBNull.Value ? null : objRow[convTopicObjective.CreateDate].ToString().Trim(); //建立日期
objvTopicObjectiveEN.ShareId = objRow[convTopicObjective.ShareId] == DBNull.Value ? null : objRow[convTopicObjective.ShareId].ToString().Trim(); //分享Id
objvTopicObjectiveEN.UpdUser = objRow[convTopicObjective.UpdUser] == DBNull.Value ? null : objRow[convTopicObjective.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvTopicObjectiveDA: GetObjByDataRow)", objException.Message));
}
objvTopicObjectiveEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvTopicObjectiveEN;
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
objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTopicObjectiveEN._CurrTabName, convTopicObjective.TopicObjectiveId, 8, "");
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
objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvTopicObjectiveEN._CurrTabName, convTopicObjective.TopicObjectiveId, 8, strPrefix);
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicObjectiveId from vTopicObjective where " + strCondition;
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicObjectiveId from vTopicObjective where " + strCondition;
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
 /// <param name = "strTopicObjectiveId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTopicObjectiveId)
{
CheckPrimaryKey(strTopicObjectiveId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTopicObjective", "TopicObjectiveId = " + "'"+ strTopicObjectiveId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvTopicObjectiveDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vTopicObjective", strCondition))
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
objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vTopicObjective");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvTopicObjectiveENS">源对象</param>
 /// <param name = "objvTopicObjectiveENT">目标对象</param>
public void CopyTo(clsvTopicObjectiveEN objvTopicObjectiveENS, clsvTopicObjectiveEN objvTopicObjectiveENT)
{
objvTopicObjectiveENT.PaperTitle = objvTopicObjectiveENS.PaperTitle; //论文标题
objvTopicObjectiveENT.PaperContent = objvTopicObjectiveENS.PaperContent; //主题内容
objvTopicObjectiveENT.Author = objvTopicObjectiveENS.Author; //作者
objvTopicObjectiveENT.Keyword = objvTopicObjectiveENS.Keyword; //关键字
objvTopicObjectiveENT.TopicObjectiveId = objvTopicObjectiveENS.TopicObjectiveId; //客观Id
objvTopicObjectiveENT.ObjectiveName = objvTopicObjectiveENS.ObjectiveName; //客观名称
objvTopicObjectiveENT.ObjectiveContent = objvTopicObjectiveENS.ObjectiveContent; //客观内容
objvTopicObjectiveENT.ObjectiveType = objvTopicObjectiveENS.ObjectiveType; //客观类型
objvTopicObjectiveENT.SourceId = objvTopicObjectiveENS.SourceId; //来源Id
objvTopicObjectiveENT.Conclusion = objvTopicObjectiveENS.Conclusion; //结论
objvTopicObjectiveENT.IsSubmit = objvTopicObjectiveENS.IsSubmit; //是否提交
objvTopicObjectiveENT.UpdDate = objvTopicObjectiveENS.UpdDate; //修改日期
objvTopicObjectiveENT.Memo = objvTopicObjectiveENS.Memo; //备注
objvTopicObjectiveENT.ObjectiveTypeName = objvTopicObjectiveENS.ObjectiveTypeName; //ObjectiveTypeName
objvTopicObjectiveENT.CitationCount = objvTopicObjectiveENS.CitationCount; //引用统计
objvTopicObjectiveENT.AppraiseCount = objvTopicObjectiveENS.AppraiseCount; //评论数
objvTopicObjectiveENT.Score = objvTopicObjectiveENS.Score; //评分
objvTopicObjectiveENT.StuScore = objvTopicObjectiveENS.StuScore; //学生平均分
objvTopicObjectiveENT.TeaScore = objvTopicObjectiveENS.TeaScore; //教师评分
objvTopicObjectiveENT.IdCurrEduCls = objvTopicObjectiveENS.IdCurrEduCls; //教学班流水号
objvTopicObjectiveENT.PdfContent = objvTopicObjectiveENS.PdfContent; //Pdf内容
objvTopicObjectiveENT.PdfPageNum = objvTopicObjectiveENS.PdfPageNum; //Pdf页码
objvTopicObjectiveENT.OkCount = objvTopicObjectiveENS.OkCount; //点赞统计
objvTopicObjectiveENT.VersionCount = objvTopicObjectiveENS.VersionCount; //版本统计
objvTopicObjectiveENT.CreateDate = objvTopicObjectiveENS.CreateDate; //建立日期
objvTopicObjectiveENT.ShareId = objvTopicObjectiveENS.ShareId; //分享Id
objvTopicObjectiveENT.UpdUser = objvTopicObjectiveENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvTopicObjectiveEN objvTopicObjectiveEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.PaperTitle, 500, convTopicObjective.PaperTitle);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.Author, 200, convTopicObjective.Author);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.Keyword, 1000, convTopicObjective.Keyword);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.TopicObjectiveId, 8, convTopicObjective.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.ObjectiveName, 500, convTopicObjective.ObjectiveName);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.ObjectiveType, 2, convTopicObjective.ObjectiveType);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.SourceId, 10, convTopicObjective.SourceId);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.Conclusion, 5000, convTopicObjective.Conclusion);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.UpdDate, 20, convTopicObjective.UpdDate);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.Memo, 1000, convTopicObjective.Memo);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.ObjectiveTypeName, 8, convTopicObjective.ObjectiveTypeName);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.IdCurrEduCls, 8, convTopicObjective.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.PdfContent, 2000, convTopicObjective.PdfContent);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.CreateDate, 20, convTopicObjective.CreateDate);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.ShareId, 2, convTopicObjective.ShareId);
clsCheckSql.CheckFieldLen(objvTopicObjectiveEN.UpdUser, 20, convTopicObjective.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.PaperTitle, convTopicObjective.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.Author, convTopicObjective.Author);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.Keyword, convTopicObjective.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.TopicObjectiveId, convTopicObjective.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.ObjectiveName, convTopicObjective.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.ObjectiveType, convTopicObjective.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.SourceId, convTopicObjective.SourceId);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.Conclusion, convTopicObjective.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.UpdDate, convTopicObjective.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.Memo, convTopicObjective.Memo);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.ObjectiveTypeName, convTopicObjective.ObjectiveTypeName);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.IdCurrEduCls, convTopicObjective.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.PdfContent, convTopicObjective.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.CreateDate, convTopicObjective.CreateDate);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.ShareId, convTopicObjective.ShareId);
clsCheckSql.CheckSqlInjection4Field(objvTopicObjectiveEN.UpdUser, convTopicObjective.UpdUser);
//检查外键字段长度
 objvTopicObjectiveEN._IsCheckProperty = true;
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTopicObjectiveEN._CurrTabName);
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvTopicObjectiveEN._CurrTabName, strCondition);
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
 objSQL = clsvTopicObjectiveDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}