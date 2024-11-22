
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_PapersBigTopicDA
 表名:cc_PapersBigTopic(01120077)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:12:27
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
 /// 试卷大题目(cc_PapersBigTopic)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_PapersBigTopicDA : clsCommBase4DA
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
 return clscc_PapersBigTopicEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_PapersBigTopicEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_PapersBigTopicEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_PapersBigTopicEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_PapersBigTopicEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strPapersBigTopicId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strPapersBigTopicId)
{
strPapersBigTopicId = strPapersBigTopicId.Replace("'", "''");
if (strPapersBigTopicId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_PapersBigTopic中,检查关键字,长度不正确!(clscc_PapersBigTopicDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strPapersBigTopicId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_PapersBigTopic中,关键字不能为空 或 null!(clscc_PapersBigTopicDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strPapersBigTopicId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_PapersBigTopicDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_PapersBigTopic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable_cc_PapersBigTopic)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PapersBigTopic.* from cc_PapersBigTopic Left Join {1} on {2} where {3} and cc_PapersBigTopic.PapersBigTopicId not in (Select top {5} cc_PapersBigTopic.PapersBigTopicId from cc_PapersBigTopic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1} and PapersBigTopicId not in (Select top {2} PapersBigTopicId from cc_PapersBigTopic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1} and PapersBigTopicId not in (Select top {3} PapersBigTopicId from cc_PapersBigTopic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_PapersBigTopic.* from cc_PapersBigTopic Left Join {1} on {2} where {3} and cc_PapersBigTopic.PapersBigTopicId not in (Select top {5} cc_PapersBigTopic.PapersBigTopicId from cc_PapersBigTopic Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1} and PapersBigTopicId not in (Select top {2} PapersBigTopicId from cc_PapersBigTopic where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_PapersBigTopic where {1} and PapersBigTopicId not in (Select top {3} PapersBigTopicId from cc_PapersBigTopic where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_PapersBigTopicEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA:GetObjLst)", objException.Message));
}
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = TransNullToBool(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetObjLst)", objException.Message));
}
objcc_PapersBigTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PapersBigTopicEN);
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
public List<clscc_PapersBigTopicEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_PapersBigTopicEN> arrObjLst = new List<clscc_PapersBigTopicEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = TransNullToBool(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetObjLst)", objException.Message));
}
objcc_PapersBigTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_PapersBigTopicEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_PapersBigTopic(ref clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where PapersBigTopicId = " + "'"+ objcc_PapersBigTopicEN.PapersBigTopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_PapersBigTopicEN.PapersBigTopicId = objDT.Rows[0][concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PapersBigTopicEN.PapersBigTopicName = objDT.Rows[0][concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_PapersBigTopicEN.TopicDescription = objDT.Rows[0][concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_PapersBigTopicEN.TopicScores = TransNullToInt(objDT.Rows[0][concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objcc_PapersBigTopicEN.CourseExamPaperId = objDT.Rows[0][concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_PapersBigTopicEN.QuestionTypeId = objDT.Rows[0][concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objcc_PapersBigTopicEN.IsShow = TransNullToBool(objDT.Rows[0][concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PapersBigTopicEN.OrderNum = TransNullToInt(objDT.Rows[0][concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_PapersBigTopicEN.UpdDate = objDT.Rows[0][concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PapersBigTopicEN.UpdUser = objDT.Rows[0][concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PapersBigTopicEN.Memo = objDT.Rows[0][concc_PapersBigTopic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_PapersBigTopicDA: Getcc_PapersBigTopic)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strPapersBigTopicId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_PapersBigTopicEN GetObjByPapersBigTopicId(string strPapersBigTopicId)
{
CheckPrimaryKey(strPapersBigTopicId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where PapersBigTopicId = " + "'"+ strPapersBigTopicId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
 objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objcc_PapersBigTopicEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetObjByPapersBigTopicId)", objException.Message));
}
return objcc_PapersBigTopicEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_PapersBigTopicEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN()
{
PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(), //试卷大题目Id
PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(), //试卷大题目名称
TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(), //标题描述
TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()), //大题得分
CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(), //考卷流水号
QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(), //题目类型Id
IsShow = TransNullToBool(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()), //是否启用
OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(), //修改人
Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim() //备注
};
objcc_PapersBigTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PapersBigTopicEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_PapersBigTopicEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = TransNullToBool(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetObjByDataRowcc_PapersBigTopic)", objException.Message));
}
objcc_PapersBigTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PapersBigTopicEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_PapersBigTopicEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_PapersBigTopicEN objcc_PapersBigTopicEN = new clscc_PapersBigTopicEN();
try
{
objcc_PapersBigTopicEN.PapersBigTopicId = objRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objcc_PapersBigTopicEN.PapersBigTopicName = objRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objcc_PapersBigTopicEN.TopicDescription = objRow[concc_PapersBigTopic.TopicDescription] == DBNull.Value ? null : objRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objcc_PapersBigTopicEN.TopicScores = objRow[concc_PapersBigTopic.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.TopicScores].ToString().Trim()); //大题得分
objcc_PapersBigTopicEN.CourseExamPaperId = objRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_PapersBigTopicEN.QuestionTypeId = objRow[concc_PapersBigTopic.QuestionTypeId] == DBNull.Value ? null : objRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objcc_PapersBigTopicEN.IsShow = TransNullToBool(objRow[concc_PapersBigTopic.IsShow].ToString().Trim()); //是否启用
objcc_PapersBigTopicEN.OrderNum = objRow[concc_PapersBigTopic.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_PapersBigTopic.OrderNum].ToString().Trim()); //序号
objcc_PapersBigTopicEN.UpdDate = objRow[concc_PapersBigTopic.UpdDate] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objcc_PapersBigTopicEN.UpdUser = objRow[concc_PapersBigTopic.UpdUser] == DBNull.Value ? null : objRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objcc_PapersBigTopicEN.Memo = objRow[concc_PapersBigTopic.Memo] == DBNull.Value ? null : objRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_PapersBigTopicDA: GetObjByDataRow)", objException.Message));
}
objcc_PapersBigTopicEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_PapersBigTopicEN;
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
objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PapersBigTopicEN._CurrTabName, concc_PapersBigTopic.PapersBigTopicId, 8, "");
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
objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_PapersBigTopicEN._CurrTabName, concc_PapersBigTopic.PapersBigTopicId, 8, strPrefix);
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select PapersBigTopicId from cc_PapersBigTopic where " + strCondition;
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select PapersBigTopicId from cc_PapersBigTopic where " + strCondition;
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
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strPapersBigTopicId)
{
CheckPrimaryKey(strPapersBigTopicId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PapersBigTopic", "PapersBigTopicId = " + "'"+ strPapersBigTopicId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_PapersBigTopic", strCondition))
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
objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_PapersBigTopic");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
 {
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PapersBigTopicEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PapersBigTopic");
objRow = objDS.Tables["cc_PapersBigTopic"].NewRow();
objRow[concc_PapersBigTopic.PapersBigTopicId] = objcc_PapersBigTopicEN.PapersBigTopicId; //试卷大题目Id
objRow[concc_PapersBigTopic.PapersBigTopicName] = objcc_PapersBigTopicEN.PapersBigTopicName; //试卷大题目名称
 if (objcc_PapersBigTopicEN.TopicDescription !=  "")
 {
objRow[concc_PapersBigTopic.TopicDescription] = objcc_PapersBigTopicEN.TopicDescription; //标题描述
 }
objRow[concc_PapersBigTopic.TopicScores] = objcc_PapersBigTopicEN.TopicScores; //大题得分
objRow[concc_PapersBigTopic.CourseExamPaperId] = objcc_PapersBigTopicEN.CourseExamPaperId; //考卷流水号
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  "")
 {
objRow[concc_PapersBigTopic.QuestionTypeId] = objcc_PapersBigTopicEN.QuestionTypeId; //题目类型Id
 }
objRow[concc_PapersBigTopic.IsShow] = objcc_PapersBigTopicEN.IsShow; //是否启用
objRow[concc_PapersBigTopic.OrderNum] = objcc_PapersBigTopicEN.OrderNum; //序号
 if (objcc_PapersBigTopicEN.UpdDate !=  "")
 {
objRow[concc_PapersBigTopic.UpdDate] = objcc_PapersBigTopicEN.UpdDate; //修改日期
 }
 if (objcc_PapersBigTopicEN.UpdUser !=  "")
 {
objRow[concc_PapersBigTopic.UpdUser] = objcc_PapersBigTopicEN.UpdUser; //修改人
 }
 if (objcc_PapersBigTopicEN.Memo !=  "")
 {
objRow[concc_PapersBigTopic.Memo] = objcc_PapersBigTopicEN.Memo; //备注
 }
objDS.Tables[clscc_PapersBigTopicEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_PapersBigTopicEN._CurrTabName);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PapersBigTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_PapersBigTopicEN.PapersBigTopicId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicId);
 var strPapersBigTopicId = objcc_PapersBigTopicEN.PapersBigTopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicId + "'");
 }
 
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicName);
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicName + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicDescription);
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicDescription + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicScores);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.TopicScores.ToString());
 }
 
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.CourseExamPaperId);
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.QuestionTypeId);
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_PapersBigTopic.IsShow);
 arrValueListForInsert.Add("'" + (objcc_PapersBigTopicEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.OrderNum);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.OrderNum.ToString());
 }
 
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdDate);
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdUser);
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.Memo);
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PapersBigTopic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PapersBigTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_PapersBigTopicEN.PapersBigTopicId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicId);
 var strPapersBigTopicId = objcc_PapersBigTopicEN.PapersBigTopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicId + "'");
 }
 
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicName);
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicName + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicDescription);
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicDescription + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicScores);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.TopicScores.ToString());
 }
 
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.CourseExamPaperId);
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.QuestionTypeId);
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_PapersBigTopic.IsShow);
 arrValueListForInsert.Add("'" + (objcc_PapersBigTopicEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.OrderNum);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.OrderNum.ToString());
 }
 
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdDate);
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdUser);
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.Memo);
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PapersBigTopic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_PapersBigTopicEN.PapersBigTopicId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PapersBigTopicEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_PapersBigTopicEN.PapersBigTopicId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicId);
 var strPapersBigTopicId = objcc_PapersBigTopicEN.PapersBigTopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicId + "'");
 }
 
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicName);
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicName + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicDescription);
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicDescription + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicScores);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.TopicScores.ToString());
 }
 
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.CourseExamPaperId);
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.QuestionTypeId);
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_PapersBigTopic.IsShow);
 arrValueListForInsert.Add("'" + (objcc_PapersBigTopicEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.OrderNum);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.OrderNum.ToString());
 }
 
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdDate);
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdUser);
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.Memo);
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PapersBigTopic");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_PapersBigTopicEN.PapersBigTopicId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_PapersBigTopicEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_PapersBigTopicEN.PapersBigTopicId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicId);
 var strPapersBigTopicId = objcc_PapersBigTopicEN.PapersBigTopicId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicId + "'");
 }
 
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.PapersBigTopicName);
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPapersBigTopicName + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicDescription);
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTopicDescription + "'");
 }
 
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.TopicScores);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.TopicScores.ToString());
 }
 
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.CourseExamPaperId);
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.QuestionTypeId);
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionTypeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_PapersBigTopic.IsShow);
 arrValueListForInsert.Add("'" + (objcc_PapersBigTopicEN.IsShow  ==  false ? "0" : "1") + "'");
 
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.OrderNum);
 arrValueListForInsert.Add(objcc_PapersBigTopicEN.OrderNum.ToString());
 }
 
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdDate);
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.UpdUser);
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_PapersBigTopic.Memo);
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_PapersBigTopic");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_PapersBigTopics(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where PapersBigTopicId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_PapersBigTopic");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strPapersBigTopicId = oRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim();
if (IsExist(strPapersBigTopicId))
{
 string strResult = "关键字变量值为:" + string.Format("PapersBigTopicId = {0}", strPapersBigTopicId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_PapersBigTopicEN._CurrTabName ].NewRow();
objRow[concc_PapersBigTopic.PapersBigTopicId] = oRow[concc_PapersBigTopic.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objRow[concc_PapersBigTopic.PapersBigTopicName] = oRow[concc_PapersBigTopic.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objRow[concc_PapersBigTopic.TopicDescription] = oRow[concc_PapersBigTopic.TopicDescription].ToString().Trim(); //标题描述
objRow[concc_PapersBigTopic.TopicScores] = oRow[concc_PapersBigTopic.TopicScores].ToString().Trim(); //大题得分
objRow[concc_PapersBigTopic.CourseExamPaperId] = oRow[concc_PapersBigTopic.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_PapersBigTopic.QuestionTypeId] = oRow[concc_PapersBigTopic.QuestionTypeId].ToString().Trim(); //题目类型Id
objRow[concc_PapersBigTopic.IsShow] = oRow[concc_PapersBigTopic.IsShow].ToString().Trim(); //是否启用
objRow[concc_PapersBigTopic.OrderNum] = oRow[concc_PapersBigTopic.OrderNum].ToString().Trim(); //序号
objRow[concc_PapersBigTopic.UpdDate] = oRow[concc_PapersBigTopic.UpdDate].ToString().Trim(); //修改日期
objRow[concc_PapersBigTopic.UpdUser] = oRow[concc_PapersBigTopic.UpdUser].ToString().Trim(); //修改人
objRow[concc_PapersBigTopic.Memo] = oRow[concc_PapersBigTopic.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_PapersBigTopicEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_PapersBigTopicEN._CurrTabName);
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PapersBigTopicEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
strSQL = "Select * from cc_PapersBigTopic where PapersBigTopicId = " + "'"+ objcc_PapersBigTopicEN.PapersBigTopicId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_PapersBigTopicEN._CurrTabName);
if (objDS.Tables[clscc_PapersBigTopicEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:PapersBigTopicId = " + "'"+ objcc_PapersBigTopicEN.PapersBigTopicId+"'");
return false;
}
objRow = objDS.Tables[clscc_PapersBigTopicEN._CurrTabName].Rows[0];
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicId))
 {
objRow[concc_PapersBigTopic.PapersBigTopicId] = objcc_PapersBigTopicEN.PapersBigTopicId; //试卷大题目Id
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicName))
 {
objRow[concc_PapersBigTopic.PapersBigTopicName] = objcc_PapersBigTopicEN.PapersBigTopicName; //试卷大题目名称
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicDescription))
 {
objRow[concc_PapersBigTopic.TopicDescription] = objcc_PapersBigTopicEN.TopicDescription; //标题描述
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicScores))
 {
objRow[concc_PapersBigTopic.TopicScores] = objcc_PapersBigTopicEN.TopicScores; //大题得分
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.CourseExamPaperId))
 {
objRow[concc_PapersBigTopic.CourseExamPaperId] = objcc_PapersBigTopicEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.QuestionTypeId))
 {
objRow[concc_PapersBigTopic.QuestionTypeId] = objcc_PapersBigTopicEN.QuestionTypeId; //题目类型Id
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.IsShow))
 {
objRow[concc_PapersBigTopic.IsShow] = objcc_PapersBigTopicEN.IsShow; //是否启用
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.OrderNum))
 {
objRow[concc_PapersBigTopic.OrderNum] = objcc_PapersBigTopicEN.OrderNum; //序号
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdDate))
 {
objRow[concc_PapersBigTopic.UpdDate] = objcc_PapersBigTopicEN.UpdDate; //修改日期
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdUser))
 {
objRow[concc_PapersBigTopic.UpdUser] = objcc_PapersBigTopicEN.UpdUser; //修改人
 }
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.Memo))
 {
objRow[concc_PapersBigTopic.Memo] = objcc_PapersBigTopicEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_PapersBigTopicEN._CurrTabName);
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PapersBigTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_PapersBigTopic Set ");
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicName))
 {
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName); //试卷大题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.PapersBigTopicName); //试卷大题目名称
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicDescription))
 {
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicDescription, concc_PapersBigTopic.TopicDescription); //标题描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicDescription); //标题描述
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicScores))
 {
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.TopicScores, concc_PapersBigTopic.TopicScores); //大题得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicScores); //大题得分
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.CourseExamPaperId))
 {
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.QuestionTypeId))
 {
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, concc_PapersBigTopic.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PapersBigTopicEN.IsShow == true?"1":"0", concc_PapersBigTopic.IsShow); //是否启用
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.OrderNum))
 {
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.OrderNum, concc_PapersBigTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.OrderNum); //序号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdDate))
 {
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PapersBigTopic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.UpdDate); //修改日期
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdUser))
 {
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_PapersBigTopic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.UpdUser); //修改人
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.Memo))
 {
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PapersBigTopic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PapersBigTopicId = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicId); 
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strCondition)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PapersBigTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PapersBigTopic Set ");
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicName))
 {
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PapersBigTopicName = '{0}',", strPapersBigTopicName); //试卷大题目名称
 }
 else
 {
 sbSQL.Append(" PapersBigTopicName = null,"); //试卷大题目名称
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicDescription))
 {
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicDescription = '{0}',", strTopicDescription); //标题描述
 }
 else
 {
 sbSQL.Append(" TopicDescription = null,"); //标题描述
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicScores))
 {
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.TopicScores, concc_PapersBigTopic.TopicScores); //大题得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicScores); //大题得分
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.CourseExamPaperId))
 {
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.QuestionTypeId))
 {
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_PapersBigTopicEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.OrderNum))
 {
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.OrderNum, concc_PapersBigTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.OrderNum); //序号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdDate))
 {
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdUser))
 {
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.Memo))
 {
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PapersBigTopicEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PapersBigTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PapersBigTopic Set ");
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicName))
 {
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PapersBigTopicName = '{0}',", strPapersBigTopicName); //试卷大题目名称
 }
 else
 {
 sbSQL.Append(" PapersBigTopicName = null,"); //试卷大题目名称
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicDescription))
 {
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TopicDescription = '{0}',", strTopicDescription); //标题描述
 }
 else
 {
 sbSQL.Append(" TopicDescription = null,"); //标题描述
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicScores))
 {
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.TopicScores, concc_PapersBigTopic.TopicScores); //大题得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicScores); //大题得分
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.CourseExamPaperId))
 {
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.QuestionTypeId))
 {
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionTypeId = '{0}',", strQuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.Append(" QuestionTypeId = null,"); //题目类型Id
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_PapersBigTopicEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.OrderNum))
 {
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.OrderNum, concc_PapersBigTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.OrderNum); //序号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdDate))
 {
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdUser))
 {
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.Memo))
 {
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_PapersBigTopicEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_PapersBigTopicEN objcc_PapersBigTopicEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_PapersBigTopicEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_PapersBigTopicEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_PapersBigTopicEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_PapersBigTopic Set ");
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.PapersBigTopicName))
 {
 if (objcc_PapersBigTopicEN.PapersBigTopicName !=  null)
 {
 var strPapersBigTopicName = objcc_PapersBigTopicEN.PapersBigTopicName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName); //试卷大题目名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.PapersBigTopicName); //试卷大题目名称
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicDescription))
 {
 if (objcc_PapersBigTopicEN.TopicDescription !=  null)
 {
 var strTopicDescription = objcc_PapersBigTopicEN.TopicDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTopicDescription, concc_PapersBigTopic.TopicDescription); //标题描述
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicDescription); //标题描述
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.TopicScores))
 {
 if (objcc_PapersBigTopicEN.TopicScores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.TopicScores, concc_PapersBigTopic.TopicScores); //大题得分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.TopicScores); //大题得分
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.CourseExamPaperId))
 {
 if (objcc_PapersBigTopicEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_PapersBigTopicEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.QuestionTypeId))
 {
 if (objcc_PapersBigTopicEN.QuestionTypeId !=  null)
 {
 var strQuestionTypeId = objcc_PapersBigTopicEN.QuestionTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionTypeId, concc_PapersBigTopic.QuestionTypeId); //题目类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.QuestionTypeId); //题目类型Id
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_PapersBigTopicEN.IsShow == true?"1":"0", concc_PapersBigTopic.IsShow); //是否启用
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.OrderNum))
 {
 if (objcc_PapersBigTopicEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_PapersBigTopicEN.OrderNum, concc_PapersBigTopic.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.OrderNum); //序号
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdDate))
 {
 if (objcc_PapersBigTopicEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_PapersBigTopicEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_PapersBigTopic.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.UpdDate); //修改日期
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.UpdUser))
 {
 if (objcc_PapersBigTopicEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_PapersBigTopicEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_PapersBigTopic.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.UpdUser); //修改人
 }
 }
 
 if (objcc_PapersBigTopicEN.IsUpdated(concc_PapersBigTopic.Memo))
 {
 if (objcc_PapersBigTopicEN.Memo !=  null)
 {
 var strMemo = objcc_PapersBigTopicEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_PapersBigTopic.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_PapersBigTopic.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where PapersBigTopicId = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicId); 
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
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strPapersBigTopicId) 
{
CheckPrimaryKey(strPapersBigTopicId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strPapersBigTopicId,
};
 objSQL.ExecSP("cc_PapersBigTopic_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strPapersBigTopicId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strPapersBigTopicId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
//删除cc_PapersBigTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PapersBigTopic where PapersBigTopicId = " + "'"+ strPapersBigTopicId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_PapersBigTopic(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
//删除cc_PapersBigTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PapersBigTopic where PapersBigTopicId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strPapersBigTopicId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strPapersBigTopicId) 
{
CheckPrimaryKey(strPapersBigTopicId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
//删除cc_PapersBigTopic本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_PapersBigTopic where PapersBigTopicId = " + "'"+ strPapersBigTopicId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_PapersBigTopic(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: Delcc_PapersBigTopic)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PapersBigTopic where " + strCondition ;
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
public bool Delcc_PapersBigTopicWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_PapersBigTopicDA: Delcc_PapersBigTopicWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_PapersBigTopic where " + strCondition ;
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
 /// <param name = "objcc_PapersBigTopicENS">源对象</param>
 /// <param name = "objcc_PapersBigTopicENT">目标对象</param>
public void CopyTo(clscc_PapersBigTopicEN objcc_PapersBigTopicENS, clscc_PapersBigTopicEN objcc_PapersBigTopicENT)
{
objcc_PapersBigTopicENT.PapersBigTopicId = objcc_PapersBigTopicENS.PapersBigTopicId; //试卷大题目Id
objcc_PapersBigTopicENT.PapersBigTopicName = objcc_PapersBigTopicENS.PapersBigTopicName; //试卷大题目名称
objcc_PapersBigTopicENT.TopicDescription = objcc_PapersBigTopicENS.TopicDescription; //标题描述
objcc_PapersBigTopicENT.TopicScores = objcc_PapersBigTopicENS.TopicScores; //大题得分
objcc_PapersBigTopicENT.CourseExamPaperId = objcc_PapersBigTopicENS.CourseExamPaperId; //考卷流水号
objcc_PapersBigTopicENT.QuestionTypeId = objcc_PapersBigTopicENS.QuestionTypeId; //题目类型Id
objcc_PapersBigTopicENT.IsShow = objcc_PapersBigTopicENS.IsShow; //是否启用
objcc_PapersBigTopicENT.OrderNum = objcc_PapersBigTopicENS.OrderNum; //序号
objcc_PapersBigTopicENT.UpdDate = objcc_PapersBigTopicENS.UpdDate; //修改日期
objcc_PapersBigTopicENT.UpdUser = objcc_PapersBigTopicENS.UpdUser; //修改人
objcc_PapersBigTopicENT.Memo = objcc_PapersBigTopicENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_PapersBigTopicEN.PapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldNotNull(objcc_PapersBigTopicEN.CourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.PapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.PapersBigTopicName, 50, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.TopicDescription, 100, concc_PapersBigTopic.TopicDescription);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.CourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.QuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdDate, 20, concc_PapersBigTopic.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdUser, 20, concc_PapersBigTopic.UpdUser);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.Memo, 1000, concc_PapersBigTopic.Memo);
//检查字段外键固定长度
 objcc_PapersBigTopicEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.PapersBigTopicName, 50, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.TopicDescription, 100, concc_PapersBigTopic.TopicDescription);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.CourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.QuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdDate, 20, concc_PapersBigTopic.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdUser, 20, concc_PapersBigTopic.UpdUser);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.Memo, 1000, concc_PapersBigTopic.Memo);
