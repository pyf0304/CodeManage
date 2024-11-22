
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_ExamPaperQuestionTypeRelaDA
 表名:vcc_ExamPaperQuestionTypeRela(01120238)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:00
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
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
 /// v考卷题型关系(vcc_ExamPaperQuestionTypeRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_ExamPaperQuestionTypeRelaDA : clsCommBase4DA
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
 return clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_ExamPaperQuestionTypeRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_ExamPaperQuestionTypeRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_ExamPaperQuestionTypeRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_ExamPaperQuestionTypeRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_ExamPaperQuestionTypeRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable_vcc_ExamPaperQuestionTypeRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_ExamPaperQuestionTypeRela.* from vcc_ExamPaperQuestionTypeRela Left Join {1} on {2} where {3} and vcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela not in (Select top {5} vcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1} and IdExamPaperQuestionTypeRela not in (Select top {2} IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1} and IdExamPaperQuestionTypeRela not in (Select top {3} IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_ExamPaperQuestionTypeRela.* from vcc_ExamPaperQuestionTypeRela Left Join {1} on {2} where {3} and vcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela not in (Select top {5} vcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1} and IdExamPaperQuestionTypeRela not in (Select top {2} IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_ExamPaperQuestionTypeRela where {1} and IdExamPaperQuestionTypeRela not in (Select top {3} IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA:GetObjLst)", objException.Message));
}
List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = new List<clsvcc_ExamPaperQuestionTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN();
try
{
objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaEN.IsShow = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaEN.UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperQuestionTypeRelaEN.Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaEN.IsUse = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数
objvcc_ExamPaperQuestionTypeRelaEN.PerScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值
objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号
objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperQuestionTypeRelaEN.Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetObjLst)", objException.Message));
}
objvcc_ExamPaperQuestionTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_ExamPaperQuestionTypeRelaEN);
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
public List<clsvcc_ExamPaperQuestionTypeRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_ExamPaperQuestionTypeRelaEN> arrObjLst = new List<clsvcc_ExamPaperQuestionTypeRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN();
try
{
objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaEN.IsShow = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaEN.UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperQuestionTypeRelaEN.Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaEN.IsUse = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数
objvcc_ExamPaperQuestionTypeRelaEN.PerScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值
objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号
objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperQuestionTypeRelaEN.Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetObjLst)", objException.Message));
}
objvcc_ExamPaperQuestionTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_ExamPaperQuestionTypeRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_ExamPaperQuestionTypeRela(ref clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where IdExamPaperQuestionTypeRela = " + ""+ objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.IsShow = TransNullToBool(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = TransNullToDouble(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UserName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.Scores = TransNullToDouble(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.IsUse = TransNullToBool(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数(字段类型:int,字段长度:4,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.PerScore = TransNullToDouble(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.Memo = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objDT.Rows[0][convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: Getvcc_ExamPaperQuestionTypeRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngIdExamPaperQuestionTypeRela">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_ExamPaperQuestionTypeRelaEN GetObjByIdExamPaperQuestionTypeRela(long lngIdExamPaperQuestionTypeRela)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where IdExamPaperQuestionTypeRela = " + ""+ lngIdExamPaperQuestionTypeRela+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN();
try
{
 objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = Int32.Parse(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela(字段类型:bigint,字段长度:8,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = Double.Parse(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分(字段类型:decimal,字段长度:10,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间(字段类型:varchar,字段长度:14,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名(字段类型:varchar,字段长度:30,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值(字段类型:decimal,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.IsUse = clsEntityBase2.TransNullToBool_S(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = Int32.Parse(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数(字段类型:int,字段长度:4,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.PerScore = Double.Parse(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT(字段类型:char,字段长度:8,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT(字段类型:varchar,字段长度:100,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetObjByIdExamPaperQuestionTypeRela)", objException.Message));
}
return objvcc_ExamPaperQuestionTypeRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_ExamPaperQuestionTypeRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_ExamPaperQuestionTypeRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN()
{
IdExamPaperQuestionTypeRela = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()), //Id_ExamPaperQuestionTypeRela
CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(), //考卷流水号
CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(), //课程名称
ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(), //考卷名称
ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(), //试卷类型Id
ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(), //试卷类型名称
IsShow = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()), //是否启用
TotalScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()), //总得分
ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()), //浏览量
DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()), //已做人数
PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()), //考试时间（分钟）
PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(), //试卷显示模式名称
ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(), //考卷建立时间
UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(), //用户名
CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(), //课程章节ID
SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(), //节Id
ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(), //章名
SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(), //节名
ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(), //节名简称
QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()), //题目数
Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()), //分值
QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(), //题目类型名
QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(), //题目类型英文名
DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(), //默认答案模式Id
DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(), //默认答案类型Id
IsUse = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()), //是否使用
ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(), //章Id
NeedQuestionNum = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()), //需要题目数
PerScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()), //每题分值
OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(), //备注
ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(), //ChapterId4QT
ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(), //ChapterName_Sim4QT
ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim() //ChapterName4QT
};
objvcc_ExamPaperQuestionTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_ExamPaperQuestionTypeRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_ExamPaperQuestionTypeRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN();
try
{
objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaEN.IsShow = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaEN.UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperQuestionTypeRelaEN.Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaEN.IsUse = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数
objvcc_ExamPaperQuestionTypeRelaEN.PerScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值
objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号
objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperQuestionTypeRelaEN.Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetObjByDataRowvcc_ExamPaperQuestionTypeRela)", objException.Message));
}
objvcc_ExamPaperQuestionTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_ExamPaperQuestionTypeRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_ExamPaperQuestionTypeRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN = new clsvcc_ExamPaperQuestionTypeRelaEN();
try
{
objvcc_ExamPaperQuestionTypeRelaEN.IdExamPaperQuestionTypeRela = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela].ToString().Trim()); //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId = objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_ExamPaperQuestionTypeRelaEN.CourseId = objRow[convcc_ExamPaperQuestionTypeRela.CourseId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseId].ToString().Trim(); //课程Id
objvcc_ExamPaperQuestionTypeRelaEN.CourseName = objRow[convcc_ExamPaperQuestionTypeRela.CourseName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.CourseName].ToString().Trim(); //课程名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId].ToString().Trim(); //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName = objRow[convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName].ToString().Trim(); //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaEN.IsShow = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsShow].ToString().Trim()); //是否启用
objvcc_ExamPaperQuestionTypeRelaEN.TotalScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.TotalScore].ToString().Trim()); //总得分
objvcc_ExamPaperQuestionTypeRelaEN.ViewCount = objRow[convcc_ExamPaperQuestionTypeRela.ViewCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.ViewCount].ToString().Trim()); //浏览量
objvcc_ExamPaperQuestionTypeRelaEN.DoneNumber = objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.DoneNumber].ToString().Trim()); //已做人数
objvcc_ExamPaperQuestionTypeRelaEN.PaperTime = objRow[convcc_ExamPaperQuestionTypeRela.PaperTime] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.PaperTime].ToString().Trim()); //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName = objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.PaperDispModeName].ToString().Trim(); //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime = objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ExamCreateTime].ToString().Trim(); //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaEN.UserName = objRow[convcc_ExamPaperQuestionTypeRela.UserName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UserName].ToString().Trim(); //用户名
objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId = objRow[convcc_ExamPaperQuestionTypeRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_ExamPaperQuestionTypeRelaEN.SectionId = objRow[convcc_ExamPaperQuestionTypeRela.SectionId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionId].ToString().Trim(); //节Id
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName].ToString().Trim(); //章名
objvcc_ExamPaperQuestionTypeRelaEN.SectionName = objRow[convcc_ExamPaperQuestionTypeRela.SectionName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionName].ToString().Trim(); //节名
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim = objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_ExamPaperQuestionTypeRelaEN.QuestionNum = objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.QuestionNum].ToString().Trim()); //题目数
objvcc_ExamPaperQuestionTypeRelaEN.Scores = objRow[convcc_ExamPaperQuestionTypeRela.Scores] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.Scores].ToString().Trim()); //分值
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName = objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.QuestionTypeENName].ToString().Trim(); //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId].ToString().Trim(); //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId = objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId].ToString().Trim(); //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaEN.IsUse = TransNullToBool(objRow[convcc_ExamPaperQuestionTypeRela.IsUse].ToString().Trim()); //是否使用
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId].ToString().Trim(); //章Id
objvcc_ExamPaperQuestionTypeRelaEN.NeedQuestionNum = TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.NeedQuestionNum].ToString().Trim()); //需要题目数
objvcc_ExamPaperQuestionTypeRelaEN.PerScore = TransNullToDouble(objRow[convcc_ExamPaperQuestionTypeRela.PerScore].ToString().Trim()); //每题分值
objvcc_ExamPaperQuestionTypeRelaEN.OrderNum = objRow[convcc_ExamPaperQuestionTypeRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_ExamPaperQuestionTypeRela.OrderNum].ToString().Trim()); //序号
objvcc_ExamPaperQuestionTypeRelaEN.UpdDate = objRow[convcc_ExamPaperQuestionTypeRela.UpdDate].ToString().Trim(); //修改日期
objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId = objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_ExamPaperQuestionTypeRelaEN.Memo = objRow[convcc_ExamPaperQuestionTypeRela.Memo] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.Memo].ToString().Trim(); //备注
objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterId4QT].ToString().Trim(); //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT].ToString().Trim(); //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT = objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT] == DBNull.Value ? null : objRow[convcc_ExamPaperQuestionTypeRela.ChapterName4QT].ToString().Trim(); //ChapterName4QT
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA: GetObjByDataRow)", objException.Message));
}
objvcc_ExamPaperQuestionTypeRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_ExamPaperQuestionTypeRelaEN;
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
objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName, convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela, 8, "");
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
objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName, convcc_ExamPaperQuestionTypeRela.IdExamPaperQuestionTypeRela, 8, strPrefix);
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where " + strCondition;
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select IdExamPaperQuestionTypeRela from vcc_ExamPaperQuestionTypeRela where " + strCondition;
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
 /// <param name = "lngIdExamPaperQuestionTypeRela">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngIdExamPaperQuestionTypeRela)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_ExamPaperQuestionTypeRela", "IdExamPaperQuestionTypeRela = " + ""+ lngIdExamPaperQuestionTypeRela+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_ExamPaperQuestionTypeRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_ExamPaperQuestionTypeRela", strCondition))
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
objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_ExamPaperQuestionTypeRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaENS">源对象</param>
 /// <param name = "objvcc_ExamPaperQuestionTypeRelaENT">目标对象</param>
