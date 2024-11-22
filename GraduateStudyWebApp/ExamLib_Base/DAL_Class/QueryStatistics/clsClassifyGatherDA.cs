
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsClassifyGatherDA
 表名:ClassifyGather(01120011)
 * 版本:2024.11.13.1(服务器:WIN-SRV103-116)
 日期:2024/11/13 06:18:20
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
 /// 分类统计(ClassifyGather)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsClassifyGatherDA : clsCommBase4DA
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
 return clsClassifyGatherEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsClassifyGatherEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsClassifyGatherEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsClassifyGatherEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsClassifyGatherEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strClassifyGatherId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strClassifyGatherId)
{
strClassifyGatherId = strClassifyGatherId.Replace("'", "''");
if (strClassifyGatherId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:ClassifyGather中,检查关键字,长度不正确!(clsClassifyGatherDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strClassifyGatherId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ClassifyGather中,关键字不能为空 或 null!(clsClassifyGatherDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strClassifyGatherId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsClassifyGatherDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ClassifyGather(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable_ClassifyGather)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClassifyGather.* from ClassifyGather Left Join {1} on {2} where {3} and ClassifyGather.ClassifyGatherId not in (Select top {5} ClassifyGather.ClassifyGatherId from ClassifyGather Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1} and ClassifyGatherId not in (Select top {2} ClassifyGatherId from ClassifyGather where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1} and ClassifyGatherId not in (Select top {3} ClassifyGatherId from ClassifyGather where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsClassifyGatherDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
strSQL = string.Format("Select Top {0} ClassifyGather.* from ClassifyGather Left Join {1} on {2} where {3} and ClassifyGather.ClassifyGatherId not in (Select top {5} ClassifyGather.ClassifyGatherId from ClassifyGather Left Join {1} on {2} where {3} order by {4} {6}) order by {4} {6} ",
intPageSize, strTabName, strOnCondition, strCondition, strNewOrderBy, intTop_In, IsAscOrDesc);
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1} and ClassifyGatherId not in (Select top {2} ClassifyGatherId from ClassifyGather where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ClassifyGather where {1} and ClassifyGatherId not in (Select top {3} ClassifyGatherId from ClassifyGather where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsClassifyGatherEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsClassifyGatherDA:GetObjLst)", objException.Message));
}
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = TransNullToBool(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClassifyGatherDA: GetObjLst)", objException.Message));
}
objClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClassifyGatherEN);
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
public List<clsClassifyGatherEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsClassifyGatherDA:GetObjLstByTabName)", objException.Message));
}
List<clsClassifyGatherEN> arrObjLst = new List<clsClassifyGatherEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = TransNullToBool(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsClassifyGatherDA: GetObjLst)", objException.Message));
}
objClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objClassifyGatherEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetClassifyGather(ref clsClassifyGatherEN objClassifyGatherEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where ClassifyGatherId = " + "'"+ objClassifyGatherEN.ClassifyGatherId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objClassifyGatherEN.ClassifyGatherId = objDT.Rows[0][conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objClassifyGatherEN.ClassifyGatherName = objDT.Rows[0][conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objClassifyGatherEN.ClassifyGatherPeriod = objDT.Rows[0][conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
 objClassifyGatherEN.QuestionnaireSetId = objDT.Rows[0][conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objClassifyGatherEN.IsDefault = TransNullToBool(objDT.Rows[0][conClassifyGather.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objClassifyGatherEN.UpdUser = objDT.Rows[0][conClassifyGather.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objClassifyGatherEN.UpdDate = objDT.Rows[0][conClassifyGather.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClassifyGatherEN.Memo = objDT.Rows[0][conClassifyGather.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsClassifyGatherDA: GetClassifyGather)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strClassifyGatherId">表关键字</param>
 /// <returns>表对象</returns>
public clsClassifyGatherEN GetObjByClassifyGatherId(string strClassifyGatherId)
{
CheckPrimaryKey(strClassifyGatherId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where ClassifyGatherId = " + "'"+ strClassifyGatherId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
 objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id(字段类型:char,字段长度:4,是否可空:False)
 objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称(字段类型:varchar,字段长度:30,是否可空:False)
 objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期(字段类型:varchar,字段长度:50,是否可空:True)
 objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID(字段类型:char,字段长度:4,是否可空:True)
 objClassifyGatherEN.IsDefault = clsEntityBase2.TransNullToBool_S(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认(字段类型:bit,字段长度:1,是否可空:True)
 objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人(字段类型:varchar,字段长度:20,是否可空:True)
 objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsClassifyGatherDA: GetObjByClassifyGatherId)", objException.Message));
}
return objClassifyGatherEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsClassifyGatherEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsClassifyGatherDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN()
{
ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(), //分类统计Id
ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(), //分类统计名称
ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(), //分类统计时期
QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(), //问卷集ID
IsDefault = TransNullToBool(objRow[conClassifyGather.IsDefault].ToString().Trim()), //是否默认
UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(), //修改人
UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim() //备注
};
objClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClassifyGatherEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsClassifyGatherDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsClassifyGatherEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = TransNullToBool(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsClassifyGatherDA: GetObjByDataRowClassifyGather)", objException.Message));
}
objClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClassifyGatherEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsClassifyGatherEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsClassifyGatherEN objClassifyGatherEN = new clsClassifyGatherEN();
try
{
objClassifyGatherEN.ClassifyGatherId = objRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objClassifyGatherEN.ClassifyGatherName = objRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objClassifyGatherEN.ClassifyGatherPeriod = objRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objClassifyGatherEN.QuestionnaireSetId = objRow[conClassifyGather.QuestionnaireSetId] == DBNull.Value ? null : objRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objClassifyGatherEN.IsDefault = TransNullToBool(objRow[conClassifyGather.IsDefault].ToString().Trim()); //是否默认
objClassifyGatherEN.UpdUser = objRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objClassifyGatherEN.UpdDate = objRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objClassifyGatherEN.Memo = objRow[conClassifyGather.Memo] == DBNull.Value ? null : objRow[conClassifyGather.Memo].ToString().Trim(); //备注
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsClassifyGatherDA: GetObjByDataRow)", objException.Message));
}
objClassifyGatherEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objClassifyGatherEN;
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
objSQL = clsClassifyGatherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClassifyGatherEN._CurrTabName, conClassifyGather.ClassifyGatherId, 4, "");
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
objSQL = clsClassifyGatherDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsClassifyGatherEN._CurrTabName, conClassifyGather.ClassifyGatherId, 4, strPrefix);
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ClassifyGatherId from ClassifyGather where " + strCondition;
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ClassifyGatherId from ClassifyGather where " + strCondition;
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
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strClassifyGatherId)
{
CheckPrimaryKey(strClassifyGatherId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClassifyGather", "ClassifyGatherId = " + "'"+ strClassifyGatherId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsClassifyGatherDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ClassifyGather", strCondition))
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
objSQL = clsClassifyGatherDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ClassifyGather");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsClassifyGatherEN objClassifyGatherEN)
 {
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClassifyGatherEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClassifyGather");
objRow = objDS.Tables["ClassifyGather"].NewRow();
objRow[conClassifyGather.ClassifyGatherId] = objClassifyGatherEN.ClassifyGatherId; //分类统计Id
objRow[conClassifyGather.ClassifyGatherName] = objClassifyGatherEN.ClassifyGatherName; //分类统计名称
objRow[conClassifyGather.ClassifyGatherPeriod] = objClassifyGatherEN.ClassifyGatherPeriod; //分类统计时期
 if (objClassifyGatherEN.QuestionnaireSetId !=  "")
 {
objRow[conClassifyGather.QuestionnaireSetId] = objClassifyGatherEN.QuestionnaireSetId; //问卷集ID
 }
objRow[conClassifyGather.IsDefault] = objClassifyGatherEN.IsDefault; //是否默认
objRow[conClassifyGather.UpdUser] = objClassifyGatherEN.UpdUser; //修改人
objRow[conClassifyGather.UpdDate] = objClassifyGatherEN.UpdDate; //修改日期
 if (objClassifyGatherEN.Memo !=  "")
 {
objRow[conClassifyGather.Memo] = objClassifyGatherEN.Memo; //备注
 }
objDS.Tables[clsClassifyGatherEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsClassifyGatherEN._CurrTabName);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClassifyGatherEN objClassifyGatherEN)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClassifyGatherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClassifyGatherEN.ClassifyGatherId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherId);
 var strClassifyGatherId = objClassifyGatherEN.ClassifyGatherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherId + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherName);
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherName + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherPeriod);
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherPeriod + "'");
 }
 
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.QuestionnaireSetId);
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conClassifyGather.IsDefault);
 arrValueListForInsert.Add("'" + (objClassifyGatherEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdUser);
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdDate);
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClassifyGatherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.Memo);
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClassifyGather");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClassifyGatherEN objClassifyGatherEN)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClassifyGatherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClassifyGatherEN.ClassifyGatherId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherId);
 var strClassifyGatherId = objClassifyGatherEN.ClassifyGatherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherId + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherName);
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherName + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherPeriod);
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherPeriod + "'");
 }
 
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.QuestionnaireSetId);
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conClassifyGather.IsDefault);
 arrValueListForInsert.Add("'" + (objClassifyGatherEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdUser);
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdDate);
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClassifyGatherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.Memo);
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClassifyGather");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objClassifyGatherEN.ClassifyGatherId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsClassifyGatherEN objClassifyGatherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClassifyGatherEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClassifyGatherEN.ClassifyGatherId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherId);
 var strClassifyGatherId = objClassifyGatherEN.ClassifyGatherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherId + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherName);
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherName + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherPeriod);
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherPeriod + "'");
 }
 
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.QuestionnaireSetId);
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conClassifyGather.IsDefault);
 arrValueListForInsert.Add("'" + (objClassifyGatherEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdUser);
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdDate);
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClassifyGatherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.Memo);
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClassifyGather");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objClassifyGatherEN.ClassifyGatherId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsClassifyGatherEN objClassifyGatherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objClassifyGatherEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objClassifyGatherEN.ClassifyGatherId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherId);
 var strClassifyGatherId = objClassifyGatherEN.ClassifyGatherId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherId + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherName);
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherName + "'");
 }
 
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.ClassifyGatherPeriod);
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClassifyGatherPeriod + "'");
 }
 
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.QuestionnaireSetId);
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strQuestionnaireSetId + "'");
 }
 
 arrFieldListForInsert.Add(conClassifyGather.IsDefault);
 arrValueListForInsert.Add("'" + (objClassifyGatherEN.IsDefault  ==  false ? "0" : "1") + "'");
 
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdUser);
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.UpdDate);
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objClassifyGatherEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conClassifyGather.Memo);
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ClassifyGather");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewClassifyGathers(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where ClassifyGatherId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ClassifyGather");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strClassifyGatherId = oRow[conClassifyGather.ClassifyGatherId].ToString().Trim();
if (IsExist(strClassifyGatherId))
{
 string strResult = "关键字变量值为:" + string.Format("ClassifyGatherId = {0}", strClassifyGatherId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsClassifyGatherEN._CurrTabName ].NewRow();
objRow[conClassifyGather.ClassifyGatherId] = oRow[conClassifyGather.ClassifyGatherId].ToString().Trim(); //分类统计Id
objRow[conClassifyGather.ClassifyGatherName] = oRow[conClassifyGather.ClassifyGatherName].ToString().Trim(); //分类统计名称
objRow[conClassifyGather.ClassifyGatherPeriod] = oRow[conClassifyGather.ClassifyGatherPeriod].ToString().Trim(); //分类统计时期
objRow[conClassifyGather.QuestionnaireSetId] = oRow[conClassifyGather.QuestionnaireSetId].ToString().Trim(); //问卷集ID
objRow[conClassifyGather.IsDefault] = oRow[conClassifyGather.IsDefault].ToString().Trim(); //是否默认
objRow[conClassifyGather.UpdUser] = oRow[conClassifyGather.UpdUser].ToString().Trim(); //修改人
objRow[conClassifyGather.UpdDate] = oRow[conClassifyGather.UpdDate].ToString().Trim(); //修改日期
objRow[conClassifyGather.Memo] = oRow[conClassifyGather.Memo].ToString().Trim(); //备注
 objDS.Tables[clsClassifyGatherEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsClassifyGatherEN._CurrTabName);
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
 /// <param name = "objClassifyGatherEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsClassifyGatherEN objClassifyGatherEN)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClassifyGatherEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
strSQL = "Select * from ClassifyGather where ClassifyGatherId = " + "'"+ objClassifyGatherEN.ClassifyGatherId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsClassifyGatherEN._CurrTabName);
if (objDS.Tables[clsClassifyGatherEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ClassifyGatherId = " + "'"+ objClassifyGatherEN.ClassifyGatherId+"'");
return false;
}
objRow = objDS.Tables[clsClassifyGatherEN._CurrTabName].Rows[0];
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherId))
 {
objRow[conClassifyGather.ClassifyGatherId] = objClassifyGatherEN.ClassifyGatherId; //分类统计Id
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherName))
 {
objRow[conClassifyGather.ClassifyGatherName] = objClassifyGatherEN.ClassifyGatherName; //分类统计名称
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherPeriod))
 {
objRow[conClassifyGather.ClassifyGatherPeriod] = objClassifyGatherEN.ClassifyGatherPeriod; //分类统计时期
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.QuestionnaireSetId))
 {
objRow[conClassifyGather.QuestionnaireSetId] = objClassifyGatherEN.QuestionnaireSetId; //问卷集ID
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.IsDefault))
 {
objRow[conClassifyGather.IsDefault] = objClassifyGatherEN.IsDefault; //是否默认
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdUser))
 {
objRow[conClassifyGather.UpdUser] = objClassifyGatherEN.UpdUser; //修改人
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdDate))
 {
objRow[conClassifyGather.UpdDate] = objClassifyGatherEN.UpdDate; //修改日期
 }
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.Memo))
 {
objRow[conClassifyGather.Memo] = objClassifyGatherEN.Memo; //备注
 }
