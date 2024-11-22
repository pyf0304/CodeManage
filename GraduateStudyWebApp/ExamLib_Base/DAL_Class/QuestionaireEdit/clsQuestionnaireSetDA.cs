
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQuestionnaireSetDA
 表名:QuestionnaireSet(01120007)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:02:06
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
 /// 问卷集(QuestionnaireSet)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsQuestionnaireSetDA : clsCommBase4DA
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
 return clsQuestionnaireSetEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsQuestionnaireSetEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsQuestionnaireSetEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsQuestionnaireSetEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsQuestionnaireSetEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strQuestionnaireSetId)
{
strQuestionnaireSetId = strQuestionnaireSetId.Replace("'", "''");
if (strQuestionnaireSetId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:QuestionnaireSet中,检查关键字,长度不正确!(clsQuestionnaireSetDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strQuestionnaireSetId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:QuestionnaireSet中,关键字不能为空 或 null!(clsQuestionnaireSetDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strQuestionnaireSetId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsQuestionnaireSetDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_QuestionnaireSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable_QuestionnaireSet)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireSet.* from QuestionnaireSet Left Join {1} on {2} where {3} and QuestionnaireSet.QuestionnaireSetId not in (Select top {5} QuestionnaireSet.QuestionnaireSetId from QuestionnaireSet Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1} and QuestionnaireSetId not in (Select top {2} QuestionnaireSetId from QuestionnaireSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1} and QuestionnaireSetId not in (Select top {3} QuestionnaireSetId from QuestionnaireSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} QuestionnaireSet.* from QuestionnaireSet Left Join {1} on {2} where {3} and QuestionnaireSet.QuestionnaireSetId not in (Select top {5} QuestionnaireSet.QuestionnaireSetId from QuestionnaireSet Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1} and QuestionnaireSetId not in (Select top {2} QuestionnaireSetId from QuestionnaireSet where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from QuestionnaireSet where {1} and QuestionnaireSetId not in (Select top {3} QuestionnaireSetId from QuestionnaireSet where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsQuestionnaireSetEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA:GetObjLst)", objException.Message));
}
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = TransNullToBool(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireSetDA: GetObjLst)", objException.Message));
}
objQuestionnaireSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireSetEN);
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
public List<clsQuestionnaireSetEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA:GetObjLstByTabName)", objException.Message));
}
List<clsQuestionnaireSetEN> arrObjLst = new List<clsQuestionnaireSetEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = TransNullToBool(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsQuestionnaireSetDA: GetObjLst)", objException.Message));
}
objQuestionnaireSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objQuestionnaireSetEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetQuestionnaireSet(ref clsQuestionnaireSetEN objQuestionnaireSetEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where QuestionnaireSetId = " + "'"+ objQuestionnaireSetEN.QuestionnaireSetId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objQuestionnaireSetEN.QuestionnaireSetId = objDT.Rows[0][conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.QuestionnaireSetName = objDT.Rows[0][conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireSetEN.OrderFieldInExport = objDT.Rows[0][conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireSetEN.ClassNo = TransNullToInt(objDT.Rows[0][conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.ClassNo2 = TransNullToInt(objDT.Rows[0][conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.IsShowQuestionNo = TransNullToBool(objDT.Rows[0][conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireSetEN.LogoFileName = objDT.Rows[0][conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireSetEN.UpdDate = objDT.Rows[0][conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireSetEN.UpdUser = objDT.Rows[0][conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireSetEN.Memo = objDT.Rows[0][conQuestionnaireSet.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsQuestionnaireSetDA: GetQuestionnaireSet)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">表关键字</param>
 /// <returns>表对象</returns>
public clsQuestionnaireSetEN GetObjByQuestionnaireSetId(string strQuestionnaireSetId)
{
CheckPrimaryKey(strQuestionnaireSetId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where QuestionnaireSetId = " + "'"+ strQuestionnaireSetId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
 objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段(字段类型:varchar,字段长度:200,是否可空:True)
 objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2(字段类型:int,字段长度:4,是否可空:True)
 objQuestionnaireSetEN.IsShowQuestionNo = clsEntityBase2.TransNullToBool_S(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号(字段类型:bit,字段长度:1,是否可空:True)
 objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名(字段类型:varchar,字段长度:50,是否可空:True)
 objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsQuestionnaireSetDA: GetObjByQuestionnaireSetId)", objException.Message));
}
return objQuestionnaireSetEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsQuestionnaireSetEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN()
{
QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(), //问卷集ID
QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(), //问卷集名
OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(), //导出排序字段
ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()), //分类号1
ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()), //分类号2
IsShowQuestionNo = TransNullToBool(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()), //是否显示问题编号
LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(), //Logo文件名
UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(), //修改人
Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim() //备注
};
objQuestionnaireSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireSetEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsQuestionnaireSetDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireSetEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = TransNullToBool(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsQuestionnaireSetDA: GetObjByDataRowQuestionnaireSet)", objException.Message));
}
objQuestionnaireSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireSetEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsQuestionnaireSetEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsQuestionnaireSetEN objQuestionnaireSetEN = new clsQuestionnaireSetEN();
try
{
objQuestionnaireSetEN.QuestionnaireSetId = objRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objQuestionnaireSetEN.QuestionnaireSetName = objRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objQuestionnaireSetEN.OrderFieldInExport = objRow[conQuestionnaireSet.OrderFieldInExport] == DBNull.Value ? null : objRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objQuestionnaireSetEN.ClassNo = objRow[conQuestionnaireSet.ClassNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo].ToString().Trim()); //分类号1
objQuestionnaireSetEN.ClassNo2 = objRow[conQuestionnaireSet.ClassNo2] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conQuestionnaireSet.ClassNo2].ToString().Trim()); //分类号2
objQuestionnaireSetEN.IsShowQuestionNo = TransNullToBool(objRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim()); //是否显示问题编号
objQuestionnaireSetEN.LogoFileName = objRow[conQuestionnaireSet.LogoFileName] == DBNull.Value ? null : objRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objQuestionnaireSetEN.UpdDate = objRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objQuestionnaireSetEN.UpdUser = objRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objQuestionnaireSetEN.Memo = objRow[conQuestionnaireSet.Memo] == DBNull.Value ? null : objRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsQuestionnaireSetDA: GetObjByDataRow)", objException.Message));
}
objQuestionnaireSetEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objQuestionnaireSetEN;
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
objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireSetEN._CurrTabName, conQuestionnaireSet.QuestionnaireSetId, 4, "");
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
objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsQuestionnaireSetEN._CurrTabName, conQuestionnaireSet.QuestionnaireSetId, 4, strPrefix);
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select QuestionnaireSetId from QuestionnaireSet where " + strCondition;
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select QuestionnaireSetId from QuestionnaireSet where " + strCondition;
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
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strQuestionnaireSetId)
{
CheckPrimaryKey(strQuestionnaireSetId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireSet", "QuestionnaireSetId = " + "'"+ strQuestionnaireSetId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("QuestionnaireSet", strCondition))
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
objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("QuestionnaireSet");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsQuestionnaireSetEN objQuestionnaireSetEN)
 {
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireSetEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireSet");
objRow = objDS.Tables["QuestionnaireSet"].NewRow();
objRow[conQuestionnaireSet.QuestionnaireSetId] = objQuestionnaireSetEN.QuestionnaireSetId; //问卷集ID
objRow[conQuestionnaireSet.QuestionnaireSetName] = objQuestionnaireSetEN.QuestionnaireSetName; //问卷集名
 if (objQuestionnaireSetEN.OrderFieldInExport !=  "")
 {
objRow[conQuestionnaireSet.OrderFieldInExport] = objQuestionnaireSetEN.OrderFieldInExport; //导出排序字段
 }
objRow[conQuestionnaireSet.ClassNo] = objQuestionnaireSetEN.ClassNo; //分类号1
objRow[conQuestionnaireSet.ClassNo2] = objQuestionnaireSetEN.ClassNo2; //分类号2
objRow[conQuestionnaireSet.IsShowQuestionNo] = objQuestionnaireSetEN.IsShowQuestionNo; //是否显示问题编号
 if (objQuestionnaireSetEN.LogoFileName !=  "")
 {
objRow[conQuestionnaireSet.LogoFileName] = objQuestionnaireSetEN.LogoFileName; //Logo文件名
 }
objRow[conQuestionnaireSet.UpdDate] = objQuestionnaireSetEN.UpdDate; //修改日期
objRow[conQuestionnaireSet.UpdUser] = objQuestionnaireSetEN.UpdUser; //修改人
 if (objQuestionnaireSetEN.Memo !=  "")
 {
objRow[conQuestionnaireSet.Memo] = objQuestionnaireSetEN.Memo; //备注
 }
objDS.Tables[clsQuestionnaireSetEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsQuestionnaireSetEN._CurrTabName);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireSetEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireSetEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetName);
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetName + "'");
 }
 
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.OrderFieldInExport);
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrderFieldInExport + "'");
 }
 
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo.ToString());
 }
 
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo2);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo2.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireSet.IsShowQuestionNo);
 arrValueListForInsert.Add("'" + (objQuestionnaireSetEN.IsShowQuestionNo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.LogoFileName);
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogoFileName + "'");
 }
 
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdDate);
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdUser);
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.Memo);
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireSetEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireSetEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetName);
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetName + "'");
 }
 
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.OrderFieldInExport);
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrderFieldInExport + "'");
 }
 
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo.ToString());
 }
 
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo2);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo2.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireSet.IsShowQuestionNo);
 arrValueListForInsert.Add("'" + (objQuestionnaireSetEN.IsShowQuestionNo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.LogoFileName);
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogoFileName + "'");
 }
 
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdDate);
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdUser);
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.Memo);
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objQuestionnaireSetEN.QuestionnaireSetId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsQuestionnaireSetEN objQuestionnaireSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireSetEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireSetEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireSetEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetName);
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetName + "'");
 }
 
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.OrderFieldInExport);
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrderFieldInExport + "'");
 }
 
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo.ToString());
 }
 
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo2);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo2.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireSet.IsShowQuestionNo);
 arrValueListForInsert.Add("'" + (objQuestionnaireSetEN.IsShowQuestionNo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.LogoFileName);
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogoFileName + "'");
 }
 
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdDate);
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdUser);
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.Memo);
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireSet");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objQuestionnaireSetEN.QuestionnaireSetId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsQuestionnaireSetEN objQuestionnaireSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objQuestionnaireSetEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objQuestionnaireSetEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetId);
 var strQuestionnaireSetId = objQuestionnaireSetEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.QuestionnaireSetName);
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetName + "'");
 }
 
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.OrderFieldInExport);
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOrderFieldInExport + "'");
 }
 
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo.ToString());
 }
 
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.ClassNo2);
 arrValueListForInsert.Add(objQuestionnaireSetEN.ClassNo2.ToString());
 }
 
 arrFieldListForInsert.Add(conQuestionnaireSet.IsShowQuestionNo);
 arrValueListForInsert.Add("'" + (objQuestionnaireSetEN.IsShowQuestionNo  ==  false ? "0" : "1") + "'");
 
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.LogoFileName);
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strLogoFileName + "'");
 }
 
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdDate);
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.UpdUser);
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conQuestionnaireSet.Memo);
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into QuestionnaireSet");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewQuestionnaireSets(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where QuestionnaireSetId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "QuestionnaireSet");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strQuestionnaireSetId = oRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim();
if (IsExist(strQuestionnaireSetId))
{
 string strResult = "关键字变量值为:" + string.Format("QuestionnaireSetId = {0}", strQuestionnaireSetId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsQuestionnaireSetEN._CurrTabName ].NewRow();
objRow[conQuestionnaireSet.QuestionnaireSetId] = oRow[conQuestionnaireSet.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objRow[conQuestionnaireSet.QuestionnaireSetName] = oRow[conQuestionnaireSet.QuestionnaireSetName].ToString().Trim(); //问卷集名
objRow[conQuestionnaireSet.OrderFieldInExport] = oRow[conQuestionnaireSet.OrderFieldInExport].ToString().Trim(); //导出排序字段
objRow[conQuestionnaireSet.ClassNo] = oRow[conQuestionnaireSet.ClassNo].ToString().Trim(); //分类号1
objRow[conQuestionnaireSet.ClassNo2] = oRow[conQuestionnaireSet.ClassNo2].ToString().Trim(); //分类号2
objRow[conQuestionnaireSet.IsShowQuestionNo] = oRow[conQuestionnaireSet.IsShowQuestionNo].ToString().Trim(); //是否显示问题编号
objRow[conQuestionnaireSet.LogoFileName] = oRow[conQuestionnaireSet.LogoFileName].ToString().Trim(); //Logo文件名
objRow[conQuestionnaireSet.UpdDate] = oRow[conQuestionnaireSet.UpdDate].ToString().Trim(); //修改日期
objRow[conQuestionnaireSet.UpdUser] = oRow[conQuestionnaireSet.UpdUser].ToString().Trim(); //修改人
objRow[conQuestionnaireSet.Memo] = oRow[conQuestionnaireSet.Memo].ToString().Trim(); //备注
 objDS.Tables[clsQuestionnaireSetEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsQuestionnaireSetEN._CurrTabName);
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
 /// <param name = "objQuestionnaireSetEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireSetEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
strSQL = "Select * from QuestionnaireSet where QuestionnaireSetId = " + "'"+ objQuestionnaireSetEN.QuestionnaireSetId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsQuestionnaireSetEN._CurrTabName);
if (objDS.Tables[clsQuestionnaireSetEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:QuestionnaireSetId = " + "'"+ objQuestionnaireSetEN.QuestionnaireSetId+"'");
return false;
}
objRow = objDS.Tables[clsQuestionnaireSetEN._CurrTabName].Rows[0];
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetId))
 {
objRow[conQuestionnaireSet.QuestionnaireSetId] = objQuestionnaireSetEN.QuestionnaireSetId; //问卷集ID
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetName))
 {
objRow[conQuestionnaireSet.QuestionnaireSetName] = objQuestionnaireSetEN.QuestionnaireSetName; //问卷集名
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.OrderFieldInExport))
 {
objRow[conQuestionnaireSet.OrderFieldInExport] = objQuestionnaireSetEN.OrderFieldInExport; //导出排序字段
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo))
 {
objRow[conQuestionnaireSet.ClassNo] = objQuestionnaireSetEN.ClassNo; //分类号1
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo2))
 {
objRow[conQuestionnaireSet.ClassNo2] = objQuestionnaireSetEN.ClassNo2; //分类号2
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.IsShowQuestionNo))
 {
objRow[conQuestionnaireSet.IsShowQuestionNo] = objQuestionnaireSetEN.IsShowQuestionNo; //是否显示问题编号
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.LogoFileName))
 {
objRow[conQuestionnaireSet.LogoFileName] = objQuestionnaireSetEN.LogoFileName; //Logo文件名
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdDate))
 {
objRow[conQuestionnaireSet.UpdDate] = objQuestionnaireSetEN.UpdDate; //修改日期
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdUser))
 {
objRow[conQuestionnaireSet.UpdUser] = objQuestionnaireSetEN.UpdUser; //修改人
 }
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.Memo))
 {
objRow[conQuestionnaireSet.Memo] = objQuestionnaireSetEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsQuestionnaireSetEN._CurrTabName);
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update QuestionnaireSet Set ");
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetName))
 {
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName); //问卷集名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.QuestionnaireSetName); //问卷集名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.OrderFieldInExport))
 {
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOrderFieldInExport, conQuestionnaireSet.OrderFieldInExport); //导出排序字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.OrderFieldInExport); //导出排序字段
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo))
 {
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo, conQuestionnaireSet.ClassNo); //分类号1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo); //分类号1
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo2))
 {
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo2, conQuestionnaireSet.ClassNo2); //分类号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo2); //分类号2
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.IsShowQuestionNo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireSetEN.IsShowQuestionNo == true?"1":"0", conQuestionnaireSet.IsShowQuestionNo); //是否显示问题编号
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.LogoFileName))
 {
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogoFileName, conQuestionnaireSet.LogoFileName); //Logo文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.LogoFileName); //Logo文件名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdDate))
 {
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdUser))
 {
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireSet.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.Memo))
 {
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireSet.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionnaireSetId = '{0}'", objQuestionnaireSetEN.QuestionnaireSetId); 
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsQuestionnaireSetEN objQuestionnaireSetEN, string strCondition)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireSet Set ");
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetName))
 {
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetName = '{0}',", strQuestionnaireSetName); //问卷集名
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetName = null,"); //问卷集名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.OrderFieldInExport))
 {
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OrderFieldInExport = '{0}',", strOrderFieldInExport); //导出排序字段
 }
 else
 {
 sbSQL.Append(" OrderFieldInExport = null,"); //导出排序字段
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo))
 {
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo, conQuestionnaireSet.ClassNo); //分类号1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo); //分类号1
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo2))
 {
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo2, conQuestionnaireSet.ClassNo2); //分类号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo2); //分类号2
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.IsShowQuestionNo))
 {
 sbSQL.AppendFormat(" IsShowQuestionNo = '{0}',", objQuestionnaireSetEN.IsShowQuestionNo == true?"1":"0"); //是否显示问题编号
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.LogoFileName))
 {
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogoFileName = '{0}',", strLogoFileName); //Logo文件名
 }
 else
 {
 sbSQL.Append(" LogoFileName = null,"); //Logo文件名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdDate))
 {
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdUser))
 {
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.Memo))
 {
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireSetEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsQuestionnaireSetEN objQuestionnaireSetEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireSet Set ");
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetName))
 {
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetName = '{0}',", strQuestionnaireSetName); //问卷集名
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetName = null,"); //问卷集名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.OrderFieldInExport))
 {
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OrderFieldInExport = '{0}',", strOrderFieldInExport); //导出排序字段
 }
 else
 {
 sbSQL.Append(" OrderFieldInExport = null,"); //导出排序字段
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo))
 {
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo, conQuestionnaireSet.ClassNo); //分类号1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo); //分类号1
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo2))
 {
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo2, conQuestionnaireSet.ClassNo2); //分类号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo2); //分类号2
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.IsShowQuestionNo))
 {
 sbSQL.AppendFormat(" IsShowQuestionNo = '{0}',", objQuestionnaireSetEN.IsShowQuestionNo == true?"1":"0"); //是否显示问题编号
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.LogoFileName))
 {
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" LogoFileName = '{0}',", strLogoFileName); //Logo文件名
 }
 else
 {
 sbSQL.Append(" LogoFileName = null,"); //Logo文件名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdDate))
 {
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdUser))
 {
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.Memo))
 {
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objQuestionnaireSetEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsQuestionnaireSetEN objQuestionnaireSetEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objQuestionnaireSetEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objQuestionnaireSetEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objQuestionnaireSetEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update QuestionnaireSet Set ");
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.QuestionnaireSetName))
 {
 if (objQuestionnaireSetEN.QuestionnaireSetName !=  null)
 {
 var strQuestionnaireSetName = objQuestionnaireSetEN.QuestionnaireSetName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName); //问卷集名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.QuestionnaireSetName); //问卷集名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.OrderFieldInExport))
 {
 if (objQuestionnaireSetEN.OrderFieldInExport !=  null)
 {
 var strOrderFieldInExport = objQuestionnaireSetEN.OrderFieldInExport.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOrderFieldInExport, conQuestionnaireSet.OrderFieldInExport); //导出排序字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.OrderFieldInExport); //导出排序字段
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo))
 {
 if (objQuestionnaireSetEN.ClassNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo, conQuestionnaireSet.ClassNo); //分类号1
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo); //分类号1
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.ClassNo2))
 {
 if (objQuestionnaireSetEN.ClassNo2 !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objQuestionnaireSetEN.ClassNo2, conQuestionnaireSet.ClassNo2); //分类号2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.ClassNo2); //分类号2
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.IsShowQuestionNo))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objQuestionnaireSetEN.IsShowQuestionNo == true?"1":"0", conQuestionnaireSet.IsShowQuestionNo); //是否显示问题编号
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.LogoFileName))
 {
 if (objQuestionnaireSetEN.LogoFileName !=  null)
 {
 var strLogoFileName = objQuestionnaireSetEN.LogoFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strLogoFileName, conQuestionnaireSet.LogoFileName); //Logo文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.LogoFileName); //Logo文件名
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdDate))
 {
 if (objQuestionnaireSetEN.UpdDate !=  null)
 {
 var strUpdDate = objQuestionnaireSetEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conQuestionnaireSet.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.UpdDate); //修改日期
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.UpdUser))
 {
 if (objQuestionnaireSetEN.UpdUser !=  null)
 {
 var strUpdUser = objQuestionnaireSetEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conQuestionnaireSet.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.UpdUser); //修改人
 }
 }
 
 if (objQuestionnaireSetEN.IsUpdated(conQuestionnaireSet.Memo))
 {
 if (objQuestionnaireSetEN.Memo !=  null)
 {
 var strMemo = objQuestionnaireSetEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conQuestionnaireSet.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conQuestionnaireSet.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where QuestionnaireSetId = '{0}'", objQuestionnaireSetEN.QuestionnaireSetId); 
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
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strQuestionnaireSetId) 
{
CheckPrimaryKey(strQuestionnaireSetId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strQuestionnaireSetId,
};
 objSQL.ExecSP("QuestionnaireSet_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strQuestionnaireSetId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strQuestionnaireSetId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
//删除QuestionnaireSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireSet where QuestionnaireSetId = " + "'"+ strQuestionnaireSetId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelQuestionnaireSet(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
//删除QuestionnaireSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireSet where QuestionnaireSetId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strQuestionnaireSetId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strQuestionnaireSetId) 
{
CheckPrimaryKey(strQuestionnaireSetId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
//删除QuestionnaireSet本表中与当前对象有关的记录
strSQL = strSQL + "Delete from QuestionnaireSet where QuestionnaireSetId = " + "'"+ strQuestionnaireSetId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelQuestionnaireSet(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: DelQuestionnaireSet)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireSet where " + strCondition ;
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
public bool DelQuestionnaireSetWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsQuestionnaireSetDA: DelQuestionnaireSetWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from QuestionnaireSet where " + strCondition ;
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
 /// <param name = "objQuestionnaireSetENS">源对象</param>
 /// <param name = "objQuestionnaireSetENT">目标对象</param>
public void CopyTo(clsQuestionnaireSetEN objQuestionnaireSetENS, clsQuestionnaireSetEN objQuestionnaireSetENT)
{
objQuestionnaireSetENT.QuestionnaireSetId = objQuestionnaireSetENS.QuestionnaireSetId; //问卷集ID
objQuestionnaireSetENT.QuestionnaireSetName = objQuestionnaireSetENS.QuestionnaireSetName; //问卷集名
objQuestionnaireSetENT.OrderFieldInExport = objQuestionnaireSetENS.OrderFieldInExport; //导出排序字段
objQuestionnaireSetENT.ClassNo = objQuestionnaireSetENS.ClassNo; //分类号1
objQuestionnaireSetENT.ClassNo2 = objQuestionnaireSetENS.ClassNo2; //分类号2
objQuestionnaireSetENT.IsShowQuestionNo = objQuestionnaireSetENS.IsShowQuestionNo; //是否显示问题编号
objQuestionnaireSetENT.LogoFileName = objQuestionnaireSetENS.LogoFileName; //Logo文件名
objQuestionnaireSetENT.UpdDate = objQuestionnaireSetENS.UpdDate; //修改日期
objQuestionnaireSetENT.UpdUser = objQuestionnaireSetENS.UpdUser; //修改人
objQuestionnaireSetENT.Memo = objQuestionnaireSetENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objQuestionnaireSetEN.QuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckFieldNotNull(objQuestionnaireSetEN.IsShowQuestionNo, conQuestionnaireSet.IsShowQuestionNo);
clsCheckSql.CheckFieldNotNull(objQuestionnaireSetEN.UpdDate, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckFieldNotNull(objQuestionnaireSetEN.UpdUser, conQuestionnaireSet.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.QuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.QuestionnaireSetName, 50, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.OrderFieldInExport, 200, conQuestionnaireSet.OrderFieldInExport);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.LogoFileName, 50, conQuestionnaireSet.LogoFileName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdDate, 20, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdUser, 20, conQuestionnaireSet.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.Memo, 1000, conQuestionnaireSet.Memo);
//检查字段外键固定长度
 objQuestionnaireSetEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.QuestionnaireSetName, 50, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.OrderFieldInExport, 200, conQuestionnaireSet.OrderFieldInExport);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.LogoFileName, 50, conQuestionnaireSet.LogoFileName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdDate, 20, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdUser, 20, conQuestionnaireSet.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.Memo, 1000, conQuestionnaireSet.Memo);
//检查外键字段长度
 objQuestionnaireSetEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.QuestionnaireSetId, 4, conQuestionnaireSet.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.QuestionnaireSetName, 50, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.OrderFieldInExport, 200, conQuestionnaireSet.OrderFieldInExport);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.LogoFileName, 50, conQuestionnaireSet.LogoFileName);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdDate, 20, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.UpdUser, 20, conQuestionnaireSet.UpdUser);
clsCheckSql.CheckFieldLen(objQuestionnaireSetEN.Memo, 1000, conQuestionnaireSet.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.QuestionnaireSetId, conQuestionnaireSet.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.QuestionnaireSetName, conQuestionnaireSet.QuestionnaireSetName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.OrderFieldInExport, conQuestionnaireSet.OrderFieldInExport);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.LogoFileName, conQuestionnaireSet.LogoFileName);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.UpdDate, conQuestionnaireSet.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.UpdUser, conQuestionnaireSet.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objQuestionnaireSetEN.Memo, conQuestionnaireSet.Memo);
//检查外键字段长度
 objQuestionnaireSetEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetQuestionnaireSetId()
{
//获取某学院所有专业信息
string strSQL = "select QuestionnaireSetId, QuestionnaireSetName from QuestionnaireSet ";
 clsSpecSQLforSql mySql = clsQuestionnaireSetDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--QuestionnaireSet(问卷集),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objQuestionnaireSetEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsQuestionnaireSetEN objQuestionnaireSetEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and QuestionnaireSetName = '{0}'", objQuestionnaireSetEN.QuestionnaireSetName);
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireSetEN._CurrTabName);
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsQuestionnaireSetEN._CurrTabName, strCondition);
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
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
 objSQL = clsQuestionnaireSetDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}