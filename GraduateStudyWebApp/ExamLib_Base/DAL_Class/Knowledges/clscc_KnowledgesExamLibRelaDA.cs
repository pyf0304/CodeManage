
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clscc_KnowledgesExamLibRelaDA
 表名:cc_KnowledgesExamLibRela(01120140)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 05:58:39
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
 /// 知识点习题关系(cc_KnowledgesExamLibRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clscc_KnowledgesExamLibRelaDA : clsCommBase4DA
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
 return clscc_KnowledgesExamLibRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clscc_KnowledgesExamLibRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clscc_KnowledgesExamLibRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clscc_KnowledgesExamLibRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clscc_KnowledgesExamLibRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_cc_KnowledgesExamLibRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable_cc_KnowledgesExamLibRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_KnowledgesExamLibRela.* from cc_KnowledgesExamLibRela Left Join {1} on {2} where {3} and cc_KnowledgesExamLibRela.mId not in (Select top {5} cc_KnowledgesExamLibRela.mId from cc_KnowledgesExamLibRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1} and mId not in (Select top {2} mId from cc_KnowledgesExamLibRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1} and mId not in (Select top {3} mId from cc_KnowledgesExamLibRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} cc_KnowledgesExamLibRela.* from cc_KnowledgesExamLibRela Left Join {1} on {2} where {3} and cc_KnowledgesExamLibRela.mId not in (Select top {5} cc_KnowledgesExamLibRela.mId from cc_KnowledgesExamLibRela Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1} and mId not in (Select top {2} mId from cc_KnowledgesExamLibRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from cc_KnowledgesExamLibRela where {1} and mId not in (Select top {3} mId from cc_KnowledgesExamLibRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clscc_KnowledgesExamLibRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA:GetObjLst)", objException.Message));
}
List<clscc_KnowledgesExamLibRelaEN> arrObjLst = new List<clscc_KnowledgesExamLibRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN();
try
{
objcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objcc_KnowledgesExamLibRelaEN.QuestionId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgesExamLibRelaEN.CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objcc_KnowledgesExamLibRelaEN.IsMain = TransNullToBool(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源
objcc_KnowledgesExamLibRelaEN.UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgesExamLibRelaEN.Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetObjLst)", objException.Message));
}
objcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_KnowledgesExamLibRelaEN);
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
public List<clscc_KnowledgesExamLibRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clscc_KnowledgesExamLibRelaEN> arrObjLst = new List<clscc_KnowledgesExamLibRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN();
try
{
objcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objcc_KnowledgesExamLibRelaEN.QuestionId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgesExamLibRelaEN.CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objcc_KnowledgesExamLibRelaEN.IsMain = TransNullToBool(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源
objcc_KnowledgesExamLibRelaEN.UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgesExamLibRelaEN.Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetObjLst)", objException.Message));
}
objcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objcc_KnowledgesExamLibRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getcc_KnowledgesExamLibRela(ref clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where mId = " + ""+ objcc_KnowledgesExamLibRelaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objDT.Rows[0][concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.QuestionId = TransNullToInt(objDT.Rows[0][concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.CourseId = objDT.Rows[0][concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objDT.Rows[0][concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objDT.Rows[0][concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objDT.Rows[0][concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.IsMain = TransNullToBool(objDT.Rows[0][concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.UpdDate = objDT.Rows[0][concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.UpdUserId = objDT.Rows[0][concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.Memo = objDT.Rows[0][concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: Getcc_KnowledgesExamLibRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clscc_KnowledgesExamLibRelaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN();
try
{
 objcc_KnowledgesExamLibRelaEN.mId = Int32.Parse(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.QuestionId = Int32.Parse(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id(字段类型:bigint,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id(字段类型:char,字段长度:8,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = Double.Parse(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id(字段类型:char,字段长度:8,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = Double.Parse(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度(字段类型:decimal,字段长度:6,是否可空:False)
 objcc_KnowledgesExamLibRelaEN.IsMain = clsEntityBase2.TransNullToBool_S(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源(字段类型:bit,字段长度:1,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objcc_KnowledgesExamLibRelaEN.Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetObjBymId)", objException.Message));
}
return objcc_KnowledgesExamLibRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clscc_KnowledgesExamLibRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN()
{
mId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()), //mId
QuestionId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()), //题目Id
CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(), //课程Id
PositiveCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()), //正相关度
CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(), //知识点Id
NegativeCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()), //负相关度
IsMain = TransNullToBool(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()), //是否主资源
UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim() //备注
};
objcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_KnowledgesExamLibRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clscc_KnowledgesExamLibRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN();
try
{
objcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objcc_KnowledgesExamLibRelaEN.QuestionId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgesExamLibRelaEN.CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objcc_KnowledgesExamLibRelaEN.IsMain = TransNullToBool(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源
objcc_KnowledgesExamLibRelaEN.UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgesExamLibRelaEN.Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetObjByDataRowcc_KnowledgesExamLibRela)", objException.Message));
}
objcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_KnowledgesExamLibRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clscc_KnowledgesExamLibRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN = new clscc_KnowledgesExamLibRelaEN();
try
{
objcc_KnowledgesExamLibRelaEN.mId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.mId].ToString().Trim()); //mId
objcc_KnowledgesExamLibRelaEN.QuestionId = TransNullToInt(objRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim()); //题目Id
objcc_KnowledgesExamLibRelaEN.CourseId = objRow[concc_KnowledgesExamLibRela.CourseId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objcc_KnowledgesExamLibRelaEN.PositiveCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim()); //正相关度
objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objcc_KnowledgesExamLibRelaEN.NegativeCorrelation = TransNullToDouble(objRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim()); //负相关度
objcc_KnowledgesExamLibRelaEN.IsMain = TransNullToBool(objRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim()); //是否主资源
objcc_KnowledgesExamLibRelaEN.UpdDate = objRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objcc_KnowledgesExamLibRelaEN.UpdUserId = objRow[concc_KnowledgesExamLibRela.UpdUserId] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objcc_KnowledgesExamLibRelaEN.Memo = objRow[concc_KnowledgesExamLibRela.Memo] == DBNull.Value ? null : objRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clscc_KnowledgesExamLibRelaDA: GetObjByDataRow)", objException.Message));
}
objcc_KnowledgesExamLibRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objcc_KnowledgesExamLibRelaEN;
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
objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_KnowledgesExamLibRelaEN._CurrTabName, concc_KnowledgesExamLibRela.mId, 8, "");
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
objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clscc_KnowledgesExamLibRelaEN._CurrTabName, concc_KnowledgesExamLibRela.mId, 8, strPrefix);
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from cc_KnowledgesExamLibRela where " + strCondition;
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from cc_KnowledgesExamLibRela where " + strCondition;
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_KnowledgesExamLibRela", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("cc_KnowledgesExamLibRela", strCondition))
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
objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("cc_KnowledgesExamLibRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
 {
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_KnowledgesExamLibRelaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_KnowledgesExamLibRela");
objRow = objDS.Tables["cc_KnowledgesExamLibRela"].NewRow();
objRow[concc_KnowledgesExamLibRela.QuestionId] = objcc_KnowledgesExamLibRelaEN.QuestionId; //题目Id
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  "")
 {
objRow[concc_KnowledgesExamLibRela.CourseId] = objcc_KnowledgesExamLibRelaEN.CourseId; //课程Id
 }
objRow[concc_KnowledgesExamLibRela.PositiveCorrelation] = objcc_KnowledgesExamLibRelaEN.PositiveCorrelation; //正相关度
objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId] = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId; //知识点Id
objRow[concc_KnowledgesExamLibRela.NegativeCorrelation] = objcc_KnowledgesExamLibRelaEN.NegativeCorrelation; //负相关度
objRow[concc_KnowledgesExamLibRela.IsMain] = objcc_KnowledgesExamLibRelaEN.IsMain; //是否主资源
objRow[concc_KnowledgesExamLibRela.UpdDate] = objcc_KnowledgesExamLibRelaEN.UpdDate; //修改日期
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  "")
 {
objRow[concc_KnowledgesExamLibRela.UpdUserId] = objcc_KnowledgesExamLibRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  "")
 {
objRow[concc_KnowledgesExamLibRela.Memo] = objcc_KnowledgesExamLibRelaEN.Memo; //备注
 }
