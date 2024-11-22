
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTopicObjectiveVerDA
 表名:TopicObjectiveVer(01120648)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:15:25
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
 /// 主题客观版本(TopicObjectiveVer)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTopicObjectiveVerDA : clsCommBase4DA
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
 return clsTopicObjectiveVerEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTopicObjectiveVerEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTopicObjectiveVerEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTopicObjectiveVerEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTopicObjectiveVerEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TopicObjectiveVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable_TopicObjectiveVer)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TopicObjectiveVer.* from TopicObjectiveVer Left Join {1} on {2} where {3} and TopicObjectiveVer.TopicObjectiveVId not in (Select top {5} TopicObjectiveVer.TopicObjectiveVId from TopicObjectiveVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {2} TopicObjectiveVId from TopicObjectiveVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {3} TopicObjectiveVId from TopicObjectiveVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} TopicObjectiveVer.* from TopicObjectiveVer Left Join {1} on {2} where {3} and TopicObjectiveVer.TopicObjectiveVId not in (Select top {5} TopicObjectiveVer.TopicObjectiveVId from TopicObjectiveVer Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {2} TopicObjectiveVId from TopicObjectiveVer where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TopicObjectiveVer where {1} and TopicObjectiveVId not in (Select top {3} TopicObjectiveVId from TopicObjectiveVer where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTopicObjectiveVerEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA:GetObjLst)", objException.Message));
}
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetObjLst)", objException.Message));
}
objTopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTopicObjectiveVerEN);
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
public List<clsTopicObjectiveVerEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA:GetObjLstByTabName)", objException.Message));
}
List<clsTopicObjectiveVerEN> arrObjLst = new List<clsTopicObjectiveVerEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetObjLst)", objException.Message));
}
objTopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTopicObjectiveVerEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTopicObjectiveVer(ref clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where TopicObjectiveVId = " + ""+ objTopicObjectiveVerEN.TopicObjectiveVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objDT.Rows[0][conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id(字段类型:bigint,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.TopicObjectiveId = objDT.Rows[0][conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.ObjectiveName = objDT.Rows[0][conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objTopicObjectiveVerEN.ObjectiveContent = objDT.Rows[0][conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTopicObjectiveVerEN.ObjectiveType = objDT.Rows[0][conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objTopicObjectiveVerEN.Conclusion = objDT.Rows[0][conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objTopicObjectiveVerEN.SourceId = objDT.Rows[0][conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objTopicObjectiveVerEN.UpdDate = objDT.Rows[0][conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveVerEN.UpdUser = objDT.Rows[0][conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveVerEN.IdCurrEduCls = objDT.Rows[0][conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.PdfContent = objDT.Rows[0][conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objTopicObjectiveVerEN.PdfPageNum = TransNullToInt(objDT.Rows[0][conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveVerEN.Memo = objDT.Rows[0][conTopicObjectiveVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetTopicObjectiveVer)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">表关键字</param>
 /// <returns>表对象</returns>
public clsTopicObjectiveVerEN GetObjByTopicObjectiveVId(long lngTopicObjectiveVId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
 objTopicObjectiveVerEN.TopicObjectiveVId = Int32.Parse(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id(字段类型:bigint,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称(字段类型:varchar,字段长度:500,是否可空:True)
 objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型(字段类型:char,字段长度:2,是否可空:True)
 objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论(字段类型:varchar,字段长度:5000,是否可空:True)
 objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id(字段类型:char,字段长度:10,是否可空:True)
 objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容(字段类型:varchar,字段长度:2000,是否可空:True)
 objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码(字段类型:int,字段长度:4,是否可空:True)
 objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetObjByTopicObjectiveVId)", objException.Message));
}
return objTopicObjectiveVerEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTopicObjectiveVerEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN()
{
TopicObjectiveVId = TransNullToInt(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()), //主题客观版本Id
TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(), //客观Id
ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(), //客观名称
ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(), //客观内容
ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(), //客观类型
Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(), //结论
SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(), //来源Id
UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(), //修改人
IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(), //教学班流水号
PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(), //Pdf内容
PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()), //Pdf页码
Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim() //备注
};
objTopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveVerEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTopicObjectiveVerEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetObjByDataRowTopicObjectiveVer)", objException.Message));
}
objTopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveVerEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTopicObjectiveVerEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTopicObjectiveVerEN objTopicObjectiveVerEN = new clsTopicObjectiveVerEN();
try
{
objTopicObjectiveVerEN.TopicObjectiveVId = TransNullToInt(objRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim()); //主题客观版本Id
objTopicObjectiveVerEN.TopicObjectiveId = objRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objTopicObjectiveVerEN.ObjectiveName = objRow[conTopicObjectiveVer.ObjectiveName] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objTopicObjectiveVerEN.ObjectiveContent = objRow[conTopicObjectiveVer.ObjectiveContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objTopicObjectiveVerEN.ObjectiveType = objRow[conTopicObjectiveVer.ObjectiveType] == DBNull.Value ? null : objRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objTopicObjectiveVerEN.Conclusion = objRow[conTopicObjectiveVer.Conclusion] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objTopicObjectiveVerEN.SourceId = objRow[conTopicObjectiveVer.SourceId] == DBNull.Value ? null : objRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objTopicObjectiveVerEN.UpdDate = objRow[conTopicObjectiveVer.UpdDate] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objTopicObjectiveVerEN.UpdUser = objRow[conTopicObjectiveVer.UpdUser] == DBNull.Value ? null : objRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objTopicObjectiveVerEN.IdCurrEduCls = objRow[conTopicObjectiveVer.IdCurrEduCls] == DBNull.Value ? null : objRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objTopicObjectiveVerEN.PdfContent = objRow[conTopicObjectiveVer.PdfContent] == DBNull.Value ? null : objRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objTopicObjectiveVerEN.PdfPageNum = objRow[conTopicObjectiveVer.PdfPageNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim()); //Pdf页码
objTopicObjectiveVerEN.Memo = objRow[conTopicObjectiveVer.Memo] == DBNull.Value ? null : objRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTopicObjectiveVerDA: GetObjByDataRow)", objException.Message));
}
objTopicObjectiveVerEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTopicObjectiveVerEN;
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
objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTopicObjectiveVerEN._CurrTabName, conTopicObjectiveVer.TopicObjectiveVId, 8, "");
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
objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTopicObjectiveVerEN._CurrTabName, conTopicObjectiveVer.TopicObjectiveVId, 8, strPrefix);
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TopicObjectiveVId from TopicObjectiveVer where " + strCondition;
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TopicObjectiveVId from TopicObjectiveVer where " + strCondition;
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngTopicObjectiveVId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TopicObjectiveVer", "TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TopicObjectiveVer", strCondition))
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
objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TopicObjectiveVer");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
 {
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveVerEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TopicObjectiveVer");
objRow = objDS.Tables["TopicObjectiveVer"].NewRow();
objRow[conTopicObjectiveVer.TopicObjectiveId] = objTopicObjectiveVerEN.TopicObjectiveId; //客观Id
 if (objTopicObjectiveVerEN.ObjectiveName !=  "")
 {
objRow[conTopicObjectiveVer.ObjectiveName] = objTopicObjectiveVerEN.ObjectiveName; //客观名称
 }
 if (objTopicObjectiveVerEN.ObjectiveContent !=  "")
 {
objRow[conTopicObjectiveVer.ObjectiveContent] = objTopicObjectiveVerEN.ObjectiveContent; //客观内容
 }
 if (objTopicObjectiveVerEN.ObjectiveType !=  "")
 {
objRow[conTopicObjectiveVer.ObjectiveType] = objTopicObjectiveVerEN.ObjectiveType; //客观类型
 }
 if (objTopicObjectiveVerEN.Conclusion !=  "")
 {
objRow[conTopicObjectiveVer.Conclusion] = objTopicObjectiveVerEN.Conclusion; //结论
 }
 if (objTopicObjectiveVerEN.SourceId !=  "")
 {
objRow[conTopicObjectiveVer.SourceId] = objTopicObjectiveVerEN.SourceId; //来源Id
 }
 if (objTopicObjectiveVerEN.UpdDate !=  "")
 {
objRow[conTopicObjectiveVer.UpdDate] = objTopicObjectiveVerEN.UpdDate; //修改日期
 }
 if (objTopicObjectiveVerEN.UpdUser !=  "")
 {
objRow[conTopicObjectiveVer.UpdUser] = objTopicObjectiveVerEN.UpdUser; //修改人
 }
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  "")
 {
objRow[conTopicObjectiveVer.IdCurrEduCls] = objTopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objTopicObjectiveVerEN.PdfContent !=  "")
 {
objRow[conTopicObjectiveVer.PdfContent] = objTopicObjectiveVerEN.PdfContent; //Pdf内容
 }
