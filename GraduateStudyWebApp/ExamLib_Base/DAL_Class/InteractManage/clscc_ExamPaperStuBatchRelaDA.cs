
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_ExamPaperStuBatchRelaDA
 表名:cc_ExamPaperStuBatchRela(01120239)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:09:23
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// 考卷与学生批次关系(cc_ExamPaperStuBatchRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_ExamPaperStuBatchRelaDA : clsCommBase4DA
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
 return clscc_ExamPaperStuBatchRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_ExamPaperStuBatchRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuBatchRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_ExamPaperStuBatchRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_ExamPaperStuBatchRelaEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdPaperStuBatch)
{
strIdPaperStuBatch = strIdPaperStuBatch.Replace("'", "''");
if (strIdPaperStuBatch.Length > 10)
{
throw new Exception("(errid:Data000001)在表:cc_ExamPaperStuBatchRela中,检查关键字,长度不正确!(clscc_ExamPaperStuBatchRelaDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdPaperStuBatch)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_ExamPaperStuBatchRela中,关键字不能为空 或 null!(clscc_ExamPaperStuBatchRelaDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdPaperStuBatch);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_ExamPaperStuBatchRelaDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_ExamPaperStuBatchRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable_cc_ExamPaperStuBatchRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperStuBatchRela.* from cc_ExamPaperStuBatchRela Left Join {1} on {2} where {3} and cc_ExamPaperStuBatchRela.IdPaperStuBatch not in (Select top {5} cc_ExamPaperStuBatchRela.IdPaperStuBatch from cc_ExamPaperStuBatchRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1} and IdPaperStuBatch not in (Select top {2} IdPaperStuBatch from cc_ExamPaperStuBatchRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1} and IdPaperStuBatch not in (Select top {3} IdPaperStuBatch from cc_ExamPaperStuBatchRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_ExamPaperStuBatchRela.* from cc_ExamPaperStuBatchRela Left Join {1} on {2} where {3} and cc_ExamPaperStuBatchRela.IdPaperStuBatch not in (Select top {5} cc_ExamPaperStuBatchRela.IdPaperStuBatch from cc_ExamPaperStuBatchRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1} and IdPaperStuBatch not in (Select top {2} IdPaperStuBatch from cc_ExamPaperStuBatchRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_ExamPaperStuBatchRela where {1} and IdPaperStuBatch not in (Select top {3} IdPaperStuBatch from cc_ExamPaperStuBatchRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_ExamPaperStuBatchRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA:GetObjLst)", objException.Message));
}
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
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
public List<clscc_ExamPaperStuBatchRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_ExamPaperStuBatchRelaEN> arrObjLst = new List<clscc_ExamPaperStuBatchRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetObjLst)", objException.Message));
}
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_ExamPaperStuBatchRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_ExamPaperStuBatchRela(ref clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where IdPaperStuBatch = " + "'"+ objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objDT.Rows[0][concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objDT.Rows[0][concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objDT.Rows[0][concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.BatchTime = objDT.Rows[0][concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objDT.Rows[0][concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.Scores = TransNullToDouble(objDT.Rows[0][concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsSave = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsSubmit = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objDT.Rows[0][concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.OperateTime = objDT.Rows[0][concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsMarking = TransNullToBool(objDT.Rows[0][concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.MarkerId = objDT.Rows[0][concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.MarkDate = objDT.Rows[0][concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerIP = objDT.Rows[0][concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerDate = objDT.Rows[0][concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerTime = objDT.Rows[0][concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.TotalGetScore = TransNullToDouble(objDT.Rows[0][concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分(字段类型:decimal,字段长度:12,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.UpdDate = objDT.Rows[0][concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.UpdUserId = objDT.Rows[0][concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.Memo = objDT.Rows[0][concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: Getcc_ExamPaperStuBatchRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">表关键字</param>
 /// <returns>表对象</returns>
public clscc_ExamPaperStuBatchRelaEN GetObjByIdPaperStuBatch(string strIdPaperStuBatch)
{
CheckPrimaryKey(strIdPaperStuBatch);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where IdPaperStuBatch = " + "'"+ strIdPaperStuBatch+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
 objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号(字段类型:char,字段长度:10,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号(字段类型:char,字段长度:8,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsSave = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsSubmit = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.IsMarking = clsEntityBase2.TransNullToBool_S(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅(字段类型:bit,字段长度:1,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期(字段类型:varchar,字段长度:14,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP(字段类型:varchar,字段长度:30,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期(字段类型:varchar,字段长度:8,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间(字段类型:varchar,字段长度:10,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分(字段类型:decimal,字段长度:12,是否可空:False)
 objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetObjByIdPaperStuBatch)", objException.Message));
}
return objcc_ExamPaperStuBatchRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_ExamPaperStuBatchRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN()
{
IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(), //学生试卷批次流水号
CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(), //考卷流水号
IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(), //学生流水号
BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(), //批次
IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(), //教学班流水号
Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()), //分值
IsSave = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()), //是否保存
IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()), //是否提交
RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(), //实际完成日期
OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(), //操作时间
IsMarking = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()), //是否批阅
MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(), //打分者
MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(), //打分日期
AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(), //回答IP
AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(), //回答日期
AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(), //回答时间
TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()), //考生获取总分
UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim() //备注
};
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuBatchRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperStuBatchRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetObjByDataRowcc_ExamPaperStuBatchRela)", objException.Message));
}
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuBatchRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_ExamPaperStuBatchRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN = new clscc_ExamPaperStuBatchRelaEN();
try
{
objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch = objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = objRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objcc_ExamPaperStuBatchRelaEN.BatchTime = objRow[concc_ExamPaperStuBatchRela.BatchTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objcc_ExamPaperStuBatchRelaEN.Scores = objRow[concc_ExamPaperStuBatchRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim()); //分值
objcc_ExamPaperStuBatchRelaEN.IsSave = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim()); //是否保存
objcc_ExamPaperStuBatchRelaEN.IsSubmit = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim()); //是否提交
objcc_ExamPaperStuBatchRelaEN.RealFinishDate = objRow[concc_ExamPaperStuBatchRela.RealFinishDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objcc_ExamPaperStuBatchRelaEN.OperateTime = objRow[concc_ExamPaperStuBatchRela.OperateTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objcc_ExamPaperStuBatchRelaEN.IsMarking = TransNullToBool(objRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim()); //是否批阅
objcc_ExamPaperStuBatchRelaEN.MarkerId = objRow[concc_ExamPaperStuBatchRela.MarkerId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objcc_ExamPaperStuBatchRelaEN.MarkDate = objRow[concc_ExamPaperStuBatchRela.MarkDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objcc_ExamPaperStuBatchRelaEN.AnswerIP = objRow[concc_ExamPaperStuBatchRela.AnswerIP] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objcc_ExamPaperStuBatchRelaEN.AnswerDate = objRow[concc_ExamPaperStuBatchRela.AnswerDate] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objcc_ExamPaperStuBatchRelaEN.AnswerTime = objRow[concc_ExamPaperStuBatchRela.AnswerTime] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objcc_ExamPaperStuBatchRelaEN.TotalGetScore = objRow[concc_ExamPaperStuBatchRela.TotalGetScore] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim()); //考生获取总分
objcc_ExamPaperStuBatchRelaEN.UpdDate = objRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objcc_ExamPaperStuBatchRelaEN.UpdUserId = objRow[concc_ExamPaperStuBatchRela.UpdUserId] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_ExamPaperStuBatchRelaEN.Memo = objRow[concc_ExamPaperStuBatchRela.Memo] == DBNull.Value ? null : objRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_ExamPaperStuBatchRelaDA: GetObjByDataRow)", objException.Message));
}
objcc_ExamPaperStuBatchRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_ExamPaperStuBatchRelaEN;
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
objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperStuBatchRelaEN._CurrTabName, concc_ExamPaperStuBatchRela.IdPaperStuBatch, 10, "");
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
objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_ExamPaperStuBatchRelaEN._CurrTabName, concc_ExamPaperStuBatchRela.IdPaperStuBatch, 10, strPrefix);
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdPaperStuBatch from cc_ExamPaperStuBatchRela where " + strCondition;
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdPaperStuBatch from cc_ExamPaperStuBatchRela where " + strCondition;
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
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdPaperStuBatch)
{
CheckPrimaryKey(strIdPaperStuBatch);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperStuBatchRela", "IdPaperStuBatch = " + "'"+ strIdPaperStuBatch+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_ExamPaperStuBatchRela", strCondition))
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
objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_ExamPaperStuBatchRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
 {
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperStuBatchRela");
objRow = objDS.Tables["cc_ExamPaperStuBatchRela"].NewRow();
objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch] = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch; //学生试卷批次流水号
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId; //考卷流水号
 }
