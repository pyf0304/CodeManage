
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_KnowledgesExamLibRelaDA
 表名:vcc_KnowledgesExamLibRela(01120142)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:05
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
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
 /// v知识点习题关系(vcc_KnowledgesExamLibRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_KnowledgesExamLibRelaDA : clsCommBase4DA
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
 return clsvcc_KnowledgesExamLibRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_KnowledgesExamLibRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_KnowledgesExamLibRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_KnowledgesExamLibRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_KnowledgesExamLibRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_KnowledgesExamLibRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable_vcc_KnowledgesExamLibRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_KnowledgesExamLibRela.* from vcc_KnowledgesExamLibRela Left Join {1} on {2} where {3} and vcc_KnowledgesExamLibRela.mId not in (Select top {5} vcc_KnowledgesExamLibRela.mId from vcc_KnowledgesExamLibRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1} and mId not in (Select top {2} mId from vcc_KnowledgesExamLibRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1} and mId not in (Select top {3} mId from vcc_KnowledgesExamLibRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_KnowledgesExamLibRela.* from vcc_KnowledgesExamLibRela Left Join {1} on {2} where {3} and vcc_KnowledgesExamLibRela.mId not in (Select top {5} vcc_KnowledgesExamLibRela.mId from vcc_KnowledgesExamLibRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1} and mId not in (Select top {2} mId from vcc_KnowledgesExamLibRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_KnowledgesExamLibRela where {1} and mId not in (Select top {3} mId from vcc_KnowledgesExamLibRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_KnowledgesExamLibRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA:GetObjLst)", objException.Message));
}
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterNameSim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionNameSim4Question
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetObjLst)", objException.Message));
}
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
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
public List<clsvcc_KnowledgesExamLibRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_KnowledgesExamLibRelaEN> arrObjLst = new List<clsvcc_KnowledgesExamLibRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetObjLst)", objException.Message));
}
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_KnowledgesExamLibRela(ref clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where mId = " + ""+ objvcc_KnowledgesExamLibRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objDT.Rows[0][convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionID = objDT.Rows[0][convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionName = objDT.Rows[0][convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionContent = objDT.Rows[0][convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objDT.Rows[0][convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objDT.Rows[0][convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseId = objDT.Rows[0][convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objDT.Rows[0][convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objDT.Rows[0][convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objDT.Rows[0][convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objDT.Rows[0][convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objDT.Rows[0][convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseName = objDT.Rows[0][convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objDT.Rows[0][convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.ChapterId = objDT.Rows[0][convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objDT.Rows[0][convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.UpdDate = objDT.Rows[0][convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.UpdUserId = objDT.Rows[0][convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.Memo = objDT.Rows[0][convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objDT.Rows[0][convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterNameSim4Question(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objDT.Rows[0][convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionNameSim4Question(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: Getvcc_KnowledgesExamLibRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_KnowledgesExamLibRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
 objvcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容(字段类型:text,字段长度:2147483647,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question(字段类型:varchar,字段长度:10,是否可空:True)
 objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question(字段类型:varchar,字段长度:10,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetObjBymId)", objException.Message));
}
return objvcc_KnowledgesExamLibRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_KnowledgesExamLibRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from vcc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN()
{
mId = TransNullToInt(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()), //mId
QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(), //题目ID
QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(), //题目内容
ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(), //章名简称
SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(), //节名简称
CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(), //课程Id
PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()), //正相关度
CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(), //知识点Id
KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(), //知识点名称
KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(), //知识点标题
KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(), //知识点内容
CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(), //课程名称
CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(), //课程章节ID
ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(), //章Id
NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()), //负相关度
UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(), //备注
ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(), //ChapterNameSim4Question
SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim() //SectionNameSim4Question
};
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_KnowledgesExamLibRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_KnowledgesExamLibRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterName_Sim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionName_Sim4Question
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetObjByDataRowvcc_KnowledgesExamLibRela)", objException.Message));
}
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_KnowledgesExamLibRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_KnowledgesExamLibRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN = new clsvcc_KnowledgesExamLibRelaEN();
try
{
objvcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[convcc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objvcc_KnowledgesExamLibRelaEN.QuestionID = objRow[convcc_KnowledgesExamLibRela.QuestionID].ToString().Trim(); //题目ID
objvcc_KnowledgesExamLibRelaEN.QuestionIndex = objRow[convcc_KnowledgesExamLibRela.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_KnowledgesExamLibRela.QuestionIndex].ToString().Trim()); //题目序号
objvcc_KnowledgesExamLibRelaEN.QuestionName = objRow[convcc_KnowledgesExamLibRela.QuestionName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionName].ToString().Trim(); //题目名称
objvcc_KnowledgesExamLibRelaEN.QuestionContent = objRow[convcc_KnowledgesExamLibRela.QuestionContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.QuestionContent].ToString().Trim(); //题目内容
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim].ToString().Trim(); //章名简称
objvcc_KnowledgesExamLibRelaEN.SectionNameSim = objRow[convcc_KnowledgesExamLibRela.SectionNameSim] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim].ToString().Trim(); //节名简称
objvcc_KnowledgesExamLibRelaEN.CourseId = objRow[convcc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objvcc_KnowledgesExamLibRelaEN.PositiveCorrelation = objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[convcc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objvcc_KnowledgesExamLibRelaEN.KnowledgeName = objRow[convcc_KnowledgesExamLibRela.KnowledgeName].ToString().Trim(); //知识点名称
objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle = objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeTitle].ToString().Trim(); //知识点标题
objvcc_KnowledgesExamLibRelaEN.KnowledgeContent = objRow[convcc_KnowledgesExamLibRela.KnowledgeContent] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.KnowledgeContent].ToString().Trim(); //知识点内容
objvcc_KnowledgesExamLibRelaEN.CourseName = objRow[convcc_KnowledgesExamLibRela.CourseName] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.CourseName].ToString().Trim(); //课程名称
objvcc_KnowledgesExamLibRelaEN.CourseChapterId = objRow[convcc_KnowledgesExamLibRela.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_KnowledgesExamLibRelaEN.ChapterId = objRow[convcc_KnowledgesExamLibRela.ChapterId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterId].ToString().Trim(); //章Id
objvcc_KnowledgesExamLibRelaEN.NegativeCorrelation = objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objvcc_KnowledgesExamLibRelaEN.UpdDate = objRow[convcc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objvcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[convcc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objvcc_KnowledgesExamLibRelaEN.Memo = objRow[convcc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question = objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.ChapterNameSim4Question].ToString().Trim(); //ChapterNameSim4Question
objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question = objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question] == DBNull.Value ? null : objRow[convcc_KnowledgesExamLibRela.SectionNameSim4Question].ToString().Trim(); //SectionNameSim4Question
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_KnowledgesExamLibRelaDA: GetObjByDataRow)", objException.Message));
}
objvcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_KnowledgesExamLibRelaEN;
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
objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_KnowledgesExamLibRelaEN._CurrTabName, convcc_KnowledgesExamLibRela.mId, 8, "");
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
objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_KnowledgesExamLibRelaEN._CurrTabName, convcc_KnowledgesExamLibRela.mId, 8, strPrefix);
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vcc_KnowledgesExamLibRela where " + strCondition;
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vcc_KnowledgesExamLibRela where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_KnowledgesExamLibRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_KnowledgesExamLibRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_KnowledgesExamLibRela", strCondition))
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
objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_KnowledgesExamLibRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <param name = "objvcc_KnowledgesExamLibRelaENT">目标对象</param>
public void CopyTo(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENS, clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaENT)
{
objvcc_KnowledgesExamLibRelaENT.mId = objvcc_KnowledgesExamLibRelaENS.mId; //mId
objvcc_KnowledgesExamLibRelaENT.QuestionID = objvcc_KnowledgesExamLibRelaENS.QuestionID; //题目ID
objvcc_KnowledgesExamLibRelaENT.QuestionIndex = objvcc_KnowledgesExamLibRelaENS.QuestionIndex; //题目序号
objvcc_KnowledgesExamLibRelaENT.QuestionName = objvcc_KnowledgesExamLibRelaENS.QuestionName; //题目名称
objvcc_KnowledgesExamLibRelaENT.QuestionContent = objvcc_KnowledgesExamLibRelaENS.QuestionContent; //题目内容
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim; //章名简称
objvcc_KnowledgesExamLibRelaENT.SectionNameSim = objvcc_KnowledgesExamLibRelaENS.SectionNameSim; //节名简称
objvcc_KnowledgesExamLibRelaENT.CourseId = objvcc_KnowledgesExamLibRelaENS.CourseId; //课程Id
objvcc_KnowledgesExamLibRelaENT.PositiveCorrelation = objvcc_KnowledgesExamLibRelaENS.PositiveCorrelation; //正相关度
objvcc_KnowledgesExamLibRelaENT.CourseKnowledgeId = objvcc_KnowledgesExamLibRelaENS.CourseKnowledgeId; //知识点Id
objvcc_KnowledgesExamLibRelaENT.KnowledgeName = objvcc_KnowledgesExamLibRelaENS.KnowledgeName; //知识点名称
objvcc_KnowledgesExamLibRelaENT.KnowledgeTitle = objvcc_KnowledgesExamLibRelaENS.KnowledgeTitle; //知识点标题
objvcc_KnowledgesExamLibRelaENT.KnowledgeContent = objvcc_KnowledgesExamLibRelaENS.KnowledgeContent; //知识点内容
objvcc_KnowledgesExamLibRelaENT.CourseName = objvcc_KnowledgesExamLibRelaENS.CourseName; //课程名称
objvcc_KnowledgesExamLibRelaENT.CourseChapterId = objvcc_KnowledgesExamLibRelaENS.CourseChapterId; //课程章节ID
objvcc_KnowledgesExamLibRelaENT.ChapterId = objvcc_KnowledgesExamLibRelaENS.ChapterId; //章Id
objvcc_KnowledgesExamLibRelaENT.NegativeCorrelation = objvcc_KnowledgesExamLibRelaENS.NegativeCorrelation; //负相关度
objvcc_KnowledgesExamLibRelaENT.UpdDate = objvcc_KnowledgesExamLibRelaENS.UpdDate; //修改日期
objvcc_KnowledgesExamLibRelaENT.UpdUserId = objvcc_KnowledgesExamLibRelaENS.UpdUserId; //修改用户Id
objvcc_KnowledgesExamLibRelaENT.Memo = objvcc_KnowledgesExamLibRelaENS.Memo; //备注
objvcc_KnowledgesExamLibRelaENT.ChapterNameSim4Question = objvcc_KnowledgesExamLibRelaENS.ChapterNameSim4Question; //ChapterNameSim4Question
objvcc_KnowledgesExamLibRelaENT.SectionNameSim4Question = objvcc_KnowledgesExamLibRelaENS.SectionNameSim4Question; //SectionNameSim4Question
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_KnowledgesExamLibRelaEN objvcc_KnowledgesExamLibRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.QuestionID, 8, convcc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.QuestionName, 500, convcc_KnowledgesExamLibRela.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.QuestionContent, 4000, convcc_KnowledgesExamLibRela.QuestionContent);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.ChapterNameSim, 10, convcc_KnowledgesExamLibRela.ChapterNameSim);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.SectionNameSim, 10, convcc_KnowledgesExamLibRela.SectionNameSim);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.CourseId, 8, convcc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.KnowledgeName, 100, convcc_KnowledgesExamLibRela.KnowledgeName);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle, 100, convcc_KnowledgesExamLibRela.KnowledgeTitle);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.CourseName, 100, convcc_KnowledgesExamLibRela.CourseName);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.CourseChapterId, 8, convcc_KnowledgesExamLibRela.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.ChapterId, 8, convcc_KnowledgesExamLibRela.ChapterId);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.UpdDate, 20, convcc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.UpdUserId, 20, convcc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.Memo, 1000, convcc_KnowledgesExamLibRela.Memo);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question, 10, convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
clsCheckSql.CheckFieldLen(objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question, 10, convcc_KnowledgesExamLibRela.SectionNameSim4Question);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.QuestionID, convcc_KnowledgesExamLibRela.QuestionID);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.QuestionName, convcc_KnowledgesExamLibRela.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.QuestionContent, convcc_KnowledgesExamLibRela.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.ChapterNameSim, convcc_KnowledgesExamLibRela.ChapterNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.SectionNameSim, convcc_KnowledgesExamLibRela.SectionNameSim);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.CourseId, convcc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, convcc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.KnowledgeName, convcc_KnowledgesExamLibRela.KnowledgeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.KnowledgeTitle, convcc_KnowledgesExamLibRela.KnowledgeTitle);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.CourseName, convcc_KnowledgesExamLibRela.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.CourseChapterId, convcc_KnowledgesExamLibRela.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.ChapterId, convcc_KnowledgesExamLibRela.ChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.UpdDate, convcc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.UpdUserId, convcc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.Memo, convcc_KnowledgesExamLibRela.Memo);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.ChapterNameSim4Question, convcc_KnowledgesExamLibRela.ChapterNameSim4Question);
clsCheckSql.CheckSqlInjection4Field(objvcc_KnowledgesExamLibRelaEN.SectionNameSim4Question, convcc_KnowledgesExamLibRela.SectionNameSim4Question);
//检查外键字段长度
 objvcc_KnowledgesExamLibRelaEN._IsCheckProperty = true;
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_KnowledgesExamLibRelaEN._CurrTabName);
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_KnowledgesExamLibRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}