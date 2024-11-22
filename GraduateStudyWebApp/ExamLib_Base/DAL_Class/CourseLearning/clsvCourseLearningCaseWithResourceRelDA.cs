
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseWithResourceRelDA
 表名:vCourseLearningCaseWithResourceRel(01120472)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:46:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
 /// v课程学习案例With资源关系(vCourseLearningCaseWithResourceRel)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCourseLearningCaseWithResourceRelDA : clsCommBase4DA
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
 return clsvCourseLearningCaseWithResourceRelEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCourseLearningCaseWithResourceRelEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseWithResourceRelEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCourseLearningCaseWithResourceRelEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCourseLearningCaseWithResourceRelEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strIdCourseLearningCase)
{
strIdCourseLearningCase = strIdCourseLearningCase.Replace("'", "''");
if (strIdCourseLearningCase.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vCourseLearningCaseWithResourceRel中,检查关键字,长度不正确!(clsvCourseLearningCaseWithResourceRelDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strIdCourseLearningCase)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCourseLearningCaseWithResourceRel中,关键字不能为空 或 null!(clsvCourseLearningCaseWithResourceRelDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strIdCourseLearningCase);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCourseLearningCaseWithResourceRelDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCourseLearningCaseWithResourceRel(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable_vCourseLearningCaseWithResourceRel)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseWithResourceRel.* from vCourseLearningCaseWithResourceRel Left Join {1} on {2} where {3} and vCourseLearningCaseWithResourceRel.IdCourseLearningCase not in (Select top {5} vCourseLearningCaseWithResourceRel.IdCourseLearningCase from vCourseLearningCaseWithResourceRel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCaseWithResourceRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCaseWithResourceRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vCourseLearningCaseWithResourceRel.* from vCourseLearningCaseWithResourceRel Left Join {1} on {2} where {3} and vCourseLearningCaseWithResourceRel.IdCourseLearningCase not in (Select top {5} vCourseLearningCaseWithResourceRel.IdCourseLearningCase from vCourseLearningCaseWithResourceRel Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1} and IdCourseLearningCase not in (Select top {2} IdCourseLearningCase from vCourseLearningCaseWithResourceRel where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCourseLearningCaseWithResourceRel where {1} and IdCourseLearningCase not in (Select top {3} IdCourseLearningCase from vCourseLearningCaseWithResourceRel where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCourseLearningCaseWithResourceRelEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA:GetObjLst)", objException.Message));
}
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
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
public List<clsvCourseLearningCaseWithResourceRelEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCourseLearningCaseWithResourceRelEN> arrObjLst = new List<clsvCourseLearningCaseWithResourceRelEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetObjLst)", objException.Message));
}
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCourseLearningCaseWithResourceRelEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCourseLearningCaseWithResourceRel(ref clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where IdCourseLearningCase = " + "'"+ objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdResource = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdFile = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileSize = objDT.Rows[0][convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.SaveTime = objDT.Rows[0][convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdResourceType = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IsExistFile = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileNewName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsMain = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdCaseType = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.OwnerId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.DisciplineID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.DisciplineName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.BrowseCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = TransNullToFloat(objDT.Rows[0][convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.VersionNo = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objDT.Rows[0][convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objDT.Rows[0][convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdSkillType = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.DocFile = objDT.Rows[0][convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objDT.Rows[0][convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsVisible = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsDualVideo = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CollegeID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CollegeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objDT.Rows[0][convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.MajorID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.MajorName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseCode = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objDT.Rows[0][convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ViewCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsShow = TransNullToBool(objDT.Rows[0][convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.DownloadNumber = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileIntegration = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.LikeCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CollectionCount = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.Memo = objDT.Rows[0][convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = TransNullToInt(objDT.Rows[0][convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.OwnerName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objDT.Rows[0][convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objDT.Rows[0][convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetvCourseLearningCaseWithResourceRel)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strIdCourseLearningCase">表关键字</param>
 /// <returns>表对象</returns>
public clsvCourseLearningCaseWithResourceRelEN GetObjByIdCourseLearningCase(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
 objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IsExistFile = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名(字段类型:varchar,字段长度:530,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间(字段类型:char,字段长度:6,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id(字段类型:varchar,字段长度:20,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分(字段类型:float,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述(字段类型:varchar,字段长度:8000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法(字段类型:varchar,字段长度:2000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id(字段类型:char,字段长度:2,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名(字段类型:varchar,字段长度:200,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsVisible = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsDualVideo = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频(字段类型:bit,字段长度:1,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号(字段类型:char,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写(字段类型:varchar,字段长度:12,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID(字段类型:char,字段长度:4,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码(字段类型:varchar,字段长度:20,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量(字段类型:bigint,字段长度:8,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id(字段类型:char,字段长度:2,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数(字段类型:int,字段长度:4,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名(字段类型:varchar,字段长度:30,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id(字段类型:varchar,字段长度:51,是否可空:True)
 objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称(字段类型:varchar,字段长度:50,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetObjByIdCourseLearningCase)", objException.Message));
}
return objvCourseLearningCaseWithResourceRelEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCourseLearningCaseWithResourceRelEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
strSQL = "Select * from vCourseLearningCaseWithResourceRel where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN()
{
IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(), //课程学习案例流水号
IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()), //微格案例资源关系流水号
FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(), //功能模块名称
IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(), //资源流水号
ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(), //资源ID
ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(), //资源名称
IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(), //FTP资源流水号
IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(), //文件流水号
FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(), //文件大小
SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(), //创建时间
IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(), //资源类型流水号
ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(), //资源类型ID
ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(), //资源类型名称
ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(), //上传者
IsExistFile = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()), //是否存在文件
FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(), //新文件名
IsMain = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()), //是否主资源
CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(), //课程学习案例ID
CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(), //课程学习案例名称
CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(), //案例文本内容
CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(), //课程学习案例主题词
CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(), //课程学习日期
CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(), //课程学习时间
CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(), //案例入库日期
CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(), //案例入库时间
IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(), //案例类型流水号
IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(), //课程学习案例类型流水号
CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(), //课程学习案例类型名称
OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(), //拥有者Id
IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(), //id_StudyLevel
StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(), //学段名称
IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(), //教案流水号
IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(), //学科流水号
DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(), //学科ID
DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(), //学科名称
BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()), //浏览次数
IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(), //评价量表版本流水号
senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(), //评价量表版本ID
senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(), //评价量表版本名称
senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()), //评价量表版本总分
VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()), //版本号
IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(), //教学技能流水号
TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(), //教学技能ID
SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(), //技能类型名称
TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(), //教学技能名称
TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(), //教学技能理论阐述
TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(), //教学技能实践操作方法
IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(), //技能类型流水号
SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(), //技能类型ID
CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(), //课例等级Id
CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(), //案例等级名称
DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(), //生成的Word文件名
IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()), //是否需要生成Word
WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(), //Word生成日期
IsVisible = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()), //是否显示
IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()), //是否双视频
IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(), //学院流水号
CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(), //学院ID
CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(), //学院名称
CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(), //学院名称简写
IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(), //专业流水号
MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(), //专业ID
MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(), //专业名称
CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(), //课程Id
CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(), //课程代码
CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(), //课程名称
TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(), //教学方案Id
CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(), //父节点名称
CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(), //节简称
ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(), //章简称
ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()), //浏览量
IsShow = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()), //是否启用
DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()), //下载数目
FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()), //文件积分
LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()), //资源喜欢数量
CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()), //收藏数量
RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(), //推荐度Id
RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(), //推荐度名称
Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(), //备注
BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()), //课例浏览次数
OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(), //拥有者姓名
OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(), //拥有者名称附Id
CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim() //案例类型名称
};
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseWithResourceRelEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseWithResourceRelEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetObjByDataRowvCourseLearningCaseWithResourceRel)", objException.Message));
}
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseWithResourceRelEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCourseLearningCaseWithResourceRelEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN = new clsvCourseLearningCaseWithResourceRelEN();
try
{
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningCaseWithResourceRelEN.IdMicroteachCaseResourceRel = objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.IdMicroteachCaseResourceRel].ToString().Trim()); //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelEN.FuncModuleId = objRow[convCourseLearningCaseWithResourceRel.FuncModuleId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningCaseWithResourceRelEN.FuncModuleName = objRow[convCourseLearningCaseWithResourceRel.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningCaseWithResourceRelEN.IdResource = objRow[convCourseLearningCaseWithResourceRel.IdResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResource].ToString().Trim(); //资源流水号
objvCourseLearningCaseWithResourceRelEN.ResourceID = objRow[convCourseLearningCaseWithResourceRel.ResourceID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceID].ToString().Trim(); //资源ID
objvCourseLearningCaseWithResourceRelEN.ResourceName = objRow[convCourseLearningCaseWithResourceRel.ResourceName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceName].ToString().Trim(); //资源名称
objvCourseLearningCaseWithResourceRelEN.IdFtpResource = objRow[convCourseLearningCaseWithResourceRel.IdFtpResource] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFtpResource].ToString().Trim(); //FTP资源流水号
objvCourseLearningCaseWithResourceRelEN.IdFile = objRow[convCourseLearningCaseWithResourceRel.IdFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdFile].ToString().Trim(); //文件流水号
objvCourseLearningCaseWithResourceRelEN.FileSize = objRow[convCourseLearningCaseWithResourceRel.FileSize] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileSize].ToString().Trim(); //文件大小
objvCourseLearningCaseWithResourceRelEN.SaveTime = objRow[convCourseLearningCaseWithResourceRel.SaveTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SaveTime].ToString().Trim(); //创建时间
objvCourseLearningCaseWithResourceRelEN.IdResourceType = objRow[convCourseLearningCaseWithResourceRel.IdResourceType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdResourceType].ToString().Trim(); //资源类型流水号
objvCourseLearningCaseWithResourceRelEN.ResourceTypeID = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeID].ToString().Trim(); //资源类型ID
objvCourseLearningCaseWithResourceRelEN.ResourceTypeName = objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceTypeName].ToString().Trim(); //资源类型名称
objvCourseLearningCaseWithResourceRelEN.ResourceOwner = objRow[convCourseLearningCaseWithResourceRel.ResourceOwner] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ResourceOwner].ToString().Trim(); //上传者
objvCourseLearningCaseWithResourceRelEN.IsExistFile = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsExistFile].ToString().Trim()); //是否存在文件
objvCourseLearningCaseWithResourceRelEN.FileNewName = objRow[convCourseLearningCaseWithResourceRel.FileNewName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.FileNewName].ToString().Trim(); //新文件名
objvCourseLearningCaseWithResourceRelEN.IsMain = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsMain].ToString().Trim()); //是否主资源
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseID].ToString().Trim(); //课程学习案例ID
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseText].ToString().Trim(); //案例文本内容
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme].ToString().Trim(); //课程学习案例主题词
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDate].ToString().Trim(); //课程学习日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTime].ToString().Trim(); //课程学习时间
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn].ToString().Trim(); //案例入库日期
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn].ToString().Trim(); //案例入库时间
objvCourseLearningCaseWithResourceRelEN.IdCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCaseType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdCaseType].ToString().Trim(); //案例类型流水号
objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType = objRow[convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType].ToString().Trim(); //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName].ToString().Trim(); //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelEN.OwnerId = objRow[convCourseLearningCaseWithResourceRel.OwnerId].ToString().Trim(); //拥有者Id
objvCourseLearningCaseWithResourceRelEN.IdStudyLevel = objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdStudyLevel].ToString().Trim(); //id_StudyLevel
objvCourseLearningCaseWithResourceRelEN.StudyLevelName = objRow[convCourseLearningCaseWithResourceRel.StudyLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.StudyLevelName].ToString().Trim(); //学段名称
objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan = objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdTeachingPlan].ToString().Trim(); //教案流水号
objvCourseLearningCaseWithResourceRelEN.IdDiscipline = objRow[convCourseLearningCaseWithResourceRel.IdDiscipline].ToString().Trim(); //学科流水号
objvCourseLearningCaseWithResourceRelEN.DisciplineID = objRow[convCourseLearningCaseWithResourceRel.DisciplineID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineID].ToString().Trim(); //学科ID
objvCourseLearningCaseWithResourceRelEN.DisciplineName = objRow[convCourseLearningCaseWithResourceRel.DisciplineName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DisciplineName].ToString().Trim(); //学科名称
objvCourseLearningCaseWithResourceRelEN.BrowseCount = objRow[convCourseLearningCaseWithResourceRel.BrowseCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount].ToString().Trim()); //浏览次数
objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion = objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion].ToString().Trim(); //评价量表版本流水号
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionID].ToString().Trim(); //评价量表版本ID
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionName].ToString().Trim(); //评价量表版本名称
objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionTtlScore = objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convCourseLearningCaseWithResourceRel.senateGaugeVersionTtlScore].ToString().Trim()); //评价量表版本总分
objvCourseLearningCaseWithResourceRelEN.VersionNo = objRow[convCourseLearningCaseWithResourceRel.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.VersionNo].ToString().Trim()); //版本号
objvCourseLearningCaseWithResourceRelEN.IdTeachSkill = objRow[convCourseLearningCaseWithResourceRel.IdTeachSkill].ToString().Trim(); //教学技能流水号
objvCourseLearningCaseWithResourceRelEN.TeachSkillID = objRow[convCourseLearningCaseWithResourceRel.TeachSkillID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillID].ToString().Trim(); //教学技能ID
objvCourseLearningCaseWithResourceRelEN.SkillTypeName = objRow[convCourseLearningCaseWithResourceRel.SkillTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeName].ToString().Trim(); //技能类型名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillName = objRow[convCourseLearningCaseWithResourceRel.TeachSkillName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillName].ToString().Trim(); //教学技能名称
objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory = objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillTheory].ToString().Trim(); //教学技能理论阐述
objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod = objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.TeachSkillOperMethod].ToString().Trim(); //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelEN.IdSkillType = objRow[convCourseLearningCaseWithResourceRel.IdSkillType] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.IdSkillType].ToString().Trim(); //技能类型流水号
objvCourseLearningCaseWithResourceRelEN.SkillTypeID = objRow[convCourseLearningCaseWithResourceRel.SkillTypeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.SkillTypeID].ToString().Trim(); //技能类型ID
objvCourseLearningCaseWithResourceRelEN.CaseLevelId = objRow[convCourseLearningCaseWithResourceRel.CaseLevelId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelId].ToString().Trim(); //课例等级Id
objvCourseLearningCaseWithResourceRelEN.CaseLevelName = objRow[convCourseLearningCaseWithResourceRel.CaseLevelName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseLevelName].ToString().Trim(); //案例等级名称
objvCourseLearningCaseWithResourceRelEN.DocFile = objRow[convCourseLearningCaseWithResourceRel.DocFile] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.DocFile].ToString().Trim(); //生成的Word文件名
objvCourseLearningCaseWithResourceRelEN.IsNeedGeneWord = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsNeedGeneWord].ToString().Trim()); //是否需要生成Word
objvCourseLearningCaseWithResourceRelEN.WordCreateDate = objRow[convCourseLearningCaseWithResourceRel.WordCreateDate] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.WordCreateDate].ToString().Trim(); //Word生成日期
objvCourseLearningCaseWithResourceRelEN.IsVisible = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsVisible].ToString().Trim()); //是否显示
objvCourseLearningCaseWithResourceRelEN.IsDualVideo = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsDualVideo].ToString().Trim()); //是否双视频
objvCourseLearningCaseWithResourceRelEN.IdXzCollege = objRow[convCourseLearningCaseWithResourceRel.IdXzCollege].ToString().Trim(); //学院流水号
objvCourseLearningCaseWithResourceRelEN.CollegeID = objRow[convCourseLearningCaseWithResourceRel.CollegeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeID].ToString().Trim(); //学院ID
objvCourseLearningCaseWithResourceRelEN.CollegeName = objRow[convCourseLearningCaseWithResourceRel.CollegeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeName].ToString().Trim(); //学院名称
objvCourseLearningCaseWithResourceRelEN.CollegeNameA = objRow[convCourseLearningCaseWithResourceRel.CollegeNameA] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CollegeNameA].ToString().Trim(); //学院名称简写
objvCourseLearningCaseWithResourceRelEN.IdXzMajor = objRow[convCourseLearningCaseWithResourceRel.IdXzMajor].ToString().Trim(); //专业流水号
objvCourseLearningCaseWithResourceRelEN.MajorID = objRow[convCourseLearningCaseWithResourceRel.MajorID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorID].ToString().Trim(); //专业ID
objvCourseLearningCaseWithResourceRelEN.MajorName = objRow[convCourseLearningCaseWithResourceRel.MajorName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.MajorName].ToString().Trim(); //专业名称
objvCourseLearningCaseWithResourceRelEN.CourseId = objRow[convCourseLearningCaseWithResourceRel.CourseId].ToString().Trim(); //课程Id
objvCourseLearningCaseWithResourceRelEN.CourseCode = objRow[convCourseLearningCaseWithResourceRel.CourseCode] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseCode].ToString().Trim(); //课程代码
objvCourseLearningCaseWithResourceRelEN.CourseName = objRow[convCourseLearningCaseWithResourceRel.CourseName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseName].ToString().Trim(); //课程名称
objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId = objRow[convCourseLearningCaseWithResourceRel.TeachingSolutionId].ToString().Trim(); //教学方案Id
objvCourseLearningCaseWithResourceRelEN.CourseChapterId = objRow[convCourseLearningCaseWithResourceRel.CourseChapterId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterId].ToString().Trim(); //课程章节ID
objvCourseLearningCaseWithResourceRelEN.CourseChapterName = objRow[convCourseLearningCaseWithResourceRel.CourseChapterName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterName].ToString().Trim(); //课程章节名称
objvCourseLearningCaseWithResourceRelEN.ParentNodeID = objRow[convCourseLearningCaseWithResourceRel.ParentNodeID] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeID].ToString().Trim(); //父节点编号
objvCourseLearningCaseWithResourceRelEN.ParentNodeName = objRow[convCourseLearningCaseWithResourceRel.ParentNodeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeName].ToString().Trim(); //父节点名称
objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred = objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CourseChapterReferred].ToString().Trim(); //节简称
objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred = objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.ParentNodeReferred].ToString().Trim(); //章简称
objvCourseLearningCaseWithResourceRelEN.ViewCount = objRow[convCourseLearningCaseWithResourceRel.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.ViewCount].ToString().Trim()); //浏览量
objvCourseLearningCaseWithResourceRelEN.IsShow = TransNullToBool(objRow[convCourseLearningCaseWithResourceRel.IsShow].ToString().Trim()); //是否启用
objvCourseLearningCaseWithResourceRelEN.DownloadNumber = objRow[convCourseLearningCaseWithResourceRel.DownloadNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.DownloadNumber].ToString().Trim()); //下载数目
objvCourseLearningCaseWithResourceRelEN.FileIntegration = objRow[convCourseLearningCaseWithResourceRel.FileIntegration] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.FileIntegration].ToString().Trim()); //文件积分
objvCourseLearningCaseWithResourceRelEN.LikeCount = objRow[convCourseLearningCaseWithResourceRel.LikeCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.LikeCount].ToString().Trim()); //资源喜欢数量
objvCourseLearningCaseWithResourceRelEN.CollectionCount = objRow[convCourseLearningCaseWithResourceRel.CollectionCount] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.CollectionCount].ToString().Trim()); //收藏数量
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeId].ToString().Trim(); //推荐度Id
objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName = objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.RecommendedDegreeName].ToString().Trim(); //推荐度名称
objvCourseLearningCaseWithResourceRelEN.Memo = objRow[convCourseLearningCaseWithResourceRel.Memo] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.Memo].ToString().Trim(); //备注
objvCourseLearningCaseWithResourceRelEN.BrowseCount4Case = objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCourseLearningCaseWithResourceRel.BrowseCount4Case].ToString().Trim()); //课例浏览次数
objvCourseLearningCaseWithResourceRelEN.OwnerName = objRow[convCourseLearningCaseWithResourceRel.OwnerName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerName].ToString().Trim(); //拥有者姓名
objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId = objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.OwnerNameWithId].ToString().Trim(); //拥有者名称附Id
objvCourseLearningCaseWithResourceRelEN.CaseTypeName = objRow[convCourseLearningCaseWithResourceRel.CaseTypeName] == DBNull.Value ? null : objRow[convCourseLearningCaseWithResourceRel.CaseTypeName].ToString().Trim(); //案例类型名称
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCourseLearningCaseWithResourceRelDA: GetObjByDataRow)", objException.Message));
}
objvCourseLearningCaseWithResourceRelEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCourseLearningCaseWithResourceRelEN;
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
objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseWithResourceRelEN._CurrTabName, convCourseLearningCaseWithResourceRel.IdCourseLearningCase, 8, "");
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
objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCourseLearningCaseWithResourceRelEN._CurrTabName, convCourseLearningCaseWithResourceRel.IdCourseLearningCase, 8, strPrefix);
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCaseWithResourceRel where " + strCondition;
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdCourseLearningCase from vCourseLearningCaseWithResourceRel where " + strCondition;
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
 /// <param name = "strIdCourseLearningCase">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strIdCourseLearningCase)
{
CheckPrimaryKey(strIdCourseLearningCase);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseWithResourceRel", "IdCourseLearningCase = " + "'"+ strIdCourseLearningCase+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCourseLearningCaseWithResourceRelDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCourseLearningCaseWithResourceRel", strCondition))
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
objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCourseLearningCaseWithResourceRel");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningCaseWithResourceRelENS">源对象</param>
 /// <param name = "objvCourseLearningCaseWithResourceRelENT">目标对象</param>
public void CopyTo(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENS, clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelENT)
{
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCase = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningCaseWithResourceRelENT.IdMicroteachCaseResourceRel = objvCourseLearningCaseWithResourceRelENS.IdMicroteachCaseResourceRel; //微格案例资源关系流水号
objvCourseLearningCaseWithResourceRelENT.FuncModuleId = objvCourseLearningCaseWithResourceRelENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseWithResourceRelENT.FuncModuleName = objvCourseLearningCaseWithResourceRelENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseWithResourceRelENT.IdResource = objvCourseLearningCaseWithResourceRelENS.IdResource; //资源流水号
objvCourseLearningCaseWithResourceRelENT.ResourceID = objvCourseLearningCaseWithResourceRelENS.ResourceID; //资源ID
objvCourseLearningCaseWithResourceRelENT.ResourceName = objvCourseLearningCaseWithResourceRelENS.ResourceName; //资源名称
objvCourseLearningCaseWithResourceRelENT.IdFtpResource = objvCourseLearningCaseWithResourceRelENS.IdFtpResource; //FTP资源流水号
objvCourseLearningCaseWithResourceRelENT.IdFile = objvCourseLearningCaseWithResourceRelENS.IdFile; //文件流水号
objvCourseLearningCaseWithResourceRelENT.FileSize = objvCourseLearningCaseWithResourceRelENS.FileSize; //文件大小
objvCourseLearningCaseWithResourceRelENT.SaveTime = objvCourseLearningCaseWithResourceRelENS.SaveTime; //创建时间
objvCourseLearningCaseWithResourceRelENT.IdResourceType = objvCourseLearningCaseWithResourceRelENS.IdResourceType; //资源类型流水号
objvCourseLearningCaseWithResourceRelENT.ResourceTypeID = objvCourseLearningCaseWithResourceRelENS.ResourceTypeID; //资源类型ID
objvCourseLearningCaseWithResourceRelENT.ResourceTypeName = objvCourseLearningCaseWithResourceRelENS.ResourceTypeName; //资源类型名称
objvCourseLearningCaseWithResourceRelENT.ResourceOwner = objvCourseLearningCaseWithResourceRelENS.ResourceOwner; //上传者
objvCourseLearningCaseWithResourceRelENT.IsExistFile = objvCourseLearningCaseWithResourceRelENS.IsExistFile; //是否存在文件
objvCourseLearningCaseWithResourceRelENT.FileNewName = objvCourseLearningCaseWithResourceRelENS.FileNewName; //新文件名
objvCourseLearningCaseWithResourceRelENT.IsMain = objvCourseLearningCaseWithResourceRelENS.IsMain; //是否主资源
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseID = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseText = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseText; //案例文本内容
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTheme = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTheme; //课程学习案例主题词
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDate = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDate; //课程学习日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTime = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTime; //课程学习时间
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseDateIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseDateIn; //案例入库日期
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTimeIn = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTimeIn; //案例入库时间
objvCourseLearningCaseWithResourceRelENT.IdCaseType = objvCourseLearningCaseWithResourceRelENS.IdCaseType; //案例类型流水号
objvCourseLearningCaseWithResourceRelENT.IdCourseLearningCaseType = objvCourseLearningCaseWithResourceRelENS.IdCourseLearningCaseType; //课程学习案例类型流水号
objvCourseLearningCaseWithResourceRelENT.CourseLearningCaseTypeName = objvCourseLearningCaseWithResourceRelENS.CourseLearningCaseTypeName; //课程学习案例类型名称
objvCourseLearningCaseWithResourceRelENT.OwnerId = objvCourseLearningCaseWithResourceRelENS.OwnerId; //拥有者Id
objvCourseLearningCaseWithResourceRelENT.IdStudyLevel = objvCourseLearningCaseWithResourceRelENS.IdStudyLevel; //id_StudyLevel
objvCourseLearningCaseWithResourceRelENT.StudyLevelName = objvCourseLearningCaseWithResourceRelENS.StudyLevelName; //学段名称
objvCourseLearningCaseWithResourceRelENT.IdTeachingPlan = objvCourseLearningCaseWithResourceRelENS.IdTeachingPlan; //教案流水号
objvCourseLearningCaseWithResourceRelENT.IdDiscipline = objvCourseLearningCaseWithResourceRelENS.IdDiscipline; //学科流水号
objvCourseLearningCaseWithResourceRelENT.DisciplineID = objvCourseLearningCaseWithResourceRelENS.DisciplineID; //学科ID
objvCourseLearningCaseWithResourceRelENT.DisciplineName = objvCourseLearningCaseWithResourceRelENS.DisciplineName; //学科名称
objvCourseLearningCaseWithResourceRelENT.BrowseCount = objvCourseLearningCaseWithResourceRelENS.BrowseCount; //浏览次数
objvCourseLearningCaseWithResourceRelENT.IdSenateGaugeVersion = objvCourseLearningCaseWithResourceRelENS.IdSenateGaugeVersion; //评价量表版本流水号
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionID = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionID; //评价量表版本ID
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionName = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseWithResourceRelENT.senateGaugeVersionTtlScore = objvCourseLearningCaseWithResourceRelENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvCourseLearningCaseWithResourceRelENT.VersionNo = objvCourseLearningCaseWithResourceRelENS.VersionNo; //版本号
objvCourseLearningCaseWithResourceRelENT.IdTeachSkill = objvCourseLearningCaseWithResourceRelENS.IdTeachSkill; //教学技能流水号
objvCourseLearningCaseWithResourceRelENT.TeachSkillID = objvCourseLearningCaseWithResourceRelENS.TeachSkillID; //教学技能ID
objvCourseLearningCaseWithResourceRelENT.SkillTypeName = objvCourseLearningCaseWithResourceRelENS.SkillTypeName; //技能类型名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillName = objvCourseLearningCaseWithResourceRelENS.TeachSkillName; //教学技能名称
objvCourseLearningCaseWithResourceRelENT.TeachSkillTheory = objvCourseLearningCaseWithResourceRelENS.TeachSkillTheory; //教学技能理论阐述
objvCourseLearningCaseWithResourceRelENT.TeachSkillOperMethod = objvCourseLearningCaseWithResourceRelENS.TeachSkillOperMethod; //教学技能实践操作方法
objvCourseLearningCaseWithResourceRelENT.IdSkillType = objvCourseLearningCaseWithResourceRelENS.IdSkillType; //技能类型流水号
objvCourseLearningCaseWithResourceRelENT.SkillTypeID = objvCourseLearningCaseWithResourceRelENS.SkillTypeID; //技能类型ID
objvCourseLearningCaseWithResourceRelENT.CaseLevelId = objvCourseLearningCaseWithResourceRelENS.CaseLevelId; //课例等级Id
objvCourseLearningCaseWithResourceRelENT.CaseLevelName = objvCourseLearningCaseWithResourceRelENS.CaseLevelName; //案例等级名称
objvCourseLearningCaseWithResourceRelENT.DocFile = objvCourseLearningCaseWithResourceRelENS.DocFile; //生成的Word文件名
objvCourseLearningCaseWithResourceRelENT.IsNeedGeneWord = objvCourseLearningCaseWithResourceRelENS.IsNeedGeneWord; //是否需要生成Word
objvCourseLearningCaseWithResourceRelENT.WordCreateDate = objvCourseLearningCaseWithResourceRelENS.WordCreateDate; //Word生成日期
objvCourseLearningCaseWithResourceRelENT.IsVisible = objvCourseLearningCaseWithResourceRelENS.IsVisible; //是否显示
objvCourseLearningCaseWithResourceRelENT.IsDualVideo = objvCourseLearningCaseWithResourceRelENS.IsDualVideo; //是否双视频
objvCourseLearningCaseWithResourceRelENT.IdXzCollege = objvCourseLearningCaseWithResourceRelENS.IdXzCollege; //学院流水号
objvCourseLearningCaseWithResourceRelENT.CollegeID = objvCourseLearningCaseWithResourceRelENS.CollegeID; //学院ID
objvCourseLearningCaseWithResourceRelENT.CollegeName = objvCourseLearningCaseWithResourceRelENS.CollegeName; //学院名称
objvCourseLearningCaseWithResourceRelENT.CollegeNameA = objvCourseLearningCaseWithResourceRelENS.CollegeNameA; //学院名称简写
objvCourseLearningCaseWithResourceRelENT.IdXzMajor = objvCourseLearningCaseWithResourceRelENS.IdXzMajor; //专业流水号
objvCourseLearningCaseWithResourceRelENT.MajorID = objvCourseLearningCaseWithResourceRelENS.MajorID; //专业ID
objvCourseLearningCaseWithResourceRelENT.MajorName = objvCourseLearningCaseWithResourceRelENS.MajorName; //专业名称
objvCourseLearningCaseWithResourceRelENT.CourseId = objvCourseLearningCaseWithResourceRelENS.CourseId; //课程Id
objvCourseLearningCaseWithResourceRelENT.CourseCode = objvCourseLearningCaseWithResourceRelENS.CourseCode; //课程代码
objvCourseLearningCaseWithResourceRelENT.CourseName = objvCourseLearningCaseWithResourceRelENS.CourseName; //课程名称
objvCourseLearningCaseWithResourceRelENT.TeachingSolutionId = objvCourseLearningCaseWithResourceRelENS.TeachingSolutionId; //教学方案Id
objvCourseLearningCaseWithResourceRelENT.CourseChapterId = objvCourseLearningCaseWithResourceRelENS.CourseChapterId; //课程章节ID
objvCourseLearningCaseWithResourceRelENT.CourseChapterName = objvCourseLearningCaseWithResourceRelENS.CourseChapterName; //课程章节名称
objvCourseLearningCaseWithResourceRelENT.ParentNodeID = objvCourseLearningCaseWithResourceRelENS.ParentNodeID; //父节点编号
objvCourseLearningCaseWithResourceRelENT.ParentNodeName = objvCourseLearningCaseWithResourceRelENS.ParentNodeName; //父节点名称
objvCourseLearningCaseWithResourceRelENT.CourseChapterReferred = objvCourseLearningCaseWithResourceRelENS.CourseChapterReferred; //节简称
objvCourseLearningCaseWithResourceRelENT.ParentNodeReferred = objvCourseLearningCaseWithResourceRelENS.ParentNodeReferred; //章简称
objvCourseLearningCaseWithResourceRelENT.ViewCount = objvCourseLearningCaseWithResourceRelENS.ViewCount; //浏览量
objvCourseLearningCaseWithResourceRelENT.IsShow = objvCourseLearningCaseWithResourceRelENS.IsShow; //是否启用
objvCourseLearningCaseWithResourceRelENT.DownloadNumber = objvCourseLearningCaseWithResourceRelENS.DownloadNumber; //下载数目
objvCourseLearningCaseWithResourceRelENT.FileIntegration = objvCourseLearningCaseWithResourceRelENS.FileIntegration; //文件积分
objvCourseLearningCaseWithResourceRelENT.LikeCount = objvCourseLearningCaseWithResourceRelENS.LikeCount; //资源喜欢数量
objvCourseLearningCaseWithResourceRelENT.CollectionCount = objvCourseLearningCaseWithResourceRelENS.CollectionCount; //收藏数量
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeId = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeId; //推荐度Id
objvCourseLearningCaseWithResourceRelENT.RecommendedDegreeName = objvCourseLearningCaseWithResourceRelENS.RecommendedDegreeName; //推荐度名称
objvCourseLearningCaseWithResourceRelENT.Memo = objvCourseLearningCaseWithResourceRelENS.Memo; //备注
objvCourseLearningCaseWithResourceRelENT.BrowseCount4Case = objvCourseLearningCaseWithResourceRelENS.BrowseCount4Case; //课例浏览次数
objvCourseLearningCaseWithResourceRelENT.OwnerName = objvCourseLearningCaseWithResourceRelENS.OwnerName; //拥有者姓名
objvCourseLearningCaseWithResourceRelENT.OwnerNameWithId = objvCourseLearningCaseWithResourceRelENS.OwnerNameWithId; //拥有者名称附Id
objvCourseLearningCaseWithResourceRelENT.CaseTypeName = objvCourseLearningCaseWithResourceRelENS.CaseTypeName; //案例类型名称
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCourseLearningCaseWithResourceRelEN objvCourseLearningCaseWithResourceRelEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, 8, convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.FuncModuleId, 4, convCourseLearningCaseWithResourceRel.FuncModuleId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.FuncModuleName, 30, convCourseLearningCaseWithResourceRel.FuncModuleName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdResource, 8, convCourseLearningCaseWithResourceRel.IdResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ResourceID, 8, convCourseLearningCaseWithResourceRel.ResourceID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ResourceName, 100, convCourseLearningCaseWithResourceRel.ResourceName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdFtpResource, 8, convCourseLearningCaseWithResourceRel.IdFtpResource);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdFile, 8, convCourseLearningCaseWithResourceRel.IdFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.FileSize, 50, convCourseLearningCaseWithResourceRel.FileSize);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.SaveTime, 6, convCourseLearningCaseWithResourceRel.SaveTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdResourceType, 4, convCourseLearningCaseWithResourceRel.IdResourceType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ResourceTypeID, 4, convCourseLearningCaseWithResourceRel.ResourceTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ResourceTypeName, 50, convCourseLearningCaseWithResourceRel.ResourceTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ResourceOwner, 50, convCourseLearningCaseWithResourceRel.ResourceOwner);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.FileNewName, 530, convCourseLearningCaseWithResourceRel.FileNewName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName, 100, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText, 8000, convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme, 200, convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn, 8, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn, 6, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdCaseType, 4, convCourseLearningCaseWithResourceRel.IdCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType, 4, convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName, 30, convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.OwnerId, 20, convCourseLearningCaseWithResourceRel.OwnerId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdStudyLevel, 4, convCourseLearningCaseWithResourceRel.IdStudyLevel);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.StudyLevelName, 50, convCourseLearningCaseWithResourceRel.StudyLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan, 8, convCourseLearningCaseWithResourceRel.IdTeachingPlan);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdDiscipline, 4, convCourseLearningCaseWithResourceRel.IdDiscipline);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.DisciplineID, 4, convCourseLearningCaseWithResourceRel.DisciplineID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.DisciplineName, 50, convCourseLearningCaseWithResourceRel.DisciplineName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion, 4, convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID, 4, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName, 200, convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdTeachSkill, 8, convCourseLearningCaseWithResourceRel.IdTeachSkill);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.TeachSkillID, 8, convCourseLearningCaseWithResourceRel.TeachSkillID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.SkillTypeName, 50, convCourseLearningCaseWithResourceRel.SkillTypeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.TeachSkillName, 50, convCourseLearningCaseWithResourceRel.TeachSkillName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory, 8000, convCourseLearningCaseWithResourceRel.TeachSkillTheory);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod, 2000, convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdSkillType, 4, convCourseLearningCaseWithResourceRel.IdSkillType);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.SkillTypeID, 4, convCourseLearningCaseWithResourceRel.SkillTypeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CaseLevelId, 2, convCourseLearningCaseWithResourceRel.CaseLevelId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CaseLevelName, 30, convCourseLearningCaseWithResourceRel.CaseLevelName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.DocFile, 200, convCourseLearningCaseWithResourceRel.DocFile);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.WordCreateDate, 14, convCourseLearningCaseWithResourceRel.WordCreateDate);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdXzCollege, 4, convCourseLearningCaseWithResourceRel.IdXzCollege);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CollegeID, 4, convCourseLearningCaseWithResourceRel.CollegeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CollegeName, 100, convCourseLearningCaseWithResourceRel.CollegeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CollegeNameA, 12, convCourseLearningCaseWithResourceRel.CollegeNameA);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.IdXzMajor, 8, convCourseLearningCaseWithResourceRel.IdXzMajor);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.MajorID, 4, convCourseLearningCaseWithResourceRel.MajorID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.MajorName, 100, convCourseLearningCaseWithResourceRel.MajorName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseId, 8, convCourseLearningCaseWithResourceRel.CourseId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseCode, 20, convCourseLearningCaseWithResourceRel.CourseCode);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseName, 100, convCourseLearningCaseWithResourceRel.CourseName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId, 8, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseChapterId, 8, convCourseLearningCaseWithResourceRel.CourseChapterId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseChapterName, 100, convCourseLearningCaseWithResourceRel.CourseChapterName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ParentNodeID, 8, convCourseLearningCaseWithResourceRel.ParentNodeID);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ParentNodeName, 50, convCourseLearningCaseWithResourceRel.ParentNodeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred, 10, convCourseLearningCaseWithResourceRel.CourseChapterReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred, 10, convCourseLearningCaseWithResourceRel.ParentNodeReferred);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId, 2, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName, 30, convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.Memo, 1000, convCourseLearningCaseWithResourceRel.Memo);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.OwnerName, 30, convCourseLearningCaseWithResourceRel.OwnerName);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId, 51, convCourseLearningCaseWithResourceRel.OwnerNameWithId);
clsCheckSql.CheckFieldLen(objvCourseLearningCaseWithResourceRelEN.CaseTypeName, 50, convCourseLearningCaseWithResourceRel.CaseTypeName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCase, convCourseLearningCaseWithResourceRel.IdCourseLearningCase);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.FuncModuleId, convCourseLearningCaseWithResourceRel.FuncModuleId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.FuncModuleName, convCourseLearningCaseWithResourceRel.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdResource, convCourseLearningCaseWithResourceRel.IdResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ResourceID, convCourseLearningCaseWithResourceRel.ResourceID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ResourceName, convCourseLearningCaseWithResourceRel.ResourceName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdFtpResource, convCourseLearningCaseWithResourceRel.IdFtpResource);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdFile, convCourseLearningCaseWithResourceRel.IdFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.FileSize, convCourseLearningCaseWithResourceRel.FileSize);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.SaveTime, convCourseLearningCaseWithResourceRel.SaveTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdResourceType, convCourseLearningCaseWithResourceRel.IdResourceType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ResourceTypeID, convCourseLearningCaseWithResourceRel.ResourceTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ResourceTypeName, convCourseLearningCaseWithResourceRel.ResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ResourceOwner, convCourseLearningCaseWithResourceRel.ResourceOwner);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.FileNewName, convCourseLearningCaseWithResourceRel.FileNewName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseID, convCourseLearningCaseWithResourceRel.CourseLearningCaseID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseName, convCourseLearningCaseWithResourceRel.CourseLearningCaseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseText, convCourseLearningCaseWithResourceRel.CourseLearningCaseText);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTheme, convCourseLearningCaseWithResourceRel.CourseLearningCaseTheme);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDate, convCourseLearningCaseWithResourceRel.CourseLearningCaseDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTime, convCourseLearningCaseWithResourceRel.CourseLearningCaseTime);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseDateIn, convCourseLearningCaseWithResourceRel.CourseLearningCaseDateIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTimeIn, convCourseLearningCaseWithResourceRel.CourseLearningCaseTimeIn);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdCaseType, convCourseLearningCaseWithResourceRel.IdCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdCourseLearningCaseType, convCourseLearningCaseWithResourceRel.IdCourseLearningCaseType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseLearningCaseTypeName, convCourseLearningCaseWithResourceRel.CourseLearningCaseTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.OwnerId, convCourseLearningCaseWithResourceRel.OwnerId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdStudyLevel, convCourseLearningCaseWithResourceRel.IdStudyLevel);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.StudyLevelName, convCourseLearningCaseWithResourceRel.StudyLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdTeachingPlan, convCourseLearningCaseWithResourceRel.IdTeachingPlan);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdDiscipline, convCourseLearningCaseWithResourceRel.IdDiscipline);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.DisciplineID, convCourseLearningCaseWithResourceRel.DisciplineID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.DisciplineName, convCourseLearningCaseWithResourceRel.DisciplineName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdSenateGaugeVersion, convCourseLearningCaseWithResourceRel.IdSenateGaugeVersion);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionID, convCourseLearningCaseWithResourceRel.senateGaugeVersionID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.senateGaugeVersionName, convCourseLearningCaseWithResourceRel.senateGaugeVersionName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdTeachSkill, convCourseLearningCaseWithResourceRel.IdTeachSkill);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.TeachSkillID, convCourseLearningCaseWithResourceRel.TeachSkillID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.SkillTypeName, convCourseLearningCaseWithResourceRel.SkillTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.TeachSkillName, convCourseLearningCaseWithResourceRel.TeachSkillName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.TeachSkillTheory, convCourseLearningCaseWithResourceRel.TeachSkillTheory);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.TeachSkillOperMethod, convCourseLearningCaseWithResourceRel.TeachSkillOperMethod);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdSkillType, convCourseLearningCaseWithResourceRel.IdSkillType);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.SkillTypeID, convCourseLearningCaseWithResourceRel.SkillTypeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CaseLevelId, convCourseLearningCaseWithResourceRel.CaseLevelId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CaseLevelName, convCourseLearningCaseWithResourceRel.CaseLevelName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.DocFile, convCourseLearningCaseWithResourceRel.DocFile);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.WordCreateDate, convCourseLearningCaseWithResourceRel.WordCreateDate);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdXzCollege, convCourseLearningCaseWithResourceRel.IdXzCollege);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CollegeID, convCourseLearningCaseWithResourceRel.CollegeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CollegeName, convCourseLearningCaseWithResourceRel.CollegeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CollegeNameA, convCourseLearningCaseWithResourceRel.CollegeNameA);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.IdXzMajor, convCourseLearningCaseWithResourceRel.IdXzMajor);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.MajorID, convCourseLearningCaseWithResourceRel.MajorID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.MajorName, convCourseLearningCaseWithResourceRel.MajorName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseId, convCourseLearningCaseWithResourceRel.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseCode, convCourseLearningCaseWithResourceRel.CourseCode);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseName, convCourseLearningCaseWithResourceRel.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.TeachingSolutionId, convCourseLearningCaseWithResourceRel.TeachingSolutionId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseChapterId, convCourseLearningCaseWithResourceRel.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseChapterName, convCourseLearningCaseWithResourceRel.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ParentNodeID, convCourseLearningCaseWithResourceRel.ParentNodeID);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ParentNodeName, convCourseLearningCaseWithResourceRel.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CourseChapterReferred, convCourseLearningCaseWithResourceRel.CourseChapterReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.ParentNodeReferred, convCourseLearningCaseWithResourceRel.ParentNodeReferred);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeId, convCourseLearningCaseWithResourceRel.RecommendedDegreeId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.RecommendedDegreeName, convCourseLearningCaseWithResourceRel.RecommendedDegreeName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.Memo, convCourseLearningCaseWithResourceRel.Memo);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.OwnerName, convCourseLearningCaseWithResourceRel.OwnerName);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.OwnerNameWithId, convCourseLearningCaseWithResourceRel.OwnerNameWithId);
clsCheckSql.CheckSqlInjection4Field(objvCourseLearningCaseWithResourceRelEN.CaseTypeName, convCourseLearningCaseWithResourceRel.CaseTypeName);
//检查外键字段长度
 objvCourseLearningCaseWithResourceRelEN._IsCheckProperty = true;
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseWithResourceRelEN._CurrTabName);
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCourseLearningCaseWithResourceRelEN._CurrTabName, strCondition);
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
 objSQL = clsvCourseLearningCaseWithResourceRelDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}