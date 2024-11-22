
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsAqa_QuestionsExDA
 表名:Aqa_QuestionsEx(01120952)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:06:57
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
 /// Aqa_QuestionsEx(Aqa_QuestionsEx)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsAqa_QuestionsExDA : clsCommBase4DA
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
 return clsAqa_QuestionsExEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsAqa_QuestionsExEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsAqa_QuestionsExEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsAqa_QuestionsExEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsAqa_QuestionsExEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strStuId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strStuId)
{
strStuId = strStuId.Replace("'", "''");
if (strStuId.Length > 20)
{
throw new Exception("(errid:Data000001)在表:Aqa_QuestionsEx中,检查关键字,长度不正确!(clsAqa_QuestionsExDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strStuId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Aqa_QuestionsEx中,关键字不能为空 或 null!(clsAqa_QuestionsExDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strStuId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsAqa_QuestionsExDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Aqa_QuestionsEx(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable_Aqa_QuestionsEx)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Aqa_QuestionsEx.* from Aqa_QuestionsEx Left Join {1} on {2} where {3} and Aqa_QuestionsEx.StuId not in (Select top {5} Aqa_QuestionsEx.StuId from Aqa_QuestionsEx Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1} and StuId not in (Select top {2} StuId from Aqa_QuestionsEx where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1} and StuId not in (Select top {3} StuId from Aqa_QuestionsEx where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} Aqa_QuestionsEx.* from Aqa_QuestionsEx Left Join {1} on {2} where {3} and Aqa_QuestionsEx.StuId not in (Select top {5} Aqa_QuestionsEx.StuId from Aqa_QuestionsEx Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1} and StuId not in (Select top {2} StuId from Aqa_QuestionsEx where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Aqa_QuestionsEx where {1} and StuId not in (Select top {3} StuId from Aqa_QuestionsEx where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsAqa_QuestionsExEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA:GetObjLst)", objException.Message));
}
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetObjLst)", objException.Message));
}
objAqa_QuestionsExEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAqa_QuestionsExEN);
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
public List<clsAqa_QuestionsExEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA:GetObjLstByTabName)", objException.Message));
}
List<clsAqa_QuestionsExEN> arrObjLst = new List<clsAqa_QuestionsExEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetObjLst)", objException.Message));
}
objAqa_QuestionsExEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objAqa_QuestionsExEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetAqa_QuestionsEx(ref clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where StuId = " + "'"+ objAqa_QuestionsExEN.StuId+"'" + " and QuestionsId = " + "'"+ objAqa_QuestionsExEN.QuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objAqa_QuestionsExEN.StuId = objDT.Rows[0][conAqa_QuestionsEx.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objAqa_QuestionsExEN.QuestionsId = objDT.Rows[0][conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objAqa_QuestionsExEN.PaperId = objDT.Rows[0][conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objAqa_QuestionsExEN.PaperTitle = objDT.Rows[0][conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objAqa_QuestionsExEN.QuestionsContent = objDT.Rows[0][conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objAqa_QuestionsExEN.QuestionsTypeId = objDT.Rows[0][conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objAqa_QuestionsExEN.QuestionsTypeName = objDT.Rows[0][conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objAqa_QuestionsExEN.StuName = objDT.Rows[0][conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objAqa_QuestionsExEN.StuAnswer = objDT.Rows[0][conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetAqa_QuestionsEx)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strStuId">表关键字</param>
 /// <param name = "strQuestionsId">表关键字</param>
 /// <returns>表对象</returns>
public clsAqa_QuestionsExEN GetObjByKeyLst(string strStuId,string strQuestionsId)
{
CheckPrimaryKey(strStuId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where StuId = " + "'"+ strStuId+"'" + " and QuestionsId = " + "'"+ strQuestionsId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
 objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号(字段类型:varchar,字段长度:20,是否可空:True)
 objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id(字段类型:char,字段长度:8,是否可空:False)
 objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id(字段类型:char,字段长度:8,是否可空:True)
 objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题(字段类型:varchar,字段长度:500,是否可空:False)
 objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容(字段类型:varchar,字段长度:1000,是否可空:True)
 objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id(字段类型:char,字段长度:2,是否可空:False)
 objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称(字段类型:varchar,字段长度:50,是否可空:True)
 objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名(字段类型:varchar,字段长度:50,是否可空:True)
 objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案(字段类型:varchar,字段长度:500,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetObjByKeyLst)", objException.Message));
}
return objAqa_QuestionsExEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsAqa_QuestionsExEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN()
{
StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(), //学号
QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(), //提问Id
PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(), //论文Id
PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(), //论文标题
QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(), //提问内容
QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(), //问题类型Id
QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(), //问题类型名称
StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(), //姓名
StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim() //答案
};
objAqa_QuestionsExEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAqa_QuestionsExEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsAqa_QuestionsExEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetObjByDataRowAqa_QuestionsEx)", objException.Message));
}
objAqa_QuestionsExEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAqa_QuestionsExEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsAqa_QuestionsExEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsAqa_QuestionsExEN objAqa_QuestionsExEN = new clsAqa_QuestionsExEN();
try
{
objAqa_QuestionsExEN.StuId = objRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objAqa_QuestionsExEN.QuestionsId = objRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objAqa_QuestionsExEN.PaperId = objRow[conAqa_QuestionsEx.PaperId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objAqa_QuestionsExEN.PaperTitle = objRow[conAqa_QuestionsEx.PaperTitle] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objAqa_QuestionsExEN.QuestionsContent = objRow[conAqa_QuestionsEx.QuestionsContent] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objAqa_QuestionsExEN.QuestionsTypeId = objRow[conAqa_QuestionsEx.QuestionsTypeId] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objAqa_QuestionsExEN.QuestionsTypeName = objRow[conAqa_QuestionsEx.QuestionsTypeName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objAqa_QuestionsExEN.StuName = objRow[conAqa_QuestionsEx.StuName] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objAqa_QuestionsExEN.StuAnswer = objRow[conAqa_QuestionsEx.StuAnswer] == DBNull.Value ? null : objRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsAqa_QuestionsExDA: GetObjByDataRow)", objException.Message));
}
objAqa_QuestionsExEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objAqa_QuestionsExEN;
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
objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAqa_QuestionsExEN._CurrTabName, conAqa_QuestionsEx.StuId, 20, "");
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
objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsAqa_QuestionsExEN._CurrTabName, conAqa_QuestionsEx.StuId, 20, strPrefix);
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select StuId,QuestionsId from Aqa_QuestionsEx where " + strCondition;
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select StuId,QuestionsId from Aqa_QuestionsEx where " + strCondition;
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
 /// <param name = "strStuId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strStuId, string strQuestionsId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Aqa_QuestionsEx", "StuId = " + "'"+ strStuId+"'" + " and QuestionsId = " + "'"+ strQuestionsId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Aqa_QuestionsEx", strCondition))
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
objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Aqa_QuestionsEx");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
 {
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAqa_QuestionsExEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Aqa_QuestionsEx");
objRow = objDS.Tables["Aqa_QuestionsEx"].NewRow();
objRow[conAqa_QuestionsEx.StuId] = objAqa_QuestionsExEN.StuId; //学号
objRow[conAqa_QuestionsEx.QuestionsId] = objAqa_QuestionsExEN.QuestionsId; //提问Id
 if (objAqa_QuestionsExEN.PaperId !=  "")
 {
objRow[conAqa_QuestionsEx.PaperId] = objAqa_QuestionsExEN.PaperId; //论文Id
 }
 if (objAqa_QuestionsExEN.PaperTitle !=  "")
 {
objRow[conAqa_QuestionsEx.PaperTitle] = objAqa_QuestionsExEN.PaperTitle; //论文标题
 }
 if (objAqa_QuestionsExEN.QuestionsContent !=  "")
 {
objRow[conAqa_QuestionsEx.QuestionsContent] = objAqa_QuestionsExEN.QuestionsContent; //提问内容
 }
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  "")
 {
objRow[conAqa_QuestionsEx.QuestionsTypeId] = objAqa_QuestionsExEN.QuestionsTypeId; //问题类型Id
 }
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  "")
 {
objRow[conAqa_QuestionsEx.QuestionsTypeName] = objAqa_QuestionsExEN.QuestionsTypeName; //问题类型名称
 }
 if (objAqa_QuestionsExEN.StuName !=  "")
 {
objRow[conAqa_QuestionsEx.StuName] = objAqa_QuestionsExEN.StuName; //姓名
 }
 if (objAqa_QuestionsExEN.StuAnswer !=  "")
 {
objRow[conAqa_QuestionsEx.StuAnswer] = objAqa_QuestionsExEN.StuAnswer; //答案
 }
