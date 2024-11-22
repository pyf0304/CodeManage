
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_CourseKnowledgesDA
 表名:cc_CourseKnowledges(01120082)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:01:51
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
 /// 知识点(cc_CourseKnowledges)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_CourseKnowledgesDA : clsCommBase4DA
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
 return clscc_CourseKnowledgesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_CourseKnowledgesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_CourseKnowledgesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_CourseKnowledgesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_CourseKnowledgesEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCourseKnowledgeId)
{
strCourseKnowledgeId = strCourseKnowledgeId.Replace("'", "''");
if (strCourseKnowledgeId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:cc_CourseKnowledges中,检查关键字,长度不正确!(clscc_CourseKnowledgesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseKnowledgeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:cc_CourseKnowledges中,关键字不能为空 或 null!(clscc_CourseKnowledgesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseKnowledgeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clscc_CourseKnowledgesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_CourseKnowledges(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable_cc_CourseKnowledges)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseKnowledges.* from cc_CourseKnowledges Left Join {1} on {2} where {3} and cc_CourseKnowledges.CourseKnowledgeId not in (Select top {5} cc_CourseKnowledges.CourseKnowledgeId from cc_CourseKnowledges Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {2} CourseKnowledgeId from cc_CourseKnowledges where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {3} CourseKnowledgeId from cc_CourseKnowledges where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_CourseKnowledges.* from cc_CourseKnowledges Left Join {1} on {2} where {3} and cc_CourseKnowledges.CourseKnowledgeId not in (Select top {5} cc_CourseKnowledges.CourseKnowledgeId from cc_CourseKnowledges Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {2} CourseKnowledgeId from cc_CourseKnowledges where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {3} CourseKnowledgeId from cc_CourseKnowledges where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_CourseKnowledgesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA:GetObjLst)", objException.Message));
}
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetObjLst)", objException.Message));
}
objcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseKnowledgesEN);
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
public List<clscc_CourseKnowledgesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_CourseKnowledgesEN> arrObjLst = new List<clscc_CourseKnowledgesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetObjLst)", objException.Message));
}
objcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_CourseKnowledges(ref clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where CourseKnowledgeId = " + "'"+ objcc_CourseKnowledgesEN.CourseKnowledgeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_CourseKnowledgesEN.CourseKnowledgeId = objDT.Rows[0][concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.KnowledgeName = objDT.Rows[0][concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objcc_CourseKnowledgesEN.KnowledgeTitle = objDT.Rows[0][concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeContent = objDT.Rows[0][concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeModuleId = objDT.Rows[0][concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.CourseId = objDT.Rows[0][concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeTypeId = objDT.Rows[0][concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseKnowledgesEN.CourseChapterId = objDT.Rows[0][concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.ModuleWeight = TransNullToDouble(objDT.Rows[0][concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重(字段类型:numeric,字段长度:6,是否可空:True)
 objcc_CourseKnowledgesEN.UserId = objDT.Rows[0][concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseKnowledgesEN.UploadDate = objDT.Rows[0][concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseKnowledgesEN.IsShow = TransNullToBool(objDT.Rows[0][concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseKnowledgesEN.IsCast = TransNullToBool(objDT.Rows[0][concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseKnowledgesEN.LikeCount = TransNullToInt(objDT.Rows[0][concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseKnowledgesEN.OrderNum = TransNullToInt(objDT.Rows[0][concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseKnowledgesEN.UpdDate = objDT.Rows[0][concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseKnowledgesEN.UpdUser = objDT.Rows[0][concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseKnowledgesEN.Memo = objDT.Rows[0][concc_CourseKnowledges.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_CourseKnowledgesDA: Getcc_CourseKnowledges)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
CheckPrimaryKey(strCourseKnowledgeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
 objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重(字段类型:numeric,字段长度:6,是否可空:True)
 objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetObjByCourseKnowledgeId)", objException.Message));
}
return objcc_CourseKnowledgesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_CourseKnowledgesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN()
{
CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(), //知识点名称
KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(), //知识点标题
KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(), //知识点内容
KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(), //知识点模块Id
CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(), //课程Id
KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(), //知识点类型Id
CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(), //课程章节ID
ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()), //模块权重
UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(), //用户ID
UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(), //上传时间
IsShow = TransNullToBool(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()), //是否启用
IsCast = TransNullToBool(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()), //是否播放
LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()), //资源喜欢数量
OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(), //修改人
Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim() //备注
};
objcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseKnowledgesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_CourseKnowledgesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetObjByDataRowcc_CourseKnowledges)", objException.Message));
}
objcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseKnowledgesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_CourseKnowledgesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN = new clscc_CourseKnowledgesEN();
try
{
objcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_CourseKnowledgesEN.KnowledgeName = objRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objcc_CourseKnowledgesEN.KnowledgeTitle = objRow[concc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objcc_CourseKnowledgesEN.KnowledgeContent = objRow[concc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objcc_CourseKnowledgesEN.KnowledgeModuleId = objRow[concc_CourseKnowledges.KnowledgeModuleId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objcc_CourseKnowledgesEN.CourseId = objRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[concc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objcc_CourseKnowledgesEN.CourseChapterId = objRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objcc_CourseKnowledgesEN.ModuleWeight = objRow[concc_CourseKnowledges.ModuleWeight] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim()); //模块权重
objcc_CourseKnowledgesEN.UserId = objRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objcc_CourseKnowledgesEN.UploadDate = objRow[concc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[concc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[concc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objcc_CourseKnowledgesEN.LikeCount = objRow[concc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[concc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objcc_CourseKnowledgesEN.OrderNum = objRow[concc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[concc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objcc_CourseKnowledgesEN.UpdDate = objRow[concc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objcc_CourseKnowledgesEN.UpdUser = objRow[concc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objcc_CourseKnowledgesEN.Memo = objRow[concc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_CourseKnowledgesDA: GetObjByDataRow)", objException.Message));
}
objcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_CourseKnowledgesEN;
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
objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.CourseKnowledgeId, 8, "");
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
objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_CourseKnowledgesEN._CurrTabName, concc_CourseKnowledges.CourseKnowledgeId, 8, strPrefix);
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseKnowledgeId from cc_CourseKnowledges where " + strCondition;
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseKnowledgeId from cc_CourseKnowledges where " + strCondition;
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
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCourseKnowledgeId)
{
CheckPrimaryKey(strCourseKnowledgeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseKnowledges", "CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_CourseKnowledges", strCondition))
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
objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_CourseKnowledges");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
 {
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseKnowledgesEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseKnowledges");
objRow = objDS.Tables["cc_CourseKnowledges"].NewRow();
objRow[concc_CourseKnowledges.CourseKnowledgeId] = objcc_CourseKnowledgesEN.CourseKnowledgeId; //知识点Id
objRow[concc_CourseKnowledges.KnowledgeName] = objcc_CourseKnowledgesEN.KnowledgeName; //知识点名称
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  "")
 {
objRow[concc_CourseKnowledges.KnowledgeTitle] = objcc_CourseKnowledgesEN.KnowledgeTitle; //知识点标题
 }
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  "")
 {
objRow[concc_CourseKnowledges.KnowledgeContent] = objcc_CourseKnowledgesEN.KnowledgeContent; //知识点内容
 }
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  "")
 {
objRow[concc_CourseKnowledges.KnowledgeModuleId] = objcc_CourseKnowledgesEN.KnowledgeModuleId; //知识点模块Id
 }
objRow[concc_CourseKnowledges.CourseId] = objcc_CourseKnowledgesEN.CourseId; //课程Id
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  "")
 {
objRow[concc_CourseKnowledges.KnowledgeTypeId] = objcc_CourseKnowledgesEN.KnowledgeTypeId; //知识点类型Id
 }
objRow[concc_CourseKnowledges.CourseChapterId] = objcc_CourseKnowledgesEN.CourseChapterId; //课程章节ID
objRow[concc_CourseKnowledges.ModuleWeight] = objcc_CourseKnowledgesEN.ModuleWeight; //模块权重
objRow[concc_CourseKnowledges.UserId] = objcc_CourseKnowledgesEN.UserId; //用户ID
 if (objcc_CourseKnowledgesEN.UploadDate !=  "")
 {
objRow[concc_CourseKnowledges.UploadDate] = objcc_CourseKnowledgesEN.UploadDate; //上传时间
 }
objRow[concc_CourseKnowledges.IsShow] = objcc_CourseKnowledgesEN.IsShow; //是否启用
objRow[concc_CourseKnowledges.IsCast] = objcc_CourseKnowledgesEN.IsCast; //是否播放
objRow[concc_CourseKnowledges.LikeCount] = objcc_CourseKnowledgesEN.LikeCount; //资源喜欢数量
objRow[concc_CourseKnowledges.OrderNum] = objcc_CourseKnowledgesEN.OrderNum; //序号
 if (objcc_CourseKnowledgesEN.UpdDate !=  "")
 {
objRow[concc_CourseKnowledges.UpdDate] = objcc_CourseKnowledgesEN.UpdDate; //修改日期
 }
 if (objcc_CourseKnowledgesEN.UpdUser !=  "")
 {
objRow[concc_CourseKnowledges.UpdUser] = objcc_CourseKnowledgesEN.UpdUser; //修改人
 }
 if (objcc_CourseKnowledgesEN.Memo !=  "")
 {
objRow[concc_CourseKnowledges.Memo] = objcc_CourseKnowledgesEN.Memo; //备注
 }
objDS.Tables[clscc_CourseKnowledgesEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_CourseKnowledgesEN._CurrTabName);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseKnowledgesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseKnowledgesEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_CourseKnowledgesEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeName);
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeName + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTitle);
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTitle + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeContent);
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeContent + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeModuleId);
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeModuleId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseId);
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTypeId);
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseChapterId);
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.ModuleWeight);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.ModuleWeight.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UserId);
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UploadDate);
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.LikeCount);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.LikeCount.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.OrderNum);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.OrderNum.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdDate);
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdUser);
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.Memo);
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseKnowledges");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseKnowledgesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseKnowledgesEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_CourseKnowledgesEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeName);
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeName + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTitle);
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTitle + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeContent);
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeContent + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeModuleId);
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeModuleId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseId);
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTypeId);
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseChapterId);
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.ModuleWeight);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.ModuleWeight.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UserId);
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UploadDate);
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.LikeCount);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.LikeCount.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.OrderNum);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.OrderNum.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdDate);
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdUser);
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.Memo);
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseKnowledges");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objcc_CourseKnowledgesEN.CourseKnowledgeId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseKnowledgesEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseKnowledgesEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_CourseKnowledgesEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeName);
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeName + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTitle);
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTitle + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeContent);
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeContent + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeModuleId);
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeModuleId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseId);
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTypeId);
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseChapterId);
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.ModuleWeight);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.ModuleWeight.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UserId);
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UploadDate);
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.LikeCount);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.LikeCount.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.OrderNum);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.OrderNum.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdDate);
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdUser);
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.Memo);
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseKnowledges");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objcc_CourseKnowledgesEN.CourseKnowledgeId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_CourseKnowledgesEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objcc_CourseKnowledgesEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_CourseKnowledgesEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeName);
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeName + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTitle);
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTitle + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeContent);
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeContent + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeModuleId);
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeModuleId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseId);
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.KnowledgeTypeId);
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKnowledgeTypeId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.CourseChapterId);
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseChapterId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.ModuleWeight);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.ModuleWeight.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UserId);
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UploadDate);
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUploadDate + "'");
 }
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsShow);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsShow  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(concc_CourseKnowledges.IsCast);
 arrValueListForInsert.Add("'" + (objcc_CourseKnowledgesEN.IsCast  ==  false ? "0" : "1") + "'");
 
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.LikeCount);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.LikeCount.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.OrderNum);
 arrValueListForInsert.Add(objcc_CourseKnowledgesEN.OrderNum.ToString());
 }
 
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdDate);
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.UpdUser);
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_CourseKnowledges.Memo);
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_CourseKnowledges");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_CourseKnowledgess(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where CourseKnowledgeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_CourseKnowledges");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strCourseKnowledgeId = oRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim();
if (IsExist(strCourseKnowledgeId))
{
 string strResult = "关键字变量值为:" + string.Format("CourseKnowledgeId = {0}", strCourseKnowledgeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_CourseKnowledgesEN._CurrTabName ].NewRow();
objRow[concc_CourseKnowledges.CourseKnowledgeId] = oRow[concc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[concc_CourseKnowledges.KnowledgeName] = oRow[concc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objRow[concc_CourseKnowledges.KnowledgeTitle] = oRow[concc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objRow[concc_CourseKnowledges.KnowledgeContent] = oRow[concc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objRow[concc_CourseKnowledges.KnowledgeModuleId] = oRow[concc_CourseKnowledges.KnowledgeModuleId].ToString().Trim(); //知识点模块Id
objRow[concc_CourseKnowledges.CourseId] = oRow[concc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objRow[concc_CourseKnowledges.KnowledgeTypeId] = oRow[concc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objRow[concc_CourseKnowledges.CourseChapterId] = oRow[concc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objRow[concc_CourseKnowledges.ModuleWeight] = oRow[concc_CourseKnowledges.ModuleWeight].ToString().Trim(); //模块权重
objRow[concc_CourseKnowledges.UserId] = oRow[concc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objRow[concc_CourseKnowledges.UploadDate] = oRow[concc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objRow[concc_CourseKnowledges.IsShow] = oRow[concc_CourseKnowledges.IsShow].ToString().Trim(); //是否启用
objRow[concc_CourseKnowledges.IsCast] = oRow[concc_CourseKnowledges.IsCast].ToString().Trim(); //是否播放
objRow[concc_CourseKnowledges.LikeCount] = oRow[concc_CourseKnowledges.LikeCount].ToString().Trim(); //资源喜欢数量
objRow[concc_CourseKnowledges.OrderNum] = oRow[concc_CourseKnowledges.OrderNum].ToString().Trim(); //序号
objRow[concc_CourseKnowledges.UpdDate] = oRow[concc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objRow[concc_CourseKnowledges.UpdUser] = oRow[concc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objRow[concc_CourseKnowledges.Memo] = oRow[concc_CourseKnowledges.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_CourseKnowledgesEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_CourseKnowledgesEN._CurrTabName);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseKnowledgesEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from cc_CourseKnowledges where CourseKnowledgeId = " + "'"+ objcc_CourseKnowledgesEN.CourseKnowledgeId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_CourseKnowledgesEN._CurrTabName);
if (objDS.Tables[clscc_CourseKnowledgesEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:CourseKnowledgeId = " + "'"+ objcc_CourseKnowledgesEN.CourseKnowledgeId+"'");
return false;
}
objRow = objDS.Tables[clscc_CourseKnowledgesEN._CurrTabName].Rows[0];
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseKnowledgeId))
 {
objRow[concc_CourseKnowledges.CourseKnowledgeId] = objcc_CourseKnowledgesEN.CourseKnowledgeId; //知识点Id
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeName))
 {
objRow[concc_CourseKnowledges.KnowledgeName] = objcc_CourseKnowledgesEN.KnowledgeName; //知识点名称
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTitle))
 {
objRow[concc_CourseKnowledges.KnowledgeTitle] = objcc_CourseKnowledgesEN.KnowledgeTitle; //知识点标题
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeContent))
 {
objRow[concc_CourseKnowledges.KnowledgeContent] = objcc_CourseKnowledgesEN.KnowledgeContent; //知识点内容
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId))
 {
objRow[concc_CourseKnowledges.KnowledgeModuleId] = objcc_CourseKnowledgesEN.KnowledgeModuleId; //知识点模块Id
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseId))
 {
objRow[concc_CourseKnowledges.CourseId] = objcc_CourseKnowledgesEN.CourseId; //课程Id
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId))
 {
objRow[concc_CourseKnowledges.KnowledgeTypeId] = objcc_CourseKnowledgesEN.KnowledgeTypeId; //知识点类型Id
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseChapterId))
 {
objRow[concc_CourseKnowledges.CourseChapterId] = objcc_CourseKnowledgesEN.CourseChapterId; //课程章节ID
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.ModuleWeight))
 {
objRow[concc_CourseKnowledges.ModuleWeight] = objcc_CourseKnowledgesEN.ModuleWeight; //模块权重
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UserId))
 {
objRow[concc_CourseKnowledges.UserId] = objcc_CourseKnowledgesEN.UserId; //用户ID
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UploadDate))
 {
objRow[concc_CourseKnowledges.UploadDate] = objcc_CourseKnowledgesEN.UploadDate; //上传时间
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsShow))
 {
objRow[concc_CourseKnowledges.IsShow] = objcc_CourseKnowledgesEN.IsShow; //是否启用
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsCast))
 {
objRow[concc_CourseKnowledges.IsCast] = objcc_CourseKnowledgesEN.IsCast; //是否播放
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.LikeCount))
 {
objRow[concc_CourseKnowledges.LikeCount] = objcc_CourseKnowledgesEN.LikeCount; //资源喜欢数量
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.OrderNum))
 {
objRow[concc_CourseKnowledges.OrderNum] = objcc_CourseKnowledgesEN.OrderNum; //序号
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdDate))
 {
objRow[concc_CourseKnowledges.UpdDate] = objcc_CourseKnowledgesEN.UpdDate; //修改日期
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdUser))
 {
objRow[concc_CourseKnowledges.UpdUser] = objcc_CourseKnowledgesEN.UpdUser; //修改人
 }
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.Memo))
 {
objRow[concc_CourseKnowledges.Memo] = objcc_CourseKnowledgesEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_CourseKnowledgesEN._CurrTabName);
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseKnowledgesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_CourseKnowledges Set ");
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeName))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeName, concc_CourseKnowledges.KnowledgeName); //知识点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeName); //知识点名称
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTitle))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTitle, concc_CourseKnowledges.KnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeTitle); //知识点标题
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeContent))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeContent, concc_CourseKnowledges.KnowledgeContent); //知识点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeContent); //知识点内容
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeModuleId, concc_CourseKnowledges.KnowledgeModuleId); //知识点模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeModuleId); //知识点模块Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseId))
 {
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseKnowledges.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTypeId, concc_CourseKnowledges.KnowledgeTypeId); //知识点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeTypeId); //知识点类型Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseChapterId))
 {
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseKnowledges.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.ModuleWeight))
 {
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.ModuleWeight, concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UserId))
 {
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseKnowledges.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UserId); //用户ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UploadDate))
 {
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseKnowledges.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseKnowledgesEN.IsShow == true?"1":"0", concc_CourseKnowledges.IsShow); //是否启用
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseKnowledgesEN.IsCast == true?"1":"0", concc_CourseKnowledges.IsCast); //是否播放
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.LikeCount))
 {
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.LikeCount, concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.OrderNum))
 {
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.OrderNum, concc_CourseKnowledges.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.OrderNum); //序号
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdDate))
 {
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseKnowledges.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdUser))
 {
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_CourseKnowledges.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UpdUser); //修改人
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.Memo))
 {
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseKnowledges.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseKnowledgeId = '{0}'", objcc_CourseKnowledgesEN.CourseKnowledgeId); 
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
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCondition)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseKnowledgesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseKnowledges Set ");
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeName))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeName = '{0}',", strKnowledgeName); //知识点名称
 }
 else
 {
 sbSQL.Append(" KnowledgeName = null,"); //知识点名称
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTitle))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTitle = '{0}',", strKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.Append(" KnowledgeTitle = null,"); //知识点标题
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeContent))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeContent = '{0}',", strKnowledgeContent); //知识点内容
 }
 else
 {
 sbSQL.Append(" KnowledgeContent = null,"); //知识点内容
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeModuleId = '{0}',", strKnowledgeModuleId); //知识点模块Id
 }
 else
 {
 sbSQL.Append(" KnowledgeModuleId = null,"); //知识点模块Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseId))
 {
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTypeId = '{0}',", strKnowledgeTypeId); //知识点类型Id
 }
 else
 {
 sbSQL.Append(" KnowledgeTypeId = null,"); //知识点类型Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseChapterId))
 {
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.ModuleWeight))
 {
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.ModuleWeight, concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UserId))
 {
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UploadDate))
 {
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseKnowledgesEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseKnowledgesEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.LikeCount))
 {
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.LikeCount, concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.OrderNum))
 {
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.OrderNum, concc_CourseKnowledges.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.OrderNum); //序号
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdDate))
 {
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdUser))
 {
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.Memo))
 {
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseKnowledgesEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseKnowledgesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseKnowledges Set ");
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeName))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeName = '{0}',", strKnowledgeName); //知识点名称
 }
 else
 {
 sbSQL.Append(" KnowledgeName = null,"); //知识点名称
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTitle))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTitle = '{0}',", strKnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.Append(" KnowledgeTitle = null,"); //知识点标题
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeContent))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeContent = '{0}',", strKnowledgeContent); //知识点内容
 }
 else
 {
 sbSQL.Append(" KnowledgeContent = null,"); //知识点内容
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeModuleId = '{0}',", strKnowledgeModuleId); //知识点模块Id
 }
 else
 {
 sbSQL.Append(" KnowledgeModuleId = null,"); //知识点模块Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseId))
 {
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KnowledgeTypeId = '{0}',", strKnowledgeTypeId); //知识点类型Id
 }
 else
 {
 sbSQL.Append(" KnowledgeTypeId = null,"); //知识点类型Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseChapterId))
 {
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseChapterId = '{0}',", strCourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.Append(" CourseChapterId = null,"); //课程章节ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.ModuleWeight))
 {
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.ModuleWeight, concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UserId))
 {
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户ID
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UploadDate))
 {
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UploadDate = '{0}',", strUploadDate); //上传时间
 }
 else
 {
 sbSQL.Append(" UploadDate = null,"); //上传时间
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsShow))
 {
 sbSQL.AppendFormat(" IsShow = '{0}',", objcc_CourseKnowledgesEN.IsShow == true?"1":"0"); //是否启用
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsCast))
 {
 sbSQL.AppendFormat(" IsCast = '{0}',", objcc_CourseKnowledgesEN.IsCast == true?"1":"0"); //是否播放
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.LikeCount))
 {
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.LikeCount, concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.OrderNum))
 {
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.OrderNum, concc_CourseKnowledges.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.OrderNum); //序号
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdDate))
 {
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdUser))
 {
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.Memo))
 {
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_CourseKnowledgesEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_CourseKnowledgesEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_CourseKnowledgesEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_CourseKnowledgesEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_CourseKnowledges Set ");
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeName))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeName !=  null)
 {
 var strKnowledgeName = objcc_CourseKnowledgesEN.KnowledgeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeName, concc_CourseKnowledges.KnowledgeName); //知识点名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeName); //知识点名称
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTitle))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTitle !=  null)
 {
 var strKnowledgeTitle = objcc_CourseKnowledgesEN.KnowledgeTitle.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTitle, concc_CourseKnowledges.KnowledgeTitle); //知识点标题
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeTitle); //知识点标题
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeContent))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeContent !=  null)
 {
 var strKnowledgeContent = objcc_CourseKnowledgesEN.KnowledgeContent.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeContent, concc_CourseKnowledges.KnowledgeContent); //知识点内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeContent); //知识点内容
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeModuleId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeModuleId !=  null)
 {
 var strKnowledgeModuleId = objcc_CourseKnowledgesEN.KnowledgeModuleId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeModuleId, concc_CourseKnowledges.KnowledgeModuleId); //知识点模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeModuleId); //知识点模块Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseId))
 {
 if (objcc_CourseKnowledgesEN.CourseId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseId !=  null)
 {
 var strCourseId = objcc_CourseKnowledgesEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_CourseKnowledges.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.CourseId); //课程Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.KnowledgeTypeId))
 {
 if (objcc_CourseKnowledgesEN.KnowledgeTypeId !=  null)
 {
 var strKnowledgeTypeId = objcc_CourseKnowledgesEN.KnowledgeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKnowledgeTypeId, concc_CourseKnowledges.KnowledgeTypeId); //知识点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.KnowledgeTypeId); //知识点类型Id
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.CourseChapterId))
 {
 if (objcc_CourseKnowledgesEN.CourseChapterId  ==  "")
 {
 objcc_CourseKnowledgesEN.CourseChapterId = null;
 }
 if (objcc_CourseKnowledgesEN.CourseChapterId !=  null)
 {
 var strCourseChapterId = objcc_CourseKnowledgesEN.CourseChapterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseChapterId, concc_CourseKnowledges.CourseChapterId); //课程章节ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.CourseChapterId); //课程章节ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.ModuleWeight))
 {
 if (objcc_CourseKnowledgesEN.ModuleWeight !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.ModuleWeight, concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.ModuleWeight); //模块权重
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UserId))
 {
 if (objcc_CourseKnowledgesEN.UserId !=  null)
 {
 var strUserId = objcc_CourseKnowledgesEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, concc_CourseKnowledges.UserId); //用户ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UserId); //用户ID
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UploadDate))
 {
 if (objcc_CourseKnowledgesEN.UploadDate !=  null)
 {
 var strUploadDate = objcc_CourseKnowledgesEN.UploadDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUploadDate, concc_CourseKnowledges.UploadDate); //上传时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UploadDate); //上传时间
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsShow))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseKnowledgesEN.IsShow == true?"1":"0", concc_CourseKnowledges.IsShow); //是否启用
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.IsCast))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_CourseKnowledgesEN.IsCast == true?"1":"0", concc_CourseKnowledges.IsCast); //是否播放
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.LikeCount))
 {
 if (objcc_CourseKnowledgesEN.LikeCount !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.LikeCount, concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.LikeCount); //资源喜欢数量
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.OrderNum))
 {
 if (objcc_CourseKnowledgesEN.OrderNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_CourseKnowledgesEN.OrderNum, concc_CourseKnowledges.OrderNum); //序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.OrderNum); //序号
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdDate))
 {
 if (objcc_CourseKnowledgesEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_CourseKnowledgesEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_CourseKnowledges.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UpdDate); //修改日期
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.UpdUser))
 {
 if (objcc_CourseKnowledgesEN.UpdUser !=  null)
 {
 var strUpdUser = objcc_CourseKnowledgesEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, concc_CourseKnowledges.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.UpdUser); //修改人
 }
 }
 
 if (objcc_CourseKnowledgesEN.IsUpdated(concc_CourseKnowledges.Memo))
 {
 if (objcc_CourseKnowledgesEN.Memo !=  null)
 {
 var strMemo = objcc_CourseKnowledgesEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_CourseKnowledges.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_CourseKnowledges.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where CourseKnowledgeId = '{0}'", objcc_CourseKnowledgesEN.CourseKnowledgeId); 
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
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strCourseKnowledgeId) 
{
CheckPrimaryKey(strCourseKnowledgeId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strCourseKnowledgeId,
};
 objSQL.ExecSP("cc_CourseKnowledges_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strCourseKnowledgeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strCourseKnowledgeId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
//删除cc_CourseKnowledges本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseKnowledges where CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_CourseKnowledges(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
//删除cc_CourseKnowledges本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseKnowledges where CourseKnowledgeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strCourseKnowledgeId) 
{
CheckPrimaryKey(strCourseKnowledgeId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
//删除cc_CourseKnowledges本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_CourseKnowledges where CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_CourseKnowledges(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: Delcc_CourseKnowledges)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseKnowledges where " + strCondition ;
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
public bool Delcc_CourseKnowledgesWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_CourseKnowledgesDA: Delcc_CourseKnowledgesWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_CourseKnowledges where " + strCondition ;
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
 /// <param name = "objcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objcc_CourseKnowledgesENT">目标对象</param>
public void CopyTo(clscc_CourseKnowledgesEN objcc_CourseKnowledgesENS, clscc_CourseKnowledgesEN objcc_CourseKnowledgesENT)
{
objcc_CourseKnowledgesENT.CourseKnowledgeId = objcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objcc_CourseKnowledgesENT.KnowledgeName = objcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objcc_CourseKnowledgesENT.KnowledgeTitle = objcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objcc_CourseKnowledgesENT.KnowledgeContent = objcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objcc_CourseKnowledgesENT.KnowledgeModuleId = objcc_CourseKnowledgesENS.KnowledgeModuleId; //知识点模块Id
objcc_CourseKnowledgesENT.CourseId = objcc_CourseKnowledgesENS.CourseId; //课程Id
objcc_CourseKnowledgesENT.KnowledgeTypeId = objcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objcc_CourseKnowledgesENT.CourseChapterId = objcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objcc_CourseKnowledgesENT.ModuleWeight = objcc_CourseKnowledgesENS.ModuleWeight; //模块权重
objcc_CourseKnowledgesENT.UserId = objcc_CourseKnowledgesENS.UserId; //用户ID
objcc_CourseKnowledgesENT.UploadDate = objcc_CourseKnowledgesENS.UploadDate; //上传时间
objcc_CourseKnowledgesENT.IsShow = objcc_CourseKnowledgesENS.IsShow; //是否启用
objcc_CourseKnowledgesENT.IsCast = objcc_CourseKnowledgesENS.IsCast; //是否播放
objcc_CourseKnowledgesENT.LikeCount = objcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objcc_CourseKnowledgesENT.OrderNum = objcc_CourseKnowledgesENS.OrderNum; //序号
objcc_CourseKnowledgesENT.UpdDate = objcc_CourseKnowledgesENS.UpdDate; //修改日期
objcc_CourseKnowledgesENT.UpdUser = objcc_CourseKnowledgesENS.UpdUser; //修改人
objcc_CourseKnowledgesENT.Memo = objcc_CourseKnowledgesENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_CourseKnowledgesEN.KnowledgeName, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldNotNull(objcc_CourseKnowledgesEN.CourseId, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldNotNull(objcc_CourseKnowledgesEN.CourseChapterId, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldNotNull(objcc_CourseKnowledgesEN.UserId, concc_CourseKnowledges.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeName, 100, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTitle, 100, concc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeModuleId, 8, concc_CourseKnowledges.KnowledgeModuleId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UserId, 18, concc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UploadDate, 20, concc_CourseKnowledges.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdDate, 20, concc_CourseKnowledges.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdUser, 20, concc_CourseKnowledges.UpdUser);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.Memo, 1000, concc_CourseKnowledges.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
 objcc_CourseKnowledgesEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeName, 100, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTitle, 100, concc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeModuleId, 8, concc_CourseKnowledges.KnowledgeModuleId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UserId, 18, concc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UploadDate, 20, concc_CourseKnowledges.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdDate, 20, concc_CourseKnowledges.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdUser, 20, concc_CourseKnowledges.UpdUser);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.Memo, 1000, concc_CourseKnowledges.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
 objcc_CourseKnowledgesEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseKnowledgeId, 8, concc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeName, 100, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTitle, 100, concc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeModuleId, 8, concc_CourseKnowledges.KnowledgeModuleId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.KnowledgeTypeId, 4, concc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UserId, 18, concc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UploadDate, 20, concc_CourseKnowledges.UploadDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdDate, 20, concc_CourseKnowledges.UpdDate);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.UpdUser, 20, concc_CourseKnowledges.UpdUser);
clsCheckSql.CheckFieldLen(objcc_CourseKnowledgesEN.Memo, 1000, concc_CourseKnowledges.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.CourseKnowledgeId, concc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.KnowledgeName, concc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.KnowledgeTitle, concc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.KnowledgeModuleId, concc_CourseKnowledges.KnowledgeModuleId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.CourseId, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.KnowledgeTypeId, concc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.CourseChapterId, concc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.UserId, concc_CourseKnowledges.UserId);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.UploadDate, concc_CourseKnowledges.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.UpdDate, concc_CourseKnowledges.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.UpdUser, concc_CourseKnowledges.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objcc_CourseKnowledgesEN.Memo, concc_CourseKnowledges.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseId, 8, concc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_CourseKnowledgesEN.CourseChapterId, 8, concc_CourseKnowledges.CourseChapterId);
 objcc_CourseKnowledgesEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCourseKnowledgeId()
{
//获取某学院所有专业信息
string strSQL = "select CourseKnowledgeId, KnowledgeName from cc_CourseKnowledges ";
 clsSpecSQLforSql mySql = clscc_CourseKnowledgesDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_CourseKnowledges(知识点),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_CourseKnowledgesEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_CourseKnowledgesEN objcc_CourseKnowledgesEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CourseId = '{0}'", objcc_CourseKnowledgesEN.CourseId);
 sbCondition.AppendFormat(" and KnowledgeName = '{0}'", objcc_CourseKnowledgesEN.KnowledgeName);
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseKnowledgesEN._CurrTabName);
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_CourseKnowledgesEN._CurrTabName, strCondition);
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
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
 objSQL = clscc_CourseKnowledgesDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}