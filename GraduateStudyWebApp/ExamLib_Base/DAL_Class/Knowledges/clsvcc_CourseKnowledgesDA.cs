
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseKnowledgesDA
 表名:vcc_CourseKnowledges(01120141)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:04:18
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
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
 /// v课程知识点(vcc_CourseKnowledges)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseKnowledgesDA : clsCommBase4DA
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
 return clsvcc_CourseKnowledgesEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseKnowledgesEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseKnowledgesEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseKnowledgesEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseKnowledgesEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vcc_CourseKnowledges中,检查关键字,长度不正确!(clsvcc_CourseKnowledgesDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCourseKnowledgeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vcc_CourseKnowledges中,关键字不能为空 或 null!(clsvcc_CourseKnowledgesDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCourseKnowledgeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvcc_CourseKnowledgesDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseKnowledges(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable_vcc_CourseKnowledges)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseKnowledges.* from vcc_CourseKnowledges Left Join {1} on {2} where {3} and vcc_CourseKnowledges.CourseKnowledgeId not in (Select top {5} vcc_CourseKnowledges.CourseKnowledgeId from vcc_CourseKnowledges Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {2} CourseKnowledgeId from vcc_CourseKnowledges where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {3} CourseKnowledgeId from vcc_CourseKnowledges where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseKnowledges.* from vcc_CourseKnowledges Left Join {1} on {2} where {3} and vcc_CourseKnowledges.CourseKnowledgeId not in (Select top {5} vcc_CourseKnowledges.CourseKnowledgeId from vcc_CourseKnowledges Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {2} CourseKnowledgeId from vcc_CourseKnowledges where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseKnowledges where {1} and CourseKnowledgeId not in (Select top {3} CourseKnowledgeId from vcc_CourseKnowledges where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseKnowledgesEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetObjLst)", objException.Message));
}
objvcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
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
public List<clsvcc_CourseKnowledgesEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseKnowledgesEN> arrObjLst = new List<clsvcc_CourseKnowledgesEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetObjLst)", objException.Message));
}
objvcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseKnowledgesEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseKnowledges(ref clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where CourseKnowledgeId = " + "'"+ objvcc_CourseKnowledgesEN.CourseKnowledgeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseKnowledgesEN.CourseKnowledgeId = objDT.Rows[0][convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseKnowledgesEN.KnowledgeName = objDT.Rows[0][convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseKnowledgesEN.KnowledgeTitle = objDT.Rows[0][convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeContent = objDT.Rows[0][convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseId = objDT.Rows[0][convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseCode = objDT.Rows[0][convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseName = objDT.Rows[0][convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseChapterId = objDT.Rows[0][convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseKnowledgesEN.UserId = objDT.Rows[0][convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterId = objDT.Rows[0][convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.UploadDate = objDT.Rows[0][convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_CourseKnowledgesEN.SectionId = objDT.Rows[0][convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.IsShow = TransNullToBool(objDT.Rows[0][convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterName = objDT.Rows[0][convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.IsCast = TransNullToBool(objDT.Rows[0][convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseKnowledgesEN.SectionName = objDT.Rows[0][convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.LikeCount = TransNullToInt(objDT.Rows[0][convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterNameSim = objDT.Rows[0][convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseKnowledgesEN.UpdDate = objDT.Rows[0][convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.SectionNameSim = objDT.Rows[0][convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseKnowledgesEN.Memo = objDT.Rows[0][convcc_CourseKnowledges.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseKnowledgesEN.QuestionNum = TransNullToInt(objDT.Rows[0][convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.UpdUser = objDT.Rows[0][convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeTypeId = objDT.Rows[0][convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeTypeName = objDT.Rows[0][convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: Getvcc_CourseKnowledges)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCourseKnowledgeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseKnowledgesEN GetObjByCourseKnowledgeId(string strCourseKnowledgeId)
{
CheckPrimaryKey(strCourseKnowledgeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
 objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间(字段类型:varchar,字段长度:20,是否可空:False)
 objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.IsCast = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetObjByCourseKnowledgeId)", objException.Message));
}
return objvcc_CourseKnowledgesEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseKnowledgesEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseKnowledges where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN()
{
CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(), //知识点名称
KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(), //知识点标题
KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(), //知识点内容
CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(), //课程章节ID
UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(), //用户ID
ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(), //章Id
UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(), //上传时间
SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(), //节Id
IsShow = TransNullToBool(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()), //是否启用
ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(), //章名
IsCast = TransNullToBool(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()), //是否播放
SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(), //节名
LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()), //资源喜欢数量
ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(), //章名简称
UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(), //修改日期
SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(), //节名简称
Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(), //备注
QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()), //题目数
OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()), //序号
UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(), //修改人
KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(), //知识点类型Id
KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim() //知识点类型名
};
objvcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseKnowledgesEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseKnowledgesEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetObjByDataRowvcc_CourseKnowledges)", objException.Message));
}
objvcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseKnowledgesEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseKnowledgesEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN();
try
{
objvcc_CourseKnowledgesEN.CourseKnowledgeId = objRow[convcc_CourseKnowledges.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_CourseKnowledgesEN.KnowledgeName = objRow[convcc_CourseKnowledges.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_CourseKnowledgesEN.KnowledgeTitle = objRow[convcc_CourseKnowledges.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_CourseKnowledgesEN.KnowledgeContent = objRow[convcc_CourseKnowledges.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_CourseKnowledgesEN.CourseId = objRow[convcc_CourseKnowledges.CourseId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseId].ToString().Trim(); //课程Id
objvcc_CourseKnowledgesEN.CourseCode = objRow[convcc_CourseKnowledges.CourseCode] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseCode].ToString().Trim(); //课程代码
objvcc_CourseKnowledgesEN.CourseName = objRow[convcc_CourseKnowledges.CourseName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.CourseName].ToString().Trim(); //课程名称
objvcc_CourseKnowledgesEN.CourseChapterId = objRow[convcc_CourseKnowledges.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseKnowledgesEN.UserId = objRow[convcc_CourseKnowledges.UserId].ToString().Trim(); //用户ID
objvcc_CourseKnowledgesEN.ChapterId = objRow[convcc_CourseKnowledges.ChapterId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterId].ToString().Trim(); //章Id
objvcc_CourseKnowledgesEN.UploadDate = objRow[convcc_CourseKnowledges.UploadDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UploadDate].ToString().Trim(); //上传时间
objvcc_CourseKnowledgesEN.SectionId = objRow[convcc_CourseKnowledges.SectionId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionId].ToString().Trim(); //节Id
objvcc_CourseKnowledgesEN.IsShow = TransNullToBool(objRow[convcc_CourseKnowledges.IsShow].ToString().Trim()); //是否启用
objvcc_CourseKnowledgesEN.ChapterName = objRow[convcc_CourseKnowledges.ChapterName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterName].ToString().Trim(); //章名
objvcc_CourseKnowledgesEN.IsCast = TransNullToBool(objRow[convcc_CourseKnowledges.IsCast].ToString().Trim()); //是否播放
objvcc_CourseKnowledgesEN.SectionName = objRow[convcc_CourseKnowledges.SectionName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionName].ToString().Trim(); //节名
objvcc_CourseKnowledgesEN.LikeCount = objRow[convcc_CourseKnowledges.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseKnowledges.LikeCount].ToString().Trim()); //资源喜欢数量
objvcc_CourseKnowledgesEN.ChapterNameSim = objRow[convcc_CourseKnowledges.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_CourseKnowledgesEN.UpdDate = objRow[convcc_CourseKnowledges.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseKnowledgesEN.SectionNameSim = objRow[convcc_CourseKnowledges.SectionNameSim] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.SectionNameSim].ToString().Trim(); //节名简称
objvcc_CourseKnowledgesEN.Memo = objRow[convcc_CourseKnowledges.Memo] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.Memo].ToString().Trim(); //备注
objvcc_CourseKnowledgesEN.QuestionNum = objRow[convcc_CourseKnowledges.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.QuestionNum].ToString().Trim()); //题目数
objvcc_CourseKnowledgesEN.OrderNum = objRow[convcc_CourseKnowledges.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseKnowledges.OrderNum].ToString().Trim()); //序号
objvcc_CourseKnowledgesEN.UpdUser = objRow[convcc_CourseKnowledges.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.UpdUser].ToString().Trim(); //修改人
objvcc_CourseKnowledgesEN.KnowledgeTypeId = objRow[convcc_CourseKnowledges.KnowledgeTypeId] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeId].ToString().Trim(); //知识点类型Id
objvcc_CourseKnowledgesEN.KnowledgeTypeName = objRow[convcc_CourseKnowledges.KnowledgeTypeName] == DBNull.Value ? null : objRow[convcc_CourseKnowledges.KnowledgeTypeName].ToString().Trim(); //知识点类型名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseKnowledgesDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseKnowledgesEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseKnowledgesEN;
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
objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseKnowledgesEN._CurrTabName, convcc_CourseKnowledges.CourseKnowledgeId, 8, "");
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
objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseKnowledgesEN._CurrTabName, convcc_CourseKnowledges.CourseKnowledgeId, 8, strPrefix);
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CourseKnowledgeId from vcc_CourseKnowledges where " + strCondition;
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CourseKnowledgeId from vcc_CourseKnowledges where " + strCondition;
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseKnowledges", "CourseKnowledgeId = " + "'"+ strCourseKnowledgeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseKnowledgesDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseKnowledges", strCondition))
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
objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseKnowledges");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseKnowledgesENS">源对象</param>
 /// <param name = "objvcc_CourseKnowledgesENT">目标对象</param>