objDS.Tables[clsAqa_QuestionsExEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsAqa_QuestionsExEN._CurrTabName);
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAqa_QuestionsExEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAqa_QuestionsExEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuId);
 var strStuId = objAqa_QuestionsExEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsId);
 var strQuestionsId = objAqa_QuestionsExEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperId);
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperTitle);
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsContent);
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeId);
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeName);
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuName);
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuAnswer);
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswer + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Aqa_QuestionsEx");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAqa_QuestionsExEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAqa_QuestionsExEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuId);
 var strStuId = objAqa_QuestionsExEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsId);
 var strQuestionsId = objAqa_QuestionsExEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperId);
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperTitle);
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsContent);
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeId);
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeName);
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuName);
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuAnswer);
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswer + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Aqa_QuestionsEx");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objAqa_QuestionsExEN.StuId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsAqa_QuestionsExEN objAqa_QuestionsExEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAqa_QuestionsExEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAqa_QuestionsExEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuId);
 var strStuId = objAqa_QuestionsExEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsId);
 var strQuestionsId = objAqa_QuestionsExEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperId);
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperTitle);
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsContent);
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeId);
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeName);
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuName);
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuAnswer);
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswer + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Aqa_QuestionsEx");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objAqa_QuestionsExEN.StuId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsAqa_QuestionsExEN objAqa_QuestionsExEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objAqa_QuestionsExEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objAqa_QuestionsExEN.StuId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuId);
 var strStuId = objAqa_QuestionsExEN.StuId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsId);
 var strQuestionsId = objAqa_QuestionsExEN.QuestionsId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperId);
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperId + "'");
 }
 
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.PaperTitle);
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPaperTitle + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsContent);
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsContent + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeId);
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeId + "'");
 }
 
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.QuestionsTypeName);
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionsTypeName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuName);
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuName + "'");
 }
 
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 arrFieldListForInsert.Add(conAqa_QuestionsEx.StuAnswer);
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStuAnswer + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Aqa_QuestionsEx");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewAqa_QuestionsExs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where StuId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Aqa_QuestionsEx");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strStuId = oRow[conAqa_QuestionsEx.StuId].ToString().Trim();
string strQuestionsId = oRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim();
if (IsExist(strStuId,strQuestionsId))
{
 string strResult = "关键字变量值为:" + string.Format("StuId = {0},QuestionsId = {1}", strStuId,strQuestionsId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsAqa_QuestionsExEN._CurrTabName ].NewRow();
objRow[conAqa_QuestionsEx.StuId] = oRow[conAqa_QuestionsEx.StuId].ToString().Trim(); //学号
objRow[conAqa_QuestionsEx.QuestionsId] = oRow[conAqa_QuestionsEx.QuestionsId].ToString().Trim(); //提问Id
objRow[conAqa_QuestionsEx.PaperId] = oRow[conAqa_QuestionsEx.PaperId].ToString().Trim(); //论文Id
objRow[conAqa_QuestionsEx.PaperTitle] = oRow[conAqa_QuestionsEx.PaperTitle].ToString().Trim(); //论文标题
objRow[conAqa_QuestionsEx.QuestionsContent] = oRow[conAqa_QuestionsEx.QuestionsContent].ToString().Trim(); //提问内容
objRow[conAqa_QuestionsEx.QuestionsTypeId] = oRow[conAqa_QuestionsEx.QuestionsTypeId].ToString().Trim(); //问题类型Id
objRow[conAqa_QuestionsEx.QuestionsTypeName] = oRow[conAqa_QuestionsEx.QuestionsTypeName].ToString().Trim(); //问题类型名称
objRow[conAqa_QuestionsEx.StuName] = oRow[conAqa_QuestionsEx.StuName].ToString().Trim(); //姓名
objRow[conAqa_QuestionsEx.StuAnswer] = oRow[conAqa_QuestionsEx.StuAnswer].ToString().Trim(); //答案
 objDS.Tables[clsAqa_QuestionsExEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsAqa_QuestionsExEN._CurrTabName);
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
 /// <param name = "objAqa_QuestionsExEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAqa_QuestionsExEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
strSQL = "Select * from Aqa_QuestionsEx where StuId = " + "'"+ objAqa_QuestionsExEN.StuId+"'" + " and QuestionsId = " + "'"+ objAqa_QuestionsExEN.QuestionsId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsAqa_QuestionsExEN._CurrTabName);
if (objDS.Tables[clsAqa_QuestionsExEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:StuId = " + "'"+ objAqa_QuestionsExEN.StuId+"'" + " and QuestionsId = " + "'"+ objAqa_QuestionsExEN.QuestionsId+"'");
return false;
}
objRow = objDS.Tables[clsAqa_QuestionsExEN._CurrTabName].Rows[0];
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuId))
 {
objRow[conAqa_QuestionsEx.StuId] = objAqa_QuestionsExEN.StuId; //学号
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsId))
 {
objRow[conAqa_QuestionsEx.QuestionsId] = objAqa_QuestionsExEN.QuestionsId; //提问Id
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperId))
 {
objRow[conAqa_QuestionsEx.PaperId] = objAqa_QuestionsExEN.PaperId; //论文Id
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperTitle))
 {
objRow[conAqa_QuestionsEx.PaperTitle] = objAqa_QuestionsExEN.PaperTitle; //论文标题
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsContent))
 {
objRow[conAqa_QuestionsEx.QuestionsContent] = objAqa_QuestionsExEN.QuestionsContent; //提问内容
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId))
 {
objRow[conAqa_QuestionsEx.QuestionsTypeId] = objAqa_QuestionsExEN.QuestionsTypeId; //问题类型Id
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName))
 {
objRow[conAqa_QuestionsEx.QuestionsTypeName] = objAqa_QuestionsExEN.QuestionsTypeName; //问题类型名称
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuName))
 {
objRow[conAqa_QuestionsEx.StuName] = objAqa_QuestionsExEN.StuName; //姓名
 }
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuAnswer))
 {
objRow[conAqa_QuestionsEx.StuAnswer] = objAqa_QuestionsExEN.StuAnswer; //答案
 }
