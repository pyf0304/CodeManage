
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvcc_CourseExamPaperRelationship4AppDA
 表名:vcc_CourseExamPaperRelationship4App(01120256)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:47
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
 /// v题目与试卷关系4App(vcc_CourseExamPaperRelationship4App)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvcc_CourseExamPaperRelationship4AppDA : clsCommBase4DA
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
 return clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvcc_CourseExamPaperRelationship4AppEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vcc_CourseExamPaperRelationship4App(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable_vcc_CourseExamPaperRelationship4App)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaperRelationship4App.* from vcc_CourseExamPaperRelationship4App Left Join {1} on {2} where {3} and vcc_CourseExamPaperRelationship4App.mId not in (Select top {5} vcc_CourseExamPaperRelationship4App.mId from vcc_CourseExamPaperRelationship4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1} and mId not in (Select top {2} mId from vcc_CourseExamPaperRelationship4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1} and mId not in (Select top {3} mId from vcc_CourseExamPaperRelationship4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vcc_CourseExamPaperRelationship4App.* from vcc_CourseExamPaperRelationship4App Left Join {1} on {2} where {3} and vcc_CourseExamPaperRelationship4App.mId not in (Select top {5} vcc_CourseExamPaperRelationship4App.mId from vcc_CourseExamPaperRelationship4App Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1} and mId not in (Select top {2} mId from vcc_CourseExamPaperRelationship4App where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vcc_CourseExamPaperRelationship4App where {1} and mId not in (Select top {3} mId from vcc_CourseExamPaperRelationship4App where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA:GetObjLst)", objException.Message));
}
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
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
public List<clsvcc_CourseExamPaperRelationship4AppEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA:GetObjLstByTabName)", objException.Message));
}
List<clsvcc_CourseExamPaperRelationship4AppEN> arrObjLst = new List<clsvcc_CourseExamPaperRelationship4AppEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetObjLst)", objException.Message));
}
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvcc_CourseExamPaperRelationship4AppEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvcc_CourseExamPaperRelationship4App(ref clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where mId = " + ""+ objvcc_CourseExamPaperRelationship4AppEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvcc_CourseExamPaperRelationship4AppEN.mId = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionId = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = TransNullToFloat(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.IsEffective = TransNullToBool(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UserId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.StartTime = TransNullToDouble(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicScores = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.OrderNum = TransNullToInt(objDT.Rows[0][convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objDT.Rows[0][convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: Getvcc_CourseExamPaperRelationship4App)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvcc_CourseExamPaperRelationship4AppEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
 objvcc_CourseExamPaperRelationship4AppEN.mId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionId = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID(字段类型:char,字段长度:2,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : clsEntityBase2.TransNullToFloat_S(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分(字段类型:float,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.IsEffective = clsEntityBase2.TransNullToBool_S(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效(字段类型:bit,字段长度:1,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID(字段类型:varchar,字段长度:18,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)(字段类型:decimal,字段长度:12,是否可空:False)
 objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id(字段类型:char,字段长度:8,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称(字段类型:varchar,字段长度:50,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述(字段类型:varchar,字段长度:100,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.OrderNum = Int32.Parse(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetObjBymId)", objException.Message));
}
return objvcc_CourseExamPaperRelationship4AppEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvcc_CourseExamPaperRelationship4AppEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
strSQL = "Select * from vcc_CourseExamPaperRelationship4App where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN()
{
mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()), //mId
CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(), //考卷流水号
ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(), //考卷名称
CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(), //课程Id
CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(), //课程名称
QuestionId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()), //题目序号
QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(), //题目名称
QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(), //题目类型名
ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(), //题库等级ID
ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(), //题库等级名
QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()), //题目得分
IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()), //是否有效
UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(), //用户ID
StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()), //开始时间(s)
PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(), //试卷大题目Id
PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(), //试卷大题目名称
TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(), //标题描述
TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()), //大题得分
TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()), //TopicOrderNum
OrderNum = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim() //修改人
};
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationship4AppEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperRelationship4AppEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetObjByDataRowvcc_CourseExamPaperRelationship4App)", objException.Message));
}
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationship4AppEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvcc_CourseExamPaperRelationship4AppEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN = new clsvcc_CourseExamPaperRelationship4AppEN();
try
{
objvcc_CourseExamPaperRelationship4AppEN.mId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.mId].ToString().Trim()); //mId
objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId = objRow[convcc_CourseExamPaperRelationship4App.CourseExamPaperId].ToString().Trim(); //考卷流水号
objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName = objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamPaperName].ToString().Trim(); //考卷名称
objvcc_CourseExamPaperRelationship4AppEN.CourseId = objRow[convcc_CourseExamPaperRelationship4App.CourseId].ToString().Trim(); //课程Id
objvcc_CourseExamPaperRelationship4AppEN.CourseName = objRow[convcc_CourseExamPaperRelationship4App.CourseName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.CourseName].ToString().Trim(); //课程名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionId = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionId].ToString().Trim()); //题目Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionIndex = objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.QuestionIndex].ToString().Trim()); //题目序号
objvcc_CourseExamPaperRelationship4AppEN.QuestionName = objRow[convcc_CourseExamPaperRelationship4App.QuestionName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionName].ToString().Trim(); //题目名称
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeId].ToString().Trim(); //题目类型Id
objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName = objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.QuestionTypeName].ToString().Trim(); //题目类型名
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeId].ToString().Trim(); //题库等级ID
objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName = objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.ExamGradeName].ToString().Trim(); //题库等级名
objvcc_CourseExamPaperRelationship4AppEN.QuestionScore = objRow[convcc_CourseExamPaperRelationship4App.QuestionScore] == DBNull.Value ? (float?)null : TransNullToFloat(objRow[convcc_CourseExamPaperRelationship4App.QuestionScore].ToString().Trim()); //题目得分
objvcc_CourseExamPaperRelationship4AppEN.IsEffective = TransNullToBool(objRow[convcc_CourseExamPaperRelationship4App.IsEffective].ToString().Trim()); //是否有效
objvcc_CourseExamPaperRelationship4AppEN.UserId = objRow[convcc_CourseExamPaperRelationship4App.UserId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UserId].ToString().Trim(); //用户ID
objvcc_CourseExamPaperRelationship4AppEN.StartTime = objRow[convcc_CourseExamPaperRelationship4App.StartTime] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convcc_CourseExamPaperRelationship4App.StartTime].ToString().Trim()); //开始时间(s)
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicId].ToString().Trim(); //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName = objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.PapersBigTopicName].ToString().Trim(); //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppEN.TopicDescription = objRow[convcc_CourseExamPaperRelationship4App.TopicDescription] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.TopicDescription].ToString().Trim(); //标题描述
objvcc_CourseExamPaperRelationship4AppEN.TopicScores = objRow[convcc_CourseExamPaperRelationship4App.TopicScores] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicScores].ToString().Trim()); //大题得分
objvcc_CourseExamPaperRelationship4AppEN.TopicOrderNum = objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.TopicOrderNum].ToString().Trim()); //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppEN.OrderNum = TransNullToInt(objRow[convcc_CourseExamPaperRelationship4App.OrderNum].ToString().Trim()); //序号
objvcc_CourseExamPaperRelationship4AppEN.UpdDate = objRow[convcc_CourseExamPaperRelationship4App.UpdDate] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdDate].ToString().Trim(); //修改日期
objvcc_CourseExamPaperRelationship4AppEN.UpdUser = objRow[convcc_CourseExamPaperRelationship4App.UpdUser] == DBNull.Value ? null : objRow[convcc_CourseExamPaperRelationship4App.UpdUser].ToString().Trim(); //修改人
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA: GetObjByDataRow)", objException.Message));
}
objvcc_CourseExamPaperRelationship4AppEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvcc_CourseExamPaperRelationship4AppEN;
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
objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, convcc_CourseExamPaperRelationship4App.mId, 8, "");
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
objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, convcc_CourseExamPaperRelationship4App.mId, 8, strPrefix);
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vcc_CourseExamPaperRelationship4App where " + strCondition;
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vcc_CourseExamPaperRelationship4App where " + strCondition;
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaperRelationship4App", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvcc_CourseExamPaperRelationship4AppDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vcc_CourseExamPaperRelationship4App", strCondition))
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
objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vcc_CourseExamPaperRelationship4App");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENS">源对象</param>
 /// <param name = "objvcc_CourseExamPaperRelationship4AppENT">目标对象</param>