public void CopyTo(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENS, clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesENT)
{
objvcc_CourseKnowledgesENT.CourseKnowledgeId = objvcc_CourseKnowledgesENS.CourseKnowledgeId; //知识点Id
objvcc_CourseKnowledgesENT.KnowledgeName = objvcc_CourseKnowledgesENS.KnowledgeName; //知识点名称
objvcc_CourseKnowledgesENT.KnowledgeTitle = objvcc_CourseKnowledgesENS.KnowledgeTitle; //知识点标题
objvcc_CourseKnowledgesENT.KnowledgeContent = objvcc_CourseKnowledgesENS.KnowledgeContent; //知识点内容
objvcc_CourseKnowledgesENT.CourseId = objvcc_CourseKnowledgesENS.CourseId; //课程Id
objvcc_CourseKnowledgesENT.CourseCode = objvcc_CourseKnowledgesENS.CourseCode; //课程代码
objvcc_CourseKnowledgesENT.CourseName = objvcc_CourseKnowledgesENS.CourseName; //课程名称
objvcc_CourseKnowledgesENT.CourseChapterId = objvcc_CourseKnowledgesENS.CourseChapterId; //课程章节ID
objvcc_CourseKnowledgesENT.UserId = objvcc_CourseKnowledgesENS.UserId; //用户ID
objvcc_CourseKnowledgesENT.ChapterId = objvcc_CourseKnowledgesENS.ChapterId; //章Id
objvcc_CourseKnowledgesENT.UploadDate = objvcc_CourseKnowledgesENS.UploadDate; //上传时间
objvcc_CourseKnowledgesENT.SectionId = objvcc_CourseKnowledgesENS.SectionId; //节Id
objvcc_CourseKnowledgesENT.IsShow = objvcc_CourseKnowledgesENS.IsShow; //是否启用
objvcc_CourseKnowledgesENT.ChapterName = objvcc_CourseKnowledgesENS.ChapterName; //章名
objvcc_CourseKnowledgesENT.IsCast = objvcc_CourseKnowledgesENS.IsCast; //是否播放
objvcc_CourseKnowledgesENT.SectionName = objvcc_CourseKnowledgesENS.SectionName; //节名
objvcc_CourseKnowledgesENT.LikeCount = objvcc_CourseKnowledgesENS.LikeCount; //资源喜欢数量
objvcc_CourseKnowledgesENT.ChapterNameSim = objvcc_CourseKnowledgesENS.ChapterNameSim; //章名简称
objvcc_CourseKnowledgesENT.UpdDate = objvcc_CourseKnowledgesENS.UpdDate; //修改日期
objvcc_CourseKnowledgesENT.SectionNameSim = objvcc_CourseKnowledgesENS.SectionNameSim; //节名简称
objvcc_CourseKnowledgesENT.Memo = objvcc_CourseKnowledgesENS.Memo; //备注
objvcc_CourseKnowledgesENT.QuestionNum = objvcc_CourseKnowledgesENS.QuestionNum; //题目数
objvcc_CourseKnowledgesENT.OrderNum = objvcc_CourseKnowledgesENS.OrderNum; //序号
objvcc_CourseKnowledgesENT.UpdUser = objvcc_CourseKnowledgesENS.UpdUser; //修改人
objvcc_CourseKnowledgesENT.KnowledgeTypeId = objvcc_CourseKnowledgesENS.KnowledgeTypeId; //知识点类型Id
objvcc_CourseKnowledgesENT.KnowledgeTypeName = objvcc_CourseKnowledgesENS.KnowledgeTypeName; //知识点类型名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseKnowledgesEN objvcc_CourseKnowledgesEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.CourseKnowledgeId, 8, convcc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.KnowledgeName, 100, convcc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.KnowledgeTitle, 100, convcc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.CourseId, 8, convcc_CourseKnowledges.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.CourseCode, 20, convcc_CourseKnowledges.CourseCode);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.CourseName, 100, convcc_CourseKnowledges.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.CourseChapterId, 8, convcc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.UserId, 18, convcc_CourseKnowledges.UserId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.ChapterId, 8, convcc_CourseKnowledges.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.UploadDate, 20, convcc_CourseKnowledges.UploadDate);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.SectionId, 8, convcc_CourseKnowledges.SectionId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.ChapterName, 100, convcc_CourseKnowledges.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.SectionName, 100, convcc_CourseKnowledges.SectionName);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.ChapterNameSim, 10, convcc_CourseKnowledges.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.UpdDate, 20, convcc_CourseKnowledges.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.SectionNameSim, 10, convcc_CourseKnowledges.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.Memo, 1000, convcc_CourseKnowledges.Memo);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.UpdUser, 20, convcc_CourseKnowledges.UpdUser);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.KnowledgeTypeId, 4, convcc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseKnowledgesEN.KnowledgeTypeName, 50, convcc_CourseKnowledges.KnowledgeTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.CourseKnowledgeId, convcc_CourseKnowledges.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.KnowledgeName, convcc_CourseKnowledges.KnowledgeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.KnowledgeTitle, convcc_CourseKnowledges.KnowledgeTitle);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.CourseId, convcc_CourseKnowledges.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.CourseCode, convcc_CourseKnowledges.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.CourseName, convcc_CourseKnowledges.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.CourseChapterId, convcc_CourseKnowledges.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.UserId, convcc_CourseKnowledges.UserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.ChapterId, convcc_CourseKnowledges.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.UploadDate, convcc_CourseKnowledges.UploadDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.SectionId, convcc_CourseKnowledges.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.ChapterName, convcc_CourseKnowledges.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.SectionName, convcc_CourseKnowledges.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.ChapterNameSim, convcc_CourseKnowledges.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.UpdDate, convcc_CourseKnowledges.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.SectionNameSim, convcc_CourseKnowledges.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.Memo, convcc_CourseKnowledges.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.UpdUser, convcc_CourseKnowledges.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.KnowledgeTypeId, convcc_CourseKnowledges.KnowledgeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseKnowledgesEN.KnowledgeTypeName, convcc_CourseKnowledges.KnowledgeTypeName);
//检查外键字段长度
 objvcc_CourseKnowledgesEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseKnowledgesEN._CurrTabName);
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseKnowledgesEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseKnowledgesDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}