objRow[concc_ExamPaperStuBatchRela.IdStudentInfo] = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo; //学生流水号
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.BatchTime] = objcc_ExamPaperStuBatchRelaEN.BatchTime; //批次
 }
objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls] = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls; //教学班流水号
objRow[concc_ExamPaperStuBatchRela.Scores] = objcc_ExamPaperStuBatchRelaEN.Scores; //分值
objRow[concc_ExamPaperStuBatchRela.IsSave] = objcc_ExamPaperStuBatchRelaEN.IsSave; //是否保存
objRow[concc_ExamPaperStuBatchRela.IsSubmit] = objcc_ExamPaperStuBatchRelaEN.IsSubmit; //是否提交
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.RealFinishDate] = objcc_ExamPaperStuBatchRelaEN.RealFinishDate; //实际完成日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.OperateTime] = objcc_ExamPaperStuBatchRelaEN.OperateTime; //操作时间
 }
objRow[concc_ExamPaperStuBatchRela.IsMarking] = objcc_ExamPaperStuBatchRelaEN.IsMarking; //是否批阅
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.MarkerId] = objcc_ExamPaperStuBatchRelaEN.MarkerId; //打分者
 }
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.MarkDate] = objcc_ExamPaperStuBatchRelaEN.MarkDate; //打分日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.AnswerIP] = objcc_ExamPaperStuBatchRelaEN.AnswerIP; //回答IP
 }
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.AnswerDate] = objcc_ExamPaperStuBatchRelaEN.AnswerDate; //回答日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.AnswerTime] = objcc_ExamPaperStuBatchRelaEN.AnswerTime; //回答时间
 }