objDS.Tables[clscc_KnowledgesExamLibRelaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clscc_KnowledgesExamLibRelaEN._CurrTabName);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.QuestionId);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.QuestionId.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseId);
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.PositiveCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.PositiveCorrelation.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.NegativeCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.NegativeCorrelation.ToString());
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.IsMain);
 arrValueListForInsert.Add("'" + (objcc_KnowledgesExamLibRelaEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdDate);
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdUserId);
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.Memo);
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_KnowledgesExamLibRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.QuestionId);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.QuestionId.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseId);
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.PositiveCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.PositiveCorrelation.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.NegativeCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.NegativeCorrelation.ToString());
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.IsMain);
 arrValueListForInsert.Add("'" + (objcc_KnowledgesExamLibRelaEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdDate);
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdUserId);
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.Memo);
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_KnowledgesExamLibRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.QuestionId);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.QuestionId.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseId);
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.PositiveCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.PositiveCorrelation.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.NegativeCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.NegativeCorrelation.ToString());
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.IsMain);
 arrValueListForInsert.Add("'" + (objcc_KnowledgesExamLibRelaEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdDate);
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdUserId);
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.Memo);
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_KnowledgesExamLibRela");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objcc_KnowledgesExamLibRelaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.QuestionId);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.QuestionId.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseId);
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.PositiveCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.PositiveCorrelation.ToString());
 
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.CourseKnowledgeId);
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCourseKnowledgeId + "'");
 }
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.NegativeCorrelation);
 arrValueListForInsert.Add(objcc_KnowledgesExamLibRelaEN.NegativeCorrelation.ToString());
 
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.IsMain);
 arrValueListForInsert.Add("'" + (objcc_KnowledgesExamLibRelaEN.IsMain  ==  false ? "0" : "1") + "'");
 
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdDate);
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.UpdUserId);
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(concc_KnowledgesExamLibRela.Memo);
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into cc_KnowledgesExamLibRela");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool Addnewcc_KnowledgesExamLibRelas(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "cc_KnowledgesExamLibRela");
//检查关键字的唯一性
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clscc_KnowledgesExamLibRelaEN._CurrTabName ].NewRow();
objRow[concc_KnowledgesExamLibRela.QuestionId] = oRow[concc_KnowledgesExamLibRela.QuestionId].ToString().Trim(); //题目Id
objRow[concc_KnowledgesExamLibRela.CourseId] = oRow[concc_KnowledgesExamLibRela.CourseId].ToString().Trim(); //课程Id
objRow[concc_KnowledgesExamLibRela.PositiveCorrelation] = oRow[concc_KnowledgesExamLibRela.PositiveCorrelation].ToString().Trim(); //正相关度
objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId] = oRow[concc_KnowledgesExamLibRela.CourseKnowledgeId].ToString().Trim(); //知识点Id
objRow[concc_KnowledgesExamLibRela.NegativeCorrelation] = oRow[concc_KnowledgesExamLibRela.NegativeCorrelation].ToString().Trim(); //负相关度
objRow[concc_KnowledgesExamLibRela.IsMain] = oRow[concc_KnowledgesExamLibRela.IsMain].ToString().Trim(); //是否主资源
objRow[concc_KnowledgesExamLibRela.UpdDate] = oRow[concc_KnowledgesExamLibRela.UpdDate].ToString().Trim(); //修改日期
objRow[concc_KnowledgesExamLibRela.UpdUserId] = oRow[concc_KnowledgesExamLibRela.UpdUserId].ToString().Trim(); //修改用户Id
objRow[concc_KnowledgesExamLibRela.Memo] = oRow[concc_KnowledgesExamLibRela.Memo].ToString().Trim(); //备注
 objDS.Tables[clscc_KnowledgesExamLibRelaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clscc_KnowledgesExamLibRelaEN._CurrTabName);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_KnowledgesExamLibRelaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