try
{
objDA.Update(objDS, clsClassifyGatherEN._CurrTabName);
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClassifyGatherEN objClassifyGatherEN)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClassifyGatherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ClassifyGather Set ");
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherName))
 {
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassifyGatherName, conClassifyGather.ClassifyGatherName); //分类统计名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.ClassifyGatherName); //分类统计名称
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherPeriod))
 {
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassifyGatherPeriod, conClassifyGather.ClassifyGatherPeriod); //分类统计时期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.ClassifyGatherPeriod); //分类统计时期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.QuestionnaireSetId))
 {
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conClassifyGather.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClassifyGatherEN.IsDefault == true?"1":"0", conClassifyGather.IsDefault); //是否默认
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdUser))
 {
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conClassifyGather.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.UpdUser); //修改人
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdDate))
 {
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClassifyGather.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.UpdDate); //修改日期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.Memo))
 {
 if (objClassifyGatherEN.Memo !=  null)
 {
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClassifyGather.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ClassifyGatherId = '{0}'", objClassifyGatherEN.ClassifyGatherId); 
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
 /// <param name = "objClassifyGatherEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsClassifyGatherEN objClassifyGatherEN, string strCondition)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClassifyGatherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClassifyGather Set ");
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherName))
 {
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassifyGatherName = '{0}',", strClassifyGatherName); //分类统计名称
 }
 else
 {
 sbSQL.Append(" ClassifyGatherName = null,"); //分类统计名称
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherPeriod))
 {
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassifyGatherPeriod = '{0}',", strClassifyGatherPeriod); //分类统计时期
 }
 else
 {
 sbSQL.Append(" ClassifyGatherPeriod = null,"); //分类统计时期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.QuestionnaireSetId))
 {
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objClassifyGatherEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdUser))
 {
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdDate))
 {
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.Memo))
 {
 if (objClassifyGatherEN.Memo !=  null)
 {
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClassifyGatherEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsClassifyGatherEN objClassifyGatherEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClassifyGatherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClassifyGather Set ");
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherName))
 {
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassifyGatherName = '{0}',", strClassifyGatherName); //分类统计名称
 }
 else
 {
 sbSQL.Append(" ClassifyGatherName = null,"); //分类统计名称
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherPeriod))
 {
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClassifyGatherPeriod = '{0}',", strClassifyGatherPeriod); //分类统计时期
 }
 else
 {
 sbSQL.Append(" ClassifyGatherPeriod = null,"); //分类统计时期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.QuestionnaireSetId))
 {
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" QuestionnaireSetId = '{0}',", strQuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.Append(" QuestionnaireSetId = null,"); //问卷集ID
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.IsDefault))
 {
 sbSQL.AppendFormat(" IsDefault = '{0}',", objClassifyGatherEN.IsDefault == true?"1":"0"); //是否默认
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdUser))
 {
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改人
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改人
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdDate))
 {
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.Memo))
 {
 if (objClassifyGatherEN.Memo !=  null)
 {
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objClassifyGatherEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsClassifyGatherEN objClassifyGatherEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objClassifyGatherEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objClassifyGatherEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objClassifyGatherEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ClassifyGather Set ");
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherName))
 {
 if (objClassifyGatherEN.ClassifyGatherName !=  null)
 {
 var strClassifyGatherName = objClassifyGatherEN.ClassifyGatherName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassifyGatherName, conClassifyGather.ClassifyGatherName); //分类统计名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.ClassifyGatherName); //分类统计名称
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.ClassifyGatherPeriod))
 {
 if (objClassifyGatherEN.ClassifyGatherPeriod !=  null)
 {
 var strClassifyGatherPeriod = objClassifyGatherEN.ClassifyGatherPeriod.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClassifyGatherPeriod, conClassifyGather.ClassifyGatherPeriod); //分类统计时期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.ClassifyGatherPeriod); //分类统计时期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.QuestionnaireSetId))
 {
 if (objClassifyGatherEN.QuestionnaireSetId !=  null)
 {
 var strQuestionnaireSetId = objClassifyGatherEN.QuestionnaireSetId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strQuestionnaireSetId, conClassifyGather.QuestionnaireSetId); //问卷集ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.QuestionnaireSetId); //问卷集ID
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.IsDefault))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objClassifyGatherEN.IsDefault == true?"1":"0", conClassifyGather.IsDefault); //是否默认
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdUser))
 {
 if (objClassifyGatherEN.UpdUser !=  null)
 {
 var strUpdUser = objClassifyGatherEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conClassifyGather.UpdUser); //修改人
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.UpdUser); //修改人
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.UpdDate))
 {
 if (objClassifyGatherEN.UpdDate !=  null)
 {
 var strUpdDate = objClassifyGatherEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conClassifyGather.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.UpdDate); //修改日期
 }
 }
 
 if (objClassifyGatherEN.IsUpdated(conClassifyGather.Memo))
 {
 if (objClassifyGatherEN.Memo !=  null)
 {
 var strMemo = objClassifyGatherEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conClassifyGather.Memo); //备注
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conClassifyGather.Memo); //备注
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ClassifyGatherId = '{0}'", objClassifyGatherEN.ClassifyGatherId); 
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
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strClassifyGatherId) 
{
CheckPrimaryKey(strClassifyGatherId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strClassifyGatherId,
};
 objSQL.ExecSP("ClassifyGather_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strClassifyGatherId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strClassifyGatherId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
//删除ClassifyGather本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClassifyGather where ClassifyGatherId = " + "'"+ strClassifyGatherId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelClassifyGather(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
//删除ClassifyGather本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClassifyGather where ClassifyGatherId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strClassifyGatherId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strClassifyGatherId) 
{
CheckPrimaryKey(strClassifyGatherId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
//删除ClassifyGather本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ClassifyGather where ClassifyGatherId = " + "'"+ strClassifyGatherId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelClassifyGather(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsClassifyGatherDA: DelClassifyGather)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClassifyGather where " + strCondition ;
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
public bool DelClassifyGatherWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsClassifyGatherDA: DelClassifyGatherWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ClassifyGather where " + strCondition ;
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
 /// <param name = "objClassifyGatherENS">源对象</param>
 /// <param name = "objClassifyGatherENT">目标对象</param>
public void CopyTo(clsClassifyGatherEN objClassifyGatherENS, clsClassifyGatherEN objClassifyGatherENT)
{
objClassifyGatherENT.ClassifyGatherId = objClassifyGatherENS.ClassifyGatherId; //分类统计Id
objClassifyGatherENT.ClassifyGatherName = objClassifyGatherENS.ClassifyGatherName; //分类统计名称
objClassifyGatherENT.ClassifyGatherPeriod = objClassifyGatherENS.ClassifyGatherPeriod; //分类统计时期
objClassifyGatherENT.QuestionnaireSetId = objClassifyGatherENS.QuestionnaireSetId; //问卷集ID
objClassifyGatherENT.IsDefault = objClassifyGatherENS.IsDefault; //是否默认
objClassifyGatherENT.UpdUser = objClassifyGatherENS.UpdUser; //修改人
objClassifyGatherENT.UpdDate = objClassifyGatherENS.UpdDate; //修改日期
objClassifyGatherENT.Memo = objClassifyGatherENS.Memo; //备注
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsClassifyGatherEN objClassifyGatherEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objClassifyGatherEN.ClassifyGatherName, conClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldNotNull(objClassifyGatherEN.ClassifyGatherPeriod, conClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckFieldNotNull(objClassifyGatherEN.UpdUser, conClassifyGather.UpdUser);
clsCheckSql.CheckFieldNotNull(objClassifyGatherEN.UpdDate, conClassifyGather.UpdDate);
//检查字段长度
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherId, 4, conClassifyGather.ClassifyGatherId);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherName, 30, conClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherPeriod, 50, conClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.QuestionnaireSetId, 4, conClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdUser, 20, conClassifyGather.UpdUser);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdDate, 20, conClassifyGather.UpdDate);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.Memo, 1000, conClassifyGather.Memo);
//检查字段外键固定长度
 objClassifyGatherEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsClassifyGatherEN objClassifyGatherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherName, 30, conClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherPeriod, 50, conClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.QuestionnaireSetId, 4, conClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdUser, 20, conClassifyGather.UpdUser);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdDate, 20, conClassifyGather.UpdDate);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.Memo, 1000, conClassifyGather.Memo);