objRow[concc_ExamPaperStuBatchRela.TotalGetScore] = objcc_ExamPaperStuBatchRelaEN.TotalGetScore; //考生获取总分
objRow[concc_ExamPaperStuBatchRela.UpdDate] = objcc_ExamPaperStuBatchRelaEN.UpdDate; //修改日期
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.UpdUserId] = objcc_ExamPaperStuBatchRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  "")
 {
objRow[concc_ExamPaperStuBatchRela.Memo] = objcc_ExamPaperStuBatchRelaEN.Memo; //备注
 }
objDS.Tables[clscc_ExamPaperStuBatchRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_ExamPaperStuBatchRelaEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.BatchTime);
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.Scores.ToString());
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.OperateTime);
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkerId);
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkDate);
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.TotalGetScore);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.TotalGetScore.ToString());
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdDate);
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Memo);
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuBatchRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.BatchTime);
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.Scores.ToString());
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.OperateTime);
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkerId);
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkDate);
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.TotalGetScore);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.TotalGetScore.ToString());
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdDate);
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Memo);
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuBatchRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.BatchTime);
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.Scores.ToString());
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.OperateTime);
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkerId);
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkDate);
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.TotalGetScore);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.TotalGetScore.ToString());
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdDate);
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Memo);
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuBatchRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_ExamPaperStuBatchRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdPaperStuBatch);
 var strIdPaperStuBatch = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdPaperStuBatch + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.CourseExamPaperId);
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseExamPaperId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdStudentInfo);
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdStudentInfo + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.BatchTime);
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strBatchTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IdCurrEduCls);
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strIdCurrEduCls + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Scores);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.Scores.ToString());
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSave);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSave  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsSubmit);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsSubmit  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.RealFinishDate);
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRealFinishDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.OperateTime);
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOperateTime + "'");
 }
 
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.IsMarking);
 arrValueListForInsert.Add("'" + (objcc_ExamPaperStuBatchRelaEN.IsMarking  ==  false ? "0" : "1") + "'");
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkerId);
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkerId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.MarkDate);
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMarkDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerIP);
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerIP + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerDate);
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.AnswerTime);
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnswerTime + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.TotalGetScore);
 arrValueListForInsert.Add(objcc_ExamPaperStuBatchRelaEN.TotalGetScore.ToString());
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdDate);
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.UpdUserId);
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_ExamPaperStuBatchRela.Memo);
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_ExamPaperStuBatchRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_ExamPaperStuBatchRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where IdPaperStuBatch = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_ExamPaperStuBatchRela");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strIdPaperStuBatch = oRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim();
if (IsExist(strIdPaperStuBatch))
{
 string strResult = "关键字变量值为:" + string.Format("IdPaperStuBatch = {0}", strIdPaperStuBatch) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_ExamPaperStuBatchRelaEN._CurrTabName ].NewRow();
objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch] = oRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch].ToString().Trim(); //学生试卷批次流水号
objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] = oRow[concc_ExamPaperStuBatchRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objRow[concc_ExamPaperStuBatchRela.IdStudentInfo] = oRow[concc_ExamPaperStuBatchRela.IdStudentInfo].ToString().Trim(); //学生流水号
objRow[concc_ExamPaperStuBatchRela.BatchTime] = oRow[concc_ExamPaperStuBatchRela.BatchTime].ToString().Trim(); //批次
objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls] = oRow[concc_ExamPaperStuBatchRela.IdCurrEduCls].ToString().Trim(); //教学班流水号
objRow[concc_ExamPaperStuBatchRela.Scores] = oRow[concc_ExamPaperStuBatchRela.Scores].ToString().Trim(); //分值
objRow[concc_ExamPaperStuBatchRela.IsSave] = oRow[concc_ExamPaperStuBatchRela.IsSave].ToString().Trim(); //是否保存
objRow[concc_ExamPaperStuBatchRela.IsSubmit] = oRow[concc_ExamPaperStuBatchRela.IsSubmit].ToString().Trim(); //是否提交
objRow[concc_ExamPaperStuBatchRela.RealFinishDate] = oRow[concc_ExamPaperStuBatchRela.RealFinishDate].ToString().Trim(); //实际完成日期
objRow[concc_ExamPaperStuBatchRela.OperateTime] = oRow[concc_ExamPaperStuBatchRela.OperateTime].ToString().Trim(); //操作时间
objRow[concc_ExamPaperStuBatchRela.IsMarking] = oRow[concc_ExamPaperStuBatchRela.IsMarking].ToString().Trim(); //是否批阅
objRow[concc_ExamPaperStuBatchRela.MarkerId] = oRow[concc_ExamPaperStuBatchRela.MarkerId].ToString().Trim(); //打分者
objRow[concc_ExamPaperStuBatchRela.MarkDate] = oRow[concc_ExamPaperStuBatchRela.MarkDate].ToString().Trim(); //打分日期
objRow[concc_ExamPaperStuBatchRela.AnswerIP] = oRow[concc_ExamPaperStuBatchRela.AnswerIP].ToString().Trim(); //回答IP
objRow[concc_ExamPaperStuBatchRela.AnswerDate] = oRow[concc_ExamPaperStuBatchRela.AnswerDate].ToString().Trim(); //回答日期
objRow[concc_ExamPaperStuBatchRela.AnswerTime] = oRow[concc_ExamPaperStuBatchRela.AnswerTime].ToString().Trim(); //回答时间
objRow[concc_ExamPaperStuBatchRela.TotalGetScore] = oRow[concc_ExamPaperStuBatchRela.TotalGetScore].ToString().Trim(); //考生获取总分
objRow[concc_ExamPaperStuBatchRela.UpdDate] = oRow[concc_ExamPaperStuBatchRela.UpdDate].ToString().Trim(); //修改日期
objRow[concc_ExamPaperStuBatchRela.UpdUserId] = oRow[concc_ExamPaperStuBatchRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_ExamPaperStuBatchRela.Memo] = oRow[concc_ExamPaperStuBatchRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_ExamPaperStuBatchRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_ExamPaperStuBatchRelaEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuBatchRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_ExamPaperStuBatchRela where IdPaperStuBatch = " + "'"+ objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_ExamPaperStuBatchRelaEN._CurrTabName);
if (objDS.Tables[clscc_ExamPaperStuBatchRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:IdPaperStuBatch = " + "'"+ objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch+"'");
return false;
}
objRow = objDS.Tables[clscc_ExamPaperStuBatchRelaEN._CurrTabName].Rows[0];
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdPaperStuBatch))
 {
objRow[concc_ExamPaperStuBatchRela.IdPaperStuBatch] = objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch; //学生试卷批次流水号
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId))
 {
objRow[concc_ExamPaperStuBatchRela.CourseExamPaperId] = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId; //考卷流水号
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo))
 {
objRow[concc_ExamPaperStuBatchRela.IdStudentInfo] = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo; //学生流水号
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime))
 {
objRow[concc_ExamPaperStuBatchRela.BatchTime] = objcc_ExamPaperStuBatchRelaEN.BatchTime; //批次
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls))
 {
objRow[concc_ExamPaperStuBatchRela.IdCurrEduCls] = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls; //教学班流水号
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Scores))
 {
objRow[concc_ExamPaperStuBatchRela.Scores] = objcc_ExamPaperStuBatchRelaEN.Scores; //分值
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSave))
 {
objRow[concc_ExamPaperStuBatchRela.IsSave] = objcc_ExamPaperStuBatchRelaEN.IsSave; //是否保存
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit))
 {
objRow[concc_ExamPaperStuBatchRela.IsSubmit] = objcc_ExamPaperStuBatchRelaEN.IsSubmit; //是否提交
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate))
 {
objRow[concc_ExamPaperStuBatchRela.RealFinishDate] = objcc_ExamPaperStuBatchRelaEN.RealFinishDate; //实际完成日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime))
 {
objRow[concc_ExamPaperStuBatchRela.OperateTime] = objcc_ExamPaperStuBatchRelaEN.OperateTime; //操作时间
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking))
 {
objRow[concc_ExamPaperStuBatchRela.IsMarking] = objcc_ExamPaperStuBatchRelaEN.IsMarking; //是否批阅
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId))
 {
objRow[concc_ExamPaperStuBatchRela.MarkerId] = objcc_ExamPaperStuBatchRelaEN.MarkerId; //打分者
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate))
 {
objRow[concc_ExamPaperStuBatchRela.MarkDate] = objcc_ExamPaperStuBatchRelaEN.MarkDate; //打分日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP))
 {
objRow[concc_ExamPaperStuBatchRela.AnswerIP] = objcc_ExamPaperStuBatchRelaEN.AnswerIP; //回答IP
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate))
 {
objRow[concc_ExamPaperStuBatchRela.AnswerDate] = objcc_ExamPaperStuBatchRelaEN.AnswerDate; //回答日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime))
 {
objRow[concc_ExamPaperStuBatchRela.AnswerTime] = objcc_ExamPaperStuBatchRelaEN.AnswerTime; //回答时间
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore))
 {
objRow[concc_ExamPaperStuBatchRela.TotalGetScore] = objcc_ExamPaperStuBatchRelaEN.TotalGetScore; //考生获取总分
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate))
 {
objRow[concc_ExamPaperStuBatchRela.UpdDate] = objcc_ExamPaperStuBatchRelaEN.UpdDate; //修改日期
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId))
 {
objRow[concc_ExamPaperStuBatchRela.UpdUserId] = objcc_ExamPaperStuBatchRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Memo))
 {
objRow[concc_ExamPaperStuBatchRela.Memo] = objcc_ExamPaperStuBatchRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_ExamPaperStuBatchRelaEN._CurrTabName);
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_ExamPaperStuBatchRela Set ");
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_ExamPaperStuBatchRela.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_ExamPaperStuBatchRela.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchTime, concc_ExamPaperStuBatchRela.BatchTime); //批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.BatchTime); //批次
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_ExamPaperStuBatchRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Scores))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.Scores, concc_ExamPaperStuBatchRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSave == true?"1":"0", concc_ExamPaperStuBatchRela.IsSave); //是否保存
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSubmit == true?"1":"0", concc_ExamPaperStuBatchRela.IsSubmit); //是否提交
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_ExamPaperStuBatchRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_ExamPaperStuBatchRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.OperateTime); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsMarking == true?"1":"0", concc_ExamPaperStuBatchRela.IsMarking); //是否批阅
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_ExamPaperStuBatchRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.MarkerId); //打分者
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_ExamPaperStuBatchRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.MarkDate); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_ExamPaperStuBatchRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerIP); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_ExamPaperStuBatchRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerDate); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_ExamPaperStuBatchRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerTime); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore))
 {
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.TotalGetScore, concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_ExamPaperStuBatchRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_ExamPaperStuBatchRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Memo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperStuBatchRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatch = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch); 
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strCondition)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuBatchRela Set ");
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchTime = '{0}',", strBatchTime); //批次
 }
 else
 {
 sbSQL.Append(" BatchTime = null,"); //批次
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Scores))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.Scores, concc_ExamPaperStuBatchRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore))
 {
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.TotalGetScore, concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Memo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuBatchRela Set ");
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseExamPaperId = '{0}',", strCourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.Append(" CourseExamPaperId = null,"); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdStudentInfo = '{0}',", strIdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.Append(" IdStudentInfo = null,"); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" BatchTime = '{0}',", strBatchTime); //批次
 }
 else
 {
 sbSQL.Append(" BatchTime = null,"); //批次
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" IdCurrEduCls = '{0}',", strIdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.Append(" IdCurrEduCls = null,"); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Scores))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.Scores, concc_ExamPaperStuBatchRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSave))
 {
 sbSQL.AppendFormat(" IsSave = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSave == true?"1":"0"); //是否保存
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit))
 {
 sbSQL.AppendFormat(" IsSubmit = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSubmit == true?"1":"0"); //是否提交
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RealFinishDate = '{0}',", strRealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.Append(" RealFinishDate = null,"); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OperateTime = '{0}',", strOperateTime); //操作时间
 }
 else
 {
 sbSQL.Append(" OperateTime = null,"); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking))
 {
 sbSQL.AppendFormat(" IsMarking = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsMarking == true?"1":"0"); //是否批阅
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkerId = '{0}',", strMarkerId); //打分者
 }
 else
 {
 sbSQL.Append(" MarkerId = null,"); //打分者
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MarkDate = '{0}',", strMarkDate); //打分日期
 }
 else
 {
 sbSQL.Append(" MarkDate = null,"); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerIP = '{0}',", strAnswerIP); //回答IP
 }
 else
 {
 sbSQL.Append(" AnswerIP = null,"); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerDate = '{0}',", strAnswerDate); //回答日期
 }
 else
 {
 sbSQL.Append(" AnswerDate = null,"); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnswerTime = '{0}',", strAnswerTime); //回答时间
 }
 else
 {
 sbSQL.Append(" AnswerTime = null,"); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore))
 {
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.TotalGetScore, concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Memo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_ExamPaperStuBatchRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_ExamPaperStuBatchRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_ExamPaperStuBatchRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_ExamPaperStuBatchRela Set ");
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.CourseExamPaperId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId !=  null)
 {
 var strCourseExamPaperId = objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseExamPaperId, concc_ExamPaperStuBatchRela.CourseExamPaperId); //考卷流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.CourseExamPaperId); //考卷流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdStudentInfo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdStudentInfo = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdStudentInfo !=  null)
 {
 var strIdStudentInfo = objcc_ExamPaperStuBatchRelaEN.IdStudentInfo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdStudentInfo, concc_ExamPaperStuBatchRela.IdStudentInfo); //学生流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.IdStudentInfo); //学生流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.BatchTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.BatchTime !=  null)
 {
 var strBatchTime = objcc_ExamPaperStuBatchRelaEN.BatchTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strBatchTime, concc_ExamPaperStuBatchRela.BatchTime); //批次
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.BatchTime); //批次
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IdCurrEduCls))
 {
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls  ==  "")
 {
 objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls = null;
 }
 if (objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls !=  null)
 {
 var strIdCurrEduCls = objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strIdCurrEduCls, concc_ExamPaperStuBatchRela.IdCurrEduCls); //教学班流水号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.IdCurrEduCls); //教学班流水号
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Scores))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Scores !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.Scores, concc_ExamPaperStuBatchRela.Scores); //分值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Scores); //分值
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSave))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSave == true?"1":"0", concc_ExamPaperStuBatchRela.IsSave); //是否保存
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsSubmit))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsSubmit == true?"1":"0", concc_ExamPaperStuBatchRela.IsSubmit); //是否提交
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.RealFinishDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.RealFinishDate !=  null)
 {
 var strRealFinishDate = objcc_ExamPaperStuBatchRelaEN.RealFinishDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRealFinishDate, concc_ExamPaperStuBatchRela.RealFinishDate); //实际完成日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.RealFinishDate); //实际完成日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.OperateTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.OperateTime !=  null)
 {
 var strOperateTime = objcc_ExamPaperStuBatchRelaEN.OperateTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOperateTime, concc_ExamPaperStuBatchRela.OperateTime); //操作时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.OperateTime); //操作时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.IsMarking))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_ExamPaperStuBatchRelaEN.IsMarking == true?"1":"0", concc_ExamPaperStuBatchRela.IsMarking); //是否批阅
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkerId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkerId !=  null)
 {
 var strMarkerId = objcc_ExamPaperStuBatchRelaEN.MarkerId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkerId, concc_ExamPaperStuBatchRela.MarkerId); //打分者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.MarkerId); //打分者
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.MarkDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.MarkDate !=  null)
 {
 var strMarkDate = objcc_ExamPaperStuBatchRelaEN.MarkDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMarkDate, concc_ExamPaperStuBatchRela.MarkDate); //打分日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.MarkDate); //打分日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerIP))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerIP !=  null)
 {
 var strAnswerIP = objcc_ExamPaperStuBatchRelaEN.AnswerIP.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerIP, concc_ExamPaperStuBatchRela.AnswerIP); //回答IP
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerIP); //回答IP
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerDate !=  null)
 {
 var strAnswerDate = objcc_ExamPaperStuBatchRelaEN.AnswerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerDate, concc_ExamPaperStuBatchRela.AnswerDate); //回答日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerDate); //回答日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.AnswerTime))
 {
 if (objcc_ExamPaperStuBatchRelaEN.AnswerTime !=  null)
 {
 var strAnswerTime = objcc_ExamPaperStuBatchRelaEN.AnswerTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnswerTime, concc_ExamPaperStuBatchRela.AnswerTime); //回答时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.AnswerTime); //回答时间
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.TotalGetScore))
 {
 if (objcc_ExamPaperStuBatchRelaEN.TotalGetScore !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_ExamPaperStuBatchRelaEN.TotalGetScore, concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.TotalGetScore); //考生获取总分
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdDate))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_ExamPaperStuBatchRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_ExamPaperStuBatchRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.UpdUserId))
 {
 if (objcc_ExamPaperStuBatchRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_ExamPaperStuBatchRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_ExamPaperStuBatchRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_ExamPaperStuBatchRelaEN.IsUpdated(concc_ExamPaperStuBatchRela.Memo))
 {
 if (objcc_ExamPaperStuBatchRelaEN.Memo !=  null)
 {
 var strMemo = objcc_ExamPaperStuBatchRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_ExamPaperStuBatchRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_ExamPaperStuBatchRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where IdPaperStuBatch = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch); 
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
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strIdPaperStuBatch) 
{
CheckPrimaryKey(strIdPaperStuBatch);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strIdPaperStuBatch,
};
 objSQL.ExecSP("cc_ExamPaperStuBatchRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strIdPaperStuBatch, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strIdPaperStuBatch);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
//删除cc_ExamPaperStuBatchRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuBatchRela where IdPaperStuBatch = " + "'"+ strIdPaperStuBatch+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_ExamPaperStuBatchRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
//删除cc_ExamPaperStuBatchRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuBatchRela where IdPaperStuBatch in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strIdPaperStuBatch">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strIdPaperStuBatch) 
{
CheckPrimaryKey(strIdPaperStuBatch);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
//删除cc_ExamPaperStuBatchRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_ExamPaperStuBatchRela where IdPaperStuBatch = " + "'"+ strIdPaperStuBatch+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_ExamPaperStuBatchRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: Delcc_ExamPaperStuBatchRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperStuBatchRela where " + strCondition ;
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
public bool Delcc_ExamPaperStuBatchRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_ExamPaperStuBatchRelaDA: Delcc_ExamPaperStuBatchRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_ExamPaperStuBatchRela where " + strCondition ;
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
 /// <param name = "objcc_ExamPaperStuBatchRelaENS">源对象</param>
 /// <param name = "objcc_ExamPaperStuBatchRelaENT">目标对象</param>
public void CopyTo(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENS, clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaENT)
{
objcc_ExamPaperStuBatchRelaENT.IdPaperStuBatch = objcc_ExamPaperStuBatchRelaENS.IdPaperStuBatch; //学生试卷批次流水号
objcc_ExamPaperStuBatchRelaENT.CourseExamPaperId = objcc_ExamPaperStuBatchRelaENS.CourseExamPaperId; //考卷流水号
objcc_ExamPaperStuBatchRelaENT.IdStudentInfo = objcc_ExamPaperStuBatchRelaENS.IdStudentInfo; //学生流水号
objcc_ExamPaperStuBatchRelaENT.BatchTime = objcc_ExamPaperStuBatchRelaENS.BatchTime; //批次
objcc_ExamPaperStuBatchRelaENT.IdCurrEduCls = objcc_ExamPaperStuBatchRelaENS.IdCurrEduCls; //教学班流水号
objcc_ExamPaperStuBatchRelaENT.Scores = objcc_ExamPaperStuBatchRelaENS.Scores; //分值
objcc_ExamPaperStuBatchRelaENT.IsSave = objcc_ExamPaperStuBatchRelaENS.IsSave; //是否保存
objcc_ExamPaperStuBatchRelaENT.IsSubmit = objcc_ExamPaperStuBatchRelaENS.IsSubmit; //是否提交
objcc_ExamPaperStuBatchRelaENT.RealFinishDate = objcc_ExamPaperStuBatchRelaENS.RealFinishDate; //实际完成日期
objcc_ExamPaperStuBatchRelaENT.OperateTime = objcc_ExamPaperStuBatchRelaENS.OperateTime; //操作时间
objcc_ExamPaperStuBatchRelaENT.IsMarking = objcc_ExamPaperStuBatchRelaENS.IsMarking; //是否批阅
objcc_ExamPaperStuBatchRelaENT.MarkerId = objcc_ExamPaperStuBatchRelaENS.MarkerId; //打分者
objcc_ExamPaperStuBatchRelaENT.MarkDate = objcc_ExamPaperStuBatchRelaENS.MarkDate; //打分日期
objcc_ExamPaperStuBatchRelaENT.AnswerIP = objcc_ExamPaperStuBatchRelaENS.AnswerIP; //回答IP
objcc_ExamPaperStuBatchRelaENT.AnswerDate = objcc_ExamPaperStuBatchRelaENS.AnswerDate; //回答日期
objcc_ExamPaperStuBatchRelaENT.AnswerTime = objcc_ExamPaperStuBatchRelaENS.AnswerTime; //回答时间
objcc_ExamPaperStuBatchRelaENT.TotalGetScore = objcc_ExamPaperStuBatchRelaENS.TotalGetScore; //考生获取总分
objcc_ExamPaperStuBatchRelaENT.UpdDate = objcc_ExamPaperStuBatchRelaENS.UpdDate; //修改日期
objcc_ExamPaperStuBatchRelaENT.UpdUserId = objcc_ExamPaperStuBatchRelaENS.UpdUserId; //修改用户Id
objcc_ExamPaperStuBatchRelaENT.Memo = objcc_ExamPaperStuBatchRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, concc_ExamPaperStuBatchRela.IdCurrEduCls);
clsCheckSql.CheckFieldNotNull(objcc_ExamPaperStuBatchRelaEN.UpdDate, concc_ExamPaperStuBatchRela.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, 10, concc_ExamPaperStuBatchRela.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.BatchTime, 14, concc_ExamPaperStuBatchRela.BatchTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.RealFinishDate, 14, concc_ExamPaperStuBatchRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.OperateTime, 14, concc_ExamPaperStuBatchRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkerId, 20, concc_ExamPaperStuBatchRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkDate, 14, concc_ExamPaperStuBatchRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerIP, 30, concc_ExamPaperStuBatchRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerDate, 8, concc_ExamPaperStuBatchRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerTime, 10, concc_ExamPaperStuBatchRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdDate, 20, concc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdUserId, 20, concc_ExamPaperStuBatchRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.Memo, 1000, concc_ExamPaperStuBatchRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
 objcc_ExamPaperStuBatchRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.BatchTime, 14, concc_ExamPaperStuBatchRela.BatchTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.RealFinishDate, 14, concc_ExamPaperStuBatchRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.OperateTime, 14, concc_ExamPaperStuBatchRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkerId, 20, concc_ExamPaperStuBatchRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkDate, 14, concc_ExamPaperStuBatchRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerIP, 30, concc_ExamPaperStuBatchRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerDate, 8, concc_ExamPaperStuBatchRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerTime, 10, concc_ExamPaperStuBatchRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdDate, 20, concc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdUserId, 20, concc_ExamPaperStuBatchRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.Memo, 1000, concc_ExamPaperStuBatchRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
 objcc_ExamPaperStuBatchRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, 10, concc_ExamPaperStuBatchRela.IdPaperStuBatch);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.BatchTime, 14, concc_ExamPaperStuBatchRela.BatchTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.RealFinishDate, 14, concc_ExamPaperStuBatchRela.RealFinishDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.OperateTime, 14, concc_ExamPaperStuBatchRela.OperateTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkerId, 20, concc_ExamPaperStuBatchRela.MarkerId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.MarkDate, 14, concc_ExamPaperStuBatchRela.MarkDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerIP, 30, concc_ExamPaperStuBatchRela.AnswerIP);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerDate, 8, concc_ExamPaperStuBatchRela.AnswerDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.AnswerTime, 10, concc_ExamPaperStuBatchRela.AnswerTime);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdDate, 20, concc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.UpdUserId, 20, concc_ExamPaperStuBatchRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_ExamPaperStuBatchRelaEN.Memo, 1000, concc_ExamPaperStuBatchRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.IdPaperStuBatch, concc_ExamPaperStuBatchRela.IdPaperStuBatch);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.BatchTime, concc_ExamPaperStuBatchRela.BatchTime);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, concc_ExamPaperStuBatchRela.IdCurrEduCls);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.RealFinishDate, concc_ExamPaperStuBatchRela.RealFinishDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.OperateTime, concc_ExamPaperStuBatchRela.OperateTime);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.MarkerId, concc_ExamPaperStuBatchRela.MarkerId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.MarkDate, concc_ExamPaperStuBatchRela.MarkDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.AnswerIP, concc_ExamPaperStuBatchRela.AnswerIP);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.AnswerDate, concc_ExamPaperStuBatchRela.AnswerDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.AnswerTime, concc_ExamPaperStuBatchRela.AnswerTime);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.UpdDate, concc_ExamPaperStuBatchRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.UpdUserId, concc_ExamPaperStuBatchRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_ExamPaperStuBatchRelaEN.Memo, concc_ExamPaperStuBatchRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId, 8, concc_ExamPaperStuBatchRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdStudentInfo, 8, concc_ExamPaperStuBatchRela.IdStudentInfo);
clsCheckSql.CheckFieldForeignKey(objcc_ExamPaperStuBatchRelaEN.IdCurrEduCls, 8, concc_ExamPaperStuBatchRela.IdCurrEduCls);
 objcc_ExamPaperStuBatchRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_ExamPaperStuBatchRela(考卷与学生批次关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_ExamPaperStuBatchRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_ExamPaperStuBatchRelaEN objcc_ExamPaperStuBatchRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId == null)
{
 sbCondition.AppendFormat(" and CourseExamPaperId is null");
}
else
{
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objcc_ExamPaperStuBatchRelaEN.CourseExamPaperId);
}
 sbCondition.AppendFormat(" and IdStudentInfo = '{0}'", objcc_ExamPaperStuBatchRelaEN.IdStudentInfo);
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperStuBatchRelaEN._CurrTabName);
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_ExamPaperStuBatchRelaEN._CurrTabName, strCondition);
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_ExamPaperStuBatchRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}