objRow[conTopicObjectiveVer.PdfPageNum] = objTopicObjectiveVerEN.PdfPageNum; //Pdf页码
 if (objTopicObjectiveVerEN.Memo !=  "")
 {
objRow[conTopicObjectiveVer.Memo] = objTopicObjectiveVerEN.Memo; //备注
 }
objDS.Tables[clsTopicObjectiveVerEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Conclusion);
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.SourceId);
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdDate);
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdUser);
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfContent);
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Memo);
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Conclusion);
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.SourceId);
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdDate);
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdUser);
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfContent);
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Memo);
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTopicObjectiveVerEN objTopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveVerEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Conclusion);
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.SourceId);
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdDate);
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdUser);
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfContent);
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Memo);
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTopicObjectiveVerEN objTopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTopicObjectiveVerEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.TopicObjectiveId);
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicObjectiveId + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveName);
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveName + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveContent);
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveContent + "'");
 }
 
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.ObjectiveType);
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strObjectiveType + "'");
 }
 
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Conclusion);
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConclusion + "'");
 }
 
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.SourceId);
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceId + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdDate);
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.UpdUser);
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.IdCurrEduCls);
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfContent);
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPdfContent + "'");
 }
 
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.PdfPageNum);
 arrValueListForInsert.Add(objTopicObjectiveVerEN.PdfPageNum.ToString());
 }
 
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTopicObjectiveVer.Memo);
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TopicObjectiveVer");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTopicObjectiveVers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where TopicObjectiveVId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TopicObjectiveVer");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngTopicObjectiveVId = TransNullToInt(oRow[conTopicObjectiveVer.TopicObjectiveVId].ToString().Trim());
if (IsExist(lngTopicObjectiveVId))
{
 string strResult = "关键字变量值为:" + string.Format("TopicObjectiveVId = {0}", lngTopicObjectiveVId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTopicObjectiveVerEN._CurrTabName ].NewRow();
objRow[conTopicObjectiveVer.TopicObjectiveId] = oRow[conTopicObjectiveVer.TopicObjectiveId].ToString().Trim(); //客观Id
objRow[conTopicObjectiveVer.ObjectiveName] = oRow[conTopicObjectiveVer.ObjectiveName].ToString().Trim(); //客观名称
objRow[conTopicObjectiveVer.ObjectiveContent] = oRow[conTopicObjectiveVer.ObjectiveContent].ToString().Trim(); //客观内容
objRow[conTopicObjectiveVer.ObjectiveType] = oRow[conTopicObjectiveVer.ObjectiveType].ToString().Trim(); //客观类型
objRow[conTopicObjectiveVer.Conclusion] = oRow[conTopicObjectiveVer.Conclusion].ToString().Trim(); //结论
objRow[conTopicObjectiveVer.SourceId] = oRow[conTopicObjectiveVer.SourceId].ToString().Trim(); //来源Id
objRow[conTopicObjectiveVer.UpdDate] = oRow[conTopicObjectiveVer.UpdDate].ToString().Trim(); //修改日期
objRow[conTopicObjectiveVer.UpdUser] = oRow[conTopicObjectiveVer.UpdUser].ToString().Trim(); //修改人
objRow[conTopicObjectiveVer.IdCurrEduCls] = oRow[conTopicObjectiveVer.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[conTopicObjectiveVer.PdfContent] = oRow[conTopicObjectiveVer.PdfContent].ToString().Trim(); //Pdf内容
objRow[conTopicObjectiveVer.PdfPageNum] = oRow[conTopicObjectiveVer.PdfPageNum].ToString().Trim(); //Pdf页码
objRow[conTopicObjectiveVer.Memo] = oRow[conTopicObjectiveVer.Memo].ToString().Trim(); //备注
 objDS.Tables[clsTopicObjectiveVerEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveVerEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveVerEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
strSQL = "Select * from TopicObjectiveVer where TopicObjectiveVId = " + ""+ objTopicObjectiveVerEN.TopicObjectiveVId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTopicObjectiveVerEN._CurrTabName);
if (objDS.Tables[clsTopicObjectiveVerEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TopicObjectiveVId = " + ""+ objTopicObjectiveVerEN.TopicObjectiveVId+"");
return false;
}
objRow = objDS.Tables[clsTopicObjectiveVerEN._CurrTabName].Rows[0];
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.TopicObjectiveId))
 {
objRow[conTopicObjectiveVer.TopicObjectiveId] = objTopicObjectiveVerEN.TopicObjectiveId; //客观Id
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveName))
 {
objRow[conTopicObjectiveVer.ObjectiveName] = objTopicObjectiveVerEN.ObjectiveName; //客观名称
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveContent))
 {
objRow[conTopicObjectiveVer.ObjectiveContent] = objTopicObjectiveVerEN.ObjectiveContent; //客观内容
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveType))
 {
objRow[conTopicObjectiveVer.ObjectiveType] = objTopicObjectiveVerEN.ObjectiveType; //客观类型
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Conclusion))
 {
objRow[conTopicObjectiveVer.Conclusion] = objTopicObjectiveVerEN.Conclusion; //结论
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.SourceId))
 {
objRow[conTopicObjectiveVer.SourceId] = objTopicObjectiveVerEN.SourceId; //来源Id
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdDate))
 {
objRow[conTopicObjectiveVer.UpdDate] = objTopicObjectiveVerEN.UpdDate; //修改日期
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdUser))
 {
objRow[conTopicObjectiveVer.UpdUser] = objTopicObjectiveVerEN.UpdUser; //修改人
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.IdCurrEduCls))
 {
objRow[conTopicObjectiveVer.IdCurrEduCls] = objTopicObjectiveVerEN.IdCurrEduCls; //教学班流水号
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfContent))
 {
objRow[conTopicObjectiveVer.PdfContent] = objTopicObjectiveVerEN.PdfContent; //Pdf内容
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfPageNum))
 {
objRow[conTopicObjectiveVer.PdfPageNum] = objTopicObjectiveVerEN.PdfPageNum; //Pdf页码
 }
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Memo))
 {
objRow[conTopicObjectiveVer.Memo] = objTopicObjectiveVerEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsTopicObjectiveVerEN._CurrTabName);
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TopicObjectiveVer Set ");
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.TopicObjectiveId))
 {
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicObjectiveId, conTopicObjectiveVer.TopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.TopicObjectiveId); //客观Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveName))
 {
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conTopicObjectiveVer.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveName); //客观名称
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveContent))
 {
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conTopicObjectiveVer.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveContent); //客观内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveType))
 {
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conTopicObjectiveVer.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveType); //客观类型
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Conclusion))
 {
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conTopicObjectiveVer.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.Conclusion); //结论
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.SourceId))
 {
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceId, conTopicObjectiveVer.SourceId); //来源Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.SourceId); //来源Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdDate))
 {
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTopicObjectiveVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.UpdDate); //修改日期
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdUser))
 {
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTopicObjectiveVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.UpdUser); //修改人
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.IdCurrEduCls))
 {
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conTopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfContent))
 {
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conTopicObjectiveVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfContent); //Pdf内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfPageNum))
 {
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveVerEN.PdfPageNum, conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Memo))
 {
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTopicObjectiveVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveVId = {0}", objTopicObjectiveVerEN.TopicObjectiveVId); 
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
 /// <param name = "objTopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strCondition)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjectiveVer Set ");
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.TopicObjectiveId))
 {
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicObjectiveId = '{0}',", strTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.Append(" TopicObjectiveId = null,"); //客观Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveName))
 {
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveContent))
 {
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveType))
 {
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Conclusion))
 {
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.SourceId))
 {
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceId = '{0}',", strSourceId); //来源Id
 }
 else
 {
 sbSQL.Append(" SourceId = null,"); //来源Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdDate))
 {
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdUser))
 {
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.IdCurrEduCls))
 {
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfContent))
 {
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfPageNum))
 {
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveVerEN.PdfPageNum, conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Memo))
 {
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTopicObjectiveVerEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTopicObjectiveVerEN objTopicObjectiveVerEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjectiveVer Set ");
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.TopicObjectiveId))
 {
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicObjectiveId = '{0}',", strTopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.Append(" TopicObjectiveId = null,"); //客观Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveName))
 {
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveName = '{0}',", strObjectiveName); //客观名称
 }
 else
 {
 sbSQL.Append(" ObjectiveName = null,"); //客观名称
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveContent))
 {
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveContent = '{0}',", strObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.Append(" ObjectiveContent = null,"); //客观内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveType))
 {
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ObjectiveType = '{0}',", strObjectiveType); //客观类型
 }
 else
 {
 sbSQL.Append(" ObjectiveType = null,"); //客观类型
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Conclusion))
 {
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Conclusion = '{0}',", strConclusion); //结论
 }
 else
 {
 sbSQL.Append(" Conclusion = null,"); //结论
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.SourceId))
 {
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceId = '{0}',", strSourceId); //来源Id
 }
 else
 {
 sbSQL.Append(" SourceId = null,"); //来源Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdDate))
 {
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdUser))
 {
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.IdCurrEduCls))
 {
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfContent))
 {
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PdfContent = '{0}',", strPdfContent); //Pdf内容
 }
 else
 {
 sbSQL.Append(" PdfContent = null,"); //Pdf内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfPageNum))
 {
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveVerEN.PdfPageNum, conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Memo))
 {
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTopicObjectiveVerEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTopicObjectiveVerEN objTopicObjectiveVerEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objTopicObjectiveVerEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTopicObjectiveVerEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TopicObjectiveVer Set ");
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.TopicObjectiveId))
 {
 if (objTopicObjectiveVerEN.TopicObjectiveId !=  null)
 {
 var strTopicObjectiveId = objTopicObjectiveVerEN.TopicObjectiveId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicObjectiveId, conTopicObjectiveVer.TopicObjectiveId); //客观Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.TopicObjectiveId); //客观Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveName))
 {
 if (objTopicObjectiveVerEN.ObjectiveName !=  null)
 {
 var strObjectiveName = objTopicObjectiveVerEN.ObjectiveName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveName, conTopicObjectiveVer.ObjectiveName); //客观名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveName); //客观名称
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveContent))
 {
 if (objTopicObjectiveVerEN.ObjectiveContent !=  null)
 {
 var strObjectiveContent = objTopicObjectiveVerEN.ObjectiveContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveContent, conTopicObjectiveVer.ObjectiveContent); //客观内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveContent); //客观内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.ObjectiveType))
 {
 if (objTopicObjectiveVerEN.ObjectiveType !=  null)
 {
 var strObjectiveType = objTopicObjectiveVerEN.ObjectiveType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strObjectiveType, conTopicObjectiveVer.ObjectiveType); //客观类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.ObjectiveType); //客观类型
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Conclusion))
 {
 if (objTopicObjectiveVerEN.Conclusion !=  null)
 {
 var strConclusion = objTopicObjectiveVerEN.Conclusion.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConclusion, conTopicObjectiveVer.Conclusion); //结论
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.Conclusion); //结论
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.SourceId))
 {
 if (objTopicObjectiveVerEN.SourceId !=  null)
 {
 var strSourceId = objTopicObjectiveVerEN.SourceId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceId, conTopicObjectiveVer.SourceId); //来源Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.SourceId); //来源Id
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdDate))
 {
 if (objTopicObjectiveVerEN.UpdDate !=  null)
 {
 var strUpdDate = objTopicObjectiveVerEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTopicObjectiveVer.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.UpdDate); //修改日期
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.UpdUser))
 {
 if (objTopicObjectiveVerEN.UpdUser !=  null)
 {
 var strUpdUser = objTopicObjectiveVerEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTopicObjectiveVer.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.UpdUser); //修改人
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.IdCurrEduCls))
 {
 if (objTopicObjectiveVerEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objTopicObjectiveVerEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, conTopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfContent))
 {
 if (objTopicObjectiveVerEN.PdfContent !=  null)
 {
 var strPdfContent = objTopicObjectiveVerEN.PdfContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPdfContent, conTopicObjectiveVer.PdfContent); //Pdf内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfContent); //Pdf内容
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.PdfPageNum))
 {
 if (objTopicObjectiveVerEN.PdfPageNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objTopicObjectiveVerEN.PdfPageNum, conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.PdfPageNum); //Pdf页码
 }
 }
 
 if (objTopicObjectiveVerEN.IsUpdated(conTopicObjectiveVer.Memo))
 {
 if (objTopicObjectiveVerEN.Memo !=  null)
 {
 var strMemo = objTopicObjectiveVerEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTopicObjectiveVer.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTopicObjectiveVer.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TopicObjectiveVId = {0}", objTopicObjectiveVerEN.TopicObjectiveVId); 
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
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngTopicObjectiveVId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngTopicObjectiveVId,
};
 objSQL.ExecSP("TopicObjectiveVer_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngTopicObjectiveVId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
//删除TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTopicObjectiveVer(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
//删除TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjectiveVer where TopicObjectiveVId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngTopicObjectiveVId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngTopicObjectiveVId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
//删除TopicObjectiveVer本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TopicObjectiveVer where TopicObjectiveVId = " + ""+ lngTopicObjectiveVId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTopicObjectiveVer(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: DelTopicObjectiveVer)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TopicObjectiveVer where " + strCondition ;
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
public bool DelTopicObjectiveVerWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTopicObjectiveVerDA: DelTopicObjectiveVerWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TopicObjectiveVer where " + strCondition ;
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
 /// <param name = "objTopicObjectiveVerENS">源对象</param>
 /// <param name = "objTopicObjectiveVerENT">目标对象</param>
public void CopyTo(clsTopicObjectiveVerEN objTopicObjectiveVerENS, clsTopicObjectiveVerEN objTopicObjectiveVerENT)
{
objTopicObjectiveVerENT.TopicObjectiveVId = objTopicObjectiveVerENS.TopicObjectiveVId; //主题客观版本Id
objTopicObjectiveVerENT.TopicObjectiveId = objTopicObjectiveVerENS.TopicObjectiveId; //客观Id
objTopicObjectiveVerENT.ObjectiveName = objTopicObjectiveVerENS.ObjectiveName; //客观名称
objTopicObjectiveVerENT.ObjectiveContent = objTopicObjectiveVerENS.ObjectiveContent; //客观内容
objTopicObjectiveVerENT.ObjectiveType = objTopicObjectiveVerENS.ObjectiveType; //客观类型
objTopicObjectiveVerENT.Conclusion = objTopicObjectiveVerENS.Conclusion; //结论
objTopicObjectiveVerENT.SourceId = objTopicObjectiveVerENS.SourceId; //来源Id
objTopicObjectiveVerENT.UpdDate = objTopicObjectiveVerENS.UpdDate; //修改日期
objTopicObjectiveVerENT.UpdUser = objTopicObjectiveVerENS.UpdUser; //修改人
objTopicObjectiveVerENT.IdCurrEduCls = objTopicObjectiveVerENS.IdCurrEduCls; //教学班流水号
objTopicObjectiveVerENT.PdfContent = objTopicObjectiveVerENS.PdfContent; //Pdf内容
objTopicObjectiveVerENT.PdfPageNum = objTopicObjectiveVerENS.PdfPageNum; //Pdf页码
objTopicObjectiveVerENT.Memo = objTopicObjectiveVerENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTopicObjectiveVerEN.TopicObjectiveId, conTopicObjectiveVer.TopicObjectiveId);
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.TopicObjectiveId, 8, conTopicObjectiveVer.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveName, 500, conTopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveType, 2, conTopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Conclusion, 5000, conTopicObjectiveVer.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.SourceId, 10, conTopicObjectiveVer.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdDate, 20, conTopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdUser, 20, conTopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.IdCurrEduCls, 8, conTopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.PdfContent, 2000, conTopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Memo, 1000, conTopicObjectiveVer.Memo);
//检查字段外键固定长度
 objTopicObjectiveVerEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.TopicObjectiveId, 8, conTopicObjectiveVer.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveName, 500, conTopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveType, 2, conTopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Conclusion, 5000, conTopicObjectiveVer.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.SourceId, 10, conTopicObjectiveVer.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdDate, 20, conTopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdUser, 20, conTopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.IdCurrEduCls, 8, conTopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.PdfContent, 2000, conTopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Memo, 1000, conTopicObjectiveVer.Memo);
