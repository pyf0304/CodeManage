
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvClassifyGatherFieldDA
 表名:vClassifyGatherField(01120016)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
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
 /// v分类汇总字段(vClassifyGatherField)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvClassifyGatherFieldDA : clsCommBase4DA
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
 return clsvClassifyGatherFieldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvClassifyGatherFieldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvClassifyGatherFieldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvClassifyGatherFieldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvClassifyGatherFieldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vClassifyGatherField(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable_vClassifyGatherField)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClassifyGatherField.* from vClassifyGatherField Left Join {1} on {2} where {3} and vClassifyGatherField.mId not in (Select top {5} vClassifyGatherField.mId from vClassifyGatherField Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1} and mId not in (Select top {2} mId from vClassifyGatherField where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1} and mId not in (Select top {3} mId from vClassifyGatherField where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} vClassifyGatherField.* from vClassifyGatherField Left Join {1} on {2} where {3} and vClassifyGatherField.mId not in (Select top {5} vClassifyGatherField.mId from vClassifyGatherField Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1} and mId not in (Select top {2} mId from vClassifyGatherField where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vClassifyGatherField where {1} and mId not in (Select top {3} mId from vClassifyGatherField where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvClassifyGatherFieldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA:GetObjLst)", objException.Message));
}
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = TransNullToInt(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = TransNullToBool(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = TransNullToBool(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = TransNullToInt(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetObjLst)", objException.Message));
}
objvClassifyGatherFieldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClassifyGatherFieldEN);
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
public List<clsvClassifyGatherFieldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA:GetObjLstByTabName)", objException.Message));
}
List<clsvClassifyGatherFieldEN> arrObjLst = new List<clsvClassifyGatherFieldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = TransNullToInt(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = TransNullToBool(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = TransNullToBool(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = TransNullToInt(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetObjLst)", objException.Message));
}
objvClassifyGatherFieldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvClassifyGatherFieldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvClassifyGatherField(ref clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where mId = " + ""+ objvClassifyGatherFieldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvClassifyGatherFieldEN.mId = TransNullToInt(objDT.Rows[0][convClassifyGatherField.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvClassifyGatherFieldEN.QuestionId = TransNullToInt(objDT.Rows[0][convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvClassifyGatherFieldEN.QuestionIndex = TransNullToInt(objDT.Rows[0][convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.QuestionNo = objDT.Rows[0][convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClassifyGatherFieldEN.QuestionName = objDT.Rows[0][convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvClassifyGatherFieldEN.GridTitle = objDT.Rows[0][convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.QuestionnaireSetId = objDT.Rows[0][convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.QuestionnaireSetName = objDT.Rows[0][convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.ClassifyGatherId = objDT.Rows[0][convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyGatherName = objDT.Rows[0][convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyFieldTypeId = objDT.Rows[0][convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyFieldTypeName = objDT.Rows[0][convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.GatherModeId = objDT.Rows[0][convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.GatherModeName = objDT.Rows[0][convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.QuestionTypeId = objDT.Rows[0][convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClassifyGatherFieldEN.QuestionTypeName = objDT.Rows[0][convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.AnswerTypeId = objDT.Rows[0][convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvClassifyGatherFieldEN.AnswerTypeName = objDT.Rows[0][convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.IsDefault = TransNullToBool(objDT.Rows[0][convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherFieldEN.AnswerModeId = objDT.Rows[0][convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.AnswerModeName = objDT.Rows[0][convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.DetailTitle = objDT.Rows[0][convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.IsDetailTitleIndexNo = TransNullToBool(objDT.Rows[0][convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherFieldEN.ClassifyGatherPeriod = objDT.Rows[0][convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.RecNo = TransNullToInt(objDT.Rows[0][convClassifyGatherField.RecNo].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.UpdDate = objDT.Rows[0][convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.UpdUser = objDT.Rows[0][convClassifyGatherField.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.Memo = objDT.Rows[0][convClassifyGatherField.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetvClassifyGatherField)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsvClassifyGatherFieldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
 objvClassifyGatherFieldEN.mId = Int32.Parse(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号(字段类型:int,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号(字段类型:varchar,字段长度:10,是否可空:True)
 objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称(字段类型:varchar,字段长度:500,是否可空:True)
 objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id(字段类型:char,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id(字段类型:char,字段长度:4,是否可空:True)
 objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题(字段类型:varchar,字段长度:30,是否可空:True)
 objvClassifyGatherFieldEN.IsDetailTitleIndexNo = clsEntityBase2.TransNullToBool_S(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号(字段类型:bit,字段长度:1,是否可空:True)
 objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
 objvClassifyGatherFieldEN.RecNo = Int32.Parse(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetObjBymId)", objException.Message));
}
return objvClassifyGatherFieldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvClassifyGatherFieldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
strSQL = "Select * from vClassifyGatherField where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN()
{
mId = TransNullToInt(objRow[convClassifyGatherField.mId].ToString().Trim()), //mId
QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionId].ToString().Trim()), //题目Id
QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()), //题目序号
QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(), //题目编号
QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(), //题目名称
GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(), //表格标题
QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(), //问卷集ID
QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(), //问卷集名
ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(), //分类统计Id
ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(), //分类统计名称
ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(), //分类字段类型Id
ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(), //分类字段类型名称
GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(), //汇总模式Id
GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(), //汇总模式名称
QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(), //题目类型Id
QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(), //题目类型名
AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(), //答案类型ID
AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(), //答案类型名
IsDefault = TransNullToBool(objRow[convClassifyGatherField.IsDefault].ToString().Trim()), //是否默认
AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(), //答案模式Id
AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(), //答案模式名称
DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(), //详细列表标题
IsDetailTitleIndexNo = TransNullToBool(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()), //标题是否编号
ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(), //分类统计时期
RecNo = TransNullToInt(objRow[convClassifyGatherField.RecNo].ToString().Trim()), //序号
UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(), //修改人
Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim() //备注
};
objvClassifyGatherFieldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherFieldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvClassifyGatherFieldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = TransNullToInt(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = TransNullToBool(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = TransNullToBool(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = TransNullToInt(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetObjByDataRowvClassifyGatherField)", objException.Message));
}
objvClassifyGatherFieldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherFieldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvClassifyGatherFieldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvClassifyGatherFieldEN objvClassifyGatherFieldEN = new clsvClassifyGatherFieldEN();
try
{
objvClassifyGatherFieldEN.mId = TransNullToInt(objRow[convClassifyGatherField.mId].ToString().Trim()); //mId
objvClassifyGatherFieldEN.QuestionId = objRow[convClassifyGatherField.QuestionId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionId].ToString().Trim()); //题目Id
objvClassifyGatherFieldEN.QuestionIndex = objRow[convClassifyGatherField.QuestionIndex] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convClassifyGatherField.QuestionIndex].ToString().Trim()); //题目序号
objvClassifyGatherFieldEN.QuestionNo = objRow[convClassifyGatherField.QuestionNo] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionNo].ToString().Trim(); //题目编号
objvClassifyGatherFieldEN.QuestionName = objRow[convClassifyGatherField.QuestionName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionName].ToString().Trim(); //题目名称
objvClassifyGatherFieldEN.GridTitle = objRow[convClassifyGatherField.GridTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.GridTitle].ToString().Trim(); //表格标题
objvClassifyGatherFieldEN.QuestionnaireSetId = objRow[convClassifyGatherField.QuestionnaireSetId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objvClassifyGatherFieldEN.QuestionnaireSetName = objRow[convClassifyGatherField.QuestionnaireSetName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionnaireSetName].ToString().Trim(); //问卷集名
objvClassifyGatherFieldEN.ClassifyGatherId = objRow[convClassifyGatherField.ClassifyGatherId].ToString().Trim(); //分类统计Id
objvClassifyGatherFieldEN.ClassifyGatherName = objRow[convClassifyGatherField.ClassifyGatherName].ToString().Trim(); //分类统计名称
objvClassifyGatherFieldEN.ClassifyFieldTypeId = objRow[convClassifyGatherField.ClassifyFieldTypeId].ToString().Trim(); //分类字段类型Id
objvClassifyGatherFieldEN.ClassifyFieldTypeName = objRow[convClassifyGatherField.ClassifyFieldTypeName].ToString().Trim(); //分类字段类型名称
objvClassifyGatherFieldEN.GatherModeId = objRow[convClassifyGatherField.GatherModeId].ToString().Trim(); //汇总模式Id
objvClassifyGatherFieldEN.GatherModeName = objRow[convClassifyGatherField.GatherModeName].ToString().Trim(); //汇总模式名称
objvClassifyGatherFieldEN.QuestionTypeId = objRow[convClassifyGatherField.QuestionTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeId].ToString().Trim(); //题目类型Id
objvClassifyGatherFieldEN.QuestionTypeName = objRow[convClassifyGatherField.QuestionTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.QuestionTypeName].ToString().Trim(); //题目类型名
objvClassifyGatherFieldEN.AnswerTypeId = objRow[convClassifyGatherField.AnswerTypeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeId].ToString().Trim(); //答案类型ID
objvClassifyGatherFieldEN.AnswerTypeName = objRow[convClassifyGatherField.AnswerTypeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerTypeName].ToString().Trim(); //答案类型名
objvClassifyGatherFieldEN.IsDefault = TransNullToBool(objRow[convClassifyGatherField.IsDefault].ToString().Trim()); //是否默认
objvClassifyGatherFieldEN.AnswerModeId = objRow[convClassifyGatherField.AnswerModeId] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeId].ToString().Trim(); //答案模式Id
objvClassifyGatherFieldEN.AnswerModeName = objRow[convClassifyGatherField.AnswerModeName] == DBNull.Value ? null : objRow[convClassifyGatherField.AnswerModeName].ToString().Trim(); //答案模式名称
objvClassifyGatherFieldEN.DetailTitle = objRow[convClassifyGatherField.DetailTitle] == DBNull.Value ? null : objRow[convClassifyGatherField.DetailTitle].ToString().Trim(); //详细列表标题
objvClassifyGatherFieldEN.IsDetailTitleIndexNo = TransNullToBool(objRow[convClassifyGatherField.IsDetailTitleIndexNo].ToString().Trim()); //标题是否编号
objvClassifyGatherFieldEN.ClassifyGatherPeriod = objRow[convClassifyGatherField.ClassifyGatherPeriod] == DBNull.Value ? null : objRow[convClassifyGatherField.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objvClassifyGatherFieldEN.RecNo = TransNullToInt(objRow[convClassifyGatherField.RecNo].ToString().Trim()); //序号
objvClassifyGatherFieldEN.UpdDate = objRow[convClassifyGatherField.UpdDate].ToString().Trim(); //修改日期
objvClassifyGatherFieldEN.UpdUser = objRow[convClassifyGatherField.UpdUser].ToString().Trim(); //修改人
objvClassifyGatherFieldEN.Memo = objRow[convClassifyGatherField.Memo] == DBNull.Value ? null : objRow[convClassifyGatherField.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvClassifyGatherFieldDA: GetObjByDataRow)", objException.Message));
}
objvClassifyGatherFieldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvClassifyGatherFieldEN;
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
objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClassifyGatherFieldEN._CurrTabName, convClassifyGatherField.mId, 8, "");
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
objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvClassifyGatherFieldEN._CurrTabName, convClassifyGatherField.mId, 8, strPrefix);
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from vClassifyGatherField where " + strCondition;
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from vClassifyGatherField where " + strCondition;
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClassifyGatherField", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvClassifyGatherFieldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vClassifyGatherField", strCondition))
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
objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vClassifyGatherField");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvClassifyGatherFieldENS">源对象</param>
 /// <param name = "objvClassifyGatherFieldENT">目标对象</param>