//检查外键字段长度
 objcc_PapersBigTopicEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.PapersBigTopicId, 8, concc_PapersBigTopic.PapersBigTopicId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.PapersBigTopicName, 50, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.TopicDescription, 100, concc_PapersBigTopic.TopicDescription);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.CourseExamPaperId, 8, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.QuestionTypeId, 2, concc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdDate, 20, concc_PapersBigTopic.UpdDate);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.UpdUser, 20, concc_PapersBigTopic.UpdUser);
clsCheckSql.CheckFieldLen(objcc_PapersBigTopicEN.Memo, 1000, concc_PapersBigTopic.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.PapersBigTopicId, concc_PapersBigTopic.PapersBigTopicId);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.PapersBigTopicName, concc_PapersBigTopic.PapersBigTopicName);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.TopicDescription, concc_PapersBigTopic.TopicDescription);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.CourseExamPaperId, concc_PapersBigTopic.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.QuestionTypeId, concc_PapersBigTopic.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.UpdDate, concc_PapersBigTopic.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.UpdUser, concc_PapersBigTopic.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcc_PapersBigTopicEN.Memo, concc_PapersBigTopic.Memo);
//检查外键字段长度
 objcc_PapersBigTopicEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetPapersBigTopicId()
{
//获取某学院所有专业信息
string strSQL = "select PapersBigTopicId, PapersBigTopicName from cc_PapersBigTopic ";
 clsSpecSQLforSql mySql = clscc_PapersBigTopicDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_PapersBigTopic(试卷大题目),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_PapersBigTopicEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_PapersBigTopicEN objcc_PapersBigTopicEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PapersBigTopicName = '{0}'", objcc_PapersBigTopicEN.PapersBigTopicName);
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PapersBigTopicEN._CurrTabName);
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_PapersBigTopicEN._CurrTabName, strCondition);
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
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
 objSQL = clscc_PapersBigTopicDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}