public void CopyTo(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENS, clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppENT)
{
objvcc_CourseExamPaperRelationship4AppENT.mId = objvcc_CourseExamPaperRelationship4AppENS.mId; //mId
objvcc_CourseExamPaperRelationship4AppENT.CourseExamPaperId = objvcc_CourseExamPaperRelationship4AppENS.CourseExamPaperId; //考卷流水号
objvcc_CourseExamPaperRelationship4AppENT.ExamPaperName = objvcc_CourseExamPaperRelationship4AppENS.ExamPaperName; //考卷名称
objvcc_CourseExamPaperRelationship4AppENT.CourseId = objvcc_CourseExamPaperRelationship4AppENS.CourseId; //课程Id
objvcc_CourseExamPaperRelationship4AppENT.CourseName = objvcc_CourseExamPaperRelationship4AppENS.CourseName; //课程名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionId = objvcc_CourseExamPaperRelationship4AppENS.QuestionId; //题目Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionIndex = objvcc_CourseExamPaperRelationship4AppENS.QuestionIndex; //题目序号
objvcc_CourseExamPaperRelationship4AppENT.QuestionName = objvcc_CourseExamPaperRelationship4AppENS.QuestionName; //题目名称
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeId = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeId; //题目类型Id
objvcc_CourseExamPaperRelationship4AppENT.QuestionTypeName = objvcc_CourseExamPaperRelationship4AppENS.QuestionTypeName; //题目类型名
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeId = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeId; //题库等级ID
objvcc_CourseExamPaperRelationship4AppENT.ExamGradeName = objvcc_CourseExamPaperRelationship4AppENS.ExamGradeName; //题库等级名
objvcc_CourseExamPaperRelationship4AppENT.QuestionScore = objvcc_CourseExamPaperRelationship4AppENS.QuestionScore; //题目得分
objvcc_CourseExamPaperRelationship4AppENT.IsEffective = objvcc_CourseExamPaperRelationship4AppENS.IsEffective; //是否有效
objvcc_CourseExamPaperRelationship4AppENT.UserId = objvcc_CourseExamPaperRelationship4AppENS.UserId; //用户ID
objvcc_CourseExamPaperRelationship4AppENT.StartTime = objvcc_CourseExamPaperRelationship4AppENS.StartTime; //开始时间(s)
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicId = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicId; //试卷大题目Id
objvcc_CourseExamPaperRelationship4AppENT.PapersBigTopicName = objvcc_CourseExamPaperRelationship4AppENS.PapersBigTopicName; //试卷大题目名称
objvcc_CourseExamPaperRelationship4AppENT.TopicDescription = objvcc_CourseExamPaperRelationship4AppENS.TopicDescription; //标题描述
objvcc_CourseExamPaperRelationship4AppENT.TopicScores = objvcc_CourseExamPaperRelationship4AppENS.TopicScores; //大题得分
objvcc_CourseExamPaperRelationship4AppENT.TopicOrderNum = objvcc_CourseExamPaperRelationship4AppENS.TopicOrderNum; //TopicOrderNum
objvcc_CourseExamPaperRelationship4AppENT.OrderNum = objvcc_CourseExamPaperRelationship4AppENS.OrderNum; //序号
objvcc_CourseExamPaperRelationship4AppENT.UpdDate = objvcc_CourseExamPaperRelationship4AppENS.UpdDate; //修改日期
objvcc_CourseExamPaperRelationship4AppENT.UpdUser = objvcc_CourseExamPaperRelationship4AppENS.UpdUser; //修改人
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvcc_CourseExamPaperRelationship4AppEN objvcc_CourseExamPaperRelationship4AppEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId, 8, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName, 500, convcc_CourseExamPaperRelationship4App.ExamPaperName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.CourseId, 8, convcc_CourseExamPaperRelationship4App.CourseId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.CourseName, 100, convcc_CourseExamPaperRelationship4App.CourseName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.QuestionName, 500, convcc_CourseExamPaperRelationship4App.QuestionName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId, 2, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName, 20, convcc_CourseExamPaperRelationship4App.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId, 2, convcc_CourseExamPaperRelationship4App.ExamGradeId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName, 50, convcc_CourseExamPaperRelationship4App.ExamGradeName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.UserId, 18, convcc_CourseExamPaperRelationship4App.UserId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId, 8, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName, 50, convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.TopicDescription, 100, convcc_CourseExamPaperRelationship4App.TopicDescription);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.UpdDate, 20, convcc_CourseExamPaperRelationship4App.UpdDate);
clsCheckSql.CheckFieldLen(objvcc_CourseExamPaperRelationship4AppEN.UpdUser, 20, convcc_CourseExamPaperRelationship4App.UpdUser);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.CourseExamPaperId, convcc_CourseExamPaperRelationship4App.CourseExamPaperId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.ExamPaperName, convcc_CourseExamPaperRelationship4App.ExamPaperName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.CourseId, convcc_CourseExamPaperRelationship4App.CourseId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.CourseName, convcc_CourseExamPaperRelationship4App.CourseName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.QuestionName, convcc_CourseExamPaperRelationship4App.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeId, convcc_CourseExamPaperRelationship4App.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.QuestionTypeName, convcc_CourseExamPaperRelationship4App.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.ExamGradeId, convcc_CourseExamPaperRelationship4App.ExamGradeId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.ExamGradeName, convcc_CourseExamPaperRelationship4App.ExamGradeName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.UserId, convcc_CourseExamPaperRelationship4App.UserId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicId, convcc_CourseExamPaperRelationship4App.PapersBigTopicId);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.PapersBigTopicName, convcc_CourseExamPaperRelationship4App.PapersBigTopicName);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.TopicDescription, convcc_CourseExamPaperRelationship4App.TopicDescription);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.UpdDate, convcc_CourseExamPaperRelationship4App.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvcc_CourseExamPaperRelationship4AppEN.UpdUser, convcc_CourseExamPaperRelationship4App.UpdUser);
//检查外键字段长度
 objvcc_CourseExamPaperRelationship4AppEN._IsCheckProperty = true;
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName);
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvcc_CourseExamPaperRelationship4AppEN._CurrTabName, strCondition);
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
 objSQL = clsvcc_CourseExamPaperRelationship4AppDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}