public void CopyTo(clsvClassifyGatherFieldEN objvClassifyGatherFieldENS, clsvClassifyGatherFieldEN objvClassifyGatherFieldENT)
{
objvClassifyGatherFieldENT.mId = objvClassifyGatherFieldENS.mId; //mId
objvClassifyGatherFieldENT.QuestionId = objvClassifyGatherFieldENS.QuestionId; //题目Id
objvClassifyGatherFieldENT.QuestionIndex = objvClassifyGatherFieldENS.QuestionIndex; //题目序号
objvClassifyGatherFieldENT.QuestionNo = objvClassifyGatherFieldENS.QuestionNo; //题目编号
objvClassifyGatherFieldENT.QuestionName = objvClassifyGatherFieldENS.QuestionName; //题目名称
objvClassifyGatherFieldENT.GridTitle = objvClassifyGatherFieldENS.GridTitle; //表格标题
objvClassifyGatherFieldENT.QuestionnaireSetId = objvClassifyGatherFieldENS.QuestionnaireSetId; //问卷集ID
objvClassifyGatherFieldENT.QuestionnaireSetName = objvClassifyGatherFieldENS.QuestionnaireSetName; //问卷集名
objvClassifyGatherFieldENT.ClassifyGatherId = objvClassifyGatherFieldENS.ClassifyGatherId; //分类统计Id
objvClassifyGatherFieldENT.ClassifyGatherName = objvClassifyGatherFieldENS.ClassifyGatherName; //分类统计名称
objvClassifyGatherFieldENT.ClassifyFieldTypeId = objvClassifyGatherFieldENS.ClassifyFieldTypeId; //分类字段类型Id
objvClassifyGatherFieldENT.ClassifyFieldTypeName = objvClassifyGatherFieldENS.ClassifyFieldTypeName; //分类字段类型名称
objvClassifyGatherFieldENT.GatherModeId = objvClassifyGatherFieldENS.GatherModeId; //汇总模式Id
objvClassifyGatherFieldENT.GatherModeName = objvClassifyGatherFieldENS.GatherModeName; //汇总模式名称
objvClassifyGatherFieldENT.QuestionTypeId = objvClassifyGatherFieldENS.QuestionTypeId; //题目类型Id
objvClassifyGatherFieldENT.QuestionTypeName = objvClassifyGatherFieldENS.QuestionTypeName; //题目类型名
objvClassifyGatherFieldENT.AnswerTypeId = objvClassifyGatherFieldENS.AnswerTypeId; //答案类型ID
objvClassifyGatherFieldENT.AnswerTypeName = objvClassifyGatherFieldENS.AnswerTypeName; //答案类型名
objvClassifyGatherFieldENT.IsDefault = objvClassifyGatherFieldENS.IsDefault; //是否默认
objvClassifyGatherFieldENT.AnswerModeId = objvClassifyGatherFieldENS.AnswerModeId; //答案模式Id
objvClassifyGatherFieldENT.AnswerModeName = objvClassifyGatherFieldENS.AnswerModeName; //答案模式名称
objvClassifyGatherFieldENT.DetailTitle = objvClassifyGatherFieldENS.DetailTitle; //详细列表标题
objvClassifyGatherFieldENT.IsDetailTitleIndexNo = objvClassifyGatherFieldENS.IsDetailTitleIndexNo; //标题是否编号
objvClassifyGatherFieldENT.ClassifyGatherPeriod = objvClassifyGatherFieldENS.ClassifyGatherPeriod; //分类统计时期
objvClassifyGatherFieldENT.RecNo = objvClassifyGatherFieldENS.RecNo; //序号
objvClassifyGatherFieldENT.UpdDate = objvClassifyGatherFieldENS.UpdDate; //修改日期
objvClassifyGatherFieldENT.UpdUser = objvClassifyGatherFieldENS.UpdUser; //修改人
objvClassifyGatherFieldENT.Memo = objvClassifyGatherFieldENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvClassifyGatherFieldEN objvClassifyGatherFieldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionNo, 10, convClassifyGatherField.QuestionNo);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionName, 500, convClassifyGatherField.QuestionName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.GridTitle, 30, convClassifyGatherField.GridTitle);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionnaireSetId, 4, convClassifyGatherField.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionnaireSetName, 50, convClassifyGatherField.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.ClassifyGatherId, 4, convClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.ClassifyGatherName, 30, convClassifyGatherField.ClassifyGatherName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.ClassifyFieldTypeId, 4, convClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.ClassifyFieldTypeName, 30, convClassifyGatherField.ClassifyFieldTypeName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.GatherModeId, 4, convClassifyGatherField.GatherModeId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.GatherModeName, 30, convClassifyGatherField.GatherModeName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionTypeId, 2, convClassifyGatherField.QuestionTypeId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.QuestionTypeName, 20, convClassifyGatherField.QuestionTypeName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.AnswerTypeId, 2, convClassifyGatherField.AnswerTypeId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.AnswerTypeName, 50, convClassifyGatherField.AnswerTypeName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.AnswerModeId, 4, convClassifyGatherField.AnswerModeId);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.AnswerModeName, 30, convClassifyGatherField.AnswerModeName);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.DetailTitle, 30, convClassifyGatherField.DetailTitle);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.ClassifyGatherPeriod, 50, convClassifyGatherField.ClassifyGatherPeriod);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.UpdDate, 20, convClassifyGatherField.UpdDate);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.UpdUser, 20, convClassifyGatherField.UpdUser);
clsCheckSql.CheckFieldLen(objvClassifyGatherFieldEN.Memo, 1000, convClassifyGatherField.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionNo, convClassifyGatherField.QuestionNo);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionName, convClassifyGatherField.QuestionName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.GridTitle, convClassifyGatherField.GridTitle);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionnaireSetId, convClassifyGatherField.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionnaireSetName, convClassifyGatherField.QuestionnaireSetName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.ClassifyGatherId, convClassifyGatherField.ClassifyGatherId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.ClassifyGatherName, convClassifyGatherField.ClassifyGatherName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.ClassifyFieldTypeId, convClassifyGatherField.ClassifyFieldTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.ClassifyFieldTypeName, convClassifyGatherField.ClassifyFieldTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.GatherModeId, convClassifyGatherField.GatherModeId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.GatherModeName, convClassifyGatherField.GatherModeName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionTypeId, convClassifyGatherField.QuestionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.QuestionTypeName, convClassifyGatherField.QuestionTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.AnswerTypeId, convClassifyGatherField.AnswerTypeId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.AnswerTypeName, convClassifyGatherField.AnswerTypeName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.AnswerModeId, convClassifyGatherField.AnswerModeId);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.AnswerModeName, convClassifyGatherField.AnswerModeName);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.DetailTitle, convClassifyGatherField.DetailTitle);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.ClassifyGatherPeriod, convClassifyGatherField.ClassifyGatherPeriod);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.UpdDate, convClassifyGatherField.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.UpdUser, convClassifyGatherField.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvClassifyGatherFieldEN.Memo, convClassifyGatherField.Memo);
//检查外键字段长度
 objvClassifyGatherFieldEN._IsCheckProperty = true;
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClassifyGatherFieldEN._CurrTabName);
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvClassifyGatherFieldEN._CurrTabName, strCondition);
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
 objSQL = clsvClassifyGatherFieldDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}