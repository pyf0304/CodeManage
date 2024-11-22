
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationshipDA
 表名:vcc_CourseExamPaperRelationship(01120075)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:29:24
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
 /// 题目与试卷关系(vcc_CourseExamPaperRelationship)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseExamPaperRelationshipDA : clsCommBase4DA
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
 return clsvcc_CourseExamPaperRelationshipEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationshipEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationshipEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationshipEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationshipEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseExamPaperRelationship(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable_vcc_CourseExamPaperRelationship)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaperRelationship.* from vcc_CourseExamPaperRelationship Left Join {1} on {2} where {3} and vcc_CourseExamPaperRelationship.mId not in (Select top {5} vcc_CourseExamPaperRelationship.mId from vcc_CourseExamPaperRelationship Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1} and mId not in (Select top {2} mId from vcc_CourseExamPaperRelationship where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1} and mId not in (Select top {3} mId from vcc_CourseExamPaperRelationship where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaperRelationship.* from vcc_CourseExamPaperRelationship Left Join {1} on {2} where {3} and vcc_CourseExamPaperRelationship.mId not in (Select top {5} vcc_CourseExamPaperRelationship.mId from vcc_CourseExamPaperRelationship Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1} and mId not in (Select top {2} mId from vcc_CourseExamPaperRelationship where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship where {1} and mId not in (Select top {3} mId from vcc_CourseExamPaperRelationship where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseExamPaperRelationshipEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
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
public List<clsvcc_CourseExamPaperRelationshipEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseExamPaperRelationshipEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationshipEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperRelationshipEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseExamPaperRelationship(ref clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where mId = " + ""+ objvcc_CourseExamPaperRelationshipEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseExamPaperRelationshipEN.mId = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objDT.Rows[0][convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objDT.Rows[0][convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseId = objDT.Rows[0][convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseName = objDT.Rows[0][convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionId = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionName = objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionContent = objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objDT.Rows[0][convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objDT.Rows[0][convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objDT.Rows[0][convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objDT.Rows[0][convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objDT.Rows[0][convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objDT.Rows[0][convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objDT.Rows[0][convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objDT.Rows[0][convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objDT.Rows[0][convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objDT.Rows[0][convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.DefaultValue = objDT.Rows[0][convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TextDirectId = objDT.Rows[0][convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTab = objDT.Rows[0][convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objDT.Rows[0][convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabName = objDT.Rows[0][convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objDT.Rows[0][convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.RelaEvent = objDT.Rows[0][convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FirstIndent = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objDT.Rows[0][convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsEffective = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UserId = objDT.Rows[0][convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.StartTime = TransNullToDouble(objDT.Rows[0][convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objDT.Rows[0][convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objDT.Rows[0][convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicDescription = objDT.Rows[0][convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicScores = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UpdDate = objDT.Rows[0][convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UpdUser = objDT.Rows[0][convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: Getvcc_CourseExamPaperRelationship)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseExamPaperRelationshipEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
 objvcc_CourseExamPaperRelationshipEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案(字段类型:varchar,字段长度:8000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID(字段类型:char,字段长度:8,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号(字段类型:varchar,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID(字段类型:char,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件(字段类型:varchar,字段长度:200,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件(字段类型:varchar,字段长度:4000,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FirstIndent = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetObjBymId)", objException.Message));
}
return objvcc_CourseExamPaperRelationshipEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseExamPaperRelationshipEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN()
{
mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()), //mId
CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(), //考卷流水号
ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(), //考卷名称
CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(), //课程名称
QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(), //题目名称
QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(), //题目内容
ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(), //题目答案
CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(), //课程章节ID
CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(), //课程章节名称
ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(), //父节点编号
ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(), //父节点名称
QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(), //题目类型名
ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(), //题库等级名
AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(), //答案模式Id
IsHaveAdditionalMemo = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()), //是否有附加说明
QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()), //题目得分
QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(), //题目补充
DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(), //缺省值
TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(), //文本方向ID
FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()), //填空框宽度
MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()), //备注框宽度
CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(), //代码表
CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(), //CodeTab_Code
CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(), //CodeTab_Name
CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(), //代码表_条件
RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(), //相关事件
FirstIndent = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()), //首行缩进
DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(), //默认选项
FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()), //填空框高度
IsMulti4FillInText = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()), //是否填空框多行
CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()), //复选框限制数
IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()), //是否有效
UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(), //用户ID
StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()), //开始时间(s)
PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(), //试卷大题目Id
PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(), //试卷大题目名称
TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(), //标题描述
TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()), //大题得分
TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()), //TopicOrderNum
OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim() //修改人
};
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationshipEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperRelationshipEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetObjByDataRowvcc_CourseExamPaperRelationship)", objException.Message));
}
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationshipEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperRelationshipEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN = new clsvcc_CourseExamPaperRelationshipEN();
try
{
objvcc_CourseExamPaperRelationshipEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationshipEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationshipEN.CourseId = objRow[convcc_CourseExamPaperRelationship.CourseId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationshipEN.CourseName = objRow[convcc_CourseExamPaperRelationship.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationshipEN.QuestionId = objRow[convcc_CourseExamPaperRelationship.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationshipEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationshipEN.QuestionName = objRow[convcc_CourseExamPaperRelationship.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationshipEN.QuestionContent = objRow[convcc_CourseExamPaperRelationship.QuestionContent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionContent].ToString().Trim(); //题目内容
objvcc_CourseExamPaperRelationshipEN.ExamAnswer = objRow[convcc_CourseExamPaperRelationship.ExamAnswer] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamAnswer].ToString().Trim(); //题目答案
objvcc_CourseExamPaperRelationshipEN.CourseChapterId = objRow[convcc_CourseExamPaperRelationship.CourseChapterId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterId].ToString().Trim(); //课程章节ID
objvcc_CourseExamPaperRelationshipEN.CourseChapterName = objRow[convcc_CourseExamPaperRelationship.CourseChapterName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CourseChapterName].ToString().Trim(); //课程章节名称
objvcc_CourseExamPaperRelationshipEN.ParentNodeId = objRow[convcc_CourseExamPaperRelationship.ParentNodeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeId].ToString().Trim(); //父节点编号
objvcc_CourseExamPaperRelationshipEN.ParentNodeName = objRow[convcc_CourseExamPaperRelationship.ParentNodeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ParentNodeName].ToString().Trim(); //父节点名称
objvcc_CourseExamPaperRelationshipEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationshipEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationshipEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationshipEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationshipEN.AnswerTypeId = objRow[convcc_CourseExamPaperRelationship.AnswerTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerTypeId].ToString().Trim(); //答案类型ID
objvcc_CourseExamPaperRelationshipEN.AnswerModeId = objRow[convcc_CourseExamPaperRelationship.AnswerModeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.AnswerModeId].ToString().Trim(); //答案模式Id
objvcc_CourseExamPaperRelationshipEN.IsHaveAdditionalMemo = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsHaveAdditionalMemo].ToString().Trim()); //是否有附加说明
objvcc_CourseExamPaperRelationshipEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd = objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.QuestionNameAdd].ToString().Trim(); //题目补充
objvcc_CourseExamPaperRelationshipEN.DefaultValue = objRow[convcc_CourseExamPaperRelationship.DefaultValue] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultValue].ToString().Trim(); //缺省值
objvcc_CourseExamPaperRelationshipEN.TextDirectId = objRow[convcc_CourseExamPaperRelationship.TextDirectId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TextDirectId].ToString().Trim(); //文本方向ID
objvcc_CourseExamPaperRelationshipEN.FillInTextWidth = objRow[convcc_CourseExamPaperRelationship.FillInTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextWidth].ToString().Trim()); //填空框宽度
objvcc_CourseExamPaperRelationshipEN.MemoTextWidth = objRow[convcc_CourseExamPaperRelationship.MemoTextWidth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.MemoTextWidth].ToString().Trim()); //备注框宽度
objvcc_CourseExamPaperRelationshipEN.CodeTab = objRow[convcc_CourseExamPaperRelationship.CodeTab] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTab].ToString().Trim(); //代码表
objvcc_CourseExamPaperRelationshipEN.CodeTabCode = objRow[convcc_CourseExamPaperRelationship.CodeTabCode] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCode].ToString().Trim(); //CodeTab_Code
objvcc_CourseExamPaperRelationshipEN.CodeTabName = objRow[convcc_CourseExamPaperRelationship.CodeTabName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabName].ToString().Trim(); //CodeTab_Name
objvcc_CourseExamPaperRelationshipEN.CodeTabCondition = objRow[convcc_CourseExamPaperRelationship.CodeTabCondition] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.CodeTabCondition].ToString().Trim(); //代码表_条件
objvcc_CourseExamPaperRelationshipEN.RelaEvent = objRow[convcc_CourseExamPaperRelationship.RelaEvent] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.RelaEvent].ToString().Trim(); //相关事件
objvcc_CourseExamPaperRelationshipEN.FirstIndent = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.FirstIndent].ToString().Trim()); //首行缩进
objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem = objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.DefaultSelectItem].ToString().Trim(); //默认选项
objvcc_CourseExamPaperRelationshipEN.FillInTextHeight = objRow[convcc_CourseExamPaperRelationship.FillInTextHeight] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.FillInTextHeight].ToString().Trim()); //填空框高度
objvcc_CourseExamPaperRelationshipEN.IsMulti4FillInText = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsMulti4FillInText].ToString().Trim()); //是否填空框多行
objvcc_CourseExamPaperRelationshipEN.CheckBoxLimitCount = objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.CheckBoxLimitCount].ToString().Trim()); //复选框限制数
objvcc_CourseExamPaperRelationshipEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationshipEN.UserId = objRow[convcc_CourseExamPaperRelationship.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationshipEN.StartTime = objRow[convcc_CourseExamPaperRelationship.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationshipEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationshipEN.TopicScores = objRow[convcc_CourseExamPaperRelationship.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationshipEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationshipEN.OrderNum = objRow[convcc_CourseExamPaperRelationship.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationshipEN.UpdDate = objRow[convcc_CourseExamPaperRelationship.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationshipEN.UpdUser = objRow[convcc_CourseExamPaperRelationship.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationshipDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseExamPaperRelationshipEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationshipEN;
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
objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperRelationshipEN._CurrTabName, convcc_CourseExamPaperRelationship.mId, 8, "");
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
objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperRelationshipEN._CurrTabName, convcc_CourseExamPaperRelationship.mId, 8, strPrefix);
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vcc_CourseExamPaperRelationship where " + strCondition;
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vcc_CourseExamPaperRelationship where " + strCondition;
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaperRelationship", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationshipDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaperRelationship", strCondition))
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
objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseExamPaperRelationship");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationshipENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationshipENT">目标对象</param>
public void CopyTo(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENS, clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipENT)
{
objvcc_CourseExamPaperRelationshipENT.mId = objvcc_CourseExamPaperRelationshipENS.mId; //mId
objvcc_CourseExamPaperRelationshipENT.CourseExamPaperId = objvcc_CourseExamPaperRelationshipENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationshipENT.ExamPaperName = objvcc_CourseExamPaperRelationshipENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationshipENT.CourseId = objvcc_CourseExamPaperRelationshipENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationshipENT.CourseName = objvcc_CourseExamPaperRelationshipENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationshipENT.QuestionId = objvcc_CourseExamPaperRelationshipENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationshipENT.QuestionIndex = objvcc_CourseExamPaperRelationshipENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationshipENT.QuestionName = objvcc_CourseExamPaperRelationshipENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationshipENT.QuestionContent = objvcc_CourseExamPaperRelationshipENS.QuestionContent; //题目内容
objvcc_CourseExamPaperRelationshipENT.ExamAnswer = objvcc_CourseExamPaperRelationshipENS.ExamAnswer; //题目答案
objvcc_CourseExamPaperRelationshipENT.CourseChapterId = objvcc_CourseExamPaperRelationshipENS.CourseChapterId; //课程章节ID
objvcc_CourseExamPaperRelationshipENT.CourseChapterName = objvcc_CourseExamPaperRelationshipENS.CourseChapterName; //课程章节名称
objvcc_CourseExamPaperRelationshipENT.ParentNodeId = objvcc_CourseExamPaperRelationshipENS.ParentNodeId; //父节点编号
objvcc_CourseExamPaperRelationshipENT.ParentNodeName = objvcc_CourseExamPaperRelationshipENS.ParentNodeName; //父节点名称
objvcc_CourseExamPaperRelationshipENT.QuestionTypeId = objvcc_CourseExamPaperRelationshipENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationshipENT.QuestionTypeName = objvcc_CourseExamPaperRelationshipENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationshipENT.ExamGradeId = objvcc_CourseExamPaperRelationshipENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationshipENT.ExamGradeName = objvcc_CourseExamPaperRelationshipENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationshipENT.AnswerTypeId = objvcc_CourseExamPaperRelationshipENS.AnswerTypeId; //答案类型ID
objvcc_CourseExamPaperRelationshipENT.AnswerModeId = objvcc_CourseExamPaperRelationshipENS.AnswerModeId; //答案模式Id
objvcc_CourseExamPaperRelationshipENT.IsHaveAdditionalMemo = objvcc_CourseExamPaperRelationshipENS.IsHaveAdditionalMemo; //是否有附加说明
objvcc_CourseExamPaperRelationshipENT.QuestionScore = objvcc_CourseExamPaperRelationshipENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationshipENT.QuestionNameAdd = objvcc_CourseExamPaperRelationshipENS.QuestionNameAdd; //题目补充
objvcc_CourseExamPaperRelationshipENT.DefaultValue = objvcc_CourseExamPaperRelationshipENS.DefaultValue; //缺省值
objvcc_CourseExamPaperRelationshipENT.TextDirectId = objvcc_CourseExamPaperRelationshipENS.TextDirectId; //文本方向ID
objvcc_CourseExamPaperRelationshipENT.FillInTextWidth = objvcc_CourseExamPaperRelationshipENS.FillInTextWidth; //填空框宽度
objvcc_CourseExamPaperRelationshipENT.MemoTextWidth = objvcc_CourseExamPaperRelationshipENS.MemoTextWidth; //备注框宽度
objvcc_CourseExamPaperRelationshipENT.CodeTab = objvcc_CourseExamPaperRelationshipENS.CodeTab; //代码表
objvcc_CourseExamPaperRelationshipENT.CodeTabCode = objvcc_CourseExamPaperRelationshipENS.CodeTabCode; //CodeTab_Code
objvcc_CourseExamPaperRelationshipENT.CodeTabName = objvcc_CourseExamPaperRelationshipENS.CodeTabName; //CodeTab_Name
objvcc_CourseExamPaperRelationshipENT.CodeTabCondition = objvcc_CourseExamPaperRelationshipENS.CodeTabCondition; //代码表_条件
objvcc_CourseExamPaperRelationshipENT.RelaEvent = objvcc_CourseExamPaperRelationshipENS.RelaEvent; //相关事件
objvcc_CourseExamPaperRelationshipENT.FirstIndent = objvcc_CourseExamPaperRelationshipENS.FirstIndent; //首行缩进
objvcc_CourseExamPaperRelationshipENT.DefaultSelectItem = objvcc_CourseExamPaperRelationshipENS.DefaultSelectItem; //默认选项
objvcc_CourseExamPaperRelationshipENT.FillInTextHeight = objvcc_CourseExamPaperRelationshipENS.FillInTextHeight; //填空框高度
objvcc_CourseExamPaperRelationshipENT.IsMulti4FillInText = objvcc_CourseExamPaperRelationshipENS.IsMulti4FillInText; //是否填空框多行
objvcc_CourseExamPaperRelationshipENT.CheckBoxLimitCount = objvcc_CourseExamPaperRelationshipENS.CheckBoxLimitCount; //复选框限制数
objvcc_CourseExamPaperRelationshipENT.IsEffective = objvcc_CourseExamPaperRelationshipENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationshipENT.UserId = objvcc_CourseExamPaperRelationshipENS.UserId; //用户ID
objvcc_CourseExamPaperRelationshipENT.StartTime = objvcc_CourseExamPaperRelationshipENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicId = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationshipENT.PapersBigTopicName = objvcc_CourseExamPaperRelationshipENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationshipENT.TopicDescription = objvcc_CourseExamPaperRelationshipENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationshipENT.TopicScores = objvcc_CourseExamPaperRelationshipENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationshipENT.TopicOrderNum = objvcc_CourseExamPaperRelationshipENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationshipENT.OrderNum = objvcc_CourseExamPaperRelationshipENS.OrderNum; //序号
objvcc_CourseExamPaperRelationshipENT.UpdDate = objvcc_CourseExamPaperRelationshipENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationshipENT.UpdUser = objvcc_CourseExamPaperRelationshipENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseExamPaperRelationshipEN objvcc_CourseExamPaperRelationshipEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId, 8, convcc_CourseExamPaperRelationship.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ExamPaperName, 500, convcc_CourseExamPaperRelationship.ExamPaperName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CourseId, 8, convcc_CourseExamPaperRelationship.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CourseName, 100, convcc_CourseExamPaperRelationship.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.QuestionName, 500, convcc_CourseExamPaperRelationship.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.QuestionContent, 4000, convcc_CourseExamPaperRelationship.QuestionContent);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ExamAnswer, 8000, convcc_CourseExamPaperRelationship.ExamAnswer);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CourseChapterId, 8, convcc_CourseExamPaperRelationship.CourseChapterId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CourseChapterName, 100, convcc_CourseExamPaperRelationship.CourseChapterName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ParentNodeId, 8, convcc_CourseExamPaperRelationship.ParentNodeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ParentNodeName, 100, convcc_CourseExamPaperRelationship.ParentNodeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.QuestionTypeId, 2, convcc_CourseExamPaperRelationship.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.QuestionTypeName, 20, convcc_CourseExamPaperRelationship.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ExamGradeId, 2, convcc_CourseExamPaperRelationship.ExamGradeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.ExamGradeName, 50, convcc_CourseExamPaperRelationship.ExamGradeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.AnswerTypeId, 2, convcc_CourseExamPaperRelationship.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.AnswerModeId, 4, convcc_CourseExamPaperRelationship.AnswerModeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd, 500, convcc_CourseExamPaperRelationship.QuestionNameAdd);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.DefaultValue, 50, convcc_CourseExamPaperRelationship.DefaultValue);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.TextDirectId, 4, convcc_CourseExamPaperRelationship.TextDirectId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CodeTab, 50, convcc_CourseExamPaperRelationship.CodeTab);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CodeTabCode, 50, convcc_CourseExamPaperRelationship.CodeTabCode);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CodeTabName, 50, convcc_CourseExamPaperRelationship.CodeTabName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.CodeTabCondition, 200, convcc_CourseExamPaperRelationship.CodeTabCondition);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.RelaEvent, 4000, convcc_CourseExamPaperRelationship.RelaEvent);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem, 20, convcc_CourseExamPaperRelationship.DefaultSelectItem);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.UserId, 18, convcc_CourseExamPaperRelationship.UserId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId, 8, convcc_CourseExamPaperRelationship.PapersBigTopicId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName, 50, convcc_CourseExamPaperRelationship.PapersBigTopicName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.TopicDescription, 100, convcc_CourseExamPaperRelationship.TopicDescription);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.UpdDate, 20, convcc_CourseExamPaperRelationship.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationshipEN.UpdUser, 20, convcc_CourseExamPaperRelationship.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CourseExamPaperId, convcc_CourseExamPaperRelationship.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ExamPaperName, convcc_CourseExamPaperRelationship.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CourseId, convcc_CourseExamPaperRelationship.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CourseName, convcc_CourseExamPaperRelationship.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.QuestionName, convcc_CourseExamPaperRelationship.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.QuestionContent, convcc_CourseExamPaperRelationship.QuestionContent);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ExamAnswer, convcc_CourseExamPaperRelationship.ExamAnswer);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CourseChapterId, convcc_CourseExamPaperRelationship.CourseChapterId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CourseChapterName, convcc_CourseExamPaperRelationship.CourseChapterName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ParentNodeId, convcc_CourseExamPaperRelationship.ParentNodeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ParentNodeName, convcc_CourseExamPaperRelationship.ParentNodeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.QuestionTypeId, convcc_CourseExamPaperRelationship.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.QuestionTypeName, convcc_CourseExamPaperRelationship.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ExamGradeId, convcc_CourseExamPaperRelationship.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.ExamGradeName, convcc_CourseExamPaperRelationship.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.AnswerTypeId, convcc_CourseExamPaperRelationship.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.AnswerModeId, convcc_CourseExamPaperRelationship.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.QuestionNameAdd, convcc_CourseExamPaperRelationship.QuestionNameAdd);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.DefaultValue, convcc_CourseExamPaperRelationship.DefaultValue);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.TextDirectId, convcc_CourseExamPaperRelationship.TextDirectId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CodeTab, convcc_CourseExamPaperRelationship.CodeTab);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CodeTabCode, convcc_CourseExamPaperRelationship.CodeTabCode);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CodeTabName, convcc_CourseExamPaperRelationship.CodeTabName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.CodeTabCondition, convcc_CourseExamPaperRelationship.CodeTabCondition);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.RelaEvent, convcc_CourseExamPaperRelationship.RelaEvent);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.DefaultSelectItem, convcc_CourseExamPaperRelationship.DefaultSelectItem);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.UserId, convcc_CourseExamPaperRelationship.UserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.PapersBigTopicId, convcc_CourseExamPaperRelationship.PapersBigTopicId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.PapersBigTopicName, convcc_CourseExamPaperRelationship.PapersBigTopicName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.TopicDescription, convcc_CourseExamPaperRelationship.TopicDescription);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.UpdDate, convcc_CourseExamPaperRelationship.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationshipEN.UpdUser, convcc_CourseExamPaperRelationship.UpdUser);
//检查外键字段长度
 objvcc_CourseExamPaperRelationshipEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperRelationshipEN._CurrTabName);
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperRelationshipEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseExamPaperRelationshipDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}