//检查外键字段长度
 objTopicObjectiveVerEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.TopicObjectiveId, 8, conTopicObjectiveVer.TopicObjectiveId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveName, 500, conTopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.ObjectiveType, 2, conTopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Conclusion, 5000, conTopicObjectiveVer.Conclusion);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.SourceId, 10, conTopicObjectiveVer.SourceId);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdDate, 20, conTopicObjectiveVer.UpdDate);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.UpdUser, 20, conTopicObjectiveVer.UpdUser);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.IdCurrEduCls, 8, conTopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.PdfContent, 2000, conTopicObjectiveVer.PdfContent);
clsCheckSql.CheckFieldLen(objTopicObjectiveVerEN.Memo, 1000, conTopicObjectiveVer.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.TopicObjectiveId, conTopicObjectiveVer.TopicObjectiveId);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.ObjectiveName, conTopicObjectiveVer.ObjectiveName);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.ObjectiveType, conTopicObjectiveVer.ObjectiveType);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.Conclusion, conTopicObjectiveVer.Conclusion);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.SourceId, conTopicObjectiveVer.SourceId);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.UpdDate, conTopicObjectiveVer.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.UpdUser, conTopicObjectiveVer.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.IdCurrEduCls, conTopicObjectiveVer.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.PdfContent, conTopicObjectiveVer.PdfContent);
clsCheckSql.CheckSqlInjection4Field(objTopicObjectiveVerEN.Memo, conTopicObjectiveVer.Memo);
//检查外键字段长度
 objTopicObjectiveVerEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TopicObjectiveVer(主题客观版本),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTopicObjectiveVerEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTopicObjectiveVerEN objTopicObjectiveVerEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TopicObjectiveVId = '{0}'", objTopicObjectiveVerEN.TopicObjectiveVId);
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTopicObjectiveVerEN._CurrTabName);
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTopicObjectiveVerEN._CurrTabName, strCondition);
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
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
 objSQL = clsTopicObjectiveVerDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}