try
{
objDA.Update(objDS, clsAqa_QuestionsExEN._CurrTabName);
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAqa_QuestionsExEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Aqa_QuestionsEx Set ");
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperId))
 {
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conAqa_QuestionsEx.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.PaperId); //论文Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperTitle))
 {
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conAqa_QuestionsEx.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.PaperTitle); //论文标题
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsContent))
 {
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conAqa_QuestionsEx.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsContent); //提问内容
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeId, conAqa_QuestionsEx.QuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsTypeId); //问题类型Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeName, conAqa_QuestionsEx.QuestionsTypeName); //问题类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsTypeName); //问题类型名称
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuName))
 {
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuName, conAqa_QuestionsEx.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.StuName); //姓名
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuAnswer))
 {
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswer, conAqa_QuestionsEx.StuAnswer); //答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.StuAnswer); //答案
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StuId = '{0}' And QuestionsId = '{1}'", objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId); 
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
 /// <param name = "objAqa_QuestionsExEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strCondition)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAqa_QuestionsExEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Aqa_QuestionsEx Set ");
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperId))
 {
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperTitle))
 {
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsContent))
 {
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeId = '{0}',", strQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" QuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeName = '{0}',", strQuestionsTypeName); //问题类型名称
 }
 else
 {
 sbSQL.Append(" QuestionsTypeName = null,"); //问题类型名称
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuName))
 {
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", strStuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuAnswer))
 {
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswer = '{0}',", strStuAnswer); //答案
 }
 else
 {
 sbSQL.Append(" StuAnswer = null,"); //答案
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
 /// <param name = "objAqa_QuestionsExEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsAqa_QuestionsExEN objAqa_QuestionsExEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAqa_QuestionsExEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Aqa_QuestionsEx Set ");
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperId))
 {
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperId = '{0}',", strPaperId); //论文Id
 }
 else
 {
 sbSQL.Append(" PaperId = null,"); //论文Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperTitle))
 {
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PaperTitle = '{0}',", strPaperTitle); //论文标题
 }
 else
 {
 sbSQL.Append(" PaperTitle = null,"); //论文标题
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsContent))
 {
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsContent = '{0}',", strQuestionsContent); //提问内容
 }
 else
 {
 sbSQL.Append(" QuestionsContent = null,"); //提问内容
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeId = '{0}',", strQuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.Append(" QuestionsTypeId = null,"); //问题类型Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionsTypeName = '{0}',", strQuestionsTypeName); //问题类型名称
 }
 else
 {
 sbSQL.Append(" QuestionsTypeName = null,"); //问题类型名称
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuName))
 {
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuName = '{0}',", strStuName); //姓名
 }
 else
 {
 sbSQL.Append(" StuName = null,"); //姓名
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuAnswer))
 {
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StuAnswer = '{0}',", strStuAnswer); //答案
 }
 else
 {
 sbSQL.Append(" StuAnswer = null,"); //答案
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
 /// <param name = "objAqa_QuestionsExEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsAqa_QuestionsExEN objAqa_QuestionsExEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objAqa_QuestionsExEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objAqa_QuestionsExEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Aqa_QuestionsEx Set ");
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperId))
 {
 if (objAqa_QuestionsExEN.PaperId !=  null)
 {
 var strPaperId = objAqa_QuestionsExEN.PaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperId, conAqa_QuestionsEx.PaperId); //论文Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.PaperId); //论文Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.PaperTitle))
 {
 if (objAqa_QuestionsExEN.PaperTitle !=  null)
 {
 var strPaperTitle = objAqa_QuestionsExEN.PaperTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPaperTitle, conAqa_QuestionsEx.PaperTitle); //论文标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.PaperTitle); //论文标题
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsContent))
 {
 if (objAqa_QuestionsExEN.QuestionsContent !=  null)
 {
 var strQuestionsContent = objAqa_QuestionsExEN.QuestionsContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsContent, conAqa_QuestionsEx.QuestionsContent); //提问内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsContent); //提问内容
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeId))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeId !=  null)
 {
 var strQuestionsTypeId = objAqa_QuestionsExEN.QuestionsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeId, conAqa_QuestionsEx.QuestionsTypeId); //问题类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsTypeId); //问题类型Id
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.QuestionsTypeName))
 {
 if (objAqa_QuestionsExEN.QuestionsTypeName !=  null)
 {
 var strQuestionsTypeName = objAqa_QuestionsExEN.QuestionsTypeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionsTypeName, conAqa_QuestionsEx.QuestionsTypeName); //问题类型名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.QuestionsTypeName); //问题类型名称
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuName))
 {
 if (objAqa_QuestionsExEN.StuName !=  null)
 {
 var strStuName = objAqa_QuestionsExEN.StuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuName, conAqa_QuestionsEx.StuName); //姓名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.StuName); //姓名
 }
 }
 
 if (objAqa_QuestionsExEN.IsUpdated(conAqa_QuestionsEx.StuAnswer))
 {
 if (objAqa_QuestionsExEN.StuAnswer !=  null)
 {
 var strStuAnswer = objAqa_QuestionsExEN.StuAnswer.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStuAnswer, conAqa_QuestionsEx.StuAnswer); //答案
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conAqa_QuestionsEx.StuAnswer); //答案
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where StuId = '{0}' And QuestionsId = '{1}'", objAqa_QuestionsExEN.StuId,objAqa_QuestionsExEN.QuestionsId); 
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
 /// <param name = "strStuId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strStuId,string strQuestionsId) 
{
CheckPrimaryKey(strStuId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strStuId,
 strQuestionsId,
};
 objSQL.ExecSP("Aqa_QuestionsEx_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strStuId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strStuId,string strQuestionsId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strStuId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
//删除Aqa_QuestionsEx本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Aqa_QuestionsEx where StuId = " + "'"+ strStuId+"'" + " and QuestionsId = " + "'"+ strQuestionsId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelRecKeyLsts(List<string> arrKeyLsts)
{
if (arrKeyLsts.Count  == 0) return 0;
int intCount = 0;
foreach (var strKeyLst in arrKeyLsts)
{
string[] sstrKey = strKeyLst.Split('|');
string strStuId = sstrKey[0];
string strQuestionsId = sstrKey[1];
 int intRecNum  = this.DelRecord(strStuId,strQuestionsId);
 intCount += intRecNum;
}
 return intCount;
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strStuId">给定的关键字值</param>
 /// <param name = "strQuestionsId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strStuId,string strQuestionsId) 
{
CheckPrimaryKey(strStuId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
//删除Aqa_QuestionsEx本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Aqa_QuestionsEx where StuId = " + "'"+ strStuId+"'" + " and QuestionsId = " + "'"+ strQuestionsId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelAqa_QuestionsEx(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: DelAqa_QuestionsEx)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Aqa_QuestionsEx where " + strCondition ;
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
public bool DelAqa_QuestionsExWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsAqa_QuestionsExDA: DelAqa_QuestionsExWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Aqa_QuestionsEx where " + strCondition ;
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
 /// <param name = "objAqa_QuestionsExENS">源对象</param>
 /// <param name = "objAqa_QuestionsExENT">目标对象</param>
public void CopyTo(clsAqa_QuestionsExEN objAqa_QuestionsExENS, clsAqa_QuestionsExEN objAqa_QuestionsExENT)
{
objAqa_QuestionsExENT.StuId = objAqa_QuestionsExENS.StuId; //学号
objAqa_QuestionsExENT.QuestionsId = objAqa_QuestionsExENS.QuestionsId; //提问Id
objAqa_QuestionsExENT.PaperId = objAqa_QuestionsExENS.PaperId; //论文Id
objAqa_QuestionsExENT.PaperTitle = objAqa_QuestionsExENS.PaperTitle; //论文标题
objAqa_QuestionsExENT.QuestionsContent = objAqa_QuestionsExENS.QuestionsContent; //提问内容
objAqa_QuestionsExENT.QuestionsTypeId = objAqa_QuestionsExENS.QuestionsTypeId; //问题类型Id
objAqa_QuestionsExENT.QuestionsTypeName = objAqa_QuestionsExENS.QuestionsTypeName; //问题类型名称
objAqa_QuestionsExENT.StuName = objAqa_QuestionsExENS.StuName; //姓名
objAqa_QuestionsExENT.StuAnswer = objAqa_QuestionsExENS.StuAnswer; //答案
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
//检查字段不能为空(NULL)
//检查字段长度
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuId, 20, conAqa_QuestionsEx.StuId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsId, 8, conAqa_QuestionsEx.QuestionsId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperId, 8, conAqa_QuestionsEx.PaperId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperTitle, 500, conAqa_QuestionsEx.PaperTitle);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsContent, 1000, conAqa_QuestionsEx.QuestionsContent);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeId, 2, conAqa_QuestionsEx.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeName, 50, conAqa_QuestionsEx.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuName, 50, conAqa_QuestionsEx.StuName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuAnswer, 500, conAqa_QuestionsEx.StuAnswer);
//检查字段外键固定长度
 objAqa_QuestionsExEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperId, 8, conAqa_QuestionsEx.PaperId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperTitle, 500, conAqa_QuestionsEx.PaperTitle);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsContent, 1000, conAqa_QuestionsEx.QuestionsContent);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeId, 2, conAqa_QuestionsEx.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeName, 50, conAqa_QuestionsEx.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuName, 50, conAqa_QuestionsEx.StuName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuAnswer, 500, conAqa_QuestionsEx.StuAnswer);