public void CopyTo(clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaENS, clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaENT)
{
objvcc_ExamPaperQuestionTypeRelaENT.IdExamPaperQuestionTypeRela = objvcc_ExamPaperQuestionTypeRelaENS.IdExamPaperQuestionTypeRela; //Id_ExamPaperQuestionTypeRela
objvcc_ExamPaperQuestionTypeRelaENT.CourseExamPaperId = objvcc_ExamPaperQuestionTypeRelaENS.CourseExamPaperId; //考卷流水号
objvcc_ExamPaperQuestionTypeRelaENT.CourseId = objvcc_ExamPaperQuestionTypeRelaENS.CourseId; //课程Id
objvcc_ExamPaperQuestionTypeRelaENT.CourseName = objvcc_ExamPaperQuestionTypeRelaENS.CourseName; //课程名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperName = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperName; //考卷名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperTypeId = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperTypeId; //试卷类型Id
objvcc_ExamPaperQuestionTypeRelaENT.ExamPaperTypeName = objvcc_ExamPaperQuestionTypeRelaENS.ExamPaperTypeName; //试卷类型名称
objvcc_ExamPaperQuestionTypeRelaENT.IsShow = objvcc_ExamPaperQuestionTypeRelaENS.IsShow; //是否启用
objvcc_ExamPaperQuestionTypeRelaENT.TotalScore = objvcc_ExamPaperQuestionTypeRelaENS.TotalScore; //总得分
objvcc_ExamPaperQuestionTypeRelaENT.ViewCount = objvcc_ExamPaperQuestionTypeRelaENS.ViewCount; //浏览量
objvcc_ExamPaperQuestionTypeRelaENT.DoneNumber = objvcc_ExamPaperQuestionTypeRelaENS.DoneNumber; //已做人数
objvcc_ExamPaperQuestionTypeRelaENT.PaperTime = objvcc_ExamPaperQuestionTypeRelaENS.PaperTime; //考试时间（分钟）
objvcc_ExamPaperQuestionTypeRelaENT.PaperDispModeName = objvcc_ExamPaperQuestionTypeRelaENS.PaperDispModeName; //试卷显示模式名称
objvcc_ExamPaperQuestionTypeRelaENT.ExamCreateTime = objvcc_ExamPaperQuestionTypeRelaENS.ExamCreateTime; //考卷建立时间
objvcc_ExamPaperQuestionTypeRelaENT.UserName = objvcc_ExamPaperQuestionTypeRelaENS.UserName; //用户名
objvcc_ExamPaperQuestionTypeRelaENT.CourseChapterId = objvcc_ExamPaperQuestionTypeRelaENS.CourseChapterId; //课程章节ID
objvcc_ExamPaperQuestionTypeRelaENT.SectionId = objvcc_ExamPaperQuestionTypeRelaENS.SectionId; //节Id
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName; //章名
objvcc_ExamPaperQuestionTypeRelaENT.SectionName = objvcc_ExamPaperQuestionTypeRelaENS.SectionName; //节名
objvcc_ExamPaperQuestionTypeRelaENT.ChapterNameSim = objvcc_ExamPaperQuestionTypeRelaENS.ChapterNameSim; //章名简称
objvcc_ExamPaperQuestionTypeRelaENT.SectionNameSim = objvcc_ExamPaperQuestionTypeRelaENS.SectionNameSim; //节名简称
objvcc_ExamPaperQuestionTypeRelaENT.QuestionNum = objvcc_ExamPaperQuestionTypeRelaENS.QuestionNum; //题目数
objvcc_ExamPaperQuestionTypeRelaENT.Scores = objvcc_ExamPaperQuestionTypeRelaENS.Scores; //分值
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeId = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeId; //题目类型Id
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeName = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeName; //题目类型名
objvcc_ExamPaperQuestionTypeRelaENT.QuestionTypeENName = objvcc_ExamPaperQuestionTypeRelaENS.QuestionTypeENName; //题目类型英文名
objvcc_ExamPaperQuestionTypeRelaENT.DefaAnswerModeId = objvcc_ExamPaperQuestionTypeRelaENS.DefaAnswerModeId; //默认答案模式Id
objvcc_ExamPaperQuestionTypeRelaENT.DefaAnswerTypeId = objvcc_ExamPaperQuestionTypeRelaENS.DefaAnswerTypeId; //默认答案类型Id
objvcc_ExamPaperQuestionTypeRelaENT.IsUse = objvcc_ExamPaperQuestionTypeRelaENS.IsUse; //是否使用
objvcc_ExamPaperQuestionTypeRelaENT.ChapterId = objvcc_ExamPaperQuestionTypeRelaENS.ChapterId; //章Id
objvcc_ExamPaperQuestionTypeRelaENT.NeedQuestionNum = objvcc_ExamPaperQuestionTypeRelaENS.NeedQuestionNum; //需要题目数
objvcc_ExamPaperQuestionTypeRelaENT.PerScore = objvcc_ExamPaperQuestionTypeRelaENS.PerScore; //每题分值
objvcc_ExamPaperQuestionTypeRelaENT.OrderNum = objvcc_ExamPaperQuestionTypeRelaENS.OrderNum; //序号
objvcc_ExamPaperQuestionTypeRelaENT.UpdDate = objvcc_ExamPaperQuestionTypeRelaENS.UpdDate; //修改日期
objvcc_ExamPaperQuestionTypeRelaENT.UpdUserId = objvcc_ExamPaperQuestionTypeRelaENS.UpdUserId; //修改用户Id
objvcc_ExamPaperQuestionTypeRelaENT.Memo = objvcc_ExamPaperQuestionTypeRelaENS.Memo; //备注
objvcc_ExamPaperQuestionTypeRelaENT.ChapterId4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterId4QT; //ChapterId4QT
objvcc_ExamPaperQuestionTypeRelaENT.ChapterNameSim4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterNameSim4QT; //ChapterName_Sim4QT
objvcc_ExamPaperQuestionTypeRelaENT.ChapterName4QT = objvcc_ExamPaperQuestionTypeRelaENS.ChapterName4QT; //ChapterName4QT
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_ExamPaperQuestionTypeRelaEN objvcc_ExamPaperQuestionTypeRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId, 8, convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.CourseId, 8, convcc_ExamPaperQuestionTypeRela.CourseId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.CourseName, 100, convcc_ExamPaperQuestionTypeRela.CourseName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName, 500, convcc_ExamPaperQuestionTypeRela.ExamPaperName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId, 2, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName, 30, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName, 30, convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime, 14, convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.UserName, 30, convcc_ExamPaperQuestionTypeRela.UserName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId, 8, convcc_ExamPaperQuestionTypeRela.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.SectionId, 8, convcc_ExamPaperQuestionTypeRela.SectionId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterName, 100, convcc_ExamPaperQuestionTypeRela.ChapterName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.SectionName, 100, convcc_ExamPaperQuestionTypeRela.SectionName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim, 10, convcc_ExamPaperQuestionTypeRela.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim, 10, convcc_ExamPaperQuestionTypeRela.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId, 2, convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName, 20, convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName, 50, convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId, 4, convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId, 2, convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterId, 8, convcc_ExamPaperQuestionTypeRela.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.UpdDate, 20, convcc_ExamPaperQuestionTypeRela.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId, 20, convcc_ExamPaperQuestionTypeRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.Memo, 1000, convcc_ExamPaperQuestionTypeRela.Memo);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT, 8, convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT, 10, convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT);
clsCheckSql.CheckFieldLen(objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT, 100, convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.CourseExamPaperId, convcc_ExamPaperQuestionTypeRela.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.CourseId, convcc_ExamPaperQuestionTypeRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.CourseName, convcc_ExamPaperQuestionTypeRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperName, convcc_ExamPaperQuestionTypeRela.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeId, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ExamPaperTypeName, convcc_ExamPaperQuestionTypeRela.ExamPaperTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.PaperDispModeName, convcc_ExamPaperQuestionTypeRela.PaperDispModeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ExamCreateTime, convcc_ExamPaperQuestionTypeRela.ExamCreateTime);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.UserName, convcc_ExamPaperQuestionTypeRela.UserName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.CourseChapterId, convcc_ExamPaperQuestionTypeRela.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.SectionId, convcc_ExamPaperQuestionTypeRela.SectionId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterName, convcc_ExamPaperQuestionTypeRela.ChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.SectionName, convcc_ExamPaperQuestionTypeRela.SectionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim, convcc_ExamPaperQuestionTypeRela.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.SectionNameSim, convcc_ExamPaperQuestionTypeRela.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeId, convcc_ExamPaperQuestionTypeRela.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeName, convcc_ExamPaperQuestionTypeRela.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.QuestionTypeENName, convcc_ExamPaperQuestionTypeRela.QuestionTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerModeId, convcc_ExamPaperQuestionTypeRela.DefaAnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.DefaAnswerTypeId, convcc_ExamPaperQuestionTypeRela.DefaAnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterId, convcc_ExamPaperQuestionTypeRela.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.UpdDate, convcc_ExamPaperQuestionTypeRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.UpdUserId, convcc_ExamPaperQuestionTypeRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.Memo, convcc_ExamPaperQuestionTypeRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterId4QT, convcc_ExamPaperQuestionTypeRela.ChapterId4QT);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterNameSim4QT, convcc_ExamPaperQuestionTypeRela.ChapterNameSim4QT);
clsCheckSql.CheckSqlInjection4Field(objvcc_ExamPaperQuestionTypeRelaEN.ChapterName4QT, convcc_ExamPaperQuestionTypeRela.ChapterName4QT);
//检查外键字段长度
 objvcc_ExamPaperQuestionTypeRelaEN._IsCheckProperty = true;
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName);
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_ExamPaperQuestionTypeRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_ExamPaperQuestionTypeRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}