strSQL = "Select * from cc_KnowledgesExamLibRela where mId = " + ""+ objcc_KnowledgesExamLibRelaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clscc_KnowledgesExamLibRelaEN._CurrTabName);
if (objDS.Tables[clscc_KnowledgesExamLibRelaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objcc_KnowledgesExamLibRelaEN.mId+"");
return false;
}
objRow = objDS.Tables[clscc_KnowledgesExamLibRelaEN._CurrTabName].Rows[0];
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.QuestionId))
 {
objRow[concc_KnowledgesExamLibRela.QuestionId] = objcc_KnowledgesExamLibRelaEN.QuestionId; //题目Id
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseId))
 {
objRow[concc_KnowledgesExamLibRela.CourseId] = objcc_KnowledgesExamLibRelaEN.CourseId; //课程Id
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation))
 {
objRow[concc_KnowledgesExamLibRela.PositiveCorrelation] = objcc_KnowledgesExamLibRelaEN.PositiveCorrelation; //正相关度
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId))
 {
objRow[concc_KnowledgesExamLibRela.CourseKnowledgeId] = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId; //知识点Id
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation))
 {
objRow[concc_KnowledgesExamLibRela.NegativeCorrelation] = objcc_KnowledgesExamLibRelaEN.NegativeCorrelation; //负相关度
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.IsMain))
 {
objRow[concc_KnowledgesExamLibRela.IsMain] = objcc_KnowledgesExamLibRelaEN.IsMain; //是否主资源
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdDate))
 {
objRow[concc_KnowledgesExamLibRela.UpdDate] = objcc_KnowledgesExamLibRelaEN.UpdDate; //修改日期
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId))
 {
objRow[concc_KnowledgesExamLibRela.UpdUserId] = objcc_KnowledgesExamLibRelaEN.UpdUserId; //修改用户Id
 }
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.Memo))
 {
objRow[concc_KnowledgesExamLibRela.Memo] = objcc_KnowledgesExamLibRelaEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clscc_KnowledgesExamLibRelaEN._CurrTabName);
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update cc_KnowledgesExamLibRela Set ");
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.QuestionId, concc_KnowledgesExamLibRela.QuestionId); //题目Id
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_KnowledgesExamLibRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.CourseId); //课程Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.PositiveCorrelation, concc_KnowledgesExamLibRela.PositiveCorrelation); //正相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, concc_KnowledgesExamLibRela.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.NegativeCorrelation, concc_KnowledgesExamLibRela.NegativeCorrelation); //负相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.IsMain))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_KnowledgesExamLibRelaEN.IsMain == true?"1":"0", concc_KnowledgesExamLibRela.IsMain); //是否主资源
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdDate))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_KnowledgesExamLibRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_KnowledgesExamLibRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.Memo))
 {
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_KnowledgesExamLibRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_KnowledgesExamLibRelaEN.mId); 
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strCondition)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_KnowledgesExamLibRela Set ");
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_KnowledgesExamLibRelaEN.QuestionId); //题目Id
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation))
 {
 sbSQL.AppendFormat(" PositiveCorrelation = {0},", objcc_KnowledgesExamLibRelaEN.PositiveCorrelation); //正相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation))
 {
 sbSQL.AppendFormat(" NegativeCorrelation = {0},", objcc_KnowledgesExamLibRelaEN.NegativeCorrelation); //负相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.IsMain))
 {
 sbSQL.AppendFormat(" IsMain = '{0}',", objcc_KnowledgesExamLibRelaEN.IsMain == true?"1":"0"); //是否主资源
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdDate))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.Memo))
 {
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_KnowledgesExamLibRela Set ");
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.QuestionId))
 {
 sbSQL.AppendFormat(" QuestionId = {0},", objcc_KnowledgesExamLibRelaEN.QuestionId); //题目Id
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseId = '{0}',", strCourseId); //课程Id
 }
 else
 {
 sbSQL.Append(" CourseId = null,"); //课程Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation))
 {
 sbSQL.AppendFormat(" PositiveCorrelation = {0},", objcc_KnowledgesExamLibRelaEN.PositiveCorrelation); //正相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CourseKnowledgeId = '{0}',", strCourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.Append(" CourseKnowledgeId = null,"); //知识点Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation))
 {
 sbSQL.AppendFormat(" NegativeCorrelation = {0},", objcc_KnowledgesExamLibRelaEN.NegativeCorrelation); //负相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.IsMain))
 {
 sbSQL.AppendFormat(" IsMain = '{0}',", objcc_KnowledgesExamLibRelaEN.IsMain == true?"1":"0"); //是否主资源
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdDate))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.Memo))
 {
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objcc_KnowledgesExamLibRelaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objcc_KnowledgesExamLibRelaEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objcc_KnowledgesExamLibRelaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objcc_KnowledgesExamLibRelaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update cc_KnowledgesExamLibRela Set ");
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.QuestionId))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.QuestionId, concc_KnowledgesExamLibRela.QuestionId); //题目Id
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseId !=  null)
 {
 var strCourseId = objcc_KnowledgesExamLibRelaEN.CourseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseId, concc_KnowledgesExamLibRela.CourseId); //课程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.CourseId); //课程Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.PositiveCorrelation))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.PositiveCorrelation, concc_KnowledgesExamLibRela.PositiveCorrelation); //正相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.CourseKnowledgeId))
 {
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId  ==  "")
 {
 objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId = null;
 }
 if (objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId !=  null)
 {
 var strCourseKnowledgeId = objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCourseKnowledgeId, concc_KnowledgesExamLibRela.CourseKnowledgeId); //知识点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.CourseKnowledgeId); //知识点Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.NegativeCorrelation))
 {
 sbSQL.AppendFormat("{1} = {0},",objcc_KnowledgesExamLibRelaEN.NegativeCorrelation, concc_KnowledgesExamLibRela.NegativeCorrelation); //负相关度
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.IsMain))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objcc_KnowledgesExamLibRelaEN.IsMain == true?"1":"0", concc_KnowledgesExamLibRela.IsMain); //是否主资源
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdDate))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdDate !=  null)
 {
 var strUpdDate = objcc_KnowledgesExamLibRelaEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, concc_KnowledgesExamLibRela.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.UpdDate); //修改日期
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.UpdUserId))
 {
 if (objcc_KnowledgesExamLibRelaEN.UpdUserId !=  null)
 {
 var strUpdUserId = objcc_KnowledgesExamLibRelaEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, concc_KnowledgesExamLibRela.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.UpdUserId); //修改用户Id
 }
 }
 
 if (objcc_KnowledgesExamLibRelaEN.IsUpdated(concc_KnowledgesExamLibRela.Memo))
 {
 if (objcc_KnowledgesExamLibRelaEN.Memo !=  null)
 {
 var strMemo = objcc_KnowledgesExamLibRelaEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, concc_KnowledgesExamLibRela.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",concc_KnowledgesExamLibRela.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objcc_KnowledgesExamLibRelaEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("cc_KnowledgesExamLibRela_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
//删除cc_KnowledgesExamLibRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_KnowledgesExamLibRela where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int Delcc_KnowledgesExamLibRela(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除cc_KnowledgesExamLibRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_KnowledgesExamLibRela where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
//删除cc_KnowledgesExamLibRela本表中与当前对象有关的记录
strSQL = strSQL + "Delete from cc_KnowledgesExamLibRela where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int Delcc_KnowledgesExamLibRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: Delcc_KnowledgesExamLibRela)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_KnowledgesExamLibRela where " + strCondition ;
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
public bool Delcc_KnowledgesExamLibRelaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clscc_KnowledgesExamLibRelaDA: Delcc_KnowledgesExamLibRelaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from cc_KnowledgesExamLibRela where " + strCondition ;
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
 /// <param name = "objcc_KnowledgesExamLibRelaENS">源对象</param>
 /// <param name = "objcc_KnowledgesExamLibRelaENT">目标对象</param>
public void CopyTo(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENS, clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaENT)
{
objcc_KnowledgesExamLibRelaENT.mId = objcc_KnowledgesExamLibRelaENS.mId; //mId
objcc_KnowledgesExamLibRelaENT.QuestionId = objcc_KnowledgesExamLibRelaENS.QuestionId; //题目Id
objcc_KnowledgesExamLibRelaENT.CourseId = objcc_KnowledgesExamLibRelaENS.CourseId; //课程Id
objcc_KnowledgesExamLibRelaENT.PositiveCorrelation = objcc_KnowledgesExamLibRelaENS.PositiveCorrelation; //正相关度
objcc_KnowledgesExamLibRelaENT.CourseKnowledgeId = objcc_KnowledgesExamLibRelaENS.CourseKnowledgeId; //知识点Id
objcc_KnowledgesExamLibRelaENT.NegativeCorrelation = objcc_KnowledgesExamLibRelaENS.NegativeCorrelation; //负相关度
objcc_KnowledgesExamLibRelaENT.IsMain = objcc_KnowledgesExamLibRelaENS.IsMain; //是否主资源
objcc_KnowledgesExamLibRelaENT.UpdDate = objcc_KnowledgesExamLibRelaENS.UpdDate; //修改日期
objcc_KnowledgesExamLibRelaENT.UpdUserId = objcc_KnowledgesExamLibRelaENS.UpdUserId; //修改用户Id
objcc_KnowledgesExamLibRelaENT.Memo = objcc_KnowledgesExamLibRelaENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objcc_KnowledgesExamLibRelaEN.QuestionId, concc_KnowledgesExamLibRela.QuestionId);
clsCheckSql.CheckFieldNotNull(objcc_KnowledgesExamLibRelaEN.PositiveCorrelation, concc_KnowledgesExamLibRela.PositiveCorrelation);
clsCheckSql.CheckFieldNotNull(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldNotNull(objcc_KnowledgesExamLibRelaEN.NegativeCorrelation, concc_KnowledgesExamLibRela.NegativeCorrelation);
clsCheckSql.CheckFieldNotNull(objcc_KnowledgesExamLibRelaEN.UpdDate, concc_KnowledgesExamLibRela.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdDate, 20, concc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdUserId, 20, concc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.Memo, 1000, concc_KnowledgesExamLibRela.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
 objcc_KnowledgesExamLibRelaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdDate, 20, concc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdUserId, 20, concc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.Memo, 1000, concc_KnowledgesExamLibRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
 objcc_KnowledgesExamLibRelaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdDate, 20, concc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.UpdUserId, 20, concc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckFieldLen(objcc_KnowledgesExamLibRelaEN.Memo, 1000, concc_KnowledgesExamLibRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objcc_KnowledgesExamLibRelaEN.CourseId, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckSqlInjection4Field(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, concc_KnowledgesExamLibRela.CourseKnowledgeId);
clsCheckSql.CheckSqlInjection4Field(objcc_KnowledgesExamLibRelaEN.UpdDate, concc_KnowledgesExamLibRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objcc_KnowledgesExamLibRelaEN.UpdUserId, concc_KnowledgesExamLibRela.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objcc_KnowledgesExamLibRelaEN.Memo, concc_KnowledgesExamLibRela.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseId, 8, concc_KnowledgesExamLibRela.CourseId);
clsCheckSql.CheckFieldForeignKey(objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId, 8, concc_KnowledgesExamLibRela.CourseKnowledgeId);
 objcc_KnowledgesExamLibRelaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--cc_KnowledgesExamLibRela(知识点习题关系),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objcc_KnowledgesExamLibRelaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clscc_KnowledgesExamLibRelaEN objcc_KnowledgesExamLibRelaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionId = '{0}'", objcc_KnowledgesExamLibRelaEN.QuestionId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objcc_KnowledgesExamLibRelaEN.CourseKnowledgeId);
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_KnowledgesExamLibRelaEN._CurrTabName);
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clscc_KnowledgesExamLibRelaEN._CurrTabName, strCondition);
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
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
 objSQL = clscc_KnowledgesExamLibRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}