//检查外键字段长度
 objAqa_QuestionsExEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsAqa_QuestionsExEN objAqa_QuestionsExEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuId, 20, conAqa_QuestionsEx.StuId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsId, 8, conAqa_QuestionsEx.QuestionsId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperId, 8, conAqa_QuestionsEx.PaperId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.PaperTitle, 500, conAqa_QuestionsEx.PaperTitle);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsContent, 1000, conAqa_QuestionsEx.QuestionsContent);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeId, 2, conAqa_QuestionsEx.QuestionsTypeId);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.QuestionsTypeName, 50, conAqa_QuestionsEx.QuestionsTypeName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuName, 50, conAqa_QuestionsEx.StuName);
clsCheckSql.CheckFieldLen(objAqa_QuestionsExEN.StuAnswer, 500, conAqa_QuestionsEx.StuAnswer);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.StuId, conAqa_QuestionsEx.StuId);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.QuestionsId, conAqa_QuestionsEx.QuestionsId);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.PaperId, conAqa_QuestionsEx.PaperId);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.PaperTitle, conAqa_QuestionsEx.PaperTitle);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.QuestionsContent, conAqa_QuestionsEx.QuestionsContent);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.QuestionsTypeId, conAqa_QuestionsEx.QuestionsTypeId);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.QuestionsTypeName, conAqa_QuestionsEx.QuestionsTypeName);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.StuName, conAqa_QuestionsEx.StuName);
clsCheckSql.CheckSqlInjection4Field(objAqa_QuestionsExEN.StuAnswer, conAqa_QuestionsEx.StuAnswer);
//检查外键字段长度
 objAqa_QuestionsExEN._IsCheckProperty = true;
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAqa_QuestionsExEN._CurrTabName);
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsAqa_QuestionsExEN._CurrTabName, strCondition);
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
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
 objSQL = clsAqa_QuestionsExDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}