//检查外键字段长度
 objClassifyGatherEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsClassifyGatherEN objClassifyGatherEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherId, 4, conClassifyGather.ClassifyGatherId);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherName, 30, conClassifyGather.ClassifyGatherName);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.ClassifyGatherPeriod, 50, conClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.QuestionnaireSetId, 4, conClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdUser, 20, conClassifyGather.UpdUser);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.UpdDate, 20, conClassifyGather.UpdDate);
clsCheckSql.CheckFieldLen(objClassifyGatherEN.Memo, 1000, conClassifyGather.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.ClassifyGatherId, conClassifyGather.ClassifyGatherId);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.ClassifyGatherName, conClassifyGather.ClassifyGatherName);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.ClassifyGatherPeriod, conClassifyGather.ClassifyGatherPeriod);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.QuestionnaireSetId, conClassifyGather.QuestionnaireSetId);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.UpdUser, conClassifyGather.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.UpdDate, conClassifyGather.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objClassifyGatherEN.Memo, conClassifyGather.Memo);
//检查外键字段长度
 objClassifyGatherEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetClassifyGatherId()
{
//获取某学院所有专业信息
string strSQL = "select ClassifyGatherId, ClassifyGatherName from ClassifyGather ";
 clsSpecSQLforSql mySql = clsClassifyGatherDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClassifyGatherEN._CurrTabName);
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsClassifyGatherEN._CurrTabName, strCondition);
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
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
 objSQL = clsClassifyGatherDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}